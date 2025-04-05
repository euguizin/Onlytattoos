<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class horarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(horarios))
        dgv_horario = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewImageColumn()
        Column5 = New DataGridViewImageColumn()
        Label1 = New Label()
        CType(dgv_horario, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgv_horario
        ' 
        dgv_horario.AllowUserToAddRows = False
        dgv_horario.AllowUserToDeleteRows = False
        dgv_horario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_horario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv_horario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_horario.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        dgv_horario.Location = New Point(32, 156)
        dgv_horario.Name = "dgv_horario"
        dgv_horario.ReadOnly = True
        dgv_horario.RowHeadersWidth = 51
        dgv_horario.Size = New Size(871, 354)
        dgv_horario.TabIndex = 12
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(306, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(359, 34)
        Label1.TabIndex = 13
        Label1.Text = "HORARIOS AGENDADOS"
        ' 
        ' horarios
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(929, 590)
        Controls.Add(Label1)
        Controls.Add(dgv_horario)
        FormBorderStyle = FormBorderStyle.None
        Name = "horarios"
        Text = "horarios"
        CType(dgv_horario, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgv_horario As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Label1 As Label
End Class
