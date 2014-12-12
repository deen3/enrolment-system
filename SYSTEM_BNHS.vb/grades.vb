Imports MySql.Data.MySqlClient
Public Class grades
    Dim MysqlConn As MySqlConnection
    Dim BNHSCommand As New MySqlCommand
    Dim BNHSAdapter As New MySqlDataAdapter
    Dim BNHSData As New DataTable
    Dim SQL As String

    Dim studId As String
    Dim studName As String
    Dim sectionName As String

    Private Sub grades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection()
        'Connection String
        MysqlConn.ConnectionString = "server=localhost; user id=root; password=; database=bnhs"

        If login.position_title = "Clerk" Then
            btnEnrolment.Enabled() = False
            btnGrades.Enabled() = False
        ElseIf login.position_title = "Faculty" Then
            btnPreReg.Enabled() = False
        End If
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click

        'searching and displaying students id and name
        'if belong to a specified year/ section

        'clear last data stored in data table 
        BNHSData.Clear()

        ' Split string with spaces
        If txtSearchStud.Text.Contains(" "c) Then
            Dim words As String() = txtSearchStud.Text.Split(New Char() {" "c})
            Dim w1 As String = words(0)
            Dim w2 As String = words(1)
            ' Define the SQL to grab data from table.
            SQL = "SELECT * " & _
                "FROM(students)" & _
                "WHERE (( studName LIKE '%" & w1 & "%' AND studName LIKE '%" & w2 & "%' )" & _
                "OR ( studName LIKE '%" & w2 & "%' AND studName LIKE '%" & w1 & "%' )) " '& _
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
            BNHSAdapter.Fill(BNHSData)

            If txtSearchStud.Text = "" Then
                MsgBox("Please enter the name!")
            Else
                If BNHSData.Rows.Count > 0 Then
                    studId = BNHSData.Rows(0).Item("studId")
                    studName = BNHSData.Rows(0).Item("studName")
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

        SQL = "SELECT studId FROM stud_section WHERE sectionName = '" & cboYearSection.Text & "'"

        BNHSData.Clear()
        ' Try, Catch, Finally
        Try
            MysqlConn.Open()
            BNHSCommand.Connection = MysqlConn
            BNHSCommand.CommandText = SQL
            BNHSAdapter.SelectCommand = BNHSCommand
            BNHSAdapter.Fill(BNHSData)

            If cboYearSection.Text = "Year/ Section" Then
                MsgBox("Please enter the name!")
            Else
                If BNHSData.Rows.Count > 0 Then
                    txtStudId.Text = studId
                    txtName.Text = studName
                Else
                    MsgBox("Student not belong to " & cboYearSection.Text)
                End If
            End If
        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
        Finally
            MysqlConn.Close()
            MysqlConn.Dispose()
        End Try

        ' end of searching and displaying students id and name

    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        home.Show()
        Me.Close()
    End Sub

    Private Sub btnPreReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreReg.Click
        preReg.Show()
        Me.Close()
    End Sub

    Private Sub btnEnrolment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnrolment.Click
        enrolment.Show()
        Me.Close()
    End Sub
    Dim fTriggerd As Boolean = False
    Dim eTriggerd As Boolean = False
    Dim mTriggerd As Boolean = False
    Dim sTriggerd As Boolean = False
    Dim mkTriggerd As Boolean = False

    Dim atmapvTriggerd As Boolean = False

    Dim mak1Triggerd As Boolean = False
    Dim mak2Triggerd As Boolean = False
    Dim mak3Triggerd As Boolean = False
    Dim mak4Triggerd As Boolean = False

    Dim genAveTriggerd As Boolean = False

    Dim f1_i, f2_i, f3_i, f4_i, fTotal As Decimal
    Dim e1_i, e2_i, e3_i, e4_i, eTotal As Decimal
    Dim m1_i, m2_i, m3_i, m4_i, mTotal As Decimal
    Dim s1_i, s2_i, s3_i, s4_i, sTotal As Decimal
    Dim mk1_i, mk2_i, mk3_i, mk4_i, mkTotal As Decimal
    Dim a1_i, a2_i, a3_i, a4_i As Decimal
    Dim t1_i, t2_i, t3_i, t4_i As Decimal
    Dim map1_i, map2_i, map3_i, map4_i As Decimal
    Dim v1_i, v2_i, v3_i, v4_i As Decimal

    Dim aUnit_i, tUnit_i, mapUnit_i, vUnit_i As Decimal

    Dim fFinal_i, eFinal_i, mFinal_i, sFinal_i, mkFinal_i, genAve_i As Decimal
    Dim fUnit_i, eUnit_i, mUnit_i, sUnit_i, mkUnit_i, totalUnits_i As Decimal

    Public Sub displayFinalRemarks()
        
        If fTriggerd = True Then
            If f1.Text = "" Or f2.Text = "" Or f3.Text = "" Or f4.Text = "" Then
                fFinal.Text = ""
            ElseIf Not IsNumeric(f1.Text) Or Not IsNumeric(f2.Text) Or Not IsNumeric(f3.Text) Or Not IsNumeric(f4.Text) Then
                MsgBox("Error! Please enter numeric inputs only!")
            Else
                f1_i = f1.Text
                f2_i = f2.Text
                f3_i = f3.Text
                f4_i = f4.Text

                fTotal = (f1_i + f2_i + f3_i + f4_i) / 4
                fFinal.Text = fTotal

                If fFinal.Text >= 75 Then
                    fRemarks.Text = "Passed"
                ElseIf fFinal.Text > 100 Or fFinal.Text < 65 Then
                    fRemarks.Text = "Invalid!"
                Else
                    fRemarks.Text = "Failed"
                End If
            End If
        ElseIf eTriggerd = True Then
            If e1.Text = "" Or e2.Text = "" Or e3.Text = "" Or e4.Text = "" Then
                eFinal.Text = ""
            ElseIf Not IsNumeric(e1.Text) Or Not IsNumeric(e2.Text) Or Not IsNumeric(e3.Text) Or Not IsNumeric(e4.Text) Then
                MsgBox("Error! Please enter numeric inputs only!")
            Else
                e1_i = e1.Text
                e2_i = e2.Text
                e3_i = e3.Text
                e4_i = e4.Text

                eTotal = (e1_i + e2_i + e3_i + e4_i) / 4
                eFinal.Text = eTotal

                If eFinal.Text >= 75 Then
                    eRemarks.Text = "Passed"
                ElseIf eFinal.Text > 100 Or eFinal.Text < 65 Then
                    eRemarks.Text = "Invalid!"
                Else
                    eRemarks.Text = "Failed"
                End If
            End If
        ElseIf mTriggerd = True Then
            If m1.Text = "" Or m2.Text = "" Or m3.Text = "" Or m4.Text = "" Then
                mFinal.Text = ""
            ElseIf Not IsNumeric(m1.Text) Or Not IsNumeric(m2.Text) Or Not IsNumeric(m3.Text) Or Not IsNumeric(m4.Text) Then
                MsgBox("Error! Please enter numeric inputs only!")
            Else
                m1_i = m1.Text
                m2_i = m2.Text
                m3_i = m3.Text
                m4_i = m4.Text

                mTotal = (m1_i + m2_i + m3_i + m4_i) / 4
                mFinal.Text = mTotal

                If mFinal.Text >= 75 Then
                    mRemarks.Text = "Passed"
                ElseIf mFinal.Text > 100 Or mFinal.Text < 65 Then
                    mRemarks.Text = "Invalid!"
                Else
                    mRemarks.Text = "Failed"
                End If
            End If
        ElseIf sTriggerd = True Then
            If s1.Text = "" Or s2.Text = "" Or s3.Text = "" Or s4.Text = "" Then
                sFinal.Text = ""
            ElseIf Not IsNumeric(s1.Text) Or Not IsNumeric(s2.Text) Or Not IsNumeric(s3.Text) Or Not IsNumeric(s4.Text) Then
                MsgBox("Error! Please enter numeric inputs only!")
            Else
                s1_i = s1.Text
                s2_i = s2.Text
                s3_i = s3.Text
                s4_i = s4.Text

                sTotal = (s1_i + s2_i + s3_i + s4_i) / 4
                sFinal.Text = sTotal

                If sFinal.Text >= 75 Then
                    sRemarks.Text = "Passed"
                ElseIf sFinal.Text > 100 Or sFinal.Text < 65 Then
                    sRemarks.Text = "Invalid!"
                Else
                    sRemarks.Text = "Failed"
                End If
            End If
        ElseIf atmapvTriggerd = True Then
            ' AP
            If a1.Text = "" Or a2.Text = "" Or a3.Text = "" Or a4.Text = "" Then
                aFinal.Text = ""
            ElseIf Not IsNumeric(a1.Text) Or Not IsNumeric(a2.Text) Or Not IsNumeric(a3.Text) Or Not IsNumeric(a4.Text) Then
                MsgBox("Error! Please enter numeric inputs only!")
            Else
                a1_i = a1.Text
                a2_i = a2.Text
                a3_i = a3.Text
                a4_i = a4.Text

                aFinal.Text = (a1_i + a2_i + a3_i + a4_i) / 4

                If aFinal.Text >= 75 Then
                    aRemarks.Text = "Passed"
                ElseIf aFinal.Text > 100 Or aFinal.Text < 65 Then
                    aRemarks.Text = "Invalid!"
                Else
                    aRemarks.Text = "Failed"
                End If
            End If
            ' TLE
            If t1.Text = "" Or t2.Text = "" Or t3.Text = "" Or t4.Text = "" Then
                tFinal.Text = ""
            ElseIf Not IsNumeric(t1.Text) Or Not IsNumeric(t2.Text) Or Not IsNumeric(t3.Text) Or Not IsNumeric(t4.Text) Then
                MsgBox("Error! Please enter numeric inputs only!")
            Else
                t1_i = t1.Text
                t2_i = t2.Text
                t3_i = t3.Text
                t4_i = t4.Text

                tFinal.Text = (t1_i + t2_i + t3_i + t4_i) / 4

                If tFinal.Text >= 75 Then
                    tRemarks.Text = "Passed"
                ElseIf tFinal.Text > 100 Or tFinal.Text < 65 Then
                    tRemarks.Text = "Invalid!"
                Else
                    tRemarks.Text = "Failed"
                End If
            End If
            ' MAPEH
            If map1.Text = "" Or map2.Text = "" Or map3.Text = "" Or map4.Text = "" Then
                mapFinal.Text = ""
            ElseIf Not IsNumeric(map1.Text) Or Not IsNumeric(map2.Text) Or Not IsNumeric(map3.Text) Or Not IsNumeric(map4.Text) Then
                MsgBox("Error! Please enter numeric inputs only!")
            Else
                map1_i = map1.Text
                map2_i = map2.Text
                map3_i = map3.Text
                map4_i = map4.Text

                mapFinal.Text = (map1_i + map2_i + map3_i + map4_i) / 4

                If mapFinal.Text >= 75 Then
                    mapRemarks.Text = "Passed"
                ElseIf mapFinal.Text > 100 Or mapFinal.Text < 65 Then
                    mapRemarks.Text = "Invalid!"
                Else
                    mapRemarks.Text = "Failed"
                End If
            End If
            ' VE
            If v1.Text = "" Or v2.Text = "" Or v3.Text = "" Or v4.Text = "" Then
                vFinal.Text = ""
            ElseIf Not IsNumeric(v1.Text) Or Not IsNumeric(v2.Text) Or Not IsNumeric(v3.Text) Or Not IsNumeric(v4.Text) Then
                MsgBox("Error! Please enter numeric inputs only!")
            Else
                v1_i = v1.Text
                v2_i = v2.Text
                v3_i = v3.Text
                v4_i = v4.Text

                vFinal.Text = (v1_i + v2_i + v3_i + v4_i) / 4

                If vFinal.Text >= 75 Then
                    vRemarks.Text = "Passed"
                ElseIf vFinal.Text > 100 Or vFinal.Text < 65 Then
                    vRemarks.Text = "Invalid!"
                Else
                    vRemarks.Text = "Failed"
                End If
            End If
        End If

        'compute grade for MAKABAYAN
        If mak1Triggerd = True Then
            If a1.Text = "" Or t1.Text = "" Or map1.Text = "" Or v1.Text = "" Then
                mk1.Text = ""
            ElseIf Not IsNumeric(a1.Text) Or Not IsNumeric(t1.Text) Or Not IsNumeric(map1.Text) Or Not IsNumeric(v1.Text) Then
                MsgBox("Error! Please enter numeric inputs only!")
            Else
                a1_i = a1.Text
                t1_i = t1.Text
                map1_i = map1.Text
                v1_i = v1.Text

                mk1.Text = (a1_i + t1_i + map1_i + v1_i) / 4
            End If
        ElseIf mak2Triggerd = True Then
            If a2.Text = "" Or t2.Text = "" Or map2.Text = "" Or v2.Text = "" Then
                mk2.Text = ""
            ElseIf Not IsNumeric(a2.Text) Or Not IsNumeric(t2.Text) Or Not IsNumeric(map2.Text) Or Not IsNumeric(v2.Text) Then
                MsgBox("Error! Please enter numeric inputs only!")
            Else
                a2_i = a2.Text
                t2_i = t2.Text
                map2_i = map2.Text
                v2_i = v2.Text

                mk2.Text = (a2_i + t2_i + map2_i + v2_i) / 4
            End If
        ElseIf mak3Triggerd = True Then
            If a3.Text = "" Or t3.Text = "" Or map3.Text = "" Or v3.Text = "" Then
                mk3.Text = ""
            ElseIf Not IsNumeric(a3.Text) Or Not IsNumeric(t3.Text) Or Not IsNumeric(map3.Text) Or Not IsNumeric(v3.Text) Then
                MsgBox("Error! Please enter numeric inputs only!")
            Else
                a3_i = a3.Text
                t3_i = t3.Text
                map3_i = map3.Text
                v3_i = v3.Text

                mk3.Text = (a3_i + t3_i + map3_i + v3_i) / 4
            End If
        ElseIf mak4Triggerd = True Then
            If a4.Text = "" Or t4.Text = "" Or map4.Text = "" Or v4.Text = "" Then
                mk4.Text = ""
            ElseIf Not IsNumeric(a4.Text) Or Not IsNumeric(t4.Text) Or Not IsNumeric(map4.Text) Or Not IsNumeric(v4.Text) Then
                MsgBox("Error! Please enter numeric inputs only!")
            Else
                a4_i = a4.Text
                t4_i = t4.Text
                map4_i = map4.Text
                v4_i = v4.Text

                mk4.Text = (a4_i + t4_i + map4_i + v4_i) / 4
            End If
        End If

        If mak1Triggerd = True Or mak2Triggerd = True Or mak3Triggerd = True Or mak4Triggerd = True Then
            If mk1.Text = "" Or mk2.Text = "" Or mk3.Text = "" Or mk4.Text = "" Then
                mkFinal.Text = ""
            ElseIf Not IsNumeric(mk1.Text) Or Not IsNumeric(mk2.Text) Or Not IsNumeric(mk3.Text) Or Not IsNumeric(mk4.Text) Then
                MsgBox("Error! Please enter numeric inputs only!")
            Else
                mk1_i = mk1.Text
                mk2_i = mk2.Text
                mk3_i = mk3.Text
                mk4_i = mk4.Text

                mkFinal.Text = (mk1_i + mk2_i + mk3_i + mk4_i) / 4

                If mkFinal.Text >= 75 Then
                    mKRemarks.Text = "Passed"
                ElseIf mkFinal.Text > 100 Or mkFinal.Text < 65 Then
                    mKRemarks.Text = "Invalid!"
                Else
                    mKRemarks.Text = "Failed"
                End If
            End If
        End If
        'end of computing grade for MAKABAYAN
    End Sub

    Public Sub removeReadOnly()
        If Not f3.Text = "" And Not e3.Text = "" And Not m3.Text = "" And Not s3.Text = "" _
        And Not a3.Text = "" And Not t3.Text = "" And Not map3.Text = "" And Not v3.Text = "" Then

            f4.ReadOnly = False
            e4.ReadOnly = False
            m4.ReadOnly = False
            s4.ReadOnly = False
            a4.ReadOnly = False
            t4.ReadOnly = False
            map4.ReadOnly = False
            v4.ReadOnly = False

            f4.BackColor = Color.White
            e4.BackColor = Color.White
            m4.BackColor = Color.White
            s4.BackColor = Color.White
            a4.BackColor = Color.White
            t4.BackColor = Color.White
            map4.BackColor = Color.White
            v4.BackColor = Color.White

        ElseIf Not f2.Text = "" And Not e2.Text = "" And Not m2.Text = "" And Not s2.Text = "" _
        And Not a2.Text = "" And Not t2.Text = "" And Not map2.Text = "" And Not v2.Text = "" Then


            f3.ReadOnly = False
            e3.ReadOnly = False
            m3.ReadOnly = False
            s3.ReadOnly = False
            a3.ReadOnly = False
            t3.ReadOnly = False
            map3.ReadOnly = False
            v3.ReadOnly = False

            f3.BackColor = Color.White
            e3.BackColor = Color.White
            m3.BackColor = Color.White
            s3.BackColor = Color.White
            a3.BackColor = Color.White
            t3.BackColor = Color.White
            map3.BackColor = Color.White
            v3.BackColor = Color.White

        ElseIf Not f1.Text = "" And Not e1.Text = "" And Not m1.Text = "" And Not s1.Text = "" _
        And Not a1.Text = "" And Not t1.Text = "" And Not map1.Text = "" And Not v1.Text = "" Then


            f2.ReadOnly = False
            e2.ReadOnly = False
            m2.ReadOnly = False
            s2.ReadOnly = False
            a2.ReadOnly = False
            t2.ReadOnly = False
            map2.ReadOnly = False
            v2.ReadOnly = False

            f2.BackColor = Color.White
            e2.BackColor = Color.White
            m2.BackColor = Color.White
            s2.BackColor = Color.White
            a2.BackColor = Color.White
            t2.BackColor = Color.White
            map2.BackColor = Color.White
            v2.BackColor = Color.White

        End If
    End Sub
    
    Private Sub f1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f4.TextChanged, f3.TextChanged, f2.TextChanged, f1.TextChanged
        removeReadOnly()
        fTriggerd = True
        displayFinalRemarks()
        fTriggerd = False
    End Sub

    Private Sub e1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles e4.TextChanged, e3.TextChanged, e2.TextChanged, e1.TextChanged
        removeReadOnly()
        eTriggerd = True
        displayFinalRemarks()
        eTriggerd = False
    End Sub

    Private Sub m1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m4.TextChanged, m3.TextChanged, m2.TextChanged, m1.TextChanged
        removeReadOnly()
        mTriggerd = True
        displayFinalRemarks()
        mTriggerd = False
    End Sub

    Private Sub s1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles s4.TextChanged, s3.TextChanged, s2.TextChanged, s1.TextChanged
        removeReadOnly()
        sTriggerd = True
        displayFinalRemarks()
        sTriggerd = False
    End Sub

    'compute grade for MAKABAYAN
    Private Sub a1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles v1.TextChanged, t1.TextChanged, map1.TextChanged, a1.TextChanged
        removeReadOnly()
        atmapvTriggerd = True

        mak1Triggerd = True
        displayFinalRemarks()
        mak1Triggerd = False

        atmapvTriggerd = False
    End Sub

    Private Sub a2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles v2.TextChanged, t2.TextChanged, map2.TextChanged, a2.TextChanged
        removeReadOnly()
        atmapvTriggerd = True
        mak2Triggerd = True
        displayFinalRemarks()
        mak2Triggerd = False
        atmapvTriggerd = False
    End Sub

    Private Sub a3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles v3.TextChanged, t3.TextChanged, map3.TextChanged, a3.TextChanged
        removeReadOnly()
        atmapvTriggerd = True
        mak3Triggerd = True
        displayFinalRemarks()
        mak3Triggerd = False
        atmapvTriggerd = False
    End Sub

    Private Sub a4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles v4.TextChanged, t4.TextChanged, map4.TextChanged, a4.TextChanged
        removeReadOnly()
        atmapvTriggerd = True
        mak4Triggerd = True
        displayFinalRemarks()
        mak4Triggerd = False
        atmapvTriggerd = False
    End Sub
    'END OF computing grade for MAKABAYAN

    Private Sub aUnit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vUnit.TextChanged, tUnit.TextChanged, mapUnit.TextChanged, aUnit.TextChanged
        If aUnit.Text = "" Or tUnit.Text = "" Or mapUnit.Text = "" Or vUnit.Text = "" Then
            mkUnit.Text = ""
        Else
            aUnit_i = aUnit.Text
            tUnit_i = tUnit.Text
            mapUnit_i = mapUnit.Text
            vUnit_i = vUnit.Text

            mkUnit.Text = aUnit_i + tUnit_i + mapUnit_i + vUnit_i
        End If
    End Sub

    Private Sub fUnit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sUnit.TextChanged, mUnit.TextChanged, mkUnit.TextChanged, fUnit.TextChanged, eUnit.TextChanged
        If fUnit.Text = "" Or eUnit.Text = "" Or mUnit.Text = "" Or sUnit.Text = "" Or mkUnit.Text = "" Then
            totalUnits.Text = ""
        Else
            fUnit_i = fUnit.Text
            eUnit_i = eUnit.Text
            mUnit_i = mUnit.Text
            sUnit_i = sUnit.Text
            mkUnit_i = mkUnit.Text

            'displaying total units
            totalUnits_i = fUnit_i + eUnit_i + mUnit_i + sUnit_i + mkUnit_i
            totalUnits.Text = totalUnits_i

        End If
    End Sub

    Private Sub btnComputeFG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComputeFG.Click

        ' computing for final grade
        If fFinal.Text = "" Or eFinal.Text = "" Or mFinal.Text = "" Or sFinal.Text = "" Or mkFinal.Text = "" Then
            genAve.Text = ""
        Else
            If fUnit.Text = "" Or eUnit.Text = "" Or mUnit.Text = "" Or sUnit.Text = "" Or mkUnit.Text = "" Then
                MsgBox("Please fill in the units!")
            Else

                fTotal = fFinal.Text * fUnit_i
                eTotal = eFinal.Text * eUnit_i
                mTotal = mFinal.Text * mUnit_i
                sTotal = sFinal.Text * sUnit_i
                mkTotal = mkFinal.Text * mkUnit_i

                genAve_i = (fTotal + eTotal + mTotal + sTotal + mkTotal) / totalUnits.Text
                genAve.Text = genAve_i
                MsgBox("Gen Ave: " & genAve_i)

            End If
        End If
        ' end of computing for final grade
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If genAve.Text = "" Then
            MsgBox("Please compute for the General Average first!")
        ElseIf cboYearSection.Text = "" Or txtSearchStud.Text = "" Then
            MsgBox("Please enter student's Name and Year/Section!")
        Else
            SQL = "INSERT INTO stud_subj VALUES" & _
                         "('" & studId & "',101, 1, '" & cboYearSection.Text & "', '" & f1.Text & "')," & _
                         "('" & studId & "',102, 1, '" & cboYearSection.Text & "', '" & e1.Text & "')," & _
                         "('" & studId & "',103, 1, '" & cboYearSection.Text & "', '" & m1.Text & "')," & _
                         "('" & studId & "',104, 1, '" & cboYearSection.Text & "', '" & s1.Text & "')," & _
                         "('" & studId & "',105, 1, '" & cboYearSection.Text & "', '" & mk1.Text & "')," & _
                         "('" & studId & "',111, 1, '" & cboYearSection.Text & "', '" & a1.Text & "')," & _
                         "('" & studId & "',112, 1, '" & cboYearSection.Text & "', '" & map1.Text & "')," & _
                         "('" & studId & "',109, 1, '" & cboYearSection.Text & "', '" & v1.Text & "')," & _
                         "('" & studId & "',101, 2, '" & cboYearSection.Text & "', '" & f2.Text & "')," & _
                         "('" & studId & "',102, 2, '" & cboYearSection.Text & "', '" & e2.Text & "')," & _
                         "('" & studId & "',103, 2, '" & cboYearSection.Text & "', '" & m2.Text & "')," & _
                         "('" & studId & "',104, 2, '" & cboYearSection.Text & "', '" & s2.Text & "')," & _
                         "('" & studId & "',105, 2, '" & cboYearSection.Text & "', '" & mk2.Text & "')," & _
                         "('" & studId & "',111, 2, '" & cboYearSection.Text & "', '" & a2.Text & "')," & _
                         "('" & studId & "',112, 2, '" & cboYearSection.Text & "', '" & map2.Text & "')," & _
                         "('" & studId & "',109, 2, '" & cboYearSection.Text & "', '" & v2.Text & "')," & _
                         "('" & studId & "',101, 3, '" & cboYearSection.Text & "', '" & f3.Text & "')," & _
                         "('" & studId & "',102, 3, '" & cboYearSection.Text & "', '" & e3.Text & "')," & _
                         "('" & studId & "',103, 3, '" & cboYearSection.Text & "', '" & m3.Text & "')," & _
                         "('" & studId & "',104, 3, '" & cboYearSection.Text & "', '" & s3.Text & "')," & _
                         "('" & studId & "',105, 3, '" & cboYearSection.Text & "', '" & mk3.Text & "')," & _
                         "('" & studId & "',111, 3, '" & cboYearSection.Text & "', '" & a3.Text & "')," & _
                         "('" & studId & "',112, 3, '" & cboYearSection.Text & "', '" & map3.Text & "')," & _
                         "('" & studId & "',109, 3, '" & cboYearSection.Text & "', '" & v3.Text & "')," & _
                         "('" & studId & "',101, 4, '" & cboYearSection.Text & "', '" & f4.Text & "')," & _
                         "('" & studId & "',102, 4, '" & cboYearSection.Text & "', '" & e4.Text & "')," & _
                         "('" & studId & "',103, 4, '" & cboYearSection.Text & "', '" & m4.Text & "')," & _
                         "('" & studId & "',104, 4, '" & cboYearSection.Text & "', '" & s4.Text & "')," & _
                         "('" & studId & "',105, 4, '" & cboYearSection.Text & "', '" & mk4.Text & "')," & _
                         "('" & studId & "',111, 4, '" & cboYearSection.Text & "', '" & a4.Text & "')," & _
                         "('" & studId & "',112, 4, '" & cboYearSection.Text & "', '" & map4.Text & "')," & _
                         "('" & studId & "',109, 4, '" & cboYearSection.Text & "', '" & v4.Text & "')," & _
                         "('" & studId & "',101, 5, '" & cboYearSection.Text & "', '" & fFinal.Text & "')," & _
                         "('" & studId & "',102, 5, '" & cboYearSection.Text & "', '" & eFinal.Text & "')," & _
                         "('" & studId & "',103, 5, '" & cboYearSection.Text & "', '" & mFinal.Text & "')," & _
                         "('" & studId & "',104, 5, '" & cboYearSection.Text & "', '" & sFinal.Text & "')," & _
                         "('" & studId & "',105, 5, '" & cboYearSection.Text & "', '" & mkFinal.Text & "')," & _
                         "('" & studId & "',111, 5, '" & cboYearSection.Text & "', '" & aFinal.Text & "')," & _
                         "('" & studId & "',112, 5, '" & cboYearSection.Text & "', '" & mapFinal.Text & "')," & _
                         "('" & studId & "',109, 5, '" & cboYearSection.Text & "', '" & vFinal.Text & "')," & _
                         "('" & studId & "',110, 5, '" & cboYearSection.Text & "', '" & genAve.Text & "')"

            ' Try, Catch, Finally
            Try
                MysqlConn.Open()
                BNHSCommand.Connection = MysqlConn
                BNHSCommand.CommandText = SQL
                BNHSAdapter.SelectCommand = BNHSCommand
                BNHSAdapter.Fill(BNHSData)

                MessageBox.Show("Successfully saved!")

            Catch myerror As MySqlException
                MessageBox.Show(myerror.Message & "To modify existing grades please click the Edit Grades button")
            Finally
                MysqlConn.Close()
                MysqlConn.Dispose()
            End Try
        End If
        clearAllFields()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        clearAllFields()
    End Sub

    Private Sub txtSearchStud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchStud.Click
        txtSearchStud.Text = ""
    End Sub

    Public Sub clearAllFields()
        cboYearSection.Text = ""
        txtSearchStud.Text = ""
        txtName.Text = ""
        txtStudId.Text = ""
        f1.Text = ""
        f2.Text = ""
        f3.Text = ""
        f4.Text = ""
        e1.Text = ""
        e2.Text = ""
        e3.Text = ""
        e4.Text = ""
        m1.Text = ""
        m2.Text = ""
        m3.Text = ""
        m4.Text = ""
        s1.Text = ""
        s2.Text = ""
        s3.Text = ""
        s4.Text = ""
        mk1.Text = ""
        mk2.Text = ""
        mk3.Text = ""
        mk4.Text = ""
        a1.Text = ""
        a2.Text = ""
        a3.Text = ""
        a4.Text = ""
        t1.Text = ""
        t2.Text = ""
        t3.Text = ""
        t4.Text = ""
        map1.Text = ""
        map2.Text = ""
        map3.Text = ""
        map4.Text = ""
        v1.Text = ""
        v2.Text = ""
        v3.Text = ""
        v4.Text = ""

        fFinal.Text = ""
        eFinal.Text = ""
        mFinal.Text = ""
        sFinal.Text = ""
        mkFinal.Text = ""
        aFinal.Text = ""
        tFinal.Text = ""
        mapFinal.Text = ""
        vFinal.Text = ""

        fRemarks.Text = ""
        eRemarks.Text = ""
        mRemarks.Text = ""
        sRemarks.Text = ""
        mKRemarks.Text = ""
        aRemarks.Text = ""
        tRemarks.Text = ""
        mapRemarks.Text = ""
        vRemarks.Text = ""

        fUnit.Text = ""
        eUnit.Text = ""
        mUnit.Text = ""
        sUnit.Text = ""
        mkUnit.Text = ""
        aUnit.Text = ""
        tUnit.Text = ""
        mapUnit.Text = ""
        vUnit.Text = ""

        genAve.Text = ""
        totalUnits.Text = ""

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