Public Class frmHobbies
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBackToHome.Click
        Me.Hide()
    End Sub

    Private Sub frmHobbies_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSuspicious_Click(sender As Object, e As EventArgs) Handles btnSuspicious.Click
        frmRealHobbies.Show()
        Me.Hide()
    End Sub
End Class