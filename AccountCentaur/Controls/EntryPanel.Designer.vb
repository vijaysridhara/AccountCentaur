<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntryPanel
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.PanBot = New System.Windows.Forms.Panel
        Me.butClearRows = New System.Windows.Forms.Button
        Me.lblNewEntry = New System.Windows.Forms.Label
        Me.butMakeEntry = New System.Windows.Forms.Button
        Me.txtNewItem = New System.Windows.Forms.TextBox
        Me.butAddRow = New System.Windows.Forms.Button
        Me.butEnter = New System.Windows.Forms.Button
        Me.dgdEntry = New System.Windows.Forms.DataGridView
        Me.colExpense = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.colMethod = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.colComments = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDate = New System.Windows.Forms.DataGridViewButtonColumn
        Me.colAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HSplitter = New System.Windows.Forms.SplitContainer
        Me.transView = New Transactions
        Me.PanBot.SuspendLayout()
        CType(Me.dgdEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HSplitter.Panel1.SuspendLayout()
        Me.HSplitter.Panel2.SuspendLayout()
        Me.HSplitter.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanBot
        '
        Me.PanBot.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanBot.Controls.Add(Me.butClearRows)
        Me.PanBot.Controls.Add(Me.lblNewEntry)
        Me.PanBot.Controls.Add(Me.butMakeEntry)
        Me.PanBot.Controls.Add(Me.txtNewItem)
        Me.PanBot.Controls.Add(Me.butAddRow)
        Me.PanBot.Controls.Add(Me.butEnter)
        Me.PanBot.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanBot.Location = New System.Drawing.Point(0, 385)
        Me.PanBot.Name = "PanBot"
        Me.PanBot.Size = New System.Drawing.Size(761, 26)
        Me.PanBot.TabIndex = 2
        '
        'butClearRows
        '
        Me.butClearRows.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butClearRows.Location = New System.Drawing.Point(449, 3)
        Me.butClearRows.Name = "butClearRows"
        Me.butClearRows.Size = New System.Drawing.Size(66, 23)
        Me.butClearRows.TabIndex = 4
        Me.butClearRows.Text = "Clear ro&ws"
        Me.butClearRows.UseVisualStyleBackColor = True
        '
        'lblNewEntry
        '
        Me.lblNewEntry.AutoSize = True
        Me.lblNewEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewEntry.Location = New System.Drawing.Point(85, 7)
        Me.lblNewEntry.Name = "lblNewEntry"
        Me.lblNewEntry.Size = New System.Drawing.Size(63, 16)
        Me.lblNewEntry.TabIndex = 1
        Me.lblNewEntry.Text = "New &item"
        '
        'butMakeEntry
        '
        Me.butMakeEntry.Dock = System.Windows.Forms.DockStyle.Right
        Me.butMakeEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butMakeEntry.Location = New System.Drawing.Point(648, 0)
        Me.butMakeEntry.Name = "butMakeEntry"
        Me.butMakeEntry.Size = New System.Drawing.Size(113, 26)
        Me.butMakeEntry.TabIndex = 5
        Me.butMakeEntry.Text = "Ma&ke entry"
        Me.butMakeEntry.UseVisualStyleBackColor = True
        '
        'txtNewItem
        '
        Me.txtNewItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewItem.Location = New System.Drawing.Point(151, 3)
        Me.txtNewItem.MaxLength = 100
        Me.txtNewItem.Name = "txtNewItem"
        Me.txtNewItem.Size = New System.Drawing.Size(220, 22)
        Me.txtNewItem.TabIndex = 2
        '
        'butAddRow
        '
        Me.butAddRow.Dock = System.Windows.Forms.DockStyle.Left
        Me.butAddRow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddRow.Location = New System.Drawing.Point(0, 0)
        Me.butAddRow.Name = "butAddRow"
        Me.butAddRow.Size = New System.Drawing.Size(79, 26)
        Me.butAddRow.TabIndex = 0
        Me.butAddRow.Text = "Add &New"
        Me.butAddRow.UseVisualStyleBackColor = True
        '
        'butEnter
        '
        Me.butEnter.Enabled = False
        Me.butEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butEnter.Location = New System.Drawing.Point(377, 3)
        Me.butEnter.Name = "butEnter"
        Me.butEnter.Size = New System.Drawing.Size(66, 23)
        Me.butEnter.TabIndex = 3
        Me.butEnter.Text = "Add &text"
        Me.butEnter.UseVisualStyleBackColor = True
        '
        'dgdEntry
        '
        Me.dgdEntry.AllowUserToAddRows = False
        Me.dgdEntry.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.dgdEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdEntry.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colExpense, Me.colMethod, Me.colComments, Me.colDate, Me.colAmount})
        Me.dgdEntry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgdEntry.Location = New System.Drawing.Point(0, 0)
        Me.dgdEntry.Name = "dgdEntry"
        Me.dgdEntry.Size = New System.Drawing.Size(761, 411)
        Me.dgdEntry.TabIndex = 1
        '
        'colExpense
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colExpense.DefaultCellStyle = DataGridViewCellStyle1
        Me.colExpense.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.colExpense.HeaderText = "Expense"
        Me.colExpense.Name = "colExpense"
        Me.colExpense.ReadOnly = True
        Me.colExpense.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colExpense.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colExpense.Width = 150
        '
        'colMethod
        '
        Me.colMethod.HeaderText = "Method"
        Me.colMethod.Items.AddRange(New Object() {"Cash", "Cheque", "Online", "Creditcard", "Other"})
        Me.colMethod.Name = "colMethod"
        '
        'colComments
        '
        Me.colComments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colComments.HeaderText = "Comments"
        Me.colComments.Name = "colComments"
        '
        'colDate
        '
        Me.colDate.HeaderText = "Date"
        Me.colDate.Name = "colDate"
        Me.colDate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colAmount
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colAmount.DefaultCellStyle = DataGridViewCellStyle2
        Me.colAmount.HeaderText = "Amount"
        Me.colAmount.Name = "colAmount"
        '
        'HSplitter
        '
        Me.HSplitter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HSplitter.Location = New System.Drawing.Point(0, 0)
        Me.HSplitter.Name = "HSplitter"
        Me.HSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'HSplitter.Panel1
        '
        Me.HSplitter.Panel1.Controls.Add(Me.PanBot)
        Me.HSplitter.Panel1.Controls.Add(Me.dgdEntry)
        '
        'HSplitter.Panel2
        '
        Me.HSplitter.Panel2.Controls.Add(Me.transView)
        Me.HSplitter.Size = New System.Drawing.Size(761, 555)
        Me.HSplitter.SplitterDistance = 411
        Me.HSplitter.TabIndex = 3
        '
        'transView
        '
        Me.transView.BackColor = System.Drawing.Color.LightSteelBlue
        Me.transView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.transView.Location = New System.Drawing.Point(0, 0)
        Me.transView.Name = "transView"
        Me.transView.ShowMod = False
        Me.transView.Size = New System.Drawing.Size(761, 140)
        Me.transView.TabIndex = 0
        Me.transView.UseGlobalIndex = False
        '
        'EntryPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.HSplitter)
        Me.Name = "EntryPanel"
        Me.Size = New System.Drawing.Size(761, 555)
        Me.PanBot.ResumeLayout(False)
        Me.PanBot.PerformLayout()
        CType(Me.dgdEntry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HSplitter.Panel1.ResumeLayout(False)
        Me.HSplitter.Panel2.ResumeLayout(False)
        Me.HSplitter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanBot As System.Windows.Forms.Panel
    Friend WithEvents butMakeEntry As System.Windows.Forms.Button
    Friend WithEvents txtNewItem As System.Windows.Forms.TextBox
    Friend WithEvents butAddRow As System.Windows.Forms.Button
    Friend WithEvents butEnter As System.Windows.Forms.Button
    Friend WithEvents dgdEntry As System.Windows.Forms.DataGridView
    Friend WithEvents lblNewEntry As System.Windows.Forms.Label
    Friend WithEvents butClearRows As System.Windows.Forms.Button
    Friend WithEvents HSplitter As System.Windows.Forms.SplitContainer
    Friend WithEvents transView As Transactions
    Friend WithEvents colExpense As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colMethod As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colComments As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colAmount As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
