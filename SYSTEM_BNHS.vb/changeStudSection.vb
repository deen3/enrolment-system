Imports MySql.Data.MySqlClient
Public Class changeStudSection
    Dim MysqlConn As MySqlConnection
    Dim BNHSCommand As New MySqlCommand
    Dim BNHSAdapter As New MySqlDataAdapter
    Dim BNHSData As New DataTable
    Dim SQL As String
    Dim SQL2 As String

    Dim dgResult As DialogResult
    Private Sub changeStudSection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection()
        'Connection String
        MysqlConn.ConnectionString = "server=localhost; user id=root; password=; database=bnhs"

    End Sub

    Private Sub btnSearchEnrol_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchEnrol.Click
        BNHSData.Clear()

        If txtSearchStudId.Text = "" Then
            MessageBox.Show("Please enter the student ID!")
        Else

            'check if student already enrolled
            SQL = "SELECT * FROM enrolled_stud WHERE studId = '" & txtSearchStudId.Text & "' "
            ' Try, Catch, Finally
            Try
                MysqlConn.Open()
                BNHSCommand.Connection = MysqlConn
                BNHSCommand.CommandText = SQL
                BNHSAdapter.SelectCommand = BNHSCommand
                BNHSAdapter.Fill(BNHSData)

                If BNHSData.Rows.Count > 0 Then
                    ' Define the SQL to grab data from table.
                    SQL = "SELECT * " & _
                            "FROM(students)" & _
                            "WHERE studId = '" & txtSearchStudId.Text & "' "
                    SQL2 = "SELECT sectionName FROM stud_section WHERE studId = '" & txtSearchStudId.Text & "'"

                    ' Try, Catch, Finally
                    Try
                        'clear data table
                        BNHSData.Clear()

                        BNHSCommand.CommandText = SQL
                        BNHSAdapter.SelectCommand = BNHSCommand
                        BNHSAdapter.Fill(BNHSData)

                        If BNHSData.Rows.Count > 0 Then
                            txtStudName.Text = BNHSData.Rows(0).Item("studName")
                        End If

                        BNHSData.Clear()
                        BNHSCommand.CommandText = SQL2
                        BNHSAdapter.SelectCommand = BNHSCommand
                        BNHSAdapter.Fill(BNHSData)

                        If BNHSData.Rows.Count > 0 Then
                            txtStudSection.Text = BNHSData.Rows(0).Item("sectionName")
                        End If

                    Catch myerror As MySqlException
                        MessageBox.Show("Cannot connect to database: " & myerror.Message)
                    Finally
                        MysqlConn.Close()
                        MysqlConn.Dispose()
                    End Try
                Else
                    MessageBox.Show("Student not found!")
                End If

            Catch myerror As MySqlException
                MessageBox.Show("Cannot connect to database: " & myerror.Message)
            Finally
                MysqlConn.Close()
                MysqlConn.Dispose()
            End Try
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        BNHSData.Clear()

        SQL = "UPDATE stud_section SET sectionName = '" & cboChangeSecStud.Text & "'  WHERE studId = '" & txtSearchStudId.Text & "' "

        If txtStudName.Text = "" And txtStudSection.Text = "" Then
            MessageBox.Show("Please choose a student!")
        ElseIf cboChangeSecStud.Text = "" Then
            MessageBox.Show("Please choose a Year/Section to trasfer student!")
        Else
            Dim msg As String = "Are you sure you want to transfer " & txtStudName.Text & " to " & cboChangeSecStud.Text & ". Continue?"
            dgResult = MessageBox.Show(msg, _
                                                "Important Question", _
                                                MessageBoxButtons.YesNo)
            If (dgResult = 6) Then
                ' Try, Catch, Finally
                Try
                    MysqlConn.Open()
                    BNHSCommand.Connection = MysqlConn
                    BNHSCommand.CommandText = SQL
                    BNHSAdapter.SelectCommand = BNHSCommand
                    BNHSAdapter.Fill(BNHSData)

                    BNHSCommand.CommandText = SQL2
                    BNHSAdapter.SelectCommand = BNHSCommand
                    BNHSAdapter.Fill(BNHSData)

                    MessageBox.Show(txtStudName.Text & " was successfully trasfered to " & cboChangeSecStud.Text)

                Catch myerror As MySqlException
                    MessageBox.Show("Cannot connect to database: " & myerror.Message)
                Finally
                    MysqlConn.Close()
                    MysqlConn.Dispose()
                End Try
            End If

            Me.Dispose()
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub txtSearchStudId_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtSearchStudId.Text = ""
    End Sub

    Private Sub txtSearchStudId_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchStudId.Click
        txtSearchStudId.Text = ""
    End Sub
End Class