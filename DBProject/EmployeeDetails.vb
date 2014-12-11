Imports MySql.Data.MySqlClient
Public Class EmployeeDetails

    Private Sub EmployeeDetails_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Dim MySqlConn As MySqlConnection
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=isoptera.lcsc.edu;port=3306;userid=CS;password=cs445;database=cs445"
        Try
            MySqlConn.Open()
            Dim MySqlCmd As New MySqlCommand()
            MySqlCmd.Connection = MySqlConn
            Try 'SELECT ALL EMPLOYEES
                MySqlCmd.CommandText = "SELECT * FROM Employee_T"
                Dim EmployeeAdapter As New MySqlDataAdapter(MySqlCmd)
                Dim EmployeeTable As New DataTable()
                EmployeeAdapter.Fill(EmployeeTable)
                EmployeeEdit.EmployeeDataGridView1.DataSource = EmployeeTable
                EmployeeTable.Dispose()
                EmployeeAdapter.Dispose()
            Catch
                MessageBox.Show("An error occured when loading Employee_T")
            End Try
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
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
                    MySqlCmd.CommandText = "DELETE FROM `cs445`.`Employee_T` WHERE `EmployeeID`='" + TextBoxEmpId.Text + "'"
                    MySqlCmd.ExecuteNonQuery()
                    MySqlCmd.Dispose()
                Catch
                    MessageBox.Show("Unable to update record, sorry!")
                Finally
                    MySqlConn.Close()
                    MySqlConn.Dispose()
                End Try
            Else
                Try
                    MySqlConn.Open()
                    Dim MySqlCmd As New MySqlCommand()
                    MySqlCmd.Connection = MySqlConn
                    MySqlCmd.CommandText = "INSERT INTO `cs445`.`Employee_T` (`EmployeeID`, `EmployeeName`, `EmployeeAddress`, `EmployeeCity`, `EmployeeState`, `EmployeeZip`, `EmployeeBirthDate`, `EmployeeDateHired`, `EmployeeSupervisor`) VALUES ('" + TextBoxEmpId.Text + "','" + TextBoxEmpName.Text + "','" + TextBoxEmpAddr.Text + "','" + TextBoxEmpCity.Text + "','" + TextBoxEmpState.Text + "','" + TextBoxEmpZip.Text + "','" + TextBoxEmpBirth.Text + "','" + TextBoxEmpHired.Text + "','" + TextBoxEmpSuperID.Text + "') ON DUPLICATE KEY UPDATE `EmployeeName`='" + TextBoxEmpName.Text + "', `EmployeeAddress`='" + TextBoxEmpAddr.Text + "', `EmployeeCity`='" + TextBoxEmpCity.Text + "', `EmployeeState`='" + TextBoxEmpState.Text + "', `EmployeeZip`='" + TextBoxEmpZip.Text + "', `EmployeeBirthDate`='" + TextBoxEmpBirth.Text + "', `EmployeeDateHired`='" + TextBoxEmpHired.Text + "', `EmployeeSupervisor`='" + TextBoxEmpSuperID.Text + "'"
                    MySqlCmd.ExecuteNonQuery()
                    MySqlCmd.Dispose()
                Catch
                    MessageBox.Show("Unable to update record, sorry!")
                Finally
                    MySqlConn.Close()
                    MySqlConn.Dispose()
                End Try
            End If
        End If
            Close()
    End Sub
End Class