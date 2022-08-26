<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Expenses
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
        Me.colHExpense = New System.Windows.Forms.ColumnHeader
        Me.colHFreq = New System.Windows.Forms.ColumnHeader
        Me.lsvExpenses = New System.Windows.Forms.ListView
        Me.lblFreq = New System.Windows.Forms.Label
        Me.cboFrequency = New System.Windows.Forms.ComboBox
        Me.butDelete = New System.Windows.Forms.Button
        Me.butAdd = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtExpense = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'colHExpense
        '
        Me.colHExpense.Text = "Expense"
        Me.colHExpense.Width = 264
        '
        'colHFreq
        '
        Me.colHFreq.Text = "Frequency"
        Me.colHFreq.Width = 101
        '
        'lsvExpenses
        '
        Me.lsvExpenses.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lsvExpenses.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colHExpense, Me.colHFreq})
        Me.lsvExpenses.Dock = System.Windows.Forms.DockStyle.Left
        Me.lsvExpenses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvExpenses.FullRowSelect = True
        Me.lsvExpenses.GridLines = True
        Me.lsvExpenses.HideSelection = False
        Me.lsvExpenses.Location = New System.Drawing.Point(0, 0)
        Me.lsvExpenses.MultiSelect = False
        Me.lsvExpenses.Name = "lsvExpenses"
        Me.lsvExpenses.Size = New System.Drawing.Size(373, 306)
        Me.lsvExpenses.TabIndex = 8
        Me.lsvExpenses.UseCompatibleStateImageBehavior = False
        Me.lsvExpenses.View = System.Windows.Forms.View.Details
        '
        'lblFreq
        '
        Me.lblFreq.AutoSize = True
        Me.lblFreq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFreq.Location = New System.Drawing.Point(380, 42)
        Me.lblFreq.Name = "lblFreq"
        Me.lblFreq.Size = New System.Drawing.Size(72, 16)
        Me.lblFreq.TabIndex = 11
        Me.lblFreq.Text = "&Frequency"
        '
        'cboFrequency
        '
        Me.cboFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFrequency.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFrequency.FormattingEnabled = True
        Me.cboFrequency.Items.AddRange(New Object() {"DAILY", "ALT-DAYS", "WEEKLY", "BI-WEEKLY", "FORTNIGHT", "MONTHLY", "QUARTER", "HALFYEAR", "YEARLY", "ADHOC"})
        Me.cboFrequency.Location = New System.Drawing.Point(383, 61)
        Me.cboFrequency.Name = "cboFrequency"
        Me.cboFrequency.Size = New System.Drawing.Size(122, 24)
        Me.cboFrequency.TabIndex = 12
        '
        'butDelete
        '
        Me.butDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butDelete.Location = New System.Drawing.Point(383, 128)
        Me.butDelete.Name = "butDelete"
        Me.butDelete.Size = New System.Drawing.Size(125, 23)
        Me.butDelete.TabIndex = 14
        Me.butDelete.Text = "&Delete"
        Me.butDelete.UseVisualStyleBackColor = True
        '
        'butAdd
        '
        Me.butAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAdd.Location = New System.Drawing.Point(383, 99)
        Me.butAdd.Name = "butAdd"
        Me.butAdd.Size = New System.Drawing.Size(126, 23)
        Me.butAdd.TabIndex = 13
        Me.butAdd.Text = "&Add"
        Me.butAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(380, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Expen&se"
        '
        'txtExpense
        '
        Me.txtExpense.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpense.Location = New System.Drawing.Point(380, 16)
        Me.txtExpense.MaxLength = 100
        Me.txtExpense.Name = "txtExpense"
        Me.txtExpense.Size = New System.Drawing.Size(125, 22)
        Me.txtExpense.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Info
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(385, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 54)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "F1 - Help" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F2 - Add note" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F3 - Calculator" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F4 - Currency converter"
        '
        'Expenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lsvExpenses)
        Me.Controls.Add(Me.lblFreq)
        Me.Controls.Add(Me.cboFrequency)
        Me.Controls.Add(Me.butDelete)
        Me.Controls.Add(Me.butAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtExpense)
        Me.Name = "Expenses"
        Me.Size = New System.Drawing.Size(579, 306)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents colHExpense As System.Windows.Forms.ColumnHeader
    Friend WithEvents colHFreq As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvExpenses As System.Windows.Forms.ListView
    Friend WithEvents lblFreq As System.Windows.Forms.Label
    Friend WithEvents cboFrequency As System.Windows.Forms.ComboBox
    Friend WithEvents butDelete As System.Windows.Forms.Button
    Friend WithEvents butAdd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtExpense As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
