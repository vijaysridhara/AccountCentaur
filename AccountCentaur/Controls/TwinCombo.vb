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
Friend Class TwinCombo
    Shadows Event Click(ByVal sender As Object, ByVal e As System.EventArgs)
    Private _Fillen As Integer
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
            lblName.Text = "&" & Mid(value, 4)
            Fillit()
        End Set
    End Property

    Public Shadows ReadOnly Property Items() As ComboBox.ObjectCollection
        Get
            Return cboCombo.Items
        End Get
    End Property
    Public Property DropDownStyle() As ComboBoxStyle
        Get
            Return cboCombo.DropDownStyle
        End Get
        Set(ByVal value As ComboBoxStyle)
            cboCombo.DropDownStyle = value
        End Set
    End Property
    Public ReadOnly Property Label() As String
        Get
            Return lblName.Text
        End Get
        'Set(ByVal value As String)
        '    lblName.Text = value
        'End Set
    End Property
    Public Shadows Property Text() As String
        Get
            Return cboCombo.Text
        End Get
        Set(ByVal value As String)
            cboCombo.Text = value
        End Set
    End Property
    Public Sub AddItem(ByVal itm As Object)
        cboCombo.Items.Add(itm)
    End Sub
    Public Sub RemoveItem(ByVal value As Object)
        cboCombo.Items.Remove(value)
    End Sub
    Public Shadows Function Contains(ByVal value As Object) As Boolean
        Return cboCombo.Items.Contains(value)
    End Function
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
                cboCombo.Dock = DockStyle.None
                lblName.Dock = DockStyle.Top
                cboCombo.Dock = DockStyle.Fill
            Else
                cboCombo.Dock = DockStyle.None
                lblName.Dock = DockStyle.Left
                cboCombo.Dock = DockStyle.Fill

            End If
            Call TwinCombo_Resize(Me, New System.EventArgs)
        End Set


    End Property
    Public Sub Clear()
        cboCombo.Items.Clear()
    End Sub
    Public Property SelectedIndex() As Integer
        Get
            Return cboCombo.SelectedIndex
        End Get
        Set(ByVal value As Integer)
            cboCombo.SelectedIndex = value
        End Set
    End Property
    Public Property SelectedItem() As Object
        Get
            Return cboCombo.SelectedItem
        End Get
        Set(ByVal value As Object)
            cboCombo.SelectedItem = value
        End Set
    End Property



    Private Sub TwinCombo_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.AlignVertical Then
            Me.Height = cboCombo.Height + lblName.Height
        Else
            Me.Height = cboCombo.Height
        End If
        FillerLength = _Fillen
    End Sub

    Private Sub cboCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCombo.SelectedIndexChanged
        RaiseEvent Click(sender, e)
    End Sub
End Class
