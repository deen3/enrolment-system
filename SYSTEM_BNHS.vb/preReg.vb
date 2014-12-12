Imports MySql.Data.MySqlClient
Public Class preReg

    Dim MysqlConn As MySqlConnection
    Dim BNHSCommand As New MySqlCommand
    Dim BNHSAdapter As New MySqlDataAdapter
    Dim BNHSData As New DataTable
    Dim SQL As String

    Private Sub preReg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub clearAllFields()
        txtLastName.Text = ""
        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        cboGender.Text = "Select"
        txtAge.Text = ""
        cboMonthBday.Text = ""
        nudDayBday.Text = ""
        cboYearBday.Text = ""
        txtBgyAddress.Text = "Barangay/Barrio"
        txtCityAddress.Text = "City"
        txtProvinceAddress.Text = "Province"
        txtContact.Text = ""
    End Sub

    Private Sub cboYearBday_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYearBday.TextChanged
        If Not cboYearBday.Text = "" And IsNumeric(cboYearBday.Text) Then
            txtAge.Text = Date.Today.Year - cboYearBday.Text
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim studId As Integer
        Dim studName As String
        Dim name = txtLastName.Text & ", " & txtFirstName.Text & " " & txtMiddleName.Text
        Dim bday = cboMonthBday.Text & " " & nudDayBday.Text & " " & cboYearBday.Text
        Dim address = txtBgyAddress.Text & "" & txtCityAddress.Text & " " & txtProvinceAddress.Text

        Dim alreadyRegistered As Boolean
        alreadyRegistered = False

        'checking if all fields were filled out
        If (txtLastName.Text = "" Or txtFirstName.Text = "" Or cboGender.Text = "Select" Or txtAge.Text = "" Or bday = "" Or txtBgyAddress.Text = "Barangay/Barrio" Or txtCityAddress.Text = "City" Or txtProvinceAddress.Text = "Province") Then
            MessageBox.Show("Please fill all fields with *!")

        Else
            'check first if name is already registered
            SQL = "SELECT studId, studName FROM students WHERE studName = '" & name & "' "

            ' Try, Catch, Finally
            Try
                MysqlConn.Open()
                BNHSCommand.Connection = MysqlConn
                BNHSCommand.CommandText = SQL
                BNHSAdapter.SelectCommand = BNHSCommand
                BNHSAdapter.Fill(BNHSData)

                studId = BNHSData.Rows(0).Item("studId")
                studName = BNHSData.Rows(0).Item("studName")
                MessageBox.Show(studName + " is already registered. Student ID: " & studId)
                alreadyRegistered = True
            Catch myerror As MySqlException
                MessageBox.Show("Cannot connect to database: " & myerror.Message)
            Finally
                MysqlConn.Close()
                MysqlConn.Dispose()
            End Try

            If (alreadyRegistered = False) Then

                ' save student's information
                ' Define the SQL to grab data from table.
                SQL = "INSERT INTO students " & _
                    "(studName, gender, age, bday, address, contact)" & _
                    "VALUES ('" & name & "','" & cboGender.Text & "'," & _
                    "'" & txtAge.Text & "', '" & bday & "',  '" & address & "'," & _
                    "'" & txtContact.Text & "' )"

                ' Try, Catch, Finally
                Try
                    MysqlConn.Open()
                    BNHSCommand.Connection = MysqlConn
                    BNHSCommand.CommandText = SQL
                    BNHSAdapter.SelectCommand = BNHSCommand
                    BNHSAdapter.Fill(BNHSData)

                    MessageBox.Show("Successfully saved " & txtFirstName.Text & " " & txtLastName.Text & " to database!")

                Catch myerror As MySqlException
                    MessageBox.Show("Cannot connect to database: " & myerror.Message)
                Finally
                    MysqlConn.Close()
                    MysqlConn.Dispose()
                End Try
            End If

            End If  ' end of If (txtLastName.Text = "" Or txtFirstName.Text = ""....
            clearAllFields()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        clearAllFields()
    End Sub

    Private Sub txtBgyAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBgyAddress.Click
        txtBgyAddress.Text = ""
    End Sub

    Private Sub txtCityAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCityAddress.Click
        txtCityAddress.Text = ""
    End Sub

    Private Sub txtProvinceAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProvinceAddress.Click
        txtProvinceAddress.Text = ""
    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        home.Show()
        Me.Close()
    End Sub

    Private Sub btnEnrolment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnrolment.Click
        enrolment.Show()
        Me.Close()
    End Sub

    Private Sub btnEditStudentsInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditStudentsInfo.Click
        editStudentsInfo.show()
    End Sub

    Private Sub btnGrades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrades.Click
        grades.Show()
        Me.Close()
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Me.Dispose()
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
