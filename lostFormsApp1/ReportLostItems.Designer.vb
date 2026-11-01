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
        backBtn = New Button()
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
        pnlFormContent.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        SuspendLayout()
        ' 
        ' backBtn
        ' 
        backBtn.Location = New Point(11, 11)
        backBtn.Margin = New Padding(2)
        backBtn.Name = "backBtn"
        backBtn.Size = New Size(36, 25)
        backBtn.TabIndex = 1
        backBtn.Text = "<<"
        backBtn.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(51, 11)
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
        Label5.Location = New Point(60, 42)
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
        pnlFormContent.Location = New Point(60, 72)
        pnlFormContent.Name = "pnlFormContent"
        pnlFormContent.Size = New Size(458, 261)
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
        Panel4.Location = New Point(3, 90)
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
        Panel5.Location = New Point(138, 90)
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
        Panel6.Location = New Point(3, 180)
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
        Panel7.Location = New Point(3, 268)
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
        clearFormBtn.Location = New Point(297, 341)
        clearFormBtn.Name = "clearFormBtn"
        clearFormBtn.Size = New Size(75, 23)
        clearFormBtn.TabIndex = 9
        clearFormBtn.Text = "Clear Form"
        clearFormBtn.UseVisualStyleBackColor = True
        ' 
        ' submitformBtn
        ' 
        submitformBtn.Location = New Point(378, 341)
        submitformBtn.Name = "submitformBtn"
        submitformBtn.Size = New Size(120, 23)
        submitformBtn.TabIndex = 10
        submitformBtn.Text = "Submit Form"
        submitformBtn.UseVisualStyleBackColor = True
        ' 
        ' ReportLostItems
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(567, 421)
        Controls.Add(submitformBtn)
        Controls.Add(clearFormBtn)
        Controls.Add(pnlFormContent)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(backBtn)
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
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents backBtn As Button
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
End Class
