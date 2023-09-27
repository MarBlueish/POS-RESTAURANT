Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Random
Public Class UsuariosForm



    ' Declaração da conexão com o banco de dados
    Dim conn As MySqlConnection

    ' Método para preencher a DataGridView com os usuários
    Private Sub PreencherUsuarios()
        ' Inicializa a conexão com o banco de dados
        conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

        Try
            ' Abre a conexão com o banco de dados
            conn.Open()

            ' Query SQL para selecionar todos os usuários
            Dim sql As String = "SELECT * FROM Usuarios"
            Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            Dim ds As DataSet = New DataSet()

            ' Preenche o DataSet com os dados da tabela Usuarios
            adapter.Fill(ds, "Usuarios")

            ' Define a fonte de dados da DataGridView como o DataSet
            DataGridViewUsuario.DataSource = ds.Tables("Usuarios")
        Catch ex As Exception
            ' Exibe uma mensagem de erro em caso de falha
            MsgBox(ex.Message)
        Finally
            ' Fecha a conexão com o banco de dados
            conn.Close()
        End Try
    End Sub

    ' Método para adicionar um novo usuário
    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click
        ' Obtém os valores dos campos
        Dim NomeUsuario As String = TextBoxNomeUsuario.Text
        Dim Cargo As String = ComboBoxCargo.Text
        Dim Email As String = TextBoxEmail.Text
        Dim Contacto_telf As String = TextBoxContacto.Text

        ' Inicializa a conexão com o banco de dados
        conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

        Try
            ' Abre a conexão com o banco de dados
            conn.Open()

            ' Verifica se a tabela está vazia
            Dim tabelaVazia As Boolean = True
            Dim verificaTabelaVaziaSQL As String = "SELECT COUNT(*) FROM Usuarios"
            Dim cmdVerificaTabelaVazia As MySqlCommand = New MySqlCommand(verificaTabelaVaziaSQL, conn)
            Dim numRegistros As Integer = Convert.ToInt32(cmdVerificaTabelaVazia.ExecuteScalar())

            If numRegistros > 0 Then
                tabelaVazia = False
            End If

            ' Se a tabela estiver vazia, redefine o valor AUTO_INCREMENT
            If tabelaVazia Then
                Dim redefineAutoIncrementSQL As String = "ALTER TABLE Usuarios AUTO_INCREMENT = 1"
                Dim cmdRedefineAutoIncrement As MySqlCommand = New MySqlCommand(redefineAutoIncrementSQL, conn)
                cmdRedefineAutoIncrement.ExecuteNonQuery()
            End If

            ' Query SQL para verificar se o usuário já existe
            Dim verificaUsuarioSQL As String = "SELECT COUNT(*) FROM Usuarios WHERE Nome_Usuario = @NomeUsuario"
            Dim cmdVerificaUsuario As MySqlCommand = New MySqlCommand(verificaUsuarioSQL, conn)
            cmdVerificaUsuario.Parameters.AddWithValue("@NomeUsuario", NomeUsuario)
            Dim usuarioExistente As Integer = Convert.ToInt32(cmdVerificaUsuario.ExecuteScalar())

            If usuarioExistente > 0 Then
                ' Exibe uma mensagem de erro se o usuário já existe
                MsgBox("Usuário já cadastrado no sistema. O usuário deve ser único. Por favor, verifique os dados.")
            Else
                ' Gera uma senha aleatória de 4 números e 2 letras
                Dim senhaGerada As String = GerarSenha()

                ' Query SQL para adicionar o usuário
                Dim sql As String = "INSERT INTO Usuarios (Nome_Usuario, Senha, Cargo, Email, Contacto_telf) VALUES (@NomeUsuario, @Senha, @Cargo, @Email, @Contacto_telf)"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@NomeUsuario", NomeUsuario)
                cmd.Parameters.AddWithValue("@Senha", senhaGerada)
                cmd.Parameters.AddWithValue("@Cargo", Cargo)
                cmd.Parameters.AddWithValue("@Email", Email)
                cmd.Parameters.AddWithValue("@Contacto_telf", Contacto_telf)

                ' Executa a consulta SQL
                cmd.ExecuteNonQuery()

                ' Limpa os campos após adicionar o usuário
                LimparCampos()

                ' Atualiza a DataGridView com os usuários
                PreencherUsuarios()

                ' Exibe a senha gerada
                MsgBox("Usuário adicionado com sucesso! Senha gerada: " & senhaGerada)
            End If
        Catch ex As Exception
            ' Exibe uma mensagem de erro em caso de falha
            MsgBox(ex.Message)
        Finally
            ' Fecha a conexão com o banco de dados
            conn.Close()
        End Try
    End Sub

    ' Método para gerar uma senha aleatória de 4 números e 2 letras
    Private Function GerarSenha() As String
        Dim senha As New StringBuilder()
        Dim random As New Random()
        Dim letras As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim numeros As String = "0123456789"

        ' Gera 4 números aleatórios
        For i As Integer = 1 To 4
            senha.Append(numeros(random.Next(0, numeros.Length)))
        Next

        ' Gera 2 letras aleatórias
        For i As Integer = 1 To 2
            senha.Append(letras(random.Next(0, letras.Length)))
        Next

        ' Embaralha a senha
        For i As Integer = 0 To senha.Length - 1
            Dim temp As Char = senha(i)
            Dim index As Integer = random.Next(i, senha.Length)
            senha(i) = senha(index)
            senha(index) = temp
        Next

        Return senha.ToString()
    End Function

    ' Método para editar um usuário existente
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        ' Obtém o valor do NomeUsuario a partir do TextBox
        Dim NomeUsuario As String = TextBoxNomeUsuario.Text

        ' Obtém os valores dos outros campos
        Dim Cargo As String = ComboBoxCargo.Text
        Dim Email As String = TextBoxEmail.Text
        Dim Contacto_telf As String = TextBoxContacto.Text

        ' Inicializa a conexão com o banco de dados
        conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

        Try
            ' Abre a conexão com o banco de dados
            conn.Open()

            ' Query SQL para verificar se o usuário existe
            Dim verificaUsuarioSQL As String = "SELECT COUNT(*) FROM Usuarios WHERE Nome_Usuario = @NomeUsuario"
            Dim cmdVerificaUsuario As MySqlCommand = New MySqlCommand(verificaUsuarioSQL, conn)
            cmdVerificaUsuario.Parameters.AddWithValue("@NomeUsuario", NomeUsuario)
            Dim usuarioExistente As Integer = Convert.ToInt32(cmdVerificaUsuario.ExecuteScalar())

            If usuarioExistente > 0 Then
                ' Query SQL para atualizar o usuário
                Dim sql As String = "UPDATE Usuarios SET Cargo = @Cargo, Email = @Email, Contacto_telf = @Contacto_telf WHERE Nome_Usuario = @NomeUsuario"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@NomeUsuario", NomeUsuario)
                cmd.Parameters.AddWithValue("@Cargo", Cargo)
                cmd.Parameters.AddWithValue("@Email", Email)
                cmd.Parameters.AddWithValue("@Contacto_telf", Contacto_telf)

                ' Executa a consulta SQL
                cmd.ExecuteNonQuery()

                ' Limpa os campos após editar o usuário
                LimparCampos()

                ' Atualiza a DataGridView com os usuários
                PreencherUsuarios()

                MsgBox("Usuário editado com sucesso!")
            Else
                ' Exibe uma mensagem de erro se o usuário não existir
                MsgBox("Usuário não encontrado no sistema. Por favor, verifique os dados.")
            End If
        Catch ex As Exception
            ' Exibe uma mensagem de erro em caso de falha
            MsgBox(ex.Message)
        Finally
            ' Fecha a conexão com o banco de dados
            conn.Close()
        End Try
    End Sub

    ' Método para deletar um usuário
    Private Sub BtnDeletar_Click(sender As Object, e As EventArgs) Handles BtnDeletar.Click
        ' Obtém o valor do NomeUsuario a partir do TextBox
        Dim NomeUsuario As String = TextBoxNomeUsuario.Text

        ' Inicializa a conexão com o banco de dados
        conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

        Try
            ' Abre a conexão com o banco de dados
            conn.Open()

            ' Query SQL para verificar se o usuário existe
            Dim verificaUsuarioSQL As String = "SELECT COUNT(*) FROM Usuarios WHERE Nome_Usuario = @NomeUsuario"
            Dim cmdVerificaUsuario As MySqlCommand = New MySqlCommand(verificaUsuarioSQL, conn)
            cmdVerificaUsuario.Parameters.AddWithValue("@NomeUsuario", NomeUsuario)
            Dim usuarioExistente As Integer = Convert.ToInt32(cmdVerificaUsuario.ExecuteScalar())

            If usuarioExistente > 0 Then
                ' Query SQL para deletar o usuário
                Dim sql As String = "DELETE FROM Usuarios WHERE Nome_Usuario = @NomeUsuario"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@NomeUsuario", NomeUsuario)

                ' Executa a consulta SQL
                cmd.ExecuteNonQuery()

                ' Limpa os campos após deletar o usuário
                LimparCampos()

                ' Atualiza a DataGridView com os usuários
                PreencherUsuarios()

                MsgBox("Usuário deletado com sucesso!")
            Else
                ' Exibe uma mensagem de erro se o usuário não existir
                MsgBox("Usuário não encontrado no sistema. Por favor, verifique os dados.")
            End If
        Catch ex As Exception
            ' Exibe uma mensagem de erro em caso de falha
            MsgBox(ex.Message)
        Finally
            ' Fecha a conexão com o banco de dados
            conn.Close()
        End Try
    End Sub

    ' Método para limpar os campos
    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        LimparCampos()
    End Sub

    ' Método para limpar todos os campos
    Private Sub LimparCampos()
        TextBoxNomeUsuario.Clear()
        TextBoxApelido.Clear()
        TextBoxSenha.Clear()
        ComboBoxCargo.SelectedIndex = -1
        TextBoxIdUsuario.Clear()
        TextBoxEmail.Clear()
        TextBoxContacto.Clear()
    End Sub

    ' Método para preencher a ComboBox com os cargos dentro de um restaurante
    Private Sub PreencherComboBoxCargos()
        ' Adicione aqui os cargos desejados
        ComboBoxCargo.Items.Add("Garçom")
        ComboBoxCargo.Items.Add("Cozinheiro")
        ComboBoxCargo.Items.Add("Atendente")
        ComboBoxCargo.Items.Add("Gerente")
        ComboBoxCargo.Items.Add("Auxiliar de Cozinha")
        ComboBoxCargo.Items.Add("Supervisor de Salão")
        ComboBoxCargo.Items.Add("Barista")
        ComboBoxCargo.Items.Add("Admin")
        ' Adicione quantos cargos você precisar
    End Sub

    ' Método para buscar informações do usuário por Nome_Usuario
    Private Sub BuscarInformacoesPorNomeUsuario(NomeUsuario As String)
        ' Inicializa a conexão com o banco de dados
        conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

        Try
            ' Abre a conexão com o banco de dados
            conn.Open()

            ' Query SQL para buscar informações do usuário por Nome_Usuario
            Dim sql As String = "SELECT * FROM Usuarios WHERE Nome_Usuario = @NomeUsuario"
            Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@NomeUsuario", NomeUsuario)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Se o usuário for encontrado, preenche os campos
            If reader.Read() Then
                TextBoxNomeUsuario.Text = reader("Nome_Usuario").ToString()
                ComboBoxCargo.Text = reader("Cargo").ToString()
                TextBoxEmail.Text = reader("Email").ToString()
                TextBoxContacto.Text = reader("Contacto_telf").ToString()
            Else
                ' Limpa os campos (exceto o Nome_Usuario) se o usuário não for encontrado
                LimparCamposExcetoNomeUsuario()
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

    ' Método para limpar os campos (exceto o Nome_Usuario)
    Private Sub LimparCamposExcetoNomeUsuario()
        ComboBoxCargo.SelectedIndex = -1
        TextBoxEmail.Clear()
        TextBoxContacto.Clear()
    End Sub

    ' Método para realizar a pesquisa de usuários por Nome_Usuario, Cargo, Email ou Contacto_telf
    Private Sub TextBoxPesquisa_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPesquisa.TextChanged
        ' Obtém o texto da pesquisa
        Dim pesquisa As String = TextBoxPesquisa.Text

        ' Inicializa a conexão com o banco de dados
        conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

        Try
            ' Abre a conexão com o banco de dados
            conn.Open()

            ' Query SQL para realizar a pesquisa
            Dim sql As String = "SELECT * FROM Usuarios WHERE Nome_Usuario LIKE @pesquisa OR Cargo LIKE @pesquisa OR Email LIKE @pesquisa OR Contacto_telf LIKE @pesquisa"
            Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@pesquisa", "%" & pesquisa & "%")

            Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()

            ' Preenche o DataSet com os resultados da pesquisa
            adapter.Fill(ds, "Usuarios")

            ' Define a fonte de dados da DataGridView como o DataSet
            DataGridViewUsuario.DataSource = ds.Tables("Usuarios")
        Catch ex As Exception
            ' Exibe uma mensagem de erro em caso de falha
            MsgBox(ex.Message)
        Finally
            ' Fecha a conexão com o banco de dados
            conn.Close()
        End Try
    End Sub

    ' Evento ao carregar o formulário
    Private Sub GerenciarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Preenche a ComboBox com os cargos disponíveis
        PreencherComboBoxCargos()

        ' Preenche a DataGridView com os usuários
        PreencherUsuarios()
    End Sub

    ' Evento ao selecionar uma linha na DataGridView
    Private Sub DataGridViewUsuario_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewUsuario.SelectionChanged
        ' Verifica se há pelo menos uma linha selecionada
        If DataGridViewUsuario.SelectedRows.Count > 0 Then
            ' Obtém o valor da célula "Nome_Usuario" da linha selecionada
            Dim NomeUsuario As String = DataGridViewUsuario.SelectedRows(0).Cells("Nome_Usuario").Value.ToString()

            ' Busca informações do usuário por Nome_Usuario e preenche os campos
            BuscarInformacoesPorNomeUsuario(NomeUsuario)
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

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        LoginForm1.Show()
    End Sub
End Class