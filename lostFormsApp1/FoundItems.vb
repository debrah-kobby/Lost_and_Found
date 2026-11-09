Public Class FoundItems



    Private Sub reportFoundItemBtn_Click(sender As Object, e As EventArgs) Handles reportFoundItemBtn.Click
        Me.Hide()
        ReportFoundItems.Show()
    End Sub

    Private Sub dashboardBtn_Click_1(sender As Object, e As EventArgs) Handles dashboardBtn.Click
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

    Private Sub lostItemBtn_Click(sender As Object, e As EventArgs) Handles lostItemBtn.Click
        Me.Hide()
        LostItems.Show()
    End Sub
End Class