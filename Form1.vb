Public Class HomeForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SignIn.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Adpass As String

        Adpass = InputBox("Admin Password")
        If Adpass = "Group 47" Then
            Form4.Show()
            Me.Hide()
        ElseIf Adpass = "" Then
            MsgBox("Enter Password")
        Else
            MsgBox("Incorrect Password")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Confirm if you want to exit", " Fresh Farm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
