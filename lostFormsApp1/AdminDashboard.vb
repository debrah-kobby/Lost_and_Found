
Public Class AdminDashboard

    ' ==========================================
    ' LOAD ADMIN DASHBOARD
    ' ==========================================
    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConfigureClaimsGrid()
        LoadPendingClaims()

    End Sub


    ' ==========================================
    ' CONFIGURE CLAIMS DATAGRIDVIEW
    ' ==========================================
    Private Sub ConfigureClaimsGrid()

        With pendingClaimsGrid

            .AutoGenerateColumns = True
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .RowHeadersVisible = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        End With

    End Sub


    ' ==========================================
    ' LOAD PENDING CLAIMS
    ' ==========================================
    Private Sub LoadPendingClaims()

        Try

            pendingClaimsGrid.DataSource = GetPendingClaims()

            ' Hide internal database ID
            If pendingClaimsGrid.Columns.Contains("FoundItemID") Then
                pendingClaimsGrid.Columns("FoundItemID").Visible = False
            End If

            ' Enable or disable buttons
            Dim hasClaims As Boolean = pendingClaimsGrid.Rows.Count > 0

            approveClaimBtn.Enabled = hasClaims
            rejectClaimBtn.Enabled = hasClaims

        Catch ex As Exception

            MessageBox.Show(
                "Unable to load pending claims: " & ex.Message,
                "Loading Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' ==========================================
    ' GET SELECTED CLAIM ID
    ' ==========================================
    Private Function GetSelectedClaimID() As Integer

        If pendingClaimsGrid.SelectedRows.Count = 0 Then

            MessageBox.Show("Please select a claim first.")

            Return 0

        End If

        Return Convert.ToInt32(
            pendingClaimsGrid.SelectedRows(0).Cells("ClaimID").Value
        )

    End Function


    ' ==========================================
    ' HANDLE GRID SELECTION
    ' ==========================================
    Private Sub pendingClaimsGrid_SelectionChanged(
        sender As Object,
        e As EventArgs
    ) Handles pendingClaimsGrid.SelectionChanged

        Dim hasSelection As Boolean =
            pendingClaimsGrid.SelectedRows.Count > 0

        approveClaimBtn.Enabled = hasSelection
        rejectClaimBtn.Enabled = hasSelection

    End Sub


    ' ==========================================
    ' APPROVE SELECTED CLAIM
    ' ==========================================
    Private Sub approveClaimBtn_Click(
        sender As Object,
        e As EventArgs
    ) Handles approveClaimBtn.Click

        Dim claimID As Integer = GetSelectedClaimID()

        If claimID = 0 Then Return

        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to approve this claim?",
            "Confirm Approval",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then

            Try

                If ApproveClaim(claimID) Then

                    MessageBox.Show(
                        "Claim approved successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    )

                    LoadPendingClaims()

                Else

                    MessageBox.Show(
                        "The claim could not be approved. It may already have been processed or the item may no longer be available.",
                        "Approval Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    )

                    LoadPendingClaims()

                End If

            Catch ex As Exception

                MessageBox.Show(
                    "Error approving claim: " & ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

            End Try

        End If

    End Sub


    ' ==========================================
    ' REJECT SELECTED CLAIM
    ' ==========================================
    Private Sub rejectClaimBtn_Click(
        sender As Object,
        e As EventArgs
    ) Handles rejectClaimBtn.Click

        Dim claimID As Integer = GetSelectedClaimID()

        If claimID = 0 Then Return

        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to reject this claim?",
            "Confirm Rejection",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If result = DialogResult.Yes Then

            Try

                If RejectClaim(claimID) Then

                    MessageBox.Show(
                        "Claim rejected successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    )

                    LoadPendingClaims()

                Else

                    MessageBox.Show(
                        "The claim could not be rejected. It may already have been processed.",
                        "Rejection Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    )

                    LoadPendingClaims()

                End If

            Catch ex As Exception

                MessageBox.Show(
                    "Error rejecting claim: " & ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

            End Try

        End If

    End Sub


    ' ==========================================
    ' REFRESH PENDING CLAIMS
    ' ==========================================
    Private Sub refreshClaimsBtn_Click(
        sender As Object,
        e As EventArgs
    ) Handles refreshClaimsBtn.Click

        LoadPendingClaims()

    End Sub

End Class
