Public Class ReportFoundItems
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

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
End Class