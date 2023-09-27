Imports System.Windows.Forms.VisualStyles
Imports MySql.Data.MySqlClient
Imports NLog

Public Class PratosForm

    Private Shared Logger As Logger = LogManager.GetCurrentClassLogger()

    ' Declaração da conexão com o banco de dados
    Private conn As MySqlConnection

    ' Variável para controlar o ID do prato
    Private idPrato As Integer = 1

    ' Evento que é acionado ao carregar o formulário
    Public Sub New()
        ' Este é o construtor do formulário
        InitializeComponent()
    End Sub

    Private Sub PratosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Preenche o ComboBox de Pratos
        CarregarPratosNaComboBox()
        AtualizarListaPratos()
    End Sub

    ' Preenche o ComboBox de Pratos com as opções
    Private Sub CarregarPratosNaComboBox()
        ComboBoxPrato.Items.Add("Bacalhau à Brás")
        ComboBoxPrato.Items.Add("Francesinha")
        ComboBoxPrato.Items.Add("Arroz de Pato")
        ComboBoxPrato.Items.Add("Caldo Verde")
        ComboBoxPrato.Items.Add("Amêijoas à Bulhão Pato")
        ComboBoxPrato.Items.Add("Feijoada à Transmontana")
        ComboBoxPrato.Items.Add("Cozido à Portuguesa")
        ComboBoxPrato.Items.Add("Açorda de Marisco")
        ComboBoxPrato.Items.Add("Tripas à Moda do Porto")
        ComboBoxPrato.Items.Add("Arroz de Marisco")
        ComboBoxPrato.Items.Add("Carne de Porco à Alentejana")
        ComboBoxPrato.Items.Add("Polvo à Lagareiro")
        ComboBoxPrato.Items.Add("Robalo Grelhado")
        ComboBoxPrato.Items.Add("Sardinhas Assadas")
        ComboBoxPrato.Items.Add("Paelha à Portuguesa")
        ComboBoxPrato.Items.Add("Alheira de Mirandela")
        ComboBoxPrato.Items.Add("Salada de Polvo")
        ComboBoxPrato.Items.Add("Pastéis de Bacalhau")
        ComboBoxPrato.Items.Add("Lulas à Setubalense")
        ComboBoxPrato.Items.Add("Rojões à Minhota")
        ComboBoxPrato.Items.Add("Bifanas à Moda do Porto")
        ComboBoxPrato.Items.Add("Sopa de Pedra")
        ComboBoxPrato.Items.Add("Chanfana")
        ComboBoxPrato.Items.Add("Pataniscas de Bacalhau")
        ComboBoxPrato.Items.Add("Empadão de Pato")
        ComboBoxPrato.Items.Add("Bitoque")
        ComboBoxPrato.Items.Add("Frango no Churrasco")
        ComboBoxPrato.Items.Add("Cataplana de Marisco")
        ComboBoxPrato.Items.Add("Feijoada")
        ComboBoxPrato.Items.Add("Coxinha")
        ComboBoxPrato.Items.Add("Acarajé")
        ComboBoxPrato.Items.Add("Pão de Queijo")
        ComboBoxPrato.Items.Add("Moqueca de Peixe")
    End Sub

    Private Sub ComboBoxPrato_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPrato.SelectedIndexChanged
        ' Obtém o prato selecionado na ComboBox
        ' Verifica se um item foi selecionado na ComboBox
        If ComboBoxPrato.SelectedItem IsNot Nothing Then
            ' Obtém o prato selecionado na ComboBox
            Dim pratoSelecionado As String = ComboBoxPrato.SelectedItem.ToString()

            ' Define a descrição correspondente na TextBoxDescricao
            Select Case pratoSelecionado
                Case "Bacalhau à Brás"
                    TextBoxDescricao.Text = "Bacalhau à Brás é um prato tradicional português feito com bacalhau desfiado, batatas palha, cebola, alho, ovos e salsa. É um prato saboroso e reconfortante."
                Case "Francesinha"
                    TextBoxDescricao.Text = "A Francesinha é uma sanduíche recheada com carne, linguiça e queijo, coberta com um molho picante à base de tomate. É um prato típico da cidade do Porto e muito saboroso."
                Case "Arroz de Pato"
                    TextBoxDescricao.Text = "Arroz de Pato é um prato que combina arroz, pato e chouriço, tudo cozido no forno até ficar dourado e delicioso. É um prato reconfortante e tradicional."
                Case "Caldo Verde"
                    TextBoxDescricao.Text = "Caldo Verde é uma sopa tradicional portuguesa feita com couve-galega, batatas, chouriço e azeite. É uma sopa simples e muito apreciada."
                Case "Amêijoas à Bulhão Pato"
                    TextBoxDescricao.Text = "Amêijoas à Bulhão Pato são um prato de mariscos típico de Portugal, preparado com amêijoas, alho, coentros e azeite. É uma entrada deliciosa."
                Case "Feijoada à Transmontana"
                    TextBoxDescricao.Text = "Feijoada à Transmontana é um prato de feijão preto com diversas carnes, como chouriço, morcela e entrecosto. É uma especialidade da região de Trás-os-Montes em Portugal."
                Case "Cozido à Portuguesa"
                    TextBoxDescricao.Text = "O Cozido à Portuguesa é uma refeição substancial que inclui uma variedade de carnes, legumes e enchidos cozidos. É um prato típico de Portugal e muito apreciado."
                Case "Açorda de Marisco"
                    TextBoxDescricao.Text = "A Açorda de Marisco é uma sopa típica portuguesa feita com pão, caldo de marisco, coentros e ovos escalfados. É uma sopa rica em sabores do mar."
                Case "Tripas à Moda do Porto"
                    TextBoxDescricao.Text = "Tripas à Moda do Porto é um prato tradicional da cidade do Porto, preparado com tripas de porco, feijão branco, enchidos e diversos temperos. É uma iguaria única."
                Case "Arroz de Marisco"
                    TextBoxDescricao.Text = "Arroz de Marisco é um prato português que combina arroz com uma variedade de frutos do mar, como camarões, mexilhões e amêijoas. É um prato de sabor intenso."
                Case "Carne de Porco à Alentejana"
                    TextBoxDescricao.Text = "Carne de Porco à Alentejana é um prato típico do Alentejo, preparado com carne de porco, amêijoas, batatas e temperos. É uma combinação deliciosa de sabores."
                Case "Polvo à Lagareiro"
                    TextBoxDescricao.Text = "Polvo à Lagareiro é um prato tradicional português que envolve cozinhar polvo no forno com muito azeite, alho e batatas. É uma delícia da culinária lusitana."
                Case "Robalo Grelhado"
                    TextBoxDescricao.Text = "Robalo Grelhado é um prato de peixe simples e saudável, preparado grelhando robalo com temperos e azeite. É uma opção leve e saborosa."
                Case "Sardinhas Assadas"
                    TextBoxDescricao.Text = "Sardinhas Assadas são um prato popular em Portugal, especialmente durante as festas de São João. As sardinhas são temperadas e assadas na brasa, resultando em um sabor único."
                Case "Paelha à Portuguesa"
                    TextBoxDescricao.Text = "A Paelha à Portuguesa é uma versão portuguesa da paella espanhola, feita com arroz, frutos do mar, carne de porco, chouriço e açafrão. É uma refeição colorida e saborosa."
                Case "Alheira de Mirandela"
                    TextBoxDescricao.Text = "Alheira de Mirandela é uma enchido tradicional português, especialmente associado à região de Mirandela. É feita com carne de aves, pão e temperos."
                Case "Salada de Polvo"
                    TextBoxDescricao.Text = "Salada de Polvo é um prato de frutos do mar preparado com polvo cozido, cebola, pimento, azeite e vinagre. É uma entrada refrescante."
                Case "Pastéis de Bacalhau"
                    TextBoxDescricao.Text = "Pastéis de Bacalhau são bolinhos fritos feitos com bacalhau desfiado, batata, cebola e temperos. São um petisco muito apreciado em Portugal."
                Case "Lulas à Setubalense"
                    TextBoxDescricao.Text = "Lulas à Setubalense é um prato de lulas preparado com tomate, cebola, pimento e especiarias. É uma iguaria da região de Setúbal."
                Case "Rojões à Minhota"
                    TextBoxDescricao.Text = "Rojões à Minhota é um prato típico da região do Minho, preparado com pedaços de carne de porco fritos, servidos com batatas e arroz."
                Case "Bifanas à Moda do Porto"
                    TextBoxDescricao.Text = "Bifanas à Moda do Porto são sanduíches de carne de porco temperada, muito populares na cidade do Porto. São servidas em pão com mostarda e vinho branco."
                Case "Sopa de Pedra"
                    TextBoxDescricao.Text = "Sopa de Pedra é uma sopa tradicional portuguesa feita com feijão, carne de porco, chouriço e outros ingredientes. O nome vem da lenda da pedra que foi adicionada à sopa para enriquecê-la."
                Case "Chanfana"
                    TextBoxDescricao.Text = "Chanfana é um prato típico da região da Beira Litoral, em Portugal, feito com carne de cabra ou carneiro, vinho tinto, alho e especiarias. É cozido lentamente até a carne ficar tenra."
                Case "Pataniscas de Bacalhau"
                    TextBoxDescricao.Text = "Pataniscas de Bacalhau são bolinhos fritos feitos com bacalhau desfiado, farinha, ovos e temperos. São um petisco muito apreciado em Portugal."
                Case "Empadão de Pato"
                    TextBoxDescricao.Text = "Empadão de Pato é um prato que combina carne de pato desfiada com purê de batata, gratinado no forno. É uma refeição reconfortante."
                Case "Bitoque"
                    TextBoxDescricao.Text = "Bitoque é um prato português que consiste em bife de vaca grelhado com ovo a cavalo, servido com batatas fritas e arroz. É uma opção popular em Portugal."
                Case "Frango no Churrasco"
                    TextBoxDescricao.Text = "Frango no Churrasco é um prato simples e saboroso, feito com frango temperado e grelhado. É uma especialidade de churrascarias."
                Case "Cataplana de Marisco"
                    TextBoxDescricao.Text = "Cataplana de Marisco é um prato algarvio preparado em uma cataplana, uma panela de cobre, com uma mistura de frutos do mar, tomate, cebola e temperos. É uma delícia da culinária do sul de Portugal."
                Case "Feijoada"
                    TextBoxDescricao.Text = "Feijoada é um prato brasileiro que combina feijão preto com diversas carnes, como carne de porco e linguiça. É uma refeição saborosa e nutritiva."
                Case "Coxinha"
                    TextBoxDescricao.Text = "Coxinha é um salgado brasileiro, feito com massa de batata recheada com frango desfiado e temperos. É empanado e frito até ficar crocante."
                Case "Acarajé"
                    TextBoxDescricao.Text = "Acarajé é uma iguaria da culinária baiana, feita com massa de feijão-fradinho frita, recheada com camarão seco, vatapá e outros ingredientes. É uma delícia típica de festas e celebrações."
                Case "Pão de Queijo"
                    TextBoxDescricao.Text = "Pão de Queijo é uma especialidade mineira, feito com massa de polvilho e queijo. É assado e serve como um petisco delicioso."
                Case "Moqueca de Peixe"
                    TextBoxDescricao.Text = "Moqueca de Peixe é um prato brasileiro preparado com peixe, camarão, pimentões, cebolas, tomate e leite de coco. É cozido lentamente em uma panela de barro e é conhecido por seu sabor único."
                Case Else
                    TextBoxDescricao.Text = "Descrição não disponível."
            End Select

        End If
    End Sub

    ' Atualiza a lista de pratos no DataGridView
    Private Sub AtualizarListaPratos()
        ' Configura a conexão com o banco de dados
        conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

        Try
            conn.Open()

            ' Consulta SQL para obter todos os pratos
            Dim sql As String = "SELECT * FROM Produto_Comestivel"
            Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            Dim builder As MySqlCommandBuilder = New MySqlCommandBuilder(adapter)
            Dim ds As DataSet = New DataSet()
            adapter.Fill(ds, "Produto_Comestivel")

            ' Define o resultado da consulta como fonte de dados do DataGridView
            DataGridViewPratos.DataSource = ds.Tables("Produto_Comestivel")
        Catch ex As Exception
            ' Exibe mensagem de erro em caso de falha na conexão ou consulta
            MsgBox(ex.Message)
        Finally
            ' Fecha a conexão com o banco de dados
            conn.Close()
        End Try
    End Sub

    ' Evento acionado ao alterar o texto em TextBoxIdPrato
    Private Sub TextBoxIdPrato_TextChanged(sender As Object, e As EventArgs) Handles TextBoxIdPrato.TextChanged
        ' Obtém o ID do prato da TextBoxIdPrato
        Dim idPrato As Integer

        If Integer.TryParse(TextBoxIdPrato.Text, idPrato) AndAlso idPrato > 0 Then
            ' Consulta SQL para obter os detalhes do prato com base no ID do prato
            ' Certifique-se de ajustar a conexão e a consulta de acordo com o seu banco de dados
            conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")
            conn.Open()

            Dim query As String = "SELECT Nome_Prato, Valor_Producao, Valor_Venda FROM Produto_Comestivel WHERE ID_Prato = @PratoID"
            Dim cmd As MySqlCommand = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@PratoID", idPrato)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' Preenche TextBoxDescricao, TextBoxPreco, TextBoxValorProducao e TextBoxValorVenda com os dados do prato
                ComboBoxPrato.Text = reader("Nome_Prato").ToString

                TextBoxValorProducao.Text = reader("Valor_Producao").ToString()
                TextBoxValorVenda.Text = reader("Valor_Venda").ToString()
            Else
                ' Limpa os campos se não houver correspondência
                TextBoxDescricao.Clear()
                TextBoxPreco.Clear()
                TextBoxValorProducao.Clear()
                TextBoxValorVenda.Clear()
                ComboBoxPrato.SelectedItem = -1
            End If

            reader.Close()
            conn.Close()
        Else
            ' Limpa os campos se o ID do prato não for válido
            TextBoxDescricao.Clear()
            TextBoxPreco.Clear()
            TextBoxValorProducao.Clear()
            TextBoxValorVenda.Clear()
            ComboBoxPrato.SelectedItem = -1
        End If
    End Sub

    ' Limpa os campos do formulário
    Private Sub LimparCampos()
        TextBoxIdPrato.Clear()
        TextBoxDescricao.Clear()
        TextBoxPreco.Clear()
        TextBoxValorProducao.Clear()
        TextBoxValorVenda.Clear()
        ComboBoxPrato.SelectedIndex = -1
    End Sub

    ' Evento acionado ao clicar no botão Adicionar
    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click
        ' Configura a conexão com o banco de dados
        conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

        Try
            conn.Open()

            ' Verifica se o nome do prato foi preenchido
            If String.IsNullOrEmpty(ComboBoxPrato.Text.Trim()) Then
                MsgBox("O nome do prato é obrigatório.")
                Return
            End If

            ' Verifica se o preço do prato foi preenchido e é válido
            Dim precoPrato As Decimal

            If Not Decimal.TryParse(TextBoxPreco.Text, precoPrato) OrElse precoPrato <= 0 Then
                MsgBox("O preço do prato é obrigatório.")
                Return
            End If

            ' Verifica se o valor de produção foi preenchido e é válido
            Dim valorProducao As Decimal

            If Not Decimal.TryParse(TextBoxValorProducao.Text, valorProducao) OrElse valorProducao <= 0 Then
                MsgBox("O valor de produção é obrigatório.")
                Return
            End If

            ' Verifica se o valor de venda foi preenchido e é válido
            Dim valorVenda As Decimal

            If Not Decimal.TryParse(TextBoxValorVenda.Text, valorVenda) OrElse valorVenda <= 0 Then
                MsgBox("O valor de venda é obrigatório.")
                Return
            End If

            ' Caso contrário, insira o novo prato com o ID atual
            Dim query As String = "INSERT INTO Produto_Comestivel (ID_Prato, Nome_Prato, Valor_Producao, Valor_Venda) VALUES (@ID_Prato, @NomePrato, @PrecoPrato, @ValorProducao, @ValorVenda)"
            Dim cmd As MySqlCommand = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ID_Prato", idPrato)
            cmd.Parameters.AddWithValue("@NomePrato", ComboBoxPrato.Text.Trim())
            cmd.Parameters.AddWithValue("@PrecoPrato", precoPrato)
            cmd.Parameters.AddWithValue("@ValorProducao", valorProducao)
            cmd.Parameters.AddWithValue("@ValorVenda", valorVenda)

            cmd.ExecuteNonQuery()

            ' Incrementa o ID para o próximo prato
            idPrato += 1

            MsgBox("Prato adicionado com sucesso.")
            LimparCampos()
            AtualizarListaPratos()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Function PratoIDExiste(idPrato As Integer) As Boolean
        ' Configura a conexão com o banco de dados
        conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

        Try
            conn.Open()

            ' Verifica se o ID do prato já existe na base de dados
            Dim sqlCheckID As String = "SELECT COUNT(*) FROM Produto_Comestivel WHERE ID_Prato = @ID_Prato"
            Dim cmdCheckID As MySqlCommand = New MySqlCommand(sqlCheckID, conn)
            cmdCheckID.Parameters.AddWithValue("@ID_Prato", idPrato)

            Dim count As Integer = CInt(cmdCheckID.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False ' Em caso de erro, retornar False
        Finally
            conn.Close()
        End Try
    End Function

    ' Evento acionado ao clicar no botão Editar
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        ' Obtém o ID do prato a partir do TextBoxIdPrato
        Dim idPrato As Integer

        If Integer.TryParse(TextBoxIdPrato.Text, idPrato) AndAlso idPrato > 0 Then
            ' Configura a conexão com o banco de dados
            conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

            Try
                conn.Open()

                ' Verifica se o nome do prato foi preenchido
                If String.IsNullOrEmpty(ComboBoxPrato.Text.Trim()) Then
                    MsgBox("O nome do prato é obrigatório.")
                    Return
                End If

                ' Verifica se o preço do prato foi preenchido e é válido
                Dim precoPrato As Decimal

                If Not Decimal.TryParse(TextBoxPreco.Text, precoPrato) OrElse precoPrato <= 0 Then
                    MsgBox("O preço do prato é obrigatório.")
                    Return
                End If

                ' Verifica se o valor de produção foi preenchido e é válido
                Dim valorProducao As Decimal

                If Not Decimal.TryParse(TextBoxValorProducao.Text, valorProducao) OrElse valorProducao <= 0 Then
                    MsgBox("O valor de produção é obrigatório.")
                    Return
                End If

                ' Verifica se o valor de venda foi preenchido e é válido
                Dim valorVenda As Decimal

                If Not Decimal.TryParse(TextBoxValorVenda.Text, valorVenda) OrElse valorVenda <= 0 Then
                    MsgBox("O valor de venda é obrigatório.")
                    Return
                End If

                ' Consulta SQL para atualizar os dados do prato
                Dim query As String = "UPDATE Produto_Comestivel SET Nome_Prato = @NomePrato, Valor_Producao = @ValorProducao, Valor_Venda = @ValorVenda WHERE ID_Prato = @PratoID"
                Dim cmd As MySqlCommand = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@NomePrato", ComboBoxPrato.Text.Trim())
                cmd.Parameters.AddWithValue("@PrecoPrato", precoPrato)
                cmd.Parameters.AddWithValue("@ValorProducao", valorProducao)
                cmd.Parameters.AddWithValue("@ValorVenda", valorVenda)
                cmd.Parameters.AddWithValue("@PratoID", idPrato)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    ' Exibe mensagem de sucesso
                    MsgBox("Prato editado com sucesso.")

                    ' Limpa os campos (exceto TextBoxIdPrato)
                    LimparCampos()

                    ' Atualiza a lista de pratos
                    AtualizarListaPratos()
                Else
                    ' Exibe mensagem se nenhum prato for encontrado para edição
                    MsgBox("Nenhum prato foi encontrado para edição.")
                End If
            Catch ex As Exception
                ' Exibe mensagem de erro em caso de falha na operação
                MsgBox(ex.Message)
            Finally
                ' Fecha a conexão com o banco de dados
                conn.Close()
            End Try
        Else
            ' Exibe mensagem se o ID do prato não for válido
            MsgBox("Informe um ID válido para editar.")
        End If
    End Sub

    ' Evento acionado ao clicar no botão Deletar
    Private Sub BtnDeletar_Click(sender As Object, e As EventArgs) Handles BtnDeletar.Click
        ' Obtém o ID do prato a partir do TextBoxIdPrato
        Dim idPrato As Integer

        If Integer.TryParse(TextBoxIdPrato.Text, idPrato) AndAlso idPrato > 0 Then
            ' Configura a conexão com o banco de dados
            conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

            Try
                conn.Open()

                ' Consulta SQL para excluir o prato com base no ID
                Dim query As String = "DELETE FROM Produto_Comestivel WHERE ID_Prato = @PratoID"
                Dim cmd As MySqlCommand = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@PratoID", idPrato)
                cmd.ExecuteNonQuery()

                ' Exibe mensagem de sucesso
                MsgBox("Prato excluído com sucesso.")

                ' Limpa os campos (exceto TextBoxIdPrato)
                LimparCampos()

                ' Atualiza a lista de pratos
                AtualizarListaPratos()
            Catch ex As Exception
                ' Exibe mensagem de erro em caso de falha na operação
                MsgBox(ex.Message)
            Finally
                ' Fecha a conexão com o banco de dados
                conn.Close()
            End Try
        Else
            ' Exibe mensagem se o ID do prato não for válido
            MsgBox("Informe um ID válido para excluir.")
        End If
    End Sub

    ' Evento acionado ao clicar no botão Limpar
    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        ' Limpa os campos (exceto TextBoxIdPrato)
        LimparCampos()
    End Sub

    ' Evento acionado ao clicar no botão Fechar
    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        End
    End Sub

    ' Evento acionado ao clicar em uma célula do DataGridView
    Private Sub DataGridViewPratos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPratos.CellClick
        ' Manipula o evento de clique em uma célula do DataGridView
        If e.RowIndex >= 0 Then
            ' Obtém o ID do prato a partir do DataGridView
            Dim idPrato As Integer

            If Integer.TryParse(DataGridViewPratos.Rows(e.RowIndex).Cells("ID_Prato").Value.ToString(), idPrato) Then
                TextBoxIdPrato.Text = idPrato.ToString()
                PreencherCamposComPrato(idPrato)
            End If
        End If
    End Sub

    ' Preenche os campos com os dados do prato com base no ID
    Private Sub PreencherCamposComPrato(idPrato As Integer)
        ' Configura a conexão com o banco de dados
        conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

        Try
            conn.Open()

            ' Consulta SQL para obter os dados do prato com base no ID
            Dim sql As String = "SELECT * FROM Produto_Comestivel WHERE ID_Prato = @ID_Prato"
            Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@ID_Prato", idPrato)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' Preenche os campos com os dados do prato
                ComboBoxPrato.Text = reader("Nome_Prato").ToString()

                TextBoxValorProducao.Text = reader("Valor_Producao").ToString()
                TextBoxValorVenda.Text = reader("Valor_Venda").ToString()
            Else
                ' Limpa os campos se o prato não for encontrado
                LimparCampos()
            End If

            reader.Close()
        Catch ex As Exception
            ' Exibe mensagem de erro em caso de falha na operação
            MsgBox(ex.Message)
        Finally
            ' Fecha a conexão com o banco de dados
            conn.Close()
        End Try
    End Sub

    Private Sub TextBoxPesquisa_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPesquisa.TextChanged
        ' Armazena o valor atual da caixa de texto
        Dim valorAtual As String = TextBoxPesquisa.Text

        ' Monta a consulta SQL usando um parâmetro
        Dim pesquisa As String = "%" & valorAtual & "%" ' Pesquisa por qualquer parte da string
        Dim query As String = "SELECT * FROM Produto_Comestivel WHERE Nome_Prato LIKE @pesquisa"

        Try
            ' Abre a conexão com o banco de dados
            conn.Open()

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@pesquisa", pesquisa)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dataSet As New DataSet()

            adapter.Fill(dataSet, "Produto_Comestivel")

            ' Verifica se há resultados da pesquisa
            If dataSet.Tables("Produto_Comestivel").Rows.Count > 0 Then
                ' Exibe os resultados no DataGridView
                DataGridViewPratos.DataSource = dataSet.Tables("Produto_Comestivel")
            Else
                ' Caso não haja resultados, exibe uma mensagem
                MsgBox("Nenhum prato encontrado com o nome fornecido.")
            End If
        Catch ex As Exception
            MsgBox("Erro ao pesquisar pratos: " & ex.Message)
        Finally
            ' Fecha a conexão com o banco de dados
            conn.Close()
        End Try
    End Sub



    Private Sub BtnFornecedor_Click(sender As Object, e As EventArgs) Handles BtnFornecedor.Click
        FornecedorForm.Show()

    End Sub

    Private Sub BtnPratos_Click(sender As Object, e As EventArgs) Handles BtnPratos.Click

        HomeForm.Show()

    End Sub

    Private Sub BtnMesas_Click(sender As Object, e As EventArgs) Handles BtnMesas.Click
        MesasForm.Show()
    End Sub

    Private Sub BtnPagamento_Click(sender As Object, e As EventArgs) Handles BtnPagamento.Click
        PagamentoForm.Show()
    End Sub

    Private Sub BtnPedidosDelivery_Click(sender As Object, e As EventArgs) Handles BtnPedidosDelivery.Click
        PedidosDeliveryForm.Show()
    End Sub

    Private Sub BtnProdutoBruto_Click(sender As Object, e As EventArgs) Handles BtnProdutoBruto.Click
        ProdutoBrutoForm.Show()
    End Sub

    Private Sub BtnRecuperarSenha_Click(sender As Object, e As EventArgs) Handles BtnRecuperarSenha.Click
        RecuperarSenhaForm.Show()
    End Sub



    Private Sub BtnStock_Click(sender As Object, e As EventArgs) Handles BtnStock.Click
        StockForm.Show()
    End Sub

    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click
        UsuariosForm.Show()
    End Sub

    Private Sub BtnAboutMe_Click(sender As Object, e As EventArgs) Handles BtnAboutMe.Click

        AboutBox1.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Close()
        LoginForm1.Show()
    End Sub
End Class
