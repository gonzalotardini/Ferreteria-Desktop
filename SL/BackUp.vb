
Imports System.Configuration
Imports System.Data.SqlClient
Imports dal

Public Class BackUp
    Inherits DatosBase

    Public Sub RealizarBackUp()


        Try

            Dim NombreRespaldo

            NombreRespaldo = "BACKUP_" & Now.Day & "_" & Now.Month & "_" & Now.Year & ".bak"

            Me.Conexion.Close()
            Me.Conexion.Open()

            Dim conexion As New SqlConnection("data source = FERRETERIA-PC\SQLEXPRESS; initial catalog = Ferreteria; user id = FERRETERIA-PC; password = chaca1994")

            Dim RutaDestino As String = "C:\Users\Ferreteria2\Dropbox\backup Base de datos\"

            Dim cmd As New SqlCommand("BACKUP DATABASE Ferreteria TO DISK = '" & RutaDestino & NombreRespaldo & "'", Me.Conexion)


            cmd.ExecuteNonQuery()

        Catch ex As Exception

            Throw New Exception(ex.Message)

        Finally
            Conexion.Close()
        End Try
        



    End Sub

End Class
