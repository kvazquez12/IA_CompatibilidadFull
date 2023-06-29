Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(254, 250, 224)
        pnlTitulo.BackColor = Color.FromArgb(204, 213, 174)
        btnRegistrar.BackColor = Color.FromArgb(250, 237, 205)
        btnComprobar.BackColor = Color.FromArgb(250, 237, 205)

        Enlace()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        frmInicial.Show()
        Me.Hide()

    End Sub

    Private Sub btnComprobar_Click(sender As Object, e As EventArgs) Handles btnComprobar.Click
        Resultados.Show()
        Me.Hide()

    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.Exit()
    End Sub

    Private Sub btn_Minimizar_Click(sender As Object, e As EventArgs) Handles btn_Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class