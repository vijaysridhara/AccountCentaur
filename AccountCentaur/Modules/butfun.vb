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
Friend Module butfun

    Public ReportMode As Integer = 0
    Public GraphMode As Integer = 0
    Public GraphYear As Date = Date.Now
    Public Rempwd As Boolean
    Public Amount_Value As Double
    Public IsAdmin As Boolean ' I added two things here
    Public WHERECONDITON As String = ""
    'Public USERISADMIN As Boolean
    'Public WHOLOGGEDIN As String
    '

    '  Friend sqlconn As SQLiteConnection
    Public Yme As Date = CDate(Format(Date.Now, "yyyy-MM"))
    Public ExpCollection As New List(Of ExpenseRecord)
    ' The following sets the WHERE condition for SELECT queries if the user is admin or not
    Friend Sub SetWhereCondition()
        'if not admin 
        If Not IsAdmin Then
            WHERECONDITON = " USER='" & WHOLOGGEDIN & "' "
        Else
            WHERECONDITON = " 1 "
        End If
    End Sub


    Friend Sub DE(ByVal ex As Exception)
        MessageBox.Show(ex.Message)
    End Sub
    Friend Function IsEmpty(ByVal ob As Object) As Boolean
        If Trim(ob.TEXT) = "" Then Return True
        Return False
    End Function
    Friend Function ConfDelete() As Boolean
        If MessageBox.Show("Do you really want to delete", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Return True
        End If
        Return False
    End Function
    Friend Function IsNull(ByVal va As Object) As Object
        If va Is Nothing Then Return True
        If va Is DBNull.Value Then Return True
        If CType(va, String) = "" Then Return True
        Return False
    End Function
    Friend Function GetExpenses() As Boolean
        Try
            ExpCollection.Clear()
            SQCM.CommandText = "SELECT EXPENSE,EXPFREQ FROM EXPENSES WHERE USER='" & WHOLOGGEDIN & "' ORDER BY EXPENSE,EXPFREQ"
            Dim dr As SQLiteDataReader
            dr = SQCM.ExecuteReader

            While dr.Read

                Dim ex As New ExpenseRecord(dr(0).ToString, dr(1).ToString)
                ExpCollection.Add(ex)

            End While
            dr.Close()
            dr.Dispose()
        Catch ex As Exception
            DE(ex)
        End Try
    End Function





    Friend Sub SetColor(ByVal par As Control, ByVal clr As Color)
        For Each ctl As Control In par.Controls
            If TypeOf ctl Is TextBox Or TypeOf ctl Is ListBox Or TypeOf ctl Is Label Or TypeOf ctl Is ListView Or TypeOf ctl Is DataGridView Or TypeOf ctl Is ZedGraph.ZedGraphControl Then Continue For
            ctl.BackColor = clr
            ctl.Refresh()
            SetColor(ctl, clr)
        Next
    End Sub
   
End Module
