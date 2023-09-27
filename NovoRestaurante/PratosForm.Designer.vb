<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PratosForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(PratosForm))
        Panel2 = New Panel()
        GroupBoxPesquisa = New GroupBox()
        lblPesquisar = New Label()
        TextBoxPesquisa = New TextBox()
        BtnFechar = New Button()
        Panel1 = New Panel()
        BtnLogout = New Button()
        BtnRecuperarSenha = New Button()
        BtnUsuarios = New Button()
        Lbl_time = New Label()
        BtnAboutMe = New Button()
        BtnMesas = New Button()
        BtnProdutoBruto = New Button()
        Lbl_Data = New Label()
        BtnFornecedor = New Button()
        BtnStock = New Button()
        Lbl_User = New Label()
        BtnPedidosDelivery = New Button()
        Label5 = New Label()
        BtnPagamento = New Button()
        BtnPratos = New Button()
        lblPrecoPratoNormalP = New Label()
        lblTipoPratoP = New Label()
        lblIdPratoNormalP = New Label()
        BtnImprimir = New Button()
        BtnFormatar = New Button()
        ComboBoxPrato = New ComboBox()
        DataGridViewPratos = New DataGridView()
        TextBoxIdPrato = New TextBox()
        lblIdPrato = New Label()
        BtnLimpar = New Button()
        BtnDeletar = New Button()
        BtnEditar = New Button()
        BtnAdicionar = New Button()
        TextBoxPreco = New TextBox()
        TextBoxDescricao = New TextBox()
        lblPreco = New Label()
        lblDescricao = New Label()
        lblPrato = New Label()
        TextBoxValorVenda = New TextBox()
        Label4 = New Label()
        Label1 = New Label()
        TextBoxValorProducao = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Panel2.SuspendLayout()
        GroupBoxPesquisa.SuspendLayout()
        Panel1.SuspendLayout()
        CType(DataGridViewPratos, ComponentModel.ISupportInitialize).BeginInit()
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
        BtnFechar.Location = New Point(1042, 0)
        BtnFechar.Margin = New Padding(3, 2, 3, 2)
        BtnFechar.Name = "BtnFechar"
        BtnFechar.Size = New Size(38, 28)
        BtnFechar.TabIndex = 31
        BtnFechar.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Maroon
        Panel1.Controls.Add(BtnLogout)
        Panel1.Controls.Add(BtnRecuperarSenha)
        Panel1.Controls.Add(BtnUsuarios)
        Panel1.Controls.Add(Lbl_time)
        Panel1.Controls.Add(BtnAboutMe)
        Panel1.Controls.Add(BtnMesas)
        Panel1.Controls.Add(BtnProdutoBruto)
        Panel1.Controls.Add(Lbl_Data)
        Panel1.Controls.Add(BtnFornecedor)
        Panel1.Controls.Add(BtnStock)
        Panel1.Controls.Add(Lbl_User)
        Panel1.Controls.Add(BtnPedidosDelivery)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(BtnPagamento)
        Panel1.Controls.Add(BtnPratos)
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
        BtnLogout.Location = New Point(17, 482)
        BtnLogout.Margin = New Padding(3, 2, 3, 2)
        BtnLogout.Name = "BtnLogout"
        BtnLogout.Size = New Size(197, 44)
        BtnLogout.TabIndex = 117
        BtnLogout.Text = "     Logout"
        BtnLogout.UseVisualStyleBackColor = False
        ' 
        ' BtnRecuperarSenha
        ' 
        BtnRecuperarSenha.BackColor = Color.Maroon
        BtnRecuperarSenha.FlatStyle = FlatStyle.Flat
        BtnRecuperarSenha.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnRecuperarSenha.ForeColor = Color.Snow
        BtnRecuperarSenha.Location = New Point(17, 328)
        BtnRecuperarSenha.Margin = New Padding(3, 2, 3, 2)
        BtnRecuperarSenha.Name = "BtnRecuperarSenha"
        BtnRecuperarSenha.Size = New Size(197, 28)
        BtnRecuperarSenha.TabIndex = 113
        BtnRecuperarSenha.Text = "Recuperar Senha"
        BtnRecuperarSenha.UseVisualStyleBackColor = False
        ' 
        ' BtnUsuarios
        ' 
        BtnUsuarios.BackColor = Color.Maroon
        BtnUsuarios.FlatStyle = FlatStyle.Flat
        BtnUsuarios.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnUsuarios.ForeColor = Color.Snow
        BtnUsuarios.Location = New Point(18, 392)
        BtnUsuarios.Margin = New Padding(3, 2, 3, 2)
        BtnUsuarios.Name = "BtnUsuarios"
        BtnUsuarios.Size = New Size(197, 28)
        BtnUsuarios.TabIndex = 115
        BtnUsuarios.Text = "Usuários"
        BtnUsuarios.UseVisualStyleBackColor = False
        ' 
        ' Lbl_time
        ' 
        Lbl_time.AutoSize = True
        Lbl_time.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Lbl_time.ForeColor = Color.White
        Lbl_time.Location = New Point(107, 577)
        Lbl_time.Name = "Lbl_time"
        Lbl_time.Size = New Size(44, 20)
        Lbl_time.TabIndex = 37
        Lbl_time.Text = "Data"
        ' 
        ' BtnAboutMe
        ' 
        BtnAboutMe.BackColor = Color.Maroon
        BtnAboutMe.FlatStyle = FlatStyle.Flat
        BtnAboutMe.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnAboutMe.ForeColor = Color.Snow
        BtnAboutMe.Location = New Point(17, 87)
        BtnAboutMe.Margin = New Padding(3, 2, 3, 2)
        BtnAboutMe.Name = "BtnAboutMe"
        BtnAboutMe.Size = New Size(197, 28)
        BtnAboutMe.TabIndex = 108
        BtnAboutMe.Text = "About"
        BtnAboutMe.UseVisualStyleBackColor = False
        ' 
        ' BtnMesas
        ' 
        BtnMesas.BackColor = Color.Maroon
        BtnMesas.FlatStyle = FlatStyle.Flat
        BtnMesas.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnMesas.ForeColor = Color.Snow
        BtnMesas.Location = New Point(17, 190)
        BtnMesas.Margin = New Padding(3, 2, 3, 2)
        BtnMesas.Name = "BtnMesas"
        BtnMesas.Size = New Size(197, 28)
        BtnMesas.TabIndex = 109
        BtnMesas.Text = "Mesas"
        BtnMesas.UseVisualStyleBackColor = False
        ' 
        ' BtnProdutoBruto
        ' 
        BtnProdutoBruto.BackColor = Color.Maroon
        BtnProdutoBruto.FlatStyle = FlatStyle.Flat
        BtnProdutoBruto.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnProdutoBruto.ForeColor = Color.Snow
        BtnProdutoBruto.Location = New Point(17, 294)
        BtnProdutoBruto.Margin = New Padding(3, 2, 3, 2)
        BtnProdutoBruto.Name = "BtnProdutoBruto"
        BtnProdutoBruto.Size = New Size(197, 28)
        BtnProdutoBruto.TabIndex = 113
        BtnProdutoBruto.Text = "Produto Bruto"
        BtnProdutoBruto.UseVisualStyleBackColor = False
        ' 
        ' Lbl_Data
        ' 
        Lbl_Data.AutoSize = True
        Lbl_Data.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Lbl_Data.ForeColor = Color.White
        Lbl_Data.Location = New Point(51, 577)
        Lbl_Data.Name = "Lbl_Data"
        Lbl_Data.Size = New Size(54, 20)
        Lbl_Data.TabIndex = 36
        Lbl_Data.Text = "Data:-"
        ' 
        ' BtnFornecedor
        ' 
        BtnFornecedor.BackColor = Color.Maroon
        BtnFornecedor.FlatStyle = FlatStyle.Flat
        BtnFornecedor.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnFornecedor.ForeColor = Color.Snow
        BtnFornecedor.Location = New Point(17, 122)
        BtnFornecedor.Margin = New Padding(3, 2, 3, 2)
        BtnFornecedor.Name = "BtnFornecedor"
        BtnFornecedor.Size = New Size(197, 28)
        BtnFornecedor.TabIndex = 111
        BtnFornecedor.Text = "Fornecedor"
        BtnFornecedor.UseVisualStyleBackColor = False
        ' 
        ' BtnStock
        ' 
        BtnStock.BackColor = Color.Maroon
        BtnStock.FlatStyle = FlatStyle.Flat
        BtnStock.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnStock.ForeColor = Color.Snow
        BtnStock.Location = New Point(17, 360)
        BtnStock.Margin = New Padding(3, 2, 3, 2)
        BtnStock.Name = "BtnStock"
        BtnStock.Size = New Size(198, 28)
        BtnStock.TabIndex = 112
        BtnStock.Text = "Stock"
        BtnStock.UseVisualStyleBackColor = False
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
        ' BtnPedidosDelivery
        ' 
        BtnPedidosDelivery.BackColor = Color.Maroon
        BtnPedidosDelivery.FlatStyle = FlatStyle.Flat
        BtnPedidosDelivery.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnPedidosDelivery.ForeColor = Color.Snow
        BtnPedidosDelivery.Location = New Point(17, 260)
        BtnPedidosDelivery.Margin = New Padding(3, 2, 3, 2)
        BtnPedidosDelivery.Name = "BtnPedidosDelivery"
        BtnPedidosDelivery.Size = New Size(197, 28)
        BtnPedidosDelivery.TabIndex = 110
        BtnPedidosDelivery.Text = "Pedidos Delivery"
        BtnPedidosDelivery.UseVisualStyleBackColor = False
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
        ' BtnPagamento
        ' 
        BtnPagamento.BackColor = Color.Maroon
        BtnPagamento.FlatStyle = FlatStyle.Flat
        BtnPagamento.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnPagamento.ForeColor = Color.Snow
        BtnPagamento.Location = New Point(17, 225)
        BtnPagamento.Margin = New Padding(3, 2, 3, 2)
        BtnPagamento.Name = "BtnPagamento"
        BtnPagamento.Size = New Size(197, 28)
        BtnPagamento.TabIndex = 116
        BtnPagamento.Text = "Pagamento"
        BtnPagamento.UseVisualStyleBackColor = False
        ' 
        ' BtnPratos
        ' 
        BtnPratos.BackColor = Color.Maroon
        BtnPratos.FlatStyle = FlatStyle.Flat
        BtnPratos.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnPratos.ForeColor = Color.Snow
        BtnPratos.Location = New Point(17, 156)
        BtnPratos.Margin = New Padding(3, 2, 3, 2)
        BtnPratos.Name = "BtnPratos"
        BtnPratos.Size = New Size(197, 28)
        BtnPratos.TabIndex = 114
        BtnPratos.Text = "Home"
        BtnPratos.UseVisualStyleBackColor = False
        ' 
        ' lblPrecoPratoNormalP
        ' 
        lblPrecoPratoNormalP.AutoSize = True
        lblPrecoPratoNormalP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblPrecoPratoNormalP.ForeColor = Color.Red
        lblPrecoPratoNormalP.Location = New Point(999, 72)
        lblPrecoPratoNormalP.Name = "lblPrecoPratoNormalP"
        lblPrecoPratoNormalP.Size = New Size(18, 23)
        lblPrecoPratoNormalP.TabIndex = 94
        lblPrecoPratoNormalP.Text = "*"
        lblPrecoPratoNormalP.Visible = False
        ' 
        ' lblTipoPratoP
        ' 
        lblTipoPratoP.AutoSize = True
        lblTipoPratoP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblTipoPratoP.ForeColor = Color.Red
        lblTipoPratoP.Location = New Point(763, 72)
        lblTipoPratoP.Name = "lblTipoPratoP"
        lblTipoPratoP.Size = New Size(18, 23)
        lblTipoPratoP.TabIndex = 93
        lblTipoPratoP.Text = "*"
        lblTipoPratoP.Visible = False
        ' 
        ' lblIdPratoNormalP
        ' 
        lblIdPratoNormalP.AutoSize = True
        lblIdPratoNormalP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblIdPratoNormalP.ForeColor = Color.Red
        lblIdPratoNormalP.Location = New Point(523, 72)
        lblIdPratoNormalP.Name = "lblIdPratoNormalP"
        lblIdPratoNormalP.Size = New Size(18, 23)
        lblIdPratoNormalP.TabIndex = 92
        lblIdPratoNormalP.Text = "*"
        lblIdPratoNormalP.Visible = False
        ' 
        ' BtnImprimir
        ' 
        BtnImprimir.BackColor = Color.Maroon
        BtnImprimir.FlatStyle = FlatStyle.Flat
        BtnImprimir.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnImprimir.ForeColor = Color.Snow
        BtnImprimir.Location = New Point(1179, 527)
        BtnImprimir.Margin = New Padding(3, 2, 3, 2)
        BtnImprimir.Name = "BtnImprimir"
        BtnImprimir.Size = New Size(108, 28)
        BtnImprimir.TabIndex = 91
        BtnImprimir.Text = "Imprimir"
        BtnImprimir.UseVisualStyleBackColor = False
        ' 
        ' BtnFormatar
        ' 
        BtnFormatar.BackColor = Color.Maroon
        BtnFormatar.FlatStyle = FlatStyle.Flat
        BtnFormatar.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnFormatar.ForeColor = Color.Snow
        BtnFormatar.Location = New Point(1035, 527)
        BtnFormatar.Margin = New Padding(3, 2, 3, 2)
        BtnFormatar.Name = "BtnFormatar"
        BtnFormatar.Size = New Size(116, 28)
        BtnFormatar.TabIndex = 90
        BtnFormatar.Text = "Formatar"
        BtnFormatar.UseVisualStyleBackColor = False
        ' 
        ' ComboBoxPrato
        ' 
        ComboBoxPrato.FormattingEnabled = True
        ComboBoxPrato.Location = New Point(626, 82)
        ComboBoxPrato.Margin = New Padding(3, 2, 3, 2)
        ComboBoxPrato.Name = "ComboBoxPrato"
        ComboBoxPrato.Size = New Size(133, 23)
        ComboBoxPrato.TabIndex = 89
        ' 
        ' DataGridViewPratos
        ' 
        DataGridViewPratos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewPratos.Location = New Point(281, 355)
        DataGridViewPratos.Margin = New Padding(3, 2, 3, 2)
        DataGridViewPratos.Name = "DataGridViewPratos"
        DataGridViewPratos.RowHeadersWidth = 51
        DataGridViewPratos.RowTemplate.Height = 29
        DataGridViewPratos.Size = New Size(739, 220)
        DataGridViewPratos.TabIndex = 88
        ' 
        ' TextBoxIdPrato
        ' 
        TextBoxIdPrato.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxIdPrato.Location = New Point(409, 80)
        TextBoxIdPrato.Margin = New Padding(3, 2, 3, 2)
        TextBoxIdPrato.Name = "TextBoxIdPrato"
        TextBoxIdPrato.Size = New Size(110, 27)
        TextBoxIdPrato.TabIndex = 87
        ' 
        ' lblIdPrato
        ' 
        lblIdPrato.AutoSize = True
        lblIdPrato.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblIdPrato.Location = New Point(319, 87)
        lblIdPrato.Name = "lblIdPrato"
        lblIdPrato.Size = New Size(71, 19)
        lblIdPrato.TabIndex = 86
        lblIdPrato.Text = "Id Prato:"
        ' 
        ' BtnLimpar
        ' 
        BtnLimpar.BackColor = Color.Maroon
        BtnLimpar.FlatStyle = FlatStyle.Flat
        BtnLimpar.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnLimpar.ForeColor = Color.Snow
        BtnLimpar.Location = New Point(1042, 290)
        BtnLimpar.Margin = New Padding(3, 2, 3, 2)
        BtnLimpar.Name = "BtnLimpar"
        BtnLimpar.Size = New Size(90, 39)
        BtnLimpar.TabIndex = 85
        BtnLimpar.Text = "Limpar"
        BtnLimpar.UseVisualStyleBackColor = False
        ' 
        ' BtnDeletar
        ' 
        BtnDeletar.BackColor = Color.Maroon
        BtnDeletar.FlatStyle = FlatStyle.Flat
        BtnDeletar.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnDeletar.ForeColor = Color.Snow
        BtnDeletar.Location = New Point(1167, 290)
        BtnDeletar.Margin = New Padding(3, 2, 3, 2)
        BtnDeletar.Name = "BtnDeletar"
        BtnDeletar.Size = New Size(93, 39)
        BtnDeletar.TabIndex = 84
        BtnDeletar.Text = "Deletar"
        BtnDeletar.UseVisualStyleBackColor = False
        ' 
        ' BtnEditar
        ' 
        BtnEditar.BackColor = Color.Maroon
        BtnEditar.FlatStyle = FlatStyle.Flat
        BtnEditar.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnEditar.ForeColor = Color.Snow
        BtnEditar.Location = New Point(932, 290)
        BtnEditar.Margin = New Padding(3, 2, 3, 2)
        BtnEditar.Name = "BtnEditar"
        BtnEditar.Size = New Size(75, 39)
        BtnEditar.TabIndex = 83
        BtnEditar.Text = "Editar"
        BtnEditar.UseVisualStyleBackColor = False
        ' 
        ' BtnAdicionar
        ' 
        BtnAdicionar.BackColor = Color.Maroon
        BtnAdicionar.FlatStyle = FlatStyle.Flat
        BtnAdicionar.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnAdicionar.ForeColor = Color.Snow
        BtnAdicionar.Location = New Point(780, 290)
        BtnAdicionar.Margin = New Padding(3, 2, 3, 2)
        BtnAdicionar.Name = "BtnAdicionar"
        BtnAdicionar.Size = New Size(117, 39)
        BtnAdicionar.TabIndex = 82
        BtnAdicionar.Text = "Adicionar"
        BtnAdicionar.UseVisualStyleBackColor = False
        ' 
        ' TextBoxPreco
        ' 
        TextBoxPreco.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxPreco.Location = New Point(885, 80)
        TextBoxPreco.Margin = New Padding(3, 2, 3, 2)
        TextBoxPreco.Name = "TextBoxPreco"
        TextBoxPreco.Size = New Size(110, 27)
        TextBoxPreco.TabIndex = 81
        ' 
        ' TextBoxDescricao
        ' 
        TextBoxDescricao.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxDescricao.Location = New Point(417, 172)
        TextBoxDescricao.Margin = New Padding(3, 2, 3, 2)
        TextBoxDescricao.Multiline = True
        TextBoxDescricao.Name = "TextBoxDescricao"
        TextBoxDescricao.Size = New Size(341, 158)
        TextBoxDescricao.TabIndex = 80
        ' 
        ' lblPreco
        ' 
        lblPreco.AutoSize = True
        lblPreco.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblPreco.Location = New Point(810, 87)
        lblPreco.Name = "lblPreco"
        lblPreco.Size = New Size(57, 19)
        lblPreco.TabIndex = 79
        lblPreco.Text = "Preço:"
        ' 
        ' lblDescricao
        ' 
        lblDescricao.AutoSize = True
        lblDescricao.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblDescricao.Location = New Point(298, 174)
        lblDescricao.Name = "lblDescricao"
        lblDescricao.Size = New Size(90, 19)
        lblDescricao.TabIndex = 78
        lblDescricao.Text = "Descrição:"
        ' 
        ' lblPrato
        ' 
        lblPrato.AutoSize = True
        lblPrato.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblPrato.Location = New Point(556, 87)
        lblPrato.Name = "lblPrato"
        lblPrato.Size = New Size(52, 19)
        lblPrato.TabIndex = 77
        lblPrato.Text = "Prato:"
        ' 
        ' TextBoxValorVenda
        ' 
        TextBoxValorVenda.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxValorVenda.Location = New Point(682, 125)
        TextBoxValorVenda.Margin = New Padding(3, 2, 3, 2)
        TextBoxValorVenda.Name = "TextBoxValorVenda"
        TextBoxValorVenda.Size = New Size(110, 27)
        TextBoxValorVenda.TabIndex = 99
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(556, 132)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 19)
        Label4.TabIndex = 98
        Label4.Text = "Valor Venda:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(525, 122)
        Label1.Name = "Label1"
        Label1.Size = New Size(18, 23)
        Label1.TabIndex = 97
        Label1.Text = "*"
        Label1.Visible = False
        ' 
        ' TextBoxValorProducao
        ' 
        TextBoxValorProducao.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxValorProducao.Location = New Point(409, 130)
        TextBoxValorProducao.Margin = New Padding(3, 2, 3, 2)
        TextBoxValorProducao.Name = "TextBoxValorProducao"
        TextBoxValorProducao.Size = New Size(110, 27)
        TextBoxValorProducao.TabIndex = 96
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(252, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(135, 19)
        Label2.TabIndex = 95
        Label2.Text = "Valor Pradução:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(797, 120)
        Label3.Name = "Label3"
        Label3.Size = New Size(18, 23)
        Label3.TabIndex = 100
        Label3.Text = "*"
        Label3.Visible = False
        ' 
        ' PratosForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1312, 600)
        Controls.Add(TextBoxValorVenda)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(TextBoxValorProducao)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(lblPrecoPratoNormalP)
        Controls.Add(lblTipoPratoP)
        Controls.Add(lblIdPratoNormalP)
        Controls.Add(BtnImprimir)
        Controls.Add(BtnFormatar)
        Controls.Add(ComboBoxPrato)
        Controls.Add(DataGridViewPratos)
        Controls.Add(TextBoxIdPrato)
        Controls.Add(lblIdPrato)
        Controls.Add(BtnLimpar)
        Controls.Add(BtnDeletar)
        Controls.Add(BtnEditar)
        Controls.Add(BtnAdicionar)
        Controls.Add(TextBoxPreco)
        Controls.Add(TextBoxDescricao)
        Controls.Add(lblPreco)
        Controls.Add(lblDescricao)
        Controls.Add(lblPrato)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "PratosForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PratosForm"
        Panel2.ResumeLayout(False)
        GroupBoxPesquisa.ResumeLayout(False)
        GroupBoxPesquisa.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridViewPratos, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblPrecoPratoNormalP As Label
    Friend WithEvents lblTipoPratoP As Label
    Friend WithEvents lblIdPratoNormalP As Label
    Friend WithEvents BtnImprimir As Button
    Friend WithEvents BtnFormatar As Button
    Friend WithEvents ComboBoxPrato As ComboBox
    Friend WithEvents DataGridViewPratos As DataGridView
    Friend WithEvents TextBoxIdPrato As TextBox
    Friend WithEvents lblIdPrato As Label
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnDeletar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnAdicionar As Button
    Friend WithEvents TextBoxPreco As TextBox
    Friend WithEvents TextBoxDescricao As TextBox
    Friend WithEvents lblPreco As Label
    Friend WithEvents lblDescricao As Label
    Friend WithEvents lblPrato As Label
    Friend WithEvents TextBoxValorVenda As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxValorProducao As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnUsuarios As Button
    Friend WithEvents BtnAboutMe As Button
    Friend WithEvents BtnMesas As Button
    Friend WithEvents BtnProdutoBruto As Button
    Friend WithEvents BtnFornecedor As Button
    Friend WithEvents BtnPedidosDelivery As Button
    Friend WithEvents BtnStock As Button
    Friend WithEvents BtnPagamento As Button
    Friend WithEvents BtnPratos As Button
    Friend WithEvents BtnRecuperarSenha As Button
    Friend WithEvents BtnLogout As Button
End Class
