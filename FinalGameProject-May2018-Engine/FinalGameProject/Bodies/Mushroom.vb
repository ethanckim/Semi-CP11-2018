Public Class Mushroom
    Inherits GameBody

    Dim animationStep As Integer = 0

    Public Sub New(g As GameStatus, x As Integer, y As Integer)
        MyBase.New(g, x, y)
    End Sub

    Public Overrides Function SpriteId() As Char
        Return BodyOptions.M
    End Function

    Protected Friend Overrides Function Collission(ahead As GameBody, dx As Integer, dy As Integer) As Boolean
        If ahead.SpriteId = BodyOptions.C Then
            Move(Direction.Left)
        End If
        Return False
    End Function

    Public Overrides Sub AutoMove()
        If animationStep < 2 Then
            Move(Direction.Down)
        Else
            Move(Direction.Up)
        End If

        animationStep += 1
        If animationStep >= 4 Then
            animationStep = 0
        End If
    End Sub
End Class
