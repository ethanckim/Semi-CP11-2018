Public Class ItMightBePaint

    Dim imgFront As Image
    Dim imgBack As Image
    Dim imgComplete As Image
    Dim gfxFront As Graphics
    Dim gfxBack As Graphics
    Dim gfxComplete As Graphics

    Dim SaveMouseX As Integer
    Dim SaveMouseY As Integer
    Dim SavedClick As Boolean = False

    Dim ButtonsDown As Integer
    Dim Trebuchet As Font

    Dim cFG As Color
    Dim bFG As Brush
    Dim pFG As Pen

    Dim cBG As Color
    Dim bBG As Brush
    Dim pBG As Pen

    Private Sub ItMightBePaint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imgFront = New Bitmap(pnlCanvas.Width, pnlCanvas.Height)
        gfxFront = Graphics.FromImage(imgFront)
        gfxFront.FillRectangle(Brushes.White, 0, 0, pnlCanvas.Width, pnlCanvas.Height)

        imgBack = New Bitmap(pnlCanvas.Width, pnlCanvas.Height)
        gfxBack = Graphics.FromImage(imgBack)
        gfxBack.FillRectangle(Brushes.White, 0, 0, pnlCanvas.Width, pnlCanvas.Height)

        imgComplete = New Bitmap(pnlCanvas.Width, pnlCanvas.Height)
        gfxComplete = Graphics.FromImage(imgComplete)
        gfxComplete.FillRectangle(Brushes.White, 0, 0, pnlCanvas.Width, pnlCanvas.Height)

        bFG = New SolidBrush(Color.Black)
        pFG = New Pen(Color.Black)
        bBG = New SolidBrush(Color.Black)
    End Sub

    Private Sub Swap()
        Dim imgTemp As Image
        Dim gfxTemp As Graphics

        imgTemp = imgFront
        gfxTemp = gfxFront

        imgFront = imgBack
        gfxFront = gfxBack

        imgBack = imgTemp
        gfxBack = gfxTemp

        gfxBack.DrawImage(imgFront, 0, 0)

    End Sub

    Private Sub radPencil_CheckedChanged(sender As Object, e As EventArgs) Handles radPencil.CheckedChanged
        If radPencil.Checked Then
            chkDrag.Checked = True
        Else
            chkDrag.Checked = False
        End If

    End Sub

    Private Sub radEraser_CheckedChanged(sender As Object, e As EventArgs) Handles radEraser.CheckedChanged
        If radEraser.Checked Then
            chkDrag.Checked = True
        Else
            chkDrag.Checked = False
        End If

    End Sub

    Private Sub radCircle_CheckedChanged(sender As Object, e As EventArgs) Handles radCircle.CheckedChanged
        If radCircle.Checked = True Then
            chkDrag.Checked = False
            chkDrag.Enabled = False
        Else
            SavedClick = False
            pnlCanvas.Refresh()
            chkDrag.Enabled = True
        End If

    End Sub

    Private Sub radLine_CheckedChanged(sender As Object, e As EventArgs) Handles radLine.CheckedChanged
        If radLine.Checked = True Then
            chkDrag.Checked = False
            chkDrag.Enabled = False
        Else
            SavedClick = False
            pnlCanvas.Refresh()
            chkDrag.Enabled = True
        End If

    End Sub

    Private Sub pnlCanvas_Paint(sender As Object, e As PaintEventArgs) Handles pnlCanvas.Paint
        Swap()
        e.Graphics.DrawImage(imgFront, 0, 0)

    End Sub

    Private Sub pnlCanvas_MouseClick(sender As Object, e As MouseEventArgs) Handles pnlCanvas.MouseClick
        Drawing(e)

    End Sub

    Private Sub pnlCanvas_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlCanvas.MouseDown
        'Which mouse button did you press?
        ButtonsDown = e.Button

        'Save Mouse X and Y
        SavedClick = True
        SaveMouseX = e.X
        SaveMouseY = e.Y

        'Save a copy of the Back buffer into the complete buffer
        gfxComplete.DrawImage(imgBack, 0, 0)


    End Sub

    Private Sub pnlCanvas_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlCanvas.MouseMove
        If ButtonsDown > 0 Then

            If radLine.Checked Then
                gfxBack.DrawImage(imgComplete, 0, 0)
                Drawing(e)
            End If

            If radCircle.Checked Then
                gfxBack.DrawImage(imgComplete, 0, 0)
                Drawing(e)
            End If

            If chkDrag.Checked Then
                Drawing(e)
            End If

        End If

    End Sub

    Private Sub pnlCanvas_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlCanvas.MouseUp
        ButtonsDown = 0

        If SavedClick = True Then
            If radLine.Checked = True Then
                gfxBack.DrawImage(imgComplete, 0, 0)
                gfxBack.DrawLine(pFG, SaveMouseX, SaveMouseY, e.X, e.Y)

            ElseIf radCircle.Checked = True Then
                gfxBack.DrawImage(imgComplete, 0, 0)

                Dim Radius As Single
                Radius = Math.Sqrt(Math.Pow(SaveMouseX - e.X, 2) + Math.Pow(SaveMouseY - e.Y, 2))

                gfxBack.DrawEllipse(pFG, SaveMouseX - Radius, SaveMouseX - Radius, Radius * 2, Radius * 2)

            End If

        End If

        SavedClick = False

    End Sub

    Private Sub Drawing(e As MouseEventArgs)

        If radPencil.Checked Then
            gfxBack.FillEllipse(bFG, e.X, e.Y, spinSize.Value, spinSize.Value)

        ElseIf radText.Checked Then
            Trebuchet = New Font("Trebuchet MS", spinSize.Value + 8)
            gfxBack.DrawString(txtText.Text, Trebuchet, bFG, e.X, e.Y)

        ElseIf radCircle.Checked Then
            Dim Radius As Single
            Radius = Math.Sqrt(Math.Pow(SaveMouseX - e.X, 2) + Math.Pow(SaveMouseY - e.Y, 2))

            pFG.Width = spinSize.Value
            gfxBack.DrawEllipse(pFG, SaveMouseX - Radius, SaveMouseX - Radius, Radius * 2, Radius * 2)

        ElseIf radLine.Checked Then
            pFG.Width = spinSize.Value
            gfxBack.DrawLine(pFG, SaveMouseX, SaveMouseY, e.X, e.Y)

        Else
            gfxBack.FillEllipse(Brushes.White, e.X, e.Y, spinSize.Value + 10, spinSize.Value + 10)

        End If

        pnlCanvas.Refresh()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        gfxBack.FillRectangle(Brushes.White, 0, 0, pnlCanvas.Width, pnlCanvas.Height)
        pnlCanvas.Refresh()

    End Sub

    Private Sub btnFill_Click(sender As Object, e As EventArgs) Handles btnFill.Click
        If radFG.Checked = True Then
            gfxBack.FillRectangle(bFG, 0, 0, pnlCanvas.Width, pnlCanvas.Height)
        Else
            gfxBack.FillRectangle(bBG, 0, 0, pnlCanvas.Width, pnlCanvas.Height)
        End If

        pnlCanvas.Refresh()

    End Sub


    Private Sub updateColor()

        If radFG.Checked = True Then
            cFG = Color.FromArgb(sclR.Value, sclG.Value, sclB.Value)
            bFG = New SolidBrush(cFG)
            pFG = New Pen(cFG)

            btnFGColor.BackColor = cFG
        Else
            cBG = Color.FromArgb(sclR.Value, sclG.Value, sclB.Value)
            bBG = New SolidBrush(cBG)
            pBG = New Pen(cBG)

            btnBGColor.BackColor = cBG
        End If


    End Sub

    Private Sub sclR_Scroll(sender As Object, e As ScrollEventArgs) Handles sclR.Scroll
        updateColor()
        lblRAmount.Text = Str(sclR.Value)

    End Sub

    Private Sub sclG_Scroll(sender As Object, e As ScrollEventArgs) Handles sclG.Scroll
        updateColor()
        lblGAmount.Text = Str(sclG.Value)

    End Sub

    Private Sub sclB_Scroll(sender As Object, e As ScrollEventArgs) Handles sclB.Scroll
        updateColor()
        lblBAmount.Text = Str(sclB.Value)

    End Sub

    Private Sub tmrRefresh_Tick(sender As Object, e As EventArgs) Handles tmrRefreshfps.Tick
        pnlCanvas.Refresh()
    End Sub

End Class
