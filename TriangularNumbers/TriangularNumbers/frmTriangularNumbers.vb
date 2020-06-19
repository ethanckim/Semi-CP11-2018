Public Class frmTriangularNumbers
    Dim UpTill As Integer = 0
    Dim Current As Long = 0

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtOutput.Text = ""
        Current = 0
        UpTill = txtInput.Text

        Dim i As Integer = 1
        While i <= UpTill
            txtOutput.Text += Str(Current) + " + " + Str(i) + " = "
            Current += i
            txtOutput.Text += Str(Current) + vbCrLf

            i += 1
        End While
    End Sub
End Class
