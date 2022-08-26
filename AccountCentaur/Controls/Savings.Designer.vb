<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Savings
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
        Me.butUpdateEntry = New System.Windows.Forms.Button
        Me.butMakeEntry = New System.Windows.Forms.Button
        Me.butDeleteEntry = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chkNonInsurance = New System.Windows.Forms.CheckBox
        Me.twcSaving = New TwinText
        Me.twtComments = New TwinText
        Me.twtAmount = New TwinText
        Me.twcType = New TwinCombo
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpYear = New System.Windows.Forms.DateTimePicker
        Me.lsvSavings = New System.Windows.Forms.ListView
        Me.colhSaving = New System.Windows.Forms.ColumnHeader
        Me.colHType = New System.Windows.Forms.ColumnHeader
        Me.colhDate = New System.Windows.Forms.ColumnHeader
        Me.colHComments = New System.Windows.Forms.ColumnHeader
        Me.colHAmount = New System.Windows.Forms.ColumnHeader
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'butUpdateEntry
        '
        Me.butUpdateEntry.Enabled = False
        Me.butUpdateEntry.Location = New System.Drawing.Point(44, 341)
        Me.butUpdateEntry.Name = "butUpdateEntry"
        Me.butUpdateEntry.Size = New System.Drawing.Size(115, 28)
        Me.butUpdateEntry.TabIndex = 11
        Me.butUpdateEntry.Text = "&Update entry"
        Me.butUpdateEntry.UseVisualStyleBackColor = True
        '
        'butMakeEntry
        '
        Me.butMakeEntry.Location = New System.Drawing.Point(44, 307)
        Me.butMakeEntry.Name = "butMakeEntry"
        Me.butMakeEntry.Size = New System.Drawing.Size(115, 28)
        Me.butMakeEntry.TabIndex = 10
        Me.butMakeEntry.Text = "Make &entry"
        Me.butMakeEntry.UseVisualStyleBackColor = True
        '
        'butDeleteEntry
        '
        Me.butDeleteEntry.Enabled = False
        Me.butDeleteEntry.Location = New System.Drawing.Point(44, 378)
        Me.butDeleteEntry.Name = "butDeleteEntry"
        Me.butDeleteEntry.Size = New System.Drawing.Size(115, 28)
        Me.butDeleteEntry.TabIndex = 12
        Me.butDeleteEntry.Text = "&Delete entry"
        Me.butDeleteEntry.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkNonInsurance)
        Me.Panel1.Controls.Add(Me.butDeleteEntry)
        Me.Panel1.Controls.Add(Me.butUpdateEntry)
        Me.Panel1.Controls.Add(Me.butMakeEntry)
        Me.Panel1.Controls.Add(Me.twcSaving)
        Me.Panel1.Controls.Add(Me.twtComments)
        Me.Panel1.Controls.Add(Me.twtAmount)
        Me.Panel1.Controls.Add(Me.twcType)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dtpYear)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(222, 425)
        Me.Panel1.TabIndex = 1
        '
        'chkNonInsurance
        '
        Me.chkNonInsurance.AutoSize = True
        Me.chkNonInsurance.Location = New System.Drawing.Point(9, 259)
        Me.chkNonInsurance.Name = "chkNonInsurance"
        Me.chkNonInsurance.Size = New System.Drawing.Size(113, 17)
        Me.chkNonInsurance.TabIndex = 13
        Me.chkNonInsurance.Text = "Exclude insu&rance"
        Me.chkNonInsurance.UseVisualStyleBackColor = True
        '
        'twcSaving
        '
        Me.twcSaving.AlignVertical = False
        Me.twcSaving.AllowNumeric = False
        Me.twcSaving.FillerLength = 9
        Me.twcSaving.Label = "&nText   "
        Me.twcSaving.Location = New System.Drawing.Point(10, 82)
        Me.twcSaving.MultiLine = False
        Me.twcSaving.Name = "twcSaving"
        Me.twcSaving.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.twcSaving.Scrollbars = System.Windows.Forms.ScrollBars.None
        Me.twcSaving.Size = New System.Drawing.Size(206, 22)
        Me.twcSaving.TabIndex = 3
        '
        'twtComments
        '
        Me.twtComments.AlignVertical = False
        Me.twtComments.AllowNumeric = False
        Me.twtComments.FillerLength = 9
        Me.twtComments.Label = "&nText   "
        Me.twtComments.Location = New System.Drawing.Point(10, 134)
        Me.twtComments.MultiLine = True
        Me.twtComments.Name = "twtComments"
        Me.twtComments.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.twtComments.Scrollbars = System.Windows.Forms.ScrollBars.None
        Me.twtComments.Size = New System.Drawing.Size(206, 119)
        Me.twtComments.TabIndex = 3
        '
        'twtAmount
        '
        Me.twtAmount.AlignVertical = False
        Me.twtAmount.AllowNumeric = True
        Me.twtAmount.FillerLength = 9
        Me.twtAmount.Label = "&nText   "
        Me.twtAmount.Location = New System.Drawing.Point(10, 108)
        Me.twtAmount.MultiLine = False
        Me.twtAmount.Name = "twtAmount"
        Me.twtAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.twtAmount.Scrollbars = System.Windows.Forms.ScrollBars.None
        Me.twtAmount.Size = New System.Drawing.Size(206, 22)
        Me.twtAmount.TabIndex = 4
        '
        'twcType
        '
        Me.twcType.AlignVertical = False
        Me.twcType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.twcType.FillerLength = 9
        Me.twcType.Location = New System.Drawing.Point(10, 56)
        Me.twcType.Name = "twcType"
        Me.twcType.SelectedIndex = -1
        Me.twcType.SelectedItem = Nothing
        Me.twcType.Size = New System.Drawing.Size(206, 24)
        Me.twcType.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&For month"
        '
        'dtpYear
        '
        Me.dtpYear.CustomFormat = "yyyy-MM"
        Me.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYear.Location = New System.Drawing.Point(73, 30)
        Me.dtpYear.Name = "dtpYear"
        Me.dtpYear.Size = New System.Drawing.Size(109, 20)
        Me.dtpYear.TabIndex = 1
        '
        'lsvSavings
        '
        Me.lsvSavings.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lsvSavings.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colhSaving, Me.colHType, Me.colhDate, Me.colHComments, Me.colHAmount})
        Me.lsvSavings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsvSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvSavings.FullRowSelect = True
        Me.lsvSavings.GridLines = True
        Me.lsvSavings.HideSelection = False
        Me.lsvSavings.Location = New System.Drawing.Point(222, 0)
        Me.lsvSavings.MultiSelect = False
        Me.lsvSavings.Name = "lsvSavings"
        Me.lsvSavings.Size = New System.Drawing.Size(517, 425)
        Me.lsvSavings.TabIndex = 13
        Me.lsvSavings.UseCompatibleStateImageBehavior = False
        Me.lsvSavings.View = System.Windows.Forms.View.Details
        '
        'colhSaving
        '
        Me.colhSaving.Text = "Savingname"
        Me.colhSaving.Width = 99
        '
        'colHType
        '
        Me.colHType.Text = "Type"
        Me.colHType.Width = 81
        '
        'colhDate
        '
        Me.colhDate.Text = "Date entered"
        Me.colhDate.Width = 83
        '
        'colHComments
        '
        Me.colHComments.Text = "Comments"
        Me.colHComments.Width = 159
        '
        'colHAmount
        '
        Me.colHAmount.Text = "Amount"
        Me.colHAmount.Width = 97
        '
        'Savings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lsvSavings)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Savings"
        Me.Size = New System.Drawing.Size(739, 425)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents twtComments As TwinText
    Friend WithEvents twtAmount As TwinText
    Friend WithEvents twcType As TwinCombo
    Friend WithEvents butUpdateEntry As System.Windows.Forms.Button
    Friend WithEvents butMakeEntry As System.Windows.Forms.Button
    Friend WithEvents butDeleteEntry As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents twcSaving As TwinText
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpYear As System.Windows.Forms.DateTimePicker
    Friend WithEvents lsvSavings As System.Windows.Forms.ListView
    Friend WithEvents colhSaving As System.Windows.Forms.ColumnHeader
    Friend WithEvents colHType As System.Windows.Forms.ColumnHeader
    Friend WithEvents colhDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents colHComments As System.Windows.Forms.ColumnHeader
    Friend WithEvents colHAmount As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkNonInsurance As System.Windows.Forms.CheckBox

End Class
