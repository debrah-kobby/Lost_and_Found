<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label2 = New Label()
        pendingClaimsGrid = New DataGridView()
        approveClaimBtn = New Button()
        rejectClaimBtn = New Button()
        refreshClaimsBtn = New Button()
        CType(pendingClaimsGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Menu
        Label2.Font = New Font("Papyrus", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(134, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(398, 30)
        Label2.TabIndex = 16
        Label2.Text = "Lost and Found System - Welcome Admin"
        ' 
        ' pendingClaimsGrid
        ' 
        pendingClaimsGrid.AllowUserToAddRows = False
        pendingClaimsGrid.AllowUserToDeleteRows = False
        pendingClaimsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        pendingClaimsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        pendingClaimsGrid.Location = New Point(12, 105)
        pendingClaimsGrid.MultiSelect = False
        pendingClaimsGrid.Name = "pendingClaimsGrid"
        pendingClaimsGrid.RowHeadersVisible = False
        pendingClaimsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        pendingClaimsGrid.Size = New Size(776, 213)
        pendingClaimsGrid.TabIndex = 17
        ' 
        ' approveClaimBtn
        ' 
        approveClaimBtn.Location = New Point(379, 345)
        approveClaimBtn.Name = "approveClaimBtn"
        approveClaimBtn.Size = New Size(106, 23)
        approveClaimBtn.TabIndex = 18
        approveClaimBtn.Text = "Approve Claim "
        approveClaimBtn.UseVisualStyleBackColor = True
        ' 
        ' rejectClaimBtn
        ' 
        rejectClaimBtn.Location = New Point(518, 345)
        rejectClaimBtn.Name = "rejectClaimBtn"
        rejectClaimBtn.Size = New Size(108, 23)
        rejectClaimBtn.TabIndex = 19
        rejectClaimBtn.Text = "Reject Claim"
        rejectClaimBtn.UseVisualStyleBackColor = True
        ' 
        ' refreshClaimsBtn
        ' 
        refreshClaimsBtn.Location = New Point(670, 345)
        refreshClaimsBtn.Name = "refreshClaimsBtn"
        refreshClaimsBtn.Size = New Size(118, 23)
        refreshClaimsBtn.TabIndex = 20
        refreshClaimsBtn.Text = "Refresh"
        refreshClaimsBtn.UseVisualStyleBackColor = True
        ' 
        ' AdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(800, 514)
        Controls.Add(refreshClaimsBtn)
        Controls.Add(rejectClaimBtn)
        Controls.Add(approveClaimBtn)
        Controls.Add(pendingClaimsGrid)
        Controls.Add(Label2)
        Name = "AdminDashboard"
        Text = "AdminDashboard"
        CType(pendingClaimsGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents pendingClaimsGrid As DataGridView
    Friend WithEvents approveClaimBtn As Button
    Friend WithEvents rejectClaimBtn As Button
    Friend WithEvents refreshClaimsBtn As Button
End Class
