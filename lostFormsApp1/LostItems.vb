Public Class LostItems
    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs)
        Hide
        Dashboard.Show
    End Sub

    Private Sub foundItemsBtn_Click(sender As Object, e As EventArgs)
        Hide
        FoundItems.Show
    End Sub

    Private Sub reportLostItemsBtn_Click(sender As Object, e As EventArgs)
        Hide
        ReportLostItems.Show
    End Sub

    Private Sub bckToLoginBtn_Click(sender As Object, e As EventArgs)
        Hide
        LoginForm.Show
    End Sub

    Private Sub LostItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class