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
        Username_Label = New Label()
        password_label = New Label()
        txtusername = New TextBox()
        txtpassword = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnpassword = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Username_Label
        ' 
        Username_Label.AutoSize = True
        Username_Label.Location = New Point(121, 142)
        Username_Label.Margin = New Padding(2, 0, 2, 0)
        Username_Label.Name = "Username_Label"
        Username_Label.Size = New Size(126, 15)
        Username_Label.TabIndex = 0
        Username_Label.Text = "Student ID/ Username:"
        ' 
        ' password_label
        ' 
        password_label.AutoSize = True
        password_label.Location = New Point(188, 178)
        password_label.Margin = New Padding(2, 0, 2, 0)
        password_label.Name = "password_label"
        password_label.Size = New Size(60, 15)
        password_label.TabIndex = 0
        password_label.Text = "Password:"
        ' 
        ' txtusername
        ' 
        txtusername.Location = New Point(259, 138)
        txtusername.Margin = New Padding(2)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(215, 23)
        txtusername.TabIndex = 2
        ' 
        ' txtpassword
        ' 
        txtpassword.Location = New Point(259, 174)
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
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(165, 64)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(223, 25)
        Label4.TabIndex = 4
        Label4.Text = "Lost And Found login "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(209, 95)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(148, 14)
        Label5.TabIndex = 5
        Label5.Text = "Sign in to access your account"
        ' 
        ' btnpassword
        ' 
        btnpassword.Location = New Point(265, 213)
        btnpassword.Margin = New Padding(2)
        btnpassword.Name = "btnpassword"
        btnpassword.Size = New Size(103, 25)
        btnpassword.TabIndex = 6
        btnpassword.Text = "Login"
        btnpassword.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.Screenshot_2026_09_30_132334
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = My.Resources.Resources.Screenshot_2026_09_30_132334
        PictureBox1.Location = New Point(-3, 0)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(561, 56)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(726, 483)
        Controls.Add(btnpassword)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtpassword)
        Controls.Add(txtusername)
        Controls.Add(PictureBox1)
        Controls.Add(password_label)
        Controls.Add(Username_Label)
        Margin = New Padding(2)
        Name = "LoginForm"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Username_Label As Label
    Friend WithEvents password_label As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnpassword As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
