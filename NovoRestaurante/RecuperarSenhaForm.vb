Imports System.Net ' Biblioteca para suporte a recursos de rede
Imports System.Net.Mail ' Biblioteca para enviar e-mails
Imports MySql.Data.MySqlClient ' Biblioteca para conexão com MySQL
Imports System.Text ' Biblioteca para manipulação de strings
Imports System.Security.Cryptography ' Biblioteca para funções de criptografia
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class RecuperarSenhaForm


    ' Variáveis para armazenar dados
    Dim verificationCode As String ' Código de verificação gerado
    Dim username As String = "suportejmdgourmed@gmail.com" ' Seu endereço de e-mail do Gmail
    Dim password As String = "r u c g h s u i c m t h n a d w" ' Sua senha do Gmail
    Dim connectionString As String = "server=127.0.0.1;user=root;password=;database=restaurante1" ' String de conexão com o banco de dados MySQL
    Dim conn As MySqlConnection ' Objeto de conexão MySQL
    Dim emailVerificationCode As String ' Código de verificação enviado por e-mail

    ' Evento acionado ao enviar um e-mail de verificação
    Private Sub SendVerificationCodeEmail(toEmail As String, code As String)
        Try
            ' Cria uma nova conexão
            Using conn As New MySqlConnection(connectionString)
                ' Abre a conexão com o banco de dados
                conn.Open()

                ' Verifica se o e-mail e a senha correspondem aos registros no banco de dados
                If VerifyCredentials(TextBoxEmail.Text, TextBoxNomeUsuario.Text, conn) Then
                    Dim fromAddress As New MailAddress("noreply@suportegourmet.com", "suportejmdgourmed")
                    Dim toAddress As New MailAddress(toEmail)
                    Dim subject As String = "Verifique seu endereço de e-mail e senha"
                    Dim body As String = String.Format("Use o seguinte código para verificar seu endereço de e-mail para o software: {0}", code)

                    Dim smtp As New SmtpClient()
                    smtp.Host = "smtp.gmail.com"
                    smtp.Port = 587
                    smtp.EnableSsl = True
                    smtp.Credentials = New NetworkCredential(username, password)

                    Dim message As New MailMessage(fromAddress, toAddress)
                    message.Subject = subject
                    message.Body = body

                    smtp.Send(message)

                    ' Armazena o código enviado por e-mail na variável
                    emailVerificationCode = code
                    MsgBox("E-mail de verificação enviado. Por favor, verifique seu e-mail.")
                    BtnVerificar.Visible = True
                Else
                    MsgBox("Os dados de Nome de Usuário e Email digitados não correspondem aos registros no banco de dados.")
                End If
            End Using
        Catch ex As Exception
            MsgBox("Falha ao enviar o e-mail de verificação: " & ex.Message)
        End Try
    End Sub

    ' Função para verificar as credenciais do usuário no banco de dados
    Private Function VerifyCredentials(email As String, nomeUsuario As String, conn As MySqlConnection) As Boolean
        Try
            ' Consulta SQL para verificar as credenciais
            Dim query As String = "SELECT Nome_Usuario, Email FROM Usuarios WHERE Email = @Email AND Nome_Usuario = @NomeUsuario COLLATE utf8mb4_general_ci"
            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@Email", email)
                command.Parameters.AddWithValue("@NomeUsuario", nomeUsuario)

                ' Executa a consulta e verifica se há registros correspondentes
                Using reader As MySqlDataReader = command.ExecuteReader()
                    Return reader.HasRows
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Erro ao verificar credenciais: " & ex.Message)
            Return False
        End Try
    End Function

    ' Evento acionado ao clicar no botão "Verificar"
    Private Sub BtnVerificar_Click(sender As Object, e As EventArgs) Handles BtnVerificar.Click
        Dim enteredCode As String = TextBoxVerificationCode.Text

        If VerifyCode(enteredCode) Then
            MsgBox("Código verificado com sucesso!")
            BtnReporSenha.Visible = True
            BtnLimpar2.Visible = True
            TextBoxRepitaPasse.Visible = True
            TextBoxNovaPasse.Visible = True
            lblNovapasse.Visible = True
            lblRepNovPasse.Visible = True
            BtnVerificar.Visible = False
            TextBoxVerificationCode.Visible = False
        Else
            MsgBox("Falha na verificação de código! Por favor, tente novamente.")
            TextBoxVerificationCode.Clear()
        End If
    End Sub

    ' Evento acionado ao clicar no botão "Enviar E-mail"
    Private Sub BtnEnviarEmail_Click(sender As Object, e As EventArgs) Handles BtnEnviarEmail.Click
        Dim enteredEmail As String = TextBoxEmail.Text
        Dim enteredNomeUsuario As String = TextBoxNomeUsuario.Text

        If enteredNomeUsuario <> "" AndAlso IsValidEmail(enteredEmail) Then
            ' Gere um novo código e armazene na variável
            verificationCode = GenerateVerificationCode(6)
            SendVerificationCodeEmail(enteredEmail, verificationCode)

            ' Oculte e desabilite os controles após o envio do código
            BtnVerificar.Visible = True
            TextBoxVerificationCode.Visible = True
            BtnEnviarEmail.Visible = False
            TextBoxEmail.Visible = False
            TextBoxNomeUsuario.Visible = False
            lblEmail.Visible = False
            lblNomeUsuario.Visible = False
            BtnLimparDados1.Visible = False
        Else
            ' Exiba as labels correspondentes se os campos estiverem vazios
            If enteredNomeUsuario = "" Then
                lblIdUsuarioRecP.Visible = True
            Else
                lblIdUsuarioRecP.Visible = False
            End If

            If Not IsValidEmail(enteredEmail) Then
                lblEmailUsuarioRecP.Visible = True
            Else
                lblEmailUsuarioRecP.Visible = False
            End If

            MsgBox("Por favor, preencha corretamente o nome de usuário e o campo de e-mail.")
        End If
    End Sub



    ' Evento acionado ao clicar no botão "Login"
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Me.Hide()
        LoginForm1.Show()
        ' Aqui você pode adicionar a lógica para redirecionar o usuário para a próxima tela após o login.
    End Sub

    ' Função para validar um endereço de e-mail
    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim addr As New System.Net.Mail.MailAddress(email)
            Return addr.Address = email
        Catch
            Return False
        End Try
    End Function

    ' Função para gerar um código de verificação aleatório
    Private Function GenerateVerificationCode(length As Integer) As String
        Dim chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim sb As New StringBuilder()
        Dim random As New Random()

        For i As Integer = 0 To length - 1
            Dim index As Integer = random.Next(0, chars.Length)
            sb.Append(chars(index))
        Next

        Return sb.ToString()
    End Function

    ' Função para verificar o código inserido pelo usuário
    Private Function VerifyCode(verificationCode As String) As Boolean
        ' Compare o código inserido pelo usuário com o código armazenado na variável
        Return String.Equals(verificationCode, emailVerificationCode)
    End Function

    Private Sub BtnLimparDados1_Click(sender As Object, e As EventArgs) Handles BtnLimparDados1.Click
        TextBoxEmail.Clear()
        TextBoxNomeUsuario.Clear()
    End Sub

    Private Sub BtnLimpar2_Click(sender As Object, e As EventArgs) Handles BtnLimpar2.Click
        TextBoxRepitaPasse.Clear()
        TextBoxNovaPasse.Clear()

    End Sub

    ' Função para obter a senha atual do banco de dados com base no Nome_Usuario e Email
    Private Function GetPasswordFromDatabase(nomeUsuario As String, email As String) As String
        Try
            ' Consulta SQL para obter a senha com base no Nome_Usuario e Email
            Dim query As String = "SELECT Senha FROM Usuarios WHERE Nome_Usuario = @NomeUsuario AND Email = @Email"
            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@NomeUsuario", nomeUsuario)
                command.Parameters.AddWithValue("@Email", email)

                conn.Open()
                Dim senha As String = command.ExecuteScalar()?.ToString()
                conn.Close()

                Return senha
            End Using
        Catch ex As Exception
            MsgBox("Erro ao obter a senha do banco de dados: " & ex.Message)
            Return String.Empty
        End Try
    End Function

    Private Sub BtnReporSenha_Click(sender As Object, e As EventArgs) Handles BtnReporSenha.Click
        ' Verifica se as senhas nas TextBox são iguais
        If TextBoxNovaPasse.Text = TextBoxRepitaPasse.Text Then
            ' Verifica se a nova senha é diferente da senha atual no banco de dados
            If TextBoxNovaPasse.Text <> GetPasswordFromDatabase(TextBoxNomeUsuario.Text, TextBoxEmail.Text) Then
                ' Verifica se a senha contém pelo menos um caractere especial
                If ContainsSpecialCharacter(TextBoxNovaPasse.Text) Then
                    ' Se todas as condições forem atendidas, atualize a senha no banco de dados
                    If UpdatePassword(TextBoxNomeUsuario.Text, TextBoxEmail.Text, TextBoxNovaPasse.Text) Then
                        MsgBox("Senha alterada com sucesso!")
                        BtnReporSenha.Visible = False
                        BtnLimpar2.Visible = False
                        TextBoxRepitaPasse.Visible = False
                        TextBoxNovaPasse.Visible = False
                        lblNovapasse.Visible = False
                        lblRepNovPasse.Visible = False
                        BtnLogin.Visible = True
                        ' Limpa as TextBox de senha
                        TextBoxNovaPasse.Clear()
                        TextBoxRepitaPasse.Clear()
                    Else
                        MsgBox("Erro ao alterar a senha no banco de dados.")
                    End If
                Else
                    MsgBox("A senha deve conter pelo menos um caractere especial.")
                End If
            Else
                MsgBox("A nova senha deve ser diferente da senha atual.")
            End If
        Else
            ' Senhas não coincidem, exibe mensagem e limpa as TextBox
            MsgBox("As senhas não coincidem. Por favor, digite novamente.")
            TextBoxNovaPasse.Clear()
            TextBoxRepitaPasse.Clear()
        End If
    End Sub

    ' Função para verificar se a senha contém pelo menos um caractere especial
    Private Function ContainsSpecialCharacter(password As String) As Boolean
        Dim specialCharacters As String = "!@#$%^&*()_-+=<>?/{}[]|\"
        For Each c As Char In specialCharacters
            If password.Contains(c) Then
                Return True
            End If
        Next
        Return False
    End Function


    ' Função para atualizar a senha no banco de dados
    Private Function UpdatePassword(nomeUsuario As String, email As String, novaSenha As String) As Boolean
        Try
            ' Cria uma nova conexão
            Using conn As New MySqlConnection(connectionString)
                ' Abre a conexão com o banco de dados
                conn.Open()

                ' Atualiza a senha no banco de dados
                Dim query As String = "UPDATE Usuarios SET Senha = @NovaSenha WHERE Nome_Usuario = @NomeUsuario AND Email = @Email"
                Using command As New MySqlCommand(query, conn)
                    command.Parameters.AddWithValue("@NovaSenha", novaSenha)
                    command.Parameters.AddWithValue("@NomeUsuario", nomeUsuario)
                    command.Parameters.AddWithValue("@Email", email)

                    ' Executa a atualização
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        Return True ' Atualização bem-sucedida
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Erro ao atualizar a senha: " & ex.Message)
        End Try

        Return False ' Falha na atualização
    End Function


    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        HomeForm.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Close()
        LoginForm1.Show()
    End Sub
End Class

