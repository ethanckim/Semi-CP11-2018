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
        lblBSCount.Text = Str(frmPaint.manager.GetGame.GetBSScore()).Trim
        lblRCount.Text = Str(frmPaint.manager.GetGame.GetRScore()).Trim
        If frmPaint.manager.GetGame.Perfect = True Then
            picPerfect.Visible = True
        Else
            picPerfect.Visible = False
        End If
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        frmPaint.manager.GetGame.NewGame()
        frmPaint.manager.GetGame.Animation_Cooldown = 6
    End Sub

    Protected Friend sendClose As Boolean = True
    Private Sub frmDebug_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If sendClose Then
            sendClose = False
            frmPaint.Close()
        End If
    End Sub

    Private Sub btnGameOver_Click(sender As Object, e As EventArgs)
        frmPaint.manager.GetGame.GameOver()
    End Sub

    Private Sub btnRestartLevel_Click(sender As Object, e As EventArgs) Handles btnRestartLevel.Click
        frmPaint.manager.GetGame.RestartLevel()
        frmPaint.manager.GetGame.Animation_Cooldown = 6
    End Sub

    Private Sub btnCamUp_Click(sender As Object, e As EventArgs) Handles btnCamUp.Click
        frmPaint.manager.GetGame.MoveCam(Direction.Up)
    End Sub

    Private Sub btnCamRight_Click(sender As Object, e As EventArgs) Handles btnCamRight.Click
        frmPaint.manager.GetGame.MoveCam(Direction.Right)
    End Sub

    Private Sub btnCamDown_Click(sender As Object, e As EventArgs) Handles btnCamDown.Click
        frmPaint.manager.GetGame.MoveCam(Direction.Down)
    End Sub

    Private Sub btnCamLeft_Click(sender As Object, e As EventArgs) Handles btnCamLeft.Click
        frmPaint.manager.GetGame.MoveCam(Direction.Left)
    End Sub

End Class