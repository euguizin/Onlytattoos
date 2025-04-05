<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agendamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(agendamento))
        Label1 = New Label()
        Label2 = New Label()
        txt_nome = New TextBox()
        cmb_data_tattoo = New DateTimePicker()
        Label4 = New Label()
        drop_horario = New ComboBox()
        Label5 = New Label()
        btn_confirmar = New Button()
        dgv_agendamento = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewImageColumn()
        Column5 = New DataGridViewImageColumn()
        Label3 = New Label()
        txt_cpf = New MaskedTextBox()
        btn_atualizar = New Button()
        CType(dgv_agendamento, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(239, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(431, 34)
        Label1.TabIndex = 1
        Label1.Text = "AGENDAMENTO DE CLIENTES"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(1, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 20)
        Label2.TabIndex = 2
        Label2.Text = "Nome: "
        ' 
        ' txt_nome
        ' 
        txt_nome.Location = New Point(52, 139)
        txt_nome.Name = "txt_nome"
        txt_nome.Size = New Size(262, 27)
        txt_nome.TabIndex = 3
        ' 
        ' cmb_data_tattoo
        ' 
        cmb_data_tattoo.Format = DateTimePickerFormat.Short
        cmb_data_tattoo.Location = New Point(121, 173)
        cmb_data_tattoo.Name = "cmb_data_tattoo"
        cmb_data_tattoo.Size = New Size(126, 27)
        cmb_data_tattoo.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(1, 178)
        Label4.Name = "Label4"
        Label4.Size = New Size(114, 20)
        Label4.TabIndex = 7
        Label4.Text = "Data da Sessão:"
        ' 
        ' drop_horario
        ' 
        drop_horario.FormattingEnabled = True
        drop_horario.Location = New Point(70, 208)
        drop_horario.Name = "drop_horario"
        drop_horario.Size = New Size(128, 28)
        drop_horario.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(1, 211)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 20)
        Label5.TabIndex = 9
        Label5.Text = "Horário:"
        ' 
        ' btn_confirmar
        ' 
        btn_confirmar.Location = New Point(23, 253)
        btn_confirmar.Name = "btn_confirmar"
        btn_confirmar.Size = New Size(105, 38)
        btn_confirmar.TabIndex = 10
        btn_confirmar.Text = "CONFIRMAR"
        btn_confirmar.UseVisualStyleBackColor = True
        ' 
        ' dgv_agendamento
        ' 
        dgv_agendamento.AllowUserToAddRows = False
        dgv_agendamento.AllowUserToDeleteRows = False
        dgv_agendamento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_agendamento.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv_agendamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_agendamento.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        dgv_agendamento.Location = New Point(320, 94)
        dgv_agendamento.Name = "dgv_agendamento"
        dgv_agendamento.ReadOnly = True
        dgv_agendamento.RowHeadersWidth = 51
        dgv_agendamento.Size = New Size(743, 435)
        dgv_agendamento.TabIndex = 11
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Nome"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 79
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Data"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 70
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Horário"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 89
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "EDITAR"
        Column4.Image = CType(resources.GetObject("Column4.Image"), Image)
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 64
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "EXCLUIR"
        Column5.Image = CType(resources.GetObject("Column5.Image"), Image)
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 71
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(1, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 20)
        Label3.TabIndex = 12
        Label3.Text = "CPF:"
        ' 
        ' txt_cpf
        ' 
        txt_cpf.Location = New Point(43, 103)
        txt_cpf.Mask = "000,000,000-00"
        txt_cpf.Name = "txt_cpf"
        txt_cpf.Size = New Size(97, 27)
        txt_cpf.TabIndex = 13
        ' 
        ' btn_atualizar
        ' 
        btn_atualizar.Location = New Point(163, 253)
        btn_atualizar.Name = "btn_atualizar"
        btn_atualizar.Size = New Size(105, 38)
        btn_atualizar.TabIndex = 14
        btn_atualizar.Text = "ATUALIZAR"
        btn_atualizar.UseVisualStyleBackColor = True
        ' 
        ' agendamento
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1081, 548)
        Controls.Add(btn_atualizar)
        Controls.Add(txt_cpf)
        Controls.Add(Label3)
        Controls.Add(dgv_agendamento)
        Controls.Add(btn_confirmar)
        Controls.Add(Label5)
        Controls.Add(drop_horario)
        Controls.Add(Label4)
        Controls.Add(cmb_data_tattoo)
        Controls.Add(txt_nome)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "agendamento"
        Text = "agendamento"
        WindowState = FormWindowState.Maximized
        CType(dgv_agendamento, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents cmb_data_tattoo As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents drop_horario As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents dgv_agendamento As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents btn_atualizar As Button
End Class
