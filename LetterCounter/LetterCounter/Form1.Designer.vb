<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnCount = New System.Windows.Forms.Button()
        Me.btnAscii = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(40, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(269, 26)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "String Frequency Counter"
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.Location = New System.Drawing.Point(17, 60)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(37, 17)
        Me.lblText.TabIndex = 4
        Me.lblText.Text = "Text"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(17, 168)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(48, 17)
        Me.lblResult.TabIndex = 4
        Me.lblResult.Text = "Result"
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(31, 80)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(291, 72)
        Me.txtInput.TabIndex = 2
        '
        'txtOutput
        '
        Me.txtOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput.Location = New System.Drawing.Point(31, 188)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(189, 228)
        Me.txtOutput.TabIndex = 3
        '
        'btnCount
        '
        Me.btnCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCount.Location = New System.Drawing.Point(244, 172)
        Me.btnCount.Name = "btnCount"
        Me.btnCount.Size = New System.Drawing.Size(75, 55)
        Me.btnCount.TabIndex = 1
        Me.btnCount.Text = "Count"
        Me.btnCount.UseVisualStyleBackColor = True
        '
        'btnAscii
        '
        Me.btnAscii.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAscii.Location = New System.Drawing.Point(244, 255)
        Me.btnAscii.Name = "btnAscii"
        Me.btnAscii.Size = New System.Drawing.Size(75, 49)
        Me.btnAscii.TabIndex = 1
        Me.btnAscii.Text = "Ascii Code"
        Me.btnAscii.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(229, 310)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 67)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "Shows what the ascii code is for the first character in the input text"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCount
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 429)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnAscii)
        Me.Controls.Add(Me.btnCount)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblText As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents btnCount As Button
    Friend WithEvents btnAscii As Button
    Friend WithEvents TextBox1 As TextBox
End Class
