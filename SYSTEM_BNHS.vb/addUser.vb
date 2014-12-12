Imports MySql.Data.MySqlClient
Public Class addUser
    Dim MysqlConn As MySqlConnection
    Dim BNHSCommand As New MySqlCommand
    Dim BNHSAdapter As New MySqlDataAdapter
    Dim BNHSData As New DataTable
    Dim SQL As String

    Dim personnelId As Integer

    Private Sub addUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection()
        'Connection String
        MysqlConn.ConnectionString = "server=localhost; user id=root; password=; database=bnhs"

        ' Define the SQL to grab data from table.
        SQL = "SELECT *" & _
            "FROM(user)"

        BNHSData.Clear()
        ' Try, Catch, Finally
        Try
            MysqlConn.Open()
            BNHSCommand.Connection = MysqlConn
            BNHSCommand.CommandText = SQL
            BNHSAdapter.SelectCommand = BNHSCommand
            BNHSAdapter.Fill(BNHSData)

            dgvUser.DataSource = BNHSData

        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
        Finally
            MysqlConn.Close()
            MysqlConn.Dispose()
        End Try

        cboPosition.Text = "Select Position"
    End Sub

    Private Sub btnSearchFaculty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchFaculty.Click
        'clear last data stored in data table 
        BNHSData.Clear()

        ' Split string with spaces
        If txtSearchFaculty.Text.Contains(" "c) Then
            Dim words As String() = txtSearchFaculty.Text.Split(New Char() {" "c})
            Dim w1 As String = words(0)
            Dim w2 As String = words(1)
            ' Define the SQL to grab data from table.
            SQL = "SELECT * " & _
                "FROM(personnel)" & _
                "WHERE ( name LIKE '%" & w1 & "%' AND name LIKE '%" & w2 & "%' )" & _
                "OR ( name LIKE '%" & w2 & "%' AND name LIKE '%" & w1 & "%' ) "
        Else
            SQL = "SELECT * " & _
                "FROM(personnel)" & _
                "WHERE name LIKE '%" & txtSearchFaculty.Text & "%' "
        End If

        ' Try, Catch, Finally
        Try
            MysqlConn.Open()
            BNHSCommand.Connection = MysqlConn
            BNHSCommand.CommandText = SQL
            BNHSAdapter.SelectCommand = BNHSCommand
            BNHSAdapter.Fill(BNHSData)

            If txtSearchFaculty.Text = "" Then
                MsgBox("Please enter name to search!")
            Else
                If BNHSData.Rows.Count > 0 Then
                    personnelId = BNHSData.Rows(0).Item("personnel_id")
                    txtPerId.Text = BNHSData.Rows(0).Item("personnel_id")
                    txtPerName.Text = BNHSData.Rows(0).Item("name")
                Else
                    MsgBox("Personnel not found!")
                End If
            End If
        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
        Finally
            MysqlConn.Close()
            MysqlConn.Dispose()
        End Try

        txtSearchFaculty.Text = ""
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please enter username and password")
        ElseIf cboPosition.Text = "Select Position" Then
            MessageBox.Show("Please choose user's position")
        Else
            ' Define the SQL to grab data from table.
            SQL = "INSERT INTO user VALUES('" & personnelId & "','" & cboPosition.Text & "', '" & txtUsername.Text & "', '" & txtPassword.Text & "')"

            ' Try, Catch, Finally
            Try
                MysqlConn.Open()
                BNHSCommand.Connection = MysqlConn
                BNHSCommand.CommandText = SQL
                BNHSAdapter.SelectCommand = BNHSCommand
                BNHSAdapter.Fill(BNHSData)

                MessageBox.Show(txtUsername.Text & " was successfully added")

            Catch myerror As MySqlException
                MessageBox.Show("Cannot connect to database: " & myerror.Message)
            Finally
                MysqlConn.Close()
                MysqlConn.Dispose()
            End Try
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtSearchFaculty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchFaculty.Click
        txtSearchFaculty.Text = ""
    End Sub
End Class