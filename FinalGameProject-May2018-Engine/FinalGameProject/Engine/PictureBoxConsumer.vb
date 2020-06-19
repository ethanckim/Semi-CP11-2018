Imports FinalGameProject

Public Class PictureBoxConsumer
    Inherits PictureBox

    Private debugEnabled As Boolean = False
    Dim manager As FrameManager

    ' frame rate stuff
    Const NUM_FRAMES = 40
    Dim tickIndex As Integer = 0
    Dim tickSum As ULong = 0
    Dim tickList(NUM_FRAMES - 1) As Double


    Private mouseButtonsDown As Integer = 0

    Sub New()
        MyBase.New()
        InitializeComponent()

        manager = New FrameManager(10, 10)

        Dim i As Integer = 0
        While i < tickList.Length
            tickList(i) = 0
            i += 1
        End While
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Try
            MyBase.OnPaint(e)
            Dim current As Image = manager.GetCurrent()
            Dim debugInfo As String = manager.GetDebugInfo()

            If Not current Is Nothing Then
                e.Graphics.DrawImage(current, 0, 0)
            End If

            Dim fps As Double
            Dim currentTime As Double = ((DateTime.Now - New DateTime(1970, 1, 1)).TotalMilliseconds) / 1000
            fps = CalcFps(currentTime)
            If debugEnabled Then
                Dim frameRate As String
                If fps < 0.01 Then
                    frameRate = "???"
                Else
                    frameRate = FormatNumber(fps, 1)
                End If
                e.Graphics.DrawString("FPS: " + frameRate, SystemFonts.DefaultFont, Brushes.Black, 2, 514)
                e.Graphics.DrawString(debugInfo, SystemFonts.DefaultFont, Brushes.Black, 80, 514)

                e.Graphics.DrawString(manager.GetGame.ToString(), SystemFonts.DefaultFont, Brushes.Black, 2, 528)
            End If
        Catch ex As Exception
            manager.LogException(ex)
        End Try
    End Sub

    Private Sub PictureBoxConsumer_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        manager.SetSize(Width, Height)
    End Sub

    Public Function GetFrameManager() As FrameManager
        Return manager
    End Function

    Public Sub EnableDebugInfo(x As Boolean)
        debugEnabled = x
    End Sub

    Protected Shadows Sub MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        Try
            MyBase.RaiseMouseEvent(sender, e)

            Dim i As Integer = 0, j As Integer = 0
            Dim layers As List(Of GraphicsLayer) = manager.GetGame.graphicsLayers
            While j < layers.Count
                Dim listeners As List(Of GameBody) = layers(j).bodies

                i = 0
                While i < listeners.Count
                    Dim l As IMouseListener = listeners(i)
                    If mouseButtonsDown = 0 Then
                        l.MouseMoved(e.X, e.Y)
                    Else
                        l.MouseDrag(mouseButtonsDown, e.X, e.Y)
                    End If
                    i += 1
                End While

                j += 1
            End While

        Catch ex As Exception
            manager.LogException(ex)
        End Try
    End Sub
    Private Function FindButton(e As System.Windows.Forms.MouseEventArgs) As Integer
        Dim button As Integer = 0
        Select Case e.Button
            Case MouseButtons.Left
                button = 1
            Case MouseButtons.Middle
                button = 4
            Case MouseButtons.Right
                button = 2
        End Select
        Return button
    End Function
    Protected Shadows Sub MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        Try
            MyBase.RaiseMouseEvent(sender, e)
            Dim button As Integer = FindButton(e)
            mouseButtonsDown = mouseButtonsDown Or button

            Dim i As Integer = 0, j As Integer = 0
            Dim layers As List(Of GraphicsLayer) = manager.GetGame.graphicsLayers
            While j < layers.Count
                Dim listeners As List(Of GameBody) = layers(j).bodies

                i = 0
                While i < listeners.Count
                    Dim l As IMouseListener = listeners(i)
                    If l IsNot Nothing Then
                        l.MouseDown(button, e.X, e.Y)
                    End If
                    i += 1
                End While

                j += 1
            End While

        Catch ex As Exception
            manager.LogException(ex)
        End Try
    End Sub
    Protected Shadows Sub MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        Try
            Dim button As Integer = FindButton(e)
            mouseButtonsDown = mouseButtonsDown Xor button

            Dim i As Integer = 0, j As Integer = 0
            Dim layers As List(Of GraphicsLayer) = manager.GetGame.graphicsLayers
            While j < layers.Count
                Dim listeners As List(Of GameBody) = layers(j).bodies

                i = 0
                While i < listeners.Count
                    Dim l As IMouseListener = listeners(i)
                    If l IsNot Nothing Then
                        l.MouseUp(button, e.X, e.Y)
                    End If
                    i += 1
                End While

                j += 1
            End While

        Catch ex As Exception
            manager.LogException(ex)
        End Try
    End Sub
    Protected Shadows Sub MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        Try
            Dim i As Integer = 0, j As Integer = 0
            Dim layers As List(Of GraphicsLayer) = manager.GetGame.graphicsLayers
            While j < layers.Count
                Dim listeners As List(Of GameBody) = layers(j).bodies

                i = 0
                While i < listeners.Count
                    Dim l As IMouseListener = listeners(i)
                    If l IsNot Nothing Then
                        l.MouseEnter()
                    End If
                    i += 1
                End While

                j += 1
            End While

        Catch ex As Exception
            manager.LogException(ex)
        End Try
    End Sub
    Protected Shadows Sub MouseLeave(sender As Object, e As System.EventArgs) Handles MyBase.MouseLeave
        Try
            Dim i As Integer = 0, j As Integer = 0
            Dim layers As List(Of GraphicsLayer) = manager.GetGame.graphicsLayers
            While j < layers.Count
                Dim listeners As List(Of GameBody) = layers(j).bodies

                i = 0
                While i < listeners.Count
                    Dim l As IMouseListener = listeners(i)
                    If l IsNot Nothing Then
                        l.MouseLeave()
                    End If
                    i += 1
                End While

                j += 1
            End While

        Catch ex As Exception
            manager.LogException(ex)
        End Try
    End Sub

    ''' <summary>
    '''  Calculates the average frame rate over the last NUM_FRAMES displayed
    ''' </summary>
    ''' <param name="newTick"></param>
    ''' <returns></returns>
    Public Function CalcFps(newTick As Double) As Double
        tickIndex += 1
        If tickIndex = NUM_FRAMES Then
            tickIndex = 0
        End If
        Dim prevTick As Double = tickList(tickIndex)
        tickList(tickIndex) = newTick
        Dim deltaT As Double = newTick - prevTick
        If deltaT = 0 Then
            Return -1
        End If
        Return NUM_FRAMES / deltaT
    End Function

End Class
