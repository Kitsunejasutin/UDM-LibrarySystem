<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogIn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogIn))
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.picUDM = New System.Windows.Forms.PictureBox()
        Me.btnSignup = New System.Windows.Forms.Button()
        Me.btnForgot = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblMar = New System.Windows.Forms.Label()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.llblRead1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbNews1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.picUDM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pbNews1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.Location = New System.Drawing.Point(501, 262)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(362, 27)
        Me.txtUsername.TabIndex = 7
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(501, 310)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(362, 27)
        Me.txtPassword.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(616, 343)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 35)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Log In"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'picUDM
        '
        Me.picUDM.BackColor = System.Drawing.Color.White
        Me.picUDM.Image = CType(resources.GetObject("picUDM.Image"), System.Drawing.Image)
        Me.picUDM.Location = New System.Drawing.Point(616, 124)
        Me.picUDM.Name = "picUDM"
        Me.picUDM.Size = New System.Drawing.Size(120, 116)
        Me.picUDM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUDM.TabIndex = 10
        Me.picUDM.TabStop = False
        '
        'btnSignup
        '
        Me.btnSignup.Location = New System.Drawing.Point(420, 429)
        Me.btnSignup.Name = "btnSignup"
        Me.btnSignup.Size = New System.Drawing.Size(94, 29)
        Me.btnSignup.TabIndex = 13
        Me.btnSignup.Text = "SignUp"
        Me.btnSignup.UseVisualStyleBackColor = True
        '
        'btnForgot
        '
        Me.btnForgot.Location = New System.Drawing.Point(838, 429)
        Me.btnForgot.Name = "btnForgot"
        Me.btnForgot.Size = New System.Drawing.Size(94, 29)
        Me.btnForgot.TabIndex = 14
        Me.btnForgot.Text = "Forgot?"
        Me.btnForgot.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(388, 92)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(573, 396)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.White
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Location = New System.Drawing.Point(420, 265)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(78, 20)
        Me.lblUsername.TabIndex = 16
        Me.lblUsername.Text = "Username:"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.BackColor = System.Drawing.Color.White
        Me.lblPass.Location = New System.Drawing.Point(420, 313)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(73, 20)
        Me.lblPass.TabIndex = 17
        Me.lblPass.Text = "Password:"
        '
        'lblMar
        '
        Me.lblMar.AutoSize = True
        Me.lblMar.BackColor = System.Drawing.Color.Black
        Me.lblMar.Font = New System.Drawing.Font("Sitka Text", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMar.ForeColor = System.Drawing.Color.White
        Me.lblMar.Location = New System.Drawing.Point(115, 611)
        Me.lblMar.Name = "lblMar"
        Me.lblMar.Size = New System.Drawing.Size(0, 68)
        Me.lblMar.TabIndex = 18
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(0, 583)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(1325, 116)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox2.TabIndex = 19
        Me.pictureBox2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.llblRead1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.pbNews1)
        Me.Panel1.Location = New System.Drawing.Point(7, 705)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1318, 344)
        Me.Panel1.TabIndex = 20
        '
        'llblRead1
        '
        Me.llblRead1.AutoSize = True
        Me.llblRead1.Location = New System.Drawing.Point(848, 292)
        Me.llblRead1.Name = "llblRead1"
        Me.llblRead1.Size = New System.Drawing.Size(106, 20)
        Me.llblRead1.TabIndex = 3
        Me.llblRead1.TabStop = True
        Me.llblRead1.Text = "Read More >>"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(617, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(579, 140)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SimSun", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(719, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "V1 is now Online!"
        '
        'pbNews1
        '
        Me.pbNews1.Image = CType(resources.GetObject("pbNews1.Image"), System.Drawing.Image)
        Me.pbNews1.Location = New System.Drawing.Point(62, 79)
        Me.pbNews1.Name = "pbNews1"
        Me.pbNews1.Size = New System.Drawing.Size(392, 199)
        Me.pbNews1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbNews1.TabIndex = 0
        Me.pbNews1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(7, -1)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1318, 578)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1329, 724)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblMar)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnForgot)
        Me.Controls.Add(Me.btnSignup)
        Me.Controls.Add(Me.picUDM)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Name = "LogIn"
        Me.Text = "Main Form"
        CType(Me.picUDM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbNews1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents picUDM As PictureBox
    Friend WithEvents btnSignup As Button
    Friend WithEvents btnForgot As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents lblMar As Label
    Friend WithEvents lbl As PictureBox
    Friend WithEvents pictureBox2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents llblRead1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pbNews1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
