Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class SignIn

    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim errorCounter As Integer

    Public Sub Profile()
        sqlConn.ConnectionString = "password=21Edward123456789;user id=root;server=localhost;database=myconnector"

        Try
            sqlCmd.Connection = sqlConn
            sqlCmd.CommandText = ("select Farmer_Name, Email, Location, Date_of_Birth, Gender, phone, FarmName, Livestock_No, Product FROM myconnector.farmer WHERE Email ='" + EmailBox.Text.Trim.ToLower + "'")
            sqlConn.Open()
            sqlRd = sqlCmd.ExecuteReader()
            If sqlRd.HasRows Then
                sqlRd.Read()
                Form5.Namelbl.Text = sqlRd.GetValue(0).ToString()
                Form5.FarmerNameTxt.Text = sqlRd.GetValue(6).ToString()
                Form5.EmailTxt.Text = sqlRd.GetValue(1).ToString()
                Form5.LocTxt.Text = sqlRd.GetValue(2).ToString()
                Form5.DOBTxt.Text = sqlRd.GetValue(3).ToString.Substring(0, 10)
                Form5.genderTxt.Text = sqlRd.GetValue(4).ToString()
                Form5.PhoneTxt.Text = sqlRd.GetValue(5).ToString()
                Dim Lifestocks As String = sqlRd.GetValue(7).ToString()
                If Lifestocks > 1 Then
                    Form5.ProductTxt.Text = sqlRd.GetValue(8).ToString() & " and Lifestocks"
                Else
                    Form5.ProductTxt.Text = sqlRd.GetValue(8).ToString()

                End If
            Else
                MsgBox("Please Sign Up Again")
                Form2.Show()
            End If
        Catch ex As Exception
            MessageBox.Show("Hmm you have come across an error ")
        Finally
            sqlConn.Close()


        End Try
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Signupbtn.Click
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        HomeForm.Show()
        Me.Close()
    End Sub
    Private Sub Loginbtn_Click(sender As Object, e As EventArgs) Handles Loginbtn.Click

        If EmailBox.Text = "" Then
            MsgBox("Input Username")
        ElseIf PasswordBox.Text = "" Then
            MsgBox("Input Password")
        Else
            sqlConn = New MySqlConnection
            sqlConn.ConnectionString = "password=21Edward123456789;user id=root;server=localhost;database=myconnector"

            Dim READER As MySqlDataReader
            sqlConn.Open()
            Dim Query = "SELECT * FROM myconnector.farmer where Email = '" & EmailBox.Text & "'and Passwords= '" & PasswordBox.Text & "'"

            sqlCmd = New MySqlCommand(Query, sqlConn)
            READER = sqlCmd.ExecuteReader
            errorCounter += 0

            If READER.Read = True Then
                sqlConn.Close()
                Profile()
                MsgBox("Welcome " + Form5.Namelbl.Text)


                Form5.Show()
                EmailBox.Text = ""
                PasswordBox.Text = ""
                Me.Hide()
            Else
                MsgBox("Wrong Password or Username")
                errorCounter = errorCounter + 1
                sqlConn.Close()
                If errorCounter = 3 Then
                    MessageBox.Show("Authentication failed!", "Login Message")
                    Application.Exit()

                End If
            End If
        End If
        sqlConn.Dispose()

    End Sub

    Private Sub SignIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = Loginbtn
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Confirm if you want to exit", " Fresh Farm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class