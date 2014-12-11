Imports MySql.Data.MySqlClient
Public Class SkillDetails

    Private Sub WorksCenterDetails_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Dim MySqlConn As MySqlConnection
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=isoptera.lcsc.edu;port=3306;userid=CS;password=cs445;database=cs445"
        Try
            MySqlConn.Open()
            Dim MySqlCmd As New MySqlCommand()
            MySqlCmd.Connection = MySqlConn
            Try 'SELECT ALL SKILLS
                MySqlCmd.CommandText = "SELECT * FROM `cs445`.`Skill_T`"
                Dim SkillAdapter As New MySqlDataAdapter(MySqlCmd)
                Dim SkillTable As New DataTable()
                SkillAdapter.Fill(SkillTable)
                EmployeeEdit.SkillDataGridView1.DataSource = SkillTable
                SkillTable.Dispose()
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
                    MySqlCmd.CommandText = "DELETE FROM `cs445`.`Skill_T` WHERE `SkillID`='" + TextBoxSkillId.Text + "'"
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
                    MySqlCmd.CommandText = "INSERT INTO `cs445`.`Skill_T` (`SkillID`, `SkillDescription`) VALUES ('" + TextBoxSkillId.Text + "','" + TextBoxSkillDesc.Text + "') ON DUPLICATE KEY UPDATE `SkillDescription`='" + TextBoxSkillDesc.Text + "'"
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