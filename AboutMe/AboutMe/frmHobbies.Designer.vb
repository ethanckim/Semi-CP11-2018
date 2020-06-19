<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHobbies
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
        Me.btnBackToHome = New System.Windows.Forms.Button()
        Me.btnSuspicious = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(440, 95)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "You aready learned my hobbies in the home window!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Now Shoo, Shoo." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Me wisperin" &
    "g: (Why did I made that button?)"
        '
        'btnBackToHome
        '
        Me.btnBackToHome.Location = New System.Drawing.Point(338, 113)
        Me.btnBackToHome.Name = "btnBackToHome"
        Me.btnBackToHome.Size = New System.Drawing.Size(114, 37)
        Me.btnBackToHome.TabIndex = 1
        Me.btnBackToHome.Text = "Home"
        Me.btnBackToHome.UseVisualStyleBackColor = True
        '
        'btnSuspicious
        '
        Me.btnSuspicious.BackColor = System.Drawing.SystemColors.Menu
        Me.btnSuspicious.FlatAppearance.BorderSize = 0
        Me.btnSuspicious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuspicious.Location = New System.Drawing.Point(12, 113)
        Me.btnSuspicious.Name = "btnSuspicious"
        Me.btnSuspicious.Size = New System.Drawing.Size(320, 37)
        Me.btnSuspicious.TabIndex = 2
        Me.btnSuspicious.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnSuspicious.UseVisualStyleBackColor = False
        '
        'frmHobbies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 160)
        Me.Controls.Add(Me.btnSuspicious)
        Me.Controls.Add(Me.btnBackToHome)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frmHobbies"
        Me.Text = "Hobbies"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnBackToHome As Button
    Friend WithEvents btnSuspicious As Button
End Class
