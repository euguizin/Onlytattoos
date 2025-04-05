Module Module1
    Public db As ADODB.Connection 'variavel banco de dados
    Public rs As ADODB.Recordset  'variavel da tabela
    Public sql As String 'variavel de query(gravar,excluir...)

    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB; Data Source=DESKTOP-6B34AU1;initial catalog=clientes;trusted_connection=yes;") 'Nome do Servidor, Nome do Banco, Validação do Windows
            MsgBox("Conexao OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "aviso ai vlw")
        Catch ex As Exception
            MsgBox("Erro ao conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "aviso ai vlw")
        End Try
    End Sub
End Module
