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
Friend Class Savings

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Savings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        With twcType.Items
            .Add("Saving scheme")
            .Add("Recurring deposit")
            .Add("Gold Purchased")
            .Add("Put in Locker")
            .Add("Lent to someone")
            .Add("Shares purchased")
            .Add("Mutual funds")
            .Add("IPO Purchased")
            .Add("SIP")
            .Add("Bonds Purchased")
            .Add("Real estate")
            .Add("Life Insurance")
            .Add("House Insurance")
            .Add("Vehicle Insurance")
            .Add("Other Insurance")
            .Add("Other")
        End With
    End Sub
    Public Sub RefreshContents()
        Dim Q As String, dr As SQLiteDataReader
        DefaultZeros()
        If chkNonInsurance.Checked = False Then
            Q = "SELECT ROWNUM,FORMONTHYR,SAVENAME,SAVETYPE,ONDATE,COMMENTS,AMOUNT FROM INVESTMENTS WHERE  " & WHERECONDITON & " ORDER BY FORMONTHYR DESC,SAVETYPE,SAVENAME"
        Else
            Q = "SELECT ROWNUM,FORMONTHYR,SAVENAME,SAVETYPE,ONDATE,COMMENTS,AMOUNT FROM INVESTMENTS WHERE " & WHERECONDITON & " AND SAVETYPE NOT LIKE '%Insurance' ORDER BY FORMONTHYR DESC,SAVETYPE,SAVENAME"
        End If

        Try
            lsvSavings.Items.Clear()
            SQCM.CommandText = Q
            dr = SQCM.ExecuteReader
            Dim PREVMTYR As String = ""
            Dim tots As Double
            Dim strt As Boolean
            While dr.Read
                strt = True
                If PREVMTYR <> dr(1) Then
                    If PREVMTYR <> "" Then
                        Dim lvs As ListViewItem
                        lvs = lsvSavings.Items.Add("TOTAL")
                        lvs.Font = New Font(lvs.Font, FontStyle.Bold)
                        lvs.Group = lsvSavings.Groups(PREVMTYR)
                        lvs.SubItems.Add("")
                        lvs.SubItems.Add("")
                        lvs.SubItems.Add("")

                        lvs.SubItems.Add(FormatCurrency(tots, 2))
                        lvs.Tag = "TOT"
                    End If
                    lsvSavings.Groups.Add(dr(1), dr(1))
                    PREVMTYR = dr(1)
                    tots = 0
                End If
                Dim lv As ListViewItem
                lv = lsvSavings.Items.Add(dr(2))
                lv.Group = lsvSavings.Groups(PREVMTYR)
                lv.SubItems.Add(dr(3))

                lv.SubItems.Add(dr(4))
                lv.SubItems.Add(dr(5))
                lv.SubItems.Add(FormatCurrency(dr(6), 2))
                tots += dr(6)
                lv.Tag = dr(0)
            End While
            If strt Then
                Dim lv As ListViewItem
                lv = lsvSavings.Items.Add("TOTAL")
                lv.Group = lsvSavings.Groups(PREVMTYR)
                lv.SubItems.Add("")
                lv.SubItems.Add("")
                lv.SubItems.Add("")
                lv.SubItems.Add(FormatCurrency(tots, 2))
                lv.Tag = "TOT"
                lv.Font = New Font(lv.Font, FontStyle.Bold)
            End If
            dr.Close()
            dr.Dispose()
            butDeleteEntry.Enabled = False
            butUpdateEntry.Enabled = False
        Catch ex As Exception
            DE(ex)
        End Try

    End Sub

    Private Sub butMakeEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butMakeEntry.Click
        Try
            DefaultZeros()
            Dim Q As String, MTYR As String, TYP As String, CDAT As String, AMT As Decimal, SNAME As String, COMM As String
            MTYR = Format(dtpYear.Value, "yyyy-MM")
            SNAME = twcSaving.Text
            TYP = twcType.Text

            AMT = twtAmount.Text
            COMM = twtComments.Text
            CDAT = Format(Date.Now, "yyyy-MM-dd")

            Q = "INSERT INTO INVESTMENTS (FORMONTHYR,SAVENAME,SAVETYPE,ONDATE,COMMENTS,USER,AMOUNT) " & _
            "VALUES('" & MTYR & "','" & SNAME & "','" & TYP & "','" & CDAT & _
            "','" & COMM & "','" & WHOLOGGEDIN & "'," & AMT & ")"
            SQCM.CommandText = Q
            SQCM.ExecuteNonQuery()
            RefreshContents()
        Catch ex As Exception
            DE(ex)
        End Try

    End Sub
    Private Sub DefaultZeros()
        If twtAmount.Text = "" Then twtAmount.Text = 0
    End Sub

    Private Sub chkNonInsurance_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNonInsurance.CheckedChanged

    End Sub

    Private Sub chkNonInsurance_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkNonInsurance.CheckStateChanged
        RefreshContents()
    End Sub

    Private Sub lsvSavings_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvSavings.SelectedIndexChanged
        butDeleteEntry.Enabled = False
        butUpdateEntry.Enabled = False

        Try
            If lsvSavings.SelectedItems.Count = 0 Then Exit Sub
            If CStr(lsvSavings.SelectedItems(0).Tag) = "TOT" Then Exit Sub
            Dim lv As ListViewItem
            lv = lsvSavings.SelectedItems(0)
            Dim dt As Date
            With lv
                dt = CDate(.Group.Header & "-01")
                dtpYear.Value = dt

                twcSaving.Text = .SubItems(0).Text
                twcType.Text = .SubItems(1).Text

                twtAmount.Text = .SubItems(4).Text
                twtComments.Text = .SubItems(3).Text
                butDeleteEntry.Enabled = True
                butUpdateEntry.Enabled = True
            End With

        Catch ex As Exception
            DE(ex)
        End Try

    End Sub

    Private Sub butUpdateEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butUpdateEntry.Click
        Try
            DefaultZeros()
            Dim Q As String, MTYR As String, TYP As String, CDAT As String, AMT As Decimal, SNAME As String, COMM As String
            MTYR = Format(dtpYear.Value, "yyyy-MM")
            SNAME = twcSaving.Text
            TYP = twcType.Text
            AMT = twtAmount.Text
            COMM = twtComments.Text
            CDAT = Format(Date.Now, "yyyy-MM-dd")
            Q = "UPDATE INVESTMENTS SET FORMONTHYR='" & MTYR & "',SAVETYPE='" & TYP & "',SAVENAME='" & SNAME & "',ONDATE='" & _
               CDAT & "',COMMENTS='" & COMM & "',AMOUNT=" & AMT & " WHERE ROWNUM=" & lsvSavings.SelectedItems(0).Tag
            SQCM.CommandText = Q
            SQCM.ExecuteNonQuery()
            RefreshContents()
        Catch ex As Exception
            DE(ex)
        End Try

    End Sub

    Private Sub butDeleteEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butDeleteEntry.Click
        Try
            Dim IX As Integer = lsvSavings.SelectedItems(0).Tag
            If ConfDelete() Then
                Dim q As String
                q = "DELETE FROM INVESTMENTS WHERE ROWNUM=" & IX
                SQCM.CommandText = q
                SQCM.ExecuteNonQuery()
                RefreshContents()
            End If
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub
End Class
