Imports Entidades
Imports dal
Imports System.Configuration
Imports System.Data.SqlClient


Public Class CategoriaMetodos
    Inherits DatosBase

    Public Function AgregarCategoria(Categoria As Categoria) As Boolean

        Dim _Consulta As String
        Dim _Comando As SqlCommand

        Try
            Me.Conexion.Close()
            Me.Conexion.Open()

            _Consulta = "Insert Into Categoria (Descripcion) values (@Descripcion)"

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Descripcion", Categoria.Descripcion)

            _Comando.ExecuteNonQuery()

            MsgBox("Se ha cargado correctamente la categoria " + Categoria.Descripcion, MsgBoxStyle.Information, "INFORMACION")
            Return True
        Catch ex As Exception
            MsgBox("ERROR al cargar categoria", MsgBoxStyle.Exclamation, "ATENCION")
            Return False
        Finally
            Me.Conexion.Close()
        End Try





    End Function

    Public Function ObtenerTodasCategorias() As DataSet

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataSet As New DataSet

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Consulta = "Select * from Categoria order by Descripcion"

        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataSet)

        Return _DataSet

        Me.Conexion.Close()


    End Function


    Public Function ActualizarCategoria(categoria As Categoria) As Boolean


        Dim _Consulta As String
        Dim _Comando As SqlCommand

        Try

            Me.Conexion.Close()
            Me.Conexion.Open()

            _Consulta = "Update Categoria set Descripcion=@Descripcion where Cod_Categoria=@Cod_Categoria"

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Descripcion", categoria.Descripcion)
            _Comando.Parameters.AddWithValue("@Cod_Categoria", categoria.Cod_Categoria)

            _Comando.ExecuteNonQuery()

            MsgBox("Se actualizó correctamente la categoria " + categoria.Descripcion, MsgBoxStyle.Information, "INFORMACION")
            Return True
        Catch
            MsgBox("ERROR al actualizar categoria", MsgBoxStyle.Exclamation, "ATENCION")
            Return False
        Finally
            Me.Conexion.Close()
        End Try

    End Function



End Class
