<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecipt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblOranges = New System.Windows.Forms.Label()
        Me.txtOrangeAmount = New System.Windows.Forms.TextBox()
        Me.txtOrangePrice = New System.Windows.Forms.TextBox()
        Me.lblAt1 = New System.Windows.Forms.Label()
        Me.lblEach1 = New System.Windows.Forms.Label()
        Me.chkTaxInput = New System.Windows.Forms.CheckBox()
        Me.txtOrangeTotal = New System.Windows.Forms.TextBox()
        Me.txtMandarinsTotal = New System.Windows.Forms.TextBox()
        Me.lblEach2 = New System.Windows.Forms.Label()
        Me.lblAt2 = New System.Windows.Forms.Label()
        Me.txtMandarinPrice = New System.Windows.Forms.TextBox()
        Me.txtMandarinAmount = New System.Windows.Forms.TextBox()
        Me.lblMandarins = New System.Windows.Forms.Label()
        Me.txtOJTotal = New System.Windows.Forms.TextBox()
        Me.lblEach3 = New System.Windows.Forms.Label()
        Me.lblAt3 = New System.Windows.Forms.Label()
        Me.txtOJPrice = New System.Windows.Forms.TextBox()
        Me.txtOJAmount = New System.Windows.Forms.TextBox()
        Me.lblOJ = New System.Windows.Forms.Label()
        Me.txtTaxInput = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.lblDollars = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTaxOutput = New System.Windows.Forms.Label()
        Me.txtTaxOutput = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblOranges
        '
        Me.lblOranges.AutoSize = True
        Me.lblOranges.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOranges.Location = New System.Drawing.Point(24, 15)
        Me.lblOranges.Name = "lblOranges"
        Me.lblOranges.Size = New System.Drawing.Size(90, 24)
        Me.lblOranges.TabIndex = 3
        Me.lblOranges.Text = "Oranges"
        '
        'txtOrangeAmount
        '
        Me.txtOrangeAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrangeAmount.Location = New System.Drawing.Point(28, 51)
        Me.txtOrangeAmount.Name = "txtOrangeAmount"
        Me.txtOrangeAmount.Size = New System.Drawing.Size(74, 22)
        Me.txtOrangeAmount.TabIndex = 1
        Me.txtOrangeAmount.Text = "0"
        '
        'txtOrangePrice
        '
        Me.txtOrangePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrangePrice.Location = New System.Drawing.Point(136, 51)
        Me.txtOrangePrice.Name = "txtOrangePrice"
        Me.txtOrangePrice.Size = New System.Drawing.Size(74, 22)
        Me.txtOrangePrice.TabIndex = 1
        Me.txtOrangePrice.Text = "1.19"
        Me.txtOrangePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAt1
        '
        Me.lblAt1.AutoSize = True
        Me.lblAt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAt1.Location = New System.Drawing.Point(108, 51)
        Me.lblAt1.Name = "lblAt1"
        Me.lblAt1.Size = New System.Drawing.Size(22, 16)
        Me.lblAt1.TabIndex = 3
        Me.lblAt1.Text = "@"
        '
        'lblEach1
        '
        Me.lblEach1.AutoSize = True
        Me.lblEach1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEach1.Location = New System.Drawing.Point(216, 52)
        Me.lblEach1.Name = "lblEach1"
        Me.lblEach1.Size = New System.Drawing.Size(56, 16)
        Me.lblEach1.TabIndex = 3
        Me.lblEach1.Text = "/Each = "
        '
        'chkTaxInput
        '
        Me.chkTaxInput.AutoSize = True
        Me.chkTaxInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTaxInput.Location = New System.Drawing.Point(64, 256)
        Me.chkTaxInput.Name = "chkTaxInput"
        Me.chkTaxInput.Size = New System.Drawing.Size(50, 20)
        Me.chkTaxInput.TabIndex = 1
        Me.chkTaxInput.Text = "Tax"
        Me.chkTaxInput.UseVisualStyleBackColor = True
        '
        'txtOrangeTotal
        '
        Me.txtOrangeTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrangeTotal.Location = New System.Drawing.Point(287, 51)
        Me.txtOrangeTotal.Name = "txtOrangeTotal"
        Me.txtOrangeTotal.Size = New System.Drawing.Size(74, 22)
        Me.txtOrangeTotal.TabIndex = 2
        '
        'txtMandarinsTotal
        '
        Me.txtMandarinsTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMandarinsTotal.Location = New System.Drawing.Point(287, 132)
        Me.txtMandarinsTotal.Name = "txtMandarinsTotal"
        Me.txtMandarinsTotal.Size = New System.Drawing.Size(74, 22)
        Me.txtMandarinsTotal.TabIndex = 2
        '
        'lblEach2
        '
        Me.lblEach2.AutoSize = True
        Me.lblEach2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEach2.Location = New System.Drawing.Point(216, 133)
        Me.lblEach2.Name = "lblEach2"
        Me.lblEach2.Size = New System.Drawing.Size(56, 16)
        Me.lblEach2.TabIndex = 3
        Me.lblEach2.Text = "/Each = "
        '
        'lblAt2
        '
        Me.lblAt2.AutoSize = True
        Me.lblAt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAt2.Location = New System.Drawing.Point(108, 132)
        Me.lblAt2.Name = "lblAt2"
        Me.lblAt2.Size = New System.Drawing.Size(22, 16)
        Me.lblAt2.TabIndex = 3
        Me.lblAt2.Text = "@"
        '
        'txtMandarinPrice
        '
        Me.txtMandarinPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMandarinPrice.Location = New System.Drawing.Point(136, 132)
        Me.txtMandarinPrice.Name = "txtMandarinPrice"
        Me.txtMandarinPrice.Size = New System.Drawing.Size(74, 22)
        Me.txtMandarinPrice.TabIndex = 1
        Me.txtMandarinPrice.Text = "0.35"
        Me.txtMandarinPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMandarinAmount
        '
        Me.txtMandarinAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMandarinAmount.Location = New System.Drawing.Point(28, 132)
        Me.txtMandarinAmount.Name = "txtMandarinAmount"
        Me.txtMandarinAmount.Size = New System.Drawing.Size(74, 22)
        Me.txtMandarinAmount.TabIndex = 1
        Me.txtMandarinAmount.Text = "0"
        '
        'lblMandarins
        '
        Me.lblMandarins.AutoSize = True
        Me.lblMandarins.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMandarins.Location = New System.Drawing.Point(24, 96)
        Me.lblMandarins.Name = "lblMandarins"
        Me.lblMandarins.Size = New System.Drawing.Size(112, 24)
        Me.lblMandarins.TabIndex = 3
        Me.lblMandarins.Text = "Mandarins"
        '
        'txtOJTotal
        '
        Me.txtOJTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOJTotal.Location = New System.Drawing.Point(287, 211)
        Me.txtOJTotal.Name = "txtOJTotal"
        Me.txtOJTotal.Size = New System.Drawing.Size(74, 22)
        Me.txtOJTotal.TabIndex = 2
        '
        'lblEach3
        '
        Me.lblEach3.AutoSize = True
        Me.lblEach3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEach3.Location = New System.Drawing.Point(216, 212)
        Me.lblEach3.Name = "lblEach3"
        Me.lblEach3.Size = New System.Drawing.Size(56, 16)
        Me.lblEach3.TabIndex = 3
        Me.lblEach3.Text = "/Each = "
        '
        'lblAt3
        '
        Me.lblAt3.AutoSize = True
        Me.lblAt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAt3.Location = New System.Drawing.Point(108, 211)
        Me.lblAt3.Name = "lblAt3"
        Me.lblAt3.Size = New System.Drawing.Size(22, 16)
        Me.lblAt3.TabIndex = 3
        Me.lblAt3.Text = "@"
        '
        'txtOJPrice
        '
        Me.txtOJPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOJPrice.Location = New System.Drawing.Point(136, 211)
        Me.txtOJPrice.Name = "txtOJPrice"
        Me.txtOJPrice.Size = New System.Drawing.Size(74, 22)
        Me.txtOJPrice.TabIndex = 1
        Me.txtOJPrice.Text = "3.99"
        Me.txtOJPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOJAmount
        '
        Me.txtOJAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOJAmount.Location = New System.Drawing.Point(28, 211)
        Me.txtOJAmount.Name = "txtOJAmount"
        Me.txtOJAmount.Size = New System.Drawing.Size(74, 22)
        Me.txtOJAmount.TabIndex = 1
        Me.txtOJAmount.Text = "0"
        '
        'lblOJ
        '
        Me.lblOJ.AutoSize = True
        Me.lblOJ.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOJ.Location = New System.Drawing.Point(24, 175)
        Me.lblOJ.Name = "lblOJ"
        Me.lblOJ.Size = New System.Drawing.Size(135, 24)
        Me.lblOJ.TabIndex = 3
        Me.lblOJ.Text = "Orange Juice"
        '
        'txtTaxInput
        '
        Me.txtTaxInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaxInput.Location = New System.Drawing.Point(120, 254)
        Me.txtTaxInput.Name = "txtTaxInput"
        Me.txtTaxInput.Size = New System.Drawing.Size(37, 22)
        Me.txtTaxInput.TabIndex = 1
        Me.txtTaxInput.Text = "5"
        Me.txtTaxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(64, 294)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(272, 34)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate Total"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(199, 346)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(112, 22)
        Me.txtSubTotal.TabIndex = 2
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent.Location = New System.Drawing.Point(161, 257)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(20, 16)
        Me.lblPercent.TabIndex = 3
        Me.lblPercent.Text = "%"
        '
        'lblDollars
        '
        Me.lblDollars.AutoSize = True
        Me.lblDollars.BackColor = System.Drawing.Color.White
        Me.lblDollars.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDollars.Location = New System.Drawing.Point(139, 54)
        Me.lblDollars.Name = "lblDollars"
        Me.lblDollars.Size = New System.Drawing.Size(15, 16)
        Me.lblDollars.TabIndex = 3
        Me.lblDollars.Text = "$"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(139, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "$"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(139, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "$"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(78, 348)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(73, 16)
        Me.lblSubtotal.TabIndex = 3
        Me.lblSubtotal.Text = "Subtotal :"
        '
        'lblTaxOutput
        '
        Me.lblTaxOutput.AutoSize = True
        Me.lblTaxOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxOutput.Location = New System.Drawing.Point(78, 382)
        Me.lblTaxOutput.Name = "lblTaxOutput"
        Me.lblTaxOutput.Size = New System.Drawing.Size(42, 16)
        Me.lblTaxOutput.TabIndex = 3
        Me.lblTaxOutput.Text = "Tax :"
        Me.lblTaxOutput.Visible = False
        '
        'txtTaxOutput
        '
        Me.txtTaxOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaxOutput.Location = New System.Drawing.Point(199, 379)
        Me.txtTaxOutput.Name = "txtTaxOutput"
        Me.txtTaxOutput.Size = New System.Drawing.Size(112, 22)
        Me.txtTaxOutput.TabIndex = 2
        Me.txtTaxOutput.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(78, 416)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(52, 16)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "Total :"
        Me.lblTotal.Visible = False
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(199, 412)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(112, 22)
        Me.txtTotal.TabIndex = 2
        Me.txtTotal.Visible = False
        '
        'frmRecipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 456)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtTaxOutput)
        Me.Controls.Add(Me.lblTaxOutput)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDollars)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtTaxInput)
        Me.Controls.Add(Me.txtOJTotal)
        Me.Controls.Add(Me.lblEach3)
        Me.Controls.Add(Me.lblAt3)
        Me.Controls.Add(Me.txtOJPrice)
        Me.Controls.Add(Me.txtOJAmount)
        Me.Controls.Add(Me.lblOJ)
        Me.Controls.Add(Me.txtMandarinsTotal)
        Me.Controls.Add(Me.lblEach2)
        Me.Controls.Add(Me.lblAt2)
        Me.Controls.Add(Me.txtMandarinPrice)
        Me.Controls.Add(Me.txtMandarinAmount)
        Me.Controls.Add(Me.lblMandarins)
        Me.Controls.Add(Me.txtOrangeTotal)
        Me.Controls.Add(Me.chkTaxInput)
        Me.Controls.Add(Me.lblEach1)
        Me.Controls.Add(Me.lblAt1)
        Me.Controls.Add(Me.txtOrangePrice)
        Me.Controls.Add(Me.txtOrangeAmount)
        Me.Controls.Add(Me.lblOranges)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmRecipt"
        Me.Text = "Billy's Orange Market"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOranges As Label
    Friend WithEvents txtOrangeAmount As TextBox
    Friend WithEvents txtOrangePrice As TextBox
    Friend WithEvents lblAt1 As Label
    Friend WithEvents lblEach1 As Label
    Friend WithEvents chkTaxInput As CheckBox
    Friend WithEvents txtOrangeTotal As TextBox
    Friend WithEvents txtMandarinsTotal As TextBox
    Friend WithEvents lblEach2 As Label
    Friend WithEvents lblAt2 As Label
    Friend WithEvents txtMandarinPrice As TextBox
    Friend WithEvents txtMandarinAmount As TextBox
    Friend WithEvents lblMandarins As Label
    Friend WithEvents txtOJTotal As TextBox
    Friend WithEvents lblEach3 As Label
    Friend WithEvents lblAt3 As Label
    Friend WithEvents txtOJPrice As TextBox
    Friend WithEvents txtOJAmount As TextBox
    Friend WithEvents lblOJ As Label
    Friend WithEvents txtTaxInput As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents lblPercent As Label
    Friend WithEvents lblDollars As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTaxOutput As Label
    Friend WithEvents txtTaxOutput As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox
End Class
