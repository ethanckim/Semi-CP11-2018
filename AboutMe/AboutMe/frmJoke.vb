Public Class frmJoke
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAnswer1.Click
        MessageBox.Show("Engineers", "Answer")
    End Sub

    Private Sub btnAnswer2_Click(sender As Object, e As EventArgs) Handles btnAnswer2.Click
        MessageBox.Show("Curr-ea", "Answer")
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub btnAnswer3_Click(sender As Object, e As EventArgs) Handles btnAnswer3.Click
        MessageBox.Show("Guardians of the Galaxy", "Answer")
    End Sub

    Private Sub btnAnswer4_Click(sender As Object, e As EventArgs) Handles btnAnswer4.Click
        MessageBox.Show("Definitely... Gill Sans  ͡° ͜ʖ ͡°", "Answer")
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
    End Sub
End Class