<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FoundItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FoundItems))
        Panel3 = New Panel()
        locationPicker = New ComboBox()
        locationLabel = New Label()
        categoryPicker = New ComboBox()
        categoryLabel = New Label()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Panel9 = New Panel()
        dashboardBtn = New Button()
        myClaimsBtn = New Button()
        PictureBox9 = New PictureBox()
        Button3 = New Button()
        lostItemBtn = New Button()
        myReportsBtn = New Button()
        foundItemsBtn = New Button()
        PictureBox8 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox6 = New PictureBox()
        reportFoundItemBtn = New Button()
        PictureBox5 = New PictureBox()
        reportlostitembtn = New Button()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        bckToLogin = New Button()
        Label4 = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Panel3.SuspendLayout()
        Panel9.SuspendLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(locationPicker)
        Panel3.Controls.Add(locationLabel)
        Panel3.Controls.Add(categoryPicker)
        Panel3.Controls.Add(categoryLabel)
        Panel3.Controls.Add(TextBox1)
        Panel3.Controls.Add(Label5)
        Panel3.Location = New Point(209, 85)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(559, 395)
        Panel3.TabIndex = 4
        ' 
        ' locationPicker
        ' 
        locationPicker.FormattingEnabled = True
        locationPicker.Items.AddRange(New Object() {"Library", "LBC", "AB", "YAB", "LAB 1", "LAB 2"})
        locationPicker.Location = New Point(355, 118)
        locationPicker.Name = "locationPicker"
        locationPicker.Size = New Size(133, 23)
        locationPicker.TabIndex = 13
        locationPicker.Text = "Library"
        ' 
        ' locationLabel
        ' 
        locationLabel.AutoSize = True
        locationLabel.Location = New Point(273, 118)
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
        TextBox1.Location = New Point(23, 60)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search for Found Items"
        TextBox1.Size = New Size(387, 23)
        TextBox1.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(21, 42)
        Label5.Name = "Label5"
        Label5.Size = New Size(183, 15)
        Label5.TabIndex = 8
        Label5.Text = "Browse and manage Items Found"
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = SystemColors.AppWorkspace
        Panel9.Controls.Add(dashboardBtn)
        Panel9.Controls.Add(myClaimsBtn)
        Panel9.Controls.Add(PictureBox9)
        Panel9.Controls.Add(Button3)
        Panel9.Controls.Add(lostItemBtn)
        Panel9.Controls.Add(myReportsBtn)
        Panel9.Controls.Add(foundItemsBtn)
        Panel9.Controls.Add(PictureBox8)
        Panel9.Controls.Add(PictureBox7)
        Panel9.Controls.Add(PictureBox6)
        Panel9.Controls.Add(reportFoundItemBtn)
        Panel9.Controls.Add(PictureBox5)
        Panel9.Controls.Add(reportlostitembtn)
        Panel9.Controls.Add(PictureBox4)
        Panel9.Controls.Add(PictureBox3)
        Panel9.Controls.Add(PictureBox1)
        Panel9.Controls.Add(PictureBox2)
        Panel9.Controls.Add(bckToLogin)
        Panel9.Location = New Point(4, 5)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(188, 489)
        Panel9.TabIndex = 18
        ' 
        ' dashboardBtn
        ' 
        dashboardBtn.BackColor = Color.White
        dashboardBtn.FlatStyle = FlatStyle.Flat
        dashboardBtn.Location = New Point(39, 80)
        dashboardBtn.Margin = New Padding(2)
        dashboardBtn.Name = "dashboardBtn"
        dashboardBtn.Size = New Size(136, 26)
        dashboardBtn.TabIndex = 23
        dashboardBtn.Text = "DASHBOARD"
        dashboardBtn.UseVisualStyleBackColor = False
        ' 
        ' myClaimsBtn
        ' 
        myClaimsBtn.BackColor = Color.White
        myClaimsBtn.FlatStyle = FlatStyle.Flat
        myClaimsBtn.Location = New Point(39, 378)
        myClaimsBtn.Margin = New Padding(2)
        myClaimsBtn.Name = "myClaimsBtn"
        myClaimsBtn.Size = New Size(136, 26)
        myClaimsBtn.TabIndex = 14
        myClaimsBtn.Text = "MY CLAIMS"
        myClaimsBtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), Image)
        PictureBox9.Location = New Point(10, 380)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(24, 24)
        PictureBox9.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox9.TabIndex = 22
        PictureBox9.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(39, 449)
        Button3.Margin = New Padding(2)
        Button3.Name = "Button3"
        Button3.Size = New Size(136, 26)
        Button3.TabIndex = 21
        Button3.Text = "PROFILE"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' lostItemBtn
        ' 
        lostItemBtn.BackColor = SystemColors.ControlLightLight
        lostItemBtn.FlatStyle = FlatStyle.Flat
        lostItemBtn.ForeColor = Color.Black
        lostItemBtn.Location = New Point(39, 232)
        lostItemBtn.Margin = New Padding(2)
        lostItemBtn.Name = "lostItemBtn"
        lostItemBtn.Size = New Size(136, 26)
        lostItemBtn.TabIndex = 12
        lostItemBtn.Text = "LOST ITEMS"
        lostItemBtn.UseVisualStyleBackColor = False
        ' 
        ' myReportsBtn
        ' 
        myReportsBtn.BackColor = Color.White
        myReportsBtn.FlatStyle = FlatStyle.Flat
        myReportsBtn.Location = New Point(39, 330)
        myReportsBtn.Margin = New Padding(2)
        myReportsBtn.Name = "myReportsBtn"
        myReportsBtn.Size = New Size(136, 26)
        myReportsBtn.TabIndex = 13
        myReportsBtn.Text = "MY REPORTS"
        myReportsBtn.UseVisualStyleBackColor = False
        ' 
        ' foundItemsBtn
        ' 
        foundItemsBtn.BackColor = SystemColors.AppWorkspace
        foundItemsBtn.FlatStyle = FlatStyle.Flat
        foundItemsBtn.ForeColor = Color.White
        foundItemsBtn.Location = New Point(39, 284)
        foundItemsBtn.Margin = New Padding(2)
        foundItemsBtn.Name = "foundItemsBtn"
        foundItemsBtn.Size = New Size(136, 26)
        foundItemsBtn.TabIndex = 11
        foundItemsBtn.Text = "FOUND ITEMS"
        foundItemsBtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(10, 234)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(24, 24)
        PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox8.TabIndex = 20
        PictureBox8.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(10, 284)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(24, 24)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 17
        PictureBox7.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(10, 450)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(24, 24)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 17
        PictureBox6.TabStop = False
        ' 
        ' reportFoundItemBtn
        ' 
        reportFoundItemBtn.BackColor = SystemColors.ControlLightLight
        reportFoundItemBtn.FlatStyle = FlatStyle.Flat
        reportFoundItemBtn.ForeColor = Color.Black
        reportFoundItemBtn.Location = New Point(39, 180)
        reportFoundItemBtn.Margin = New Padding(2)
        reportFoundItemBtn.Name = "reportFoundItemBtn"
        reportFoundItemBtn.Size = New Size(136, 26)
        reportFoundItemBtn.TabIndex = 10
        reportFoundItemBtn.Text = "REPORT FOUND ITEM"
        reportFoundItemBtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(10, 331)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(24, 24)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 19
        PictureBox5.TabStop = False
        ' 
        ' reportlostitembtn
        ' 
        reportlostitembtn.BackColor = SystemColors.InactiveBorder
        reportlostitembtn.FlatStyle = FlatStyle.Flat
        reportlostitembtn.ForeColor = SystemColors.ActiveCaptionText
        reportlostitembtn.Location = New Point(39, 130)
        reportlostitembtn.Margin = New Padding(2)
        reportlostitembtn.Name = "reportlostitembtn"
        reportlostitembtn.Size = New Size(136, 26)
        reportlostitembtn.TabIndex = 9
        reportlostitembtn.Text = "REPORT LOST ITEM"
        reportlostitembtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(10, 181)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(24, 24)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 18
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(10, 130)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(24, 24)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 17
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(10, 80)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(24, 24)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(6, 6)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(31, 30)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 13
        PictureBox2.TabStop = False
        ' 
        ' bckToLogin
        ' 
        bckToLogin.BackColor = Color.Black
        bckToLogin.FlatStyle = FlatStyle.Flat
        bckToLogin.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bckToLogin.ForeColor = Color.White
        bckToLogin.Location = New Point(132, 13)
        bckToLogin.Margin = New Padding(2)
        bckToLogin.Name = "bckToLogin"
        bckToLogin.Size = New Size(34, 23)
        bckToLogin.TabIndex = 0
        bckToLogin.Text = "<"
        bckToLogin.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(209, 16)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(168, 25)
        Label4.TabIndex = 19
        Label4.Text = "FOUND ITEMS"
        ' 
        ' FoundItems
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 499)
        Controls.Add(Label4)
        Controls.Add(Panel9)
        Controls.Add(Panel3)
        Name = "FoundItems"
        Text = "Form7"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel9.ResumeLayout(False)
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents locationPicker As ComboBox
    Friend WithEvents locationLabel As Label
    Friend WithEvents categoryPicker As ComboBox
    Friend WithEvents categoryLabel As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents dashboardBtn As Button
    Friend WithEvents myClaimsBtn As Button
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents lostItemBtn As Button
    Friend WithEvents myReportsBtn As Button
    Friend WithEvents foundItemsBtn As Button
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents reportFoundItemBtn As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents reportlostitembtn As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents bckToLogin As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
