
Imports System.Data

Public Class MyReports

    Private allLostReports As DataTable
    Private allFoundReports As DataTable

    Private Sub MyReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Populate Report Type dropdown
        reportTypeComboBox.Items.Clear()
        reportTypeComboBox.Items.Add("All")
        reportTypeComboBox.Items.Add("Lost")
        reportTypeComboBox.Items.Add("Found")
        reportTypeComboBox.SelectedIndex = 0

        ' Set default date range
        fromDatePicker.Value = Date.Today.AddMonths(-1)
        toDatePicker.Value = Date.Today

        LoadReports()

    End Sub


    ' Refresh reports whenever the user returns to this form
    Private Sub MyReports_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        If allLostReports IsNot Nothing Then
            LoadReports()
        End If

    End Sub


    ' LOAD REPORTS FROM DATABASE
    Private Sub LoadReports()

        Try

            allLostReports = GetMyLostItems()
            allFoundReports = GetMyFoundItems()

            ' Update summary figures
            totalReportsNumber.Text =
                (allLostReports.Rows.Count + allFoundReports.Rows.Count).ToString()

            lostCount.Text = allLostReports.Rows.Count.ToString()

            foundCount.Text = allFoundReports.Rows.Count.ToString()

            ' Count reports with Claimed status
            Dim claimedTotal As Integer = 0

            For Each report As DataRow In allLostReports.Rows
                If String.Equals(report("Status").ToString(),
                                 "Claimed",
                                 StringComparison.OrdinalIgnoreCase) Then
                    claimedTotal += 1
                End If
            Next

            For Each report As DataRow In allFoundReports.Rows
                If String.Equals(report("Status").ToString(),
                                 "Claimed",
                                 StringComparison.OrdinalIgnoreCase) Then
                    claimedTotal += 1
                End If
            Next

            claimedCount.Text = claimedTotal.ToString()

            ' Display reports using selected filters
            GenerateReports()

        Catch ex As Exception

            MessageBox.Show("Unable to load reports: " & ex.Message,
                            "Database Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        End Try

    End Sub


    ' GENERATE FILTERED REPORTS
    Private Sub generateBtn_Click(sender As Object, e As EventArgs) Handles generateBtn.Click

        GenerateReports()

    End Sub


    Private Sub GenerateReports()

        Try

            If toDatePicker.Value.Date < fromDatePicker.Value.Date Then

                MessageBox.Show("The To Date cannot be earlier than the From Date.",
                                "Invalid Date Range",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning)
                Return

            End If

            Dim selectedType As String =
                reportTypeComboBox.SelectedItem.ToString()

            Dim startDate As DateTime = fromDatePicker.Value.Date
            Dim endDate As DateTime = toDatePicker.Value.Date.AddDays(1)

            ' Configure Lost Reports Grid
            lostReportsGrid.AutoGenerateColumns = False

            lostReportsGrid.Columns("ItemID").DataPropertyName = "ItemID"
            lostReportsGrid.Columns("ItemName").DataPropertyName = "ItemName"
            lostReportsGrid.Columns("Category").DataPropertyName = "Category"
            lostReportsGrid.Columns("LocationLost").DataPropertyName = "LocationLost"
            lostReportsGrid.Columns("DateLost").DataPropertyName = "DateLost"
            lostReportsGrid.Columns("Status").DataPropertyName = "Status"

            ' Configure Found Reports Grid
            foundReportsGrid.AutoGenerateColumns = False

            foundReportsGrid.Columns("FoundReportID").DataPropertyName = "ItemID"
            foundReportsGrid.Columns("FoundItemName").DataPropertyName = "ItemName"
            foundReportsGrid.Columns("FoundCategory").DataPropertyName = "Category"
            foundReportsGrid.Columns("FoundLocation").DataPropertyName = "LocationFound"
            foundReportsGrid.Columns("FoundDate").DataPropertyName = "DateFound"
            foundReportsGrid.Columns("FoundStatus").DataPropertyName = "Status"

            ' Apply date filters
            Dim filteredLost As DataTable =
                FilterReportsByDate(allLostReports, "DateLost", startDate, endDate)

            Dim filteredFound As DataTable =
                FilterReportsByDate(allFoundReports, "DateFound", startDate, endDate)

            ' Apply report type filter
            If selectedType = "All" OrElse selectedType = "Lost" Then

                lostReportsGrid.DataSource = filteredLost
                lostReportsGrid.Visible = True

            Else

                lostReportsGrid.DataSource = Nothing
                lostReportsGrid.Visible = False

            End If

            If selectedType = "All" OrElse selectedType = "Found" Then

                foundReportsGrid.DataSource = filteredFound
                foundReportsGrid.Visible = True

            Else

                foundReportsGrid.DataSource = Nothing
                foundReportsGrid.Visible = False

            End If

            ' Format date columns
            lostReportsGrid.Columns("DateLost").DefaultCellStyle.Format = "dd MMM yyyy"

            foundReportsGrid.Columns("FoundDate").DefaultCellStyle.Format = "dd MMM yyyy"

        Catch ex As Exception

            MessageBox.Show("Unable to generate reports: " & ex.Message,
                            "Report Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        End Try

    End Sub


    ' FILTER A DATATABLE USING A DATE RANGE
    Private Function FilterReportsByDate(sourceTable As DataTable,
                                         dateColumn As String,
                                         startDate As DateTime,
                                         endDate As DateTime) As DataTable

        Dim filteredTable As DataTable = sourceTable.Clone()

        For Each report As DataRow In sourceTable.Rows

            Dim reportDate As DateTime

            If DateTime.TryParse(Convert.ToString(report(dateColumn)), reportDate) Then

                If reportDate >= startDate AndAlso reportDate < endDate Then
                    filteredTable.ImportRow(report)
                End If

            End If

        Next

        Return filteredTable

    End Function


    ' NAVIGATION BUTTONS

    Private Sub reportFoundItemBtn_Click(sender As Object, e As EventArgs) Handles reportFoundItemBtn.Click
        Me.Hide()
        ReportFoundItems.Show()
    End Sub

    Private Sub foundItemsBtn_Click(sender As Object, e As EventArgs) Handles foundItemsBtn.Click
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
        CurrentUserID = 0
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub myReportsBtn_Click(sender As Object, e As EventArgs) Handles myReportsBtn.Click
        LoadReports()
    End Sub

    Private Sub myClaimsBtn_Click(sender As Object, e As EventArgs) Handles myClaimsBtn.Click
        Me.Hide()
        MyClaims.Show()
    End Sub

    Private Sub myProfileBtn_Click(sender As Object, e As EventArgs) Handles myProfileBtn.Click
        Me.Hide()
        MyProfile.Show()
    End Sub

    Private Sub lostItemBtn_Click(sender As Object, e As EventArgs) Handles lostItemBtn.Click
        Me.Hide()
        LostItems.Show()
    End Sub
End Class
