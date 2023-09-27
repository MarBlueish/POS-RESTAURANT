<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm1
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(LoginForm1))
        Button1 = New Button()
        TextBoxPassword = New TextBox()
        TextBoxUser = New TextBox()
        Btn_Login = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        lblRestaurante = New Label()
        BtnFechar = New Button()
        lblEsqueciSenha = New Label()
        PictureBox3 = New PictureBox()
        lblUserP = New Label()
        lblPasswordP = New Label()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Maroon
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(187, 225)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(102, 33)
        Button1.TabIndex = 34
        Button1.Text = "Limpar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.BorderStyle = BorderStyle.None
        TextBoxPassword.Cursor = Cursors.Hand
        TextBoxPassword.Font = New Font("Segoe UI Black", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        TextBoxPassword.Location = New Point(105, 164)
        TextBoxPassword.Margin = New Padding(3, 2, 3, 2)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.Size = New Size(184, 29)
        TextBoxPassword.TabIndex = 33
        TextBoxPassword.UseSystemPasswordChar = True
        ' 
        ' TextBoxUser
        ' 
        TextBoxUser.BackColor = SystemColors.Window
        TextBoxUser.BorderStyle = BorderStyle.None
        TextBoxUser.Cursor = Cursors.Hand
        TextBoxUser.Font = New Font("Segoe UI Black", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        TextBoxUser.Location = New Point(105, 124)
        TextBoxUser.Margin = New Padding(3, 2, 3, 2)
        TextBoxUser.Name = "TextBoxUser"
        TextBoxUser.Size = New Size(184, 29)
        TextBoxUser.TabIndex = 32
        ' 
        ' Btn_Login
        ' 
        Btn_Login.BackColor = Color.Maroon
        Btn_Login.Cursor = Cursors.Hand
        Btn_Login.FlatAppearance.BorderSize = 0
        Btn_Login.FlatStyle = FlatStyle.Flat
        Btn_Login.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Btn_Login.ForeColor = Color.White
        Btn_Login.Location = New Point(18, 225)
        Btn_Login.Margin = New Padding(3, 2, 3, 2)
        Btn_Login.Name = "Btn_Login"
        Btn_Login.Size = New Size(90, 33)
        Btn_Login.TabIndex = 24
        Btn_Login.Text = "Login"
        Btn_Login.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(18, 164)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(69, 34)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(18, 118)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(69, 34)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' lblRestaurante
        ' 
        lblRestaurante.AutoSize = True
        lblRestaurante.BackColor = Color.Transparent
        lblRestaurante.Font = New Font("Century Gothic", 22.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblRestaurante.ForeColor = Color.Red
        lblRestaurante.Location = New Point(519, 110)
        lblRestaurante.Name = "lblRestaurante"
        lblRestaurante.Size = New Size(189, 38)
        lblRestaurante.TabIndex = 25
        lblRestaurante.Text = "Restaurante"
        ' 
        ' BtnFechar
        ' 
        BtnFechar.BackColor = Color.Transparent
        BtnFechar.BackgroundImage = CType(resources.GetObject("BtnFechar.BackgroundImage"), Image)
        BtnFechar.BackgroundImageLayout = ImageLayout.Stretch
        BtnFechar.FlatAppearance.BorderSize = 0
        BtnFechar.FlatStyle = FlatStyle.Flat
        BtnFechar.Location = New Point(950, 0)
        BtnFechar.Margin = New Padding(3, 2, 3, 2)
        BtnFechar.Name = "BtnFechar"
        BtnFechar.Size = New Size(38, 28)
        BtnFechar.TabIndex = 35
        BtnFechar.UseVisualStyleBackColor = False
        ' 
        ' lblEsqueciSenha
        ' 
        lblEsqueciSenha.AutoSize = True
        lblEsqueciSenha.BackColor = Color.Transparent
        lblEsqueciSenha.Cursor = Cursors.Hand
        lblEsqueciSenha.Font = New Font("Arial", 16.2F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point)
        lblEsqueciSenha.ForeColor = Color.DodgerBlue
        lblEsqueciSenha.Location = New Point(18, 283)
        lblEsqueciSenha.Name = "lblEsqueciSenha"
        lblEsqueciSenha.Size = New Size(184, 25)
        lblEsqueciSenha.TabIndex = 36
        lblEsqueciSenha.Text = "Esqueci a Senha"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(768, 61)
        PictureBox3.Margin = New Padding(3, 2, 3, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(192, 80)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 37
        PictureBox3.TabStop = False
        ' 
        ' lblUserP
        ' 
        lblUserP.AutoSize = True
        lblUserP.BackColor = Color.Transparent
        lblUserP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblUserP.ForeColor = Color.Red
        lblUserP.Location = New Point(294, 118)
        lblUserP.Name = "lblUserP"
        lblUserP.Size = New Size(18, 23)
        lblUserP.TabIndex = 70
        lblUserP.Text = "*"
        lblUserP.Visible = False
        ' 
        ' lblPasswordP
        ' 
        lblPasswordP.AutoSize = True
        lblPasswordP.BackColor = Color.Transparent
        lblPasswordP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblPasswordP.ForeColor = Color.Red
        lblPasswordP.Location = New Point(294, 160)
        lblPasswordP.Name = "lblPasswordP"
        lblPasswordP.Size = New Size(18, 23)
        lblPasswordP.TabIndex = 71
        lblPasswordP.Text = "*"
        lblPasswordP.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(lblPasswordP)
        Panel1.Controls.Add(lblUserP)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(lblEsqueciSenha)
        Panel1.Controls.Add(BtnFechar)
        Panel1.Controls.Add(lblRestaurante)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Btn_Login)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(988, 458)
        Panel1.TabIndex = 35
        ' 
        ' LoginForm1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(988, 458)
        Controls.Add(TextBoxUser)
        Controls.Add(TextBoxPassword)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoginForm1"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents TextBoxUser As TextBox
    Friend WithEvents Btn_Login As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblRestaurante As Label
    Friend WithEvents BtnFechar As Button
    Friend WithEvents lblEsqueciSenha As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblUserP As Label
    Friend WithEvents lblPasswordP As Label
    Friend WithEvents Panel1 As Panel
End Class
