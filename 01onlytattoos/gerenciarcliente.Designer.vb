<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gerenciarcliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gerenciarcliente))
        Label1 = New Label()
        cmb_data_nasc = New DateTimePicker()
        Label6 = New Label()
        txt_telefone = New MaskedTextBox()
        Label5 = New Label()
        txt_email = New TextBox()
        Label4 = New Label()
        txt_cpf = New MaskedTextBox()
        Label3 = New Label()
        txt_nome = New TextBox()
        Label2 = New Label()
        dgv_dados = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewImageColumn()
        Column6 = New DataGridViewImageColumn()
        cmb_tipo = New ComboBox()
        Label7 = New Label()
        txt_busca = New TextBox()
        btn_confirmar = New Button()
        CType(dgv_dados, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(159, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(461, 34)
        Label1.TabIndex = 1
        Label1.Text = "GERENCIAMENTO DE CLIENTES"
        ' 
        ' cmb_data_nasc
        ' 
        cmb_data_nasc.Format = DateTimePickerFormat.Short
        cmb_data_nasc.Location = New Point(170, 141)
        cmb_data_nasc.Name = "cmb_data_nasc"
        cmb_data_nasc.Size = New Size(104, 27)
        cmb_data_nasc.TabIndex = 46
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 144)
        Label6.Name = "Label6"
        Label6.Size = New Size(152, 20)
        Label6.TabIndex = 45
        Label6.Text = "Data de Nascimento: "
        ' 
        ' txt_telefone
        ' 
        txt_telefone.Location = New Point(437, 108)
        txt_telefone.Mask = "(99) 00000-0000"
        txt_telefone.Name = "txt_telefone"
        txt_telefone.Size = New Size(121, 27)
        txt_telefone.TabIndex = 44
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(357, 111)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 20)
        Label5.TabIndex = 43
        Label5.Text = "Telefone:"
        ' 
        ' txt_email
        ' 
        txt_email.Location = New Point(72, 108)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(279, 27)
        txt_email.TabIndex = 42
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 111)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 20)
        Label4.TabIndex = 41
        Label4.Text = "Email: "
        ' 
        ' txt_cpf
        ' 
        txt_cpf.Location = New Point(384, 70)
        txt_cpf.Mask = "000,000,000-00"
        txt_cpf.Name = "txt_cpf"
        txt_cpf.Size = New Size(114, 27)
        txt_cpf.TabIndex = 40
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(342, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 20)
        Label3.TabIndex = 39
        Label3.Text = "CPF:"
        ' 
        ' txt_nome
        ' 
        txt_nome.Location = New Point(72, 69)
        txt_nome.Name = "txt_nome"
        txt_nome.Size = New Size(247, 27)
        txt_nome.TabIndex = 38
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 20)
        Label2.TabIndex = 37
        Label2.Text = "Nome: "
        ' 
        ' dgv_dados
        ' 
        dgv_dados.AllowUserToAddRows = False
        dgv_dados.AllowUserToDeleteRows = False
        dgv_dados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_dados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv_dados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_dados.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        dgv_dados.Location = New Point(7, 240)
        dgv_dados.Name = "dgv_dados"
        dgv_dados.ReadOnly = True
        dgv_dados.RowHeadersWidth = 51
        dgv_dados.Size = New Size(882, 286)
        dgv_dados.TabIndex = 47
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "CPF"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 62
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "NOME"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 81
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "DATA DE NASCIMENTO"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 177
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "TELEFONE"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 106
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "EDITAR"
        Column5.Image = CType(resources.GetObject("Column5.Image"), Image)
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 64
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "EXCLUIR"
        Column6.Image = CType(resources.GetObject("Column6.Image"), Image)
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 71
        ' 
        ' cmb_tipo
        ' 
        cmb_tipo.FormattingEnabled = True
        cmb_tipo.Location = New Point(113, 203)
        cmb_tipo.Name = "cmb_tipo"
        cmb_tipo.Size = New Size(151, 28)
        cmb_tipo.TabIndex = 49
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(7, 206)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 20)
        Label7.TabIndex = 50
        Label7.Text = "Pesquisar por:"
        ' 
        ' txt_busca
        ' 
        txt_busca.Location = New Point(270, 203)
        txt_busca.Name = "txt_busca"
        txt_busca.Size = New Size(198, 27)
        txt_busca.TabIndex = 51
        ' 
        ' btn_confirmar
        ' 
        btn_confirmar.Location = New Point(497, 177)
        btn_confirmar.Name = "btn_confirmar"
        btn_confirmar.Size = New Size(112, 49)
        btn_confirmar.TabIndex = 52
        btn_confirmar.Text = "CONFIRMAR"
        btn_confirmar.UseVisualStyleBackColor = True
        ' 
        ' gerenciarcliente
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1081, 548)
        Controls.Add(btn_confirmar)
        Controls.Add(txt_busca)
        Controls.Add(Label7)
        Controls.Add(cmb_tipo)
        Controls.Add(dgv_dados)
        Controls.Add(cmb_data_nasc)
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
        FormBorderStyle = FormBorderStyle.None
        Name = "gerenciarcliente"
        Text = "gerenciarcliente"
        CType(dgv_dados, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_data_nasc As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_telefone As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_busca As TextBox
    Friend WithEvents btn_confirmar As Button
End Class
