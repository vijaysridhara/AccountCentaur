<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transactions
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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Me.butUpdateRecord = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grpQuery = New System.Windows.Forms.GroupBox
        Me.rbStarts = New System.Windows.Forms.RadioButton
        Me.rbEnds = New System.Windows.Forms.RadioButton
        Me.rbLike = New System.Windows.Forms.RadioButton
        Me.grpReport = New System.Windows.Forms.GroupBox
        Me.rbSearch = New System.Windows.Forms.RadioButton
        Me.rbDetails = New System.Windows.Forms.RadioButton
        Me.lblFind = New System.Windows.Forms.Label
        Me.txtFind = New System.Windows.Forms.TextBox
        Me.lblMonth = New System.Windows.Forms.Label
        Me.ymMonth = New VitalLogic.Controls.YearMonth
        Me.butDeleteRecord = New System.Windows.Forms.Button
        Me.lblOn = New System.Windows.Forms.Label
        Me.dtpExpDate = New System.Windows.Forms.DateTimePicker
        Me.lsvTransactions = New System.Windows.Forms.ListView
        Me.twcAmount = New TwinText
        Me.twcComments = New TwinText
        Me.twcExpense = New TwinText
        Me.twcMethod = New TwinText
        Me.twcGroupby = New TwinCombo
        Me.Panel1.SuspendLayout()
        Me.grpQuery.SuspendLayout()
        Me.grpReport.SuspendLayout()
        Me.SuspendLayout()
        '
        'butUpdateRecord
        '
        Me.butUpdateRecord.Enabled = False
        Me.butUpdateRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butUpdateRecord.Location = New System.Drawing.Point(48, 238)
        Me.butUpdateRecord.Name = "butUpdateRecord"
        Me.butUpdateRecord.Size = New System.Drawing.Size(125, 23)
        Me.butUpdateRecord.TabIndex = 8
        Me.butUpdateRecord.Text = "&Update Record"
        Me.butUpdateRecord.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.grpQuery)
        Me.Panel1.Controls.Add(Me.grpReport)
        Me.Panel1.Controls.Add(Me.lblFind)
        Me.Panel1.Controls.Add(Me.txtFind)
        Me.Panel1.Controls.Add(Me.lblMonth)
        Me.Panel1.Controls.Add(Me.ymMonth)
        Me.Panel1.Controls.Add(Me.twcAmount)
        Me.Panel1.Controls.Add(Me.butUpdateRecord)
        Me.Panel1.Controls.Add(Me.twcComments)
        Me.Panel1.Controls.Add(Me.butDeleteRecord)
        Me.Panel1.Controls.Add(Me.twcExpense)
        Me.Panel1.Controls.Add(Me.twcMethod)
        Me.Panel1.Controls.Add(Me.lblOn)
        Me.Panel1.Controls.Add(Me.dtpExpDate)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(199, 402)
        Me.Panel1.TabIndex = 13
        '
        'grpQuery
        '
        Me.grpQuery.Controls.Add(Me.rbStarts)
        Me.grpQuery.Controls.Add(Me.rbEnds)
        Me.grpQuery.Controls.Add(Me.rbLike)
        Me.grpQuery.Location = New System.Drawing.Point(11, 131)
        Me.grpQuery.Name = "grpQuery"
        Me.grpQuery.Size = New System.Drawing.Size(126, 89)
        Me.grpQuery.TabIndex = 24
        Me.grpQuery.TabStop = False
        '
        'rbStarts
        '
        Me.rbStarts.AutoSize = True
        Me.rbStarts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbStarts.Location = New System.Drawing.Point(6, 19)
        Me.rbStarts.Name = "rbStarts"
        Me.rbStarts.Size = New System.Drawing.Size(85, 20)
        Me.rbStarts.TabIndex = 21
        Me.rbStarts.Text = "Starts with"
        Me.rbStarts.UseVisualStyleBackColor = True
        '
        'rbEnds
        '
        Me.rbEnds.AutoSize = True
        Me.rbEnds.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEnds.Location = New System.Drawing.Point(6, 64)
        Me.rbEnds.Name = "rbEnds"
        Me.rbEnds.Size = New System.Drawing.Size(82, 20)
        Me.rbEnds.TabIndex = 23
        Me.rbEnds.Text = "Ends with"
        Me.rbEnds.UseVisualStyleBackColor = True
        '
        'rbLike
        '
        Me.rbLike.AutoSize = True
        Me.rbLike.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLike.Location = New System.Drawing.Point(6, 42)
        Me.rbLike.Name = "rbLike"
        Me.rbLike.Size = New System.Drawing.Size(51, 20)
        Me.rbLike.TabIndex = 22
        Me.rbLike.Text = "Like"
        Me.rbLike.UseVisualStyleBackColor = True
        '
        'grpReport
        '
        Me.grpReport.Controls.Add(Me.rbSearch)
        Me.grpReport.Controls.Add(Me.rbDetails)
        Me.grpReport.Location = New System.Drawing.Point(11, 0)
        Me.grpReport.Name = "grpReport"
        Me.grpReport.Size = New System.Drawing.Size(126, 63)
        Me.grpReport.TabIndex = 21
        Me.grpReport.TabStop = False
        '
        'rbSearch
        '
        Me.rbSearch.AutoSize = True
        Me.rbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSearch.Location = New System.Drawing.Point(6, 19)
        Me.rbSearch.Name = "rbSearch"
        Me.rbSearch.Size = New System.Drawing.Size(126, 20)
        Me.rbSearch.TabIndex = 20
        Me.rbSearch.Text = "Search in Report"
        Me.rbSearch.UseVisualStyleBackColor = True
        '
        'rbDetails
        '
        Me.rbDetails.AutoSize = True
        Me.rbDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDetails.Location = New System.Drawing.Point(6, 42)
        Me.rbDetails.Name = "rbDetails"
        Me.rbDetails.Size = New System.Drawing.Size(126, 20)
        Me.rbDetails.TabIndex = 19
        Me.rbDetails.Text = "Details of Report"
        Me.rbDetails.UseVisualStyleBackColor = True
        '
        'lblFind
        '
        Me.lblFind.AutoSize = True
        Me.lblFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFind.Location = New System.Drawing.Point(8, 85)
        Me.lblFind.Name = "lblFind"
        Me.lblFind.Size = New System.Drawing.Size(184, 15)
        Me.lblFind.TabIndex = 15
        Me.lblFind.Text = "Search for an Expense Item"
        '
        'txtFind
        '
        Me.txtFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFind.Location = New System.Drawing.Point(11, 103)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(109, 22)
        Me.txtFind.TabIndex = 12
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Enabled = False
        Me.lblMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.Location = New System.Drawing.Point(8, 72)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(106, 16)
        Me.lblMonth.TabIndex = 11
        Me.lblMonth.Text = "Select the Month"
        '
        'ymMonth
        '
        Me.ymMonth.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ymMonth.Enabled = False
        Me.ymMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ymMonth.Location = New System.Drawing.Point(11, 91)

        Me.ymMonth.Name = "ymMonth"
        Me.ymMonth.Size = New System.Drawing.Size(181, 21)
        Me.ymMonth.TabIndex = 10
        '
        'butDeleteRecord
        '
        Me.butDeleteRecord.Enabled = False
        Me.butDeleteRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butDeleteRecord.Location = New System.Drawing.Point(48, 267)
        Me.butDeleteRecord.Name = "butDeleteRecord"
        Me.butDeleteRecord.Size = New System.Drawing.Size(125, 23)
        Me.butDeleteRecord.TabIndex = 9
        Me.butDeleteRecord.Text = "&Delete Record"
        Me.butDeleteRecord.UseVisualStyleBackColor = True
        '
        'lblOn
        '
        Me.lblOn.AutoSize = True
        Me.lblOn.Location = New System.Drawing.Point(13, 207)
        Me.lblOn.Name = "lblOn"
        Me.lblOn.Size = New System.Drawing.Size(21, 13)
        Me.lblOn.TabIndex = 5
        Me.lblOn.Text = "&On"
        '
        'dtpExpDate
        '
        Me.dtpExpDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpExpDate.Enabled = False
        Me.dtpExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpExpDate.Location = New System.Drawing.Point(74, 202)
        Me.dtpExpDate.Name = "dtpExpDate"
        Me.dtpExpDate.Size = New System.Drawing.Size(95, 20)
        Me.dtpExpDate.TabIndex = 6
        '
        'lsvTransactions
        '
        Me.lsvTransactions.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lsvTransactions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsvTransactions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvTransactions.FullRowSelect = True
        Me.lsvTransactions.GridLines = True
        ListViewGroup1.Header = "ListViewGroup"
        ListViewGroup1.Name = "ListViewGroup1"
        ListViewGroup2.Header = "ListViewGroup"
        ListViewGroup2.Name = "ListViewGroup2"
        Me.lsvTransactions.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2})
        Me.lsvTransactions.HideSelection = False
        Me.lsvTransactions.Location = New System.Drawing.Point(199, 24)
        Me.lsvTransactions.MultiSelect = False
        Me.lsvTransactions.Name = "lsvTransactions"
        Me.lsvTransactions.Size = New System.Drawing.Size(365, 402)
        Me.lsvTransactions.TabIndex = 14
        Me.lsvTransactions.UseCompatibleStateImageBehavior = False
        Me.lsvTransactions.View = System.Windows.Forms.View.Details
        '
        'twcAmount
        '
        Me.twcAmount.AlignVertical = False
        Me.twcAmount.AllowNumeric = False
        Me.twcAmount.Enabled = False
        Me.twcAmount.FillerLength = 9
        Me.twcAmount.Label = "&nText   "
        Me.twcAmount.Location = New System.Drawing.Point(11, 181)
        Me.twcAmount.MultiLine = False
        Me.twcAmount.Name = "twcAmount"
        Me.twcAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.twcAmount.Scrollbars = System.Windows.Forms.ScrollBars.None
        Me.twcAmount.Size = New System.Drawing.Size(160, 22)
        Me.twcAmount.TabIndex = 4
        '
        'twcComments
        '
        Me.twcComments.AlignVertical = False
        Me.twcComments.AllowNumeric = False
        Me.twcComments.Enabled = False
        Me.twcComments.FillerLength = 0
        Me.twcComments.Label = "&nText   "
        Me.twcComments.Location = New System.Drawing.Point(11, 159)
        Me.twcComments.MultiLine = False
        Me.twcComments.Name = "twcComments"
        Me.twcComments.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.twcComments.Scrollbars = System.Windows.Forms.ScrollBars.None
        Me.twcComments.Size = New System.Drawing.Size(160, 22)
        Me.twcComments.TabIndex = 3
        '
        'twcExpense
        '
        Me.twcExpense.AlignVertical = False
        Me.twcExpense.AllowNumeric = False
        Me.twcExpense.Enabled = False
        Me.twcExpense.FillerLength = 9
        Me.twcExpense.Label = "&nText   "
        Me.twcExpense.Location = New System.Drawing.Point(11, 115)
        Me.twcExpense.MultiLine = False
        Me.twcExpense.Name = "twcExpense"
        Me.twcExpense.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.twcExpense.Scrollbars = System.Windows.Forms.ScrollBars.None
        Me.twcExpense.Size = New System.Drawing.Size(160, 22)
        Me.twcExpense.TabIndex = 1
        '
        'twcMethod
        '
        Me.twcMethod.AlignVertical = False
        Me.twcMethod.AllowNumeric = False
        Me.twcMethod.Enabled = False
        Me.twcMethod.FillerLength = 9
        Me.twcMethod.Label = "&nText   "
        Me.twcMethod.Location = New System.Drawing.Point(11, 137)
        Me.twcMethod.MultiLine = False
        Me.twcMethod.Name = "twcMethod"
        Me.twcMethod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.twcMethod.Scrollbars = System.Windows.Forms.ScrollBars.None
        Me.twcMethod.Size = New System.Drawing.Size(160, 22)
        Me.twcMethod.TabIndex = 2
        '
        'twcGroupby
        '
        Me.twcGroupby.AlignVertical = False
        Me.twcGroupby.Dock = System.Windows.Forms.DockStyle.Top
        Me.twcGroupby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.twcGroupby.FillerLength = 6
        Me.twcGroupby.Location = New System.Drawing.Point(0, 0)
        Me.twcGroupby.Name = "twcGroupby"
        Me.twcGroupby.SelectedIndex = -1
        Me.twcGroupby.SelectedItem = Nothing
        Me.twcGroupby.Size = New System.Drawing.Size(564, 24)
        Me.twcGroupby.TabIndex = 0
        '
        'Transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lsvTransactions)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.twcGroupby)
        Me.Name = "Transactions"
        Me.Size = New System.Drawing.Size(564, 426)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grpQuery.ResumeLayout(False)
        Me.grpQuery.PerformLayout()
        Me.grpReport.ResumeLayout(False)
        Me.grpReport.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents twcGroupby As TwinCombo
    Friend WithEvents butUpdateRecord As System.Windows.Forms.Button
    Friend WithEvents twcAmount As TwinText
    Friend WithEvents twcComments As TwinText
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents butDeleteRecord As System.Windows.Forms.Button
    Friend WithEvents twcExpense As TwinText
    Friend WithEvents twcMethod As TwinText
    Friend WithEvents lblOn As System.Windows.Forms.Label
    Friend WithEvents dtpExpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lsvTransactions As System.Windows.Forms.ListView
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents ymMonth As VitalLogic.Controls.YearMonth
    Friend WithEvents lblFind As System.Windows.Forms.Label
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents rbDetails As System.Windows.Forms.RadioButton
    Friend WithEvents rbSearch As System.Windows.Forms.RadioButton
    Friend WithEvents rbEnds As System.Windows.Forms.RadioButton
    Friend WithEvents rbLike As System.Windows.Forms.RadioButton
    Friend WithEvents rbStarts As System.Windows.Forms.RadioButton
    Friend WithEvents grpReport As System.Windows.Forms.GroupBox
    Friend WithEvents grpQuery As System.Windows.Forms.GroupBox
 
End Class
