Public Class secretaria
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btn_agendamento_Click(sender As Object, e As EventArgs) Handles btn_agendamento.Click
        With agendamento
            .TopLevel = False
            backpanel.Controls.Add(agendamento)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_novocad_Click(sender As Object, e As EventArgs) Handles btn_novocad.Click
        With cadastrocliente
            .TopLevel = False
            backpanel.Controls.Add(cadastrocliente)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_gerenciar_Click(sender As Object, e As EventArgs) Handles btn_gerenciar.Click
        With gerenciarcliente
            .TopLevel = False
            backpanel.Controls.Add(gerenciarcliente)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class
