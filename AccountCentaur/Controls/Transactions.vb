Imports VitalLogic.Controls.YearMonth
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
Friend Class Transactions
    Dim enabler As Boolean
    Private GlbIND As Boolean
 
    Public Property ShowMod() As Boolean
        Get
            Return Panel1.Visible
        End Get
        Set(ByVal value As Boolean)
            Panel1.Visible = value
        End Set
    End Property
    Public Property UseGlobalIndex() As Boolean
        Get
            Return GlbIND
        End Get
        Set(ByVal value As Boolean)
            GlbIND = value
            If value Then
                twcGroupby.Visible = True
                ymMonth.Visible = False
                twcAmount.Visible = False
                twcComments.Visible = False
                twcExpense.Visible = False
                twcMethod.Visible = False
                butDeleteRecord.Visible = False
                butUpdateRecord.Visible = False
                dtpExpDate.Visible = False
                lblOn.Visible = False
                lblMonth.Visible = False
                lblFind.Visible = False
                txtFind.Visible = False
                grpQuery.Visible = False
            Else
                twcGroupby.Visible = False
            End If
        End Set
    End Property

    Private Sub lsvTransactions_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvTransactions.SelectedIndexChanged
        If lsvTransactions.SelectedItems.Count > 0 Then
            If enabler Then
                twcAmount.Enabled = True
                twcComments.Enabled = True
                twcExpense.Enabled = True
                twcMethod.Enabled = True
                butDeleteRecord.Enabled = True
                butUpdateRecord.Enabled = True
                dtpExpDate.Enabled = True
                lblOn.Enabled = True
                dtpExpDate.Value = lsvTransactions.SelectedItems(0).Text
                twcExpense.Text = lsvTransactions.SelectedItems(0).SubItems(1).Text
                twcMethod.Text = lsvTransactions.SelectedItems(0).SubItems(3).Text
                twcComments.Text = lsvTransactions.SelectedItems(0).SubItems(4).Text
                twcAmount.Text = lsvTransactions.SelectedItems(0).SubItems(5).Text


            Else
                twcAmount.Enabled = False
                twcComments.Enabled = False
                twcExpense.Enabled = False
                twcMethod.Enabled = False
                dtpExpDate.Enabled = False
                butDeleteRecord.Enabled = False
                butUpdateRecord.Enabled = False
                lblOn.Enabled = False
            End If
        End If
    End Sub
    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
    Public Sub RefreshContents(Optional ByVal ldcnt As Integer = 3)
        twcAmount.Clear()
        twcComments.Clear()
        twcExpense.Clear()
        twcMethod.Clear()
        With twcGroupby
            .Clear()

            .Items.Add("Month-Year")
            .Items.Add("Datewise")
            .Items.Add("Expense")

            .Items.Add("Entered today")
            .Items.Add("Updatable")
            If GlbIND = False Then
                twcGroupby.SelectedIndex = ldcnt
            Else
                twcGroupby.SelectedIndex = ReportMode
            End If
        End With
    End Sub
    Private Sub butFetch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub LoadItems(ByVal GROUP As Boolean, ByVal CONDITION As String)

    End Sub

    Private Sub twcGroupby_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles twcGroupby.Click

        twcAmount.Enabled = False
        twcComments.Enabled = False
        twcExpense.Enabled = False
        twcMethod.Enabled = False
        dtpExpDate.Enabled = False
        butDeleteRecord.Enabled = False
        butUpdateRecord.Enabled = False
        lblOn.Enabled = False
        lblMonth.Enabled = False
        ymMonth.Enabled = False



        lsvTransactions.Columns.Clear()
        lsvTransactions.Items.Clear()
        lsvTransactions.Groups.Clear()
        Dim Q As String, Dr As SQLiteDataReader
        Select Case twcGroupby.SelectedItem.ToString
            Case "Datewise"
                If IsAdmin Then
                    'Q = "SELECT A.EXPDATE,A.EXPENSE,B.EXPFREQ,A.EXPMETHOD,A.MISCELLANY,A.EXPENTRY,A.AMOUNT FROM TRANSACTIONS A LEFT OUTER JOIN EXPENSES B ON  A.EXPENSE=B.EXPENSE AND A.USER=B.USER  ORDER BY A.EXPDATE DESC,A.EXPENSE,B.EXPFREQ"
                    Q = "SELECT A.EXPDATE,A.EXPENSE,B.EXPFREQ,A.EXPMETHOD,A.MISCELLANY,A.EXPENTRY,A.AMOUNT FROM TRANSACTIONS A LEFT OUTER JOIN EXPENSES B ON  A.EXPENSE=B.EXPENSE AND A.USER=B.USER WHERE SUBSTR(A.EXPDATE,1,7) LIKE '" & Format(Yme, "yyyy-MM") & "' ORDER BY A.EXPDATE DESC,A.EXPENSE,B.EXPFREQ"
                Else
                    'Q = "SELECT A.EXPDATE,A.EXPENSE,B.EXPFREQ,A.EXPMETHOD,A.MISCELLANY,A.EXPENTRY,A.AMOUNT FROM TRANSACTIONS A LEFT OUTER JOIN EXPENSES B ON  A.EXPENSE=B.EXPENSE AND A.USER=B.USER WHERE A.USER='" & WHOLOGGEDIN & "' ORDER BY A.EXPDATE DESC,A.EXPENSE,B.EXPFREQ"
                    Q = "SELECT A.EXPDATE,A.EXPENSE,B.EXPFREQ,A.EXPMETHOD,A.MISCELLANY,A.EXPENTRY,A.AMOUNT FROM TRANSACTIONS A LEFT OUTER JOIN EXPENSES B ON  A.EXPENSE=B.EXPENSE AND A.USER=B.USER WHERE SUBSTR(A.EXPDATE,1,7) LIKE '" & Format(Yme, "yyyy-MM") & "' AND A.USER='" & WHOLOGGEDIN & "' ORDER BY A.EXPDATE DESC,A.EXPENSE,B.EXPFREQ"
                End If

                SQCM.CommandText = Q
                Dr = SQCM.ExecuteReader
                Dim prevda As Date
                With lsvTransactions.Columns
                    .Add("Expense", 100)
                    .Add("Frequency", 100)
                    .Add("Mode", 100)
                    .Add("Comments", 100)
                    .Add("Entered on", 100)
                    .Add("Amount", 100, HorizontalAlignment.Right)
                End With
                Dim lvi As ListViewItem, start As Boolean = True, total As Double
                Dim freq As String
                While Dr.Read
                    If prevda <> Dr(0) Then
                        If Not start Then
                            With lsvTransactions.Items
                                lvi = .Add("TOTAL")
                                lvi.Font = New Font(lvi.Font, FontStyle.Bold)
                                lvi.Group = lsvTransactions.Groups(Format(prevda, "dd-MMM-yyyy"))
                                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.AddRange(New String() {" ", " ", " ", " ", FormatCurrency(System.Math.Round(total, 2), 2)})
                                total = 0
                            End With
                        End If
                        lsvTransactions.Groups.Add(Format(Dr(0), "dd-MMM-yyyy"), Format(Dr(0), "dd-MMM-yyyy"))
                        prevda = Dr(0)
                        If start Then start = False
                    End If
                    With lsvTransactions.Items
                        lvi = .Add(Dr(1))
                        lvi.Group = lsvTransactions.Groups(Format(Dr(0), "dd-MMM-yyyy"))
                        If IsNull(Dr(2)) Then freq = "" Else freq = Dr(2)
                        lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(freq)
                        Dim x As String
                        If Dr(3) Is DBNull.Value Then
                            x = ""
                        Else
                            x = Dr(3)
                        End If
                        lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(x)
                        If Dr(4) Is DBNull.Value Then
                            x = ""
                        Else
                            x = Dr(4)
                        End If
                        lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(x)
                        lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(Format(Dr(5), "dd-MMM-yyyy"))
                        lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(FormatCurrency(Dr(6), 2))
                        total += CDbl(Dr(6))
                    End With
                End While
                If Not start Then
                    With lsvTransactions.Items
                        lvi = .Add("TOTAL")
                        lvi.Font = New Font(lvi.Font, FontStyle.Bold)
                        lvi.Group = lsvTransactions.Groups(Format(prevda, "dd-MMM-yyyy"))
                        lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.AddRange(New String() {" ", " ", " ", " ", FormatCurrency(System.Math.Round(total, 2), 2)})
                        total = 0
                    End With
                End If
                Dr.Close()
                Dr.Dispose()

            Case "Month-Year"
                ' Q = "SELECT A.EXPDATE,A.EXPENSE,B.EXPFREQ,A.EXPMETHOD,SUM(A.AMOUNT) FROM TRANSACTIONS A,EXPENSES B WHERE A.EXPENSE=B.EXPENSE  GROUP BY A.EXPDATE,A.EXPENSE,B.EXPFREQ,A.EXPMETHOD ORDER BY a.expdate,A.EXPENSE"
                If IsAdmin Then
                    Q = "SELECT SUBSTR(a.expdate,1,7) AS Y,A.EXPENSE,B.EXPFREQ,A.EXPMETHOD,SUM(A.AMOUNT) FROM TRANSACTIONS A LEFT OUTER JOIN EXPENSES B ON A.EXPENSE=B.EXPENSE AND A.USER=B.USER  GROUP BY Y,A.EXPENSE,B.EXPFREQ,A.EXPMETHOD ORDER BY Y DESC,A.EXPENSE"
                Else
                    Q = "SELECT SUBSTR(a.expdate,1,7) AS Y,A.EXPENSE,B.EXPFREQ,A.EXPMETHOD,SUM(A.AMOUNT) FROM TRANSACTIONS A LEFT OUTER JOIN EXPENSES B ON A.EXPENSE=B.EXPENSE AND A.USER=B.USER WHERE A.USER='" & WHOLOGGEDIN & "' GROUP BY Y,A.EXPENSE,B.EXPFREQ,A.EXPMETHOD ORDER BY Y DESC,A.EXPENSE"
                End If
                SQCM.CommandText = Q
                Dr = SQCM.ExecuteReader
                Dim prevda As String = "", curda As String
                With lsvTransactions.Columns
                    .Add("Expense", 100)
                    .Add("Frequency", 100)
                    .Add("Mode", 100)
                    .Add("Amount", 100, HorizontalAlignment.Right)
                End With
                Dim lvi As ListViewItem, start As Boolean = True, total As Double
                Dim freq As String
                While Dr.Read
                    curda = Dr(0) ' Format(Dr(0), "MMM") & "-" & Format(Dr(0), "yyyy")
                    If prevda <> curda Then
                        If Not start Then
                            With lsvTransactions.Items
                                lvi = .Add("TOTAL")
                                lvi.Font = New Font(lvi.Font, FontStyle.Bold)
                                lvi.Group = lsvTransactions.Groups(prevda)
                                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.AddRange(New String() {" ", " ", FormatCurrency(System.Math.Round(total, 2), 2)})
                                total = 0
                            End With
                        End If
                        lsvTransactions.Groups.Add(curda, curda)
                        prevda = curda
                        If start Then start = False
                    End If
                    With lsvTransactions.Items
                        lvi = .Add(Dr(1))
                        lvi.Group = lsvTransactions.Groups(curda)
                        If IsNull(Dr(2)) Then freq = "" Else freq = Dr(2)
                        lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(freq)
                        Dim x As String
                        If Dr(3) Is DBNull.Value Then
                            x = ""
                        Else
                            x = Dr(3)
                        End If
                        lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(x)
                        lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(FormatCurrency(Dr(4), 2))
                        total += CDbl(Dr(4))
                    End With
                End While
                If Not start Then
                    With lsvTransactions.Items
                        lvi = .Add("TOTAL")
                        lvi.Font = New Font(lvi.Font, FontStyle.Bold)
                        lvi.Group = lsvTransactions.Groups(prevda)
                        lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.AddRange(New String() {" ", " ", FormatCurrency(System.Math.Round(total, 2), 2)})
                        total = 0
                    End With
                End If
                Dr.Close()
                Dr.Dispose()
            Case "Expense"
                If IsAdmin Then
                    Q = "SELECT SUBSTR(a.expdate,1,4) AS Y,A.EXPENSE,B.EXPFREQ,SUM(A.AMOUNT) FROM TRANSACTIONS A LEFT OUTER JOIN EXPENSES B ON A.EXPENSE=B.EXPENSE AND  A.USER=B.USER  GROUP BY Y,A.EXPENSE,B.EXPFREQ ORDER BY Y desc,A.EXPENSE"
                Else
                    Q = "SELECT SUBSTR(a.expdate,1,4) AS Y,A.EXPENSE,B.EXPFREQ,SUM(A.AMOUNT) FROM TRANSACTIONS A LEFT OUTER JOIN EXPENSES B ON A.EXPENSE=B.EXPENSE AND  A.USER=B.USER WHERE A.USER='" & WHOLOGGEDIN & "' GROUP BY Y,A.EXPENSE,B.EXPFREQ ORDER BY Y desc,A.EXPENSE"

                End If
                SQCM.CommandText = Q
                Dr = SQCM.ExecuteReader
                Dim prevda As String = "", curda As String
                With lsvTransactions.Columns
                    .Add("Expense", 100)
                    .Add("Frequency", 100)
                    .Add("Amount", 100, HorizontalAlignment.Right)
                End With
                Dim freq As String
                Dim lvi As ListViewItem, start As Boolean = True, total As Double
                While Dr.Read
                    curda = Dr(0) ' Format(Dr(0), "MMM") & "-" & Format(Dr(0), "yyyy")
                    If prevda <> curda Then
                        If Not start Then
                            With lsvTransactions.Items
                                lvi = .Add("TOTAL")
                                lvi.Font = New Font(lvi.Font, FontStyle.Bold)
                                lvi.Group = lsvTransactions.Groups(prevda)
                                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.AddRange(New String() {" ", FormatCurrency(System.Math.Round(total, 2), 2)})
                                total = 0
                            End With
                        End If
                        lsvTransactions.Groups.Add(curda, curda)
                        prevda = curda
                        If start Then start = False
                    End If
                    With lsvTransactions.Items
                        lvi = .Add(Dr(1))
                        lvi.Group = lsvTransactions.Groups(curda)
                        If IsNull(Dr(2)) Then freq = "" Else freq = Dr(2)
                        lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(freq)
                        lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(FormatCurrency(Dr(3), 2))
                        total += CDbl(Dr(3))
                    End With
                End While
                If Not start Then
                    With lsvTransactions.Items
                        lvi = .Add("TOTAL")
                        lvi.Font = New Font(lvi.Font, FontStyle.Bold)
                        lvi.Group = lsvTransactions.Groups(prevda)
                        lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.AddRange(New String() {" ", FormatCurrency(System.Math.Round(total, 2), 2)})
                        total = 0
                    End With
                End If
                Dr.Close()
                Dr.Dispose()
            Case "Entered today"
                If IsAdmin Then
                    Q = "SELECT A.EXPDATE,A.EXPENSE,B.EXPFREQ,A.EXPMETHOD,A.MISCELLANY,A.EXPENTRY,A.AMOUNT FROM TRANSACTIONS A LEFT OUTER JOIN EXPENSES B ON  A.EXPENSE=B.EXPENSE  AND A.USER=B.USER WHERE A.EXPENTRY='" & Format(Date.Now, "yyyy-MM-dd") & "'  ORDER BY A.EXPDATE DESC,A.EXPENSE,B.EXPFREQ"
                Else
                    Q = "SELECT A.EXPDATE,A.EXPENSE,B.EXPFREQ,A.EXPMETHOD,A.MISCELLANY,A.EXPENTRY,A.AMOUNT FROM TRANSACTIONS A LEFT OUTER JOIN EXPENSES B ON  A.EXPENSE=B.EXPENSE  AND A.USER=B.USER WHERE A.EXPENTRY='" & Format(Date.Now, "yyyy-MM-dd") & "' AND A.USER='" & WHOLOGGEDIN & "' ORDER BY A.EXPDATE DESC,A.EXPENSE,B.EXPFREQ"

                End If
                SQCM.CommandText = Q
                Dr = SQCM.ExecuteReader
                With lsvTransactions.Columns
                    .Add("Expense", 100)
                    .Add("Frequency", 100)
                    .Add("Mode", 100)
                    .Add("Comments", 100)
                    .Add("Spent on", 100)
                    .Add("Amount", 100, HorizontalAlignment.Right)
                End With
                Dim lvi As ListViewItem, start As Boolean = True, total As Double
                lsvTransactions.Groups.Add(Format(Date.Now, "dd-MMM-yyyy"), "Entered on " & Format(Date.Now, "dd-MMM-yyyy"))
                Dim freq As String
                While Dr.Read
                    If start Then
                        start = False
                    End If

                    With lsvTransactions.Items
                        lvi = .Add(Dr(1))
                        lvi.Group = lsvTransactions.Groups(Format(Date.Now, "dd-MMM-yyyy"))
                        If IsNull(Dr(2)) Then freq = "" Else freq = Dr(2)
                        lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(freq)
                        Dim x As String
                        If Dr(3) Is DBNull.Value Then
                            x = ""
                        Else
                            x = Dr(3)
                        End If
                        lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(x)
                        If Dr(4) Is DBNull.Value Then
                            x = ""
                        Else
                            x = Dr(4)
                        End If
                        lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(x)
                        lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(Format(Dr(0), "dd-MMM-yyyy"))
                        lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(FormatCurrency(Dr(6), 2))
                        total += CDbl(Dr(6))
                    End With
                End While
                If Not start Then
                    With lsvTransactions.Items
                        lvi = .Add("TOTAL")
                        lvi.Font = New Font(lvi.Font, FontStyle.Bold)
                        lvi.Group = lsvTransactions.Groups(Format(Date.Now, "dd-MMM-yyyy"))
                        lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.AddRange(New String() {" ", " ", " ", " ", FormatCurrency(System.Math.Round(total, 2), 2)})
                        total = 0
                    End With
                End If
                Dr.Close()
                Dr.Dispose()

            Case "Updatable"
                If IsAdmin Then
                    'Q = "SELECT A.EXPDATE,A.EXPENSE,B.EXPFREQ,A.EXPMETHOD,A.MISCELLANY,A.AMOUNT,A.ROWNUM FROM TRANSACTIONS A LEFT OUTER JOIN EXPENSES B ON A.EXPENSE=B.EXPENSE AND A.USER=B.USER ORDER BY A.EXPDATE DESC,A.EXPENSE,B.EXPFREQ"
                    Q = "SELECT A.EXPDATE,A.EXPENSE,B.EXPFREQ,A.EXPMETHOD,A.MISCELLANY,A.AMOUNT,A.ROWNUM FROM TRANSACTIONS A LEFT OUTER JOIN EXPENSES B ON A.EXPENSE=B.EXPENSE AND A.USER=B.USER WHERE SUBSTR(A.EXPDATE,1,7) LIKE '" & Format(Yme, "yyyy-MM") & "' ORDER BY A.EXPDATE DESC,A.EXPENSE,B.EXPFREQ"
                Else
                    'Q = "SELECT A.EXPDATE,A.EXPENSE,B.EXPFREQ,A.EXPMETHOD,A.MISCELLANY,A.AMOUNT,A.ROWNUM FROM TRANSACTIONS A LEFT OUTER JOIN EXPENSES B ON A.EXPENSE=B.EXPENSE AND A.USER=B.USER WHERE A.USER='" & WHOLOGGEDIN & "' ORDER BY A.EXPDATE DESC,A.EXPENSE,B.EXPFREQ"
                    Q = "SELECT A.EXPDATE,A.EXPENSE,B.EXPFREQ,A.EXPMETHOD,A.MISCELLANY,A.AMOUNT,A.ROWNUM FROM TRANSACTIONS A LEFT OUTER JOIN EXPENSES B ON A.EXPENSE=B.EXPENSE AND A.USER=B.USER WHERE SUBSTR(A.EXPDATE,1,7) LIKE '" & Format(Yme, "yyyy-MM") & "' AND  A.USER='" & WHOLOGGEDIN & "' ORDER BY A.EXPDATE DESC,A.EXPENSE,B.EXPFREQ"
                End If
                SQCM.CommandText = Q
                Dr = SQCM.ExecuteReader
                With lsvTransactions.Columns
                    .Add("Date", 100)
                    .Add("Expense", 100)
                    .Add("Frequency", 100)
                    .Add("Mode", 100)
                    .Add("Comments", 100)
                    .Add("Amount", 100, HorizontalAlignment.Right)
                End With
                Dim lvi As ListViewItem
                Dim freq As String
                While Dr.Read
                    With lsvTransactions.Items
                        lvi = .Add(Format(Dr(0), "dd-MMM-yyyy"))
                        lvi.Tag = Dr(6)
                        If IsNull(Dr(2)) Then freq = "" Else freq = Dr(2)
                        lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(Dr(1))
                        lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(freq)
                        Dim x As String
                        If Dr(3) Is DBNull.Value Then
                            x = ""
                        Else
                            x = Dr(3)
                        End If
                        lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(x)
                        If Dr(4) Is DBNull.Value Then
                            x = ""
                        Else
                            x = Dr(4)
                        End If
                        lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(x)
                        If Dr(5) Is DBNull.Value Then
                            x = ""
                        Else
                            x = Dr(5)
                        End If
                        lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(x)
                    End With
                End While
                Dr.Close()
                Dr.Dispose()

        End Select
        If twcGroupby.SelectedItem.ToString = "Updatable" Then
            enabler = True
        Else
            enabler = False
        End If

        If twcGroupby.SelectedIndex = 1 Or twcGroupby.SelectedIndex = 4 Then
            lblMonth.Enabled = True
            ymMonth.Enabled = True
        Else
            lblMonth.Enabled = False
            ymMonth.Enabled = False
        End If

        If UseGlobalIndex And rbSearch.Checked = False Then
            ReportMode = twcGroupby.SelectedIndex
        Else
            If UseGlobalIndex And rbSearch.Checked = True Then
                lsvTransactions.Items.Clear()
            End If
        End If

    End Sub

    Private Sub twcGroupby_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles twcGroupby.Load

    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub butUpdateRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butUpdateRecord.Click
        Try
            Dim dt As Date, exp As String, com As String = "", Q As String
            dt = lsvTransactions.SelectedItems(0).Text
            dt = Format(dt, "yyyy-MM-dd")
            exp = lsvTransactions.SelectedItems(0).SubItems(1).Text
            ' com = lsvTransactions.SelectedItems(0).SubItems(4).Text
            Q = "UPDATE TRANSACTIONS SET EXPENSE='" & twcExpense.Text & "'," & _
             "EXPDATE='" & Format(dtpExpDate.Value, "yyyy-MM-dd") & "'," & _
             "EXPMETHOD='" & twcMethod.Text & "',MISCELLANY='" & twcComments.Text & "'," & _
             "AMOUNT=" & twcAmount.Text & " WHERE ROWNUM=" & lsvTransactions.SelectedItems(0).Tag
            SQCM.CommandText = Q
            SQCM.ExecuteNonQuery()
            lsvTransactions.SelectedItems(0).Text = Format(dtpExpDate.Value, "dd-MMM-yyyy")
            lsvTransactions.SelectedItems(0).SubItems(1).Text = twcExpense.Text.Trim
            lsvTransactions.SelectedItems(0).SubItems(3).Text = twcMethod.Text.Trim
            lsvTransactions.SelectedItems(0).SubItems(4).Text = twcComments.Text.Trim
            lsvTransactions.SelectedItems(0).SubItems(5).Text = twcAmount.Text
        Catch ex As Exception

            DE(ex)
        End Try
    End Sub

    Private Sub butDeleteRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butDeleteRecord.Click
        Try
            Dim dt As Date, dt1 As String, exp As String, com As String = "", Q As String
            dt = lsvTransactions.SelectedItems(0).Text
            dt1 = Format(dt, "yyyy-MM-dd")
            exp = lsvTransactions.SelectedItems(0).SubItems(1).Text
            ' com = lsvTransactions.SelectedItems(0).SubItems(4).Text
            Q = "DELETE FROM TRANSACTIONS WHERE ROWNUM=" & lsvTransactions.SelectedItems(0).Tag
            SQCM.CommandText = Q
            SQCM.ExecuteNonQuery()
            lsvTransactions.SelectedItems(0).Remove()
            twcAmount.Clear()
            twcComments.Clear()
            twcExpense.Clear()
            twcMethod.Clear()
        Catch ex As Exception

            DE(ex)
        End Try
    End Sub


    Private Sub twcMethod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles twcMethod.Load

    End Sub

    Private Sub FetchDetails()
        lsvTransactions.Columns.Clear()
        lsvTransactions.Groups.Clear()
        Dim Q As String, Dr As SQLiteDataReader
        If IsAdmin Then
            Q = "SELECT A.EXPENSE,A.EXPDATE,A.EXPENTRY,A.AMOUNT,B.EXPFREQ,A.EXPMETHOD,A.MISCELLANY FROM TRANSACTIONS A LEFT OUTER JOIN EXPENSES B ON  A.EXPENSE=B.EXPENSE  AND A.USER=B.USER WHERE A.EXPENSE LIKE '" & txtFind.Text & "%'  ORDER BY A.EXPDATE DESC,A.EXPENSE,B.EXPFREQ"
        Else
            Q = "SELECT A.EXPENSE,A.EXPDATE,A.EXPENTRY,A.AMOUNT,B.EXPFREQ,A.EXPMETHOD,A.MISCELLANY FROM TRANSACTIONS A LEFT OUTER JOIN EXPENSES B ON  A.EXPENSE=B.EXPENSE  AND A.USER=B.USER WHERE A.EXPENSE LIKE '" & txtFind.Text & "%'  AND A.USER='" & WHOLOGGEDIN & "' ORDER BY A.EXPDATE DESC,A.EXPENSE,B.EXPFREQ"

        End If
        SQCM.CommandText = Q
        Dr = SQCM.ExecuteReader
        With lsvTransactions.Columns
            .Add("Expense", 100)
            .Add("Spent on", 100)
            .Add("Entered on", 100)
            .Add("Amount", 100)
            .Add("Mode", 100)
            .Add("Frequency", 100)
            .Add("Comments", 100, HorizontalAlignment.Left)
        End With
        Dim lvi As ListViewItem, start As Boolean = True, total As Double
        Dim freq As String
        While Dr.Read
            If start Then
                start = False
            End If

            With lsvTransactions.Items
                '                lvi = .Add(Dr(1))
                If IsNull(Dr(5)) Then freq = "" Else freq = Dr(5)

                lsvTransactions.Items.Add(Dr(0))
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(Format(Dr(1), "dd-MMM-yyyy"))
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(Format(Dr(2), "dd-MMM-yyyy"))
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(FormatCurrency(Dr(3), 2))
                Dim x As String
                If Dr(4) Is DBNull.Value Then
                    x = ""
                Else
                    x = Dr(4)
                End If
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(x)
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(freq)
                If Dr(6) Is DBNull.Value Then
                    x = ""
                Else
                    x = Dr(6)
                End If
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(x)
                total += CDbl(Dr(3))
            End With
        End While
        If Not start Then
            With lsvTransactions.Items
                lvi = .Add("TOTAL")
                lvi.Font = New Font(lvi.Font, FontStyle.Bold)
                'lvi.Group = lsvTransactions.Groups(Format(Date.Now, "dd-MMM-yyyy"))
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.AddRange(New String() {" ", " ", FormatCurrency(System.Math.Round(total, 2), 2)})
                total = 0
            End With
        End If
        Dr.Close()
        Dr.Dispose()
    End Sub

    Private Sub Fetchdetails_date()
        lsvTransactions.Items.Clear()
        Dim Q As String, Dr As SQLiteDataReader
        If IsAdmin Then
            Q = "SELECT A.EXPDATE,A.EXPENSE,B.EXPFREQ,A.EXPMETHOD,A.MISCELLANY,A.EXPENTRY,A.AMOUNT FROM TRANSACTIONS A LEFT OUTER JOIN EXPENSES B ON  A.EXPENSE=B.EXPENSE AND A.USER=B.USER WHERE SUBSTR(A.EXPDATE,1,7) LIKE '" & Format(Yme, "yyyy-MM") & "' ORDER BY A.EXPDATE DESC,A.EXPENSE,B.EXPFREQ"
        Else
            Q = "SELECT A.EXPDATE,A.EXPENSE,B.EXPFREQ,A.EXPMETHOD,A.MISCELLANY,A.EXPENTRY,A.AMOUNT FROM TRANSACTIONS A LEFT OUTER JOIN EXPENSES B ON  A.EXPENSE=B.EXPENSE AND A.USER=B.USER WHERE SUBSTR(A.EXPDATE,1,7) LIKE '" & Format(Yme, "yyyy-MM") & "' AND A.USER='" & WHOLOGGEDIN & "' ORDER BY A.EXPDATE DESC,A.EXPENSE,B.EXPFREQ"
        End If

        SQCM.CommandText = Q
        Dr = SQCM.ExecuteReader
        Dim prevda As Date
        With lsvTransactions.Columns
            .Add("Expense", 100)
            .Add("Frequency", 100)
            .Add("Mode", 100)
            .Add("Comments", 100)
            .Add("Entered on", 100)
            .Add("Amount", 100, HorizontalAlignment.Right)
        End With
        Dim lvi As ListViewItem, start As Boolean = True, total As Double
        Dim freq As String
        While Dr.Read
            If prevda <> Dr(0) Then
                If Not start Then
                    With lsvTransactions.Items
                        lvi = .Add("TOTAL")
                        lvi.Font = New Font(lvi.Font, FontStyle.Bold)
                        lvi.Group = lsvTransactions.Groups(Format(prevda, "dd-MMM-yyyy"))
                        lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.AddRange(New String() {" ", " ", " ", " ", FormatCurrency(System.Math.Round(total, 2), 2)})
                        total = 0
                    End With
                End If
                lsvTransactions.Groups.Add(Format(Dr(0), "dd-MMM-yyyy"), Format(Dr(0), "dd-MMM-yyyy"))
                prevda = Dr(0)
                If start Then start = False
            End If
            With lsvTransactions.Items
                lvi = .Add(Dr(1))
                lvi.Group = lsvTransactions.Groups(Format(Dr(0), "dd-MMM-yyyy"))
                If IsNull(Dr(2)) Then freq = "" Else freq = Dr(2)
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(freq)
                Dim x As String
                If Dr(3) Is DBNull.Value Then
                    x = ""
                Else
                    x = Dr(3)
                End If
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(x)
                If Dr(4) Is DBNull.Value Then
                    x = ""
                Else
                    x = Dr(4)
                End If
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(x)
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(Format(Dr(5), "dd-MMM-yyyy"))
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(FormatCurrency(Dr(6), 2))
                total += CDbl(Dr(6))
            End With
        End While
        If Not start Then
            With lsvTransactions.Items
                lvi = .Add("TOTAL")
                lvi.Font = New Font(lvi.Font, FontStyle.Bold)
                lvi.Group = lsvTransactions.Groups(Format(prevda, "dd-MMM-yyyy"))
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.AddRange(New String() {" ", " ", " ", " ", FormatCurrency(System.Math.Round(total, 2), 2)})
                total = 0
            End With
        End If
        Dr.Close()
        Dr.Dispose()
    End Sub
    Private Sub Fetchdetails_upd()
        lsvTransactions.Items.Clear()
        Dim Q As String, Dr As SQLiteDataReader
        If IsAdmin Then
            Q = "SELECT A.EXPDATE,A.EXPENSE,B.EXPFREQ,A.EXPMETHOD,A.MISCELLANY,A.AMOUNT,A.ROWNUM FROM TRANSACTIONS A LEFT OUTER JOIN EXPENSES B ON A.EXPENSE=B.EXPENSE AND A.USER=B.USER WHERE SUBSTR(A.EXPDATE,1,7) LIKE '" & Format(Yme, "yyyy-MM") & "' ORDER BY A.EXPDATE DESC,A.EXPENSE,B.EXPFREQ"
        Else
            Q = "SELECT A.EXPDATE,A.EXPENSE,B.EXPFREQ,A.EXPMETHOD,A.MISCELLANY,A.AMOUNT,A.ROWNUM FROM TRANSACTIONS A LEFT OUTER JOIN EXPENSES B ON A.EXPENSE=B.EXPENSE AND A.USER=B.USER WHERE SUBSTR(A.EXPDATE,1,7) LIKE '" & Format(Yme, "yyyy-MM") & "' AND  A.USER='" & WHOLOGGEDIN & "' ORDER BY A.EXPDATE DESC,A.EXPENSE,B.EXPFREQ"
        End If
        SQCM.CommandText = Q
        Dr = SQCM.ExecuteReader
        With lsvTransactions.Columns
            .Add("Date", 100)
            .Add("Expense", 100)
            .Add("Frequency", 100)
            .Add("Mode", 100)
            .Add("Comments", 100)
            .Add("Amount", 100, HorizontalAlignment.Right)
        End With
        Dim lvi As ListViewItem
        Dim freq As String
        While Dr.Read
            With lsvTransactions.Items
                lvi = .Add(Format(Dr(0), "dd-MMM-yyyy"))
                lvi.Tag = Dr(6)
                If IsNull(Dr(2)) Then freq = "" Else freq = Dr(2)
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(Dr(1))
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(freq)
                Dim x As String
                If Dr(3) Is DBNull.Value Then
                    x = ""
                Else
                    x = Dr(3)
                End If
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(x)
                If Dr(4) Is DBNull.Value Then
                    x = ""
                Else
                    x = Dr(4)
                End If
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(x)
                If Dr(5) Is DBNull.Value Then
                    x = ""
                Else
                    x = Dr(5)
                End If
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(x)
            End With
        End While
        Dr.Close()
        Dr.Dispose()
    End Sub

    'Private Sub Fetchdetails_none()
    '    lsvTransactions.Items.Clear()
    '    Dim Q As String, Dr As Finisar.SQLite.SQLiteDataReader
    '    If IsAdmin Then
    '        Q = "SELECT SUBSTR(a.expdate,1,7) AS Y,A.EXPENSE,B.EXPFREQ,A.EXPMETHOD,SUM(A.AMOUNT) FROM TRANSACTIONS A LEFT OUTER JOIN EXPENSES B ON A.EXPENSE=B.EXPENSE AND A.USER=B.USER  GROUP BY Y,A.EXPENSE,B.EXPFREQ,A.EXPMETHOD ORDER BY Y DESC,A.EXPENSE"
    '    Else
    '        Q = "SELECT SUBSTR(a.expdate,1,7) AS Y,A.EXPENSE,B.EXPFREQ,A.EXPMETHOD,SUM(A.AMOUNT) FROM TRANSACTIONS A LEFT OUTER JOIN EXPENSES B ON A.EXPENSE=B.EXPENSE AND A.USER=B.USER WHERE A.USER='" & WHOLOGGEDIN & "' GROUP BY Y,A.EXPENSE,B.EXPFREQ,A.EXPMETHOD ORDER BY Y DESC,A.EXPENSE"
    '    End If
    '    SQCM.CommandText = Q
    '    Dr = SQCM.ExecuteReader
    '    Dim prevda As String = "", curda As String
    '    With lsvTransactions.Columns
    '        .Add("Expense", 100)
    '        .Add("Frequency", 100)
    '        .Add("Mode", 100)
    '        .Add("Amount", 100, HorizontalAlignment.Right)
    '    End With
    '    Dim lvi As ListViewItem, start As Boolean = True, total As Double
    '    Dim freq As String
    '    While Dr.Read
    '        curda = Dr(0)
    '        If prevda <> curda Then
    '            If Not start Then
    '                With lsvTransactions.Items
    '                    lvi = .Add("TOTAL")
    '                    lvi.Font = New Font(lvi.Font, FontStyle.Bold)
    '                    lvi.Group = lsvTransactions.Groups(prevda)
    '                    lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.AddRange(New String() {" ", " ", FormatCurrency(System.Math.Round(total, 2), 2)})
    '                    total = 0
    '                End With
    '            End If
    '            lsvTransactions.Groups.Add(curda, curda)
    '            prevda = curda
    '            If start Then start = False
    '        End If
    '        With lsvTransactions.Items
    '            lvi = .Add(Dr(1))
    '            lvi.Group = lsvTransactions.Groups(curda)
    '            If IsNull(Dr(2)) Then freq = "" Else freq = Dr(2)
    '            lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(freq)
    '            lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(Dr(3))
    '            lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(FormatCurrency(Dr(4), 2))
    '            total += CDbl(Dr(4))
    '        End With
    '    End While
    '    If Not start Then
    '        With lsvTransactions.Items
    '            lvi = .Add("TOTAL")
    '            lvi.Font = New Font(lvi.Font, FontStyle.Bold)
    '            lvi.Group = lsvTransactions.Groups(prevda)
    '            lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.AddRange(New String() {" ", " ", FormatCurrency(System.Math.Round(total, 2), 2)})
    '            total = 0
    '        End With
    '    End If
    '    Dr.Close()
    '    Dr.Dispose()

    'End Sub



    Private Sub txtFind_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFind.TextChanged
        If txtFind.Text <> "" Then
            If rbStarts.Checked = True Then
                lsvTransactions.Clear()
                FetchDetails()
            End If
            If rbLike.Checked = True Then
                lsvTransactions.Clear()
                FetchDetails_like()
            End If
            If rbEnds.Checked = True Then
                lsvTransactions.Clear()
                FetchDetails_ends()
            End If
        End If
        If txtFind.Text = "" Then
            lsvTransactions.Clear()
            'Fetchdetails_none()
        End If
    End Sub


    Private Sub ymMonth_ValueChanged() Handles ymMonth.ValueChanged
        Yme = "15-" & ymMonth.YearMonthValue
        If twcGroupby.SelectedIndex = 1 Then
            Fetchdetails_date()
            Exit Sub
        End If
        If twcGroupby.SelectedIndex = 4 Then
            Fetchdetails_upd()
            Exit Sub
        End If
    End Sub

    Private Sub rbSearch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSearch.CheckedChanged
        If rbSearch.Checked = True Then
            rbStarts.Checked = True
            lsvTransactions.Items.Clear()
            lsvTransactions.Columns.Clear()
            lblFind.Visible = True
            txtFind.Visible = True
            ymMonth.Visible = False
            twcAmount.Visible = False
            twcComments.Visible = False
            twcExpense.Visible = False
            twcMethod.Visible = False
            butDeleteRecord.Visible = False
            butUpdateRecord.Visible = False
            dtpExpDate.Visible = False
            lblOn.Visible = False
            lblMonth.Visible = False
            twcGroupby.Enabled = False
            grpQuery.Visible = True
        End If
    End Sub

    Private Sub rbDetails_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDetails.CheckedChanged
        If rbDetails.Checked = True Then
            lsvTransactions.Items.Clear()
            lsvTransactions.Columns.Clear()
            twcGroupby.SelectedIndex = 1
            Fetchdetails_date()
            twcGroupby.Enabled = True
            ymMonth.Visible = True
            twcAmount.Visible = True
            twcComments.Visible = True
            twcExpense.Visible = True
            twcMethod.Visible = True
            butDeleteRecord.Visible = True
            butUpdateRecord.Visible = True
            dtpExpDate.Visible = True
            lblOn.Visible = True
            lblMonth.Visible = True
            lblFind.Visible = False
            txtFind.Visible = False
            grpQuery.Visible = False
        End If
    End Sub

    Private Sub FetchDetails_like()
        lsvTransactions.Columns.Clear()
        lsvTransactions.Groups.Clear()
        Dim Q As String, Dr As SQLiteDataReader
        If IsAdmin Then
            Q = "SELECT A.EXPENSE,A.EXPDATE,A.EXPENTRY,A.AMOUNT,B.EXPFREQ,A.EXPMETHOD,A.MISCELLANY FROM TRANSACTIONS A LEFT OUTER JOIN EXPENSES B ON  A.EXPENSE=B.EXPENSE  AND A.USER=B.USER WHERE A.EXPENSE LIKE '%" & txtFind.Text & "%'  ORDER BY A.EXPDATE DESC,A.EXPENSE,B.EXPFREQ"
        Else
            Q = "SELECT A.EXPENSE,A.EXPDATE,A.EXPENTRY,A.AMOUNT,B.EXPFREQ,A.EXPMETHOD,A.MISCELLANY FROM TRANSACTIONS A LEFT OUTER JOIN EXPENSES B ON  A.EXPENSE=B.EXPENSE  AND A.USER=B.USER WHERE A.EXPENSE LIKE '%" & txtFind.Text & "%'  AND A.USER='" & WHOLOGGEDIN & "' ORDER BY A.EXPDATE DESC,A.EXPENSE,B.EXPFREQ"

        End If
        SQCM.CommandText = Q
        Dr = SQCM.ExecuteReader
        With lsvTransactions.Columns
            .Add("Expense", 100)
            .Add("Spent on", 100)
            .Add("Entered on", 100)
            .Add("Amount", 100)
            .Add("Mode", 100)
            .Add("Frequency", 100)
            .Add("Comments", 100, HorizontalAlignment.Left)
        End With
        Dim lvi As ListViewItem, start As Boolean = True, total As Double
        Dim freq As String
        While Dr.Read
            If start Then
                start = False
            End If

            With lsvTransactions.Items
                '                lvi = .Add(Dr(1))
                If IsNull(Dr(5)) Then freq = "" Else freq = Dr(5)
                lsvTransactions.Items.Add(Dr(0))
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(Format(Dr(1), "dd-MMM-yyyy"))
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(Format(Dr(2), "dd-MMM-yyyy"))
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(FormatCurrency(Dr(3), 2))
                Dim x As String
                If Dr(4) Is DBNull.Value Then
                    x = ""
                Else
                    x = Dr(4)
                End If
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(x)
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(freq)
                If Dr(6) Is DBNull.Value Then
                    x = ""
                Else
                    x = Dr(6)
                End If
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(x)
                total += CDbl(Dr(3))
            End With
        End While
        If Not start Then
            With lsvTransactions.Items
                lvi = .Add("TOTAL")
                lvi.Font = New Font(lvi.Font, FontStyle.Bold)
                'lvi.Group = lsvTransactions.Groups(Format(Date.Now, "dd-MMM-yyyy"))
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.AddRange(New String() {" ", " ", FormatCurrency(System.Math.Round(total, 2), 2)})
                total = 0
            End With
        End If
        Dr.Close()
        Dr.Dispose()
    End Sub

    Private Sub FetchDetails_ends()
        lsvTransactions.Columns.Clear()
        lsvTransactions.Groups.Clear()
        Dim Q As String, Dr As SQLiteDataReader
        If IsAdmin Then
            Q = "SELECT A.EXPENSE,A.EXPDATE,A.EXPENTRY,A.AMOUNT,B.EXPFREQ,A.EXPMETHOD,A.MISCELLANY FROM TRANSACTIONS A LEFT OUTER JOIN EXPENSES B ON  A.EXPENSE=B.EXPENSE  AND A.USER=B.USER WHERE A.EXPENSE LIKE '%_" & txtFind.Text & "'  ORDER BY A.EXPDATE DESC,A.EXPENSE,B.EXPFREQ"
        Else
            Q = "SELECT A.EXPENSE,A.EXPDATE,A.EXPENTRY,A.AMOUNT,B.EXPFREQ,A.EXPMETHOD,A.MISCELLANY FROM TRANSACTIONS A LEFT OUTER JOIN EXPENSES B ON  A.EXPENSE=B.EXPENSE  AND A.USER=B.USER WHERE A.EXPENSE LIKE '%_" & txtFind.Text & "'  AND A.USER='" & WHOLOGGEDIN & "' ORDER BY A.EXPDATE DESC,A.EXPENSE,B.EXPFREQ"

        End If
        SQCM.CommandText = Q
        Dr = SQCM.ExecuteReader
        With lsvTransactions.Columns
            .Add("Expense", 100)
            .Add("Spent on", 100)
            .Add("Entered on", 100)
            .Add("Amount", 100)
            .Add("Mode", 100)
            .Add("Frequency", 100)
            .Add("Comments", 100, HorizontalAlignment.Left)
        End With
        Dim lvi As ListViewItem, start As Boolean = True, total As Double
        Dim freq As String
        While Dr.Read
            If start Then
                start = False
            End If

            With lsvTransactions.Items
                '                lvi = .Add(Dr(1))
                If IsNull(Dr(5)) Then freq = "" Else freq = Dr(5)
                lsvTransactions.Items.Add(Dr(0))
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(Format(Dr(1), "dd-MMM-yyyy"))
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(Format(Dr(2), "dd-MMM-yyyy"))
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(FormatCurrency(Dr(3), 2))
                Dim x As String
                If Dr(4) Is DBNull.Value Then
                    x = ""
                Else
                    x = Dr(4)
                End If
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(x)
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(freq)
                If Dr(6) Is DBNull.Value Then
                    x = ""
                Else
                    x = Dr(6)
                End If
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.Add(x)
                total += CDbl(Dr(3))
            End With
        End While
        If Not start Then
            With lsvTransactions.Items
                lvi = .Add("TOTAL")
                lvi.Font = New Font(lvi.Font, FontStyle.Bold)
                'lvi.Group = lsvTransactions.Groups(Format(Date.Now, "dd-MMM-yyyy"))
                lsvTransactions.Items(lsvTransactions.Items.Count - 1).SubItems.AddRange(New String() {" ", " ", FormatCurrency(System.Math.Round(total, 2), 2)})
                total = 0
            End With
        End If
        Dr.Close()
        Dr.Dispose()
    End Sub

    Private Sub rbStarts_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbStarts.CheckedChanged
        If txtFind.Text <> "" Then
            lsvTransactions.Clear()
            FetchDetails()
        Else
            lsvTransactions.Clear()
        End If
    End Sub

    Private Sub rbLike_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbLike.CheckedChanged
        If txtFind.Text <> "" Then
            lsvTransactions.Clear()
            FetchDetails_like()
        Else
            lsvTransactions.Clear()
        End If
    End Sub

    Private Sub rbEnds_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEnds.CheckedChanged
        If txtFind.Text <> "" Then
            lsvTransactions.Clear()
            FetchDetails_ends()
        Else
            lsvTransactions.Clear()
        End If
    End Sub

    Private Sub Transactions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ymMonth.YearMonthValue = Date.Now.Month & "-" & Date.Now.Year
    End Sub

    Private Sub ymMonth_YearChanged() Handles ymMonth.ValueChanged
        Yme = "15-" & ymMonth.YearMonthValue
        If twcGroupby.SelectedIndex = 1 Then
            Fetchdetails_date()
            Exit Sub
        End If
        If twcGroupby.SelectedIndex = 4 Then
            Fetchdetails_upd()
            Exit Sub
        End If
    End Sub
End Class
