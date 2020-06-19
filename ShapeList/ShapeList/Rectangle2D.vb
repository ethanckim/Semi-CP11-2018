Public Class Rectangle2D
    Inherits Shape2D

    Dim length As Decimal
    Dim width As Decimal

    Public Sub New(l As Decimal, w As Decimal)
        If l <= 0 Or w <= 0 Then
            Throw New InvalidDimensionException
        End If

        Me.length = l
        Me.width = w
    End Sub

    Public Overrides Function GetArea() As Decimal
        Return length * width
    End Function

    Public Overrides Function GetPreimeter() As Decimal
        Return 2 * length + 2 * width
    End Function

    Public Overrides Function GetShapeType() As String
        Return "Rectangle"
    End Function

    Public Overrides Function GetDimensions() As String
        Return "Length: " + Str(length) + " ,  Width: " + Str(width)
    End Function

End Class
