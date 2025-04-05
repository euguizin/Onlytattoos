<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadastrocliente
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
        Label1 = New Label()
        Label2 = New Label()
        txt_nome = New TextBox()
        Label3 = New Label()
        txt_cpf = New MaskedTextBox()
        Label4 = New Label()
        txt_email = New TextBox()
        Label5 = New Label()
        txt_telefone = New MaskedTextBox()
        Label6 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        btn_gravar = New Button()
        cmb_data_nasc = New DateTimePicker()
        Label7 = New Label()
        cmb_ficha = New ComboBox()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlText
        Panel1.Location = New Point(58, 53)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1, 1)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(138, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(364, 34)
        Label1.TabIndex = 1
        Label1.Text = "CADASTRO DE CLIENTES"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 20)
        Label2.TabIndex = 2
        Label2.Text = "Nome: "
        ' 
        ' txt_nome
        ' 
        txt_nome.Location = New Point(79, 79)
        txt_nome.Name = "txt_nome"
        txt_nome.Size = New Size(247, 27)
        txt_nome.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(363, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 20)
        Label3.TabIndex = 4
        Label3.Text = "CPF:"
        ' 
        ' txt_cpf
        ' 
        txt_cpf.Location = New Point(406, 79)
        txt_cpf.Mask = "000,000,000-00"
        txt_cpf.Name = "txt_cpf"
        txt_cpf.Size = New Size(114, 27)
        txt_cpf.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(19, 121)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 20)
        Label4.TabIndex = 6
        Label4.Text = "Email: "
        ' 
        ' txt_email
        ' 
        txt_email.Location = New Point(79, 117)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(279, 27)
        txt_email.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(363, 121)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 20)
        Label5.TabIndex = 8
        Label5.Text = "Telefone:"
        ' 
        ' txt_telefone
        ' 
        txt_telefone.Location = New Point(443, 117)
        txt_telefone.Mask = "(99) 00000-0000"
        txt_telefone.Name = "txt_telefone"
        txt_telefone.Size = New Size(121, 27)
        txt_telefone.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(19, 157)
        Label6.Name = "Label6"
        Label6.Size = New Size(152, 20)
        Label6.TabIndex = 10
        Label6.Text = "Data de Nascimento: "
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' btn_gravar
        ' 
        btn_gravar.BackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        btn_gravar.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_gravar.ForeColor = SystemColors.ButtonHighlight
        btn_gravar.Location = New Point(443, 187)
        btn_gravar.Name = "btn_gravar"
        btn_gravar.Size = New Size(123, 49)
        btn_gravar.TabIndex = 35
        btn_gravar.Text = "GRAVAR"
        btn_gravar.UseVisualStyleBackColor = False
        ' 
        ' cmb_data_nasc
        ' 
        cmb_data_nasc.Format = DateTimePickerFormat.Short
        cmb_data_nasc.Location = New Point(177, 153)
        cmb_data_nasc.Name = "cmb_data_nasc"
        cmb_data_nasc.Size = New Size(105, 27)
        cmb_data_nasc.TabIndex = 36
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(19, 196)
        Label7.Name = "Label7"
        Label7.Size = New Size(228, 20)
        Label7.TabIndex = 37
        Label7.Text = "Preencheu a Ficha de Anamnese?"
        ' 
        ' cmb_ficha
        ' 
        cmb_ficha.FormattingEnabled = True
        cmb_ficha.Location = New Point(250, 193)
        cmb_ficha.Name = "cmb_ficha"
        cmb_ficha.Size = New Size(76, 28)
        cmb_ficha.TabIndex = 38
        ' 
        ' cadastrocliente
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1081, 548)
        Controls.Add(cmb_ficha)
        Controls.Add(Label7)
        Controls.Add(cmb_data_nasc)
        Controls.Add(btn_gravar)
        Controls.Add(Label6)
        Controls.Add(txt_telefone)
        Controls.Add(Label5)
        Controls.Add(txt_email)
        Controls.Add(Label4)
        Controls.Add(txt_cpf)
        Controls.Add(Label3)
        Controls.Add(txt_nome)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "cadastrocliente"
        StartPosition = FormStartPosition.CenterScreen
        Text = "cadastrocliente"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_telefone As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_gravar As Button
    Friend WithEvents cmb_data_nasc As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_ficha As ComboBox
End Class
