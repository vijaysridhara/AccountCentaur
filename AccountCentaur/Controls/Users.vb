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
Friend Class Users

    Private Sub Users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub RefreshContents()
        Try
            lstUsers.Items.Clear()

            lstUsers.Items.Add("admin")
             
            Dim Q As String, DR As SQLiteDataReader
            Q = "SELECT USER FROM USERS WHERE USER<>'admin' ORDER BY USER"
            SQCM.CommandText = Q
            DR = SQCM.ExecuteReader
            While DR.Read
                lstUsers.Items.Add(DR(0))
            End While
            DR.Close()
            DR.Dispose()

        Catch ex As Exception
            DE(ex)

        End Try
    End Sub

    Private Sub lstUsers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstUsers.SelectedIndexChanged
        Try
            If lstUsers.SelectedItem Is Nothing Then Exit Sub
            If lstUsers.SelectedItem.ToString = "admin" Then
                butDeleteUser.Enabled = False
            Else
                butDeleteUser.Enabled = True
            End If
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub butAdduser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAdduser.Click
        Try
         
            Dim un As String
            un = twtUSer.Text.Trim
            If un = "" Then Exit Sub
            Dim q As String, VJE As New VJEncryptor.Encryptor
            q = "INSERT INTO USERS VALUES('" & un & "','" & VJE.EncryptTripleDES(un & "123", un) & "','USER')"
            SQCM.CommandText = q
            SQCM.ExecuteNonQuery()
            lstUsers.Items.Add(un)
            VJE = Nothing
            twtUSer.Clear()
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub butDeleteUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butDeleteUser.Click
        Try
            Dim UN As String
            UN = lstUsers.SelectedItem.ToString
            If UN = "admin" Then
                MsgBox("Administrator cannot be deleted", MsgBoxStyle.Information)
                Exit Sub
            End If
            If ConfDelete() = False Then Exit Sub
            Dim q As String
            butDeleteUser.Enabled = False
            q = "DELETE FROM USERS WHERE USER='" & UN & "'"
            SQCM.CommandText = q
            SQCM.ExecuteNonQuery()
            lstUsers.Items.RemoveAt(lstUsers.SelectedIndex)
            If MsgBox("Do you want to delete the dependent items also?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            q = "DELETE FROM INCOME WHERE USER='" & UN & "'"
            SQCM.CommandText = q
            SQCM.ExecuteNonQuery()
            q = "DELETE FROM TRANSACTIONS WHERE USER='" & UN & "'"
            SQCM.CommandText = q
            SQCM.ExecuteNonQuery()
            q = "DELETE FROM EXPENSES WHERE USER='" & UN & "'"
            SQCM.CommandText = q
            SQCM.ExecuteNonQuery()
            q = "DELETE FROM INVESTMENTS WHERE USER='" & UN & "'"
            SQCM.CommandText = q
            SQCM.ExecuteNonQuery()
            q = "DELETE FROM NOTES WHERE USER='" & UN & "'"
            SQCM.CommandText = q
            SQCM.ExecuteNonQuery()


        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub butResetPW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butResetPW.Click
        Try
            Dim UN As String
            UN = lstUsers.SelectedItem.ToString
            Dim VJE As New VJEncryptor.Encryptor
            Dim Q As String
            Q = "UPDATE USERS SET PASSWORD='" & VJE.EncryptTripleDES(UN & "123", UN) & "' WHERE USER='" & UN & "'"
            SQCM.CommandText = Q
            SQCM.ExecuteNonQuery()
            MsgBox("Password reset successfully", MsgBoxStyle.Information)
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub butResetall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butResetall.Click
        Try
            If MsgBox("This will delete all items from the database, do you want to continue?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            Dim Q As String
            Q = "DELETE FROM TRANSACTIONS"
            SQCM.CommandText = Q
            SQCM.ExecuteNonQuery()
            Q = "DELETE FROM INCOME"
            SQCM.CommandText = Q
            SQCM.ExecuteNonQuery()
            Q = "DELETE FROM EXPENSES"
            SQCM.CommandText = Q
            SQCM.ExecuteNonQuery()
            Q = "DELETE FROM INVESTMENTS"
            SQCM.CommandText = Q
            SQCM.ExecuteNonQuery()
            Q = "DELETE FROM NOTES"
            SQCM.CommandText = Q
            SQCM.ExecuteNonQuery()

        Catch ex As Exception
            DE(ex)
        End Try
    End Sub



    Private Sub butCheckforUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCheckforUpdate.Click
        On Error Resume Next
        Process.Start("http://www.vitallogic.net/chkupt.php?pid=" & Application.ProductName & "&ver=" & Application.ProductVersion)
    End Sub

    Private Sub butChangeColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butChangeColor.Click
        On Error Resume Next
        Dim cdlg As New ColorDialog
        cdlg.Color = butChangeColor.BackColor
        If cdlg.ShowDialog = DialogResult.OK Then
            For Each ctl As Control In newMain.Controls
                If TypeOf ctl Is TextBox Or TypeOf ctl Is ListBox Or TypeOf ctl Is Label Or TypeOf ctl Is ListView Or TypeOf ctl Is DataGridView Or TypeOf ctl Is ZedGraph.ZedGraphControl Then
                    Continue For
                Else
                    ctl.BackColor = cdlg.Color
                    ctl.Refresh()
                    SetColor(ctl, cdlg.Color)
                End If
            Next
            My.Settings.Appearance = cdlg.Color
        End If
    End Sub

End Class
