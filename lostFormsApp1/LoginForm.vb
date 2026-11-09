Public Class LoginForm
    Dim strusername As String
    Dim strpassword As String
    Private Sub btnpassword_Click(sender As Object, e As EventArgs) Handles btnpassword.Click
        'assign
        strusername = txtusername.Text
        strpassword = txtpassword.Text


        Select Case strusername
            Case "kofi"
                If strpassword = "kofi123" Then
                    MessageBox.Show("Login Successful")
                    Dashboard.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Invalid Password")
                End If
            Case "admin"
                If strpassword = "admin123" Then
                    MessageBox.Show("Admin Login Successful")
                    Dashboard.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Invalid Password")
                End If
            Case Else
                MessageBox.Show("User not found")
        End Select
        Label1.BackColor = Color.Transparent
    End Sub

    Private Sub signUpLabel_Click(sender As Object, e As EventArgs) Handles signUpLabel.Click
        Me.Hide()
        SignUpForm.Show()
    End Sub
End Class
