<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cad_produto
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
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        btn_excluir_agulhas = New Button()
        cmb_qtd_agulha = New ComboBox()
        Label15 = New Label()
        btn_atualizar_agulha = New Button()
        btn_cadastrar_agulha = New Button()
        txt_valor_agulha = New TextBox()
        txt_qtd_comprada = New TextBox()
        cmb_espessura_agulha = New ComboBox()
        cmb_tipo_agulha = New ComboBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        dgv_agulha = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column26 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        TabPage2 = New TabPage()
        btn_excluir_batoques = New Button()
        dgv_batoque = New DataGridView()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        btn_atualizar_batoque = New Button()
        btn_cadastrar_batoque = New Button()
        txt_valor_batoque = New TextBox()
        Label8 = New Label()
        txt_qtd_batoque = New TextBox()
        Label7 = New Label()
        cmb_tamanho_batoque = New ComboBox()
        Label6 = New Label()
        TabPage3 = New TabPage()
        btn_excluir_tintas = New Button()
        btn_atualizar_tintas = New Button()
        btn_cadastrar_tintas = New Button()
        dgv_tinta = New DataGridView()
        Column14 = New DataGridViewTextBoxColumn()
        Column15 = New DataGridViewTextBoxColumn()
        Column16 = New DataGridViewTextBoxColumn()
        Column17 = New DataGridViewTextBoxColumn()
        txt_valor_tintas = New TextBox()
        Label11 = New Label()
        txt_qtd_tintas = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        cmb_cor_tintas = New ComboBox()
        TabPage4 = New TabPage()
        btn_excluir_produto = New Button()
        dgv_produto_geral = New DataGridView()
        Column20 = New DataGridViewTextBoxColumn()
        Column21 = New DataGridViewTextBoxColumn()
        Column22 = New DataGridViewTextBoxColumn()
        Column23 = New DataGridViewTextBoxColumn()
        btn_atualizar_produto = New Button()
        btn_cadastrar_produto = New Button()
        txt_valor_produto = New TextBox()
        Label14 = New Label()
        txt_qtd_produto = New TextBox()
        Label13 = New Label()
        cmb_produto = New ComboBox()
        Label12 = New Label()
        Label1 = New Label()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(dgv_agulha, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(dgv_batoque, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        CType(dgv_tinta, ComponentModel.ISupportInitialize).BeginInit()
        TabPage4.SuspendLayout()
        CType(dgv_produto_geral, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Location = New Point(25, 56)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(905, 553)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(btn_excluir_agulhas)
        TabPage1.Controls.Add(cmb_qtd_agulha)
        TabPage1.Controls.Add(Label15)
        TabPage1.Controls.Add(btn_atualizar_agulha)
        TabPage1.Controls.Add(btn_cadastrar_agulha)
        TabPage1.Controls.Add(txt_valor_agulha)
        TabPage1.Controls.Add(txt_qtd_comprada)
        TabPage1.Controls.Add(cmb_espessura_agulha)
        TabPage1.Controls.Add(cmb_tipo_agulha)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(dgv_agulha)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(897, 520)
        TabPage1.TabIndex = 0
        TabPage1.Text = "AGULHAS"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' btn_excluir_agulhas
        ' 
        btn_excluir_agulhas.Location = New Point(766, 139)
        btn_excluir_agulhas.Name = "btn_excluir_agulhas"
        btn_excluir_agulhas.Size = New Size(109, 49)
        btn_excluir_agulhas.TabIndex = 13
        btn_excluir_agulhas.Text = "EXCLUIR"
        btn_excluir_agulhas.UseVisualStyleBackColor = True
        ' 
        ' cmb_qtd_agulha
        ' 
        cmb_qtd_agulha.FormattingEnabled = True
        cmb_qtd_agulha.Location = New Point(525, 52)
        cmb_qtd_agulha.Name = "cmb_qtd_agulha"
        cmb_qtd_agulha.Size = New Size(76, 28)
        cmb_qtd_agulha.TabIndex = 12
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(353, 52)
        Label15.Name = "Label15"
        Label15.Size = New Size(166, 20)
        Label15.TabIndex = 11
        Label15.Text = "Quantidade de agulhas:"
        ' 
        ' btn_atualizar_agulha
        ' 
        btn_atualizar_agulha.Location = New Point(767, 81)
        btn_atualizar_agulha.Name = "btn_atualizar_agulha"
        btn_atualizar_agulha.Size = New Size(109, 49)
        btn_atualizar_agulha.TabIndex = 10
        btn_atualizar_agulha.Text = "ATUALIZAR"
        btn_atualizar_agulha.UseVisualStyleBackColor = True
        ' 
        ' btn_cadastrar_agulha
        ' 
        btn_cadastrar_agulha.Location = New Point(766, 23)
        btn_cadastrar_agulha.Name = "btn_cadastrar_agulha"
        btn_cadastrar_agulha.Size = New Size(109, 49)
        btn_cadastrar_agulha.TabIndex = 9
        btn_cadastrar_agulha.Text = "CADASTRAR"
        btn_cadastrar_agulha.UseVisualStyleBackColor = True
        ' 
        ' txt_valor_agulha
        ' 
        txt_valor_agulha.Location = New Point(446, 120)
        txt_valor_agulha.Name = "txt_valor_agulha"
        txt_valor_agulha.Size = New Size(73, 27)
        txt_valor_agulha.TabIndex = 8
        ' 
        ' txt_qtd_comprada
        ' 
        txt_qtd_comprada.Location = New Point(248, 120)
        txt_qtd_comprada.Name = "txt_qtd_comprada"
        txt_qtd_comprada.Size = New Size(73, 27)
        txt_qtd_comprada.TabIndex = 7
        ' 
        ' cmb_espessura_agulha
        ' 
        cmb_espessura_agulha.FormattingEnabled = True
        cmb_espessura_agulha.Location = New Point(248, 49)
        cmb_espessura_agulha.Name = "cmb_espessura_agulha"
        cmb_espessura_agulha.Size = New Size(76, 28)
        cmb_espessura_agulha.TabIndex = 6
        ' 
        ' cmb_tipo_agulha
        ' 
        cmb_tipo_agulha.FormattingEnabled = True
        cmb_tipo_agulha.Location = New Point(67, 49)
        cmb_tipo_agulha.Name = "cmb_tipo_agulha"
        cmb_tipo_agulha.Size = New Size(76, 28)
        cmb_tipo_agulha.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(366, 124)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 20)
        Label5.TabIndex = 4
        Label5.Text = "Valor Total:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(101, 124)
        Label4.Name = "Label4"
        Label4.Size = New Size(135, 20)
        Label4.TabIndex = 3
        Label4.Text = "Volume comprado:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(166, 52)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 20)
        Label3.TabIndex = 2
        Label3.Text = "Espessura:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 20)
        Label2.TabIndex = 1
        Label2.Text = "Tipo:"
        ' 
        ' dgv_agulha
        ' 
        dgv_agulha.AllowUserToAddRows = False
        dgv_agulha.AllowUserToDeleteRows = False
        dgv_agulha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_agulha.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv_agulha.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_agulha.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column26, Column4, Column5})
        dgv_agulha.Location = New Point(19, 195)
        dgv_agulha.Name = "dgv_agulha"
        dgv_agulha.ReadOnly = True
        dgv_agulha.RowHeadersWidth = 51
        dgv_agulha.Size = New Size(855, 291)
        dgv_agulha.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Tipo"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 68
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Espessura"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 102
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Quantidade de agulhas"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 129
        ' 
        ' Column26
        ' 
        Column26.HeaderText = "Volume Comprado"
        Column26.MinimumWidth = 6
        Column26.Name = "Column26"
        Column26.ReadOnly = True
        Column26.Width = 149
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Valor Unitário"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 119
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Valor Total"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 101
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(btn_excluir_batoques)
        TabPage2.Controls.Add(dgv_batoque)
        TabPage2.Controls.Add(btn_atualizar_batoque)
        TabPage2.Controls.Add(btn_cadastrar_batoque)
        TabPage2.Controls.Add(txt_valor_batoque)
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(txt_qtd_batoque)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(cmb_tamanho_batoque)
        TabPage2.Controls.Add(Label6)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(897, 520)
        TabPage2.TabIndex = 1
        TabPage2.Text = "BATOQUES"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' btn_excluir_batoques
        ' 
        btn_excluir_batoques.Location = New Point(767, 140)
        btn_excluir_batoques.Name = "btn_excluir_batoques"
        btn_excluir_batoques.Size = New Size(109, 49)
        btn_excluir_batoques.TabIndex = 14
        btn_excluir_batoques.Text = "EXCLUIR"
        btn_excluir_batoques.UseVisualStyleBackColor = True
        ' 
        ' dgv_batoque
        ' 
        dgv_batoque.AllowUserToAddRows = False
        dgv_batoque.AllowUserToDeleteRows = False
        dgv_batoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_batoque.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv_batoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_batoque.Columns.AddRange(New DataGridViewColumn() {Column8, Column9, Column10, Column11})
        dgv_batoque.Location = New Point(19, 195)
        dgv_batoque.Name = "dgv_batoque"
        dgv_batoque.ReadOnly = True
        dgv_batoque.RowHeadersWidth = 51
        dgv_batoque.Size = New Size(855, 291)
        dgv_batoque.TabIndex = 13
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Tamanho"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 98
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Quantidade"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 116
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "Valor Unitário"
        Column10.MinimumWidth = 6
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        Column10.Width = 129
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "Valor Total"
        Column11.MinimumWidth = 6
        Column11.Name = "Column11"
        Column11.ReadOnly = True
        Column11.Width = 109
        ' 
        ' btn_atualizar_batoque
        ' 
        btn_atualizar_batoque.Location = New Point(767, 81)
        btn_atualizar_batoque.Name = "btn_atualizar_batoque"
        btn_atualizar_batoque.Size = New Size(109, 49)
        btn_atualizar_batoque.TabIndex = 12
        btn_atualizar_batoque.Text = "ATUALIZAR"
        btn_atualizar_batoque.UseVisualStyleBackColor = True
        ' 
        ' btn_cadastrar_batoque
        ' 
        btn_cadastrar_batoque.Location = New Point(766, 23)
        btn_cadastrar_batoque.Name = "btn_cadastrar_batoque"
        btn_cadastrar_batoque.Size = New Size(109, 49)
        btn_cadastrar_batoque.TabIndex = 11
        btn_cadastrar_batoque.Text = "CADASTRAR"
        btn_cadastrar_batoque.UseVisualStyleBackColor = True
        ' 
        ' txt_valor_batoque
        ' 
        txt_valor_batoque.Location = New Point(251, 109)
        txt_valor_batoque.Name = "txt_valor_batoque"
        txt_valor_batoque.Size = New Size(73, 27)
        txt_valor_batoque.TabIndex = 10
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(197, 113)
        Label8.Name = "Label8"
        Label8.Size = New Size(46, 20)
        Label8.TabIndex = 9
        Label8.Text = "Valor:"
        ' 
        ' txt_qtd_batoque
        ' 
        txt_qtd_batoque.Location = New Point(115, 109)
        txt_qtd_batoque.Name = "txt_qtd_batoque"
        txt_qtd_batoque.Size = New Size(73, 27)
        txt_qtd_batoque.TabIndex = 8
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(19, 113)
        Label7.Name = "Label7"
        Label7.Size = New Size(90, 20)
        Label7.TabIndex = 7
        Label7.Text = "Quantidade:"
        ' 
        ' cmb_tamanho_batoque
        ' 
        cmb_tamanho_batoque.FormattingEnabled = True
        cmb_tamanho_batoque.Location = New Point(97, 49)
        cmb_tamanho_batoque.Name = "cmb_tamanho_batoque"
        cmb_tamanho_batoque.Size = New Size(76, 28)
        cmb_tamanho_batoque.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(19, 52)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 20)
        Label6.TabIndex = 0
        Label6.Text = "Tamanho:"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(btn_excluir_tintas)
        TabPage3.Controls.Add(btn_atualizar_tintas)
        TabPage3.Controls.Add(btn_cadastrar_tintas)
        TabPage3.Controls.Add(dgv_tinta)
        TabPage3.Controls.Add(txt_valor_tintas)
        TabPage3.Controls.Add(Label11)
        TabPage3.Controls.Add(txt_qtd_tintas)
        TabPage3.Controls.Add(Label10)
        TabPage3.Controls.Add(Label9)
        TabPage3.Controls.Add(cmb_cor_tintas)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(897, 520)
        TabPage3.TabIndex = 2
        TabPage3.Text = "TINTAS"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' btn_excluir_tintas
        ' 
        btn_excluir_tintas.Location = New Point(767, 140)
        btn_excluir_tintas.Name = "btn_excluir_tintas"
        btn_excluir_tintas.Size = New Size(109, 49)
        btn_excluir_tintas.TabIndex = 9
        btn_excluir_tintas.Text = "EXCLUIR"
        btn_excluir_tintas.UseVisualStyleBackColor = True
        ' 
        ' btn_atualizar_tintas
        ' 
        btn_atualizar_tintas.Location = New Point(767, 81)
        btn_atualizar_tintas.Name = "btn_atualizar_tintas"
        btn_atualizar_tintas.Size = New Size(109, 49)
        btn_atualizar_tintas.TabIndex = 8
        btn_atualizar_tintas.Text = "ATUALIZAR"
        btn_atualizar_tintas.UseVisualStyleBackColor = True
        ' 
        ' btn_cadastrar_tintas
        ' 
        btn_cadastrar_tintas.Location = New Point(766, 23)
        btn_cadastrar_tintas.Name = "btn_cadastrar_tintas"
        btn_cadastrar_tintas.Size = New Size(109, 49)
        btn_cadastrar_tintas.TabIndex = 7
        btn_cadastrar_tintas.Text = "CADASTRAR"
        btn_cadastrar_tintas.UseVisualStyleBackColor = True
        ' 
        ' dgv_tinta
        ' 
        dgv_tinta.AllowUserToAddRows = False
        dgv_tinta.AllowUserToDeleteRows = False
        dgv_tinta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_tinta.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv_tinta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_tinta.Columns.AddRange(New DataGridViewColumn() {Column14, Column15, Column16, Column17})
        dgv_tinta.Location = New Point(19, 195)
        dgv_tinta.Name = "dgv_tinta"
        dgv_tinta.ReadOnly = True
        dgv_tinta.RowHeadersWidth = 51
        dgv_tinta.Size = New Size(855, 291)
        dgv_tinta.TabIndex = 6
        ' 
        ' Column14
        ' 
        Column14.HeaderText = "Cor"
        Column14.MinimumWidth = 6
        Column14.Name = "Column14"
        Column14.ReadOnly = True
        Column14.Width = 61
        ' 
        ' Column15
        ' 
        Column15.HeaderText = "Quantidade em ML"
        Column15.MinimumWidth = 6
        Column15.Name = "Column15"
        Column15.ReadOnly = True
        Column15.Width = 133
        ' 
        ' Column16
        ' 
        Column16.HeaderText = "Valor Unitário p/ ML"
        Column16.MinimumWidth = 6
        Column16.Name = "Column16"
        Column16.ReadOnly = True
        Column16.Width = 139
        ' 
        ' Column17
        ' 
        Column17.HeaderText = "Valor Total"
        Column17.MinimumWidth = 6
        Column17.Name = "Column17"
        Column17.ReadOnly = True
        Column17.Width = 101
        ' 
        ' txt_valor_tintas
        ' 
        txt_valor_tintas.Location = New Point(286, 84)
        txt_valor_tintas.Name = "txt_valor_tintas"
        txt_valor_tintas.Size = New Size(67, 27)
        txt_valor_tintas.TabIndex = 5
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(234, 88)
        Label11.Name = "Label11"
        Label11.Size = New Size(46, 20)
        Label11.TabIndex = 4
        Label11.Text = "Valor:"
        ' 
        ' txt_qtd_tintas
        ' 
        txt_qtd_tintas.Location = New Point(152, 84)
        txt_qtd_tintas.Name = "txt_qtd_tintas"
        txt_qtd_tintas.Size = New Size(76, 27)
        txt_qtd_tintas.TabIndex = 3
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(17, 91)
        Label10.Name = "Label10"
        Label10.Size = New Size(139, 20)
        Label10.TabIndex = 2
        Label10.Text = "Quantidade em ML:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(17, 47)
        Label9.Name = "Label9"
        Label9.Size = New Size(39, 20)
        Label9.TabIndex = 1
        Label9.Text = "Cor: "
        ' 
        ' cmb_cor_tintas
        ' 
        cmb_cor_tintas.FormattingEnabled = True
        cmb_cor_tintas.Location = New Point(62, 44)
        cmb_cor_tintas.Name = "cmb_cor_tintas"
        cmb_cor_tintas.Size = New Size(79, 28)
        cmb_cor_tintas.TabIndex = 0
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(btn_excluir_produto)
        TabPage4.Controls.Add(dgv_produto_geral)
        TabPage4.Controls.Add(btn_atualizar_produto)
        TabPage4.Controls.Add(btn_cadastrar_produto)
        TabPage4.Controls.Add(txt_valor_produto)
        TabPage4.Controls.Add(Label14)
        TabPage4.Controls.Add(txt_qtd_produto)
        TabPage4.Controls.Add(Label13)
        TabPage4.Controls.Add(cmb_produto)
        TabPage4.Controls.Add(Label12)
        TabPage4.Location = New Point(4, 29)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(897, 520)
        TabPage4.TabIndex = 3
        TabPage4.Text = "PRODUTOS EM GERAL"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' btn_excluir_produto
        ' 
        btn_excluir_produto.Location = New Point(767, 140)
        btn_excluir_produto.Name = "btn_excluir_produto"
        btn_excluir_produto.Size = New Size(109, 49)
        btn_excluir_produto.TabIndex = 9
        btn_excluir_produto.Text = "EXCLUIR"
        btn_excluir_produto.UseVisualStyleBackColor = True
        ' 
        ' dgv_produto_geral
        ' 
        dgv_produto_geral.AllowUserToAddRows = False
        dgv_produto_geral.AllowUserToDeleteRows = False
        dgv_produto_geral.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_produto_geral.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv_produto_geral.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_produto_geral.Columns.AddRange(New DataGridViewColumn() {Column20, Column21, Column22, Column23})
        dgv_produto_geral.Location = New Point(19, 195)
        dgv_produto_geral.Name = "dgv_produto_geral"
        dgv_produto_geral.ReadOnly = True
        dgv_produto_geral.RowHeadersWidth = 51
        dgv_produto_geral.Size = New Size(855, 291)
        dgv_produto_geral.TabIndex = 8
        ' 
        ' Column20
        ' 
        Column20.HeaderText = "Produto"
        Column20.MinimumWidth = 6
        Column20.Name = "Column20"
        Column20.ReadOnly = True
        Column20.Width = 91
        ' 
        ' Column21
        ' 
        Column21.HeaderText = "Quantidade un/ml"
        Column21.MinimumWidth = 6
        Column21.Name = "Column21"
        Column21.ReadOnly = True
        Column21.Width = 146
        ' 
        ' Column22
        ' 
        Column22.HeaderText = "Valor Unitário"
        Column22.MinimumWidth = 6
        Column22.Name = "Column22"
        Column22.ReadOnly = True
        Column22.Width = 119
        ' 
        ' Column23
        ' 
        Column23.HeaderText = "Valor Total"
        Column23.MinimumWidth = 6
        Column23.Name = "Column23"
        Column23.ReadOnly = True
        Column23.Width = 101
        ' 
        ' btn_atualizar_produto
        ' 
        btn_atualizar_produto.Location = New Point(767, 81)
        btn_atualizar_produto.Name = "btn_atualizar_produto"
        btn_atualizar_produto.Size = New Size(109, 49)
        btn_atualizar_produto.TabIndex = 7
        btn_atualizar_produto.Text = "ATUALIZAR"
        btn_atualizar_produto.UseVisualStyleBackColor = True
        ' 
        ' btn_cadastrar_produto
        ' 
        btn_cadastrar_produto.Location = New Point(766, 23)
        btn_cadastrar_produto.Name = "btn_cadastrar_produto"
        btn_cadastrar_produto.Size = New Size(109, 49)
        btn_cadastrar_produto.TabIndex = 6
        btn_cadastrar_produto.Text = "CADASTRAR"
        btn_cadastrar_produto.UseVisualStyleBackColor = True
        ' 
        ' txt_valor_produto
        ' 
        txt_valor_produto.Location = New Point(287, 79)
        txt_valor_produto.Name = "txt_valor_produto"
        txt_valor_produto.Size = New Size(86, 27)
        txt_valor_produto.TabIndex = 5
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(234, 81)
        Label14.Name = "Label14"
        Label14.Size = New Size(46, 20)
        Label14.TabIndex = 4
        Label14.Text = "Valor:"
        ' 
        ' txt_qtd_produto
        ' 
        txt_qtd_produto.Location = New Point(143, 79)
        txt_qtd_produto.Name = "txt_qtd_produto"
        txt_qtd_produto.Size = New Size(86, 27)
        txt_qtd_produto.TabIndex = 3
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(16, 83)
        Label13.Name = "Label13"
        Label13.Size = New Size(130, 20)
        Label13.TabIndex = 2
        Label13.Text = "Quantidade un/ml"
        ' 
        ' cmb_produto
        ' 
        cmb_produto.FormattingEnabled = True
        cmb_produto.Location = New Point(91, 29)
        cmb_produto.Name = "cmb_produto"
        cmb_produto.Size = New Size(117, 28)
        cmb_produto.TabIndex = 1
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(16, 32)
        Label12.Name = "Label12"
        Label12.Size = New Size(69, 20)
        Label12.TabIndex = 0
        Label12.Text = "Produto: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(394, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(149, 34)
        Label1.TabIndex = 1
        Label1.Text = "ESTOQUE"
        ' 
        ' cad_produto
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(979, 704)
        Controls.Add(Label1)
        Controls.Add(TabControl1)
        FormBorderStyle = FormBorderStyle.None
        Name = "cad_produto"
        Text = "cad_produto"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(dgv_agulha, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(dgv_batoque, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        CType(dgv_tinta, ComponentModel.ISupportInitialize).EndInit()
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        CType(dgv_produto_geral, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents dgv_agulha As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_espessura_agulha As ComboBox
    Friend WithEvents cmb_tipo_agulha As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_valor_agulha As TextBox
    Friend WithEvents txt_qtd_comprada As TextBox
    Friend WithEvents btn_atualizar_agulha As Button
    Friend WithEvents btn_cadastrar_agulha As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_tamanho_batoque As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_valor_batoque As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_qtd_batoque As TextBox
    Friend WithEvents dgv_batoque As DataGridView
    Friend WithEvents btn_atualizar_batoque As Button
    Friend WithEvents btn_cadastrar_batoque As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents cmb_cor_tintas As ComboBox
    Friend WithEvents btn_atualizar_tintas As Button
    Friend WithEvents btn_cadastrar_tintas As Button
    Friend WithEvents dgv_tinta As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_qtd_produto As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cmb_produto As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents dgv_produto_geral As DataGridView
    Friend WithEvents btn_atualizar_produto As Button
    Friend WithEvents btn_cadastrar_produto As Button
    Friend WithEvents txt_valor_produto As TextBox
    Friend WithEvents cmb_qtd_agulha As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_valor_tintas As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_qtd_tintas As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_excluir_agulhas As Button
    Friend WithEvents btn_excluir_produto As Button
    Friend WithEvents btn_excluir_batoques As Button
    Friend WithEvents btn_excluir_tintas As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column26 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents Column21 As DataGridViewTextBoxColumn
    Friend WithEvents Column22 As DataGridViewTextBoxColumn
    Friend WithEvents Column23 As DataGridViewTextBoxColumn
End Class
