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

        If level = 1 Then
            'Camera
            game.CamX = 23
            game.CamY = 23

            'Game Map
            Dim Map As Char(,)
            Map = {
                {R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R},
                {R, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, R},
                {R, K, S, S, S, S, S, S, S, S, S, S, S, S, S, K, K, S, S, S, S, S, S, S, S, S, S, S, S, S, K, R},
                {R, K, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, K, R},
                {R, K, S, S, B, B, B, B, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, B, B, B, B, S, S, K, R},
                {R, K, S, S, B, I, I, B, S, S, B, B, S, S, S, K, K, S, S, S, B, B, S, S, B, I, I, B, S, S, K, R},
                {R, K, S, S, B, I, I, B, S, S, B, B, S, S, S, K, K, S, S, S, B, B, S, S, B, I, I, B, S, S, K, R},
                {R, K, S, S, B, B, B, B, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, B, B, B, B, S, S, K, R},
                {R, K, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, K, R},
                {R, K, S, S, S, S, S, S, S, S, S, S, S, S, S, K, K, S, S, S, S, S, S, S, S, S, S, S, S, S, K, R},
                {R, K, S, S, S, S, S, S, S, S, R, R, R, R, R, R, R, R, R, R, R, R, S, S, S, S, S, S, S, S, K, R},
                {R, K, S, S, S, S, S, S, S, S, R, R, R, R, R, R, R, R, R, R, R, R, S, S, S, S, S, S, S, S, K, R},
                {R, K, S, S, I, B, R, I, S, S, R, R, R, R, R, R, R, R, R, R, R, R, S, S, I, R, B, I, S, S, K, R},
                {R, K, S, S, K, B, B, K, S, S, R, R, R, R, R, R, R, R, R, R, R, R, S, S, K, B, B, K, S, S, K, R},
                {R, K, S, S, K, R, B, K, S, S, R, R, R, R, R, R, R, R, R, R, R, R, S, S, K, B, R, K, S, S, K, R},
                {R, K, S, S, K, B, B, K, S, S, R, R, R, R, R, R, R, R, R, R, R, R, S, S, K, B, B, K, S, S, K, R},
                {R, K, S, S, K, B, R, K, S, S, R, R, R, R, R, R, R, R, R, R, R, R, S, S, K, R, B, K, S, S, K, R},
                {R, K, S, S, K, B, B, K, S, S, R, R, R, R, R, R, R, R, R, R, R, R, S, S, K, B, B, K, S, S, K, R},
                {R, K, S, S, K, R, B, K, S, S, R, R, R, R, R, R, R, R, R, R, R, R, S, S, K, B, R, K, S, S, K, R},
                {R, K, S, S, I, R, B, I, S, S, R, R, R, R, R, R, R, R, R, R, R, R, S, S, I, B, R, I, S, S, K, R},
                {R, K, S, S, S, S, S, S, S, S, R, R, R, R, R, R, R, R, R, R, R, R, S, S, S, S, S, S, S, S, K, R},
                {R, K, S, S, S, S, S, S, S, S, R, R, R, R, R, R, R, R, R, R, R, R, S, S, S, S, S, S, S, S, K, R},
                {R, K, S, S, S, S, S, S, S, S, S, S, S, S, S, K, K, S, S, S, S, S, S, S, S, S, S, S, S, S, K, R},
                {R, K, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, K, R},
                {R, K, S, S, B, B, B, B, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, B, B, B, B, S, S, K, R},
                {R, K, S, S, B, I, I, B, S, S, B, B, S, S, S, K, K, S, S, S, B, B, S, S, B, I, I, B, S, S, K, R},
                {R, K, S, S, B, I, I, B, S, S, B, B, S, S, S, K, K, S, S, S, B, B, S, S, B, I, I, B, S, S, K, R},
                {R, K, S, S, B, B, B, B, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, B, B, B, B, S, S, K, R},
                {R, K, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, K, R},
                {R, K, S, S, S, S, S, S, S, S, S, S, S, S, S, K, K, S, S, S, S, S, S, S, S, S, S, S, S, S, K, R},
                {R, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, R},
                {R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R}
            }
            'The only problem with the 2D array, is that x & y cordinates are backwards
            'Transpose it! (Use Utils/Helpers)

            Map = Helpers.Transpose(Map)

            Dim x As Integer = 0
            While x < PLAYFIELD_SIZE_X

                Dim y As Integer = 0
                While y < PLAYFIELD_SIZE_Y

                    Select Case Map(x, y)
                    'Add new Sprites here
                        Case K
                            bodies.Add(New Bumper(game, x, y))
                        Case B
                            bodies.Add(New BlueSphere(game, x, y))
                        Case R
                            bodies.Add(New RedSphere(game, x, y))
                        Case I
                            bodies.Add(New Ring(game, x, y))
                    End Select

                    y += 1
                End While

                x += 1
            End While

        ElseIf level = 2 Then
            'Camera
            game.CamX = 11
            game.CamY = 11

            'Game Map
            Dim Map As Char(,)
            Map = {
                {R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R},
                {R, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, R},
                {R, K, I, I, K, R, R, K, I, I, K, R, R, K, I, I, K, R, R, K, I, I, K, R, R, K, S, R, I, I, K, R},
                {R, K, S, S, K, R, R, K, S, S, K, R, R, K, S, S, K, R, R, K, S, S, K, R, R, K, S, R, I, I, K, R},
                {R, K, S, S, S, K, K, S, B, B, S, K, K, S, S, S, S, K, K, S, B, B, S, K, K, S, S, S, R, R, K, R},
                {R, K, S, S, S, S, S, B, S, S, B, S, S, S, B, B, S, S, S, B, S, S, B, S, S, S, S, S, S, S, K, R},
                {R, K, S, S, S, S, S, B, S, S, B, S, S, S, B, B, S, S, S, B, S, S, B, S, S, S, S, S, S, S, K, R},
                {R, K, S, S, S, K, K, S, B, B, S, K, K, S, S, S, S, K, K, S, B, B, S, K, K, S, S, S, S, S, K, R},
                {R, K, S, S, K, R, R, K, S, S, K, R, R, K, S, S, K, R, R, K, S, S, K, R, R, K, S, S, S, S, K, R},
                {R, K, S, S, K, R, R, K, S, S, K, R, R, K, S, S, K, R, R, K, S, S, K, R, R, K, S, S, S, S, K, R},
                {R, K, S, S, S, K, K, S, S, S, S, K, K, S, B, B, S, K, K, S, S, S, S, K, K, S, S, S, S, S, K, R},
                {R, K, S, S, S, S, S, S, B, B, S, S, S, B, S, S, B, S, S, S, B, B, S, S, S, S, S, S, S, S, K, R},
                {R, K, S, S, S, S, S, S, B, B, S, S, S, B, S, S, B, S, S, S, B, B, S, S, S, S, S, S, S, S, K, R},
                {R, K, S, S, S, K, K, S, S, S, S, K, K, S, B, B, S, K, K, S, S, S, S, K, K, S, S, S, S, S, K, R},
                {R, K, S, S, K, R, R, K, S, S, K, R, R, K, S, S, K, R, R, K, S, S, K, I, I, K, S, S, S, S, K, R},
                {R, K, S, S, K, R, R, K, S, S, K, R, R, K, S, S, K, R, R, K, S, S, K, I, I, K, S, S, S, S, K, R},
                {R, K, S, S, S, K, K, S, S, S, S, K, K, S, S, S, S, K, K, S, S, S, S, K, K, S, S, S, I, I, K, R},
                {R, K, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, I, I, K, R},
                {R, K, R, Y, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, K, R},
                {R, K, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, K, R},
                {R, K, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, K, R},
                {R, K, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, K, R},
                {R, K, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, Y, R, K, R},
                {R, K, R, S, R, R, R, R, R, R, R, R, R, R, R, R, R, R, S, S, S, S, S, S, S, S, S, S, S, I, K, R},
                {R, K, R, B, K, K, K, K, B, B, B, B, B, Y, R, R, R, R, S, S, S, S, S, S, S, B, B, B, S, I, K, R},
                {R, K, R, B, K, I, I, K, B, R, K, K, K, R, R, R, R, R, S, S, B, S, S, B, S, S, B, S, S, I, K, R},
                {R, K, R, B, K, I, I, K, B, R, K, I, I, K, R, R, R, R, S, S, B, S, S, B, S, S, B, S, S, I, K, R},
                {R, K, R, B, K, K, K, K, B, R, K, I, I, K, R, R, R, R, S, S, B, B, B, B, S, S, B, S, S, S, K, R},
                {R, K, R, B, B, B, B, B, B, R, K, I, I, K, R, R, R, R, S, S, B, S, S, B, S, B, B, B, S, I, K, R},
                {R, K, R, R, R, R, R, R, R, R, K, K, K, K, R, R, R, R, S, S, S, S, S, S, S, S, S, S, S, S, K, R},
                {R, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, K, R},
                {R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R}
            }
            'The only problem with the 2D array, is that x & y cordinates are backwards
            'Transpose it! (Use Utils/Helpers)

            Map = Helpers.Transpose(Map)

            Dim xAxis As Integer = 0
            While xAxis < PLAYFIELD_SIZE_X

                Dim yAxis As Integer = 0
                While yAxis < PLAYFIELD_SIZE_Y

                    Select Case Map(xAxis, yAxis)
                    'Add new Sprites here
                        Case K
                            bodies.Add(New Bumper(game, xAxis, yAxis))
                        Case B
                            bodies.Add(New BlueSphere(game, xAxis, yAxis))
                        Case R
                            bodies.Add(New RedSphere(game, xAxis, yAxis))
                        Case Y
                            bodies.Add(New YellowSphere(game, xAxis, yAxis))
                        Case I
                            bodies.Add(New Ring(game, xAxis, yAxis))
                    End Select

                    yAxis += 1
                End While

                xAxis += 1
            End While

        ElseIf level = 3 Then

            'Camera
            game.CamX = 23
            game.CamY = 0

            'Game Map
            Dim Map As Char(,)
            Map = {
                {R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R},
                {R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R},
                {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, I, S, S, S, R, R},
                {R, R, S, S, B, B, B, B, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, S, S, S, R, R},
                {R, R, S, S, B, I, R, B, S, G, B, B, S, S, S, S, S, G, G, G, G, G, G, S, I, R, G, K, I, S, R, R},
                {R, R, S, S, B, R, I, B, S, G, B, B, S, S, S, S, S, G, I, I, I, I, G, S, S, S, K, S, S, S, R, R},
                {R, R, S, S, B, B, B, B, S, G, G, G, S, S, S, S, S, G, I, I, I, I, G, S, S, S, I, S, S, S, R, R},
                {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, G, G, G, G, G, G, S, S, S, S, R, S, S, R, R},
                {R, R, S, S, S, B, B, G, S, S, S, S, S, B, B, B, B, S, S, S, S, S, S, S, S, S, K, B, R, S, R, R},
                {R, R, S, S, S, B, B, G, S, S, S, S, S, B, R, R, B, S, S, S, S, S, S, S, S, S, S, K, S, S, R, R},
                {R, R, S, S, S, G, G, G, S, S, S, S, S, B, B, B, B, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
                {R, R, S, S, S, S, S, S, S, S, S, S, S, Y, S, S, S, S, S, S, S, S, S, S, S, Y, S, S, S, S, R, R},
                {R, R, R, R, R, R, B, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, I, R, R},
                {R, R, I, R, R, R, B, B, I, I, I, I, I, I, I, I, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R},
                {R, R, R, R, R, R, R, B, R, R, R, R, R, R, R, I, R, R, R, R, R, R, R, R, R, R, R, R, R, I, R, R},
                {R, R, I, R, R, R, R, B, R, R, R, R, R, R, R, I, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R},
                {R, R, S, S, S, S, S, S, S, S, B, B, S, Y, S, S, S, S, S, S, S, S, S, S, S, Y, S, S, S, S, R, R},
                {R, R, S, S, S, S, S, S, S, S, K, K, S, S, S, S, R, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
                {R, R, S, S, G, G, G, S, S, S, K, K, S, S, S, K, B, R, S, S, S, S, S, S, K, S, S, S, S, S, R, R},
                {R, R, S, S, G, G, G, S, S, S, R, R, S, S, S, S, K, S, S, S, S, S, S, R, G, K, S, S, S, S, R, R},
                {R, R, S, S, G, G, G, S, S, S, G, G, S, S, S, S, S, S, S, S, S, S, S, S, R, S, S, S, S, S, R, R},
                {R, R, S, S, S, S, S, S, S, S, G, G, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
                {R, R, S, S, S, S, S, S, S, S, R, R, S, S, S, S, S, S, K, S, S, S, S, S, S, S, S, S, S, S, R, R},
                {R, R, S, S, S, S, S, S, S, S, K, K, S, S, S, S, S, K, I, R, S, S, S, S, S, S, S, S, S, S, R, R},
                {R, R, S, S, S, S, S, S, S, S, K, K, S, S, S, S, S, S, R, S, S, S, S, B, G, G, G, B, S, S, R, R},
                {R, R, S, S, S, S, S, S, S, S, K, K, S, S, S, S, S, S, S, S, S, S, S, G, G, I, G, G, S, S, R, R},
                {R, R, B, R, R, R, R, R, B, S, S, K, K, S, S, S, S, S, S, S, S, S, S, B, G, G, G, B, S, S, R, R},
                {R, R, B, R, B, B, B, R, B, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
                {R, R, B, R, B, K, B, R, B, R, S, S, S, S, S, S, I, I, I, I, S, S, S, S, S, S, S, S, S, S, R, R},
                {R, R, B, B, B, K, B, B, B, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
                {R, R, R, R, R, K, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R},
                {R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R}
            }
            'The only problem with the 2D array, is that x & y cordinates are backwards
            'Transpose it! (Use Utils/Helpers)

            Map = Helpers.Transpose(Map)

            Dim xAxis As Integer = 0
            While xAxis < PLAYFIELD_SIZE_X

                Dim yAxis As Integer = 0
                While yAxis < PLAYFIELD_SIZE_Y

                    Select Case Map(xAxis, yAxis)
                    'Add new Sprites here
                        Case K
                            bodies.Add(New Bumper(game, xAxis, yAxis))
                        Case B
                            bodies.Add(New BlueSphere(game, xAxis, yAxis))
                        Case R
                            bodies.Add(New RedSphere(game, xAxis, yAxis))
                        Case Y
                            bodies.Add(New YellowSphere(game, xAxis, yAxis))
                        Case G
                            bodies.Add(New GreenSphere(game, xAxis, yAxis))
                        Case I
                            bodies.Add(New Ring(game, xAxis, yAxis))
                    End Select

                    yAxis += 1
                End While

                xAxis += 1
            End While

        End If
    End Sub

    Public Overrides Sub PaintNextFrame(gfx As Graphics, game As GameStatus, bounds As Rectangle)

        MyBase.PaintNextFrame(gfx, game, bounds)

        'Dim x As Integer = 0
        'While x < GameStatus.CAM_SIZE_X
        '    gfx.DrawLine(Pens.Gray, Helpers.ConvertGridToPixel(x), 0, Helpers.ConvertGridToPixel(x), Helpers.ConvertGridToPixel(PLAYFIELD_SIZE_Y))

        '    x += 1
        'End While

        'Dim y As Integer = 0
        'While y < GameStatus.CAM_SIZE_Y
        '    gfx.DrawLine(Pens.Gray, 0, Helpers.ConvertGridToPixel(y), Helpers.ConvertGridToPixel(PLAYFIELD_SIZE_X), Helpers.ConvertGridToPixel(y))

        '    y += 1
        'End While

        ''Put the x y cordinates into the box
        'x = game.CamX
        'While x < game.CamX + CAM_SIZE_X
        '    y = game.CamY
        '    While y < game.CamY + CAM_SIZE_Y

        '        gfx.DrawString(Str(x).Trim + "," + Str(y).Trim, SystemFonts.DefaultFont, Brushes.Gray,
        '                       Helpers.ConvertGridToPixel(x - game.CamX), Helpers.ConvertGridToPixel(y - game.CamY))

        '        y += 1
        '    End While
        '    x += 1
        'End While

    End Sub

End Class



'Blank Map Template
'               {R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R},
'               {R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R},
'               {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
'               {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
'               {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
'               {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
'               {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
'               {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
'               {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
'               {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
'               {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
'               {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
'               {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
'               {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
'               {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
'               {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
'               {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
'               {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
'               {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
'               {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
'               {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
'               {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
'               {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
'               {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
'               {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
'               {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
'               {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
'               {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
'               {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
'               {R, R, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, S, R, R},
'               {R, R, R, R, R, K, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R},
'               {R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R, R}
