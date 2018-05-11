Imports System.Data.OleDb

Public Class DatabaseHandler

    Dim cn As OleDbConnection
    Dim str As String
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim connstr As String

    Structure UserData
        Public muted As Boolean
        Public nickname As String
    End Structure

    Public Sub New()
        GenerateConnectionString()
    End Sub
    Private Sub GenerateConnectionString()
        connstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + My.Settings.dbfile + "; Persist Security Info=False;"
    End Sub
    Public Function LoadUserData(username As String) As UserData
        Dim ud As UserData
        Try
            cn = New OleDbConnection(connstr)
            cn.Open()
            str = "SELECT * from UserData WHERE username='" + username + "'"
            cmd = New OleDbCommand(str, cn)
            dr = cmd.ExecuteReader
            While dr.Read
                ud.muted = CBool(dr("canspeak"))
                ud.nickname = dr("nickname")
            End While
            Return ud
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
    Friend Function LoadUsers() As String()
        Dim users() As String
        Try
            cn = New OleDbConnection(connstr)
            cn.Open()
            str = "SELECT username FROM UserData"
            cmd = New OleDbCommand(str, cn)
            dr = cmd.ExecuteReader
            While (dr.Read)
                users.Add(dr("username").ToString)
            End While
            Return users
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
End Class
