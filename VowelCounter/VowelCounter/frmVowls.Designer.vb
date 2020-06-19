<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVowls
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
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.lblVowelCounter = New System.Windows.Forms.Label()
        Me.lblVowels = New System.Windows.Forms.Label()
        Me.lblConsonants = New System.Windows.Forms.Label()
        Me.txtVowels = New System.Windows.Forms.TextBox()
        Me.txtConsonants = New System.Windows.Forms.TextBox()
        Me.btnCount = New System.Windows.Forms.Button()
        Me.txtCharacters = New System.Windows.Forms.TextBox()
        Me.lblCharacters = New System.Windows.Forms.Label()
        Me.btnCrazy = New System.Windows.Forms.Button()
        Me.btnReverse = New System.Windows.Forms.Button()
        Me.btnPalindrome = New System.Windows.Forms.Button()
        Me.txtSpecialOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(12, 58)
        Me.txtText.Multiline = True
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(376, 120)
        Me.txtText.TabIndex = 2
        '
        'lblVowelCounter
        '
        Me.lblVowelCounter.AutoSize = True
        Me.lblVowelCounter.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVowelCounter.Location = New System.Drawing.Point(109, 16)
        Me.lblVowelCounter.Name = "lblVowelCounter"
        Me.lblVowelCounter.Size = New System.Drawing.Size(183, 30)
        Me.lblVowelCounter.TabIndex = 2
        Me.lblVowelCounter.Text = "Vowel Counter"
        '
        'lblVowels
        '
        Me.lblVowels.AutoSize = True
        Me.lblVowels.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVowels.Location = New System.Drawing.Point(56, 198)
        Me.lblVowels.Name = "lblVowels"
        Me.lblVowels.Size = New System.Drawing.Size(58, 17)
        Me.lblVowels.TabIndex = 3
        Me.lblVowels.Text = "Vowels :"
        '
        'lblConsonants
        '
        Me.lblConsonants.AutoSize = True
        Me.lblConsonants.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsonants.Location = New System.Drawing.Point(26, 224)
        Me.lblConsonants.Name = "lblConsonants"
        Me.lblConsonants.Size = New System.Drawing.Size(88, 17)
        Me.lblConsonants.TabIndex = 3
        Me.lblConsonants.Text = "Consonants :"
        '
        'txtVowels
        '
        Me.txtVowels.BackColor = System.Drawing.Color.White
        Me.txtVowels.Location = New System.Drawing.Point(121, 197)
        Me.txtVowels.Name = "txtVowels"
        Me.txtVowels.ReadOnly = True
        Me.txtVowels.Size = New System.Drawing.Size(100, 20)
        Me.txtVowels.TabIndex = 3
        '
        'txtConsonants
        '
        Me.txtConsonants.BackColor = System.Drawing.Color.White
        Me.txtConsonants.Location = New System.Drawing.Point(121, 224)
        Me.txtConsonants.Name = "txtConsonants"
        Me.txtConsonants.ReadOnly = True
        Me.txtConsonants.Size = New System.Drawing.Size(100, 20)
        Me.txtConsonants.TabIndex = 3
        '
        'btnCount
        '
        Me.btnCount.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCount.Location = New System.Drawing.Point(262, 201)
        Me.btnCount.Name = "btnCount"
        Me.btnCount.Size = New System.Drawing.Size(104, 61)
        Me.btnCount.TabIndex = 0
        Me.btnCount.Text = "Count"
        Me.btnCount.UseVisualStyleBackColor = True
        '
        'txtCharacters
        '
        Me.txtCharacters.BackColor = System.Drawing.Color.White
        Me.txtCharacters.Location = New System.Drawing.Point(121, 252)
        Me.txtCharacters.Name = "txtCharacters"
        Me.txtCharacters.ReadOnly = True
        Me.txtCharacters.Size = New System.Drawing.Size(100, 20)
        Me.txtCharacters.TabIndex = 3
        '
        'lblCharacters
        '
        Me.lblCharacters.AutoSize = True
        Me.lblCharacters.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharacters.Location = New System.Drawing.Point(26, 252)
        Me.lblCharacters.Name = "lblCharacters"
        Me.lblCharacters.Size = New System.Drawing.Size(81, 17)
        Me.lblCharacters.TabIndex = 3
        Me.lblCharacters.Text = "Characters :"
        '
        'btnCrazy
        '
        Me.btnCrazy.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrazy.Location = New System.Drawing.Point(12, 291)
        Me.btnCrazy.Name = "btnCrazy"
        Me.btnCrazy.Size = New System.Drawing.Size(109, 30)
        Me.btnCrazy.TabIndex = 1
        Me.btnCrazy.Text = "Crazy"
        Me.btnCrazy.UseVisualStyleBackColor = True
        '
        'btnReverse
        '
        Me.btnReverse.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReverse.Location = New System.Drawing.Point(146, 291)
        Me.btnReverse.Name = "btnReverse"
        Me.btnReverse.Size = New System.Drawing.Size(109, 30)
        Me.btnReverse.TabIndex = 1
        Me.btnReverse.Text = "Reverse"
        Me.btnReverse.UseVisualStyleBackColor = True
        '
        'btnPalindrome
        '
        Me.btnPalindrome.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPalindrome.Location = New System.Drawing.Point(279, 291)
        Me.btnPalindrome.Name = "btnPalindrome"
        Me.btnPalindrome.Size = New System.Drawing.Size(109, 30)
        Me.btnPalindrome.TabIndex = 1
        Me.btnPalindrome.Text = "Palindrome"
        Me.btnPalindrome.UseVisualStyleBackColor = True
        '
        'txtSpecialOutput
        '
        Me.txtSpecialOutput.BackColor = System.Drawing.Color.White
        Me.txtSpecialOutput.Location = New System.Drawing.Point(12, 332)
        Me.txtSpecialOutput.Multiline = True
        Me.txtSpecialOutput.Name = "txtSpecialOutput"
        Me.txtSpecialOutput.ReadOnly = True
        Me.txtSpecialOutput.Size = New System.Drawing.Size(376, 120)
        Me.txtSpecialOutput.TabIndex = 2
        '
        'frmVowls
        '
        Me.AcceptButton = Me.btnCount
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 463)
        Me.Controls.Add(Me.txtSpecialOutput)
        Me.Controls.Add(Me.btnPalindrome)
        Me.Controls.Add(Me.btnReverse)
        Me.Controls.Add(Me.btnCrazy)
        Me.Controls.Add(Me.txtCharacters)
        Me.Controls.Add(Me.lblCharacters)
        Me.Controls.Add(Me.btnCount)
        Me.Controls.Add(Me.txtConsonants)
        Me.Controls.Add(Me.txtVowels)
        Me.Controls.Add(Me.lblConsonants)
        Me.Controls.Add(Me.lblVowels)
        Me.Controls.Add(Me.lblVowelCounter)
        Me.Controls.Add(Me.txtText)
        Me.Name = "frmVowls"
        Me.Text = "Vowel Counter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtText As TextBox
    Friend WithEvents lblVowelCounter As Label
    Friend WithEvents lblVowels As Label
    Friend WithEvents lblConsonants As Label
    Friend WithEvents txtVowels As TextBox
    Friend WithEvents txtConsonants As TextBox
    Friend WithEvents btnCount As Button
    Friend WithEvents txtCharacters As TextBox
    Friend WithEvents lblCharacters As Label
    Friend WithEvents btnCrazy As Button
    Friend WithEvents btnReverse As Button
    Friend WithEvents btnPalindrome As Button
    Friend WithEvents txtSpecialOutput As TextBox
End Class
