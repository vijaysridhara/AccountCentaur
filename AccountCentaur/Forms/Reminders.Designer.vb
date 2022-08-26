<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reminders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reminders))
        Me.Notes1 = New Notes
        Me.SuspendLayout()
        '
        'Notes1
        '
        Me.Notes1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Notes1.Location = New System.Drawing.Point(0, 0)
        Me.Notes1.Name = "Notes1"
        Me.Notes1.Size = New System.Drawing.Size(591, 395)
        Me.Notes1.TabIndex = 0
        '
        'Reminders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 395)
        Me.Controls.Add(Me.Notes1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Reminders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reminders"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Notes1 As Notes
End Class
