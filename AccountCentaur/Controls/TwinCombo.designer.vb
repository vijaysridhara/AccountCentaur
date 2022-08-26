<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TwinCombo
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
        Me.cboCombo = New System.Windows.Forms.ComboBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboCombo
        '
        Me.cboCombo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboCombo.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cboCombo.FormattingEnabled = True
        Me.cboCombo.Location = New System.Drawing.Point(31, 0)
        Me.cboCombo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboCombo.Name = "cboCombo"
        Me.cboCombo.Size = New System.Drawing.Size(172, 24)
        Me.cboCombo.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblName.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(0, 0)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(31, 16)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Lbl"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'TwinCombo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cboCombo)
        Me.Controls.Add(Me.lblName)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "TwinCombo"
        Me.Size = New System.Drawing.Size(203, 29)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboCombo As System.Windows.Forms.ComboBox
    Friend WithEvents lblName As System.Windows.Forms.Label

End Class
