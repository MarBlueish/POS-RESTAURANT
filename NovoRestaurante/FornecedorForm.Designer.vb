<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FornecedorForm
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FornecedorForm))
        Panel2 = New Panel()
        GroupBoxPesquisa = New GroupBox()
        ComboBoxTipoPesquisa = New ComboBox()
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
        DateTimePickerDataEntrega = New DateTimePicker()
        DateTimePickerCadastro = New DateTimePicker()
        TextBoxObservacoes = New TextBox()
        Label4 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lblTipoFornecedor2 = New Label()
        lblEmail2 = New Label()
        lblNif2 = New Label()
        lblIban2 = New Label()
        Label1 = New Label()
        TextBoxIdFornecedor = New TextBox()
        lblIdFornecedor = New Label()
        DataGridViewFornecedores = New DataGridView()
        BtnLimpar = New Button()
        BtnDeleta = New Button()
        BtnEdita = New Button()
        BtnAdicionar = New Button()
        ComboBoxFormaPagamento = New ComboBox()
        TextBoxEmpresa = New TextBox()
        TextBoxMorada = New TextBox()
        lblPagamento = New Label()
        ComboBoxTipoFornecedor = New ComboBox()
        TextBoxContacto = New TextBox()
        TextBoxEmail = New TextBox()
        TextBoxIBAN = New TextBox()
        TextBoxNIF = New TextBox()
        lblEmail = New Label()
        lblNIF = New Label()
        lblContacto = New Label()
        lblTipoFornecedor = New Label()
        lblIBAN = New Label()
        lblMorada = New Label()
        lblNome = New Label()
        lblIdForn2 = New Label()
        lblNome2 = New Label()
        lblMorada2 = New Label()
        lblPagamento2 = New Label()
        lblContacto2 = New Label()
        Timer1 = New Timer(components)
        Panel2.SuspendLayout()
        GroupBoxPesquisa.SuspendLayout()
        Panel1.SuspendLayout()
        CType(DataGridViewFornecedores, ComponentModel.ISupportInitialize).BeginInit()
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
        GroupBoxPesquisa.Controls.Add(ComboBoxTipoPesquisa)
        GroupBoxPesquisa.Controls.Add(lblPesquisar)
        GroupBoxPesquisa.Controls.Add(TextBoxPesquisa)
        GroupBoxPesquisa.FlatStyle = FlatStyle.Flat
        GroupBoxPesquisa.Location = New Point(2, 2)
        GroupBoxPesquisa.Margin = New Padding(3, 2, 3, 2)
        GroupBoxPesquisa.Name = "GroupBoxPesquisa"
        GroupBoxPesquisa.Padding = New Padding(3, 2, 3, 2)
        GroupBoxPesquisa.Size = New Size(970, 51)
        GroupBoxPesquisa.TabIndex = 60
        GroupBoxPesquisa.TabStop = False
        ' 
        ' ComboBoxTipoPesquisa
        ' 
        ComboBoxTipoPesquisa.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBoxTipoPesquisa.FormattingEnabled = True
        ComboBoxTipoPesquisa.Location = New Point(780, 11)
        ComboBoxTipoPesquisa.Margin = New Padding(3, 2, 3, 2)
        ComboBoxTipoPesquisa.Name = "ComboBoxTipoPesquisa"
        ComboBoxTipoPesquisa.Size = New Size(165, 27)
        ComboBoxTipoPesquisa.TabIndex = 85
        ' 
        ' lblPesquisar
        ' 
        lblPesquisar.AutoSize = True
        lblPesquisar.Font = New Font("Century Gothic", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblPesquisar.ForeColor = Color.Snow
        lblPesquisar.Location = New Point(430, 17)
        lblPesquisar.Name = "lblPesquisar"
        lblPesquisar.Size = New Size(84, 21)
        lblPesquisar.TabIndex = 1
        lblPesquisar.Text = "Pesquisar"
        ' 
        ' TextBoxPesquisa
        ' 
        TextBoxPesquisa.Location = New Point(532, 15)
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
        BtnFechar.TabIndex = 65
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
        BtnLogout.Location = New Point(18, 456)
        BtnLogout.Margin = New Padding(3, 2, 3, 2)
        BtnLogout.Name = "BtnLogout"
        BtnLogout.Size = New Size(197, 44)
        BtnLogout.TabIndex = 142
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
        Lbl_time.TabIndex = 61
        Lbl_time.Text = "Data"
        ' 
        ' BtnRecuperarSenha
        ' 
        BtnRecuperarSenha.BackColor = Color.Maroon
        BtnRecuperarSenha.FlatStyle = FlatStyle.Flat
        BtnRecuperarSenha.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnRecuperarSenha.ForeColor = Color.Snow
        BtnRecuperarSenha.Location = New Point(17, 299)
        BtnRecuperarSenha.Margin = New Padding(3, 2, 3, 2)
        BtnRecuperarSenha.Name = "BtnRecuperarSenha"
        BtnRecuperarSenha.Size = New Size(197, 28)
        BtnRecuperarSenha.TabIndex = 137
        BtnRecuperarSenha.Text = "Recuperar Senha"
        BtnRecuperarSenha.UseVisualStyleBackColor = False
        ' 
        ' BtnUsuarios
        ' 
        BtnUsuarios.BackColor = Color.Maroon
        BtnUsuarios.FlatStyle = FlatStyle.Flat
        BtnUsuarios.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnUsuarios.ForeColor = Color.Snow
        BtnUsuarios.Location = New Point(19, 363)
        BtnUsuarios.Margin = New Padding(3, 2, 3, 2)
        BtnUsuarios.Name = "BtnUsuarios"
        BtnUsuarios.Size = New Size(197, 28)
        BtnUsuarios.TabIndex = 140
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
        Lbl_Data.TabIndex = 60
        Lbl_Data.Text = "Data:-"
        ' 
        ' BtnAbout
        ' 
        BtnAbout.BackColor = Color.Maroon
        BtnAbout.FlatStyle = FlatStyle.Flat
        BtnAbout.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnAbout.ForeColor = Color.Snow
        BtnAbout.Location = New Point(17, 58)
        BtnAbout.Margin = New Padding(3, 2, 3, 2)
        BtnAbout.Name = "BtnAbout"
        BtnAbout.Size = New Size(197, 28)
        BtnAbout.TabIndex = 131
        BtnAbout.Text = "About"
        BtnAbout.UseVisualStyleBackColor = False
        ' 
        ' BtnMesas
        ' 
        BtnMesas.BackColor = Color.Maroon
        BtnMesas.FlatStyle = FlatStyle.Flat
        BtnMesas.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnMesas.ForeColor = Color.Snow
        BtnMesas.Location = New Point(17, 161)
        BtnMesas.Margin = New Padding(3, 2, 3, 2)
        BtnMesas.Name = "BtnMesas"
        BtnMesas.Size = New Size(197, 28)
        BtnMesas.TabIndex = 132
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
        Lbl_User.TabIndex = 64
        Lbl_User.Text = "User"
        ' 
        ' BtnProdutoBruto
        ' 
        BtnProdutoBruto.BackColor = Color.Maroon
        BtnProdutoBruto.FlatStyle = FlatStyle.Flat
        BtnProdutoBruto.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnProdutoBruto.ForeColor = Color.Snow
        BtnProdutoBruto.Location = New Point(17, 265)
        BtnProdutoBruto.Margin = New Padding(3, 2, 3, 2)
        BtnProdutoBruto.Name = "BtnProdutoBruto"
        BtnProdutoBruto.Size = New Size(197, 28)
        BtnProdutoBruto.TabIndex = 138
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
        Label5.TabIndex = 63
        Label5.Text = "Seja Bem Vindo(a),"
        ' 
        ' BtnFornecedor
        ' 
        BtnFornecedor.BackColor = Color.Maroon
        BtnFornecedor.FlatStyle = FlatStyle.Flat
        BtnFornecedor.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnFornecedor.ForeColor = Color.Snow
        BtnFornecedor.Location = New Point(17, 92)
        BtnFornecedor.Margin = New Padding(3, 2, 3, 2)
        BtnFornecedor.Name = "BtnFornecedor"
        BtnFornecedor.Size = New Size(197, 28)
        BtnFornecedor.TabIndex = 134
        BtnFornecedor.Text = "Fornecedor"
        BtnFornecedor.UseVisualStyleBackColor = False
        ' 
        ' BtnPratos
        ' 
        BtnPratos.BackColor = Color.Maroon
        BtnPratos.FlatStyle = FlatStyle.Flat
        BtnPratos.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnPratos.ForeColor = Color.Snow
        BtnPratos.Location = New Point(17, 127)
        BtnPratos.Margin = New Padding(3, 2, 3, 2)
        BtnPratos.Name = "BtnPratos"
        BtnPratos.Size = New Size(197, 28)
        BtnPratos.TabIndex = 139
        BtnPratos.Text = "Home"
        BtnPratos.UseVisualStyleBackColor = False
        ' 
        ' BtnStock
        ' 
        BtnStock.BackColor = Color.Maroon
        BtnStock.FlatStyle = FlatStyle.Flat
        BtnStock.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnStock.ForeColor = Color.Snow
        BtnStock.Location = New Point(18, 331)
        BtnStock.Margin = New Padding(3, 2, 3, 2)
        BtnStock.Name = "BtnStock"
        BtnStock.Size = New Size(198, 28)
        BtnStock.TabIndex = 135
        BtnStock.Text = "Stock"
        BtnStock.UseVisualStyleBackColor = False
        ' 
        ' BtnPagamento
        ' 
        BtnPagamento.BackColor = Color.Maroon
        BtnPagamento.FlatStyle = FlatStyle.Flat
        BtnPagamento.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnPagamento.ForeColor = Color.Snow
        BtnPagamento.Location = New Point(17, 196)
        BtnPagamento.Margin = New Padding(3, 2, 3, 2)
        BtnPagamento.Name = "BtnPagamento"
        BtnPagamento.Size = New Size(197, 28)
        BtnPagamento.TabIndex = 141
        BtnPagamento.Text = "Pagamento"
        BtnPagamento.UseVisualStyleBackColor = False
        ' 
        ' BtnPedidosDelivery
        ' 
        BtnPedidosDelivery.BackColor = Color.Maroon
        BtnPedidosDelivery.FlatStyle = FlatStyle.Flat
        BtnPedidosDelivery.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnPedidosDelivery.ForeColor = Color.Snow
        BtnPedidosDelivery.Location = New Point(17, 230)
        BtnPedidosDelivery.Margin = New Padding(3, 2, 3, 2)
        BtnPedidosDelivery.Name = "BtnPedidosDelivery"
        BtnPedidosDelivery.Size = New Size(197, 28)
        BtnPedidosDelivery.TabIndex = 133
        BtnPedidosDelivery.Text = "Pedidos Delivery"
        BtnPedidosDelivery.UseVisualStyleBackColor = False
        ' 
        ' DateTimePickerDataEntrega
        ' 
        DateTimePickerDataEntrega.Location = New Point(1082, 126)
        DateTimePickerDataEntrega.Margin = New Padding(3, 2, 3, 2)
        DateTimePickerDataEntrega.Name = "DateTimePickerDataEntrega"
        DateTimePickerDataEntrega.Size = New Size(202, 23)
        DateTimePickerDataEntrega.TabIndex = 130
        ' 
        ' DateTimePickerCadastro
        ' 
        DateTimePickerCadastro.Location = New Point(1082, 152)
        DateTimePickerCadastro.Margin = New Padding(3, 2, 3, 2)
        DateTimePickerCadastro.Name = "DateTimePickerCadastro"
        DateTimePickerCadastro.Size = New Size(202, 23)
        DateTimePickerCadastro.TabIndex = 129
        ' 
        ' TextBoxObservacoes
        ' 
        TextBoxObservacoes.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxObservacoes.Location = New Point(1082, 180)
        TextBoxObservacoes.Margin = New Padding(3, 2, 3, 2)
        TextBoxObservacoes.Multiline = True
        TextBoxObservacoes.Name = "TextBoxObservacoes"
        TextBoxObservacoes.Size = New Size(202, 110)
        TextBoxObservacoes.TabIndex = 128
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(938, 187)
        Label4.Name = "Label4"
        Label4.Size = New Size(114, 19)
        Label4.TabIndex = 127
        Label4.Text = "Observações:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(1286, 149)
        Label2.Name = "Label2"
        Label2.Size = New Size(18, 23)
        Label2.TabIndex = 126
        Label2.Text = "*"
        Label2.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(938, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 19)
        Label3.TabIndex = 125
        Label3.Text = "Data Cadastro:"
        ' 
        ' lblTipoFornecedor2
        ' 
        lblTipoFornecedor2.AutoSize = True
        lblTipoFornecedor2.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblTipoFornecedor2.ForeColor = Color.Red
        lblTipoFornecedor2.Location = New Point(1286, 122)
        lblTipoFornecedor2.Name = "lblTipoFornecedor2"
        lblTipoFornecedor2.Size = New Size(18, 23)
        lblTipoFornecedor2.TabIndex = 123
        lblTipoFornecedor2.Text = "*"
        lblTipoFornecedor2.Visible = False
        ' 
        ' lblEmail2
        ' 
        lblEmail2.AutoSize = True
        lblEmail2.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblEmail2.ForeColor = Color.Red
        lblEmail2.Location = New Point(893, 256)
        lblEmail2.Name = "lblEmail2"
        lblEmail2.Size = New Size(18, 23)
        lblEmail2.TabIndex = 121
        lblEmail2.Text = "*"
        lblEmail2.Visible = False
        ' 
        ' lblNif2
        ' 
        lblNif2.AutoSize = True
        lblNif2.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblNif2.ForeColor = Color.Red
        lblNif2.Location = New Point(893, 224)
        lblNif2.Name = "lblNif2"
        lblNif2.Size = New Size(18, 23)
        lblNif2.TabIndex = 120
        lblNif2.Text = "*"
        lblNif2.Visible = False
        ' 
        ' lblIban2
        ' 
        lblIban2.AutoSize = True
        lblIban2.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblIban2.ForeColor = Color.Red
        lblIban2.Location = New Point(893, 193)
        lblIban2.Name = "lblIban2"
        lblIban2.Size = New Size(18, 23)
        lblIban2.TabIndex = 119
        lblIban2.Text = "*"
        lblIban2.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(938, 129)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 19)
        Label1.TabIndex = 115
        Label1.Text = "Data Entrega:"
        ' 
        ' TextBoxIdFornecedor
        ' 
        TextBoxIdFornecedor.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxIdFornecedor.Location = New Point(379, 62)
        TextBoxIdFornecedor.Margin = New Padding(3, 2, 3, 2)
        TextBoxIdFornecedor.Name = "TextBoxIdFornecedor"
        TextBoxIdFornecedor.Size = New Size(154, 27)
        TextBoxIdFornecedor.TabIndex = 114
        ' 
        ' lblIdFornecedor
        ' 
        lblIdFornecedor.AutoSize = True
        lblIdFornecedor.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblIdFornecedor.Location = New Point(293, 64)
        lblIdFornecedor.Name = "lblIdFornecedor"
        lblIdFornecedor.Size = New Size(65, 19)
        lblIdFornecedor.TabIndex = 113
        lblIdFornecedor.Text = "Id Forn:"
        ' 
        ' DataGridViewFornecedores
        ' 
        DataGridViewFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewFornecedores.Location = New Point(270, 356)
        DataGridViewFornecedores.Margin = New Padding(3, 2, 3, 2)
        DataGridViewFornecedores.Name = "DataGridViewFornecedores"
        DataGridViewFornecedores.RowHeadersWidth = 51
        DataGridViewFornecedores.RowTemplate.Height = 29
        DataGridViewFornecedores.Size = New Size(994, 238)
        DataGridViewFornecedores.TabIndex = 112
        ' 
        ' BtnLimpar
        ' 
        BtnLimpar.BackColor = Color.Maroon
        BtnLimpar.FlatStyle = FlatStyle.Flat
        BtnLimpar.Font = New Font("Century Gothic", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnLimpar.ForeColor = Color.Snow
        BtnLimpar.Location = New Point(1082, 303)
        BtnLimpar.Margin = New Padding(3, 2, 3, 2)
        BtnLimpar.Name = "BtnLimpar"
        BtnLimpar.Size = New Size(82, 27)
        BtnLimpar.TabIndex = 111
        BtnLimpar.Text = "Limpar"
        BtnLimpar.UseVisualStyleBackColor = False
        ' 
        ' BtnDeleta
        ' 
        BtnDeleta.BackColor = Color.Maroon
        BtnDeleta.FlatStyle = FlatStyle.Flat
        BtnDeleta.Font = New Font("Century Gothic", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnDeleta.ForeColor = Color.Snow
        BtnDeleta.Location = New Point(1200, 303)
        BtnDeleta.Margin = New Padding(3, 2, 3, 2)
        BtnDeleta.Name = "BtnDeleta"
        BtnDeleta.Size = New Size(88, 27)
        BtnDeleta.TabIndex = 110
        BtnDeleta.Text = "Deletar"
        BtnDeleta.UseVisualStyleBackColor = False
        ' 
        ' BtnEdita
        ' 
        BtnEdita.BackColor = Color.Maroon
        BtnEdita.FlatStyle = FlatStyle.Flat
        BtnEdita.Font = New Font("Century Gothic", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnEdita.ForeColor = Color.Snow
        BtnEdita.Location = New Point(978, 303)
        BtnEdita.Margin = New Padding(3, 2, 3, 2)
        BtnEdita.Name = "BtnEdita"
        BtnEdita.Size = New Size(75, 27)
        BtnEdita.TabIndex = 109
        BtnEdita.Text = "Editar"
        BtnEdita.UseVisualStyleBackColor = False
        ' 
        ' BtnAdicionar
        ' 
        BtnAdicionar.BackColor = Color.Maroon
        BtnAdicionar.FlatStyle = FlatStyle.Flat
        BtnAdicionar.Font = New Font("Century Gothic", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnAdicionar.ForeColor = Color.Snow
        BtnAdicionar.Location = New Point(842, 303)
        BtnAdicionar.Margin = New Padding(3, 2, 3, 2)
        BtnAdicionar.Name = "BtnAdicionar"
        BtnAdicionar.Size = New Size(105, 27)
        BtnAdicionar.TabIndex = 108
        BtnAdicionar.Text = "Adicionar"
        BtnAdicionar.UseVisualStyleBackColor = False
        ' 
        ' ComboBoxFormaPagamento
        ' 
        ComboBoxFormaPagamento.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBoxFormaPagamento.FormattingEnabled = True
        ComboBoxFormaPagamento.Location = New Point(379, 284)
        ComboBoxFormaPagamento.Margin = New Padding(3, 2, 3, 2)
        ComboBoxFormaPagamento.Name = "ComboBoxFormaPagamento"
        ComboBoxFormaPagamento.Size = New Size(165, 27)
        ComboBoxFormaPagamento.TabIndex = 107
        ' 
        ' TextBoxEmpresa
        ' 
        TextBoxEmpresa.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxEmpresa.Location = New Point(379, 91)
        TextBoxEmpresa.Margin = New Padding(3, 2, 3, 2)
        TextBoxEmpresa.Name = "TextBoxEmpresa"
        TextBoxEmpresa.Size = New Size(510, 27)
        TextBoxEmpresa.TabIndex = 106
        ' 
        ' TextBoxMorada
        ' 
        TextBoxMorada.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxMorada.Location = New Point(379, 120)
        TextBoxMorada.Margin = New Padding(3, 2, 3, 2)
        TextBoxMorada.Multiline = True
        TextBoxMorada.Name = "TextBoxMorada"
        TextBoxMorada.Size = New Size(510, 72)
        TextBoxMorada.TabIndex = 105
        ' 
        ' lblPagamento
        ' 
        lblPagamento.AutoSize = True
        lblPagamento.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblPagamento.Location = New Point(247, 290)
        lblPagamento.Name = "lblPagamento"
        lblPagamento.Size = New Size(109, 19)
        lblPagamento.TabIndex = 104
        lblPagamento.Text = "Pagamento: "
        ' 
        ' ComboBoxTipoFornecedor
        ' 
        ComboBoxTipoFornecedor.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBoxTipoFornecedor.FormattingEnabled = True
        ComboBoxTipoFornecedor.Location = New Point(1123, 92)
        ComboBoxTipoFornecedor.Margin = New Padding(3, 2, 3, 2)
        ComboBoxTipoFornecedor.Name = "ComboBoxTipoFornecedor"
        ComboBoxTipoFornecedor.Size = New Size(165, 27)
        ComboBoxTipoFornecedor.TabIndex = 103
        ' 
        ' TextBoxContacto
        ' 
        TextBoxContacto.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxContacto.Location = New Point(466, 311)
        TextBoxContacto.Margin = New Padding(3, 2, 3, 2)
        TextBoxContacto.Name = "TextBoxContacto"
        TextBoxContacto.Size = New Size(202, 27)
        TextBoxContacto.TabIndex = 102
        ' 
        ' TextBoxEmail
        ' 
        TextBoxEmail.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxEmail.Location = New Point(379, 256)
        TextBoxEmail.Margin = New Padding(3, 2, 3, 2)
        TextBoxEmail.Name = "TextBoxEmail"
        TextBoxEmail.Size = New Size(510, 27)
        TextBoxEmail.TabIndex = 101
        ' 
        ' TextBoxIBAN
        ' 
        TextBoxIBAN.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxIBAN.Location = New Point(379, 197)
        TextBoxIBAN.Margin = New Padding(3, 2, 3, 2)
        TextBoxIBAN.Name = "TextBoxIBAN"
        TextBoxIBAN.Size = New Size(510, 27)
        TextBoxIBAN.TabIndex = 100
        ' 
        ' TextBoxNIF
        ' 
        TextBoxNIF.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxNIF.Location = New Point(379, 228)
        TextBoxNIF.Margin = New Padding(3, 2, 3, 2)
        TextBoxNIF.Name = "TextBoxNIF"
        TextBoxNIF.Size = New Size(510, 27)
        TextBoxNIF.TabIndex = 99
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblEmail.Location = New Point(305, 263)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(56, 19)
        lblEmail.TabIndex = 98
        lblEmail.Text = "Email:"
        ' 
        ' lblNIF
        ' 
        lblNIF.AutoSize = True
        lblNIF.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblNIF.Location = New Point(324, 228)
        lblNIF.Name = "lblNIF"
        lblNIF.Size = New Size(37, 19)
        lblNIF.TabIndex = 97
        lblNIF.Text = "NIF:"
        ' 
        ' lblContacto
        ' 
        lblContacto.AutoSize = True
        lblContacto.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblContacto.Location = New Point(270, 318)
        lblContacto.Name = "lblContacto"
        lblContacto.Size = New Size(84, 19)
        lblContacto.TabIndex = 96
        lblContacto.Text = "Contacto:"
        ' 
        ' lblTipoFornecedor
        ' 
        lblTipoFornecedor.AutoSize = True
        lblTipoFornecedor.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblTipoFornecedor.Location = New Point(938, 98)
        lblTipoFornecedor.Name = "lblTipoFornecedor"
        lblTipoFornecedor.Size = New Size(163, 19)
        lblTipoFornecedor.TabIndex = 95
        lblTipoFornecedor.Text = "Tipo de Fornecedor:"
        ' 
        ' lblIBAN
        ' 
        lblIBAN.AutoSize = True
        lblIBAN.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblIBAN.Location = New Point(309, 204)
        lblIBAN.Name = "lblIBAN"
        lblIBAN.Size = New Size(50, 19)
        lblIBAN.TabIndex = 94
        lblIBAN.Text = "IBAN:"
        ' 
        ' lblMorada
        ' 
        lblMorada.AutoSize = True
        lblMorada.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblMorada.Location = New Point(293, 122)
        lblMorada.Name = "lblMorada"
        lblMorada.Size = New Size(75, 19)
        lblMorada.TabIndex = 93
        lblMorada.Text = "Morada:"
        ' 
        ' lblNome
        ' 
        lblNome.AutoSize = True
        lblNome.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblNome.Location = New Point(293, 92)
        lblNome.Name = "lblNome"
        lblNome.Size = New Size(61, 19)
        lblNome.TabIndex = 92
        lblNome.Text = "Nome:"
        ' 
        ' lblIdForn2
        ' 
        lblIdForn2.AutoSize = True
        lblIdForn2.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblIdForn2.ForeColor = Color.Red
        lblIdForn2.Location = New Point(538, 61)
        lblIdForn2.Name = "lblIdForn2"
        lblIdForn2.Size = New Size(18, 23)
        lblIdForn2.TabIndex = 116
        lblIdForn2.Text = "*"
        lblIdForn2.Visible = False
        ' 
        ' lblNome2
        ' 
        lblNome2.AutoSize = True
        lblNome2.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblNome2.ForeColor = Color.Red
        lblNome2.Location = New Point(893, 89)
        lblNome2.Name = "lblNome2"
        lblNome2.Size = New Size(18, 23)
        lblNome2.TabIndex = 117
        lblNome2.Text = "*"
        lblNome2.Visible = False
        ' 
        ' lblMorada2
        ' 
        lblMorada2.AutoSize = True
        lblMorada2.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblMorada2.ForeColor = Color.Red
        lblMorada2.Location = New Point(893, 119)
        lblMorada2.Name = "lblMorada2"
        lblMorada2.Size = New Size(18, 23)
        lblMorada2.TabIndex = 118
        lblMorada2.Text = "*"
        lblMorada2.Visible = False
        ' 
        ' lblPagamento2
        ' 
        lblPagamento2.AutoSize = True
        lblPagamento2.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblPagamento2.ForeColor = Color.Red
        lblPagamento2.Location = New Point(538, 280)
        lblPagamento2.Name = "lblPagamento2"
        lblPagamento2.Size = New Size(18, 23)
        lblPagamento2.TabIndex = 124
        lblPagamento2.Text = "*"
        lblPagamento2.Visible = False
        ' 
        ' lblContacto2
        ' 
        lblContacto2.AutoSize = True
        lblContacto2.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblContacto2.ForeColor = Color.Red
        lblContacto2.Location = New Point(662, 304)
        lblContacto2.Name = "lblContacto2"
        lblContacto2.Size = New Size(18, 23)
        lblContacto2.TabIndex = 122
        lblContacto2.Text = "*"
        lblContacto2.Visible = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 5000
        ' 
        ' FornecedorForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1312, 600)
        Controls.Add(DateTimePickerDataEntrega)
        Controls.Add(DateTimePickerCadastro)
        Controls.Add(TextBoxObservacoes)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(lblTipoFornecedor2)
        Controls.Add(lblEmail2)
        Controls.Add(lblNif2)
        Controls.Add(lblIban2)
        Controls.Add(Label1)
        Controls.Add(TextBoxIdFornecedor)
        Controls.Add(lblIdFornecedor)
        Controls.Add(DataGridViewFornecedores)
        Controls.Add(BtnLimpar)
        Controls.Add(BtnDeleta)
        Controls.Add(BtnEdita)
        Controls.Add(BtnAdicionar)
        Controls.Add(ComboBoxFormaPagamento)
        Controls.Add(TextBoxEmpresa)
        Controls.Add(TextBoxMorada)
        Controls.Add(lblPagamento)
        Controls.Add(ComboBoxTipoFornecedor)
        Controls.Add(TextBoxContacto)
        Controls.Add(TextBoxEmail)
        Controls.Add(TextBoxIBAN)
        Controls.Add(TextBoxNIF)
        Controls.Add(lblEmail)
        Controls.Add(lblNIF)
        Controls.Add(lblContacto)
        Controls.Add(lblTipoFornecedor)
        Controls.Add(lblIBAN)
        Controls.Add(lblMorada)
        Controls.Add(lblNome)
        Controls.Add(lblIdForn2)
        Controls.Add(lblNome2)
        Controls.Add(lblMorada2)
        Controls.Add(lblPagamento2)
        Controls.Add(lblContacto2)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "FornecedorForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FornecedorForm"
        Panel2.ResumeLayout(False)
        GroupBoxPesquisa.ResumeLayout(False)
        GroupBoxPesquisa.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridViewFornecedores, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBoxPesquisa As GroupBox
    Friend WithEvents ComboBoxTipoPesquisa As ComboBox
    Friend WithEvents lblPesquisar As Label
    Friend WithEvents TextBoxPesquisa As TextBox
    Friend WithEvents BtnFechar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lbl_time As Label
    Friend WithEvents Lbl_Data As Label
    Friend WithEvents Lbl_User As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePickerDataEntrega As DateTimePicker
    Friend WithEvents DateTimePickerCadastro As DateTimePicker
    Friend WithEvents TextBoxObservacoes As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTipoFornecedor2 As Label
    Friend WithEvents lblEmail2 As Label
    Friend WithEvents lblNif2 As Label
    Friend WithEvents lblIban2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxIdFornecedor As TextBox
    Friend WithEvents lblIdFornecedor As Label
    Friend WithEvents DataGridViewFornecedores As DataGridView
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnDeleta As Button
    Friend WithEvents BtnEdita As Button
    Friend WithEvents BtnAdicionar As Button
    Friend WithEvents ComboBoxFormaPagamento As ComboBox
    Friend WithEvents TextBoxEmpresa As TextBox
    Friend WithEvents TextBoxMorada As TextBox
    Friend WithEvents lblPagamento As Label
    Friend WithEvents ComboBoxTipoFornecedor As ComboBox
    Friend WithEvents TextBoxContacto As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxIBAN As TextBox
    Friend WithEvents TextBoxNIF As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblNIF As Label
    Friend WithEvents lblContacto As Label
    Friend WithEvents lblTipoFornecedor As Label
    Friend WithEvents lblIBAN As Label
    Friend WithEvents lblMorada As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents lblIdForn2 As Label
    Friend WithEvents lblNome2 As Label
    Friend WithEvents lblMorada2 As Label
    Friend WithEvents lblPagamento2 As Label
    Friend WithEvents lblContacto2 As Label
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
    Friend WithEvents Timer1 As Timer
End Class
