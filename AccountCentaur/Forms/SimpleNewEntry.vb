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
Friend Class SimpleNewEntry

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            Dim exp As String, met As String, comm As String, expdate As Date, expentry As Date, amt As Decimal
            exp = Split(ComboBox1.Text, ":")(0).Trim
            met = ComboBox2.Text
            comm = ""
            expdate = Date.Now
            expentry = Date.Now
            amt = TextBox1.Text
            If exp = "" Or amt = 0 Or met = "" Then
                MsgBox("You did not specify the expense or the amount or the mode of payment", MsgBoxStyle.Information)
                lblImg.Image = ImageList1.Images(1)
                Exit Sub
            End If
            SQCM.CommandText = "INSERT INTO TRANSACTIONS (EXPENSE,EXPMETHOD,AMOUNT,EXPDATE,EXPENTRY,MISCELLANY,USER) VALUES('" & exp & "','" & _
            met & "'," & amt & ",'" & Format(expdate, "yyyy-MM-dd") & "','" & Format(expentry, "yyyy-MM-dd") & "','" & comm & "','" & WHOLOGGEDIN & "')"
            SQCM.ExecuteNonQuery()
            TextBox1.Clear()
            lblImg.Image = ImageList1.Images(0)
        Catch ex As Exception
            DE(ex)
            lblImg.Image = ImageList1.Images(1)
            Exit Sub
        End Try
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SimpleNewEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ComboBox1.Items.Clear()
        For i As Integer = 0 To ExpCollection.Count - 1
            ComboBox1.Items.Add(ExpCollection(i).Expense & " : " & ExpCollection(i).Frequency)
        Next
    End Sub
End Class
