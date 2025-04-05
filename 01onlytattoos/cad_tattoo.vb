Public Class cad_tattoo
    Private Sub cad_tattoo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub

    Private Sub AtualizarValortinta(corOuProduto As String, tabela As String, quantidadeMaskedTextBox As MaskedTextBox, valorMaskedTextBox As MaskedTextBox)
        Try
            sql = $"SELECT * FROM {tabela} WHERE cor = '{corOuProduto}'"
            rs = db.Execute(UCase(sql))
            If rs.EOF = False Then
                Dim quantidade As Double
                If Double.TryParse(quantidadeMaskedTextBox.Text, quantidade) Then
                    Dim precoUnitario As Double = Val(rs.Fields(3).Value)
                    valorMaskedTextBox.Text = FormatCurrency(quantidade * precoUnitario, 2)
                Else
                    valorMaskedTextBox.Text = FormatCurrency(0, 2)
                End If
            Else
                valorMaskedTextBox.Text = FormatCurrency(0, 2)
            End If
            AtualizarPassivo()
        Catch ex As Exception
            MsgBox($"Erro ao calcular valor para {corOuProduto}: {ex.Message}", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
    Private Sub AtualizarValorbatoque(corOuProduto As String, tabela As String, quantidadeMaskedTextBox As MaskedTextBox, valorMaskedTextBox As MaskedTextBox)
        Try
            sql = $"SELECT * FROM {tabela} WHERE tamanho = '{corOuProduto}'"
            rs = db.Execute(UCase(sql))
            If rs.EOF = False Then
                Dim quantidade As Double
                If Double.TryParse(quantidadeMaskedTextBox.Text, quantidade) Then
                    Dim precoUnitario As Double = Val(rs.Fields(3).Value)
                    valorMaskedTextBox.Text = FormatCurrency(quantidade * precoUnitario, 2)
                Else
                    valorMaskedTextBox.Text = FormatCurrency(0, 2)
                End If
            Else
                valorMaskedTextBox.Text = FormatCurrency(0, 2)
            End If
            AtualizarPassivo()
        Catch ex As Exception
            MsgBox($"Erro ao calcular valor para {corOuProduto}: {ex.Message}", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
    Private Sub AtualizarValorproduto(corOuProduto As String, tabela As String, quantidadeMaskedTextBox As MaskedTextBox, valorMaskedTextBox As MaskedTextBox)
        Try
            sql = $"SELECT * FROM {tabela} WHERE produto = '{corOuProduto}'"
            rs = db.Execute(UCase(sql))
            If rs.EOF = False Then
                Dim quantidade As Double
                If Double.TryParse(quantidadeMaskedTextBox.Text, quantidade) Then
                    Dim precoUnitario As Double = Val(rs.Fields(3).Value)
                    valorMaskedTextBox.Text = FormatCurrency(quantidade * precoUnitario, 2)
                Else
                    valorMaskedTextBox.Text = FormatCurrency(0, 2)
                End If
            Else
                valorMaskedTextBox.Text = FormatCurrency(0, 2)
            End If
            AtualizarPassivo()
        Catch ex As Exception
            MsgBox($"Erro ao calcular valor para {corOuProduto}: {ex.Message}", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub


    Private Sub AtualizarPassivo()
        Try
            Dim total As Double = 0
            Dim maskedTextBoxes = {preto_valor, branco_valor, amarelo_valor, azul_valor, verde_valor, vermelho_valor, laranja_valor, p_valor, pp_valor, m_valor, g_valor, gg_valor, baixalingua_valor, bandagem_valor, gel_valor, gilete_valor, luva_valor, papelmanteiga_valor, plasticofilme_valor, snob_valor, tintaimpressora_valor, decalque_valor, vaselina_valor}
            For Each maskedTextBox In maskedTextBoxes
                Dim valor As Double = 0
                If Not String.IsNullOrEmpty(maskedTextBox.Text) Then
                    Dim valorLimpo As String = String.Concat(maskedTextBox.Text.Where(Function(c) Char.IsDigit(c) Or c = "."c))
                    If Double.TryParse(valorLimpo, valor) Then
                        total += valor
                    End If
                End If
            Next
            txt_passivo.Text = FormatCurrency(total / 100, 2)
        Catch ex As Exception
            MsgBox($"Erro ao atualizar passivo: {ex.Message}", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub preto_qtd_TextChanged(sender As Object, e As EventArgs) Handles preto_qtd.TextChanged
        AtualizarValortinta("PRETO", "tb_tintas", preto_qtd, preto_valor)
    End Sub

    Private Sub branco_qtd_TextChanged(sender As Object, e As EventArgs) Handles branco_qtd.TextChanged
        AtualizarValortinta("BRANCO", "tb_tintas", branco_qtd, branco_valor)
    End Sub


    Private Sub amarelo_qtd_TextChanged(sender As Object, e As EventArgs) Handles amarelo_qtd.TextChanged
        AtualizarValortinta("amarelo", "tb_tintas", amarelo_qtd, amarelo_valor)
    End Sub

    Private Sub azul_qtd_TextChanged(sender As Object, e As EventArgs) Handles azul_qtd.TextChanged
        AtualizarValortinta("azul", "tb_tintas", azul_qtd, azul_valor)
    End Sub

    Private Sub verde_qtd_TextChanged(sender As Object, e As EventArgs) Handles verde_qtd.TextChanged
        AtualizarValortinta("verde", "tb_tintas", verde_qtd, verde_valor)
    End Sub

    Private Sub vermelho_qtd_TextChanged(sender As Object, e As EventArgs) Handles vermelho_qtd.TextChanged
        AtualizarValortinta("vermelho", "tb_tintas", vermelho_qtd, vermelho_valor)
    End Sub

    Private Sub laranja_qtd_TextChanged(sender As Object, e As EventArgs) Handles laranja_qtd.TextChanged
        AtualizarValortinta("laranja", "tb_tintas", laranja_qtd, laranja_valor)
    End Sub

    Private Sub p_qtd_TextChanged(sender As Object, e As EventArgs) Handles p_qtd.TextChanged
        AtualizarValorbatoque("p", "tb_batoques", p_qtd, p_valor)
    End Sub

    Private Sub pp_qtd_TextChanged(sender As Object, e As EventArgs) Handles pp_qtd.TextChanged
        AtualizarValorbatoque("pp", "tb_batoques", pp_qtd, pp_valor)
    End Sub

    Private Sub m_qtd_TextChanged(sender As Object, e As EventArgs) Handles m_qtd.TextChanged
        AtualizarValorbatoque("m", "tb_batoques", m_qtd, m_valor)
    End Sub

    Private Sub g_qtd_TextChanged(sender As Object, e As EventArgs) Handles g_qtd.TextChanged
        AtualizarValorbatoque("g", "tb_batoques", g_qtd, g_valor)
    End Sub

    Private Sub gg_qtd_TextChanged(sender As Object, e As EventArgs) Handles gg_qtd.TextChanged
        AtualizarValorbatoque("gg", "tb_batoques", gg_qtd, gg_valor)
    End Sub

    Private Sub baixalingua_qtd_TextChanged(sender As Object, e As EventArgs) Handles baixalingua_qtd.TextChanged
        AtualizarValorproduto("baixa lingua", "tb_produtos_geral", baixalingua_qtd, baixalingua_valor)
    End Sub

    Private Sub bandagem_qtd_TextChanged(sender As Object, e As EventArgs) Handles bandagem_qtd.TextChanged
        AtualizarValorproduto("bandagem", "tb_produtos_geral", bandagem_qtd, bandagem_valor)
    End Sub

    Private Sub gel_qtd_TextChanged(sender As Object, e As EventArgs) Handles gel_qtd.TextChanged
        AtualizarValorproduto("gel transfer", "tb_produtos_geral", gel_qtd, gel_valor)
    End Sub

    Private Sub gilete_qtd_TextChanged(sender As Object, e As EventArgs) Handles gilete_qtd.TextChanged
        AtualizarValorproduto("gillete", "tb_produtos_geral", gilete_qtd, gilete_valor)
    End Sub

    Private Sub luva_qtd_TextChanged(sender As Object, e As EventArgs) Handles luva_qtd.TextChanged
        AtualizarValorproduto("luva", "tb_produtos_geral", luva_qtd, luva_valor)
    End Sub

    Private Sub papelmanteiga_qtd_TextChanged(sender As Object, e As EventArgs) Handles papelmanteiga_qtd.TextChanged
        AtualizarValorproduto("papel manteiga", "tb_produtos_geral", papelmanteiga_qtd, papelmanteiga_valor)
    End Sub

    Private Sub plasticofilme_qtd_TextChanged(sender As Object, e As EventArgs) Handles plasticofilme_qtd.TextChanged
        AtualizarValorproduto("plastico filme", "tb_produtos_geral", plasticofilme_qtd, plasticofilme_valor)
    End Sub

    Private Sub snob_qtd_TextChanged(sender As Object, e As EventArgs) Handles snob_qtd.TextChanged
        AtualizarValorproduto("snob", "tb_produtos_geral", snob_qtd, snob_valor)
    End Sub

    Private Sub tintaimpressora_qtd_TextChanged(sender As Object, e As EventArgs) Handles tintaimpressora_qtd.TextChanged
        AtualizarValorproduto("tinta impressora", "tb_produtos_geral", tintaimpressora_qtd, tintaimpressora_valor)
    End Sub

    Private Sub decalque_qtd_TextChanged(sender As Object, e As EventArgs) Handles decalque_qtd.TextChanged
        AtualizarValorproduto("decalque", "tb_produtos_geral", decalque_qtd, decalque_valor)
    End Sub

    Private Sub vaselina_qtd_TextChanged(sender As Object, e As EventArgs) Handles vaselina_qtd.TextChanged
        AtualizarValorproduto("vaselina", "tb_produtos_geral", vaselina_qtd, vaselina_valor)
    End Sub

    Private Sub txt_valor_cobrado_TextChanged(sender As Object, e As EventArgs) Handles txt_valor_cobrado.TextChanged
        Try
            Dim valorCobrado As Double = txt_valor_cobrado.Text
            Dim passivo As Double = txt_passivo.Text
            Dim total As Double = valorCobrado - passivo

            txt_lucro.Text = FormatCurrency(total, 2)
        Catch ex As Exception
            MsgBox($"Erro ao calcular lucro: {ex.Message}", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
    Private Sub baixa_material(tabela As String, qtd As String, quantidade As Int32, valo As String, valor As Int32, coluna As String, id As String)
        Try
            sql = $"update {tabela} set {qtd} = {qtd} - {quantidade},{valo} = {valo} - {valor * quantidade} where {coluna} = '{id}'"
            rs = db.Execute(UCase(sql))
        Catch ex As Exception
            MsgBox($"Erro ao calcular lucro:", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try


    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        baixa_material("tb_tintas", "quantidade", preto_qtd.Text, "valor_total", preto_valor.Text, "cor", "preto")
        baixa_material("tb_tintas", "quantidade", branco_qtd.Text, "valor_total", branco_valor.Text, "cor", "branco")
        baixa_material("tb_tintas", "quantidade", amarelo_qtd.Text, "valor_total", amarelo_valor.Text, "cor", "amarelo")
        baixa_material("tb_tintas", "quantidade", azul_qtd.Text, "valor_total", azul_valor.Text, "cor", "azul")
        baixa_material("tb_tintas", "quantidade", verde_qtd.Text, "valor_total", verde_valor.Text, "cor", "verde")
        baixa_material("tb_tintas", "quantidade", vermelho_qtd.Text, "valor_total", vermelho_valor.Text, "cor", "vermelho")
        baixa_material("tb_tintas", "quantidade", laranja_qtd.Text, "valor_total", laranja_valor.Text, "cor", "laranja")
        baixa_material("tb_batoques", "quantidade", pp_qtd.Text, "valor_total", pp_valor.Text, "tamanho", "pp")
        baixa_material("tb_batoques", "quantidade", p_qtd.Text, "valor_total", p_valor.Text, "tamanho", "p")
        baixa_material("tb_batoques", "quantidade", m_qtd.Text, "valor_total", m_valor.Text, "tamanho", "m")
        baixa_material("tb_batoques", "quantidade", g_qtd.Text, "valor_total", g_valor.Text, "tamanho", "g")
        baixa_material("tb_batoques", "quantidade", gg_qtd.Text, "valor_total", gg_valor.Text, "tamanho", "gg")
        baixa_material("tb_produtos_geral", "quantidade", baixalingua_qtd.Text, "valor_total", baixalingua_valor.Text, "produto", "baixa lingua")
        baixa_material("tb_produtos_geral", "quantidade", bandagem_qtd.Text, "valor_total", bandagem_valor.Text, "produto", "bandagem")
        baixa_material("tb_produtos_geral", "quantidade", gel_qtd.Text, "valor_total", gel_valor.Text, "produto", "gel transfer")
        baixa_material("tb_produtos_geral", "quantidade", gilete_qtd.Text, "valor_total", gilete_valor.Text, "produto", "gillete")
        baixa_material("tb_produtos_geral", "quantidade", luva_qtd.Text, "valor_total", luva_valor.Text, "produto", "luva")
        baixa_material("tb_produtos_geral", "quantidade", papelmanteiga_qtd.Text, "valor_total", papelmanteiga_valor.Text, "produto", "papel manteiga")
        baixa_material("tb_produtos_geral", "quantidade", plasticofilme_qtd.Text, "valor_total", plasticofilme_valor.Text, "produto", "plastico filme")
        baixa_material("tb_produtos_geral", "quantidade", snob_qtd.Text, "valor_total", snob_valor.Text, "produto", "snob")
        baixa_material("tb_produtos_geral", "quantidade", tintaimpressora_qtd.Text, "valor_total", tintaimpressora_valor.Text, "produto", "Tinta Impressora")
        baixa_material("tb_produtos_geral", "quantidade", decalque_qtd.Text, "valor_total", decalque_valor.Text, "produto", "Decalque")
        baixa_material("tb_produtos_geral", "quantidade", vermelho_qtd.Text, "valor_total", vaselina_valor.Text, "produto", "")
        MsgBox($"Operação realizada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
    End Sub
End Class