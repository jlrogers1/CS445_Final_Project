Imports MySql.Data.MySqlClient

Public Class auth
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim Authenticated = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox_DB.Text = "cs445"
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=isoptera.lcsc.edu;port=3306;userid='" + TextBox_UN.Text + "';password='" + TextBox_Pwd.Text + "';database='" + TextBox_DB.Text + "'"
        Try
            MySqlConn.Open()
            MySqlConn.Close()
            Authenticated = True
        Catch exError As MySqlException
            Authenticated = False
            MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
        Finally
            MySqlConn.Dispose()
            Try
                If Authenticated = True Then
                    Try
                        Dim PVFMain As New EmployeeEdit()
                        Me.Hide()
                        PVFMain.Show()
                    Catch
                        MsgBox("An Error Occurred.")
                    End Try
                End If
            Catch
                Authenticated = False
                MsgBox("An Error Occurred.")
            End Try
        End Try
    End Sub
End Class