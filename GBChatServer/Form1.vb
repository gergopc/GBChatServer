Imports System.Net
Imports System.Net.Sockets

Public Class Form1

    Dim server As Server

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeStrings()
        server = New Server
    End Sub

    Private Sub InitializeStrings()
        sendBroadcast.Text = My.Resources.SendBroadcast
    End Sub

    Private Sub sendBroadcast_Click(sender As Object, e As EventArgs) Handles sendBroadcast.Click

    End Sub

    Private Sub SaveLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveLogToolStripMenuItem.Click
        server.SaveLog()
    End Sub

    Private Sub UserManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserManagerToolStripMenuItem.Click
        UserManager.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox.Text = server.GetLog
    End Sub
End Class