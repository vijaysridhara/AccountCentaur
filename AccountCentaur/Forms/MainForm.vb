
Imports System.Data.SQLite
'***********************************************************************
'Copyright 2005-2022 Vijay Sridhara

'Licensed under the Apache License, Version 2.0 (the "License");
'you may not use this file except in compliance with the License.
'You may obtain a copy of the License at

'http://www.apache.org/licenses/LICENSE-2.0

'Unless required by applicable law or agreed to in writing, software
'distributed under the License is distributed on an "AS IS" BASIS,
'WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
'See the License for the specific language governing permissions and
'limitations under the License.
'***********************************************************************
Friend Class MainForm
    Private WithEvents NI As New NotifyIcon
    Dim Reminders As Boolean
    Private Sub MainForm_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Try
            sqlconn.Close()
        Catch ex As Exception

        End Try

    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
            Exit Sub
        End If
        NI.Dispose()

        'If LType = VitalLogic.Licenses.T6.T7.F33 Then
        '    LManager.YHeliumCall()
        'End If

        LoginForm.Close()
        LoginForm.Dispose()
        tmrReminders.Stop()
        tmrReminders.Enabled = False
        SaveSetting(Application.ProductName, "Settings", "Reminders", chkReminders.Checked)

    End Sub

    Private Sub MainForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.F1 Then
                Process.Start(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\AccountCentaur.chm")
            ElseIf e.KeyCode = Keys.F2 Then
                Dim an As New AddNote
                an.ShowDialog()
            ElseIf e.KeyCode = Keys.F3 Then
                butCalc_Click(sender, e)
            ElseIf e.KeyCode = Keys.F4 Then
                Dim newcur As New CurrencyConverter
                newcur.Show()
            End If
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        If USERISADMIN Then butUsers.Enabled = True Else butUsers.Enabled = False

        GetExpenses()
        optEntry.Checked = True
        optSavings.Enabled = True
        optNotes.Enabled = True
        chkReminders.Checked = GetSetting(Application.ProductName, "Settings", "Reminders", True)
        NI.ContextMenuStrip = ctxTrayMenu
        NI.Icon = Me.Icon
        NI.Visible = True
    End Sub

    Private Sub Hsplitter_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Hsplitter.Resize
        On Error Resume Next
        If About1.Visible Then
            About1.Location = New Point(Hsplitter.Panel2.Width / 2 - About1.Width / 2, Hsplitter.Height / 2 - About1.Height / 2)
        End If
        Panel2.Location = New Point(10, Hsplitter.Height / 2 - Panel2.Height / 2)
        If Panel2.Top < PictureBox1.Top + PictureBox1.Height Then
            Panel2.Top = PictureBox1.Top + PictureBox1.Height
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butExit.Click
        If MsgBox("Do you really want to exit", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Try
            SQCM.CommandText = "VACUUM"
            SQCM.ExecuteNonQuery()
            NI.Dispose()
            Me.Close()
            Me.Dispose()
            LoginForm.Close()
            LoginForm.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub optEntry_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optEntry.CheckedChanged
        With EntryPanel1
            .Visible = True
            .Dock = DockStyle.Fill
            .RefreshContents()
        End With
        lblTitle.Text = "Enter transactions"
        Transactions1.Visible = False
        Expenses1.Visible = False
        Notes1.Visible = False
        About1.Visible = False
        Graph1.Visible = False
        Income1.Visible = False
        Users1.Visible = False
        Savings1.Visible = False

    End Sub

    Private Sub optExpenses_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optExpenses.CheckedChanged
        With Expenses1
            .Visible = True
            .Dock = DockStyle.Fill
            .RefreshContents()
        End With
        lblTitle.Text = "List of Expenses"
        Transactions1.Visible = False
        EntryPanel1.Visible = False
        Graph1.Visible = False
        About1.Visible = False
        Notes1.Visible = False
        Users1.Visible = False
        Income1.Visible = False
        Savings1.Visible = False

    End Sub

    Private Sub optIncome_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optIncome.CheckedChanged
        With Income1
            .Visible = True
            .Dock = DockStyle.Fill
            .RefreshContents()
        End With
        lblTitle.Text = "Income entries"
        Notes1.Visible = False
        Expenses1.Visible = False
        EntryPanel1.Visible = False
        Transactions1.Visible = False
        Graph1.Visible = False
        About1.Visible = False
        Users1.Visible = False
        Savings1.Visible = False

    End Sub

    Private Sub optReport_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optReport.CheckedChanged
        With Transactions1
            .Visible = True
            .Dock = DockStyle.Fill
            .RefreshContents()
            .ShowMod = True
        End With
        lblTitle.Text = "Expenses report"
        Notes1.Visible = False
        Users1.Visible = False
        Expenses1.Visible = False
        EntryPanel1.Visible = False
        About1.Visible = False
        Graph1.Visible = False
        Income1.Visible = False
        Savings1.Visible = False

    End Sub

    Private Sub optGraphs_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optGraphs.CheckedChanged
        With Graph1
            .Visible = True
            .Dock = DockStyle.Fill
        End With
        lblTitle.Text = "Graphical report"
        Notes1.Visible = False
        Expenses1.Visible = False
        EntryPanel1.Visible = False
        Transactions1.Visible = False
        About1.Visible = False
        Income1.Visible = False
        Users1.Visible = False
        Savings1.Visible = False
    End Sub

    Private Sub optAbout_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAbout.CheckedChanged
        With About1
            .Visible = True
        End With
        lblTitle.Text = "About AccountCentaur"
        Savings1.Visible = False
        Notes1.Visible = False
        Expenses1.Visible = False
        EntryPanel1.Visible = False
        Transactions1.Visible = False
        Graph1.Visible = False
        Income1.Visible = False
        Users1.Visible = False
        Hsplitter_Resize(sender, e)
    End Sub

    Private Sub butUsers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butUsers.CheckedChanged
        Try
            With Users1
                .Visible = True
                .Dock = DockStyle.Fill
                .RefreshContents()
            End With
            lblTitle.Text = "User Management"
            About1.Visible = False
            Notes1.Visible = False
            Expenses1.Visible = False
            EntryPanel1.Visible = False
            Transactions1.Visible = False
            Graph1.Visible = False
            Income1.Visible = False
            Savings1.Visible = False

        Catch ex As Exception
            DE(ex)
        End Try

    End Sub

    Private Sub butResetpw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butResetpw.Click
        ChangePassword.ShowDialog()
    End Sub

    Private Sub butHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butHelp.Click
        Try
            Process.Start(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\AccountCentaur.chm")

        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub optNotes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optNotes.CheckedChanged
        Try
            With Notes1
                .Visible = True
                .Dock = DockStyle.Fill
                .RefreshContents()
            End With
            lblTitle.Text = "Any Miscellaneous notes"
            About1.Visible = False
            Users1.Visible = False
            Expenses1.Visible = False
            EntryPanel1.Visible = False
            Transactions1.Visible = False
            Graph1.Visible = False
            Income1.Visible = False
            Savings1.Visible = False
        Catch ex As Exception
            DE(ex)
        End Try

    End Sub

    Private Sub butCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCalc.Click
        On Error Resume Next
        Process.Start("calc.exe")
    End Sub

    Private Sub optSavings_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optSavings.CheckedChanged
        Try
            With Savings1
                .Visible = True
                .Dock = DockStyle.Fill
                .RefreshContents()
            End With
            lblTitle.Text = "Savings and Investment details"
            About1.Visible = False
            Users1.Visible = False
            Expenses1.Visible = False
            EntryPanel1.Visible = False
            Transactions1.Visible = False
            Graph1.Visible = False
            Income1.Visible = False
            Notes1.Visible = False
        Catch ex As Exception
            DE(ex)
        End Try

    End Sub

    Private Sub tmrReminders_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrReminders.Tick
        CheckforOpenNotes()
    End Sub

    Private Sub CheckforOpenNotes()
        Try
            SQCM.CommandText = "Select 1 FROM NOTES WHERE STATUS='O' AND ONORAFTER<='" & Format(Date.Now, "yyyy-MM-dd") & "' AND " & WHERECONDITON
            SQCM.Connection = sqlconn
            Dim dr As SQLiteDataReader
            dr = SQCM.ExecuteReader
            '           OpenNoteCollection.Clear()
            Dim ThereAreOpenNotes As Boolean
            If dr.Read Then
                ThereAreOpenNotes = True
            End If

            '                OpenNoteCollection.Add(ont)
            dr.Close()
            dr.Dispose()
            tmrReminders.Stop()
            If ThereAreOpenNotes Then
                If MsgBox("There are some reminders for you, would you want to open?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Dim rmdrs As New Reminders
                    rmdrs.Notes1.DontShowCheck = True
                    rmdrs.Notes1.RefreshContents(True)
                    rmdrs.ShowDialog()
                End If
            End If
            tmrReminders.Start()

        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub chkReminders_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkReminders.CheckStateChanged
        If chkReminders.CheckState = CheckState.Checked Then
            tmrReminders.Enabled = True
            tmrReminders.Start()
        Else
            tmrReminders.Stop()
            tmrReminders.Enabled = False
        End If
    End Sub

    Private Sub NI_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NI.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub NewExpenseToolstripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewExpenseToolstripMenuItem.Click
        Dim sne As New SimpleNewEntry
        sne.Show()
    End Sub

    Private Sub ShowWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowWindowToolStripMenuItem.Click
        If Me.Visible Then
            Me.Hide()
            ShowWindowToolStripMenuItem.Text = "Hide window"
        Else
            Me.Show()
            ShowWindowToolStripMenuItem.Text = "Show window"
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        On Error Resume Next
        LoginForm.Close()
        Dim ex As New FormClosingEventArgs(CloseReason.ApplicationExitCall, False)
        MainForm_FormClosing(Me, ex)
        Me.Close()
        Me.Dispose()
        LoginForm.Dispose()
    End Sub

    Private Sub ctxTrayMenu_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ctxTrayMenu.Opening
        If Me.Visible Then
            ShowWindowToolStripMenuItem.Text = "Hide window"
        Else
            ShowWindowToolStripMenuItem.Text = "Show window"
        End If
    End Sub

    Private Sub MainForm_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

    End Sub

    Private Sub MainForm_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel

    End Sub
End Class
