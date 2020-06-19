Imports FinalGameProject

Public Class FrameManager

    Public kill As Boolean = False
    Dim delay As Integer = 50
    Dim renderWorker As System.Threading.Thread

    Dim current As Image
    Dim readyFrames As Queue(Of Image) = New Queue(Of Image)
    Dim availableFrames As Queue(Of Image) = New Queue(Of Image)
    Dim graphicsStorage As Hashtable = New Hashtable()

    Dim exceptionList As List(Of ExceptionStamp) = New List(Of ExceptionStamp)

    Friend Sub LogException(ex As Exception)
        exceptionList.Add(New ExceptionStamp(ex))
    End Sub

    Private bounds As Rectangle
    Const MAX_TO_KEEP = 10
    Public Const RES = 96

    Private game As GameStatus
    Private textEnabled As Boolean = False

    Sub New(width As Integer, height As Integer)
        Me.bounds.X = 0
        Me.bounds.Y = 0

        SetSize(width, height)
    End Sub

    Public Sub Start(delay As Integer, game As GameStatus)
        Me.delay = delay
        Me.game = game


        If renderWorker Is Nothing Then
            renderWorker = New System.Threading.Thread(AddressOf RenderJob)
            renderWorker.Start()
        End If
    End Sub

    Public Function GetCurrent() As Image
        Dim target As Image = Nothing
        Dim oldCurrent As Image = current
        While readyFrames.Count > 0
            If target IsNot Nothing Then
                If readyFrames.Count > 3 Then
                    graphicsStorage.Remove(target)
                Else
                    availableFrames.Enqueue(target)
                End If
            End If
            target = readyFrames.Dequeue


        End While

        If target IsNot Nothing Then
            current = target
            availableFrames.Enqueue(oldCurrent)
        End If
        Return current
    End Function


    Private Function CreateFrame() As Image
        Dim frame As Bitmap
        Dim frameGfx As Graphics
        frame = New Bitmap(bounds.Width, bounds.Height)
        frame.SetResolution(RES, RES)
        frameGfx = Graphics.FromImage(frame)
        frameGfx.FillRectangle(Brushes.White, 0, 0, bounds.Width, bounds.Height)
        graphicsStorage.Add(frame, frameGfx)

        Return frame
    End Function

    Friend Sub RenderNextFrame()
        ' prep work
        Dim nextFrame As Image = Nothing
        Dim gfx As Graphics = Nothing
        If availableFrames.Count > 0 Then
            nextFrame = availableFrames.Dequeue

            While availableFrames.Count > MAX_TO_KEEP
                Dim remove As Image = availableFrames.Dequeue
                If Not remove Is Nothing Then
                    graphicsStorage.Remove(remove)
                End If
            End While
        End If
        If nextFrame Is Nothing Then
            nextFrame = CreateFrame()
        End If
        Try
            gfx = graphicsStorage(nextFrame)
        Catch e As Exception
        End Try


        game.AdvanceAnimation()

        If gfx Is Nothing Then
            gfx = Graphics.FromImage(nextFrame)
            graphicsStorage.Add(nextFrame, gfx)
        End If

        gfx.FillRectangle(Brushes.White, bounds)

        Dim layers As List(Of GraphicsLayer) = game.graphicsLayers

        Dim i As Integer = 0
        While i < layers.Count
            Dim layer As GraphicsLayer = layers(i)
            layer.CreateMap()
            layer.PaintNextFrame(gfx, game, bounds)
            i += 1
        End While

        ' frame is done, put it in the queue to be displayed by PictureBoxConsumer
        readyFrames.Enqueue(nextFrame)
    End Sub

    Public Sub SetSize(width As Integer, height As Integer)
        Me.bounds.Width = width
        Me.bounds.Height = height

        readyFrames.Clear()
        availableFrames.Clear()

        current = CreateFrame()
    End Sub


    Private Sub RenderJob()
        While Not kill
            RenderNextFrame()
            Threading.Thread.Sleep(delay)
        End While
    End Sub

    Friend Function GetGame() As GameStatus
        Return game
    End Function

    Public Function GetDebugInfo() As String
        'Return "hello"

        Dim frames As String = "N/A"
        Dim avail As String = "N/A"
        If readyFrames IsNot Nothing Then
            frames = Str(readyFrames.Count).Trim
        End If
        If availableFrames IsNot Nothing Then
            avail = Str(availableFrames.Count).Trim
        End If

        Dim exceptions As String = If(exceptionList.Count > 0, "Exceptions" + vbCrLf, "")
        For i As Integer = 0 To exceptionList.Count - 1 Step 1
            Dim stamp As ExceptionStamp = exceptionList(i)


            exceptions += stamp.t.ToLongTimeString() + ": " + stamp.ex.GetType.ToString() + vbCrLf
        Next

        Return "Frames Ready: " + frames + " Buffers Available: " + avail + vbCrLf + exceptions
    End Function
End Class
