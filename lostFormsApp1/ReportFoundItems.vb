Public Class ReportFoundItems


    Private Sub clearFormBtn_Click(sender As Object, e As EventArgs) Handles clearFormBtn.Click
        nameInput.Clear()
        locationFoundInput.Clear()
        itemDescriptionInput.Clear()
        phoneNumberInput.Clear()
        emailInput.Clear()

        categoryInput.SelectedIndex = -1

        dateFoundInput.Value = DateTime.Now
        timeFoundInput.Value = DateTime.Now
    End Sub

    Private Sub submitFormBtn_Click(sender As Object, e As EventArgs) Handles submitFormBtn.Click
        MessageBox.Show("Successfully Reported a Found Item")
    End Sub



    Private Sub reportlostitembtn_Click(sender As Object, e As EventArgs) Handles reportlostitembtn.Click
        Me.Hide()
        ReportLostItems.Show()
    End Sub

    Private Sub lostItemBtn_Click(sender As Object, e As EventArgs) Handles lostItemBtn.Click
        Me.Hide()
        LostItems.Show()
    End Sub

    Private Sub foundItemsBtn_Click(sender As Object, e As EventArgs) Handles foundItemsBtn.Click
        Me.Hide()
        FoundItems.Show()
    End Sub

    Private Sub dashBoardBtn_Click(sender As Object, e As EventArgs) Handles dashBoardBtn.Click
        Me.Hide()
        Dashboard.Show()
    End Sub
End Class