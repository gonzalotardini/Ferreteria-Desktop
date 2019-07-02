Imports Entidades
Imports System.Configuration
Imports System.Data.SqlClient

Public Class ClientesMetodos
    Inherits DatosBase


    Public Sub AgregarCliente(Cliente As Cliente)
        Dim _Consulta As String
        Dim _Comando As SqlCommand


        _Consulta = "Insert Into Cliente (Razon_Social, Cuit, Direccion, Localidad, Telefono, Email) values (@Razon_Social, @Cuit, @Direccion, @Localidad, @Telefono, @Email)"

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        _Comando.Parameters.AddWithValue("@Razon_Social", Cliente.Razon_Social)
        _Comando.Parameters.AddWithValue("@Cuit", Cliente.Cuit)
        _Comando.Parameters.AddWithValue("@Direccion", Cliente.Direccion)
        _Comando.Parameters.AddWithValue("@Localidad", Cliente.Localidad)
        _Comando.Parameters.AddWithValue("@Telefono", Cliente.Telefono)
        _Comando.Parameters.AddWithValue("@Email", Cliente.Email)

        _Comando.ExecuteNonQuery()

        Me.Conexion.Close()
    End Sub




    Public Function ObtenerTodosLosClientes() As DataSet
        Dim _Consulta As String
        Dim _Comando As New SqlCommand
        Dim _DataSet As New DataSet

        _Consulta = "Select * from Cliente order by razon_social"


        Me.Conexion.Close()
        Me.Conexion.Open()

        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataSet)


        Return _DataSet

        Me.Conexion.Close()

    End Function


    Public Function BuscarClientePorRazonSocial(cliente As Cliente) As DataSet
        Dim _Consulta As String
        Dim _Comando As New SqlCommand
        Dim _DataSet As New DataSet

        _Consulta = "Select * from Cliente where Razon_Social like '%" + cliente.Razon_Social + "%' order by razon_social"


        Me.Conexion.Close()
        Me.Conexion.Open()

        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataSet)


        Return _DataSet

        Me.Conexion.Close()

    End Function



    Public Function BuscarClientePorCuit(cliente As Cliente) As DataSet
        Dim _Consulta As String
        Dim _Comando As New SqlCommand
        Dim _DataSet As New DataSet

        _Consulta = "Select * from Cliente where Cuit like '@Cuit%'order by razon_social"
            '"Select * from Cliente where Cuit like '%" + cliente.Cuit + "%' order by razon_social"
        Me.Conexion.Close()
        Me.Conexion.Open()

        _Comando = New SqlCommand(_Consulta, Me.Conexion)
        _Comando.Parameters.AddWithValue("@Cuit", cliente.Cuit)

        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataSet)


        Return _DataSet

        Me.Conexion.Close()

    End Function




    Public Function ObtenerClientePorCodigo(Cliente As Cliente) As Cliente

        Dim _Consulta As String
        Dim _Comando As New SqlCommand
        Dim _DataSet As New DataSet
        Dim ClienteObtenido As New Cliente



        _Consulta = "Select * from Cliente where Cod_Cliente=@Cod_Cliente"


        Try

            Me.Conexion.Close()
            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)
            _Comando.Parameters.AddWithValue("@Cod_cliente", Cliente.Cod_Cliente)

            Dim _Adapter As New SqlDataAdapter(_Comando)

            _Adapter.Fill(_DataSet)


            ClienteObtenido.Cod_Cliente = _DataSet.Tables(0).Rows(0).Item("Cod_Cliente")
            ClienteObtenido.Cuit = _DataSet.Tables(0).Rows(0).Item("Cuit")
            ClienteObtenido.Direccion = _DataSet.Tables(0).Rows(0).Item("Direccion")
            ClienteObtenido.Email = _DataSet.Tables(0).Rows(0).Item("Email")
            ClienteObtenido.Localidad = _DataSet.Tables(0).Rows(0).Item("Localidad")
            ClienteObtenido.Razon_Social = _DataSet.Tables(0).Rows(0).Item("Razon_Social")
            ClienteObtenido.Telefono = _DataSet.Tables(0).Rows(0).Item("Telefono")


            Return ClienteObtenido




        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Information, "Error")
            Return Nothing
        Finally

            Me.Conexion.Close()
        End Try



    End Function




    Public Sub ActualizarCliente(ByVal Cliente As Cliente)


        Dim _Consulta As String
        Dim _Comando As SqlCommand

        Try
            _Consulta = "Update Cliente set Razon_Social=@Razon_Social, Cuit=@Cuit, Direccion=@Direccion, Localidad=@Localidad, Telefono=@Telefono, Email=@Email where Cod_Cliente=@Cod_Cliente"

            Me.Conexion.Close()
            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Cod_Cliente", Cliente.Cod_Cliente)
            _Comando.Parameters.AddWithValue("@Razon_Social", Cliente.Razon_Social)
            _Comando.Parameters.AddWithValue("@Cuit", Cliente.Cuit)
            _Comando.Parameters.AddWithValue("@Direccion", Cliente.Direccion)
            _Comando.Parameters.AddWithValue("@Localidad", Cliente.Localidad)
            _Comando.Parameters.AddWithValue("@Telefono", Cliente.Telefono)
            _Comando.Parameters.AddWithValue("@Email", Cliente.Email)

            _Comando.ExecuteNonQuery()


            

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")


        Finally
            Me.Conexion.Close()


        End Try




        



    End Sub

End Class
