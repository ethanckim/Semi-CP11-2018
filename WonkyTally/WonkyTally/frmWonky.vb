Public Class frmWonky
    Dim Values(5) As Integer
    Dim Buttons(5) As Button
    Dim Total As Integer
    Dim r As System.Random

    Private Sub Increase(i As Integer)
        Total += Values(i)
        txtCurrent.Text = Str(Total)
        Values(i) = r.Next(-10, 11)
        Buttons(i).Text = Str(Values(i))
        Update(i)
    End Sub

    Private Sub Update(i As Integer)
        Values(i) = r.Next(-10, 11)
        Buttons(i).Text = Str(Values(i))
    End Sub

    Private Sub tmrRandomizer_Tick(sender As Object, e As EventArgs) Handles tmrRandomizer.Tick

        Dim j As Integer = r.Next(0, 6)
        Update(j)

        Dim k As Integer = 0
        Dim FoundZero As Boolean = False
        While k < Values.Count

            If Values(k) = 0 Then
                FoundZero = True
            End If

            k += 1
        End While

        If FoundZero = False Then
            tmrRandomizer.Enabled = False
        End If
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        Increase(0)
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        Increase(1)
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        Increase(2)
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        Increase(3)
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        Increase(4)
    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        Increase(5)
    End Sub

    Private Sub frmWonky_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        r = New System.Random()
        Buttons(0) = btnA
        Buttons(1) = btnB
        Buttons(2) = btnC
        Buttons(3) = btnD
        Buttons(4) = btnE
        Buttons(5) = btnF
    End Sub

    Private Sub btnRerandomize_Click(sender As Object, e As EventArgs) Handles btnRerandomize.Click
        Values(0) = 0
        Values(1) = 0
        Values(2) = 0
        Values(3) = 0
        Values(4) = 0
        Values(5) = 0
        Buttons(0).Text = "-"
        Buttons(1).Text = "-"
        Buttons(2).Text = "-"
        Buttons(3).Text = "-"
        Buttons(4).Text = "-"
        Buttons(5).Text = "-"

        tmrRandomizer.Enabled = True
    End Sub
End Class
