Imports MySql.Data.MySqlClient

Public Class LoginForm1
    ' String de conexão com o banco de dados MySQL
    Private connectionString As String = "Server=127.0.0.1;User=root;Password=;Database=restaurante1"

    ' Contador de tentativas de login
    Private loginAttempts As Integer = 0

    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click
        ' Obtém o nome de usuário e senha digitados pelo usuário
        Dim username As String = TextBoxUser.Text
        Dim password As String = TextBoxPassword.Text

        ' Abre a conexão com o banco de dados
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Consulta SQL para selecionar o usuário com nome de usuário correspondente
            Dim query As String = "SELECT * FROM Usuarios WHERE Nome_Usuario = @username"
            Using command As New MySqlCommand(query, connection)
                ' Adiciona parâmetros para evitar a injeção de SQL
                command.Parameters.AddWithValue("@username", username)

                ' Executa a consulta SQL
                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.HasRows Then
                    ' Usuário encontrado na tabela Usuarios
                    reader.Read()
                    Dim senhaArmazenada As String = reader("Senha").ToString()
                    Dim nomeUsuario As String = reader("Nome_Usuario").ToString()
                    Dim idUsuario As Integer = reader("ID_Usuario")

                    ' Fecha o DataReader após a consulta
                    reader.Close()

                    If password = senhaArmazenada Then
                        ' Credenciais válidas

                        ' Verifica se o usuário já está logado
                        If UsuarioJaLogado(idUsuario) Then
                            MessageBox.Show("Usuário já está logado em outro dispositivo. Verifique seus dados e tente novamente.")
                            TextBoxUser.Clear()
                            TextBoxPassword.Clear()
                            Return
                        End If

                        ' Registra a data e hora de login
                        Dim dataLogin As DateTime = DateTime.Now

                        ' Insere os dados de login na tabela DataLogin usando uma nova conexão
                        Using insertConnection As New MySqlConnection(connectionString)
                            insertConnection.Open()

                            ' Insere o registro de login
                            Dim insertLoginQuery As String = "INSERT INTO DataLogin (id_login, Data_De_Login, Data_De_Logout) VALUES (@id_login, @Data_De_Login, NULL)"
                            Using insertLoginCommand As New MySqlCommand(insertLoginQuery, insertConnection)
                                insertLoginCommand.Parameters.AddWithValue("@id_login", idUsuario)
                                insertLoginCommand.Parameters.AddWithValue("@Data_De_Login", dataLogin)
                                insertLoginCommand.ExecuteNonQuery()
                            End Using
                        End Using

                        ' Exibe uma mensagem de boas-vindas com o nome do usuário
                        MessageBox.Show("Bem-vindo, " & nomeUsuario & "!")

                        ' Direciona para o formulário HomeForm após o login bem-sucedido


                        ' Fecha o formulário de login
                        Me.Hide()
                        HomeForm.Show()


                    Else
                        ' Senha incorreta
                        loginAttempts += 1

                        If loginAttempts >= 3 Then
                            ' Bloquear o usuário após três tentativas malsucedidas
                            MessageBox.Show("Tentativas de login excedidas. Contate um administrador para obter assistência.")
                            End
                        Else
                            ' Exibe uma mensagem de erro
                            MessageBox.Show("Senha incorreta. Tentativa " & loginAttempts & " de 3.")
                            TextBoxPassword.Clear()
                        End If
                    End If
                Else
                    ' Nome de usuário não encontrado na tabela Usuarios
                    MessageBox.Show("Os dados inseridos não correspondem a nenhum usuário.")
                    TextBoxUser.Clear()
                    TextBoxPassword.Clear()
                End If
            End Using
        End Using

        ' Verifica se o nome de usuário foi digitado exatamente conforme definido (sensível a maiúsculas e minúsculas)
        If Not IsUsernameCaseSensitive(username) Then
            ' Exibe uma mensagem de alerta
            MessageBox.Show("Verifique se o usuário foi digitado conforme definições. Caso contrário, contate o Administrador.")
        End If
    End Sub

    Private Function UsuarioJaLogado(idUsuario As Integer) As Boolean
        ' Verifica se o usuário já está logado em outro dispositivo
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Consulta SQL para verificar se há um registro de login ativo para o usuário
            Dim query As String = "SELECT * FROM DataLogin WHERE id_login = @id_login AND Data_De_Logout IS NULL"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id_login", idUsuario)
                Dim existingLogin As Object = command.ExecuteScalar()

                If existingLogin IsNot Nothing Then
                    ' Já existe um registro de login ativo para o usuário
                    Return True
                End If
            End Using
        End Using

        Return False
    End Function

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        ' Fechar o aplicativo
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Limpa os campos de usuário e senha
        TextBoxUser.Text = ""
        TextBoxPassword.Text = ""
    End Sub

    Private Function IsUsernameCaseSensitive(username As String) As Boolean
        ' Consulta SQL para verificar se o nome de usuário é sensível a maiúsculas e minúsculas
        Dim query As String = "SELECT * FROM Usuarios WHERE Nome_Usuario COLLATE utf8_bin = @username"
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Using command As New MySqlCommand(query, connection)
                ' Adiciona parâmetros para evitar a injeção de SQL
                command.Parameters.AddWithValue("@username", username)

                ' Fecha qualquer DataReader aberto anteriormente, se houver
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    reader.Close()
                End If

                ' Executa a consulta SQL novamente
                Dim newReader As MySqlDataReader = command.ExecuteReader()
                Return newReader.HasRows
            End Using
        End Using
    End Function

    Private Sub lblEsqueciSenha_Click(sender As Object, e As EventArgs) Handles lblEsqueciSenha.Click

        RecuperarSenhaForm.Show()
    End Sub


End Class
