Imports System.ComponentModel

Public Class frmWelcome

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        frmPaint.Show()
        frmPaint.manager.GetGame.ChangeLevel(1)
        Me.Hide()
    End Sub

    Private Sub frmWelcome_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        My.Computer.Audio.Play("\\semi-fs2\semi-studenthome\ethanc.kim\CP11\FinalGameProject\FinalGameProject\Music\NoWay.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub frmWelcome_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            My.Computer.Audio.Play("\\semi-fs2\semi-studenthome\ethanc.kim\CP11\FinalGameProject\FinalGameProject\Music\NoWay.wav", AudioPlayMode.BackgroundLoop)

            'If frmPaint.manager.GetGame.BeatGame = True Then
            'MessageBox.Show("Thank you for Playing Blue Spheres 2D!" + vbCrLf + "Credits: Ethan Kim", "Congradulations!")
            'frmPaint.manager.GetGame.BeatGame = False
            'End If
        End If
    End Sub

    Private Sub frmWelcome_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Computer.Audio.Stop()
    End Sub

    Private Sub btnJump_Click(sender As Object, e As EventArgs) Handles btnJump.Click

        Try
            If Int(txtLevel.Text) > 3 Or Int(txtLevel.Text) < 1 Then
                MessageBox.Show("Give a valid Level Number", "Warning")
                Exit Sub
            End If
        Catch ex As InvalidCastException
            MessageBox.Show("Give a valid Level Number", "Alert")
            Exit Sub
        End Try

        frmPaint.Show()
        frmPaint.manager.GetGame.ChangeLevel(txtLevel.Text.Trim)
        Me.Hide()
    End Sub

    Private Sub btnInstructions_Click(sender As Object, e As EventArgs) Handles btnInstructions.Click
        frmInstructions.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        MessageBox.Show("Not Currently Available", "Alert")
    End Sub
End Class