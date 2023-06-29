
Imports System.Runtime.InteropServices
Imports System.Data
Imports System.Data.OleDb
Public Class Resultados
    Private Sub Resultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(254, 250, 224)
        pnlTitulo.BackColor = Color.FromArgb(204, 213, 174)
        pnlBotones.BackColor = Color.FromArgb(204, 213, 174)
        btnSalir.BackColor = Color.FromArgb(250, 237, 205)
        btnRegistro.BackColor = Color.FromArgb(250, 237, 205)
        btnComparar.BackColor = Color.FromArgb(250, 237, 205)
        Cargar_Usuario1()
        Cargar_Usuario2()
        cbxPersona1.Text = "Selecciona una persona"
        cbxPersona2.Text = "Selecciona una persona"

    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.Exit()
    End Sub

    Private Sub btn_Minimizar_Click(sender As Object, e As EventArgs) Handles btn_Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub Cargar_Usuario1()


        Try
            '' Obtiene informacion de la columna
            Dim Tabla As New DataTable
            '' Consulta SQL para pedir la columna Nombre de la tabla usuarios
            Dim Consulta_Sql As String = "SELECT Nombre FROM Usuarios"
            '' Variable adaptador que realiza en enlace entre la consulta/Conexion
            Dim Adaptador As New OleDbDataAdapter(Consulta_Sql, Conexion)
            ''Llena la informacion que encontro la variable Tabla
            Adaptador.Fill(Tabla)
            '' Llena el combobox con la variable tabla(Todos los datos enctontrados)
            cbxPersona1.DataSource = Tabla

            '' Muestra la informacion solamente del campo Nombre del Combo Box
            cbxPersona1.DisplayMember = "Nombre"

        Catch ex As Exception
            MsgBox("Error de Operacion" & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Cargar_Usuario2()


        Try
            '' Obtiene informacion de la columna
            Dim Tabla As New DataTable
            '' Consulta SQL para pedir la columna Nombre de la tabla usuarios
            Dim Consulta_Sql As String = "SELECT Nombre FROM Usuarios"
            '' Variable adaptador que realiza en enlace entre la consulta/Conexion
            Dim Adaptador As New OleDbDataAdapter(Consulta_Sql, Conexion)
            ''Llena la informacion que encontro la variable Tabla
            Adaptador.Fill(Tabla)
            '' Llena el combobox con la variable tabla(Todos los datos enctontrados)
            cbxPersona2.DataSource = Tabla

            '' Muestra la informacion solamente del campo Nombre del Combo Box
            cbxPersona2.DisplayMember = "Nombre"

        Catch ex As Exception
            MsgBox("Error de Operacion" & ex.Message, MsgBoxStyle.Critical)
        End Try


    End Sub

    Public cmdPorcentaje As New OleDb.OleDbCommand
    Private Sub porcentaje()
        Dim valor1 As String
        Dim valor2 As String
        Dim total As Double

        Try
            cmdPorcentaje.Connection = Conexion

            '1. RangoEdad

            cmdPorcentaje = New OleDbCommand("SELECT RangoEdad FROM Usuarios WHERE Nombre = '" & cbxPersona1.Text & "'", Conexion)
            valor1 = cmdPorcentaje.ExecuteScalar
            cmdPorcentaje = New OleDbCommand("SELECT RangoEdad FROM Usuarios WHERE Nombre = '" & cbxPersona2.Text & "'", Conexion)
            valor2 = cmdPorcentaje.ExecuteScalar
            'Valor 1
            '12-15
            If valor1 = "12-15" And valor2 = "12-15" Then
                total = total + 1
            ElseIf valor1 = "12-15" And valor2 = "16-18" Then
                total = total + 0.8
            ElseIf valor1 = "12-15" And valor2 = "19-21" Then
                total = total + 0.6
            ElseIf valor1 = "12-15" And valor2 = "22-24" Then
                total = total + 0.4
            ElseIf valor1 = "12-15" And valor2 = "25-27" Then
                total = total + 0.2
            ElseIf valor1 = "12-15" And valor2 = "27-30" Then
                total = total + 0

                '16-18

            ElseIf valor1 = "16-18" And valor2 = "12-15" Then
                total = total + 0.8
            ElseIf valor1 = "16-18" And valor2 = "16-18" Then
                total = total + 1
            ElseIf valor1 = "16-18" And valor2 = "19-21" Then
                total = total + 0.8
            ElseIf valor1 = "16-18" And valor2 = "22-24" Then
                total = total + 0.6
            ElseIf valor1 = "16-18" And valor2 = "25-27" Then
                total = total + 0.4
            ElseIf valor1 = "16-18" And valor2 = "27-30" Then
                total = total + 0.2

                '19-21

            ElseIf valor1 = "19-21" And valor2 = "12-15" Then
                total = total + 0.6
            ElseIf valor1 = "19-21" And valor2 = "16-18" Then
                total = total + 0.8
            ElseIf valor1 = "19-21" And valor2 = "19-21" Then
                total = total + 1
            ElseIf valor1 = "19-21" And valor2 = "22-24" Then
                total = total + 0.8
            ElseIf valor1 = "19-21" And valor2 = "25-27" Then
                total = total + 0.6
            ElseIf valor1 = "19-21" And valor2 = "27-30" Then
                total = total + 0.4

                '22-24

            ElseIf valor1 = "22-24" And valor2 = "12-15" Then
                total = total + 0.4
            ElseIf valor1 = "22-24" And valor2 = "16-18" Then
                total = total + 0.6
            ElseIf valor1 = "22-24" And valor2 = "19-21" Then
                total = total + 0.8
            ElseIf valor1 = "22-24" And valor2 = "22-24" Then
                total = total + 1
            ElseIf valor1 = "22-24" And valor2 = "25-27" Then
                total = total + 0.8
            ElseIf valor1 = "22-24" And valor2 = "27-30" Then
                total = total + 0.6

                '25-27
            ElseIf valor1 = "25-27" And valor2 = "12-15" Then
                total = total + 0.2
            ElseIf valor1 = "25-27" And valor2 = "16-18" Then
                total = total + 0.4
            ElseIf valor1 = "25-27" And valor2 = "19-21" Then
                total = total + 0.6
            ElseIf valor1 = "25-27" And valor2 = "22-24" Then
                total = total + 0.8
            ElseIf valor1 = "25-27" And valor2 = "25-27" Then
                total = total + 1
            ElseIf valor1 = "25-27" And valor2 = "27-30" Then
                total = total + 0.8

                '27-30
            ElseIf valor1 = "27-30" And valor2 = "12-15" Then
                total = total + 0
            ElseIf valor1 = "27-30" And valor2 = "16-18" Then
                total = total + 0.2
            ElseIf valor1 = "27-30" And valor2 = "19-21" Then
                total = total + 0.4
            ElseIf valor1 = "27-30" And valor2 = "22-24" Then
                total = total + 0.6
            ElseIf valor1 = "27-30" And valor2 = "25-27" Then
                total = total + 0.8

            ElseIf valor1 = "27-30" And valor2 = "27-30" Then
                total = total + 1
            End If

            'VALOR 2
            '12-15
            If valor2 = "12-15" And valor1 = "12-15" Then
                total = total + 1
            ElseIf valor2 = "12-15" And valor1 = "16-18" Then
                total = total + 0.8
            ElseIf valor2 = "12-15" And valor1 = "19-21" Then
                total = total + 0.6
            ElseIf valor2 = "12-15" And valor1 = "22-24" Then
                total = total + 0.4
            ElseIf valor2 = "12-15" And valor1 = "25-27" Then
                total = total + 0.2
            ElseIf valor2 = "12-15" And valor1 = "27-30" Then
                total = total + 0

                '16-18
            ElseIf valor2 = "16-18" And valor1 = "12-15" Then
                total = total + 0.8
            ElseIf valor2 = "16-18" And valor1 = "16-18" Then
                total = total + 1
            ElseIf valor2 = "16-18" And valor1 = "19-21" Then
                total = total + 0.8
            ElseIf valor2 = "16-18" And valor1 = "22-24" Then
                total = total + 0.6
            ElseIf valor2 = "16-18" And valor1 = "25-27" Then
                total = total + 0.4
            ElseIf valor2 = "16-18" And valor1 = "27-30" Then
                total = total + 0.2

                '19-21
            ElseIf valor2 = "19-21" And valor1 = "12-15" Then
                total = total + 0.6
            ElseIf valor2 = "19-21" And valor1 = "16-18" Then
                total = total + 0.8
            ElseIf valor2 = "19-21" And valor1 = "19-21" Then
                total = total + 1
            ElseIf valor2 = "19-21" And valor1 = "22-24" Then
                total = total + 0.8
            ElseIf valor2 = "19-21" And valor1 = "25-27" Then
                total = total + 0.6
            ElseIf valor2 = "19-21" And valor1 = "27-30" Then
                total = total + 0.4

                '22-24
            ElseIf valor2 = "22-24" And valor1 = "12-15" Then
                total = total + 0.4
            ElseIf valor2 = "22-24" And valor1 = "16-18" Then
                total = total + 0.6
            ElseIf valor2 = "22-24" And valor1 = "19-21" Then
                total = total + 0.8
            ElseIf valor2 = "22-24" And valor1 = "22-24" Then
                total = total + 1
            ElseIf valor2 = "22-24" And valor1 = "25-27" Then
                total = total + 0.8
            ElseIf valor2 = "22-24" And valor1 = "27-30" Then
                total = total + 0.6

                '25-27
            ElseIf valor2 = "25-27" And valor1 = "12-15" Then
                total = total + 0.2
            ElseIf valor2 = "25-27" And valor1 = "16-18" Then
                total = total + 0.4
            ElseIf valor2 = "25-27" And valor1 = "19-21" Then
                total = total + 0.6
            ElseIf valor2 = "25-27" And valor1 = "22-24" Then
                total = total + 0.8
            ElseIf valor2 = "25-27" And valor1 = "25-27" Then
                total = total + 1
            ElseIf valor2 = "25-27" And valor1 = "27-30" Then
                total = total + 0.8

                '27-30
            ElseIf valor2 = "27-30" And valor1 = "12-15" Then
                total = total + 0
            ElseIf valor2 = "27-30" And valor1 = "16-18" Then
                total = total + 0.2
            ElseIf valor2 = "27-30" And valor1 = "19-21" Then
                total = total + 0.4
            ElseIf valor2 = "27-30" And valor1 = "22-24" Then
                total = total + 0.6
            ElseIf valor2 = "27-30" And valor1 = "25-27" Then
                total = total + 0.8
            ElseIf valor2 = "27-30" And valor1 = "27-30" Then
                total = total + 1
            End If

            If valor1 = valor2 Then
                total = total - 1
            End If




            '2.Personalidad
            cmdPorcentaje = New OleDbCommand("SELECT Personalidad FROM Usuarios WHERE Nombre = '" & cbxPersona1.Text & "'", Conexion)
            valor1 = cmdPorcentaje.ExecuteScalar
            cmdPorcentaje = New OleDbCommand("SELECT Personalidad FROM Usuarios WHERE Nombre = '" & cbxPersona2.Text & "'", Conexion)
            valor2 = cmdPorcentaje.ExecuteScalar
            'Valor 1
            If valor1 = "Introvertido" And valor2 = "Introvertido" Then
                total = total + 1
            ElseIf valor1 = "Introvertido" And valor2 = "Extrovertido" Then
                total = total + 0.5
            ElseIf valor1 = "Extrovertido" And valor2 = "Introvertido" Then
                total = total + 0.5
            ElseIf valor1 = "Extrovertido" And valor2 = "Extrovertido" Then
                total = total + 1
            End If

            'Valor 2
            If valor2 = "Introvertido" And valor1 = "Introvertido" Then
                total = total + 1
            ElseIf valor2 = "Introvertido" And valor1 = "Extrovertido" Then
                total = total + 0.5
            ElseIf valor2 = "Extrovertido" And valor1 = "Introvertido" Then
                total = total + 0.5
            ElseIf valor2 = "Extrovertido" And valor1 = "Extrovertido" Then
                total = total + 1
            End If

            If valor1 = valor2 Then
                total = total - 1
            End If

            '3.Actividad Deportiva
            cmdPorcentaje = New OleDbCommand("SELECT ActividadDeportiva FROM Usuarios WHERE Nombre = '" & cbxPersona1.Text & "'", Conexion)
            valor1 = cmdPorcentaje.ExecuteScalar
            cmdPorcentaje = New OleDbCommand("SELECT ActividadDeportiva FROM Usuarios WHERE Nombre = '" & cbxPersona2.Text & "'", Conexion)
            valor2 = cmdPorcentaje.ExecuteScalar
            'Valor 1
            'Nulo
            If valor1 = "Nulo" And valor2 = "Nulo" Then
                total = total + 1
            ElseIf valor1 = "Nulo" And valor2 = "Leve" Then
                total = total + 0.6
            ElseIf valor1 = "Nulo" And valor2 = "Moderado" Then
                total = total + 0.3
            ElseIf valor1 = "Nulo" And valor2 = "Alta" Then
                total = total + 0

                'Leve
            ElseIf valor1 = "Leve" And valor2 = "Nulo" Then
                total = total + 0.6
            ElseIf valor1 = "Leve" And valor2 = "Leve" Then
                total = total + 1
            ElseIf valor1 = "Leve" And valor2 = "Moderado" Then
                total = total + 0.6
            ElseIf valor1 = "Leve" And valor2 = "Alta" Then
                total = total + 0.3

                'Moderado
            ElseIf valor1 = "Moderado" And valor2 = "Nulo" Then
                total = total + 0.3
            ElseIf valor1 = "Moderado" And valor2 = "Leve" Then
                total = total + 0.6
            ElseIf valor1 = "Moderado" And valor2 = "Moderado" Then
                total = total + 1
            ElseIf valor1 = "Moderado" And valor2 = "Alta" Then
                total = total + 0.6

                'Alta
            ElseIf valor1 = "Alta" And valor2 = "Nulo" Then
                total = total + 0
            ElseIf valor1 = "Alta" And valor2 = "Leve" Then
                total = total + 0.3
            ElseIf valor1 = "Alta" And valor2 = "Moderado" Then
                total = total + 0.6
            ElseIf valor1 = "Alta" And valor2 = "Alta" Then
                total = total + 1

            End If

            'Valor 2
            'Nulo
            If valor2 = "Nulo" And valor1 = "Nulo" Then
                total = total + 1
            ElseIf valor2 = "Nulo" And valor1 = "Leve" Then
                total = total + 0.6
            ElseIf valor2 = "Nulo" And valor1 = "Moderado" Then
                total = total + 0.3
            ElseIf valor2 = "Nulo" And valor1 = "Alta" Then
                total = total + 0

                'Leve
            ElseIf valor2 = "Leve" And valor1 = "Nulo" Then
                total = total + 0.6
            ElseIf valor2 = "Leve" And valor1 = "Leve" Then
                total = total + 1
            ElseIf valor2 = "Leve" And valor1 = "Moderado" Then
                total = total + 0.6
            ElseIf valor2 = "Leve" And valor1 = "Alta" Then
                total = total + 0.3

                'Moderado
            ElseIf valor2 = "Moderado" And valor1 = "Nulo" Then
                total = total + 0.3
            ElseIf valor2 = "Moderado" And valor1 = "Leve" Then
                total = total + 0.6
            ElseIf valor2 = "Moderado" And valor1 = "Moderado" Then
                total = total + 1
            ElseIf valor2 = "Moderado" And valor1 = "Alta" Then
                total = total + 0.6

                'Alta
            ElseIf valor2 = "Alta" And valor1 = "Nulo" Then
                total = total + 0
            ElseIf valor2 = "Alta" And valor1 = "Leve" Then
                total = total + 0.3
            ElseIf valor2 = "Alta" And valor1 = "Moderado" Then
                total = total + 0.6
            ElseIf valor2 = "Alta" And valor1 = "Alta" Then
                total = total + 1
            End If

            If valor1 = valor2 Then
                total = total - 1
            End If

            '4.Gusto por videojuegos
            cmdPorcentaje = New OleDbCommand("SELECT GustoVideojuegos FROM Usuarios WHERE Nombre = '" & cbxPersona1.Text & "'", Conexion)
            valor1 = cmdPorcentaje.ExecuteScalar
            cmdPorcentaje = New OleDbCommand("SELECT GustoVideojuegos FROM Usuarios WHERE Nombre = '" & cbxPersona2.Text & "'", Conexion)
            valor2 = cmdPorcentaje.ExecuteScalar
            'Valor 1
            'Nulo
            If valor1 = "Nulo" And valor2 = "Nulo" Then
                total = total + 1
            ElseIf valor1 = "Nulo" And valor2 = "Leve" Then
                total = total + 0.6
            ElseIf valor1 = "Nulo" And valor2 = "Moderado" Then
                total = total + 0.3
            ElseIf valor1 = "Nulo" And valor2 = "Alta" Then
                total = total + 0

                'Leve
            ElseIf valor1 = "Leve" And valor2 = "Nulo" Then
                total = total + 0.6
            ElseIf valor1 = "Leve" And valor2 = "Leve" Then
                total = total + 1
            ElseIf valor1 = "Leve" And valor2 = "Moderado" Then
                total = total + 0.6
            ElseIf valor1 = "Leve" And valor2 = "Alta" Then
                total = total + 0.3

                'Moderado
            ElseIf valor1 = "Moderado" And valor2 = "Nulo" Then
                total = total + 0.3
            ElseIf valor1 = "Moderado" And valor2 = "Leve" Then
                total = total + 0.6
            ElseIf valor1 = "Moderado" And valor2 = "Moderado" Then
                total = total + 1
            ElseIf valor1 = "Moderado" And valor2 = "Alta" Then
                total = total + 0.6

                'Alta
            ElseIf valor1 = "Alta" And valor2 = "Nulo" Then
                total = total + 0
            ElseIf valor1 = "Alta" And valor2 = "Leve" Then
                total = total + 0.3
            ElseIf valor1 = "Alta" And valor2 = "Moderado" Then
                total = total + 0.6
            ElseIf valor1 = "Alta" And valor2 = "Alta" Then
                total = total + 1

            End If

            'Valor 2
            'Nulo
            If valor2 = "Nulo" And valor1 = "Nulo" Then
                total = total + 1
            ElseIf valor2 = "Nulo" And valor1 = "Leve" Then
                total = total + 0.6
            ElseIf valor2 = "Nulo" And valor1 = "Moderado" Then
                total = total + 0.3
            ElseIf valor2 = "Nulo" And valor1 = "Alta" Then
                total = total + 0

                'Leve
            ElseIf valor2 = "Leve" And valor1 = "Nulo" Then
                total = total + 0.6
            ElseIf valor2 = "Leve" And valor1 = "Leve" Then
                total = total + 1
            ElseIf valor2 = "Leve" And valor1 = "Moderado" Then
                total = total + 0.6
            ElseIf valor2 = "Leve" And valor1 = "Alta" Then
                total = total + 0.3

                'Moderado
            ElseIf valor2 = "Moderado" And valor1 = "Nulo" Then
                total = total + 0.3
            ElseIf valor2 = "Moderado" And valor1 = "Leve" Then
                total = total + 0.6
            ElseIf valor2 = "Moderado" And valor1 = "Moderado" Then
                total = total + 1
            ElseIf valor2 = "Moderado" And valor1 = "Alta" Then
                total = total + 0.6

                'Alta
            ElseIf valor2 = "Alta" And valor1 = "Nulo" Then
                total = total + 0
            ElseIf valor2 = "Alta" And valor1 = "Leve" Then
                total = total + 0.3
            ElseIf valor2 = "Alta" And valor1 = "Moderado" Then
                total = total + 0.6
            ElseIf valor2 = "Alta" And valor1 = "Alta" Then
                total = total + 1
            End If

            If valor1 = valor2 Then
                total = total - 1
            End If

            ' 5.Tipo de Videojuegos
            cmdPorcentaje = New OleDbCommand("SELECT TipoVideojuegos FROM Usuarios WHERE Nombre = '" & cbxPersona1.Text & "'", Conexion)
            valor1 = cmdPorcentaje.ExecuteScalar
            cmdPorcentaje = New OleDbCommand("SELECT TipoVideojuegos FROM Usuarios WHERE Nombre = '" & cbxPersona2.Text & "'", Conexion)
            valor2 = cmdPorcentaje.ExecuteScalar

            'Valor 1
            'Accion
            If valor1 = "Accion" And valor2 = "Accion" Then
                total = total + 1
            ElseIf valor1 = "Accion" And valor2 = "Terror" Then
                total = total + 0.2
            ElseIf valor1 = "Accion" And valor2 = "Estrategia" Then
                total = total + 0.2
            ElseIf valor1 = "Accion" And valor2 = "Simulacion" Then
                total = total + 0.2
            ElseIf valor1 = "Accion" And valor2 = "Otro" Then
                total = total + 0.2

                'Terror
            ElseIf valor1 = "Terror" And valor2 = "Accion" Then
                total = total + 0.2
            ElseIf valor1 = "Terror" And valor2 = "Terror" Then
                total = total + 1
            ElseIf valor1 = "Terror" And valor2 = "Estrategia" Then
                total = total + 0.2
            ElseIf valor1 = "Terror" And valor2 = "Simulacion" Then
                total = total + 0.2
            ElseIf valor1 = "Terror" And valor2 = "Otro" Then
                total = total + 0.2

                'Estrategia
            ElseIf valor1 = "Estrategia" And valor2 = "Accion" Then
                total = total + 0.2
            ElseIf valor1 = "Estrategia" And valor2 = "Terror" Then
                total = total + 0.2
            ElseIf valor1 = "Estrategia" And valor2 = "Estrategia" Then
                total = total + 1
            ElseIf valor1 = "Estrategia" And valor2 = "Simulacion" Then
                total = total + 0.2
            ElseIf valor1 = "Estrategia" And valor2 = "Otro" Then
                total = total + 0.2

                'Simulacion
            ElseIf valor1 = "Simulacion" And valor2 = "Accion" Then
                total = total + 0.2
            ElseIf valor1 = "Simulacion" And valor2 = "Terror" Then
                total = total + 0.2
            ElseIf valor1 = "Simulacion" And valor2 = "Estrategia" Then
                total = total + 0.2
            ElseIf valor1 = "Simulacion" And valor2 = "Simulacion" Then
                total = total + 1
            ElseIf valor1 = "Simulacion" And valor2 = "Otro" Then
                total = total + 0.2

                'Otro
            ElseIf valor1 = "Otro" And valor2 = "Accion" Then
                total = total + 0.2
            ElseIf valor1 = "Otro" And valor2 = "Terror" Then
                total = total + 0.2
            ElseIf valor1 = "Otro" And valor2 = "Estrategia" Then
                total = total + 0.2
            ElseIf valor1 = "Otro" And valor2 = "Simulacion" Then
                total = total + 0.2
            ElseIf valor1 = "Otro" And valor2 = "Otro" Then
                total = total + 1
            End If


            'Valor 2
            'Accion
            If valor2 = "Accion" And valor1 = "Accion" Then
                total = total + 1
            ElseIf valor2 = "Accion" And valor1 = "Terror" Then
                total = total + 0.2
            ElseIf valor2 = "Accion" And valor1 = "Estrategia" Then
                total = total + 0.2
            ElseIf valor2 = "Accion" And valor1 = "Simulacion" Then
                total = total + 0.2
            ElseIf valor2 = "Accion" And valor1 = "Otro" Then
                total = total + 0.2

                'Terror
            ElseIf valor2 = "Terror" And valor1 = "Accion" Then
                total = total + 0.2
            ElseIf valor2 = "Terror" And valor1 = "Terror" Then
                total = total + 1
            ElseIf valor2 = "Terror" And valor1 = "Estrategia" Then
                total = total + 0.2
            ElseIf valor2 = "Terror" And valor1 = "Simulacion" Then
                total = total + 0.2
            ElseIf valor2 = "Terror" And valor1 = "Otro" Then
                total = total + 0.2

                'Estrategia
            ElseIf valor2 = "Estrategia" And valor1 = "Accion" Then
                total = total + 0.2
            ElseIf valor2 = "Estrategia" And valor1 = "Terror" Then
                total = total + 0.2
            ElseIf valor2 = "Estrategia" And valor1 = "Estrategia" Then
                total = total + 1
            ElseIf valor2 = "Estrategia" And valor1 = "Simulacion" Then
                total = total + 0.2
            ElseIf valor2 = "Estrategia" And valor1 = "Otro" Then
                total = total + 0.2

                'Simulacion
            ElseIf valor2 = "Simulacion" And valor1 = "Accion" Then
                total = total + 0.2
            ElseIf valor2 = "Simulacion" And valor1 = "Terror" Then
                total = total + 0.2
            ElseIf valor2 = "Simulacion" And valor1 = "Estrategia" Then
                total = total + 0.2
            ElseIf valor2 = "Simulacion" And valor1 = "Simulacion" Then
                total = total + 1
            ElseIf valor2 = "Simulacion" And valor1 = "Otro" Then
                total = total + 0.2

                'Otro
            ElseIf valor2 = "Otro" And valor1 = "Accion" Then
                total = total + 0.2
            ElseIf valor2 = "Otro" And valor1 = "Terror" Then
                total = total + 0.2
            ElseIf valor2 = "Otro" And valor1 = "Estrategia" Then
                total = total + 0.2
            ElseIf valor2 = "Otro" And valor1 = "Simulacion" Then
                total = total + 0.2
            ElseIf valor2 = "Otro" And valor1 = "Otro" Then
                total = total + 1
            End If

            If valor1 = valor2 Then
                total = total - 1
            End If

            '6.Gusto por el cine
            cmdPorcentaje = New OleDbCommand("SELECT GustoCine FROM Usuarios WHERE Nombre = '" & cbxPersona1.Text & "'", Conexion)
            valor1 = cmdPorcentaje.ExecuteScalar
            cmdPorcentaje = New OleDbCommand("SELECT GustoCine FROM Usuarios WHERE Nombre = '" & cbxPersona2.Text & "'", Conexion)
            valor2 = cmdPorcentaje.ExecuteScalar
            'Valor 1
            'Nulo
            If valor1 = "Nulo" And valor2 = "Nulo" Then
                total = total + 1
            ElseIf valor1 = "Nulo" And valor2 = "Leve" Then
                total = total + 0.6
            ElseIf valor1 = "Nulo" And valor2 = "Moderado" Then
                total = total + 0.3
            ElseIf valor1 = "Nulo" And valor2 = "Alta" Then
                total = total + 0

                'Leve
            ElseIf valor1 = "Leve" And valor2 = "Nulo" Then
                total = total + 0.6
            ElseIf valor1 = "Leve" And valor2 = "Leve" Then
                total = total + 1
            ElseIf valor1 = "Leve" And valor2 = "Moderado" Then
                total = total + 0.6
            ElseIf valor1 = "Leve" And valor2 = "Alta" Then
                total = total + 0.3

                'Moderado
            ElseIf valor1 = "Moderado" And valor2 = "Nulo" Then
                total = total + 0.3
            ElseIf valor1 = "Moderado" And valor2 = "Leve" Then
                total = total + 0.6
            ElseIf valor1 = "Moderado" And valor2 = "Moderado" Then
                total = total + 1
            ElseIf valor1 = "Moderado" And valor2 = "Alta" Then
                total = total + 0.6

                'Alta
            ElseIf valor1 = "Alta" And valor2 = "Nulo" Then
                total = total + 0
            ElseIf valor1 = "Alta" And valor2 = "Leve" Then
                total = total + 0.3
            ElseIf valor1 = "Alta" And valor2 = "Moderado" Then
                total = total + 0.6
            ElseIf valor1 = "Alta" And valor2 = "Alta" Then
                total = total + 1

            End If

            'Valor 2
            'Nulo
            If valor2 = "Nulo" And valor1 = "Nulo" Then
                total = total + 1
            ElseIf valor2 = "Nulo" And valor1 = "Leve" Then
                total = total + 0.6
            ElseIf valor2 = "Nulo" And valor1 = "Moderado" Then
                total = total + 0.3
            ElseIf valor2 = "Nulo" And valor1 = "Alta" Then
                total = total + 0

                'Leve
            ElseIf valor2 = "Leve" And valor1 = "Nulo" Then
                total = total + 0.6
            ElseIf valor2 = "Leve" And valor1 = "Leve" Then
                total = total + 1
            ElseIf valor2 = "Leve" And valor1 = "Moderado" Then
                total = total + 0.6
            ElseIf valor2 = "Leve" And valor1 = "Alta" Then
                total = total + 0.3

                'Moderado
            ElseIf valor2 = "Moderado" And valor1 = "Nulo" Then
                total = total + 0.3
            ElseIf valor2 = "Moderado" And valor1 = "Leve" Then
                total = total + 0.6
            ElseIf valor2 = "Moderado" And valor1 = "Moderado" Then
                total = total + 1
            ElseIf valor2 = "Moderado" And valor1 = "Alta" Then
                total = total + 0.6

                'Alta
            ElseIf valor2 = "Alta" And valor1 = "Nulo" Then
                total = total + 0
            ElseIf valor2 = "Alta" And valor1 = "Leve" Then
                total = total + 0.3
            ElseIf valor2 = "Alta" And valor1 = "Moderado" Then
                total = total + 0.6
            ElseIf valor2 = "Alta" And valor1 = "Alta" Then
                total = total + 1
            End If

            If valor1 = valor2 Then
                total = total - 1
            End If

            '7.Gusto por mascotas
            cmdPorcentaje = New OleDbCommand("SELECT GustoMascotas FROM Usuarios WHERE Nombre = '" & cbxPersona1.Text & "'", Conexion)
            valor1 = cmdPorcentaje.ExecuteScalar
            cmdPorcentaje = New OleDbCommand("SELECT GustoMascotas FROM Usuarios WHERE Nombre = '" & cbxPersona2.Text & "'", Conexion)
            valor2 = cmdPorcentaje.ExecuteScalar
            'Valor 1
            'Gatos
            If valor1 = "Gatos" And valor2 = "Gatos" Then
                total = total + 1
            ElseIf valor1 = "Gatos" And valor2 IsNot Nothing Then
                total = total + 0.2

                'Perros
            ElseIf valor1 = "Perros" And valor2 = "Perros" Then
                total = total + 1
            ElseIf valor1 = "Perros" And valor2 IsNot Nothing Then
                total = total + 0.2

                'Aves
            ElseIf valor1 = "Aves" And valor2 = "Aves" Then
                total = total + 1
            ElseIf valor1 = "Aves" And valor2 IsNot Nothing Then
                total = total + 0.2

                'Roedores

            ElseIf valor1 = "Roedores" And valor2 = "Roedores" Then
                total = total + 1
            ElseIf valor1 = "Roedores" And valor2 IsNot Nothing Then
                total = total + 0.2

                'Peces
            ElseIf valor1 = "Peces" And valor2 = "Peces" Then
                total = total + 1
            ElseIf valor1 = "Peces" And valor2 IsNot Nothing Then
                total = total + 0.2

                'Reptiles
            ElseIf valor1 = "Reptiles" And valor2 = "Reptiles" Then
                total = total + 1
            ElseIf valor1 = "Reptiles" And valor2 IsNot Nothing Then
                total = total + 0.2
            End If

            'Valor 2
            'Gatos
            If valor2 = "Gatos" And valor1 = "Gatos" Then
                total = total + 1
            ElseIf valor2 = "Gatos" And valor1 IsNot Nothing Then
                total = total + 0.2

                'Perros
            ElseIf valor2 = "Perros" And valor1 = "Perros" Then
                total = total + 1
            ElseIf valor2 = "Perros" And valor1 IsNot Nothing Then
                total = total + 0.2

                'Aves
            ElseIf valor2 = "Aves" And valor1 = "Aves" Then
                total = total + 1
            ElseIf valor2 = "Aves" And valor1 IsNot Nothing Then
                total = total + 0.2

                'Roedores

            ElseIf valor2 = "Roedores" And valor1 = "Roedores" Then
                total = total + 1
            ElseIf valor1 = "Roedores" And valor1 IsNot Nothing Then
                total = total + 0.2

                'Peces
            ElseIf valor2 = "Peces" And valor1 = "Peces" Then
                total = total + 0.2
            ElseIf valor1 = "Peces" And valor1 IsNot Nothing Then
                total = total + 0.2

                'Reptiles
            ElseIf valor2 = "Reptiles" And valor1 = "Reptiles" Then
                total = total + 1
            ElseIf valor2 = "Reptiles" And valor1 IsNot Nothing Then
                total = total + 0.2
            End If

            If valor1 = valor2 Then
                total = total - 1
            End If


            '8.Gusto por la Musica 
            cmdPorcentaje = New OleDbCommand("SELECT GustoMusica FROM Usuarios WHERE Nombre = '" & cbxPersona1.Text & "'", Conexion)
            valor1 = cmdPorcentaje.ExecuteScalar
            cmdPorcentaje = New OleDbCommand("SELECT GustoMusica FROM Usuarios WHERE Nombre = '" & cbxPersona2.Text & "'", Conexion)
            valor2 = cmdPorcentaje.ExecuteScalar
            'Valor 1
            'Pop
            If valor1 = "Pop" And valor2 = "Pop" Then
                total = total + 1
            ElseIf valor1 = "Pop" And valor2 IsNot Nothing Then
                total = total + 0.2

                'Rock
            ElseIf valor1 = "Rock" And valor2 = "Rock" Then
                total = total + 1
            ElseIf valor1 = "Rock" And valor2 IsNot Nothing Then
                total = total + 0.2

                'Indie
            ElseIf valor1 = "Indie" And valor2 = "Indie" Then
                total = total + 1
            ElseIf valor1 = "Indie" And valor2 IsNot Nothing Then
                total = total + 0.2

                'K-Pop
            ElseIf valor1 = "K-Pop" And valor2 = "K-Pop" Then
                total = total + 1
            ElseIf valor1 = "K-Pop" And valor2 IsNot Nothing Then
                total = total + 0.2

                'Clasica
            ElseIf valor1 = "Clasica" And valor2 = "Clasica" Then
                total = total + 1
            ElseIf valor1 = "Clasica" And valor2 IsNot Nothing Then
                total = total + 0.2

                'Otro
            ElseIf valor1 = "Otro" And valor2 = "Otro" Then
                total = total + 1
            ElseIf valor1 = "Otro" And valor2 IsNot Nothing Then
                total = total + 0.2
            End If

            'Valor 2
            'Pop
            If valor2 = "Pop" And valor1 = "Pop" Then
                total = total + 1
            ElseIf valor2 = "Pop" And valor1 IsNot Nothing Then
                total = total + 0.2

                'Rock
            ElseIf valor2 = "Rock" And valor1 = "Rock" Then
                total = total + 1
            ElseIf valor2 = "Rock" And valor1 IsNot Nothing Then
                total = total + 0.2

                'Indie
            ElseIf valor2 = "Indie" And valor1 = "Indie" Then
                total = total + 1
            ElseIf valor2 = "Indie" And valor1 IsNot Nothing Then
                total = total + 0.2

                'K-Pop
            ElseIf valor2 = "K-Pop" And valor1 = "K-Pop" Then
                total = total + 1
            ElseIf valor1 = "K-Pop" And valor1 IsNot Nothing Then
                total = total + 0.2

                'Clasica
            ElseIf valor2 = "Clasica" And valor1 = "Clasica" Then
                total = total + 0.2
            ElseIf valor1 = "Clasica" And valor1 IsNot Nothing Then
                total = total + 0.2

                'Otro
            ElseIf valor2 = "Otro" And valor1 = "Otro" Then
                total = total + 1
            ElseIf valor2 = "Otro" And valor1 IsNot Nothing Then
                total = total + 0.2
            End If

            If valor1 = valor2 Then
                total = total - 1
            End If

            '8.Habitos de sueño
            cmdPorcentaje = New OleDbCommand("SELECT HabitoSleep FROM Usuarios WHERE Nombre = '" & cbxPersona1.Text & "'", Conexion)
            valor1 = cmdPorcentaje.ExecuteScalar
            cmdPorcentaje = New OleDbCommand("SELECT HabitoSleep FROM Usuarios WHERE Nombre = '" & cbxPersona2.Text & "'", Conexion)
            valor2 = cmdPorcentaje.ExecuteScalar

            'Valor1
            'Regulares
            If valor1 = "Regulares" And valor2 = "Regulares" Then
                total = total + 1
            ElseIf valor1 = "Regulares" And valor2 = "Invertidos (vivir de noche)" Then
            ElseIf valor1 = "Regulares" And valor2 = "Irregulares" Then
                total = total + 0.5

                'Invertidos
            ElseIf valor1 = "Invertidos (vivir de noche)" And valor2 = "Regulares" Then
            ElseIf valor1 = "Invertidos (vivir de noche)" And valor2 = "Invertidos (vivir de noche)" Then
                total = total + 1
            ElseIf valor1 = "Invertidos (vivir de noche)" And valor2 = "Irregulares" Then
                total = total + 0.5

                'Irregulares
            ElseIf valor1 = "Irregulares" And valor2 = "Regulares" Then
                total = total + 0.5
            ElseIf valor1 = "Irregulares" And valor2 = "Invertidos (vivir de noche)" Then
                total = total + 0.5
            ElseIf valor1 = "Irregulares" And valor2 = "Irregulares" Then
                total = total + 1

            End If

            'Valor2
            'Regulares
            If valor2 = "Regulares" And valor1 = "Regulares" Then
                total = total + 1
            ElseIf valor2 = "Regulares" And valor1 = "Invertidos (vivir de noche)" Then
            ElseIf valor2 = "Regulares" And valor1 = "Irregulares" Then
                total = total + 0.5

                'Invertidos
            ElseIf valor2 = "Invertidos (vivir de noche)" And valor1 = "Regulares" Then
            ElseIf valor2 = "Invertidos (vivir de noche)" And valor1 = "Invertidos (vivir de noche)" Then
                total = total + 1
            ElseIf valor1 = "Invertidos (vivir de noche)" And valor1 = "Irregulares" Then
                total = total + 0.5

                'Irregulares
            ElseIf valor2 = "Irregulares" And valor1 = "Regulares" Then
                total = total + 0.5
            ElseIf valor2 = "Irregulares" And valor1 = "Invertidos (vivir de noche)" Then
                total = total + 0.5
            ElseIf valor2 = "Irregulares" And valor1 = "Irregulares" Then
                total = total + 1
            End If

            If valor1 = valor2 Then
                    total = total - 1
                End If


            '9.Gusto por leer
            cmdPorcentaje = New OleDbCommand("SELECT GustoLeer FROM Usuarios WHERE Nombre = '" & cbxPersona1.Text & "'", Conexion)
            valor1 = cmdPorcentaje.ExecuteScalar
            cmdPorcentaje = New OleDbCommand("SELECT GustoLeer FROM Usuarios WHERE Nombre = '" & cbxPersona2.Text & "'", Conexion)
            valor2 = cmdPorcentaje.ExecuteScalar
                'Valor 1
                'Nulo
                If valor1 = "Nulo" And valor2 = "Nulo" Then
                    total = total + 1
                ElseIf valor1 = "Nulo" And valor2 = "Leve" Then
                    total = total + 0.6
                ElseIf valor1 = "Nulo" And valor2 = "Moderado" Then
                    total = total + 0.3
                ElseIf valor1 = "Nulo" And valor2 = "Alta" Then
                    total = total + 0

                    'Leve
                ElseIf valor1 = "Leve" And valor2 = "Nulo" Then
                    total = total + 0.6
                ElseIf valor1 = "Leve" And valor2 = "Leve" Then
                    total = total + 1
                ElseIf valor1 = "Leve" And valor2 = "Moderado" Then
                    total = total + 0.6
                ElseIf valor1 = "Leve" And valor2 = "Alta" Then
                    total = total + 0.3

                    'Moderado
                ElseIf valor1 = "Moderado" And valor2 = "Nulo" Then
                    total = total + 0.3
                ElseIf valor1 = "Moderado" And valor2 = "Leve" Then
                    total = total + 0.6
                ElseIf valor1 = "Moderado" And valor2 = "Moderado" Then
                    total = total + 1
                ElseIf valor1 = "Moderado" And valor2 = "Alta" Then
                    total = total + 0.6

                    'Alta
                ElseIf valor1 = "Alta" And valor2 = "Nulo" Then
                    total = total + 0
                ElseIf valor1 = "Alta" And valor2 = "Leve" Then
                    total = total + 0.3
                ElseIf valor1 = "Alta" And valor2 = "Moderado" Then
                    total = total + 0.6
                ElseIf valor1 = "Alta" And valor2 = "Alta" Then
                    total = total + 1

                End If

                'Valor 2
                'Nulo
                If valor2 = "Nulo" And valor1 = "Nulo" Then
                    total = total + 1
                ElseIf valor2 = "Nulo" And valor1 = "Leve" Then
                    total = total + 0.6
                ElseIf valor2 = "Nulo" And valor1 = "Moderado" Then
                    total = total + 0.3
                ElseIf valor2 = "Nulo" And valor1 = "Alta" Then
                    total = total + 0

                    'Leve
                ElseIf valor2 = "Leve" And valor1 = "Nulo" Then
                    total = total + 0.6
                ElseIf valor2 = "Leve" And valor1 = "Leve" Then
                    total = total + 1
                ElseIf valor2 = "Leve" And valor1 = "Moderado" Then
                    total = total + 0.6
                ElseIf valor2 = "Leve" And valor1 = "Alta" Then
                    total = total + 0.3

                    'Moderado
                ElseIf valor2 = "Moderado" And valor1 = "Nulo" Then
                    total = total + 0.3
                ElseIf valor2 = "Moderado" And valor1 = "Leve" Then
                    total = total + 0.6
                ElseIf valor2 = "Moderado" And valor1 = "Moderado" Then
                    total = total + 1
                ElseIf valor2 = "Moderado" And valor1 = "Alta" Then
                    total = total + 0.6

                    'Alta
                ElseIf valor2 = "Alta" And valor1 = "Nulo" Then
                    total = total + 0
                ElseIf valor2 = "Alta" And valor1 = "Leve" Then
                    total = total + 0.3
                ElseIf valor2 = "Alta" And valor1 = "Moderado" Then
                    total = total + 0.6
                ElseIf valor2 = "Alta" And valor1 = "Alta" Then
                    total = total + 1
                End If

                If valor1 = valor2 Then
                    total = total - 1
                End If

            '11.PazInterior
            cmdPorcentaje = New OleDbCommand("SELECT PazInterior FROM Usuarios WHERE Nombre = '" & cbxPersona1.Text & "'", Conexion)
            valor1 = cmdPorcentaje.ExecuteScalar
            cmdPorcentaje = New OleDbCommand("SELECT PazInterior FROM Usuarios WHERE Nombre = '" & cbxPersona2.Text & "'", Conexion)
            valor2 = cmdPorcentaje.ExecuteScalar

                'Valor1
                'Regulares
                If valor1 = "Tranquilo" And valor2 = "Tranquilo" Then
                    total = total + 1
                ElseIf valor1 = "Tranquilo" And valor2 = "Reactivo" Then
                    total = total + 0.6
                ElseIf valor1 = "Tranquilo" And valor2 = "Ansioso" Then
                    total = total + 0.6

                    'Invertidos
                ElseIf valor1 = "Reactivo" And valor2 = "Tranquilo" Then
                    total = total + 0.6
                ElseIf valor1 = "Reactivo" And valor2 = "Reactivo" Then
                    total = total + 1
                ElseIf valor1 = "Reactivo" And valor2 = "Ansioso" Then
                    total = total + 0.6

                    'Irregulares
                ElseIf valor1 = "Ansioso" And valor2 = "Tranquilo" Then
                    total = total + 0.6
                ElseIf valor1 = "Ansioso" And valor2 = "Reactivo" Then
                    total = total + 0.6
                ElseIf valor1 = "Ansioso" And valor2 = "Ansioso" Then
                    total = total + 1

                End If

            'Valor2
            'Regulares
            If valor2 = "Tranquilo" And valor1 = "Tranquilo" Then
                total = total + 1
            ElseIf valor2 = "Tranquilo" And valor1 = "Reactivo" Then
                total = total + 0.6
            ElseIf valor2 = "Tranquilo" And valor1 = "Ansioso" Then
                total = total + 0.6

                'Invertidos
            ElseIf valor2 = "Reactivo" And valor1 = "Tranquilo" Then
                total = total + 0.6
            ElseIf valor2 = "Reactivo" And valor1 = "Reactivo" Then
                total = total + 1
            ElseIf valor1 = "Reactivo" And valor1 = "Ansioso" Then
                total = total + 0.6

                'Irregulares
            ElseIf valor2 = "Ansioso" And valor1 = "Tranquilo" Then
                total = total + 0.6
            ElseIf valor2 = "Ansioso" And valor1 = "Reactivo" Then
                total = total + 0.6
            ElseIf valor2 = "Ansioso" And valor1 = "Ansioso" Then
                total = total + 1
            End If
            If valor1 = valor2 Then
                    total = total - 1
                End If


            '12.Enfoque Personal
            cmdPorcentaje = New OleDbCommand("SELECT EnfoquePersonal FROM Usuarios WHERE Nombre = '" & cbxPersona1.Text & "'", Conexion)
            valor1 = cmdPorcentaje.ExecuteScalar
            cmdPorcentaje = New OleDbCommand("SELECT EnfoquePersonal FROM Usuarios WHERE Nombre = '" & cbxPersona2.Text & "'", Conexion)
            valor2 = cmdPorcentaje.ExecuteScalar

            'Valor 1
            'Familiar
            If valor1 = "Familiar" And valor2 = "Familiar" Then
                total = total + 1
            ElseIf valor1 = "Familiar" And valor2 IsNot Nothing Then
                total = total + 0.2

                'Trabajo/Escuela
            ElseIf valor1 = "Trabajo/Escuela" And valor2 = "Trabajo/Escuela" Then
                total = total + 1
            ElseIf valor1 = "Trabajo/Escuela" And valor2 IsNot Nothing Then
                total = total + 0.2

                'Amigos
            ElseIf valor1 = "Amigos" And valor2 = "Amigos" Then
                total = total + 1
            ElseIf valor1 = "Amigos" And valor2 IsNot Nothing Then
                total = total + 0.2

                'Pareja
            ElseIf valor1 = "Pareja" And valor2 = "Pareja" Then
                total = total + 1
            ElseIf valor1 = "Pareja" And valor2 IsNot Nothing Then
                total = total + 0.2

                'Individual
            ElseIf valor1 = "Individual" And valor2 = "Individual" Then
                total = total + 1
            ElseIf valor1 = "Individual" And valor2 IsNot Nothing Then
                total = total + 0.2
            End If

            'Valor 2
            'Familiar
            If valor2 = "Familiar" And valor1 = "Familiar" Then
                total = total + 1
            ElseIf valor2 = "Familiar" And valor1 IsNot Nothing Then
                total = total + 0.2

                'Trabajo/Escuela
            ElseIf valor2 = "Trabajo/Escuela" And valor1 = "Trabajo/Escuela" Then
                total = total + 1
            ElseIf valor2 = "Trabajo/Escuela" And valor1 IsNot Nothing Then
                total = total + 0.2

                'Amigos
            ElseIf valor2 = "Amigos" And valor1 = "Amigos" Then
                total = total + 1
            ElseIf valor2 = "Amigos" And valor1 IsNot Nothing Then
                total = total + 0.2

                'Pareja
            ElseIf valor2 = "Pareja" And valor1 = "Pareja" Then
                total = total + 1
            ElseIf valor1 = "Pareja" And valor1 IsNot Nothing Then
                total = total + 0.2

                'Individual
            ElseIf valor2 = "Individual" And valor1 = "Individual" Then
                total = total + 1
            ElseIf valor1 = "Individual" And valor1 IsNot Nothing Then
                total = total + 0.2
            End If

            If valor1 = valor2 Then
                total = total - 1
            End If


            '13. Creencias
            cmdPorcentaje = New OleDbCommand("SELECT Creencias FROM Usuarios WHERE Nombre = '" & cbxPersona1.Text & "'", Conexion)
            valor1 = cmdPorcentaje.ExecuteScalar
            cmdPorcentaje = New OleDbCommand("SELECT Creencias FROM Usuarios WHERE Nombre = '" & cbxPersona2.Text & "'", Conexion)
            valor2 = cmdPorcentaje.ExecuteScalar

            'Valor 1
            'Creyente
            If valor1 = "Creyente" And valor2 = "Creyente" Then
                total = total + 1
            ElseIf valor1 = "Creyente" And valor2 = "Agnostico" Then
                total = total + 0.5
            ElseIf valor1 = "Creyente" And valor2 = "Ateo" Then
                total = total + 0.5

                'Agnostico
            ElseIf valor1 = "Agnostico" And valor2 = "Creyente" Then
                total = total + 0.5
            ElseIf valor1 = "Agnostico" And valor2 = "Agnostico" Then
                total = total + 1
            ElseIf valor1 = "Agnostico" And valor2 = "Ateo" Then
                total = total + 0.5

                'Ateo
            ElseIf valor1 = "Ateo" And valor2 = "Creyente" Then
                total = total + 0.5
            ElseIf valor1 = "Ateo" And valor2 = "Agnostico" Then
                total = total + 0.5
            ElseIf valor1 = "Ateo" And valor2 = "Ateo" Then
                total = total + 1
            End If
            'Valor 2
            'Creyente
            If valor2 = "Creyente" And valor1 = "Creyente" Then
                total = total + 1
            ElseIf valor2 = "Creyente" And valor1 = "Agnostico" Then
                total = total + 0.5
            ElseIf valor2 = "Creyente" And valor1 = "Ateo" Then
                total = total + 0.5

                'Agnostico
            ElseIf valor2 = "Agnostico" And valor1 = "Creyente" Then
                total = total + 0.5
            ElseIf valor2 = "Agnostico" And valor1 = "Agnostico" Then
                total = total + 1
            ElseIf valor2 = "Agnostico" And valor1 = "Ateo" Then
                total = total + 0.5

                'Ateo
            ElseIf valor2 = "Ateo" And valor1 = "Creyente" Then
                total = total + 0.5
            ElseIf valor2 = "Ateo" And valor1 = "Agnostico" Then
                total = total + 0.5
            ElseIf valor2 = "Ateo" And valor1 = "Ateo" Then
                total = total + 1
            End If
            If valor1 = valor2 Then
                total = total - 1
            End If


            '14. Estacion preferida del año
            cmdPorcentaje = New OleDbCommand("SELECT EstacionPreferida FROM Usuarios WHERE Nombre = '" & cbxPersona1.Text & "'", Conexion)
            valor1 = cmdPorcentaje.ExecuteScalar
            cmdPorcentaje = New OleDbCommand("SELECT EstacionPreferida FROM Usuarios WHERE Nombre = '" & cbxPersona2.Text & "'", Conexion)
            valor2 = cmdPorcentaje.ExecuteScalar
            'Valor 1
            'Primavera
            If valor1 = "Primavera" And valor2 = "Primavera" Then
                total = total + 1
            ElseIf valor1 = "Primavera" And valor2 = "Verano" Then
                total = total + 0.6
            ElseIf valor1 = "Primavera" And valor2 = "Otono" Then
                total = total + 0.3
            ElseIf valor1 = "Primavera" And valor2 = "Invierno" Then
                total = total + 0

                'Verano
            ElseIf valor1 = "Verano" And valor2 = "Primavera" Then
                total = total + 0.6
            ElseIf valor1 = "Verano" And valor2 = "Verano" Then
                total = total + 1
            ElseIf valor1 = "Verano" And valor2 = "Otono" Then
                total = total + 0
            ElseIf valor1 = "Verano" And valor2 = "Invierno" Then
                total = total + 0.3

                'Otono
            ElseIf valor1 = "Otono" And valor2 = "Primavera" Then
                total = total + 0.3
            ElseIf valor1 = "Otono" And valor2 = "Verano" Then
                total = total + 0.6
            ElseIf valor1 = "Otono" And valor2 = "Otono" Then
                total = total + 1
            ElseIf valor1 = "Otono" And valor2 = "Invierno" Then
                total = total + 0.6

                'Invierno
            ElseIf valor1 = "Invierno" And valor2 = "Primavera" Then
                total = total + 0
            ElseIf valor1 = "Invierno" And valor2 = "Verano" Then
                total = total + 0.3
            ElseIf valor1 = "Invierno" And valor2 = "Otono" Then
                total = total + 0.6
            ElseIf valor1 = "Invierno" And valor2 = "Invierno" Then
                total = total + 1

            End If

            'Valor 2
            'Primavera
            If valor2 = "Primavera" And valor1 = "Primavera" Then
                total = total + 1
            ElseIf valor2 = "Primavera" And valor1 = "Verano" Then
                total = total + 0.6
            ElseIf valor2 = "Primavera" And valor1 = "Otono" Then
                total = total + 0.3
            ElseIf valor2 = "Primavera" And valor1 = "Invierno" Then
                total = total + 0

                'Verano
            ElseIf valor2 = "Verano" And valor1 = "Primavera" Then
                total = total + 0.6
            ElseIf valor2 = "Verano" And valor1 = "Verano" Then
                total = total + 1
            ElseIf valor2 = "Verano" And valor1 = "Otono" Then
                total = total + 0
            ElseIf valor2 = "Verano" And valor1 = "Invierno" Then
                total = total + 0.3

                'Otono
            ElseIf valor2 = "Otono" And valor1 = "Primavera" Then
                total = total + 0.3
            ElseIf valor2 = "Otono" And valor1 = "Verano" Then
                total = total + 0.6
            ElseIf valor2 = "Otono" And valor1 = "Otono" Then
                total = total + 1
            ElseIf valor2 = "Otono" And valor1 = "Invierno" Then
                total = total + 0.6

                'Invierno
            ElseIf valor2 = "Invierno" And valor1 = "Primavera" Then
                total = total + 0
            ElseIf valor2 = "Invierno" And valor1 = "Verano" Then
                total = total + 0.3
            ElseIf valor2 = "Invierno" And valor1 = "Otono" Then
                total = total + 0.6
            ElseIf valor2 = "Invierno" And valor1 = "Invierno" Then
                total = total + 1
            End If

            If valor1 = valor2 Then
                total = total - 1
            End If
            Dim resultado As Integer
            resultado = ((total * 100) / 14)
            resultado = Math.Round(resultado, 2)
            lblPorcentaje.Text = resultado.ToString + "%"
        Catch ex As Exception

            MsgBox("Error de Operacion " & ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub btnComparar_Click(sender As Object, e As EventArgs) Handles btnComparar.Click
        porcentaje()
    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        Principal.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub
End Class