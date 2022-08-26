<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notes
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.twcNotes = New TwinText
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.chkShowOpennotesonly = New System.Windows.Forms.CheckBox
        Me.twtStatus = New TwinCombo
        Me.dtpOnorAfter = New System.Windows.Forms.DateTimePicker
        Me.lblOnorAfter = New System.Windows.Forms.Label
        Me.butAdd = New System.Windows.Forms.Button
        Me.butUpdate = New System.Windows.Forms.Button
        Me.butDelete = New System.Windows.Forms.Button
        Me.dtpYear = New System.Windows.Forms.DateTimePicker
        Me.lblNotes = New System.Windows.Forms.Label
        Me.dgdNotes = New System.Windows.Forms.DataGridView
        Me.colHDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colHNotes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colHRemindOn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colHStatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgdNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.twcNotes)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 226)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(576, 172)
        Me.Panel1.TabIndex = 1
        '
        'twcNotes
        '
        Me.twcNotes.AlignVertical = False
        Me.twcNotes.AllowNumeric = False
        Me.twcNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.twcNotes.FillerLength = 0
        Me.twcNotes.Label = "&nText"
        Me.twcNotes.Location = New System.Drawing.Point(209, 0)
        Me.twcNotes.MultiLine = True
        Me.twcNotes.Name = "twcNotes"
        Me.twcNotes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.twcNotes.Scrollbars = System.Windows.Forms.ScrollBars.None
        Me.twcNotes.Size = New System.Drawing.Size(367, 172)
        Me.twcNotes.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.chkShowOpennotesonly)
        Me.Panel2.Controls.Add(Me.twtStatus)
        Me.Panel2.Controls.Add(Me.dtpOnorAfter)
        Me.Panel2.Controls.Add(Me.lblOnorAfter)
        Me.Panel2.Controls.Add(Me.butAdd)
        Me.Panel2.Controls.Add(Me.butUpdate)
        Me.Panel2.Controls.Add(Me.butDelete)
        Me.Panel2.Controls.Add(Me.dtpYear)
        Me.Panel2.Controls.Add(Me.lblNotes)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(209, 172)
        Me.Panel2.TabIndex = 10
        '
        'chkShowOpennotesonly
        '
        Me.chkShowOpennotesonly.AutoSize = True
        Me.chkShowOpennotesonly.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowOpennotesonly.Location = New System.Drawing.Point(10, 148)
        Me.chkShowOpennotesonly.Name = "chkShowOpennotesonly"
        Me.chkShowOpennotesonly.Size = New System.Drawing.Size(122, 20)
        Me.chkShowOpennotesonly.TabIndex = 8
        Me.chkShowOpennotesonly.Text = "Show on&ly open"
        Me.chkShowOpennotesonly.UseVisualStyleBackColor = True
        '
        'twtStatus
        '
        Me.twtStatus.AlignVertical = False
        Me.twtStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.twtStatus.FillerLength = 9
        Me.twtStatus.Location = New System.Drawing.Point(10, 58)
        Me.twtStatus.Name = "twtStatus"
        Me.twtStatus.SelectedIndex = -1
        Me.twtStatus.SelectedItem = Nothing
        Me.twtStatus.Size = New System.Drawing.Size(130, 24)
        Me.twtStatus.TabIndex = 7
        '
        'dtpOnorAfter
        '
        Me.dtpOnorAfter.CustomFormat = "dd-MMM-yyyy"
        Me.dtpOnorAfter.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpOnorAfter.Location = New System.Drawing.Point(74, 32)
        Me.dtpOnorAfter.Name = "dtpOnorAfter"
        Me.dtpOnorAfter.Size = New System.Drawing.Size(109, 20)
        Me.dtpOnorAfter.TabIndex = 6
        '
        'lblOnorAfter
        '
        Me.lblOnorAfter.AutoSize = True
        Me.lblOnorAfter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnorAfter.Location = New System.Drawing.Point(7, 36)
        Me.lblOnorAfter.Name = "lblOnorAfter"
        Me.lblOnorAfter.Size = New System.Drawing.Size(69, 16)
        Me.lblOnorAfter.TabIndex = 5
        Me.lblOnorAfter.Text = "&On or after"
        '
        'butAdd
        '
        Me.butAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAdd.Location = New System.Drawing.Point(10, 86)
        Me.butAdd.Name = "butAdd"
        Me.butAdd.Size = New System.Drawing.Size(75, 23)
        Me.butAdd.TabIndex = 2
        Me.butAdd.Text = "&Add"
        Me.butAdd.UseVisualStyleBackColor = True
        '
        'butUpdate
        '
        Me.butUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butUpdate.Location = New System.Drawing.Point(91, 86)
        Me.butUpdate.Name = "butUpdate"
        Me.butUpdate.Size = New System.Drawing.Size(75, 23)
        Me.butUpdate.TabIndex = 3
        Me.butUpdate.Text = "&Update"
        Me.butUpdate.UseVisualStyleBackColor = True
        '
        'butDelete
        '
        Me.butDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butDelete.Location = New System.Drawing.Point(10, 115)
        Me.butDelete.Name = "butDelete"
        Me.butDelete.Size = New System.Drawing.Size(156, 23)
        Me.butDelete.TabIndex = 4
        Me.butDelete.Text = "&Delete"
        Me.butDelete.UseVisualStyleBackColor = True
        '
        'dtpYear
        '
        Me.dtpYear.CustomFormat = "dd-MMM-yyyy"
        Me.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYear.Location = New System.Drawing.Point(73, 6)
        Me.dtpYear.Name = "dtpYear"
        Me.dtpYear.Size = New System.Drawing.Size(109, 20)
        Me.dtpYear.TabIndex = 1
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotes.Location = New System.Drawing.Point(7, 8)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(37, 16)
        Me.lblNotes.TabIndex = 0
        Me.lblNotes.Text = "&Date"
        '
        'dgdNotes
        '
        Me.dgdNotes.AllowUserToAddRows = False
        Me.dgdNotes.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.dgdNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdNotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colHDate, Me.colHNotes, Me.colHRemindOn, Me.colHStatus})
        Me.dgdNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgdNotes.Location = New System.Drawing.Point(0, 0)
        Me.dgdNotes.Name = "dgdNotes"
        Me.dgdNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgdNotes.Size = New System.Drawing.Size(576, 226)
        Me.dgdNotes.TabIndex = 0
        '
        'colHDate
        '
        Me.colHDate.HeaderText = "Date"
        Me.colHDate.Name = "colHDate"
        Me.colHDate.ReadOnly = True
        '
        'colHNotes
        '
        Me.colHNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colHNotes.HeaderText = "Notes"
        Me.colHNotes.Name = "colHNotes"
        Me.colHNotes.ReadOnly = True
        '
        'colHRemindOn
        '
        Me.colHRemindOn.HeaderText = "Remind on"
        Me.colHRemindOn.Name = "colHRemindOn"
        Me.colHRemindOn.ReadOnly = True
        '
        'colHStatus
        '
        Me.colHStatus.HeaderText = "Status"
        Me.colHStatus.Name = "colHStatus"
        Me.colHStatus.ReadOnly = True
        '
        'Notes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgdNotes)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Notes"
        Me.Size = New System.Drawing.Size(576, 398)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgdNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents twcNotes As TwinText
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents butUpdate As System.Windows.Forms.Button
    Friend WithEvents butDelete As System.Windows.Forms.Button
    Friend WithEvents dtpYear As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents dgdNotes As System.Windows.Forms.DataGridView
    Friend WithEvents butAdd As System.Windows.Forms.Button
    Friend WithEvents twtStatus As TwinCombo
    Friend WithEvents dtpOnorAfter As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblOnorAfter As System.Windows.Forms.Label
    Friend WithEvents chkShowOpennotesonly As System.Windows.Forms.CheckBox
    Friend WithEvents colHDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHNotes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHRemindOn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHStatus As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
