Imports FinalGameProject
Imports FinalGameProject.BodyOptions
Imports FinalGameProject.GameStatus

Public Class GroundLayer
    Inherits GraphicsLayer

    Public Sub New(game As GameStatus)
        MyBase.New(game)
    End Sub

    Protected Friend Overrides Sub ChangeLevel(level As Integer)
        bodies.Clear()

        Dim Map As Char(,)
            Map = {
                {M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N},
                {N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M},
                {M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N},
                {N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M},
                {M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N},
                {N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M},
                {M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N},
                {N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M},
                {M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N},
                {N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M},
                {M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N},
                {N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M},
                {M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N},
                {N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M},
                {M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N},
                {N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M},
                {M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N},
                {N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M},
                {M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N},
                {N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M},
                {M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N},
                {N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M},
                {M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N},
                {N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M},
                {M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N},
                {N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M},
                {M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N},
                {N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M},
                {M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N},
                {N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M},
                {M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N},
                {N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M, N, M}
            }

            Map = Helpers.Transpose(Map)

            Dim x As Integer = 0
            While x < PLAYFIELD_SIZE_X

                Dim y As Integer = 0
                While y < PLAYFIELD_SIZE_Y

                    Select Case Map(x, y)
                    'Add new Sprites here
                        Case M
                        Dim t As Tile1 = New Tile1(game, x, y)
                        t.spriteNum = level - 1
                        bodies.Add(t)
                    Case N
                        Dim t As Tile2 = New Tile2(game, x, y)
                        t.spriteNum = level - 1
                        bodies.Add(t)
                End Select

                y += 1
                End While

                x += 1
        End While

    End Sub
End Class
