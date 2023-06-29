Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices

Public Class Preguntas
    Private Sub Preguntas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(254, 250, 224)
        pnlTitulo.BackColor = Color.FromArgb(204, 213, 174)
        pnlBotones.BackColor = Color.FromArgb(204, 213, 174)
        btnReg.BackColor = Color.FromArgb(250, 237, 205)
        btnAnterior.BackColor = Color.FromArgb(250, 237, 205)



    End Sub





    Public Comando_Registrar As New OleDb.OleDbCommand

    Private Sub Registrar_Usuarios()


        Try
            'Asignaos la conexion a la variable
            Comando_Registrar.Connection = Conexion
            ' & Chr(13) & Es un salto de linea en el codig
            Comando_Registrar = New OleDb.OleDbCommand("INSERT INTO Usuarios(Nombre, RangoEdad, Sexo, Creencias, Personalidad, ActividadDeportiva, GustoVideojuegos, TipoVideojuegos, GustoCine, GustoMascotas, GustoMusica, HabitoSleep, GustoLeer, PazInterior, EnfoquePersonal, EstacionPreferida)" & Chr(13) &
                                                       "VALUES(Nombre, RangoEdad, Sexo, Creencias, Personalidad, ActividadDeportiva, GustoVideojuegos, TipoVideojuegos, GustoCine, GustoMascotas, GustoMusica, HabitoSleep, GustoLeer, PazInterior, EnfoquePersonal, EstacionPreferida)", Conexion)
            'Pasamos los datos de los campos a la base de datos
            Comando_Registrar.Parameters.AddWithValue("@Nombre", Module1.nombre)
            Comando_Registrar.Parameters.AddWithValue("@RangoEdad", Module1.edad)
            Comando_Registrar.Parameters.AddWithValue("@Sexo", Module1.sexo)
            Comando_Registrar.Parameters.AddWithValue("@Creencias", Module1.creencias)
            Comando_Registrar.Parameters.AddWithValue("@Personalidad", Module1.personalidad)

            If trbDeporte.Value = 0 Then
                Comando_Registrar.Parameters.AddWithValue("@ActividadDeportiva", "Nulo")
            ElseIf trbDeporte.Value = 1 Then
                Comando_Registrar.Parameters.AddWithValue("@ActividadDeportiva", "Leve")
            ElseIf trbDeporte.Value = 2 Then
                Comando_Registrar.Parameters.AddWithValue("@ActividadDeportiva", "Moderado")
            ElseIf trbDeporte.Value = 3 Then
                Comando_Registrar.Parameters.AddWithValue("@ActividadDeportiva", "Alta")
            End If

            If rbV1.Checked Then
                Comando_Registrar.Parameters.AddWithValue("@GustoVideojuegos", "Nulo")
            ElseIf rbV2.Checked Then
                Comando_Registrar.Parameters.AddWithValue("@GustoVideojuegos", "Leve")
            ElseIf rbV3.Checked Then
                Comando_Registrar.Parameters.AddWithValue("@GustoVideojuegos", "Moderado")
            ElseIf rbV4.Checked Then
                Comando_Registrar.Parameters.AddWithValue("@GustoVideojuegos", "Alta")
            End If

            If rbVF1.Checked Then
                Comando_Registrar.Parameters.AddWithValue("@TipoVideojuegos", "Accion")
            ElseIf rbVF2.Checked Then
                Comando_Registrar.Parameters.AddWithValue("@TipoVideojuegos", "Terror")
            ElseIf rbVF3.Checked Then
                Comando_Registrar.Parameters.AddWithValue("@TipoVideojuegos", "Estrategia")
            ElseIf rbVF4.Checked Then
                Comando_Registrar.Parameters.AddWithValue("@TipoVideojuegos", "Simulacion")
            ElseIf rbVF5.Checked Then
                Comando_Registrar.Parameters.AddWithValue("@TipoVideojuegos", "Otro")
            End If

            If rbC1.Checked Then
                Comando_Registrar.Parameters.AddWithValue("@GustoCine", "Nulo")
            ElseIf rbC2.Checked Then
                Comando_Registrar.Parameters.AddWithValue("@GustoCine", "Leve")
            ElseIf rbC3.Checked Then
                Comando_Registrar.Parameters.AddWithValue("@GustoCine", "Moderado")
            ElseIf rbC4.Checked Then
                Comando_Registrar.Parameters.AddWithValue("@GustoCine", "Alta")
            End If

            Comando_Registrar.Parameters.AddWithValue("@GustoMascotas", cmbMascotas.Text)
            Comando_Registrar.Parameters.AddWithValue("@GustoMusica", cmbMusica.Text)
            Comando_Registrar.Parameters.AddWithValue("@HabitoSleep", cmbSueno.Text)

            If rbLec1.Checked Then
                Comando_Registrar.Parameters.AddWithValue("@GustoLeer", "Nulo")
            ElseIf rbLec2.Checked Then
                Comando_Registrar.Parameters.AddWithValue("@GustoLeer", "Leve")
            ElseIf rbLec3.Checked Then
                Comando_Registrar.Parameters.AddWithValue("@GustoLeer", "Moderado")
            ElseIf rbLec4.Checked Then
                Comando_Registrar.Parameters.AddWithValue("@GustoLeer", "Alta")
            End If
            Comando_Registrar.Parameters.AddWithValue("@PazInterior", cmbPaz.Text)
            Comando_Registrar.Parameters.AddWithValue("@EnfoquePersonal", cmbEnfoque.Text)

            If rbPrimavera.Checked Then
                Comando_Registrar.Parameters.AddWithValue("@EstacionPreferida", "Primavera")
            ElseIf rbOtono.Checked Then
                Comando_Registrar.Parameters.AddWithValue("@EstacionPreferida", "Otono")
            ElseIf rbVerano.Checked Then
                Comando_Registrar.Parameters.AddWithValue("@EstacionPreferida", "Verano")
            ElseIf rbInvierno.Checked Then
                Comando_Registrar.Parameters.AddWithValue("@EstacionPreferida", "Invierno")
            End If


            Comando_Registrar.ExecuteNonQuery()


        Catch ex As Exception
            'Mensaje de error
            MsgBox("Error operacion" & ex.Message, MsgBoxStyle.Critical)


        End Try
    End Sub




    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.Exit()
    End Sub

    Private Sub btn_Minimizar_Click(sender As Object, e As EventArgs) Handles btn_Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        frmInicial.Show()
        Me.Close()

    End Sub

    Private Sub btnSig_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        Registrar_Usuarios()
        MsgBox("Usuario Registrado", MsgBoxStyle.Critical)
        Me.Close()
        Principal.Show()
    End Sub
End Class