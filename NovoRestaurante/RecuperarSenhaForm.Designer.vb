<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecuperarSenhaForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(RecuperarSenhaForm))
        Panel2 = New Panel()
        BtnFechar = New Button()
        Panel1 = New Panel()
        BtnLogout = New Button()
        Lbl_time = New Label()
        Lbl_Data = New Label()
        Lbl_User = New Label()
        Label5 = New Label()
        BtnLogin = New Button()
        Label2 = New Label()
        TextBoxVerificationCode = New TextBox()
        BtnVerificar = New Button()
        lblRepNovaPasseUsuarioRecP = New Label()
        lblNovaPasseUsuarioRecP = New Label()
        BtnLimparDados1 = New Button()
        BtnLimpar2 = New Button()
        lblRepNovPasse = New Label()
        TextBoxRepitaPasse = New TextBox()
        BtnEnviarEmail = New Button()
        lblNovapasse = New Label()
        TextBoxNovaPasse = New TextBox()
        lblEmail = New Label()
        TextBoxEmail = New TextBox()
        BtnReporSenha = New Button()
        TextBoxNomeUsuario = New TextBox()
        lblNomeUsuario = New Label()
        Label1 = New Label()
        lblIdUsuarioRecP = New Label()
        lblEmailUsuarioRecP = New Label()
        Button1 = New Button()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Maroon
        Panel2.Controls.Add(BtnFechar)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(232, 0)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1080, 56)
        Panel2.TabIndex = 36
        ' 
        ' BtnFechar
        ' 
        BtnFechar.BackColor = Color.Transparent
        BtnFechar.BackgroundImage = CType(resources.GetObject("BtnFechar.BackgroundImage"), Image)
        BtnFechar.BackgroundImageLayout = ImageLayout.Stretch
        BtnFechar.FlatAppearance.BorderSize = 0
        BtnFechar.FlatStyle = FlatStyle.Flat
        BtnFechar.Location = New Point(1043, 2)
        BtnFechar.Margin = New Padding(3, 2, 3, 2)
        BtnFechar.Name = "BtnFechar"
        BtnFechar.Size = New Size(38, 28)
        BtnFechar.TabIndex = 33
        BtnFechar.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Maroon
        Panel1.Controls.Add(BtnLogout)
        Panel1.Controls.Add(Lbl_time)
        Panel1.Controls.Add(Lbl_Data)
        Panel1.Controls.Add(Lbl_User)
        Panel1.Controls.Add(Label5)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(232, 600)
        Panel1.TabIndex = 35
        ' 
        ' BtnLogout
        ' 
        BtnLogout.BackColor = Color.Maroon
        BtnLogout.Cursor = Cursors.Hand
        BtnLogout.FlatAppearance.BorderSize = 0
        BtnLogout.FlatStyle = FlatStyle.Flat
        BtnLogout.Font = New Font("Century Gothic", 22.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnLogout.ForeColor = Color.Black
        BtnLogout.Image = CType(resources.GetObject("BtnLogout.Image"), Image)
        BtnLogout.ImageAlign = ContentAlignment.MiddleLeft
        BtnLogout.Location = New Point(18, 464)
        BtnLogout.Margin = New Padding(3, 2, 3, 2)
        BtnLogout.Name = "BtnLogout"
        BtnLogout.Size = New Size(197, 44)
        BtnLogout.TabIndex = 41
        BtnLogout.Text = "     Logout"
        BtnLogout.UseVisualStyleBackColor = False
        ' 
        ' Lbl_time
        ' 
        Lbl_time.AutoSize = True
        Lbl_time.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Lbl_time.ForeColor = Color.White
        Lbl_time.Location = New Point(107, 578)
        Lbl_time.Name = "Lbl_time"
        Lbl_time.Size = New Size(44, 20)
        Lbl_time.TabIndex = 37
        Lbl_time.Text = "Data"
        ' 
        ' Lbl_Data
        ' 
        Lbl_Data.AutoSize = True
        Lbl_Data.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Lbl_Data.ForeColor = Color.White
        Lbl_Data.Location = New Point(51, 578)
        Lbl_Data.Name = "Lbl_Data"
        Lbl_Data.Size = New Size(54, 20)
        Lbl_Data.TabIndex = 36
        Lbl_Data.Text = "Data:-"
        ' 
        ' Lbl_User
        ' 
        Lbl_User.AutoSize = True
        Lbl_User.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Lbl_User.ForeColor = Color.Snow
        Lbl_User.Location = New Point(166, 545)
        Lbl_User.Name = "Lbl_User"
        Lbl_User.Size = New Size(37, 19)
        Lbl_User.TabIndex = 40
        Lbl_User.Text = "User"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label5.ForeColor = Color.Snow
        Label5.Location = New Point(34, 545)
        Label5.Name = "Label5"
        Label5.Size = New Size(129, 19)
        Label5.TabIndex = 39
        Label5.Text = "Seja Bem Vindo(a),"
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = Color.Maroon
        BtnLogin.FlatStyle = FlatStyle.Flat
        BtnLogin.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnLogin.ForeColor = Color.Snow
        BtnLogin.Location = New Point(577, 434)
        BtnLogin.Margin = New Padding(3, 2, 3, 2)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(146, 30)
        BtnLogin.TabIndex = 100
        BtnLogin.Text = "Menu Login"
        BtnLogin.UseVisualStyleBackColor = False
        BtnLogin.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(422, 274)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 19)
        Label2.TabIndex = 99
        Label2.Text = "Validar Codigo"
        Label2.Visible = False
        ' 
        ' TextBoxVerificationCode
        ' 
        TextBoxVerificationCode.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxVerificationCode.Location = New Point(565, 268)
        TextBoxVerificationCode.Margin = New Padding(3, 2, 3, 2)
        TextBoxVerificationCode.Name = "TextBoxVerificationCode"
        TextBoxVerificationCode.Size = New Size(158, 27)
        TextBoxVerificationCode.TabIndex = 97
        TextBoxVerificationCode.Visible = False
        ' 
        ' BtnVerificar
        ' 
        BtnVerificar.BackColor = Color.Maroon
        BtnVerificar.FlatStyle = FlatStyle.Flat
        BtnVerificar.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnVerificar.ForeColor = Color.Snow
        BtnVerificar.Location = New Point(771, 268)
        BtnVerificar.Margin = New Padding(3, 2, 3, 2)
        BtnVerificar.Name = "BtnVerificar"
        BtnVerificar.Size = New Size(138, 30)
        BtnVerificar.TabIndex = 96
        BtnVerificar.Text = "Verificar"
        BtnVerificar.UseVisualStyleBackColor = False
        BtnVerificar.Visible = False
        ' 
        ' lblRepNovaPasseUsuarioRecP
        ' 
        lblRepNovaPasseUsuarioRecP.AutoSize = True
        lblRepNovaPasseUsuarioRecP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblRepNovaPasseUsuarioRecP.ForeColor = Color.Red
        lblRepNovaPasseUsuarioRecP.Location = New Point(812, 335)
        lblRepNovaPasseUsuarioRecP.Name = "lblRepNovaPasseUsuarioRecP"
        lblRepNovaPasseUsuarioRecP.Size = New Size(18, 23)
        lblRepNovaPasseUsuarioRecP.TabIndex = 94
        lblRepNovaPasseUsuarioRecP.Text = "*"
        lblRepNovaPasseUsuarioRecP.Visible = False
        ' 
        ' lblNovaPasseUsuarioRecP
        ' 
        lblNovaPasseUsuarioRecP.AutoSize = True
        lblNovaPasseUsuarioRecP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblNovaPasseUsuarioRecP.ForeColor = Color.Red
        lblNovaPasseUsuarioRecP.Location = New Point(812, 298)
        lblNovaPasseUsuarioRecP.Name = "lblNovaPasseUsuarioRecP"
        lblNovaPasseUsuarioRecP.Size = New Size(18, 23)
        lblNovaPasseUsuarioRecP.TabIndex = 93
        lblNovaPasseUsuarioRecP.Text = "*"
        lblNovaPasseUsuarioRecP.Visible = False
        ' 
        ' BtnLimparDados1
        ' 
        BtnLimparDados1.BackColor = Color.Maroon
        BtnLimparDados1.FlatStyle = FlatStyle.Flat
        BtnLimparDados1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnLimparDados1.ForeColor = Color.Snow
        BtnLimparDados1.Location = New Point(771, 219)
        BtnLimparDados1.Margin = New Padding(3, 2, 3, 2)
        BtnLimparDados1.Name = "BtnLimparDados1"
        BtnLimparDados1.Size = New Size(138, 30)
        BtnLimparDados1.TabIndex = 91
        BtnLimparDados1.Text = "Limpar Dados"
        BtnLimparDados1.UseVisualStyleBackColor = False
        ' 
        ' BtnLimpar2
        ' 
        BtnLimpar2.BackColor = Color.Maroon
        BtnLimpar2.FlatStyle = FlatStyle.Flat
        BtnLimpar2.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnLimpar2.ForeColor = Color.Snow
        BtnLimpar2.Location = New Point(659, 382)
        BtnLimpar2.Margin = New Padding(3, 2, 3, 2)
        BtnLimpar2.Name = "BtnLimpar2"
        BtnLimpar2.Size = New Size(164, 30)
        BtnLimpar2.TabIndex = 90
        BtnLimpar2.Text = "Limpar Dados"
        BtnLimpar2.UseVisualStyleBackColor = False
        BtnLimpar2.Visible = False
        ' 
        ' lblRepNovPasse
        ' 
        lblRepNovPasse.AutoSize = True
        lblRepNovPasse.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblRepNovPasse.Location = New Point(388, 350)
        lblRepNovPasse.Name = "lblRepNovPasse"
        lblRepNovPasse.Size = New Size(154, 19)
        lblRepNovPasse.TabIndex = 89
        lblRepNovPasse.Text = "Repita Nova Passe:"
        lblRepNovPasse.Visible = False
        ' 
        ' TextBoxRepitaPasse
        ' 
        TextBoxRepitaPasse.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxRepitaPasse.Location = New Point(570, 344)
        TextBoxRepitaPasse.Margin = New Padding(3, 2, 3, 2)
        TextBoxRepitaPasse.Name = "TextBoxRepitaPasse"
        TextBoxRepitaPasse.Size = New Size(242, 27)
        TextBoxRepitaPasse.TabIndex = 88
        TextBoxRepitaPasse.Visible = False
        ' 
        ' BtnEnviarEmail
        ' 
        BtnEnviarEmail.BackColor = Color.Maroon
        BtnEnviarEmail.FlatStyle = FlatStyle.Flat
        BtnEnviarEmail.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnEnviarEmail.ForeColor = Color.Snow
        BtnEnviarEmail.Location = New Point(565, 219)
        BtnEnviarEmail.Margin = New Padding(3, 2, 3, 2)
        BtnEnviarEmail.Name = "BtnEnviarEmail"
        BtnEnviarEmail.Size = New Size(138, 30)
        BtnEnviarEmail.TabIndex = 87
        BtnEnviarEmail.Text = "Enviar Email"
        BtnEnviarEmail.UseVisualStyleBackColor = False
        ' 
        ' lblNovapasse
        ' 
        lblNovapasse.AutoSize = True
        lblNovapasse.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblNovapasse.Location = New Point(447, 313)
        lblNovapasse.Name = "lblNovapasse"
        lblNovapasse.Size = New Size(101, 19)
        lblNovapasse.TabIndex = 86
        lblNovapasse.Text = "Nova Passe:"
        lblNovapasse.Visible = False
        ' 
        ' TextBoxNovaPasse
        ' 
        TextBoxNovaPasse.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxNovaPasse.Location = New Point(570, 306)
        TextBoxNovaPasse.Margin = New Padding(3, 2, 3, 2)
        TextBoxNovaPasse.Name = "TextBoxNovaPasse"
        TextBoxNovaPasse.Size = New Size(242, 27)
        TextBoxNovaPasse.TabIndex = 85
        TextBoxNovaPasse.Visible = False
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblEmail.Location = New Point(500, 182)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(56, 19)
        lblEmail.TabIndex = 84
        lblEmail.Text = "Email:"
        ' 
        ' TextBoxEmail
        ' 
        TextBoxEmail.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxEmail.Location = New Point(565, 179)
        TextBoxEmail.Margin = New Padding(3, 2, 3, 2)
        TextBoxEmail.Name = "TextBoxEmail"
        TextBoxEmail.Size = New Size(344, 27)
        TextBoxEmail.TabIndex = 83
        ' 
        ' BtnReporSenha
        ' 
        BtnReporSenha.BackColor = Color.Maroon
        BtnReporSenha.FlatStyle = FlatStyle.Flat
        BtnReporSenha.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnReporSenha.ForeColor = Color.Snow
        BtnReporSenha.Location = New Point(486, 382)
        BtnReporSenha.Margin = New Padding(3, 2, 3, 2)
        BtnReporSenha.Name = "BtnReporSenha"
        BtnReporSenha.Size = New Size(146, 30)
        BtnReporSenha.TabIndex = 82
        BtnReporSenha.Text = "Repor Senha"
        BtnReporSenha.UseVisualStyleBackColor = False
        BtnReporSenha.Visible = False
        ' 
        ' TextBoxNomeUsuario
        ' 
        TextBoxNomeUsuario.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxNomeUsuario.Location = New Point(570, 147)
        TextBoxNomeUsuario.Margin = New Padding(3, 2, 3, 2)
        TextBoxNomeUsuario.Name = "TextBoxNomeUsuario"
        TextBoxNomeUsuario.Size = New Size(242, 27)
        TextBoxNomeUsuario.TabIndex = 81
        ' 
        ' lblNomeUsuario
        ' 
        lblNomeUsuario.AutoSize = True
        lblNomeUsuario.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblNomeUsuario.Location = New Point(434, 149)
        lblNomeUsuario.Name = "lblNomeUsuario"
        lblNomeUsuario.Size = New Size(121, 19)
        lblNomeUsuario.TabIndex = 80
        lblNomeUsuario.Text = "Nome Usuario:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(718, 259)
        Label1.Name = "Label1"
        Label1.Size = New Size(18, 23)
        Label1.TabIndex = 98
        Label1.Text = "*"
        Label1.Visible = False
        ' 
        ' lblIdUsuarioRecP
        ' 
        lblIdUsuarioRecP.AutoSize = True
        lblIdUsuarioRecP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblIdUsuarioRecP.ForeColor = Color.Red
        lblIdUsuarioRecP.Location = New Point(804, 136)
        lblIdUsuarioRecP.Name = "lblIdUsuarioRecP"
        lblIdUsuarioRecP.Size = New Size(18, 23)
        lblIdUsuarioRecP.TabIndex = 92
        lblIdUsuarioRecP.Text = "*"
        lblIdUsuarioRecP.Visible = False
        ' 
        ' lblEmailUsuarioRecP
        ' 
        lblEmailUsuarioRecP.AutoSize = True
        lblEmailUsuarioRecP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblEmailUsuarioRecP.ForeColor = Color.Red
        lblEmailUsuarioRecP.Location = New Point(906, 170)
        lblEmailUsuarioRecP.Name = "lblEmailUsuarioRecP"
        lblEmailUsuarioRecP.Size = New Size(18, 23)
        lblEmailUsuarioRecP.TabIndex = 95
        lblEmailUsuarioRecP.Text = "*"
        lblEmailUsuarioRecP.Visible = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Maroon
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button1.ForeColor = Color.Snow
        Button1.Location = New Point(256, 559)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(138, 30)
        Button1.TabIndex = 88
        Button1.Text = "Voltar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' RecuperarSenhaForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1312, 600)
        Controls.Add(Button1)
        Controls.Add(BtnLogin)
        Controls.Add(Label2)
        Controls.Add(TextBoxVerificationCode)
        Controls.Add(BtnVerificar)
        Controls.Add(lblRepNovaPasseUsuarioRecP)
        Controls.Add(lblNovaPasseUsuarioRecP)
        Controls.Add(BtnLimparDados1)
        Controls.Add(BtnLimpar2)
        Controls.Add(lblRepNovPasse)
        Controls.Add(TextBoxRepitaPasse)
        Controls.Add(BtnEnviarEmail)
        Controls.Add(lblNovapasse)
        Controls.Add(TextBoxNovaPasse)
        Controls.Add(lblEmail)
        Controls.Add(TextBoxEmail)
        Controls.Add(BtnReporSenha)
        Controls.Add(TextBoxNomeUsuario)
        Controls.Add(lblNomeUsuario)
        Controls.Add(Label1)
        Controls.Add(lblIdUsuarioRecP)
        Controls.Add(lblEmailUsuarioRecP)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "RecuperarSenhaForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RecuperarSenhaForm"
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnFechar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lbl_time As Label
    Friend WithEvents Lbl_Data As Label
    Friend WithEvents Lbl_User As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnLogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxVerificationCode As TextBox
    Friend WithEvents BtnVerificar As Button
    Friend WithEvents lblRepNovaPasseUsuarioRecP As Label
    Friend WithEvents lblNovaPasseUsuarioRecP As Label
    Friend WithEvents BtnLimparDados1 As Button
    Friend WithEvents BtnLimpar2 As Button
    Friend WithEvents lblRepNovPasse As Label
    Friend WithEvents TextBoxRepitaPasse As TextBox
    Friend WithEvents BtnEnviarEmail As Button
    Friend WithEvents lblNovapasse As Label
    Friend WithEvents TextBoxNovaPasse As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents BtnReporSenha As Button
    Friend WithEvents TextBoxNomeUsuario As TextBox
    Friend WithEvents lblNomeUsuario As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblIdUsuarioRecP As Label
    Friend WithEvents lblEmailUsuarioRecP As Label
    Friend WithEvents BtnLogout As Button
    Friend WithEvents Button1 As Button
End Class
