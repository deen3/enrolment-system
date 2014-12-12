Imports MySql.Data.MySqlClient
Public Class deleteUser
    Dim MysqlConn As MySqlConnection
    Dim BNHSCommand As New MySqlCommand
    Dim BNHSAdapter As New MySqlDataAdapter
    Dim BNHSData As New DataTable
    Dim SQL As String

    Private Sub deleteUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub btnSearchEnrol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchEnrol.Click
        ' Define the SQL to grab data from table.
        SQL = "SELECT * FROM user WHERE username LIKE '%" & txtSearchUser.Text & "%'"

        BNHSData.Clear()
        ' Try, Catch, Finally
        Try
            MysqlConn.Open()
            BNHSCommand.Connection = MysqlConn
            BNHSCommand.CommandText = SQL
            BNHSAdapter.SelectCommand = BNHSCommand
            BNHSAdapter.Fill(BNHSData)

            If BNHSData.Rows.Count > 0 Then
                txtUsername.Text = BNHSData.Rows(0).Item("username")
                txtPassword.Text = BNHSData.Rows(0).Item("password")
                txtPosition.Text = BNHSData.Rows(0).Item("position_title")
            End If

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

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Or txtPosition.Text = "" Then
            MessageBox.Show("Please choose user to delete!")
        Else
            ' Define the SQL to grab data from table.
            SQL = "DELETE FROM user " & _
            "WHERE username = '" & txtUsername.Text & "' AND password = '" & txtPassword.Text & "'"

            BNHSData.Clear()
            ' Try, Catch, Finally
            Try
                MysqlConn.Open()
                BNHSCommand.Connection = MysqlConn
                BNHSCommand.CommandText = SQL
                BNHSAdapter.SelectCommand = BNHSCommand
                BNHSAdapter.Fill(BNHSData)

                MessageBox.Show(txtUsername.Text & " was successfully deleted")

            Catch myerror As MySqlException
                MessageBox.Show("Cannot connect to database: " & myerror.Message)
            Finally
                MysqlConn.Close()
                MysqlConn.Dispose()
            End Try
            Me.Close()
        End If
    End Sub
End Class