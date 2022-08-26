<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstUsers = New System.Windows.Forms.ListBox()
        Me.butAdduser = New System.Windows.Forms.Button()
        Me.butDeleteUser = New System.Windows.Forms.Button()
        Me.butResetPW = New System.Windows.Forms.Button()
        Me.butResetall = New System.Windows.Forms.Button()
        Me.twtUSer = New TwinText()
        Me.butCheckforUpdate = New System.Windows.Forms.Button()
        Me.butChangeColor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstUsers
        '
        Me.lstUsers.Dock = System.Windows.Forms.DockStyle.Left
        Me.lstUsers.FormattingEnabled = True
        Me.lstUsers.Location = New System.Drawing.Point(0, 0)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.Size = New System.Drawing.Size(161, 354)
        Me.lstUsers.TabIndex = 0
        '
        'butAdduser
        '
        Me.butAdduser.BackColor = System.Drawing.SystemColors.Control
        Me.butAdduser.Location = New System.Drawing.Point(167, 42)
        Me.butAdduser.Name = "butAdduser"
        Me.butAdduser.Size = New System.Drawing.Size(150, 23)
        Me.butAdduser.TabIndex = 2
        Me.butAdduser.Text = "&Add user"
        Me.butAdduser.UseVisualStyleBackColor = False
        '
        'butDeleteUser
        '
        Me.butDeleteUser.Location = New System.Drawing.Point(167, 71)
        Me.butDeleteUser.Name = "butDeleteUser"
        Me.butDeleteUser.Size = New System.Drawing.Size(150, 23)
        Me.butDeleteUser.TabIndex = 3
        Me.butDeleteUser.Text = "&Delete user"
        Me.butDeleteUser.UseVisualStyleBackColor = True
        '
        'butResetPW
        '
        Me.butResetPW.Location = New System.Drawing.Point(167, 169)
        Me.butResetPW.Name = "butResetPW"
        Me.butResetPW.Size = New System.Drawing.Size(150, 23)
        Me.butResetPW.TabIndex = 5
        Me.butResetPW.Text = "Reset &password"
        Me.butResetPW.UseVisualStyleBackColor = True
        '
        'butResetall
        '
        Me.butResetall.Location = New System.Drawing.Point(167, 238)
        Me.butResetall.Name = "butResetall"
        Me.butResetall.Size = New System.Drawing.Size(150, 23)
        Me.butResetall.TabIndex = 6
        Me.butResetall.Text = "&Clear all data except users"
        Me.butResetall.UseVisualStyleBackColor = True
        '
        'twtUSer
        '
        Me.twtUSer.AlignVertical = True
        Me.twtUSer.AllowNumeric = False
        Me.twtUSer.FillerLength = 0
        Me.twtUSer.Label = "&nText"
        Me.twtUSer.Location = New System.Drawing.Point(167, 3)
        Me.twtUSer.MultiLine = False
        Me.twtUSer.Name = "twtUSer"
        Me.twtUSer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.twtUSer.Scrollbars = System.Windows.Forms.ScrollBars.None
        Me.twtUSer.Size = New System.Drawing.Size(150, 38)
        Me.twtUSer.TabIndex = 1
        '
        'butCheckforUpdate
        '
        Me.butCheckforUpdate.Location = New System.Drawing.Point(167, 309)
        Me.butCheckforUpdate.Name = "butCheckforUpdate"
        Me.butCheckforUpdate.Size = New System.Drawing.Size(150, 23)
        Me.butCheckforUpdate.TabIndex = 7
        Me.butCheckforUpdate.Text = "Chec&k for updates"
        Me.butCheckforUpdate.UseVisualStyleBackColor = True
        '
        'butChangeColor
        '
        Me.butChangeColor.Location = New System.Drawing.Point(167, 109)
        Me.butChangeColor.Name = "butChangeColor"
        Me.butChangeColor.Size = New System.Drawing.Size(150, 23)
        Me.butChangeColor.TabIndex = 4
        Me.butChangeColor.Text = "Set appearance"
        Me.butChangeColor.UseVisualStyleBackColor = True
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.butChangeColor)
        Me.Controls.Add(Me.butCheckforUpdate)
        Me.Controls.Add(Me.butResetall)
        Me.Controls.Add(Me.butResetPW)
        Me.Controls.Add(Me.butDeleteUser)
        Me.Controls.Add(Me.butAdduser)
        Me.Controls.Add(Me.twtUSer)
        Me.Controls.Add(Me.lstUsers)
        Me.Name = "Users"
        Me.Size = New System.Drawing.Size(336, 354)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstUsers As System.Windows.Forms.ListBox
    Friend WithEvents twtUSer As TwinText
    Friend WithEvents butAdduser As System.Windows.Forms.Button
    Friend WithEvents butDeleteUser As System.Windows.Forms.Button
    Friend WithEvents butResetPW As System.Windows.Forms.Button
    Friend WithEvents butResetall As System.Windows.Forms.Button
    Friend WithEvents butCheckforUpdate As System.Windows.Forms.Button
    Friend WithEvents butChangeColor As System.Windows.Forms.Button

End Class
