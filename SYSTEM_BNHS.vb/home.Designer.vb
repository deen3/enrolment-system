<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.gbMenu = New System.Windows.Forms.GroupBox
        Me.btnGrades = New System.Windows.Forms.Button
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.btnPreReg = New System.Windows.Forms.Button
        Me.btnEnrolment = New System.Windows.Forms.Button
        Me.btnHome = New System.Windows.Forms.Button
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblUser = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.gbTimeDate = New System.Windows.Forms.GroupBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.USERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ACCOUNTSETTINGSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.gbContent = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblLoginTime = New System.Windows.Forms.Label
        Me.btnAddUser = New System.Windows.Forms.Button
        Me.btnDeleteUser = New System.Windows.Forms.Button
        Me.btnEditUser = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblDesignation = New System.Windows.Forms.Label
        Me.lblPosition = New System.Windows.Forms.Label
        Me.lblGender = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.gbMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTimeDate.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.gbContent.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbMenu
        '
        Me.gbMenu.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.templatemo_left_bg
        Me.gbMenu.Controls.Add(Me.btnGrades)
        Me.gbMenu.Controls.Add(Me.MonthCalendar1)
        Me.gbMenu.Controls.Add(Me.btnPreReg)
        Me.gbMenu.Controls.Add(Me.btnEnrolment)
        Me.gbMenu.Controls.Add(Me.btnHome)
        Me.gbMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbMenu.Location = New System.Drawing.Point(9, 176)
        Me.gbMenu.Name = "gbMenu"
        Me.gbMenu.Size = New System.Drawing.Size(239, 487)
        Me.gbMenu.TabIndex = 45
        Me.gbMenu.TabStop = False
        '
        'btnGrades
        '
        Me.btnGrades.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.button
        Me.btnGrades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGrades.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrades.ForeColor = System.Drawing.Color.White
        Me.btnGrades.Location = New System.Drawing.Point(15, 193)
        Me.btnGrades.Name = "btnGrades"
        Me.btnGrades.Size = New System.Drawing.Size(208, 48)
        Me.btnGrades.TabIndex = 4
        Me.btnGrades.Text = "GRADES"
        Me.btnGrades.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(6, 268)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 3
        '
        'btnPreReg
        '
        Me.btnPreReg.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.button
        Me.btnPreReg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPreReg.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreReg.ForeColor = System.Drawing.Color.White
        Me.btnPreReg.Location = New System.Drawing.Point(15, 85)
        Me.btnPreReg.Name = "btnPreReg"
        Me.btnPreReg.Size = New System.Drawing.Size(208, 48)
        Me.btnPreReg.TabIndex = 2
        Me.btnPreReg.Text = "      PRE-REGISTRATION"
        Me.btnPreReg.UseVisualStyleBackColor = True
        '
        'btnEnrolment
        '
        Me.btnEnrolment.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.button
        Me.btnEnrolment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnrolment.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnrolment.ForeColor = System.Drawing.Color.White
        Me.btnEnrolment.Location = New System.Drawing.Point(15, 139)
        Me.btnEnrolment.Name = "btnEnrolment"
        Me.btnEnrolment.Size = New System.Drawing.Size(208, 48)
        Me.btnEnrolment.TabIndex = 1
        Me.btnEnrolment.Text = "    ENROLMENT"
        Me.btnEnrolment.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.button_active
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Location = New System.Drawing.Point(15, 31)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(208, 48)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "HOME"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Location = New System.Drawing.Point(45, 362)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(484, 119)
        Me.RichTextBox2.TabIndex = 44
        Me.RichTextBox2.Text = resources.GetString("RichTextBox2.Text")
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(45, 276)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(484, 55)
        Me.RichTextBox1.TabIndex = 43
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.header_logo
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(-4, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(959, 129)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label2.Location = New System.Drawing.Point(6, 334)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 25)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "MISSION"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.MintCream
        Me.lblUser.Location = New System.Drawing.Point(847, 315)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(48, 24)
        Me.lblUser.TabIndex = 47
        Me.lblUser.Text = "User"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label1.Location = New System.Drawing.Point(6, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 25)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "VISION"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.user
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(804, 178)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(136, 131)
        Me.PictureBox2.TabIndex = 46
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.BNHS
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(535, 238)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 40
        Me.PictureBox3.TabStop = False
        '
        'gbTimeDate
        '
        Me.gbTimeDate.BackColor = System.Drawing.Color.LightBlue
        Me.gbTimeDate.Controls.Add(Me.MenuStrip1)
        Me.gbTimeDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbTimeDate.Location = New System.Drawing.Point(-4, 138)
        Me.gbTimeDate.Name = "gbTimeDate"
        Me.gbTimeDate.Size = New System.Drawing.Size(961, 32)
        Me.gbTimeDate.TabIndex = 44
        Me.gbTimeDate.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("MerriamRegular", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.USERToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(28, 7)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(161, 26)
        Me.MenuStrip1.TabIndex = 47
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'USERToolStripMenuItem
        '
        Me.USERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ACCOUNTSETTINGSToolStripMenuItem, Me.LOGOUTToolStripMenuItem})
        Me.USERToolStripMenuItem.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USERToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.USERToolStripMenuItem.Name = "USERToolStripMenuItem"
        Me.USERToolStripMenuItem.Size = New System.Drawing.Size(61, 22)
        Me.USERToolStripMenuItem.Text = "USER"
        '
        'ACCOUNTSETTINGSToolStripMenuItem
        '
        Me.ACCOUNTSETTINGSToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.ACCOUNTSETTINGSToolStripMenuItem.Name = "ACCOUNTSETTINGSToolStripMenuItem"
        Me.ACCOUNTSETTINGSToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.ACCOUNTSETTINGSToolStripMenuItem.Text = "ACCOUNT SETTINGS"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.LOGOUTToolStripMenuItem.Text = "LOGOUT"
        '
        'gbContent
        '
        Me.gbContent.BackColor = System.Drawing.Color.White
        Me.gbContent.Controls.Add(Me.RichTextBox2)
        Me.gbContent.Controls.Add(Me.RichTextBox1)
        Me.gbContent.Controls.Add(Me.Label2)
        Me.gbContent.Controls.Add(Me.Label1)
        Me.gbContent.Controls.Add(Me.PictureBox3)
        Me.gbContent.Controls.Add(Me.GroupBox1)
        Me.gbContent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbContent.Location = New System.Drawing.Point(257, 177)
        Me.gbContent.Name = "gbContent"
        Me.gbContent.Size = New System.Drawing.Size(535, 487)
        Me.gbContent.TabIndex = 42
        Me.gbContent.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(541, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(142, 487)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'lblLoginTime
        '
        Me.lblLoginTime.AutoSize = True
        Me.lblLoginTime.BackColor = System.Drawing.Color.Transparent
        Me.lblLoginTime.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginTime.ForeColor = System.Drawing.Color.MintCream
        Me.lblLoginTime.Location = New System.Drawing.Point(792, 338)
        Me.lblLoginTime.Name = "lblLoginTime"
        Me.lblLoginTime.Size = New System.Drawing.Size(89, 18)
        Me.lblLoginTime.TabIndex = 48
        Me.lblLoginTime.Text = "Login Time:"
        Me.lblLoginTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnAddUser
        '
        Me.btnAddUser.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.button_plain
        Me.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddUser.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.ForeColor = System.Drawing.Color.White
        Me.btnAddUser.Location = New System.Drawing.Point(806, 526)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(134, 36)
        Me.btnAddUser.TabIndex = 49
        Me.btnAddUser.Text = "ADD USER"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.button_plain
        Me.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeleteUser.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteUser.ForeColor = System.Drawing.Color.White
        Me.btnDeleteUser.Location = New System.Drawing.Point(806, 627)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(134, 36)
        Me.btnDeleteUser.TabIndex = 50
        Me.btnDeleteUser.Text = "DELETE USER"
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'btnEditUser
        '
        Me.btnEditUser.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.button_plain
        Me.btnEditUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEditUser.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditUser.ForeColor = System.Drawing.Color.White
        Me.btnEditUser.Location = New System.Drawing.Point(806, 573)
        Me.btnEditUser.Name = "btnEditUser"
        Me.btnEditUser.Size = New System.Drawing.Size(134, 36)
        Me.btnEditUser.TabIndex = 51
        Me.btnEditUser.Text = "EDIT USER"
        Me.btnEditUser.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lblDesignation)
        Me.GroupBox2.Controls.Add(Me.lblPosition)
        Me.GroupBox2.Controls.Add(Me.lblGender)
        Me.GroupBox2.Controls.Add(Me.lblName)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.GroupBox2.Location = New System.Drawing.Point(804, 369)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(136, 143)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "User Info:"
        '
        'lblDesignation
        '
        Me.lblDesignation.AutoSize = True
        Me.lblDesignation.BackColor = System.Drawing.Color.Transparent
        Me.lblDesignation.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesignation.ForeColor = System.Drawing.Color.MintCream
        Me.lblDesignation.Location = New System.Drawing.Point(1, 111)
        Me.lblDesignation.Name = "lblDesignation"
        Me.lblDesignation.Size = New System.Drawing.Size(68, 15)
        Me.lblDesignation.TabIndex = 56
        Me.lblDesignation.Text = "Designation:"
        Me.lblDesignation.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.BackColor = System.Drawing.Color.Transparent
        Me.lblPosition.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.ForeColor = System.Drawing.Color.MintCream
        Me.lblPosition.Location = New System.Drawing.Point(1, 83)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(77, 15)
        Me.lblPosition.TabIndex = 55
        Me.lblPosition.Text = "Position Title:"
        Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.MintCream
        Me.lblGender.Location = New System.Drawing.Point(1, 55)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(45, 15)
        Me.lblGender.TabIndex = 54
        Me.lblGender.Text = "Gender:"
        Me.lblGender.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.MintCream
        Me.lblName.Location = New System.Drawing.Point(1, 26)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 15)
        Me.lblName.TabIndex = 53
        Me.lblName.Text = "Name:"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.templatemo_left_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(952, 677)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnEditUser)
        Me.Controls.Add(Me.btnDeleteUser)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.gbMenu)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.gbTimeDate)
        Me.Controls.Add(Me.gbContent)
        Me.Controls.Add(Me.lblLoginTime)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gbMenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTimeDate.ResumeLayout(False)
        Me.gbTimeDate.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbContent.ResumeLayout(False)
        Me.gbContent.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbMenu As System.Windows.Forms.GroupBox
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnPreReg As System.Windows.Forms.Button
    Friend WithEvents btnEnrolment As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents gbTimeDate As System.Windows.Forms.GroupBox
    Friend WithEvents gbContent As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblLoginTime As System.Windows.Forms.Label
    Friend WithEvents btnAddUser As System.Windows.Forms.Button
    Friend WithEvents btnDeleteUser As System.Windows.Forms.Button
    Friend WithEvents btnEditUser As System.Windows.Forms.Button
    Friend WithEvents btnGrades As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDesignation As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents USERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ACCOUNTSETTINGSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
