<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWonky
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
        Me.txtCurrent = New System.Windows.Forms.TextBox()
        Me.btnA = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnD = New System.Windows.Forms.Button()
        Me.btnE = New System.Windows.Forms.Button()
        Me.btnF = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrRandomizer = New System.Windows.Forms.Timer(Me.components)
        Me.btnRerandomize = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCurrent
        '
        Me.txtCurrent.Location = New System.Drawing.Point(268, 47)
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.Size = New System.Drawing.Size(100, 20)
        Me.txtCurrent.TabIndex = 2
        '
        'btnA
        '
        Me.btnA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnA.Location = New System.Drawing.Point(11, 99)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(86, 76)
        Me.btnA.TabIndex = 1
        Me.btnA.Text = "-"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'btnB
        '
        Me.btnB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnB.Location = New System.Drawing.Point(109, 99)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(86, 76)
        Me.btnB.TabIndex = 1
        Me.btnB.Text = " -"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'btnC
        '
        Me.btnC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC.Location = New System.Drawing.Point(201, 99)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(86, 76)
        Me.btnC.TabIndex = 1
        Me.btnC.Text = " -"
        Me.btnC.UseVisualStyleBackColor = True
        '
        'btnD
        '
        Me.btnD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnD.Location = New System.Drawing.Point(293, 99)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(86, 76)
        Me.btnD.TabIndex = 1
        Me.btnD.Text = "-"
        Me.btnD.UseVisualStyleBackColor = True
        '
        'btnE
        '
        Me.btnE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnE.Location = New System.Drawing.Point(385, 99)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(86, 76)
        Me.btnE.TabIndex = 1
        Me.btnE.Text = "-"
        Me.btnE.UseVisualStyleBackColor = True
        '
        'btnF
        '
        Me.btnF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnF.Location = New System.Drawing.Point(477, 99)
        Me.btnF.Name = "btnF"
        Me.btnF.Size = New System.Drawing.Size(86, 76)
        Me.btnF.TabIndex = 1
        Me.btnF.Text = "-"
        Me.btnF.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "SUPER Jackpot Fortune"
        '
        'tmrRandomizer
        '
        Me.tmrRandomizer.Enabled = True
        Me.tmrRandomizer.Interval = 250
        '
        'btnRerandomize
        '
        Me.btnRerandomize.Location = New System.Drawing.Point(420, 40)
        Me.btnRerandomize.Name = "btnRerandomize"
        Me.btnRerandomize.Size = New System.Drawing.Size(113, 33)
        Me.btnRerandomize.TabIndex = 8
        Me.btnRerandomize.Text = "Rerandomize"
        Me.btnRerandomize.UseVisualStyleBackColor = True
        '
        'frmWonky
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 198)
        Me.Controls.Add(Me.btnRerandomize)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnF)
        Me.Controls.Add(Me.btnE)
        Me.Controls.Add(Me.btnD)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btnB)
        Me.Controls.Add(Me.btnA)
        Me.Controls.Add(Me.txtCurrent)
        Me.Name = "frmWonky"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCurrent As TextBox
    Friend WithEvents btnA As Button
    Friend WithEvents btnB As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnD As Button
    Friend WithEvents btnE As Button
    Friend WithEvents btnF As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tmrRandomizer As Timer
    Friend WithEvents btnRerandomize As Button
End Class
