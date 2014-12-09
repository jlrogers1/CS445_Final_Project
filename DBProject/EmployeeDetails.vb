Public Class EmployeeDetails

    Private Sub EmployeeDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            Try
                MessageBox.Show("UPDATING!")
            Catch
                MessageBox.Show("ERROR UPDATING!")
            End Try
        End If
        Close()
    End Sub
End Class