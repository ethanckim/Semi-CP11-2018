<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnimalType
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.rdbLionfish = New System.Windows.Forms.RadioButton()
        Me.rdbHomosapien = New System.Windows.Forms.RadioButton()
        Me.rdbFox = New System.Windows.Forms.RadioButton()
        Me.rdbEchidna = New System.Windows.Forms.RadioButton()
        Me.txtPhrase = New System.Windows.Forms.TextBox()
        Me.lblPhrase = New System.Windows.Forms.Label()
        Me.btnSetCurrent = New System.Windows.Forms.Button()
        Me.lblActions = New System.Windows.Forms.Label()
        Me.btnLegs = New System.Windows.Forms.Button()
        Me.btnName = New System.Windows.Forms.Button()
        Me.btnSpeak = New System.Windows.Forms.Button()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.btnSpikes = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(91, 25)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(103, 24)
        Me.txtName.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(18, 25)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(67, 20)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name: "
        '
        'rdbLionfish
        '
        Me.rdbLionfish.AutoSize = True
        Me.rdbLionfish.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbLionfish.Location = New System.Drawing.Point(31, 67)
        Me.rdbLionfish.Name = "rdbLionfish"
        Me.rdbLionfish.Size = New System.Drawing.Size(74, 21)
        Me.rdbLionfish.TabIndex = 2
        Me.rdbLionfish.TabStop = True
        Me.rdbLionfish.Text = "Lionfish"
        Me.rdbLionfish.UseVisualStyleBackColor = True
        '
        'rdbHomosapien
        '
        Me.rdbHomosapien.AutoSize = True
        Me.rdbHomosapien.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbHomosapien.Location = New System.Drawing.Point(96, 106)
        Me.rdbHomosapien.Name = "rdbHomosapien"
        Me.rdbHomosapien.Size = New System.Drawing.Size(104, 20)
        Me.rdbHomosapien.TabIndex = 3
        Me.rdbHomosapien.TabStop = True
        Me.rdbHomosapien.Text = "Homosapien"
        Me.rdbHomosapien.UseVisualStyleBackColor = True
        '
        'rdbFox
        '
        Me.rdbFox.AutoSize = True
        Me.rdbFox.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFox.Location = New System.Drawing.Point(31, 106)
        Me.rdbFox.Name = "rdbFox"
        Me.rdbFox.Size = New System.Drawing.Size(48, 21)
        Me.rdbFox.TabIndex = 4
        Me.rdbFox.TabStop = True
        Me.rdbFox.Text = "Fox"
        Me.rdbFox.UseVisualStyleBackColor = True
        '
        'rdbEchidna
        '
        Me.rdbEchidna.AutoSize = True
        Me.rdbEchidna.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbEchidna.Location = New System.Drawing.Point(121, 67)
        Me.rdbEchidna.Name = "rdbEchidna"
        Me.rdbEchidna.Size = New System.Drawing.Size(74, 21)
        Me.rdbEchidna.TabIndex = 5
        Me.rdbEchidna.TabStop = True
        Me.rdbEchidna.Text = "Echidna"
        Me.rdbEchidna.UseVisualStyleBackColor = True
        '
        'txtPhrase
        '
        Me.txtPhrase.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhrase.Location = New System.Drawing.Point(83, 156)
        Me.txtPhrase.Name = "txtPhrase"
        Me.txtPhrase.Size = New System.Drawing.Size(125, 24)
        Me.txtPhrase.TabIndex = 6
        '
        'lblPhrase
        '
        Me.lblPhrase.AutoSize = True
        Me.lblPhrase.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhrase.Location = New System.Drawing.Point(12, 157)
        Me.lblPhrase.Name = "lblPhrase"
        Me.lblPhrase.Size = New System.Drawing.Size(65, 19)
        Me.lblPhrase.TabIndex = 7
        Me.lblPhrase.Text = "Phrase: "
        '
        'btnSetCurrent
        '
        Me.btnSetCurrent.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetCurrent.Location = New System.Drawing.Point(24, 191)
        Me.btnSetCurrent.Name = "btnSetCurrent"
        Me.btnSetCurrent.Size = New System.Drawing.Size(176, 31)
        Me.btnSetCurrent.TabIndex = 8
        Me.btnSetCurrent.Text = "Set Current"
        Me.btnSetCurrent.UseVisualStyleBackColor = True
        '
        'lblActions
        '
        Me.lblActions.AutoSize = True
        Me.lblActions.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActions.Location = New System.Drawing.Point(247, 20)
        Me.lblActions.Name = "lblActions"
        Me.lblActions.Size = New System.Drawing.Size(80, 20)
        Me.lblActions.TabIndex = 9
        Me.lblActions.Text = "Actions: "
        '
        'btnLegs
        '
        Me.btnLegs.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLegs.Location = New System.Drawing.Point(362, 51)
        Me.btnLegs.Name = "btnLegs"
        Me.btnLegs.Size = New System.Drawing.Size(80, 31)
        Me.btnLegs.TabIndex = 10
        Me.btnLegs.Text = "Legs?"
        Me.btnLegs.UseVisualStyleBackColor = True
        '
        'btnName
        '
        Me.btnName.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnName.Location = New System.Drawing.Point(276, 90)
        Me.btnName.Name = "btnName"
        Me.btnName.Size = New System.Drawing.Size(80, 31)
        Me.btnName.TabIndex = 11
        Me.btnName.Text = "Name"
        Me.btnName.UseVisualStyleBackColor = True
        '
        'btnSpeak
        '
        Me.btnSpeak.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpeak.Location = New System.Drawing.Point(276, 51)
        Me.btnSpeak.Name = "btnSpeak"
        Me.btnSpeak.Size = New System.Drawing.Size(80, 31)
        Me.btnSpeak.TabIndex = 12
        Me.btnSpeak.Text = "Speak"
        Me.btnSpeak.UseVisualStyleBackColor = True
        '
        'btnColor
        '
        Me.btnColor.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnColor.Location = New System.Drawing.Point(362, 90)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(80, 31)
        Me.btnColor.TabIndex = 13
        Me.btnColor.Text = "Color?"
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'btnSpikes
        '
        Me.btnSpikes.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpikes.Location = New System.Drawing.Point(448, 51)
        Me.btnSpikes.Name = "btnSpikes"
        Me.btnSpikes.Size = New System.Drawing.Size(80, 31)
        Me.btnSpikes.TabIndex = 14
        Me.btnSpikes.Text = "Spikes?"
        Me.btnSpikes.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(448, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 31)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Tails?"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(247, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Output: "
        '
        'txtOutput
        '
        Me.txtOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtOutput.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput.Location = New System.Drawing.Point(266, 176)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(261, 75)
        Me.txtOutput.TabIndex = 17
        '
        'frmAnimalType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 279)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSpikes)
        Me.Controls.Add(Me.btnColor)
        Me.Controls.Add(Me.btnSpeak)
        Me.Controls.Add(Me.btnName)
        Me.Controls.Add(Me.btnLegs)
        Me.Controls.Add(Me.lblActions)
        Me.Controls.Add(Me.btnSetCurrent)
        Me.Controls.Add(Me.lblPhrase)
        Me.Controls.Add(Me.txtPhrase)
        Me.Controls.Add(Me.rdbEchidna)
        Me.Controls.Add(Me.rdbFox)
        Me.Controls.Add(Me.rdbHomosapien)
        Me.Controls.Add(Me.rdbLionfish)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Name = "frmAnimalType"
        Me.Text = "Animal Type"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents rdbLionfish As RadioButton
    Friend WithEvents rdbHomosapien As RadioButton
    Friend WithEvents rdbFox As RadioButton
    Friend WithEvents rdbEchidna As RadioButton
    Friend WithEvents txtPhrase As TextBox
    Friend WithEvents lblPhrase As Label
    Friend WithEvents btnSetCurrent As Button
    Friend WithEvents lblActions As Label
    Friend WithEvents btnLegs As Button
    Friend WithEvents btnName As Button
    Friend WithEvents btnSpeak As Button
    Friend WithEvents btnColor As Button
    Friend WithEvents btnSpikes As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOutput As TextBox
End Class
