<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelloWorld
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
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(12, 12)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(260, 73)
        Me.btnFirst.TabIndex = 0
        Me.btnFirst.Text = "My First Button"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'frmHelloWorld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 97)
        Me.Controls.Add(Me.btnFirst)
        Me.Name = "frmHelloWorld"
        Me.Text = "Ethan's First Program"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnFirst As Button
End Class
