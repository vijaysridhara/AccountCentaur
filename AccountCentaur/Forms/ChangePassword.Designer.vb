<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.twtNewPassword = New TwinText
        Me.twtConfirmPassword = New TwinText
        Me.butOK = New System.Windows.Forms.Button
        Me.butCancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'twtNewPassword
        '
        Me.twtNewPassword.AlignVertical = True
        Me.twtNewPassword.AllowNumeric = False
        Me.twtNewPassword.FillerLength = 0
        Me.twtNewPassword.Label = "&nText"
        Me.twtNewPassword.Location = New System.Drawing.Point(12, 12)
        Me.twtNewPassword.MultiLine = False
        Me.twtNewPassword.Name = "twtNewPassword"
        Me.twtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.twtNewPassword.Scrollbars = System.Windows.Forms.ScrollBars.None
        Me.twtNewPassword.Size = New System.Drawing.Size(156, 34)
        Me.twtNewPassword.TabIndex = 0
        '
        'twtConfirmPassword
        '
        Me.twtConfirmPassword.AlignVertical = True
        Me.twtConfirmPassword.AllowNumeric = False
        Me.twtConfirmPassword.FillerLength = 0
        Me.twtConfirmPassword.Label = "&nText"
        Me.twtConfirmPassword.Location = New System.Drawing.Point(12, 51)
        Me.twtConfirmPassword.MultiLine = False
        Me.twtConfirmPassword.Name = "twtConfirmPassword"
        Me.twtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.twtConfirmPassword.Scrollbars = System.Windows.Forms.ScrollBars.None
        Me.twtConfirmPassword.Size = New System.Drawing.Size(156, 34)
        Me.twtConfirmPassword.TabIndex = 1
        '
        'butOK
        '
        Me.butOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butOK.Location = New System.Drawing.Point(12, 90)
        Me.butOK.Name = "butOK"
        Me.butOK.Size = New System.Drawing.Size(75, 23)
        Me.butOK.TabIndex = 2
        Me.butOK.Text = "O&k"
        Me.butOK.UseVisualStyleBackColor = True
        '
        'butCancel
        '
        Me.butCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butCancel.Location = New System.Drawing.Point(93, 90)
        Me.butCancel.Name = "butCancel"
        Me.butCancel.Size = New System.Drawing.Size(75, 23)
        Me.butCancel.TabIndex = 3
        Me.butCancel.Text = "&Cancel"
        Me.butCancel.UseVisualStyleBackColor = True
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(175, 121)
        Me.Controls.Add(Me.butCancel)
        Me.Controls.Add(Me.butOK)
        Me.Controls.Add(Me.twtConfirmPassword)
        Me.Controls.Add(Me.twtNewPassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "ChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChangePasswor"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents twtNewPassword As TwinText
    Friend WithEvents twtConfirmPassword As TwinText
    Friend WithEvents butOK As System.Windows.Forms.Button
    Friend WithEvents butCancel As System.Windows.Forms.Button
End Class
