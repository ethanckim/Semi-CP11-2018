Public Class Lionfish
    Inherits Animal

    Public Sub New(n As String)
        MyBase.New(n)
    End Sub

    Public Overrides Function color() As String
        Return "Nimo (White with Orange Stripes)"
    End Function

    Public Overrides Function legs() As Integer
        Return 0
    End Function

    Public Overrides Function speak() As String
        Return "Bulb."
    End Function

    Public Overrides Function spikes() As Boolean
        Return True
    End Function

    Public Overrides Function tails() As Boolean
        Return False
    End Function
End Class
