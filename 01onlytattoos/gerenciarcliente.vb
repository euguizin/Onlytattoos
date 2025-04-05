Public Class gerenciarcliente
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txt_cpf_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_cpf.MaskInputRejected

    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Try
            sql = "select * from tb_clientes where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_cpf.Text = rs.Fields(1).Value
                txt_nome.Text = rs.Fields(2).Value
                txt_email.Text = rs.Fields(3).Value
                txt_telefone.Text = rs.Fields(4).Value
            Else
                txt_nome.Focus()
            End If
        Catch ex As Exception
            MsgBox("erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "atenção")
        End Try
    End Sub

    Private Sub gerenciarcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_dados()
        carregar_tipo()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                If .CurrentRow.Cells(5).Selected = True Then
                    aux = .CurrentRow.Cells(0).Value
                    resp = MsgBox("Deseja realmente excluir o CPF: " & aux & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete from tb_clientes where cpf = '" & aux & "'"
                        rs = db.Execute(sql)
                        carregar_dados()
                    End If
                ElseIf .CurrentRow.Cells(4).Selected = True Then
                    aux = .CurrentRow.Cells(0).Value
                    sql = "select * from tb_clientes where cpf='" & aux & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        txt_cpf.Text = rs.Fields(0).Value
                        txt_nome.Text = rs.Fields(1).Value
                        txt_email.Text = rs.Fields(2).Value
                        txt_telefone.Text = rs.Fields(3).Value
                        cmb_data_nasc.Value = rs.Fields(4).Value
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "atenção")
        End Try
    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            With dgv_dados
                sql = "select * from tb_clientes where " & cmb_tipo.Text & " like '" & txt_busca.Text & "%'"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(4).Value, rs.Fields(3).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Try
            sql = "UPDATE tb_clientes SET " &
                    "nome = '" & txt_nome.Text & "', " &
                    "email = '" & txt_email.Text & "', " &
                    "telefone = '" & txt_telefone.Text & "', " &
                    "data_nasc = '" & cmb_data_nasc.Value.Date & "' " &
                    "WHERE cpf = '" & txt_cpf.Text & "'"
            rs = db.Execute(UCase(sql))
            MsgBox("Dados gravados com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            limpar_cad2()
            carregar_dados()
        Catch ex As Exception
            MsgBox("deu alguma merda", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

End Class