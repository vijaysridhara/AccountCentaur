Imports System.Data
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
Friend Class Expenses

    Private Sub Expenses_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus

    End Sub

    Public Sub RefreshContents()
        Dim ctxt As String
        Dim DS As New DataSet
        Try
            lsvExpenses.Items.Clear()
            ctxt = "SELECT EXPENSE,EXPFREQ FROM EXPENSES WHERE " & WHERECONDITON & " ORDER BY EXPENSE,EXPFREQ"
            Dim SQLda As New SQLiteDataAdapter(ctxt, sqlconn)
            SQLda.Fill(DS)
            Dim DATROWCOL As DataRowCollection = DS.Tables(0).Rows

            For Each DR As DataRow In DATROWCOL
                lsvExpenses.Items.Add(DR("EXPENSE"))
                lsvExpenses.Items(lsvExpenses.Items.Count - 1).SubItems.Add(DR("EXPFREQ"))


            Next
            SQLda = Nothing
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub
    Private Sub butAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAdd.Click
        Try

            If IsEmpty(txtExpense) Or IsEmpty(cboFrequency) Then Exit Sub
            SQCM.CommandText = "INSERT INTO EXPENSES(EXPENSE,EXPFREQ,USER) VALUES ('" & _
            txtExpense.Text.Trim & "','" & cboFrequency.Text & "','" & WHOLOGGEDIN & "')"
            SQCM.ExecuteNonQuery()
            lsvExpenses.Items.Add(txtExpense.Text)
            lsvExpenses.Items(lsvExpenses.Items.Count - 1).SubItems.Add(cboFrequency.Text)
            txtExpense.Clear()
            GetExpenses()
            txtExpense.Focus()
            RefreshContents()
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub butDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butDelete.Click
        Try
            If lsvExpenses.SelectedItems.Count = 0 Then Exit Sub
            If ConfDelete() = False Then Exit Sub

            Dim ex As String, fr As String
            ex = lsvExpenses.SelectedItems(0).Text
            fr = lsvExpenses.SelectedItems(0).SubItems(1).Text
            SQCM.CommandText = "DELETE FROM EXPENSES WHERE EXPENSE='" & ex & "' AND EXPFREQ='" & fr & "' AND  USER='" & WHOLOGGEDIN & "'"
            SQCM.ExecuteNonQuery()
            lsvExpenses.Items.Remove(lsvExpenses.SelectedItems(0))
            GetExpenses()
            RefreshContents()
            If lsvExpenses.Items.Count > 0 Then
                lsvExpenses.Items(lsvExpenses.Items.Count - 1).Selected = True
            End If
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub Expenses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lsvExpenses_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lsvExpenses.KeyDown
        Try
            If e.KeyCode <> Keys.Delete Then Exit Sub
            If lsvExpenses.SelectedItems.Count > 0 Then
                butDelete_Click(sender, e)
            End If
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub
End Class
