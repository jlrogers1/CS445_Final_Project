Imports MySql.Data.MySqlClient
Public Class Form1
    Dim MySqlConn As MySqlConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=isoptera.lcsc.edu;port=3306;userid=CS;password=cs445;database=cs445"
        Try
            MySqlConn.Open()
            MessageBox.Show("Connecton Established!")
            Dim MyTable As New DataTable()
            Dim MySqlCmd As New MySqlCommand()
            MySqlCmd.Connection = MySqlConn
            MySqlCmd.CommandText = "SELECT * FROM Customer_T"
            Dim MyAdapter As New MySqlDataAdapter(MySqlCmd)
            MyAdapter.Fill(MyTable)
            DataGridView1.DataSource = MyTable
            MySqlConn.Close()
            MyTable.Dispose()
            MySqlCmd.Dispose()
            MyAdapter.Dispose()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub
End Class