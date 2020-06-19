Imports System.ComponentModel

Public Class frmDebug
    Friend mouseConsole As InputsToConsole

    Private Sub chkFps_CheckedChanged(sender As Object, e As EventArgs) Handles chkFps.CheckedChanged
        frmPaint.pbcCanvas.EnableDebugInfo(chkFps.Checked)
    End Sub

    'Private Sub chkMouseConsole_CheckedChanged(sender As Object, e As EventArgs) Handles chkMouseConsole.CheckedChanged
    '    If mouseConsole Is Nothing Then
    '        mouseConsole = New InputsToConsole()
    '    End If
    '    If chkMouseConsole.Checked Then
    '        frmPaint.manager.AddMouseListener(mouseConsole)
    '        frmPaint.manager.AddKeyboardListener(mouseConsole)
    '    Else
    '        frmPaint.manager.GetMouseListeners.Remove(mouseConsole)
    '        frmPaint.manager.GetKeyboardListeners.Remove(mouseConsole)
    '    End If
    'End Sub

    Private Sub tmrGame_Tick(sender As Object, e As EventArgs) Handles tmrGame.Tick
        lblScore.Text = Str(frmPaint.manager.GetGame.GetScore()).Trim
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        frmPaint.manager.GetGame.NewGame()
    End Sub

    Protected Friend sendClose As Boolean = True
    Private Sub frmDebug_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If sendClose Then
            sendClose = False
            frmPaint.Close()
        End If
    End Sub

    Private Sub btnGameOver_Click(sender As Object, e As EventArgs) Handles btnGameOver.Click
        frmPaint.manager.GetGame.GameOver()
    End Sub

    Private Sub btnRestartLevel_Click(sender As Object, e As EventArgs) Handles btnRestartLevel.Click
        frmPaint.manager.GetGame.RestartLevel()
    End Sub
End Class