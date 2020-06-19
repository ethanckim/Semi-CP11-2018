Imports FinalGameProject
Imports FinalGameProject.BodyOptions

Public MustInherit Class GameBody
    Implements IKeyboardListener, IMouseListener

    Protected Friend location As Point
    Protected Friend game As GameStatus
    Protected Friend spriteNum As Integer = 0

    Public Sub New(g As GameStatus, x As Integer, y As Integer)
        Me.game = g
        Me.location = New Point(x, y)
    End Sub

    Public MustOverride Function SpriteId() As Char

    Public Function Move(d As Direction) As Boolean

        Dim dx As Integer = xDelta(d)
        Dim dy As Integer = yDelta(d)

        Return Move(dx, dy)
    End Function

    Public Function Move(dx As Integer, dy As Integer) As Boolean
        Dim x2 As Integer = location.X + dx
        Dim y2 As Integer = location.Y + dy

        Dim ahead As List(Of GameBody) = game.LookAhead(x2, y2)
        Dim allowMove As Boolean = True
        For Each target In ahead
            allowMove = allowMove AndAlso Collission(target, dx, dy)
        Next
        If allowMove Then
            location.X = x2
            location.Y = y2
        End If
        Return allowMove
    End Function

    Public Overridable Sub AutoMove()
        ' Default does nothing
    End Sub

    ''' <summary>
    ''' Gets called before you Move() into a location that has a Body there already.
    ''' In this project, we'll use Look-Ahead collission detection. The Body that is moving 
    ''' is responsible for not ruining the playability of your game.
    ''' </summary>
    ''' <returns>False if the move should be blocked, True if it should be allowed</returns>
    Protected Friend MustOverride Function Collission(ahead As GameBody, dx As Integer, dy As Integer) As Boolean

    Public Overridable Sub KeyDown(keyCode As Keys) Implements IKeyboardListener.KeyDown
    End Sub

    Public Overridable Sub KeyUp(keyCode As Keys) Implements IKeyboardListener.KeyUp
    End Sub

    Public Overridable Sub MouseMoved(x As Integer, y As Integer) Implements IMouseListener.MouseMoved
    End Sub

    Public Overridable Sub MouseDown(button As Integer, x As Integer, y As Integer) Implements IMouseListener.MouseDown
    End Sub

    Public Overridable Sub MouseUp(button As Integer, x As Integer, y As Integer) Implements IMouseListener.MouseUp
    End Sub

    Public Overridable Sub MouseDrag(buttons As Integer, x As Integer, y As Integer) Implements IMouseListener.MouseDrag
    End Sub

    Public Overridable Sub MouseEnter() Implements IMouseListener.MouseEnter
    End Sub

    Public Overridable Sub MouseLeave() Implements IMouseListener.MouseLeave
    End Sub
End Class
