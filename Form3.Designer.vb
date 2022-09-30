<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignIn))
        Me.Signupbtn = New System.Windows.Forms.Label()
        Me.Loginbtn = New System.Windows.Forms.Button()
        Me.EmailBox = New System.Windows.Forms.TextBox()
        Me.PasswordBox = New System.Windows.Forms.TextBox()
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Signupbtn
        '
        Me.Signupbtn.AutoSize = True
        Me.Signupbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Signupbtn.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Signupbtn.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Signupbtn.Location = New System.Drawing.Point(469, 170)
        Me.Signupbtn.Name = "Signupbtn"
        Me.Signupbtn.Size = New System.Drawing.Size(172, 21)
        Me.Signupbtn.TabIndex = 9
        Me.Signupbtn.Text = "Or Sign Up to continue"
        '
        'Loginbtn
        '
        Me.Loginbtn.BackColor = System.Drawing.Color.Black
        Me.Loginbtn.BackgroundImage = CType(resources.GetObject("Loginbtn.BackgroundImage"), System.Drawing.Image)
        Me.Loginbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Loginbtn.Location = New System.Drawing.Point(467, 380)
        Me.Loginbtn.Name = "Loginbtn"
        Me.Loginbtn.Size = New System.Drawing.Size(145, 37)
        Me.Loginbtn.TabIndex = 10
        Me.Loginbtn.UseVisualStyleBackColor = False
        '
        'EmailBox
        '
        Me.EmailBox.BackColor = System.Drawing.Color.White
        Me.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmailBox.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EmailBox.Location = New System.Drawing.Point(438, 250)
        Me.EmailBox.Name = "EmailBox"
        Me.EmailBox.Size = New System.Drawing.Size(210, 18)
        Me.EmailBox.TabIndex = 11
        Me.EmailBox.Text = "hello@reallygreatsite.com"
        '
        'PasswordBox
        '
        Me.PasswordBox.BackColor = System.Drawing.Color.White
        Me.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PasswordBox.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PasswordBox.Location = New System.Drawing.Point(438, 322)
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.Size = New System.Drawing.Size(210, 22)
        Me.PasswordBox.TabIndex = 12
        Me.PasswordBox.Text = "   ******"
        Me.PasswordBox.UseSystemPasswordChar = True
        '
        'Exitbtn
        '
        Me.Exitbtn.BackColor = System.Drawing.Color.Black
        Me.Exitbtn.BackgroundImage = CType(resources.GetObject("Exitbtn.BackgroundImage"), System.Drawing.Image)
        Me.Exitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Exitbtn.Location = New System.Drawing.Point(467, 423)
        Me.Exitbtn.Name = "Exitbtn"
        Me.Exitbtn.Size = New System.Drawing.Size(145, 37)
        Me.Exitbtn.TabIndex = 13
        Me.Exitbtn.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1026, 26)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(44, 37)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'SignIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1082, 687)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Exitbtn)
        Me.Controls.Add(Me.PasswordBox)
        Me.Controls.Add(Me.EmailBox)
        Me.Controls.Add(Me.Loginbtn)
        Me.Controls.Add(Me.Signupbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SignIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Signupbtn As Label
    Friend WithEvents Loginbtn As Button
    Friend WithEvents EmailBox As TextBox
    Friend WithEvents PasswordBox As TextBox
    Friend WithEvents Exitbtn As Button
    Friend WithEvents Button4 As Button
End Class
