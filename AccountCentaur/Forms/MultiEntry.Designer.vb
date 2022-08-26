<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultiEntry
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
        Me.txtData = New System.Windows.Forms.TextBox
        Me.butok = New System.Windows.Forms.Button
        Me.butcancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtData
        '
        Me.txtData.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.Location = New System.Drawing.Point(0, 0)
        Me.txtData.Multiline = True
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(119, 154)
        Me.txtData.TabIndex = 0
        '
        'butok
        '
        Me.butok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butok.Location = New System.Drawing.Point(0, 156)
        Me.butok.Name = "butok"
        Me.butok.Size = New System.Drawing.Size(60, 23)
        Me.butok.TabIndex = 1
        Me.butok.Text = "O&K"
        Me.butok.UseVisualStyleBackColor = True
        '
        'butcancel
        '
        Me.butcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butcancel.Location = New System.Drawing.Point(60, 156)
        Me.butcancel.Name = "butcancel"
        Me.butcancel.Size = New System.Drawing.Size(59, 24)
        Me.butcancel.TabIndex = 2
        Me.butcancel.Text = "&Cancel"
        Me.butcancel.UseVisualStyleBackColor = True
        '
        'MultiEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(119, 180)
        Me.ControlBox = False
        Me.Controls.Add(Me.butcancel)
        Me.Controls.Add(Me.butok)
        Me.Controls.Add(Me.txtData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "MultiEntry"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtData As System.Windows.Forms.TextBox
    Friend WithEvents butok As System.Windows.Forms.Button
    Friend WithEvents butcancel As System.Windows.Forms.Button
End Class
