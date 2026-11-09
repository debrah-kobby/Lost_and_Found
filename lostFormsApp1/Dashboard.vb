Public Class Dashboard
    ' Public property to receive username from the login form
    <System.ComponentModel.Browsable(False)>
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property Username As String
        Get
            Return Label5.Text
        End Get
        Set(value As String)
            If String.IsNullOrEmpty(value) Then
                Label5.Text = "Welcome, User !!"
            Else
                Label5.Text = "Welcome, " & value
            End If
        End Set
    End Property
    Private Sub bckToLogin_Click(sender As Object, e As EventArgs) Handles bckToLogin.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub reportlostitembtn_Click(sender As Object, e As EventArgs) Handles reportlostitembtn.Click
        ReportLostItems.Show()
        Hide()
    End Sub

    Private Sub BreportFoundItemBtn_Click(sender As Object, e As EventArgs) Handles reportFoundItemBtn.Click
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


End Class