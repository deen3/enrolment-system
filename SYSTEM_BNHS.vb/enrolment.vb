Imports MySql.Data.MySqlClient
Public Class enrolment

    Dim MysqlConn As MySqlConnection
    Dim BNHSCommand As New MySqlCommand
    Dim BNHSAdapter As New MySqlDataAdapter
    Dim BNHSData As New DataTable
    Dim BNHSData1 As New DataTable
    Dim SQL As String
    Dim ENROL_SQL As String

    Dim COUNT_SQL As String

    Dim studentCount As Integer = 0
    Dim dgResult As DialogResult

    Dim loginUser As Integer = 1


    
    Private Sub enrolment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection()
        'Connection String
        MysqlConn.ConnectionString = "server=localhost; user id=root; password=; database=bnhs"

        If login.position_title = "Clerk" Then
            btnEnrolment.Enabled() = False
            btnGrades.Enabled() = False
        ElseIf login.position_title = "Faculty" Then
            btnPreReg.Enabled() = False
        End If

        clearAllFields()
    End Sub

    Private Sub btnSearchEnrol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchEnrol.Click
        'clear last data stored in data table 
        BNHSData1.Clear()
        clearAllFields()

        ' Split string with spaces
        If txtSearchStud.Text.Contains(" "c) Then
            Dim words As String() = txtSearchStud.Text.Split(New Char() {" "c})
            Dim w1 As String = words(0)
            Dim w2 As String = words(1)
            ' Define the SQL to grab data from table.
            SQL = "SELECT * " & _
                "FROM(students)" & _
                "WHERE ( studName LIKE '%" & w1 & "%' AND studName LIKE '%" & w2 & "%' )" & _
                "OR ( studName LIKE '%" & w2 & "%' AND studName LIKE '%" & w1 & "%' ) "
        Else
            SQL = "SELECT * " & _
                "FROM(students)" & _
                "WHERE studName LIKE '%" & txtSearchStud.Text & "%' "
        End If

        ' Try, Catch, Finally
        Try
            MysqlConn.Open()
            BNHSCommand.Connection = MysqlConn
            BNHSCommand.CommandText = SQL
            BNHSAdapter.SelectCommand = BNHSCommand
            BNHSAdapter.Fill(BNHSData1)

            If txtSearchStud.Text = "" Then
                MsgBox("Please enter name to search!")
            Else
                If BNHSData1.Rows.Count > 0 Then
                    txtStudId.Text = BNHSData1.Rows(0).Item("studId")
                    txtName.Text = BNHSData1.Rows(0).Item("studName")
                    txtGender.Text = BNHSData1.Rows(0).Item("gender")
                    txtAge.Text = BNHSData1.Rows(0).Item("age")
                    txtBday.Text = BNHSData1.Rows(0).Item("bday")
                    txtAddress.Text = BNHSData1.Rows(0).Item("address")
                    txtContact.Text = BNHSData1.Rows(0).Item("contact")
                Else
                    MsgBox("Student not found!")
                End If
            End If
        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
        Finally
            MysqlConn.Close()
            MysqlConn.Dispose()
        End Try

        ' get student's last year genAverage


        txtSearchStud.Text = ""
    End Sub

    Dim dgv1 As Boolean = False
    Dim dgv2 As Boolean = False
    Dim yearSection As String

    Private Sub btnSeachStudSection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeachStudSection.Click
        dgv1 = True
        yearSection = cboYearSection.Text
        displayStudents()
        dgv1 = False
    End Sub

    Private Sub btnYearSection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYearSection.Click
        dgv2 = True
        yearSection = cboYearSection1.Text
        displayStudents()
        dgv2 = False
    End Sub

    Public Sub displayStudents()
        'clear last data stored in data table 
        BNHSData.Clear()

        ' Define the SQL to grab data from table.
        SQL = "SELECT *" & _
            "FROM(students)" & _
            "WHERE studId IN" & _
            "( " & _
            " SELECT studId FROM stud_section WHERE sectionName LIKE '%" & yearSection & "%'" & _
            ")"

        COUNT_SQL = "SELECT COUNT(*) FROM stud_section WHERE sectionName = '" & yearSection & "'"

        ' Try, Catch, Finally
        Try

            MysqlConn.Open()
            BNHSCommand.Connection = MysqlConn
            BNHSCommand.CommandText = COUNT_SQL
            BNHSAdapter.SelectCommand = BNHSCommand

            'displaying total number of enrolled students
            studentCount = BNHSCommand.ExecuteScalar()

            BNHSCommand.CommandText = SQL
            BNHSAdapter.SelectCommand = BNHSCommand
            BNHSAdapter.Fill(BNHSData)

            If cboYearSection.Text = "" And cboYearSection1.Text = "" Then
                MsgBox("Please select Year/Section!")
            Else
                If dgv1 = True Then
                    dgvStudSection.DataSource = BNHSData
                    txtTotalNumStuds.Text = studentCount
                ElseIf dgv2 = True Then
                    dgvStudSection1.DataSource = BNHSData
                    txtTotalNumStuds1.Text = studentCount
                End If
            End If
        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
        Finally
            MysqlConn.Close()
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnEnrol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnrol.Click

        'clear last data stored in data table 
        BNHSData.Clear()

        Dim regDate As Date = DateTime.Now().ToString("MM-dd-yyyy")

        If (txtStudId.Text = "") Then
            MessageBox.Show("Choose a student  first!", _
                "Important Note", _
                 MessageBoxButtons.OK, _
                 MessageBoxIcon.Exclamation, _
                 MessageBoxDefaultButton.Button1)
        ElseIf (cbSy.Text = "School Year") Then
            MessageBox.Show("Choose School Year!", _
                "Important Note", _
                 MessageBoxButtons.OK, _
                 MessageBoxIcon.Exclamation, _
                 MessageBoxDefaultButton.Button1)
        ElseIf (cboYearSection.Text = "") Then
            MessageBox.Show("Designate student to Year/Section!", _
                "Important Note", _
                 MessageBoxButtons.OK, _
                 MessageBoxIcon.Exclamation, _
                 MessageBoxDefaultButton.Button1)
        Else
            If (studentCount > 40) Then
                dgResult = MessageBox.Show("Number of students reached the maximum of 40. Continue?", _
                                            "Important Question", _
                                            MessageBoxButtons.YesNo)
                If (dgResult = 6) Then
                End If
            Else
                ' Define the SQL to grab data from table.
                SQL = "INSERT INTO stud_section VALUES ('" & txtStudId.Text & "','" & cboYearSection.Text & "', '" & cbSy.Text & "' )"
                ENROL_SQL = "INSERT INTO enrolled_stud VALUES ('" & txtStudId.Text & "','" & cbSy.Text & "','" & cboYearSection.Text & "','" & regDate & "','" & loginUser & "' )"

                ' Try, Catch, Finally
                Try
                    MysqlConn.Open()
                    BNHSCommand.Connection = MysqlConn
                    BNHSCommand.CommandText = ENROL_SQL
                    BNHSAdapter.SelectCommand = BNHSCommand
                    BNHSAdapter.Fill(BNHSData)

                    'clear last data stored in data table 
                    BNHSData.Clear()

                    BNHSCommand.CommandText = SQL
                    BNHSAdapter.SelectCommand = BNHSCommand
                    BNHSAdapter.Fill(BNHSData)

                    MessageBox.Show("Succesfully enrolled " & txtName.Text)

                Catch myerror As MySqlException
                    MessageBox.Show(txtName.Text & " is already enrolled!!", _
                    "Important Note", _
                     MessageBoxButtons.OK, _
                     MessageBoxIcon.Exclamation, _
                     MessageBoxDefaultButton.Button1)
                Finally
                    MysqlConn.Close()
                    MysqlConn.Dispose()
                End Try
            End If
        End If
        clearAllFields()
    End Sub

    Private Sub clearAllFields()
        txtStudId.Text = ""
        txtName.Text = ""
        txtGender.Text = ""
        txtAge.Text = ""
        txtBday.Text = ""
        txtAddress.Text = ""
        txtContact.Text = ""

        txtGenAverage.Text = ""

    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        home.Show()
        Me.Hide()
    End Sub

    Private Sub btnPreReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreReg.Click
        preReg.Show()
        Me.Hide()
    End Sub

    Private Sub tbc_Selected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles tbc.Selected
        clearAllFields()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        deleteStud.Show()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        changeStudSection.Show()
    End Sub

    Private Sub txtSearchStud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchStud.Click
        txtSearchStud.Text = ""
    End Sub

    Private Sub btnGrades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrades.Click
        grades.Show()
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub ACCOUNTSETTINGSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACCOUNTSETTINGSToolStripMenuItem.Click
        userAccount.Show()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Dim dgResult = MessageBox.Show("Are you really want to logout?", _
                                            "Important Question", _
                                            MessageBoxButtons.YesNo)
        If (dgResult = 6) Then
            Me.Close()
            Me.Dispose()
        End If
    End Sub

    Private Sub btnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPreview.Click
        pvDialog.Document = PrintDocument1
        pvDialog.PrintPreviewControl.Zoom = 1
        pvDialog.ShowDialog()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.dgvStudSection1.Width, Me.dgvStudSection1.Height)
        dgvStudSection1.DrawToBitmap(bm, New Rectangle(0, 0, dgvStudSection1.Width, Me.dgvStudSection1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub
End Class
