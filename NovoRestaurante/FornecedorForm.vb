Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Linq
Public Class FornecedorForm
    ' Function to close PratosForm if it is open
    Private Sub ClosePratosForm()
        ' Check if there are any open forms of type PratosForm
        Dim openPratosForms = Application.OpenForms.OfType(Of PratosForm)()

        ' If there is at least one open PratosForm, close it
        If openPratosForms.Any() Then
            Dim pratosFormToClose As PratosForm = openPratosForms.First()
            pratosFormToClose.Close()
        End If
    End Sub

    Dim conn As MySqlConnection

    ' Método executado quando o formulário é carregado
    Private Sub GerenciarFornecedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Preenche a DataGridView com os fornecedores do banco de dados
        PreencherFornecedores()

        ' Preenche o ComboBox de Tipo de Fornecedor
        PreencherComboBoxTipoFornecedor()

        ' Preenche o ComboBox de Forma de Pagamento
        PreencherComboBoxPagamento()

        ' Preenche o ComboBox de Tipo de Pesquisa
        PreencherComboBoxTipoPesquisa()

        ' Oculta as labels de campos vazios
        EsconderLabelsCamposVazios()
    End Sub

    ' Preenche a DataGridView com os fornecedores do banco de dados
    Private Sub PreencherFornecedores()
        ' Inicializa a conexão com o banco de dados
        conn = New MySqlConnection("Server=127.0.0.1;User=root;Password=;Database=restaurante1")

        Try
            ' Abre a conexão com o banco de dados
            conn.Open()

            ' Consulta SQL para selecionar todos os fornecedores
            Dim sql As String = "SELECT * FROM fornecedor"
            Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            Dim ds As DataSet = New DataSet()

            ' Preenche o DataSet com os dados da tabela fornecedor
            adapter.Fill(ds, "fornecedor")

            ' Define a fonte de dados da DataGridView como o DataSet
            DataGridViewFornecedores.DataSource = ds.Tables("fornecedor")
        Catch ex As Exception
            ' Exibe uma mensagem de erro em caso de falha
            MsgBox(ex.Message)
        Finally
            ' Fecha a conexão com o banco de dados
            conn.Close()
        End Try
    End Sub

    ' Adiciona um novo fornecedor
    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click
        ' Obtém os valores dos campos
        Dim nomeFornecedor As String = TextBoxEmpresa.Text
        Dim morada As String = TextBoxMorada.Text
        Dim iban As String = TextBoxIBAN.Text
        Dim nif As String = TextBoxNIF.Text
        Dim formaPagamento As String = ComboBoxFormaPagamento.Text
        Dim contacto As String = TextBoxContacto.Text
        Dim tipoFornecedor As String = ComboBoxTipoFornecedor.Text
        Dim dataEntrega As String = DateTimePickerDataEntrega.Value.ToString("yyyy-MM-dd HH:mm:ss")
        Dim email As String = TextBoxEmail.Text
        Dim dataCadastro As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        Dim observacoes As String = TextBoxObservacoes.Text

        ' Inicializa a conexão com o banco de dados
        conn = New MySqlConnection("Server=127.0.0.1;User=root;Password=;Database=restaurante1")

        Try
            ' Abre a conexão com o banco de dados
            conn.Open()

            ' Query SQL para adicionar o fornecedor
            Dim sql As String = "INSERT INTO fornecedor (Empresa_FORNECEDOR, Morada_FORNECEDOR, IBAN_FORNECEDOR, NIF_FORNECEDOR, FORMA_PAGAMENTO, CONTACTO_FORNECEDOR, TIPO_FORNECEDOR, DATA_ENTREGA, EMAIL_FORNECEDOR, DATA_CADASTRO, OBSERVACOES) VALUES (@empresa, @morada, @iban, @nif, @formaPagamento, @contacto, @tipoFornecedor, @dataEntrega, @email, @dataCadastro, @observacoes)"
            Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@empresa", nomeFornecedor)
            cmd.Parameters.AddWithValue("@morada", morada)
            cmd.Parameters.AddWithValue("@iban", iban)
            cmd.Parameters.AddWithValue("@nif", nif)
            cmd.Parameters.AddWithValue("@formaPagamento", formaPagamento)
            cmd.Parameters.AddWithValue("@contacto", contacto)
            cmd.Parameters.AddWithValue("@tipoFornecedor", tipoFornecedor)
            cmd.Parameters.AddWithValue("@dataEntrega", dataEntrega)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@dataCadastro", dataCadastro)
            cmd.Parameters.AddWithValue("@observacoes", observacoes)

            ' Executa a consulta SQL
            cmd.ExecuteNonQuery()

            ' Limpa os campos após adicionar o fornecedor
            LimparCampos()

            ' Atualiza a DataGridView com os fornecedores
            PreencherFornecedores()
        Catch ex As Exception
            ' Exibe uma mensagem de erro em caso de falha
            MsgBox(ex.Message)
        Finally
            ' Fecha a conexão com o banco de dados
            conn.Close()
        End Try
    End Sub

    ' Método que lida com a mudança de texto no TextBoxPesquisa
    Private Sub TextBoxPesquisa_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPesquisa.TextChanged
        ' Verifica se a TextBoxPesquisa está vazia
        If String.IsNullOrWhiteSpace(TextBoxPesquisa.Text) Then
            ' Se estiver vazia, preenche novamente a lista de fornecedores
            PreencherFornecedores()
        Else
            ' Caso contrário, realiza a pesquisa
            PesquisarFornecedores(TextBoxPesquisa.Text)
        End If
    End Sub

    ' Realiza a pesquisa de fornecedores com base no texto de pesquisa
    Private Sub PesquisarFornecedores(textoPesquisa As String)
        ' Inicializa a conexão com o banco de dados
        conn = New MySqlConnection("Server=127.0.0.1;User=root;Password=;Database=restaurante1")

        Try
            ' Abre a conexão com o banco de dados
            conn.Open()

            ' Consulta SQL parametrizada para pesquisar fornecedores por diferentes campos
            Dim sql As String = "SELECT * FROM fornecedor WHERE Empresa_FORNECEDOR LIKE @textoPesquisa OR Morada_FORNECEDOR LIKE @textoPesquisa OR IBAN_FORNECEDOR LIKE @textoPesquisa OR NIF_FORNECEDOR LIKE @textoPesquisa OR TIPO_FORNECEDOR LIKE @textoPesquisa OR EMAIL_FORNECEDOR LIKE @textoPesquisa OR OBSERVACOES LIKE @textoPesquisa"
            Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            adapter.SelectCommand.Parameters.AddWithValue("@textoPesquisa", "%" & textoPesquisa & "%")
            Dim ds As DataSet = New DataSet()

            ' Preenche o conjunto de dados com os resultados da consulta
            adapter.Fill(ds, "fornecedor")

            ' Exibe os fornecedores no DataGridView
            DataGridViewFornecedores.DataSource = ds.Tables("fornecedor")
        Catch ex As Exception
            ' Exibe mensagem de erro caso ocorra
            MsgBox(ex.Message)
        Finally
            ' Fecha a conexão com o banco de dados
            conn.Close()
        End Try
    End Sub

    ' Verifica campos vazios e exibe as labels correspondentes
    Private Function VerificarCamposVazios() As Boolean
        Dim camposVazios As Boolean = False

        If String.IsNullOrEmpty(TextBoxEmpresa.Text) Then
            lblNome2.Visible = True
            camposVazios = True
        End If

        If String.IsNullOrEmpty(TextBoxMorada.Text) Then
            lblMorada2.Visible = True
            camposVazios = True
        End If

        If String.IsNullOrEmpty(TextBoxIBAN.Text) Then
            lblIban2.Visible = True
            camposVazios = True
        End If

        If String.IsNullOrEmpty(TextBoxNIF.Text) Then
            lblNif2.Visible = True
            camposVazios = True
        End If

        If String.IsNullOrEmpty(TextBoxEmail.Text) Then
            lblEmail2.Visible = True
            camposVazios = True
        End If

        ' Adicione mais verificações de campos vazios conforme necessário

        Return camposVazios
    End Function

    ' Limpa os campos e oculta as labels
    Private Sub LimparCampos()
        TextBoxIdFornecedor.Clear()
        TextBoxEmpresa.Clear()
        TextBoxMorada.Clear()
        TextBoxIBAN.Clear()
        TextBoxNIF.Clear()
        ComboBoxFormaPagamento.SelectedIndex = -1
        TextBoxContacto.Clear()
        ComboBoxTipoFornecedor.SelectedIndex = -1
        DateTimePickerDataEntrega.Value = DateTime.Now ' Define o DateTimePicker para a data atual
        TextBoxEmail.Clear()
        DateTimePickerCadastro.Value = DateTime.Now ' Define o DateTimePicker para a data atual
        TextBoxObservacoes.Clear()
        TextBoxPesquisa.Clear()

        ' Ocultar todas as labels de campos vazios
        EsconderLabelsCamposVazios()
    End Sub

    ' Oculta as labels de campos vazios
    Private Sub EsconderLabelsCamposVazios()
        lblNome2.Visible = False
        lblMorada2.Visible = False
        lblIban2.Visible = False
        lblNif2.Visible = False
        lblEmail2.Visible = False

        ' Oculte outras labels de campos vazios conforme necessário
    End Sub

    ' Método chamado quando o botão Limpar é clicado para limpar os campos
    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        LimparCampos()
    End Sub

    ' Preenche o ComboBox de Tipo de Fornecedor
    Private Sub PreencherComboBoxTipoFornecedor()
        ' Limpa e preenche o ComboBoxTipoFornecedor
        ComboBoxTipoFornecedor.Items.Clear()

        ' Adicionando os tipos de fornecedor comuns
        ComboBoxTipoFornecedor.Items.Add("Carnes e Peixes")
        ComboBoxTipoFornecedor.Items.Add("Frutas e Verduras")
        ComboBoxTipoFornecedor.Items.Add("Bebidas")
        ComboBoxTipoFornecedor.Items.Add("Limpeza")
        ComboBoxTipoFornecedor.Items.Add("Arroz e Feijão")
        ComboBoxTipoFornecedor.Items.Add("Pratos e Talheres")
        ComboBoxTipoFornecedor.Items.Add("Farinhas e Derivados")
        ComboBoxTipoFornecedor.Items.Add("Sistema")

        ' ... Adicione mais tipos de fornecedor conforme necessário
    End Sub

    ' Preenche o ComboBox de Forma de Pagamento
    Private Sub PreencherComboBoxPagamento()
        ' Limpa e preenche o ComboBoxFormaPagamento
        ComboBoxFormaPagamento.Items.Clear()

        ' Adicionando formas de pagamento comuns
        ComboBoxFormaPagamento.Items.Add("Dinheiro")
        ComboBoxFormaPagamento.Items.Add("Cartão de Crédito")
        ComboBoxFormaPagamento.Items.Add("Cartão de Débito")
        ComboBoxFormaPagamento.Items.Add("Transferência Bancária")
        ComboBoxFormaPagamento.Items.Add("MBWay")
        ComboBoxFormaPagamento.Items.Add("PayPal")
        ComboBoxFormaPagamento.Items.Add("Revolut")
        ComboBoxFormaPagamento.Items.Add("Apple Pay")

        ' ... Adicione mais formas de pagamento conforme necessário
    End Sub

    ' Preenche o ComboBox de Tipo de Pesquisa
    Private Sub PreencherComboBoxTipoPesquisa()
        ' Limpa e preenche o ComboBoxTipoPesquisa
        ComboBoxTipoPesquisa.Items.Clear()

        ' Adicionando os tipos de pesquisa comuns
        ComboBoxTipoPesquisa.Items.Add("Empresa")
        ComboBoxTipoPesquisa.Items.Add("Morada")
        ComboBoxTipoPesquisa.Items.Add("IBAN")
        ComboBoxTipoPesquisa.Items.Add("NIF")
        ComboBoxTipoPesquisa.Items.Add("Tipo de Fornecedor")
        ComboBoxTipoPesquisa.Items.Add("Email")
        ComboBoxTipoPesquisa.Items.Add("Observações")

        ' ... Adicione mais tipos de pesquisa conforme necessário
    End Sub


    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles BtnAbout.Click

        AboutBox1.Show()
    End Sub

    Private Sub BtnPratos_Click(sender As Object, e As EventArgs) Handles BtnPratos.Click
        Me.Hide()
        HomeForm.Show()
    End Sub

    Private Sub BtnMesas_Click(sender As Object, e As EventArgs) Handles BtnMesas.Click
        Me.Hide()
        MesasForm.Show()
    End Sub

    Private Sub BtnPagamento_Click(sender As Object, e As EventArgs) Handles BtnPagamento.Click
        Me.Hide()
        PagamentoForm.Show()
    End Sub

    Private Sub BtnPedidosDelivery_Click(sender As Object, e As EventArgs) Handles BtnPedidosDelivery.Click
        Me.Hide()
        PedidosDeliveryForm.Show()
    End Sub

    Private Sub BtnProdutoBruto_Click(sender As Object, e As EventArgs) Handles BtnProdutoBruto.Click
        Me.Hide()
        ProdutoBrutoForm.Show()
    End Sub

    Private Sub BtnRecuperarSenha_Click(sender As Object, e As EventArgs) Handles BtnRecuperarSenha.Click
        Me.Hide()
        RecuperarSenhaForm.Show()
    End Sub




    Private Sub BtnStock_Click(sender As Object, e As EventArgs) Handles BtnStock.Click
        Me.Hide()
        StockForm.Show()
    End Sub

    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click
        Me.Hide()
        UsuariosForm.Show()
    End Sub

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs)
        Me.Hide()
        LoginForm1.Show()
    End Sub

    Private Sub BtnFechar_Click_1(sender As Object, e As EventArgs) Handles BtnFechar.Click
        End
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Close()
        LoginForm1.Show()
    End Sub
End Class