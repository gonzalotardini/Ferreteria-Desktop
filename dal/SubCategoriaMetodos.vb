Imports Entidades
Imports System.Configuration
Imports System.Data.SqlClient

Public Class SubCategoriaMetodos
    Inherits DatosBase

    Public Function ObtenerTodasLasSUbCategorias() As DataSet

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataSet As New DataSet

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Consulta = "Select SC.Cod_SubCategoria, SC.Descripcion AS 'Sub Categoria', C.Descripcion as 'Categoria'  from SubCategoria as SC, Categoria as C where SC.Cod_Categoria=C.Cod_Categoria order by SC.Descripcion"

        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataSet)

        Return _DataSet



    End Function

    Public Function ObtenerTodasLasSUbCategoriasSolas() As DataSet

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataSet As New DataSet

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Consulta = "Select Cod_SubCategoria, Descripcion from SubCategoria order by Descripcion"

        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataSet)

        Return _DataSet



    End Function



    Public Function AgregarSubCategoria(ByVal Categoria As Categoria, ByVal SubCategoria As SubCategoria) As Boolean

        Dim _Consulta As String
        Dim _Comand As SqlCommand




        Try
            Me.Conexion.Close()
            Me.Conexion.Open()


            _Consulta = "Insert into SubCategoria (Cod_Categoria, Descripcion) values (@Cod_Categoria, @Descripcion)"


            _Comand = New SqlCommand(_Consulta, Me.Conexion)

            _Comand.Parameters.AddWithValue("@Cod_Categoria", Categoria.Cod_Categoria)
            _Comand.Parameters.AddWithValue("@Descripcion", SubCategoria.Descripcion)

            _Comand.ExecuteNonQuery()

            MsgBox("Se agregó correctamente la Sub-Categoría " + SubCategoria.Descripcion, MsgBoxStyle.Information, "INFORMACIÓN")

            Return True
        Catch ex As Exception

            MsgBox("ERROR al cargar", MsgBoxStyle.Exclamation, "ATENCIÓN")

            Return False
        Finally
            Me.Conexion.Close()

        End Try

        





    End Function



    Public Function ObtenerCategoriaConId(SubCategoria As SubCategoria) As Categoria
        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataSet As New DataSet
        Dim categoria As New Categoria

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Consulta = "Select SC.Cod_Categoria from SubCategoria as SC Where Cod_SubCategoria=@Cod_SubCategoria"



        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        _Comando.Parameters.AddWithValue("@Cod_SubCategoria", SubCategoria.Cod_SubCategoria)


        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataSet)


        categoria.Cod_Categoria = _DataSet.Tables(0).Rows(0).Item("Cod_Categoria")



        Return categoria

    End Function



    Public Sub ActualizarSubCategoria(subCategoria As SubCategoria)

        Dim _Consulta As String
        Dim _Comando As SqlCommand

        _Consulta = "Update SubCategoria set Cod_Categoria=@Cod_Categoria, Descripcion=@Descripcion where Cod_SubCategoria=@Cod_SubCategoria"



        Try


            Me.Conexion.Close()
            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Cod_Categoria", subCategoria.Cod_Categoria)
            _Comando.Parameters.AddWithValue("@Descripcion", subCategoria.Descripcion)
            _Comando.Parameters.AddWithValue("@Cod_SubCategoria", subCategoria.Cod_SubCategoria)


            _Comando.ExecuteNonQuery()

            MsgBox("Se actualizo correctamente la Sub-Categoria " + subCategoria.Descripcion, MsgBoxStyle.Information, "INFORMACIÓN")

        Catch ex As Exception


        Finally
            Me.Conexion.Close()
        End Try



    End Sub


    Public Function BuscarSubCategoriaPorDescripcion(subcategoria As SubCategoria) As DataSet



        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataSet As New DataSet

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Consulta = "Select SC.Cod_SubCategoria, SC.Descripcion AS 'Sub Categoria', C.Descripcion as 'Categoria'  from SubCategoria as SC, Categoria as C where SC.Cod_Categoria=C.Cod_Categoria and SC.Descripcion like '%" + subcategoria.Descripcion + "%' order by SC.Descripcion"

        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataSet)

        Return _DataSet
    End Function

End Class
