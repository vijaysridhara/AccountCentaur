<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TwinText
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblName = New System.Windows.Forms.Label
        Me.txtText = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblName.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(0, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(32, 16)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Lbl"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtText
        '
        Me.txtText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtText.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtText.Location = New System.Drawing.Point(32, 0)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(118, 22)
        Me.txtText.TabIndex = 2
        '
        'TwinText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.lblName)
        Me.Name = "TwinText"
        Me.Size = New System.Drawing.Size(150, 24)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtText As System.Windows.Forms.TextBox

End Class
