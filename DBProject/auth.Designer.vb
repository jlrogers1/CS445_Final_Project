<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class auth
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(auth))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox_UN = New System.Windows.Forms.TextBox()
        Me.TextBox_Pwd = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 3
        Me.Button1.Font = New System.Drawing.Font("Showcard Gothic", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(533, 441)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(211, 59)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Authenticate"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox_UN
        '
        Me.TextBox_UN.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox_UN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_UN.Location = New System.Drawing.Point(533, 41)
        Me.TextBox_UN.Name = "TextBox_UN"
        Me.TextBox_UN.Size = New System.Drawing.Size(396, 26)
        Me.TextBox_UN.TabIndex = 2
        Me.TextBox_UN.Text = "Username" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBox_Pwd
        '
        Me.TextBox_Pwd.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox_Pwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Pwd.Location = New System.Drawing.Point(533, 103)
        Me.TextBox_Pwd.Name = "TextBox_Pwd"
        Me.TextBox_Pwd.Size = New System.Drawing.Size(396, 26)
        Me.TextBox_Pwd.TabIndex = 3
        Me.TextBox_Pwd.Text = "Password"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(533, 156)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(211, 26)
        Me.TextBox3.TabIndex = 4
        Me.TextBox3.Text = "Database(default cs445)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Fuchsia
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label8.Font = New System.Drawing.Font("Lucida Handwriting", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(12, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(335, 42)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Human Resources"
        '
        'auth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1214, 630)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox_Pwd)
        Me.Controls.Add(Me.TextBox_UN)
        Me.Controls.Add(Me.Button1)
        Me.Name = "auth"
        Me.Text = "Authentication"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox_UN As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Pwd As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
