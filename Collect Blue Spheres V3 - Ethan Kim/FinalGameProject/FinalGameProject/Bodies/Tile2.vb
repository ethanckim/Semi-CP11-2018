Imports FinalGameProject

Public Class Tile2
    Inherits GameBody

    Public Sub New(g As GameStatus, x As Integer, y As Integer)
        MyBase.New(g, x, y)
    End Sub

    Public Overrides Function SpriteId() As Char
        Return BodyOptions.N
    End Function

    Protected Friend Overrides Function Collission(ahead As GameBody, dx As Integer, dy As Integer) As Boolean
        Return True
    End Function

End Class
