Public Class frmHome
    Private Sub btnHobbies_Click(sender As Object, e As EventArgs) Handles btnHobbies.Click
        frmHobbies.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btnJoke_Click(sender As Object, e As EventArgs) Handles btnJoke.Click
        frmJoke.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do you really want to quit?", "Quit", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            End
        End If
    End Sub
End Class
