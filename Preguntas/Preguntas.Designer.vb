<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Preguntas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.btn_Minimizar = New System.Windows.Forms.Button()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.pnlBotones = New System.Windows.Forms.Panel()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.lblDeporte = New System.Windows.Forms.Label()
        Me.trbDeporte = New System.Windows.Forms.TrackBar()
        Me.gpbGustoV = New System.Windows.Forms.GroupBox()
        Me.rbV4 = New System.Windows.Forms.RadioButton()
        Me.rbV3 = New System.Windows.Forms.RadioButton()
        Me.rbV2 = New System.Windows.Forms.RadioButton()
        Me.rbV1 = New System.Windows.Forms.RadioButton()
        Me.gpbFavV = New System.Windows.Forms.GroupBox()
        Me.rbVF5 = New System.Windows.Forms.RadioButton()
        Me.rbVF4 = New System.Windows.Forms.RadioButton()
        Me.rbVF3 = New System.Windows.Forms.RadioButton()
        Me.rbVF2 = New System.Windows.Forms.RadioButton()
        Me.rbVF1 = New System.Windows.Forms.RadioButton()
        Me.gpbCine = New System.Windows.Forms.GroupBox()
        Me.rbC4 = New System.Windows.Forms.RadioButton()
        Me.rbC3 = New System.Windows.Forms.RadioButton()
        Me.rbC2 = New System.Windows.Forms.RadioButton()
        Me.rbC1 = New System.Windows.Forms.RadioButton()
        Me.lblMascotas = New System.Windows.Forms.Label()
        Me.cmbMascotas = New System.Windows.Forms.ComboBox()
        Me.lblMusica = New System.Windows.Forms.Label()
        Me.cmbMusica = New System.Windows.Forms.ComboBox()
        Me.gpbLectura = New System.Windows.Forms.GroupBox()
        Me.rbLec4 = New System.Windows.Forms.RadioButton()
        Me.rbLec3 = New System.Windows.Forms.RadioButton()
        Me.rbLec2 = New System.Windows.Forms.RadioButton()
        Me.rbLec1 = New System.Windows.Forms.RadioButton()
        Me.lblSueno = New System.Windows.Forms.Label()
        Me.lblPaz = New System.Windows.Forms.Label()
        Me.gpbEstacion = New System.Windows.Forms.GroupBox()
        Me.rbInvierno = New System.Windows.Forms.RadioButton()
        Me.rbOtono = New System.Windows.Forms.RadioButton()
        Me.rbVerano = New System.Windows.Forms.RadioButton()
        Me.rbPrimavera = New System.Windows.Forms.RadioButton()
        Me.cmbSueno = New System.Windows.Forms.ComboBox()
        Me.cmbPaz = New System.Windows.Forms.ComboBox()
        Me.lblEnfoque = New System.Windows.Forms.Label()
        Me.cmbEnfoque = New System.Windows.Forms.ComboBox()
        Me.lblBajo = New System.Windows.Forms.Label()
        Me.lblMucho = New System.Windows.Forms.Label()
        Me.pnlTitulo.SuspendLayout()
        Me.pnlBotones.SuspendLayout()
        CType(Me.trbDeporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbGustoV.SuspendLayout()
        Me.gpbFavV.SuspendLayout()
        Me.gpbCine.SuspendLayout()
        Me.gpbLectura.SuspendLayout()
        Me.gpbEstacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.Transparent
        Me.pnlTitulo.Controls.Add(Me.lblTitulo)
        Me.pnlTitulo.Controls.Add(Me.btn_Salir)
        Me.pnlTitulo.Controls.Add(Me.btn_Minimizar)
        Me.pnlTitulo.Controls.Add(Me.btnRestaurar)
        Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(767, 37)
        Me.pnlTitulo.TabIndex = 6
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Franklin Gothic Heavy", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 5)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(258, 30)
        Me.lblTitulo.TabIndex = 34
        Me.lblTitulo.Text = "Búsqueda de Amistad"
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
        Me.btn_Salir.Location = New System.Drawing.Point(742, 5)
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
        Me.btn_Minimizar.Location = New System.Drawing.Point(710, 5)
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
        Me.btnRestaurar.Location = New System.Drawing.Point(710, 5)
        Me.btnRestaurar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(28, 26)
        Me.btnRestaurar.TabIndex = 3
        Me.btnRestaurar.UseVisualStyleBackColor = True
        '
        'pnlBotones
        '
        Me.pnlBotones.Controls.Add(Me.btnAnterior)
        Me.pnlBotones.Controls.Add(Me.btnReg)
        Me.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBotones.Location = New System.Drawing.Point(0, 663)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(767, 43)
        Me.pnlBotones.TabIndex = 20
        '
        'btnAnterior
        '
        Me.btnAnterior.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.btnAnterior.Location = New System.Drawing.Point(12, 8)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(96, 32)
        Me.btnAnterior.TabIndex = 21
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnReg
        '
        Me.btnReg.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.btnReg.Location = New System.Drawing.Point(659, 8)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(96, 32)
        Me.btnReg.TabIndex = 20
        Me.btnReg.Text = "Registrar"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'lblDeporte
        '
        Me.lblDeporte.AutoSize = True
        Me.lblDeporte.BackColor = System.Drawing.Color.Transparent
        Me.lblDeporte.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeporte.Location = New System.Drawing.Point(7, 79)
        Me.lblDeporte.Name = "lblDeporte"
        Me.lblDeporte.Size = New System.Drawing.Size(209, 26)
        Me.lblDeporte.TabIndex = 21
        Me.lblDeporte.Text = "Actividad Deportiva:"
        '
        'trbDeporte
        '
        Me.trbDeporte.Location = New System.Drawing.Point(222, 79)
        Me.trbDeporte.Maximum = 3
        Me.trbDeporte.Name = "trbDeporte"
        Me.trbDeporte.Size = New System.Drawing.Size(120, 45)
        Me.trbDeporte.TabIndex = 22
        '
        'gpbGustoV
        '
        Me.gpbGustoV.Controls.Add(Me.rbV4)
        Me.gpbGustoV.Controls.Add(Me.rbV3)
        Me.gpbGustoV.Controls.Add(Me.rbV2)
        Me.gpbGustoV.Controls.Add(Me.rbV1)
        Me.gpbGustoV.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbGustoV.Location = New System.Drawing.Point(36, 172)
        Me.gpbGustoV.Name = "gpbGustoV"
        Me.gpbGustoV.Size = New System.Drawing.Size(274, 125)
        Me.gpbGustoV.TabIndex = 24
        Me.gpbGustoV.TabStop = False
        Me.gpbGustoV.Text = "Gusto por los videojuegos:"
        '
        'rbV4
        '
        Me.rbV4.AutoSize = True
        Me.rbV4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbV4.Location = New System.Drawing.Point(139, 74)
        Me.rbV4.Name = "rbV4"
        Me.rbV4.Size = New System.Drawing.Size(55, 28)
        Me.rbV4.TabIndex = 4
        Me.rbV4.TabStop = True
        Me.rbV4.Text = "Alta"
        Me.rbV4.UseVisualStyleBackColor = True
        '
        'rbV3
        '
        Me.rbV3.AutoSize = True
        Me.rbV3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbV3.Location = New System.Drawing.Point(139, 40)
        Me.rbV3.Name = "rbV3"
        Me.rbV3.Size = New System.Drawing.Size(100, 28)
        Me.rbV3.TabIndex = 3
        Me.rbV3.TabStop = True
        Me.rbV3.Text = "Moderado"
        Me.rbV3.UseVisualStyleBackColor = True
        '
        'rbV2
        '
        Me.rbV2.AutoSize = True
        Me.rbV2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbV2.Location = New System.Drawing.Point(27, 74)
        Me.rbV2.Name = "rbV2"
        Me.rbV2.Size = New System.Drawing.Size(59, 28)
        Me.rbV2.TabIndex = 2
        Me.rbV2.TabStop = True
        Me.rbV2.Text = "Leve"
        Me.rbV2.UseVisualStyleBackColor = True
        '
        'rbV1
        '
        Me.rbV1.AutoSize = True
        Me.rbV1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbV1.Location = New System.Drawing.Point(27, 40)
        Me.rbV1.Name = "rbV1"
        Me.rbV1.Size = New System.Drawing.Size(61, 28)
        Me.rbV1.TabIndex = 1
        Me.rbV1.TabStop = True
        Me.rbV1.Text = "Nulo"
        Me.rbV1.UseVisualStyleBackColor = True
        '
        'gpbFavV
        '
        Me.gpbFavV.Controls.Add(Me.rbVF5)
        Me.gpbFavV.Controls.Add(Me.rbVF4)
        Me.gpbFavV.Controls.Add(Me.rbVF3)
        Me.gpbFavV.Controls.Add(Me.rbVF2)
        Me.gpbFavV.Controls.Add(Me.rbVF1)
        Me.gpbFavV.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbFavV.Location = New System.Drawing.Point(373, 172)
        Me.gpbFavV.Name = "gpbFavV"
        Me.gpbFavV.Size = New System.Drawing.Size(328, 125)
        Me.gpbFavV.TabIndex = 25
        Me.gpbFavV.TabStop = False
        Me.gpbFavV.Text = "Videojuegos favoritos:"
        '
        'rbVF5
        '
        Me.rbVF5.AutoSize = True
        Me.rbVF5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVF5.Location = New System.Drawing.Point(230, 40)
        Me.rbVF5.Name = "rbVF5"
        Me.rbVF5.Size = New System.Drawing.Size(58, 28)
        Me.rbVF5.TabIndex = 5
        Me.rbVF5.TabStop = True
        Me.rbVF5.Text = "Otro"
        Me.rbVF5.UseVisualStyleBackColor = True
        '
        'rbVF4
        '
        Me.rbVF4.AutoSize = True
        Me.rbVF4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVF4.Location = New System.Drawing.Point(103, 74)
        Me.rbVF4.Name = "rbVF4"
        Me.rbVF4.Size = New System.Drawing.Size(107, 28)
        Me.rbVF4.TabIndex = 4
        Me.rbVF4.TabStop = True
        Me.rbVF4.Text = "Simulación"
        Me.rbVF4.UseVisualStyleBackColor = True
        '
        'rbVF3
        '
        Me.rbVF3.AutoSize = True
        Me.rbVF3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVF3.Location = New System.Drawing.Point(103, 40)
        Me.rbVF3.Name = "rbVF3"
        Me.rbVF3.Size = New System.Drawing.Size(97, 28)
        Me.rbVF3.TabIndex = 3
        Me.rbVF3.TabStop = True
        Me.rbVF3.Text = "Estrategia"
        Me.rbVF3.UseVisualStyleBackColor = True
        '
        'rbVF2
        '
        Me.rbVF2.AutoSize = True
        Me.rbVF2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVF2.Location = New System.Drawing.Point(6, 74)
        Me.rbVF2.Name = "rbVF2"
        Me.rbVF2.Size = New System.Drawing.Size(67, 28)
        Me.rbVF2.TabIndex = 2
        Me.rbVF2.TabStop = True
        Me.rbVF2.Text = "Terror"
        Me.rbVF2.UseVisualStyleBackColor = True
        '
        'rbVF1
        '
        Me.rbVF1.AutoSize = True
        Me.rbVF1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVF1.Location = New System.Drawing.Point(6, 40)
        Me.rbVF1.Name = "rbVF1"
        Me.rbVF1.Size = New System.Drawing.Size(75, 28)
        Me.rbVF1.TabIndex = 1
        Me.rbVF1.TabStop = True
        Me.rbVF1.Text = "Acción"
        Me.rbVF1.UseVisualStyleBackColor = True
        '
        'gpbCine
        '
        Me.gpbCine.Controls.Add(Me.rbC4)
        Me.gpbCine.Controls.Add(Me.rbC3)
        Me.gpbCine.Controls.Add(Me.rbC2)
        Me.gpbCine.Controls.Add(Me.rbC1)
        Me.gpbCine.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbCine.Location = New System.Drawing.Point(36, 326)
        Me.gpbCine.Name = "gpbCine"
        Me.gpbCine.Size = New System.Drawing.Size(274, 125)
        Me.gpbCine.TabIndex = 25
        Me.gpbCine.TabStop = False
        Me.gpbCine.Text = "Gusto por el cine: "
        '
        'rbC4
        '
        Me.rbC4.AutoSize = True
        Me.rbC4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbC4.Location = New System.Drawing.Point(139, 74)
        Me.rbC4.Name = "rbC4"
        Me.rbC4.Size = New System.Drawing.Size(55, 28)
        Me.rbC4.TabIndex = 4
        Me.rbC4.TabStop = True
        Me.rbC4.Text = "Alta"
        Me.rbC4.UseVisualStyleBackColor = True
        '
        'rbC3
        '
        Me.rbC3.AutoSize = True
        Me.rbC3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbC3.Location = New System.Drawing.Point(139, 40)
        Me.rbC3.Name = "rbC3"
        Me.rbC3.Size = New System.Drawing.Size(100, 28)
        Me.rbC3.TabIndex = 3
        Me.rbC3.TabStop = True
        Me.rbC3.Text = "Moderado"
        Me.rbC3.UseVisualStyleBackColor = True
        '
        'rbC2
        '
        Me.rbC2.AutoSize = True
        Me.rbC2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbC2.Location = New System.Drawing.Point(27, 74)
        Me.rbC2.Name = "rbC2"
        Me.rbC2.Size = New System.Drawing.Size(59, 28)
        Me.rbC2.TabIndex = 2
        Me.rbC2.TabStop = True
        Me.rbC2.Text = "Leve"
        Me.rbC2.UseVisualStyleBackColor = True
        '
        'rbC1
        '
        Me.rbC1.AutoSize = True
        Me.rbC1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbC1.Location = New System.Drawing.Point(27, 40)
        Me.rbC1.Name = "rbC1"
        Me.rbC1.Size = New System.Drawing.Size(61, 28)
        Me.rbC1.TabIndex = 1
        Me.rbC1.TabStop = True
        Me.rbC1.Text = "Nulo"
        Me.rbC1.UseVisualStyleBackColor = True
        '
        'lblMascotas
        '
        Me.lblMascotas.AutoSize = True
        Me.lblMascotas.BackColor = System.Drawing.Color.Transparent
        Me.lblMascotas.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMascotas.Location = New System.Drawing.Point(332, 557)
        Me.lblMascotas.Name = "lblMascotas"
        Me.lblMascotas.Size = New System.Drawing.Size(251, 26)
        Me.lblMascotas.TabIndex = 26
        Me.lblMascotas.Text = "Gusto por las mascotas: "
        '
        'cmbMascotas
        '
        Me.cmbMascotas.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.cmbMascotas.FormattingEnabled = True
        Me.cmbMascotas.Items.AddRange(New Object() {"Gatos", "Perros", "Aves", "Roedores", "Peces ", "Reptiles"})
        Me.cmbMascotas.Location = New System.Drawing.Point(583, 556)
        Me.cmbMascotas.Name = "cmbMascotas"
        Me.cmbMascotas.Size = New System.Drawing.Size(155, 32)
        Me.cmbMascotas.TabIndex = 27
        '
        'lblMusica
        '
        Me.lblMusica.AutoSize = True
        Me.lblMusica.BackColor = System.Drawing.Color.Transparent
        Me.lblMusica.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMusica.Location = New System.Drawing.Point(358, 498)
        Me.lblMusica.Name = "lblMusica"
        Me.lblMusica.Size = New System.Drawing.Size(215, 26)
        Me.lblMusica.TabIndex = 28
        Me.lblMusica.Text = "Gusto por la música: "
        '
        'cmbMusica
        '
        Me.cmbMusica.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.cmbMusica.FormattingEnabled = True
        Me.cmbMusica.Items.AddRange(New Object() {"Pop", "Rock", "Indie", "K-Pop", "Clasica", "Otro"})
        Me.cmbMusica.Location = New System.Drawing.Point(583, 497)
        Me.cmbMusica.Name = "cmbMusica"
        Me.cmbMusica.Size = New System.Drawing.Size(155, 32)
        Me.cmbMusica.TabIndex = 29
        '
        'gpbLectura
        '
        Me.gpbLectura.Controls.Add(Me.rbLec4)
        Me.gpbLectura.Controls.Add(Me.rbLec3)
        Me.gpbLectura.Controls.Add(Me.rbLec2)
        Me.gpbLectura.Controls.Add(Me.rbLec1)
        Me.gpbLectura.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbLectura.Location = New System.Drawing.Point(397, 326)
        Me.gpbLectura.Name = "gpbLectura"
        Me.gpbLectura.Size = New System.Drawing.Size(274, 125)
        Me.gpbLectura.TabIndex = 26
        Me.gpbLectura.TabStop = False
        Me.gpbLectura.Text = "Gusto por leer:"
        '
        'rbLec4
        '
        Me.rbLec4.AutoSize = True
        Me.rbLec4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLec4.Location = New System.Drawing.Point(139, 74)
        Me.rbLec4.Name = "rbLec4"
        Me.rbLec4.Size = New System.Drawing.Size(55, 28)
        Me.rbLec4.TabIndex = 4
        Me.rbLec4.TabStop = True
        Me.rbLec4.Text = "Alta"
        Me.rbLec4.UseVisualStyleBackColor = True
        '
        'rbLec3
        '
        Me.rbLec3.AutoSize = True
        Me.rbLec3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLec3.Location = New System.Drawing.Point(139, 40)
        Me.rbLec3.Name = "rbLec3"
        Me.rbLec3.Size = New System.Drawing.Size(100, 28)
        Me.rbLec3.TabIndex = 3
        Me.rbLec3.TabStop = True
        Me.rbLec3.Text = "Moderado"
        Me.rbLec3.UseVisualStyleBackColor = True
        '
        'rbLec2
        '
        Me.rbLec2.AutoSize = True
        Me.rbLec2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLec2.Location = New System.Drawing.Point(27, 74)
        Me.rbLec2.Name = "rbLec2"
        Me.rbLec2.Size = New System.Drawing.Size(59, 28)
        Me.rbLec2.TabIndex = 2
        Me.rbLec2.TabStop = True
        Me.rbLec2.Text = "Leve"
        Me.rbLec2.UseVisualStyleBackColor = True
        '
        'rbLec1
        '
        Me.rbLec1.AutoSize = True
        Me.rbLec1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLec1.Location = New System.Drawing.Point(25, 40)
        Me.rbLec1.Name = "rbLec1"
        Me.rbLec1.Size = New System.Drawing.Size(61, 28)
        Me.rbLec1.TabIndex = 1
        Me.rbLec1.TabStop = True
        Me.rbLec1.Text = "Nulo"
        Me.rbLec1.UseVisualStyleBackColor = True
        '
        'lblSueno
        '
        Me.lblSueno.AutoSize = True
        Me.lblSueno.BackColor = System.Drawing.Color.Transparent
        Me.lblSueno.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSueno.Location = New System.Drawing.Point(361, 64)
        Me.lblSueno.Name = "lblSueno"
        Me.lblSueno.Size = New System.Drawing.Size(186, 26)
        Me.lblSueno.TabIndex = 30
        Me.lblSueno.Text = "Hábitos de sueño:"
        '
        'lblPaz
        '
        Me.lblPaz.AutoSize = True
        Me.lblPaz.BackColor = System.Drawing.Color.Transparent
        Me.lblPaz.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaz.Location = New System.Drawing.Point(417, 111)
        Me.lblPaz.Name = "lblPaz"
        Me.lblPaz.Size = New System.Drawing.Size(137, 26)
        Me.lblPaz.TabIndex = 31
        Me.lblPaz.Text = "Paz Interior: "
        '
        'gpbEstacion
        '
        Me.gpbEstacion.Controls.Add(Me.rbInvierno)
        Me.gpbEstacion.Controls.Add(Me.rbOtono)
        Me.gpbEstacion.Controls.Add(Me.rbVerano)
        Me.gpbEstacion.Controls.Add(Me.rbPrimavera)
        Me.gpbEstacion.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbEstacion.Location = New System.Drawing.Point(36, 483)
        Me.gpbEstacion.Name = "gpbEstacion"
        Me.gpbEstacion.Size = New System.Drawing.Size(274, 125)
        Me.gpbEstacion.TabIndex = 26
        Me.gpbEstacion.TabStop = False
        Me.gpbEstacion.Text = "Estación del año preferida: "
        '
        'rbInvierno
        '
        Me.rbInvierno.AutoSize = True
        Me.rbInvierno.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbInvierno.Location = New System.Drawing.Point(139, 74)
        Me.rbInvierno.Name = "rbInvierno"
        Me.rbInvierno.Size = New System.Drawing.Size(84, 28)
        Me.rbInvierno.TabIndex = 4
        Me.rbInvierno.TabStop = True
        Me.rbInvierno.Text = "Invierno"
        Me.rbInvierno.UseVisualStyleBackColor = True
        '
        'rbOtono
        '
        Me.rbOtono.AutoSize = True
        Me.rbOtono.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbOtono.Location = New System.Drawing.Point(139, 40)
        Me.rbOtono.Name = "rbOtono"
        Me.rbOtono.Size = New System.Drawing.Size(71, 28)
        Me.rbOtono.TabIndex = 3
        Me.rbOtono.TabStop = True
        Me.rbOtono.Text = "Otoño"
        Me.rbOtono.UseVisualStyleBackColor = True
        '
        'rbVerano
        '
        Me.rbVerano.AutoSize = True
        Me.rbVerano.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVerano.Location = New System.Drawing.Point(27, 74)
        Me.rbVerano.Name = "rbVerano"
        Me.rbVerano.Size = New System.Drawing.Size(77, 28)
        Me.rbVerano.TabIndex = 2
        Me.rbVerano.TabStop = True
        Me.rbVerano.Text = "Verano"
        Me.rbVerano.UseVisualStyleBackColor = True
        '
        'rbPrimavera
        '
        Me.rbPrimavera.AutoSize = True
        Me.rbPrimavera.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPrimavera.Location = New System.Drawing.Point(27, 40)
        Me.rbPrimavera.Name = "rbPrimavera"
        Me.rbPrimavera.Size = New System.Drawing.Size(97, 28)
        Me.rbPrimavera.TabIndex = 1
        Me.rbPrimavera.TabStop = True
        Me.rbPrimavera.Text = "Primavera"
        Me.rbPrimavera.UseVisualStyleBackColor = True
        '
        'cmbSueno
        '
        Me.cmbSueno.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSueno.FormattingEnabled = True
        Me.cmbSueno.Items.AddRange(New Object() {"Regulares", "Invertidos (vivir de noche)", "Irregulares"})
        Me.cmbSueno.Location = New System.Drawing.Point(560, 63)
        Me.cmbSueno.Name = "cmbSueno"
        Me.cmbSueno.Size = New System.Drawing.Size(195, 29)
        Me.cmbSueno.TabIndex = 32
        '
        'cmbPaz
        '
        Me.cmbPaz.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPaz.FormattingEnabled = True
        Me.cmbPaz.Items.AddRange(New Object() {"Tranquilo", "Ansioso", "Reactivo"})
        Me.cmbPaz.Location = New System.Drawing.Point(560, 110)
        Me.cmbPaz.Name = "cmbPaz"
        Me.cmbPaz.Size = New System.Drawing.Size(195, 29)
        Me.cmbPaz.TabIndex = 33
        '
        'lblEnfoque
        '
        Me.lblEnfoque.AutoSize = True
        Me.lblEnfoque.BackColor = System.Drawing.Color.Transparent
        Me.lblEnfoque.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnfoque.Location = New System.Drawing.Point(302, 611)
        Me.lblEnfoque.Name = "lblEnfoque"
        Me.lblEnfoque.Size = New System.Drawing.Size(278, 26)
        Me.lblEnfoque.TabIndex = 34
        Me.lblEnfoque.Text = "Enfoque personal principal:"
        '
        'cmbEnfoque
        '
        Me.cmbEnfoque.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.cmbEnfoque.FormattingEnabled = True
        Me.cmbEnfoque.Items.AddRange(New Object() {"Familiar", "Trabajo/Escuela", "Amigos", "Pareja", "Individual"})
        Me.cmbEnfoque.Location = New System.Drawing.Point(583, 610)
        Me.cmbEnfoque.Name = "cmbEnfoque"
        Me.cmbEnfoque.Size = New System.Drawing.Size(155, 32)
        Me.cmbEnfoque.TabIndex = 35
        '
        'lblBajo
        '
        Me.lblBajo.AutoSize = True
        Me.lblBajo.BackColor = System.Drawing.Color.Transparent
        Me.lblBajo.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBajo.Location = New System.Drawing.Point(219, 110)
        Me.lblBajo.Name = "lblBajo"
        Me.lblBajo.Size = New System.Drawing.Size(36, 17)
        Me.lblBajo.TabIndex = 36
        Me.lblBajo.Text = "Poco"
        Me.lblBajo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMucho
        '
        Me.lblMucho.AutoSize = True
        Me.lblMucho.BackColor = System.Drawing.Color.Transparent
        Me.lblMucho.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMucho.Location = New System.Drawing.Point(304, 110)
        Me.lblMucho.Name = "lblMucho"
        Me.lblMucho.Size = New System.Drawing.Size(45, 17)
        Me.lblMucho.TabIndex = 37
        Me.lblMucho.Text = "Mucho"
        Me.lblMucho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Preguntas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 706)
        Me.Controls.Add(Me.lblMucho)
        Me.Controls.Add(Me.lblBajo)
        Me.Controls.Add(Me.cmbEnfoque)
        Me.Controls.Add(Me.lblEnfoque)
        Me.Controls.Add(Me.cmbPaz)
        Me.Controls.Add(Me.cmbSueno)
        Me.Controls.Add(Me.gpbEstacion)
        Me.Controls.Add(Me.lblPaz)
        Me.Controls.Add(Me.lblSueno)
        Me.Controls.Add(Me.gpbLectura)
        Me.Controls.Add(Me.cmbMusica)
        Me.Controls.Add(Me.lblMusica)
        Me.Controls.Add(Me.cmbMascotas)
        Me.Controls.Add(Me.lblMascotas)
        Me.Controls.Add(Me.gpbCine)
        Me.Controls.Add(Me.gpbFavV)
        Me.Controls.Add(Me.gpbGustoV)
        Me.Controls.Add(Me.trbDeporte)
        Me.Controls.Add(Me.lblDeporte)
        Me.Controls.Add(Me.pnlBotones)
        Me.Controls.Add(Me.pnlTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Preguntas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preguntas"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        Me.pnlBotones.ResumeLayout(False)
        CType(Me.trbDeporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbGustoV.ResumeLayout(False)
        Me.gpbGustoV.PerformLayout()
        Me.gpbFavV.ResumeLayout(False)
        Me.gpbFavV.PerformLayout()
        Me.gpbCine.ResumeLayout(False)
        Me.gpbCine.PerformLayout()
        Me.gpbLectura.ResumeLayout(False)
        Me.gpbLectura.PerformLayout()
        Me.gpbEstacion.ResumeLayout(False)
        Me.gpbEstacion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents btn_Salir As Button
    Friend WithEvents btn_Minimizar As Button
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents pnlBotones As Panel
    Friend WithEvents btnReg As Button
    Friend WithEvents lblDeporte As Label
    Friend WithEvents trbDeporte As TrackBar
    Friend WithEvents gpbGustoV As GroupBox
    Friend WithEvents rbV4 As RadioButton
    Friend WithEvents rbV3 As RadioButton
    Friend WithEvents rbV2 As RadioButton
    Friend WithEvents rbV1 As RadioButton
    Friend WithEvents gpbFavV As GroupBox
    Friend WithEvents rbVF5 As RadioButton
    Friend WithEvents rbVF4 As RadioButton
    Friend WithEvents rbVF3 As RadioButton
    Friend WithEvents rbVF2 As RadioButton
    Friend WithEvents rbVF1 As RadioButton
    Friend WithEvents gpbCine As GroupBox
    Friend WithEvents rbC4 As RadioButton
    Friend WithEvents rbC3 As RadioButton
    Friend WithEvents rbC2 As RadioButton
    Friend WithEvents rbC1 As RadioButton
    Friend WithEvents lblMascotas As Label
    Friend WithEvents cmbMascotas As ComboBox
    Friend WithEvents lblMusica As Label
    Friend WithEvents cmbMusica As ComboBox
    Friend WithEvents gpbLectura As GroupBox
    Friend WithEvents rbLec4 As RadioButton
    Friend WithEvents rbLec3 As RadioButton
    Friend WithEvents rbLec2 As RadioButton
    Friend WithEvents rbLec1 As RadioButton
    Friend WithEvents btnAnterior As Button
    Friend WithEvents lblSueno As Label
    Friend WithEvents lblPaz As Label
    Friend WithEvents gpbEstacion As GroupBox
    Friend WithEvents rbInvierno As RadioButton
    Friend WithEvents rbOtono As RadioButton
    Friend WithEvents rbVerano As RadioButton
    Friend WithEvents rbPrimavera As RadioButton
    Friend WithEvents cmbSueno As ComboBox
    Friend WithEvents cmbPaz As ComboBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblEnfoque As Label
    Friend WithEvents cmbEnfoque As ComboBox
    Friend WithEvents lblBajo As Label
    Friend WithEvents lblMucho As Label
End Class
