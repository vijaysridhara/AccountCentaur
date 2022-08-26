
Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel
Imports System.Text
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
Friend Class EntryPanel

    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdEntry.CellContentClick
        Dim ct As Calendar
        ct = New Calendar
        If e.ColumnIndex <> 3 Then Exit Sub
        dgdEntry.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Format(ct.ShowDateForm(dgdEntry.Rows(e.RowIndex).Cells(e.ColumnIndex).Value), "dd-MMM-yyyy")
    End Sub

    Dim init As Boolean = True
    Public Sub RefreshContents()
        If init Then init = False : Exit Sub

        transView.RefreshContents(3)
       
    End Sub

    Private Sub butAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddRow.Click
        Try
            dgdEntry.Rows.Add()
            With dgdEntry.Rows(dgdEntry.Rows.Count - 1)
                '.Cells(0).Value = dgdEntry.Rows.Count
                For I As Integer = 0 To ExpCollection.Count - 1
                    CType(.Cells(0), DataGridViewComboBoxCell).Items.Add(ExpCollection(I).Expense & " : " & ExpCollection(I).Frequency)
                Next
                CType(.Cells(0), DataGridViewComboBoxCell).ReadOnly = False
                .Cells(3).Value = Format(Date.Now, "dd-MMM-yyyy")
                .Cells(4).Value = FormatCurrency(0.0, 2)
                dgdEntry.Focus()
            End With
        Catch ex As Exception
            DE(ex)
        End Try

    End Sub

    Private Sub DataGridView1_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        DE(e.Exception)
    End Sub

    Private Sub DataGridView1_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs)

    End Sub

    Private Sub butEnter_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub butMakeEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butMakeEntry.Click
        Try
            If dgdEntry.Rows.Count > 0 Then
                For i As Integer = 0 To dgdEntry.Rows.Count - 1
                    Dim exp As String, met As String, comm As String, expdate As Date, expentry As Date, amt As Decimal
                    exp = Split(dgdEntry.Rows(i).Cells(0).Value, ":")(0).Trim
                    met = dgdEntry.Rows(i).Cells(1).Value
                    comm = dgdEntry.Rows(i).Cells(2).Value
                    expdate = dgdEntry.Rows(i).Cells(3).Value
                    expentry = Date.Now
                    amt = dgdEntry.Rows(i).Cells(4).Value
                    If exp = "" Then
                        MsgBox("You did not specify the expense, I have made other entries", MsgBoxStyle.Information)
                        Continue For
                    End If
                    SQCM.CommandText = "INSERT INTO TRANSACTIONS (EXPENSE,EXPMETHOD,AMOUNT,EXPDATE,EXPENTRY,MISCELLANY,USER) VALUES('" & exp & "','" & _
                    met & "'," & amt & ",'" & Format(expdate, "yyyy-MM-dd") & "','" & Format(expentry, "yyyy-MM-dd") & "','" & comm & "','" & WHOLOGGEDIN & "')"
                    SQCM.ExecuteNonQuery()

                    transView.RefreshContents(3)
      
                Next
                dgdEntry.Rows.Clear()
            End If
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub


    Private Sub txtNewItem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNewItem.TextChanged
        If Trim(txtNewItem.Text) <> "" Then
            butEnter.Enabled = True
        Else
            butEnter.Enabled = False
        End If
    End Sub

    Private Sub butEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butEnter.Click
        Try
            dgdEntry.Rows.Add()
            With dgdEntry.Rows(dgdEntry.Rows.Count - 1)
                '.Cells(0).Value = dgdEntry.Rows.Count
                CType(.Cells(0), DataGridViewComboBoxCell).Items.Add(Trim(txtNewItem.Text) & " : ADHOC")
                CType(.Cells(0), DataGridViewComboBoxCell).Value = Trim(txtNewItem.Text) & " : ADHOC"
                CType(.Cells(0), DataGridViewComboBoxCell).ReadOnly = False
                .Cells(3).Value = Format(Date.Now, "dd-MMM-yyyy")
                .Cells(4).Value = FormatCurrency(0.0, 2)
                dgdEntry.Focus()
                
                If MsgBox("Do you wish to make it permanent?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    txtNewItem.Clear()
                    Exit Sub

                End If
                Try
                    SQCM.CommandText = "INSERT INTO EXPENSES(EXPENSE,EXPFREQ,USER) VALUES ('" & _
                    Trim(txtNewItem.Text) & "','ADHOC','" & WHOLOGGEDIN & "')"
                    SQCM.ExecuteNonQuery()
                    GetExpenses()
                    txtNewItem.Clear()
                Catch ex As Exception
                    DE(ex)
                End Try
            End With

        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub butClearRows_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClearRows.Click
        Try
            dgdEntry.Rows.Clear()
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Dim nentry As Boolean

    Private Sub dgdEntry_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdEntry.CellValueChanged
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex = 4 Then
            If nentry Then nentry = False : Exit Sub
            nentry = True
            Dim tx As String = dgdEntry.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            dgdEntry.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = FormatCurrency(tx, 2, TriState.True)
        End If
    End Sub

    Private Sub dgdEntry_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgdEntry.MouseDoubleClick

        If dgdEntry.Rows.Count = 0 Then Exit Sub
        If dgdEntry.CurrentCell.Selected = True Then
            If dgdEntry.CurrentCell.ColumnIndex = 4 Then
                Dim at As New MultiForm

                If IsNumeric(dgdEntry.CurrentCell.Value) = False Then dgdEntry.CurrentCell.Value = 0
                dgdEntry.CurrentCell.Value = at.ShowAmtForm(dgdEntry.CurrentCell.Value)
                System.Windows.Forms.SendKeys.Send("{ESC}")
            End If
        End If
    End Sub

    Dim CSTring(,) As String

    Private Sub dgdEntry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgdEntry.KeyDown
        If dgdEntry.SelectedRows.Count > 0 Then
            If e.Control = True Then
                If e.KeyCode = Keys.C Then
                    ReDim CSTring(0 To dgdEntry.ColumnCount - 1, 0 To dgdEntry.SelectedRows.Count - 1)
                    For i As Integer = 0 To dgdEntry.SelectedRows.Count - 1
                        For j As Integer = 0 To dgdEntry.ColumnCount - 1
                            CSTring(j, i) = dgdEntry.SelectedRows(i).Cells(j).Value
                        Next
                    Next
                ElseIf e.KeyCode = Keys.V Then
                    If CSTring Is Nothing Then Exit Sub
                    For i As Integer = 0 To CSTring.GetUpperBound(1)
                        dgdEntry.Rows.Insert(dgdEntry.CurrentRow.Index, 1) '
                        For j As Integer = 0 To dgdEntry.ColumnCount - 1
                            If j = 0 Then
                                For k As Integer = 0 To ExpCollection.Count - 1
                                    CType(dgdEntry.Rows(dgdEntry.CurrentRow.Index - 1).Cells(j), DataGridViewComboBoxCell).Items.Add(ExpCollection(k).Expense & " : " & ExpCollection(k).Frequency)
                                Next
                                CType(dgdEntry.Rows(dgdEntry.CurrentRow.Index - 1).Cells(j), DataGridViewComboBoxCell).Value = CSTring(j, i)
                                CType(dgdEntry.Rows(dgdEntry.CurrentRow.Index - 1).Cells(j), DataGridViewComboBoxCell).ReadOnly = False
                            ElseIf j = 1 Then
                                CType(dgdEntry.Rows(dgdEntry.CurrentRow.Index - 1).Cells(j), DataGridViewComboBoxCell).Value = CSTring(j, i)
                                CType(dgdEntry.Rows(dgdEntry.CurrentRow.Index - 1).Cells(j), DataGridViewComboBoxCell).ReadOnly = False
                            Else
                                dgdEntry.Rows(dgdEntry.CurrentRow.Index - 1).Cells(j).Value = CSTring(j, i)
                            End If
                        Next
                    Next
                End If
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            If dgdEntry.Rows.Count = 0 Then Exit Sub
            If dgdEntry.CurrentCell.ColumnIndex = 4 Then
                dgdEntry_MouseDoubleClick(sender, New MouseEventArgs(Windows.Forms.MouseButtons.Left, 2, 0, 0, 0))
            End If

        End If
    End Sub


End Class
