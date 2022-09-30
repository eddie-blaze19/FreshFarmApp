Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32


Public Class Form2
    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim sqlDt As New DataTable
    Dim sqlQuery As String

    Private Sub updateTable()
        sqlConn.ConnectionString = "password=21Edward123456789;user id=root;server=localhost;database=myconnector"
        sqlConn.Open()
        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "SELECT * FROM myconnector.farmer;"

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlConn.Close()
        Form4.DataGridView1.DataSource = sqlDt
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles SignUpbtn.Click
        sqlConn.ConnectionString = "password=21Edward123456789;user id=root;server=localhost;database=myconnector"
        Try
            sqlConn.Open()
            sqlQuery = "Insert into myconnector.farmer(Farmer_Name, Email, Passwords, Location, Date_of_Birth, User_Type, Gender, phone, FarmName, Livestock_No, Product )
               values('" & NameBox.Text & "','" & EmailBox.Text.Trim.ToLower & "','" & PasswordBox.Text & "','" & LocationBox.Text & "','" & DateTimePicker1.Text & "','" & "User" & "','" & ComboBox1.Text & "','" & phoneBox.Text & "','" & FarmNameBox.Text & "','" & NoBox.Text & "','" & productBox.Text & "')"

            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlRd = sqlCmd.ExecuteReader
            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, " MySQL Commector ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Exit()
        Finally
            sqlConn.Dispose()
        End Try
        updateTable()
        MsgBox("Sign up Successful")
        Me.Hide()
        NameBox.Text= ""
        EmailBox.Text = ""
        PasswordBox.Text = ""
        LocationBox.Text = ""
        DateTimePicker1.Text = ""
        phoneBox.Text = ""
        FarmNameBox.Text = ""
        NoBox.Text = ""
        productBox.Text = ""
        SignIn.Show()
    End Sub
    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click

        HomeForm.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Loginbtn.Click
        SignIn.Show()
        Me.Close()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Confirm if you want to exit", " Fresh Farm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub


End Class
