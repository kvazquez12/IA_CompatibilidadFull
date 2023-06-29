<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnComprobar = New System.Windows.Forms.Button()
        Me.lblInstrucciones = New System.Windows.Forms.Label()
        Me.lblBienvenida = New System.Windows.Forms.Label()
        Me.pnlTitulo.SuspendLayout()
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
        Me.pnlTitulo.Size = New System.Drawing.Size(487, 37)
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
        Me.btn_Salir.Location = New System.Drawing.Point(462, 5)
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
        Me.btn_Minimizar.Location = New System.Drawing.Point(430, 5)
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
        Me.btnRestaurar.Location = New System.Drawing.Point(430, 5)
        Me.btnRestaurar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(28, 26)
        Me.btnRestaurar.TabIndex = 3
        Me.btnRestaurar.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.btnRegistrar.Location = New System.Drawing.Point(68, 142)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(135, 57)
        Me.btnRegistrar.TabIndex = 21
        Me.btnRegistrar.Text = "Registrar nuevo usuario"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnComprobar
        '
        Me.btnComprobar.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.btnComprobar.Location = New System.Drawing.Point(275, 142)
        Me.btnComprobar.Name = "btnComprobar"
        Me.btnComprobar.Size = New System.Drawing.Size(135, 57)
        Me.btnComprobar.TabIndex = 22
        Me.btnComprobar.Text = "Hacer prueba de compatibilidad"
        Me.btnComprobar.UseVisualStyleBackColor = True
        '
        'lblInstrucciones
        '
        Me.lblInstrucciones.AutoSize = True
        Me.lblInstrucciones.BackColor = System.Drawing.Color.Transparent
        Me.lblInstrucciones.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstrucciones.Location = New System.Drawing.Point(12, 99)
        Me.lblInstrucciones.Name = "lblInstrucciones"
        Me.lblInstrucciones.Size = New System.Drawing.Size(290, 24)
        Me.lblInstrucciones.TabIndex = 23
        Me.lblInstrucciones.Text = "¿Qué quieres hacer el día de hoy? "
        Me.lblInstrucciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBienvenida
        '
        Me.lblBienvenida.AutoSize = True
        Me.lblBienvenida.BackColor = System.Drawing.Color.Transparent
        Me.lblBienvenida.Font = New System.Drawing.Font("Franklin Gothic Heavy", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenida.Location = New System.Drawing.Point(148, 47)
        Me.lblBienvenida.Name = "lblBienvenida"
        Me.lblBienvenida.Size = New System.Drawing.Size(188, 37)
        Me.lblBienvenida.TabIndex = 24
        Me.lblBienvenida.Text = "Bienvenido"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 245)
        Me.Controls.Add(Me.lblBienvenida)
        Me.Controls.Add(Me.lblInstrucciones)
        Me.Controls.Add(Me.btnComprobar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.pnlTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btn_Salir As Button
    Friend WithEvents btn_Minimizar As Button
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnComprobar As Button
    Friend WithEvents lblInstrucciones As Label
    Friend WithEvents lblBienvenida As Label
End Class
