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
        panel_esq = New Panel()
        Button1 = New Button()
        Label1 = New Label()
        btn_novocad = New Button()
        btn_gerenciar = New Button()
        btn_agendamento = New Button()
        Panel2 = New Panel()
        backpanel = New Panel()
        panel_esq.SuspendLayout()
        SuspendLayout()
        ' 
        ' panel_esq
        ' 
        panel_esq.BackColor = Color.FromArgb(CByte(25), CByte(42), CByte(86))
        panel_esq.Controls.Add(Button1)
        panel_esq.Controls.Add(Label1)
        panel_esq.Controls.Add(btn_novocad)
        panel_esq.Controls.Add(btn_gerenciar)
        panel_esq.Controls.Add(btn_agendamento)
        panel_esq.Dock = DockStyle.Left
        panel_esq.Location = New Point(0, 0)
        panel_esq.Name = "panel_esq"
        panel_esq.Size = New Size(262, 635)
        panel_esq.TabIndex = 0
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
        Button1.Location = New Point(0, 576)
        Button1.Name = "Button1"
        Button1.Size = New Size(256, 43)
        Button1.TabIndex = 11
        Button1.Text = "SAIR "
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(49, 51)
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
        Panel2.Size = New Size(1124, 56)
        Panel2.TabIndex = 1
        ' 
        ' backpanel
        ' 
        backpanel.Dock = DockStyle.Fill
        backpanel.Location = New Point(262, 56)
        backpanel.Name = "backpanel"
        backpanel.Size = New Size(1124, 579)
        backpanel.TabIndex = 2
        ' 
        ' secretaria
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1386, 635)
        Controls.Add(backpanel)
        Controls.Add(Panel2)
        Controls.Add(panel_esq)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "secretaria"
        Text = "Form1"
        panel_esq.ResumeLayout(False)
        panel_esq.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panel_esq As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_agendamento As Button
    Friend WithEvents btn_gerenciar As Button
    Friend WithEvents btn_novocad As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents backpanel As Panel
    Friend WithEvents Button1 As Button

End Class
