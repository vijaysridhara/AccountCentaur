
Imports System.Data.SQLite
Imports butfun
Imports VijaySridhara.Applications.InitParams
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
Friend Class LoginForm


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            Dim vje As New VJEncryptor.Encryptor
            Dim un As String, pw As String, Q As String, dr As SQLiteDataReader
            un = twcUsers.Text.Trim

            pw = PasswordText.Text.Trim
            Q = "SELECT USER,PASSWORD,TYPE FROM USERS WHERE USER='" & un & "'"
            SQCM.CommandText = Q
            dr = SQCM.ExecuteReader
            If dr.Read Then
                If vje.EncryptTripleDES(pw, un) = dr(1) Then
                    If dr(2).ToString.ToUpper = "ADMIN" Then USERISADMIN = True
                    WHOLOGGEDIN = un
                    dr.Close()
                    dr.Dispose()
                    newMain.optEntry_CheckedChanged(sender, New System.EventArgs)
                    newMain.Show()
                    Rempwd = ChkRempwd.Checked
                    My.Settings.Rempwd = Rempwd
                    If Rempwd = False Then

                        My.Settings.pw = ""
                        My.Settings.un = ""

                    Else
                        My.Settings.pw = vje.EncryptTripleDES(PasswordText.Text.Trim, twcUsers.Text.Trim)
                        My.Settings.un = un
                    End If
                    vje = Nothing
                    If un = "admin" Then
                        IsAdmin = True

                    End If
                    SetWhereCondition()

                    Me.Hide()
                Else
                    dr.Close()
                    dr.Dispose()
                    MsgBox("Wrong password", MsgBoxStyle.Information)
                    PasswordText.Focus()
                    PasswordText.SelectionStart = 0
                    PasswordText.SelectionLength = PasswordText.Text.Length
                End If

                Exit Sub

            Else
                dr.Close()
                dr.Dispose()
                MsgBox("There exists no such user, please contact admin", MsgBoxStyle.Information)
            End If
            Me.Close()

        Catch ex As Exception
            DE(ex)
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


    Private Sub LoginForm1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            OK_Click(sender, e)
        ElseIf e.KeyCode = Keys.Escape Then
            Cancel_Click(sender, e)

        End If
    End Sub

    Private Sub LoginForm1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
    End Sub


    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim vje As New VJEncryptor.Encryptor
        Try

            Dim dbfolder As String
            dbfolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            dbfolder += "\AccountCentaur"
            constring = "Data Source={0};New=FALSE;Version=3"
            constring = String.Format(constring, dbfolder & "\PEQ.db")
            If IO.Directory.Exists(dbfolder) = False Then
                MkDir(dbfolder)
            End If
            If IO.File.Exists(dbfolder & "\PEQ.db") = False Then
                IO.File.Create(dbfolder & "\PEQ.db").Close()
                sqlconn = New SQLiteConnection(constring)
                sqlconn.Open()
                SQCM.Connection = sqlconn
                Dim query As String = "CREATE TABLE EXPENSES (EXPENSE VARCHAR(100),EXPFREQ VARCHAR(10), USER VARCHAR(20),PRIMARY KEY (EXPENSE,USER)); CREATE TABLE INCOME ( ROWNUM INTEGER PRIMARY KEY AUTOINCREMENT, GROSSINCOME NUMERIC(10,2), FORMONTHYR CHAR(7), TYPE              VARCHAR(20) DEFAULT 'SALARY', INCOMETAX    NUMERIC(10,2) DEFAULT 0, PFDED            NUMERIC(10,2) DEFAULT 0, LOANDED        NUMERIC(10,2) DEFAULT 0, OTHERDED     NUMERIC(10,2) DEFAULT 0, NETINCOME    NUMERIC(10,2) DEFAULT 0, COMMENTS VARCHAR(100) , USER VARCHAR(20)); CREATE TABLE INVESTMENTS (ROWNUM INTEGER PRIMARY KEY AUTOINCREMENT, SAVENAME VARCHAR(40), SAVETYPE VARCHAR(30), FORMONTHYR CHAR(7), AMOUNT NUMERIC(10,2) DEFAULT 0, ONDATE    DATE, COMMENTS VARCHAR(100), USER VARCHAR(20) ); CREATE TABLE NOTES ( ROWNUM INTEGER PRIMARY KEY AUTOINCREMENT, NOTES VARCHAR(200), NOTEDATE DATE, STATUS CHAR(1) DEFAULT 'O', ONORAFTER DATE, USER VARCHAR(20) ); CREATE TABLE TRANSACTIONS ( ROWNUM INTEGER PRIMARY KEY AUTOINCREMENT, EXPENSE VARCHAR(100), EXPMETHOD VARCHAR(10), AMOUNT NUMERIC(10,2), EXPDATE DATE, EXPENTRY DATE, MISCELLANY VARCHAR(100) , USER VARCHAR(20)); CREATE TABLE USERS ( USER VARCHAR(20) PRIMARY KEY, PASSWORD VARCHAR(100), TYPE CHAR(5) DEFAULT 'USER' )"
                Dim queries() As String = query.Split(";")
                For Each q As String In queries
                    SQCM.CommandText = q
                    SQCM.ExecuteNonQuery()
                Next
                query = "INSERT INTO USERS(USER,PASSWORD,TYPE) VALUES('admin','" & vje.EncryptTripleDES("admin123", "admin") & "','admin')"
                SQCM.CommandText = query
                SQCM.ExecuteNonQuery()
            Else
                sqlconn = New SQLiteConnection(constring)
                sqlconn.Open()
                SQCM.Connection = sqlconn
            End If
        Catch ex As Exception
            DE(ex)
            Me.Close()
        End Try
        GetUsers()
        Try
            newMain = New MainForm()
        Catch ex As Exception
            DE(ex)
        End Try

        For Each ctl As Control In newMain.Controls
            If TypeOf ctl Is TextBox Or TypeOf ctl Is ListBox Or TypeOf ctl Is Label Or TypeOf ctl Is ListView Or TypeOf ctl Is DataGridView Or TypeOf ctl Is ZedGraph.ZedGraphControl Then Continue For
            ctl.BackColor = My.Settings.Appearance
            SetColor(ctl, My.Settings.Appearance)
        Next
        Dim un As String
        Dim pw As String
        Rempwd = My.Settings.Rempwd
        Dim np As String
        un = My.Settings.un
        pw = My.Settings.pw
        np = vje.DecryptTripleDES(pw, un)
        ChkRempwd.Checked = Rempwd
        If Rempwd Then
            twcUsers.Text = un
            PasswordText.Text = np
        End If

    End Sub
    Private Sub GetUsers()
        Try

            twcUsers.AddItem("admin")

            Dim Q As String, dr As SQLiteDataReader
            Q = "SELECT USER FROM USERS WHERE USER<>'admin'  ORDER BY USER "
            SQCM.CommandText = Q
            dr = SQCM.ExecuteReader
            While dr.Read
                twcUsers.Items.Add(dr(0))
            End While
            dr.Close()
            dr.Dispose()
            twcUsers.SelectedIndex = 0

        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub ChkRempwd_CheckedChanged(sender As Object, e As EventArgs) Handles ChkRempwd.CheckedChanged

    End Sub
End Class
