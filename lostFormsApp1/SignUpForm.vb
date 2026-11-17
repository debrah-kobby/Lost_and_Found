
Public Class SignUpForm

    Private Sub logInLabel_Click(sender As Object, e As EventArgs) Handles logInLabel.Click

        Me.Hide()
        LoginForm.Show()

    End Sub


    Private Sub btnsignup_Click(sender As Object, e As EventArgs) Handles btnsignup.Click

        ' Get user input
        Dim studentID As String = txtstudentID.Text.Trim()
        Dim firstName As String = txtfirstname.Text.Trim()
        Dim lastName As String = txtlastname.Text.Trim()
        Dim email As String = txtemail.Text.Trim()
        Dim password As String = txtpassword.Text
        Dim confirmPassword As String = txtconfirmpassword.Text

        ' Check for empty fields
        If studentID = "" OrElse firstName = "" OrElse
           lastName = "" OrElse email = "" OrElse
           password = "" OrElse confirmPassword = "" Then

            MessageBox.Show("Please fill in all fields.")
            Return

        End If

        ' Check if passwords match
        If password <> confirmPassword Then

            MessageBox.Show("Passwords do not match.")
            txtconfirmpassword.Clear()
            txtconfirmpassword.Focus()
            Return

        End If

        ' Hash password
        Dim hashedPassword As String = PasswordHelper.HashPassword(password)

        ' Register user
        Dim registered As Boolean = RegisterUser(
            studentID,
            firstName,
            lastName,
            email,
            hashedPassword
        )

        If registered Then

            MessageBox.Show("Registration successful! You can now log in.")

            LoginForm.Show()
            Me.Hide()

        Else

            MessageBox.Show("Student ID or email already exists.")

        End If

    End Sub

End Class
