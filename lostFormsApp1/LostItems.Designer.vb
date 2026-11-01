<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LostItems
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
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        bckToLoginBtn = New Button()
        reportLostItemsBtn = New Button()
        foundItemsBtn = New Button()
        dashboardBtn = New Button()
        Label3 = New Label()
        Panel3 = New Panel()
        locationPicker = New ComboBox()
        locationLabel = New Label()
        categoryPicker = New ComboBox()
        categoryLabel = New Label()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(785, 34)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ButtonFace
        Label2.Location = New Point(648, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 15)
        Label2.TabIndex = 1
        Label2.Text = "LOST AND FOUND"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonFace
        Label1.Location = New Point(23, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(36, 15)
        Label1.TabIndex = 0
        Label1.Text = "UPSA"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(bckToLoginBtn)
        Panel2.Controls.Add(reportLostItemsBtn)
        Panel2.Controls.Add(foundItemsBtn)
        Panel2.Controls.Add(dashboardBtn)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(3, 43)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(145, 395)
        Panel2.TabIndex = 1
        ' 
        ' bckToLoginBtn
        ' 
        bckToLoginBtn.Location = New Point(9, 342)
        bckToLoginBtn.Name = "bckToLoginBtn"
        bckToLoginBtn.Size = New Size(128, 23)
        bckToLoginBtn.TabIndex = 6
        bckToLoginBtn.Text = "BACK TO LOGIN"
        bckToLoginBtn.UseVisualStyleBackColor = True
        ' 
        ' reportLostItemsBtn
        ' 
        reportLostItemsBtn.Location = New Point(6, 178)
        reportLostItemsBtn.Name = "reportLostItemsBtn"
        reportLostItemsBtn.Size = New Size(128, 23)
        reportLostItemsBtn.TabIndex = 5
        reportLostItemsBtn.Text = "REPORT LOST ITEM"
        reportLostItemsBtn.UseVisualStyleBackColor = True
        ' 
        ' foundItemsBtn
        ' 
        foundItemsBtn.Location = New Point(14, 128)
        foundItemsBtn.Name = "foundItemsBtn"
        foundItemsBtn.Size = New Size(114, 23)
        foundItemsBtn.TabIndex = 4
        foundItemsBtn.Text = "FOUND ITEMS"
        foundItemsBtn.UseVisualStyleBackColor = True
        ' 
        ' dashboardBtn
        ' 
        dashboardBtn.Location = New Point(23, 77)
        dashboardBtn.Name = "dashboardBtn"
        dashboardBtn.Size = New Size(90, 23)
        dashboardBtn.TabIndex = 3
        dashboardBtn.Text = "DASHBOARD"
        dashboardBtn.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 16)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 15)
        Label3.TabIndex = 2
        Label3.Text = "MAIN MENU"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(locationPicker)
        Panel3.Controls.Add(locationLabel)
        Panel3.Controls.Add(categoryPicker)
        Panel3.Controls.Add(categoryLabel)
        Panel3.Controls.Add(TextBox1)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Location = New Point(170, 43)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(618, 395)
        Panel3.TabIndex = 2
        ' 
        ' locationPicker
        ' 
        locationPicker.FormattingEnabled = True
        locationPicker.Items.AddRange(New Object() {"Library", "LBC", "AB", "YAB", "LAB 1", "LAB 2"})
        locationPicker.Location = New Point(416, 110)
        locationPicker.Name = "locationPicker"
        locationPicker.Size = New Size(133, 23)
        locationPicker.TabIndex = 13
        locationPicker.Text = "Library"
        ' 
        ' locationLabel
        ' 
        locationLabel.AutoSize = True
        locationLabel.Location = New Point(348, 113)
        locationLabel.Name = "locationLabel"
        locationLabel.Size = New Size(62, 15)
        locationLabel.TabIndex = 12
        locationLabel.Text = "Location  :"
        ' 
        ' categoryPicker
        ' 
        categoryPicker.FormattingEnabled = True
        categoryPicker.Items.AddRange(New Object() {"Electronics", "Bag", "Food", "ID", "Books", "Other Stationary"})
        categoryPicker.Location = New Point(82, 110)
        categoryPicker.Name = "categoryPicker"
        categoryPicker.Size = New Size(133, 23)
        categoryPicker.TabIndex = 11
        categoryPicker.Text = "Electronics"
        ' 
        ' categoryLabel
        ' 
        categoryLabel.AutoSize = True
        categoryLabel.Location = New Point(21, 113)
        categoryLabel.Name = "categoryLabel"
        categoryLabel.Size = New Size(64, 15)
        categoryLabel.TabIndex = 10
        categoryLabel.Text = "Category  :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(21, 77)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search for a Lost item"
        TextBox1.Size = New Size(586, 23)
        TextBox1.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(21, 42)
        Label5.Name = "Label5"
        Label5.Size = New Size(241, 15)
        Label5.TabIndex = 8
        Label5.Text = "Browse and manage Items Reported Missing"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(21, 16)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 15)
        Label4.TabIndex = 7
        Label4.Text = "LOST ITEMS"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = SystemColors.ActiveCaptionText
        FlowLayoutPanel1.Location = New Point(154, 43)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(10, 395)
        FlowLayoutPanel1.TabIndex = 3
        ' 
        ' LostItems
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "LostItems"
        Text = "Form6"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents reportLostItemsBtn As Button
    Friend WithEvents foundItemsBtn As Button
    Friend WithEvents dashboardBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents bckToLoginBtn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents locationPicker As ComboBox
    Friend WithEvents locationLabel As Label
    Friend WithEvents categoryPicker As ComboBox
    Friend WithEvents categoryLabel As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
