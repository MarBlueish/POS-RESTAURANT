Imports System.IO
'Imports iTextSharp.text
'Imports iTextSharp.text.pdf
Imports System.Windows.Forms
Imports System.Text
Imports System.Reflection.Metadata

Public Class PagamentoForm

    Private Sub Pagamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboPag.Items.Add("Dinheiro")
        cboPag.Items.Add("Multibanco")
        cboPag.Items.Add("MB Way")
        cboPag.Items.Add("Débito Automático")
        cboPag.Items.Add("Cartão Visa")
        cboPag.Items.Add("Cartão Mastercard")

        TextBoxCusto.Text = "0.00 €"
        TextBoxTroco.Text = "0.00 €"
    End Sub

    Private Function Custo_Item() As Double
        Dim Sum As Double = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            Sum = Sum + Convert.ToDouble(DataGridView1.Rows(i).Cells(2).Value)
        Next i
        Return Sum
    End Function

    Private Sub AtualizarLabels()
        Dim iva As Double = 0.23
        Dim subtotal As Double = Custo_Item()
        TextBoxSubTotal.Text = Format(subtotal, "N2") & " €"

        Dim ivaValor As Double = Math.Round(subtotal * iva, 2)
        TextBoxIva.Text = Format(ivaValor, "N2") & " €"

        Dim total As Double = Math.Round(subtotal + ivaValor, 2)
        TextBoxTotal.Text = Format(total, "N2") & " €"

        Dim pago As Double = Val(TextBoxCusto.Text)
        If pago >= total Then
            Dim troco As Double = pago - total
            TextBoxTroco.Text = Format(troco, "N2") & " €"
        Else
            TextBoxTroco.Text = ""
        End If
    End Sub

    Private Sub LimparCampos()
        TextBoxTroco.Text = ""
        TextBoxCusto.Text = "0.00 €"
        TextBoxSubTotal.Text = "0.00 €"
        TextBoxTotal.Text = "0.00 €"
        TextBoxIva.Text = "0.00 €"
        cboPag.Text = ""
        DataGridView1.Rows.Clear()
        AtualizarLabels()
    End Sub

    Private Sub LimparValorPagamento()
        TextBoxCusto.Text = "0.00 €"
        cboPag.Text = ""
        TextBoxTroco.Text = ""
    End Sub

    Private Sub CalcularTroco()
        If cboPag.Text = "Dinheiro" Then
            Dim pago As Double = Val(TextBoxCusto.Text)
            Dim total As Double = Val(TextBoxTotal.Text)

            If pago >= total Then
                Dim troco As Double = pago - total
                TextBoxTroco.Text = Format(troco, "N2") & " €"
            Else
                TextBoxTroco.Text = ""
            End If
        Else
            TextBoxTroco.Text = "0"
        End If

        AtualizarLabels()
    End Sub

    Private Sub BtnC_Click(sender As Object, e As EventArgs) Handles BtnC.Click
        LimparValorPagamento()
    End Sub

    Private Sub NumbersOnly(sender As Object, e As EventArgs) Handles Btn0.Click, Btn1.Click, Btn2.Click, Btn3.Click, Btn4.Click, Btn5.Click, Btn6.Click, Btn7.Click, Btn8.Click, Btn9.Click, Btn_dot.Click
        Dim B As Button = sender

        If TextBoxCusto.Text = "0.00 €" Then
            TextBoxCusto.Text = ""
            TextBoxCusto.Text = B.Text
        ElseIf B.Text = "." Then
            If Not TextBoxCusto.Text.Contains(".") Then
                TextBoxCusto.Text = TextBoxCusto.Text + B.Text
            End If
        Else
            TextBoxCusto.Text = TextBoxCusto.Text + B.Text
        End If
    End Sub

    Private Sub Btn_Imprimir_Click(sender As Object, e As EventArgs) Handles Btn_Imprimir.Click
        Dim height As Integer = DataGridView1.Height
        DataGridView1.Height = (DataGridView1.RowCount + 1) * DataGridView1.RowTemplate.Height
        Dim bitmap As Bitmap = New Bitmap(DataGridView1.Width, DataGridView1.Height)
        DataGridView1.DrawToBitmap(bitmap, New Rectangle(0, 0, DataGridView1.Width, DataGridView1.Height))

        Using printDocument As New Printing.PrintDocument()
            Dim printDialog As New PrintDialog()
            printDialog.Document = printDocument
            If printDialog.ShowDialog() = DialogResult.OK Then
                printDocument.Print()
            End If
        End Using

        DataGridView1.Height = height
    End Sub

    Private Sub AdicionarProduto(nomeProduto As String, precoProduto As Double)
        Dim CustodeItem As Double = precoProduto
        Dim found As Boolean = False

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = nomeProduto Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Math.Round(Double.Parse(row.Cells(1).Value) * CustodeItem, 2)
                found = True
                Exit For
            End If
        Next

        If Not found Then
            DataGridView1.Rows.Add(nomeProduto, 1, Math.Round(CustodeItem, 2))
        End If

        AtualizarLabels()
    End Sub

    Private Sub BtnMesa1_Click(sender As Object, e As EventArgs)
        AdicionarProduto("Capp Coffee", 2.3)
    End Sub

    Private Sub BtnPagamento_Click(sender As Object, e As EventArgs) Handles BtnPagamento.Click
        CalcularTroco()
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        LimparCampos()
    End Sub

    Private Sub BtnRemover_Click(sender As Object, e As EventArgs) Handles BtnRemover.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                DataGridView1.Rows.Remove(row)
            Next
            AtualizarLabels()

            Dim pago As Double = Val(TextBoxCusto.Text)
            Dim total As Double = Val(TextBoxTotal.Text)

            If pago >= total Then
                Dim troco As Double = pago - total
                TextBoxTroco.Text = Format(troco, "N2") & " €"
            Else
                TextBoxTroco.Text = ""
            End If
        Else
            TextBoxTroco.Text = "0"
        End If
    End Sub

    Private Sub BtnMesa1_Click_1(sender As Object, e As EventArgs) Handles BtnMesa1.Click
        AdicionarProduto("Capp Coffee", 2.3)
    End Sub

    Private Sub BtnMesa2_Click(sender As Object, e As EventArgs) Handles BtnMesa2.Click
        AdicionarProduto("Coffee Cappuccino", 1.9)
    End Sub

    Private Sub BtnMesa3_Click(sender As Object, e As EventArgs) Handles BtnMesa3.Click
        AdicionarProduto("Melinda", 0.9)
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
    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        End
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Close()
        LoginForm1.Show()
    End Sub
End Class