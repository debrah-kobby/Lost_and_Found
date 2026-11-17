
Imports System.Data
Imports System.Collections.Generic

Public Class LostItems

    Private isLoadingFilters As Boolean = False


    ' ==========================================
    ' NAVIGATION
    ' ==========================================

    Private Sub reportFoundItemBtn_Click(sender As Object, e As EventArgs) Handles reportFoundItemBtn.Click
        Me.Hide()
        ReportFoundItems.Show()
    End Sub

    Private Sub foundItemsBtn_Click_1(sender As Object, e As EventArgs) Handles foundItemsBtn.Click
        Me.Hide()
        FoundItems.Show()
    End Sub

    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
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

    Private Sub LostItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            ' Configure DataGridView
            lostItemsGrid.AutoGenerateColumns = False

            lostItemsGrid.Columns("ItemID").DataPropertyName = "ItemID"
            lostItemsGrid.Columns("ItemName").DataPropertyName = "ItemName"
            lostItemsGrid.Columns("Category").DataPropertyName = "Category"
            lostItemsGrid.Columns("LocationLost").DataPropertyName = "LocationLost"
            lostItemsGrid.Columns("Description").DataPropertyName = "Description"
            lostItemsGrid.Columns("DateLost").DataPropertyName = "DateLost"
            lostItemsGrid.Columns("Status").DataPropertyName = "Status"

            ' Load category and location filters
            LoadFilterOptions()

            ' Display all lost items initially
            LoadLostItems()

        Catch ex As Exception

            MessageBox.Show("Unable to load lost items: " & ex.Message,
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

            Dim itemsTable As DataTable = GetLostItems()

            PopulateComboBox(categoryPicker, itemsTable, "Category")
            PopulateComboBox(locationPicker, itemsTable, "LocationLost")

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
    ' LOAD AND FILTER LOST ITEMS
    ' ==========================================

    Private Sub LoadLostItems()

        Try

            Dim searchName As String = searchLostItem.Text.Trim()

            Dim selectedCategory As String = ""

            If categoryPicker.SelectedIndex > 0 Then
                selectedCategory = categoryPicker.Text
            End If

            Dim selectedLocation As String = ""

            If locationPicker.SelectedIndex > 0 Then
                selectedLocation = locationPicker.Text
            End If

            ' Retrieve matching records from database
            lostItemsGrid.DataSource =
                SearchLostItems(searchName,
                                selectedCategory,
                                selectedLocation)

        Catch ex As Exception

            MessageBox.Show("Unable to search lost items: " & ex.Message,
                            "Search Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        End Try

    End Sub


    ' ==========================================
    ' SEARCH WHEN TEXT CHANGES
    ' ==========================================

    Private Sub searchLostItem_TextChanged(sender As Object,
                                           e As EventArgs) Handles searchLostItem.TextChanged

        If Not isLoadingFilters Then
            LoadLostItems()
        End If

    End Sub


    ' ==========================================
    ' FILTER WHEN CATEGORY OR LOCATION CHANGES
    ' ==========================================

    Private Sub filterOptions_SelectedIndexChanged(sender As Object,
                                                    e As EventArgs) Handles categoryPicker.SelectedIndexChanged,
                                                                           locationPicker.SelectedIndexChanged

        If Not isLoadingFilters Then
            LoadLostItems()
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
            searchLostItem.Clear()

            ' Reset category
            If categoryPicker.Items.Count > 0 Then
                categoryPicker.SelectedIndex = 0
            End If

            ' Reset location
            If locationPicker.Items.Count > 0 Then
                locationPicker.SelectedIndex = 0
            End If

        Finally

            isLoadingFilters = False

        End Try

        ' Reload all lost items
        LoadLostItems()

    End Sub

End Class
