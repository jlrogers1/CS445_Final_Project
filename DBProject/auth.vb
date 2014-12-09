Imports MySql.Data.MySqlClient

Public Class auth
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=isoptera.lcsc.edu;port=3306;userid='" & TextBox_UN.Text & "';password='" & TextBox_Pwd.Text & "';database='" & TextBox_DB.Text & "'"
        Try
            MySqlConn.Open()
            MessageBox.Show("Connection Established!")
            


            MySqlConn.Close()
            
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub TextBox_UN_TextChanged(sender As Object, e As EventArgs) Handles TextBox_UN.TextChanged

    End Sub

    Private Sub TextBox_Pwd_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Pwd.TextChanged

    End Sub

    Private Sub TextBox_DB_TextChanged(sender As Object, e As EventArgs) Handles TextBox_DB.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class