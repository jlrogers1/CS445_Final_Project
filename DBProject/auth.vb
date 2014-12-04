Imports MySql.Data.MySqlClient

Public Class auth
    Dim MySqlConn As MySqlConnection


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=isoptera.lcsc.edu;port=3306;userid=CS;password=cs445;database=cs445"

        Try
            MySqlConn.Open()
            Dim Command As MySqlCommand

            MySqlConn.Close()
            
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub
End Class