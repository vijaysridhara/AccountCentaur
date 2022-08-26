<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Income
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
        Me.butDeleteEntry = New System.Windows.Forms.Button
        Me.butUpdateEntry = New System.Windows.Forms.Button
        Me.butMakeEntry = New System.Windows.Forms.Button
        Me.twtComments = New TwinText
        Me.twtNetIncome = New TwinText
        Me.twtOtherDeduction = New TwinText
        Me.twtLoanDeductions = New TwinText
        Me.twtSavings = New TwinText
        Me.twtIncomeTax = New TwinText
        Me.twtGrossIncome = New TwinText
        Me.twcType = New TwinCombo
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpYear = New System.Windows.Forms.DateTimePicker
        Me.lsvIncome = New System.Windows.Forms.ListView
        Me.colType = New System.Windows.Forms.ColumnHeader
        Me.colGross = New System.Windows.Forms.ColumnHeader
        Me.colTax = New System.Windows.Forms.ColumnHeader
        Me.colPFD = New System.Windows.Forms.ColumnHeader
        Me.colLoans = New System.Windows.Forms.ColumnHeader
        Me.colOther = New System.Windows.Forms.ColumnHeader
        Me.colNet = New System.Windows.Forms.ColumnHeader
        Me.colComments = New System.Windows.Forms.ColumnHeader
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.butDeleteEntry)
        Me.Panel1.Controls.Add(Me.butUpdateEntry)
        Me.Panel1.Controls.Add(Me.butMakeEntry)
        Me.Panel1.Controls.Add(Me.twtComments)
        Me.Panel1.Controls.Add(Me.twtNetIncome)
        Me.Panel1.Controls.Add(Me.twtOtherDeduction)
        Me.Panel1.Controls.Add(Me.twtLoanDeductions)
        Me.Panel1.Controls.Add(Me.twtSavings)
        Me.Panel1.Controls.Add(Me.twtIncomeTax)
        Me.Panel1.Controls.Add(Me.twtGrossIncome)
        Me.Panel1.Controls.Add(Me.twcType)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dtpYear)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 226)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 168)
        Me.Panel1.TabIndex = 0
        '
        'butDeleteEntry
        '
        Me.butDeleteEntry.Enabled = False
        Me.butDeleteEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butDeleteEntry.Location = New System.Drawing.Point(429, 81)
        Me.butDeleteEntry.Name = "butDeleteEntry"
        Me.butDeleteEntry.Size = New System.Drawing.Size(115, 28)
        Me.butDeleteEntry.TabIndex = 12
        Me.butDeleteEntry.Text = "&Delete entry"
        Me.butDeleteEntry.UseVisualStyleBackColor = True
        '
        'butUpdateEntry
        '
        Me.butUpdateEntry.Enabled = False
        Me.butUpdateEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butUpdateEntry.Location = New System.Drawing.Point(429, 44)
        Me.butUpdateEntry.Name = "butUpdateEntry"
        Me.butUpdateEntry.Size = New System.Drawing.Size(115, 28)
        Me.butUpdateEntry.TabIndex = 11
        Me.butUpdateEntry.Text = "&Update entry"
        Me.butUpdateEntry.UseVisualStyleBackColor = True
        '
        'butMakeEntry
        '
        Me.butMakeEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butMakeEntry.Location = New System.Drawing.Point(429, 10)
        Me.butMakeEntry.Name = "butMakeEntry"
        Me.butMakeEntry.Size = New System.Drawing.Size(115, 28)
        Me.butMakeEntry.TabIndex = 10
        Me.butMakeEntry.Text = "Make &entry"
        Me.butMakeEntry.UseVisualStyleBackColor = True
        '
        'twtComments
        '
        Me.twtComments.AlignVertical = False
        Me.twtComments.AllowNumeric = False
        Me.twtComments.FillerLength = 0
        Me.twtComments.Label = "&nText"
        Me.twtComments.Location = New System.Drawing.Point(10, 56)
        Me.twtComments.MultiLine = False
        Me.twtComments.Name = "twtComments"
        Me.twtComments.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.twtComments.Scrollbars = System.Windows.Forms.ScrollBars.None
        Me.twtComments.Size = New System.Drawing.Size(150, 22)
        Me.twtComments.TabIndex = 3
        '
        'twtNetIncome
        '
        Me.twtNetIncome.AlignVertical = False
        Me.twtNetIncome.AllowNumeric = True
        Me.twtNetIncome.FillerLength = 15
        Me.twtNetIncome.Label = "&nText         "
        Me.twtNetIncome.Location = New System.Drawing.Point(212, 133)
        Me.twtNetIncome.MultiLine = False
        Me.twtNetIncome.Name = "twtNetIncome"
        Me.twtNetIncome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.twtNetIncome.Scrollbars = System.Windows.Forms.ScrollBars.None
        Me.twtNetIncome.Size = New System.Drawing.Size(207, 22)
        Me.twtNetIncome.TabIndex = 9
        '
        'twtOtherDeduction
        '
        Me.twtOtherDeduction.AlignVertical = False
        Me.twtOtherDeduction.AllowNumeric = True
        Me.twtOtherDeduction.FillerLength = 14
        Me.twtOtherDeduction.Label = "&nText        "
        Me.twtOtherDeduction.Location = New System.Drawing.Point(212, 107)
        Me.twtOtherDeduction.MultiLine = False
        Me.twtOtherDeduction.Name = "twtOtherDeduction"
        Me.twtOtherDeduction.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.twtOtherDeduction.Scrollbars = System.Windows.Forms.ScrollBars.None
        Me.twtOtherDeduction.Size = New System.Drawing.Size(207, 22)
        Me.twtOtherDeduction.TabIndex = 8
        '
        'twtLoanDeductions
        '
        Me.twtLoanDeductions.AlignVertical = False
        Me.twtLoanDeductions.AllowNumeric = True
        Me.twtLoanDeductions.FillerLength = 14
        Me.twtLoanDeductions.Label = "&nText        "
        Me.twtLoanDeductions.Location = New System.Drawing.Point(212, 81)
        Me.twtLoanDeductions.MultiLine = False
        Me.twtLoanDeductions.Name = "twtLoanDeductions"
        Me.twtLoanDeductions.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.twtLoanDeductions.Scrollbars = System.Windows.Forms.ScrollBars.None
        Me.twtLoanDeductions.Size = New System.Drawing.Size(207, 22)
        Me.twtLoanDeductions.TabIndex = 7
        '
        'twtSavings
        '
        Me.twtSavings.AlignVertical = False
        Me.twtSavings.AllowNumeric = True
        Me.twtSavings.FillerLength = 15
        Me.twtSavings.Label = "&nText         "
        Me.twtSavings.Location = New System.Drawing.Point(212, 55)
        Me.twtSavings.MultiLine = False
        Me.twtSavings.Name = "twtSavings"
        Me.twtSavings.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.twtSavings.Scrollbars = System.Windows.Forms.ScrollBars.None
        Me.twtSavings.Size = New System.Drawing.Size(207, 22)
        Me.twtSavings.TabIndex = 6
        '
        'twtIncomeTax
        '
        Me.twtIncomeTax.AlignVertical = False
        Me.twtIncomeTax.AllowNumeric = True
        Me.twtIncomeTax.FillerLength = 15
        Me.twtIncomeTax.Label = "&nText         "
        Me.twtIncomeTax.Location = New System.Drawing.Point(212, 29)
        Me.twtIncomeTax.MultiLine = False
        Me.twtIncomeTax.Name = "twtIncomeTax"
        Me.twtIncomeTax.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.twtIncomeTax.Scrollbars = System.Windows.Forms.ScrollBars.None
        Me.twtIncomeTax.Size = New System.Drawing.Size(207, 22)
        Me.twtIncomeTax.TabIndex = 5
        '
        'twtGrossIncome
        '
        Me.twtGrossIncome.AlignVertical = False
        Me.twtGrossIncome.AllowNumeric = True
        Me.twtGrossIncome.FillerLength = 15
        Me.twtGrossIncome.Label = "&nText         "
        Me.twtGrossIncome.Location = New System.Drawing.Point(212, 3)
        Me.twtGrossIncome.MultiLine = False
        Me.twtGrossIncome.Name = "twtGrossIncome"
        Me.twtGrossIncome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.twtGrossIncome.Scrollbars = System.Windows.Forms.ScrollBars.None
        Me.twtGrossIncome.Size = New System.Drawing.Size(207, 22)
        Me.twtGrossIncome.TabIndex = 4
        '
        'twcType
        '
        Me.twcType.AlignVertical = False
        Me.twcType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.twcType.FillerLength = 9
        Me.twcType.Location = New System.Drawing.Point(10, 29)
        Me.twcType.Name = "twcType"
        Me.twcType.SelectedIndex = -1
        Me.twcType.SelectedItem = Nothing
        Me.twcType.Size = New System.Drawing.Size(150, 24)
        Me.twcType.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&For month"
        '
        'dtpYear
        '
        Me.dtpYear.CustomFormat = "yyyy-MM"
        Me.dtpYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYear.Location = New System.Drawing.Point(73, 3)
        Me.dtpYear.Name = "dtpYear"
        Me.dtpYear.Size = New System.Drawing.Size(67, 22)
        Me.dtpYear.TabIndex = 1
        '
        'lsvIncome
        '
        Me.lsvIncome.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lsvIncome.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colType, Me.colGross, Me.colTax, Me.colPFD, Me.colLoans, Me.colOther, Me.colNet, Me.colComments})
        Me.lsvIncome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsvIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvIncome.FullRowSelect = True
        Me.lsvIncome.GridLines = True
        Me.lsvIncome.HideSelection = False
        Me.lsvIncome.Location = New System.Drawing.Point(0, 0)
        Me.lsvIncome.MultiSelect = False
        Me.lsvIncome.Name = "lsvIncome"
        Me.lsvIncome.Size = New System.Drawing.Size(584, 226)
        Me.lsvIncome.TabIndex = 0
        Me.lsvIncome.UseCompatibleStateImageBehavior = False
        Me.lsvIncome.View = System.Windows.Forms.View.Details
        '
        'colType
        '
        Me.colType.Text = "Type"
        Me.colType.Width = 100
        '
        'colGross
        '
        Me.colGross.Text = "Gross"
        Me.colGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colGross.Width = 120
        '
        'colTax
        '
        Me.colTax.Text = "Tax"
        Me.colTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colTax.Width = 100
        '
        'colPFD
        '
        Me.colPFD.Text = "Savings"
        Me.colPFD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colPFD.Width = 100
        '
        'colLoans
        '
        Me.colLoans.Text = "Loans"
        Me.colLoans.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colLoans.Width = 100
        '
        'colOther
        '
        Me.colOther.Text = "Others"
        Me.colOther.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colOther.Width = 100
        '
        'colNet
        '
        Me.colNet.Text = "Net"
        Me.colNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colNet.Width = 120
        '
        'colComments
        '
        Me.colComments.Text = "Comments"
        Me.colComments.Width = 200
        '
        'Income
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lsvIncome)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Income"
        Me.Size = New System.Drawing.Size(584, 394)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpYear As System.Windows.Forms.DateTimePicker
    Friend WithEvents twcType As TwinCombo
    Friend WithEvents twtGrossIncome As TwinText
    Friend WithEvents twtLoanDeductions As TwinText
    Friend WithEvents twtSavings As TwinText
    Friend WithEvents twtIncomeTax As TwinText
    Friend WithEvents twtNetIncome As TwinText
    Friend WithEvents twtOtherDeduction As TwinText
    Friend WithEvents twtComments As TwinText
    Friend WithEvents lsvIncome As System.Windows.Forms.ListView
    Friend WithEvents colType As System.Windows.Forms.ColumnHeader
    Friend WithEvents colGross As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTax As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPFD As System.Windows.Forms.ColumnHeader
    Friend WithEvents colLoans As System.Windows.Forms.ColumnHeader
    Friend WithEvents colOther As System.Windows.Forms.ColumnHeader
    Friend WithEvents colNet As System.Windows.Forms.ColumnHeader
    Friend WithEvents colComments As System.Windows.Forms.ColumnHeader
    Friend WithEvents butDeleteEntry As System.Windows.Forms.Button
    Friend WithEvents butUpdateEntry As System.Windows.Forms.Button
    Friend WithEvents butMakeEntry As System.Windows.Forms.Button

End Class
