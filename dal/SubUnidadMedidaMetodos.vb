
Imports System.Configuration
Imports System.Data.SqlClient
Imports Entidades

Public Class SubUnidadMedidaMetodos
    Inherits DatosBase

    Public Sub AgregarSubUnidadMedida(SubUnidadMedida As SubUnidad_Medida, UnidadMedida As UnidadMedida)

        Dim _Consulta As String
        Dim _Comando As SqlCommand


        Try
            Me.Conexion.Close()
            Me.Conexion.Open()

            _Consulta = "Insert into SubUnidad_Medida (Cod_Unidad_Medida, Descripcion) values (@Cod_Unidad_Medida, @Descripcion) "

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Cod_Unidad_Medida", UnidadMedida.Cod_UnidadMedida)
            _Comando.Parameters.AddWithValue("@Descripcion", SubUnidadMedida.Descripcion_SubUnidad)

            _Comando.ExecuteNonQuery()

            ' MsgBox("Se agregó correctamente la Sub-Unidad de Medida " + SubUnidadMedida.Descripcion_SubUnidad, MsgBoxStyle.Information, "INFORMACIÓN")

        Catch ex As Exception
            ' MsgBox("ERROR al cargar", MsgBoxStyle.Exclamation, "ATENCIÓN")
        Finally
            Me.Conexion.Close()
        End Try


    End Sub


    Public Function ObtenerTodasLasSubUnidadMedia() As DataSet

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _Dataset As New DataSet

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Consulta = "Select SU.Cod_SubUnidad_Medida, SU.Descripcion AS 'Sub Unidad', U.Descripcion as 'Unidad'  from SubUnidad_Medida as SU, Unidad_Medida as U where SU.Cod_Unidad_Medida=U.Cod_Unidad_Medida order by U.Descripcion"

        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_Dataset)

        Return _Dataset

    End Function

    Public Function ObtenerUnidadMedidaConId(SubUnidadMedida As SubUnidad_Medida) As UnidadMedida

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataSet As New DataSet
        Dim UnidadMedida As New UnidadMedida

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Consulta = "Select SU.Cod_Unidad_Medida from SubUnidad_Medida as SU Where Cod_SubUnidad_Medida=@Cod_SubUnidad_Medida"



        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        _Comando.Parameters.AddWithValue("@Cod_SubUnidad_Medida", SubUnidadMedida.Cod_SubUnidad_Medida)


        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataSet)


        UnidadMedida.Cod_UnidadMedida = _DataSet.Tables(0).Rows(0).Item("Cod_Unidad_Medida")



        Return UnidadMedida


    End Function



    Public Sub ActualizarSubUnidadMedida(SubUnidadMedida As SubUnidad_Medida)

        Dim _Consulta As String
        Dim _Comando As SqlCommand

        _Consulta = "Update SubUnidad_Medida set Cod_Unidad_Medida=@Cod_Unidad_Medida, Descripcion=@Descripcion where Cod_SubUnidad_Medida=@Cod_SubUnidad_Medida"



        Try


            Me.Conexion.Close()
            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Cod_Unidad_Medida", SubUnidadMedida.Cod_Unidad_Medida)
            _Comando.Parameters.AddWithValue("@Descripcion", SubUnidadMedida.Descripcion_SubUnidad)
            _Comando.Parameters.AddWithValue("@Cod_SubUnidad_Medida", SubUnidadMedida.Cod_SubUnidad_Medida)


            _Comando.ExecuteNonQuery()

            MsgBox("Se actualizo correctamente la Sub-Unidad " + SubUnidadMedida.Descripcion_SubUnidad, MsgBoxStyle.Information, "INFORMACIÓN")

        Catch ex As Exception


        Finally
            Me.Conexion.Close()
        End Try

    End Sub

End Class
