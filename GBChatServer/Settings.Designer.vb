<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PortSetter = New System.Windows.Forms.NumericUpDown()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.sdb = New System.Windows.Forms.Label()
        Me.txtDB = New System.Windows.Forms.TextBox()
        Me.browseDataBase = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.logloc = New System.Windows.Forms.Label()
        Me.browseLog = New System.Windows.Forms.Button()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.PortSetter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server Port:"
        '
        'PortSetter
        '
        Me.PortSetter.Location = New System.Drawing.Point(116, 35)
        Me.PortSetter.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.PortSetter.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PortSetter.Name = "PortSetter"
        Me.PortSetter.Size = New System.Drawing.Size(51, 20)
        Me.PortSetter.TabIndex = 1
        Me.PortSetter.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApply.Enabled = False
        Me.btnApply.Location = New System.Drawing.Point(197, 226)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 2
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(116, 226)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(35, 226)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'sdb
        '
        Me.sdb.AutoSize = True
        Me.sdb.Location = New System.Drawing.Point(12, 91)
        Me.sdb.Name = "sdb"
        Me.sdb.Size = New System.Drawing.Size(75, 13)
        Me.sdb.TabIndex = 5
        Me.sdb.Text = "Database File:"
        '
        'txtDB
        '
        Me.txtDB.Location = New System.Drawing.Point(12, 116)
        Me.txtDB.Name = "txtDB"
        Me.txtDB.Size = New System.Drawing.Size(179, 20)
        Me.txtDB.TabIndex = 6
        '
        'browseDataBase
        '
        Me.browseDataBase.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.browseDataBase.Location = New System.Drawing.Point(197, 114)
        Me.browseDataBase.Name = "browseDataBase"
        Me.browseDataBase.Size = New System.Drawing.Size(75, 23)
        Me.browseDataBase.TabIndex = 7
        Me.browseDataBase.Text = "Browse"
        Me.browseDataBase.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "database.mdb"
        Me.OpenFileDialog1.Filter = "Access Database Files (*.mdb, *.accdb)|*.mdb;*.accdb"
        '
        'logloc
        '
        Me.logloc.AutoSize = True
        Me.logloc.Location = New System.Drawing.Point(12, 148)
        Me.logloc.Name = "logloc"
        Me.logloc.Size = New System.Drawing.Size(72, 13)
        Me.logloc.TabIndex = 8
        Me.logloc.Text = "Log Location:"
        '
        'browseLog
        '
        Me.browseLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.browseLog.Location = New System.Drawing.Point(197, 168)
        Me.browseLog.Name = "browseLog"
        Me.browseLog.Size = New System.Drawing.Size(75, 23)
        Me.browseLog.TabIndex = 10
        Me.browseLog.Text = "Browse"
        Me.browseLog.UseVisualStyleBackColor = True
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(12, 170)
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(179, 20)
        Me.txtLog.TabIndex = 9
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.browseLog)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.logloc)
        Me.Controls.Add(Me.browseDataBase)
        Me.Controls.Add(Me.txtDB)
        Me.Controls.Add(Me.sdb)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.PortSetter)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Settings"
        Me.Text = "Settings"
        CType(Me.PortSetter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PortSetter As NumericUpDown
    Friend WithEvents btnApply As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents sdb As Label
    Friend WithEvents txtDB As TextBox
    Friend WithEvents browseDataBase As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents logloc As Label
    Friend WithEvents browseLog As Button
    Friend WithEvents txtLog As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
