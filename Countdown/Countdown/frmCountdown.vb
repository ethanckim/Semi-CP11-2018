Public Class frmCountdown

    Dim seconds As Integer = 5

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        tmrCounter.Enabled = True
    End Sub

    Private Sub tmrCounter_Tick(sender As Object, e As EventArgs) Handles tmrCounter.Tick
        seconds -= 1
        txtSeconds.Text = Str(seconds)
        If seconds = 0 Then
            tmrCounter.Enabled = False
            MessageBox.Show("Time's Up!", "5 Second Countdown")
            seconds = 5
            txtSeconds.Text = "5"
        End If
    End Sub
End Class