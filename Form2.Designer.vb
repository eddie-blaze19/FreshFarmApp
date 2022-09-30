<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.SignUpbtn = New System.Windows.Forms.Button()
        Me.Loginbtn = New System.Windows.Forms.Label()
        Me.EmailBox = New System.Windows.Forms.TextBox()
        Me.PasswordBox = New System.Windows.Forms.TextBox()
        Me.LocationBox = New System.Windows.Forms.TextBox()
        Me.MySqlDataAdapter1 = New MySql.Data.MySqlClient.MySqlDataAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.NoBox = New System.Windows.Forms.TextBox()
        Me.FarmNameBox = New System.Windows.Forms.TextBox()
        Me.phoneBox = New System.Windows.Forms.TextBox()
        Me.productBox = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'NameBox
        '
        Me.NameBox.BackColor = System.Drawing.Color.White
        Me.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NameBox.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NameBox.Location = New System.Drawing.Point(289, 244)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(210, 22)
        Me.NameBox.TabIndex = 2
        Me.NameBox.Text = "Mark Kojo"
        '
        'Exitbtn
        '
        Me.Exitbtn.BackColor = System.Drawing.Color.Black
        Me.Exitbtn.BackgroundImage = CType(resources.GetObject("Exitbtn.BackgroundImage"), System.Drawing.Image)
        Me.Exitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Exitbtn.Location = New System.Drawing.Point(547, 612)
        Me.Exitbtn.Name = "Exitbtn"
        Me.Exitbtn.Size = New System.Drawing.Size(145, 44)
        Me.Exitbtn.TabIndex = 6
        Me.Exitbtn.UseVisualStyleBackColor = False
        '
        'SignUpbtn
        '
        Me.SignUpbtn.BackgroundImage = CType(resources.GetObject("SignUpbtn.BackgroundImage"), System.Drawing.Image)
        Me.SignUpbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SignUpbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SignUpbtn.Location = New System.Drawing.Point(396, 612)
        Me.SignUpbtn.Name = "SignUpbtn"
        Me.SignUpbtn.Size = New System.Drawing.Size(145, 44)
        Me.SignUpbtn.TabIndex = 7
        Me.SignUpbtn.UseVisualStyleBackColor = True
        '
        'Loginbtn
        '
        Me.Loginbtn.AutoSize = True
        Me.Loginbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Loginbtn.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loginbtn.Location = New System.Drawing.Point(446, 174)
        Me.Loginbtn.Name = "Loginbtn"
        Me.Loginbtn.Size = New System.Drawing.Size(191, 21)
        Me.Loginbtn.TabIndex = 8
        Me.Loginbtn.Text = "Already Registered? Login"
        '
        'EmailBox
        '
        Me.EmailBox.BackColor = System.Drawing.Color.White
        Me.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmailBox.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EmailBox.Location = New System.Drawing.Point(289, 319)
        Me.EmailBox.Name = "EmailBox"
        Me.EmailBox.Size = New System.Drawing.Size(210, 18)
        Me.EmailBox.TabIndex = 9
        Me.EmailBox.Text = "hello@reallygreatsite.com"
        '
        'PasswordBox
        '
        Me.PasswordBox.BackColor = System.Drawing.Color.White
        Me.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PasswordBox.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PasswordBox.Location = New System.Drawing.Point(289, 396)
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.Size = New System.Drawing.Size(210, 22)
        Me.PasswordBox.TabIndex = 10
        Me.PasswordBox.Text = "   ******"
        Me.PasswordBox.UseSystemPasswordChar = True
        '
        'LocationBox
        '
        Me.LocationBox.BackColor = System.Drawing.Color.White
        Me.LocationBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LocationBox.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LocationBox.Location = New System.Drawing.Point(289, 543)
        Me.LocationBox.Name = "LocationBox"
        Me.LocationBox.Size = New System.Drawing.Size(210, 22)
        Me.LocationBox.TabIndex = 13
        Me.LocationBox.Text = "Accra"
        '
        'MySqlDataAdapter1
        '
        Me.MySqlDataAdapter1.DeleteCommand = Nothing
        Me.MySqlDataAdapter1.InsertCommand = Nothing
        Me.MySqlDataAdapter1.SelectCommand = Nothing
        Me.MySqlDataAdapter1.UpdateCommand = Nothing
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1026, 26)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(44, 37)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'NoBox
        '
        Me.NoBox.BackColor = System.Drawing.Color.White
        Me.NoBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NoBox.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NoBox.HideSelection = False
        Me.NoBox.Location = New System.Drawing.Point(584, 469)
        Me.NoBox.Name = "NoBox"
        Me.NoBox.Size = New System.Drawing.Size(210, 22)
        Me.NoBox.TabIndex = 20
        Me.NoBox.Text = "0"
        '
        'FarmNameBox
        '
        Me.FarmNameBox.BackColor = System.Drawing.Color.White
        Me.FarmNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FarmNameBox.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FarmNameBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FarmNameBox.Location = New System.Drawing.Point(584, 543)
        Me.FarmNameBox.Name = "FarmNameBox"
        Me.FarmNameBox.Size = New System.Drawing.Size(210, 22)
        Me.FarmNameBox.TabIndex = 19
        Me.FarmNameBox.Text = "AZ porary Farm"
        '
        'phoneBox
        '
        Me.phoneBox.BackColor = System.Drawing.Color.White
        Me.phoneBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.phoneBox.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.phoneBox.Location = New System.Drawing.Point(615, 396)
        Me.phoneBox.Name = "phoneBox"
        Me.phoneBox.Size = New System.Drawing.Size(179, 22)
        Me.phoneBox.TabIndex = 18
        '
        'productBox
        '
        Me.productBox.BackColor = System.Drawing.Color.White
        Me.productBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.productBox.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.productBox.Location = New System.Drawing.Point(584, 319)
        Me.productBox.Name = "productBox"
        Me.productBox.Size = New System.Drawing.Size(210, 18)
        Me.productBox.TabIndex = 17
        Me.productBox.Text = "ex. Yam"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox5.Location = New System.Drawing.Point(584, 244)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(210, 22)
        Me.TextBox5.TabIndex = 16
        Me.TextBox5.Text = "Mark Kojo"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"MALE", "FEMALE", "OTHER"})
        Me.ComboBox1.Location = New System.Drawing.Point(584, 239)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(210, 29)
        Me.ComboBox1.TabIndex = 21
        Me.ComboBox1.Text = "MALE"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(289, 469)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 29)
        Me.DateTimePicker1.TabIndex = 22
        Me.DateTimePicker1.Value = New Date(2022, 8, 29, 0, 0, 0, 0)
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(584, 396)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(30, 22)
        Me.TextBox1.TabIndex = 23
        Me.TextBox1.Text = "233"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1082, 687)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.NoBox)
        Me.Controls.Add(Me.FarmNameBox)
        Me.Controls.Add(Me.phoneBox)
        Me.Controls.Add(Me.productBox)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.LocationBox)
        Me.Controls.Add(Me.PasswordBox)
        Me.Controls.Add(Me.EmailBox)
        Me.Controls.Add(Me.Loginbtn)
        Me.Controls.Add(Me.SignUpbtn)
        Me.Controls.Add(Me.Exitbtn)
        Me.Controls.Add(Me.NameBox)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NameBox As TextBox
    Friend WithEvents Exitbtn As Button
    Friend WithEvents SignUpbtn As Button
    Friend WithEvents Loginbtn As Label
    Friend WithEvents EmailBox As TextBox
    Friend WithEvents PasswordBox As TextBox
    Friend WithEvents LocationBox As TextBox
    Private WithEvents MySqlDataAdapter1 As MySql.Data.MySqlClient.MySqlDataAdapter
    Friend WithEvents Button4 As Button
    Friend WithEvents NoBox As TextBox
    Friend WithEvents FarmNameBox As TextBox
    Friend WithEvents phoneBox As TextBox
    Friend WithEvents productBox As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
End Class
