Imports MySql.Data.MySqlClient
Public Class WorksCenterDetails

    Private Sub WorksCenterDetails_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Dim MySqlConn As MySqlConnection
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=isoptera.lcsc.edu;port=3306;userid=CS;password=cs445;database=cs445"
        Try
            MySqlConn.Open()
            Dim MySqlCmd As New MySqlCommand()
            MySqlCmd.Connection = MySqlConn
            Try 'SELECT ALL LOCATIONS EMPLOYEES WORK
                MySqlCmd.CommandText = "SELECT * FROM WorkCenter_T"
                Dim WorksCenterAdapter As New MySqlDataAdapter(MySqlCmd)
                Dim WorksCenterTable As New DataTable()
                WorksCenterAdapter.Fill(WorksCenterTable)
                EmployeeEdit.WorkCenterDataGridView1.DataSource = WorksCenterTable
                WorksCenterTable.Dispose()
                WorksCenterAdapter.Dispose()
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
                    MySqlCmd.CommandText = "DELETE FROM `cs445`.`WorkCenter_T` WHERE `WorkCenterID`='" + TextBoxWorkCenterId.Text + "'"
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
                    MySqlCmd.CommandText = "INSERT INTO `cs445`.`WorkCenter_T` (`WorkCenterID`, `WorkCenterLocation`) VALUES ('" + TextBoxWorkCenterId.Text + "','" + TextBoxWorkCenterDesc.Text + "') ON DUPLICATE KEY UPDATE `WorkCenterLocation`='" + TextBoxWorkCenterDesc.Text + "'"
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
End Class