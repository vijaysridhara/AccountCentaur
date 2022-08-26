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
'***********************************************************************s
Friend Class Notes
    Friend DontShowCheck As Boolean
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub dgdNotes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim ct As Calendar
        ct = New Calendar
        If e.ColumnIndex <> 0 Then Exit Sub
        dgdNotes.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = Format(ct.ShowDateForm(dgdNotes.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value), "dd-MMM-yyyy")

    End Sub

    Friend Sub RefreshContents(Optional ByVal showOpen As Boolean = False)
        Try

            init = True
            If DontShowCheck Then
                chkShowOpennotesonly.Visible = False
            End If
            dgdNotes.Rows.Clear()
            Dim CMD As String
            If showOpen Then
                CMD = "SELECT ROWNUM,NOTES,NOTEDATE,ONORAFTER,STATUS FROM NOTES WHERE " & WHERECONDITON & " AND STATUS='O' ORDER BY ONORAFTER"
            Else
                CMD = "SELECT ROWNUM,NOTES,NOTEDATE,ONORAFTER,STATUS FROM NOTES WHERE " & WHERECONDITON & " ORDER BY ONORAFTER"
            End If
            SQCM.CommandText = CMD
            SQCM.Connection = sqlconn
            Dim SQRD As SQLiteDataReader
            SQRD = SQCM.ExecuteReader
            While SQRD.Read
                dgdNotes.Rows.Add()
                dgdNotes.Rows(dgdNotes.Rows.Count - 1).Cells(0).Value = Format(SQRD(2), "dd-MMM-yyyy")
                dgdNotes.Rows(dgdNotes.Rows.Count - 1).Cells(1).Value = SQRD(1)
                dgdNotes.Rows(dgdNotes.Rows.Count - 1).Cells(2).Value = Format(SQRD(3), "dd-MMM-yyyy")
                dgdNotes.Rows(dgdNotes.Rows.Count - 1).Cells(3).Value = SQRD(4)

                dgdNotes.Rows(dgdNotes.Rows.Count - 1).Tag = SQRD(0)
            End While
            SQRD.Close()
            SQRD.Dispose()
            init = False
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub


    Dim init As Boolean
    Private Sub dgdNotes_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgdNotes.SelectionChanged
        Try

            If init Then Exit Sub
            butUpdate.Enabled = False

            dtpYear.Value = dgdNotes.SelectedRows(0).Cells(0).Value
            twcNotes.Text = dgdNotes.SelectedRows(0).Cells(1).Value
            dtpOnorAfter.Value = dgdNotes.SelectedRows(0).Cells(2).Value
            twtStatus.Text = dgdNotes.SelectedRows(0).Cells(3).Value
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub butUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butUpdate.Click
        Try
            If dgdNotes.Rows.Count = 0 Then Exit Sub
            If dgdNotes.SelectedRows.Count = 0 Then Exit Sub
            Dim dt, tx As String
            dt = Format(dtpYear.Value, "yyyy-MM-dd")
            tx = Replace(twcNotes.Text, "'", "`")
            SQCM.CommandText = "UPDATE NOTES SET NOTEDATE='" & dt & "', NOTES='" & tx & "',ONORAFTER='" & Format(dtpOnorAfter.Value, "yyyy-MM-dd") & "',STATUS='" & twtStatus.Text & "' WHERE ROWNUM=" & dgdNotes.SelectedRows(0).Tag
            SQCM.ExecuteNonQuery()
            dgdNotes.SelectedRows(0).Cells(0).Value = Format(dtpYear.Value, "dd-MMM-yyyy")
            dgdNotes.SelectedRows(0).Cells(1).Value = tx
            If chkShowOpennotesonly.CheckState = CheckState.Checked Or DontShowCheck Then
                RefreshContents(True)
            Else
                RefreshContents(False)
            End If
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub dgdNotes_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdNotes.CellContentClick

    End Sub

    Private Sub dtpYear_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpYear.ValueChanged
        If init = False Then butUpdate.Enabled = True
    End Sub

    Private Sub twcNotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles twcNotes.Load
        With twtStatus.Items
            .Add("O")
            .Add("C")
            .Add("P")
        End With
        If DontShowCheck Then
            chkShowOpennotesonly.Visible = False

        End If
        twtStatus.SelectedIndex = 0

    End Sub

    Private Sub twcNotes_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles twcNotes.TextChanged
        If init = False Then butUpdate.Enabled = True
    End Sub

    Private Sub butDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butDelete.Click
        Try
            If dgdNotes.SelectedRows.Count = 0 Then Exit Sub
            Dim q As String
            q = "DELETE FROM NOTES WHERE ROWNUM=" & dgdNotes.SelectedRows(0).Tag
            SQCM.CommandText = q
            SQCM.ExecuteNonQuery()
            RefreshContents()
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub butAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAdd.Click
        Try
            Dim sq As String = "INSERT INTO NOTES(NOTEDATE,NOTES,STATUS,ONORAFTER,USER) VALUES('" & Format(dtpYear.Value, "yyyy-MM-dd") & "','" & Replace(twcNotes.Text, "'", "`") & "','" & twtStatus.Text & "','" & Format(dtpOnorAfter.Value, "yyyy-MM-dd") & "','" & WHOLOGGEDIN & "')"
            SQCM.CommandText = sq
            SQCM.Connection = sqlconn
            SQCM.ExecuteNonQuery()
            RefreshContents()
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub chkShowOpennotesonly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowOpennotesonly.CheckedChanged
        If chkShowOpennotesonly.CheckState = CheckState.Checked Then RefreshContents(True) Else RefreshContents()
    End Sub
End Class
