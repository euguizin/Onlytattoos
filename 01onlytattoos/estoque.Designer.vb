<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class estoque
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
        Label1 = New Label()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        dgv_agulha = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column26 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        TabPage3 = New TabPage()
        dgv_tinta = New DataGridView()
        Column14 = New DataGridViewTextBoxColumn()
        Column15 = New DataGridViewTextBoxColumn()
        Column16 = New DataGridViewTextBoxColumn()
        Column17 = New DataGridViewTextBoxColumn()
        TabPage2 = New TabPage()
        dgv_batoque = New DataGridView()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        TabPage4 = New TabPage()
        dgv_produto_geral = New DataGridView()
        Column20 = New DataGridViewTextBoxColumn()
        Column21 = New DataGridViewTextBoxColumn()
        Column22 = New DataGridViewTextBoxColumn()
        Column23 = New DataGridViewTextBoxColumn()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(dgv_agulha, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        CType(dgv_tinta, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(dgv_batoque, ComponentModel.ISupportInitialize).BeginInit()
        TabPage4.SuspendLayout()
        CType(dgv_produto_geral, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(367, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(149, 34)
        Label1.TabIndex = 0
        Label1.Text = "ESTOQUE"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Location = New Point(14, 85)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(856, 421)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(dgv_agulha)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(848, 388)
        TabPage1.TabIndex = 0
        TabPage1.Text = " Agulhas "
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' dgv_agulha
        ' 
        dgv_agulha.AllowUserToAddRows = False
        dgv_agulha.AllowUserToDeleteRows = False
        dgv_agulha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_agulha.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv_agulha.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_agulha.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column26, Column4, Column5})
        dgv_agulha.Location = New Point(15, 40)
        dgv_agulha.Name = "dgv_agulha"
        dgv_agulha.ReadOnly = True
        dgv_agulha.RowHeadersWidth = 51
        dgv_agulha.Size = New Size(791, 291)
        dgv_agulha.TabIndex = 2
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
        ' TabPage3
        ' 
        TabPage3.Controls.Add(dgv_tinta)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(848, 388)
        TabPage3.TabIndex = 2
        TabPage3.Text = " Tintas "
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' dgv_tinta
        ' 
        dgv_tinta.AllowUserToAddRows = False
        dgv_tinta.AllowUserToDeleteRows = False
        dgv_tinta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_tinta.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv_tinta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_tinta.Columns.AddRange(New DataGridViewColumn() {Column14, Column15, Column16, Column17})
        dgv_tinta.Location = New Point(15, 40)
        dgv_tinta.Name = "dgv_tinta"
        dgv_tinta.ReadOnly = True
        dgv_tinta.RowHeadersWidth = 51
        dgv_tinta.Size = New Size(791, 291)
        dgv_tinta.TabIndex = 7
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
        ' TabPage2
        ' 
        TabPage2.Controls.Add(dgv_batoque)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(848, 388)
        TabPage2.TabIndex = 3
        TabPage2.Text = " Batoques "
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' dgv_batoque
        ' 
        dgv_batoque.AllowUserToAddRows = False
        dgv_batoque.AllowUserToDeleteRows = False
        dgv_batoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_batoque.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv_batoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_batoque.Columns.AddRange(New DataGridViewColumn() {Column8, Column9, Column10, Column11})
        dgv_batoque.Location = New Point(15, 40)
        dgv_batoque.Name = "dgv_batoque"
        dgv_batoque.ReadOnly = True
        dgv_batoque.RowHeadersWidth = 51
        dgv_batoque.Size = New Size(791, 291)
        dgv_batoque.TabIndex = 14
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
        ' TabPage4
        ' 
        TabPage4.Controls.Add(dgv_produto_geral)
        TabPage4.Location = New Point(4, 29)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(848, 388)
        TabPage4.TabIndex = 4
        TabPage4.Text = " Produtos Geral "
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' dgv_produto_geral
        ' 
        dgv_produto_geral.AllowUserToAddRows = False
        dgv_produto_geral.AllowUserToDeleteRows = False
        dgv_produto_geral.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_produto_geral.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv_produto_geral.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_produto_geral.Columns.AddRange(New DataGridViewColumn() {Column20, Column21, Column22, Column23})
        dgv_produto_geral.Location = New Point(15, 40)
        dgv_produto_geral.Name = "dgv_produto_geral"
        dgv_produto_geral.ReadOnly = True
        dgv_produto_geral.RowHeadersWidth = 51
        dgv_produto_geral.Size = New Size(791, 291)
        dgv_produto_geral.TabIndex = 9
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
        ' estoque
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(950, 554)
        Controls.Add(TabControl1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "estoque"
        Text = "estoque"
        WindowState = FormWindowState.Maximized
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        CType(dgv_agulha, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        CType(dgv_tinta, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        CType(dgv_batoque, ComponentModel.ISupportInitialize).EndInit()
        TabPage4.ResumeLayout(False)
        CType(dgv_produto_geral, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents dgv_agulha As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column26 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents dgv_tinta As DataGridView
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents dgv_batoque As DataGridView
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents dgv_produto_geral As DataGridView
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents Column21 As DataGridViewTextBoxColumn
    Friend WithEvents Column22 As DataGridViewTextBoxColumn
    Friend WithEvents Column23 As DataGridViewTextBoxColumn
End Class
