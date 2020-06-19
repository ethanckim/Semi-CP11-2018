Public Class Homosaphien
    Inherits Animal
    Dim Name As String

    Public Sub New(n As String)
        MyBase.New(n)
    End Sub

    Public Overrides Function color() As String
        Return "red and yellow, black and white"
    End Function

    Public Overrides Function legs() As Integer
        Return 2
    End Function

    Public Overrides Function speak() As String
        Throw New NotImplementedException()
    End Function

    Public Overrides Function spikes() As Boolean
        Return False
    End Function

    Public Overrides Function tails() As Boolean
        Return False
    End Function
End Class
