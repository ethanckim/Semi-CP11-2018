<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProbSim
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtRawOutput = New System.Windows.Forms.TextBox()
        Me.txtNumIterations = New System.Windows.Forms.TextBox()
        Me.txtSummary = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.prbOverall = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tmrUiUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.chkCustom = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkTT = New System.Windows.Forms.CheckBox()
        Me.chkHH = New System.Windows.Forms.CheckBox()
        Me.lblNoComma = New System.Windows.Forms.Label()
        Me.txtCondition = New System.Windows.Forms.TextBox()
        Me.radTwntyForRollsSixSix = New System.Windows.Forms.RadioButton()
        Me.radBtoBHeads = New System.Windows.Forms.RadioButton()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.radTemFlips = New System.Windows.Forms.RadioButton()
        Me.lblIterations = New System.Windows.Forms.Label()
        Me.grpOptions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtRawOutput
        '
        Me.txtRawOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtRawOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRawOutput.Location = New System.Drawing.Point(284, 32)
        Me.txtRawOutput.Multiline = True
        Me.txtRawOutput.Name = "txtRawOutput"
        Me.txtRawOutput.ReadOnly = True
        Me.txtRawOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRawOutput.Size = New System.Drawing.Size(338, 507)
        Me.txtRawOutput.TabIndex = 0
        '
        'txtNumIterations
        '
        Me.txtNumIterations.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumIterations.Location = New System.Drawing.Point(84, 19)
        Me.txtNumIterations.Name = "txtNumIterations"
        Me.txtNumIterations.Size = New System.Drawing.Size(169, 26)
        Me.txtNumIterations.TabIndex = 1
        Me.txtNumIterations.Text = "50000"
        '
        'txtSummary
        '
        Me.txtSummary.BackColor = System.Drawing.Color.White
        Me.txtSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSummary.Location = New System.Drawing.Point(628, 32)
        Me.txtSummary.Multiline = True
        Me.txtSummary.Name = "txtSummary"
        Me.txtSummary.ReadOnly = True
        Me.txtSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSummary.Size = New System.Drawing.Size(338, 507)
        Me.txtSummary.TabIndex = 0
        '
        'btnGo
        '
        Me.btnGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.Location = New System.Drawing.Point(16, 434)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(235, 28)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'prbOverall
        '
        Me.prbOverall.Location = New System.Drawing.Point(16, 468)
        Me.prbOverall.Name = "prbOverall"
        Me.prbOverall.Size = New System.Drawing.Size(235, 28)
        Me.prbOverall.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(280, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Results"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(624, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Summary"
        '
        'tmrUiUpdate
        '
        Me.tmrUiUpdate.Enabled = True
        Me.tmrUiUpdate.Interval = 250
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.chkCustom)
        Me.grpOptions.Controls.Add(Me.GroupBox1)
        Me.grpOptions.Controls.Add(Me.radTwntyForRollsSixSix)
        Me.grpOptions.Controls.Add(Me.radBtoBHeads)
        Me.grpOptions.Controls.Add(Me.lblStatus)
        Me.grpOptions.Controls.Add(Me.Label3)
        Me.grpOptions.Controls.Add(Me.radTemFlips)
        Me.grpOptions.Controls.Add(Me.lblIterations)
        Me.grpOptions.Controls.Add(Me.prbOverall)
        Me.grpOptions.Controls.Add(Me.txtNumIterations)
        Me.grpOptions.Controls.Add(Me.btnGo)
        Me.grpOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOptions.Location = New System.Drawing.Point(12, 12)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(266, 525)
        Me.grpOptions.TabIndex = 5
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'chkCustom
        '
        Me.chkCustom.AutoSize = True
        Me.chkCustom.Location = New System.Drawing.Point(8, 164)
        Me.chkCustom.Name = "chkCustom"
        Me.chkCustom.Size = New System.Drawing.Size(15, 14)
        Me.chkCustom.TabIndex = 0
        Me.chkCustom.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkTT)
        Me.GroupBox1.Controls.Add(Me.chkHH)
        Me.GroupBox1.Controls.Add(Me.lblNoComma)
        Me.GroupBox1.Controls.Add(Me.txtCondition)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 123)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Custom Coin - Average Flips"
        '
        'chkTT
        '
        Me.chkTT.AutoSize = True
        Me.chkTT.Location = New System.Drawing.Point(136, 87)
        Me.chkTT.Name = "chkTT"
        Me.chkTT.Size = New System.Drawing.Size(46, 24)
        Me.chkTT.TabIndex = 3
        Me.chkTT.Text = "TT"
        Me.chkTT.UseVisualStyleBackColor = True
        '
        'chkHH
        '
        Me.chkHH.AutoSize = True
        Me.chkHH.Location = New System.Drawing.Point(31, 87)
        Me.chkHH.Name = "chkHH"
        Me.chkHH.Size = New System.Drawing.Size(52, 24)
        Me.chkHH.TabIndex = 2
        Me.chkHH.Text = "HH"
        Me.chkHH.UseVisualStyleBackColor = True
        '
        'lblNoComma
        '
        Me.lblNoComma.AutoSize = True
        Me.lblNoComma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoComma.Location = New System.Drawing.Point(28, 59)
        Me.lblNoComma.Name = "lblNoComma"
        Me.lblNoComma.Size = New System.Drawing.Size(123, 16)
        Me.lblNoComma.TabIndex = 1
        Me.lblNoComma.Text = "(Comma Delimited)"
        '
        'txtCondition
        '
        Me.txtCondition.Enabled = False
        Me.txtCondition.Location = New System.Drawing.Point(17, 30)
        Me.txtCondition.Name = "txtCondition"
        Me.txtCondition.Size = New System.Drawing.Size(204, 26)
        Me.txtCondition.TabIndex = 0
        '
        'radTwntyForRollsSixSix
        '
        Me.radTwntyForRollsSixSix.AutoSize = True
        Me.radTwntyForRollsSixSix.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTwntyForRollsSixSix.Location = New System.Drawing.Point(8, 118)
        Me.radTwntyForRollsSixSix.Name = "radTwntyForRollsSixSix"
        Me.radTwntyForRollsSixSix.Size = New System.Drawing.Size(120, 22)
        Me.radTwntyForRollsSixSix.TabIndex = 8
        Me.radTwntyForRollsSixSix.TabStop = True
        Me.radTwntyForRollsSixSix.Text = "24 Rolls, [6, 6]"
        Me.radTwntyForRollsSixSix.UseVisualStyleBackColor = True
        '
        'radBtoBHeads
        '
        Me.radBtoBHeads.AutoSize = True
        Me.radBtoBHeads.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBtoBHeads.Location = New System.Drawing.Point(8, 87)
        Me.radBtoBHeads.Name = "radBtoBHeads"
        Me.radBtoBHeads.Size = New System.Drawing.Size(255, 22)
        Me.radBtoBHeads.TabIndex = 7
        Me.radBtoBHeads.TabStop = True
        Me.radBtoBHeads.Text = "Average flips, Back-to-Back Heads"
        Me.radBtoBHeads.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(74, 335)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(177, 96)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 335)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Status:"
        '
        'radTemFlips
        '
        Me.radTemFlips.AutoSize = True
        Me.radTemFlips.Checked = True
        Me.radTemFlips.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTemFlips.Location = New System.Drawing.Point(8, 57)
        Me.radTemFlips.Margin = New System.Windows.Forms.Padding(2)
        Me.radTemFlips.Name = "radTemFlips"
        Me.radTemFlips.Size = New System.Drawing.Size(223, 22)
        Me.radTemFlips.TabIndex = 5
        Me.radTemFlips.TabStop = True
        Me.radTemFlips.Text = "10 Flips, Back-to-Back Heads"
        Me.radTemFlips.UseVisualStyleBackColor = True
        '
        'lblIterations
        '
        Me.lblIterations.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIterations.Location = New System.Drawing.Point(9, 19)
        Me.lblIterations.Name = "lblIterations"
        Me.lblIterations.Size = New System.Drawing.Size(69, 26)
        Me.lblIterations.TabIndex = 4
        Me.lblIterations.Text = "Iterations"
        Me.lblIterations.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmProbSim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 549)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSummary)
        Me.Controls.Add(Me.txtRawOutput)
        Me.Name = "frmProbSim"
        Me.Text = "Probability Simulator"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtRawOutput As TextBox
    Friend WithEvents txtNumIterations As TextBox
    Friend WithEvents txtSummary As TextBox
    Friend WithEvents btnGo As Button
    Friend WithEvents prbOverall As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tmrUiUpdate As Timer
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents lblIterations As Label
    Friend WithEvents radTemFlips As RadioButton
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents radBtoBHeads As RadioButton
    Friend WithEvents radTwntyForRollsSixSix As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkCustom As CheckBox
    Friend WithEvents lblNoComma As Label
    Friend WithEvents txtCondition As TextBox
    Friend WithEvents chkHH As CheckBox
    Friend WithEvents chkTT As CheckBox
End Class
