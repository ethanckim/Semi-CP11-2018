Public Class Echidna
    Inherits Animal

    Public Sub New(n As String)
        MyBase.New(n)
    End Sub

    Public Overrides Function color() As String
        Return "Reddish-Brown"
    End Function

    Public Overrides Function legs() As Integer
        Return 4
    End Function

    Public Overrides Function speak() As String
        Return "D U KNOW DE WAI"
    End Function

    Public Overrides Function spikes() As Boolean
        Return True
    End Function

    Public Overrides Function tails() As Boolean
        Return True
    End Function
End Class
