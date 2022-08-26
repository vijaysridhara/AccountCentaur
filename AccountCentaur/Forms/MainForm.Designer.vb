<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Hsplitter = New System.Windows.Forms.SplitContainer
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.optEntry = New System.Windows.Forms.RadioButton
        Me.chkReminders = New System.Windows.Forms.CheckBox
        Me.butExit = New System.Windows.Forms.Button
        Me.butResetpw = New System.Windows.Forms.Button
        Me.butHelp = New System.Windows.Forms.Button
        Me.butUsers = New System.Windows.Forms.RadioButton
        Me.optExpenses = New System.Windows.Forms.RadioButton
        Me.optAbout = New System.Windows.Forms.RadioButton
        Me.optIncome = New System.Windows.Forms.RadioButton
        Me.optNotes = New System.Windows.Forms.RadioButton
        Me.optSavings = New System.Windows.Forms.RadioButton
        Me.optGraphs = New System.Windows.Forms.RadioButton
        Me.optReport = New System.Windows.Forms.RadioButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Savings1 = New Savings
        Me.Notes1 = New Notes
        Me.Users1 = New Users
        Me.Income1 = New Income
        Me.About1 = New About
        Me.Graph1 = New Graph
        Me.Transactions1 = New Transactions
        Me.Expenses1 = New Expenses
        Me.EntryPanel1 = New EntryPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.butCalc = New System.Windows.Forms.Button
        Me.tmrReminders = New System.Windows.Forms.Timer(Me.components)
        Me.ctxTrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewExpenseToolstripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ShowWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Hsplitter.Panel1.SuspendLayout()
        Me.Hsplitter.Panel2.SuspendLayout()
        Me.Hsplitter.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxTrayMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Hsplitter
        '
        Me.Hsplitter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Hsplitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.Hsplitter.Location = New System.Drawing.Point(0, 0)
        Me.Hsplitter.Name = "Hsplitter"
        '
        'Hsplitter.Panel1
        '
        Me.Hsplitter.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Hsplitter.Panel1.Controls.Add(Me.Panel2)
        Me.Hsplitter.Panel1.Controls.Add(Me.PictureBox1)
        '
        'Hsplitter.Panel2
        '
        Me.Hsplitter.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Hsplitter.Panel2.Controls.Add(Me.Savings1)
        Me.Hsplitter.Panel2.Controls.Add(Me.Notes1)
        Me.Hsplitter.Panel2.Controls.Add(Me.Users1)
        Me.Hsplitter.Panel2.Controls.Add(Me.Income1)
        Me.Hsplitter.Panel2.Controls.Add(Me.About1)
        Me.Hsplitter.Panel2.Controls.Add(Me.Graph1)
        Me.Hsplitter.Panel2.Controls.Add(Me.Transactions1)
        Me.Hsplitter.Panel2.Controls.Add(Me.Expenses1)
        Me.Hsplitter.Panel2.Controls.Add(Me.EntryPanel1)
        Me.Hsplitter.Panel2.Controls.Add(Me.Panel1)
        Me.Hsplitter.Size = New System.Drawing.Size(774, 581)
        Me.Hsplitter.SplitterDistance = 144
        Me.Hsplitter.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.optEntry)
        Me.Panel2.Controls.Add(Me.chkReminders)
        Me.Panel2.Controls.Add(Me.butExit)
        Me.Panel2.Controls.Add(Me.butResetpw)
        Me.Panel2.Controls.Add(Me.butHelp)
        Me.Panel2.Controls.Add(Me.butUsers)
        Me.Panel2.Controls.Add(Me.optExpenses)
        Me.Panel2.Controls.Add(Me.optAbout)
        Me.Panel2.Controls.Add(Me.optIncome)
        Me.Panel2.Controls.Add(Me.optNotes)
        Me.Panel2.Controls.Add(Me.optSavings)
        Me.Panel2.Controls.Add(Me.optGraphs)
        Me.Panel2.Controls.Add(Me.optReport)
        Me.Panel2.Location = New System.Drawing.Point(12, 108)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(120, 470)
        Me.Panel2.TabIndex = 37
        '
        'optEntry
        '
        Me.optEntry.Appearance = System.Windows.Forms.Appearance.Button
        Me.optEntry.Checked = True
        Me.optEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optEntry.Image = My.Resources.Resources.Entry1
        Me.optEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optEntry.Location = New System.Drawing.Point(3, 3)
        Me.optEntry.Name = "optEntry"
        Me.optEntry.Size = New System.Drawing.Size(107, 34)
        Me.optEntry.TabIndex = 0
        Me.optEntry.TabStop = True
        Me.optEntry.Text = "Entr&y"
        Me.optEntry.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optEntry.UseVisualStyleBackColor = True
        '
        'chkReminders
        '
        Me.chkReminders.AutoSize = True
        Me.chkReminders.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReminders.Location = New System.Drawing.Point(10, 362)
        Me.chkReminders.Name = "chkReminders"
        Me.chkReminders.Size = New System.Drawing.Size(93, 20)
        Me.chkReminders.TabIndex = 12
        Me.chkReminders.Text = "Re&minders"
        Me.chkReminders.UseVisualStyleBackColor = True
        '
        'butExit
        '
        Me.butExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butExit.Image = My.Resources.Resources._Exit
        Me.butExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.butExit.Location = New System.Drawing.Point(4, 440)
        Me.butExit.Name = "butExit"
        Me.butExit.Size = New System.Drawing.Size(106, 25)
        Me.butExit.TabIndex = 11
        Me.butExit.Text = "E&xit"
        Me.butExit.UseVisualStyleBackColor = True
        '
        'butResetpw
        '
        Me.butResetpw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butResetpw.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butResetpw.Location = New System.Drawing.Point(4, 389)
        Me.butResetpw.Name = "butResetpw"
        Me.butResetpw.Size = New System.Drawing.Size(106, 23)
        Me.butResetpw.TabIndex = 9
        Me.butResetpw.Text = "Reset p&w"
        Me.butResetpw.UseVisualStyleBackColor = True
        '
        'butHelp
        '
        Me.butHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butHelp.Image = My.Resources.Resources.Help
        Me.butHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.butHelp.Location = New System.Drawing.Point(4, 414)
        Me.butHelp.Name = "butHelp"
        Me.butHelp.Size = New System.Drawing.Size(106, 25)
        Me.butHelp.TabIndex = 10
        Me.butHelp.Text = "&Help"
        Me.butHelp.UseVisualStyleBackColor = True
        '
        'butUsers
        '
        Me.butUsers.Appearance = System.Windows.Forms.Appearance.Button
        Me.butUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butUsers.Image = My.Resources.Resources.User1
        Me.butUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.butUsers.Location = New System.Drawing.Point(3, 274)
        Me.butUsers.Name = "butUsers"
        Me.butUsers.Size = New System.Drawing.Size(107, 37)
        Me.butUsers.TabIndex = 7
        Me.butUsers.Text = "&Users"
        Me.butUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.butUsers.UseVisualStyleBackColor = True
        '
        'optExpenses
        '
        Me.optExpenses.Appearance = System.Windows.Forms.Appearance.Button
        Me.optExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optExpenses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optExpenses.Image = My.Resources.Resources.Expenses1
        Me.optExpenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optExpenses.Location = New System.Drawing.Point(3, 40)
        Me.optExpenses.Name = "optExpenses"
        Me.optExpenses.Size = New System.Drawing.Size(107, 36)
        Me.optExpenses.TabIndex = 1
        Me.optExpenses.Text = "&Expenses"
        Me.optExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optExpenses.UseVisualStyleBackColor = True
        '
        'optAbout
        '
        Me.optAbout.Appearance = System.Windows.Forms.Appearance.Button
        Me.optAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAbout.Image = My.Resources.Resources.About
        Me.optAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optAbout.Location = New System.Drawing.Point(3, 314)
        Me.optAbout.Name = "optAbout"
        Me.optAbout.Size = New System.Drawing.Size(107, 36)
        Me.optAbout.TabIndex = 8
        Me.optAbout.Text = "&About"
        Me.optAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optAbout.UseVisualStyleBackColor = True
        '
        'optIncome
        '
        Me.optIncome.Appearance = System.Windows.Forms.Appearance.Button
        Me.optIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optIncome.Image = My.Resources.Resources.Income1
        Me.optIncome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optIncome.Location = New System.Drawing.Point(3, 79)
        Me.optIncome.Name = "optIncome"
        Me.optIncome.Size = New System.Drawing.Size(107, 36)
        Me.optIncome.TabIndex = 2
        Me.optIncome.Text = "In&come"
        Me.optIncome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optIncome.UseVisualStyleBackColor = True
        '
        'optNotes
        '
        Me.optNotes.Appearance = System.Windows.Forms.Appearance.Button
        Me.optNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optNotes.Image = My.Resources.Resources.note
        Me.optNotes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optNotes.Location = New System.Drawing.Point(3, 235)
        Me.optNotes.Name = "optNotes"
        Me.optNotes.Size = New System.Drawing.Size(107, 36)
        Me.optNotes.TabIndex = 6
        Me.optNotes.Text = "N&otes"
        Me.optNotes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optNotes.UseVisualStyleBackColor = True
        '
        'optSavings
        '
        Me.optSavings.Appearance = System.Windows.Forms.Appearance.Button
        Me.optSavings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSavings.Image = My.Resources.Resources.saving
        Me.optSavings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optSavings.Location = New System.Drawing.Point(3, 118)
        Me.optSavings.Name = "optSavings"
        Me.optSavings.Size = New System.Drawing.Size(107, 36)
        Me.optSavings.TabIndex = 3
        Me.optSavings.Text = "&Savings"
        Me.optSavings.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optSavings.UseVisualStyleBackColor = True
        '
        'optGraphs
        '
        Me.optGraphs.Appearance = System.Windows.Forms.Appearance.Button
        Me.optGraphs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optGraphs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optGraphs.Image = My.Resources.Resources.pie
        Me.optGraphs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optGraphs.Location = New System.Drawing.Point(3, 196)
        Me.optGraphs.Name = "optGraphs"
        Me.optGraphs.Size = New System.Drawing.Size(107, 36)
        Me.optGraphs.TabIndex = 5
        Me.optGraphs.Text = "&Graphs"
        Me.optGraphs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optGraphs.UseVisualStyleBackColor = True
        '
        'optReport
        '
        Me.optReport.Appearance = System.Windows.Forms.Appearance.Button
        Me.optReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optReport.Image = My.Resources.Resources.Report
        Me.optReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optReport.Location = New System.Drawing.Point(3, 157)
        Me.optReport.Name = "optReport"
        Me.optReport.Size = New System.Drawing.Size(107, 36)
        Me.optReport.TabIndex = 4
        Me.optReport.Text = "&Report"
        Me.optReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optReport.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = My.Resources.Resources.mybook
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Savings1
        '
        Me.Savings1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Savings1.Location = New System.Drawing.Point(90, 320)
        Me.Savings1.Name = "Savings1"
        Me.Savings1.Size = New System.Drawing.Size(317, 240)
        Me.Savings1.TabIndex = 36
        '
        'Notes1
        '
        Me.Notes1.Location = New System.Drawing.Point(182, 88)
        Me.Notes1.Name = "Notes1"
        Me.Notes1.Size = New System.Drawing.Size(275, 211)
        Me.Notes1.TabIndex = 35
        '
        'Users1
        '
        Me.Users1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Users1.Location = New System.Drawing.Point(15, 146)
        Me.Users1.Name = "Users1"
        Me.Users1.Size = New System.Drawing.Size(336, 291)
        Me.Users1.TabIndex = 34
        '
        'Income1
        '
        Me.Income1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Income1.Location = New System.Drawing.Point(424, 91)
        Me.Income1.Name = "Income1"
        Me.Income1.Size = New System.Drawing.Size(126, 138)
        Me.Income1.TabIndex = 33
        '
        'About1
        '
        Me.About1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.About1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.About1.Location = New System.Drawing.Point(383, 285)
        Me.About1.Name = "About1"
        Me.About1.Size = New System.Drawing.Size(413, 394)
        Me.About1.TabIndex = 32
        Me.About1.Visible = False
        '
        'Graph1
        '
        Me.Graph1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Graph1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Graph1.Location = New System.Drawing.Point(351, 346)
        Me.Graph1.Name = "Graph1"
        Me.Graph1.Size = New System.Drawing.Size(157, 151)
        Me.Graph1.TabIndex = 31
        Me.Graph1.Visible = False
        '
        'Transactions1
        '
        Me.Transactions1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Transactions1.Location = New System.Drawing.Point(182, 365)
        Me.Transactions1.Name = "Transactions1"
        Me.Transactions1.ShowMod = False
        Me.Transactions1.Size = New System.Drawing.Size(130, 117)
        Me.Transactions1.TabIndex = 30
        Me.Transactions1.UseGlobalIndex = True
        Me.Transactions1.Visible = False
        '
        'Expenses1
        '
        Me.Expenses1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Expenses1.Location = New System.Drawing.Point(214, 285)
        Me.Expenses1.Name = "Expenses1"
        Me.Expenses1.Size = New System.Drawing.Size(76, 58)
        Me.Expenses1.TabIndex = 29
        Me.Expenses1.Visible = False
        '
        'EntryPanel1
        '
        Me.EntryPanel1.Location = New System.Drawing.Point(351, 135)
        Me.EntryPanel1.Name = "EntryPanel1"
        Me.EntryPanel1.Size = New System.Drawing.Size(152, 125)
        Me.EntryPanel1.TabIndex = 28
        Me.EntryPanel1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Controls.Add(Me.butCalc)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(626, 29)
        Me.Panel1.TabIndex = 27
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.RosyBrown
        Me.PictureBox2.Image = My.Resources.Resources.VitalLogicSmall
        Me.PictureBox2.Location = New System.Drawing.Point(30, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.RosyBrown
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Yellow
        Me.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTitle.Location = New System.Drawing.Point(30, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(596, 29)
        Me.lblTitle.TabIndex = 27
        Me.lblTitle.Text = "Label1"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'butCalc
        '
        Me.butCalc.Dock = System.Windows.Forms.DockStyle.Left
        Me.butCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butCalc.Image = My.Resources.Resources.calci
        Me.butCalc.Location = New System.Drawing.Point(0, 0)
        Me.butCalc.Name = "butCalc"
        Me.butCalc.Size = New System.Drawing.Size(30, 29)
        Me.butCalc.TabIndex = 0
        Me.butCalc.UseVisualStyleBackColor = True
        '
        'tmrReminders
        '
        Me.tmrReminders.Interval = 30000
        '
        'ctxTrayMenu
        '
        Me.ctxTrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewExpenseToolstripMenuItem, Me.ShowWindowToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.ctxTrayMenu.Name = "ctxTrayMenu"
        Me.ctxTrayMenu.Size = New System.Drawing.Size(145, 76)
        '
        'NewExpenseToolstripMenuItem
        '
        Me.NewExpenseToolstripMenuItem.Name = "NewExpenseToolstripMenuItem"
        Me.NewExpenseToolstripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.NewExpenseToolstripMenuItem.Text = "New entry"
        '
        'ShowWindowToolStripMenuItem
        '
        Me.ShowWindowToolStripMenuItem.Name = "ShowWindowToolStripMenuItem"
        Me.ShowWindowToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ShowWindowToolStripMenuItem.Text = "Hide window"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(141, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 581)
        Me.Controls.Add(Me.Hsplitter)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.Text = "Account Centaur"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Hsplitter.Panel1.ResumeLayout(False)
        Me.Hsplitter.Panel2.ResumeLayout(False)
        Me.Hsplitter.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctxTrayMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Hsplitter As System.Windows.Forms.SplitContainer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents butExit As System.Windows.Forms.Button
    Friend WithEvents optEntry As System.Windows.Forms.RadioButton
    Friend WithEvents optExpenses As System.Windows.Forms.RadioButton
    Friend WithEvents optIncome As System.Windows.Forms.RadioButton
    Friend WithEvents optReport As System.Windows.Forms.RadioButton
    Friend WithEvents optGraphs As System.Windows.Forms.RadioButton
    Friend WithEvents optAbout As System.Windows.Forms.RadioButton
    Friend WithEvents butUsers As System.Windows.Forms.RadioButton
    Friend WithEvents butResetpw As System.Windows.Forms.Button
    Friend WithEvents butHelp As System.Windows.Forms.Button
    Friend WithEvents optNotes As System.Windows.Forms.RadioButton
    Friend WithEvents butCalc As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Notes1 As Notes
    Friend WithEvents Users1 As Users
    Friend WithEvents Income1 As Income
    Friend WithEvents About1 As About
    Friend WithEvents Graph1 As Graph
    Friend WithEvents Transactions1 As Transactions
    Friend WithEvents Expenses1 As Expenses
    Friend WithEvents EntryPanel1 As EntryPanel
    Friend WithEvents optSavings As System.Windows.Forms.RadioButton
    Friend WithEvents Savings1 As Savings
    Friend WithEvents tmrReminders As System.Windows.Forms.Timer
    Friend WithEvents chkReminders As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ctxTrayMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewExpenseToolstripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
