Imports MySql.Data.MySqlClient
Public Class EmployeeEdit
    Dim MySqlConn As MySqlConnection
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
                EmployeeDataGridView1.DataSource = EmployeeTable
                EmployeeTable.Dispose()
                EmployeeAdapter.Dispose()
            Catch
                MessageBox.Show("An error occured when loading Employee_T")
            End Try
            Try 'SELECT ALL LOCATIONS EMPLOYEES WORK
                MySqlCmd.CommandText = "SELECT * FROM WorksIn_T"
                Dim WorksInAdapter As New MySqlDataAdapter(MySqlCmd)
                Dim WorksInTable As New DataTable()
                WorksInAdapter.Fill(WorksInTable)
                WorksInDataGridView1.DataSource = WorksInTable
                WorksInTable.Dispose()
                WorksInAdapter.Dispose()
            Catch
                MessageBox.Show("An error occured when loading WorksIn_T")
            End Try
            Try 'SELECT ALL SKILLS EMPLOYEES HAVE
                MySqlCmd.CommandText = "SELECT * FROM EmployeeSkills_T"
                Dim EmployeeSkillsAdapter As New MySqlDataAdapter(MySqlCmd)
                Dim EmployeeSkillsTable As New DataTable()
                EmployeeSkillsAdapter.Fill(EmployeeSkillsTable)
                EmployeeSkillsDataGridView1.DataSource = EmployeeSkillsTable
                EmployeeSkillsTable.Dispose()
                EmployeeSkillsAdapter.Dispose()
            Catch
                MessageBox.Show("An error occured when loading EmployeeSkills_T")
            End Try
            Try 'SELECT ALL SKILLS
                MySqlCmd.CommandText = "SELECT * FROM Skill_T"
                Dim SkillAdapter As New MySqlDataAdapter(MySqlCmd)
                Dim SkillTable As New DataTable()
                SkillAdapter.Fill(SkillTable)
                SkillDataGridView1.DataSource = SkillTable
                SkillTable.Dispose()
                SkillAdapter.Dispose()
            Catch
                MessageBox.Show("An error occured when loading Skill_T")
            End Try
            MySqlCmd.Dispose()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Close()
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub EmployeeDataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmployeeDataGridView1.CellDoubleClick
        Try
            Dim EmployeeDetailsForm As New EmployeeDetails()
            Try
                EmployeeDetailsForm.TextBoxEmpId.Text = sender.CurrentRow.Cells(0).Value
            Catch
                EmployeeDetailsForm.TextBoxEmpId.Text = "NULL"
                MessageBox.Show("An error occured: emp id")
            End Try
            Try
                EmployeeDetailsForm.TextBoxEmpName.Text = sender.CurrentRow.Cells(1).Value
            Catch
                EmployeeDetailsForm.TextBoxEmpName.Text = "NULL"
                MessageBox.Show("An error occured: name")
            End Try
            Try
                EmployeeDetailsForm.TextBoxEmpAddr.Text = sender.CurrentRow.Cells(2).Value
            Catch
                EmployeeDetailsForm.TextBoxEmpAddr.Text = "NULL"
                MessageBox.Show("An error occured: address")
            End Try
            Try
                EmployeeDetailsForm.TextBoxEmpCity.Text = sender.CurrentRow.Cells(3).Value
            Catch
                EmployeeDetailsForm.TextBoxEmpCity.Text = "NULL"
                MessageBox.Show("An error occured: city")
            End Try
            Try
                EmployeeDetailsForm.TextBoxEmpState.Text = sender.CurrentRow.Cells(4).Value
            Catch
                EmployeeDetailsForm.TextBoxEmpState.Text = "NULL"
                MessageBox.Show("An error occured: state")
            End Try
            Try
                EmployeeDetailsForm.TextBoxEmpZip.Text = sender.CurrentRow.Cells(5).Value
            Catch
                EmployeeDetailsForm.TextBoxEmpZip.Text = "NULL"
                MessageBox.Show("An error occured: zip code")
            End Try
            Try
                EmployeeDetailsForm.TextBoxEmpBirth.Text = sender.CurrentRow.Cells(6).Value
            Catch
                EmployeeDetailsForm.TextBoxEmpBirth.Text = "01/01/1753"
                MessageBox.Show("An error occured: birth date, setting to default 01/01/1753")
            End Try
            Try
                EmployeeDetailsForm.TextBoxEmpHired.Text = sender.CurrentRow.Cells(7).Value
            Catch
                EmployeeDetailsForm.TextBoxEmpHired.Text = "01/01/1753"
                MessageBox.Show("An error occured: hire date, setting to default 01/01/1753")
            End Try
            Try
                EmployeeDetailsForm.TextBoxEmpSuperID.Text = sender.CurrentRow.Cells(8).Value
            Catch
                EmployeeDetailsForm.TextBoxEmpSuperID.Text = "NULL"
                MessageBox.Show("An error occured: supervisor id")
            End Try
            EmployeeDetailsForm.ShowDialog()
        Catch
            MessageBox.Show("An error occured when trying to view this employee")
        End Try
    End Sub
End Class