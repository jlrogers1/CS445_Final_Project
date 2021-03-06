﻿Imports MySql.Data.MySqlClient
Public Class WorksInDetails

    Private Sub WorksInDetails_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Dim MySqlConn As MySqlConnection
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=isoptera.lcsc.edu;port=3306;userid=CS;password=cs445;database=cs445"
        Try
            MySqlConn.Open()
            Dim MySqlCmd As New MySqlCommand()
            MySqlCmd.Connection = MySqlConn
            Try 'SELECT ALL LOCATIONS EMPLOYEES WORK
                MySqlCmd.CommandText = "SELECT * FROM `cs445`.`WorksIn_T`"
                Dim WorksInAdapter As New MySqlDataAdapter(MySqlCmd)
                Dim WorksInTable As New DataTable()
                WorksInAdapter.Fill(WorksInTable)
                EmployeeEdit.WorksInDataGridView1.DataSource = WorksInTable
                WorksInTable.Dispose()
                WorksInAdapter.Dispose()
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
                    MySqlCmd.CommandText = "DELETE FROM `cs445`.`WorksIn_T` WHERE `EmployeeID`='" + ComboBoxEmpId.SelectedValue + "' AND `WorkCenterID` ='" + ComboBoxWorkCenterId.SelectedValue + "'"
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
                    MySqlCmd.CommandText = "INSERT INTO `cs445`.`WorksIn_T` (`EmployeeID`, `WorkCenterID`) VALUES ('" + ComboBoxEmpId.SelectedValue + "','" + ComboBoxWorkCenterId.SelectedValue + "')"
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

    Private Sub WorksInDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MySqlConn As MySqlConnection
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=isoptera.lcsc.edu;port=3306;userid=CS;password=cs445;database=cs445"
        Try
            MySqlConn.Open()
            Dim MySqlCmd As New MySqlCommand()
            MySqlCmd.Connection = MySqlConn
            Try 'SELECT ALL EMPLOYEE ID's
                MySqlCmd.CommandText = "SELECT CONCAT(`EmployeeID`,': ',`EmployeeName`) AS `NAME`, `EmployeeID` FROM `cs445`.`Employee_T`;"
                Dim EmployeeAdapter As New MySqlDataAdapter(MySqlCmd)
                Dim EmployeeTable As New DataTable()
                EmployeeAdapter.Fill(EmployeeTable)
                If EmployeeTable.Rows.Count > 0 Then
                    ComboBoxEmpId.DataSource = EmployeeTable
                    ComboBoxEmpId.DisplayMember = "NAME"
                    ComboBoxEmpId.ValueMember = "EmployeeID"
                End If
                EmployeeAdapter.Dispose()
            Catch exError As MySqlException
                MsgBox("An Error Occurred. " & exError.Number & " – " & exError.Message)
            End Try
            Try 'SELECT ALL WORK LOCATIONS
                MySqlCmd.CommandText = "SELECT `WorkCenterLocation`, `WorkCenterID` FROM `cs445`.`WorkCenter_T`"
                Dim WorkCenterAdapter As New MySqlDataAdapter(MySqlCmd)
                Dim WorkCenterTable As New DataTable()
                WorkCenterAdapter.Fill(WorkCenterTable)
                If WorkCenterTable.Rows.Count > 0 Then
                    ComboBoxWorkCenterId.DataSource = WorkCenterTable
                    ComboBoxWorkCenterId.DisplayMember = "NAME"
                    ComboBoxWorkCenterId.ValueMember = "WorkCenterID"
                End If
                WorkCenterAdapter.Dispose()
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
End Class