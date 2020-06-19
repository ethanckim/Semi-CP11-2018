Public Class frmRealHobbies
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        frmHobbies.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBusan.Click
        frmBusan.Show()
    End Sub
End Class