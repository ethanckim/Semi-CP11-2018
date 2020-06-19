<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPaint
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
        Me.tmrRepaint = New System.Windows.Forms.Timer(Me.components)
        Me.pbcCanvas = New FinalGameProject.PictureBoxConsumer()
        CType(Me.pbcCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrRepaint
        '
        Me.tmrRepaint.Enabled = True
        Me.tmrRepaint.Interval = 30
        '
        'pbcCanvas
        '
        Me.pbcCanvas.BackColor = System.Drawing.Color.White
        Me.pbcCanvas.Location = New System.Drawing.Point(0, 0)
        Me.pbcCanvas.Name = "pbcCanvas"
        Me.pbcCanvas.Size = New System.Drawing.Size(512, 552)
        Me.pbcCanvas.TabIndex = 0
        Me.pbcCanvas.TabStop = False
        '
        'frmPaint
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(512, 552)
        Me.Controls.Add(Me.pbcCanvas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmPaint"
        Me.Text = "Final Game"
        CType(Me.pbcCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbcCanvas As PictureBoxConsumer
    Friend WithEvents tmrRepaint As Timer
End Class
