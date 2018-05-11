Public Class Server

    Dim serverlog As String

    Friend Sub New()

    End Sub
    Friend Sub Log(v As String, Optional title As String = "Server")
        serverlog += Date.Now + title + ": " + v + "\n"
    End Sub
    Friend Sub SaveLog()
        Try
            Dim file As String = My.Settings.LogFile + "\log - " + Date.Now.ToString("yyyy-MM-dd HH-mm") + ".txt"
            MsgBox(file)
            Dim fs As IO.FileStream = IO.File.Create(file)
            Dim log As Byte() = New Text.UTF8Encoding(True).GetBytes(serverlog)
            fs.Write(log, 0, log.Length)
            fs.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Friend Function GetLog()
        Return serverlog
    End Function
End Class

