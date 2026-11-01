Public Class ReportLostItems
    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        ' Navigate back to Form3
        Dashboard.Show()
        Hide()
    End Sub



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
End Class