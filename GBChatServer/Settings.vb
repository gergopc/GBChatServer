Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeStrings()
        InitializeValues()
    End Sub
    Private Sub InitializeValues()
        PortSetter.Value = My.Settings.port
        txtDB.Text = My.Settings.dbfile
        txtLog.Text = My.Settings.LogFile
    End Sub
    Private Sub InitializeStrings()
        btnOK.Text = My.Resources.OK
        btnCancel.Text = My.Resources.Cancel
        btnApply.Text = My.Resources.Apply
        Label1.Text = My.Resources.ServerPort + ":"
        sdb.Text = My.Resources.SelectDatabase + ":"
        browseDataBase.Text = My.Resources.Browse
        browseLog.Text = My.Resources.Browse
        logloc.Text = My.Resources.LogLoc + ":"
    End Sub
    Private Sub ApplySettings()
        My.Settings.dbfile = txtDB.Text
        My.Settings.port = PortSetter.Value
        My.Settings.LogFile = txtLog.Text
        My.Settings.Save()
    End Sub
    'Events
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ApplySettings()
        Close()
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        ApplySettings()
        btnApply.Enabled = False
    End Sub

    Private Sub browseDataBase_Click(sender As Object, e As EventArgs) Handles browseDataBase.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        txtDB.Text = OpenFileDialog1.FileName
        btnApply.Enabled = True
    End Sub

    Private Sub browseLog_Click(sender As Object, e As EventArgs) Handles browseLog.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            txtLog.Text = FolderBrowserDialog1.SelectedPath
            btnApply.Enabled = True
        End If
    End Sub

    Private Sub PortSetter_ValueChanged(sender As Object, e As EventArgs) Handles PortSetter.ValueChanged
        btnApply.Enabled = True
    End Sub
End Class