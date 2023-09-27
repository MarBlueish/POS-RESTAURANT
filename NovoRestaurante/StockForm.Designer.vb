<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(StockForm))
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
        BtnPedidosDelivery = New Button()
        BtnPratos = New Button()
        BtnPagamento = New Button()
        BtnStock = New Button()
        lblPrecoEstP = New Label()
        lblQntEstP = New Label()
        lblValidadeEstP = New Label()
        lblSaidaEstP = New Label()
        lblEntradaEstP = New Label()
        lblProdutoEstP = New Label()
        lblIIdProdutoEstP = New Label()
        lblDataValidade = New Label()
        DateTimePickerDataValidade = New DateTimePicker()
        lblDataSaida = New Label()
        DateTimePickerDataSaida = New DateTimePicker()
        lblDataEntrada = New Label()
        DateTimePickerDataEntrada = New DateTimePicker()
        TextBoxIdProduto = New TextBox()
        lblIdProduto = New Label()
        DataGridViewEstoque = New DataGridView()
        BtnLimpar = New Button()
        BtnDeletar = New Button()
        BtnEditar = New Button()
        BtnAdicionar = New Button()
        TextBoxPreco = New TextBox()
        TextBoxQuantidade = New TextBox()
        TextBoxProduto = New TextBox()
        lblPreco = New Label()
        lblQuantidade = New Label()
        lblProduto = New Label()
        Panel2.SuspendLayout()
        GroupBoxPesquisa.SuspendLayout()
        Panel1.SuspendLayout()
        CType(DataGridViewEstoque, ComponentModel.ISupportInitialize).BeginInit()
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
        GroupBoxPesquisa.TabIndex = 40
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
        BtnFechar.TabIndex = 40
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
        Panel1.Controls.Add(BtnPedidosDelivery)
        Panel1.Controls.Add(BtnPratos)
        Panel1.Controls.Add(BtnPagamento)
        Panel1.Controls.Add(BtnStock)
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
        BtnLogout.Location = New Point(17, 458)
        BtnLogout.Margin = New Padding(3, 2, 3, 2)
        BtnLogout.Name = "BtnLogout"
        BtnLogout.Size = New Size(197, 44)
        BtnLogout.TabIndex = 139
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
        Lbl_time.TabIndex = 41
        Lbl_time.Text = "Data"
        ' 
        ' BtnRecuperarSenha
        ' 
        BtnRecuperarSenha.BackColor = Color.Maroon
        BtnRecuperarSenha.FlatStyle = FlatStyle.Flat
        BtnRecuperarSenha.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnRecuperarSenha.ForeColor = Color.Snow
        BtnRecuperarSenha.Location = New Point(17, 302)
        BtnRecuperarSenha.Margin = New Padding(3, 2, 3, 2)
        BtnRecuperarSenha.Name = "BtnRecuperarSenha"
        BtnRecuperarSenha.Size = New Size(197, 28)
        BtnRecuperarSenha.TabIndex = 134
        BtnRecuperarSenha.Text = "Recuperar Senha"
        BtnRecuperarSenha.UseVisualStyleBackColor = False
        ' 
        ' BtnUsuarios
        ' 
        BtnUsuarios.BackColor = Color.Maroon
        BtnUsuarios.FlatStyle = FlatStyle.Flat
        BtnUsuarios.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnUsuarios.ForeColor = Color.Snow
        BtnUsuarios.Location = New Point(17, 366)
        BtnUsuarios.Margin = New Padding(3, 2, 3, 2)
        BtnUsuarios.Name = "BtnUsuarios"
        BtnUsuarios.Size = New Size(197, 28)
        BtnUsuarios.TabIndex = 137
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
        Lbl_Data.TabIndex = 40
        Lbl_Data.Text = "Data:-"
        ' 
        ' BtnAbout
        ' 
        BtnAbout.BackColor = Color.Maroon
        BtnAbout.FlatStyle = FlatStyle.Flat
        BtnAbout.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnAbout.ForeColor = Color.Snow
        BtnAbout.Location = New Point(17, 60)
        BtnAbout.Margin = New Padding(3, 2, 3, 2)
        BtnAbout.Name = "BtnAbout"
        BtnAbout.Size = New Size(197, 28)
        BtnAbout.TabIndex = 128
        BtnAbout.Text = "About"
        BtnAbout.UseVisualStyleBackColor = False
        ' 
        ' BtnMesas
        ' 
        BtnMesas.BackColor = Color.Maroon
        BtnMesas.FlatStyle = FlatStyle.Flat
        BtnMesas.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnMesas.ForeColor = Color.Snow
        BtnMesas.Location = New Point(17, 164)
        BtnMesas.Margin = New Padding(3, 2, 3, 2)
        BtnMesas.Name = "BtnMesas"
        BtnMesas.Size = New Size(197, 28)
        BtnMesas.TabIndex = 129
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
        Lbl_User.TabIndex = 44
        Lbl_User.Text = "User"
        ' 
        ' BtnProdutoBruto
        ' 
        BtnProdutoBruto.BackColor = Color.Maroon
        BtnProdutoBruto.FlatStyle = FlatStyle.Flat
        BtnProdutoBruto.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnProdutoBruto.ForeColor = Color.Snow
        BtnProdutoBruto.Location = New Point(17, 267)
        BtnProdutoBruto.Margin = New Padding(3, 2, 3, 2)
        BtnProdutoBruto.Name = "BtnProdutoBruto"
        BtnProdutoBruto.Size = New Size(197, 28)
        BtnProdutoBruto.TabIndex = 135
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
        Label5.TabIndex = 43
        Label5.Text = "Seja Bem Vindo(a),"
        ' 
        ' BtnFornecedor
        ' 
        BtnFornecedor.BackColor = Color.Maroon
        BtnFornecedor.FlatStyle = FlatStyle.Flat
        BtnFornecedor.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnFornecedor.ForeColor = Color.Snow
        BtnFornecedor.Location = New Point(17, 94)
        BtnFornecedor.Margin = New Padding(3, 2, 3, 2)
        BtnFornecedor.Name = "BtnFornecedor"
        BtnFornecedor.Size = New Size(197, 28)
        BtnFornecedor.TabIndex = 131
        BtnFornecedor.Text = "Fornecedor"
        BtnFornecedor.UseVisualStyleBackColor = False
        ' 
        ' BtnPedidosDelivery
        ' 
        BtnPedidosDelivery.BackColor = Color.Maroon
        BtnPedidosDelivery.FlatStyle = FlatStyle.Flat
        BtnPedidosDelivery.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnPedidosDelivery.ForeColor = Color.Snow
        BtnPedidosDelivery.Location = New Point(17, 232)
        BtnPedidosDelivery.Margin = New Padding(3, 2, 3, 2)
        BtnPedidosDelivery.Name = "BtnPedidosDelivery"
        BtnPedidosDelivery.Size = New Size(197, 28)
        BtnPedidosDelivery.TabIndex = 130
        BtnPedidosDelivery.Text = "Pedidos Delivery"
        BtnPedidosDelivery.UseVisualStyleBackColor = False
        ' 
        ' BtnPratos
        ' 
        BtnPratos.BackColor = Color.Maroon
        BtnPratos.FlatStyle = FlatStyle.Flat
        BtnPratos.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnPratos.ForeColor = Color.Snow
        BtnPratos.Location = New Point(17, 129)
        BtnPratos.Margin = New Padding(3, 2, 3, 2)
        BtnPratos.Name = "BtnPratos"
        BtnPratos.Size = New Size(197, 28)
        BtnPratos.TabIndex = 136
        BtnPratos.Text = "Home"
        BtnPratos.UseVisualStyleBackColor = False
        ' 
        ' BtnPagamento
        ' 
        BtnPagamento.BackColor = Color.Maroon
        BtnPagamento.FlatStyle = FlatStyle.Flat
        BtnPagamento.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnPagamento.ForeColor = Color.Snow
        BtnPagamento.Location = New Point(17, 198)
        BtnPagamento.Margin = New Padding(3, 2, 3, 2)
        BtnPagamento.Name = "BtnPagamento"
        BtnPagamento.Size = New Size(197, 28)
        BtnPagamento.TabIndex = 138
        BtnPagamento.Text = "Pagamento"
        BtnPagamento.UseVisualStyleBackColor = False
        ' 
        ' BtnStock
        ' 
        BtnStock.BackColor = Color.Maroon
        BtnStock.FlatStyle = FlatStyle.Flat
        BtnStock.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnStock.ForeColor = Color.Snow
        BtnStock.Location = New Point(17, 334)
        BtnStock.Margin = New Padding(3, 2, 3, 2)
        BtnStock.Name = "BtnStock"
        BtnStock.Size = New Size(198, 28)
        BtnStock.TabIndex = 132
        BtnStock.Text = "Stock"
        BtnStock.UseVisualStyleBackColor = False
        ' 
        ' lblPrecoEstP
        ' 
        lblPrecoEstP.AutoSize = True
        lblPrecoEstP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblPrecoEstP.ForeColor = Color.Red
        lblPrecoEstP.Location = New Point(1160, 118)
        lblPrecoEstP.Name = "lblPrecoEstP"
        lblPrecoEstP.Size = New Size(18, 23)
        lblPrecoEstP.TabIndex = 103
        lblPrecoEstP.Text = "*"
        lblPrecoEstP.Visible = False
        ' 
        ' lblQntEstP
        ' 
        lblQntEstP.AutoSize = True
        lblQntEstP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblQntEstP.ForeColor = Color.Red
        lblQntEstP.Location = New Point(537, 128)
        lblQntEstP.Name = "lblQntEstP"
        lblQntEstP.Size = New Size(18, 23)
        lblQntEstP.TabIndex = 102
        lblQntEstP.Text = "*"
        lblQntEstP.Visible = False
        ' 
        ' lblValidadeEstP
        ' 
        lblValidadeEstP.AutoSize = True
        lblValidadeEstP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblValidadeEstP.ForeColor = Color.Red
        lblValidadeEstP.Location = New Point(700, 279)
        lblValidadeEstP.Name = "lblValidadeEstP"
        lblValidadeEstP.Size = New Size(18, 23)
        lblValidadeEstP.TabIndex = 101
        lblValidadeEstP.Text = "*"
        lblValidadeEstP.Visible = False
        ' 
        ' lblSaidaEstP
        ' 
        lblSaidaEstP.AutoSize = True
        lblSaidaEstP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblSaidaEstP.ForeColor = Color.Red
        lblSaidaEstP.Location = New Point(700, 232)
        lblSaidaEstP.Name = "lblSaidaEstP"
        lblSaidaEstP.Size = New Size(18, 23)
        lblSaidaEstP.TabIndex = 100
        lblSaidaEstP.Text = "*"
        lblSaidaEstP.Visible = False
        ' 
        ' lblEntradaEstP
        ' 
        lblEntradaEstP.AutoSize = True
        lblEntradaEstP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblEntradaEstP.ForeColor = Color.Red
        lblEntradaEstP.Location = New Point(700, 188)
        lblEntradaEstP.Name = "lblEntradaEstP"
        lblEntradaEstP.Size = New Size(18, 23)
        lblEntradaEstP.TabIndex = 99
        lblEntradaEstP.Text = "*"
        lblEntradaEstP.Visible = False
        ' 
        ' lblProdutoEstP
        ' 
        lblProdutoEstP.AutoSize = True
        lblProdutoEstP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblProdutoEstP.ForeColor = Color.Red
        lblProdutoEstP.Location = New Point(1160, 88)
        lblProdutoEstP.Name = "lblProdutoEstP"
        lblProdutoEstP.Size = New Size(18, 23)
        lblProdutoEstP.TabIndex = 98
        lblProdutoEstP.Text = "*"
        lblProdutoEstP.Visible = False
        ' 
        ' lblIIdProdutoEstP
        ' 
        lblIIdProdutoEstP.AutoSize = True
        lblIIdProdutoEstP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblIIdProdutoEstP.ForeColor = Color.Red
        lblIIdProdutoEstP.Location = New Point(537, 92)
        lblIIdProdutoEstP.Name = "lblIIdProdutoEstP"
        lblIIdProdutoEstP.Size = New Size(18, 23)
        lblIIdProdutoEstP.TabIndex = 97
        lblIIdProdutoEstP.Text = "*"
        lblIIdProdutoEstP.Visible = False
        ' 
        ' lblDataValidade
        ' 
        lblDataValidade.AutoSize = True
        lblDataValidade.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblDataValidade.Location = New Point(296, 289)
        lblDataValidade.Name = "lblDataValidade"
        lblDataValidade.Size = New Size(152, 19)
        lblDataValidade.TabIndex = 96
        lblDataValidade.Text = "Data de Validade:"
        ' 
        ' DateTimePickerDataValidade
        ' 
        DateTimePickerDataValidade.Location = New Point(476, 287)
        DateTimePickerDataValidade.Margin = New Padding(3, 2, 3, 2)
        DateTimePickerDataValidade.Name = "DateTimePickerDataValidade"
        DateTimePickerDataValidade.Size = New Size(219, 23)
        DateTimePickerDataValidade.TabIndex = 95
        ' 
        ' lblDataSaida
        ' 
        lblDataSaida.AutoSize = True
        lblDataSaida.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblDataSaida.Location = New Point(296, 245)
        lblDataSaida.Name = "lblDataSaida"
        lblDataSaida.Size = New Size(124, 19)
        lblDataSaida.TabIndex = 94
        lblDataSaida.Text = "Data de Saída:"
        ' 
        ' DateTimePickerDataSaida
        ' 
        DateTimePickerDataSaida.Location = New Point(476, 244)
        DateTimePickerDataSaida.Margin = New Padding(3, 2, 3, 2)
        DateTimePickerDataSaida.Name = "DateTimePickerDataSaida"
        DateTimePickerDataSaida.Size = New Size(219, 23)
        DateTimePickerDataSaida.TabIndex = 93
        ' 
        ' lblDataEntrada
        ' 
        lblDataEntrada.AutoSize = True
        lblDataEntrada.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblDataEntrada.Location = New Point(296, 199)
        lblDataEntrada.Name = "lblDataEntrada"
        lblDataEntrada.Size = New Size(139, 19)
        lblDataEntrada.TabIndex = 92
        lblDataEntrada.Text = "Data de Entrada:"
        ' 
        ' DateTimePickerDataEntrada
        ' 
        DateTimePickerDataEntrada.Location = New Point(476, 197)
        DateTimePickerDataEntrada.Margin = New Padding(3, 2, 3, 2)
        DateTimePickerDataEntrada.Name = "DateTimePickerDataEntrada"
        DateTimePickerDataEntrada.Size = New Size(219, 23)
        DateTimePickerDataEntrada.TabIndex = 91
        ' 
        ' TextBoxIdProduto
        ' 
        TextBoxIdProduto.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxIdProduto.Location = New Point(423, 99)
        TextBoxIdProduto.Margin = New Padding(3, 2, 3, 2)
        TextBoxIdProduto.Name = "TextBoxIdProduto"
        TextBoxIdProduto.Size = New Size(110, 27)
        TextBoxIdProduto.TabIndex = 90
        ' 
        ' lblIdProduto
        ' 
        lblIdProduto.AutoSize = True
        lblIdProduto.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblIdProduto.Location = New Point(296, 99)
        lblIdProduto.Name = "lblIdProduto"
        lblIdProduto.Size = New Size(91, 19)
        lblIdProduto.TabIndex = 89
        lblIdProduto.Text = "Id Produto:"
        ' 
        ' DataGridViewEstoque
        ' 
        DataGridViewEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewEstoque.Location = New Point(306, 364)
        DataGridViewEstoque.Margin = New Padding(3, 2, 3, 2)
        DataGridViewEstoque.Name = "DataGridViewEstoque"
        DataGridViewEstoque.RowHeadersWidth = 51
        DataGridViewEstoque.RowTemplate.Height = 29
        DataGridViewEstoque.Size = New Size(937, 218)
        DataGridViewEstoque.TabIndex = 88
        ' 
        ' BtnLimpar
        ' 
        BtnLimpar.BackColor = Color.Maroon
        BtnLimpar.FlatStyle = FlatStyle.Flat
        BtnLimpar.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnLimpar.ForeColor = Color.Snow
        BtnLimpar.Location = New Point(1046, 200)
        BtnLimpar.Margin = New Padding(3, 2, 3, 2)
        BtnLimpar.Name = "BtnLimpar"
        BtnLimpar.Size = New Size(90, 39)
        BtnLimpar.TabIndex = 87
        BtnLimpar.Text = "Limpar"
        BtnLimpar.UseVisualStyleBackColor = False
        ' 
        ' BtnDeletar
        ' 
        BtnDeletar.BackColor = Color.Maroon
        BtnDeletar.FlatStyle = FlatStyle.Flat
        BtnDeletar.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnDeletar.ForeColor = Color.Snow
        BtnDeletar.Location = New Point(1195, 200)
        BtnDeletar.Margin = New Padding(3, 2, 3, 2)
        BtnDeletar.Name = "BtnDeletar"
        BtnDeletar.Size = New Size(93, 39)
        BtnDeletar.TabIndex = 86
        BtnDeletar.Text = "Deletar"
        BtnDeletar.UseVisualStyleBackColor = False
        ' 
        ' BtnEditar
        ' 
        BtnEditar.BackColor = Color.Maroon
        BtnEditar.FlatStyle = FlatStyle.Flat
        BtnEditar.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnEditar.ForeColor = Color.Snow
        BtnEditar.Location = New Point(943, 200)
        BtnEditar.Margin = New Padding(3, 2, 3, 2)
        BtnEditar.Name = "BtnEditar"
        BtnEditar.Size = New Size(75, 39)
        BtnEditar.TabIndex = 85
        BtnEditar.Text = "Editar"
        BtnEditar.UseVisualStyleBackColor = False
        ' 
        ' BtnAdicionar
        ' 
        BtnAdicionar.BackColor = Color.Maroon
        BtnAdicionar.FlatStyle = FlatStyle.Flat
        BtnAdicionar.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnAdicionar.ForeColor = Color.Snow
        BtnAdicionar.Location = New Point(807, 200)
        BtnAdicionar.Margin = New Padding(3, 2, 3, 2)
        BtnAdicionar.Name = "BtnAdicionar"
        BtnAdicionar.Size = New Size(117, 39)
        BtnAdicionar.TabIndex = 84
        BtnAdicionar.Text = "Adicionar"
        BtnAdicionar.UseVisualStyleBackColor = False
        ' 
        ' TextBoxPreco
        ' 
        TextBoxPreco.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxPreco.Location = New Point(1044, 122)
        TextBoxPreco.Margin = New Padding(3, 2, 3, 2)
        TextBoxPreco.Name = "TextBoxPreco"
        TextBoxPreco.Size = New Size(110, 27)
        TextBoxPreco.TabIndex = 83
        ' 
        ' TextBoxQuantidade
        ' 
        TextBoxQuantidade.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxQuantidade.Location = New Point(423, 138)
        TextBoxQuantidade.Margin = New Padding(3, 2, 3, 2)
        TextBoxQuantidade.Name = "TextBoxQuantidade"
        TextBoxQuantidade.Size = New Size(110, 27)
        TextBoxQuantidade.TabIndex = 82
        ' 
        ' TextBoxProduto
        ' 
        TextBoxProduto.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxProduto.Location = New Point(734, 92)
        TextBoxProduto.Margin = New Padding(3, 2, 3, 2)
        TextBoxProduto.Name = "TextBoxProduto"
        TextBoxProduto.Size = New Size(421, 27)
        TextBoxProduto.TabIndex = 81
        ' 
        ' lblPreco
        ' 
        lblPreco.AutoSize = True
        lblPreco.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblPreco.Location = New Point(962, 128)
        lblPreco.Name = "lblPreco"
        lblPreco.Size = New Size(57, 19)
        lblPreco.TabIndex = 80
        lblPreco.Text = "Preço:"
        ' 
        ' lblQuantidade
        ' 
        lblQuantidade.AutoSize = True
        lblQuantidade.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblQuantidade.Location = New Point(296, 145)
        lblQuantidade.Name = "lblQuantidade"
        lblQuantidade.Size = New Size(108, 19)
        lblQuantidade.TabIndex = 79
        lblQuantidade.Text = "Quantidade:"
        ' 
        ' lblProduto
        ' 
        lblProduto.AutoSize = True
        lblProduto.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblProduto.Location = New Point(607, 99)
        lblProduto.Name = "lblProduto"
        lblProduto.Size = New Size(72, 19)
        lblProduto.TabIndex = 78
        lblProduto.Text = "Produto:"
        ' 
        ' StockForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1312, 600)
        Controls.Add(lblPrecoEstP)
        Controls.Add(lblQntEstP)
        Controls.Add(lblValidadeEstP)
        Controls.Add(lblSaidaEstP)
        Controls.Add(lblEntradaEstP)
        Controls.Add(lblProdutoEstP)
        Controls.Add(lblIIdProdutoEstP)
        Controls.Add(lblDataValidade)
        Controls.Add(DateTimePickerDataValidade)
        Controls.Add(lblDataSaida)
        Controls.Add(DateTimePickerDataSaida)
        Controls.Add(lblDataEntrada)
        Controls.Add(DateTimePickerDataEntrada)
        Controls.Add(TextBoxIdProduto)
        Controls.Add(lblIdProduto)
        Controls.Add(DataGridViewEstoque)
        Controls.Add(BtnLimpar)
        Controls.Add(BtnDeletar)
        Controls.Add(BtnEditar)
        Controls.Add(BtnAdicionar)
        Controls.Add(TextBoxPreco)
        Controls.Add(TextBoxQuantidade)
        Controls.Add(TextBoxProduto)
        Controls.Add(lblPreco)
        Controls.Add(lblQuantidade)
        Controls.Add(lblProduto)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "StockForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "StockForm"
        Panel2.ResumeLayout(False)
        GroupBoxPesquisa.ResumeLayout(False)
        GroupBoxPesquisa.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridViewEstoque, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblPrecoEstP As Label
    Friend WithEvents lblQntEstP As Label
    Friend WithEvents lblValidadeEstP As Label
    Friend WithEvents lblSaidaEstP As Label
    Friend WithEvents lblEntradaEstP As Label
    Friend WithEvents lblProdutoEstP As Label
    Friend WithEvents lblIIdProdutoEstP As Label
    Friend WithEvents lblDataValidade As Label
    Friend WithEvents DateTimePickerDataValidade As DateTimePicker
    Friend WithEvents lblDataSaida As Label
    Friend WithEvents DateTimePickerDataSaida As DateTimePicker
    Friend WithEvents lblDataEntrada As Label
    Friend WithEvents DateTimePickerDataEntrada As DateTimePicker
    Friend WithEvents TextBoxIdProduto As TextBox
    Friend WithEvents lblIdProduto As Label
    Friend WithEvents DataGridViewEstoque As DataGridView
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnDeletar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnAdicionar As Button
    Friend WithEvents TextBoxPreco As TextBox
    Friend WithEvents TextBoxQuantidade As TextBox
    Friend WithEvents TextBoxProduto As TextBox
    Friend WithEvents lblPreco As Label
    Friend WithEvents lblQuantidade As Label
    Friend WithEvents lblProduto As Label
    Friend WithEvents BtnRecuperarSenha As Button
    Friend WithEvents BtnUsuarios As Button
    Friend WithEvents BtnAbout As Button
    Friend WithEvents BtnMesas As Button
    Friend WithEvents BtnProdutoBruto As Button
    Friend WithEvents BtnFornecedor As Button
    Friend WithEvents BtnPedidosDelivery As Button
    Friend WithEvents BtnPratos As Button
    Friend WithEvents BtnPagamento As Button
    Friend WithEvents BtnStock As Button
    Friend WithEvents BtnLogout As Button
End Class
