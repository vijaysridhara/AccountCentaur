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
Friend Class Income

    Private Sub Income_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        With twcType.Items
            .Add("Salary")
            .Add("Rent")
            .Add("Returns")
            .Add("Others")

        End With
    End Sub

    Private Sub twtGrossIncome_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles twtGrossIncome.TextChanged
        On Error Resume Next
        twtNetIncome.Text = (twtGrossIncome.Text - twtIncomeTax.Text - twtSavings.Text - twtLoanDeductions.Text - twtOtherDeduction.Text)

    End Sub


    Private Sub twtIncomeTax_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles twtIncomeTax.TextChanged
        On Error Resume Next
        twtNetIncome.Text = (twtGrossIncome.Text - twtIncomeTax.Text - twtSavings.Text - twtLoanDeductions.Text - twtOtherDeduction.Text)

    End Sub

    Private Sub twtLoanDeductions_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles twtLoanDeductions.TextChanged
        On Error Resume Next
        twtNetIncome.Text = (twtGrossIncome.Text - twtIncomeTax.Text - twtSavings.Text - twtLoanDeductions.Text - twtOtherDeduction.Text)

    End Sub

    Private Sub twtOtherDeduction_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles twtOtherDeduction.TextChanged
        On Error Resume Next
        twtNetIncome.Text = (twtGrossIncome.Text - twtIncomeTax.Text - twtSavings.Text - twtLoanDeductions.Text - twtOtherDeduction.Text)

    End Sub

    Private Sub twtProvidentFund_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles twtSavings.TextChanged
        On Error Resume Next
        twtNetIncome.Text = (twtGrossIncome.Text - twtIncomeTax.Text - twtSavings.Text - twtLoanDeductions.Text - twtOtherDeduction.Text)

    End Sub

    Private Sub butMakeEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butMakeEntry.Click
        Try
            DefaultZeros()
            Dim Q As String, MTYR As String, TYP As String, CM As String, GI As Double, IT As Double, PF As Double, LN As Double, OT As Double, NET As Double
            MTYR = Format(dtpYear.Value, "yyyy-MM")
            TYP = twcType.Text
            GI = twtGrossIncome.Text
            IT = twtIncomeTax.Text
            PF = twtSavings.Text
            LN = twtLoanDeductions.Text
            OT = twtOtherDeduction.Text
            NET = twtNetIncome.Text
            CM = twtComments.Text
            Q = "INSERT INTO INCOME (FORMONTHYR,TYPE,GROSSINCOME,INCOMETAX,PFDED,LOANDED,OTHERDED,NETINCOME,COMMENTS,USER) " & _
            "VALUES('" & MTYR & "','" & TYP & "'," & GI & "," & IT & _
            "," & PF & "," & LN & "," & OT & "," & NET & ",'" & CM & "','" & WHOLOGGEDIN & "')"
            SQCM.CommandText = Q
            SQCM.ExecuteNonQuery()
            RefreshContents()
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub
    Private Sub DefaultZeros()
        If twtGrossIncome.Text = "" Then twtGrossIncome.Text = 0
        If twtIncomeTax.Text = "" Then twtIncomeTax.Text = 0
        If twtSavings.Text = "" Then twtSavings.Text = 0
        If twtLoanDeductions.Text = "" Then twtLoanDeductions.Text = 0
        If twtOtherDeduction.Text = "" Then twtOtherDeduction.Text = 0
        If twtNetIncome.Text = "" Then twtNetIncome.Text = 0
    End Sub
    Public Sub RefreshContents()
        Dim Q As String, dr As SQLiteDataReader
        twtGrossIncome.Text = 0
        twtIncomeTax.Text = 0
        twtLoanDeductions.Text = 0
        twtOtherDeduction.Text = 0
        twtNetIncome.Text = 0
        twtSavings.Text = 0

        Q = "SELECT ROWNUM,FORMONTHYR,TYPE,GROSSINCOME,INCOMETAX,PFDED,LOANDED,OTHERDED,NETINCOME,COMMENTS FROM INCOME WHERE  " & WHERECONDITON & " ORDER BY FORMONTHYR DESC,TYPE"
        Try
            lsvIncome.Items.Clear()
            SQCM.CommandText = Q
            dr = SQCM.ExecuteReader
            Dim PREVMTYR As String = ""
            Dim tots(0 To 5) As Double
            Dim strt As Boolean
            While dr.Read
                strt = True
                If PREVMTYR <> dr(1) Then
                    If PREVMTYR <> "" Then
                        Dim lvs As ListViewItem

                        lvs = lsvIncome.Items.Add("TOTAL")
                        lvs.Font = New Font(lvs.Font, FontStyle.Bold)
                        lvs.Group = lsvIncome.Groups(PREVMTYR)
                        For i As Integer = 0 To 5
                            lvs.SubItems.Add(FormatCurrency(tots(i), 2))
                        Next
                        lvs.Tag = "TOT"
                    End If
                    lsvIncome.Groups.Add(dr(1), dr(1))
                    PREVMTYR = dr(1)
                    For i As Integer = 0 To 5
                        tots(i) = 0
                    Next
                End If
                Dim lv As ListViewItem
                lv = lsvIncome.Items.Add(dr(2))
                lv.Group = lsvIncome.Groups(PREVMTYR)
                lv.SubItems.Add(FormatCurrency(dr(3), 2))

                lv.SubItems.Add(FormatCurrency(dr(4)))
                lv.SubItems.Add(FormatCurrency(dr(5)))
                lv.SubItems.Add(FormatCurrency(dr(6)))
                lv.SubItems.Add(FormatCurrency(dr(7)))
                lv.SubItems.Add(FormatCurrency(dr(8)))
                For i As Integer = 0 To 5
                    tots(i) += dr(i + 3)
                Next
                lv.SubItems.Add(dr(9))
                lv.Tag = dr(0)
            End While
            If strt Then
                Dim lv As ListViewItem
                lv = lsvIncome.Items.Add("TOTAL")
                lv.Group = lsvIncome.Groups(PREVMTYR)
                For i As Integer = 0 To 5
                    lv.SubItems.Add(FormatCurrency(tots(i), 2))
                Next
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

    Private Sub lsvIncome_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvIncome.SelectedIndexChanged
        butDeleteEntry.Enabled = False
        butUpdateEntry.Enabled = False

        Try
            If lsvIncome.SelectedItems.Count = 0 Then Exit Sub
            If CStr(lsvIncome.SelectedItems(0).Tag) = "TOT" Then Exit Sub
            Dim lv As ListViewItem
            lv = lsvIncome.SelectedItems(0)
            Dim dt As Date
            With lv
                dt = CDate(.Group.Header & "-01")
                dtpYear.Value = dt

                twcType.Text = .SubItems(0).Text
                twtGrossIncome.Text = .SubItems(1).Text
                twtIncomeTax.Text = .SubItems(2).Text
                twtSavings.Text = .SubItems(3).Text
                twtLoanDeductions.Text = .SubItems(4).Text
                twtOtherDeduction.Text = .SubItems(5).Text
                twtNetIncome.Text = .SubItems(6).Text
                twtComments.Text = .SubItems(7).Text
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
            Dim Q As String, MTYR As String, TYP As String, CM As String, GI As Double, IT As Double, PF As Double, LN As Double, OT As Double, NET As Double
            MTYR = Format(dtpYear.Value, "yyyy-MM")
            TYP = twcType.Text
            GI = twtGrossIncome.Text
            IT = twtIncomeTax.Text
            PF = twtSavings.Text
            LN = twtLoanDeductions.Text
            OT = twtOtherDeduction.Text
            NET = twtNetIncome.Text
            CM = twtComments.Text
            Q = "UPDATE INCOME SET FORMONTHYR='" & MTYR & "',TYPE='" & TYP & "',GROSSINCOME=" & _
               GI & ",INCOMETAX=" & IT & ",PFDED=" & PF & ",LOANDED=" & _
             LN & ",OTHERDED=" & OT & ",NETINCOME=" & NET & ",COMMENTS='" & _
               CM & "' WHERE ROWNUM=" & lsvIncome.SelectedItems(0).Tag
            SQCM.CommandText = Q
            SQCM.ExecuteNonQuery()
            RefreshContents()
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub butDeleteEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butDeleteEntry.Click
        Try
            Dim IX As Integer = lsvIncome.SelectedItems(0).Tag
            If ConfDelete() Then
                Dim q As String
                q = "DELETE FROM INCOME WHERE ROWNUM=" & IX
                SQCM.CommandText = q
                SQCM.ExecuteNonQuery()
                RefreshContents()
            End If
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub twtGrossIncome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles twtGrossIncome.Load

    End Sub

    Private Sub twtSavings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles twtSavings.Load

    End Sub
End Class
