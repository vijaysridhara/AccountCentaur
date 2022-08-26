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
Friend Class Calendar

    Dim cf As CalForm
    Public Function ShowDateForm(ByVal dt As Date) As Date
        Dim scwidth As Integer
        scwidth = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width
        Dim ourwidth As Integer
        cf = New CalForm
        cf.Value = dt
        System.Windows.Forms.Cursor.Show()
        cf.Left = System.Windows.Forms.Cursor.Position.X
        ourwidth = cf.Width + cf.Left
        If ourwidth > scwidth Then
            cf.Left = cf.Left - (ourwidth - scwidth)
        End If
        cf.Top = System.Windows.Forms.Cursor.Position.Y
        Return cf.Show
    End Function
End Class
