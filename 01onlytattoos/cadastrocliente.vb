Public Class cadastrocliente
    Private Sub cadastrocliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        ficha_anamnese()
    End Sub

    Private Sub cadastrocliente_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Panel1.Left = (Me.Width - Panel1.Width) / 2
    End Sub
    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        'Try
        sql = "select * from tb_clientes where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
            sql = "insert into tb_clientes (cpf,nome,email,telefone,data_nasc,ficha) " &
                "values ('" & txt_cpf.Text & "','" & txt_nome.Text & "', " &
                "'" & txt_email.Text & "','" & txt_telefone.Text & "', " &
                "'" & cmb_data_nasc.Value.Date & "','" & cmb_ficha.Text & "')"
            rs = db.Execute(UCase(sql))
                MsgBox("Dados gravados com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_cad()
                carregar_agendamentos()
                carregar_dados()
            Else
                MsgBox("CPF ja cadastrado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        'Catch ex As Exception
        'MsgBox("deu alguma merda", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        'End Try
    End Sub
End Class

