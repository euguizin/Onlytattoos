Public Class cad_produto

    Private Sub cad_produto_Load(sender As Object, e As EventArgs) Handles Me.Load
        conectar_banco_estoque()
        tipo_agulha()
        espessura_agulha()
        quantidade_agulha()
        tamanho_batoque()
        cores_tintas()
        produtos_geral()
        carrear_produtos_agulha()
        carregar_produtos_batoque()
        carregar_produtos_tinta()
        carregar_produtos_geral()

    End Sub
    Private Sub btn_cadastrar_agulha_Click(sender As Object, e As EventArgs) Handles btn_cadastrar_agulha.Click
        Try
            sql = "SELECT * FROM tb_agulhas WHERE (tipo = '" & cmb_tipo_agulha.Text & "' AND espessura = '" & cmb_espessura_agulha.Text & "' AND qtd_agulhas = '" & cmb_qtd_agulha.Text & "')"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                sql = "INSERT INTO tb_agulhas (tipo, espessura, qtd_agulhas, qtd_comprada, valor_total) " &
      "VALUES ('" & cmb_tipo_agulha.Text & "', '" & cmb_espessura_agulha.Text & "', " &
      cmb_qtd_agulha.Text & ", " & txt_qtd_comprada.Text & ", " & txt_valor_agulha.Text & ")"

                rs = db.Execute(UCase(sql))
                MsgBox("Agulha Cadastrada com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_agulhas()
                carrear_produtos_agulha()
            Else
                MsgBox("Esse modelo de agulja já está cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("deu alguma merda", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_cadastrar_batoque_Click(sender As Object, e As EventArgs) Handles btn_cadastrar_batoque.Click
        Try
            sql = "select * from tb_batoques WHERE tamanho= '" & cmb_tamanho_batoque.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                sql = "insert into tb_batoques (tamanho,quantidade,valor_total) " &
                "values ('" & cmb_tamanho_batoque.Text & "','" & txt_qtd_batoque.Text & "', " &
                "'" & txt_valor_batoque.Text & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Batoque Cadastrado com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_batoques()
                carregar_produtos_batoque()
            Else
                MsgBox("Este Batoque já está cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("deu alguma merda", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_cadastrar_tintas_Click(sender As Object, e As EventArgs) Handles btn_cadastrar_tintas.Click
        Try
            sql = "select * from tb_tintas WHERE cor= '" & cmb_cor_tintas.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                sql = "insert into tb_tintas (cor,quantidade,valor_total) " &
                "values ('" & cmb_cor_tintas.Text & "','" & txt_qtd_tintas.Text & "', " &
                "'" & txt_valor_tintas.Text & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Tinta Cadastrada com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_tintas()
                carregar_produtos_tinta()
            Else
                MsgBox("Esta Tinta já está cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("deu alguma merda", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_cadastrar_produto_Click(sender As Object, e As EventArgs) Handles btn_cadastrar_produto.Click
        Try
            sql = "select * from tb_produtos_geral where produto= '" & cmb_produto.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                sql = "insert into tb_produtos_geral (produto,quantidade,valor_total) " &
                "values ('" & cmb_produto.Text & "','" & txt_qtd_produto.Text & "', " &
                "'" & txt_valor_produto.Text & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Produto Cadastrado com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_produtos_geral()
                carregar_produtos_geral()
            Else
                MsgBox("Esta Tinta já está cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("deu alguma merda", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_atualizar_agulha_Click(sender As Object, e As EventArgs) Handles btn_atualizar_agulha.Click
        Try
            sql = "SELECT * FROM tb_agulhas WHERE (tipo = '" & cmb_tipo_agulha.Text & "' AND espessura = '" & cmb_espessura_agulha.Text & "' AND qtd_agulhas = '" & cmb_qtd_agulha.Text & "')"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "UPDATE tb_agulhas " &
      "SET qtd_comprada = qtd_comprada + " & txt_qtd_comprada.Text & ", " &
      "valor_total = valor_total + " & txt_valor_agulha.Text & " " &
      "WHERE tipo = '" & cmb_tipo_agulha.Text & "' AND espessura = '" & cmb_espessura_agulha.Text & "' AND qtd_agulhas = " & cmb_qtd_agulha.Text

                rs = db.Execute(UCase(sql))
                MsgBox("Agulha atualizada com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_agulhas()
                carrear_produtos_agulha()
            Else
                MsgBox("Esse modelo de agulha não esta cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("deu alguma merda", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_atualizar_batoque_Click(sender As Object, e As EventArgs) Handles btn_atualizar_batoque.Click
        Try
            sql = "select * from tb_batoques WHERE tamanho= '" & cmb_tamanho_batoque.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "update tb_batoques set quantidade = quantidade + " & txt_qtd_batoque.Text & "," &
                " valor_total = valor_total + " & txt_valor_batoque.Text & " " &
                " where tamanho= '" & cmb_tamanho_batoque.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Batoque atualizado com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_batoques()
                carregar_produtos_batoque()
            Else
                MsgBox("Este Batoque não está cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("deu alguma merda", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_atualizar_tintas_Click(sender As Object, e As EventArgs) Handles btn_atualizar_tintas.Click
        Try
            sql = "select * from tb_tintas WHERE cor= '" & cmb_cor_tintas.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "update tb_tintas set quantidade = quantidade + " & txt_qtd_tintas.Text & ", valor_total = valor_total + " & txt_valor_tintas.Text &
                " where cor= '" & cmb_cor_tintas.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Tinta Atualizada com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_tintas()
                carregar_produtos_tinta()
            Else
                MsgBox("Esta Tinta não está cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("deu alguma merda", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_atualizar_produto_Click(sender As Object, e As EventArgs) Handles btn_atualizar_produto.Click
        Try
            sql = "select * from tb_produtos_geral where produto= '" & cmb_produto.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "update tb_produtos_geral set quantidade = quantidade + " & txt_qtd_produto.Text & ", " &
                "valor_total = valor_total + " & txt_valor_produto.Text &
                " where produto = '" & cmb_produto.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Produto atualizado com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_produtos_geral()
                carregar_produtos_geral()
            Else
                MsgBox("Esta Tinta não está cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("deu alguma merda", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_excluir_agulhas_Click(sender As Object, e As EventArgs) Handles btn_excluir_agulhas.Click
        Try
            sql = "SELECT * FROM tb_agulhas WHERE tipo = '" & cmb_tipo_agulha.Text & "' AND espessura = '" & cmb_espessura_agulha.Text & "' AND qtd_agulhas = '" & cmb_qtd_agulha.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                Dim qtdEstoqueAtual As Integer = rs.Fields("qtd_comprada").Value
                Dim valorEstoqueAtual As Decimal = rs.Fields("valor_total").Value

                If Not IsNumeric(txt_qtd_comprada.Text) OrElse Convert.ToInt32(txt_qtd_comprada.Text) <= 0 Then
                    MsgBox("Por favor, insira uma quantidade válida para exclusão.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                    Exit Sub
                End If

                Dim qtdExcluir As Integer = Convert.ToInt32(txt_qtd_comprada.Text)
                Dim valor As Integer = Convert.ToInt32(txt_valor_agulha.Text)

                If qtdExcluir > qtdEstoqueAtual Then
                    MsgBox("A quantidade informada para exclusão é maior que a quantidade disponível no estoque.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    If qtdExcluir = qtdEstoqueAtual AndAlso valorEstoqueAtual = rs.Fields("valor_total").Value Then
                        sql = "DELETE FROM tb_agulhas WHERE tipo = '" & cmb_tipo_agulha.Text & "' AND espessura = '" & cmb_espessura_agulha.Text & "' AND qtd_agulhas = '" & cmb_qtd_agulha.Text & "'"
                        db.Execute(UCase(sql))
                        MsgBox("Produto excluído com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Else
                        sql = "UPDATE tb_agulhas SET qtd_comprada = qtd_comprada - " & qtdExcluir & ", " &
                          "valor_total = valor_total - " & valor & " " &
                          "WHERE tipo = '" & cmb_tipo_agulha.Text & "' AND espessura = '" & cmb_espessura_agulha.Text & "' AND qtd_agulhas = '" & cmb_qtd_agulha.Text & "'"
                        db.Execute(UCase(sql))
                        MsgBox("Quantidade de agulhas excluída com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    End If
                    limpar_agulhas()
                    carrear_produtos_agulha()
                End If
            Else
                MsgBox("Este modelo de agulha não está cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("Erro ao excluir a quantidade de agulhas: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try


    End Sub

    Private Sub btn_excluir_produto_Click(sender As Object, e As EventArgs) Handles btn_excluir_produto.Click
        Try
            sql = "SELECT * FROM tb_produtos_geral WHERE produto = '" & cmb_produto.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                Dim qtdEstoqueAtual As Integer = rs.Fields("quantidade").Value
                Dim valorEstoqueAtual As Decimal = rs.Fields("valor_total").Value

                If Not IsNumeric(txt_qtd_produto.Text) OrElse Convert.ToInt32(txt_qtd_produto.Text) <= 0 Then
                    MsgBox("Por favor, insira uma quantidade válida para exclusão.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                    Exit Sub
                End If
                Dim qtdExcluir As Integer = Convert.ToInt32(txt_qtd_produto.Text)

                If qtdExcluir > qtdEstoqueAtual Then
                    MsgBox("A quantidade informada para exclusão é maior que a quantidade disponível no estoque.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    If qtdExcluir = qtdEstoqueAtual AndAlso valorEstoqueAtual = rs.Fields("valor_total").Value Then
                        sql = "DELETE FROM tb_produtos_geral WHERE produto = '" & cmb_produto.Text & "'"
                        db.Execute(UCase(sql))
                        MsgBox("Produto excluído do estoque.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Else
                        sql = "UPDATE tb_produtos_geral SET quantidade = quantidade - " & qtdExcluir &
                              " WHERE produto = '" & cmb_produto.Text & "'"
                        db.Execute(UCase(sql))
                        MsgBox("Quantidade excluída do estoque.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    End If


                    limpar_produtos_geral()
                    carregar_produtos_geral()
                End If
            Else
                MsgBox("Este produto não está cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("Erro ao excluir a quantidade do produto: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try


    End Sub

    Private Sub btn_excluir_batoques_Click(sender As Object, e As EventArgs) Handles btn_excluir_batoques.Click
        Try

            sql = "SELECT * FROM tb_batoques WHERE tamanho = '" & cmb_tamanho_batoque.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then

                Dim qtd_estoque As Integer = rs.Fields("quantidade").Value
                Dim valor_estoque As Decimal = rs.Fields("valor_total").Value

                If Val(txt_qtd_batoque.Text) > qtd_estoque Then
                    MsgBox("A quantidade informada é maior que a quantidade disponível no estoque!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
                    Exit Sub
                End If

                If Val(txt_qtd_batoque.Text) = qtd_estoque And Val(txt_valor_batoque.Text) = valor_estoque Then
                    sql = "DELETE FROM tb_batoques WHERE tamanho = '" & cmb_tamanho_batoque.Text & "'"
                    db.Execute(UCase(sql))
                    MsgBox("Produto excluído com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Else

                    sql = "UPDATE tb_batoques SET quantidade = quantidade - " & txt_qtd_batoque.Text & ", valor_total = valor_total - " & txt_valor_batoque.Text &
                          " WHERE tamanho = '" & cmb_tamanho_batoque.Text & "'"
                    db.Execute(UCase(sql))
                    MsgBox("Batoque atualizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                End If

                limpar_batoques()
                carregar_produtos_batoque()
            Else
                MsgBox("Este Batoque não está cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try


    End Sub

    Private Sub btn_excluir_tintas_Click(sender As Object, e As EventArgs) Handles btn_excluir_tintas.Click
        Try

            sql = "select * from tb_tintas WHERE cor= '" & cmb_cor_tintas.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then

                Dim qtd_estoque As Integer = rs.Fields("quantidade").Value
                Dim valor_estoque As Decimal = rs.Fields("valor_total").Value

                If Val(txt_qtd_tintas.Text) > qtd_estoque Then
                    MsgBox("Quantidade informada é maior que a disponível no estoque!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                    Exit Sub
                End If
                If Val(txt_qtd_tintas.Text) = qtd_estoque And Val(txt_valor_tintas.Text) = valor_estoque Then
                    sql = "DELETE FROM tb_tintas WHERE cor = '" & cmb_cor_tintas.Text & "'"
                    db.Execute(UCase(sql))
                    MsgBox("Produto excluído com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    sql = "UPDATE tb_tintas SET quantidade = quantidade - " & txt_qtd_tintas.Text & ", valor_total = valor_total - " & txt_valor_tintas.Text &
                        " WHERE cor = '" & cmb_cor_tintas.Text & "'"
                    db.Execute(UCase(sql))
                    MsgBox("Tinta excluída com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                End If

                limpar_tintas()
                carregar_produtos_tinta()
            Else
                MsgBox("Esta tinta não está cadastrada!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub dgv_agulha_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_agulha.CellContentClick

    End Sub

    Private Sub txt_valor_agulha_TextChanged(sender As Object, e As EventArgs) Handles txt_valor_agulha.TextChanged

    End Sub

    Private Sub dgv_tinta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_tinta.CellContentClick

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub
End Class
