Imports MySql.Data.MySqlClient

Public Class StockForm

    Dim conn As MySqlConnection

    Private Sub GerenciarEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Este evento é acionado quando o formulário é carregado.
        PreencherEstoque()
    End Sub

    ' Preenche a DataGridView com os itens do estoque
    Private Sub PreencherEstoque()
        ' Este método preenche a DataGridView com os dados dos itens de estoque do banco de dados.

        ' Conexão com o banco de dados MySQL.
        conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

        Try
            conn.Open()

            ' Consulta SQL para selecionar todos os itens de estoque na tabela Stock.
            Dim sql As String = "SELECT * FROM Stock"
            Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            Dim ds As DataSet = New DataSet()

            ' Preenche o DataSet com os dados dos itens de estoque.
            adapter.Fill(ds, "Stock")

            ' Define o resultado da consulta como a fonte de dados para a DataGridView.
            DataGridViewEstoque.DataSource = ds.Tables("Stock")
        Catch ex As Exception
            ' Em caso de erro, exibe uma mensagem de erro.
            MsgBox(ex.Message)
        Finally
            ' Certifique-se de fechar a conexão com o banco de dados.
            conn.Close()
        End Try
    End Sub

    ' Adiciona um novo item ao estoque
    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click
        ' Manipulador de evento para o botão "Adicionar" que adiciona um novo item ao estoque.

        ' Obtém os valores dos campos do formulário.
        Dim produto As String = TextBoxProduto.Text
        Dim quantidade As Integer = Convert.ToInt32(TextBoxQuantidade.Text)

        ' Você também precisa obter os valores dos campos id_fornecedor e id_usuario, que não estão no seu código.

        ' Conexão com o banco de dados MySQL.
        conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

        Try
            conn.Open()

            ' Query SQL para adicionar o item ao estoque.
            Dim sql As String = "INSERT INTO Stock (Produtos, Quantidade, id_fornecedor, id_usuario) VALUES (@produtos, @quantidade, @id_fornecedor, @id_usuario)"
            Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@produtos", produto)
            cmd.Parameters.AddWithValue("@quantidade", quantidade)
            ' Você também precisa definir os parâmetros para id_fornecedor e id_usuario aqui.

            ' Executa a consulta SQL para adicionar o item ao estoque.
            cmd.ExecuteNonQuery()

            ' Limpa os campos do formulário.
            LimparCampos()

            ' Atualiza a lista de itens de estoque na DataGridView.
            PreencherEstoque()
        Catch ex As Exception
            ' Em caso de erro, exibe uma mensagem de erro.
            MsgBox(ex.Message)
        Finally
            ' Certifique-se de fechar a conexão com o banco de dados.
            conn.Close()
        End Try
    End Sub

    ' Edita um item no estoque
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        ' Manipulador de evento para o botão "Editar" que edita um item no estoque.

        ' Obtém os valores dos campos do formulário.
        Dim id As Integer = Convert.ToInt32(TextBoxIdProduto.Text)
        Dim produto As String = TextBoxProduto.Text
        Dim quantidade As Integer = Convert.ToInt32(TextBoxQuantidade.Text)

        ' Você também precisa obter os valores dos campos id_fornecedor e id_usuario, que não estão no seu código.

        ' Conexão com o banco de dados MySQL.
        conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

        Try
            conn.Open()

            ' Query SQL para editar o item
            Dim sql As String = "UPDATE Stock SET Produtos = @produtos, Quantidade = @quantidade, id_fornecedor = @id_fornecedor, id_usuario = @id_usuario WHERE id_stock = @id"
            Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@produtos", produto)
            cmd.Parameters.AddWithValue("@quantidade", quantidade)
            ' Você também precisa definir os parâmetros para id_fornecedor e id_usuario aqui.

            ' Executa a consulta SQL para editar o item no estoque.
            cmd.ExecuteNonQuery()

            ' Limpa os campos do formulário.
            LimparCampos()

            ' Atualiza a lista de itens de estoque na DataGridView.
            PreencherEstoque()
        Catch ex As Exception
            ' Em caso de erro, exibe uma mensagem de erro.
            MsgBox(ex.Message)
        Finally
            ' Certifique-se de fechar a conexão com o banco de dados.
            conn.Close()
        End Try
    End Sub

    ' Deleta um item do estoque
    Private Sub BtnDeletar_Click(sender As Object, e As EventArgs) Handles BtnDeletar.Click
        ' Manipulador de evento para o botão "Deletar" que exclui um item do estoque.

        ' Obtém o ID do item a ser deletado.
        Dim id As Integer = Convert.ToInt32(TextBoxIdProduto.Text)

        ' Conexão com o banco de dados MySQL.
        conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

        Try
            conn.Open()

            ' Query SQL para deletar o item
            Dim sql As String = "DELETE FROM Stock WHERE id_stock = @id"
            Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", id)

            ' Executa a consulta SQL para deletar o item do estoque.
            cmd.ExecuteNonQuery()

            ' Limpa os campos do formulário.
            LimparCampos()

            ' Atualiza a lista de itens de estoque na DataGridView.
            PreencherEstoque()
        Catch ex As Exception
            ' Em caso de erro, exibe uma mensagem de erro.
            MsgBox(ex.Message)
        Finally
            ' Certifique-se de fechar a conexão com o banco de dados.
            conn.Close()
        End Try
    End Sub

    ' Pesquisa itens no estoque com base no texto inserido
    Private Sub TextBoxPesquisa_Click(sender As Object, e As EventArgs) Handles TextBoxPesquisa.Click
        ' Manipulador de evento para o botão "Pesquisar" que busca itens no estoque com base no texto inserido.

        ' Obtém o texto da pesquisa.
        Dim pesquisa As String = TextBoxPesquisa.Text

        ' Conexão com o banco de dados MySQL.
        conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

        Try
            conn.Open()

            ' Query SQL para pesquisar itens.
            Dim sql As String = "SELECT * FROM Stock WHERE Produtos LIKE @pesquisa OR Quantidade LIKE @pesquisa"
            Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            adapter.SelectCommand.Parameters.AddWithValue("@pesquisa", "%" & pesquisa & "%")

            Dim ds As DataSet = New DataSet()
            adapter.Fill(ds, "Stock")

            ' Define o resultado da pesquisa como a fonte de dados para a DataGridView.
            DataGridViewEstoque.DataSource = ds.Tables("Stock")
        Catch ex As Exception
            ' Em caso de erro, exibe uma mensagem de erro.
            MsgBox(ex.Message)
        Finally
            ' Certifique-se de fechar a conexão com o banco de dados.
            conn.Close()
        End Try
    End Sub

    ' Limpa os campos e a pesquisa
    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        ' Manipulador de evento para o botão "Limpar" que limpa os campos e a pesquisa.

        LimparCampos()
    End Sub

    Private Sub TextBoxIdProduto_TextChanged(sender As Object, e As EventArgs) Handles TextBoxIdProduto.TextChanged
        ' Manipulador de evento para quando o texto do campo ID do produto é alterado.

        Dim idProduto As Integer

        If Integer.TryParse(TextBoxIdProduto.Text, idProduto) Then
            ' Se o texto puder ser convertido para um número inteiro, busca informações por ID.
            BuscarInformacoesPorID(idProduto)
        Else
            ' Caso contrário, limpa os campos, exceto o ID.
            LimparCamposExcetoID()
        End If
    End Sub

    Private Sub BuscarInformacoesPorID(idProduto As Integer)
        ' Este método busca informações de um item de estoque por ID.

        ' Conexão com o banco de dados MySQL.
        conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

        Try
            conn.Open()

            ' Query SQL para buscar informações do item por ID.
            Dim sql As String = "SELECT * FROM Stock WHERE id_stock = @id"
            Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", idProduto)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' Preenche os campos com as informações do item.
                TextBoxProduto.Text = reader("Produtos").ToString()
                TextBoxQuantidade.Text = reader("Quantidade").ToString()
                ' Você também precisa definir os campos para id_fornecedor e id_usuario aqui.
            Else
                ' Se não houver correspondência, limpa os campos, exceto o ID.
                LimparCamposExcetoID()
            End If

            reader.Close()
        Catch ex As Exception
            ' Em caso de erro, exibe uma mensagem de erro.
            MsgBox(ex.Message)
        Finally
            ' Certifique-se de fechar a conexão com o banco de dados.
            conn.Close()
        End Try
    End Sub

    Private Sub LimparCampos()
        ' Este método limpa todos os campos do formulário.
        TextBoxIdProduto.Clear()
        TextBoxProduto.Clear()
        TextBoxQuantidade.Clear()
        ' Limpe os campos de id_fornecedor e id_usuario aqui, se necessário.
        TextBoxPesquisa.Clear()
    End Sub

    Private Sub LimparCamposExcetoID()
        ' Este método limpa todos os campos do formulário, exceto o campo ID.
        TextBoxProduto.Clear()
        TextBoxQuantidade.Clear()
        ' Limpe os campos de id_fornecedor e id_usuario aqui, se necessário.
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

    Private Sub BtnProdutoBruto_Click(sender As Object, e As EventArgs) Handles BtnProdutoBruto.Click
        Me.Hide()
        ProdutoBrutoForm.Show()
    End Sub

    Private Sub BtnRecuperarSenha_Click(sender As Object, e As EventArgs) Handles BtnRecuperarSenha.Click
        Me.Hide()
        RecuperarSenhaForm.Show()
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
