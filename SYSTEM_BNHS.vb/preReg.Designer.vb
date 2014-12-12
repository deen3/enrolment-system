<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class preReg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(preReg))
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.cboMonthBday = New System.Windows.Forms.ComboBox
        Me.btnEnrolment = New System.Windows.Forms.Button
        Me.cboYearBday = New System.Windows.Forms.ComboBox
        Me.nudDayBday = New System.Windows.Forms.NumericUpDown
        Me.cboGender = New System.Windows.Forms.ComboBox
        Me.txtContact = New System.Windows.Forms.TextBox
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.txtProvinceAddress = New System.Windows.Forms.TextBox
        Me.gbMenu = New System.Windows.Forms.GroupBox
        Me.btnGrades = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnHome = New System.Windows.Forms.Button
        Me.gbTimeDate = New System.Windows.Forms.GroupBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.USERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ACCOUNTSETTINGSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.txtCityAddress = New System.Windows.Forms.TextBox
        Me.txtBgyAddress = New System.Windows.Forms.TextBox
        Me.txtAge = New System.Windows.Forms.TextBox
        Me.txtMiddleName = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.btnPreReg = New System.Windows.Forms.GroupBox
        Me.btnEditStudentsInfo = New System.Windows.Forms.Button
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.nudDayBday, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMenu.SuspendLayout()
        Me.gbTimeDate.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.btnPreReg.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.button_plain
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(186, 440)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(146, 36)
        Me.btnSave.TabIndex = 30
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.button_plain
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(360, 440)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(146, 36)
        Me.btnCancel.TabIndex = 29
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cboMonthBday
        '
        Me.cboMonthBday.FormattingEnabled = True
        Me.cboMonthBday.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboMonthBday.Location = New System.Drawing.Point(196, 232)
        Me.cboMonthBday.Name = "cboMonthBday"
        Me.cboMonthBday.Size = New System.Drawing.Size(126, 21)
        Me.cboMonthBday.TabIndex = 25
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
        'cboYearBday
        '
        Me.cboYearBday.FormattingEnabled = True
        Me.cboYearBday.Items.AddRange(New Object() {"2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990"})
        Me.cboYearBday.Location = New System.Drawing.Point(426, 232)
        Me.cboYearBday.Name = "cboYearBday"
        Me.cboYearBday.Size = New System.Drawing.Size(126, 21)
        Me.cboYearBday.TabIndex = 26
        '
        'nudDayBday
        '
        Me.nudDayBday.Location = New System.Drawing.Point(340, 233)
        Me.nudDayBday.Name = "nudDayBday"
        Me.nudDayBday.Size = New System.Drawing.Size(72, 20)
        Me.nudDayBday.TabIndex = 24
        '
        'cboGender
        '
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(196, 202)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(126, 21)
        Me.cboGender.TabIndex = 23
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(196, 339)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(126, 20)
        Me.txtContact.TabIndex = 22
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(6, 268)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 3
        '
        'txtProvinceAddress
        '
        Me.txtProvinceAddress.Location = New System.Drawing.Point(482, 308)
        Me.txtProvinceAddress.Name = "txtProvinceAddress"
        Me.txtProvinceAddress.Size = New System.Drawing.Size(126, 20)
        Me.txtProvinceAddress.TabIndex = 21
        '
        'gbMenu
        '
        Me.gbMenu.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.templatemo_left_bg
        Me.gbMenu.Controls.Add(Me.btnGrades)
        Me.gbMenu.Controls.Add(Me.MonthCalendar1)
        Me.gbMenu.Controls.Add(Me.Button2)
        Me.gbMenu.Controls.Add(Me.btnEnrolment)
        Me.gbMenu.Controls.Add(Me.btnHome)
        Me.gbMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbMenu.Location = New System.Drawing.Point(9, 176)
        Me.gbMenu.Name = "gbMenu"
        Me.gbMenu.Size = New System.Drawing.Size(239, 487)
        Me.gbMenu.TabIndex = 38
        Me.gbMenu.TabStop = False
        '
        'btnGrades
        '
        Me.btnGrades.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.button
        Me.btnGrades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGrades.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrades.ForeColor = System.Drawing.Color.White
        Me.btnGrades.Location = New System.Drawing.Point(15, 194)
        Me.btnGrades.Name = "btnGrades"
        Me.btnGrades.Size = New System.Drawing.Size(208, 48)
        Me.btnGrades.TabIndex = 39
        Me.btnGrades.Text = "GRADES"
        Me.btnGrades.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.button_active
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(15, 85)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(208, 48)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "      PRE-REGISTRATION"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.button
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
        'gbTimeDate
        '
        Me.gbTimeDate.BackColor = System.Drawing.Color.LightBlue
        Me.gbTimeDate.Controls.Add(Me.MenuStrip1)
        Me.gbTimeDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbTimeDate.Location = New System.Drawing.Point(-4, 138)
        Me.gbTimeDate.Name = "gbTimeDate"
        Me.gbTimeDate.Size = New System.Drawing.Size(961, 32)
        Me.gbTimeDate.TabIndex = 37
        Me.gbTimeDate.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("MerriamRegular", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.USERToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(28, 3)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(69, 26)
        Me.MenuStrip1.TabIndex = 48
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
        'txtCityAddress
        '
        Me.txtCityAddress.Location = New System.Drawing.Point(337, 308)
        Me.txtCityAddress.Name = "txtCityAddress"
        Me.txtCityAddress.Size = New System.Drawing.Size(126, 20)
        Me.txtCityAddress.TabIndex = 20
        '
        'txtBgyAddress
        '
        Me.txtBgyAddress.Location = New System.Drawing.Point(196, 308)
        Me.txtBgyAddress.Name = "txtBgyAddress"
        Me.txtBgyAddress.Size = New System.Drawing.Size(126, 20)
        Me.txtBgyAddress.TabIndex = 19
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(258, 262)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(64, 20)
        Me.txtAge.TabIndex = 18
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(196, 157)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(227, 20)
        Me.txtMiddleName.TabIndex = 17
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(196, 127)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(227, 20)
        Me.txtFirstName.TabIndex = 16
        '
        'btnPreReg
        '
        Me.btnPreReg.BackColor = System.Drawing.Color.White
        Me.btnPreReg.Controls.Add(Me.btnEditStudentsInfo)
        Me.btnPreReg.Controls.Add(Me.btnSave)
        Me.btnPreReg.Controls.Add(Me.btnCancel)
        Me.btnPreReg.Controls.Add(Me.cboYearBday)
        Me.btnPreReg.Controls.Add(Me.cboMonthBday)
        Me.btnPreReg.Controls.Add(Me.nudDayBday)
        Me.btnPreReg.Controls.Add(Me.cboGender)
        Me.btnPreReg.Controls.Add(Me.txtContact)
        Me.btnPreReg.Controls.Add(Me.txtProvinceAddress)
        Me.btnPreReg.Controls.Add(Me.txtCityAddress)
        Me.btnPreReg.Controls.Add(Me.txtBgyAddress)
        Me.btnPreReg.Controls.Add(Me.txtAge)
        Me.btnPreReg.Controls.Add(Me.txtMiddleName)
        Me.btnPreReg.Controls.Add(Me.txtFirstName)
        Me.btnPreReg.Controls.Add(Me.txtLastName)
        Me.btnPreReg.Controls.Add(Me.Label9)
        Me.btnPreReg.Controls.Add(Me.Label8)
        Me.btnPreReg.Controls.Add(Me.Label7)
        Me.btnPreReg.Controls.Add(Me.Label6)
        Me.btnPreReg.Controls.Add(Me.Label5)
        Me.btnPreReg.Controls.Add(Me.Label3)
        Me.btnPreReg.Controls.Add(Me.Label2)
        Me.btnPreReg.Controls.Add(Me.Label4)
        Me.btnPreReg.Controls.Add(Me.Label1)
        Me.btnPreReg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPreReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPreReg.Location = New System.Drawing.Point(257, 176)
        Me.btnPreReg.Name = "btnPreReg"
        Me.btnPreReg.Size = New System.Drawing.Size(686, 487)
        Me.btnPreReg.TabIndex = 35
        Me.btnPreReg.TabStop = False
        '
        'btnEditStudentsInfo
        '
        Me.btnEditStudentsInfo.BackColor = System.Drawing.Color.Transparent
        Me.btnEditStudentsInfo.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.button_plain
        Me.btnEditStudentsInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditStudentsInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEditStudentsInfo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditStudentsInfo.ForeColor = System.Drawing.Color.White
        Me.btnEditStudentsInfo.Location = New System.Drawing.Point(467, 19)
        Me.btnEditStudentsInfo.Name = "btnEditStudentsInfo"
        Me.btnEditStudentsInfo.Size = New System.Drawing.Size(203, 39)
        Me.btnEditStudentsInfo.TabIndex = 42
        Me.btnEditStudentsInfo.Text = "EDIT STUDENT'S INFO"
        Me.btnEditStudentsInfo.UseVisualStyleBackColor = False
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(196, 98)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(227, 20)
        Me.txtLastName.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(55, 308)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 21)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "*Address:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(54, 339)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 21)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Contact No:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(57, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 21)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "*First Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(56, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Middle Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "*Gender:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(197, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Age:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "*Birthday:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "*Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PRIMARY INFORMATION"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.header_logo
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(-4, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(959, 129)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'preReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.templatemo_left_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(952, 677)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gbMenu)
        Me.Controls.Add(Me.gbTimeDate)
        Me.Controls.Add(Me.btnPreReg)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "preReg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.nudDayBday, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMenu.ResumeLayout(False)
        Me.gbTimeDate.ResumeLayout(False)
        Me.gbTimeDate.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.btnPreReg.ResumeLayout(False)
        Me.btnPreReg.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cboMonthBday As System.Windows.Forms.ComboBox
    Friend WithEvents btnEnrolment As System.Windows.Forms.Button
    Friend WithEvents cboYearBday As System.Windows.Forms.ComboBox
    Friend WithEvents nudDayBday As System.Windows.Forms.NumericUpDown
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents txtProvinceAddress As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents gbMenu As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents gbTimeDate As System.Windows.Forms.GroupBox
    Friend WithEvents txtCityAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtBgyAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents btnPreReg As System.Windows.Forms.GroupBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEditStudentsInfo As System.Windows.Forms.Button
    Friend WithEvents btnGrades As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents USERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ACCOUNTSETTINGSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
