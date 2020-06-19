<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWelcome))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnJump = New System.Windows.Forms.Button()
        Me.txtLevel = New System.Windows.Forms.TextBox()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOptions = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(400, 223)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(6, 229)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(150, 32)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "New Game!"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnJump
        '
        Me.btnJump.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJump.Location = New System.Drawing.Point(160, 229)
        Me.btnJump.Margin = New System.Windows.Forms.Padding(2)
        Me.btnJump.Name = "btnJump"
        Me.btnJump.Size = New System.Drawing.Size(170, 32)
        Me.btnJump.TabIndex = 2
        Me.btnJump.Text = "Jump to Level:"
        Me.btnJump.UseVisualStyleBackColor = True
        '
        'txtLevel
        '
        Me.txtLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLevel.Location = New System.Drawing.Point(338, 232)
        Me.txtLevel.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.Size = New System.Drawing.Size(57, 32)
        Me.txtLevel.TabIndex = 3
        '
        'btnInstructions
        '
        Me.btnInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstructions.Location = New System.Drawing.Point(6, 268)
        Me.btnInstructions.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(130, 32)
        Me.btnInstructions.TabIndex = 4
        Me.btnInstructions.Text = "Instructions"
        Me.btnInstructions.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(264, 268)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(131, 32)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit Game"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnOptions
        '
        Me.btnOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOptions.Location = New System.Drawing.Point(140, 268)
        Me.btnOptions.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(120, 32)
        Me.btnOptions.TabIndex = 6
        Me.btnOptions.Text = "Options"
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 308)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.txtLevel)
        Me.Controls.Add(Me.btnJump)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmWelcome"
        Me.Text = "Welcome"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnNew As Button
    Friend WithEvents btnJump As Button
    Friend WithEvents txtLevel As TextBox
    Friend WithEvents btnInstructions As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnOptions As Button
End Class
