<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MesasForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MesasForm))
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
        lblStatusMesaP = New Label()
        lblQntLugMesaP = New Label()
        lblNumMesaP = New Label()
        lblIdMesaP = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        TextBoxMesaID = New TextBox()
        Label1 = New Label()
        DataGridViewMesas = New DataGridView()
        BtnLimpar = New Button()
        BtnDeletar = New Button()
        BtnEditar = New Button()
        BtnAdicionar = New Button()
        ComboBoxStatus = New ComboBox()
        lblStatus = New Label()
        TextBoxMesaNumero = New TextBox()
        lblNumero = New Label()
        Ementa = New Button()
        Panel2.SuspendLayout()
        GroupBoxPesquisa.SuspendLayout()
        Panel1.SuspendLayout()
        CType(DataGridViewMesas, ComponentModel.ISupportInitialize).BeginInit()
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
        GroupBoxPesquisa.TabIndex = 34
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
        BtnFechar.TabIndex = 34
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
        BtnLogout.Location = New Point(17, 472)
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
        BtnRecuperarSenha.Location = New Point(17, 319)
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
        BtnUsuarios.Location = New Point(17, 394)
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
        BtnAbout.Location = New Point(17, 77)
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
        BtnMesas.Location = New Point(17, 181)
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
        BtnProdutoBruto.Location = New Point(17, 284)
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
        BtnFornecedor.Location = New Point(17, 112)
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
        BtnPratos.Location = New Point(17, 146)
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
        BtnStock.Location = New Point(17, 351)
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
        BtnPagamento.Location = New Point(17, 215)
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
        BtnPedidosDelivery.Location = New Point(17, 250)
        BtnPedidosDelivery.Margin = New Padding(3, 2, 3, 2)
        BtnPedidosDelivery.Name = "BtnPedidosDelivery"
        BtnPedidosDelivery.Size = New Size(197, 28)
        BtnPedidosDelivery.TabIndex = 119
        BtnPedidosDelivery.Text = "Pedidos Delivery"
        BtnPedidosDelivery.UseVisualStyleBackColor = False
        ' 
        ' lblStatusMesaP
        ' 
        lblStatusMesaP.AutoSize = True
        lblStatusMesaP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblStatusMesaP.ForeColor = Color.Red
        lblStatusMesaP.Location = New Point(613, 228)
        lblStatusMesaP.Name = "lblStatusMesaP"
        lblStatusMesaP.Size = New Size(18, 23)
        lblStatusMesaP.TabIndex = 93
        lblStatusMesaP.Text = "*"
        lblStatusMesaP.Visible = False
        ' 
        ' lblQntLugMesaP
        ' 
        lblQntLugMesaP.AutoSize = True
        lblQntLugMesaP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblQntLugMesaP.ForeColor = Color.Red
        lblQntLugMesaP.Location = New Point(613, 194)
        lblQntLugMesaP.Name = "lblQntLugMesaP"
        lblQntLugMesaP.Size = New Size(18, 23)
        lblQntLugMesaP.TabIndex = 92
        lblQntLugMesaP.Text = "*"
        lblQntLugMesaP.Visible = False
        ' 
        ' lblNumMesaP
        ' 
        lblNumMesaP.AutoSize = True
        lblNumMesaP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblNumMesaP.ForeColor = Color.Red
        lblNumMesaP.Location = New Point(613, 150)
        lblNumMesaP.Name = "lblNumMesaP"
        lblNumMesaP.Size = New Size(18, 23)
        lblNumMesaP.TabIndex = 91
        lblNumMesaP.Text = "*"
        lblNumMesaP.Visible = False
        ' 
        ' lblIdMesaP
        ' 
        lblIdMesaP.AutoSize = True
        lblIdMesaP.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblIdMesaP.ForeColor = Color.Red
        lblIdMesaP.Location = New Point(613, 110)
        lblIdMesaP.Name = "lblIdMesaP"
        lblIdMesaP.Size = New Size(18, 23)
        lblIdMesaP.TabIndex = 90
        lblIdMesaP.Text = "*"
        lblIdMesaP.Visible = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(476, 198)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(133, 27)
        TextBox1.TabIndex = 89
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(276, 205)
        Label2.Name = "Label2"
        Label2.Size = New Size(172, 19)
        Label2.TabIndex = 88
        Label2.Text = "Quantidade Lugares:"
        ' 
        ' TextBoxMesaID
        ' 
        TextBoxMesaID.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxMesaID.Location = New Point(476, 118)
        TextBoxMesaID.Margin = New Padding(3, 2, 3, 2)
        TextBoxMesaID.Name = "TextBoxMesaID"
        TextBoxMesaID.Size = New Size(133, 27)
        TextBoxMesaID.TabIndex = 87
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(385, 120)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 19)
        Label1.TabIndex = 86
        Label1.Text = "MesaID:"
        ' 
        ' DataGridViewMesas
        ' 
        DataGridViewMesas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewMesas.Location = New Point(303, 362)
        DataGridViewMesas.Margin = New Padding(3, 2, 3, 2)
        DataGridViewMesas.Name = "DataGridViewMesas"
        DataGridViewMesas.RowHeadersWidth = 51
        DataGridViewMesas.RowTemplate.Height = 29
        DataGridViewMesas.Size = New Size(937, 218)
        DataGridViewMesas.TabIndex = 85
        ' 
        ' BtnLimpar
        ' 
        BtnLimpar.BackColor = Color.Maroon
        BtnLimpar.FlatStyle = FlatStyle.Flat
        BtnLimpar.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnLimpar.ForeColor = Color.Snow
        BtnLimpar.Location = New Point(994, 183)
        BtnLimpar.Margin = New Padding(3, 2, 3, 2)
        BtnLimpar.Name = "BtnLimpar"
        BtnLimpar.Size = New Size(90, 39)
        BtnLimpar.TabIndex = 84
        BtnLimpar.Text = "Limpar"
        BtnLimpar.UseVisualStyleBackColor = False
        ' 
        ' BtnDeletar
        ' 
        BtnDeletar.BackColor = Color.Maroon
        BtnDeletar.FlatStyle = FlatStyle.Flat
        BtnDeletar.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnDeletar.ForeColor = Color.Snow
        BtnDeletar.Location = New Point(1143, 183)
        BtnDeletar.Margin = New Padding(3, 2, 3, 2)
        BtnDeletar.Name = "BtnDeletar"
        BtnDeletar.Size = New Size(93, 39)
        BtnDeletar.TabIndex = 83
        BtnDeletar.Text = "Deletar"
        BtnDeletar.UseVisualStyleBackColor = False
        ' 
        ' BtnEditar
        ' 
        BtnEditar.BackColor = Color.Maroon
        BtnEditar.FlatStyle = FlatStyle.Flat
        BtnEditar.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnEditar.ForeColor = Color.Snow
        BtnEditar.Location = New Point(891, 183)
        BtnEditar.Margin = New Padding(3, 2, 3, 2)
        BtnEditar.Name = "BtnEditar"
        BtnEditar.Size = New Size(75, 39)
        BtnEditar.TabIndex = 82
        BtnEditar.Text = "Editar"
        BtnEditar.UseVisualStyleBackColor = False
        ' 
        ' BtnAdicionar
        ' 
        BtnAdicionar.BackColor = Color.Maroon
        BtnAdicionar.FlatStyle = FlatStyle.Flat
        BtnAdicionar.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BtnAdicionar.ForeColor = Color.Snow
        BtnAdicionar.Location = New Point(754, 183)
        BtnAdicionar.Margin = New Padding(3, 2, 3, 2)
        BtnAdicionar.Name = "BtnAdicionar"
        BtnAdicionar.Size = New Size(117, 39)
        BtnAdicionar.TabIndex = 81
        BtnAdicionar.Text = "Adicionar"
        BtnAdicionar.UseVisualStyleBackColor = False
        ' 
        ' ComboBoxStatus
        ' 
        ComboBoxStatus.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBoxStatus.FormattingEnabled = True
        ComboBoxStatus.Location = New Point(476, 235)
        ComboBoxStatus.Margin = New Padding(3, 2, 3, 2)
        ComboBoxStatus.Name = "ComboBoxStatus"
        ComboBoxStatus.Size = New Size(133, 27)
        ComboBoxStatus.TabIndex = 80
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblStatus.Location = New Point(400, 241)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(56, 19)
        lblStatus.TabIndex = 79
        lblStatus.Text = "Status:"
        ' 
        ' TextBoxMesaNumero
        ' 
        TextBoxMesaNumero.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxMesaNumero.Location = New Point(476, 159)
        TextBoxMesaNumero.Margin = New Padding(3, 2, 3, 2)
        TextBoxMesaNumero.Name = "TextBoxMesaNumero"
        TextBoxMesaNumero.Size = New Size(133, 27)
        TextBoxMesaNumero.TabIndex = 78
        ' 
        ' lblNumero
        ' 
        lblNumero.AutoSize = True
        lblNumero.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblNumero.Location = New Point(329, 166)
        lblNumero.Name = "lblNumero"
        lblNumero.Size = New Size(121, 19)
        lblNumero.TabIndex = 77
        lblNumero.Text = "Mesa Número:"
        ' 
        ' Ementa
        ' 
        Ementa.BackColor = Color.Maroon
        Ementa.FlatStyle = FlatStyle.Flat
        Ementa.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Ementa.ForeColor = Color.Snow
        Ementa.Location = New Point(891, 308)
        Ementa.Margin = New Padding(3, 2, 3, 2)
        Ementa.Name = "Ementa"
        Ementa.Size = New Size(117, 39)
        Ementa.TabIndex = 94
        Ementa.Text = "Ementa"
        Ementa.UseVisualStyleBackColor = False
        ' 
        ' MesasForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1312, 600)
        Controls.Add(Ementa)
        Controls.Add(lblStatusMesaP)
        Controls.Add(lblQntLugMesaP)
        Controls.Add(lblNumMesaP)
        Controls.Add(lblIdMesaP)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(TextBoxMesaID)
        Controls.Add(Label1)
        Controls.Add(DataGridViewMesas)
        Controls.Add(BtnLimpar)
        Controls.Add(BtnDeletar)
        Controls.Add(BtnEditar)
        Controls.Add(BtnAdicionar)
        Controls.Add(ComboBoxStatus)
        Controls.Add(lblStatus)
        Controls.Add(TextBoxMesaNumero)
        Controls.Add(lblNumero)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "MesasForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MesasForm"
        Panel2.ResumeLayout(False)
        GroupBoxPesquisa.ResumeLayout(False)
        GroupBoxPesquisa.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridViewMesas, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblStatusMesaP As Label
    Friend WithEvents lblQntLugMesaP As Label
    Friend WithEvents lblNumMesaP As Label
    Friend WithEvents lblIdMesaP As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxMesaID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewMesas As DataGridView
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnDeletar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnAdicionar As Button
    Friend WithEvents ComboBoxStatus As ComboBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents TextBoxMesaNumero As TextBox
    Friend WithEvents lblNumero As Label
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
    Friend WithEvents Ementa As Button
End Class
