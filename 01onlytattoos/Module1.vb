Module Module1
    Public db As ADODB.Connection 'variavel banco de dados
    Public rs As ADODB.Recordset  'variavel da tabela
    Public sql, diretorio, aux, aux2, resp, total_agulha, cargo As String 'variavel de query(gravar,excluir...)
    Public cont As Integer

    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB; Data Source=DESKTOP-6B34AU1;initial catalog=clientes;trusted_connection=yes;") 'Nome do Servidor, Nome do Banco, Validação do Windows
        Catch ex As Exception
            MsgBox("Erro ao conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "aviso ai vlw")
        End Try
    End Sub

    Sub conectar_banco_estoque()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB; Data Source=DESKTOP-6B34AU1;initial catalog=clientes;trusted_connection=yes;") 'Nome do Servidor, Nome do Banco, Validação do Windows
        Catch ex As Exception
            MsgBox("Erro ao conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "aviso ai vlw")
        End Try
    End Sub
    Sub limpar_cad()
        With cadastrocliente
            .txt_cpf.Clear()
            .txt_nome.Clear()
            .txt_email.Clear()
            .txt_telefone.Clear()
        End With
    End Sub
    Sub limpar_cad2()
        With gerenciarcliente
            .txt_cpf.Clear()
            .txt_nome.Clear()
            .txt_email.Clear()
            .txt_telefone.Clear()
        End With
    End Sub

    Sub limpar_cad3()
        With agendamento
            .txt_cpf.Clear()
            .txt_nome.Clear()
        End With
    End Sub
    Sub limpar_agulhas()
        With cad_produto
            .txt_qtd_comprada.Clear()
            .txt_valor_agulha.Clear()
            .cmb_espessura_agulha.Refresh()
            .cmb_tipo_agulha.Refresh()
        End With
    End Sub
    Sub limpar_batoques()
        With cad_produto
            .cmb_tamanho_batoque.Refresh()
            .txt_qtd_batoque.Clear()
            .txt_valor_batoque.Clear()
        End With
    End Sub
    Sub limpar_tintas()
        With cad_produto
            .cmb_cor_tintas.Refresh()
            .txt_qtd_tintas.Clear()
            .txt_valor_tintas.Clear()
        End With
    End Sub
    Sub limpar_produtos_geral()
        With cad_produto
            .cmb_produto.Refresh()
            .txt_qtd_produto.Clear()
            .txt_valor_produto.Clear()
        End With
    End Sub
    Sub carregar_dados()
        Try
            With gerenciarcliente.dgv_dados
                sql = "select * from tb_clientes order by nome asc"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(4).Value, rs.Fields(3).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("erro1", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Sub carrear_produtos_agulha()
        Try
            With cad_produto.dgv_agulha
                sql = "select * from tb_agulhas order by tipo asc"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, FormatCurrency(rs.Fields(5).Value, 2), FormatCurrency(rs.Fields(4).Value, 2), Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("erro2", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Sub carregar_produtos_batoque()
        Try
            With cad_produto.dgv_batoque
                sql = "select * from tb_batoques"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, FormatCurrency(rs.Fields(3).Value, 2), FormatCurrency(rs.Fields(2).Value, 2), Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("erro3", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub
    Sub carregar_produtos_tinta()
        Try
            With cad_produto.dgv_tinta
                sql = "select * from tb_tintas"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, FormatCurrency(rs.Fields(3).Value, 2), FormatCurrency(rs.Fields(2).Value, 2), Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("erro4", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub
    Sub carregar_produtos_geral()
        Try
            With cad_produto.dgv_produto_geral
                sql = "select * from tb_produtos_geral"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, FormatCurrency(rs.Fields(3).Value, 2), FormatCurrency(rs.Fields(2).Value, 2), Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("erro5", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub
    Sub carregar_tipo()
        Try
            With gerenciarcliente.cmb_tipo.Items
                .Add("CPF")
                .Add("Nome")
            End With
            gerenciarcliente.cmb_tipo.SelectedIndex = 1 'Dependendo do numero colocado é o que vai vir default no cmb
        Catch ex As Exception
            MsgBox("erro6", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Sub carregar_estoque()
        Try
            With estoque.dgv_agulha

                sql = "select * from tb_agulhas order by tipo asc"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, FormatCurrency(rs.Fields(5).Value, 2), FormatCurrency(rs.Fields(4).Value, 2))
                    rs.MoveNext()
                Loop
            End With
            With estoque.dgv_batoque
                sql = "select * from tb_batoques"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, FormatCurrency(rs.Fields(3).Value, 2), FormatCurrency(rs.Fields(2).Value, 2))
                    rs.MoveNext()
                Loop
            End With
            With estoque.dgv_tinta
                sql = "select * from tb_tintas"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, FormatCurrency(rs.Fields(3).Value, 2), FormatCurrency(rs.Fields(2).Value, 2))
                    rs.MoveNext()
                Loop
            End With
            With estoque.dgv_produto_geral
                sql = "select * from tb_produtos_geral"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, FormatCurrency(rs.Fields(3).Value, 2), FormatCurrency(rs.Fields(2).Value, 2))
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception

        End Try
    End Sub
    Sub carregar_horario()
        With agendamento.drop_horario.Items
            .Add("10:00")
            .Add("11:00")
            .Add("12:00")
            .Add("13:00")
            .Add("14:00")
            .Add("15:00")
            .Add("16:00")
            .Add("17:00")
            .Add("18:00")
            .Add("19:00")
            .Add("20:00")
            .Add("21:00")
            .Add("22:00")
        End With
        agendamento.drop_horario.SelectedIndex = 1
    End Sub

    Sub carregar_agendamentos()
        Try
            With agendamento.dgv_agendamento
                sql = "select * from tb_agendamento  order by nome asc"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Sub carregar_horarios()
        Try
            With horarios.dgv_horario
                sql = "select * from tb_agendamento  order by nome asc"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub
    Sub ficha_anamnese()
        With cadastrocliente.cmb_ficha.Items
            .Add("Sim")
            .Add("Não")
        End With
    End Sub
    Sub tipo_agulha()
        With cad_produto.cmb_tipo_agulha.Items
            .Add("RL")
            .Add("RS")
            .Add("MG")
            .Add("RM")
        End With
    End Sub

    Sub espessura_agulha()
        With cad_produto.cmb_espessura_agulha.Items
            .Add("8")
            .Add("10")
            .Add("12")
        End With
    End Sub

    Sub quantidade_agulha()
        With cad_produto.cmb_qtd_agulha.Items
            .Add("1")
            .Add("3")
            .Add("5")
            .Add("7")
            .Add("9")
            .Add("11")
            .Add("13")
            .Add("15")
            .Add("17")
            .Add("18")
            .Add("21")
            .Add("23")
            .Add("25")
        End With
    End Sub

    Sub tamanho_batoque()
        With cad_produto.cmb_tamanho_batoque.Items
            .Add("PP")
            .Add("P")
            .Add("M")
            .Add("G")
            .Add("GG")
        End With
    End Sub

    Sub cores_tintas()
        With cad_produto.cmb_cor_tintas.Items
            .Add("Preto")
            .Add("Branco")
            .Add("Amarelo")
            .Add("Azul")
            .Add("Verde")
            .Add("Vermelho")
            .Add("Rosa")
            .Add("Laranja")
            .Add("Marrom")
            .Add("Bege")
        End With
    End Sub

    Sub produtos_geral()
        With cad_produto.cmb_produto.Items
            .Add("Baixa Lingua")
            .Add("Bandagem")
            .Add("Gel Transfer")
            .Add("Gillete")
            .Add("Luva")
            .Add("Papel Manteiga")
            .Add("Plastico Filme")
            .Add("Snob")
            .Add("Tinta impressora")
            .Add("Tinta Impressora decalque")
            .Add("Vaselina")
        End With
    End Sub
End Module