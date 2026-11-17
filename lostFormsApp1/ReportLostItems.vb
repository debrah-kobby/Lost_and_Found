
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

        ' Get form information
        Dim itemName As String = nameInput.Text.Trim()
        Dim location As String = locationInput.Text.Trim()
        Dim description As String = descriptionInput.Text.Trim()
        Dim phoneNumber As String = phonenumberInput.Text.Trim()
        Dim email As String = emailInput.Text.Trim()

        ' Check category selection
        If categoryPicker.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an item category.")
            Return
        End If

        Dim category As String = categoryPicker.SelectedItem.ToString()

        ' Validate required fields
        If itemName = "" OrElse location = "" OrElse
       description = "" OrElse phoneNumber = "" OrElse
       email = "" Then

            MessageBox.Show("Please fill in all fields.")
            Return

        End If

        ' Combine date and time
        Dim dateLost As DateTime =
        dateLostPicker.Value.Date.Add(timeLostPicker.Value.TimeOfDay)

        Try

            ' Save report to SQLite
            Dim saved As Boolean = SaveLostItem(
            itemName,
            category,
            location,
            description,
            phoneNumber,
            email,
            dateLost
        )

            If saved Then

                MessageBox.Show("Lost item successfully reported!")

                ' Clear form after successful submission
                clearFormBtn.PerformClick()

            Else

                MessageBox.Show("Unable to save your report.")

            End If

        Catch ex As Exception

            MessageBox.Show("Error saving report: " & ex.Message)

        End Try

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
