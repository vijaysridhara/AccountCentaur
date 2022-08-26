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
Friend Class CalForm
    Private init As Boolean
    Private isDateSet As Boolean

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        init = True
    End Sub
    Public Property Value() As Date
        Get
            Return MonthCalendar1.SelectionRange.Start
        End Get
        Set(ByVal value As Date)
            MonthCalendar1.SetDate(value)
            If MonthCalendar1.SelectionRange.Start = value Then init = False
        End Set
    End Property
    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged

    End Sub
    Public Overloads Function Show() As Date
        MyBase.ShowDialog()
        If isDateSet Then Return Value
    End Function
    Private Sub CalForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Space Then
            isDateSet = True
            Me.Close()
        End If
    End Sub

    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        If init Then init = False : Exit Sub
        isDateSet = True
        Me.Close()
    End Sub
End Class
