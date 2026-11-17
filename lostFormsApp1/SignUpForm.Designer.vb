<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUpForm))
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label4 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        Label1 = New Label()
        txtfirstname = New TextBox()
        Username_Label = New Label()
        Label3 = New Label()
        txtlastname = New TextBox()
        Label2 = New Label()
        txtstudentID = New TextBox()
        Label6 = New Label()
        txtemail = New TextBox()
        Label7 = New Label()
        Label11 = New Label()
        txtpassword = New TextBox()
        txtconfirmpassword = New TextBox()
        btnsignup = New Button()
        logInLabel = New Label()
        Label13 = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.InactiveCaptionText
        Label10.Font = New Font("Times New Roman", 8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ButtonHighlight
        Label10.Location = New Point(22, 413)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(154, 14)
        Label10.TabIndex = 22
        Label10.Text = "Everything made Easy with lF..."
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = SystemColors.InfoText
        Label9.Font = New Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ButtonHighlight
        Label9.Location = New Point(22, 374)
        Label9.Name = "Label9"
        Label9.Size = New Size(178, 16)
        Label9.TabIndex = 21
        Label9.Text = "Report Found Items."
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.InactiveCaptionText
        Label8.Font = New Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(22, 348)
        Label8.Name = "Label8"
        Label8.Size = New Size(151, 16)
        Label8.TabIndex = 20
        Label8.Text = "Find Lost Items "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Silver
        Label4.Font = New Font("Papyrus", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(74, 46)
        Label4.Name = "Label4"
        Label4.Size = New Size(142, 30)
        Label4.TabIndex = 19
        Label4.Text = "lost and found"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(22, 42)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(31, 30)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 18
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(279, 474)
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(513, 46)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 30)
        Label5.TabIndex = 23
        Label5.Text = "Sign Up"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(412, 84)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(290, 15)
        Label1.TabIndex = 24
        Label1.Text = "Welcome to Lost and Found!! Enter your details to Sign Up"
        ' 
        ' txtfirstname
        ' 
        txtfirstname.BorderStyle = BorderStyle.FixedSingle
        txtfirstname.Location = New Point(376, 142)
        txtfirstname.Margin = New Padding(2)
        txtfirstname.Name = "txtfirstname"
        txtfirstname.Size = New Size(157, 23)
        txtfirstname.TabIndex = 26
        ' 
        ' Username_Label
        ' 
        Username_Label.AutoSize = True
        Username_Label.Location = New Point(376, 125)
        Username_Label.Margin = New Padding(2, 0, 2, 0)
        Username_Label.Name = "Username_Label"
        Username_Label.Size = New Size(70, 15)
        Username_Label.TabIndex = 25
        Username_Label.Text = "First Name :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(605, 125)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 15)
        Label3.TabIndex = 27
        Label3.Text = "Last Name :"
        ' 
        ' txtlastname
        ' 
        txtlastname.BorderStyle = BorderStyle.FixedSingle
        txtlastname.Location = New Point(605, 142)
        txtlastname.Margin = New Padding(2)
        txtlastname.Name = "txtlastname"
        txtlastname.Size = New Size(157, 23)
        txtlastname.TabIndex = 28
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(376, 199)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 15)
        Label2.TabIndex = 29
        Label2.Text = "Student ID :"
        ' 
        ' txtstudentID
        ' 
        txtstudentID.BorderStyle = BorderStyle.FixedSingle
        txtstudentID.Location = New Point(376, 216)
        txtstudentID.Margin = New Padding(2)
        txtstudentID.Name = "txtstudentID"
        txtstudentID.Size = New Size(157, 23)
        txtstudentID.TabIndex = 30
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(605, 199)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 15)
        Label6.TabIndex = 31
        Label6.Text = "Email :"
        ' 
        ' txtemail
        ' 
        txtemail.BorderStyle = BorderStyle.FixedSingle
        txtemail.Location = New Point(605, 216)
        txtemail.Margin = New Padding(2)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(157, 23)
        txtemail.TabIndex = 32
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(378, 267)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(63, 15)
        Label7.TabIndex = 33
        Label7.Text = "Password :"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(606, 267)
        Label11.Margin = New Padding(2, 0, 2, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(110, 15)
        Label11.TabIndex = 34
        Label11.Text = "Confirm Password :"
        ' 
        ' txtpassword
        ' 
        txtpassword.BorderStyle = BorderStyle.FixedSingle
        txtpassword.Location = New Point(376, 284)
        txtpassword.Margin = New Padding(2)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(157, 23)
        txtpassword.TabIndex = 35
        ' 
        ' txtconfirmpassword
        ' 
        txtconfirmpassword.BorderStyle = BorderStyle.FixedSingle
        txtconfirmpassword.Location = New Point(605, 284)
        txtconfirmpassword.Margin = New Padding(2)
        txtconfirmpassword.Name = "txtconfirmpassword"
        txtconfirmpassword.Size = New Size(157, 23)
        txtconfirmpassword.TabIndex = 36
        ' 
        ' btnsignup
        ' 
        btnsignup.BackColor = SystemColors.InactiveCaptionText
        btnsignup.FlatStyle = FlatStyle.Flat
        btnsignup.ForeColor = SystemColors.ButtonHighlight
        btnsignup.Location = New Point(454, 343)
        btnsignup.Margin = New Padding(2)
        btnsignup.Name = "btnsignup"
        btnsignup.Size = New Size(220, 29)
        btnsignup.TabIndex = 37
        btnsignup.Text = "Sign Up"
        btnsignup.UseVisualStyleBackColor = False
        ' 
        ' logInLabel
        ' 
        logInLabel.AutoSize = True
        logInLabel.Font = New Font("Times New Roman", 8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        logInLabel.ForeColor = Color.MediumBlue
        logInLabel.Location = New Point(503, 386)
        logInLabel.Margin = New Padding(2, 0, 2, 0)
        logInLabel.Name = "logInLabel"
        logInLabel.Size = New Size(38, 14)
        logInLabel.TabIndex = 39
        logInLabel.Text = "Log In"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Times New Roman", 8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(376, 386)
        Label13.Margin = New Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(129, 14)
        Label13.TabIndex = 38
        Label13.Text = "Already have an account?"
        ' 
        ' SignUpForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 472)
        Controls.Add(logInLabel)
        Controls.Add(Label13)
        Controls.Add(btnsignup)
        Controls.Add(txtconfirmpassword)
        Controls.Add(txtpassword)
        Controls.Add(Label11)
        Controls.Add(Label7)
        Controls.Add(txtemail)
        Controls.Add(Label6)
        Controls.Add(txtstudentID)
        Controls.Add(Label2)
        Controls.Add(txtlastname)
        Controls.Add(Label3)
        Controls.Add(txtfirstname)
        Controls.Add(Username_Label)
        Controls.Add(Label1)
        Controls.Add(Label5)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label4)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Name = "SignUpForm"
        Text = "SignUpForm"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents Username_Label As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtstudentID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtconfirmpassword As TextBox
    Friend WithEvents btnsignup As Button
    Friend WithEvents logInLabel As Label
    Friend WithEvents Label13 As Label
End Class
