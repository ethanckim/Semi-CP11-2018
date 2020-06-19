<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShapeList
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
        Me.grpRectangle = New System.Windows.Forms.GroupBox()
        Me.btnAddRec = New System.Windows.Forms.Button()
        Me.lblRecL = New System.Windows.Forms.Label()
        Me.lblRecW = New System.Windows.Forms.Label()
        Me.txtRecL = New System.Windows.Forms.TextBox()
        Me.txtRecW = New System.Windows.Forms.TextBox()
        Me.grpCircle = New System.Windows.Forms.GroupBox()
        Me.btnAddCcl = New System.Windows.Forms.Button()
        Me.lblCclR = New System.Windows.Forms.Label()
        Me.txtCclR = New System.Windows.Forms.TextBox()
        Me.grpRightTriangle = New System.Windows.Forms.GroupBox()
        Me.btnAddTri = New System.Windows.Forms.Button()
        Me.lblTriH = New System.Windows.Forms.Label()
        Me.txtTriH = New System.Windows.Forms.TextBox()
        Me.lblTriB = New System.Windows.Forms.Label()
        Me.txtTriB = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.grpRectangle.SuspendLayout()
        Me.grpCircle.SuspendLayout()
        Me.grpRightTriangle.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpRectangle
        '
        Me.grpRectangle.Controls.Add(Me.btnAddRec)
        Me.grpRectangle.Controls.Add(Me.lblRecL)
        Me.grpRectangle.Controls.Add(Me.lblRecW)
        Me.grpRectangle.Controls.Add(Me.txtRecL)
        Me.grpRectangle.Controls.Add(Me.txtRecW)
        Me.grpRectangle.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRectangle.Location = New System.Drawing.Point(18, 69)
        Me.grpRectangle.Name = "grpRectangle"
        Me.grpRectangle.Size = New System.Drawing.Size(191, 139)
        Me.grpRectangle.TabIndex = 0
        Me.grpRectangle.TabStop = False
        Me.grpRectangle.Text = "Rectangle"
        '
        'btnAddRec
        '
        Me.btnAddRec.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRec.Location = New System.Drawing.Point(20, 100)
        Me.btnAddRec.Name = "btnAddRec"
        Me.btnAddRec.Size = New System.Drawing.Size(154, 28)
        Me.btnAddRec.TabIndex = 6
        Me.btnAddRec.Text = "Add"
        Me.btnAddRec.UseVisualStyleBackColor = True
        '
        'lblRecL
        '
        Me.lblRecL.AutoSize = True
        Me.lblRecL.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecL.Location = New System.Drawing.Point(16, 31)
        Me.lblRecL.Name = "lblRecL"
        Me.lblRecL.Size = New System.Drawing.Size(60, 19)
        Me.lblRecL.TabIndex = 3
        Me.lblRecL.Text = "Length"
        '
        'lblRecW
        '
        Me.lblRecW.AutoSize = True
        Me.lblRecW.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecW.Location = New System.Drawing.Point(16, 65)
        Me.lblRecW.Name = "lblRecW"
        Me.lblRecW.Size = New System.Drawing.Size(53, 19)
        Me.lblRecW.TabIndex = 2
        Me.lblRecW.Text = "Width"
        '
        'txtRecL
        '
        Me.txtRecL.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecL.Location = New System.Drawing.Point(89, 29)
        Me.txtRecL.Name = "txtRecL"
        Me.txtRecL.Size = New System.Drawing.Size(85, 24)
        Me.txtRecL.TabIndex = 1
        Me.txtRecL.Text = "0"
        '
        'txtRecW
        '
        Me.txtRecW.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecW.Location = New System.Drawing.Point(89, 63)
        Me.txtRecW.Name = "txtRecW"
        Me.txtRecW.Size = New System.Drawing.Size(85, 24)
        Me.txtRecW.TabIndex = 0
        Me.txtRecW.Text = "0"
        '
        'grpCircle
        '
        Me.grpCircle.Controls.Add(Me.btnAddCcl)
        Me.grpCircle.Controls.Add(Me.lblCclR)
        Me.grpCircle.Controls.Add(Me.txtCclR)
        Me.grpCircle.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCircle.Location = New System.Drawing.Point(18, 222)
        Me.grpCircle.Name = "grpCircle"
        Me.grpCircle.Size = New System.Drawing.Size(191, 139)
        Me.grpCircle.TabIndex = 4
        Me.grpCircle.TabStop = False
        Me.grpCircle.Text = "Circle"
        '
        'btnAddCcl
        '
        Me.btnAddCcl.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCcl.Location = New System.Drawing.Point(20, 100)
        Me.btnAddCcl.Name = "btnAddCcl"
        Me.btnAddCcl.Size = New System.Drawing.Size(154, 28)
        Me.btnAddCcl.TabIndex = 7
        Me.btnAddCcl.Text = "Add"
        Me.btnAddCcl.UseVisualStyleBackColor = True
        '
        'lblCclR
        '
        Me.lblCclR.AutoSize = True
        Me.lblCclR.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCclR.Location = New System.Drawing.Point(16, 31)
        Me.lblCclR.Name = "lblCclR"
        Me.lblCclR.Size = New System.Drawing.Size(57, 19)
        Me.lblCclR.TabIndex = 2
        Me.lblCclR.Text = "Radius"
        '
        'txtCclR
        '
        Me.txtCclR.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCclR.Location = New System.Drawing.Point(89, 29)
        Me.txtCclR.Name = "txtCclR"
        Me.txtCclR.Size = New System.Drawing.Size(85, 24)
        Me.txtCclR.TabIndex = 0
        Me.txtCclR.Text = "0"
        '
        'grpRightTriangle
        '
        Me.grpRightTriangle.Controls.Add(Me.btnAddTri)
        Me.grpRightTriangle.Controls.Add(Me.lblTriH)
        Me.grpRightTriangle.Controls.Add(Me.txtTriH)
        Me.grpRightTriangle.Controls.Add(Me.lblTriB)
        Me.grpRightTriangle.Controls.Add(Me.txtTriB)
        Me.grpRightTriangle.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRightTriangle.Location = New System.Drawing.Point(18, 367)
        Me.grpRightTriangle.Name = "grpRightTriangle"
        Me.grpRightTriangle.Size = New System.Drawing.Size(191, 139)
        Me.grpRightTriangle.TabIndex = 5
        Me.grpRightTriangle.TabStop = False
        Me.grpRightTriangle.Text = "Right Triangle"
        '
        'btnAddTri
        '
        Me.btnAddTri.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTri.Location = New System.Drawing.Point(20, 100)
        Me.btnAddTri.Name = "btnAddTri"
        Me.btnAddTri.Size = New System.Drawing.Size(154, 28)
        Me.btnAddTri.TabIndex = 8
        Me.btnAddTri.Text = "Add"
        Me.btnAddTri.UseVisualStyleBackColor = True
        '
        'lblTriH
        '
        Me.lblTriH.AutoSize = True
        Me.lblTriH.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTriH.Location = New System.Drawing.Point(16, 65)
        Me.lblTriH.Name = "lblTriH"
        Me.lblTriH.Size = New System.Drawing.Size(59, 19)
        Me.lblTriH.TabIndex = 5
        Me.lblTriH.Text = "Height"
        '
        'txtTriH
        '
        Me.txtTriH.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTriH.Location = New System.Drawing.Point(89, 63)
        Me.txtTriH.Name = "txtTriH"
        Me.txtTriH.Size = New System.Drawing.Size(85, 24)
        Me.txtTriH.TabIndex = 4
        Me.txtTriH.Text = "0"
        '
        'lblTriB
        '
        Me.lblTriB.AutoSize = True
        Me.lblTriB.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTriB.Location = New System.Drawing.Point(16, 31)
        Me.lblTriB.Name = "lblTriB"
        Me.lblTriB.Size = New System.Drawing.Size(42, 19)
        Me.lblTriB.TabIndex = 2
        Me.lblTriB.Text = "Base"
        '
        'txtTriB
        '
        Me.txtTriB.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTriB.Location = New System.Drawing.Point(89, 29)
        Me.txtTriB.Name = "txtTriB"
        Me.txtTriB.Size = New System.Drawing.Size(85, 24)
        Me.txtTriB.TabIndex = 0
        Me.txtTriB.Text = "0"
        '
        'txtOutput
        '
        Me.txtOutput.BackColor = System.Drawing.Color.White
        Me.txtOutput.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput.Location = New System.Drawing.Point(230, 69)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(292, 437)
        Me.txtOutput.TabIndex = 6
        Me.txtOutput.Text = "Maximum Area:  0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Minimum Area:  0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Maximum Premeter:  0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Minimum Premeter:  0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Total Area:  0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Total Premeter:  0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Average Area:  0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Average Premeter:  0"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(439, 20)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(89, 32)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear All"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmShapeList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 525)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.grpRightTriangle)
        Me.Controls.Add(Me.grpCircle)
        Me.Controls.Add(Me.grpRectangle)
        Me.Name = "frmShapeList"
        Me.Text = "Shape List"
        Me.grpRectangle.ResumeLayout(False)
        Me.grpRectangle.PerformLayout()
        Me.grpCircle.ResumeLayout(False)
        Me.grpCircle.PerformLayout()
        Me.grpRightTriangle.ResumeLayout(False)
        Me.grpRightTriangle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpRectangle As GroupBox
    Friend WithEvents lblRecL As Label
    Friend WithEvents lblRecW As Label
    Friend WithEvents txtRecL As TextBox
    Friend WithEvents txtRecW As TextBox
    Friend WithEvents grpCircle As GroupBox
    Friend WithEvents lblCclR As Label
    Friend WithEvents txtCclR As TextBox
    Friend WithEvents grpRightTriangle As GroupBox
    Friend WithEvents lblTriH As Label
    Friend WithEvents txtTriH As TextBox
    Friend WithEvents lblTriB As Label
    Friend WithEvents txtTriB As TextBox
    Friend WithEvents btnAddRec As Button
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents btnAddCcl As Button
    Friend WithEvents btnAddTri As Button
    Friend WithEvents btnClear As Button
End Class
