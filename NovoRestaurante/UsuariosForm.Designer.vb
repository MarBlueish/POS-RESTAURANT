<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuariosForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(UsuariosForm))
        Panel2 = New Panel()
        GroupBoxPesquisa = New GroupBox()
        lblPesquisar = New Label()
        TextBoxPesquisa = New TextBox()
        BtnFechar = New Button()
        Panel1 = New Panel()
        Lbl_time = New Label()
        BtnRecuperarSenha = New Button()
        Button4 = New Button()
        BtnUsuarios = New Button()
        Lbl_Data = New Label()
        BtnAbout = New Button()
        BtnMesas = New Button()
        Lbl_User = New Label()
        BtnProdutoBruto = New Button()
        Label5 = New Label()
        BtnFornecedor = New Button()
        BtnPratos = New Button()
        BtnStock = New Button()
        BtnPagamento = New Button()
        BtnPedidosDelivery = New Button()
        Label2 = New Label()
        TextBoxIdUsuario = New TextBox()
        TextBoxApelido = New TextBox()
        lblApelido = New Label()
        lblCargoUsuarioP = New Label()
        lblEmailUsuarioP = New Label()
        lblNomeUsuarioP = New Label()
        lblContactoUsuarioP = New Label()
        lblSenhaUsuarioP = New Label()
        DataGridViewUsuario = New DataGridView()
        TextBoxContacto = New TextBox()
        lblContacto = New Label()
        TextBoxEmail = New TextBox()
        lblEmail = New Label()
        BtnLimpar = New Button()
        BtnDeletar = New Button()
        BtnEditar = New Button()
        BtnAdicionar = New Button()
        TextBoxNomeUsuario = New TextBox()
        ComboBoxCargo = New ComboBox()
        TextBoxSenha = New TextBox()
        lblCargo = New Label()
        lblSenha = New Label()
        lblNomeUsuario = New Label()
        Label1 = New Label()
        Panel2.SuspendLayout()
        GroupBoxPesquisa.SuspendLayout()
        Panel1.SuspendLayout()
        CType(DataGridViewUsuario, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Maroon
        Panel2.Controls.Add(GroupBoxPesquisa)
        Panel2.Controls.Add(BtnFechar)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(264, 0)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1048, 56)
        Panel2.TabIndex = 34
        ' 
        ' GroupBoxPesquisa
        ' 
        GroupBoxPesquisa.Controls.Add(lblPesquisar)
        GroupBoxPesquisa.Controls.Add(TextBoxPesquisa)
        GroupBoxPesquisa.FlatStyle = FlatStyle.Flat
        GroupBoxPesquisa.Location = New Point(2, 2)
        GroupBoxPesquisa.Margin = New Padding(3, 2, 3, 2)
        GroupBoxPesquisa.Name = "GroupBoxPesquisa"
        GroupBoxPesquisa.Padding = New Padding(3, 2, 3, 2)
        GroupBoxPesquisa.Size = New Size(970, 51)
        GroupBoxPesquisa.TabIndex = 33
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
        ' TextBoxPesquisa
        ' 
        TextBoxPesquisa.Location = New Point(744, 19)
        TextBoxPesquisa.Margin = New Padding(3, 2, 3, 2)
        TextBoxPesquisa.Name = "TextBoxPesquisa"
        TextBoxPesquisa.Size = New Size(176, 23)
        TextBoxPesquisa.TabIndex = 0
        ' 
        ' BtnFechar
        ' 
        BtnFechar.BackColor = Color.Transparent
        BtnFechar.BackgroundImage = CType(resources.GetObject("BtnFechar.BackgroundImage"), Image)
        BtnFechar.BackgroundImageLayout = ImageLayout.Stretch
        BtnFechar.FlatAppearance.BorderSize = 0
        BtnFechar.FlatStyle = FlatStyle.Flat
        BtnFechar.Location = New Point(1012, -2)
        BtnFechar.Margin = New Padding(3, 2, 3, 2)
        BtnFechar.Name = "BtnFechar"
        BtnFechar.Size = New Size(38, 28)
        BtnFechar.TabIndex = 33
        BtnFechar.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Maroon
        Panel1.Controls.Add(Lbl_time)
        Panel1.Controls.Add(BtnRecuperarSenha)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(BtnUsuarios)
        Panel1.Controls.Add(Lbl_Data)
        Panel1.Controls.Add(BtnAbout)
        Panel1.Controls.Add(BtnMesas)
        Panel1.Controls.Add(Lbl_User)
        Panel1.Controls.Add(BtnProdutoBruto)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(BtnFornecedor)
        Panel1.Controls.Add(BtnPratos)
        Panel1.Controls.Add(BtnStock)
        Panel1.Controls.Add(BtnPagamento)
        Panel1.Controls.Add(BtnPedidosDelivery)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(264, 600)
        Panel1.TabIndex = 33
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
        ' BtnRecuperarSenha
        ' 
        BtnRecuperarSenha.BackColor = Color.Maroon
        BtnRecuperarSenha.FlatStyle = FlatStyle.Flat
        BtnRecuperarSenha.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnRecuperarSenha.ForeColor = Color.Snow
        BtnRecuperarSenha.Location = New Point(33, 320)
        BtnRecuperarSenha.Margin = New Padding(3, 2, 3, 2)
        BtnRecuperarSenha.Name = "BtnRecuperarSenha"
        BtnRecuperarSenha.Size = New Size(197, 28)
        BtnRecuperarSenha.TabIndex = 123
        BtnRecuperarSenha.Text = "Recuperar Senha"
        BtnRecuperarSenha.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Maroon
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Century Gothic", 22.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button4.ForeColor = Color.Black
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(34, 476)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(197, 44)
        Button4.TabIndex = 38
        Button4.Text = "     Logout"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' BtnUsuarios
        ' 
        BtnUsuarios.BackColor = Color.Maroon
        BtnUsuarios.FlatStyle = FlatStyle.Flat
        BtnUsuarios.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnUsuarios.ForeColor = Color.Snow
        BtnUsuarios.Location = New Point(33, 387)
        BtnUsuarios.Margin = New Padding(3, 2, 3, 2)
        BtnUsuarios.Name = "BtnUsuarios"
        BtnUsuarios.Size = New Size(197, 28)
        BtnUsuarios.TabIndex = 126
        BtnUsuarios.Text = "Usuários"
        BtnUsuarios.UseVisualStyleBackColor = False
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
        ' BtnAbout
        ' 
        BtnAbout.BackColor = Color.Maroon
        BtnAbout.FlatStyle = FlatStyle.Flat
        BtnAbout.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnAbout.ForeColor = Color.Snow
        BtnAbout.Location = New Point(33, 78)
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
        BtnMesas.Location = New Point(33, 182)
        BtnMesas.Margin = New Padding(3, 2, 3, 2)
        BtnMesas.Name = "BtnMesas"
        BtnMesas.Size = New Size(197, 28)
        BtnMesas.TabIndex = 118
        BtnMesas.Text = "Mesas"
        BtnMesas.UseVisualStyleBackColor = False
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
        ' BtnProdutoBruto
        ' 
        BtnProdutoBruto.BackColor = Color.Maroon
        BtnProdutoBruto.FlatStyle = FlatStyle.Flat
        BtnProdutoBruto.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnProdutoBruto.ForeColor = Color.Snow
        BtnProdutoBruto.Location = New Point(33, 285)
        BtnProdutoBruto.Margin = New Padding(3, 2, 3, 2)
        BtnProdutoBruto.Name = "BtnProdutoBruto"
        BtnProdutoBruto.Size = New Size(197, 28)
        BtnProdutoBruto.TabIndex = 124
        BtnProdutoBruto.Text = "Produto Bruto"
        BtnProdutoBruto.UseVisualStyleBackColor = False
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
        ' BtnFornecedor
        ' 
        BtnFornecedor.BackColor = Color.Maroon
        BtnFornecedor.FlatStyle = FlatStyle.Flat
        BtnFornecedor.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnFornecedor.ForeColor = Color.Snow
        BtnFornecedor.Location = New Point(33, 112)
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
        BtnPratos.Location = New Point(33, 147)
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
        BtnStock.Location = New Point(34, 355)
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
        BtnPagamento.Location = New Point(33, 216)
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
        BtnPedidosDelivery.Location = New Point(33, 250)
        BtnPedidosDelivery.Margin = New Padding(3, 2, 3, 2)
        BtnPedidosDelivery.Name = "BtnPedidosDelivery"
        BtnPedidosDelivery.Size = New Size(197, 28)
        BtnPedidosDelivery.TabIndex = 119
        BtnPedidosDelivery.Text = "Pedidos Delivery"
        BtnPedidosDelivery.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(289, 193)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 19)
        Label2.TabIndex = 106
        Label2.Text = "Id_Usuario:"
        ' 
        ' TextBoxIdUsuario
        ' 
        TextBoxIdUsuario.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxIdUsuario.Location = New Point(396, 188)
        TextBoxIdUsuario.Margin = New Padding(3, 2, 3, 2)
        TextBoxIdUsuario.Name = "TextBoxIdUsuario"
        TextBoxIdUsuario.Size = New Size(171, 27)
        TextBoxIdUsuario.TabIndex = 105
        ' 
        ' TextBoxApelido
        ' 
        TextBoxApelido.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxApelido.Location = New Point(824, 84)
        TextBoxApelido.Margin = New Padding(3, 2, 3, 2)
        TextBoxApelido.Name = "TextBoxApelido"
        TextBoxApelido.Size = New Size(171, 27)
        TextBoxApelido.TabIndex = 103
        ' 
        ' lblApelido
        ' 
        lblApelido.AutoSize = True
        lblApelido.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblApelido.Location = New Point(726, 90)
        lblApelido.Name = "lblApelido"
        lblApelido.Size = New Size(75, 19)
        lblApelido.TabIndex = 102
        lblApelido.Text = "Apelido:"
        ' 
        ' lblCargoUsuarioP
        ' 
        lblCargoUsuarioP.AutoSize = True
        lblCargoUsuarioP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblCargoUsuarioP.ForeColor = Color.Red
        lblCargoUsuarioP.Location = New Point(507, 129)
        lblCargoUsuarioP.Name = "lblCargoUsuarioP"
        lblCargoUsuarioP.Size = New Size(18, 23)
        lblCargoUsuarioP.TabIndex = 101
        lblCargoUsuarioP.Text = "*"
        lblCargoUsuarioP.Visible = False
        ' 
        ' lblEmailUsuarioP
        ' 
        lblEmailUsuarioP.AutoSize = True
        lblEmailUsuarioP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblEmailUsuarioP.ForeColor = Color.Red
        lblEmailUsuarioP.Location = New Point(949, 128)
        lblEmailUsuarioP.Name = "lblEmailUsuarioP"
        lblEmailUsuarioP.Size = New Size(18, 23)
        lblEmailUsuarioP.TabIndex = 100
        lblEmailUsuarioP.Text = "*"
        lblEmailUsuarioP.Visible = False
        ' 
        ' lblNomeUsuarioP
        ' 
        lblNomeUsuarioP.AutoSize = True
        lblNomeUsuarioP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblNomeUsuarioP.ForeColor = Color.Red
        lblNomeUsuarioP.Location = New Point(693, 83)
        lblNomeUsuarioP.Name = "lblNomeUsuarioP"
        lblNomeUsuarioP.Size = New Size(18, 23)
        lblNomeUsuarioP.TabIndex = 99
        lblNomeUsuarioP.Text = "*"
        lblNomeUsuarioP.Visible = False
        ' 
        ' lblContactoUsuarioP
        ' 
        lblContactoUsuarioP.AutoSize = True
        lblContactoUsuarioP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblContactoUsuarioP.ForeColor = Color.Red
        lblContactoUsuarioP.Location = New Point(1297, 129)
        lblContactoUsuarioP.Name = "lblContactoUsuarioP"
        lblContactoUsuarioP.Size = New Size(18, 23)
        lblContactoUsuarioP.TabIndex = 98
        lblContactoUsuarioP.Text = "*"
        lblContactoUsuarioP.Visible = False
        ' 
        ' lblSenhaUsuarioP
        ' 
        lblSenhaUsuarioP.AutoSize = True
        lblSenhaUsuarioP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblSenhaUsuarioP.ForeColor = Color.Red
        lblSenhaUsuarioP.Location = New Point(1297, 76)
        lblSenhaUsuarioP.Name = "lblSenhaUsuarioP"
        lblSenhaUsuarioP.Size = New Size(18, 23)
        lblSenhaUsuarioP.TabIndex = 97
        lblSenhaUsuarioP.Text = "*"
        lblSenhaUsuarioP.Visible = False
        ' 
        ' DataGridViewUsuario
        ' 
        DataGridViewUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewUsuario.Location = New Point(358, 355)
        DataGridViewUsuario.Margin = New Padding(3, 2, 3, 2)
        DataGridViewUsuario.Name = "DataGridViewUsuario"
        DataGridViewUsuario.RowHeadersWidth = 51
        DataGridViewUsuario.RowTemplate.Height = 29
        DataGridViewUsuario.Size = New Size(849, 222)
        DataGridViewUsuario.TabIndex = 96
        ' 
        ' TextBoxContacto
        ' 
        TextBoxContacto.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxContacto.Location = New Point(1085, 136)
        TextBoxContacto.Margin = New Padding(3, 2, 3, 2)
        TextBoxContacto.Name = "TextBoxContacto"
        TextBoxContacto.Size = New Size(209, 27)
        TextBoxContacto.TabIndex = 95
        ' 
        ' lblContacto
        ' 
        lblContacto.AutoSize = True
        lblContacto.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblContacto.Location = New Point(985, 140)
        lblContacto.Name = "lblContacto"
        lblContacto.Size = New Size(84, 19)
        lblContacto.TabIndex = 94
        lblContacto.Text = "Contacto:"
        ' 
        ' TextBoxEmail
        ' 
        TextBoxEmail.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxEmail.Location = New Point(601, 136)
        TextBoxEmail.Margin = New Padding(3, 2, 3, 2)
        TextBoxEmail.Name = "TextBoxEmail"
        TextBoxEmail.Size = New Size(344, 27)
        TextBoxEmail.TabIndex = 93
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblEmail.Location = New Point(536, 142)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(56, 19)
        lblEmail.TabIndex = 92
        lblEmail.Text = "Email:"
        ' 
        ' BtnLimpar
        ' 
        BtnLimpar.BackColor = Color.Maroon
        BtnLimpar.FlatStyle = FlatStyle.Flat
        BtnLimpar.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnLimpar.ForeColor = Color.Snow
        BtnLimpar.Location = New Point(1064, 285)
        BtnLimpar.Margin = New Padding(3, 2, 3, 2)
        BtnLimpar.Name = "BtnLimpar"
        BtnLimpar.Size = New Size(90, 39)
        BtnLimpar.TabIndex = 91
        BtnLimpar.Text = "Limpar"
        BtnLimpar.UseVisualStyleBackColor = False
        ' 
        ' BtnDeletar
        ' 
        BtnDeletar.BackColor = Color.Maroon
        BtnDeletar.FlatStyle = FlatStyle.Flat
        BtnDeletar.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnDeletar.ForeColor = Color.Snow
        BtnDeletar.Location = New Point(1213, 285)
        BtnDeletar.Margin = New Padding(3, 2, 3, 2)
        BtnDeletar.Name = "BtnDeletar"
        BtnDeletar.Size = New Size(93, 39)
        BtnDeletar.TabIndex = 90
        BtnDeletar.Text = "Deletar"
        BtnDeletar.UseVisualStyleBackColor = False
        ' 
        ' BtnEditar
        ' 
        BtnEditar.BackColor = Color.Maroon
        BtnEditar.FlatStyle = FlatStyle.Flat
        BtnEditar.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnEditar.ForeColor = Color.Snow
        BtnEditar.Location = New Point(961, 285)
        BtnEditar.Margin = New Padding(3, 2, 3, 2)
        BtnEditar.Name = "BtnEditar"
        BtnEditar.Size = New Size(75, 39)
        BtnEditar.TabIndex = 89
        BtnEditar.Text = "Editar"
        BtnEditar.UseVisualStyleBackColor = False
        ' 
        ' BtnAdicionar
        ' 
        BtnAdicionar.BackColor = Color.Maroon
        BtnAdicionar.FlatStyle = FlatStyle.Flat
        BtnAdicionar.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnAdicionar.ForeColor = Color.Snow
        BtnAdicionar.Location = New Point(824, 285)
        BtnAdicionar.Margin = New Padding(3, 2, 3, 2)
        BtnAdicionar.Name = "BtnAdicionar"
        BtnAdicionar.Size = New Size(117, 39)
        BtnAdicionar.TabIndex = 88
        BtnAdicionar.Text = "Adicionar"
        BtnAdicionar.UseVisualStyleBackColor = False
        ' 
        ' TextBoxNomeUsuario
        ' 
        TextBoxNomeUsuario.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxNomeUsuario.Location = New Point(446, 83)
        TextBoxNomeUsuario.Margin = New Padding(3, 2, 3, 2)
        TextBoxNomeUsuario.Name = "TextBoxNomeUsuario"
        TextBoxNomeUsuario.Size = New Size(242, 27)
        TextBoxNomeUsuario.TabIndex = 87
        ' 
        ' ComboBoxCargo
        ' 
        ComboBoxCargo.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBoxCargo.FormattingEnabled = True
        ComboBoxCargo.Location = New Point(358, 140)
        ComboBoxCargo.Margin = New Padding(3, 2, 3, 2)
        ComboBoxCargo.Name = "ComboBoxCargo"
        ComboBoxCargo.Size = New Size(146, 27)
        ComboBoxCargo.TabIndex = 86
        ' 
        ' TextBoxSenha
        ' 
        TextBoxSenha.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxSenha.Location = New Point(1085, 83)
        TextBoxSenha.Margin = New Padding(3, 2, 3, 2)
        TextBoxSenha.Name = "TextBoxSenha"
        TextBoxSenha.Size = New Size(209, 27)
        TextBoxSenha.TabIndex = 85
        ' 
        ' lblCargo
        ' 
        lblCargo.AutoSize = True
        lblCargo.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblCargo.Location = New Point(280, 142)
        lblCargo.Name = "lblCargo"
        lblCargo.Size = New Size(62, 19)
        lblCargo.TabIndex = 84
        lblCargo.Text = "Cargo:"
        ' 
        ' lblSenha
        ' 
        lblSenha.AutoSize = True
        lblSenha.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblSenha.Location = New Point(1013, 90)
        lblSenha.Name = "lblSenha"
        lblSenha.Size = New Size(62, 19)
        lblSenha.TabIndex = 83
        lblSenha.Text = "Senha:"
        ' 
        ' lblNomeUsuario
        ' 
        lblNomeUsuario.AutoSize = True
        lblNomeUsuario.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblNomeUsuario.Location = New Point(280, 90)
        lblNomeUsuario.Name = "lblNomeUsuario"
        lblNomeUsuario.Size = New Size(146, 19)
        lblNomeUsuario.TabIndex = 82
        lblNomeUsuario.Text = "Nome de Usuário:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(1000, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(18, 23)
        Label1.TabIndex = 104
        Label1.Text = "*"
        Label1.Visible = False
        ' 
        ' UsuariosForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1312, 600)
        Controls.Add(Label2)
        Controls.Add(TextBoxIdUsuario)
        Controls.Add(TextBoxApelido)
        Controls.Add(lblApelido)
        Controls.Add(lblCargoUsuarioP)
        Controls.Add(lblEmailUsuarioP)
        Controls.Add(lblNomeUsuarioP)
        Controls.Add(lblContactoUsuarioP)
        Controls.Add(lblSenhaUsuarioP)
        Controls.Add(DataGridViewUsuario)
        Controls.Add(TextBoxContacto)
        Controls.Add(lblContacto)
        Controls.Add(TextBoxEmail)
        Controls.Add(lblEmail)
        Controls.Add(BtnLimpar)
        Controls.Add(BtnDeletar)
        Controls.Add(BtnEditar)
        Controls.Add(BtnAdicionar)
        Controls.Add(TextBoxNomeUsuario)
        Controls.Add(ComboBoxCargo)
        Controls.Add(TextBoxSenha)
        Controls.Add(lblCargo)
        Controls.Add(lblSenha)
        Controls.Add(lblNomeUsuario)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "UsuariosForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UsuariosForm"
        Panel2.ResumeLayout(False)
        GroupBoxPesquisa.ResumeLayout(False)
        GroupBoxPesquisa.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridViewUsuario, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBoxPesquisa As GroupBox
    Friend WithEvents lblPesquisar As Label
    Friend WithEvents TextBoxPesquisa As TextBox
    Friend WithEvents BtnFechar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lbl_time As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Lbl_Data As Label
    Friend WithEvents Lbl_User As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxIdUsuario As TextBox
    Friend WithEvents TextBoxApelido As TextBox
    Friend WithEvents lblApelido As Label
    Friend WithEvents lblCargoUsuarioP As Label
    Friend WithEvents lblEmailUsuarioP As Label
    Friend WithEvents lblNomeUsuarioP As Label
    Friend WithEvents lblContactoUsuarioP As Label
    Friend WithEvents lblSenhaUsuarioP As Label
    Friend WithEvents DataGridViewUsuario As DataGridView
    Friend WithEvents TextBoxContacto As TextBox
    Friend WithEvents lblContacto As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnDeletar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnAdicionar As Button
    Friend WithEvents TextBoxNomeUsuario As TextBox
    Friend WithEvents ComboBoxCargo As ComboBox
    Friend WithEvents TextBoxSenha As TextBox
    Friend WithEvents lblCargo As Label
    Friend WithEvents lblSenha As Label
    Friend WithEvents lblNomeUsuario As Label
    Friend WithEvents Label1 As Label
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
End Class
