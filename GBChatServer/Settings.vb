Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeStrings()
        InitializeValues()
    End Sub
    Private Sub InitializeValues()
        PortSetter.Value = My.Settings.port
        txtUsername.Text = My.Settings.username
    End Sub
    Private Sub InitializeStrings()
        btnOK.Text = My.Resources.OK
        btnCancel.Text = My.Resources.Cancel
        btnApply.Text = My.Resources.Apply
        Label1.Text = My.Resources.ServerPort + ":"
        Label2.Text = My.Resources.Username + ":"
    End Sub
    Private Sub ApplySettings()

    End Sub
    'Events
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ApplySettings()
        Close()
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        ApplySettings()
    End Sub
End Class