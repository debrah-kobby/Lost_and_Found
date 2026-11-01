Public Class FoundItems
    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs)
        Hide
        Dashboard.Show
    End Sub

    Private Sub foundItemsBtn_Click(sender As Object, e As EventArgs) Handles foundItemsBtn.Click
        Me.Hide()
        LostItems.Show()
    End Sub

    Private Sub reportLostItemsBtn_Click(sender As Object, e As EventArgs)
        Hide
        ReportLostItems.Show
    End Sub

    Private Sub bxkToLoginBtn_Click(sender As Object, e As EventArgs)
        Hide
        LoginForm.Show
    End Sub
End Class