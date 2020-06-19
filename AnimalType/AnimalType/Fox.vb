Public Class Fox
    Inherits Animal

    Public Sub New(n As String)
        MyBase.New(n)
    End Sub

    Public Overrides Function color() As String
        Return "Orange"
    End Function

    Public Overrides Function legs() As Integer
        Return 4
    End Function

    Public Overrides Function speak() As String
        Return "Ring-ding-ding-ding-dingeringeding!
Gering-ding-ding-ding-dingeringeding!
Gering-ding-ding-ding-dingeringeding! Wa-pa-pa-pa-pa-pa-pow!
Wa-pa-pa-pa-pa-pa-pow!
Wa-pa-pa-pa-pa-pa-pow! Hatee-hatee-hatee-ho!
Hatee-hatee-hatee-ho!
Hatee-hatee-hatee-ho! Joff-tchoff-tchoffo-tchoffo-tchoff!
Tchoff-tchoff-tchoffo-tchoffo-tchoff!
Joff-tchoff-tchoffo-tchoffo-tchoff!"
    End Function

    Public Overrides Function spikes() As Boolean
        Return False
    End Function

    Public Overrides Function tails() As Boolean
        Return True
    End Function

End Class
