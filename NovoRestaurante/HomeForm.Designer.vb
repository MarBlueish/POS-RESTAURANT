<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(HomeForm))
        Panel2 = New Panel()
        BtnFechar = New Button()
        GroupBoxPesquisa = New GroupBox()
        lblPesquisar = New Label()
        TextBox1 = New TextBox()
        Panel1 = New Panel()
        Lbl_time = New Label()
        BtnLogout = New Button()
        Lbl_User = New Label()
        Label2 = New Label()
        Lbl_Data = New Label()
        BtnRecuperarSenha = New Button()
        BtnUsuarios = New Button()
        BtnAbout = New Button()
        BtnMesas = New Button()
        BtnProdutoBruto = New Button()
        BtnFornecedor = New Button()
        BtnPratos = New Button()
        BtnStock = New Button()
        BtnPagamento = New Button()
        BtnPedidosDelivery = New Button()
        Label5 = New Label()
        Panel2.SuspendLayout()
        GroupBoxPesquisa.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Maroon
        Panel2.Controls.Add(BtnFechar)
        Panel2.Controls.Add(GroupBoxPesquisa)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(232, 0)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1080, 56)
        Panel2.TabIndex = 32
        ' 
        ' BtnFechar
        ' 
        BtnFechar.BackColor = Color.Transparent
        BtnFechar.BackgroundImage = CType(resources.GetObject("BtnFechar.BackgroundImage"), Image)
        BtnFechar.BackgroundImageLayout = ImageLayout.Stretch
        BtnFechar.FlatAppearance.BorderSize = 0
        BtnFechar.FlatStyle = FlatStyle.Flat
        BtnFechar.Location = New Point(1040, 2)
        BtnFechar.Margin = New Padding(3, 2, 3, 2)
        BtnFechar.Name = "BtnFechar"
        BtnFechar.Size = New Size(38, 28)
        BtnFechar.TabIndex = 7
        BtnFechar.UseVisualStyleBackColor = False
        ' 
        ' GroupBoxPesquisa
        ' 
        GroupBoxPesquisa.Controls.Add(lblPesquisar)
        GroupBoxPesquisa.Controls.Add(TextBox1)
        GroupBoxPesquisa.FlatStyle = FlatStyle.Flat
        GroupBoxPesquisa.Location = New Point(2, 2)
        GroupBoxPesquisa.Margin = New Padding(3, 2, 3, 2)
        GroupBoxPesquisa.Name = "GroupBoxPesquisa"
        GroupBoxPesquisa.Padding = New Padding(3, 2, 3, 2)
        GroupBoxPesquisa.Size = New Size(970, 51)
        GroupBoxPesquisa.TabIndex = 31
        GroupBoxPesquisa.TabStop = False
        ' 
        ' lblPesquisar
        ' 
        lblPesquisar.AutoSize = True
        lblPesquisar.Font = New Font("Century Gothic", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblPesquisar.ForeColor = Color.Snow
        lblPesquisar.Location = New Point(642, 22)
        lblPesquisar.Name = "lblPesquisar"
        lblPesquisar.Size = New Size(84, 21)
        lblPesquisar.TabIndex = 1
        lblPesquisar.Text = "Pesquisar"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(744, 19)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(176, 23)
        TextBox1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Maroon
        Panel1.Controls.Add(Lbl_time)
        Panel1.Controls.Add(BtnLogout)
        Panel1.Controls.Add(Lbl_User)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Lbl_Data)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(232, 600)
        Panel1.TabIndex = 31
        ' 
        ' Lbl_time
        ' 
        Lbl_time.AutoSize = True
        Lbl_time.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Lbl_time.ForeColor = Color.White
        Lbl_time.Location = New Point(107, 577)
        Lbl_time.Name = "Lbl_time"
        Lbl_time.Size = New Size(44, 20)
        Lbl_time.TabIndex = 32
        Lbl_time.Text = "Data"
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
        BtnLogout.Location = New Point(17, 476)
        BtnLogout.Margin = New Padding(3, 2, 3, 2)
        BtnLogout.Name = "BtnLogout"
        BtnLogout.Size = New Size(197, 44)
        BtnLogout.TabIndex = 33
        BtnLogout.Text = "     Logout"
        BtnLogout.UseVisualStyleBackColor = False
        ' 
        ' Lbl_User
        ' 
        Lbl_User.AutoSize = True
        Lbl_User.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Lbl_User.ForeColor = Color.Snow
        Lbl_User.Location = New Point(166, 544)
        Lbl_User.Name = "Lbl_User"
        Lbl_User.Size = New Size(37, 19)
        Lbl_User.TabIndex = 35
        Lbl_User.Text = "User"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.ForeColor = Color.Snow
        Label2.Location = New Point(34, 544)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 19)
        Label2.TabIndex = 34
        Label2.Text = "Seja Bem Vindo(a),"
        ' 
        ' Lbl_Data
        ' 
        Lbl_Data.AutoSize = True
        Lbl_Data.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Lbl_Data.ForeColor = Color.White
        Lbl_Data.Location = New Point(51, 577)
        Lbl_Data.Name = "Lbl_Data"
        Lbl_Data.Size = New Size(54, 20)
        Lbl_Data.TabIndex = 31
        Lbl_Data.Text = "Data:-"
        ' 
        ' BtnRecuperarSenha
        ' 
        BtnRecuperarSenha.BackColor = Color.Maroon
        BtnRecuperarSenha.FlatStyle = FlatStyle.Flat
        BtnRecuperarSenha.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnRecuperarSenha.ForeColor = Color.Snow
        BtnRecuperarSenha.Location = New Point(905, 222)
        BtnRecuperarSenha.Margin = New Padding(3, 2, 3, 2)
        BtnRecuperarSenha.Name = "BtnRecuperarSenha"
        BtnRecuperarSenha.Size = New Size(197, 28)
        BtnRecuperarSenha.TabIndex = 123
        BtnRecuperarSenha.Text = "Recuperar Senha"
        BtnRecuperarSenha.UseVisualStyleBackColor = False
        ' 
        ' BtnUsuarios
        ' 
        BtnUsuarios.BackColor = Color.Maroon
        BtnUsuarios.FlatStyle = FlatStyle.Flat
        BtnUsuarios.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnUsuarios.ForeColor = Color.Snow
        BtnUsuarios.Location = New Point(754, 393)
        BtnUsuarios.Margin = New Padding(3, 2, 3, 2)
        BtnUsuarios.Name = "BtnUsuarios"
        BtnUsuarios.Size = New Size(197, 28)
        BtnUsuarios.TabIndex = 126
        BtnUsuarios.Text = "Usuários"
        BtnUsuarios.UseVisualStyleBackColor = False
        ' 
        ' BtnAbout
        ' 
        BtnAbout.BackColor = Color.Maroon
        BtnAbout.FlatStyle = FlatStyle.Flat
        BtnAbout.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnAbout.ForeColor = Color.Snow
        BtnAbout.Location = New Point(286, 100)
        BtnAbout.Margin = New Padding(3, 2, 3, 2)
        BtnAbout.Name = "BtnAbout"
        BtnAbout.Size = New Size(197, 28)
        BtnAbout.TabIndex = 117
        BtnAbout.Text = "About"
        BtnAbout.UseVisualStyleBackColor = False
        ' 
        ' BtnMesas
        ' 
        BtnMesas.BackColor = Color.Maroon
        BtnMesas.FlatStyle = FlatStyle.Flat
        BtnMesas.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnMesas.ForeColor = Color.Snow
        BtnMesas.Location = New Point(905, 100)
        BtnMesas.Margin = New Padding(3, 2, 3, 2)
        BtnMesas.Name = "BtnMesas"
        BtnMesas.Size = New Size(197, 28)
        BtnMesas.TabIndex = 118
        BtnMesas.Text = "Mesas"
        BtnMesas.UseVisualStyleBackColor = False
        ' 
        ' BtnProdutoBruto
        ' 
        BtnProdutoBruto.BackColor = Color.Maroon
        BtnProdutoBruto.FlatStyle = FlatStyle.Flat
        BtnProdutoBruto.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnProdutoBruto.ForeColor = Color.Snow
        BtnProdutoBruto.Location = New Point(702, 222)
        BtnProdutoBruto.Margin = New Padding(3, 2, 3, 2)
        BtnProdutoBruto.Name = "BtnProdutoBruto"
        BtnProdutoBruto.Size = New Size(197, 28)
        BtnProdutoBruto.TabIndex = 124
        BtnProdutoBruto.Text = "Produto Bruto"
        BtnProdutoBruto.UseVisualStyleBackColor = False
        ' 
        ' BtnFornecedor
        ' 
        BtnFornecedor.BackColor = Color.Maroon
        BtnFornecedor.FlatStyle = FlatStyle.Flat
        BtnFornecedor.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnFornecedor.ForeColor = Color.Snow
        BtnFornecedor.Location = New Point(499, 100)
        BtnFornecedor.Margin = New Padding(3, 2, 3, 2)
        BtnFornecedor.Name = "BtnFornecedor"
        BtnFornecedor.Size = New Size(197, 28)
        BtnFornecedor.TabIndex = 120
        BtnFornecedor.Text = "Fornecedor"
        BtnFornecedor.UseVisualStyleBackColor = False
        ' 
        ' BtnPratos
        ' 
        BtnPratos.BackColor = Color.Maroon
        BtnPratos.FlatStyle = FlatStyle.Flat
        BtnPratos.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnPratos.ForeColor = Color.Snow
        BtnPratos.Location = New Point(702, 100)
        BtnPratos.Margin = New Padding(3, 2, 3, 2)
        BtnPratos.Name = "BtnPratos"
        BtnPratos.Size = New Size(197, 28)
        BtnPratos.TabIndex = 125
        BtnPratos.Text = "Home"
        BtnPratos.UseVisualStyleBackColor = False
        ' 
        ' BtnStock
        ' 
        BtnStock.BackColor = Color.Maroon
        BtnStock.FlatStyle = FlatStyle.Flat
        BtnStock.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnStock.ForeColor = Color.Snow
        BtnStock.Location = New Point(499, 393)
        BtnStock.Margin = New Padding(3, 2, 3, 2)
        BtnStock.Name = "BtnStock"
        BtnStock.Size = New Size(198, 28)
        BtnStock.TabIndex = 121
        BtnStock.Text = "Stock"
        BtnStock.UseVisualStyleBackColor = False
        ' 
        ' BtnPagamento
        ' 
        BtnPagamento.BackColor = Color.Maroon
        BtnPagamento.FlatStyle = FlatStyle.Flat
        BtnPagamento.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnPagamento.ForeColor = Color.Snow
        BtnPagamento.Location = New Point(286, 222)
        BtnPagamento.Margin = New Padding(3, 2, 3, 2)
        BtnPagamento.Name = "BtnPagamento"
        BtnPagamento.Size = New Size(197, 28)
        BtnPagamento.TabIndex = 127
        BtnPagamento.Text = "Pagamento"
        BtnPagamento.UseVisualStyleBackColor = False
        ' 
        ' BtnPedidosDelivery
        ' 
        BtnPedidosDelivery.BackColor = Color.Maroon
        BtnPedidosDelivery.FlatStyle = FlatStyle.Flat
        BtnPedidosDelivery.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnPedidosDelivery.ForeColor = Color.Snow
        BtnPedidosDelivery.Location = New Point(499, 222)
        BtnPedidosDelivery.Margin = New Padding(3, 2, 3, 2)
        BtnPedidosDelivery.Name = "BtnPedidosDelivery"
        BtnPedidosDelivery.Size = New Size(197, 28)
        BtnPedidosDelivery.TabIndex = 119
        BtnPedidosDelivery.Text = "Pedidos Delivery"
        BtnPedidosDelivery.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(1270, 88)
        Label5.Name = "Label5"
        Label5.Size = New Size(18, 23)
        Label5.TabIndex = 111
        Label5.Text = "*"
        Label5.Visible = False
        ' 
        ' HomeForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1312, 600)
        Controls.Add(Label5)
        Controls.Add(BtnRecuperarSenha)
        Controls.Add(BtnUsuarios)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(BtnAbout)
        Controls.Add(BtnFornecedor)
        Controls.Add(BtnStock)
        Controls.Add(BtnMesas)
        Controls.Add(BtnProdutoBruto)
        Controls.Add(BtnPratos)
        Controls.Add(BtnPagamento)
        Controls.Add(BtnPedidosDelivery)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "HomeForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "HomeForm"
        Panel2.ResumeLayout(False)
        GroupBoxPesquisa.ResumeLayout(False)
        GroupBoxPesquisa.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnFechar As Button
    Friend WithEvents GroupBoxPesquisa As GroupBox
    Friend WithEvents lblPesquisar As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lbl_time As Label
    Friend WithEvents BtnLogout As Button
    Friend WithEvents Lbl_User As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Lbl_Data As Label
    Friend WithEvents BtnRecuperarSenha As Button
    Friend WithEvents BtnUsuarios As Button
    Friend WithEvents BtnAbout As Button
    Friend WithEvents BtnMesas As Button
    Friend WithEvents BtnProdutoBruto As Button
    Friend WithEvents BtnFornecedor As Button
    Friend WithEvents BtnPratos As Button
    Friend WithEvents BtnStock As Button
    Friend WithEvents BtnPagamento As Button
    Friend WithEvents BtnPedidosDelivery As Button
    Friend WithEvents Label5 As Label
End Class
