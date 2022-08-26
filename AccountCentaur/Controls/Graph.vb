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
Friend Class Graph
    Dim INIT As Boolean
    Dim cb1(0 To 15) As Color
    Dim STR(,) As String
    Private Sub LoadContentsClearGraph()
        'Exit Sub
        Dim q As String, DR As SQLiteDataReader, GINC As Double, DED As Double, TOT As Double, I As Integer = -1, NETTOT As Double = 0
        lsvItems.Items.Clear()
        With ZedGraphControl1
            .Dock = DockStyle.None
            .MasterPane.PaneList.Clear()
            .MasterPane.Add(New ZedGraph.GraphPane)
            .GraphPane.ReSize(ZedGraphControl1.CreateGraphics, ZedGraphControl1.GraphPane.Rect)
            .Invalidate()
            .Dock = DockStyle.Fill
            .ResumeLayout()
        End With
        With ZedGraphControl1.GraphPane
            .Fill = New ZedGraph.Fill(Color.White, Color.Goldenrod, 45.0F)
            .Chart.Fill.Type = ZedGraph.FillType.None
            .Legend.FontSpec.Size = 8
            .Legend.Position = ZedGraph.LegendPos.Bottom
        End With
        Select Case GraphMode
            Case 0
                Dim itm() As String
                Dim vals() As Double
                q = "SELECT SUBSTR(EXPDATE,1,7) AS D,EXPENSE,SUM(AMOUNT) FROM TRANSACTIONS WHERE  " & WHERECONDITON & " AND EXPDATE LIKE '" & Format(dtpYear.Value, "yyyy-MM") & "%' GROUP BY D,EXPENSE ORDER BY EXPENSE"
                SQCM.CommandText = q
                DR = SQCM.ExecuteReader
                While DR.Read
                    I += 1
                    ReDim Preserve itm(0 To I)
                    ReDim Preserve vals(0 To I)
                    itm(I) = DR(1)
                    vals(I) = FormatCurrency(DR(2), 2)
                    TOT += DR(2)
                End While
                DR.Close()
                DR.Dispose()

                q = "SELECT FORMONTHYR,SUM(GROSSINCOME),SUM(PFDED+LOANDED+OTHERDED+INCOMETAX) FROM INCOME WHERE  " & WHERECONDITON & " AND FORMONTHYR='" & Format(dtpYear.Value, "yyyy-MM") & "' GROUP BY FORMONTHYR"
                SQCM.CommandText = q
                DR = SQCM.ExecuteReader
                lsvItems.Groups.Clear()
                lsvItems.Items.Clear()
                lsvItems.Groups.Add("Income", "Income")
                lsvItems.Groups.Add("Deductions", "Deductions")
                lsvItems.Groups.Add("Expenses", "Expenses")
                lsvItems.Groups.Add("Balance", "Balance")
                Dim lsv As New ListViewItem
                If DR.Read Then
                    lsv = New ListViewItem
                    lsv.Text = "Gross Income"
                    lsv.SubItems.Add(FormatCurrency(DR(1), 2))
                    GINC = DR(1)
                    lsv.Group = lsvItems.Groups("Income")
                    lsvItems.Items.Add(lsv)
                    lsv = New ListViewItem
                    lsv.Text = "Deductions from Income"
                    lsv.SubItems.Add(FormatCurrency(DR(2), 2))
                    lsv.Group = lsvItems.Groups("Deductions")
                    lsvItems.Items.Add(lsv)
                    DED = DR(2)
                End If
                DR.Close()
                DR.Dispose()
                lsv = New ListViewItem
                lsv.Text = "Total Expenses"
                lsv.Font = New Font(lsv.Font, FontStyle.Bold)
                lsv.Group = lsvItems.Groups("Expenses")
                'twtExpenses.Text = FormatCurrency(System.Math.Round(TOT, 2), 2)
                With ZedGraphControl1.GraphPane
                    .Title.Text = "Expenses for the month " & Format(dtpYear.Value, "MMM-yyyy")
                    If chkBarchart.Checked = True Then
                        .XAxis.Title.Text = "Expenses"
                        .Y2Axis.Title.Text = "Amount"
                        .XAxis.MinorTic.IsInside = True

                    End If

                End With
                If TOT = 0 Then Exit Sub
                Dim k As Integer = 0
                For J As Integer = 0 To I

                    With ZedGraphControl1
                        If chkBarchart.Checked = False Then
                            .GraphPane.AddPieSlice(vals(J), cb1(k), Color.White, 45.0F, 0, itm(J))
                        End If
                    End With
                    Dim lv As ListViewItem
                    lv = lsvItems.Items.Add(itm(J))
                    lv.Group = lsvItems.Groups("Expenses")
                    lv.SubItems.Add(FormatCurrency(vals(J), 2))
                    If CInt((J / 15)) * 15 = J Then
                        k = 0

                    Else : k += 1
                    End If
                Next
                lsv.SubItems.Add(FormatCurrency(TOT, 2))
                lsvItems.Items.Add(lsv)
                lsv = New ListViewItem
                lsv.Text = "Net Balance"
                lsv.Group = lsvItems.Groups("Balance")
                lsv.SubItems.Add(FormatCurrency(GINC - DED - TOT, 2))
                lsvItems.Items.Add(lsv)
                If chkBarchart.Checked = True Then
                    ZedGraphControl1.GraphPane.XAxis.Scale.TextLabels = itm
                    ZedGraphControl1.GraphPane.XAxis.Scale.FontSpec.Size = 8
                    ZedGraphControl1.GraphPane.YAxis.Scale.FontSpec.Size = 8
                    ZedGraphControl1.GraphPane.AddBar("", Nothing, vals, Color.Navy)
                    ZedGraphControl1.GraphPane.XAxis.Type = ZedGraph.AxisType.Text
                End If
                ZedGraphControl1.AxisChange()
                'End With
            Case 1
                Dim itm() As String
                Dim vals() As Double
                q = "SELECT SUBSTR(EXPDATE,1,4) AS D,EXPENSE,SUM(AMOUNT) FROM TRANSACTIONS WHERE  " & WHERECONDITON & " AND EXPDATE LIKE '" & Format(dtpYear.Value, "yyyy") & "%' GROUP BY D,EXPENSE"
                lsvItems.Groups.Clear()
                lsvItems.Items.Clear()
                lsvItems.Groups.Add("Income", "Income")
                lsvItems.Groups.Add("Deductions", "Deductions")
                lsvItems.Groups.Add("Expenses", "Expenses")
                lsvItems.Groups.Add("Balance", "Balance")

                SQCM.CommandText = q
                DR = SQCM.ExecuteReader
                While DR.Read
                    I += 1
                    ReDim Preserve itm(0 To I)
                    ReDim Preserve vals(0 To I)
                    itm(I) = DR(1)
                    vals(I) = FormatCurrency(DR(2), 2)
                    TOT += DR(2)
                End While
                DR.Close()
                DR.Dispose()
                q = "SELECT SUBSTR(FORMONTHYR,1,4) AS Y,SUM(GROSSINCOME),SUM(PFDED+LOANDED+OTHERDED+INCOMETAX) FROM INCOME WHERE  " & WHERECONDITON & " AND FORMONTHYR LIKE'" & Format(dtpYear.Value, "yyyy") & "%' GROUP BY Y"
                SQCM.CommandText = q
                DR = SQCM.ExecuteReader
                Dim lsv As New ListViewItem
                If DR.Read Then
                    lsv = New ListViewItem
                    lsv.Text = "Gross Income"
                    lsv.SubItems.Add(FormatCurrency(DR(1), 2))
                    GINC = DR(1)
                    lsv.Group = lsvItems.Groups("Income")
                    lsvItems.Items.Add(lsv)
                    lsv = New ListViewItem
                    lsv.Text = "Deductions from Income"
                    lsv.SubItems.Add(FormatCurrency(DR(2), 2))
                    lsv.Group = lsvItems.Groups("Deductions")
                    lsvItems.Items.Add(lsv)
                    DED = DR(2)
                End If
                DR.Close()
                DR.Dispose()
                lsv = New ListViewItem
                lsv.Text = "Total Expenses"
                lsv.Font = New Font(lsv.Font, FontStyle.Bold)
                lsv.Group = lsvItems.Groups("Expenses")
                If TOT = 0 Then Exit Sub
                With ZedGraphControl1.GraphPane
                    .Title.Text = "Expenses for the year " & Format(dtpYear.Value, "yyyy")
                    If chkBarchart.Checked = True Then
                        .XAxis.Title.Text = "Expenses"
                        .XAxis.MinorTic.IsInside = True
                        .Y2Axis.Title.Text = "Amount"
                    End If

                End With

                If TOT = 0 Then Exit Sub
                Dim k As Integer = 0

                For J As Integer = 0 To I
                    With ZedGraphControl1
                        If chkBarchart.Checked = False Then
                            .GraphPane.AddPieSlice(vals(J), cb1(k), Color.White, 45.0F, 0, itm(J))
                        End If

                    End With
                    Dim lv As New ListViewItem
                    lv = lsvItems.Items.Add(itm(J))
                    lv.Group = lsvItems.Groups("Expenses")
                    lv.SubItems.Add(FormatCurrency(vals(J), 2))
                    If CInt((J / 15)) * 15 = J Then
                        k = 0
                    Else : k += 1
                    End If
                Next
                'End With
                lsv.SubItems.Add(FormatCurrency(TOT, 2))
                lsvItems.Items.Add(lsv)
                lsv = New ListViewItem
                lsv.Text = "Net Balance"
                lsv.Group = lsvItems.Groups("Balance")
                lsv.SubItems.Add(FormatCurrency(GINC - DED - TOT, 2))
                lsvItems.Items.Add(lsv)
                If chkBarchart.Checked = True Then
                    ZedGraphControl1.GraphPane.XAxis.Scale.TextLabels = itm
                    ZedGraphControl1.GraphPane.XAxis.Scale.FontSpec.Size = 8
                    ZedGraphControl1.GraphPane.YAxis.Scale.FontSpec.Size = 8
                    ZedGraphControl1.GraphPane.AddBar("", Nothing, vals, Color.Navy)
                    ZedGraphControl1.GraphPane.XAxis.Type = ZedGraph.AxisType.Text
                End If
                ZedGraphControl1.AxisChange()
            Case 2
                q = "SELECT SUBSTR(EXPDATE,1,7) AS D,SUM(AMOUNT) FROM TRANSACTIONS WHERE  " & WHERECONDITON & " AND EXPDATE LIKE '" & Format(dtpYear.Value, "yyyy") & "%' GROUP BY D ORDER BY D DESC"
                SQCM.CommandText = q
                DR = SQCM.ExecuteReader
                Dim itm() As String, vals() As Double
                While DR.Read
                    I += 1
                    ReDim Preserve itm(0 To I)
                    ReDim Preserve vals(0 To I)
                    itm(I) = DR(0)
                    vals(I) = FormatCurrency(DR(1), 2)
                    TOT += DR(1)
                End While
                DR.Close()
                DR.Dispose()
                q = "SELECT SUBSTR(FORMONTHYR,1,4) as Y,SUM(GROSSINCOME),SUM(PFDED+LOANDED+OTHERDED+INCOMETAX) FROM INCOME WHERE  " & WHERECONDITON & " AND FORMONTHYR LIKE '" & Format(dtpYear.Value, "yyyy") & "%' GROUP BY Y"
                SQCM.CommandText = q
                DR = SQCM.ExecuteReader
                lsvItems.Groups.Clear()
                lsvItems.Items.Clear()
                lsvItems.Groups.Add("Income", "Income")
                lsvItems.Groups.Add("Deductions", "Deductions")
                lsvItems.Groups.Add("Expenses", "Expenses")
                lsvItems.Groups.Add("Balance", "Balance")
                Dim lsv As New ListViewItem
                If DR.Read Then
                    lsv = New ListViewItem
                    lsv.Text = "Gross Income"
                    lsv.SubItems.Add(FormatCurrency(DR(1), 2))
                    GINC = DR(1)
                    lsv.Group = lsvItems.Groups("Income")
                    lsvItems.Items.Add(lsv)
                    lsv = New ListViewItem
                    lsv.Text = "Deductions from Income"
                    lsv.SubItems.Add(FormatCurrency(DR(2), 2))
                    lsv.Group = lsvItems.Groups("Deductions")
                    lsvItems.Items.Add(lsv)
                    DED = DR(2)
                End If
                DR.Close()
                DR.Dispose()
                lsv = New ListViewItem
                lsv.Text = "Total Expenses"
                lsv.Font = New Font(lsv.Font, FontStyle.Bold)
                lsv.Group = lsvItems.Groups("Expenses")
                With ZedGraphControl1.GraphPane
                    .Title.Text = "Expenditures for each month in " & Format(dtpYear.Value, "yyyy")
                    If chkBarchart.Checked = True Then
                        .XAxis.Title.Text = "Month"
                        .XAxis.MinorTic.IsInside = True
                        .Y2Axis.Title.Text = "Amount"
                    End If
                End With
                If TOT = 0 Then Exit Sub
                Dim k As Integer = 0
                For J As Integer = 0 To I
                    With ZedGraphControl1
                        If chkBarchart.Checked = False Then
                            .GraphPane.AddPieSlice(vals(J), cb1(k), Color.White, 45.0F, 0, itm(J))
                        End If
                    End With
                    Dim lv As New ListViewItem
                    lv = lsvItems.Items.Add(itm(J))
                    lv.Group = lsvItems.Groups("Expenses")
                    lv.SubItems.Add(FormatCurrency(vals(J), 2))
                    If CInt((J / 15)) * 15 = J Then
                        k = 0
                    Else : k += 1
                    End If
                Next
                lsv.SubItems.Add(FormatCurrency(TOT, 2))
                lsvItems.Items.Add(lsv)
                lsv = New ListViewItem
                lsv.Text = "Net Balance"
                lsv.Group = lsvItems.Groups("Balance")
                lsv.SubItems.Add(FormatCurrency(GINC - DED - TOT, 2))
                lsvItems.Items.Add(lsv)
                If chkBarchart.Checked = True Then
                    ZedGraphControl1.GraphPane.XAxis.Scale.TextLabels = itm
                    ZedGraphControl1.GraphPane.XAxis.Type = ZedGraph.AxisType.Text
                    ZedGraphControl1.GraphPane.XAxis.Scale.FontSpec.Size = 8
                    ZedGraphControl1.GraphPane.YAxis.Scale.FontSpec.Size = 8
                    ZedGraphControl1.GraphPane.AddBar("", Nothing, vals, Color.Navy)
                End If
                ZedGraphControl1.AxisChange()
                'End With
        End Select
    End Sub
    Private Sub Graph_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        twcType.Items.Add("Monthly-Expenses")

        twcType.Items.Add("Yearly-Expenses")
        twcType.Items.Add("Monthwise-Year")

        'INIT = True
        twcType.SelectedIndex = GraphMode
        dtpYear.Value = GraphYear
        cb1(0) = Color.Chocolate
        cb1(1) = Color.Red
        cb1(2) = Color.Blue
        cb1(3) = Color.Yellow
        cb1(4) = Color.Green
        cb1(5) = Color.Orange
        cb1(6) = Color.Pink
        cb1(7) = Color.Brown
        cb1(8) = Color.Black
        cb1(9) = Color.Violet
        cb1(10) = Color.Cyan
        cb1(11) = Color.LightGreen
        cb1(12) = Color.Lavender
        cb1(13) = Color.Magenta
        cb1(14) = Color.Maroon
        cb1(15) = Color.Teal
        twcType_Click(sender, e)
        'If INIT Then
        '    INIT = False

        '    Exit Sub
        'End If
    End Sub
    Private Sub twcType_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles twcType.Click
        If INIT Then Exit Sub
        GraphMode = twcType.SelectedIndex
        LoadContentsClearGraph()
    End Sub
    Private Sub chkBarchart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBarchart.CheckedChanged
        LoadContentsClearGraph()
    End Sub
    Private Sub dtpYear_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpYear.ValueChanged
        GraphYear = dtpYear.Value
        LoadContentsClearGraph()
    End Sub
End Class
