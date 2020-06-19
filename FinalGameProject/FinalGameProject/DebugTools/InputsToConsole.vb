Imports FinalGameProject

Public Class InputsToConsole
    Implements IMouseListener, IKeyboardListener
    Public Sub Output(prefix As String, x As Integer, y As Integer)
        Console.WriteLine(prefix + " (" + Str(x).Trim + ", " + Str(y).Trim + ")")
    End Sub
    Public Sub Output(prefix As String, c As Char)
        Console.WriteLine(prefix + " (" + c + ")")
    End Sub

    Public Sub MouseDown(button As Integer, x As Integer, y As Integer) Implements IMouseListener.MouseDown
        Output("BD:" + Str(button).Trim, x, y)
    End Sub

    Public Sub MouseDrag(buttons As Integer, x As Integer, y As Integer) Implements IMouseListener.MouseDrag
        Output("Dr:" + Str(buttons).Trim, x, y)
    End Sub

    Public Sub MouseEnter() Implements IMouseListener.MouseEnter
        Output("  En", -1, -1)
    End Sub

    Public Sub MouseLeave() Implements IMouseListener.MouseLeave
        Output("  Lv", -1, -1)
    End Sub

    Public Sub MouseMoved(x As Integer, y As Integer) Implements IMouseListener.MouseMoved
        Output("   M", x, y)
    End Sub

    Public Sub MouseUp(button As Integer, x As Integer, y As Integer) Implements IMouseListener.MouseUp
        Output("BU:" + Str(button).Trim, x, y)
    End Sub

    Public Sub KeyDown(keyCode As Keys) Implements IKeyboardListener.KeyDown
        Output("KD:", keyCode.ToString)
    End Sub

    Public Sub KeyUp(keyCode As Keys) Implements IKeyboardListener.KeyUp
        Output("KU:", "?")
    End Sub
End Class
