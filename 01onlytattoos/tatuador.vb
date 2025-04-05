Public Class tatuador
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles painelesq.Paint

    End Sub

    Private Sub btn_estoque_Click(sender As Object, e As EventArgs) Handles btn_estoque.Click
        With estoque
            .TopLevel = False
            Panel1.Controls.Add(estoque)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_orcamento_Click(sender As Object, e As EventArgs) Handles btn_agendamento.Click
        With horarios
            .TopLevel = False
            Panel1.Controls.Add(horarios)
            .BringToFront
            .Show
        End With
    End Sub

    Private Sub tatuador_Load(sender As Object, e As EventArgs) Handles Me.Load
        conectar_banco()
        carregar_horarios()
    End Sub

    Private Sub btn_cad_tatuagem_Click(sender As Object, e As EventArgs) Handles btn_cad_tatuagem.Click
        With cad_tattoo
            .TopLevel = False
            Panel1.Controls.Add(cad_tattoo)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        login.Show()

    End Sub

    Private Sub btn_orcamento_Click_1(sender As Object, e As EventArgs) Handles btn_orcamento.Click
        With orcamento
            .TopLevel = False
            Panel1.Controls.Add(orcamento)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class