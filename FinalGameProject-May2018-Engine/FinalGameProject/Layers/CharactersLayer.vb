Imports FinalGameProject

Public Class CharactersLayer
    Inherits GraphicsLayer


    Public Sub New(game As GameStatus)
        MyBase.New(game)
    End Sub

    Protected Friend Overrides Sub ChangeLevel(level As Integer)
        bodies.Clear()

        If level = 0 Then
            bodies.Add(New Character(game, 5, 2))
            bodies.Add(New Mushroom(game, 9, 4))
        ElseIf level = 1 Then

        End If

    End Sub

End Class

