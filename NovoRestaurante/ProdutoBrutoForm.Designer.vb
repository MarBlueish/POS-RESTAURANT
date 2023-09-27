<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProdutoBrutoForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ProdutoBrutoForm))
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
        TextBoxDataValidade = New TextBox()
        Label3 = New Label()
        TextBoxNumSerie = New TextBox()
        lblNumSerie = New Label()
        lblPrecoVendaP = New Label()
        TextBoxPrecoVenda = New TextBox()
        lblPrecoVenda = New Label()
        lblPrecoCompraP = New Label()
        lblProdutoP = New Label()
        lblDataValidadeP = New Label()
        lblIdProdutop = New Label()
        TextBoxIdProduto = New TextBox()
        lblIdProduto = New Label()
        DataGridViewProdutosBrutos = New DataGridView()
        BtnLimpar = New Button()
        BtnDeletar = New Button()
        BtnEditar = New Button()
        BtnAdicionar = New Button()
        TextBoxPrecoCompra = New TextBox()
        TextBoxProduto = New TextBox()
        lblPrecoCompra = New Label()
        lblDataValidade = New Label()
        lblProduto = New Label()
        Panel2.SuspendLayout()
        GroupBoxPesquisa.SuspendLayout()
        Panel1.SuspendLayout()
        CType(DataGridViewProdutosBrutos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Maroon
        Panel2.Controls.Add(GroupBoxPesquisa)
        Panel2.Controls.Add(BtnFechar)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(232, 0)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1080, 56)
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
        GroupBoxPesquisa.TabIndex = 43
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
        BtnFechar.Location = New Point(1040, 2)
        BtnFechar.Margin = New Padding(3, 2, 3, 2)
        BtnFechar.Name = "BtnFechar"
        BtnFechar.Size = New Size(38, 28)
        BtnFechar.TabIndex = 48
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
        Panel1.Size = New Size(232, 600)
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
        BtnLogout.Location = New Point(17, 466)
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
        Lbl_time.TabIndex = 44
        Lbl_time.Text = "Data"
        ' 
        ' BtnRecuperarSenha
        ' 
        BtnRecuperarSenha.BackColor = Color.Maroon
        BtnRecuperarSenha.FlatStyle = FlatStyle.Flat
        BtnRecuperarSenha.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnRecuperarSenha.ForeColor = Color.Snow
        BtnRecuperarSenha.Location = New Point(17, 312)
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
        BtnUsuarios.Location = New Point(18, 376)
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
        Lbl_Data.TabIndex = 43
        Lbl_Data.Text = "Data:-"
        ' 
        ' BtnAbout
        ' 
        BtnAbout.BackColor = Color.Maroon
        BtnAbout.FlatStyle = FlatStyle.Flat
        BtnAbout.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnAbout.ForeColor = Color.Snow
        BtnAbout.Location = New Point(17, 70)
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
        BtnMesas.Location = New Point(17, 174)
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
        Lbl_User.TabIndex = 47
        Lbl_User.Text = "User"
        ' 
        ' BtnProdutoBruto
        ' 
        BtnProdutoBruto.BackColor = Color.Maroon
        BtnProdutoBruto.FlatStyle = FlatStyle.Flat
        BtnProdutoBruto.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnProdutoBruto.ForeColor = Color.Snow
        BtnProdutoBruto.Location = New Point(17, 278)
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
        Label5.TabIndex = 46
        Label5.Text = "Seja Bem Vindo(a),"
        ' 
        ' BtnFornecedor
        ' 
        BtnFornecedor.BackColor = Color.Maroon
        BtnFornecedor.FlatStyle = FlatStyle.Flat
        BtnFornecedor.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnFornecedor.ForeColor = Color.Snow
        BtnFornecedor.Location = New Point(17, 105)
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
        BtnPratos.Location = New Point(17, 140)
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
        BtnStock.Location = New Point(17, 344)
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
        BtnPagamento.Location = New Point(17, 208)
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
        BtnPedidosDelivery.Location = New Point(17, 243)
        BtnPedidosDelivery.Margin = New Padding(3, 2, 3, 2)
        BtnPedidosDelivery.Name = "BtnPedidosDelivery"
        BtnPedidosDelivery.Size = New Size(197, 28)
        BtnPedidosDelivery.TabIndex = 119
        BtnPedidosDelivery.Text = "Pedidos Delivery"
        BtnPedidosDelivery.UseVisualStyleBackColor = False
        ' 
        ' TextBoxDataValidade
        ' 
        TextBoxDataValidade.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxDataValidade.Location = New Point(430, 153)
        TextBoxDataValidade.Margin = New Padding(3, 2, 3, 2)
        TextBoxDataValidade.Name = "TextBoxDataValidade"
        TextBoxDataValidade.Size = New Size(133, 27)
        TextBoxDataValidade.TabIndex = 104
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(568, 189)
        Label3.Name = "Label3"
        Label3.Size = New Size(18, 23)
        Label3.TabIndex = 103
        Label3.Text = "*"
        Label3.Visible = False
        ' 
        ' TextBoxNumSerie
        ' 
        TextBoxNumSerie.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxNumSerie.Location = New Point(430, 196)
        TextBoxNumSerie.Margin = New Padding(3, 2, 3, 2)
        TextBoxNumSerie.Name = "TextBoxNumSerie"
        TextBoxNumSerie.Size = New Size(133, 27)
        TextBoxNumSerie.TabIndex = 102
        ' 
        ' lblNumSerie
        ' 
        lblNumSerie.AutoSize = True
        lblNumSerie.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblNumSerie.Location = New Point(305, 196)
        lblNumSerie.Name = "lblNumSerie"
        lblNumSerie.Size = New Size(96, 19)
        lblNumSerie.TabIndex = 101
        lblNumSerie.Text = "Num. Série:"
        ' 
        ' lblPrecoVendaP
        ' 
        lblPrecoVendaP.AutoSize = True
        lblPrecoVendaP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblPrecoVendaP.ForeColor = Color.Red
        lblPrecoVendaP.Location = New Point(568, 274)
        lblPrecoVendaP.Name = "lblPrecoVendaP"
        lblPrecoVendaP.Size = New Size(18, 23)
        lblPrecoVendaP.TabIndex = 100
        lblPrecoVendaP.Text = "*"
        lblPrecoVendaP.Visible = False
        ' 
        ' TextBoxPrecoVenda
        ' 
        TextBoxPrecoVenda.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxPrecoVenda.Location = New Point(430, 281)
        TextBoxPrecoVenda.Margin = New Padding(3, 2, 3, 2)
        TextBoxPrecoVenda.Name = "TextBoxPrecoVenda"
        TextBoxPrecoVenda.Size = New Size(133, 27)
        TextBoxPrecoVenda.TabIndex = 99
        ' 
        ' lblPrecoVenda
        ' 
        lblPrecoVenda.AutoSize = True
        lblPrecoVenda.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblPrecoVenda.Location = New Point(286, 281)
        lblPrecoVenda.Name = "lblPrecoVenda"
        lblPrecoVenda.Size = New Size(114, 19)
        lblPrecoVenda.TabIndex = 98
        lblPrecoVenda.Text = "Preço Venda:"
        ' 
        ' lblPrecoCompraP
        ' 
        lblPrecoCompraP.AutoSize = True
        lblPrecoCompraP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblPrecoCompraP.ForeColor = Color.Red
        lblPrecoCompraP.Location = New Point(568, 236)
        lblPrecoCompraP.Name = "lblPrecoCompraP"
        lblPrecoCompraP.Size = New Size(18, 23)
        lblPrecoCompraP.TabIndex = 97
        lblPrecoCompraP.Text = "*"
        lblPrecoCompraP.Visible = False
        ' 
        ' lblProdutoP
        ' 
        lblProdutoP.AutoSize = True
        lblProdutoP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblProdutoP.ForeColor = Color.Red
        lblProdutoP.Location = New Point(1107, 93)
        lblProdutoP.Name = "lblProdutoP"
        lblProdutoP.Size = New Size(18, 23)
        lblProdutoP.TabIndex = 96
        lblProdutoP.Text = "*"
        lblProdutoP.Visible = False
        ' 
        ' lblDataValidadeP
        ' 
        lblDataValidadeP.AutoSize = True
        lblDataValidadeP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblDataValidadeP.ForeColor = Color.Red
        lblDataValidadeP.Location = New Point(568, 148)
        lblDataValidadeP.Name = "lblDataValidadeP"
        lblDataValidadeP.Size = New Size(18, 23)
        lblDataValidadeP.TabIndex = 95
        lblDataValidadeP.Text = "*"
        lblDataValidadeP.Visible = False
        ' 
        ' lblIdProdutop
        ' 
        lblIdProdutop.AutoSize = True
        lblIdProdutop.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblIdProdutop.ForeColor = Color.Red
        lblIdProdutop.Location = New Point(568, 102)
        lblIdProdutop.Name = "lblIdProdutop"
        lblIdProdutop.Size = New Size(18, 23)
        lblIdProdutop.TabIndex = 94
        lblIdProdutop.Text = "*"
        lblIdProdutop.Visible = False
        ' 
        ' TextBoxIdProduto
        ' 
        TextBoxIdProduto.Enabled = False
        TextBoxIdProduto.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxIdProduto.Location = New Point(430, 104)
        TextBoxIdProduto.Margin = New Padding(3, 2, 3, 2)
        TextBoxIdProduto.Name = "TextBoxIdProduto"
        TextBoxIdProduto.Size = New Size(133, 27)
        TextBoxIdProduto.TabIndex = 93
        ' 
        ' lblIdProduto
        ' 
        lblIdProduto.AutoSize = True
        lblIdProduto.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblIdProduto.Location = New Point(311, 104)
        lblIdProduto.Name = "lblIdProduto"
        lblIdProduto.Size = New Size(91, 19)
        lblIdProduto.TabIndex = 92
        lblIdProduto.Text = "Id Produto:"
        ' 
        ' DataGridViewProdutosBrutos
        ' 
        DataGridViewProdutosBrutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewProdutosBrutos.Location = New Point(311, 367)
        DataGridViewProdutosBrutos.Margin = New Padding(3, 2, 3, 2)
        DataGridViewProdutosBrutos.Name = "DataGridViewProdutosBrutos"
        DataGridViewProdutosBrutos.RowHeadersWidth = 51
        DataGridViewProdutosBrutos.RowTemplate.Height = 29
        DataGridViewProdutosBrutos.Size = New Size(937, 218)
        DataGridViewProdutosBrutos.TabIndex = 91
        ' 
        ' BtnLimpar
        ' 
        BtnLimpar.BackColor = Color.Maroon
        BtnLimpar.FlatStyle = FlatStyle.Flat
        BtnLimpar.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnLimpar.ForeColor = Color.Snow
        BtnLimpar.Location = New Point(1000, 198)
        BtnLimpar.Margin = New Padding(3, 2, 3, 2)
        BtnLimpar.Name = "BtnLimpar"
        BtnLimpar.Size = New Size(90, 39)
        BtnLimpar.TabIndex = 90
        BtnLimpar.Text = "Limpar"
        BtnLimpar.UseVisualStyleBackColor = False
        ' 
        ' BtnDeletar
        ' 
        BtnDeletar.BackColor = Color.Maroon
        BtnDeletar.FlatStyle = FlatStyle.Flat
        BtnDeletar.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnDeletar.ForeColor = Color.Snow
        BtnDeletar.Location = New Point(1149, 198)
        BtnDeletar.Margin = New Padding(3, 2, 3, 2)
        BtnDeletar.Name = "BtnDeletar"
        BtnDeletar.Size = New Size(93, 39)
        BtnDeletar.TabIndex = 89
        BtnDeletar.Text = "Deletar"
        BtnDeletar.UseVisualStyleBackColor = False
        ' 
        ' BtnEditar
        ' 
        BtnEditar.BackColor = Color.Maroon
        BtnEditar.FlatStyle = FlatStyle.Flat
        BtnEditar.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnEditar.ForeColor = Color.Snow
        BtnEditar.Location = New Point(897, 198)
        BtnEditar.Margin = New Padding(3, 2, 3, 2)
        BtnEditar.Name = "BtnEditar"
        BtnEditar.Size = New Size(75, 39)
        BtnEditar.TabIndex = 88
        BtnEditar.Text = "Editar"
        BtnEditar.UseVisualStyleBackColor = False
        ' 
        ' BtnAdicionar
        ' 
        BtnAdicionar.BackColor = Color.Maroon
        BtnAdicionar.FlatStyle = FlatStyle.Flat
        BtnAdicionar.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnAdicionar.ForeColor = Color.Snow
        BtnAdicionar.Location = New Point(760, 198)
        BtnAdicionar.Margin = New Padding(3, 2, 3, 2)
        BtnAdicionar.Name = "BtnAdicionar"
        BtnAdicionar.Size = New Size(117, 39)
        BtnAdicionar.TabIndex = 87
        BtnAdicionar.Text = "Adicionar"
        BtnAdicionar.UseVisualStyleBackColor = False
        ' 
        ' TextBoxPrecoCompra
        ' 
        TextBoxPrecoCompra.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxPrecoCompra.Location = New Point(430, 242)
        TextBoxPrecoCompra.Margin = New Padding(3, 2, 3, 2)
        TextBoxPrecoCompra.Name = "TextBoxPrecoCompra"
        TextBoxPrecoCompra.Size = New Size(133, 27)
        TextBoxPrecoCompra.TabIndex = 86
        ' 
        ' TextBoxProduto
        ' 
        TextBoxProduto.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxProduto.Location = New Point(725, 98)
        TextBoxProduto.Margin = New Padding(3, 2, 3, 2)
        TextBoxProduto.Name = "TextBoxProduto"
        TextBoxProduto.Size = New Size(377, 27)
        TextBoxProduto.TabIndex = 85
        ' 
        ' lblPrecoCompra
        ' 
        lblPrecoCompra.AutoSize = True
        lblPrecoCompra.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblPrecoCompra.Location = New Point(273, 242)
        lblPrecoCompra.Name = "lblPrecoCompra"
        lblPrecoCompra.Size = New Size(126, 19)
        lblPrecoCompra.TabIndex = 84
        lblPrecoCompra.Text = "Preço Compra:"
        ' 
        ' lblDataValidade
        ' 
        lblDataValidade.AutoSize = True
        lblDataValidade.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblDataValidade.Location = New Point(274, 160)
        lblDataValidade.Name = "lblDataValidade"
        lblDataValidade.Size = New Size(127, 19)
        lblDataValidade.TabIndex = 83
        lblDataValidade.Text = "Data Validade:"
        ' 
        ' lblProduto
        ' 
        lblProduto.AutoSize = True
        lblProduto.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblProduto.Location = New Point(646, 104)
        lblProduto.Name = "lblProduto"
        lblProduto.Size = New Size(72, 19)
        lblProduto.TabIndex = 82
        lblProduto.Text = "Produto:"
        ' 
        ' ProdutoBrutoForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1312, 600)
        Controls.Add(TextBoxDataValidade)
        Controls.Add(Label3)
        Controls.Add(TextBoxNumSerie)
        Controls.Add(lblNumSerie)
        Controls.Add(lblPrecoVendaP)
        Controls.Add(TextBoxPrecoVenda)
        Controls.Add(lblPrecoVenda)
        Controls.Add(lblPrecoCompraP)
        Controls.Add(lblProdutoP)
        Controls.Add(lblDataValidadeP)
        Controls.Add(lblIdProdutop)
        Controls.Add(TextBoxIdProduto)
        Controls.Add(lblIdProduto)
        Controls.Add(DataGridViewProdutosBrutos)
        Controls.Add(BtnLimpar)
        Controls.Add(BtnDeletar)
        Controls.Add(BtnEditar)
        Controls.Add(BtnAdicionar)
        Controls.Add(TextBoxPrecoCompra)
        Controls.Add(TextBoxProduto)
        Controls.Add(lblPrecoCompra)
        Controls.Add(lblDataValidade)
        Controls.Add(lblProduto)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "ProdutoBrutoForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ProdutoBrutoForm"
        Panel2.ResumeLayout(False)
        GroupBoxPesquisa.ResumeLayout(False)
        GroupBoxPesquisa.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridViewProdutosBrutos, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TextBoxDataValidade As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxNumSerie As TextBox
    Friend WithEvents lblNumSerie As Label
    Friend WithEvents lblPrecoVendaP As Label
    Friend WithEvents TextBoxPrecoVenda As TextBox
    Friend WithEvents lblPrecoVenda As Label
    Friend WithEvents lblPrecoCompraP As Label
    Friend WithEvents lblProdutoP As Label
    Friend WithEvents lblDataValidadeP As Label
    Friend WithEvents lblIdProdutop As Label
    Friend WithEvents TextBoxIdProduto As TextBox
    Friend WithEvents lblIdProduto As Label
    Friend WithEvents DataGridViewProdutosBrutos As DataGridView
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnDeletar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnAdicionar As Button
    Friend WithEvents TextBoxPrecoCompra As TextBox
    Friend WithEvents TextBoxProduto As TextBox
    Friend WithEvents lblPrecoCompra As Label
    Friend WithEvents lblDataValidade As Label
    Friend WithEvents lblProduto As Label
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
