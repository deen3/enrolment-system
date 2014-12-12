Imports MySql.Data.MySqlClient
Public Class home
    Dim MysqlConn As MySqlConnection
    Dim BNHSCommand As New MySqlCommand
    Dim BNHSAdapter As New MySqlDataAdapter
    Dim BNHSData As New DataTable
    Dim SQL As String

    Private Sub home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection()
        'Connection String
        MysqlConn.ConnectionString = "server=localhost; user id=root; password=; database=bnhs"

        If login.position_title = "Clerk" Then
            btnEnrolment.Enabled() = False
            btnGrades.Enabled() = False
            btnAddUser.Visible() = False
            btnEditUser.Visible() = False
            btnDeleteUser.Visible() = False
        ElseIf login.position_title = "Faculty" Then
            btnPreReg.Enabled() = False
            btnAddUser.Visible() = False
            btnEditUser.Visible() = False
            btnDeleteUser.Visible() = False
        End If

        lblUser.Text = login.txtUsername.Text
        lblLoginTime.Text = "Login Time: " & login.loginTime

        'display use's information

        'clear last data stored in data table 
        BNHSData.Clear()

        ' Define the SQL to grab data from table.
        SQL = "SELECT *" & _
            "FROM(personnel)" & _
            "WHERE personnel_id = '" & login.personnel_id & "'"

        ' Try, Catch, Finally
        Try
            MysqlConn.Open()
            BNHSCommand.Connection = MysqlConn
            BNHSCommand.CommandText = SQL
            BNHSAdapter.SelectCommand = BNHSCommand
            BNHSAdapter.Fill(BNHSData)

            If BNHSData.Rows.Count > 0 Then
                lblName.Text = BNHSData.Rows(0).Item("name")
                lblGender.Text = BNHSData.Rows(0).Item("gender")
                lblPosition.Text = BNHSData.Rows(0).Item("position_title")
                lblDesignation.Text = BNHSData.Rows(0).Item("designation")
            End If

        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
        Finally
            MysqlConn.Close()
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub btnPreReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreReg.Click
        preReg.Show()
        Me.Close()
    End Sub

    Private Sub btnEnrolment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnrolment.Click
        enrolment.Show()
        Me.Close()
    End Sub

    Private Sub btnGrades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrades.Click
        grades.Show()
        Me.Close()
    End Sub

    Private Sub btnAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUser.Click
        addUser.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditUser.Click
        editUser.Show()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteUser.Click
        deleteUser.Show()
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
End Class