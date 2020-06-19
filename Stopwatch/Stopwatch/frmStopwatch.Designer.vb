<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStopwatch
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
        Me.txtSeconds = New System.Windows.Forms.TextBox()
        Me.txtTenths = New System.Windows.Forms.TextBox()
        Me.btnStartStop = New System.Windows.Forms.Button()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnLapReset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPreviousLaps = New System.Windows.Forms.TextBox()
        Me.txtLapS = New System.Windows.Forms.TextBox()
        Me.txtLapT = New System.Windows.Forms.TextBox()
        Me.txtCurrentLap = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtSeconds
        '
        Me.txtSeconds.BackColor = System.Drawing.Color.White
        Me.txtSeconds.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSeconds.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtSeconds.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeconds.Location = New System.Drawing.Point(105, 29)
        Me.txtSeconds.Name = "txtSeconds"
        Me.txtSeconds.ReadOnly = True
        Me.txtSeconds.Size = New System.Drawing.Size(67, 59)
        Me.txtSeconds.TabIndex = 2
        Me.txtSeconds.Text = "00"
        Me.txtSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTenths
        '
        Me.txtTenths.BackColor = System.Drawing.Color.White
        Me.txtTenths.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTenths.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtTenths.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenths.Location = New System.Drawing.Point(207, 57)
        Me.txtTenths.Name = "txtTenths"
        Me.txtTenths.ReadOnly = True
        Me.txtTenths.Size = New System.Drawing.Size(48, 24)
        Me.txtTenths.TabIndex = 2
        Me.txtTenths.Text = "00"
        Me.txtTenths.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnStartStop
        '
        Me.btnStartStop.BackColor = System.Drawing.Color.Chocolate
        Me.btnStartStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStartStop.FlatAppearance.BorderColor = System.Drawing.Color.Peru
        Me.btnStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartStop.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartStop.ForeColor = System.Drawing.Color.White
        Me.btnStartStop.Location = New System.Drawing.Point(59, 109)
        Me.btnStartStop.Name = "btnStartStop"
        Me.btnStartStop.Size = New System.Drawing.Size(93, 32)
        Me.btnStartStop.TabIndex = 0
        Me.btnStartStop.Text = "Start"
        Me.btnStartStop.UseVisualStyleBackColor = False
        '
        'tmrTimer
        '
        '
        'btnLapReset
        '
        Me.btnLapReset.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnLapReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLapReset.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnLapReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLapReset.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLapReset.Location = New System.Drawing.Point(220, 109)
        Me.btnLapReset.Name = "btnLapReset"
        Me.btnLapReset.Size = New System.Drawing.Size(90, 32)
        Me.btnLapReset.TabIndex = 1
        Me.btnLapReset.Text = "Reset"
        Me.btnLapReset.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "S"
        '
        'txtPreviousLaps
        '
        Me.txtPreviousLaps.BackColor = System.Drawing.Color.White
        Me.txtPreviousLaps.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPreviousLaps.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtPreviousLaps.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreviousLaps.Location = New System.Drawing.Point(54, 183)
        Me.txtPreviousLaps.Multiline = True
        Me.txtPreviousLaps.Name = "txtPreviousLaps"
        Me.txtPreviousLaps.ReadOnly = True
        Me.txtPreviousLaps.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPreviousLaps.Size = New System.Drawing.Size(270, 158)
        Me.txtPreviousLaps.TabIndex = 2
        '
        'txtLapS
        '
        Me.txtLapS.BackColor = System.Drawing.Color.White
        Me.txtLapS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLapS.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtLapS.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLapS.Location = New System.Drawing.Point(196, 158)
        Me.txtLapS.Name = "txtLapS"
        Me.txtLapS.ReadOnly = True
        Me.txtLapS.Size = New System.Drawing.Size(47, 20)
        Me.txtLapS.TabIndex = 3
        Me.txtLapS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLapT
        '
        Me.txtLapT.BackColor = System.Drawing.Color.White
        Me.txtLapT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLapT.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtLapT.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLapT.Location = New System.Drawing.Point(249, 158)
        Me.txtLapT.Name = "txtLapT"
        Me.txtLapT.ReadOnly = True
        Me.txtLapT.Size = New System.Drawing.Size(45, 20)
        Me.txtLapT.TabIndex = 4
        '
        'txtCurrentLap
        '
        Me.txtCurrentLap.BackColor = System.Drawing.Color.White
        Me.txtCurrentLap.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCurrentLap.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtCurrentLap.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentLap.Location = New System.Drawing.Point(43, 158)
        Me.txtCurrentLap.Name = "txtCurrentLap"
        Me.txtCurrentLap.ReadOnly = True
        Me.txtCurrentLap.Size = New System.Drawing.Size(88, 20)
        Me.txtCurrentLap.TabIndex = 2
        Me.txtCurrentLap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmStopwatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(362, 372)
        Me.Controls.Add(Me.txtCurrentLap)
        Me.Controls.Add(Me.txtLapT)
        Me.Controls.Add(Me.txtLapS)
        Me.Controls.Add(Me.txtPreviousLaps)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLapReset)
        Me.Controls.Add(Me.btnStartStop)
        Me.Controls.Add(Me.txtTenths)
        Me.Controls.Add(Me.txtSeconds)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmStopwatch"
        Me.Text = "Stopwatch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSeconds As TextBox
    Friend WithEvents txtTenths As TextBox
    Friend WithEvents btnStartStop As Button
    Friend WithEvents tmrTimer As Timer
    Friend WithEvents btnLapReset As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPreviousLaps As TextBox
    Friend WithEvents txtLapS As TextBox
    Friend WithEvents txtLapT As TextBox
    Friend WithEvents txtCurrentLap As TextBox
End Class
