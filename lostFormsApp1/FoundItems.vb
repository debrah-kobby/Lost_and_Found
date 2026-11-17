
Imports System.Data
Imports System.Collections.Generic

Public Class FoundItems

    ' Prevent filtering while controls are being populated or cleared
    Private isLoadingFilters As Boolean = False

    ' Store the ID of the selected found item
    Private selectedFoundItemID As Integer = 0


    ' ==========================================
    ' NAVIGATION
    ' ==========================================

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


    ' ==========================================
    ' FORM LOAD
    ' ==========================================

    Private Sub FoundItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            ' Configure DataGridView
            foundItemsGrid.AutoGenerateColumns = False

            ' Remove existing Designer columns
            foundItemsGrid.Columns.Clear()

            foundItemsGrid.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect

            foundItemsGrid.MultiSelect = False
            foundItemsGrid.ReadOnly = True
            foundItemsGrid.AllowUserToAddRows = False
            foundItemsGrid.RowHeadersVisible = False

            foundItemsGrid.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill

            ' ------------------------------------------
            ' ITEM ID COLUMN
            ' ------------------------------------------

            Dim idColumn As New DataGridViewTextBoxColumn()

            idColumn.Name = "ItemID"
            idColumn.HeaderText = "Item ID"
            idColumn.DataPropertyName = "ItemID"
            idColumn.FillWeight = 50

            foundItemsGrid.Columns.Add(idColumn)


            ' ------------------------------------------
            ' ITEM NAME COLUMN
            ' ------------------------------------------

            Dim nameColumn As New DataGridViewTextBoxColumn()

            nameColumn.Name = "ItemName"
            nameColumn.HeaderText = "Item Name"
            nameColumn.DataPropertyName = "ItemName"
            nameColumn.FillWeight = 100

            foundItemsGrid.Columns.Add(nameColumn)


            ' ------------------------------------------
            ' CATEGORY COLUMN
            ' ------------------------------------------

            Dim categoryColumn As New DataGridViewTextBoxColumn()

            categoryColumn.Name = "Category"
            categoryColumn.HeaderText = "Category"
            categoryColumn.DataPropertyName = "Category"
            categoryColumn.FillWeight = 80

            foundItemsGrid.Columns.Add(categoryColumn)


            ' ------------------------------------------
            ' LOCATION COLUMN
            ' ------------------------------------------

            Dim locationColumn As New DataGridViewTextBoxColumn()

            locationColumn.Name = "LocationFound"
            locationColumn.HeaderText = "Location Found"
            locationColumn.DataPropertyName = "LocationFound"
            locationColumn.FillWeight = 100

            foundItemsGrid.Columns.Add(locationColumn)


            ' ------------------------------------------
            ' DESCRIPTION COLUMN
            ' ------------------------------------------

            Dim descriptionColumn As New DataGridViewTextBoxColumn()

            descriptionColumn.Name = "Description"
            descriptionColumn.HeaderText = "Description"
            descriptionColumn.DataPropertyName = "Description"
            descriptionColumn.FillWeight = 130

            foundItemsGrid.Columns.Add(descriptionColumn)


            ' ------------------------------------------
            ' DATE FOUND COLUMN
            ' ------------------------------------------

            Dim dateColumn As New DataGridViewTextBoxColumn()

            dateColumn.Name = "DateFound"
            dateColumn.HeaderText = "Date Found"
            dateColumn.DataPropertyName = "DateFound"
            dateColumn.FillWeight = 85

            foundItemsGrid.Columns.Add(dateColumn)


            ' ------------------------------------------
            ' STATUS COLUMN
            ' ------------------------------------------

            Dim statusColumn As New DataGridViewTextBoxColumn()

            statusColumn.Name = "Status"
            statusColumn.HeaderText = "Status"
            statusColumn.DataPropertyName = "Status"
            statusColumn.FillWeight = 65

            foundItemsGrid.Columns.Add(statusColumn)


            ' Hide claim panel initially
            claimPanel.Visible = False

            ' Load category and location filters
            LoadFilterOptions()

            ' Display all found items initially
            LoadFoundItems()

        Catch ex As Exception

            MessageBox.Show("Unable to load found items: " & ex.Message,
                            "Database Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        End Try

    End Sub


    ' ==========================================
    ' LOAD CATEGORY AND LOCATION FILTERS
    ' ==========================================

    Private Sub LoadFilterOptions()

        isLoadingFilters = True

        Try

            Dim itemsTable As DataTable = GetFoundItems()

            PopulateComboBox(categoryPicker, itemsTable, "Category")
            PopulateComboBox(locationPicker, itemsTable, "LocationFound")

        Finally

            isLoadingFilters = False

        End Try

    End Sub


    ' ==========================================
    ' POPULATE COMBOBOX WITH UNIQUE VALUES
    ' ==========================================

    Private Sub PopulateComboBox(combo As ComboBox,
                                 itemsTable As DataTable,
                                 columnName As String)

        Dim uniqueValues As New List(Of String)

        Dim existingValues As New HashSet(Of String)(
            StringComparer.OrdinalIgnoreCase)

        combo.Items.Clear()

        ' Add option to display all records
        combo.Items.Add("All")

        For Each itemRow As DataRow In itemsTable.Rows

            Dim value As String = itemRow(columnName).ToString().Trim()

            If value <> "" AndAlso existingValues.Add(value) Then
                uniqueValues.Add(value)
            End If

        Next

        ' Sort options alphabetically
        uniqueValues.Sort()

        For Each value As String In uniqueValues
            combo.Items.Add(value)
        Next

        ' Select All by default
        combo.SelectedIndex = 0

    End Sub


    ' ==========================================
    ' LOAD AND FILTER FOUND ITEMS
    ' ==========================================

    Private Sub LoadFoundItems()

        Try

            Dim searchName As String = searchFoundName.Text.Trim()

            Dim selectedCategory As String = ""

            If categoryPicker.SelectedIndex > 0 Then
                selectedCategory = categoryPicker.Text
            End If

            Dim selectedLocation As String = ""

            If locationPicker.SelectedIndex > 0 Then
                selectedLocation = locationPicker.Text
            End If

            ' Retrieve matching records from database
            foundItemsGrid.DataSource =
                SearchFoundItems(searchName,
                                 selectedCategory,
                                 selectedLocation)

        Catch ex As Exception

            MessageBox.Show("Unable to search found items: " & ex.Message,
                            "Search Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        End Try

    End Sub


    ' ==========================================
    ' SEARCH WHEN TEXT CHANGES
    ' ==========================================

    Private Sub searchFoundName_TextChanged(sender As Object,
                                            e As EventArgs) Handles searchFoundName.TextChanged

        If Not isLoadingFilters Then
            LoadFoundItems()
        End If

    End Sub


    ' ==========================================
    ' FILTER WHEN CATEGORY OR LOCATION CHANGES
    ' ==========================================

    Private Sub filterOptions_SelectedIndexChanged(sender As Object,
                                                    e As EventArgs) Handles categoryPicker.SelectedIndexChanged,
                                                                           locationPicker.SelectedIndexChanged

        If Not isLoadingFilters Then
            LoadFoundItems()
        End If

    End Sub


    ' ==========================================
    ' CLEAR ALL FILTERS
    ' ==========================================

    Private Sub clearFilterBtn_Click(sender As Object,
                                     e As EventArgs) Handles clearFilterBtn.Click

        isLoadingFilters = True

        Try

            ' Clear search textbox
            searchFoundName.Clear()

            ' Reset category filter
            If categoryPicker.Items.Count > 0 Then
                categoryPicker.SelectedIndex = 0
            End If

            ' Reset location filter
            If locationPicker.Items.Count > 0 Then
                locationPicker.SelectedIndex = 0
            End If

        Finally

            isLoadingFilters = False

        End Try

        ' Reload all found items
        LoadFoundItems()

    End Sub


    ' ==========================================
    ' OPEN CLAIM FORM
    ' ==========================================

    Private Sub claimItemBtn_Click(sender As Object,
                                   e As EventArgs) Handles claimItemBtn.Click

        If foundItemsGrid.CurrentRow Is Nothing Then

            MessageBox.Show("Please select an item first.",
                            "No Item Selected",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            Return

        End If

        Dim selectedRow As DataGridViewRow = foundItemsGrid.CurrentRow

        If selectedRow.IsNewRow Then
            Return
        End If

        ' Check item availability
        Dim itemStatus As String =
            Convert.ToString(selectedRow.Cells("Status").Value)

        If Not String.Equals(itemStatus, "Available",
                             StringComparison.OrdinalIgnoreCase) Then

            MessageBox.Show("This item is no longer available for claiming.",
                            "Item Unavailable",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            Return

        End If

        ' Store selected item's database ID
        selectedFoundItemID =
            Convert.ToInt32(selectedRow.Cells("ItemID").Value)

        ' Display selected item name
        claimItemNameLbl.Text =
            Convert.ToString(selectedRow.Cells("ItemName").Value)

        ' Clear previous reason
        claimReasonTxt.Clear()

        ' Display claim panel
        claimPanel.Visible = True

    End Sub


    ' ==========================================
    ' SUBMIT CLAIM
    ' ==========================================

    Private Sub submitClaimBtn_Click(sender As Object,
                                     e As EventArgs) Handles submitClaimBtn.Click

        Dim reason As String = claimReasonTxt.Text.Trim()

        If selectedFoundItemID <= 0 Then

            MessageBox.Show("Please select a valid item.",
                            "Invalid Item",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            Return

        End If

        If reason = "" Then

            MessageBox.Show("Please explain why you believe this item belongs to you.",
                            "Reason Required",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            claimReasonTxt.Focus()

            Return

        End If

        Try

            If SubmitClaim(selectedFoundItemID, reason) Then

                MessageBox.Show("Your claim has been submitted successfully. It is now pending admin review.",
                                "Claim Submitted",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)

                ' Reset claim form
                claimPanel.Visible = False
                selectedFoundItemID = 0
                claimReasonTxt.Clear()

                ' Refresh found items
                LoadFoundItems()

            Else

                MessageBox.Show("Unable to submit your claim. The item may no longer be available, or you may already have an active claim for it.",
                                "Claim Not Submitted",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning)

            End If

        Catch ex As Exception

            MessageBox.Show("An error occurred while submitting your claim: " & ex.Message,
                            "Submission Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        End Try

    End Sub


    ' ==========================================
    ' CANCEL CLAIM
    ' ==========================================

    Private Sub cancelClaimBtn_Click(sender As Object,
                                     e As EventArgs) Handles cancelClaimBtn.Click

        claimPanel.Visible = False

        selectedFoundItemID = 0

        claimReasonTxt.Clear()

    End Sub

End Class
