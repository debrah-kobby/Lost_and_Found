
Public Class ReportLostItems

    Private Sub clearFormBtn_Click(sender As Object, e As EventArgs) Handles clearFormBtn.Click
        nameInput.Clear()
        locationInput.Clear()
        descriptionInput.Clear()
        phonenumberInput.Clear()
        emailInput.Clear()

        categoryPicker.SelectedIndex = -1

        dateLostPicker.Value = DateTime.Now
        timeLostPicker.Value = DateTime.Now
    End Sub

    Private Sub submitformBtn_Click(sender As Object, e As EventArgs) Handles submitformBtn.Click
        MessageBox.Show("Successfully Reported a Lost Item")
    End Sub

    ' NAVIGATION

    Private Sub reportFoundItemBtn_Click(sender As Object, e As EventArgs) Handles reportFoundItemBtn.Click
        Me.Hide()
        ReportFoundItems.Show()
    End Sub

    Private Sub lostItemBtn_Click(sender As Object, e As EventArgs) Handles lostItemBtn.Click
        Me.Hide()
        LostItems.Show()
    End Sub

    Private Sub foundItemsBtn_Click(sender As Object, e As EventArgs) Handles foundItemsBtn.Click
        Me.Hide()
        FoundItems.Show()
    End Sub

    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        Me.Hide()
        Dashboard.Show()
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
        Me.Hide()
        MyProfile.Show()
    End Sub

End Class
