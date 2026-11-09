Public Class LostItems

    Private Sub reportFoundItemBtn_Click(sender As Object, e As EventArgs) Handles reportFoundItemBtn.Click
        Me.Hide()
        ReportFoundItems.Show()
    End Sub

    Private Sub foundItemsBtn_Click_1(sender As Object, e As EventArgs) Handles foundItemsBtn.Click
        Hide()
        FoundItems.Show()
    End Sub

    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        Hide()
        Dashboard.Show()
    End Sub

    Private Sub reportlostitembtn_Click(sender As Object, e As EventArgs) Handles reportlostitembtn.Click
        Hide()
        ReportLostItems.Show()
    End Sub

    Private Sub bckToLogin_Click(sender As Object, e As EventArgs) Handles bckToLogin.Click
        Hide()
        LoginForm.Show()
    End Sub
End Class