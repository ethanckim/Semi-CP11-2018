<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItMightBePaint
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
        Me.components = New System.ComponentModel.Container()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnFill = New System.Windows.Forms.Button()
        Me.radPencil = New System.Windows.Forms.RadioButton()
        Me.radText = New System.Windows.Forms.RadioButton()
        Me.pnlCanvas = New System.Windows.Forms.Panel()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.sclR = New System.Windows.Forms.HScrollBar()
        Me.lblR = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblG = New System.Windows.Forms.Label()
        Me.sclG = New System.Windows.Forms.HScrollBar()
        Me.sclB = New System.Windows.Forms.HScrollBar()
        Me.btnFGColor = New System.Windows.Forms.Button()
        Me.lblRAmount = New System.Windows.Forms.Label()
        Me.lblGAmount = New System.Windows.Forms.Label()
        Me.lblBAmount = New System.Windows.Forms.Label()
        Me.chkDrag = New System.Windows.Forms.CheckBox()
        Me.lblThick = New System.Windows.Forms.Label()
        Me.spinSize = New System.Windows.Forms.NumericUpDown()
        Me.radCircle = New System.Windows.Forms.RadioButton()
        Me.radEraser = New System.Windows.Forms.RadioButton()
        Me.tmrRefreshfps = New System.Windows.Forms.Timer(Me.components)
        Me.radLine = New System.Windows.Forms.RadioButton()
        Me.btnBGColor = New System.Windows.Forms.Button()
        Me.grpColor = New System.Windows.Forms.GroupBox()
        Me.radFG = New System.Windows.Forms.RadioButton()
        Me.radBG = New System.Windows.Forms.RadioButton()
        CType(Me.spinSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpColor.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(12, 420)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 29)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnFill
        '
        Me.btnFill.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFill.Location = New System.Drawing.Point(12, 385)
        Me.btnFill.Name = "btnFill"
        Me.btnFill.Size = New System.Drawing.Size(82, 29)
        Me.btnFill.TabIndex = 1
        Me.btnFill.Text = "Fill"
        Me.btnFill.UseVisualStyleBackColor = True
        '
        'radPencil
        '
        Me.radPencil.AutoSize = True
        Me.radPencil.Checked = True
        Me.radPencil.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPencil.Location = New System.Drawing.Point(119, 388)
        Me.radPencil.Name = "radPencil"
        Me.radPencil.Size = New System.Drawing.Size(62, 21)
        Me.radPencil.TabIndex = 2
        Me.radPencil.TabStop = True
        Me.radPencil.Text = "Pencil"
        Me.radPencil.UseVisualStyleBackColor = True
        '
        'radText
        '
        Me.radText.AutoSize = True
        Me.radText.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radText.Location = New System.Drawing.Point(119, 420)
        Me.radText.Name = "radText"
        Me.radText.Size = New System.Drawing.Size(52, 21)
        Me.radText.TabIndex = 3
        Me.radText.Text = "Text"
        Me.radText.UseVisualStyleBackColor = True
        '
        'pnlCanvas
        '
        Me.pnlCanvas.BackColor = System.Drawing.Color.White
        Me.pnlCanvas.Cursor = System.Windows.Forms.Cursors.Cross
        Me.pnlCanvas.Location = New System.Drawing.Point(12, 15)
        Me.pnlCanvas.Name = "pnlCanvas"
        Me.pnlCanvas.Size = New System.Drawing.Size(620, 356)
        Me.pnlCanvas.TabIndex = 4
        '
        'txtText
        '
        Me.txtText.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtText.Location = New System.Drawing.Point(174, 420)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(139, 23)
        Me.txtText.TabIndex = 5
        '
        'sclR
        '
        Me.sclR.Location = New System.Drawing.Point(34, 465)
        Me.sclR.Maximum = 255
        Me.sclR.Name = "sclR"
        Me.sclR.Size = New System.Drawing.Size(125, 20)
        Me.sclR.TabIndex = 6
        '
        'lblR
        '
        Me.lblR.AutoSize = True
        Me.lblR.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblR.Location = New System.Drawing.Point(11, 464)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(20, 20)
        Me.lblR.TabIndex = 7
        Me.lblR.Text = "R"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.Location = New System.Drawing.Point(412, 463)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(20, 20)
        Me.lblB.TabIndex = 8
        Me.lblB.Text = "B"
        '
        'lblG
        '
        Me.lblG.AutoSize = True
        Me.lblG.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblG.Location = New System.Drawing.Point(211, 463)
        Me.lblG.Name = "lblG"
        Me.lblG.Size = New System.Drawing.Size(21, 20)
        Me.lblG.TabIndex = 9
        Me.lblG.Text = "G"
        '
        'sclG
        '
        Me.sclG.Location = New System.Drawing.Point(235, 464)
        Me.sclG.Maximum = 255
        Me.sclG.Name = "sclG"
        Me.sclG.Size = New System.Drawing.Size(125, 20)
        Me.sclG.TabIndex = 10
        '
        'sclB
        '
        Me.sclB.Location = New System.Drawing.Point(435, 463)
        Me.sclB.Maximum = 255
        Me.sclB.Name = "sclB"
        Me.sclB.Size = New System.Drawing.Size(125, 20)
        Me.sclB.TabIndex = 11
        '
        'btnFGColor
        '
        Me.btnFGColor.BackColor = System.Drawing.Color.Black
        Me.btnFGColor.Enabled = False
        Me.btnFGColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFGColor.Location = New System.Drawing.Point(20, 43)
        Me.btnFGColor.Name = "btnFGColor"
        Me.btnFGColor.Size = New System.Drawing.Size(40, 28)
        Me.btnFGColor.TabIndex = 12
        Me.btnFGColor.UseVisualStyleBackColor = False
        '
        'lblRAmount
        '
        Me.lblRAmount.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRAmount.Location = New System.Drawing.Point(165, 468)
        Me.lblRAmount.Name = "lblRAmount"
        Me.lblRAmount.Size = New System.Drawing.Size(40, 23)
        Me.lblRAmount.TabIndex = 14
        Me.lblRAmount.Text = " "
        '
        'lblGAmount
        '
        Me.lblGAmount.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGAmount.Location = New System.Drawing.Point(365, 467)
        Me.lblGAmount.Name = "lblGAmount"
        Me.lblGAmount.Size = New System.Drawing.Size(41, 23)
        Me.lblGAmount.TabIndex = 15
        Me.lblGAmount.Text = " "
        '
        'lblBAmount
        '
        Me.lblBAmount.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBAmount.Location = New System.Drawing.Point(565, 466)
        Me.lblBAmount.Name = "lblBAmount"
        Me.lblBAmount.Size = New System.Drawing.Size(37, 23)
        Me.lblBAmount.TabIndex = 16
        Me.lblBAmount.Text = " "
        '
        'chkDrag
        '
        Me.chkDrag.AutoSize = True
        Me.chkDrag.Checked = True
        Me.chkDrag.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDrag.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDrag.Location = New System.Drawing.Point(334, 421)
        Me.chkDrag.Name = "chkDrag"
        Me.chkDrag.Size = New System.Drawing.Size(57, 21)
        Me.chkDrag.TabIndex = 17
        Me.chkDrag.Text = "Drag"
        Me.chkDrag.UseVisualStyleBackColor = True
        '
        'lblThick
        '
        Me.lblThick.AutoSize = True
        Me.lblThick.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThick.Location = New System.Drawing.Point(409, 393)
        Me.lblThick.Name = "lblThick"
        Me.lblThick.Size = New System.Drawing.Size(35, 17)
        Me.lblThick.TabIndex = 18
        Me.lblThick.Text = "Size:"
        '
        'spinSize
        '
        Me.spinSize.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spinSize.Location = New System.Drawing.Point(428, 413)
        Me.spinSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spinSize.Name = "spinSize"
        Me.spinSize.Size = New System.Drawing.Size(66, 24)
        Me.spinSize.TabIndex = 20
        Me.spinSize.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'radCircle
        '
        Me.radCircle.AutoSize = True
        Me.radCircle.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCircle.Location = New System.Drawing.Point(194, 388)
        Me.radCircle.Name = "radCircle"
        Me.radCircle.Size = New System.Drawing.Size(60, 21)
        Me.radCircle.TabIndex = 21
        Me.radCircle.Text = "Circle"
        Me.radCircle.UseVisualStyleBackColor = True
        '
        'radEraser
        '
        Me.radEraser.AutoSize = True
        Me.radEraser.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radEraser.Location = New System.Drawing.Point(328, 388)
        Me.radEraser.Name = "radEraser"
        Me.radEraser.Size = New System.Drawing.Size(63, 21)
        Me.radEraser.TabIndex = 22
        Me.radEraser.Text = "Eraser"
        Me.radEraser.UseVisualStyleBackColor = True
        '
        'tmrRefreshfps
        '
        '
        'radLine
        '
        Me.radLine.AutoSize = True
        Me.radLine.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLine.Location = New System.Drawing.Point(261, 388)
        Me.radLine.Name = "radLine"
        Me.radLine.Size = New System.Drawing.Size(51, 21)
        Me.radLine.TabIndex = 23
        Me.radLine.Text = "Line"
        Me.radLine.UseVisualStyleBackColor = True
        '
        'btnBGColor
        '
        Me.btnBGColor.BackColor = System.Drawing.Color.Black
        Me.btnBGColor.Enabled = False
        Me.btnBGColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBGColor.Location = New System.Drawing.Point(73, 43)
        Me.btnBGColor.Name = "btnBGColor"
        Me.btnBGColor.Size = New System.Drawing.Size(40, 28)
        Me.btnBGColor.TabIndex = 24
        Me.btnBGColor.UseVisualStyleBackColor = False
        '
        'grpColor
        '
        Me.grpColor.Controls.Add(Me.radBG)
        Me.grpColor.Controls.Add(Me.radFG)
        Me.grpColor.Controls.Add(Me.btnFGColor)
        Me.grpColor.Controls.Add(Me.btnBGColor)
        Me.grpColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpColor.Location = New System.Drawing.Point(508, 378)
        Me.grpColor.Name = "grpColor"
        Me.grpColor.Size = New System.Drawing.Size(128, 81)
        Me.grpColor.TabIndex = 26
        Me.grpColor.TabStop = False
        Me.grpColor.Text = "Color"
        '
        'radFG
        '
        Me.radFG.AutoSize = True
        Me.radFG.Checked = True
        Me.radFG.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFG.Location = New System.Drawing.Point(6, 19)
        Me.radFG.Name = "radFG"
        Me.radFG.Size = New System.Drawing.Size(43, 21)
        Me.radFG.TabIndex = 27
        Me.radFG.TabStop = True
        Me.radFG.Text = "FG"
        Me.radFG.UseVisualStyleBackColor = True
        '
        'radBG
        '
        Me.radBG.AutoSize = True
        Me.radBG.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBG.Location = New System.Drawing.Point(59, 19)
        Me.radBG.Name = "radBG"
        Me.radBG.Size = New System.Drawing.Size(44, 21)
        Me.radBG.TabIndex = 28
        Me.radBG.Text = "BG"
        Me.radBG.UseVisualStyleBackColor = True
        '
        'ItMightBePaint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 507)
        Me.Controls.Add(Me.grpColor)
        Me.Controls.Add(Me.radLine)
        Me.Controls.Add(Me.radEraser)
        Me.Controls.Add(Me.radCircle)
        Me.Controls.Add(Me.spinSize)
        Me.Controls.Add(Me.lblThick)
        Me.Controls.Add(Me.chkDrag)
        Me.Controls.Add(Me.lblBAmount)
        Me.Controls.Add(Me.lblGAmount)
        Me.Controls.Add(Me.lblRAmount)
        Me.Controls.Add(Me.sclB)
        Me.Controls.Add(Me.sclG)
        Me.Controls.Add(Me.lblG)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblR)
        Me.Controls.Add(Me.sclR)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.pnlCanvas)
        Me.Controls.Add(Me.radText)
        Me.Controls.Add(Me.radPencil)
        Me.Controls.Add(Me.btnFill)
        Me.Controls.Add(Me.btnClear)
        Me.Name = "ItMightBePaint"
        Me.Text = "It Might Be Paint (?)"
        CType(Me.spinSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpColor.ResumeLayout(False)
        Me.grpColor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents btnFill As Button
    Friend WithEvents radPencil As RadioButton
    Friend WithEvents radText As RadioButton
    Friend WithEvents pnlCanvas As Panel
    Friend WithEvents txtText As TextBox
    Friend WithEvents sclR As HScrollBar
    Friend WithEvents lblR As Label
    Friend WithEvents lblB As Label
    Friend WithEvents lblG As Label
    Friend WithEvents sclG As HScrollBar
    Friend WithEvents sclB As HScrollBar
    Friend WithEvents btnFGColor As Button
    Friend WithEvents lblRAmount As Label
    Friend WithEvents lblGAmount As Label
    Friend WithEvents lblBAmount As Label
    Friend WithEvents chkDrag As CheckBox
    Friend WithEvents lblThick As Label
    Friend WithEvents spinSize As NumericUpDown
    Friend WithEvents radCircle As RadioButton
    Friend WithEvents radEraser As RadioButton
    Friend WithEvents tmrRefreshfps As Timer
    Friend WithEvents radLine As RadioButton
    Friend WithEvents btnBGColor As Button
    Friend WithEvents grpColor As GroupBox
    Friend WithEvents radBG As RadioButton
    Friend WithEvents radFG As RadioButton
End Class
