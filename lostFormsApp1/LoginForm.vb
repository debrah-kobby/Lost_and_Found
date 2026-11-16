
Imports Microsoft.VisualBasic.ApplicationServices

Public Class LoginForm

    Dim strusername As String
    Dim strpassword As String
    Dim loginAttempts As Integer = 0

    Private Sub btnpassword_Click(sender As Object, e As EventArgs) Handles btnpassword.Click

        strusername = txtusername.Text.Trim()
        strpassword = txtpassword.Text

        ' Create User objects
        Dim student As New User With {
            .StudentID = "kofi",
            .PasswordHash = "kofi123"
        }

        Dim admin As New User With {
            .StudentID = "admin",
            .PasswordHash = "admin123"
        }

        ' Check login credentials
        If strusername = student.StudentID AndAlso
           strpassword = student.PasswordHash Then

            MessageBox.Show("Login Successful")
            Dashboard.Show()
            Me.Hide()

        ElseIf strusername = admin.StudentID AndAlso
               strpassword = admin.PasswordHash Then

            MessageBox.Show("Admin Login Successful")
            Dashboard.Show()
            Me.Hide()

        Else

            loginAttempts += 1

            If loginAttempts >= 3 Then

                MessageBox.Show("Too many failed attempts. Closing application.")
                Me.Close()

            Else

                MessageBox.Show("Invalid Username or Password. Attempt " &
                                loginAttempts & " of 3.")

                txtpassword.Clear()
                txtpassword.Focus()

            End If

        End If

        Label1.BackColor = Color.Transparent

    End Sub

    Private Sub signUpLabel_Click(sender As Object, e As EventArgs) Handles signUpLabel.Click

        Me.Hide()
        SignUpForm.Show()

    End Sub

End Class
