<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WorksCenterDetails
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
        Me.MyApplicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBoxWorkCenterId = New System.Windows.Forms.TextBox()
        Me.TextBoxWorkCenterDesc = New System.Windows.Forms.TextBox()
        CType(Me.MyApplicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(201, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Description"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Workcenter ID"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(258, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Done"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(147, 32)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(105, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Commit Changes"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(12, 32)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(68, 17)
        Me.CheckBox2.TabIndex = 14
        Me.CheckBox2.Text = "DELETE"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'MyApplicationBindingSource
        '
        Me.MyApplicationBindingSource.DataSource = GetType(DBProject.My.MyApplication)
        '
        'TextBoxWorkCenterId
        '
        Me.TextBoxWorkCenterId.Location = New System.Drawing.Point(95, 6)
        Me.TextBoxWorkCenterId.MaxLength = 12
        Me.TextBoxWorkCenterId.Name = "TextBoxWorkCenterId"
        Me.TextBoxWorkCenterId.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxWorkCenterId.TabIndex = 15
        '
        'TextBoxWorkCenterDesc
        '
        Me.TextBoxWorkCenterDesc.Location = New System.Drawing.Point(267, 6)
        Me.TextBoxWorkCenterDesc.MaxLength = 30
        Me.TextBoxWorkCenterDesc.Name = "TextBoxWorkCenterDesc"
        Me.TextBoxWorkCenterDesc.Size = New System.Drawing.Size(225, 20)
        Me.TextBoxWorkCenterDesc.TabIndex = 16
        '
        'WorksCenterDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 60)
        Me.Controls.Add(Me.TextBoxWorkCenterDesc)
        Me.Controls.Add(Me.TextBoxWorkCenterId)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Name = "WorksCenterDetails"
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
    Friend WithEvents MyApplicationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TextBoxWorkCenterId As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxWorkCenterDesc As System.Windows.Forms.TextBox
End Class
