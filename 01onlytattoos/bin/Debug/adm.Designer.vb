<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adm))
        Panel1 = New Panel()
        Panel2 = New Panel()
        btn_novocad = New Button()
        btn_gerenciar = New Button()
        btn_agendamento = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button3 = New Button()
        Label4 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(25), CByte(42), CByte(86))
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btn_novocad)
        Panel1.Controls.Add(btn_gerenciar)
        Panel1.Controls.Add(btn_agendamento)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(262, 706)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(262, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(656, 56)
        Panel2.TabIndex = 1
        ' 
        ' btn_novocad
        ' 
        btn_novocad.FlatAppearance.BorderSize = 0
        btn_novocad.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        btn_novocad.FlatStyle = FlatStyle.Flat
        btn_novocad.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_novocad.ForeColor = SystemColors.ButtonHighlight
        btn_novocad.Image = CType(resources.GetObject("btn_novocad.Image"), Image)
        btn_novocad.ImageAlign = ContentAlignment.MiddleLeft
        btn_novocad.Location = New Point(3, 176)
        btn_novocad.Name = "btn_novocad"
        btn_novocad.Size = New Size(256, 43)
        btn_novocad.TabIndex = 6
        btn_novocad.Text = "NOVO CADASTRO"
        btn_novocad.UseVisualStyleBackColor = True
        ' 
        ' btn_gerenciar
        ' 
        btn_gerenciar.FlatAppearance.BorderSize = 0
        btn_gerenciar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        btn_gerenciar.FlatStyle = FlatStyle.Flat
        btn_gerenciar.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_gerenciar.ForeColor = SystemColors.ButtonHighlight
        btn_gerenciar.Image = CType(resources.GetObject("btn_gerenciar.Image"), Image)
        btn_gerenciar.ImageAlign = ContentAlignment.MiddleLeft
        btn_gerenciar.Location = New Point(3, 127)
        btn_gerenciar.Name = "btn_gerenciar"
        btn_gerenciar.Size = New Size(256, 43)
        btn_gerenciar.TabIndex = 5
        btn_gerenciar.Text = "       GERENCIAR CLIENTES"
        btn_gerenciar.UseVisualStyleBackColor = True
        ' 
        ' btn_agendamento
        ' 
        btn_agendamento.FlatAppearance.BorderSize = 0
        btn_agendamento.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        btn_agendamento.FlatStyle = FlatStyle.Flat
        btn_agendamento.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_agendamento.ForeColor = SystemColors.ButtonHighlight
        btn_agendamento.Image = CType(resources.GetObject("btn_agendamento.Image"), Image)
        btn_agendamento.ImageAlign = ContentAlignment.MiddleLeft
        btn_agendamento.Location = New Point(3, 78)
        btn_agendamento.Name = "btn_agendamento"
        btn_agendamento.Size = New Size(253, 43)
        btn_agendamento.TabIndex = 4
        btn_agendamento.Text = "AGENDAMENTO"
        btn_agendamento.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(61, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 20)
        Label1.TabIndex = 7
        Label1.Text = "ADMINISTRAÇÃO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(94, 222)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 20)
        Label2.TabIndex = 8
        Label2.Text = "ESTOQUE"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(51, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 34)
        Label3.TabIndex = 5
        Label3.Text = "OnlyTattos"
        ' 
        ' Button3
        ' 
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(3, 253)
        Button3.Name = "Button3"
        Button3.Size = New Size(259, 43)
        Button3.TabIndex = 9
        Button3.Text = "     CADASTRO PRODUTO"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(79, 405)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 20)
        Label4.TabIndex = 12
        Label4.Text = "ORÇAMENTO"
        ' 
        ' adm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(918, 706)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "adm"
        Text = "adm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_novocad As Button
    Friend WithEvents btn_gerenciar As Button
    Friend WithEvents btn_agendamento As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
