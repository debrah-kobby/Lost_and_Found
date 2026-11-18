

Public Class LoginForm

    Dim loginAttempts As Integer = 0

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeDatabase()


    End Sub

    Private Sub btnpassword_Click(sender As Object, e As EventArgs) Handles btnpassword.Click

        Dim studentID As String = txtusername.Text.Trim()
        Dim password As String = txtpassword.Text

        If String.IsNullOrWhiteSpace(studentID) OrElse
           String.IsNullOrWhiteSpace(password) Then

            MessageBox.Show("Please enter your Student ID and password.")
            Return
        End If

        If AuthenticateUser(studentID, password) Then

            ' Retrieve the logged-in user's details
            CurrentUserID = GetUserID(studentID)
            CurrentUserRole = GetUserRole(studentID).Trim()

            If CurrentUserID = 0 Then
                MessageBox.Show("Unable to retrieve your user account.")
                CurrentUserID = 0
                CurrentUserRole = ""
                Return
            End If

            ' Check that the account has a valid role
            If Not String.Equals(CurrentUserRole, "Admin",
                                 StringComparison.OrdinalIgnoreCase) AndAlso
               Not String.Equals(CurrentUserRole, "Student",
                                 StringComparison.OrdinalIgnoreCase) Then

                MessageBox.Show("Your account has an invalid role.")
                CurrentUserID = 0
                CurrentUserRole = ""
                Return
            End If

            loginAttempts = 0

            ' Temporary diagnostic message
            MessageBox.Show("Login successful!" &
                            vbCrLf & "Student ID: " & studentID &
                            vbCrLf & "Retrieved Role: " & CurrentUserRole)

            ' Redirect based on account role
            If String.Equals(CurrentUserRole, "Admin",
                             StringComparison.OrdinalIgnoreCase) Then

                AdminDashboard.Show()

            Else

                Dashboard.Show()

            End If

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

            CurrentUserID = 0
            CurrentUserRole = ""

        End If

        Label1.BackColor = Color.Transparent

    End Sub

    Private Sub signUpLabel_Click(sender As Object, e As EventArgs) Handles signUpLabel.Click
        Me.Hide()
        SignUpForm.Show()
    End Sub

End Class
