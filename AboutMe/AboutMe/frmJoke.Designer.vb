<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJoke
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnAnswer1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnAnswer2 = New System.Windows.Forms.Button()
        Me.TextBox0 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btnAnswer3 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.btnAnswer4 = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(284, 22)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "What do you call motors with ears?"
        '
        'btnAnswer1
        '
        Me.btnAnswer1.Location = New System.Drawing.Point(314, 56)
        Me.btnAnswer1.Name = "btnAnswer1"
        Me.btnAnswer1.Size = New System.Drawing.Size(75, 23)
        Me.btnAnswer1.TabIndex = 0
        Me.btnAnswer1.Text = "Answer"
        Me.btnAnswer1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(12, 86)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(284, 22)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = "Where is Curry originated from?"
        '
        'btnAnswer2
        '
        Me.btnAnswer2.Location = New System.Drawing.Point(314, 86)
        Me.btnAnswer2.Name = "btnAnswer2"
        Me.btnAnswer2.Size = New System.Drawing.Size(75, 23)
        Me.btnAnswer2.TabIndex = 1
        Me.btnAnswer2.Text = "Answer"
        Me.btnAnswer2.UseVisualStyleBackColor = True
        '
        'TextBox0
        '
        Me.TextBox0.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TextBox0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox0.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox0.Location = New System.Drawing.Point(12, 12)
        Me.TextBox0.Name = "TextBox0"
        Me.TextBox0.Size = New System.Drawing.Size(378, 30)
        Me.TextBox0.TabIndex = 1
        Me.TextBox0.Text = "Are your ready for This?"
        Me.TextBox0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(12, 114)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(284, 22)
        Me.TextBox3.TabIndex = 6
        Me.TextBox3.Text = "What do you call security in a samsung store?"
        '
        'btnAnswer3
        '
        Me.btnAnswer3.Location = New System.Drawing.Point(314, 113)
        Me.btnAnswer3.Name = "btnAnswer3"
        Me.btnAnswer3.Size = New System.Drawing.Size(75, 23)
        Me.btnAnswer3.TabIndex = 7
        Me.btnAnswer3.Text = "Answer"
        Me.btnAnswer3.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(12, 142)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(284, 22)
        Me.TextBox4.TabIndex = 8
        Me.TextBox4.Text = "What is my favorite text font?"
        '
        'btnAnswer4
        '
        Me.btnAnswer4.Location = New System.Drawing.Point(314, 142)
        Me.btnAnswer4.Name = "btnAnswer4"
        Me.btnAnswer4.Size = New System.Drawing.Size(75, 23)
        Me.btnAnswer4.TabIndex = 9
        Me.btnAnswer4.Text = "Answer"
        Me.btnAnswer4.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(39, 178)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(329, 25)
        Me.btnHome.TabIndex = 10
        Me.btnHome.Text = "Back to home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'frmJoke
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 215)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnAnswer4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.btnAnswer3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox0)
        Me.Controls.Add(Me.btnAnswer2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.btnAnswer1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frmJoke"
        Me.Text = "Jokes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnAnswer1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnAnswer2 As Button
    Friend WithEvents TextBox0 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btnAnswer3 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents btnAnswer4 As Button
    Friend WithEvents btnHome As Button
End Class
