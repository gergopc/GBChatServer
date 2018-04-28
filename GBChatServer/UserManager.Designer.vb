<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.usersLabel = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.MutedChk = New System.Windows.Forms.CheckBox()
        Me.txtNN = New System.Windows.Forms.TextBox()
        Me.txtNP = New System.Windows.Forms.TextBox()
        Me.setBtn = New System.Windows.Forms.Button()
        Me.nnlabel = New System.Windows.Forms.Label()
        Me.nplabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'usersLabel
        '
        Me.usersLabel.AutoSize = True
        Me.usersLabel.Location = New System.Drawing.Point(12, 9)
        Me.usersLabel.Name = "usersLabel"
        Me.usersLabel.Size = New System.Drawing.Size(34, 13)
        Me.usersLabel.TabIndex = 1
        Me.usersLabel.Text = "Users"
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 25)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 303)
        Me.ListBox1.TabIndex = 2
        '
        'MutedChk
        '
        Me.MutedChk.AutoSize = True
        Me.MutedChk.Location = New System.Drawing.Point(138, 25)
        Me.MutedChk.Name = "MutedChk"
        Me.MutedChk.Size = New System.Drawing.Size(55, 17)
        Me.MutedChk.TabIndex = 4
        Me.MutedChk.Text = "muted"
        Me.MutedChk.UseVisualStyleBackColor = True
        '
        'txtNN
        '
        Me.txtNN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNN.Location = New System.Drawing.Point(253, 48)
        Me.txtNN.Name = "txtNN"
        Me.txtNN.Size = New System.Drawing.Size(100, 20)
        Me.txtNN.TabIndex = 5
        '
        'txtNP
        '
        Me.txtNP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNP.Location = New System.Drawing.Point(253, 74)
        Me.txtNP.Name = "txtNP"
        Me.txtNP.Size = New System.Drawing.Size(100, 20)
        Me.txtNP.TabIndex = 6
        '
        'setBtn
        '
        Me.setBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.setBtn.Enabled = False
        Me.setBtn.Location = New System.Drawing.Point(278, 305)
        Me.setBtn.Name = "setBtn"
        Me.setBtn.Size = New System.Drawing.Size(75, 23)
        Me.setBtn.TabIndex = 7
        Me.setBtn.Text = "Set"
        Me.setBtn.UseVisualStyleBackColor = True
        '
        'nnlabel
        '
        Me.nnlabel.AutoSize = True
        Me.nnlabel.Location = New System.Drawing.Point(138, 51)
        Me.nnlabel.Name = "nnlabel"
        Me.nnlabel.Size = New System.Drawing.Size(53, 13)
        Me.nnlabel.TabIndex = 8
        Me.nnlabel.Text = "nickname"
        '
        'nplabel
        '
        Me.nplabel.AutoSize = True
        Me.nplabel.Location = New System.Drawing.Point(138, 77)
        Me.nplabel.Name = "nplabel"
        Me.nplabel.Size = New System.Drawing.Size(75, 13)
        Me.nplabel.TabIndex = 9
        Me.nplabel.Text = "new password"
        '
        'UserManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 344)
        Me.Controls.Add(Me.nplabel)
        Me.Controls.Add(Me.nnlabel)
        Me.Controls.Add(Me.setBtn)
        Me.Controls.Add(Me.txtNP)
        Me.Controls.Add(Me.txtNN)
        Me.Controls.Add(Me.MutedChk)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.usersLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "UserManager"
        Me.Text = "UserManager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents usersLabel As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents MutedChk As CheckBox
    Friend WithEvents txtNN As TextBox
    Friend WithEvents txtNP As TextBox
    Friend WithEvents setBtn As Button
    Friend WithEvents nnlabel As Label
    Friend WithEvents nplabel As Label
End Class
