Public Class agendamento
    Private Sub agendamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_horario()
        carregar_agendamentos()
    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Try
            sql = "select * from tb_clientes where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_cpf.Text = rs.Fields(0).Value
                txt_nome.Text = rs.Fields(1).Value
            Else
                resp = MsgBox("Cliente não registrado! registre-o primeiro para prosseguir", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                txt_cpf.Clear()
            End If
        Catch ex As Exception
            MsgBox("erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "atenção")
        End Try
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Try
            sql = "select * from tb_agendamento where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                sql = "insert into tb_agendamento (cpf,nome,dia,horario) " &
                    "values ('" & txt_cpf.Text & "','" & txt_nome.Text & "', " &
                    "'" & cmb_data_tattoo.Value.Date & "', '" & drop_horario.Text & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Sessão Marcada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                carregar_agendamentos()
            Else
                MsgBox("Este cliente já tem um horario marcado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("deu alguma merda", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub dgv_agendamento_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_agendamento.CellContentClick
        Try
            With dgv_agendamento
                If .CurrentRow.Cells(4).Selected = True Then
                    aux = .CurrentRow.Cells(0).Value
                    aux2 = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja cancelar o agendamento de: " & aux & " no dia: " & aux2 & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete from tb_agendamento where nome = '" & aux & "'"
                        rs = db.Execute(sql)
                        carregar_agendamentos()
                    End If
                ElseIf .CurrentRow.Cells(3).Selected = True Then
                    aux = .CurrentRow.Cells(0).Value
                    sql = "select * from tb_clientes where nome='" & aux & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        txt_cpf.Text = rs.Fields(0).Value
                        txt_nome.Text = rs.Fields(1).Value
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "atenção")
        End Try
    End Sub

    Private Sub btn_atualizar_Click(sender As Object, e As EventArgs) Handles btn_atualizar.Click
        Try
            sql = "UPDATE tb_agendamento SET " &
                    "nome = '" & txt_nome.Text & "', " &
                    "dia = '" & cmb_data_tattoo.Value.Date & "', " &
                    "horario = '" & drop_horario.Text & "' " &
                    "WHERE cpf = '" & txt_cpf.Text & "'"
            rs = db.Execute(UCase(sql))
            MsgBox("Agendamento alterado com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            limpar_cad3()
            carregar_agendamentos()
        Catch ex As Exception
            MsgBox("deu alguma merda", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
End Class