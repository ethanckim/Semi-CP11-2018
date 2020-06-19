Imports FinalGameProject

Public Class RedSphere
    Inherits GameBody

    Public Sub New(g As GameStatus, x As Integer, y As Integer)
        MyBase.New(g, x, y)
    End Sub

    Public Overrides Function SpriteId() As Char
        Return BodyOptions.R
    End Function

    Protected Friend Overrides Function Collission(ahead As GameBody, dx As Integer, dy As Integer) As Boolean
        Return False
    End Function
End Class
