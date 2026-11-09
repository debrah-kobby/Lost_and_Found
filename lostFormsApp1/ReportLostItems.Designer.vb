<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportLostItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportLostItems))
        Label4 = New Label()
        Label5 = New Label()
        pnlFormContent = New FlowLayoutPanel()
        Panel1 = New Panel()
        nameInput = New TextBox()
        itemNameLabel = New Label()
        Panel2 = New Panel()
        categoryPicker = New ComboBox()
        itemCategoryLabel = New Label()
        Panel3 = New Panel()
        dateLostPicker = New DateTimePicker()
        dateLostLabel = New Label()
        Panel4 = New Panel()
        timeLostPicker = New DateTimePicker()
        timeLostLabel = New Label()
        Panel5 = New Panel()
        locationInput = New TextBox()
        locationItemLostLabel = New Label()
        Panel6 = New Panel()
        descriptionInput = New TextBox()
        itemDescriptionLabel = New Label()
        Panel7 = New Panel()
        emailInput = New TextBox()
        phonenumberInput = New TextBox()
        emailLabel = New Label()
        phonenumberLabel = New Label()
        contactInfoLabel = New Label()
        clearFormBtn = New Button()
        submitformBtn = New Button()
        Panel8 = New Panel()
        dashboardBtn = New Button()
        myClaimsBtn = New Button()
        PictureBox9 = New PictureBox()
        Button2 = New Button()
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
        pnlFormContent.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        Panel8.SuspendLayout()
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
        Label4.Location = New Point(208, 19)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(191, 25)
        Label4.TabIndex = 6
        Label4.Text = "Report a Lost Item"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(216, 52)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(366, 16)
        Label5.TabIndex = 7
        Label5.Text = "Provide details about the item you lost so we can help locate it."
        ' 
        ' pnlFormContent
        ' 
        pnlFormContent.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlFormContent.AutoScroll = True
        pnlFormContent.Controls.Add(Panel1)
        pnlFormContent.Controls.Add(Panel2)
        pnlFormContent.Controls.Add(Panel3)
        pnlFormContent.Controls.Add(Panel4)
        pnlFormContent.Controls.Add(Panel5)
        pnlFormContent.Controls.Add(Panel6)
        pnlFormContent.Controls.Add(Panel7)
        pnlFormContent.Location = New Point(208, 100)
        pnlFormContent.Name = "pnlFormContent"
        pnlFormContent.Size = New Size(574, 261)
        pnlFormContent.TabIndex = 8
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(nameInput)
        Panel1.Controls.Add(itemNameLabel)
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(129, 81)
        Panel1.TabIndex = 0
        ' 
        ' nameInput
        ' 
        nameInput.Location = New Point(16, 43)
        nameInput.Name = "nameInput"
        nameInput.PlaceholderText = "name"
        nameInput.Size = New Size(100, 23)
        nameInput.TabIndex = 1
        ' 
        ' itemNameLabel
        ' 
        itemNameLabel.AutoSize = True
        itemNameLabel.Font = New Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        itemNameLabel.Location = New Point(24, 8)
        itemNameLabel.Name = "itemNameLabel"
        itemNameLabel.Size = New Size(78, 23)
        itemNameLabel.TabIndex = 0
        itemNameLabel.Text = "Item Name"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(categoryPicker)
        Panel2.Controls.Add(itemCategoryLabel)
        Panel2.Location = New Point(138, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(139, 81)
        Panel2.TabIndex = 1
        ' 
        ' categoryPicker
        ' 
        categoryPicker.FormattingEnabled = True
        categoryPicker.Items.AddRange(New Object() {"Book ", "Electronic ", "Bag ", "Stationery", "Shoe", "ID Card"})
        categoryPicker.Location = New Point(11, 43)
        categoryPicker.Name = "categoryPicker"
        categoryPicker.Size = New Size(121, 23)
        categoryPicker.TabIndex = 3
        categoryPicker.Text = "Bag"
        ' 
        ' itemCategoryLabel
        ' 
        itemCategoryLabel.AutoSize = True
        itemCategoryLabel.Font = New Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        itemCategoryLabel.Location = New Point(24, 8)
        itemCategoryLabel.Name = "itemCategoryLabel"
        itemCategoryLabel.Size = New Size(97, 23)
        itemCategoryLabel.TabIndex = 2
        itemCategoryLabel.Text = "Item Category"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(dateLostPicker)
        Panel3.Controls.Add(dateLostLabel)
        Panel3.Location = New Point(283, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(149, 81)
        Panel3.TabIndex = 2
        ' 
        ' dateLostPicker
        ' 
        dateLostPicker.Location = New Point(5, 43)
        dateLostPicker.Name = "dateLostPicker"
        dateLostPicker.Size = New Size(141, 23)
        dateLostPicker.TabIndex = 5
        ' 
        ' dateLostLabel
        ' 
        dateLostLabel.AutoSize = True
        dateLostLabel.Font = New Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dateLostLabel.Location = New Point(26, 8)
        dateLostLabel.Name = "dateLostLabel"
        dateLostLabel.Size = New Size(69, 23)
        dateLostLabel.TabIndex = 4
        dateLostLabel.Text = "Date Lost"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(timeLostPicker)
        Panel4.Controls.Add(timeLostLabel)
        Panel4.Location = New Point(438, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(129, 84)
        Panel4.TabIndex = 3
        ' 
        ' timeLostPicker
        ' 
        timeLostPicker.Location = New Point(10, 40)
        timeLostPicker.Name = "timeLostPicker"
        timeLostPicker.Size = New Size(106, 23)
        timeLostPicker.TabIndex = 3
        ' 
        ' timeLostLabel
        ' 
        timeLostLabel.AutoSize = True
        timeLostLabel.Font = New Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        timeLostLabel.Location = New Point(24, 9)
        timeLostLabel.Name = "timeLostLabel"
        timeLostLabel.Size = New Size(72, 23)
        timeLostLabel.TabIndex = 2
        timeLostLabel.Text = "Time Lost"
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(locationInput)
        Panel5.Controls.Add(locationItemLostLabel)
        Panel5.Location = New Point(3, 93)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(294, 84)
        Panel5.TabIndex = 4
        ' 
        ' locationInput
        ' 
        locationInput.Location = New Point(11, 43)
        locationInput.Name = "locationInput"
        locationInput.PlaceholderText = "location on or off campus item was lost"
        locationInput.Size = New Size(267, 23)
        locationInput.TabIndex = 4
        ' 
        ' locationItemLostLabel
        ' 
        locationItemLostLabel.AutoSize = True
        locationItemLostLabel.Font = New Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        locationItemLostLabel.Location = New Point(11, 9)
        locationItemLostLabel.Name = "locationItemLostLabel"
        locationItemLostLabel.Size = New Size(152, 23)
        locationItemLostLabel.TabIndex = 3
        locationItemLostLabel.Text = "Location Item was Lost"
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(descriptionInput)
        Panel6.Controls.Add(itemDescriptionLabel)
        Panel6.Location = New Point(3, 183)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(429, 82)
        Panel6.TabIndex = 5
        ' 
        ' descriptionInput
        ' 
        descriptionInput.Location = New Point(16, 47)
        descriptionInput.Name = "descriptionInput"
        descriptionInput.PlaceholderText = "description of lost item"
        descriptionInput.Size = New Size(397, 23)
        descriptionInput.TabIndex = 5
        ' 
        ' itemDescriptionLabel
        ' 
        itemDescriptionLabel.AutoSize = True
        itemDescriptionLabel.Font = New Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        itemDescriptionLabel.Location = New Point(10, 9)
        itemDescriptionLabel.Name = "itemDescriptionLabel"
        itemDescriptionLabel.Size = New Size(113, 23)
        itemDescriptionLabel.TabIndex = 5
        itemDescriptionLabel.Text = "Item Description"
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(emailInput)
        Panel7.Controls.Add(phonenumberInput)
        Panel7.Controls.Add(emailLabel)
        Panel7.Controls.Add(phonenumberLabel)
        Panel7.Controls.Add(contactInfoLabel)
        Panel7.Location = New Point(3, 271)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(429, 100)
        Panel7.TabIndex = 6
        ' 
        ' emailInput
        ' 
        emailInput.Location = New Point(253, 52)
        emailInput.Name = "emailInput"
        emailInput.PlaceholderText = "hello@me.com"
        emailInput.Size = New Size(122, 23)
        emailInput.TabIndex = 11
        ' 
        ' phonenumberInput
        ' 
        phonenumberInput.Location = New Point(16, 52)
        phonenumberInput.Name = "phonenumberInput"
        phonenumberInput.PlaceholderText = "0XX XXX XXXX"
        phonenumberInput.Size = New Size(122, 23)
        phonenumberInput.TabIndex = 5
        ' 
        ' emailLabel
        ' 
        emailLabel.AutoSize = True
        emailLabel.Font = New Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        emailLabel.Location = New Point(253, 33)
        emailLabel.Margin = New Padding(2, 0, 2, 0)
        emailLabel.Name = "emailLabel"
        emailLabel.Size = New Size(41, 16)
        emailLabel.TabIndex = 10
        emailLabel.Text = "Email"
        ' 
        ' phonenumberLabel
        ' 
        phonenumberLabel.AutoSize = True
        phonenumberLabel.Font = New Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        phonenumberLabel.Location = New Point(16, 33)
        phonenumberLabel.Margin = New Padding(2, 0, 2, 0)
        phonenumberLabel.Name = "phonenumberLabel"
        phonenumberLabel.Size = New Size(91, 16)
        phonenumberLabel.TabIndex = 9
        phonenumberLabel.Text = "Phone Number"
        ' 
        ' contactInfoLabel
        ' 
        contactInfoLabel.AutoSize = True
        contactInfoLabel.Location = New Point(16, 9)
        contactInfoLabel.Name = "contactInfoLabel"
        contactInfoLabel.Size = New Size(115, 15)
        contactInfoLabel.TabIndex = 0
        contactInfoLabel.Text = "Contact Information"
        ' 
        ' clearFormBtn
        ' 
        clearFormBtn.Location = New Point(443, 377)
        clearFormBtn.Name = "clearFormBtn"
        clearFormBtn.Size = New Size(139, 23)
        clearFormBtn.TabIndex = 9
        clearFormBtn.Text = "Clear Form"
        clearFormBtn.UseVisualStyleBackColor = True
        ' 
        ' submitformBtn
        ' 
        submitformBtn.Location = New Point(588, 377)
        submitformBtn.Name = "submitformBtn"
        submitformBtn.Size = New Size(161, 23)
        submitformBtn.TabIndex = 10
        submitformBtn.Text = "Submit Form"
        submitformBtn.UseVisualStyleBackColor = True
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = SystemColors.AppWorkspace
        Panel8.Controls.Add(dashboardBtn)
        Panel8.Controls.Add(myClaimsBtn)
        Panel8.Controls.Add(PictureBox9)
        Panel8.Controls.Add(Button2)
        Panel8.Controls.Add(lostItemBtn)
        Panel8.Controls.Add(myReportsBtn)
        Panel8.Controls.Add(foundItemsBtn)
        Panel8.Controls.Add(PictureBox8)
        Panel8.Controls.Add(PictureBox7)
        Panel8.Controls.Add(PictureBox6)
        Panel8.Controls.Add(reportFoundItemBtn)
        Panel8.Controls.Add(PictureBox5)
        Panel8.Controls.Add(reportlostitembtn)
        Panel8.Controls.Add(PictureBox4)
        Panel8.Controls.Add(PictureBox3)
        Panel8.Controls.Add(PictureBox1)
        Panel8.Controls.Add(PictureBox2)
        Panel8.Controls.Add(bckToLogin)
        Panel8.Location = New Point(5, 6)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(188, 489)
        Panel8.TabIndex = 15
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
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(39, 449)
        Button2.Margin = New Padding(2)
        Button2.Name = "Button2"
        Button2.Size = New Size(136, 26)
        Button2.TabIndex = 21
        Button2.Text = "PROFILE"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' lostItemBtn
        ' 
        lostItemBtn.BackColor = Color.White
        lostItemBtn.FlatStyle = FlatStyle.Flat
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
        foundItemsBtn.BackColor = Color.White
        foundItemsBtn.FlatStyle = FlatStyle.Flat
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
        reportFoundItemBtn.BackColor = Color.WhiteSmoke
        reportFoundItemBtn.FlatStyle = FlatStyle.Flat
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
        reportlostitembtn.BackColor = Color.Gray
        reportlostitembtn.FlatStyle = FlatStyle.Flat
        reportlostitembtn.ForeColor = Color.White
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
        ' ReportLostItems
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(784, 503)
        Controls.Add(Panel8)
        Controls.Add(submitformBtn)
        Controls.Add(clearFormBtn)
        Controls.Add(pnlFormContent)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Margin = New Padding(2)
        Name = "ReportLostItems"
        Text = "Form4"
        pnlFormContent.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel8.ResumeLayout(False)
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
    Friend WithEvents pnlFormContent As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents nameInput As TextBox
    Friend WithEvents itemNameLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents itemCategoryLabel As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents categoryPicker As ComboBox
    Friend WithEvents dateLostPicker As DateTimePicker
    Friend WithEvents dateLostLabel As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents timeLostPicker As DateTimePicker
    Friend WithEvents timeLostLabel As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents locationInput As TextBox
    Friend WithEvents locationItemLostLabel As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents itemDescriptionLabel As Label
    Friend WithEvents descriptionInput As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents emailInput As TextBox
    Friend WithEvents phonenumberInput As TextBox
    Friend WithEvents emailLabel As Label
    Friend WithEvents phonenumberLabel As Label
    Friend WithEvents contactInfoLabel As Label
    Friend WithEvents clearFormBtn As Button
    Friend WithEvents submitformBtn As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents myClaimsBtn As Button
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Button2 As Button
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
    Friend WithEvents dashboardBtn As Button
End Class
