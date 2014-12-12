Imports MySql.Data.MySqlClient
Public Class editStudentsInfo
    Dim MysqlConn As MySqlConnection
    Dim BNHSCommand As New MySqlCommand
    Dim BNHSAdapter As New MySqlDataAdapter
    Dim BNHSData As New DataTable
    Dim SQL As String
    Dim ENROL_SQL As String

    Private Sub editStudentsInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection()
        'Connection String
        MysqlConn.ConnectionString = "server=localhost; user id=root; password=; database=bnhs"

    End Sub

    Private Sub btnSearchEnrol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchEnrol.Click
        'clear last data stored in data table 
        BNHSData.Clear()

        ' Split string with spaces
        If txtSearchStud.Text.Contains(" "c) Then
            Dim words As String() = txtSearchStud.Text.Split(New Char() {" "c})
            Dim w1 As String = words(0)
            Dim w2 As String = words(1)
            ' Define the SQL to grab data from table.
            Sql = "SELECT * " & _
                "FROM(students)" & _
                "WHERE ( studName LIKE '%" & w1 & "%' AND studName LIKE '%" & w2 & "%' )" & _
                "OR ( studName LIKE '%" & w2 & "%' AND studName LIKE '%" & w1 & "%' ) "
        Else
            Sql = "SELECT * " & _
                "FROM(students)" & _
                "WHERE studName LIKE '%" & txtSearchStud.Text & "%' "
        End If

        ' Try, Catch, Finally
        Try
            MysqlConn.Open()
            BNHSCommand.Connection = MysqlConn
            BNHSCommand.CommandText = Sql
            BNHSAdapter.SelectCommand = BNHSCommand
            BNHSAdapter.Fill(BNHSData)

            If txtSearchStud.Text = "" Then
                MsgBox("Please enter name to search!")
            Else
                If BNHSData.Rows.Count > 0 Then
                    txtStudId.Text = BNHSData.Rows(0).Item("studId")
                    txtName.Text = BNHSData.Rows(0).Item("studName")
                    cboGender.Text = BNHSData.Rows(0).Item("gender")
                    txtAge.Text = BNHSData.Rows(0).Item("age")
                    txtBday.Text = BNHSData.Rows(0).Item("bday")
                    txtAddress.Text = BNHSData.Rows(0).Item("address")
                    txtContact.Text = BNHSData.Rows(0).Item("contact")
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

        txtSearchStud.Text = ""
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        'clear last data stored in data table 
        BNHSData.Clear()

        SQL = "UPDATE students SET " & _
            "studName = '" & txtName.Text & "'," & _
            "gender = '" & cboGender.Text & "'," & _
            "age = '" & txtAge.Text & "'," & _
            "bday = '" & txtBday.Text & "'," & _
            "address = '" & txtAddress.Text & "'," & _
            "contact = '" & txtContact.Text & "'," & _
            "WHERE(studId = '" & txtStudId.Text & "')"

        ' Try, Catch, Finally
        Try
            MysqlConn.Open()
            BNHSCommand.Connection = MysqlConn
            BNHSCommand.CommandText = SQL
            BNHSAdapter.SelectCommand = BNHSCommand
            BNHSAdapter.Fill(BNHSData)

            MessageBox.Show("Student's information successfully edited!")
            Me.Close()

        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
        Finally
            MysqlConn.Close()
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtContact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContact.Click
        txtContact.Text = ""
    End Sub

    Private Sub txtAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddress.Click
        txtAddress.Text = ""
    End Sub

    Private Sub txtBday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBday.Click
        txtBday.Text = ""
    End Sub

    Private Sub txtAge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAge.Click
        txtAge.Text = ""
    End Sub

    Private Sub cboGender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGender.Click
        cboGender.Text = ""
    End Sub

    Private Sub txtName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.Click
        txtName.Text = ""
    End Sub
End Class