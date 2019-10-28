<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginFrm
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginFrm))
        Me.PasswordTbox = New MetroFramework.Controls.MetroTextBox()
        Me.UserNameTbox = New MetroFramework.Controls.MetroTextBox()
        Me.PasswordLbl = New MetroFramework.Controls.MetroLabel()
        Me.UserNameLbl = New MetroFramework.Controls.MetroLabel()
        Me.LoginBtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Loading_PB = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Loading_PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PasswordTbox
        '
        Me.PasswordTbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.PasswordTbox.CustomButton.Image = Nothing
        Me.PasswordTbox.CustomButton.Location = New System.Drawing.Point(140, 1)
        Me.PasswordTbox.CustomButton.Name = ""
        Me.PasswordTbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.PasswordTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.PasswordTbox.CustomButton.TabIndex = 1
        Me.PasswordTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PasswordTbox.CustomButton.UseSelectable = True
        Me.PasswordTbox.CustomButton.Visible = False
        Me.PasswordTbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.PasswordTbox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.PasswordTbox.Lines = New String(-1) {}
        Me.PasswordTbox.Location = New System.Drawing.Point(130, 172)
        Me.PasswordTbox.MaxLength = 32767
        Me.PasswordTbox.Name = "PasswordTbox"
        Me.PasswordTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PasswordTbox.SelectedText = ""
        Me.PasswordTbox.SelectionLength = 0
        Me.PasswordTbox.SelectionStart = 0
        Me.PasswordTbox.Size = New System.Drawing.Size(162, 23)
        Me.PasswordTbox.Style = MetroFramework.MetroColorStyle.Silver
        Me.PasswordTbox.TabIndex = 12
        Me.PasswordTbox.UseSelectable = True
        Me.PasswordTbox.WaterMark = "Password"
        Me.PasswordTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PasswordTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'UserNameTbox
        '
        Me.UserNameTbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.UserNameTbox.CustomButton.Image = Nothing
        Me.UserNameTbox.CustomButton.Location = New System.Drawing.Point(140, 1)
        Me.UserNameTbox.CustomButton.Name = ""
        Me.UserNameTbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.UserNameTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.UserNameTbox.CustomButton.TabIndex = 1
        Me.UserNameTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.UserNameTbox.CustomButton.UseSelectable = True
        Me.UserNameTbox.CustomButton.Visible = False
        Me.UserNameTbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.UserNameTbox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.UserNameTbox.Lines = New String(-1) {}
        Me.UserNameTbox.Location = New System.Drawing.Point(130, 140)
        Me.UserNameTbox.MaxLength = 32767
        Me.UserNameTbox.Name = "UserNameTbox"
        Me.UserNameTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserNameTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.UserNameTbox.SelectedText = ""
        Me.UserNameTbox.SelectionLength = 0
        Me.UserNameTbox.SelectionStart = 0
        Me.UserNameTbox.Size = New System.Drawing.Size(162, 23)
        Me.UserNameTbox.Style = MetroFramework.MetroColorStyle.Silver
        Me.UserNameTbox.TabIndex = 11
        Me.UserNameTbox.UseSelectable = True
        Me.UserNameTbox.WaterMark = "User Name"
        Me.UserNameTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UserNameTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PasswordLbl
        '
        Me.PasswordLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PasswordLbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.PasswordLbl.ForeColor = System.Drawing.Color.White
        Me.PasswordLbl.Location = New System.Drawing.Point(23, 172)
        Me.PasswordLbl.Name = "PasswordLbl"
        Me.PasswordLbl.Size = New System.Drawing.Size(99, 25)
        Me.PasswordLbl.Style = MetroFramework.MetroColorStyle.Black
        Me.PasswordLbl.TabIndex = 14
        Me.PasswordLbl.Text = "Password:"
        Me.PasswordLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.PasswordLbl.UseStyleColors = True
        '
        'UserNameLbl
        '
        Me.UserNameLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UserNameLbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.UserNameLbl.ForeColor = System.Drawing.Color.White
        Me.UserNameLbl.Location = New System.Drawing.Point(14, 140)
        Me.UserNameLbl.Name = "UserNameLbl"
        Me.UserNameLbl.Size = New System.Drawing.Size(110, 25)
        Me.UserNameLbl.Style = MetroFramework.MetroColorStyle.Black
        Me.UserNameLbl.TabIndex = 13
        Me.UserNameLbl.Text = "User Name:"
        Me.UserNameLbl.UseStyleColors = True
        '
        'LoginBtn
        '
        Me.LoginBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LoginBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBtn.ForeColor = System.Drawing.Color.Black
        Me.LoginBtn.Image = Nothing
        Me.LoginBtn.Location = New System.Drawing.Point(298, 140)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(73, 55)
        Me.LoginBtn.TabIndex = 17
        Me.LoginBtn.Text = "Login"
        Me.LoginBtn.UseSelectable = True
        Me.LoginBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.warehouseINVENTORY.My.Resources.Resources.K_M_logo_official_2018_1
        Me.PictureBox1.Location = New System.Drawing.Point(23, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(348, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Loading_PB
        '
        Me.Loading_PB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Loading_PB.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Loading_PB.Image = Global.warehouseINVENTORY.My.Resources.Resources.loading_image2
        Me.Loading_PB.Location = New System.Drawing.Point(298, 140)
        Me.Loading_PB.Name = "Loading_PB"
        Me.Loading_PB.Size = New System.Drawing.Size(73, 55)
        Me.Loading_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Loading_PB.TabIndex = 18
        Me.Loading_PB.TabStop = False
        '
        'LoginFrm
        '
        Me.AcceptButton = Me.LoginBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 218)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PasswordTbox)
        Me.Controls.Add(Me.UserNameTbox)
        Me.Controls.Add(Me.PasswordLbl)
        Me.Controls.Add(Me.UserNameLbl)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.Loading_PB)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginFrm"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Silver
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Loading_PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PasswordTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents UserNameTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PasswordLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents UserNameLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LoginBtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents Loading_PB As PictureBox
End Class
