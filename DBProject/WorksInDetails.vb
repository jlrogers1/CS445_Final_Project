Imports MySql.Data.MySqlClient
Public Class WorksInDetails

    Private Sub EmployeeDetails_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Dim MySqlConn As MySqlConnection
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=isoptera.lcsc.edu;port=3306;userid=CS;password=cs445;database=cs445"
        Try
            MySqlConn.Open()
            Dim MySqlCmd As New MySqlCommand()
            MySqlCmd.Connection = MySqlConn
            Try 'SELECT ALL LOCATIONS EMPLOYEES WORK
                MySqlCmd.CommandText = "SELECT * FROM WorksIn_T"
                Dim WorksInAdapter As New MySqlDataAdapter(MySqlCmd)
                Dim WorksInTable As New DataTable()
                WorksInAdapter.Fill(WorksInTable)
                EmployeeEdit.WorksInDataGridView1.DataSource = WorksInTable
                WorksInTable.Dispose()
                WorksInAdapter.Dispose()
            Catch
                MessageBox.Show("An error occured when loading WorksIn_T")
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
                    MySqlCmd.CommandText = "DELETE FROM `cs445`.`WorksIn_T` WHERE `EmployeeID`='" + TextBoxEmpId.Text + "' AND `WorkCenterID` ='" + TextBoxEmpWorkCenterID.Text +"'"
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
                    MySqlCmd.CommandText = "INSERT INTO `cs445`.`WorksIn_T` (`EmployeeID`, `WorkCenterID`) VALUES ('" + TextBoxEmpId.Text + "','" + TextBoxEmpWorkCenterID.Text + "') ON DUPLICATE KEY UPDATE `WorkCenterID`='" + TextBoxEmpWorkCenterID.Text + "'"
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

    Private Sub WorksInDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxEmpId.DataSource = EmployeeEdit.EmployeeDataGridView1
        'TextBoxEmpId.ValueMember = "EmployeeID"
        'TextBoxEmpId.DisplayMember = "EmployeeName"
    End Sub
End Class