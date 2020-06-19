Public Class frmShapeList

    'Dim Current As Shape2D
    Dim Shapes As List(Of Shape2D)

    Private Sub frmShapeList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Shapes = New List(Of Shape2D)
    End Sub

    Private Sub btnAddRec_Click(sender As Object, e As EventArgs) Handles btnAddRec.Click
        Dim r As Rectangle2D
        Try
            r = New Rectangle2D(CDec(txtRecL.Text), CDec(txtRecW.Text))
        Catch ex As InvalidDimensionException
            MessageBox.Show("Please type in valid numbers" + vbCrLf + "(No 0 or Negative numbers)", "Warning")
            Exit Sub
        Catch ex As InvalidCastException
            MessageBox.Show("Please type in Numbers", "Warning")
            Exit Sub
        End Try


        'Current = r
        Shapes.Add(r)
        ShowAreaAndPreimeterInTheTextBox()

        txtRecL.Text = "0"
        txtRecW.Text = "0"

    End Sub

    Private Sub btnAddCcl_Click(sender As Object, e As EventArgs) Handles btnAddCcl.Click
        Dim c As Circle2D
        Try
            c = New Circle2D(CDec(txtCclR.Text))
        Catch ex As InvalidDimensionException
            MessageBox.Show("Please type in valid numbers" + vbCrLf + "(No 0 or Negative numbers)", "Warning")
            Exit Sub
        Catch ex As InvalidCastException
            MessageBox.Show("Please type in Numbers", "Warning")
            Exit Sub
        End Try


        'Current = c
        Shapes.Add(c)
        ShowAreaAndPreimeterInTheTextBox()

        txtCclR.Text = "0"

    End Sub

    Private Sub btnAddTri_Click(sender As Object, e As EventArgs) Handles btnAddTri.Click
        Dim t As RightTriangle2D
        Try
            t = New RightTriangle2D(CDec(txtTriB.Text), CDec(txtTriH.Text))
        Catch ex As InvalidDimensionException
            MessageBox.Show("Please type in valid numbers" + vbCrLf + "(No 0 or Negative numbers)", "Warning")
            Exit Sub
        Catch ex As InvalidCastException
            MessageBox.Show("Please type in Numbers", "Warning")
            Exit Sub
        End Try


        'Current = t
        Shapes.Add(t)
        ShowAreaAndPreimeterInTheTextBox()

        txtTriB.Text = "0"
        txtTriH.Text = "0"

    End Sub

    Private Sub ShowAreaAndPreimeterInTheTextBox()
        txtOutput.Text = ""

        Dim totalArea As Decimal
        Dim totalPerimeter As Decimal

        Dim MaxArea As Decimal
        Dim MinArea As Decimal
        Dim MaxPremeter As Decimal
        Dim MinPremeter As Decimal

        Dim i As Integer
        While i < Shapes.Count
            Dim Current As Shape2D
            Current = Shapes(i)
            Dim Previous As Shape2D
            Try
                Previous = Shapes(i - 1)
            Catch ex As ArgumentOutOfRangeException
                Previous = Shapes(0)
            End Try


            txtOutput.Text += "Type: " + Current.GetShapeType + vbCrLf
            txtOutput.Text += "Area: " + Str(Current.GetArea) + vbCrLf
            txtOutput.Text += "Preimeter: " + Str(Current.GetPreimeter) + vbCrLf
            txtOutput.Text += Current.GetDimensions + vbCrLf
            txtOutput.Text += vbCrLf

            totalArea += Current.GetArea
            totalPerimeter += Current.GetPreimeter

            'Max and Min Area and Peremeter
            If Current.GetArea >= Previous.GetArea Then
                MaxArea = Current.GetArea
            End If
            If Current.GetArea <= Previous.GetArea Then
                MinArea = Current.GetArea
            End If
            If Current.GetPreimeter >= Previous.GetPreimeter Then
                MaxPremeter = Current.GetPreimeter
            End If
            If Current.GetPreimeter <= Previous.GetPreimeter Then
                MinPremeter = Current.GetPreimeter
            End If

            i += 1
        End While

        txtOutput.Text += "Maximum Area: " + Str(MaxArea) + vbCrLf
        txtOutput.Text += "Minimum Area: " + Str(MinArea) + vbCrLf
        txtOutput.Text += "Maximum Premeter: " + Str(MaxPremeter) + vbCrLf
        txtOutput.Text += "Minimum Premeter: " + Str(MinPremeter) + vbCrLf
        txtOutput.Text += vbCrLf

        Try
            txtOutput.Text += "Total Area: " + Str(totalArea) + vbCrLf
            txtOutput.Text += "Total Premeter: " + Str(totalPerimeter) + vbCrLf
            txtOutput.Text += "Average Area: " + Str(totalArea / Shapes.Count) + vbCrLf
            txtOutput.Text += "Average Premeter: " + Str(totalPerimeter / Shapes.Count) + vbCrLf
        Catch e As DivideByZeroException
            txtOutput.Text += "Average Area:  0" + vbCrLf
            txtOutput.Text += "Average Premeter:  0" + vbCrLf
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Shapes.Clear()
        ShowAreaAndPreimeterInTheTextBox()
    End Sub

End Class
