Imports MySql.Data.MySqlClient

Public Class PedidosDeliveryForm


    ' Declaração da conexão com o banco de dados
    Dim conn As MySqlConnection

    ' Preenche a DataGridView com os pedidos de entrega
    Private Sub PreencherPedidos()
        ' Inicializa a conexão com o banco de dados
        conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

        Try
            ' Abre a conexão com o banco de dados
            conn.Open()

            ' Query SQL para selecionar todos os pedidos de entrega
            Dim sql As String = "SELECT * FROM Pedidos_Delivery"
            Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            Dim ds As DataSet = New DataSet()

            ' Preenche o DataSet com os dados da tabela Pedidos_Delivery
            adapter.Fill(ds, "Pedidos_Delivery")

            ' Define a fonte de dados da DataGridView como o DataSet
            DataGridViewPedidos.DataSource = ds.Tables("Pedidos_Delivery")
        Catch ex As Exception
            ' Exibe uma mensagem de erro em caso de falha
            MsgBox(ex.Message)
        Finally
            ' Fecha a conexão com o banco de dados
            conn.Close()
        End Try
    End Sub

    ' Adiciona um novo pedido de entrega
    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click
        ' Obtém os valores dos campos
        Dim nomeCliente As String = TextBoxNomeCliente.Text
        Dim morada As String = TextBoxMorada.Text
        Dim contacto As String = TextBoxContacto.Text
        Dim nomePrato As String = TextBoxNomePrato.Text
        Dim precoPrato As Decimal = Decimal.Parse(TextBoxPrecoPrato.Text)
        Dim custoEntrega As Decimal = Decimal.Parse(TextBoxCustoEntrega.Text)
        Dim quantidade As Integer = Integer.Parse(TextBoxQuantidade.Text)

        ' Inicializa a conexão com o banco de dados
        conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

        Try
            ' Abre a conexão com o banco de dados
            conn.Open()

            ' Query SQL para adicionar o pedido de entrega
            Dim sql As String = "INSERT INTO Pedidos_Delivery (NomeCliente, Morada, Contacto, Nome_Prato, Preco_Prato, Custo_Entrega, Quantidade) VALUES (@nomeCliente, @morada, @contacto, @nomePrato, @precoPrato, @custoEntrega, @quantidade)"
            Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@nomeCliente", nomeCliente)
            cmd.Parameters.AddWithValue("@morada", morada)
            cmd.Parameters.AddWithValue("@contacto", contacto)
            cmd.Parameters.AddWithValue("@nomePrato", nomePrato)
            cmd.Parameters.AddWithValue("@precoPrato", precoPrato)
            cmd.Parameters.AddWithValue("@custoEntrega", custoEntrega)
            cmd.Parameters.AddWithValue("@quantidade", quantidade)

            ' Executa a consulta SQL para adicionar o pedido
            cmd.ExecuteNonQuery()

            ' Limpa os campos após adicionar o pedido
            LimparCampos()

            ' Atualiza a DataGridView com os pedidos
            PreencherPedidos()
        Catch ex As Exception
            ' Exibe uma mensagem de erro em caso de falha
            MsgBox(ex.Message)
        Finally
            ' Fecha a conexão com o banco de dados
            conn.Close()
        End Try
    End Sub

    ' Edita um pedido de entrega existente
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        ' Obtém os valores dos campos
        Dim idPedido As Integer = Integer.Parse(TextBoxIdPedido.Text)
        Dim nomeCliente As String = TextBoxNomeCliente.Text
        Dim morada As String = TextBoxMorada.Text
        Dim contacto As String = TextBoxContacto.Text
        Dim nomePrato As String = TextBoxNomePrato.Text
        Dim precoPrato As Decimal = Decimal.Parse(TextBoxPrecoPrato.Text)
        Dim custoEntrega As Decimal = Decimal.Parse(TextBoxCustoEntrega.Text)
        Dim quantidade As Integer = Integer.Parse(TextBoxQuantidade.Text)

        ' Inicializa a conexão com o banco de dados
        conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

        Try
            ' Abre a conexão com o banco de dados
            conn.Open()

            ' Query SQL para atualizar o pedido de entrega
            Dim sql As String = "UPDATE Pedidos_Delivery SET NomeCliente = @nomeCliente, Morada = @morada, Contacto = @contacto, Nome_Prato = @nomePrato, Preco_Prato = @precoPrato, Custo_Entrega = @custoEntrega, Quantidade = @quantidade WHERE ID_Ped = @idPedido"
            Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@idPedido", idPedido)
            cmd.Parameters.AddWithValue("@nomeCliente", nomeCliente)
            cmd.Parameters.AddWithValue("@morada", morada)
            cmd.Parameters.AddWithValue("@contacto", contacto)
            cmd.Parameters.AddWithValue("@nomePrato", nomePrato)
            cmd.Parameters.AddWithValue("@precoPrato", precoPrato)
            cmd.Parameters.AddWithValue("@custoEntrega", custoEntrega)
            cmd.Parameters.AddWithValue("@quantidade", quantidade)

            ' Executa a consulta SQL para atualizar o pedido
            cmd.ExecuteNonQuery()

            ' Limpa os campos após editar o pedido
            LimparCampos()

            ' Atualiza a DataGridView com os pedidos
            PreencherPedidos()
        Catch ex As Exception
            ' Exibe uma mensagem de erro em caso de falha
            MsgBox(ex.Message)
        Finally
            ' Fecha a conexão com o banco de dados
            conn.Close()
        End Try
    End Sub

    ' Deleta um pedido de entrega
    Private Sub BtnDeletar_Click(sender As Object, e As EventArgs) Handles BtnDeletar.Click
        ' Obtém o ID do pedido a ser deletado
        Dim idPedido As Integer = Integer.Parse(TextBoxIdPedido.Text)

        ' Inicializa a conexão com o banco de dados
        conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

        Try
            ' Abre a conexão com o banco de dados
            conn.Open()

            ' Query SQL para deletar o pedido de entrega
            Dim sql As String = "DELETE FROM Pedidos_Delivery WHERE ID_Ped = @idPedido"
            Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@idPedido", idPedido)

            ' Executa a consulta SQL para deletar o pedido
            cmd.ExecuteNonQuery()

            ' Limpa os campos após deletar o pedido
            LimparCampos()

            ' Atualiza a DataGridView com os pedidos
            PreencherPedidos()
        Catch ex As Exception
            ' Exibe uma mensagem de erro em caso de falha
            MsgBox(ex.Message)
        Finally
            ' Fecha a conexão com o banco de dados
            conn.Close()
        End Try
    End Sub

    ' Limpa os campos
    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        LimparCampos()
    End Sub

    ' Limpa todos os campos
    Private Sub LimparCampos()
        TextBoxIdPedido.Clear()
        TextBoxNomeCliente.Clear()
        TextBoxMorada.Clear()
        TextBoxContacto.Clear()
        TextBoxNomePrato.Clear()
        TextBoxPrecoPrato.Clear()
        TextBoxCustoEntrega.Clear()
        TextBoxQuantidade.Clear()
    End Sub

    ' Busca informações por ID e preenche os campos
    Private Sub TextBoxIDPedido_TextChanged(sender As Object, e As EventArgs) Handles TextBoxIdPedido.TextChanged
        Dim idPedido As Integer

        ' Verifica se o texto na TextBox é um número inteiro
        If Integer.TryParse(TextBoxIdPedido.Text, idPedido) Then
            BuscarInformacoesPorID(idPedido)
        Else
            ' Limpa os campos (exceto o ID) se o texto não for um número
            LimparCamposExcetoID()
        End If
    End Sub

    ' Busca informações do pedido por ID
    Private Sub BuscarInformacoesPorID(idPedido As Integer)
        ' Inicializa a conexão com o banco de dados
        conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

        Try
            ' Abre a conexão com o banco de dados
            conn.Open()

            ' Query SQL para buscar informações do pedido por ID
            Dim sql As String = "SELECT * FROM Pedidos_Delivery WHERE ID_Ped = @idPedido"
            Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@idPedido", idPedido)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Se o pedido for encontrado, preenche os campos
            If reader.Read() Then
                TextBoxNomeCliente.Text = reader("NomeCliente").ToString()
                TextBoxMorada.Text = reader("Morada").ToString()
                TextBoxContacto.Text = reader("Contacto").ToString()
                TextBoxNomePrato.Text = reader("Nome_Prato").ToString()
                TextBoxPrecoPrato.Text = reader("Preco_Prato").ToString()
                TextBoxCustoEntrega.Text = reader("Custo_Entrega").ToString()
                TextBoxQuantidade.Text = reader("Quantidade").ToString()
            Else
                ' Limpa os campos (exceto o ID) se o pedido não for encontrado
                LimparCamposExcetoID()
            End If

            reader.Close()
        Catch ex As Exception
            ' Exibe uma mensagem de erro em caso de falha
            MsgBox(ex.Message)
        Finally
            ' Fecha a conexão com o banco de dados
            conn.Close()
        End Try
    End Sub

    ' Limpa os campos (exceto o ID)
    Private Sub LimparCamposExcetoID()
        TextBoxNomeCliente.Clear()
        TextBoxMorada.Clear()
        TextBoxContacto.Clear()
        TextBoxNomePrato.Clear()
        TextBoxPrecoPrato.Clear()
        TextBoxCustoEntrega.Clear()
        TextBoxQuantidade.Clear()
    End Sub

    ' Realiza a pesquisa de pedidos por ID, nome do cliente, morada ou contacto
    Private Sub TextBoxPesquisa_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPesquisa.TextChanged
        ' Obtém o texto da pesquisa
        Dim pesquisa As String = TextBoxPesquisa.Text

        ' Inicializa a conexão com o banco de dados
        conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

        Try
            ' Abre a conexão com o banco de dados
            conn.Open()

            ' Query SQL para pesquisar pedidos com base no texto inserido
            Dim sql As String = "SELECT * FROM Pedidos_Delivery WHERE CONCAT(ID_Ped, NomeCliente, Morada, Contacto) LIKE @pesquisa"
            Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            adapter.SelectCommand.Parameters.AddWithValue("@pesquisa", "%" & pesquisa & "%")

            Dim ds As DataSet = New DataSet()
            adapter.Fill(ds, "Pedidos_Delivery")

            ' Define a fonte de dados da DataGridView como o DataSet
            DataGridViewPedidos.DataSource = ds.Tables("Pedidos_Delivery")
        Catch ex As Exception
            ' Exibe uma mensagem de erro em caso de falha
            MsgBox(ex.Message)
        Finally
            ' Fecha a conexão com o banco de dados
            conn.Close()
        End Try
    End Sub

    ' Evento ao carregar o formulário
    Private Sub GerenciarPedidosDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Preenche a DataGridView com os pedidos
        PreencherPedidos()
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

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        End
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Close()
        LoginForm1.Show()
    End Sub
End Class

