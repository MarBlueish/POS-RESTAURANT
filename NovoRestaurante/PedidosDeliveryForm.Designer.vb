<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidosDeliveryForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(PedidosDeliveryForm))
        Panel2 = New Panel()
        GroupBoxPesquisa = New GroupBox()
        lblPesquisar = New Label()
        TextBoxPesquisa = New TextBox()
        BtnFechar = New Button()
        Panel1 = New Panel()
        BtnLogout = New Button()
        Lbl_time = New Label()
        BtnRecuperarSenha = New Button()
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
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        TextBoxQuantidade = New TextBox()
        Label3 = New Label()
        TextBoxCustoEntrega = New TextBox()
        Label2 = New Label()
        TextBoxPrecoPrato = New TextBox()
        Label1 = New Label()
        TextBoxNomePrato = New TextBox()
        lblContactoDeliv = New Label()
        lblMoradaPdDelivP = New Label()
        lblNomeClientePdDelivP = New Label()
        lblIdPedidoDelivP = New Label()
        DataGridViewPedidos = New DataGridView()
        BtnLimpar = New Button()
        BtnDeletar = New Button()
        BtnEditar = New Button()
        BtnAdicionar = New Button()
        TextBoxIdPedido = New TextBox()
        TextBoxContacto = New TextBox()
        TextBoxMorada = New TextBox()
        TextBoxNomeCliente = New TextBox()
        lblIdPedido = New Label()
        lblContacto = New Label()
        lblMorada = New Label()
        lblNomeCliente = New Label()
        Panel2.SuspendLayout()
        GroupBoxPesquisa.SuspendLayout()
        Panel1.SuspendLayout()
        CType(DataGridViewPedidos, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel2.TabIndex = 32
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
        GroupBoxPesquisa.TabIndex = 32
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
        BtnFechar.TabIndex = 32
        BtnFechar.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Maroon
        Panel1.Controls.Add(BtnLogout)
        Panel1.Controls.Add(Lbl_time)
        Panel1.Controls.Add(BtnRecuperarSenha)
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
        Panel1.TabIndex = 31
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
        BtnLogout.Location = New Point(33, 464)
        BtnLogout.Margin = New Padding(3, 2, 3, 2)
        BtnLogout.Name = "BtnLogout"
        BtnLogout.Size = New Size(197, 44)
        BtnLogout.TabIndex = 128
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
        ' BtnRecuperarSenha
        ' 
        BtnRecuperarSenha.BackColor = Color.Maroon
        BtnRecuperarSenha.FlatStyle = FlatStyle.Flat
        BtnRecuperarSenha.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnRecuperarSenha.ForeColor = Color.Snow
        BtnRecuperarSenha.Location = New Point(33, 309)
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
        BtnUsuarios.Location = New Point(35, 373)
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
        BtnAbout.Location = New Point(33, 68)
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
        BtnMesas.Location = New Point(33, 171)
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
        Lbl_User.Location = New Point(166, 544)
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
        BtnProdutoBruto.Location = New Point(33, 274)
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
        Label5.Location = New Point(34, 544)
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
        BtnFornecedor.Location = New Point(33, 102)
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
        BtnPratos.Location = New Point(33, 136)
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
        BtnStock.Location = New Point(34, 341)
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
        BtnPagamento.Location = New Point(33, 206)
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
        BtnPedidosDelivery.Location = New Point(33, 240)
        BtnPedidosDelivery.Margin = New Padding(3, 2, 3, 2)
        BtnPedidosDelivery.Name = "BtnPedidosDelivery"
        BtnPedidosDelivery.Size = New Size(197, 28)
        BtnPedidosDelivery.TabIndex = 119
        BtnPedidosDelivery.Text = "Pedidos Delivery"
        BtnPedidosDelivery.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(752, 201)
        Label9.Name = "Label9"
        Label9.Size = New Size(108, 19)
        Label9.TabIndex = 115
        Label9.Text = "Quantidade:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(737, 170)
        Label8.Name = "Label8"
        Label8.Size = New Size(118, 19)
        Label8.TabIndex = 114
        Label8.Text = "Custo Entrega:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(306, 205)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 19)
        Label7.TabIndex = 113
        Label7.Text = "Preço Prato:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(303, 174)
        Label6.Name = "Label6"
        Label6.Size = New Size(104, 19)
        Label6.TabIndex = 112
        Label6.Text = "Nome Prato:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(1129, 190)
        Label4.Name = "Label4"
        Label4.Size = New Size(18, 23)
        Label4.TabIndex = 111
        Label4.Text = "*"
        Label4.Visible = False
        ' 
        ' TextBoxQuantidade
        ' 
        TextBoxQuantidade.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxQuantidade.Location = New Point(877, 194)
        TextBoxQuantidade.Margin = New Padding(3, 2, 3, 2)
        TextBoxQuantidade.Name = "TextBoxQuantidade"
        TextBoxQuantidade.Size = New Size(247, 27)
        TextBoxQuantidade.TabIndex = 110
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(1129, 157)
        Label3.Name = "Label3"
        Label3.Size = New Size(18, 23)
        Label3.TabIndex = 109
        Label3.Text = "*"
        Label3.Visible = False
        ' 
        ' TextBoxCustoEntrega
        ' 
        TextBoxCustoEntrega.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxCustoEntrega.Location = New Point(877, 161)
        TextBoxCustoEntrega.Margin = New Padding(3, 2, 3, 2)
        TextBoxCustoEntrega.Name = "TextBoxCustoEntrega"
        TextBoxCustoEntrega.Size = New Size(247, 27)
        TextBoxCustoEntrega.TabIndex = 108
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(676, 198)
        Label2.Name = "Label2"
        Label2.Size = New Size(18, 23)
        Label2.TabIndex = 107
        Label2.Text = "*"
        Label2.Visible = False
        ' 
        ' TextBoxPrecoPrato
        ' 
        TextBoxPrecoPrato.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxPrecoPrato.Location = New Point(424, 202)
        TextBoxPrecoPrato.Margin = New Padding(3, 2, 3, 2)
        TextBoxPrecoPrato.Name = "TextBoxPrecoPrato"
        TextBoxPrecoPrato.Size = New Size(247, 27)
        TextBoxPrecoPrato.TabIndex = 106
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(676, 163)
        Label1.Name = "Label1"
        Label1.Size = New Size(18, 23)
        Label1.TabIndex = 105
        Label1.Text = "*"
        Label1.Visible = False
        ' 
        ' TextBoxNomePrato
        ' 
        TextBoxNomePrato.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxNomePrato.Location = New Point(424, 167)
        TextBoxNomePrato.Margin = New Padding(3, 2, 3, 2)
        TextBoxNomePrato.Name = "TextBoxNomePrato"
        TextBoxNomePrato.Size = New Size(247, 27)
        TextBoxNomePrato.TabIndex = 104
        ' 
        ' lblContactoDeliv
        ' 
        lblContactoDeliv.AutoSize = True
        lblContactoDeliv.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblContactoDeliv.ForeColor = Color.Red
        lblContactoDeliv.Location = New Point(1129, 126)
        lblContactoDeliv.Name = "lblContactoDeliv"
        lblContactoDeliv.Size = New Size(18, 23)
        lblContactoDeliv.TabIndex = 103
        lblContactoDeliv.Text = "*"
        lblContactoDeliv.Visible = False
        ' 
        ' lblMoradaPdDelivP
        ' 
        lblMoradaPdDelivP.AutoSize = True
        lblMoradaPdDelivP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblMoradaPdDelivP.ForeColor = Color.Red
        lblMoradaPdDelivP.Location = New Point(676, 112)
        lblMoradaPdDelivP.Name = "lblMoradaPdDelivP"
        lblMoradaPdDelivP.Size = New Size(18, 23)
        lblMoradaPdDelivP.TabIndex = 102
        lblMoradaPdDelivP.Text = "*"
        lblMoradaPdDelivP.Visible = False
        ' 
        ' lblNomeClientePdDelivP
        ' 
        lblNomeClientePdDelivP.AutoSize = True
        lblNomeClientePdDelivP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblNomeClientePdDelivP.ForeColor = Color.Red
        lblNomeClientePdDelivP.Location = New Point(1129, 85)
        lblNomeClientePdDelivP.Name = "lblNomeClientePdDelivP"
        lblNomeClientePdDelivP.Size = New Size(18, 23)
        lblNomeClientePdDelivP.TabIndex = 101
        lblNomeClientePdDelivP.Text = "*"
        lblNomeClientePdDelivP.Visible = False
        ' 
        ' lblIdPedidoDelivP
        ' 
        lblIdPedidoDelivP.AutoSize = True
        lblIdPedidoDelivP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblIdPedidoDelivP.ForeColor = Color.Red
        lblIdPedidoDelivP.Location = New Point(676, 76)
        lblIdPedidoDelivP.Name = "lblIdPedidoDelivP"
        lblIdPedidoDelivP.Size = New Size(18, 23)
        lblIdPedidoDelivP.TabIndex = 100
        lblIdPedidoDelivP.Text = "*"
        lblIdPedidoDelivP.Visible = False
        ' 
        ' DataGridViewPedidos
        ' 
        DataGridViewPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewPedidos.Location = New Point(313, 358)
        DataGridViewPedidos.Margin = New Padding(3, 2, 3, 2)
        DataGridViewPedidos.Name = "DataGridViewPedidos"
        DataGridViewPedidos.RowHeadersWidth = 51
        DataGridViewPedidos.RowTemplate.Height = 29
        DataGridViewPedidos.Size = New Size(941, 232)
        DataGridViewPedidos.TabIndex = 99
        ' 
        ' BtnLimpar
        ' 
        BtnLimpar.BackColor = Color.Maroon
        BtnLimpar.FlatStyle = FlatStyle.Flat
        BtnLimpar.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnLimpar.ForeColor = Color.Snow
        BtnLimpar.Location = New Point(1047, 315)
        BtnLimpar.Margin = New Padding(3, 2, 3, 2)
        BtnLimpar.Name = "BtnLimpar"
        BtnLimpar.Size = New Size(90, 39)
        BtnLimpar.TabIndex = 98
        BtnLimpar.Text = "Limpar"
        BtnLimpar.UseVisualStyleBackColor = False
        ' 
        ' BtnDeletar
        ' 
        BtnDeletar.BackColor = Color.Maroon
        BtnDeletar.FlatStyle = FlatStyle.Flat
        BtnDeletar.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnDeletar.ForeColor = Color.Snow
        BtnDeletar.Location = New Point(1196, 315)
        BtnDeletar.Margin = New Padding(3, 2, 3, 2)
        BtnDeletar.Name = "BtnDeletar"
        BtnDeletar.Size = New Size(93, 39)
        BtnDeletar.TabIndex = 97
        BtnDeletar.Text = "Deletar"
        BtnDeletar.UseVisualStyleBackColor = False
        ' 
        ' BtnEditar
        ' 
        BtnEditar.BackColor = Color.Maroon
        BtnEditar.FlatStyle = FlatStyle.Flat
        BtnEditar.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnEditar.ForeColor = Color.Snow
        BtnEditar.Location = New Point(944, 315)
        BtnEditar.Margin = New Padding(3, 2, 3, 2)
        BtnEditar.Name = "BtnEditar"
        BtnEditar.Size = New Size(75, 39)
        BtnEditar.TabIndex = 96
        BtnEditar.Text = "Editar"
        BtnEditar.UseVisualStyleBackColor = False
        ' 
        ' BtnAdicionar
        ' 
        BtnAdicionar.BackColor = Color.Maroon
        BtnAdicionar.FlatStyle = FlatStyle.Flat
        BtnAdicionar.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnAdicionar.ForeColor = Color.Snow
        BtnAdicionar.Location = New Point(808, 315)
        BtnAdicionar.Margin = New Padding(3, 2, 3, 2)
        BtnAdicionar.Name = "BtnAdicionar"
        BtnAdicionar.Size = New Size(117, 39)
        BtnAdicionar.TabIndex = 95
        BtnAdicionar.Text = "Adicionar"
        BtnAdicionar.UseVisualStyleBackColor = False
        ' 
        ' TextBoxIdPedido
        ' 
        TextBoxIdPedido.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxIdPedido.Location = New Point(424, 85)
        TextBoxIdPedido.Margin = New Padding(3, 2, 3, 2)
        TextBoxIdPedido.Name = "TextBoxIdPedido"
        TextBoxIdPedido.Size = New Size(247, 27)
        TextBoxIdPedido.TabIndex = 94
        ' 
        ' TextBoxContacto
        ' 
        TextBoxContacto.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxContacto.Location = New Point(877, 130)
        TextBoxContacto.Margin = New Padding(3, 2, 3, 2)
        TextBoxContacto.Name = "TextBoxContacto"
        TextBoxContacto.Size = New Size(247, 27)
        TextBoxContacto.TabIndex = 93
        ' 
        ' TextBoxMorada
        ' 
        TextBoxMorada.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxMorada.Location = New Point(424, 116)
        TextBoxMorada.Margin = New Padding(3, 2, 3, 2)
        TextBoxMorada.Multiline = True
        TextBoxMorada.Name = "TextBoxMorada"
        TextBoxMorada.Size = New Size(247, 44)
        TextBoxMorada.TabIndex = 92
        ' 
        ' TextBoxNomeCliente
        ' 
        TextBoxNomeCliente.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxNomeCliente.Location = New Point(877, 92)
        TextBoxNomeCliente.Margin = New Padding(3, 2, 3, 2)
        TextBoxNomeCliente.Name = "TextBoxNomeCliente"
        TextBoxNomeCliente.Size = New Size(247, 27)
        TextBoxNomeCliente.TabIndex = 91
        ' 
        ' lblIdPedido
        ' 
        lblIdPedido.AutoSize = True
        lblIdPedido.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblIdPedido.Location = New Point(322, 92)
        lblIdPedido.Name = "lblIdPedido"
        lblIdPedido.Size = New Size(87, 19)
        lblIdPedido.TabIndex = 90
        lblIdPedido.Text = "Id Pedido:"
        ' 
        ' lblContacto
        ' 
        lblContacto.AutoSize = True
        lblContacto.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblContacto.Location = New Point(774, 137)
        lblContacto.Name = "lblContacto"
        lblContacto.Size = New Size(84, 19)
        lblContacto.TabIndex = 89
        lblContacto.Text = "Contacto:"
        ' 
        ' lblMorada
        ' 
        lblMorada.AutoSize = True
        lblMorada.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblMorada.Location = New Point(337, 129)
        lblMorada.Name = "lblMorada"
        lblMorada.Size = New Size(75, 19)
        lblMorada.TabIndex = 88
        lblMorada.Text = "Morada:"
        ' 
        ' lblNomeCliente
        ' 
        lblNomeCliente.AutoSize = True
        lblNomeCliente.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblNomeCliente.Location = New Point(708, 98)
        lblNomeCliente.Name = "lblNomeCliente"
        lblNomeCliente.Size = New Size(144, 19)
        lblNomeCliente.TabIndex = 87
        lblNomeCliente.Text = "Nome do Cliente:"
        ' 
        ' PedidosDeliveryForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1312, 600)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(TextBoxQuantidade)
        Controls.Add(Label3)
        Controls.Add(TextBoxCustoEntrega)
        Controls.Add(Label2)
        Controls.Add(TextBoxPrecoPrato)
        Controls.Add(Label1)
        Controls.Add(TextBoxNomePrato)
        Controls.Add(lblContactoDeliv)
        Controls.Add(lblMoradaPdDelivP)
        Controls.Add(lblNomeClientePdDelivP)
        Controls.Add(lblIdPedidoDelivP)
        Controls.Add(DataGridViewPedidos)
        Controls.Add(BtnLimpar)
        Controls.Add(BtnDeletar)
        Controls.Add(BtnEditar)
        Controls.Add(BtnAdicionar)
        Controls.Add(TextBoxIdPedido)
        Controls.Add(TextBoxContacto)
        Controls.Add(TextBoxMorada)
        Controls.Add(TextBoxNomeCliente)
        Controls.Add(lblIdPedido)
        Controls.Add(lblContacto)
        Controls.Add(lblMorada)
        Controls.Add(lblNomeCliente)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "PedidosDeliveryForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PedidosDeliveryForm"
        Panel2.ResumeLayout(False)
        GroupBoxPesquisa.ResumeLayout(False)
        GroupBoxPesquisa.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridViewPedidos, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Lbl_Data As Label
    Friend WithEvents Lbl_User As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxQuantidade As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxCustoEntrega As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxPrecoPrato As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNomePrato As TextBox
    Friend WithEvents lblContactoDeliv As Label
    Friend WithEvents lblMoradaPdDelivP As Label
    Friend WithEvents lblNomeClientePdDelivP As Label
    Friend WithEvents lblIdPedidoDelivP As Label
    Friend WithEvents DataGridViewPedidos As DataGridView
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnDeletar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnAdicionar As Button
    Friend WithEvents TextBoxIdPedido As TextBox
    Friend WithEvents TextBoxContacto As TextBox
    Friend WithEvents TextBoxMorada As TextBox
    Friend WithEvents TextBoxNomeCliente As TextBox
    Friend WithEvents lblIdPedido As Label
    Friend WithEvents lblContacto As Label
    Friend WithEvents lblMorada As Label
    Friend WithEvents lblNomeCliente As Label
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
    Friend WithEvents BtnLogout As Button
End Class
