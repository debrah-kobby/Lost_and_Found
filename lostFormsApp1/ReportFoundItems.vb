
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

        ' Get values from the form
        Dim itemName As String = nameInput.Text.Trim()
        Dim location As String = locationFoundInput.Text.Trim()
        Dim description As String = itemDescriptionInput.Text.Trim()
        Dim phoneNumber As String = phoneNumberInput.Text.Trim()
        Dim email As String = emailInput.Text.Trim()

        Dim category As String = ""

        If categoryInput.SelectedItem IsNot Nothing Then
            category = categoryInput.SelectedItem.ToString()
        End If

        ' Validate required fields
        If itemName = "" OrElse
       location = "" OrElse
       description = "" OrElse
       phoneNumber = "" OrElse
       email = "" OrElse
       category = "" Then

            MessageBox.Show("Please fill in all fields before submitting.",
                        "Missing Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            Return
        End If

        ' Combine date and time
        Dim dateFound As DateTime =
        dateFoundInput.Value.Date.Add(timeFoundInput.Value.TimeOfDay)

        Try

            ' Save the found item to the database
            Dim saved As Boolean = SaveFoundItem(
            itemName,
            category,
            location,
            description,
            phoneNumber,
            email,
            dateFound
        )

            If saved Then
                MessageBox.Show("Found item successfully reported!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

                clearFormBtn.PerformClick()

            Else
                MessageBox.Show("The item could not be saved. Please try again.",
                            "Submission Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            End If

        Catch ex As Exception

            MessageBox.Show("An error occurred while saving the item: " & ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)

        End Try

    End Sub


    ' NAVIGATION

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
