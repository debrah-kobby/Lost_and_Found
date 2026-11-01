Public Class LostItems
    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub foundItemsBtn_Click(sender As Object, e As EventArgs) Handles foundItemsBtn.Click
        Me.Hide()
        FoundItems.Show()
    End Sub

    Private Sub reportLostItemsBtn_Click(sender As Object, e As EventArgs) Handles reportLostItemsBtn.Click
        Me.Hide()
        ReportLostItems.Show()
    End Sub

    Private Sub bckToLoginBtn_Click(sender As Object, e As EventArgs) Handles bckToLoginBtn.Click
        Me.Hide()
        LoginForm.Show()
    End Sub


End Class