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
        TextBox1 = New TextBox()
        Label3 = New Label()
        MaskedTextBox1 = New MaskedTextBox()
        Label4 = New Label()
        TextBox2 = New TextBox()
        Label5 = New Label()
        MaskedTextBox2 = New MaskedTextBox()
        Label6 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label7 = New Label()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox8 = New CheckBox()
        CheckBox9 = New CheckBox()
        CheckBox10 = New CheckBox()
        CheckBox11 = New CheckBox()
        CheckBox12 = New CheckBox()
        CheckBox13 = New CheckBox()
        CheckBox14 = New CheckBox()
        CheckBox15 = New CheckBox()
        CheckBox16 = New CheckBox()
        CheckBox17 = New CheckBox()
        CheckBox18 = New CheckBox()
        CheckBox19 = New CheckBox()
        CheckBox20 = New CheckBox()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlText
        Panel1.Location = New Point(146, 65)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1, 1)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(146, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(364, 34)
        Label1.TabIndex = 1
        Label1.Text = "CADASTRO DE CLIENTES"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 20)
        Label2.TabIndex = 2
        Label2.Text = "Nome: "
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(79, 79)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(247, 27)
        TextBox1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(349, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 20)
        Label3.TabIndex = 4
        Label3.Text = "CPF:"
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Location = New Point(391, 80)
        MaskedTextBox1.Mask = "000,000,000-00"
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(114, 27)
        MaskedTextBox1.TabIndex = 5
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
        ' TextBox2
        ' 
        TextBox2.Location = New Point(79, 118)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(279, 27)
        TextBox2.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(364, 121)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 20)
        Label5.TabIndex = 8
        Label5.Text = "Telefone:"
        ' 
        ' MaskedTextBox2
        ' 
        MaskedTextBox2.Location = New Point(444, 118)
        MaskedTextBox2.Mask = "(99) 00000-0000"
        MaskedTextBox2.Name = "MaskedTextBox2"
        MaskedTextBox2.Size = New Size(121, 27)
        MaskedTextBox2.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(19, 154)
        Label6.Name = "Label6"
        Label6.Size = New Size(152, 20)
        Label6.TabIndex = 10
        Label6.Text = "Data de Nascimento: "
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(174, 154)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(292, 27)
        DateTimePicker1.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(146, 203)
        Label7.Name = "Label7"
        Label7.Size = New Size(317, 34)
        Label7.TabIndex = 12
        Label7.Text = "FICHA DE ANAMNESE"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(23, 266)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(222, 24)
        CheckBox1.TabIndex = 13
        CheckBox1.Text = "Está em tratamento médico?"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(23, 446)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(182, 24)
        CheckBox2.TabIndex = 14
        CheckBox2.Text = "Historico de quelóide?"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(23, 416)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(185, 24)
        CheckBox3.TabIndex = 15
        CheckBox3.Text = "Faz/Fez uso de drogas?"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(23, 386)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(137, 24)
        CheckBox4.TabIndex = 16
        CheckBox4.Text = "Amamentando?"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(23, 356)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(96, 24)
        CheckBox5.TabIndex = 17
        CheckBox5.Text = "Gestante?"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(23, 326)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(182, 24)
        CheckBox6.TabIndex = 18
        CheckBox6.Text = "Possui alguma alergia?"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(23, 296)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(197, 24)
        CheckBox7.TabIndex = 19
        CheckBox7.Text = "Alguma cirurgia recente?"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(251, 296)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(224, 24)
        CheckBox8.TabIndex = 26
        CheckBox8.Text = "Doenças infectocontagiosas?"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox9
        ' 
        CheckBox9.AutoSize = True
        CheckBox9.Location = New Point(251, 326)
        CheckBox9.Name = "CheckBox9"
        CheckBox9.Size = New Size(184, 24)
        CheckBox9.TabIndex = 25
        CheckBox9.Text = "Tem hipo/hipertensão?"
        CheckBox9.UseVisualStyleBackColor = True
        ' 
        ' CheckBox10
        ' 
        CheckBox10.AutoSize = True
        CheckBox10.Location = New Point(251, 356)
        CheckBox10.Name = "CheckBox10"
        CheckBox10.Size = New Size(212, 24)
        CheckBox10.TabIndex = 24
        CheckBox10.Text = "Problemas de cicatrização?"
        CheckBox10.UseVisualStyleBackColor = True
        ' 
        ' CheckBox11
        ' 
        CheckBox11.AutoSize = True
        CheckBox11.Location = New Point(251, 386)
        CheckBox11.Name = "CheckBox11"
        CheckBox11.Size = New Size(183, 24)
        CheckBox11.TabIndex = 23
        CheckBox11.Text = "Alimentou-se em 24H?"
        CheckBox11.UseVisualStyleBackColor = True
        ' 
        ' CheckBox12
        ' 
        CheckBox12.AutoSize = True
        CheckBox12.Location = New Point(251, 416)
        CheckBox12.Name = "CheckBox12"
        CheckBox12.Size = New Size(199, 24)
        CheckBox12.TabIndex = 22
        CheckBox12.Text = "Portador de marcapasso?"
        CheckBox12.UseVisualStyleBackColor = True
        ' 
        ' CheckBox13
        ' 
        CheckBox13.AutoSize = True
        CheckBox13.Location = New Point(251, 446)
        CheckBox13.Name = "CheckBox13"
        CheckBox13.Size = New Size(178, 24)
        CheckBox13.TabIndex = 21
        CheckBox13.Text = "Distúrbio circulatorio?"
        CheckBox13.UseVisualStyleBackColor = True
        ' 
        ' CheckBox14
        ' 
        CheckBox14.AutoSize = True
        CheckBox14.Location = New Point(251, 266)
        CheckBox14.Name = "CheckBox14"
        CheckBox14.Size = New Size(195, 24)
        CheckBox14.TabIndex = 20
        CheckBox14.Text = "Histórico de convulsões?"
        CheckBox14.UseVisualStyleBackColor = True
        ' 
        ' CheckBox15
        ' 
        CheckBox15.AutoSize = True
        CheckBox15.Location = New Point(479, 296)
        CheckBox15.Name = "CheckBox15"
        CheckBox15.Size = New Size(104, 24)
        CheckBox15.TabIndex = 33
        CheckBox15.Text = "Hemofilia?"
        CheckBox15.UseVisualStyleBackColor = True
        ' 
        ' CheckBox16
        ' 
        CheckBox16.AutoSize = True
        CheckBox16.Location = New Point(479, 326)
        CheckBox16.Name = "CheckBox16"
        CheckBox16.Size = New Size(116, 24)
        CheckBox16.TabIndex = 32
        CheckBox16.Text = "Cardiopatia?"
        CheckBox16.UseVisualStyleBackColor = True
        ' 
        ' CheckBox17
        ' 
        CheckBox17.AutoSize = True
        CheckBox17.Location = New Point(479, 356)
        CheckBox17.Name = "CheckBox17"
        CheckBox17.Size = New Size(89, 24)
        CheckBox17.TabIndex = 31
        CheckBox17.Text = "Anemia?"
        CheckBox17.UseVisualStyleBackColor = True
        ' 
        ' CheckBox18
        ' 
        CheckBox18.AutoSize = True
        CheckBox18.Location = New Point(479, 386)
        CheckBox18.Name = "CheckBox18"
        CheckBox18.Size = New Size(86, 24)
        CheckBox18.TabIndex = 30
        CheckBox18.Text = "Vitiligo?"
        CheckBox18.UseVisualStyleBackColor = True
        ' 
        ' CheckBox19
        ' 
        CheckBox19.AutoSize = True
        CheckBox19.Location = New Point(479, 416)
        CheckBox19.Name = "CheckBox19"
        CheckBox19.Size = New Size(97, 24)
        CheckBox19.TabIndex = 29
        CheckBox19.Text = "Diabetes?"
        CheckBox19.UseVisualStyleBackColor = True
        ' 
        ' CheckBox20
        ' 
        CheckBox20.AutoSize = True
        CheckBox20.Location = New Point(479, 266)
        CheckBox20.Name = "CheckBox20"
        CheckBox20.Size = New Size(96, 24)
        CheckBox20.TabIndex = 27
        CheckBox20.Text = "Hepatite?"
        CheckBox20.UseVisualStyleBackColor = True
        ' 
        ' cadastrocliente
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(824, 503)
        Controls.Add(CheckBox15)
        Controls.Add(CheckBox16)
        Controls.Add(CheckBox17)
        Controls.Add(CheckBox18)
        Controls.Add(CheckBox19)
        Controls.Add(CheckBox20)
        Controls.Add(CheckBox8)
        Controls.Add(CheckBox9)
        Controls.Add(CheckBox10)
        Controls.Add(CheckBox11)
        Controls.Add(CheckBox12)
        Controls.Add(CheckBox13)
        Controls.Add(CheckBox14)
        Controls.Add(CheckBox7)
        Controls.Add(CheckBox6)
        Controls.Add(CheckBox5)
        Controls.Add(CheckBox4)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(Label7)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label6)
        Controls.Add(MaskedTextBox2)
        Controls.Add(Label5)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(MaskedTextBox1)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "cadastrocliente"
        Text = "cadastrocliente"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents CheckBox13 As CheckBox
    Friend WithEvents CheckBox14 As CheckBox
    Friend WithEvents CheckBox15 As CheckBox
    Friend WithEvents CheckBox16 As CheckBox
    Friend WithEvents CheckBox17 As CheckBox
    Friend WithEvents CheckBox18 As CheckBox
    Friend WithEvents CheckBox19 As CheckBox
    Friend WithEvents CheckBox20 As CheckBox
End Class
