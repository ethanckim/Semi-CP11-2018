Public Class frmRecipt

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim OrangeAmount As Integer
        Dim OrangePrice As Decimal
        Dim MandarinAmount As Integer
        Dim MandarinPrice As Decimal
        Dim OJAmount As Integer
        Dim OJPrice As Decimal

        'Getting values from the UI
        'The command CInt converts a String(Ex. "5") to an Integer(Ex. 5)
        OrangeAmount = CInt(txtOrangeAmount.Text)
        MandarinAmount = CInt(txtMandarinAmount.Text)
        OJAmount = CInt(txtOJAmount.Text)
        'The command CDec converts a String(Ex. "3") to a Decimal(Ex. 3.0)
        OrangePrice = CDec(txtOrangePrice.Text)
        MandarinPrice = CDec(txtMandarinPrice.Text)
        OJPrice = CDec(txtOJPrice.Text)


        Dim OrangeOverall As Decimal
        Dim MandarinOverall As Decimal
        Dim OJOverall As Decimal
        OrangeOverall = OrangeAmount * OrangePrice
        MandarinOverall = MandarinAmount * MandarinPrice
        OJOverall = OJAmount * OJPrice

        'Makes a string into $0.00 Format
        txtOrangeTotal.Text = FormatCurrency(OrangeOverall)
        txtMandarinsTotal.Text = FormatCurrency(MandarinOverall)
        txtOJTotal.Text = FormatCurrency(OJOverall)

        Dim SubTotal As Decimal
        SubTotal = OrangeOverall + MandarinOverall + OJOverall
        txtSubTotal.Text = FormatCurrency(SubTotal)

        lblTaxOutput.Visible = False
        txtTaxOutput.Visible = False
        lblTotal.Visible = False
        txtTotal.Visible = False

        If chkTaxInput.Checked Then
            Dim TaxInput As Decimal
            Dim TaxOutput As Decimal

            TaxInput = CInt(txtTaxInput.Text)
            TaxOutput = SubTotal / 100 * TaxInput
            txtTaxOutput.Text = FormatCurrency(TaxOutput)

            Dim Total As Decimal
            Total = SubTotal + TaxOutput
            txtTotal.Text = FormatCurrency(Total)

            lblTaxOutput.Visible = True
            txtTaxOutput.Visible = True
            lblTotal.Visible = True
            txtTotal.Visible = True
        End If
    End Sub
End Class
