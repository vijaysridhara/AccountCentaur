<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.LabelProductName = New System.Windows.Forms.Label()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.LabelCompanyName = New System.Windows.Forms.Label()
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.lnkZedGraph = New System.Windows.Forms.LinkLabel()
        Me.lnkSqlite = New System.Windows.Forms.LinkLabel()
        Me.LZedG = New System.Windows.Forms.TextBox()
        Me.LabelCopyright = New System.Windows.Forms.TextBox()
        Me.lblDedicated = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.LSQLITENEt = New System.Windows.Forms.TextBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelProductName
        '
        Me.LabelProductName.AutoSize = True
        Me.LabelProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelProductName.Location = New System.Drawing.Point(154, 12)
        Me.LabelProductName.Margin = New System.Windows.Forms.Padding(7, 0, 4, 0)
        Me.LabelProductName.MaximumSize = New System.Drawing.Size(0, 20)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(122, 20)
        Me.LabelProductName.TabIndex = 11
        Me.LabelProductName.Text = "Product Name"
        Me.LabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelVersion.Location = New System.Drawing.Point(154, 46)
        Me.LabelVersion.Margin = New System.Windows.Forms.Padding(7, 0, 4, 0)
        Me.LabelVersion.MaximumSize = New System.Drawing.Size(0, 20)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(63, 20)
        Me.LabelVersion.TabIndex = 12
        Me.LabelVersion.Text = "Version"
        Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelCompanyName
        '
        Me.LabelCompanyName.AutoSize = True
        Me.LabelCompanyName.Location = New System.Drawing.Point(154, 133)
        Me.LabelCompanyName.Margin = New System.Windows.Forms.Padding(7, 0, 4, 0)
        Me.LabelCompanyName.MaximumSize = New System.Drawing.Size(0, 20)
        Me.LabelCompanyName.Name = "LabelCompanyName"
        Me.LabelCompanyName.Size = New System.Drawing.Size(94, 15)
        Me.LabelCompanyName.TabIndex = 8
        Me.LabelCompanyName.Text = "Company Name"
        Me.LabelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TextBoxDescription.Location = New System.Drawing.Point(158, 162)
        Me.TextBoxDescription.Margin = New System.Windows.Forms.Padding(7, 3, 4, 3)
        Me.TextBoxDescription.Multiline = True
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.ReadOnly = True
        Me.TextBoxDescription.Size = New System.Drawing.Size(288, 162)
        Me.TextBoxDescription.TabIndex = 14
        Me.TextBoxDescription.TabStop = False
        Me.TextBoxDescription.Text = resources.GetString("TextBoxDescription.Text")
        '
        'lnkZedGraph
        '
        Me.lnkZedGraph.AutoSize = True
        Me.lnkZedGraph.Location = New System.Drawing.Point(14, 361)
        Me.lnkZedGraph.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lnkZedGraph.Name = "lnkZedGraph"
        Me.lnkZedGraph.Size = New System.Drawing.Size(176, 15)
        Me.lnkZedGraph.TabIndex = 16
        Me.lnkZedGraph.TabStop = True
        Me.lnkZedGraph.Text = "View the license of ZedGraph.dll"
        '
        'lnkSqlite
        '
        Me.lnkSqlite.AutoSize = True
        Me.lnkSqlite.Location = New System.Drawing.Point(14, 376)
        Me.lnkSqlite.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lnkSqlite.Name = "lnkSqlite"
        Me.lnkSqlite.Size = New System.Drawing.Size(145, 15)
        Me.lnkSqlite.TabIndex = 16
        Me.lnkSqlite.TabStop = True
        Me.lnkSqlite.Text = "View the license of  SQLite"
        '
        'LZedG
        '
        Me.LZedG.Location = New System.Drawing.Point(18, 166)
        Me.LZedG.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LZedG.Multiline = True
        Me.LZedG.Name = "LZedG"
        Me.LZedG.Size = New System.Drawing.Size(40, 26)
        Me.LZedG.TabIndex = 17
        Me.LZedG.Text = resources.GetString("LZedG.Text")
        Me.LZedG.Visible = False
        '
        'LabelCopyright
        '
        Me.LabelCopyright.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.LabelCopyright.Location = New System.Drawing.Point(159, 69)
        Me.LabelCopyright.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelCopyright.Multiline = True
        Me.LabelCopyright.Name = "LabelCopyright"
        Me.LabelCopyright.Size = New System.Drawing.Size(286, 59)
        Me.LabelCopyright.TabIndex = 18
        '
        'lblDedicated
        '
        Me.lblDedicated.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDedicated.Image = Global.VijaySridhara.Applications.My.Resources.Resources.ROSE
        Me.lblDedicated.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDedicated.Location = New System.Drawing.Point(0, 411)
        Me.lblDedicated.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDedicated.Name = "lblDedicated"
        Me.lblDedicated.Size = New System.Drawing.Size(490, 16)
        Me.lblDedicated.TabIndex = 13
        Me.lblDedicated.Text = "         For the most beautiful girl on the planet"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.VijaySridhara.Applications.My.Resources.Resources.acc
        Me.LogoPictureBox.Location = New System.Drawing.Point(18, 12)
        Me.LogoPictureBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(85, 81)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 10
        Me.LogoPictureBox.TabStop = False
        '
        'LSQLITENEt
        '
        Me.LSQLITENEt.Location = New System.Drawing.Point(18, 200)
        Me.LSQLITENEt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LSQLITENEt.Multiline = True
        Me.LSQLITENEt.Name = "LSQLITENEt"
        Me.LSQLITENEt.Size = New System.Drawing.Size(40, 26)
        Me.LSQLITENEt.TabIndex = 17
        Me.LSQLITENEt.Text = resources.GetString("LSQLITENEt.Text")
        Me.LSQLITENEt.Visible = False
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Controls.Add(Me.LabelCopyright)
        Me.Controls.Add(Me.LSQLITENEt)
        Me.Controls.Add(Me.LZedG)
        Me.Controls.Add(Me.lnkSqlite)
        Me.Controls.Add(Me.lnkZedGraph)
        Me.Controls.Add(Me.TextBoxDescription)
        Me.Controls.Add(Me.lblDedicated)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.LabelProductName)
        Me.Controls.Add(Me.LabelVersion)
        Me.Controls.Add(Me.LabelCompanyName)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "About"
        Me.Size = New System.Drawing.Size(490, 427)
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents LabelProductName As System.Windows.Forms.Label
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents LabelCompanyName As System.Windows.Forms.Label
    Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblDedicated As System.Windows.Forms.Label
    Friend WithEvents lnkZedGraph As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkSqlite As System.Windows.Forms.LinkLabel
    Friend WithEvents LZedG As System.Windows.Forms.TextBox
    Friend WithEvents LabelCopyright As System.Windows.Forms.TextBox
    Friend WithEvents LSQLITENEt As System.Windows.Forms.TextBox

End Class
