Imports System.Data
Imports System.Data.OleDb

Public Class UserManager
    Private connstr As String
    Dim cn As OleDbConnection
    Dim str As String
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader

    Dim dbHandler As DatabaseHandler

    Private Sub UserManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeStrings()
        dbHandler = New DatabaseHandler
        GenerateConnectionString()
        ListBox1.Items.AddRange(dbHandler.LoadUsers)
        ListBox1.SelectedItem = ListBox1.Items(0)
    End Sub

    Private Sub InitializeStrings()
        usersLabel.Text = My.Resources.userslabel + ":"
        MutedChk.Text = My.Resources.muted
        setBtn.Text = My.Resources.setdata
        nnlabel.Text = My.Resources.nnlabel + ":"
        nplabel.Text = My.Resources.nplabel + ":"

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        LoadUserData()
        txtNP.Clear()
    End Sub

    Private Sub LoadUserData()
        MutedChk.Checked = dbHandler.LoadUserData(ListBox1.SelectedItem).muted
        txtNN.Text = dbHandler.LoadUserData(ListBox1.SelectedItem).nickname
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
        dbHandler.SetUserProperty(ListBox1.SelectedItem, "canspeak", MutedChk.Checked.ToString)
        If Not txtNP.Text = Nothing Then
            dbHandler.SetUserProperty(ListBox1.SelectedItem, "lpassword", txtNP.Text)
        End If
        dbHandler.SetUserProperty(ListBox1.SelectedItem, "nickname", txtNN.Text)
        'MsgBox(ListBox1.SelectedItem + " nickname " + txtNN.Text)
        setBtn.Enabled = False
    End Sub
End Class