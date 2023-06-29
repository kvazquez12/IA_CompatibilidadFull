Imports System.Runtime.InteropServices
Public Class frmInicial
    Private Sub frmInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(254, 250, 224)
        pnlTitulo.BackColor = Color.FromArgb(204, 213, 174)
        pnlBotones.BackColor = Color.FromArgb(204, 213, 174)
        btnSig.BackColor = Color.FromArgb(250, 237, 205)

    End Sub

    Public Sub PasarDatos()

        Dim nombre = lblNombre.Text
        Dim sexo = cmbSexo.Text

        If rb1.Checked Then
            Dim edad = "12-15"
        End If
        If rb2.Checked Then
            Dim edad = "16-18"
        End If
        If rb3.Checked Then
            Dim edad = "19-21"
        End If
        If rb4.Checked Then
            Dim edad = "22-24"
        End If
        If rb5.Checked Then
            Dim edad = "25-27"
        End If
        If rb6.Checked Then
            Dim edad = "27-30"
        End If

        If rbExtro.Checked Then
            Dim personalidad = "Extrovertido"
        ElseIf rbIntro.Checked Then
            Dim personalidad = "Introvertido"
        End If

        If rbCreye.Checked Then
            Dim creencias = "Creyente"
        ElseIf rbAgno.Checked Then
            Dim creencias = "Agnostico"
        ElseIf rbAteo.Checked Then
            Dim creencias = "Ateo"
        End If


    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.Exit()
    End Sub

    Private Sub btn_Minimizar_Click(sender As Object, e As EventArgs) Handles btn_Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnSig_Click(sender As Object, e As EventArgs) Handles btnSig.Click
        Module1.nombre = txtNombre.Text
        Module1.sexo = cmbSexo.Text

        If rb1.Checked Then
            Module1.edad = "12-15"
        ElseIf rb2.Checked Then
            Module1.edad = "16-18"
        ElseIf rb3.Checked Then
            Module1.edad = "19-21"
        ElseIf rb4.Checked Then
            Module1.edad = "22-24"
        ElseIf rb5.Checked Then
            Module1.edad = "25-27"
        ElseIf rb6.Checked Then
            Module1.edad = "27-30"
        End If

        If rbExtro.Checked Then
            Module1.personalidad = "Extrovertido"
        ElseIf rbIntro.Checked Then
            Module1.personalidad = "Introvertido"
        End If


        If rbCreye.Checked Then
            Module1.creencias = "Creyente"
        ElseIf rbAgno.Checked Then
            Module1.creencias = "Agnostico"
        ElseIf rbAteo.Checked Then
            Module1.creencias = "Ateo"
        End If

        Preguntas.Show()
        Me.Close()

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub btnComparar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Principal.Show()
        Me.Close()
    End Sub

End Class
