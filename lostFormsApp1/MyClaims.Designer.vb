<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyClaims
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyClaims))
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
        Label5 = New Label()
        Label4 = New Label()
        Panel2 = New Panel()
        Label15 = New Label()
        searchBtn = New Button()
        Label14 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        toDatePicker = New DateTimePicker()
        fromDatePicker = New DateTimePicker()
        statusComboBox = New ComboBox()
        Label11 = New Label()
        claimsGrid = New DataGridView()
        ClaimID = New DataGridViewTextBoxColumn()
        ItemName = New DataGridViewTextBoxColumn()
        Category = New DataGridViewTextBoxColumn()
        Location = New DataGridViewTextBoxColumn()
        DateReported = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        Action = New DataGridViewTextBoxColumn()
        Panel3 = New Panel()
        Button3 = New Button()
        searchedStatus = New Label()
        searchedDate = New Label()
        searchedCategory = New Label()
        searchedItemName = New Label()
        searchedClaimID = New Label()
        Label21 = New Label()
        Label20 = New Label()
        Label19 = New Label()
        Label18 = New Label()
        Label17 = New Label()
        Label16 = New Label()
        Panel1 = New Panel()
        rejectedCount = New Label()
        approvedCount = New Label()
        pendingCount = New Label()
        totalReportsNumber = New Label()
        approvedCountLbl = New Label()
        rejectedCountLbl = New Label()
        pendingCountLbl = New Label()
        totalReportsLbl = New Label()
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
        Panel2.SuspendLayout()
        CType(claimsGrid, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
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
        Panel8.Location = New Point(2, 3)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(188, 489)
        Panel8.TabIndex = 17
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
        myClaimsBtn.BackColor = Color.Gray
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
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(343, 48)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(239, 16)
        Label5.TabIndex = 20
        Label5.Text = "View and Track Items You Have Claimed"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(395, 16)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(114, 25)
        Label4.TabIndex = 19
        Label4.Text = "My Claims"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.AppWorkspace
        Panel2.Controls.Add(Label15)
        Panel2.Controls.Add(searchBtn)
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(toDatePicker)
        Panel2.Controls.Add(fromDatePicker)
        Panel2.Controls.Add(statusComboBox)
        Panel2.Controls.Add(Label11)
        Panel2.Location = New Point(213, 183)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(609, 113)
        Panel2.TabIndex = 22
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.White
        Label15.Location = New Point(317, 50)
        Label15.Margin = New Padding(2, 0, 2, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(30, 16)
        Label15.TabIndex = 29
        Label15.Text = "To :"
        ' 
        ' searchBtn
        ' 
        searchBtn.FlatStyle = FlatStyle.Flat
        searchBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchBtn.Location = New Point(466, 67)
        searchBtn.Name = "searchBtn"
        searchBtn.Size = New Size(96, 28)
        searchBtn.TabIndex = 28
        searchBtn.Text = "Search"
        searchBtn.UseVisualStyleBackColor = True
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.White
        Label14.Location = New Point(162, 50)
        Label14.Margin = New Padding(2, 0, 2, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(46, 16)
        Label14.TabIndex = 27
        Label14.Text = "From :"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.White
        Label12.Location = New Point(418, 18)
        Label12.Margin = New Padding(2, 0, 2, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(41, 16)
        Label12.TabIndex = 25
        Label12.Text = "Status"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.White
        Label13.Location = New Point(77, 69)
        Label13.Margin = New Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(43, 16)
        Label13.TabIndex = 26
        Label13.Text = "Date :"
        ' 
        ' toDatePicker
        ' 
        toDatePicker.Location = New Point(289, 69)
        toDatePicker.Name = "toDatePicker"
        toDatePicker.Size = New Size(129, 23)
        toDatePicker.TabIndex = 24
        ' 
        ' fromDatePicker
        ' 
        fromDatePicker.Location = New Point(130, 69)
        fromDatePicker.Name = "fromDatePicker"
        fromDatePicker.Size = New Size(129, 23)
        fromDatePicker.TabIndex = 23
        ' 
        ' statusComboBox
        ' 
        statusComboBox.FlatStyle = FlatStyle.Flat
        statusComboBox.FormattingEnabled = True
        statusComboBox.Location = New Point(465, 15)
        statusComboBox.Name = "statusComboBox"
        statusComboBox.Size = New Size(97, 23)
        statusComboBox.TabIndex = 22
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.White
        Label11.Location = New Point(14, 25)
        Label11.Margin = New Padding(2, 0, 2, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(101, 19)
        Label11.TabIndex = 21
        Label11.Text = "Search Claims"
        ' 
        ' claimsGrid
        ' 
        claimsGrid.AllowUserToAddRows = False
        claimsGrid.AllowUserToDeleteRows = False
        claimsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        claimsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        claimsGrid.Columns.AddRange(New DataGridViewColumn() {ClaimID, ItemName, Category, Location, DateReported, Status, Action})
        claimsGrid.Location = New Point(213, 312)
        claimsGrid.Name = "claimsGrid"
        claimsGrid.ReadOnly = True
        claimsGrid.RowHeadersVisible = False
        claimsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        claimsGrid.Size = New Size(610, 150)
        claimsGrid.TabIndex = 23
        ' 
        ' ClaimID
        ' 
        ClaimID.HeaderText = "Claim ID"
        ClaimID.Name = "ClaimID"
        ClaimID.ReadOnly = True
        ' 
        ' ItemName
        ' 
        ItemName.HeaderText = "Item Name"
        ItemName.Name = "ItemName"
        ItemName.ReadOnly = True
        ' 
        ' Category
        ' 
        Category.HeaderText = "Category"
        Category.Name = "Category"
        Category.ReadOnly = True
        ' 
        ' Location
        ' 
        Location.HeaderText = "Location"
        Location.Name = "Location"
        Location.ReadOnly = True
        ' 
        ' DateReported
        ' 
        DateReported.HeaderText = "Date Reported"
        DateReported.Name = "DateReported"
        DateReported.ReadOnly = True
        ' 
        ' Status
        ' 
        Status.HeaderText = "Status"
        Status.Name = "Status"
        Status.ReadOnly = True
        ' 
        ' Action
        ' 
        Action.HeaderText = "Action"
        Action.Name = "Action"
        Action.ReadOnly = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(searchedStatus)
        Panel3.Controls.Add(searchedDate)
        Panel3.Controls.Add(searchedCategory)
        Panel3.Controls.Add(searchedItemName)
        Panel3.Controls.Add(searchedClaimID)
        Panel3.Controls.Add(Label21)
        Panel3.Controls.Add(Label20)
        Panel3.Controls.Add(Label19)
        Panel3.Controls.Add(Label18)
        Panel3.Controls.Add(Label17)
        Panel3.Controls.Add(Label16)
        Panel3.Location = New Point(212, 468)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(611, 243)
        Panel3.TabIndex = 24
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.AppWorkspace
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(467, 208)
        Button3.Name = "Button3"
        Button3.Size = New Size(123, 23)
        Button3.TabIndex = 41
        Button3.Text = "Close"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' searchedStatus
        ' 
        searchedStatus.AutoSize = True
        searchedStatus.Font = New Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        searchedStatus.ForeColor = Color.Black
        searchedStatus.Location = New Point(176, 181)
        searchedStatus.Margin = New Padding(2, 0, 2, 0)
        searchedStatus.Name = "searchedStatus"
        searchedStatus.Size = New Size(159, 19)
        searchedStatus.TabIndex = 40
        searchedStatus.Text = "Searched Claim Details"
        ' 
        ' searchedDate
        ' 
        searchedDate.AutoSize = True
        searchedDate.Font = New Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        searchedDate.ForeColor = Color.Black
        searchedDate.Location = New Point(176, 148)
        searchedDate.Margin = New Padding(2, 0, 2, 0)
        searchedDate.Name = "searchedDate"
        searchedDate.Size = New Size(159, 19)
        searchedDate.TabIndex = 39
        searchedDate.Text = "Searched Claim Details"
        ' 
        ' searchedCategory
        ' 
        searchedCategory.AutoSize = True
        searchedCategory.Font = New Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        searchedCategory.ForeColor = Color.Black
        searchedCategory.Location = New Point(176, 116)
        searchedCategory.Margin = New Padding(2, 0, 2, 0)
        searchedCategory.Name = "searchedCategory"
        searchedCategory.Size = New Size(159, 19)
        searchedCategory.TabIndex = 38
        searchedCategory.Text = "Searched Claim Details"
        ' 
        ' searchedItemName
        ' 
        searchedItemName.AutoSize = True
        searchedItemName.Font = New Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        searchedItemName.ForeColor = Color.Black
        searchedItemName.Location = New Point(176, 79)
        searchedItemName.Margin = New Padding(2, 0, 2, 0)
        searchedItemName.Name = "searchedItemName"
        searchedItemName.Size = New Size(159, 19)
        searchedItemName.TabIndex = 37
        searchedItemName.Text = "Searched Claim Details"
        ' 
        ' searchedClaimID
        ' 
        searchedClaimID.AutoSize = True
        searchedClaimID.Font = New Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        searchedClaimID.ForeColor = Color.Black
        searchedClaimID.Location = New Point(176, 40)
        searchedClaimID.Margin = New Padding(2, 0, 2, 0)
        searchedClaimID.Name = "searchedClaimID"
        searchedClaimID.Size = New Size(159, 19)
        searchedClaimID.TabIndex = 36
        searchedClaimID.Text = "Searched Claim Details"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = Color.Black
        Label21.Location = New Point(15, 180)
        Label21.Margin = New Padding(2, 0, 2, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(58, 19)
        Label21.TabIndex = 35
        Label21.Text = "Status :"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label20.ForeColor = Color.Black
        Label20.Location = New Point(15, 148)
        Label20.Margin = New Padding(2, 0, 2, 0)
        Label20.Name = "Label20"
        Label20.Size = New Size(49, 19)
        Label20.TabIndex = 34
        Label20.Text = "Date :"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = Color.Black
        Label19.Location = New Point(13, 116)
        Label19.Margin = New Padding(2, 0, 2, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(78, 19)
        Label19.TabIndex = 33
        Label19.Text = "Category :"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = Color.Black
        Label18.Location = New Point(12, 79)
        Label18.Margin = New Padding(2, 0, 2, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(89, 19)
        Label18.TabIndex = 32
        Label18.Text = "Item Name :"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = Color.Black
        Label17.Location = New Point(10, 40)
        Label17.Margin = New Padding(2, 0, 2, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(77, 19)
        Label17.TabIndex = 31
        Label17.Text = "Claim ID :"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.Black
        Label16.Location = New Point(201, 5)
        Label16.Margin = New Padding(2, 0, 2, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(159, 19)
        Label16.TabIndex = 30
        Label16.Text = "Searched Claim Details"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.AppWorkspace
        Panel1.Controls.Add(rejectedCount)
        Panel1.Controls.Add(approvedCount)
        Panel1.Controls.Add(pendingCount)
        Panel1.Controls.Add(totalReportsNumber)
        Panel1.Controls.Add(approvedCountLbl)
        Panel1.Controls.Add(rejectedCountLbl)
        Panel1.Controls.Add(pendingCountLbl)
        Panel1.Controls.Add(totalReportsLbl)
        Panel1.Location = New Point(280, 81)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(405, 76)
        Panel1.TabIndex = 25
        ' 
        ' rejectedCount
        ' 
        rejectedCount.AutoSize = True
        rejectedCount.Font = New Font("Segoe UI Emoji", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        rejectedCount.Location = New Point(327, 33)
        rejectedCount.Name = "rejectedCount"
        rejectedCount.Size = New Size(53, 32)
        rejectedCount.TabIndex = 7
        rejectedCount.Text = "120"
        ' 
        ' approvedCount
        ' 
        approvedCount.AutoSize = True
        approvedCount.Font = New Font("Segoe UI Emoji", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        approvedCount.Location = New Point(227, 33)
        approvedCount.Name = "approvedCount"
        approvedCount.Size = New Size(53, 32)
        approvedCount.TabIndex = 6
        approvedCount.Text = "120"
        ' 
        ' pendingCount
        ' 
        pendingCount.AutoSize = True
        pendingCount.Font = New Font("Segoe UI Emoji", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        pendingCount.Location = New Point(133, 33)
        pendingCount.Name = "pendingCount"
        pendingCount.Size = New Size(53, 32)
        pendingCount.TabIndex = 5
        pendingCount.Text = "120"
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
        ' approvedCountLbl
        ' 
        approvedCountLbl.AutoSize = True
        approvedCountLbl.Font = New Font("Nirmala Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        approvedCountLbl.ForeColor = Color.White
        approvedCountLbl.Location = New Point(225, 9)
        approvedCountLbl.Name = "approvedCountLbl"
        approvedCountLbl.Size = New Size(66, 17)
        approvedCountLbl.TabIndex = 3
        approvedCountLbl.Text = "Approved"
        ' 
        ' rejectedCountLbl
        ' 
        rejectedCountLbl.AutoSize = True
        rejectedCountLbl.Font = New Font("Nirmala Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rejectedCountLbl.ForeColor = Color.White
        rejectedCountLbl.Location = New Point(327, 9)
        rejectedCountLbl.Name = "rejectedCountLbl"
        rejectedCountLbl.Size = New Size(58, 17)
        rejectedCountLbl.TabIndex = 2
        rejectedCountLbl.Text = "Rejected"
        ' 
        ' pendingCountLbl
        ' 
        pendingCountLbl.AutoSize = True
        pendingCountLbl.Font = New Font("Nirmala Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pendingCountLbl.ForeColor = Color.White
        pendingCountLbl.Location = New Point(143, 9)
        pendingCountLbl.Name = "pendingCountLbl"
        pendingCountLbl.Size = New Size(55, 17)
        pendingCountLbl.TabIndex = 1
        pendingCountLbl.Text = "Pending"
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
        ' MyClaims
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(845, 493)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        Controls.Add(claimsGrid)
        Controls.Add(Panel2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Panel8)
        Name = "MyClaims"
        Text = "MyClaims"
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
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(claimsGrid, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
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
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents searchBtn As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents toDatePicker As DateTimePicker
    Friend WithEvents fromDatePicker As DateTimePicker
    Friend WithEvents statusComboBox As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents claimsGrid As DataGridView
    Friend WithEvents ClaimID As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents Location As DataGridViewTextBoxColumn
    Friend WithEvents DateReported As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Action As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents searchedStatus As Label
    Friend WithEvents searchedDate As Label
    Friend WithEvents searchedCategory As Label
    Friend WithEvents searchedItemName As Label
    Friend WithEvents searchedClaimID As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rejectedCount As Label
    Friend WithEvents approvedCount As Label
    Friend WithEvents pendingCount As Label
    Friend WithEvents totalReportsNumber As Label
    Friend WithEvents approvedCountLbl As Label
    Friend WithEvents rejectedCountLbl As Label
    Friend WithEvents pendingCountLbl As Label
    Friend WithEvents totalReportsLbl As Label
End Class
