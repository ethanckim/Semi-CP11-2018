Imports FinalGameProject
Imports FinalGameProject.BodyOptions
Imports FinalGameProject.GameStatus
Public Class BackgroundLayer
    Inherits GraphicsLayer

    Public Sub New(game As GameStatus)
        MyBase.New(game)
    End Sub

    Protected Friend Overrides Sub ChangeLevel(level As Integer)
        bodies.Clear()

        If level = 0 Then

            ' top and bottom
            Dim i As Integer
            i = 0

            While i < MAP_SIZE_X
                bodies.Add(New Brick(game, i, 0))
                bodies.Add(New Brick(game, i, MAP_SIZE_Y - 1))
                i += 1
            End While

            ' left and right
            i = 1

            While i < MAP_SIZE_Y - 1
                bodies.Add(New Brick(game, 0, i))
                bodies.Add(New Brick(game, MAP_SIZE_X - 1, i))
                i += 1
            End While

        ElseIf level = 1 Then

        End If
    End Sub

    Public Overrides Sub PaintNextFrame(gfx As Graphics, game As GameStatus, bounds As Rectangle)
        MyBase.PaintNextFrame(gfx, game, bounds)

        Dim x As Integer = 0
        While x < GameStatus.MAP_SIZE_X
            gfx.DrawLine(Pens.Gray,
                         x * GameStatus.TILE_SIZE, 0,
                         x * GameStatus.TILE_SIZE, GameStatus.MAP_SIZE_Y * GameStatus.TILE_SIZE)

            x += 1
        End While

        Dim y As Integer = 0
        While y < GameStatus.MAP_SIZE_Y
            gfx.DrawLine(Pens.Gray,
                         Helpers.ConvertGridToPixel(0), Helpers.ConvertGridToPixel(y),
                         Helpers.ConvertGridToPixel(MAP_SIZE_X), Helpers.ConvertGridToPixel(y))
            y += 1
        End While

        ' Put the (x,y) coordinate in each box
        If frmDebug.chkFps.Checked Then
            x = 0
            While x < GameStatus.MAP_SIZE_X

                y = 0
                While y < GameStatus.MAP_SIZE_Y
                    gfx.DrawString(Str(x).Trim + "," + Str(y).Trim, SystemFonts.DefaultFont, Brushes.Gray,
                                   Helpers.ConvertGridToPixel(x), Helpers.ConvertGridToPixel(y))
                    y += 1
                End While
                x += 1
            End While
        End If
    End Sub
End Class
