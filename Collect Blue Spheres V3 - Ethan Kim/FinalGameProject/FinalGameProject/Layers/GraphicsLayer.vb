Imports FinalGameProject
Imports FinalGameProject.GameStatus

Public MustInherit Class GraphicsLayer

    Public map(,) As GameBody
    Protected Friend bodies As List(Of GameBody) = New List(Of GameBody)
    Protected Friend textEnabled As Boolean = False
    Protected Friend game As GameStatus

    Public Sub New(game As GameStatus)
        Me.game = game
    End Sub

    Public Function CreateMap() As GameBody(,)
        'create the map... for drawing and collisions

        Dim nextMap(GameStatus.PLAYFIELD_SIZE_X - 1, GameStatus.PLAYFIELD_SIZE_Y - 1) As GameBody

        Dim i As Integer
        While i < bodies.Count
            Dim b As GameBody
            b = bodies(i)

            If Helpers.Inside(b.location.X, 0, PLAYFIELD_SIZE_X) And Helpers.Inside(b.location.Y, 0, PLAYFIELD_SIZE_Y) Then
                nextMap(b.location.X, b.location.Y) = b
            End If

            i += 1
        End While

        Me.map = nextMap

        Return nextMap
    End Function

    Public Overridable Sub PaintNextFrame(gfx As Graphics, game As GameStatus, bounds As Rectangle)
        If map Is Nothing Then
            Exit Sub
        End If

        'use the map to figure out which sprite id should be drawn. Then get it from the SpriteMap, and draw it using Graphics.
        Dim x As Integer = game.CamX
        While x < game.CamX + CAM_SIZE_X

            Dim y As Integer = game.CamY
            While y < game.CamY + CAM_SIZE_Y

                Dim body As GameBody
                body = map(x, y)

                If body IsNot Nothing Then
                    Dim sprite As Image
                    sprite = game.spriteMap(body.SpriteId(), body.spriteNum)

                    If sprite IsNot Nothing Then
                        gfx.DrawImage(sprite, Helpers.ConvertGridToPixel(x - game.CamX), Helpers.ConvertGridToPixel(y - game.CamY))
                    End If

                End If

                y += 1
            End While

            x += 1
        End While



    End Sub
    Protected Friend MustOverride Sub ChangeLevel(level As Integer)


    Public Sub remove(target As GameBody)
        bodies.Remove(target)
    End Sub

    Protected Friend Overridable Sub Animate()
        'tell each body to AutoMove

        Dim i As Integer = 0
        While i < bodies.Count
            Dim body As GameBody
            body = bodies(i)

            body.AutoMove()

            i += 1
        End While

    End Sub

    Public Function search(x As Integer, y As Integer) As GameBody
        'search the list of Bodies, and see if you can find one at that (x,y) coordinate.

        Dim i As Integer = 0
        While i < bodies.Count
            Dim b As GameBody = bodies(i)

            If b.location.X = x And b.location.Y = y Then
                Return b
            End If

            i += 1
        End While

        Return Nothing
    End Function

End Class