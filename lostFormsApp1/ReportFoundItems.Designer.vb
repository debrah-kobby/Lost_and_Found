<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportFoundItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportFoundItems))
        Label4 = New Label()
        Label5 = New Label()
        Panel1 = New Panel()
        Panel8 = New Panel()
        emailInput = New TextBox()
        phoneNumberInput = New TextBox()
        emailLabel = New Label()
        phoneNumberlabel = New Label()
        contactInfoLabel = New Label()
        Panel7 = New Panel()
        itemDescriptionInput = New TextBox()
        itemDescriptionLabel = New Label()
        Panel6 = New Panel()
        locationFoundInput = New TextBox()
        locationFoundLabel = New Label()
        Panel5 = New Panel()
        timeFoundInput = New DateTimePicker()
        timeFoundlabel = New Label()
        Panel4 = New Panel()
        dateFoundInput = New DateTimePicker()
        dateFoundLabel = New Label()
        Panel3 = New Panel()
        categoryInput = New ComboBox()
        itemCategorylabel = New Label()
        Panel2 = New Panel()
        nameInput = New TextBox()
        itemNameLabel = New Label()
        clearFormBtn = New Button()
        submitFormBtn = New Button()
        Panel9 = New Panel()
        Button2 = New Button()
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
        Panel1.SuspendLayout()
        Panel8.SuspendLayout()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
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
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(208, 11)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(193, 25)
        Label4.TabIndex = 6
        Label4.Text = "Report Found Item"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(208, 47)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(475, 16)
        Label5.TabIndex = 7
        Label5.Text = "Provide details about the item you found to help reunite it  with its rightful owner. "
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.AutoScroll = True
        Panel1.Controls.Add(Panel8)
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(208, 85)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(553, 317)
        Panel1.TabIndex = 8
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(emailInput)
        Panel8.Controls.Add(phoneNumberInput)
        Panel8.Controls.Add(emailLabel)
        Panel8.Controls.Add(phoneNumberlabel)
        Panel8.Controls.Add(contactInfoLabel)
        Panel8.Location = New Point(14, 375)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(548, 79)
        Panel8.TabIndex = 5
        ' 
        ' emailInput
        ' 
        emailInput.Location = New Point(303, 48)
        emailInput.Name = "emailInput"
        emailInput.PlaceholderText = "hello@me.com"
        emailInput.Size = New Size(185, 23)
        emailInput.TabIndex = 11
        ' 
        ' phoneNumberInput
        ' 
        phoneNumberInput.Location = New Point(13, 48)
        phoneNumberInput.Name = "phoneNumberInput"
        phoneNumberInput.PlaceholderText = "0XX XXX XXXX"
        phoneNumberInput.Size = New Size(185, 23)
        phoneNumberInput.TabIndex = 2
        ' 
        ' emailLabel
        ' 
        emailLabel.AutoSize = True
        emailLabel.Font = New Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        emailLabel.Location = New Point(303, 29)
        emailLabel.Margin = New Padding(2, 0, 2, 0)
        emailLabel.Name = "emailLabel"
        emailLabel.Size = New Size(41, 16)
        emailLabel.TabIndex = 10
        emailLabel.Text = "Email"
        ' 
        ' phoneNumberlabel
        ' 
        phoneNumberlabel.AutoSize = True
        phoneNumberlabel.Font = New Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        phoneNumberlabel.Location = New Point(13, 29)
        phoneNumberlabel.Margin = New Padding(2, 0, 2, 0)
        phoneNumberlabel.Name = "phoneNumberlabel"
        phoneNumberlabel.Size = New Size(91, 16)
        phoneNumberlabel.TabIndex = 9
        phoneNumberlabel.Text = "Phone Number"
        ' 
        ' contactInfoLabel
        ' 
        contactInfoLabel.AutoSize = True
        contactInfoLabel.Location = New Point(13, 5)
        contactInfoLabel.Name = "contactInfoLabel"
        contactInfoLabel.Size = New Size(115, 15)
        contactInfoLabel.TabIndex = 4
        contactInfoLabel.Text = "Contact Information"
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(itemDescriptionInput)
        Panel7.Controls.Add(itemDescriptionLabel)
        Panel7.Location = New Point(14, 313)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(548, 64)
        Panel7.TabIndex = 4
        ' 
        ' itemDescriptionInput
        ' 
        itemDescriptionInput.Location = New Point(13, 25)
        itemDescriptionInput.Name = "itemDescriptionInput"
        itemDescriptionInput.PlaceholderText = "vivid description of item found"
        itemDescriptionInput.Size = New Size(508, 23)
        itemDescriptionInput.TabIndex = 4
        ' 
        ' itemDescriptionLabel
        ' 
        itemDescriptionLabel.AutoSize = True
        itemDescriptionLabel.Location = New Point(13, 7)
        itemDescriptionLabel.Name = "itemDescriptionLabel"
        itemDescriptionLabel.Size = New Size(94, 15)
        itemDescriptionLabel.TabIndex = 4
        itemDescriptionLabel.Text = "Item Description"
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(locationFoundInput)
        Panel6.Controls.Add(locationFoundLabel)
        Panel6.Location = New Point(14, 237)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(548, 73)
        Panel6.TabIndex = 3
        ' 
        ' locationFoundInput
        ' 
        locationFoundInput.Location = New Point(13, 28)
        locationFoundInput.Name = "locationFoundInput"
        locationFoundInput.PlaceholderText = "location item was found"
        locationFoundInput.Size = New Size(508, 23)
        locationFoundInput.TabIndex = 3
        ' 
        ' locationFoundLabel
        ' 
        locationFoundLabel.AutoSize = True
        locationFoundLabel.Location = New Point(13, 10)
        locationFoundLabel.Name = "locationFoundLabel"
        locationFoundLabel.Size = New Size(90, 15)
        locationFoundLabel.TabIndex = 2
        locationFoundLabel.Text = "Location Found"
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(timeFoundInput)
        Panel5.Controls.Add(timeFoundlabel)
        Panel5.Location = New Point(317, 131)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(245, 100)
        Panel5.TabIndex = 2
        ' 
        ' timeFoundInput
        ' 
        timeFoundInput.Location = New Point(18, 58)
        timeFoundInput.Name = "timeFoundInput"
        timeFoundInput.Size = New Size(200, 23)
        timeFoundInput.TabIndex = 4
        ' 
        ' timeFoundlabel
        ' 
        timeFoundlabel.AutoSize = True
        timeFoundlabel.Location = New Point(18, 11)
        timeFoundlabel.Name = "timeFoundlabel"
        timeFoundlabel.Size = New Size(71, 15)
        timeFoundlabel.TabIndex = 3
        timeFoundlabel.Text = "Time Found"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(dateFoundInput)
        Panel4.Controls.Add(dateFoundLabel)
        Panel4.Location = New Point(14, 131)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(245, 100)
        Panel4.TabIndex = 2
        ' 
        ' dateFoundInput
        ' 
        dateFoundInput.Location = New Point(13, 58)
        dateFoundInput.Name = "dateFoundInput"
        dateFoundInput.Size = New Size(200, 23)
        dateFoundInput.TabIndex = 3
        ' 
        ' dateFoundLabel
        ' 
        dateFoundLabel.AutoSize = True
        dateFoundLabel.Location = New Point(13, 11)
        dateFoundLabel.Name = "dateFoundLabel"
        dateFoundLabel.Size = New Size(68, 15)
        dateFoundLabel.TabIndex = 2
        dateFoundLabel.Text = "Date Found"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(categoryInput)
        Panel3.Controls.Add(itemCategorylabel)
        Panel3.Location = New Point(317, 16)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(245, 100)
        Panel3.TabIndex = 1
        ' 
        ' categoryInput
        ' 
        categoryInput.FormattingEnabled = True
        categoryInput.Items.AddRange(New Object() {"Electronics", "Bag", "Phones", "Books "})
        categoryInput.Location = New Point(18, 43)
        categoryInput.Margin = New Padding(2)
        categoryInput.Name = "categoryInput"
        categoryInput.Size = New Size(173, 23)
        categoryInput.TabIndex = 3
        categoryInput.Text = "Bag"
        ' 
        ' itemCategorylabel
        ' 
        itemCategorylabel.AutoSize = True
        itemCategorylabel.Location = New Point(18, 11)
        itemCategorylabel.Name = "itemCategorylabel"
        itemCategorylabel.Size = New Size(82, 15)
        itemCategorylabel.TabIndex = 1
        itemCategorylabel.Text = "Item Category"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(nameInput)
        Panel2.Controls.Add(itemNameLabel)
        Panel2.Location = New Point(14, 16)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(251, 100)
        Panel2.TabIndex = 0
        ' 
        ' nameInput
        ' 
        nameInput.Location = New Point(13, 43)
        nameInput.Name = "nameInput"
        nameInput.PlaceholderText = "name"
        nameInput.Size = New Size(185, 23)
        nameInput.TabIndex = 1
        ' 
        ' itemNameLabel
        ' 
        itemNameLabel.AutoSize = True
        itemNameLabel.Location = New Point(13, 11)
        itemNameLabel.Name = "itemNameLabel"
        itemNameLabel.Size = New Size(66, 15)
        itemNameLabel.TabIndex = 0
        itemNameLabel.Text = "Item Name"
        ' 
        ' clearFormBtn
        ' 
        clearFormBtn.Location = New Point(503, 413)
        clearFormBtn.Name = "clearFormBtn"
        clearFormBtn.Size = New Size(122, 23)
        clearFormBtn.TabIndex = 9
        clearFormBtn.Text = "Clear Form"
        clearFormBtn.UseVisualStyleBackColor = True
        ' 
        ' submitFormBtn
        ' 
        submitFormBtn.Location = New Point(640, 413)
        submitFormBtn.Name = "submitFormBtn"
        submitFormBtn.Size = New Size(127, 23)
        submitFormBtn.TabIndex = 10
        submitFormBtn.Text = "Submit Form"
        submitFormBtn.UseVisualStyleBackColor = True
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = SystemColors.InactiveCaption
        Panel9.Controls.Add(Button2)
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
        Panel9.TabIndex = 16
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(39, 80)
        Button2.Margin = New Padding(2)
        Button2.Name = "Button2"
        Button2.Size = New Size(136, 26)
        Button2.TabIndex = 23
        Button2.Text = "DASHBOARD"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' myClaimsBtn
        ' 
        myClaimsBtn.Location = New Point(39, 378)
        myClaimsBtn.Margin = New Padding(2)
        myClaimsBtn.Name = "myClaimsBtn"
        myClaimsBtn.Size = New Size(136, 26)
        myClaimsBtn.TabIndex = 14
        myClaimsBtn.Text = "MY CLAIMS"
        myClaimsBtn.UseVisualStyleBackColor = True
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
        lostItemBtn.Location = New Point(39, 232)
        lostItemBtn.Margin = New Padding(2)
        lostItemBtn.Name = "lostItemBtn"
        lostItemBtn.Size = New Size(136, 26)
        lostItemBtn.TabIndex = 12
        lostItemBtn.Text = "LOST ITEMS"
        lostItemBtn.UseVisualStyleBackColor = True
        ' 
        ' myReportsBtn
        ' 
        myReportsBtn.Location = New Point(39, 330)
        myReportsBtn.Margin = New Padding(2)
        myReportsBtn.Name = "myReportsBtn"
        myReportsBtn.Size = New Size(136, 26)
        myReportsBtn.TabIndex = 13
        myReportsBtn.Text = "MY REPORTS"
        myReportsBtn.UseVisualStyleBackColor = True
        ' 
        ' foundItemsBtn
        ' 
        foundItemsBtn.Location = New Point(39, 284)
        foundItemsBtn.Margin = New Padding(2)
        foundItemsBtn.Name = "foundItemsBtn"
        foundItemsBtn.Size = New Size(136, 26)
        foundItemsBtn.TabIndex = 11
        foundItemsBtn.Text = "FOUND ITEMS"
        foundItemsBtn.UseVisualStyleBackColor = True
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
        reportFoundItemBtn.BackColor = Color.Navy
        reportFoundItemBtn.ForeColor = Color.White
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
        reportlostitembtn.BackColor = SystemColors.ButtonFace
        reportlostitembtn.ForeColor = Color.Black
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
        ' ReportFoundItems
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(782, 497)
        Controls.Add(Panel9)
        Controls.Add(submitFormBtn)
        Controls.Add(clearFormBtn)
        Controls.Add(Panel1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Name = "ReportFoundItems"
        Text = "Form5"
        Panel1.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents timeFoundlabel As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dateFoundLabel As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents itemCategorylabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents itemNameLabel As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents locationFoundLabel As Label
    Friend WithEvents timeFoundInput As DateTimePicker
    Friend WithEvents dateFoundInput As DateTimePicker
    Friend WithEvents nameInput As TextBox
    Friend WithEvents locationFoundInput As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents emailInput As TextBox
    Friend WithEvents phoneNumberInput As TextBox
    Friend WithEvents emailLabel As Label
    Friend WithEvents phoneNumberlabel As Label
    Friend WithEvents contactInfoLabel As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents itemDescriptionInput As TextBox
    Friend WithEvents itemDescriptionLabel As Label
    Friend WithEvents clearFormBtn As Button
    Friend WithEvents submitFormBtn As Button
    Friend WithEvents categoryInput As ComboBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Button2 As Button
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
End Class
