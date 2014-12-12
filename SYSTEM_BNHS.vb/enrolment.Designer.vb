<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class enrolment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(enrolment))
        Me.gbTimeDate = New System.Windows.Forms.GroupBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.USERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ACCOUNTSETTINGSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.btnPreReg = New System.Windows.Forms.Button
        Me.gbMenu = New System.Windows.Forms.GroupBox
        Me.btnGrades = New System.Windows.Forms.Button
        Me.btnEnrolment = New System.Windows.Forms.Button
        Me.btnHome = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.tbc = New System.Windows.Forms.TabControl
        Me.tabEnrol = New System.Windows.Forms.TabPage
        Me.gbContent = New System.Windows.Forms.GroupBox
        Me.cbSy = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtSearchStud = New System.Windows.Forms.TextBox
        Me.txtTotalNumStuds = New System.Windows.Forms.TextBox
        Me.btnSearchEnrol = New System.Windows.Forms.Button
        Me.lblTotalNumStuds = New System.Windows.Forms.Label
        Me.cboYearSection = New System.Windows.Forms.ComboBox
        Me.btnSeachStudSection = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dgvStudSection = New System.Windows.Forms.DataGridView
        Me.txtContact = New System.Windows.Forms.TextBox
        Me.txtGender = New System.Windows.Forms.TextBox
        Me.txtAge = New System.Windows.Forms.TextBox
        Me.txtBday = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.btnEnrol = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.txtGenAverage = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtStudId = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.tabYearSection = New System.Windows.Forms.TabPage
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnPrintPreview = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.txtTotalNumStuds1 = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dgvStudSection1 = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnYearSection = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboYearSection1 = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.pvDialog = New System.Windows.Forms.PrintPreviewDialog
        Me.gbTimeDate.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.gbMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbc.SuspendLayout()
        Me.tabEnrol.SuspendLayout()
        Me.gbContent.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvStudSection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabYearSection.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvStudSection1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.MenuStrip1.Location = New System.Drawing.Point(13, 6)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(69, 26)
        Me.MenuStrip1.TabIndex = 49
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
        Me.gbMenu.TabIndex = 38
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
        Me.btnGrades.TabIndex = 40
        Me.btnGrades.Text = "GRADES"
        Me.btnGrades.UseVisualStyleBackColor = True
        '
        'btnEnrolment
        '
        Me.btnEnrolment.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.button_active
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
        'tbc
        '
        Me.tbc.Controls.Add(Me.tabEnrol)
        Me.tbc.Controls.Add(Me.tabYearSection)
        Me.tbc.Location = New System.Drawing.Point(254, 176)
        Me.tbc.Name = "tbc"
        Me.tbc.SelectedIndex = 0
        Me.tbc.Size = New System.Drawing.Size(686, 487)
        Me.tbc.TabIndex = 39
        '
        'tabEnrol
        '
        Me.tabEnrol.Controls.Add(Me.gbContent)
        Me.tabEnrol.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabEnrol.Location = New System.Drawing.Point(4, 22)
        Me.tabEnrol.Name = "tabEnrol"
        Me.tabEnrol.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEnrol.Size = New System.Drawing.Size(678, 461)
        Me.tabEnrol.TabIndex = 0
        Me.tabEnrol.Text = "Enrol Student"
        Me.tabEnrol.UseVisualStyleBackColor = True
        '
        'gbContent
        '
        Me.gbContent.BackColor = System.Drawing.Color.White
        Me.gbContent.Controls.Add(Me.cbSy)
        Me.gbContent.Controls.Add(Me.Label6)
        Me.gbContent.Controls.Add(Me.txtSearchStud)
        Me.gbContent.Controls.Add(Me.txtTotalNumStuds)
        Me.gbContent.Controls.Add(Me.btnSearchEnrol)
        Me.gbContent.Controls.Add(Me.lblTotalNumStuds)
        Me.gbContent.Controls.Add(Me.cboYearSection)
        Me.gbContent.Controls.Add(Me.btnSeachStudSection)
        Me.gbContent.Controls.Add(Me.GroupBox2)
        Me.gbContent.Controls.Add(Me.txtContact)
        Me.gbContent.Controls.Add(Me.txtGender)
        Me.gbContent.Controls.Add(Me.txtAge)
        Me.gbContent.Controls.Add(Me.txtBday)
        Me.gbContent.Controls.Add(Me.txtAddress)
        Me.gbContent.Controls.Add(Me.btnEnrol)
        Me.gbContent.Controls.Add(Me.btnCancel)
        Me.gbContent.Controls.Add(Me.txtGenAverage)
        Me.gbContent.Controls.Add(Me.txtName)
        Me.gbContent.Controls.Add(Me.txtStudId)
        Me.gbContent.Controls.Add(Me.Label10)
        Me.gbContent.Controls.Add(Me.Label9)
        Me.gbContent.Controls.Add(Me.Label8)
        Me.gbContent.Controls.Add(Me.Label7)
        Me.gbContent.Controls.Add(Me.Label5)
        Me.gbContent.Controls.Add(Me.Label3)
        Me.gbContent.Controls.Add(Me.Label2)
        Me.gbContent.Controls.Add(Me.Label4)
        Me.gbContent.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.gbContent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbContent.Location = New System.Drawing.Point(3, -6)
        Me.gbContent.Name = "gbContent"
        Me.gbContent.Size = New System.Drawing.Size(686, 493)
        Me.gbContent.TabIndex = 12
        Me.gbContent.TabStop = False
        '
        'cbSy
        '
        Me.cbSy.FormattingEnabled = True
        Me.cbSy.Items.AddRange(New Object() {"2012 - 2013", "2013 - 2014", "2014 - 2015", "2015 - 2016", "2016 - 2017", "2017 - 2018", "2018 - 2019", "2019 - 2020", "2020 - 2021"})
        Me.cbSy.Location = New System.Drawing.Point(526, 14)
        Me.cbSy.Name = "cbSy"
        Me.cbSy.Size = New System.Drawing.Size(114, 23)
        Me.cbSy.TabIndex = 50
        Me.cbSy.Text = "School Year"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label6.Location = New System.Drawing.Point(180, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 24)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Search student:"
        '
        'txtSearchStud
        '
        Me.txtSearchStud.Location = New System.Drawing.Point(323, 46)
        Me.txtSearchStud.Name = "txtSearchStud"
        Me.txtSearchStud.Size = New System.Drawing.Size(197, 21)
        Me.txtSearchStud.TabIndex = 38
        Me.txtSearchStud.Text = "student name"
        '
        'txtTotalNumStuds
        '
        Me.txtTotalNumStuds.Location = New System.Drawing.Point(573, 383)
        Me.txtTotalNumStuds.Name = "txtTotalNumStuds"
        Me.txtTotalNumStuds.Size = New System.Drawing.Size(49, 21)
        Me.txtTotalNumStuds.TabIndex = 45
        '
        'btnSearchEnrol
        '
        Me.btnSearchEnrol.BackColor = System.Drawing.Color.Transparent
        Me.btnSearchEnrol.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.button_plain
        Me.btnSearchEnrol.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchEnrol.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchEnrol.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchEnrol.ForeColor = System.Drawing.Color.White
        Me.btnSearchEnrol.Location = New System.Drawing.Point(526, 44)
        Me.btnSearchEnrol.Name = "btnSearchEnrol"
        Me.btnSearchEnrol.Size = New System.Drawing.Size(114, 28)
        Me.btnSearchEnrol.TabIndex = 39
        Me.btnSearchEnrol.Text = "SEARCH"
        Me.btnSearchEnrol.UseVisualStyleBackColor = False
        '
        'lblTotalNumStuds
        '
        Me.lblTotalNumStuds.AutoSize = True
        Me.lblTotalNumStuds.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalNumStuds.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblTotalNumStuds.Location = New System.Drawing.Point(362, 383)
        Me.lblTotalNumStuds.Name = "lblTotalNumStuds"
        Me.lblTotalNumStuds.Size = New System.Drawing.Size(205, 21)
        Me.lblTotalNumStuds.TabIndex = 44
        Me.lblTotalNumStuds.Text = "Total Enrolled Students: "
        '
        'cboYearSection
        '
        Me.cboYearSection.FormattingEnabled = True
        Me.cboYearSection.Items.AddRange(New Object() {"7 - Binet", "7 - Azucena", "7 - Bougainvillea", "7 - Chrysanthemum", "7 - Daffodil", "7 - Everlasting", "7 - Fleur d lis", "7 - Gladiola", "8 - Newton", "8 - Acacia", "8 - Banaba", "8 - Camachili", "8 - Dao", "8 - Evergreen", "III - Herschel", "III - Amethyst", "III - Beryl", "III - Citrine", "III - Diamond", "IV - Socrates", "IV - Amiability", "IV - Bravery", "IV - Charity", "IV - Dependability"})
        Me.cboYearSection.Location = New System.Drawing.Point(323, 84)
        Me.cboYearSection.Name = "cboYearSection"
        Me.cboYearSection.Size = New System.Drawing.Size(197, 23)
        Me.cboYearSection.TabIndex = 43
        '
        'btnSeachStudSection
        '
        Me.btnSeachStudSection.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.button_plain
        Me.btnSeachStudSection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeachStudSection.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSeachStudSection.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeachStudSection.ForeColor = System.Drawing.Color.White
        Me.btnSeachStudSection.Location = New System.Drawing.Point(526, 84)
        Me.btnSeachStudSection.Name = "btnSeachStudSection"
        Me.btnSeachStudSection.Size = New System.Drawing.Size(114, 28)
        Me.btnSeachStudSection.TabIndex = 42
        Me.btnSeachStudSection.Text = "SHOW"
        Me.btnSeachStudSection.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvStudSection)
        Me.GroupBox2.Location = New System.Drawing.Point(300, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(354, 264)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Students Enrolled:"
        '
        'dgvStudSection
        '
        Me.dgvStudSection.BackgroundColor = System.Drawing.Color.LightBlue
        Me.dgvStudSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudSection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvStudSection.Location = New System.Drawing.Point(3, 17)
        Me.dgvStudSection.Name = "dgvStudSection"
        Me.dgvStudSection.Size = New System.Drawing.Size(348, 244)
        Me.dgvStudSection.TabIndex = 0
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.Color.Azure
        Me.txtContact.Location = New System.Drawing.Point(118, 303)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.ReadOnly = True
        Me.txtContact.Size = New System.Drawing.Size(176, 21)
        Me.txtContact.TabIndex = 36
        '
        'txtGender
        '
        Me.txtGender.BackColor = System.Drawing.Color.Azure
        Me.txtGender.Location = New System.Drawing.Point(118, 188)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.ReadOnly = True
        Me.txtGender.Size = New System.Drawing.Size(176, 21)
        Me.txtGender.TabIndex = 35
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.Azure
        Me.txtAge.Location = New System.Drawing.Point(118, 218)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(176, 21)
        Me.txtAge.TabIndex = 34
        '
        'txtBday
        '
        Me.txtBday.BackColor = System.Drawing.Color.Azure
        Me.txtBday.Location = New System.Drawing.Point(118, 246)
        Me.txtBday.Name = "txtBday"
        Me.txtBday.ReadOnly = True
        Me.txtBday.Size = New System.Drawing.Size(176, 21)
        Me.txtBday.TabIndex = 33
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.Azure
        Me.txtAddress.Location = New System.Drawing.Point(118, 275)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(176, 21)
        Me.txtAddress.TabIndex = 32
        '
        'btnEnrol
        '
        Me.btnEnrol.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.button_plain
        Me.btnEnrol.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnrol.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnrol.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnrol.ForeColor = System.Drawing.Color.White
        Me.btnEnrol.Location = New System.Drawing.Point(184, 423)
        Me.btnEnrol.Name = "btnEnrol"
        Me.btnEnrol.Size = New System.Drawing.Size(146, 36)
        Me.btnEnrol.TabIndex = 30
        Me.btnEnrol.Text = "ENROL"
        Me.btnEnrol.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.button_plain
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(358, 423)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(146, 36)
        Me.btnCancel.TabIndex = 29
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtGenAverage
        '
        Me.txtGenAverage.BackColor = System.Drawing.Color.Azure
        Me.txtGenAverage.Location = New System.Drawing.Point(219, 355)
        Me.txtGenAverage.Name = "txtGenAverage"
        Me.txtGenAverage.ReadOnly = True
        Me.txtGenAverage.Size = New System.Drawing.Size(75, 21)
        Me.txtGenAverage.TabIndex = 27
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.Azure
        Me.txtName.Location = New System.Drawing.Point(118, 156)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(176, 21)
        Me.txtName.TabIndex = 16
        '
        'txtStudId
        '
        Me.txtStudId.BackColor = System.Drawing.Color.Azure
        Me.txtStudId.Location = New System.Drawing.Point(118, 127)
        Me.txtStudId.Name = "txtStudId"
        Me.txtStudId.ReadOnly = True
        Me.txtStudId.Size = New System.Drawing.Size(176, 21)
        Me.txtStudId.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(5, 355)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(214, 21)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Gen. Average last S.Y.:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 276)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 21)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Address:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 21)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Contact No:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 21)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Gender:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Age:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 247)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Birthday:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Student Id:"
        '
        'tabYearSection
        '
        Me.tabYearSection.Controls.Add(Me.btnPrint)
        Me.tabYearSection.Controls.Add(Me.btnEdit)
        Me.tabYearSection.Controls.Add(Me.btnPrintPreview)
        Me.tabYearSection.Controls.Add(Me.btnDelete)
        Me.tabYearSection.Controls.Add(Me.txtTotalNumStuds1)
        Me.tabYearSection.Controls.Add(Me.GroupBox3)
        Me.tabYearSection.Controls.Add(Me.GroupBox1)
        Me.tabYearSection.Controls.Add(Me.Label11)
        Me.tabYearSection.Location = New System.Drawing.Point(4, 22)
        Me.tabYearSection.Name = "tabYearSection"
        Me.tabYearSection.Padding = New System.Windows.Forms.Padding(3)
        Me.tabYearSection.Size = New System.Drawing.Size(678, 461)
        Me.tabYearSection.TabIndex = 1
        Me.tabYearSection.Text = "Year/Section"
        Me.tabYearSection.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.printer
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(603, -2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(71, 71)
        Me.btnPrint.TabIndex = 54
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.button_plain
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEdit.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(225, 427)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(212, 28)
        Me.btnEdit.TabIndex = 52
        Me.btnEdit.Text = "CHANGE STUDS' SECTION"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnPrintPreview
        '
        Me.btnPrintPreview.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.Print_preview
        Me.btnPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrintPreview.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintPreview.ForeColor = System.Drawing.Color.White
        Me.btnPrintPreview.Location = New System.Drawing.Point(526, -2)
        Me.btnPrintPreview.Name = "btnPrintPreview"
        Me.btnPrintPreview.Size = New System.Drawing.Size(71, 71)
        Me.btnPrintPreview.TabIndex = 53
        Me.btnPrintPreview.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.button_plain
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(7, 427)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(212, 28)
        Me.btnDelete.TabIndex = 46
        Me.btnDelete.Text = "DELETE A STUDENT"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtTotalNumStuds1
        '
        Me.txtTotalNumStuds1.Location = New System.Drawing.Point(619, 427)
        Me.txtTotalNumStuds1.Name = "txtTotalNumStuds1"
        Me.txtTotalNumStuds1.Size = New System.Drawing.Size(49, 20)
        Me.txtTotalNumStuds1.TabIndex = 47
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvStudSection1)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 63)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(669, 358)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'dgvStudSection1
        '
        Me.dgvStudSection1.BackgroundColor = System.Drawing.Color.LightBlue
        Me.dgvStudSection1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudSection1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvStudSection1.Location = New System.Drawing.Point(3, 16)
        Me.dgvStudSection1.Name = "dgvStudSection1"
        Me.dgvStudSection1.Size = New System.Drawing.Size(663, 339)
        Me.dgvStudSection1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnYearSection)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboYearSection1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 57)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnYearSection
        '
        Me.btnYearSection.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.button_plain
        Me.btnYearSection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnYearSection.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnYearSection.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYearSection.ForeColor = System.Drawing.Color.White
        Me.btnYearSection.Location = New System.Drawing.Point(279, 16)
        Me.btnYearSection.Name = "btnYearSection"
        Me.btnYearSection.Size = New System.Drawing.Size(91, 28)
        Me.btnYearSection.TabIndex = 55
        Me.btnYearSection.Text = "SHOW"
        Me.btnYearSection.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label1.Location = New System.Drawing.Point(1, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 18)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Select section:"
        '
        'cboYearSection1
        '
        Me.cboYearSection1.FormattingEnabled = True
        Me.cboYearSection1.Items.AddRange(New Object() {"7 - Binet", "7 - Azucena", "7 - Bougainvillea", "7 - Chrysanthemum", "7 - Daffodil", "7 - Everlasting", "7 - Fleur d lis", "7 - Gladiola", "8 - Newton", "8 - Acacia", "8 - Banaba", "8 - Camachili", "8 - Dao", "8 - Evergreen", "III - Herschel", "III - Amethyst", "III - Beryl", "III - Citrine", "III - Diamond", "IV - Socrates", "IV - Amiability", "IV - Bravery", "IV - Charity", "IV - Dependability"})
        Me.cboYearSection1.Location = New System.Drawing.Point(104, 22)
        Me.cboYearSection1.Name = "cboYearSection1"
        Me.cboYearSection1.Size = New System.Drawing.Size(164, 21)
        Me.cboYearSection1.TabIndex = 53
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label11.Location = New System.Drawing.Point(446, 427)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(181, 21)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Total Enrolled Studs: "
        '
        'PrintDocument1
        '
        '
        'pvDialog
        '
        Me.pvDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.pvDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.pvDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.pvDialog.Enabled = True
        Me.pvDialog.Icon = CType(resources.GetObject("pvDialog.Icon"), System.Drawing.Icon)
        Me.pvDialog.Name = "pvDialog"
        Me.pvDialog.Visible = False
        '
        'enrolment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SYSTEM_BNHS.vb.My.Resources.Resources.templatemo_left_bg1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(952, 677)
        Me.Controls.Add(Me.tbc)
        Me.Controls.Add(Me.gbTimeDate)
        Me.Controls.Add(Me.gbMenu)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "enrolment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gbTimeDate.ResumeLayout(False)
        Me.gbTimeDate.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbMenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbc.ResumeLayout(False)
        Me.tabEnrol.ResumeLayout(False)
        Me.gbContent.ResumeLayout(False)
        Me.gbContent.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvStudSection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabYearSection.ResumeLayout(False)
        Me.tabYearSection.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvStudSection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbTimeDate As System.Windows.Forms.GroupBox
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnPreReg As System.Windows.Forms.Button
    Friend WithEvents gbMenu As System.Windows.Forms.GroupBox
    Friend WithEvents btnEnrolment As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnGrades As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents USERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ACCOUNTSETTINGSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbc As System.Windows.Forms.TabControl
    Friend WithEvents tabEnrol As System.Windows.Forms.TabPage
    Friend WithEvents gbContent As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSearchStud As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalNumStuds As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchEnrol As System.Windows.Forms.Button
    Friend WithEvents lblTotalNumStuds As System.Windows.Forms.Label
    Friend WithEvents cboYearSection As System.Windows.Forms.ComboBox
    Friend WithEvents btnSeachStudSection As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvStudSection As System.Windows.Forms.DataGridView
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents txtBday As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents btnEnrol As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtGenAverage As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtStudId As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tabYearSection As System.Windows.Forms.TabPage
    Friend WithEvents txtTotalNumStuds1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvStudSection1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnYearSection As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboYearSection1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbSy As System.Windows.Forms.ComboBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents pvDialog As System.Windows.Forms.PrintPreviewDialog

End Class
