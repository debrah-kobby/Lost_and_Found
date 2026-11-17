
Imports System.Data

Public Class MyClaims

    Private allClaims As DataTable

    ' ==========================================
    ' FORM LOAD
    ' ==========================================
    Private Sub MyClaims_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set up status filter
        statusComboBox.Items.Clear()
        statusComboBox.Items.Add("All")
        statusComboBox.Items.Add("Pending")
        statusComboBox.Items.Add("Approved")
        statusComboBox.Items.Add("Rejected")

        statusComboBox.SelectedIndex = 0

        LoadMyClaims()

    End Sub


    ' ==========================================
    ' LOAD MY CLAIMS
    ' ==========================================
    Private Sub LoadMyClaims()

        If CurrentUserID <= 0 Then

            MessageBox.Show("Please log in to view your claims.",
                            "Login Required",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            Return

        End If

        Try

            allClaims = GetMyClaims()

            claimsGrid.DataSource = allClaims

            ' Hide internal columns
            If claimsGrid.Columns.Contains("FoundItemID") Then
                claimsGrid.Columns("FoundItemID").Visible = False
            End If

            If claimsGrid.Columns.Contains("Reason") Then
                claimsGrid.Columns("Reason").Visible = False
            End If

            ' Update column headers
            If claimsGrid.Columns.Contains("DateReported") Then
                claimsGrid.Columns("DateReported").HeaderText = "Date Claimed"
            End If

            UpdateClaimCounts()

        Catch ex As Exception

            MessageBox.Show("Unable to load your claims: " & ex.Message,
                            "Database Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        End Try

    End Sub


    ' ==========================================
    ' UPDATE CLAIM SUMMARY COUNTS
    ' ==========================================
    Private Sub UpdateClaimCounts()

        If allClaims Is Nothing Then Return

        totalReportsNumber.Text = allClaims.Rows.Count.ToString()

        Dim pending As Integer =
            allClaims.Select("Status = 'Pending'").Length

        Dim approved As Integer =
            allClaims.Select("Status = 'Approved'").Length

        Dim rejected As Integer =
            allClaims.Select("Status = 'Rejected'").Length

        pendingCount.Text = pending.ToString()
        approvedCount.Text = approved.ToString()
        rejectedCount.Text = rejected.ToString()

    End Sub


    ' ==========================================
    ' NAVIGATION
    ' ==========================================
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
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub myReportsBtn_Click(sender As Object, e As EventArgs) Handles myReportsBtn.Click
        Me.Hide()
        MyReports.Show()
    End Sub

    Private Sub myClaimsBtn_Click(sender As Object, e As EventArgs) Handles myClaimsBtn.Click
        ' Already on the My Claims form
    End Sub

    Private Sub myProfileBtn_Click(sender As Object, e As EventArgs) Handles myProfileBtn.Click
        Me.Hide()
        MyProfile.Show()
    End Sub

End Class
