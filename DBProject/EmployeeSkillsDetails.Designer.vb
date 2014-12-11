<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeSkillsDetails
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
        Me.components = New System.ComponentModel.Container()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.ComboBoxEmpId = New System.Windows.Forms.ComboBox()
        Me.MyApplicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxSkillId = New System.Windows.Forms.ComboBox()
        Me.TextBoxEmpCert = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.MyApplicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(255, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Skill ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Employee ID"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(257, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Done"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(147, 62)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(105, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Commit Changes"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(12, 62)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(132, 17)
        Me.CheckBox2.TabIndex = 14
        Me.CheckBox2.Text = "DELETE EMP FR WP"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'ComboBoxEmpId
        '
        Me.ComboBoxEmpId.FormattingEnabled = True
        Me.ComboBoxEmpId.Location = New System.Drawing.Point(85, 6)
        Me.ComboBoxEmpId.MaxLength = 10
        Me.ComboBoxEmpId.Name = "ComboBoxEmpId"
        Me.ComboBoxEmpId.Size = New System.Drawing.Size(167, 21)
        Me.ComboBoxEmpId.TabIndex = 16
        '
        'MyApplicationBindingSource
        '
        Me.MyApplicationBindingSource.DataSource = GetType(DBProject.My.MyApplication)
        '
        'ComboBoxSkillId
        '
        Me.ComboBoxSkillId.FormattingEnabled = True
        Me.ComboBoxSkillId.Location = New System.Drawing.Point(301, 6)
        Me.ComboBoxSkillId.MaxLength = 12
        Me.ComboBoxSkillId.Name = "ComboBoxSkillId"
        Me.ComboBoxSkillId.Size = New System.Drawing.Size(111, 21)
        Me.ComboBoxSkillId.TabIndex = 17
        '
        'TextBoxEmpCert
        '
        Me.TextBoxEmpCert.CustomFormat = "yyyy/MM/dd"
        Me.TextBoxEmpCert.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TextBoxEmpCert.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBoxEmpCert.Location = New System.Drawing.Point(147, 33)
        Me.TextBoxEmpCert.Name = "TextBoxEmpCert"
        Me.TextBoxEmpCert.Size = New System.Drawing.Size(105, 20)
        Me.TextBoxEmpCert.TabIndex = 20
        Me.TextBoxEmpCert.Value = New Date(1753, 1, 1, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Cert Date (YYYY/MM/DD)"
        '
        'EmployeeSkillsDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 87)
        Me.Controls.Add(Me.TextBoxEmpCert)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBoxSkillId)
        Me.Controls.Add(Me.ComboBoxEmpId)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Name = "EmployeeSkillsDetails"
        Me.Text = "Workplace Details"
        CType(Me.MyApplicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBoxEmpId As System.Windows.Forms.ComboBox
    Friend WithEvents MyApplicationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBoxSkillId As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxEmpCert As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
