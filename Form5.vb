Imports MySql.Data.MySqlClient

Public Class Form5
    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim sqlDt As New DataTable

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
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim iExit As DialogResult
        iExit = MessageBox.Show("Confirm if you want to exit", " Fresh Farm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        HomeForm.Show()
        Me.Close()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        updateTable()
    End Sub
End Class