<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Graph
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
        Me.components = New System.ComponentModel.Container
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lsvItems = New System.Windows.Forms.ListView
        Me.colItem = New System.Windows.Forms.ColumnHeader
        Me.colAmount = New System.Windows.Forms.ColumnHeader
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.twcType = New TwinCombo
        Me.chkBarchart = New System.Windows.Forms.CheckBox
        Me.dtpYear = New System.Windows.Forms.DateTimePicker
        Me.lblYear = New System.Windows.Forms.Label
        Me.ZedGraphControl1 = New ZedGraph.ZedGraphControl
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.lsvItems)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 576)
        Me.Panel1.TabIndex = 4
        '
        'lsvItems
        '
        Me.lsvItems.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lsvItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colItem, Me.colAmount})
        Me.lsvItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsvItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvItems.FullRowSelect = True
        Me.lsvItems.GridLines = True
        Me.lsvItems.Location = New System.Drawing.Point(0, 74)
        Me.lsvItems.Name = "lsvItems"
        Me.lsvItems.Size = New System.Drawing.Size(300, 502)
        Me.lsvItems.TabIndex = 9
        Me.lsvItems.UseCompatibleStateImageBehavior = False
        Me.lsvItems.View = System.Windows.Forms.View.Details
        '
        'colItem
        '
        Me.colItem.Text = "Item"
        Me.colItem.Width = 171
        '
        'colAmount
        '
        Me.colAmount.Text = "Amount"
        Me.colAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colAmount.Width = 103
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.twcType)
        Me.Panel2.Controls.Add(Me.chkBarchart)
        Me.Panel2.Controls.Add(Me.dtpYear)
        Me.Panel2.Controls.Add(Me.lblYear)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 74)
        Me.Panel2.TabIndex = 8
        '
        'twcType
        '
        Me.twcType.AlignVertical = False
        Me.twcType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.twcType.FillerLength = 13
        Me.twcType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.twcType.Location = New System.Drawing.Point(11, 28)
        Me.twcType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.twcType.Name = "twcType"
        Me.twcType.SelectedIndex = -1
        Me.twcType.SelectedItem = Nothing
        Me.twcType.Size = New System.Drawing.Size(214, 24)
        Me.twcType.TabIndex = 1
        '
        'chkBarchart
        '
        Me.chkBarchart.AutoSize = True
        Me.chkBarchart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBarchart.Location = New System.Drawing.Point(14, 55)
        Me.chkBarchart.Name = "chkBarchart"
        Me.chkBarchart.Size = New System.Drawing.Size(80, 20)
        Me.chkBarchart.TabIndex = 7
        Me.chkBarchart.Text = "Bar char&t"
        Me.chkBarchart.UseVisualStyleBackColor = True
        '
        'dtpYear
        '
        Me.dtpYear.CustomFormat = "yyyy-MM"
        Me.dtpYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYear.Location = New System.Drawing.Point(102, 2)
        Me.dtpYear.Name = "dtpYear"
        Me.dtpYear.Size = New System.Drawing.Size(126, 22)
        Me.dtpYear.TabIndex = 0
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(11, 6)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(37, 16)
        Me.lblYear.TabIndex = 0
        Me.lblYear.Text = "&Year"
        '
        'ZedGraphControl1
        '
        Me.ZedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ZedGraphControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZedGraphControl1.Location = New System.Drawing.Point(300, 0)
        Me.ZedGraphControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ZedGraphControl1.Name = "ZedGraphControl1"
        Me.ZedGraphControl1.ScrollGrace = 0
        Me.ZedGraphControl1.ScrollMaxX = 0
        Me.ZedGraphControl1.ScrollMaxY = 0
        Me.ZedGraphControl1.ScrollMaxY2 = 0
        Me.ZedGraphControl1.ScrollMinX = 0
        Me.ZedGraphControl1.ScrollMinY = 0
        Me.ZedGraphControl1.ScrollMinY2 = 0
        Me.ZedGraphControl1.Size = New System.Drawing.Size(491, 576)
        Me.ZedGraphControl1.TabIndex = 5
        '
        'Graph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Controls.Add(Me.ZedGraphControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Graph"
        Me.Size = New System.Drawing.Size(791, 576)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents dtpYear As System.Windows.Forms.DateTimePicker
    Friend WithEvents twcType As TwinCombo
    Friend WithEvents ZedGraphControl1 As ZedGraph.ZedGraphControl
    Friend WithEvents chkBarchart As System.Windows.Forms.CheckBox
    Friend WithEvents lsvItems As System.Windows.Forms.ListView
    Friend WithEvents colItem As System.Windows.Forms.ColumnHeader
    Friend WithEvents colAmount As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel2 As System.Windows.Forms.Panel

End Class
