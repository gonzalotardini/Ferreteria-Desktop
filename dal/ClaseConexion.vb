Imports System.Configuration
Imports System.Data.SqlClient



Public Class ClaseConexion
    Private _CadenaConexion As SqlConnection
    Private Shared _ObjetoConexion As ClaseConexion = Nothing


    Public Sub New()

        Dim ip = ConfigurationManager.AppSettings("IP")
        Dim base = ConfigurationManager.AppSettings("base")
        Dim usuario = ConfigurationManager.AppSettings("usuario")
        Dim contraseña = ConfigurationManager.AppSettings("contraseña")

        '_CadenaConexion = New SqlConnection(ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString)
        '_CadenaConexion = New SqlConnection("data source =" & ip & "; initial catalog = " & base & "; user id =" & usuario & "; password =" & contraseña)

        '_CadenaConexion = New SqlConnection("data source =FERRETERIA3-PC\SQLEXPRESS; initial catalog = Ferreteria; user id = ferreteria3; password = chaca1994")
        _CadenaConexion = New SqlConnection("data source =FERRETERIA2-PC\SQLEXPRESS; initial catalog = Ferreteria; user id = ferreteria; password = chaca1994")

        '"data source = NOTEBOOK-PC\SQLEXPRESS; initial catalog = Ferreteria; user id = notebook; password = chaca1994"
        '"Data Source=GONZALO-PC\SQLEXPRESS;Initial Catalog=Ferreteria;Integrated Security=True"
        '"Data Source=DESKTOP-JAKV9R3\SQLEXPRESS;Initial Catalog=Ferreteria;Integrated Security=True"
        '"Data Source=FERRETERIA2-PC\SQLEXPRESS;Initial Catalog=Ferreteria;Integrated Security=True"

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
