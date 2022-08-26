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
Friend Class TwinText
    Shadows Event TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Private _Fillen As Integer
    Private _alnu As Boolean
    Public Property AllowNumeric() As Boolean
        Get
            Return _alnu
        End Get
        Set(ByVal value As Boolean)
            _alnu = value
            If value Then txtText.TextAlign = HorizontalAlignment.Right
        End Set
    End Property
    Public Property FillerLength() As Integer
        Get
            Return _Fillen
        End Get
        Set(ByVal value As Integer)
            _Fillen = value
            Fillit()
        End Set
    End Property
    Private Sub Fillit()
        On Error Resume Next
        lblName.Text = lblName.Text.Trim & Space(FillerLength - lblName.Text.Trim.Length)

    End Sub
    Public Shadows Property Name() As String
        Get
            Return MyBase.Name
        End Get
        Set(ByVal value As String)
            MyBase.Name = value

            Label = "&" & Mid(value, 4)
            Fillit()
        End Set
    End Property
    Public Property Label() As String
        Get
            Return lblName.Text
        End Get
        Set(ByVal value As String)
            lblName.Text = value
        End Set
    End Property
    Public Property MultiLine() As Boolean
        Get
            Return txtText.Multiline
        End Get
        Set(ByVal value As Boolean)
            txtText.Multiline = value
            Call TwinText_Resize(Me, New EventArgs)
        End Set
    End Property
    Public Property Scrollbars() As System.Windows.Forms.ScrollBars
        Get
            Return txtText.ScrollBars
        End Get
        Set(ByVal value As System.Windows.Forms.ScrollBars)
            txtText.ScrollBars = value

        End Set
    End Property
    Public Shadows Property Text() As String
        Get
            Return txtText.Text
        End Get
        Set(ByVal value As String)

            txtText.Text = value
        End Set
    End Property
    Public Shadows Property PasswordChar() As Char
        Get
            Return txtText.PasswordChar
        End Get
        Set(ByVal value As Char)
            txtText.PasswordChar = value
        End Set
    End Property

    Public Property AlignVertical() As Boolean
        Get
            If lblName.Dock = DockStyle.Left Then
                Return False
            Else
                Return True
            End If
        End Get
        Set(ByVal value As Boolean)
            If value Then
                txtText.Dock = DockStyle.None
                lblName.Dock = DockStyle.Top
                txtText.Dock = DockStyle.Fill
            Else
                txtText.Dock = DockStyle.None
                lblName.Dock = DockStyle.Left
                txtText.Dock = DockStyle.Fill

            End If
            Call TwinText_Resize(Me, New System.EventArgs)
        End Set


    End Property
    Public Sub Clear()
        txtText.Clear()
    End Sub




    Private Sub TwinText_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.AlignVertical Then
            If MultiLine Then
                txtText.Height = Me.Height - lblName.Height
            Else
                Me.Height = txtText.Height + lblName.Height
            End If
        Else

            If MultiLine Then
                txtText.Height = Me.Height
            Else
                Me.Height = txtText.Height
            End If
        End If
    End Sub

    Private Sub txtText_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtText.KeyPress
        If AllowNumeric = False Then Exit Sub
        Dim tb As TextBox = sender
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "-") Then
            e.Handled = True
        End If
        If e.KeyChar = "." And InStr(txtText.Text, ".") > 0 Then
            e.Handled = True
        End If
        If e.KeyChar = "-" And InStr(txtText.Text, "-") > 0 Then
            e.Handled = True
        End If
        If e.KeyChar = "-" And txtText.SelectionStart > 0 Then
            e.Handled = True
        End If
        If e.KeyChar = "." And txtText.SelectionStart = 0 Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtText_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtText.LostFocus
        If IsNumeric(txtText.Text) And AllowNumeric Then
            txtText.Text = FormatCurrency(txtText.Text, 2)
        End If
    End Sub

    Private Sub txtText_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtText.TextChanged
        ' Dim rg As System.Text.RegularExpressions.Regex

        RaiseEvent TextChanged(sender, e)
    End Sub


    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub
End Class
