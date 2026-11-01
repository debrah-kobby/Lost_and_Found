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
        bckToLogin = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Panel1 = New Panel()
        myClaimsBtn = New Button()
        myReportsBtn = New Button()
        lostItemBtn = New Button()
        foundItemsBtn = New Button()
        reportFoundItemBtn = New Button()
        reportlostitembtn = New Button()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' bckToLogin
        ' 
        bckToLogin.Location = New Point(15, 7)
        bckToLogin.Margin = New Padding(2)
        bckToLogin.Name = "bckToLogin"
        bckToLogin.Size = New Size(34, 22)
        bckToLogin.TabIndex = 0
        bckToLogin.Text = "<<"
        bckToLogin.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(74, 4)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(243, 25)
        Label4.TabIndex = 5
        Label4.Text = "Lost And Found System "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(79, 32)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 16)
        Label5.TabIndex = 6
        Label5.Text = "Welcome, User !!"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(myClaimsBtn)
        Panel1.Controls.Add(myReportsBtn)
        Panel1.Controls.Add(lostItemBtn)
        Panel1.Controls.Add(foundItemsBtn)
        Panel1.Controls.Add(reportFoundItemBtn)
        Panel1.Controls.Add(reportlostitembtn)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(46, 53)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(568, 243)
        Panel1.TabIndex = 7
        ' 
        ' myClaimsBtn
        ' 
        myClaimsBtn.Location = New Point(312, 154)
        myClaimsBtn.Margin = New Padding(2)
        myClaimsBtn.Name = "myClaimsBtn"
        myClaimsBtn.Size = New Size(195, 26)
        myClaimsBtn.TabIndex = 14
        myClaimsBtn.Text = "MY CLAIMS"
        myClaimsBtn.UseVisualStyleBackColor = True
        ' 
        ' myReportsBtn
        ' 
        myReportsBtn.Location = New Point(20, 155)
        myReportsBtn.Margin = New Padding(2)
        myReportsBtn.Name = "myReportsBtn"
        myReportsBtn.Size = New Size(209, 26)
        myReportsBtn.TabIndex = 13
        myReportsBtn.Text = "MY REPORTS"
        myReportsBtn.UseVisualStyleBackColor = True
        ' 
        ' lostItemBtn
        ' 
        lostItemBtn.Location = New Point(22, 101)
        lostItemBtn.Margin = New Padding(2)
        lostItemBtn.Name = "lostItemBtn"
        lostItemBtn.Size = New Size(214, 26)
        lostItemBtn.TabIndex = 12
        lostItemBtn.Text = "LOST ITEMS"
        lostItemBtn.UseVisualStyleBackColor = True
        ' 
        ' foundItemsBtn
        ' 
        foundItemsBtn.Location = New Point(312, 101)
        foundItemsBtn.Margin = New Padding(2)
        foundItemsBtn.Name = "foundItemsBtn"
        foundItemsBtn.Size = New Size(195, 26)
        foundItemsBtn.TabIndex = 11
        foundItemsBtn.Text = "FOUND ITEMS"
        foundItemsBtn.UseVisualStyleBackColor = True
        ' 
        ' reportFoundItemBtn
        ' 
        reportFoundItemBtn.Location = New Point(312, 47)
        reportFoundItemBtn.Margin = New Padding(2)
        reportFoundItemBtn.Name = "reportFoundItemBtn"
        reportFoundItemBtn.Size = New Size(195, 26)
        reportFoundItemBtn.TabIndex = 10
        reportFoundItemBtn.Text = "REPORT FOUND ITEM"
        reportFoundItemBtn.UseVisualStyleBackColor = True
        ' 
        ' reportlostitembtn
        ' 
        reportlostitembtn.Location = New Point(20, 47)
        reportlostitembtn.Margin = New Padding(2)
        reportlostitembtn.Name = "reportlostitembtn"
        reportlostitembtn.Size = New Size(214, 26)
        reportlostitembtn.TabIndex = 9
        reportlostitembtn.Text = "REPORT LOST ITEM"
        reportlostitembtn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(22, 13)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 16)
        Label1.TabIndex = 8
        Label1.Text = "What are you looking for?"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(640, 312)
        Controls.Add(Panel1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(bckToLogin)
        Margin = New Padding(2)
        Name = "Form3"
        Text = "Form3"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents bckToLogin As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents myClaimsBtn As Button
    Friend WithEvents myReportsBtn As Button
    Friend WithEvents lostItemBtn As Button
    Friend WithEvents foundItemsBtn As Button
    Friend WithEvents reportFoundItemBtn As Button
    Friend WithEvents reportlostitembtn As Button
End Class
