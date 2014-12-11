<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeDetails
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxEmpAddr = New System.Windows.Forms.TextBox()
        Me.TextBoxEmpCity = New System.Windows.Forms.TextBox()
        Me.TextBoxEmpState = New System.Windows.Forms.TextBox()
        Me.TextBoxEmpZip = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxEmpName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxEmpSuperID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxEmpId = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBoxEmpBirth = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxEmpHired = New System.Windows.Forms.DateTimePicker()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Street Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "City"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(248, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "State"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(322, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Zip Code"
        '
        'TextBoxEmpAddr
        '
        Me.TextBoxEmpAddr.Location = New System.Drawing.Point(102, 32)
        Me.TextBoxEmpAddr.MaxLength = 30
        Me.TextBoxEmpAddr.Name = "TextBoxEmpAddr"
        Me.TextBoxEmpAddr.Size = New System.Drawing.Size(388, 20)
        Me.TextBoxEmpAddr.TabIndex = 1
        '
        'TextBoxEmpCity
        '
        Me.TextBoxEmpCity.Location = New System.Drawing.Point(42, 58)
        Me.TextBoxEmpCity.MaxLength = 20
        Me.TextBoxEmpCity.Name = "TextBoxEmpCity"
        Me.TextBoxEmpCity.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxEmpCity.TabIndex = 2
        '
        'TextBoxEmpState
        '
        Me.TextBoxEmpState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxEmpState.Location = New System.Drawing.Point(286, 58)
        Me.TextBoxEmpState.MaxLength = 2
        Me.TextBoxEmpState.Name = "TextBoxEmpState"
        Me.TextBoxEmpState.Size = New System.Drawing.Size(30, 20)
        Me.TextBoxEmpState.TabIndex = 3
        '
        'TextBoxEmpZip
        '
        Me.TextBoxEmpZip.Location = New System.Drawing.Point(378, 58)
        Me.TextBoxEmpZip.MaxLength = 10
        Me.TextBoxEmpZip.Name = "TextBoxEmpZip"
        Me.TextBoxEmpZip.Size = New System.Drawing.Size(112, 20)
        Me.TextBoxEmpZip.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Employee Name"
        '
        'TextBoxEmpName
        '
        Me.TextBoxEmpName.Location = New System.Drawing.Point(102, 6)
        Me.TextBoxEmpName.MaxLength = 25
        Me.TextBoxEmpName.Name = "TextBoxEmpName"
        Me.TextBoxEmpName.Size = New System.Drawing.Size(388, 20)
        Me.TextBoxEmpName.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Birth Date (YYYY/MM/DD)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(255, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Hire Date (YYYY/MM/DD)"
        '
        'TextBoxEmpSuperID
        '
        Me.TextBoxEmpSuperID.Location = New System.Drawing.Point(332, 110)
        Me.TextBoxEmpSuperID.MaxLength = 10
        Me.TextBoxEmpSuperID.Name = "TextBoxEmpSuperID"
        Me.TextBoxEmpSuperID.Size = New System.Drawing.Size(158, 20)
        Me.TextBoxEmpSuperID.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(255, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Supervisor ID"
        '
        'TextBoxEmpId
        '
        Me.TextBoxEmpId.Location = New System.Drawing.Point(85, 110)
        Me.TextBoxEmpId.MaxLength = 10
        Me.TextBoxEmpId.Name = "TextBoxEmpId"
        Me.TextBoxEmpId.Size = New System.Drawing.Size(164, 20)
        Me.TextBoxEmpId.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Employee ID"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(260, 139)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Done"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(149, 143)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(105, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Commit Changes"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBoxEmpBirth
        '
        Me.TextBoxEmpBirth.CustomFormat = "yyyy/MM/dd"
        Me.TextBoxEmpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TextBoxEmpBirth.Location = New System.Drawing.Point(149, 84)
        Me.TextBoxEmpBirth.Name = "TextBoxEmpBirth"
        Me.TextBoxEmpBirth.Size = New System.Drawing.Size(105, 20)
        Me.TextBoxEmpBirth.TabIndex = 11
        Me.TextBoxEmpBirth.Value = New Date(1753, 1, 1, 0, 0, 0, 0)
        '
        'TextBoxEmpHired
        '
        Me.TextBoxEmpHired.CustomFormat = "yyyy/MM/dd"
        Me.TextBoxEmpHired.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TextBoxEmpHired.Location = New System.Drawing.Point(390, 84)
        Me.TextBoxEmpHired.Name = "TextBoxEmpHired"
        Me.TextBoxEmpHired.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxEmpHired.TabIndex = 13
        Me.TextBoxEmpHired.Value = New Date(1753, 1, 1, 0, 0, 0, 0)
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(15, 143)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(129, 17)
        Me.CheckBox2.TabIndex = 14
        Me.CheckBox2.Text = "DELETE EMPLOYEE"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'EmployeeDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 168)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.TextBoxEmpHired)
        Me.Controls.Add(Me.TextBoxEmpBirth)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxEmpSuperID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxEmpId)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxEmpZip)
        Me.Controls.Add(Me.TextBoxEmpState)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxEmpCity)
        Me.Controls.Add(Me.TextBoxEmpAddr)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxEmpName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Name = "EmployeeDetails"
        Me.Text = "Employee Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxEmpAddr As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEmpCity As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEmpState As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEmpZip As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxEmpName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxEmpSuperID As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxEmpId As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBoxEmpBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBoxEmpHired As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
End Class
