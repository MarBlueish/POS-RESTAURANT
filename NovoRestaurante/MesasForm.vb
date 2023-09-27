Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class MesasForm


    ' Declaração da conexão com o banco de dados
    Private conn As MySqlConnection

    ' Evento que é acionado ao carregar o formulário
    Private Sub GerenciarMesas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Preenche o ComboBox de Status
        PreencherComboBoxStatus()
        ' Atualiza a lista de mesas no DataGridView
        AtualizarListaMesas()
    End Sub

    ' Preenche o ComboBox de Status com as opções
    Private Sub PreencherComboBoxStatus()
        ComboBoxStatus.Items.Add("Disponível")
        ComboBoxStatus.Items.Add("Ocupada")
    End Sub

    ' Atualiza a lista de mesas no DataGridView
    Private Sub AtualizarListaMesas()
        ' Configura a conexão com o banco de dados
        conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

        Try
            conn.Open()

            ' Consulta SQL para obter todas as mesas
            Dim sql As String = "SELECT * FROM mesas"
            Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            Dim builder As MySqlCommandBuilder = New MySqlCommandBuilder(adapter)
            Dim ds As DataSet = New DataSet()
            adapter.Fill(ds, "mesas")

            ' Define o resultado da consulta como fonte de dados do DataGridView
            DataGridViewMesas.DataSource = ds.Tables("mesas")
        Catch ex As Exception
            ' Exibe mensagem de erro em caso de falha na conexão ou consulta
            MsgBox(ex.Message)
        Finally
            ' Fecha a conexão com o banco de dados
            conn.Close()
        End Try
    End Sub

    ' Evento acionado ao alterar o texto em TextBoxMesaID
    Private Sub TextBoxMesaID_TextChanged(sender As Object, e As EventArgs) Handles TextBoxMesaID.TextChanged
        ' Obtém o número da mesa da TextBoxMesaID
        Dim numeroMesa As Integer

        If Integer.TryParse(TextBoxMesaID.Text, numeroMesa) AndAlso numeroMesa > 0 Then
            ' Consulta SQL para obter os detalhes da mesa com base no número da mesa
            ' Certifique-se de ajustar a conexão e a consulta de acordo com o seu banco de dados
            conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")
            conn.Open()

            Dim query As String = "SELECT Mesa_numero, Status FROM mesas WHERE ID_Mesa = @MesaID"
            Dim cmd As MySqlCommand = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@MesaID", numeroMesa)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' Preenche TextBoxMesaNumero e ComboBoxStatus com os dados da mesa
                TextBoxMesaNumero.Text = reader("Mesa_numero").ToString()
                ComboBoxStatus.Text = reader("Status").ToString()
            Else
                ' Limpa os campos se não houver correspondência
                TextBoxMesaNumero.Clear()
                ComboBoxStatus.SelectedIndex = -1
            End If

            reader.Close()
            conn.Close()
        Else
            ' Limpa os campos se o número da mesa não for válido
            TextBoxMesaNumero.Clear()
            ComboBoxStatus.SelectedIndex = -1
        End If
    End Sub

    ' Limpa os campos do formulário
    Private Sub LimparCampos()
        TextBoxMesaID.Clear()
        TextBoxMesaNumero.Clear()
        ComboBoxStatus.SelectedIndex = -1
    End Sub

    ' Evento acionado ao clicar no botão Adicionar
    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click
        ' Configura a conexão com o banco de dados
        conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

        Try
            conn.Open()

            ' Verifica se a ComboBoxStatus tem um item selecionado
            If String.IsNullOrEmpty(ComboBoxStatus.Text) Then
                MsgBox("Selecione um status para a mesa.")
                Return
            End If

            Dim numeroMesa As Integer

            If String.IsNullOrEmpty(TextBoxMesaNumero.Text.Trim()) Then
                ' Se o campo estiver vazio, defina o número da mesa como 1
                numeroMesa = 1
            ElseIf Not Integer.TryParse(TextBoxMesaNumero.Text, numeroMesa) Then
                ' Se o campo não for um número válido, defina o número da mesa como 1
                numeroMesa = 1
            ElseIf numeroMesa = 0 Then
                ' Se o número da mesa for zero, defina como 1
                numeroMesa = 1
            End If

            ' Verifica se o número da mesa já existe na base de dados
            If MesaNumeroExiste(numeroMesa) Then
                MsgBox("O número da mesa já existe. Escolha outro número.")
            Else
                ' Caso contrário, insira o novo número da mesa
                Dim query As String = "INSERT INTO mesas (Mesa_numero, Nmr_Lugares, Status) VALUES (@Numero, @NmrLugares, @Status)"
                Dim cmd As MySqlCommand = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Numero", numeroMesa)
                cmd.Parameters.AddWithValue("@NmrLugares", 4) ' Você pode definir o número de lugares aqui
                cmd.Parameters.AddWithValue("@Status", ComboBoxStatus.Text)

                cmd.ExecuteNonQuery()

                MsgBox("Mesa adicionada com sucesso.")
                LimparCampos()
                AtualizarListaMesas()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Function MesaNumeroExiste(numeroMesa As Integer) As Boolean
        ' Verifica se o número da mesa já existe na base de dados
        Dim sqlCheckNumber As String = "SELECT COUNT(*) FROM mesas WHERE Mesa_numero = @Numero"
        Dim cmdCheckNumber As MySqlCommand = New MySqlCommand(sqlCheckNumber, conn)
        cmdCheckNumber.Parameters.AddWithValue("@Numero", numeroMesa)

        Dim count As Integer = CInt(cmdCheckNumber.ExecuteScalar())
        Return count > 0
    End Function

    ' Evento acionado ao clicar no botão Editar
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        ' Obtém o ID da mesa a partir do TextBoxMesaID
        Dim id As Integer

        If Integer.TryParse(TextBoxMesaID.Text, id) AndAlso id > 0 Then
            ' Obtém o número da mesa a partir do TextBoxMesaNumero
            Dim numeroMesa As Integer

            If Integer.TryParse(TextBoxMesaNumero.Text, numeroMesa) Then
                ' Configura a conexão com o banco de dados
                conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

                Try
                    conn.Open()

                    ' Consulta SQL para atualizar os dados da mesa
                    Dim query As String = "UPDATE mesas SET Mesa_numero = @Numero, Status = @Status WHERE ID_Mesa = @ID"
                    Dim cmd As MySqlCommand = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Numero", numeroMesa)
                    cmd.Parameters.AddWithValue("@Status", ComboBoxStatus.Text)
                    cmd.Parameters.AddWithValue("@ID", id)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        ' Exibe mensagem de sucesso
                        MsgBox("Mesa editada com sucesso.")

                        ' Limpa os campos (exceto TextBoxMesaID)
                        LimparCampos()

                        ' Atualiza a lista de mesas
                        AtualizarListaMesas()
                    Else
                        ' Exibe mensagem se nenhuma mesa for encontrada para edição
                        MsgBox("Nenhuma mesa foi encontrada para edição.")
                    End If
                Catch ex As Exception
                    ' Exibe mensagem de erro em caso de falha na operação
                    MsgBox(ex.Message)
                Finally
                    ' Fecha a conexão com o banco de dados
                    conn.Close()
                End Try
            Else
                ' Exibe mensagem de erro se o número da mesa não for válido
                MsgBox("O número da mesa deve ser um número inteiro válido.")
            End If
        Else
            ' Exibe mensagem se o ID não for válido
            MsgBox("Informe um ID válido para editar.")
        End If
    End Sub

    ' Evento acionado ao clicar no botão Deletar
    Private Sub BtnDeletar_Click(sender As Object, e As EventArgs) Handles BtnDeletar.Click
        ' Obtém o ID da mesa a partir do TextBoxMesaID
        Dim id As Integer

        If Integer.TryParse(TextBoxMesaID.Text, id) AndAlso id > 0 Then
            ' Configura a conexão com o banco de dados
            conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

            Try
                conn.Open()

                ' Consulta SQL para excluir a mesa com base no ID
                Dim query As String = "DELETE FROM mesas WHERE ID_Mesa = @ID"
                Dim cmd As MySqlCommand = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", id)
                cmd.ExecuteNonQuery()

                ' Exibe mensagem de sucesso
                MsgBox("Mesa excluída com sucesso.")

                ' Limpa os campos (exceto TextBoxMesaID)
                LimparCampos()

                ' Atualiza a lista de mesas
                AtualizarListaMesas()
            Catch ex As Exception
                ' Exibe mensagem de erro em caso de falha na operação
                MsgBox(ex.Message)
            Finally
                ' Fecha a conexão com o banco de dados
                conn.Close()
            End Try
        Else
            ' Exibe mensagem se o ID não for válido
            MsgBox("Informe um ID válido para excluir.")
        End If
    End Sub

    ' Evento acionado ao clicar no botão Limpar
    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        ' Limpa os campos (exceto TextBoxMesaID)
        LimparCampos()
    End Sub

    ' Evento acionado ao clicar no botão Fechar
    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        End
    End Sub

    ' Evento acionado ao clicar em uma célula do DataGridView
    Private Sub DataGridViewMesas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMesas.CellClick
        ' Manipula o evento de clique em uma célula do DataGridView
        If e.RowIndex >= 0 Then
            ' Obtém o ID da mesa a partir do DataGridView
            Dim id As Integer

            If Integer.TryParse(DataGridViewMesas.Rows(e.RowIndex).Cells("ID_Mesa").Value.ToString(), id) Then
                TextBoxMesaID.Text = id.ToString()
                PreencherCamposComMesa(id)
            End If
        End If
    End Sub

    ' Preenche os campos com os dados da mesa com base no ID
    Private Sub PreencherCamposComMesa(id As Integer)
        ' Configura a conexão com o banco de dados
        conn = New MySqlConnection("server=127.0.0.1;user=root;password=;database=restaurante1")

        Try
            conn.Open()

            ' Consulta SQL para obter os dados da mesa com base no ID
            Dim sql As String = "SELECT * FROM mesas WHERE ID_Mesa = @ID"
            Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@ID", id)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' Preenche os campos com os dados da mesa
                TextBoxMesaNumero.Text = reader("Mesa_numero").ToString()
                ComboBoxStatus.Text = reader("Status").ToString()
            Else
                ' Limpa os campos se a mesa não for encontrada
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
        Dim query As String = "SELECT * FROM mesas WHERE Mesa_numero LIKE @pesquisa OR Status LIKE @pesquisa"

        Try
            ' Abre a conexão com o banco de dados
            conn.Open()

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@pesquisa", pesquisa)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dataSet As New DataSet()

            adapter.Fill(dataSet, "mesas")

            ' Verifica se há resultados da pesquisa
            If dataSet.Tables("mesas").Rows.Count > 0 Then
                ' Exibe os resultados no DataGridView
                DataGridViewMesas.DataSource = dataSet.Tables("mesas")
            Else
                ' Caso não haja resultados, exibe uma mensagem
                MessageBox.Show("Nenhuma mesa encontrada.")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ' Fecha a conexão com o banco de dados
            conn.Close()
        End Try
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

    Private Sub Ementa_Click(sender As Object, e As EventArgs) Handles Ementa.Click
        Me.Close()
        PratosForm.Show()
    End Sub



End Class