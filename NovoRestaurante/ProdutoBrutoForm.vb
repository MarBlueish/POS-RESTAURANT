Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class ProdutoBrutoForm

    Private conn As MySqlConnection

    Private Sub GerenciarBebidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Quando o formulário é carregado, atualize a lista de produtos brutos.
        AtualizarListaProdutosBrutos()
    End Sub

    Private Sub LimparCampos()
        TextBoxProduto.Clear()
        TextBoxDataValidade.Clear()
        TextBoxNumSerie.Clear()
        TextBoxPrecoCompra.Clear()
        TextBoxPrecoVenda.Clear()
        TextBoxIdProduto.Clear()
    End Sub

    Private Sub AtualizarListaProdutosBrutos()
        ' Método para atualizar a lista de produtos brutos no DataGridView.

        ' Conexão com o banco de dados MySQL.
        conn = New MySqlConnection("Server=127.0.0.1;User=root;Password=;Database=restaurante1")

        Try
            conn.Open()

            ' Consulta SQL para selecionar todos os produtos brutos na tabela Produto_Bruto.
            Dim sql As String = "SELECT * FROM Produto_Bruto"
            Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            Dim builder As MySqlCommandBuilder = New MySqlCommandBuilder(adapter)
            Dim dataSet As DataSet = New DataSet()
            adapter.Fill(dataSet)

            ' Define o resultado da consulta como a fonte de dados para o DataGridView.
            DataGridViewProdutosBrutos.DataSource = dataSet.Tables(0)
        Catch ex As Exception
            ' Em caso de erro, exiba uma mensagem de erro.
            MsgBox(ex.Message)
        Finally
            ' Certifique-se de fechar a conexão com o banco de dados.
            conn.Close()
        End Try
    End Sub

    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click
        ' Manipulador de evento para o botão "Adicionar".

        ' Verificar se a data é válida antes de inseri-la no banco de dados.
        Dim dataValidade As DateTime

        If DateTime.TryParseExact(TextBoxDataValidade.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, dataValidade) Then
            ' O valor foi convertido com sucesso para um DateTime no formato esperado.

            ' Conexão com o banco de dados MySQL.
            conn = New MySqlConnection("Server=127.0.0.1;User=root;Password=;Database=restaurante1")

            Try
                conn.Open()

                ' Consulta SQL para obter o próximo ID disponível na tabela Produto_Bruto.
                Dim queryNextId As String = "SELECT COALESCE(MAX(ID_Produto), 0) + 1 FROM Produto_Bruto"
                Dim cmdNextId As MySqlCommand = New MySqlCommand(queryNextId, conn)

                ' Obter o próximo ID.
                Dim nextId As Integer = Convert.ToInt32(cmdNextId.ExecuteScalar())

                ' Consulta SQL para inserir um novo produto na tabela Produto_Bruto.
                Dim query As String = "INSERT INTO Produto_Bruto (ID_Produto, Nome_Produto, Data_Validade, Nmr_Serie, Preco_Compra, Preco_Venda) VALUES (@ID, @NomeProduto, @DataValidade, @NmrSerie, @PrecoCompra, @PrecoVenda)"
                Dim cmd As MySqlCommand = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", nextId)
                cmd.Parameters.AddWithValue("@NomeProduto", TextBoxProduto.Text)
                cmd.Parameters.AddWithValue("@DataValidade", dataValidade) ' Use a data convertida.
                cmd.Parameters.AddWithValue("@NmrSerie", TextBoxNumSerie.Text)
                cmd.Parameters.AddWithValue("@PrecoCompra", Decimal.Parse(TextBoxPrecoCompra.Text))
                cmd.Parameters.AddWithValue("@PrecoVenda", Decimal.Parse(TextBoxPrecoVenda.Text))

                ' Executar a consulta SQL para adicionar o produto.
                cmd.ExecuteNonQuery()

                ' Exibir mensagem de sucesso.
                MsgBox("Produto adicionado com sucesso.")

                ' Limpar campos e atualizar a lista de produtos brutos.
                LimparCampos()
                AtualizarListaProdutosBrutos()
            Catch ex As Exception
                ' Em caso de erro, exiba uma mensagem de erro.
                MsgBox(ex.Message)
            Finally
                ' Certifique-se de fechar a conexão com o banco de dados.
                conn.Close()
            End Try
        Else
            ' Exiba uma mensagem de erro ao usuário, pois a data não pôde ser convertida.
            MessageBox.Show("Data de validade inválida. Use o formato yyyy-MM-dd.", "Erro de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxDataValidade.Focus() ' Coloca o foco de volta no TextBoxDataValidade.
            TextBoxDataValidade.SelectAll() ' Seleciona todo o texto no TextBoxDataValidade.
        End If
    End Sub

    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles BtnAbout.Click

        AboutBox1.Show()
    End Sub

    Private Sub BtnFornecedor_Click(sender As Object, e As EventArgs) Handles BtnFornecedor.Click
        Me.Hide()
        FornecedorForm.Show()
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
    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        End
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Close()
        LoginForm1.Show()
    End Sub
End Class