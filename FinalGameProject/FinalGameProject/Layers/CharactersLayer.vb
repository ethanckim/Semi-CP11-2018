Imports FinalGameProject

Public Class CharactersLayer
    Inherits GraphicsLayer

    Public t As Title

    Public Sub New(game As GameStatus)
        MyBase.New(game)
    End Sub

    Protected Friend Overrides Sub ChangeLevel(level As Integer)
        bodies.Clear()

        If level = 1 Then
            bodies.Add(New Character(game, 29, 29, 86, 24))

            t = New Title(game, 24, 27)
            bodies.Add(t)

        ElseIf level = 2 Then
            bodies.Add(New Character(game, 15, 15, 73, 35))

            t = New Title(game, 12, 14)
            bodies.Add(t)

        ElseIf level = 3 Then
            bodies.Add(New Character(game, 29, 2, 117, 34))

            t = New Title(game, 24, 4)
            bodies.Add(t)
        End If

    End Sub

End Class

