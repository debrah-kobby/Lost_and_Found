<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Username_Label = New Label()
        password_label = New Label()
        txtusername = New TextBox()
        txtpassword = New TextBox()
        Label3 = New Label()
        Label5 = New Label()
        btnpassword = New Button()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Username_Label
        ' 
        Username_Label.AutoSize = True
        Username_Label.Location = New Point(407, 128)
        Username_Label.Margin = New Padding(2, 0, 2, 0)
        Username_Label.Name = "Username_Label"
        Username_Label.Size = New Size(68, 15)
        Username_Label.TabIndex = 0
        Username_Label.Text = "Student ID :"
        ' 
        ' password_label
        ' 
        password_label.AutoSize = True
        password_label.Location = New Point(409, 190)
        password_label.Margin = New Padding(2, 0, 2, 0)
        password_label.Name = "password_label"
        password_label.Size = New Size(60, 15)
        password_label.TabIndex = 0
        password_label.Text = "Password:"
        ' 
        ' txtusername
        ' 
        txtusername.BorderStyle = BorderStyle.FixedSingle
        txtusername.Location = New Point(407, 148)
        txtusername.Margin = New Padding(2)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(215, 23)
        txtusername.TabIndex = 2
        ' 
        ' txtpassword
        ' 
        txtpassword.BorderStyle = BorderStyle.FixedSingle
        txtpassword.Location = New Point(409, 211)
        txtpassword.Margin = New Padding(2)
        txtpassword.Name = "txtpassword"
        txtpassword.PasswordChar = "*"c
        txtpassword.Size = New Size(220, 23)
        txtpassword.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(217, 64)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(466, 49)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 30)
        Label5.TabIndex = 5
        Label5.Text = "Sign In"
        ' 
        ' btnpassword
        ' 
        btnpassword.BackColor = SystemColors.InactiveCaptionText
        btnpassword.ForeColor = SystemColors.ButtonHighlight
        btnpassword.Location = New Point(409, 249)
        btnpassword.Margin = New Padding(2)
        btnpassword.Name = "btnpassword"
        btnpassword.Size = New Size(220, 29)
        btnpassword.TabIndex = 6
        btnpassword.Text = "Sign in"
        btnpassword.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(4, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(279, 474)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(424, 91)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(201, 15)
        Label1.TabIndex = 8
        Label1.Text = "Welcome Back!! Eter Your Details Below"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonShadow
        Label2.Location = New Point(535, 191)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 14)
        Label2.TabIndex = 9
        Label2.Text = "forgot password?"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(414, 288)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(116, 14)
        Label6.TabIndex = 10
        Label6.Text = "Dont have an account?"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Times New Roman", 8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.MediumBlue
        Label7.Location = New Point(529, 287)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(45, 14)
        Label7.TabIndex = 11
        Label7.Text = "Sign Up"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(24, 49)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(31, 30)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Silver
        Label4.Font = New Font("Papyrus", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(76, 53)
        Label4.Name = "Label4"
        Label4.Size = New Size(142, 30)
        Label4.TabIndex = 13
        Label4.Text = "lost and found"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.InactiveCaptionText
        Label8.Font = New Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(24, 355)
        Label8.Name = "Label8"
        Label8.Size = New Size(151, 16)
        Label8.TabIndex = 14
        Label8.Text = "Find Lost Items "
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = SystemColors.InfoText
        Label9.Font = New Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ButtonHighlight
        Label9.Location = New Point(24, 381)
        Label9.Name = "Label9"
        Label9.Size = New Size(178, 16)
        Label9.TabIndex = 15
        Label9.Text = "Report Found Items."
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.InactiveCaptionText
        Label10.Font = New Font("Times New Roman", 8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ButtonHighlight
        Label10.Location = New Point(24, 420)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(154, 14)
        Label10.TabIndex = 16
        Label10.Text = "Everything made Easy with lF..."
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Window
        ClientSize = New Size(726, 483)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label4)
        Controls.Add(PictureBox2)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(btnpassword)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(txtpassword)
        Controls.Add(txtusername)
        Controls.Add(password_label)
        Controls.Add(Username_Label)
        Margin = New Padding(2)
        Name = "LoginForm"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Username_Label As Label
    Friend WithEvents password_label As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnpassword As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label

End Class
