Imports FinalGameProject

Public Class Character
    Inherits GameBody

    Public Sub New(g As GameStatus, x As Integer, y As Integer)
        MyBase.New(g, x, y)
    End Sub

    Public Overrides Function SpriteId() As Char
        Return BodyOptions.C
    End Function

    Protected Friend Overrides Function Collission(ahead As GameBody, dx As Integer, dy As Integer) As Boolean
        If ahead.SpriteId() = BodyOptions.M Then
            MessageBox.Show("1 up!", "Got a mushroom")
            game.Remove(ahead)

            Return True
        End If

        Return False
    End Function

    Public Overrides Sub KeyDown(keyCode As Keys)
        Dim d As Direction
        d = Direction.None

        Select Case keyCode
            Case Keys.Down
                d = Direction.Down
            Case Keys.Up
                d = Direction.Up
            Case Keys.Left
                d = Direction.Left
            Case Keys.Right
                d = Direction.Right
        End Select

        Move(d)
    End Sub
End Class
