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

    End Sub

    Private Sub Username_Label_Click(sender As Object, e As EventArgs) Handles Username_Label.Click

    End Sub
End Class
