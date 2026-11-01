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
        Button1 = New Button()
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
        Panel1.SuspendLayout()
        Panel8.SuspendLayout()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(11, 11)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(43, 25)
        Button1.TabIndex = 1
        Button1.Text = "<<"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(58, 11)
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
        Label5.Location = New Point(58, 45)
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
        Panel1.Location = New Point(58, 64)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(584, 397)
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
        clearFormBtn.Location = New Point(389, 476)
        clearFormBtn.Name = "clearFormBtn"
        clearFormBtn.Size = New Size(75, 23)
        clearFormBtn.TabIndex = 9
        clearFormBtn.Text = "Clear Form"
        clearFormBtn.UseVisualStyleBackColor = True
        ' 
        ' submitFormBtn
        ' 
        submitFormBtn.Location = New Point(521, 476)
        submitFormBtn.Name = "submitFormBtn"
        submitFormBtn.Size = New Size(99, 23)
        submitFormBtn.TabIndex = 10
        submitFormBtn.Text = "Submit Form"
        submitFormBtn.UseVisualStyleBackColor = True
        ' 
        ' ReportFoundItems
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(782, 514)
        Controls.Add(submitFormBtn)
        Controls.Add(clearFormBtn)
        Controls.Add(Panel1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Button1)
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
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
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
End Class
