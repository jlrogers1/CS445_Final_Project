Imports MySql.Data.MySqlClient
Public Class EmployeeEdit
    Dim MySqlConn As MySqlConnection
    Private Sub PVFCMSMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=isoptera.lcsc.edu;port=3306;userid=CS;password=cs445;database=cs445"
        Try
            MySqlConn.Open()
            Dim MySqlCmd As New MySqlCommand()
            MySqlCmd.Connection = MySqlConn
            Try 'SELECT ALL EMPLOYEES
                MySqlCmd.CommandText = "SELECT * FROM `cs445`.`Employee_T`"
                Dim EmployeeAdapter As New MySqlDataAdapter(MySqlCmd)
                Dim EmployeeTable As New DataTable()
                EmployeeAdapter.Fill(EmployeeTable)
                EmployeeDataGridView1.DataSource = EmployeeTable
                EmployeeTable.Dispose()
                EmployeeAdapter.Dispose()
            Catch exError As MySqlException
                MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
            End Try
            Try 'SELECT ALL LOCATIONS EMPLOYEES WORK
                MySqlCmd.CommandText = "SELECT * FROM `cs445`.`WorksIn_T`"
                Dim WorksInAdapter As New MySqlDataAdapter(MySqlCmd)
                Dim WorksInTable As New DataTable()
                WorksInAdapter.Fill(WorksInTable)
                WorksInDataGridView1.DataSource = WorksInTable
                WorksInTable.Dispose()
                WorksInAdapter.Dispose()
            Catch exError As MySqlException
                MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
            End Try
            Try 'SELECT ALL WORK LOCATIONS
                MySqlCmd.CommandText = "SELECT * FROM `cs445`.`WorkCenter_T`"
                Dim WorkCenterAdapter As New MySqlDataAdapter(MySqlCmd)
                Dim WorkCenterTable As New DataTable()
                WorkCenterAdapter.Fill(WorkCenterTable)
                WorkCenterDataGridView1.DataSource = WorkCenterTable
                WorkCenterTable.Dispose()
                WorkCenterAdapter.Dispose()
            Catch exError As MySqlException
                MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
            End Try
            Try 'SELECT ALL SKILLS EMPLOYEES HAVE
                MySqlCmd.CommandText = "SELECT * FROM `cs445`.`EmployeeSkills_T`"
                Dim EmployeeSkillsAdapter As New MySqlDataAdapter(MySqlCmd)
                Dim EmployeeSkillsTable As New DataTable()
                EmployeeSkillsAdapter.Fill(EmployeeSkillsTable)
                EmployeeSkillsDataGridView1.DataSource = EmployeeSkillsTable
                EmployeeSkillsTable.Dispose()
                EmployeeSkillsAdapter.Dispose()
            Catch exError As MySqlException
                MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
            End Try
            Try 'SELECT ALL SKILLS
                MySqlCmd.CommandText = "SELECT * FROM `cs445`.`Skill_T`"
                Dim SkillAdapter As New MySqlDataAdapter(MySqlCmd)
                Dim SkillTable As New DataTable()
                SkillAdapter.Fill(SkillTable)
                SkillDataGridView1.DataSource = SkillTable
                SkillTable.Dispose()
                SkillAdapter.Dispose()
            Catch exError As MySqlException
                MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
            End Try
            MySqlCmd.Dispose()
        Catch exError As MySqlException
            MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
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
        Catch exError As MySqlException
            MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
        End Try
    End Sub

    Private Sub WorksInDataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles WorksInDataGridView1.CellDoubleClick
        Try
            Dim WorksInDetailsForm As New WorksInDetails()
            Try
                'This is not working yet
                'WorksInDetailsForm.ComboBoxEmpId.SelectedIndex = WorksInDetailsForm.ComboBoxEmpId.FindString(sender.CurrentRow.Cells(0).Value)
            Catch
                MessageBox.Show("An error occured: emp id")
            End Try
            Try
                'This is not working yet
                'WorksInDetailsForm.ComboBoxWorkCenterId.SelectedIndex = WorksInDetailsForm.ComboBoxWorkCenterId.FindString(sender.CurrentRow.Cells(1).Value)
            Catch
                MessageBox.Show("An error occured: work center id")
            End Try
            WorksInDetailsForm.ShowDialog()
        Catch exError As MySqlException
            MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
        End Try
    End Sub

    Private Sub WorkCenterDataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles WorkCenterDataGridView1.CellDoubleClick
        Try
            Dim WorkCenterDetailsForm As New WorksCenterDetails()
            Try
                WorkCenterDetailsForm.TextBoxWorkCenterId.Text = sender.CurrentRow.Cells(0).Value
            Catch
                MessageBox.Show("An error occured: work center id")
            End Try
            Try
                WorkCenterDetailsForm.TextBoxWorkCenterDesc.Text = sender.CurrentRow.Cells(1).Value
            Catch
                MessageBox.Show("An error occured: work center desc")
            End Try
            WorkCenterDetailsForm.ShowDialog()
        Catch exError As MySqlException
            MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
        End Try
    End Sub

    Private Sub EmployeeSkillsDataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmployeeSkillsDataGridView1.CellDoubleClick
        Try
            Dim EmployeeSkillsDetailsForm As New EmployeeSkillsDetails()
            Try
                'This is not working yet
                'EmployeeSkillsDetailsForm.ComboBoxEmpId.Text = sender.CurrentRow.Cells(0).Value
            Catch
                MessageBox.Show("An error occured: emp id")
            End Try
            Try
                'This is not working yet
                'EmployeeSkillsDetailsForm.ComboBoxSkillId.Text = sender.CurrentRow.Cells(1).Value
            Catch
                MessageBox.Show("An error occured: skill id")
            End Try
            Try
                EmployeeSkillsDetailsForm.TextBoxEmpCert.Text = sender.CurrentRow.Cells(2).Value
            Catch
                EmployeeSkillsDetailsForm.TextBoxEmpCert.Text = "01/01/1753"
                MessageBox.Show("An error occured: cert date, setting to default 01/01/1753")
            End Try
            EmployeeSkillsDetailsForm.ShowDialog()
        Catch exError As MySqlException
            MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
        End Try
    End Sub

    Private Sub SkillDataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles SkillDataGridView1.CellDoubleClick
        Try
            Dim SkillDetailsForm As New SkillDetails()
            Try
                SkillDetailsForm.TextBoxSkillId.Text = sender.CurrentRow.Cells(0).Value
            Catch
                MessageBox.Show("An error occured: work center id")
            End Try
            Try
                SkillDetailsForm.TextBoxSkillDesc.Text = sender.CurrentRow.Cells(1).Value
            Catch
                MessageBox.Show("An error occured: work center desc")
            End Try
            SkillDetailsForm.ShowDialog()
        Catch exError As MySqlException
            MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
        End Try
    End Sub

    Private Sub RefreshTablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshTablesToolStripMenuItem.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=isoptera.lcsc.edu;port=3306;userid=CS;password=cs445;database=cs445"
        Try
            MySqlConn.Open()
            Dim MySqlCmd As New MySqlCommand()
            MySqlCmd.Connection = MySqlConn
            Try 'SELECT ALL EMPLOYEES
                MySqlCmd.CommandText = "SELECT * FROM `cs445`.`Employee_T`"
                Dim EmployeeAdapter As New MySqlDataAdapter(MySqlCmd)
                Dim EmployeeTable As New DataTable()
                EmployeeAdapter.Fill(EmployeeTable)
                EmployeeDataGridView1.DataSource = EmployeeTable
                EmployeeTable.Dispose()
                EmployeeAdapter.Dispose()
            Catch exError As MySqlException
                MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
            End Try
            Try 'SELECT ALL WORK LOCATIONS
                MySqlCmd.CommandText = "SELECT * FROM `cs445`.`WorkCenter_T`"
                Dim WorkCenterAdapter As New MySqlDataAdapter(MySqlCmd)
                Dim WorkCenterTable As New DataTable()
                WorkCenterAdapter.Fill(WorkCenterTable)
                WorkCenterDataGridView1.DataSource = WorkCenterTable
                WorkCenterTable.Dispose()
                WorkCenterAdapter.Dispose()
            Catch exError As MySqlException
                MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
            End Try
            Try 'SELECT ALL LOCATIONS EMPLOYEES WORK
                MySqlCmd.CommandText = "SELECT * FROM `cs445`.`WorksIn_T`"
                Dim WorksInAdapter As New MySqlDataAdapter(MySqlCmd)
                Dim WorksInTable As New DataTable()
                WorksInAdapter.Fill(WorksInTable)
                WorksInDataGridView1.DataSource = WorksInTable
                WorksInTable.Dispose()
                WorksInAdapter.Dispose()
            Catch exError As MySqlException
                MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
            End Try
            Try 'SELECT ALL SKILLS EMPLOYEES HAVE
                MySqlCmd.CommandText = "SELECT * FROM `cs445`.`EmployeeSkills_T`"
                Dim EmployeeSkillsAdapter As New MySqlDataAdapter(MySqlCmd)
                Dim EmployeeSkillsTable As New DataTable()
                EmployeeSkillsAdapter.Fill(EmployeeSkillsTable)
                EmployeeSkillsDataGridView1.DataSource = EmployeeSkillsTable
                EmployeeSkillsTable.Dispose()
                EmployeeSkillsAdapter.Dispose()
            Catch exError As MySqlException
                MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
            End Try
            Try 'SELECT ALL SKILLS
                MySqlCmd.CommandText = "SELECT * FROM `cs445`.`Skill_T`"
                Dim SkillAdapter As New MySqlDataAdapter(MySqlCmd)
                Dim SkillTable As New DataTable()
                SkillAdapter.Fill(SkillTable)
                SkillDataGridView1.DataSource = SkillTable
                SkillTable.Dispose()
                SkillAdapter.Dispose()
            Catch exError As MySqlException
                MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
            End Try
            MySqlCmd.Dispose()
        Catch exError As MySqlException
            MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
        Finally
            MySqlConn.Close()
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub AddEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEmployeeToolStripMenuItem.Click
        Try
            Dim EmployeeDetailsForm As New EmployeeDetails()
            EmployeeDetailsForm.ShowDialog()
        Catch exError As MySqlException
            MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
        End Try
    End Sub

    Private Sub AddEmployeeWorkplaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEmployeeWorkplaceToolStripMenuItem.Click
        Try
            Dim EmployeeWorplaceForm As New WorksInDetails()
            EmployeeWorplaceForm.ShowDialog()
        Catch exError As MySqlException
            MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
        End Try
    End Sub

    Private Sub AddWorkplaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddWorkplaceToolStripMenuItem.Click
        Try
            Dim WorkplaceForm As New WorksCenterDetails()
            WorkplaceForm.ShowDialog()
        Catch exError As MySqlException
            MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
        End Try
    End Sub

    Private Sub AddEmployeeSkillToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEmployeeSkillToolStripMenuItem.Click
        Try
            Dim SkillForm As New EmployeeSkillsDetails()
            SkillForm.ShowDialog()
        Catch exError As MySqlException
            MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
        End Try
    End Sub

    Private Sub AddSkillsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSkillsToolStripMenuItem.Click
        Try
            Dim SkillForm As New SkillDetails()
            SkillForm.ShowDialog()
        Catch exError As MySqlException
            MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
        End Try
    End Sub


End Class