<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBaseballScoreboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblBall = New System.Windows.Forms.Label()
        Me.lblOut = New System.Windows.Forms.Label()
        Me.lblStrike = New System.Windows.Forms.Label()
        Me.lblAtBat = New System.Windows.Forms.Label()
        Me.lblFielding = New System.Windows.Forms.Label()
        Me.txtPlayerNumber = New System.Windows.Forms.TextBox()
        Me.txtAway1 = New System.Windows.Forms.TextBox()
        Me.txtHome1 = New System.Windows.Forms.TextBox()
        Me.txtHome2 = New System.Windows.Forms.TextBox()
        Me.txtAway2 = New System.Windows.Forms.TextBox()
        Me.txtHome3 = New System.Windows.Forms.TextBox()
        Me.txtAway3 = New System.Windows.Forms.TextBox()
        Me.txtHome4 = New System.Windows.Forms.TextBox()
        Me.txtAway4 = New System.Windows.Forms.TextBox()
        Me.txtHome5 = New System.Windows.Forms.TextBox()
        Me.txtAway5 = New System.Windows.Forms.TextBox()
        Me.txtHome6 = New System.Windows.Forms.TextBox()
        Me.txtAway6 = New System.Windows.Forms.TextBox()
        Me.txtHome7 = New System.Windows.Forms.TextBox()
        Me.txtAway7 = New System.Windows.Forms.TextBox()
        Me.txtHome8 = New System.Windows.Forms.TextBox()
        Me.txtAway8 = New System.Windows.Forms.TextBox()
        Me.txtHome9 = New System.Windows.Forms.TextBox()
        Me.txtAway9 = New System.Windows.Forms.TextBox()
        Me.lblInning1 = New System.Windows.Forms.Label()
        Me.lblInning2 = New System.Windows.Forms.Label()
        Me.lblInning3 = New System.Windows.Forms.Label()
        Me.lblInning4 = New System.Windows.Forms.Label()
        Me.lblInning5 = New System.Windows.Forms.Label()
        Me.lblInning6 = New System.Windows.Forms.Label()
        Me.lblInning7 = New System.Windows.Forms.Label()
        Me.lblInning8 = New System.Windows.Forms.Label()
        Me.lblInning9 = New System.Windows.Forms.Label()
        Me.lblPitchClock = New System.Windows.Forms.Label()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.lblSecUnit = New System.Windows.Forms.Label()
        Me.lblTenths = New System.Windows.Forms.Label()
        Me.txtAwayR = New System.Windows.Forms.TextBox()
        Me.txtAwayH = New System.Windows.Forms.TextBox()
        Me.txtHomeH = New System.Windows.Forms.TextBox()
        Me.lblHits = New System.Windows.Forms.Label()
        Me.lblRuns = New System.Windows.Forms.Label()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.btnHit = New System.Windows.Forms.Button()
        Me.btnBall = New System.Windows.Forms.Button()
        Me.btnStrike = New System.Windows.Forms.Button()
        Me.btnStartEnd = New System.Windows.Forms.Button()
        Me.lblAwayInnings = New System.Windows.Forms.Label()
        Me.lblHomeInnings = New System.Windows.Forms.Label()
        Me.txtHomeR = New System.Windows.Forms.TextBox()
        Me.tmrPitchClock = New System.Windows.Forms.Timer(Me.components)
        Me.lblField = New System.Windows.Forms.Label()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.tmrWait = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picActiveBase3 = New System.Windows.Forms.PictureBox()
        Me.picActiveBase1 = New System.Windows.Forms.PictureBox()
        Me.picUnactiveBase3 = New System.Windows.Forms.PictureBox()
        Me.picUnactiveBase1 = New System.Windows.Forms.PictureBox()
        Me.picActiveBase2 = New System.Windows.Forms.PictureBox()
        Me.picUnactiveBase2 = New System.Windows.Forms.PictureBox()
        Me.picOrioles = New System.Windows.Forms.PictureBox()
        Me.picBlueJays = New System.Windows.Forms.PictureBox()
        Me.picOut2 = New System.Windows.Forms.PictureBox()
        Me.picOut1 = New System.Windows.Forms.PictureBox()
        Me.picStrike2 = New System.Windows.Forms.PictureBox()
        Me.picStrike1 = New System.Windows.Forms.PictureBox()
        Me.picBall3 = New System.Windows.Forms.PictureBox()
        Me.picBall2 = New System.Windows.Forms.PictureBox()
        Me.picBall1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPauseClock = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picActiveBase3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picActiveBase1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUnactiveBase3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUnactiveBase1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picActiveBase2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUnactiveBase2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOrioles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlueJays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOut2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOut1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStrike2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStrike1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBall3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBall2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBall1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBall
        '
        Me.lblBall.AutoSize = True
        Me.lblBall.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBall.Location = New System.Drawing.Point(16, 23)
        Me.lblBall.Name = "lblBall"
        Me.lblBall.Size = New System.Drawing.Size(53, 20)
        Me.lblBall.TabIndex = 0
        Me.lblBall.Text = "BALL"
        '
        'lblOut
        '
        Me.lblOut.AutoSize = True
        Me.lblOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOut.Location = New System.Drawing.Point(342, 23)
        Me.lblOut.Name = "lblOut"
        Me.lblOut.Size = New System.Drawing.Size(45, 20)
        Me.lblOut.TabIndex = 4
        Me.lblOut.Text = "OUT"
        '
        'lblStrike
        '
        Me.lblStrike.AutoSize = True
        Me.lblStrike.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrike.Location = New System.Drawing.Point(178, 23)
        Me.lblStrike.Name = "lblStrike"
        Me.lblStrike.Size = New System.Drawing.Size(73, 20)
        Me.lblStrike.TabIndex = 7
        Me.lblStrike.Text = "STRIKE"
        '
        'lblAtBat
        '
        Me.lblAtBat.AutoSize = True
        Me.lblAtBat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtBat.Location = New System.Drawing.Point(38, 208)
        Me.lblAtBat.Name = "lblAtBat"
        Me.lblAtBat.Size = New System.Drawing.Size(70, 20)
        Me.lblAtBat.TabIndex = 12
        Me.lblAtBat.Text = "AT BAT"
        '
        'lblFielding
        '
        Me.lblFielding.AutoSize = True
        Me.lblFielding.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFielding.Location = New System.Drawing.Point(344, 207)
        Me.lblFielding.Name = "lblFielding"
        Me.lblFielding.Size = New System.Drawing.Size(93, 20)
        Me.lblFielding.TabIndex = 14
        Me.lblFielding.Text = "FIELDING"
        '
        'txtPlayerNumber
        '
        Me.txtPlayerNumber.BackColor = System.Drawing.Color.White
        Me.txtPlayerNumber.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtPlayerNumber.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayerNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPlayerNumber.Location = New System.Drawing.Point(113, 204)
        Me.txtPlayerNumber.Name = "txtPlayerNumber"
        Me.txtPlayerNumber.ReadOnly = True
        Me.txtPlayerNumber.Size = New System.Drawing.Size(27, 28)
        Me.txtPlayerNumber.TabIndex = 16
        Me.txtPlayerNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAway1
        '
        Me.txtAway1.BackColor = System.Drawing.Color.White
        Me.txtAway1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAway1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAway1.Location = New System.Drawing.Point(97, 274)
        Me.txtAway1.Name = "txtAway1"
        Me.txtAway1.ReadOnly = True
        Me.txtAway1.Size = New System.Drawing.Size(27, 28)
        Me.txtAway1.TabIndex = 19
        Me.txtAway1.Text = "0"
        Me.txtAway1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHome1
        '
        Me.txtHome1.BackColor = System.Drawing.Color.White
        Me.txtHome1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtHome1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHome1.Location = New System.Drawing.Point(97, 306)
        Me.txtHome1.Name = "txtHome1"
        Me.txtHome1.ReadOnly = True
        Me.txtHome1.Size = New System.Drawing.Size(27, 28)
        Me.txtHome1.TabIndex = 20
        Me.txtHome1.Text = "0"
        Me.txtHome1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHome2
        '
        Me.txtHome2.BackColor = System.Drawing.Color.White
        Me.txtHome2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtHome2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHome2.Location = New System.Drawing.Point(130, 306)
        Me.txtHome2.Name = "txtHome2"
        Me.txtHome2.ReadOnly = True
        Me.txtHome2.Size = New System.Drawing.Size(27, 28)
        Me.txtHome2.TabIndex = 22
        Me.txtHome2.Text = "0"
        Me.txtHome2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAway2
        '
        Me.txtAway2.BackColor = System.Drawing.Color.White
        Me.txtAway2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAway2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAway2.Location = New System.Drawing.Point(130, 274)
        Me.txtAway2.Name = "txtAway2"
        Me.txtAway2.ReadOnly = True
        Me.txtAway2.Size = New System.Drawing.Size(27, 28)
        Me.txtAway2.TabIndex = 21
        Me.txtAway2.Text = "0"
        Me.txtAway2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHome3
        '
        Me.txtHome3.BackColor = System.Drawing.Color.White
        Me.txtHome3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtHome3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHome3.Location = New System.Drawing.Point(163, 306)
        Me.txtHome3.Name = "txtHome3"
        Me.txtHome3.ReadOnly = True
        Me.txtHome3.Size = New System.Drawing.Size(27, 28)
        Me.txtHome3.TabIndex = 24
        Me.txtHome3.Text = "0"
        Me.txtHome3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAway3
        '
        Me.txtAway3.BackColor = System.Drawing.Color.White
        Me.txtAway3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAway3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAway3.Location = New System.Drawing.Point(163, 274)
        Me.txtAway3.Name = "txtAway3"
        Me.txtAway3.ReadOnly = True
        Me.txtAway3.Size = New System.Drawing.Size(27, 28)
        Me.txtAway3.TabIndex = 23
        Me.txtAway3.Text = "0"
        Me.txtAway3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHome4
        '
        Me.txtHome4.BackColor = System.Drawing.Color.White
        Me.txtHome4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtHome4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHome4.Location = New System.Drawing.Point(196, 306)
        Me.txtHome4.Name = "txtHome4"
        Me.txtHome4.ReadOnly = True
        Me.txtHome4.Size = New System.Drawing.Size(27, 28)
        Me.txtHome4.TabIndex = 26
        Me.txtHome4.Text = "0"
        Me.txtHome4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAway4
        '
        Me.txtAway4.BackColor = System.Drawing.Color.White
        Me.txtAway4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAway4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAway4.Location = New System.Drawing.Point(196, 274)
        Me.txtAway4.Name = "txtAway4"
        Me.txtAway4.ReadOnly = True
        Me.txtAway4.Size = New System.Drawing.Size(27, 28)
        Me.txtAway4.TabIndex = 25
        Me.txtAway4.Text = "0"
        Me.txtAway4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHome5
        '
        Me.txtHome5.BackColor = System.Drawing.Color.White
        Me.txtHome5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtHome5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHome5.Location = New System.Drawing.Point(229, 306)
        Me.txtHome5.Name = "txtHome5"
        Me.txtHome5.ReadOnly = True
        Me.txtHome5.Size = New System.Drawing.Size(27, 28)
        Me.txtHome5.TabIndex = 28
        Me.txtHome5.Text = "0"
        Me.txtHome5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAway5
        '
        Me.txtAway5.BackColor = System.Drawing.Color.White
        Me.txtAway5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAway5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAway5.Location = New System.Drawing.Point(229, 274)
        Me.txtAway5.Name = "txtAway5"
        Me.txtAway5.ReadOnly = True
        Me.txtAway5.Size = New System.Drawing.Size(27, 28)
        Me.txtAway5.TabIndex = 27
        Me.txtAway5.Text = "0"
        Me.txtAway5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHome6
        '
        Me.txtHome6.BackColor = System.Drawing.Color.White
        Me.txtHome6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtHome6.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHome6.Location = New System.Drawing.Point(262, 306)
        Me.txtHome6.Name = "txtHome6"
        Me.txtHome6.ReadOnly = True
        Me.txtHome6.Size = New System.Drawing.Size(27, 28)
        Me.txtHome6.TabIndex = 30
        Me.txtHome6.Text = "0"
        Me.txtHome6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAway6
        '
        Me.txtAway6.BackColor = System.Drawing.Color.White
        Me.txtAway6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAway6.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAway6.Location = New System.Drawing.Point(262, 274)
        Me.txtAway6.Name = "txtAway6"
        Me.txtAway6.ReadOnly = True
        Me.txtAway6.Size = New System.Drawing.Size(27, 28)
        Me.txtAway6.TabIndex = 29
        Me.txtAway6.Text = "0"
        Me.txtAway6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHome7
        '
        Me.txtHome7.BackColor = System.Drawing.Color.White
        Me.txtHome7.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtHome7.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHome7.Location = New System.Drawing.Point(295, 306)
        Me.txtHome7.Name = "txtHome7"
        Me.txtHome7.ReadOnly = True
        Me.txtHome7.Size = New System.Drawing.Size(27, 28)
        Me.txtHome7.TabIndex = 32
        Me.txtHome7.Text = "0"
        Me.txtHome7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAway7
        '
        Me.txtAway7.BackColor = System.Drawing.Color.White
        Me.txtAway7.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAway7.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAway7.Location = New System.Drawing.Point(295, 274)
        Me.txtAway7.Name = "txtAway7"
        Me.txtAway7.ReadOnly = True
        Me.txtAway7.Size = New System.Drawing.Size(27, 28)
        Me.txtAway7.TabIndex = 31
        Me.txtAway7.Text = "0"
        Me.txtAway7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHome8
        '
        Me.txtHome8.BackColor = System.Drawing.Color.White
        Me.txtHome8.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtHome8.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHome8.Location = New System.Drawing.Point(328, 306)
        Me.txtHome8.Name = "txtHome8"
        Me.txtHome8.ReadOnly = True
        Me.txtHome8.Size = New System.Drawing.Size(27, 28)
        Me.txtHome8.TabIndex = 34
        Me.txtHome8.Text = "0"
        Me.txtHome8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAway8
        '
        Me.txtAway8.BackColor = System.Drawing.Color.White
        Me.txtAway8.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAway8.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAway8.Location = New System.Drawing.Point(328, 274)
        Me.txtAway8.Name = "txtAway8"
        Me.txtAway8.ReadOnly = True
        Me.txtAway8.Size = New System.Drawing.Size(27, 28)
        Me.txtAway8.TabIndex = 33
        Me.txtAway8.Text = "0"
        Me.txtAway8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHome9
        '
        Me.txtHome9.BackColor = System.Drawing.Color.White
        Me.txtHome9.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtHome9.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHome9.Location = New System.Drawing.Point(362, 306)
        Me.txtHome9.Name = "txtHome9"
        Me.txtHome9.ReadOnly = True
        Me.txtHome9.Size = New System.Drawing.Size(27, 28)
        Me.txtHome9.TabIndex = 36
        Me.txtHome9.Text = "0"
        Me.txtHome9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAway9
        '
        Me.txtAway9.BackColor = System.Drawing.Color.White
        Me.txtAway9.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAway9.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAway9.Location = New System.Drawing.Point(362, 274)
        Me.txtAway9.Name = "txtAway9"
        Me.txtAway9.ReadOnly = True
        Me.txtAway9.Size = New System.Drawing.Size(27, 28)
        Me.txtAway9.TabIndex = 35
        Me.txtAway9.Text = "0"
        Me.txtAway9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblInning1
        '
        Me.lblInning1.AutoSize = True
        Me.lblInning1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInning1.Location = New System.Drawing.Point(101, 251)
        Me.lblInning1.Name = "lblInning1"
        Me.lblInning1.Size = New System.Drawing.Size(19, 20)
        Me.lblInning1.TabIndex = 37
        Me.lblInning1.Text = "1"
        '
        'lblInning2
        '
        Me.lblInning2.AutoSize = True
        Me.lblInning2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInning2.Location = New System.Drawing.Point(134, 251)
        Me.lblInning2.Name = "lblInning2"
        Me.lblInning2.Size = New System.Drawing.Size(19, 20)
        Me.lblInning2.TabIndex = 38
        Me.lblInning2.Text = "2"
        '
        'lblInning3
        '
        Me.lblInning3.AutoSize = True
        Me.lblInning3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInning3.Location = New System.Drawing.Point(167, 251)
        Me.lblInning3.Name = "lblInning3"
        Me.lblInning3.Size = New System.Drawing.Size(19, 20)
        Me.lblInning3.TabIndex = 39
        Me.lblInning3.Text = "3"
        '
        'lblInning4
        '
        Me.lblInning4.AutoSize = True
        Me.lblInning4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInning4.Location = New System.Drawing.Point(200, 251)
        Me.lblInning4.Name = "lblInning4"
        Me.lblInning4.Size = New System.Drawing.Size(19, 20)
        Me.lblInning4.TabIndex = 40
        Me.lblInning4.Text = "4"
        '
        'lblInning5
        '
        Me.lblInning5.AutoSize = True
        Me.lblInning5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInning5.Location = New System.Drawing.Point(233, 251)
        Me.lblInning5.Name = "lblInning5"
        Me.lblInning5.Size = New System.Drawing.Size(19, 20)
        Me.lblInning5.TabIndex = 41
        Me.lblInning5.Text = "5"
        '
        'lblInning6
        '
        Me.lblInning6.AutoSize = True
        Me.lblInning6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInning6.Location = New System.Drawing.Point(266, 251)
        Me.lblInning6.Name = "lblInning6"
        Me.lblInning6.Size = New System.Drawing.Size(19, 20)
        Me.lblInning6.TabIndex = 42
        Me.lblInning6.Text = "6"
        '
        'lblInning7
        '
        Me.lblInning7.AutoSize = True
        Me.lblInning7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInning7.Location = New System.Drawing.Point(298, 251)
        Me.lblInning7.Name = "lblInning7"
        Me.lblInning7.Size = New System.Drawing.Size(19, 20)
        Me.lblInning7.TabIndex = 43
        Me.lblInning7.Text = "7"
        '
        'lblInning8
        '
        Me.lblInning8.AutoSize = True
        Me.lblInning8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInning8.Location = New System.Drawing.Point(332, 251)
        Me.lblInning8.Name = "lblInning8"
        Me.lblInning8.Size = New System.Drawing.Size(19, 20)
        Me.lblInning8.TabIndex = 44
        Me.lblInning8.Text = "8"
        '
        'lblInning9
        '
        Me.lblInning9.AutoSize = True
        Me.lblInning9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInning9.Location = New System.Drawing.Point(366, 251)
        Me.lblInning9.Name = "lblInning9"
        Me.lblInning9.Size = New System.Drawing.Size(19, 20)
        Me.lblInning9.TabIndex = 45
        Me.lblInning9.Text = "9"
        '
        'lblPitchClock
        '
        Me.lblPitchClock.AutoSize = True
        Me.lblPitchClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPitchClock.Location = New System.Drawing.Point(181, 92)
        Me.lblPitchClock.Name = "lblPitchClock"
        Me.lblPitchClock.Size = New System.Drawing.Size(124, 20)
        Me.lblPitchClock.TabIndex = 46
        Me.lblPitchClock.Text = "PITCH CLOCK"
        '
        'lblSeconds
        '
        Me.lblSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconds.Location = New System.Drawing.Point(208, 65)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(38, 20)
        Me.lblSeconds.TabIndex = 47
        Me.lblSeconds.Text = "20"
        Me.lblSeconds.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblSecUnit
        '
        Me.lblSecUnit.AutoSize = True
        Me.lblSecUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecUnit.Location = New System.Drawing.Point(242, 72)
        Me.lblSecUnit.Name = "lblSecUnit"
        Me.lblSecUnit.Size = New System.Drawing.Size(15, 15)
        Me.lblSecUnit.TabIndex = 48
        Me.lblSecUnit.Text = "S"
        '
        'lblTenths
        '
        Me.lblTenths.AutoSize = True
        Me.lblTenths.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenths.Location = New System.Drawing.Point(264, 72)
        Me.lblTenths.Name = "lblTenths"
        Me.lblTenths.Size = New System.Drawing.Size(15, 15)
        Me.lblTenths.TabIndex = 49
        Me.lblTenths.Text = "0"
        '
        'txtAwayR
        '
        Me.txtAwayR.BackColor = System.Drawing.Color.White
        Me.txtAwayR.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAwayR.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAwayR.Location = New System.Drawing.Point(410, 274)
        Me.txtAwayR.Name = "txtAwayR"
        Me.txtAwayR.ReadOnly = True
        Me.txtAwayR.Size = New System.Drawing.Size(42, 28)
        Me.txtAwayR.TabIndex = 50
        Me.txtAwayR.Text = "0"
        Me.txtAwayR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAwayH
        '
        Me.txtAwayH.BackColor = System.Drawing.Color.White
        Me.txtAwayH.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAwayH.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAwayH.Location = New System.Drawing.Point(458, 274)
        Me.txtAwayH.Name = "txtAwayH"
        Me.txtAwayH.ReadOnly = True
        Me.txtAwayH.Size = New System.Drawing.Size(42, 28)
        Me.txtAwayH.TabIndex = 53
        Me.txtAwayH.Text = "0"
        Me.txtAwayH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHomeH
        '
        Me.txtHomeH.BackColor = System.Drawing.Color.White
        Me.txtHomeH.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtHomeH.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHomeH.Location = New System.Drawing.Point(458, 306)
        Me.txtHomeH.Name = "txtHomeH"
        Me.txtHomeH.ReadOnly = True
        Me.txtHomeH.Size = New System.Drawing.Size(42, 28)
        Me.txtHomeH.TabIndex = 54
        Me.txtHomeH.Text = "0"
        Me.txtHomeH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHits
        '
        Me.lblHits.AutoSize = True
        Me.lblHits.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHits.Location = New System.Drawing.Point(468, 251)
        Me.lblHits.Name = "lblHits"
        Me.lblHits.Size = New System.Drawing.Size(22, 20)
        Me.lblHits.TabIndex = 58
        Me.lblHits.Text = "H"
        '
        'lblRuns
        '
        Me.lblRuns.AutoSize = True
        Me.lblRuns.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRuns.Location = New System.Drawing.Point(419, 251)
        Me.lblRuns.Name = "lblRuns"
        Me.lblRuns.Size = New System.Drawing.Size(22, 20)
        Me.lblRuns.TabIndex = 59
        Me.lblRuns.Text = "R"
        '
        'txtLog
        '
        Me.txtLog.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtLog.Location = New System.Drawing.Point(20, 345)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(537, 109)
        Me.txtLog.TabIndex = 60
        '
        'btnHit
        '
        Me.btnHit.Enabled = False
        Me.btnHit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHit.Location = New System.Drawing.Point(482, 137)
        Me.btnHit.Name = "btnHit"
        Me.btnHit.Size = New System.Drawing.Size(75, 23)
        Me.btnHit.TabIndex = 68
        Me.btnHit.Text = "Hit"
        Me.btnHit.UseVisualStyleBackColor = True
        '
        'btnBall
        '
        Me.btnBall.Enabled = False
        Me.btnBall.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBall.Location = New System.Drawing.Point(482, 166)
        Me.btnBall.Name = "btnBall"
        Me.btnBall.Size = New System.Drawing.Size(75, 23)
        Me.btnBall.TabIndex = 69
        Me.btnBall.Text = "Ball"
        Me.btnBall.UseVisualStyleBackColor = True
        '
        'btnStrike
        '
        Me.btnStrike.Enabled = False
        Me.btnStrike.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStrike.Location = New System.Drawing.Point(482, 195)
        Me.btnStrike.Name = "btnStrike"
        Me.btnStrike.Size = New System.Drawing.Size(75, 23)
        Me.btnStrike.TabIndex = 70
        Me.btnStrike.Text = "Strike"
        Me.btnStrike.UseVisualStyleBackColor = True
        '
        'btnStartEnd
        '
        Me.btnStartEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartEnd.Location = New System.Drawing.Point(459, 14)
        Me.btnStartEnd.Name = "btnStartEnd"
        Me.btnStartEnd.Size = New System.Drawing.Size(107, 53)
        Me.btnStartEnd.TabIndex = 71
        Me.btnStartEnd.Text = "Play Ball!"
        Me.btnStartEnd.UseVisualStyleBackColor = True
        '
        'lblAwayInnings
        '
        Me.lblAwayInnings.AutoSize = True
        Me.lblAwayInnings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAwayInnings.Location = New System.Drawing.Point(30, 278)
        Me.lblAwayInnings.Name = "lblAwayInnings"
        Me.lblAwayInnings.Size = New System.Drawing.Size(61, 20)
        Me.lblAwayInnings.TabIndex = 17
        Me.lblAwayInnings.Text = "AWAY"
        '
        'lblHomeInnings
        '
        Me.lblHomeInnings.AutoSize = True
        Me.lblHomeInnings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeInnings.Location = New System.Drawing.Point(30, 310)
        Me.lblHomeInnings.Name = "lblHomeInnings"
        Me.lblHomeInnings.Size = New System.Drawing.Size(61, 20)
        Me.lblHomeInnings.TabIndex = 18
        Me.lblHomeInnings.Text = "HOME"
        '
        'txtHomeR
        '
        Me.txtHomeR.BackColor = System.Drawing.Color.White
        Me.txtHomeR.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtHomeR.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHomeR.Location = New System.Drawing.Point(410, 306)
        Me.txtHomeR.Name = "txtHomeR"
        Me.txtHomeR.ReadOnly = True
        Me.txtHomeR.Size = New System.Drawing.Size(42, 28)
        Me.txtHomeR.TabIndex = 51
        Me.txtHomeR.Text = "0"
        Me.txtHomeR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tmrPitchClock
        '
        Me.tmrPitchClock.Interval = 30
        '
        'lblField
        '
        Me.lblField.AutoSize = True
        Me.lblField.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblField.Location = New System.Drawing.Point(59, 74)
        Me.lblField.Name = "lblField"
        Me.lblField.Size = New System.Drawing.Size(61, 20)
        Me.lblField.TabIndex = 72
        Me.lblField.Text = "AWAY"
        '
        'lblHome
        '
        Me.lblHome.AutoSize = True
        Me.lblHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHome.Location = New System.Drawing.Point(363, 75)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(61, 20)
        Me.lblHome.TabIndex = 73
        Me.lblHome.Text = "HOME"
        '
        'tmrWait
        '
        Me.tmrWait.Interval = 500
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Baseball_Scoreboard.My.Resources.Resources.Homebase
        Me.PictureBox1.Location = New System.Drawing.Point(225, 192)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'picActiveBase3
        '
        Me.picActiveBase3.Image = Global.Baseball_Scoreboard.My.Resources.Resources.PlateActive
        Me.picActiveBase3.Location = New System.Drawing.Point(192, 156)
        Me.picActiveBase3.Name = "picActiveBase3"
        Me.picActiveBase3.Size = New System.Drawing.Size(44, 42)
        Me.picActiveBase3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picActiveBase3.TabIndex = 66
        Me.picActiveBase3.TabStop = False
        Me.picActiveBase3.Visible = False
        '
        'picActiveBase1
        '
        Me.picActiveBase1.Image = Global.Baseball_Scoreboard.My.Resources.Resources.PlateActive
        Me.picActiveBase1.Location = New System.Drawing.Point(252, 156)
        Me.picActiveBase1.Name = "picActiveBase1"
        Me.picActiveBase1.Size = New System.Drawing.Size(44, 42)
        Me.picActiveBase1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picActiveBase1.TabIndex = 65
        Me.picActiveBase1.TabStop = False
        Me.picActiveBase1.Visible = False
        '
        'picUnactiveBase3
        '
        Me.picUnactiveBase3.Image = Global.Baseball_Scoreboard.My.Resources.Resources.PlateUnactive
        Me.picUnactiveBase3.Location = New System.Drawing.Point(192, 156)
        Me.picUnactiveBase3.Name = "picUnactiveBase3"
        Me.picUnactiveBase3.Size = New System.Drawing.Size(44, 42)
        Me.picUnactiveBase3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUnactiveBase3.TabIndex = 64
        Me.picUnactiveBase3.TabStop = False
        '
        'picUnactiveBase1
        '
        Me.picUnactiveBase1.Image = Global.Baseball_Scoreboard.My.Resources.Resources.PlateUnactive
        Me.picUnactiveBase1.Location = New System.Drawing.Point(252, 156)
        Me.picUnactiveBase1.Name = "picUnactiveBase1"
        Me.picUnactiveBase1.Size = New System.Drawing.Size(44, 42)
        Me.picUnactiveBase1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUnactiveBase1.TabIndex = 63
        Me.picUnactiveBase1.TabStop = False
        '
        'picActiveBase2
        '
        Me.picActiveBase2.Image = Global.Baseball_Scoreboard.My.Resources.Resources.PlateActive
        Me.picActiveBase2.Location = New System.Drawing.Point(222, 126)
        Me.picActiveBase2.Name = "picActiveBase2"
        Me.picActiveBase2.Size = New System.Drawing.Size(44, 42)
        Me.picActiveBase2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picActiveBase2.TabIndex = 62
        Me.picActiveBase2.TabStop = False
        Me.picActiveBase2.Visible = False
        '
        'picUnactiveBase2
        '
        Me.picUnactiveBase2.Image = Global.Baseball_Scoreboard.My.Resources.Resources.PlateUnactive
        Me.picUnactiveBase2.Location = New System.Drawing.Point(222, 126)
        Me.picUnactiveBase2.Name = "picUnactiveBase2"
        Me.picUnactiveBase2.Size = New System.Drawing.Size(44, 42)
        Me.picUnactiveBase2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUnactiveBase2.TabIndex = 61
        Me.picUnactiveBase2.TabStop = False
        '
        'picOrioles
        '
        Me.picOrioles.Image = Global.Baseball_Scoreboard.My.Resources.Resources.Orioles
        Me.picOrioles.Location = New System.Drawing.Point(342, 98)
        Me.picOrioles.Name = "picOrioles"
        Me.picOrioles.Size = New System.Drawing.Size(96, 102)
        Me.picOrioles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOrioles.TabIndex = 15
        Me.picOrioles.TabStop = False
        '
        'picBlueJays
        '
        Me.picBlueJays.Image = Global.Baseball_Scoreboard.My.Resources.Resources.BlueJays
        Me.picBlueJays.Location = New System.Drawing.Point(42, 97)
        Me.picBlueJays.Name = "picBlueJays"
        Me.picBlueJays.Size = New System.Drawing.Size(96, 102)
        Me.picBlueJays.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBlueJays.TabIndex = 13
        Me.picBlueJays.TabStop = False
        '
        'picOut2
        '
        Me.picOut2.BackColor = System.Drawing.SystemColors.Control
        Me.picOut2.Image = Global.Baseball_Scoreboard.My.Resources.Resources.outCounter
        Me.picOut2.Location = New System.Drawing.Point(420, 20)
        Me.picOut2.Name = "picOut2"
        Me.picOut2.Size = New System.Drawing.Size(24, 26)
        Me.picOut2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOut2.TabIndex = 11
        Me.picOut2.TabStop = False
        Me.picOut2.Visible = False
        '
        'picOut1
        '
        Me.picOut1.BackColor = System.Drawing.SystemColors.Control
        Me.picOut1.Image = Global.Baseball_Scoreboard.My.Resources.Resources.outCounter
        Me.picOut1.Location = New System.Drawing.Point(393, 20)
        Me.picOut1.Name = "picOut1"
        Me.picOut1.Size = New System.Drawing.Size(24, 26)
        Me.picOut1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOut1.TabIndex = 10
        Me.picOut1.TabStop = False
        Me.picOut1.Visible = False
        '
        'picStrike2
        '
        Me.picStrike2.BackColor = System.Drawing.SystemColors.Control
        Me.picStrike2.Image = Global.Baseball_Scoreboard.My.Resources.Resources.strikeCounter
        Me.picStrike2.Location = New System.Drawing.Point(286, 22)
        Me.picStrike2.Name = "picStrike2"
        Me.picStrike2.Size = New System.Drawing.Size(30, 21)
        Me.picStrike2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picStrike2.TabIndex = 9
        Me.picStrike2.TabStop = False
        Me.picStrike2.Visible = False
        '
        'picStrike1
        '
        Me.picStrike1.BackColor = System.Drawing.SystemColors.Control
        Me.picStrike1.Image = Global.Baseball_Scoreboard.My.Resources.Resources.strikeCounter
        Me.picStrike1.Location = New System.Drawing.Point(257, 22)
        Me.picStrike1.Name = "picStrike1"
        Me.picStrike1.Size = New System.Drawing.Size(30, 21)
        Me.picStrike1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picStrike1.TabIndex = 8
        Me.picStrike1.TabStop = False
        Me.picStrike1.Visible = False
        '
        'picBall3
        '
        Me.picBall3.BackColor = System.Drawing.SystemColors.Control
        Me.picBall3.Image = Global.Baseball_Scoreboard.My.Resources.Resources.ballCounter
        Me.picBall3.Location = New System.Drawing.Point(131, 23)
        Me.picBall3.Name = "picBall3"
        Me.picBall3.Size = New System.Drawing.Size(25, 21)
        Me.picBall3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBall3.TabIndex = 3
        Me.picBall3.TabStop = False
        Me.picBall3.Visible = False
        '
        'picBall2
        '
        Me.picBall2.BackColor = System.Drawing.SystemColors.Control
        Me.picBall2.Image = Global.Baseball_Scoreboard.My.Resources.Resources.ballCounter
        Me.picBall2.Location = New System.Drawing.Point(103, 23)
        Me.picBall2.Name = "picBall2"
        Me.picBall2.Size = New System.Drawing.Size(25, 21)
        Me.picBall2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBall2.TabIndex = 2
        Me.picBall2.TabStop = False
        Me.picBall2.Visible = False
        '
        'picBall1
        '
        Me.picBall1.BackColor = System.Drawing.SystemColors.Control
        Me.picBall1.Image = Global.Baseball_Scoreboard.My.Resources.Resources.ballCounter
        Me.picBall1.Location = New System.Drawing.Point(75, 23)
        Me.picBall1.Name = "picBall1"
        Me.picBall1.Size = New System.Drawing.Size(25, 21)
        Me.picBall1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBall1.TabIndex = 1
        Me.picBall1.TabStop = False
        Me.picBall1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(438, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "*Click Fouls penalties here*"
        '
        'btnPauseClock
        '
        Me.btnPauseClock.Enabled = False
        Me.btnPauseClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPauseClock.Location = New System.Drawing.Point(467, 79)
        Me.btnPauseClock.Name = "btnPauseClock"
        Me.btnPauseClock.Size = New System.Drawing.Size(93, 47)
        Me.btnPauseClock.TabIndex = 75
        Me.btnPauseClock.Text = "Pause Pitch Clock"
        Me.btnPauseClock.UseVisualStyleBackColor = True
        '
        'frmBaseballScoreboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 466)
        Me.Controls.Add(Me.btnPauseClock)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHome)
        Me.Controls.Add(Me.lblField)
        Me.Controls.Add(Me.btnStartEnd)
        Me.Controls.Add(Me.btnStrike)
        Me.Controls.Add(Me.btnBall)
        Me.Controls.Add(Me.btnHit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picActiveBase3)
        Me.Controls.Add(Me.picActiveBase1)
        Me.Controls.Add(Me.picUnactiveBase3)
        Me.Controls.Add(Me.picUnactiveBase1)
        Me.Controls.Add(Me.picActiveBase2)
        Me.Controls.Add(Me.picUnactiveBase2)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.lblRuns)
        Me.Controls.Add(Me.lblHits)
        Me.Controls.Add(Me.txtHomeH)
        Me.Controls.Add(Me.txtAwayH)
        Me.Controls.Add(Me.txtHomeR)
        Me.Controls.Add(Me.txtAwayR)
        Me.Controls.Add(Me.lblTenths)
        Me.Controls.Add(Me.lblSecUnit)
        Me.Controls.Add(Me.lblSeconds)
        Me.Controls.Add(Me.lblPitchClock)
        Me.Controls.Add(Me.lblInning9)
        Me.Controls.Add(Me.lblInning8)
        Me.Controls.Add(Me.lblInning7)
        Me.Controls.Add(Me.lblInning6)
        Me.Controls.Add(Me.lblInning5)
        Me.Controls.Add(Me.lblInning4)
        Me.Controls.Add(Me.lblInning3)
        Me.Controls.Add(Me.lblInning2)
        Me.Controls.Add(Me.lblInning1)
        Me.Controls.Add(Me.txtHome9)
        Me.Controls.Add(Me.txtAway9)
        Me.Controls.Add(Me.txtHome8)
        Me.Controls.Add(Me.txtAway8)
        Me.Controls.Add(Me.txtHome7)
        Me.Controls.Add(Me.txtAway7)
        Me.Controls.Add(Me.txtHome6)
        Me.Controls.Add(Me.txtAway6)
        Me.Controls.Add(Me.txtHome5)
        Me.Controls.Add(Me.txtAway5)
        Me.Controls.Add(Me.txtHome4)
        Me.Controls.Add(Me.txtAway4)
        Me.Controls.Add(Me.txtHome3)
        Me.Controls.Add(Me.txtAway3)
        Me.Controls.Add(Me.txtHome2)
        Me.Controls.Add(Me.txtAway2)
        Me.Controls.Add(Me.txtHome1)
        Me.Controls.Add(Me.txtAway1)
        Me.Controls.Add(Me.lblHomeInnings)
        Me.Controls.Add(Me.lblAwayInnings)
        Me.Controls.Add(Me.txtPlayerNumber)
        Me.Controls.Add(Me.picOrioles)
        Me.Controls.Add(Me.lblFielding)
        Me.Controls.Add(Me.picBlueJays)
        Me.Controls.Add(Me.lblAtBat)
        Me.Controls.Add(Me.picOut2)
        Me.Controls.Add(Me.picOut1)
        Me.Controls.Add(Me.picStrike2)
        Me.Controls.Add(Me.picStrike1)
        Me.Controls.Add(Me.lblStrike)
        Me.Controls.Add(Me.lblOut)
        Me.Controls.Add(Me.picBall3)
        Me.Controls.Add(Me.picBall2)
        Me.Controls.Add(Me.picBall1)
        Me.Controls.Add(Me.lblBall)
        Me.Name = "frmBaseballScoreboard"
        Me.Text = "Baseball Scoreboard"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picActiveBase3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picActiveBase1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUnactiveBase3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUnactiveBase1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picActiveBase2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUnactiveBase2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOrioles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlueJays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOut2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOut1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStrike2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStrike1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBall3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBall2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBall1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBall As Label
    Friend WithEvents picBall1 As PictureBox
    Friend WithEvents picBall2 As PictureBox
    Friend WithEvents picBall3 As PictureBox
    Friend WithEvents lblOut As Label
    Friend WithEvents lblStrike As Label
    Friend WithEvents picStrike1 As PictureBox
    Friend WithEvents picStrike2 As PictureBox
    Friend WithEvents picOut1 As PictureBox
    Friend WithEvents picOut2 As PictureBox
    Friend WithEvents lblAtBat As Label
    Friend WithEvents picBlueJays As PictureBox
    Friend WithEvents lblFielding As Label
    Friend WithEvents picOrioles As PictureBox
    Friend WithEvents txtPlayerNumber As TextBox
    Friend WithEvents txtAway1 As TextBox
    Friend WithEvents txtHome1 As TextBox
    Friend WithEvents txtHome2 As TextBox
    Friend WithEvents txtAway2 As TextBox
    Friend WithEvents txtHome3 As TextBox
    Friend WithEvents txtAway3 As TextBox
    Friend WithEvents txtHome4 As TextBox
    Friend WithEvents txtAway4 As TextBox
    Friend WithEvents txtHome5 As TextBox
    Friend WithEvents txtAway5 As TextBox
    Friend WithEvents txtHome6 As TextBox
    Friend WithEvents txtAway6 As TextBox
    Friend WithEvents txtHome7 As TextBox
    Friend WithEvents txtAway7 As TextBox
    Friend WithEvents txtHome8 As TextBox
    Friend WithEvents txtAway8 As TextBox
    Friend WithEvents txtHome9 As TextBox
    Friend WithEvents txtAway9 As TextBox
    Friend WithEvents lblInning1 As Label
    Friend WithEvents lblInning2 As Label
    Friend WithEvents lblInning3 As Label
    Friend WithEvents lblInning4 As Label
    Friend WithEvents lblInning5 As Label
    Friend WithEvents lblInning6 As Label
    Friend WithEvents lblInning7 As Label
    Friend WithEvents lblInning8 As Label
    Friend WithEvents lblInning9 As Label
    Friend WithEvents lblPitchClock As Label
    Friend WithEvents lblSeconds As Label
    Friend WithEvents lblSecUnit As Label
    Friend WithEvents lblTenths As Label
    Friend WithEvents txtAwayR As TextBox
    Friend WithEvents txtAwayH As TextBox
    Friend WithEvents txtHomeH As TextBox
    Friend WithEvents lblHits As Label
    Friend WithEvents lblRuns As Label
    Friend WithEvents txtLog As TextBox
    Friend WithEvents picUnactiveBase2 As PictureBox
    Friend WithEvents picActiveBase2 As PictureBox
    Friend WithEvents picUnactiveBase1 As PictureBox
    Friend WithEvents picUnactiveBase3 As PictureBox
    Friend WithEvents picActiveBase1 As PictureBox
    Friend WithEvents picActiveBase3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnHit As Button
    Friend WithEvents btnBall As Button
    Friend WithEvents btnStrike As Button
    Friend WithEvents btnStartEnd As Button
    Friend WithEvents lblAwayInnings As Label
    Friend WithEvents lblHomeInnings As Label
    Friend WithEvents txtHomeR As TextBox
    Friend WithEvents tmrPitchClock As Timer
    Friend WithEvents lblField As Label
    Friend WithEvents lblHome As Label
    Friend WithEvents tmrWait As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPauseClock As Button
End Class
