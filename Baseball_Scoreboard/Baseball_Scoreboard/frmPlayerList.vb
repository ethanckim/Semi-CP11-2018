Public Class frmPlayerList

    Public PlayOrder(18) As Integer

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            PlayOrder(0) = 1
            PlayOrder(1) = txtAway1.Text
            PlayOrder(2) = txtAway2.Text
            PlayOrder(3) = txtAway3.Text
            PlayOrder(4) = txtAway4.Text
            PlayOrder(5) = txtAway5.Text
            PlayOrder(6) = txtAway6.Text
            PlayOrder(7) = txtAway7.Text
            PlayOrder(8) = txtAway8.Text
            PlayOrder(9) = txtAway9.Text
            PlayOrder(10) = txtHome1.Text
            PlayOrder(11) = txtHome2.Text
            PlayOrder(12) = txtHome3.Text
            PlayOrder(13) = txtHome4.Text
            PlayOrder(14) = txtHome5.Text
            PlayOrder(15) = txtHome6.Text
            PlayOrder(16) = txtHome7.Text
            PlayOrder(17) = txtHome8.Text
            PlayOrder(18) = txtHome9.Text
            frmBaseballScoreboard.txtLog.Text += "The Player Order is Assigned. The game will begin." + vbCrLf + "Inning 1 begins." + vbCrLf
            frmBaseballScoreboard.txtPlayerNumber.Text = PlayOrder(1)
            frmBaseballScoreboard.btnBall.Enabled = True
            frmBaseballScoreboard.btnHit.Enabled = True
            frmBaseballScoreboard.btnStrike.Enabled = True
            frmBaseballScoreboard.ResetTmr(0)
            frmBaseballScoreboard.Inning += 1
            Me.Hide()
            frmBaseballScoreboard.EnableOrNotButtons()
        Catch err As InvalidCastException
            MessageBox.Show("Write down the list with no blanks", "Error")
        End Try
    End Sub
End Class