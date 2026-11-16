
Public Class MyProfile

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
