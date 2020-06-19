Public Enum Direction
    None
    Up
    Down
    Left
    Right
End Enum

Public Module DirectionUtils
    Public Function xDelta(direction As Direction) As Integer
        Select Case direction
            Case Direction.Left
                Return -1
            Case Direction.Right
                Return 1
        End Select
        Return 0
    End Function
    Public Function yDelta(direction As Direction) As Integer
        Select Case direction
            Case Direction.Up
                Return -1
            Case Direction.Down
                Return 1
        End Select
        Return 0
    End Function
End Module