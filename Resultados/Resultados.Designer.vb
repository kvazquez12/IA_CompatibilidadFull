<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resultados
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
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.btn_Minimizar = New System.Windows.Forms.Button()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.lblPersona1 = New System.Windows.Forms.Label()
        Me.pnlBotones = New System.Windows.Forms.Panel()
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblPersona2 = New System.Windows.Forms.Label()
        Me.lblCompatibilidad = New System.Windows.Forms.Label()
        Me.lblPorcentaje = New System.Windows.Forms.Label()
        Me.cbxPersona1 = New System.Windows.Forms.ComboBox()
        Me.cbxPersona2 = New System.Windows.Forms.ComboBox()
        Me.btnComparar = New System.Windows.Forms.Button()
        Me.pnlTitulo.SuspendLayout()
        Me.pnlBotones.SuspendLayout()
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
        Me.pnlTitulo.Size = New System.Drawing.Size(670, 37)
        Me.pnlTitulo.TabIndex = 7
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Franklin Gothic Heavy", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 5)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(258, 30)
        Me.lblTitulo.TabIndex = 23
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
        Me.btn_Salir.Location = New System.Drawing.Point(645, 5)
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
        Me.btn_Minimizar.Location = New System.Drawing.Point(613, 5)
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
        Me.btnRestaurar.Location = New System.Drawing.Point(613, 5)
        Me.btnRestaurar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(28, 26)
        Me.btnRestaurar.TabIndex = 3
        Me.btnRestaurar.UseVisualStyleBackColor = True
        '
        'lblPersona1
        '
        Me.lblPersona1.AutoSize = True
        Me.lblPersona1.BackColor = System.Drawing.Color.Transparent
        Me.lblPersona1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersona1.Location = New System.Drawing.Point(113, 71)
        Me.lblPersona1.Name = "lblPersona1"
        Me.lblPersona1.Size = New System.Drawing.Size(110, 26)
        Me.lblPersona1.TabIndex = 22
        Me.lblPersona1.Text = "Persona 1"
        '
        'pnlBotones
        '
        Me.pnlBotones.Controls.Add(Me.btnRegistro)
        Me.pnlBotones.Controls.Add(Me.btnSalir)
        Me.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBotones.Location = New System.Drawing.Point(0, 269)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(670, 43)
        Me.pnlBotones.TabIndex = 30
        '
        'btnRegistro
        '
        Me.btnRegistro.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.btnRegistro.Location = New System.Drawing.Point(12, 8)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(108, 32)
        Me.btnRegistro.TabIndex = 21
        Me.btnRegistro.Text = "Regresar"
        Me.btnRegistro.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.btnSalir.Location = New System.Drawing.Point(571, 8)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 32)
        Me.btnSalir.TabIndex = 20
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblPersona2
        '
        Me.lblPersona2.AutoSize = True
        Me.lblPersona2.BackColor = System.Drawing.Color.Transparent
        Me.lblPersona2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersona2.Location = New System.Drawing.Point(425, 71)
        Me.lblPersona2.Name = "lblPersona2"
        Me.lblPersona2.Size = New System.Drawing.Size(110, 26)
        Me.lblPersona2.TabIndex = 31
        Me.lblPersona2.Text = "Persona 2"
        '
        'lblCompatibilidad
        '
        Me.lblCompatibilidad.AutoSize = True
        Me.lblCompatibilidad.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.lblCompatibilidad.Location = New System.Drawing.Point(101, 219)
        Me.lblCompatibilidad.Name = "lblCompatibilidad"
        Me.lblCompatibilidad.Size = New System.Drawing.Size(434, 24)
        Me.lblCompatibilidad.TabIndex = 33
        Me.lblCompatibilidad.Text = "Estas personas cuentan con una compatibilidad de: "
        '
        'lblPorcentaje
        '
        Me.lblPorcentaje.AutoSize = True
        Me.lblPorcentaje.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.lblPorcentaje.Location = New System.Drawing.Point(243, 243)
        Me.lblPorcentaje.Name = "lblPorcentaje"
        Me.lblPorcentaje.Size = New System.Drawing.Size(20, 24)
        Me.lblPorcentaje.TabIndex = 34
        Me.lblPorcentaje.Text = "?"
        '
        'cbxPersona1
        '
        Me.cbxPersona1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        Me.cbxPersona1.FormattingEnabled = True
        Me.cbxPersona1.Location = New System.Drawing.Point(56, 100)
        Me.cbxPersona1.Name = "cbxPersona1"
        Me.cbxPersona1.Size = New System.Drawing.Size(232, 29)
        Me.cbxPersona1.TabIndex = 35
        '
        'cbxPersona2
        '
        Me.cbxPersona2.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPersona2.FormattingEnabled = True
        Me.cbxPersona2.Location = New System.Drawing.Point(361, 100)
        Me.cbxPersona2.Name = "cbxPersona2"
        Me.cbxPersona2.Size = New System.Drawing.Size(232, 29)
        Me.cbxPersona2.TabIndex = 36
        '
        'btnComparar
        '
        Me.btnComparar.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.btnComparar.Location = New System.Drawing.Point(247, 156)
        Me.btnComparar.Name = "btnComparar"
        Me.btnComparar.Size = New System.Drawing.Size(156, 47)
        Me.btnComparar.TabIndex = 22
        Me.btnComparar.Text = "Comparar"
        Me.btnComparar.UseVisualStyleBackColor = True
        '
        'Resultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 312)
        Me.Controls.Add(Me.btnComparar)
        Me.Controls.Add(Me.cbxPersona2)
        Me.Controls.Add(Me.cbxPersona1)
        Me.Controls.Add(Me.lblPorcentaje)
        Me.Controls.Add(Me.lblCompatibilidad)
        Me.Controls.Add(Me.lblPersona2)
        Me.Controls.Add(Me.pnlBotones)
        Me.Controls.Add(Me.lblPersona1)
        Me.Controls.Add(Me.pnlTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Resultados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resultados"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        Me.pnlBotones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents btn_Salir As Button
    Friend WithEvents btn_Minimizar As Button
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents lblPersona1 As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pnlBotones As Panel
    Friend WithEvents btnRegistro As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblPersona2 As Label
    Friend WithEvents lblCompatibilidad As Label
    Friend WithEvents lblPorcentaje As Label
    Friend WithEvents cbxPersona1 As ComboBox
    Friend WithEvents cbxPersona2 As ComboBox
    Friend WithEvents btnComparar As Button
End Class
