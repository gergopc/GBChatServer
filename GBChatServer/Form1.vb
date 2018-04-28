Imports System.Net
Imports System.Net.Sockets

Public Class Form1
    Dim connstr As String

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateConnectionString()
        InitializeStrings()
    End Sub

    Private Sub InitializeStrings()
        sendBroadcast.Text = My.Resources.SendBroadcast
    End Sub

    Private Sub GenerateConnectionString()
        connstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + My.Settings.dbfile + "; Persist Security Info=False;"
    End Sub

    Private Sub SaveLog()
        Try
            Dim file As String = My.Settings.LogFile + "\log - " + Date.Now.ToString("yyyy-MM-dd HH-mm") + ".txt"
            MsgBox(file)
            Dim fs As IO.FileStream = IO.File.Create(file)
            Dim log As Byte() = New Text.UTF8Encoding(True).GetBytes(TextBox1.Text)
            fs.Write(log, 0, log.Length)
            fs.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub sendBroadcast_Click(sender As Object, e As EventArgs) Handles sendBroadcast.Click

    End Sub

    Private Sub SaveLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveLogToolStripMenuItem.Click
        SaveLog()
    End Sub

    Private Sub UserManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserManagerToolStripMenuItem.Click
        UserManager.ShowDialog()
    End Sub
End Class