
Imports System.Data
Public Class MyProfile

    ' ==========================================
    ' FORM LOAD
    ' ==========================================

    Private Sub MyProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadUserProfile()

    End Sub


    ' ==========================================
    ' LOAD USER PROFILE INFORMATION
    ' ==========================================

    Private Sub LoadUserProfile()

        Try

            Dim profileTable As DataTable = GetUserProfile()

            If profileTable.Rows.Count = 0 Then

                MessageBox.Show("Unable to find your account information. Please log in again.",
                                "Profile Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning)

                Return

            End If

            Dim profile As DataRow = profileTable.Rows(0)

            ' Display full name
            fullname.Text =
                profile("FirstName").ToString() & " " &
                profile("LastName").ToString()

            ' Display email
            email.Text = profile("Email").ToString()

            ' Display user ID
            UserID.Text = profile("UserID").ToString()

            ' Display account status
            accountstatus.Text = "Active"

            ' Display registration date
            Dim registrationDate As DateTime

            If DateTime.TryParse(profile("CreatedAt").ToString(),
                                 registrationDate) Then

                dateregistered.Text =
                    registrationDate.ToString("dd MMMM yyyy")

            Else

                dateregistered.Text = "Unavailable"

            End If

        Catch ex As Exception

            MessageBox.Show("Unable to load profile information: " & ex.Message,
                            "Profile Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        End Try

    End Sub


    ' ==========================================
    ' NAVIGATION
    ' ==========================================

    Private Sub reportFoundItemBtn_Click(sender As Object, e As EventArgs) Handles reportFoundItemBtn.Click
        Me.Hide()
        ReportFoundItems.Show()
    End Sub

    Private Sub foundItemsBtn_Click(sender As Object, e As EventArgs) Handles foundItemsBtn.Click
        Me.Hide()
        FoundItems.Show()
    End Sub

    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub reportlostitembtn_Click(sender As Object, e As EventArgs) Handles reportlostitembtn.Click
        Me.Hide()
        ReportLostItems.Show()
    End Sub

    Private Sub bckToLogin_Click(sender As Object, e As EventArgs) Handles bckToLogin.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub myReportsBtn_Click(sender As Object, e As EventArgs) Handles myReportsBtn.Click
        Me.Hide()
        MyReports.Show()
    End Sub

    Private Sub myClaimsBtn_Click(sender As Object, e As EventArgs) Handles myClaimsBtn.Click
        Me.Hide()
        MyClaims.Show()
    End Sub

    Private Sub myProfileBtn_Click(sender As Object, e As EventArgs) Handles myProfileBtn.Click
        ' Already on the My Profile form
    End Sub

End Class
