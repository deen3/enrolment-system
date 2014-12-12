<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userAccount
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
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.lnkChangeUsername = New System.Windows.Forms.LinkLabel
        Me.lnkChangePassword = New System.Windows.Forms.LinkLabel
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(23, 168)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ReadOnly = True
        Me.txtPassword.Size = New System.Drawing.Size(227, 20)
        Me.txtPassword.TabIndex = 72
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(23, 96)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.Size = New System.Drawing.Size(227, 20)
        Me.txtUsername.TabIndex = 71
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.button_plain
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(278, 219)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(164, 28)
        Me.btnCancel.TabIndex = 70
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.button_plain
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(86, 219)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(164, 28)
        Me.btnSave.TabIndex = 69
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.user
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(269, 35)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(185, 178)
        Me.PictureBox2.TabIndex = 75
        Me.PictureBox2.TabStop = False
        '
        'lnkChangeUsername
        '
        Me.lnkChangeUsername.AutoSize = True
        Me.lnkChangeUsername.BackColor = System.Drawing.Color.Transparent
        Me.lnkChangeUsername.Font = New System.Drawing.Font("Modern No. 20", 14.25!)
        Me.lnkChangeUsername.LinkColor = System.Drawing.Color.Cyan
        Me.lnkChangeUsername.Location = New System.Drawing.Point(62, 72)
        Me.lnkChangeUsername.Name = "lnkChangeUsername"
        Me.lnkChangeUsername.Size = New System.Drawing.Size(147, 21)
        Me.lnkChangeUsername.TabIndex = 76
        Me.lnkChangeUsername.TabStop = True
        Me.lnkChangeUsername.Text = "Change Username"
        Me.lnkChangeUsername.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'lnkChangePassword
        '
        Me.lnkChangePassword.AutoSize = True
        Me.lnkChangePassword.BackColor = System.Drawing.Color.Transparent
        Me.lnkChangePassword.Font = New System.Drawing.Font("Modern No. 20", 14.25!)
        Me.lnkChangePassword.LinkColor = System.Drawing.Color.Cyan
        Me.lnkChangePassword.Location = New System.Drawing.Point(62, 144)
        Me.lnkChangePassword.Name = "lnkChangePassword"
        Me.lnkChangePassword.Size = New System.Drawing.Size(143, 21)
        Me.lnkChangePassword.TabIndex = 77
        Me.lnkChangePassword.TabStop = True
        Me.lnkChangePassword.Text = "Change Password"
        '
        'userAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.bg11
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(489, 279)
        Me.Controls.Add(Me.lnkChangePassword)
        Me.Controls.Add(Me.lnkChangeUsername)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.DoubleBuffered = True
        Me.Name = "userAccount"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lnkChangeUsername As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkChangePassword As System.Windows.Forms.LinkLabel
End Class
