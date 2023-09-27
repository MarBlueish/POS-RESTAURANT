Public Class HomeForm

    ' Declaração da propriedade NomeUsuario
    Public Property NomeUsuario As String

    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles BtnAbout.Click

        AboutBox1.Show()
    End Sub

    Private Sub BtnFornecedor_Click(sender As Object, e As EventArgs) Handles BtnFornecedor.Click

        FornecedorForm.Show()
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



    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        End
    End Sub



    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click

        LoginForm1.Show()
    End Sub

    Private Sub BtnMesas_Click(sender As Object, e As EventArgs) Handles BtnMesas.Click

        MesasForm.Show()
    End Sub





End Class
