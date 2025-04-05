Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles Me.Load
        conectar_banco()

    End Sub
    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        If txt_usuario.Text = "" Or
        txt_senha.Text = "" Then
            MsgBox("Preencha Todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        Else
            sql = "select * from tb_login where(usuario='" & txt_usuario.Text & "' and senha= '" & txt_senha.Text & "')"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "select cargo from tb_login where(usuario='" & txt_usuario.Text & "')"
                rs = db.Execute(sql)
                If Not rs.EOF Then
                    cargo = rs.Fields("cargo").Value.ToString()
                    If cargo = "administrador" Then
                        adm.Show()
                        Me.Hide()
                    ElseIf cargo = "tatuador" Then
                        tatuador.Show()
                        Me.Hide()
                    ElseIf cargo = "secretaria" Then
                        secretaria.Show()
                        Me.Hide()
                    End If
                Else
                    MsgBox("usuario não encontrado", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "aviso")
                End If
            End If
        End If
        txt_usuario.Clear()
        txt_senha.Clear()
    End Sub
End Class
