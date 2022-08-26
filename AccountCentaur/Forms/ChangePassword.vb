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
Friend Class ChangePassword

    Private Sub butOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butOK.Click
        Try
            Dim Q As String, VJE As New VJEncryptor.Encryptor
            Dim pw, pwc As String
            pw = twtNewPassword.Text
            pwc = twtConfirmPassword.Text
            If pw = pwc Then
                Q = "UPDATE USERS SET PASSWORD='" & VJE.EncryptTripleDES(pw, WHOLOGGEDIN) & "' WHERE USER='" & WHOLOGGEDIN & "'"
                SQCM.CommandText = Q
                SQCM.ExecuteNonQuery()
                MsgBox("Password changed successfully", MsgBoxStyle.Information)
            Else
                MsgBox("Passwords do not match", MsgBoxStyle.Information)
                Exit Sub
            End If
            Me.Close()

        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub butCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCancel.Click
        Me.Close()
    End Sub

    Private Sub ChangePassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            butCancel_Click(sender, e)
        End If
    End Sub
End Class