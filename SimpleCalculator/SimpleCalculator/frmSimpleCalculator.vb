Public Class frmSimpleCalculator
    Dim Current As Decimal = 0
    Dim First As Decimal = 0
    Dim Second As Decimal = 0
    Dim WhichOp As Char = Chr(32)
    Dim DecimalMode As Boolean = False
    Dim DecimalTrack As Decimal = 0.1
    Dim NegativeMode As Boolean = False
    Dim MemMode As Boolean = False
    Dim Memory As Decimal = 0

    Private Sub EnableNums(b As Boolean)
        btn0.Enabled = b
        btn1.Enabled = b
        btn2.Enabled = b
        btn3.Enabled = b
        btn4.Enabled = b
        btn5.Enabled = b
        btn6.Enabled = b
        btn7.Enabled = b
        btn8.Enabled = b
        btn9.Enabled = b
        btnDot.Enabled = b
        btnNegative.Enabled = b
    End Sub

    Private Sub EnableOps(b As Boolean)
        btnMinus.Enabled = b
        btnMultiply.Enabled = b
        btnDivide.Enabled = b
        btnPlus.Enabled = b
        btnPower.Enabled = b
        btnModulo.Enabled = b
    End Sub

    Private Sub ResetDec()
        DecimalMode = False
        DecimalTrack = 0.1
    End Sub

    Private Sub AddNumber(i As Integer)
        Try
            If DecimalMode = True Then
                If i = 0 Then
                    lblOutput.Text += "0"
                    DecimalTrack *= 0.1
                Else
                    Current = Current + (DecimalTrack * i)
                    lblOutput.Text = Current
                    DecimalTrack *= 0.1
                End If
            Else
                Current = Current * 10 + i
                lblOutput.Text = Current
            End If
        Catch e As System.OverflowException
            lblOutput.Text = "Error: Overflow"
            EnableNums(False)
            EnableOps(False)
            btnEquals.Enabled = False
        End Try
    End Sub

    Private Sub Operation(j As Integer)
        CheckNeg()
        lblFirstNumber.Text = Current
        First = Current
        Current = 0
        If j = 0 Then
            WhichOp = Chr(43)
        ElseIf j = 1 Then
            WhichOp = Chr(45)
        ElseIf j = 2 Then
            WhichOp = Chr(120)
        ElseIf j = 3 Then
            WhichOp = Chr(247)
        ElseIf j = 4 Then
            WhichOp = Chr(94)
        Else
            WhichOp = Chr(37)
        End If
        lblOperation.Text = WhichOp
        lblOutput.Text = 0
        ResetDec()
        EnableOps(False)
        btnEquals.Enabled = True
    End Sub

    Private Sub CheckNeg()
        If NegativeMode = True Then
            Current *= -1
        End If
        lblNegative.Visible = False
        NegativeMode = False
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        AddNumber(0)
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        AddNumber(1)
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        AddNumber(2)
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        AddNumber(3)
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        AddNumber(4)
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        AddNumber(5)
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        AddNumber(6)
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        AddNumber(7)
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        AddNumber(8)
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        AddNumber(9)
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        If DecimalMode = False Then
            lblOutput.Text += "."
            DecimalMode = True
        End If

    End Sub

    Private Sub btnNegative_Click(sender As Object, e As EventArgs) Handles btnNegative.Click
        If NegativeMode = False Then
            NegativeMode = True
            lblNegative.Visible = True
        Else
            NegativeMode = False
            lblNegative.Visible = False
        End If
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Operation(0)
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        Operation(1)
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        Operation(2)
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        Operation(3)
    End Sub

    Private Sub btnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click
        Operation(4)
    End Sub

    Private Sub btnModulo_Click(sender As Object, e As EventArgs) Handles btnModulo.Click
        Operation(5)
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        CheckNeg()
        lblEquals.Text = "="
        Second = Current
        lblSecondNumber.Text = Second
        Try
            If WhichOp = Chr(43) Then
                Current = First + Second
            ElseIf WhichOp = Chr(45) Then
                Current = First - Second
            ElseIf WhichOp = Chr(120) Then
                Current = First * Second
            ElseIf WhichOp = Chr(247) Then
                Current = First / Second
            ElseIf WhichOp = Chr(94) Then
                Current = Math.Pow(First, Second)
            Else
                Current = First Mod Second
            End If
            lblOutput.Text = Current
        Catch f As System.DivideByZeroException
            lblOutput.Text = "Error: Divide by 0"
        Catch g As System.OverflowException
            lblOutput.Text = "Error: Overflow"
        End Try
        btnEquals.Enabled = False
        EnableNums(False)
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        lblFirstNumber.Text = " "
        lblSecondNumber.Text = " "
        lblOperation.Text = " "
        lblEquals.Text = " "
        lblOutput.Text = 0
        First = 0
        Second = 0
        Current = 0
        ResetDec()
        NegativeMode = False
        EnableOps(True)
        EnableNums(True)
    End Sub

    Private Sub btnMS_Click(sender As Object, e As EventArgs) Handles btnMS.Click
        Memory = Current
        MemMode = True
        lblMemory.Visible = True
    End Sub

    Private Sub btnMR_Click(sender As Object, e As EventArgs) Handles btnMR.Click
        If MemMode = True Then
            Current = Memory
            lblOutput.Text = Current
        End If
    End Sub

    Private Sub btnMC_Click(sender As Object, e As EventArgs) Handles btnMC.Click
        Current = 0
        MemMode = False
        lblMemory.Visible = False
    End Sub
End Class
