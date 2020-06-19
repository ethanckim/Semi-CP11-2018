Public MustInherit Class Animal

    Public MustOverride Function speak() As String
    Public MustOverride Function spikes() As Boolean
    Public MustOverride Function legs() As Integer
    Public MustOverride Function color() As String
    Public MustOverride Function tails() As Boolean

    Public name As String

    Public Sub New(n As String)
        Me.name = n
    End Sub

End Class
