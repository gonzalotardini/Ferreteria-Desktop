Imports System.Configuration
Imports System.Data.SqlClient



Public Class ClaseConexion
    Private _CadenaConexion As SqlConnection
    Private Shared _ObjetoConexion As ClaseConexion = Nothing


    Public Sub New()
        _CadenaConexion = New SqlConnection("data source = FERRETERIA-PC\SQLEXPRESS; initial catalog = Ferreteria; user id = FERRETERIA-PC; password = chaca1994")

        '"data source = NOTEBOOK-PC\SQLEXPRESS; initial catalog = Ferreteria; user id = notebook; password = chaca1994"
        '"Data Source=GONZALO-PC\SQLEXPRESS;Initial Catalog=Ferreteria;Integrated Security=True"
        'data source = FERRETERIA-PC\SQLEXPRESS; initial catalog = Ferreteria; user id = FERRETERIA-PC; password = chaca1994
    End Sub



    Public ReadOnly Property CadenaConexion As SqlConnection
        Get
            Return _CadenaConexion
        End Get
    End Property

    Public Shared Function InstanciarObjetoConexion() As ClaseConexion

        If _ObjetoConexion Is Nothing Then
            _ObjetoConexion = New ClaseConexion

        End If

        Return _ObjetoConexion

    End Function


End Class
