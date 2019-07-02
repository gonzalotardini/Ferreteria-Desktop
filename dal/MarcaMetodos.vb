Imports System.Configuration
Imports System.Data.SqlClient
Imports Entidades


Public Class MarcaMetodos
    Inherits DatosBase

    Public Function ObtenerTodasMarcas() As DataSet
        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataSet As New DataSet




        _Consulta = "Select Cod_Marca as 'Codigo', Descripcion from Marca order by Descripcion"

        Me.Conexion.Close()
        Me.Conexion.Open()


        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataSet)

        Return _DataSet


    End Function



    Public Function AgregarMarca(Marca As Marca) As Boolean
        Dim _Consulta As String
        Dim _Comando As SqlCommand

        Try
            _Consulta = "Insert into Marca (Descripcion) values (@Descripcion)"

            Me.Conexion.Close()
            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Descripcion", Marca.Descripcion)

            _Comando.ExecuteNonQuery()

            MsgBox("Se agrego correctamente la marca" + Marca.Descripcion, MsgBoxStyle.Information, "INFORMACIÓN")
            Return True



        Catch ex As Exception

            Return False
            MsgBox("ERROR al agregar " + Marca.Descripcion, MsgBoxStyle.Critical)

        Finally
            Me.Conexion.Close()
        End Try




    End Function


    Public Function ModificarMarca(Marca As Marca) As Boolean
        Dim _Consulta As String
        Dim _Comando As New SqlCommand


        Try
            Me.Conexion.Close()
            Me.Conexion.Open()

            _Consulta = "Update Marca set Descripcion=@Descripcion where Cod_Marca=@Cod_Marca"

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Descripcion", Marca.Descripcion)
            _Comando.Parameters.AddWithValue("@Cod_Marca", Marca.Cod_Marca)

            _Comando.ExecuteNonQuery()

            MsgBox("Se ha modificado correctamente")
            Return True


        Catch ex As Exception
            Return False
            MsgBox("ERROR AL MODIFICAR", MsgBoxStyle.Critical, "INFORMACION")
        End Try
        

    End Function





    Public Function BuscarMarcaPorDescripcion(Marca As Marca) As DataSet



        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataSet As New DataSet

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Consulta = "Select M.Cod_Marca, M.Descripcion AS 'Marca'  from  Marca as M where M.Descripcion like '%" + Marca.Descripcion + "%'"

        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataSet)

        Return _DataSet
    End Function
End Class
