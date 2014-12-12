Imports MySql.Data.MySqlClient
Public Class login
    Dim MysqlConn As MySqlConnection
    Dim BNHSCommand As New MySqlCommand
    Dim BNHSAdapter As New MySqlDataAdapter
    Dim BNHSData As New DataTable
    Dim SQL As String

    Public position_title As String
    Public personnel_id As String
    Public loginTime As String

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection()
        'Connection String
        MysqlConn.ConnectionString = "server=localhost; user id=root; password=; database=bnhs"

    End Sub

    Public Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtUsername.Text = "" Then
            MessageBox.Show("Please enter username and password!")
        Else
            'check if valid user
            SQL = "SELECT * FROM user WHERE username = '" & txtUsername.Text & "' AND password = '" & txtPassword.Text & "'"
            ' Try, Catch, Finally
            Try
                'clear data table
                BNHSData.Clear()

                MysqlConn.Open()
                BNHSCommand.Connection = MysqlConn
                BNHSCommand.CommandText = SQL
                BNHSAdapter.SelectCommand = BNHSCommand
                BNHSAdapter.Fill(BNHSData)

                'if found
                If BNHSData.Rows.Count > 0 Then
                    position_title = BNHSData.Rows(0).Item("position_title")
                    personnel_id = BNHSData.Rows(0).Item("personnel_id")

                    loginTime = TimeOfDay

                    home.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Not enough credentials! Contact your administrator")
                End If
            Catch myerror As MySqlException
                MessageBox.Show("Cannot connect to database: " & myerror.Message)
            Finally
                MysqlConn.Close()
                MysqlConn.Dispose()
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub txtUsername_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.Click
        txtUsername.Text = ""
    End Sub

    Private Sub txtPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.Click
        txtPassword.Text = ""
    End Sub
End Class