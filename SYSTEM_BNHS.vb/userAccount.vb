Imports MySql.Data.MySqlClient
Public Class userAccount
    Dim MysqlConn As MySqlConnection
    Dim BNHSCommand As New MySqlCommand
    Dim BNHSAdapter As New MySqlDataAdapter
    Dim BNHSData As New DataTable
    Dim SQL As String
    Dim SQL2 As String

    Private Sub userAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection()
        'Connection String
        MysqlConn.ConnectionString = "server=localhost; user id=root; password=; database=bnhs"


        BNHSData.Clear()

        'gets username and password
        SQL = "SELECT * FROM user WHERE personnel_id = '" & login.personnel_id & "' "
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
            Else
                MessageBox.Show("Not found!")
            End If

        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
        Finally
            MysqlConn.Close()
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please fill in username and password")
        Else
            BNHSData.Clear()

            'gets username and password
            SQL = "UPDATE user SET username = '" & txtUsername.Text & "', password = '" & txtPassword.Text & "' " & _
                    "WHERE personnel_id = '" & login.personnel_id & "' "
            ' Try, Catch, Finally
            Try
                MysqlConn.Open()
                BNHSCommand.Connection = MysqlConn
                BNHSCommand.CommandText = SQL
                BNHSAdapter.SelectCommand = BNHSCommand
                BNHSAdapter.Fill(BNHSData)

                home.lblUser.Text = txtUsername.Text
                MessageBox.Show("Successfully saved!")

            Catch myerror As MySqlException
                MessageBox.Show("Cannot connect to database: " & myerror.Message)
            Finally
                MysqlConn.Close()
                MysqlConn.Dispose()
            End Try
        End If
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub lnkChangeUsername_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkChangeUsername.Click
        txtUsername.ReadOnly = False
        txtUsername.Text = ""
    End Sub

    Private Sub lnkChangePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkChangePassword.Click
        txtPassword.ReadOnly = False
        txtPassword.Text = ""
    End Sub
End Class