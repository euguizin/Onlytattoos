<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        btn_entrar = New Button()
        txt_senha = New TextBox()
        txt_usuario = New TextBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(25), CByte(42), CByte(86))
        Panel1.Controls.Add(btn_entrar)
        Panel1.Controls.Add(txt_senha)
        Panel1.Controls.Add(txt_usuario)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, -5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(472, 499)
        Panel1.TabIndex = 0
        ' 
        ' btn_entrar
        ' 
        btn_entrar.BackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        btn_entrar.Font = New Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_entrar.ForeColor = SystemColors.ButtonHighlight
        btn_entrar.Location = New Point(137, 248)
        btn_entrar.Name = "btn_entrar"
        btn_entrar.Size = New Size(184, 59)
        btn_entrar.TabIndex = 3
        btn_entrar.Text = "Entrar"
        btn_entrar.UseVisualStyleBackColor = False
        ' 
        ' txt_senha
        ' 
        txt_senha.Location = New Point(40, 176)
        txt_senha.Name = "txt_senha"
        txt_senha.PlaceholderText = " Senha:"
        txt_senha.Size = New Size(364, 27)
        txt_senha.TabIndex = 2
        ' 
        ' txt_usuario
        ' 
        txt_usuario.Location = New Point(40, 131)
        txt_usuario.Name = "txt_usuario"
        txt_usuario.PlaceholderText = " Nome de usuário:"
        txt_usuario.Size = New Size(364, 27)
        txt_usuario.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Snow
        Label1.Location = New Point(40, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 41)
        Label1.TabIndex = 0
        Label1.Text = "Login"
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(25), CByte(42), CByte(86))
        ClientSize = New Size(474, 492)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "login"
        Text = "login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents btn_entrar As Button
End Class
