<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CurrencyConverter
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
        Me.wbrCurConv = New System.Windows.Forms.WebBrowser
        Me.butClose = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'wbrCurConv
        '
        Me.wbrCurConv.AllowWebBrowserDrop = False
        Me.wbrCurConv.Dock = System.Windows.Forms.DockStyle.Top
        Me.wbrCurConv.IsWebBrowserContextMenuEnabled = False
        Me.wbrCurConv.Location = New System.Drawing.Point(0, 0)
        Me.wbrCurConv.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbrCurConv.Name = "wbrCurConv"
        Me.wbrCurConv.ScrollBarsEnabled = False
        Me.wbrCurConv.Size = New System.Drawing.Size(210, 243)
        Me.wbrCurConv.TabIndex = 0
        Me.wbrCurConv.Url = New System.Uri("", System.UriKind.Relative)
        '
        'butClose
        '
        Me.butClose.Location = New System.Drawing.Point(135, 245)
        Me.butClose.Name = "butClose"
        Me.butClose.Size = New System.Drawing.Size(75, 23)
        Me.butClose.TabIndex = 1
        Me.butClose.Text = "&Close"
        Me.butClose.UseVisualStyleBackColor = True
        '
        'CurrencyConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(210, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.butClose)
        Me.Controls.Add(Me.wbrCurConv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "CurrencyConverter"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents wbrCurConv As System.Windows.Forms.WebBrowser
    Friend WithEvents butClose As System.Windows.Forms.Button
End Class
