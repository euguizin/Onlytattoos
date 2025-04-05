<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class secretaria
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(secretaria))
        Panel1 = New Panel()
        Label1 = New Label()
        btn_novocad = New Button()
        btn_gerenciar = New Button()
        btn_agendamento = New Button()
        Panel2 = New Panel()
        backpanel = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(25), CByte(42), CByte(86))
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btn_novocad)
        Panel1.Controls.Add(btn_gerenciar)
        Panel1.Controls.Add(btn_agendamento)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(262, 559)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(49, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 34)
        Label1.TabIndex = 4
        Label1.Text = "OnlyTattos"
        ' 
        ' btn_novocad
        ' 
        btn_novocad.Cursor = Cursors.Hand
        btn_novocad.FlatAppearance.BorderSize = 0
        btn_novocad.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        btn_novocad.FlatStyle = FlatStyle.Flat
        btn_novocad.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_novocad.ForeColor = SystemColors.ButtonHighlight
        btn_novocad.Image = CType(resources.GetObject("btn_novocad.Image"), Image)
        btn_novocad.ImageAlign = ContentAlignment.MiddleLeft
        btn_novocad.Location = New Point(3, 275)
        btn_novocad.Name = "btn_novocad"
        btn_novocad.Size = New Size(259, 43)
        btn_novocad.TabIndex = 3
        btn_novocad.Text = "NOVO CADASTRO"
        btn_novocad.UseVisualStyleBackColor = True
        ' 
        ' btn_gerenciar
        ' 
        btn_gerenciar.Cursor = Cursors.Hand
        btn_gerenciar.FlatAppearance.BorderSize = 0
        btn_gerenciar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(39), CByte(60), CByte(117))
        btn_gerenciar.FlatStyle = FlatStyle.Flat
        btn_gerenciar.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_gerenciar.ForeColor = SystemColors.ButtonHighlight
        btn_gerenciar.Image = CType(resources.GetObject("btn_gerenciar.Image"), Image)
        btn_gerenciar.ImageAlign = ContentAlignment.MiddleLeft
        btn_gerenciar.Location = New Point(3, 217)
        btn_gerenciar.Name = "btn_gerenciar"
        btn_gerenciar.Size = New Size(259, 43)
        btn_gerenciar.TabIndex = 2
        btn_gerenciar.Text = "       GERENCIAR CLIENTES"
        btn_gerenciar.UseVisualStyleBackColor = True
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
        btn_agendamento.Location = New Point(3, 159)
        btn_agendamento.Name = "btn_agendamento"
        btn_agendamento.Size = New Size(259, 43)
        btn_agendamento.TabIndex = 0
        btn_agendamento.Text = "AGENDAMENTO"
        btn_agendamento.UseVisualStyleBackColor = True
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
        ' backpanel
        ' 
        backpanel.Dock = DockStyle.Fill
        backpanel.Location = New Point(262, 56)
        backpanel.Name = "backpanel"
        backpanel.Size = New Size(656, 503)
        backpanel.TabIndex = 2
        ' 
        ' secretaria
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(918, 559)
        Controls.Add(backpanel)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "secretaria"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_agendamento As Button
    Friend WithEvents btn_gerenciar As Button
    Friend WithEvents btn_novocad As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents backpanel As Panel

End Class
