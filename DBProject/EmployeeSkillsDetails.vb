Imports MySql.Data.MySqlClient
Public Class EmployeeSkillsDetails

    Private Sub EmployeeSkillsDetails_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Dim MySqlConn As MySqlConnection
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=isoptera.lcsc.edu;port=3306;userid=CS;password=cs445;database=cs445"
        Try
            MySqlConn.Open()
            Dim MySqlCmd As New MySqlCommand()
            MySqlCmd.Connection = MySqlConn
            Try 'SELECT ALL EMPLOYEES CERTS
                MySqlCmd.CommandText = "SELECT * FROM `cs445`.`EmployeeSkills_T`"
                Dim EmployeeSkillsAdapter As New MySqlDataAdapter(MySqlCmd)
                Dim EmployeeSkillsTable As New DataTable()
                EmployeeSkillsAdapter.Fill(EmployeeSkillsTable)
                EmployeeEdit.EmployeeSkillsDataGridView1.DataSource = EmployeeSkillsTable
                EmployeeSkillsTable.Dispose()
                EmployeeSkillsAdapter.Dispose()
            Catch exError As MySqlException
                MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
            End Try
        Catch exError As MySqlException
            MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
        Finally
            MySqlConn.Close()
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            Dim MySqlConn As MySqlConnection
            MySqlConn = New MySqlConnection
            MySqlConn.ConnectionString = "server=isoptera.lcsc.edu;port=3306;userid=CS;password=cs445;database=cs445"
            If CheckBox2.Checked Then
                Try
                    MySqlConn.Open()
                    Dim MySqlCmd As New MySqlCommand()
                    MySqlCmd.Connection = MySqlConn
                    MySqlCmd.CommandText = "DELETE FROM `cs445`.`EmployeeSkills_T` WHERE `EmployeeID`='" + ComboBoxEmpId.SelectedValue + "' AND `SkillID` ='" + ComboBoxSkillId.SelectedValue + "'"
                    MySqlCmd.ExecuteNonQuery()
                    MySqlCmd.Dispose()
                Catch exError As MySqlException
                    MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
                Finally
                    MySqlConn.Close()
                    MySqlConn.Dispose()
                End Try
            Else
                Try
                    MySqlConn.Open()
                    Dim MySqlCmd As New MySqlCommand()
                    MySqlCmd.Connection = MySqlConn
                    MySqlCmd.CommandText = "INSERT INTO `cs445`.`EmployeeSkills_T` (`EmployeeID`, `SkillID`, `QualifyDate`) VALUES ('" + ComboBoxEmpId.SelectedValue + "','" + ComboBoxSkillId.SelectedValue + "','" + TextBoxEmpCert.Text + "') ON DUPLICATE KEY UPDATE `QualifyDate`='" + TextBoxEmpCert.Text + "'"
                    MySqlCmd.ExecuteNonQuery()
                    MySqlCmd.Dispose()
                Catch exError As MySqlException
                    MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
                Finally
                    MySqlConn.Close()
                    MySqlConn.Dispose()
                End Try
            End If
        End If
        Close()
    End Sub

    Private Sub EmployeeSkillsDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MySqlConn As MySqlConnection
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=isoptera.lcsc.edu;port=3306;userid=CS;password=cs445;database=cs445"
        Try
            MySqlConn.Open()
            Dim MySqlCmd As New MySqlCommand()
            MySqlCmd.Connection = MySqlConn
            Try 'SELECT ALL EMPLOYEE ID's
                MySqlCmd.CommandText = "SELECT CONCAT(`EmployeeID`,': ',`EmployeeName`) AS `NAME`, `EmployeeID` FROM `cs445`.`Employee_T`;"
                Dim EmployeeAdapter As New MySqlDataAdapter(MySqlCmd)
                Dim EmployeeTable As New DataTable()
                EmployeeAdapter.Fill(EmployeeTable)
                If EmployeeTable.Rows.Count > 0 Then
                    ComboBoxEmpId.DataSource = EmployeeTable
                    ComboBoxEmpId.DisplayMember = "NAME"
                    ComboBoxEmpId.ValueMember = "EmployeeID"
                End If
                EmployeeAdapter.Dispose()
            Catch exError As MySqlException
                MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
            End Try
            Try 'SELECT ALL WORK LOCATIONS
                MySqlCmd.CommandText = "SELECT CONCAT(`SkillID`,': ',`SkillDescription`) AS `NAME`, `SkillID` FROM `cs445`.`Skill_T`"
                Dim SkillAdapter As New MySqlDataAdapter(MySqlCmd)
                Dim SkillTable As New DataTable()
                SkillAdapter.Fill(SkillTable)
                If SkillTable.Rows.Count > 0 Then
                    ComboBoxSkillId.DataSource = SkillTable
                    ComboBoxSkillId.DisplayMember = "NAME"
                    ComboBoxSkillId.ValueMember = "SkillID"
                End If
                SkillAdapter.Dispose()
            Catch exError As MySqlException
                MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
            End Try
        Catch exError As MySqlException
            MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
        Finally
            MySqlConn.Close()
            MySqlConn.Dispose()
        End Try
    End Sub
End Class