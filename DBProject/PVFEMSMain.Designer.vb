<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.EmployeeDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.WorksInDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.EmployeeSkillsDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.SkillDataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.EmployeeDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.WorksInDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.EmployeeSkillsDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.SkillDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmployeeDataGridView1
        '
        Me.EmployeeDataGridView1.AllowUserToAddRows = False
        Me.EmployeeDataGridView1.AllowUserToDeleteRows = False
        Me.EmployeeDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EmployeeDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmployeeDataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.EmployeeDataGridView1.Name = "EmployeeDataGridView1"
        Me.EmployeeDataGridView1.ReadOnly = True
        Me.EmployeeDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmployeeDataGridView1.Size = New System.Drawing.Size(770, 529)
        Me.EmployeeDataGridView1.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(784, 561)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.EmployeeDataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(776, 535)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Employees"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.WorksInDataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(776, 535)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Work Location"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'WorksInDataGridView1
        '
        Me.WorksInDataGridView1.AllowUserToAddRows = False
        Me.WorksInDataGridView1.AllowUserToDeleteRows = False
        Me.WorksInDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.WorksInDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WorksInDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorksInDataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.WorksInDataGridView1.Name = "WorksInDataGridView1"
        Me.WorksInDataGridView1.ReadOnly = True
        Me.WorksInDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.WorksInDataGridView1.Size = New System.Drawing.Size(770, 529)
        Me.WorksInDataGridView1.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.EmployeeSkillsDataGridView1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(776, 535)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Emp Skills"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'EmployeeSkillsDataGridView1
        '
        Me.EmployeeSkillsDataGridView1.AllowUserToAddRows = False
        Me.EmployeeSkillsDataGridView1.AllowUserToDeleteRows = False
        Me.EmployeeSkillsDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EmployeeSkillsDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeSkillsDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmployeeSkillsDataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.EmployeeSkillsDataGridView1.Name = "EmployeeSkillsDataGridView1"
        Me.EmployeeSkillsDataGridView1.ReadOnly = True
        Me.EmployeeSkillsDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmployeeSkillsDataGridView1.Size = New System.Drawing.Size(770, 529)
        Me.EmployeeSkillsDataGridView1.TabIndex = 3
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.SkillDataGridView1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(776, 535)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Skills"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'SkillDataGridView1
        '
        Me.SkillDataGridView1.AllowUserToAddRows = False
        Me.SkillDataGridView1.AllowUserToDeleteRows = False
        Me.SkillDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SkillDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SkillDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SkillDataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.SkillDataGridView1.Name = "SkillDataGridView1"
        Me.SkillDataGridView1.ReadOnly = True
        Me.SkillDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SkillDataGridView1.Size = New System.Drawing.Size(770, 529)
        Me.SkillDataGridView1.TabIndex = 3
        '
        'EmployeeEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "EmployeeEdit"
        Me.Text = "PVF Employee Management System"
        CType(Me.EmployeeDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.WorksInDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.EmployeeSkillsDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.SkillDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EmployeeDataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents WorksInDataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents EmployeeSkillsDataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SkillDataGridView1 As System.Windows.Forms.DataGridView

End Class
