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
End Class