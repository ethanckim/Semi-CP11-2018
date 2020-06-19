<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTriangularNumbers
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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(168, 20)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Add Up to Number..."
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(186, 16)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(66, 25)
        Me.txtInput.TabIndex = 1
        Me.txtInput.Text = "0"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(78, 51)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(121, 32)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "ADD UP!!"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOutput.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtOutput.Location = New System.Drawing.Point(16, 94)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(257, 273)
        Me.txtOutput.TabIndex = 3
        '
        'frmTriangularNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 379)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmTriangularNumbers"
        Me.Text = "Triangular Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtOutput As TextBox
End Class
