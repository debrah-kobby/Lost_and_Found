Public Class SignUpForm
    Private Sub logInLabel_Click(sender As Object, e As EventArgs) Handles logInLabel.Click
        Me.Hide()
        LoginForm.Show()
    End Sub
End Class