<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicial
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicial))
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.btn_Minimizar = New System.Windows.Forms.Button()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblPerfil = New System.Windows.Forms.Label()
        Me.gpbEdad = New System.Windows.Forms.GroupBox()
        Me.rb3 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.rb4 = New System.Windows.Forms.RadioButton()
        Me.rb5 = New System.Windows.Forms.RadioButton()
        Me.rb6 = New System.Windows.Forms.RadioButton()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.lblPersonalidad = New System.Windows.Forms.Label()
        Me.rbIntro = New System.Windows.Forms.RadioButton()
        Me.rbExtro = New System.Windows.Forms.RadioButton()
        Me.lblCreencias = New System.Windows.Forms.Label()
        Me.rbCreye = New System.Windows.Forms.RadioButton()
        Me.rbAgno = New System.Windows.Forms.RadioButton()
        Me.rbAteo = New System.Windows.Forms.RadioButton()
        Me.pnlBotones = New System.Windows.Forms.Panel()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnSig = New System.Windows.Forms.Button()
        Me.lblBienvenida = New System.Windows.Forms.Label()
        Me.lblInstrucciones = New System.Windows.Forms.Label()
        Me.pnlPersonalidad = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlTitulo.SuspendLayout()
        Me.gpbEdad.SuspendLayout()
        Me.pnlBotones.SuspendLayout()
        Me.pnlPersonalidad.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.Transparent
        Me.pnlTitulo.Controls.Add(Me.btn_Salir)
        Me.pnlTitulo.Controls.Add(Me.btn_Minimizar)
        Me.pnlTitulo.Controls.Add(Me.btnRestaurar)
        Me.pnlTitulo.Controls.Add(Me.lblTitulo)
        Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(724, 37)
        Me.pnlTitulo.TabIndex = 5
        '
        'btn_Salir
        '
        Me.btn_Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Salir.BackgroundImage = Global.IA_Proyecto.My.Resources.Resources.Cerrar
        Me.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Salir.FlatAppearance.BorderSize = 0
        Me.btn_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.btn_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Salir.ForeColor = System.Drawing.Color.Transparent
        Me.btn_Salir.Location = New System.Drawing.Point(699, 5)
        Me.btn_Salir.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(23, 26)
        Me.btn_Salir.TabIndex = 0
        Me.btn_Salir.UseVisualStyleBackColor = True
        '
        'btn_Minimizar
        '
        Me.btn_Minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Minimizar.BackgroundImage = Global.IA_Proyecto.My.Resources.Resources.Minimizar
        Me.btn_Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Minimizar.FlatAppearance.BorderSize = 0
        Me.btn_Minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Minimizar.Location = New System.Drawing.Point(667, 5)
        Me.btn_Minimizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Minimizar.Name = "btn_Minimizar"
        Me.btn_Minimizar.Size = New System.Drawing.Size(28, 26)
        Me.btn_Minimizar.TabIndex = 1
        Me.btn_Minimizar.UseVisualStyleBackColor = True
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Location = New System.Drawing.Point(667, 5)
        Me.btnRestaurar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(28, 26)
        Me.btnRestaurar.TabIndex = 3
        Me.btnRestaurar.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Franklin Gothic Heavy", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 5)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(237, 30)
        Me.lblTitulo.TabIndex = 8
        Me.lblTitulo.Text = "Registro de Usuario"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(79, 248)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(99, 26)
        Me.lblNombre.TabIndex = 6
        Me.lblNombre.Text = "Nombre: "
        '
        'lblPerfil
        '
        Me.lblPerfil.AutoSize = True
        Me.lblPerfil.BackColor = System.Drawing.Color.Transparent
        Me.lblPerfil.Font = New System.Drawing.Font("Franklin Gothic Heavy", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerfil.Location = New System.Drawing.Point(12, 201)
        Me.lblPerfil.Name = "lblPerfil"
        Me.lblPerfil.Size = New System.Drawing.Size(201, 30)
        Me.lblPerfil.TabIndex = 9
        Me.lblPerfil.Text = "Perfil de Usuario"
        '
        'gpbEdad
        '
        Me.gpbEdad.Controls.Add(Me.rb3)
        Me.gpbEdad.Controls.Add(Me.rb2)
        Me.gpbEdad.Controls.Add(Me.rb4)
        Me.gpbEdad.Controls.Add(Me.rb5)
        Me.gpbEdad.Controls.Add(Me.rb6)
        Me.gpbEdad.Controls.Add(Me.rb1)
        Me.gpbEdad.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!)
        Me.gpbEdad.Location = New System.Drawing.Point(17, 362)
        Me.gpbEdad.Name = "gpbEdad"
        Me.gpbEdad.Size = New System.Drawing.Size(207, 163)
        Me.gpbEdad.TabIndex = 10
        Me.gpbEdad.TabStop = False
        Me.gpbEdad.Text = "Edad: "
        '
        'rb3
        '
        Me.rb3.AutoSize = True
        Me.rb3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb3.Location = New System.Drawing.Point(6, 129)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(82, 28)
        Me.rb3.TabIndex = 5
        Me.rb3.TabStop = True
        Me.rb3.Text = "19 - 21"
        Me.rb3.UseVisualStyleBackColor = True
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb2.Location = New System.Drawing.Point(6, 85)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(82, 28)
        Me.rb2.TabIndex = 4
        Me.rb2.TabStop = True
        Me.rb2.Text = "16 - 18"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'rb4
        '
        Me.rb4.AutoSize = True
        Me.rb4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb4.Location = New System.Drawing.Point(98, 39)
        Me.rb4.Name = "rb4"
        Me.rb4.Size = New System.Drawing.Size(82, 28)
        Me.rb4.TabIndex = 3
        Me.rb4.TabStop = True
        Me.rb4.Text = "22 - 24"
        Me.rb4.UseVisualStyleBackColor = True
        '
        'rb5
        '
        Me.rb5.AutoSize = True
        Me.rb5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb5.Location = New System.Drawing.Point(98, 85)
        Me.rb5.Name = "rb5"
        Me.rb5.Size = New System.Drawing.Size(82, 28)
        Me.rb5.TabIndex = 2
        Me.rb5.TabStop = True
        Me.rb5.Text = "25 - 27"
        Me.rb5.UseVisualStyleBackColor = True
        '
        'rb6
        '
        Me.rb6.AutoSize = True
        Me.rb6.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb6.Location = New System.Drawing.Point(98, 129)
        Me.rb6.Name = "rb6"
        Me.rb6.Size = New System.Drawing.Size(82, 28)
        Me.rb6.TabIndex = 1
        Me.rb6.TabStop = True
        Me.rb6.Text = "27 - 30"
        Me.rb6.UseVisualStyleBackColor = True
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb1.Location = New System.Drawing.Point(6, 39)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(82, 28)
        Me.rb1.TabIndex = 0
        Me.rb1.TabStop = True
        Me.rb1.Text = "12 - 15"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(198, 248)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(436, 29)
        Me.txtNombre.TabIndex = 8
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.BackColor = System.Drawing.Color.Transparent
        Me.lblSexo.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(105, 299)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(67, 26)
        Me.lblSexo.TabIndex = 11
        Me.lblSexo.Text = "Sexo:"
        '
        'cmbSexo
        '
        Me.cmbSexo.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Items.AddRange(New Object() {"Masculino", "Femenino", "No binario ", "Otro"})
        Me.cmbSexo.Location = New System.Drawing.Point(198, 299)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(145, 32)
        Me.cmbSexo.TabIndex = 12
        '
        'lblPersonalidad
        '
        Me.lblPersonalidad.AutoSize = True
        Me.lblPersonalidad.BackColor = System.Drawing.Color.Transparent
        Me.lblPersonalidad.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonalidad.Location = New System.Drawing.Point(3, 16)
        Me.lblPersonalidad.Name = "lblPersonalidad"
        Me.lblPersonalidad.Size = New System.Drawing.Size(147, 26)
        Me.lblPersonalidad.TabIndex = 13
        Me.lblPersonalidad.Text = "Personalidad:"
        '
        'rbIntro
        '
        Me.rbIntro.AutoSize = True
        Me.rbIntro.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbIntro.Location = New System.Drawing.Point(272, 16)
        Me.rbIntro.Name = "rbIntro"
        Me.rbIntro.Size = New System.Drawing.Size(108, 28)
        Me.rbIntro.TabIndex = 6
        Me.rbIntro.TabStop = True
        Me.rbIntro.Text = "Introvertido"
        Me.rbIntro.UseVisualStyleBackColor = True
        '
        'rbExtro
        '
        Me.rbExtro.AutoSize = True
        Me.rbExtro.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbExtro.Location = New System.Drawing.Point(156, 16)
        Me.rbExtro.Name = "rbExtro"
        Me.rbExtro.Size = New System.Drawing.Size(110, 28)
        Me.rbExtro.TabIndex = 14
        Me.rbExtro.TabStop = True
        Me.rbExtro.Text = "Extrovertido"
        Me.rbExtro.UseVisualStyleBackColor = True
        '
        'lblCreencias
        '
        Me.lblCreencias.AutoSize = True
        Me.lblCreencias.BackColor = System.Drawing.Color.Transparent
        Me.lblCreencias.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreencias.Location = New System.Drawing.Point(3, 15)
        Me.lblCreencias.Name = "lblCreencias"
        Me.lblCreencias.Size = New System.Drawing.Size(115, 26)
        Me.lblCreencias.TabIndex = 15
        Me.lblCreencias.Text = "Creencias:"
        '
        'rbCreye
        '
        Me.rbCreye.AutoSize = True
        Me.rbCreye.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCreye.Location = New System.Drawing.Point(124, 15)
        Me.rbCreye.Name = "rbCreye"
        Me.rbCreye.Size = New System.Drawing.Size(88, 28)
        Me.rbCreye.TabIndex = 16
        Me.rbCreye.TabStop = True
        Me.rbCreye.Text = "Creyente"
        Me.rbCreye.UseVisualStyleBackColor = True
        '
        'rbAgno
        '
        Me.rbAgno.AutoSize = True
        Me.rbAgno.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAgno.Location = New System.Drawing.Point(218, 15)
        Me.rbAgno.Name = "rbAgno"
        Me.rbAgno.Size = New System.Drawing.Size(96, 28)
        Me.rbAgno.TabIndex = 17
        Me.rbAgno.TabStop = True
        Me.rbAgno.Text = "Agnóstico"
        Me.rbAgno.UseVisualStyleBackColor = True
        '
        'rbAteo
        '
        Me.rbAteo.AutoSize = True
        Me.rbAteo.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAteo.Location = New System.Drawing.Point(320, 15)
        Me.rbAteo.Name = "rbAteo"
        Me.rbAteo.Size = New System.Drawing.Size(59, 28)
        Me.rbAteo.TabIndex = 18
        Me.rbAteo.TabStop = True
        Me.rbAteo.Text = "Ateo"
        Me.rbAteo.UseVisualStyleBackColor = True
        '
        'pnlBotones
        '
        Me.pnlBotones.Controls.Add(Me.btnRegresar)
        Me.pnlBotones.Controls.Add(Me.btnSig)
        Me.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBotones.Location = New System.Drawing.Point(0, 542)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(724, 43)
        Me.pnlBotones.TabIndex = 19
        '
        'btnRegresar
        '
        Me.btnRegresar.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.btnRegresar.Location = New System.Drawing.Point(10, 6)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(95, 32)
        Me.btnRegresar.TabIndex = 21
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnSig
        '
        Me.btnSig.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.btnSig.Location = New System.Drawing.Point(622, 6)
        Me.btnSig.Name = "btnSig"
        Me.btnSig.Size = New System.Drawing.Size(96, 32)
        Me.btnSig.TabIndex = 20
        Me.btnSig.Text = "Siguiente"
        Me.btnSig.UseVisualStyleBackColor = True
        '
        'lblBienvenida
        '
        Me.lblBienvenida.AutoSize = True
        Me.lblBienvenida.BackColor = System.Drawing.Color.Transparent
        Me.lblBienvenida.Font = New System.Drawing.Font("Franklin Gothic Heavy", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenida.Location = New System.Drawing.Point(255, 49)
        Me.lblBienvenida.Name = "lblBienvenida"
        Me.lblBienvenida.Size = New System.Drawing.Size(188, 37)
        Me.lblBienvenida.TabIndex = 9
        Me.lblBienvenida.Text = "Bienvenido"
        '
        'lblInstrucciones
        '
        Me.lblInstrucciones.AutoSize = True
        Me.lblInstrucciones.BackColor = System.Drawing.Color.Transparent
        Me.lblInstrucciones.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstrucciones.Location = New System.Drawing.Point(-3, 95)
        Me.lblInstrucciones.Name = "lblInstrucciones"
        Me.lblInstrucciones.Size = New System.Drawing.Size(727, 96)
        Me.lblInstrucciones.TabIndex = 20
        Me.lblInstrucciones.Text = resources.GetString("lblInstrucciones.Text")
        Me.lblInstrucciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlPersonalidad
        '
        Me.pnlPersonalidad.Controls.Add(Me.lblPersonalidad)
        Me.pnlPersonalidad.Controls.Add(Me.rbExtro)
        Me.pnlPersonalidad.Controls.Add(Me.rbIntro)
        Me.pnlPersonalidad.Location = New System.Drawing.Point(270, 371)
        Me.pnlPersonalidad.Name = "pnlPersonalidad"
        Me.pnlPersonalidad.Size = New System.Drawing.Size(385, 58)
        Me.pnlPersonalidad.TabIndex = 21
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblCreencias)
        Me.Panel1.Controls.Add(Me.rbCreye)
        Me.Panel1.Controls.Add(Me.rbAgno)
        Me.Panel1.Controls.Add(Me.rbAteo)
        Me.Panel1.Location = New System.Drawing.Point(270, 457)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(396, 53)
        Me.Panel1.TabIndex = 22
        '
        'frmInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 585)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlPersonalidad)
        Me.Controls.Add(Me.lblInstrucciones)
        Me.Controls.Add(Me.lblBienvenida)
        Me.Controls.Add(Me.pnlBotones)
        Me.Controls.Add(Me.cmbSexo)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.gpbEdad)
        Me.Controls.Add(Me.lblPerfil)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.pnlTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        Me.gpbEdad.ResumeLayout(False)
        Me.gpbEdad.PerformLayout()
        Me.pnlBotones.ResumeLayout(False)
        Me.pnlPersonalidad.ResumeLayout(False)
        Me.pnlPersonalidad.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents btn_Salir As Button
    Friend WithEvents btn_Minimizar As Button
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblPerfil As Label
    Friend WithEvents gpbEdad As GroupBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblSexo As Label
    Friend WithEvents cmbSexo As ComboBox
    Friend WithEvents lblPersonalidad As Label
    Friend WithEvents rbIntro As RadioButton
    Friend WithEvents rbExtro As RadioButton
    Friend WithEvents lblCreencias As Label
    Friend WithEvents rbCreye As RadioButton
    Friend WithEvents rbAgno As RadioButton
    Friend WithEvents rbAteo As RadioButton
    Friend WithEvents pnlBotones As Panel
    Friend WithEvents btnSig As Button
    Friend WithEvents lblBienvenida As Label
    Friend WithEvents lblInstrucciones As Label
    Friend WithEvents pnlPersonalidad As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rb3 As RadioButton
    Friend WithEvents rb2 As RadioButton
    Friend WithEvents rb4 As RadioButton
    Friend WithEvents rb5 As RadioButton
    Friend WithEvents rb6 As RadioButton
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents btnRegresar As Button
End Class
