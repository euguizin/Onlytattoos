<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tatuador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tatuador))
        painelesq = New Panel()
        btn_orcamento = New Button()
        Button1 = New Button()
        btn_agendamento = New Button()
        btn_cad_tatuagem = New Button()
        btn_estoque = New Button()
        Label3 = New Label()
        Panel2 = New Panel()
        Panel1 = New Panel()
        painelesq.SuspendLayout()
        SuspendLayout()
        ' 
        ' painelesq
        ' 
        painelesq.BackColor = Color.FromArgb(CByte(25), CByte(42), CByte(86))
        painelesq.Controls.Add(btn_orcamento)
        painelesq.Controls.Add(Button1)
        painelesq.Controls.Add(btn_agendamento)
        painelesq.Controls.Add(btn_cad_tatuagem)
        painelesq.Controls.Add(btn_estoque)
        painelesq.Controls.Add(Label3)
        painelesq.Dock = DockStyle.Left
        painelesq.Location = New Point(0, 0)
        painelesq.Name = "painelesq"
        painelesq.Size = New Size(262, 613)
        painelesq.TabIndex = 0
        ' 
        ' btn_orcamento
        ' 
        btn_orcamento.Cursor = Cursors.Hand
        btn_orcamento.FlatAppearance.BorderSize = 0
        btn_orcamento.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        btn_orcamento.FlatStyle = FlatStyle.Flat
        btn_orcamento.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_orcamento.ForeColor = SystemColors.ButtonHighlight
        btn_orcamento.Image = CType(resources.GetObject("btn_orcamento.Image"), Image)
        btn_orcamento.ImageAlign = ContentAlignment.MiddleLeft
        btn_orcamento.Location = New Point(3, 279)
        btn_orcamento.Name = "btn_orcamento"
        btn_orcamento.Size = New Size(259, 59)
        btn_orcamento.TabIndex = 3
        btn_orcamento.Text = "ORÇAMENTO"
        btn_orcamento.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(0, 558)
        Button1.Name = "Button1"
        Button1.Size = New Size(256, 43)
        Button1.TabIndex = 11
        Button1.Text = "SAIR "
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btn_agendamento
        ' 
        btn_agendamento.Cursor = Cursors.Hand
        btn_agendamento.FlatAppearance.BorderSize = 0
        btn_agendamento.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        btn_agendamento.FlatStyle = FlatStyle.Flat
        btn_agendamento.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_agendamento.ForeColor = SystemColors.ButtonHighlight
        btn_agendamento.Image = CType(resources.GetObject("btn_agendamento.Image"), Image)
        btn_agendamento.ImageAlign = ContentAlignment.MiddleLeft
        btn_agendamento.Location = New Point(3, 344)
        btn_agendamento.Name = "btn_agendamento"
        btn_agendamento.Size = New Size(259, 59)
        btn_agendamento.TabIndex = 2
        btn_agendamento.Text = "AGENDAMENTO"
        btn_agendamento.UseVisualStyleBackColor = True
        ' 
        ' btn_cad_tatuagem
        ' 
        btn_cad_tatuagem.Cursor = Cursors.Hand
        btn_cad_tatuagem.FlatAppearance.BorderSize = 0
        btn_cad_tatuagem.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        btn_cad_tatuagem.FlatStyle = FlatStyle.Flat
        btn_cad_tatuagem.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_cad_tatuagem.ForeColor = SystemColors.ButtonHighlight
        btn_cad_tatuagem.Image = CType(resources.GetObject("btn_cad_tatuagem.Image"), Image)
        btn_cad_tatuagem.ImageAlign = ContentAlignment.MiddleLeft
        btn_cad_tatuagem.Location = New Point(3, 205)
        btn_cad_tatuagem.Name = "btn_cad_tatuagem"
        btn_cad_tatuagem.Size = New Size(259, 77)
        btn_cad_tatuagem.TabIndex = 2
        btn_cad_tatuagem.Text = " CADASTRO DE    TATUAGEM"
        btn_cad_tatuagem.UseVisualStyleBackColor = True
        ' 
        ' btn_estoque
        ' 
        btn_estoque.Cursor = Cursors.Hand
        btn_estoque.FlatAppearance.BorderSize = 0
        btn_estoque.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        btn_estoque.FlatStyle = FlatStyle.Flat
        btn_estoque.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_estoque.ForeColor = SystemColors.ButtonHighlight
        btn_estoque.Image = CType(resources.GetObject("btn_estoque.Image"), Image)
        btn_estoque.ImageAlign = ContentAlignment.MiddleLeft
        btn_estoque.Location = New Point(3, 141)
        btn_estoque.Name = "btn_estoque"
        btn_estoque.Size = New Size(259, 57)
        btn_estoque.TabIndex = 2
        btn_estoque.Text = "ESTOQUE"
        btn_estoque.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(50, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 34)
        Label3.TabIndex = 6
        Label3.Text = "OnlyTattos"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(262, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(935, 56)
        Panel2.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(262, 56)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(935, 557)
        Panel1.TabIndex = 2
        ' 
        ' tatuador
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1197, 613)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(painelesq)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "tatuador"
        Text = "tatuador"
        painelesq.ResumeLayout(False)
        painelesq.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents painelesq As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_agendamento As Button
    Friend WithEvents btn_cad_tatuagem As Button
    Friend WithEvents btn_estoque As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_orcamento As Button
End Class
