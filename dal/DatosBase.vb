Imports System.Configuration
Imports System.Data.SqlClient


Public Class DatosBase

    Public ReadOnly Property Conexion As SqlConnection
        Get
            Return ClaseConexion.InstanciarObjetoConexion.CadenaConexion
        End Get
    End Property



End Class
