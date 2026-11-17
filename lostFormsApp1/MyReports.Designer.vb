<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyReports))
        Panel8 = New Panel()
        dashboardBtn = New Button()
        myClaimsBtn = New Button()
        PictureBox9 = New PictureBox()
        myProfileBtn = New Button()
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
        Label5 = New Label()
        Panel1 = New Panel()
        foundCount = New Label()
        claimedCount = New Label()
        lostCount = New Label()
        totalReportsNumber = New Label()
        claimedCountLbl = New Label()
        foundCountLbl = New Label()
        lostCountLbl = New Label()
        totalReportsLbl = New Label()
        Panel2 = New Panel()
        generateBtn = New Button()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        toDatePicker = New DateTimePicker()
        fromDatePicker = New DateTimePicker()
        reportTypeComboBox = New ComboBox()
        Label11 = New Label()
        lostReportsGrid = New DataGridView()
        ItemID = New DataGridViewTextBoxColumn()
        ItemName = New DataGridViewTextBoxColumn()
        Category = New DataGridViewTextBoxColumn()
        LocationLost = New DataGridViewTextBoxColumn()
        DateLost = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        foundReportsGrid = New DataGridView()
        FoundReportID = New DataGridViewTextBoxColumn()
        FoundItemName = New DataGridViewTextBoxColumn()
        FoundCategory = New DataGridViewTextBoxColumn()
        FoundLocation = New DataGridViewTextBoxColumn()
        FoundDate = New DataGridViewTextBoxColumn()
        FoundStatus = New DataGridViewTextBoxColumn()
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
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(lostReportsGrid, ComponentModel.ISupportInitialize).BeginInit()
        CType(foundReportsGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = SystemColors.AppWorkspace
        Panel8.Controls.Add(dashboardBtn)
        Panel8.Controls.Add(myClaimsBtn)
        Panel8.Controls.Add(PictureBox9)
        Panel8.Controls.Add(myProfileBtn)
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
        Panel8.Location = New Point(0, 0)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(188, 489)
        Panel8.TabIndex = 16
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
        ' myProfileBtn
        ' 
        myProfileBtn.BackColor = Color.White
        myProfileBtn.FlatStyle = FlatStyle.Flat
        myProfileBtn.Location = New Point(39, 449)
        myProfileBtn.Margin = New Padding(2)
        myProfileBtn.Name = "myProfileBtn"
        myProfileBtn.Size = New Size(136, 26)
        myProfileBtn.TabIndex = 21
        myProfileBtn.Text = "PROFILE"
        myProfileBtn.UseVisualStyleBackColor = False
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
        myReportsBtn.BackColor = Color.Gray
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
        reportlostitembtn.BackColor = Color.White
        reportlostitembtn.FlatStyle = FlatStyle.Flat
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
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(348, 13)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(121, 25)
        Label4.TabIndex = 17
        Label4.Text = "My Reports"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(259, 38)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(351, 16)
        Label5.TabIndex = 18
        Label5.Text = "Reports and Analytics      View all your reports and analytics"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.AppWorkspace
        Panel1.Controls.Add(foundCount)
        Panel1.Controls.Add(claimedCount)
        Panel1.Controls.Add(lostCount)
        Panel1.Controls.Add(totalReportsNumber)
        Panel1.Controls.Add(claimedCountLbl)
        Panel1.Controls.Add(foundCountLbl)
        Panel1.Controls.Add(lostCountLbl)
        Panel1.Controls.Add(totalReportsLbl)
        Panel1.Location = New Point(259, 80)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(405, 76)
        Panel1.TabIndex = 19
        ' 
        ' foundCount
        ' 
        foundCount.AutoSize = True
        foundCount.Font = New Font("Segoe UI Emoji", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        foundCount.Location = New Point(327, 33)
        foundCount.Name = "foundCount"
        foundCount.Size = New Size(53, 32)
        foundCount.TabIndex = 7
        foundCount.Text = "120"
        ' 
        ' claimedCount
        ' 
        claimedCount.AutoSize = True
        claimedCount.Font = New Font("Segoe UI Emoji", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        claimedCount.Location = New Point(227, 33)
        claimedCount.Name = "claimedCount"
        claimedCount.Size = New Size(53, 32)
        claimedCount.TabIndex = 6
        claimedCount.Text = "120"
        ' 
        ' lostCount
        ' 
        lostCount.AutoSize = True
        lostCount.Font = New Font("Segoe UI Emoji", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lostCount.Location = New Point(133, 33)
        lostCount.Name = "lostCount"
        lostCount.Size = New Size(53, 32)
        lostCount.TabIndex = 5
        lostCount.Text = "120"
        ' 
        ' totalReportsNumber
        ' 
        totalReportsNumber.AutoSize = True
        totalReportsNumber.Font = New Font("Segoe UI Emoji", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        totalReportsNumber.Location = New Point(23, 33)
        totalReportsNumber.Name = "totalReportsNumber"
        totalReportsNumber.Size = New Size(53, 32)
        totalReportsNumber.TabIndex = 4
        totalReportsNumber.Text = "120"
        ' 
        ' claimedCountLbl
        ' 
        claimedCountLbl.AutoSize = True
        claimedCountLbl.Font = New Font("Nirmala Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        claimedCountLbl.ForeColor = Color.White
        claimedCountLbl.Location = New Point(225, 9)
        claimedCountLbl.Name = "claimedCountLbl"
        claimedCountLbl.Size = New Size(55, 17)
        claimedCountLbl.TabIndex = 3
        claimedCountLbl.Text = "Claimed"
        ' 
        ' foundCountLbl
        ' 
        foundCountLbl.AutoSize = True
        foundCountLbl.Font = New Font("Nirmala Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        foundCountLbl.ForeColor = Color.White
        foundCountLbl.Location = New Point(327, 9)
        foundCountLbl.Name = "foundCountLbl"
        foundCountLbl.Size = New Size(44, 17)
        foundCountLbl.TabIndex = 2
        foundCountLbl.Text = "Found"
        ' 
        ' lostCountLbl
        ' 
        lostCountLbl.AutoSize = True
        lostCountLbl.Font = New Font("Nirmala Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lostCountLbl.ForeColor = Color.White
        lostCountLbl.Location = New Point(143, 9)
        lostCountLbl.Name = "lostCountLbl"
        lostCountLbl.Size = New Size(32, 17)
        lostCountLbl.TabIndex = 1
        lostCountLbl.Text = "Lost"
        ' 
        ' totalReportsLbl
        ' 
        totalReportsLbl.AutoSize = True
        totalReportsLbl.FlatStyle = FlatStyle.Flat
        totalReportsLbl.Font = New Font("Nirmala Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        totalReportsLbl.ForeColor = Color.White
        totalReportsLbl.Location = New Point(13, 8)
        totalReportsLbl.Name = "totalReportsLbl"
        totalReportsLbl.Size = New Size(86, 17)
        totalReportsLbl.TabIndex = 0
        totalReportsLbl.Text = "Total Reports"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.AppWorkspace
        Panel2.Controls.Add(generateBtn)
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(toDatePicker)
        Panel2.Controls.Add(fromDatePicker)
        Panel2.Controls.Add(reportTypeComboBox)
        Panel2.Controls.Add(Label11)
        Panel2.Location = New Point(204, 195)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(609, 113)
        Panel2.TabIndex = 20
        ' 
        ' generateBtn
        ' 
        generateBtn.FlatStyle = FlatStyle.Flat
        generateBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        generateBtn.Location = New Point(502, 57)
        generateBtn.Name = "generateBtn"
        generateBtn.Size = New Size(94, 24)
        generateBtn.TabIndex = 28
        generateBtn.Text = "Generate"
        generateBtn.UseVisualStyleBackColor = True
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.White
        Label14.Location = New Point(363, 37)
        Label14.Margin = New Padding(2, 0, 2, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(52, 16)
        Label14.TabIndex = 27
        Label14.Text = "To Date"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.White
        Label13.Location = New Point(206, 39)
        Label13.Margin = New Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(68, 16)
        Label13.TabIndex = 26
        Label13.Text = "From Date"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.White
        Label12.Location = New Point(8, 37)
        Label12.Margin = New Padding(2, 0, 2, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(75, 16)
        Label12.TabIndex = 25
        Label12.Text = "Report Type"
        ' 
        ' toDatePicker
        ' 
        toDatePicker.Location = New Point(363, 58)
        toDatePicker.Name = "toDatePicker"
        toDatePicker.Size = New Size(129, 23)
        toDatePicker.TabIndex = 24
        ' 
        ' fromDatePicker
        ' 
        fromDatePicker.Location = New Point(206, 58)
        fromDatePicker.Name = "fromDatePicker"
        fromDatePicker.Size = New Size(129, 23)
        fromDatePicker.TabIndex = 23
        ' 
        ' reportTypeComboBox
        ' 
        reportTypeComboBox.FlatStyle = FlatStyle.Flat
        reportTypeComboBox.FormattingEnabled = True
        reportTypeComboBox.Location = New Point(7, 58)
        reportTypeComboBox.Name = "reportTypeComboBox"
        reportTypeComboBox.Size = New Size(159, 23)
        reportTypeComboBox.TabIndex = 22
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.White
        Label11.Location = New Point(8, 6)
        Label11.Margin = New Padding(2, 0, 2, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(86, 16)
        Label11.TabIndex = 21
        Label11.Text = "Report Filters"
        ' 
        ' lostReportsGrid
        ' 
        lostReportsGrid.AllowUserToAddRows = False
        lostReportsGrid.AllowUserToDeleteRows = False
        lostReportsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        lostReportsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        lostReportsGrid.Columns.AddRange(New DataGridViewColumn() {ItemID, ItemName, Category, LocationLost, DateLost, Status})
        lostReportsGrid.Location = New Point(204, 339)
        lostReportsGrid.MultiSelect = False
        lostReportsGrid.Name = "lostReportsGrid"
        lostReportsGrid.ReadOnly = True
        lostReportsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        lostReportsGrid.Size = New Size(609, 150)
        lostReportsGrid.TabIndex = 21
        ' 
        ' ItemID
        ' 
        ItemID.HeaderText = "Item ID"
        ItemID.Name = "ItemID"
        ItemID.ReadOnly = True
        ' 
        ' ItemName
        ' 
        ItemName.HeaderText = "ItemName"
        ItemName.Name = "ItemName"
        ItemName.ReadOnly = True
        ' 
        ' Category
        ' 
        Category.HeaderText = "Category"
        Category.Name = "Category"
        Category.ReadOnly = True
        ' 
        ' LocationLost
        ' 
        LocationLost.HeaderText = "Location Lost"
        LocationLost.Name = "LocationLost"
        LocationLost.ReadOnly = True
        ' 
        ' DateLost
        ' 
        DateLost.HeaderText = "Date Lost"
        DateLost.Name = "DateLost"
        DateLost.ReadOnly = True
        ' 
        ' Status
        ' 
        Status.HeaderText = "Status"
        Status.Name = "Status"
        Status.ReadOnly = True
        ' 
        ' foundReportsGrid
        ' 
        foundReportsGrid.AllowUserToAddRows = False
        foundReportsGrid.AllowUserToDeleteRows = False
        foundReportsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        foundReportsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        foundReportsGrid.Columns.AddRange(New DataGridViewColumn() {FoundReportID, FoundItemName, FoundCategory, FoundLocation, FoundDate, FoundStatus})
        foundReportsGrid.Location = New Point(204, 502)
        foundReportsGrid.MultiSelect = False
        foundReportsGrid.Name = "foundReportsGrid"
        foundReportsGrid.ReadOnly = True
        foundReportsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        foundReportsGrid.Size = New Size(609, 150)
        foundReportsGrid.TabIndex = 22
        ' 
        ' FoundReportID
        ' 
        FoundReportID.HeaderText = "Item ID"
        FoundReportID.Name = "FoundReportID"
        FoundReportID.ReadOnly = True
        ' 
        ' FoundItemName
        ' 
        FoundItemName.HeaderText = "ItemName"
        FoundItemName.Name = "FoundItemName"
        FoundItemName.ReadOnly = True
        ' 
        ' FoundCategory
        ' 
        FoundCategory.HeaderText = "Category"
        FoundCategory.Name = "FoundCategory"
        FoundCategory.ReadOnly = True
        ' 
        ' FoundLocation
        ' 
        FoundLocation.HeaderText = "Location"
        FoundLocation.Name = "FoundLocation"
        FoundLocation.ReadOnly = True
        ' 
        ' FoundDate
        ' 
        FoundDate.HeaderText = "Date"
        FoundDate.Name = "FoundDate"
        FoundDate.ReadOnly = True
        ' 
        ' FoundStatus
        ' 
        FoundStatus.HeaderText = "Status"
        FoundStatus.Name = "FoundStatus"
        FoundStatus.ReadOnly = True
        ' 
        ' MyReports
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(838, 515)
        Controls.Add(foundReportsGrid)
        Controls.Add(lostReportsGrid)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Panel8)
        Name = "MyReports"
        Text = "MyReports"
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
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(lostReportsGrid, ComponentModel.ISupportInitialize).EndInit()
        CType(foundReportsGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel8 As Panel
    Friend WithEvents dashboardBtn As Button
    Friend WithEvents myClaimsBtn As Button
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents myProfileBtn As Button
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
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents claimedCountLbl As Label
    Friend WithEvents foundCountLbl As Label
    Friend WithEvents lostCountLbl As Label
    Friend WithEvents totalReportsLbl As Label
    Friend WithEvents totalReportsNumber As Label
    Friend WithEvents foundCount As Label
    Friend WithEvents claimedCount As Label
    Friend WithEvents lostCount As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents reportTypeComboBox As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents generateBtn As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents toDatePicker As DateTimePicker
    Friend WithEvents fromDatePicker As DateTimePicker
    Friend WithEvents lostReportsGrid As DataGridView
    Friend WithEvents ItemID As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents LocationLost As DataGridViewTextBoxColumn
    Friend WithEvents DateLost As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents foundReportsGrid As DataGridView
    Friend WithEvents FoundReportID As DataGridViewTextBoxColumn
    Friend WithEvents FoundItemName As DataGridViewTextBoxColumn
    Friend WithEvents FoundCategory As DataGridViewTextBoxColumn
    Friend WithEvents FoundLocation As DataGridViewTextBoxColumn
    Friend WithEvents FoundDate As DataGridViewTextBoxColumn
    Friend WithEvents FoundStatus As DataGridViewTextBoxColumn
End Class
