Imports System.Data
Imports System.Data.OleDb

Public Class UserManager
    Private connstr As String
    Dim cn As OleDbConnection
    Dim str As String
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Private Sub UserManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeStrings()
        GenerateConnectionString()
        LoadUsers()
    End Sub
    Private Sub LoadUserData()
        Try
            cn = New OleDbConnection(connstr)
            cn.Open()
            str = "SELECT * from UserData WHERE username='" + ListBox1.SelectedItem + "'"
            cmd = New OleDbCommand(str, cn)
            dr = cmd.ExecuteReader
            While dr.Read
                MutedChk.Checked = dr("canspeak")
                txtNN.Text = dr("nickname")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub LoadUsers()
        Try
            cn = New OleDbConnection(connstr)
            cn.Open()
            str = "SELECT username FROM UserData"
            cmd = New OleDbCommand(str, cn)
            dr = cmd.ExecuteReader
            While (dr.Read)
                ListBox1.Items.Add(dr("username").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub GenerateConnectionString()
        connstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + My.Settings.dbfile + "; Persist Security Info=False;"
    End Sub
    Private Sub InitializeStrings()
        usersLabel.Text = My.Resources.userslabel + ":"
        MutedChk.Text = My.Resources.muted
        setBtn.Text = My.Resources.setdata
        nnlabel.Text = My.Resources.nnlabel + ":"
        nplabel.Text = My.Resources.nplabel + ":"

    End Sub
    Private Sub SetMuted()
        Try
            cn = New OleDbConnection(connstr)
            cn.Open()
            str = "UPDATE UserData
            SET canspeak=" + MutedChk.Checked.ToString + "
            WHERE username='" + ListBox1.SelectedItem + "';"
            cmd = New OleDbCommand(str, cn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SetNewPassword()
        Try
            cn = New OleDbConnection(connstr)
            cn.Open()
            str = "UPDATE UserData
            SET password=" + txtNP.Text + "
            WHERE username='" + ListBox1.SelectedItem + "';"
            cmd = New OleDbCommand(str, cn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SetNickname()
        Try
            cn = New OleDbConnection(connstr)
            cn.Open()
            str = "UPDATE UserData
            SET nickname='" + txtNN.Text + "'
            WHERE username='" + ListBox1.SelectedItem + "';"
            cmd = New OleDbCommand(str, cn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        LoadUserData()
    End Sub

    Private Sub MutedChk_CheckedChanged(sender As Object, e As EventArgs) Handles MutedChk.CheckedChanged
        setBtn.Enabled = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNN.TextChanged
        setBtn.Enabled = True
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtNP.TextChanged
        setBtn.Enabled = True
    End Sub

    Private Sub setBtn_Click(sender As Object, e As EventArgs) Handles setBtn.Click
        SetMuted()
        If Not txtNP.Text = Nothing Then
            SetNewPassword()
        End If
        SetNickname()
        setBtn.Enabled = False
    End Sub
End Class