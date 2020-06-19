<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDebug
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDebug))
        Me.chkMouseConsole = New System.Windows.Forms.CheckBox()
        Me.chkFps = New System.Windows.Forms.CheckBox()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.tmrGame = New System.Windows.Forms.Timer(Me.components)
        Me.btnRestartLevel = New System.Windows.Forms.Button()
        Me.btnCamUp = New System.Windows.Forms.Button()
        Me.btnCamRight = New System.Windows.Forms.Button()
        Me.btnCamLeft = New System.Windows.Forms.Button()
        Me.btnCamDown = New System.Windows.Forms.Button()
        Me.picBSCount = New System.Windows.Forms.PictureBox()
        Me.lblBSCount = New System.Windows.Forms.Label()
        Me.lblRCount = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picPerfect = New System.Windows.Forms.PictureBox()
        CType(Me.picBSCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPerfect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkMouseConsole
        '
        Me.chkMouseConsole.AutoSize = True
        Me.chkMouseConsole.Enabled = False
        Me.chkMouseConsole.Location = New System.Drawing.Point(12, 12)
        Me.chkMouseConsole.Name = "chkMouseConsole"
        Me.chkMouseConsole.Size = New System.Drawing.Size(111, 17)
        Me.chkMouseConsole.TabIndex = 4
        Me.chkMouseConsole.Text = "Mouse to Console"
        Me.chkMouseConsole.UseVisualStyleBackColor = True
        '
        'chkFps
        '
        Me.chkFps.AutoSize = True
        Me.chkFps.Checked = True
        Me.chkFps.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFps.Location = New System.Drawing.Point(12, 35)
        Me.chkFps.Name = "chkFps"
        Me.chkFps.Size = New System.Drawing.Size(95, 17)
        Me.chkFps.TabIndex = 4
        Me.chkFps.Text = "Display Debug"
        Me.chkFps.UseVisualStyleBackColor = True
        '
        'btnNewGame
        '
        Me.btnNewGame.Location = New System.Drawing.Point(12, 67)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(182, 25)
        Me.btnNewGame.TabIndex = 5
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'tmrGame
        '
        Me.tmrGame.Enabled = True
        Me.tmrGame.Interval = 1
        '
        'btnRestartLevel
        '
        Me.btnRestartLevel.Location = New System.Drawing.Point(12, 98)
        Me.btnRestartLevel.Name = "btnRestartLevel"
        Me.btnRestartLevel.Size = New System.Drawing.Size(182, 25)
        Me.btnRestartLevel.TabIndex = 5
        Me.btnRestartLevel.Text = "Restart Level"
        Me.btnRestartLevel.UseVisualStyleBackColor = True
        '
        'btnCamUp
        '
        Me.btnCamUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCamUp.Location = New System.Drawing.Point(243, 70)
        Me.btnCamUp.Name = "btnCamUp"
        Me.btnCamUp.Size = New System.Drawing.Size(31, 27)
        Me.btnCamUp.TabIndex = 11
        Me.btnCamUp.Text = "↑"
        Me.btnCamUp.UseVisualStyleBackColor = True
        '
        'btnCamRight
        '
        Me.btnCamRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCamRight.Location = New System.Drawing.Point(270, 96)
        Me.btnCamRight.Name = "btnCamRight"
        Me.btnCamRight.Size = New System.Drawing.Size(30, 27)
        Me.btnCamRight.TabIndex = 12
        Me.btnCamRight.Text = "→"
        Me.btnCamRight.UseVisualStyleBackColor = True
        '
        'btnCamLeft
        '
        Me.btnCamLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCamLeft.Location = New System.Drawing.Point(218, 96)
        Me.btnCamLeft.Name = "btnCamLeft"
        Me.btnCamLeft.Size = New System.Drawing.Size(30, 27)
        Me.btnCamLeft.TabIndex = 13
        Me.btnCamLeft.Text = "←"
        Me.btnCamLeft.UseVisualStyleBackColor = True
        '
        'btnCamDown
        '
        Me.btnCamDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCamDown.Location = New System.Drawing.Point(244, 124)
        Me.btnCamDown.Name = "btnCamDown"
        Me.btnCamDown.Size = New System.Drawing.Size(30, 27)
        Me.btnCamDown.TabIndex = 14
        Me.btnCamDown.Text = "↓"
        Me.btnCamDown.UseVisualStyleBackColor = True
        '
        'picBSCount
        '
        Me.picBSCount.Image = CType(resources.GetObject("picBSCount.Image"), System.Drawing.Image)
        Me.picBSCount.Location = New System.Drawing.Point(174, 181)
        Me.picBSCount.Name = "picBSCount"
        Me.picBSCount.Size = New System.Drawing.Size(143, 55)
        Me.picBSCount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBSCount.TabIndex = 15
        Me.picBSCount.TabStop = False
        '
        'lblBSCount
        '
        Me.lblBSCount.AutoSize = True
        Me.lblBSCount.Font = New System.Drawing.Font("Monotxt_IV25", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBSCount.Location = New System.Drawing.Point(235, 201)
        Me.lblBSCount.Name = "lblBSCount"
        Me.lblBSCount.Size = New System.Drawing.Size(18, 16)
        Me.lblBSCount.TabIndex = 17
        Me.lblBSCount.Text = "-"
        Me.lblBSCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRCount
        '
        Me.lblRCount.AutoSize = True
        Me.lblRCount.Font = New System.Drawing.Font("Monotxt_IV25", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRCount.Location = New System.Drawing.Point(73, 201)
        Me.lblRCount.Name = "lblRCount"
        Me.lblRCount.Size = New System.Drawing.Size(18, 16)
        Me.lblRCount.TabIndex = 19
        Me.lblRCount.Text = "-"
        Me.lblRCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 181)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'picPerfect
        '
        Me.picPerfect.Image = CType(resources.GetObject("picPerfect.Image"), System.Drawing.Image)
        Me.picPerfect.Location = New System.Drawing.Point(59, 242)
        Me.picPerfect.Name = "picPerfect"
        Me.picPerfect.Size = New System.Drawing.Size(224, 50)
        Me.picPerfect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPerfect.TabIndex = 20
        Me.picPerfect.TabStop = False
        Me.picPerfect.Visible = False
        '
        'frmDebug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 304)
        Me.Controls.Add(Me.picPerfect)
        Me.Controls.Add(Me.lblRCount)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblBSCount)
        Me.Controls.Add(Me.picBSCount)
        Me.Controls.Add(Me.btnCamDown)
        Me.Controls.Add(Me.btnCamLeft)
        Me.Controls.Add(Me.btnCamRight)
        Me.Controls.Add(Me.btnCamUp)
        Me.Controls.Add(Me.btnRestartLevel)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.chkMouseConsole)
        Me.Controls.Add(Me.chkFps)
        Me.Name = "frmDebug"
        Me.Text = "Debug Options"
        CType(Me.picBSCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPerfect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkMouseConsole As CheckBox
    Friend WithEvents chkFps As CheckBox
    Friend WithEvents btnNewGame As Button
    Friend WithEvents tmrGame As Timer
    Friend WithEvents btnRestartLevel As Button
    Friend WithEvents btnCamUp As Button
    Friend WithEvents btnCamRight As Button
    Friend WithEvents btnCamLeft As Button
    Friend WithEvents btnCamDown As Button
    Friend WithEvents picBSCount As PictureBox
    Friend WithEvents lblBSCount As Label
    Friend WithEvents lblRCount As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picPerfect As PictureBox
End Class
