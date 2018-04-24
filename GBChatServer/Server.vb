'Imports System.Net
'Imports System.Net.Sockets

'Public Class Server

'    Dim TCPServer As Socket
'    Dim TCPListenerz As TcpListener

'    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

'        Dim sendbytes() As Byte = System.Text.Encoding.ASCII.GetBytes(TextBox2.Text)
'        TCPServer.Send(sendbytes)

'    End Sub

'    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

'        TCPListenerz = New TcpListener(IPAddress.Any, 1000)
'        TCPListenerz.Start()
'        TCPServer = TCPListenerz.AcceptSocket()
'        TCPServer.Blocking = False
'        Timer1.Enabled = True

'    End Sub

'    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

'        Try
'            Dim rcvbytes(TCPServer.ReceiveBufferSize) As Byte
'            TCPServer.Receive(rcvbytes)
'            TextBox3.Text = System.Text.Encoding.ASCII.GetString(rcvbytes)
'        Catch ex As Exception
'        End Try

'    End Sub
'End Class