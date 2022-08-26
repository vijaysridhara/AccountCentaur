<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordText As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.PasswordText = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.ChkRempwd = New System.Windows.Forms.CheckBox()
        Me.twcUsers = New TwinCombo()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PasswordLabel.Location = New System.Drawing.Point(54, 47)
        Me.PasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(79, 27)
        Me.PasswordLabel.TabIndex = 1
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordText
        '
        Me.PasswordText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PasswordText.Location = New System.Drawing.Point(56, 72)
        Me.PasswordText.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PasswordText.Name = "PasswordText"
        Me.PasswordText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordText.Size = New System.Drawing.Size(204, 22)
        Me.PasswordText.TabIndex = 2
        '
        'OK
        '
        Me.OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.OK.Location = New System.Drawing.Point(58, 123)
        Me.OK.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(80, 27)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&OK"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Cancel.Location = New System.Drawing.Point(177, 123)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(83, 27)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancel"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.VijaySridhara.Applications.My.Resources.Resources.acc
        Me.LogoPictureBox.Location = New System.Drawing.Point(14, 13)
        Me.LogoPictureBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(32, 32)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'ChkRempwd
        '
        Me.ChkRempwd.AutoSize = True
        Me.ChkRempwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChkRempwd.Location = New System.Drawing.Point(57, 97)
        Me.ChkRempwd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ChkRempwd.Name = "ChkRempwd"
        Me.ChkRempwd.Size = New System.Drawing.Size(157, 20)
        Me.ChkRempwd.TabIndex = 3
        Me.ChkRempwd.Text = "&Remember Password"
        Me.ChkRempwd.UseVisualStyleBackColor = True
        '
        'twcUsers
        '
        Me.twcUsers.AlignVertical = True
        Me.twcUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.twcUsers.FillerLength = 0
        Me.twcUsers.Location = New System.Drawing.Point(58, 8)
        Me.twcUsers.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.twcUsers.Name = "twcUsers"
        Me.twcUsers.SelectedIndex = -1
        Me.twcUsers.SelectedItem = Nothing
        Me.twcUsers.Size = New System.Drawing.Size(203, 40)
        Me.twcUsers.TabIndex = 0
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 157)
        Me.Controls.Add(Me.ChkRempwd)
        Me.Controls.Add(Me.twcUsers)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.PasswordText)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login to AccountCentaur"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents twcUsers As TwinCombo
    Friend WithEvents ChkRempwd As System.Windows.Forms.CheckBox

End Class
