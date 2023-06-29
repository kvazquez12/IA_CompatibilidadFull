'' Librerias para conexion con una base de datos

Imports System.Data
Imports System.Data.OleDb


Module Conexion_Access

    Public Ruta As String = Application.StartupPath


    '' Enlace a la base de datos y su conexion

    Public Conexion As New OleDbConnection
    Sub Enlace()
        Conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & vbLf &
            Ruta + "\Recursos_Sistema\BaseDeDatos\Usuarios.accdb"
        Conexion.Open()
    End Sub

End Module
