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
Friend Class MultiEntry

    Private init As Boolean
    Private isvalueSet As Boolean
    Private StarTVal As Double

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        init = True
    End Sub

    Private Sub MultiEntry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            butcancel_Click(sender, e)
        End If
    End Sub

    Public Property Value() As Double
        Get
            Dim arr() As String
            Dim i As Integer
            Dim temp_val As Double
            'arr = Me.AmountText.Text.Split(" ")
            arr = Me.txtData.Lines
            'arr = Me.AmountText.Lines
            For i = 0 To UBound(arr)
                If IsNumeric(arr(i)) = False Then Continue For
                temp_val = temp_val + arr(i).Trim
            Next i
            Return temp_val
        End Get
        Set(ByVal Value As Double)
            'Me.AmountText.Text = Value
            Me.txtData.Text = Value
            StarTVal = Value
        End Set
    End Property
    Public Overloads Function Show() As Double
        MyBase.ShowDialog()
        If isvalueSet Then Return Value Else Return StarTVal
    End Function

    Private Sub txtData_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtData.TextChanged
        On Error Resume Next
        isvalueSet = True
    End Sub

    Private Sub butok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butok.Click
        Me.Close()
        Me.ResetText()
    End Sub

    Private Sub butcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butcancel.Click
        isvalueSet = False
        Me.Close()
    End Sub

End Class