
Imports System.Configuration
Imports System.Data.SqlClient
Imports Entidades


Public Class UnidadMedidaMetodos
    Inherits DatosBase


    Public Function ObtenerTodasUnidadMedida() As DataSet

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataSet As New DataSet


        _Consulta = "Select Cod_Unidad_Medida as Codigo, Descripcion from Unidad_Medida"


        Me.Conexion.Close()
        Me.Conexion.Open()




        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataSet)

        Return _DataSet

        Me.Conexion.Close()



    End Function


    Public Sub AgregarUnidadMedida(UnidadMedida As UnidadMedida)

        Dim _Consulta As String
        Dim _Comando As SqlCommand



        _Consulta = "Insert into Unidad_Medida (Descripcion) values (@Descripcion)"


        Me.Conexion.Close()
        Me.Conexion.Open()




        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        _Comando.Parameters.AddWithValue("@Descripcion", UnidadMedida.Descripcion)

        _Comando.ExecuteNonQuery()

        Me.Conexion.Close()


    End Sub


    Public Function ActualizarUnidadMedida(UnidadMedida As UnidadMedida) As Boolean  'la declaro como boolean para retornar un valor true, si es true limpio el textbox del formulario


        Dim _Consulta As String
        Dim _Comando As SqlCommand



        _Consulta = "Update Unidad_Medida set Descripcion=@Descripcion where Cod_Unidad_Medida=@Cod_Unidad_Medida"

        Try
            Me.Conexion.Close()
            Me.Conexion.Open()




            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Descripcion", UnidadMedida.Descripcion)
            _Comando.Parameters.AddWithValue("@Cod_Unidad_Medida", UnidadMedida.Cod_UnidadMedida)



            _Comando.ExecuteNonQuery()



            MsgBox("Se actualizo correctamente " + UnidadMedida.Descripcion, MsgBoxStyle.Information)


            Return True
        Catch ex As Exception

            MsgBox("ERROR al actualizar", MsgBoxStyle.Critical)
            Return False
        Finally

            Me.Conexion.Close()

        End Try
        

    End Function


End Class
