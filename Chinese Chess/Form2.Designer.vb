<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.nameLbl = New System.Windows.Forms.Label()
        Me.nameTxt = New System.Windows.Forms.TextBox()
        Me.okBtn = New System.Windows.Forms.Button()
        Me.blackRBtn = New System.Windows.Forms.RadioButton()
        Me.whiteRBtn = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'nameLbl
        '
        Me.nameLbl.AutoSize = True
        Me.nameLbl.Location = New System.Drawing.Point(42, 26)
        Me.nameLbl.Name = "nameLbl"
        Me.nameLbl.Size = New System.Drawing.Size(44, 13)
        Me.nameLbl.TabIndex = 0
        Me.nameLbl.Text = "Name : "
        '
        'nameTxt
        '
        Me.nameTxt.Location = New System.Drawing.Point(92, 23)
        Me.nameTxt.Name = "nameTxt"
        Me.nameTxt.Size = New System.Drawing.Size(156, 20)
        Me.nameTxt.TabIndex = 1
        '
        'okBtn
        '
        Me.okBtn.Location = New System.Drawing.Point(173, 72)
        Me.okBtn.Name = "okBtn"
        Me.okBtn.Size = New System.Drawing.Size(75, 23)
        Me.okBtn.TabIndex = 2
        Me.okBtn.Text = "&OK"
        Me.okBtn.UseVisualStyleBackColor = True
        '
        'blackRBtn
        '
        Me.blackRBtn.AutoSize = True
        Me.blackRBtn.Location = New System.Drawing.Point(196, 49)
        Me.blackRBtn.Name = "blackRBtn"
        Me.blackRBtn.Size = New System.Drawing.Size(52, 17)
        Me.blackRBtn.TabIndex = 3
        Me.blackRBtn.TabStop = True
        Me.blackRBtn.Text = "Black"
        Me.blackRBtn.UseVisualStyleBackColor = True
        '
        'whiteRBtn
        '
        Me.whiteRBtn.AutoSize = True
        Me.whiteRBtn.Location = New System.Drawing.Point(137, 49)
        Me.whiteRBtn.Name = "whiteRBtn"
        Me.whiteRBtn.Size = New System.Drawing.Size(53, 17)
        Me.whiteRBtn.TabIndex = 4
        Me.whiteRBtn.TabStop = True
        Me.whiteRBtn.Text = "White"
        Me.whiteRBtn.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AcceptButton = Me.okBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 103)
        Me.Controls.Add(Me.whiteRBtn)
        Me.Controls.Add(Me.blackRBtn)
        Me.Controls.Add(Me.okBtn)
        Me.Controls.Add(Me.nameTxt)
        Me.Controls.Add(Me.nameLbl)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Player Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nameLbl As System.Windows.Forms.Label
    Friend WithEvents nameTxt As System.Windows.Forms.TextBox
    Friend WithEvents okBtn As System.Windows.Forms.Button
    Friend WithEvents blackRBtn As System.Windows.Forms.RadioButton
    Friend WithEvents whiteRBtn As System.Windows.Forms.RadioButton
End Class
