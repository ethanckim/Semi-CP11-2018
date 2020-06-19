Imports System.ComponentModel
Imports FinalGameProject

Public Class frmPaint
    Friend game As GameStatus
    Friend manager As FrameManager
    Const DEBUG_SIZE As Integer = 150

    Private Sub frmPaint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Const w As Integer = GameStatus.MAP_SIZE_X * GameStatus.TILE_SIZE
        Const h As Integer = GameStatus.MAP_SIZE_Y * GameStatus.TILE_SIZE + DEBUG_SIZE
        Me.Width = w + 16
        Me.Height = h
        pbcCanvas.Width = w
        pbcCanvas.Height = h

        manager = pbcCanvas.GetFrameManager()
        Try
            game = New GameStatus()
            game.InitGame()
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            manager.LogException(ex)
        End Try

        manager.Start(tmrRepaint.Interval, game)
        frmDebug.Show()
        moveDebugForm()
    End Sub

    Private Sub moveDebugForm()
        frmDebug.Left = Me.Left + Me.Width + 10
        frmDebug.Top = Me.Top
    End Sub

    Private Sub tmrRepaint_Tick(sender As Object, e As EventArgs) Handles tmrRepaint.Tick
        pbcCanvas.Invalidate()
    End Sub

    Private Sub frmPaint_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        pbcCanvas.GetFrameManager.kill = True
        frmDebug.sendClose = False
        frmDebug.Close()

        frmWelcome.Show()
    End Sub

    Private Sub frmPaint_Move(sender As Object, e As EventArgs) Handles Me.Move
        moveDebugForm()
    End Sub


    Private Sub frmPaint_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            Dim i As Integer = 0, j As Integer = 0
            Dim layers As List(Of GraphicsLayer) = manager.GetGame.graphicsLayers
            While j < layers.Count
                Dim listeners As List(Of GameBody) = layers(j).bodies

                i = 0
                While i < listeners.Count
                    Dim l As IKeyboardListener = listeners(i)
                    If l IsNot Nothing Then
                        l.KeyDown(e.KeyCode)
                    End If
                    i += 1
                End While

                j += 1
            End While

            e.Handled = True

        Catch ex As Exception
            manager.LogException(ex)
        End Try
    End Sub

    Private Sub frmPaint_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Try

            Dim i As Integer = 0, j As Integer = 0
            Dim layers As List(Of GraphicsLayer) = manager.GetGame.graphicsLayers
            While j < layers.Count
                Dim listeners As List(Of GameBody) = layers(j).bodies

                i = 0
                While i < listeners.Count
                    Dim l As IKeyboardListener = listeners(i)
                    If l IsNot Nothing Then
                        l.KeyUp(e.KeyCode)
                    End If
                    i += 1
                End While

                j += 1
            End While
            e.Handled = True

        Catch ex As Exception
            manager.LogException(ex)
        End Try
    End Sub

End Class
