Imports System.Windows.Forms
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
Friend Class AddNote
    Friend ForModify As Boolean
    Friend RowNum As Integer
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            Dim sq As String
            If ForModify = False Then
                sq = "INSERT INTO NOTES(NOTEDATE,NOTES,STATUS,ONORAFTER,USER) VALUES('" & Format(dtpYear.Value, "yyyy-MM-dd") & "','" & Replace(twcNotes.Text, "'", "`") & "','" & twtStatus.Text & "','" & Format(dtpOnorAfter.Value, "yyyy-MM-dd") & "','" & WHOLOGGEDIN & "')"
            Else
                Dim dt, tx As String
                dt = Format(dtpYear.Value, "yyyy-MM-dd")
                tx = Replace(twcNotes.Text, "'", "`")
                sq = "UPDATE NOTES SET NOTEDATE='" & dt & "', NOTES='" & tx & "',ONORAFTER='" & Format(dtpOnorAfter.Value, "yyyy-MM-dd") & "',STATUS='" & twtStatus.Text & "' WHERE ROWNUM=" & RowNum
            End If
            SQCM.CommandText = sq
            SQCM.Connection = sqlconn
            SQCM.ExecuteNonQuery()
        Catch ex As Exception
            DE(ex)
        End Try
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub AddNote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            With twtStatus.Items
                .Add("O")
                .Add("C")
                .Add("P")
            End With
            twtStatus.SelectedIndex = 0
            If ForModify Then

                Me.Text = "Modify the reminder/note"
            End If
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub
End Class
