Public Class Circle2D
    Inherits Shape2D

    Dim radius As Decimal

    Public Sub New(r As Decimal)
        If r <= 0 Then
            Throw New InvalidDimensionException
        End If

        Me.radius = r
    End Sub

    Public Overrides Function GetArea() As Decimal
        Return Math.PI * radius * radius
    End Function

    Public Overrides Function GetPreimeter() As Decimal
        Return radius * 2 * Math.PI
    End Function

    Public Overrides Function GetShapeType() As String
        Return "Circle"
    End Function

    Public Overrides Function GetDimensions() As String
        Return "Radius: " + Str(radius)
    End Function

End Class
