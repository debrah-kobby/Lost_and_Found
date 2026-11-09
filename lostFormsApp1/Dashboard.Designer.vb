<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        bckToLogin = New Button()
        Label5 = New Label()
        Panel1 = New Panel()
        myClaimsBtn = New Button()
        myReportsBtn = New Button()
        lostItemBtn = New Button()
        foundItemsBtn = New Button()
        reportFoundItemBtn = New Button()
        reportlostitembtn = New Button()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        PictureBox9 = New PictureBox()
        Button2 = New Button()
        Button1 = New Button()
        PictureBox8 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' bckToLogin
        ' 
        bckToLogin.BackColor = Color.Black
        bckToLogin.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bckToLogin.ForeColor = Color.White
        bckToLogin.Location = New Point(132, 12)
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
        Label5.ForeColor = Color.DimGray
        Label5.Location = New Point(216, 47)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(170, 16)
        Label5.TabIndex = 6
        Label5.Text = "Welcome to Your Dashboard!"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.AppWorkspace
        Panel1.Location = New Point(209, 86)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(568, 409)
        Panel1.TabIndex = 7
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
        ' reportFoundItemBtn
        ' 
        reportFoundItemBtn.BackColor = Color.White
        reportFoundItemBtn.FlatStyle = FlatStyle.Flat
        reportFoundItemBtn.Location = New Point(39, 180)
        reportFoundItemBtn.Margin = New Padding(2)
        reportFoundItemBtn.Name = "reportFoundItemBtn"
        reportFoundItemBtn.Size = New Size(136, 26)
        reportFoundItemBtn.TabIndex = 10
        reportFoundItemBtn.Text = "REPORT FOUND ITEM"
        reportFoundItemBtn.UseVisualStyleBackColor = False
        ' 
        ' reportlostitembtn
        ' 
        reportlostitembtn.BackColor = Color.White
        reportlostitembtn.FlatStyle = FlatStyle.Flat
        reportlostitembtn.Location = New Point(39, 130)
        reportlostitembtn.Margin = New Padding(2)
        reportlostitembtn.Name = "reportlostitembtn"
        reportlostitembtn.Size = New Size(136, 26)
        reportlostitembtn.TabIndex = 9
        reportlostitembtn.Text = "REPORT LOST ITEM"
        reportlostitembtn.UseVisualStyleBackColor = False
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
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.AppWorkspace
        Panel2.Controls.Add(myClaimsBtn)
        Panel2.Controls.Add(PictureBox9)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(lostItemBtn)
        Panel2.Controls.Add(myReportsBtn)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(foundItemsBtn)
        Panel2.Controls.Add(PictureBox8)
        Panel2.Controls.Add(PictureBox7)
        Panel2.Controls.Add(PictureBox6)
        Panel2.Controls.Add(reportFoundItemBtn)
        Panel2.Controls.Add(PictureBox5)
        Panel2.Controls.Add(reportlostitembtn)
        Panel2.Controls.Add(PictureBox4)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(bckToLogin)
        Panel2.Location = New Point(6, 6)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(188, 489)
        Panel2.TabIndex = 14
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
        ' Button1
        ' 
        Button1.BackColor = SystemColors.AppWorkspace
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(39, 80)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(136, 24)
        Button1.TabIndex = 15
        Button1.Text = "DASHBOARD"
        Button1.UseVisualStyleBackColor = False
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
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(10, 80)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(24, 24)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Window
        Label2.Font = New Font("Papyrus", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(209, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(234, 30)
        Label2.TabIndex = 15
        Label2.Text = "Lost and Found System"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Window
        ClientSize = New Size(783, 507)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label5)
        Margin = New Padding(2)
        Name = "Dashboard"
        Text = "Form3"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents bckToLogin As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents myClaimsBtn As Button
    Friend WithEvents myReportsBtn As Button
    Friend WithEvents lostItemBtn As Button
    Friend WithEvents foundItemsBtn As Button
    Friend WithEvents reportFoundItemBtn As Button
    Friend WithEvents reportlostitembtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
