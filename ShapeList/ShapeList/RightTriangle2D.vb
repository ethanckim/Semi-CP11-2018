Public Class RightTriangle2D
    Inherits Shape2D

    Dim base As Decimal
    Dim height As Decimal

    Public Sub New(b As Decimal, h As Decimal)
        If b <= 0 Or h <= 0 Then
            Throw New InvalidDimensionException
        End If

        Me.base = b
        Me.height = h
    End Sub

    Public Overrides Function GetArea() As Decimal
        Return base * height / 2
    End Function

    Public Overrides Function GetPreimeter() As Decimal
        Return base + height + Math.Sqrt(base * base + height * height)
    End Function

    Public Overrides Function GetShapeType() As String
        Return "Right Triangle"
    End Function

    Public Overrides Function GetDimensions() As String
        Return "Base: " + Str(base) + " ,  Height: " + Str(height)
    End Function

End Class
