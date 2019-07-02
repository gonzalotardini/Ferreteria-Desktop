Imports Entidades
Imports System.Configuration
Imports System.Data.SqlClient

Public Class ArticulosMetodos
    Inherits DatosBase



    Public Function ObtenerUnidadMedida() As DataTable
        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataTable As New DataTable

        _Consulta = "Select * from Unidad_Medida"

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataTable)

        Return _DataTable

        Me.Conexion.Close()

    End Function

    Public Function ObtenerSubUnidadMedida(ByVal Unidad_Medida As UnidadMedida) As DataTable

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataTable As New DataTable

        _Consulta = "Select * from SubUnidad_Medida where Cod_Unidad_Medida=@Cod_Unidad_Medida"
        Me.Conexion.Close()
        Me.Conexion.Open()

        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        _Comando.Parameters.AddWithValue("@Cod_Unidad_Medida", Unidad_Medida.Cod_UnidadMedida)


        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataTable)

        Return _DataTable

        Me.Conexion.Close()

    End Function

    Public Function ObtenerCategorias() As DataTable

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataTable As New DataTable


        _Consulta = "Select * from Categoria order by Descripcion"

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataTable)

        Return _DataTable

        Me.Conexion.Close()
    End Function



    Public Function ObtenerMarcas() As DataTable

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataTable As New DataTable


        _Consulta = "Select * from Marca order by Descripcion"

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataTable)

        Return _DataTable

        Me.Conexion.Close()


    End Function


    Public Function ObtenerSubCategoria(ByVal Categoria As Categoria) As DataTable

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataTable As New DataTable

        _Consulta = "Select * from SubCategoria where Cod_Categoria=@Cod_Categoria order by Descripcion"
        Me.Conexion.Close()
        Me.Conexion.Open()

        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        _Comando.Parameters.AddWithValue("@Cod_Categoria", Categoria.Cod_Categoria)


        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataTable)

        Return _DataTable

        Me.Conexion.Close()


    End Function

    Public Function CargarArticulo(ByVal Articulo As Articulo) As Boolean

        Dim _Consulta As String
        Dim _Comando As New SqlCommand

        _Consulta = "insert into Articulo (Cod_Articulo_Proveedor,Descripcion,Cod_Unidad_Medida,Cod_SubUnidad_Medida,Precio,Cod_Categoria,Cod_SubCategoria,Cod_Marca,Stock) values (@Cod_Articulo_Proveedor,@Descripcion,@Cod_Unidad_Medida, @Cod_SubUnidad_Medida, @Precio,@Cod_Categoria, @Cod_SubCategoria, @Cod_Marca, @Stock)"

        Try
            Me.Conexion.Close()
            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Cod_Articulo_Proveedor", Articulo.Cod_Articulo_Proveedor)
            _Comando.Parameters.AddWithValue("@Descripcion", Articulo.Descripcion)
            _Comando.Parameters.AddWithValue("@Cod_Unidad_Medida", Articulo.Cod_Unidad_Medida)
            _Comando.Parameters.AddWithValue("@Cod_SubUnidad_Medida", Articulo.Cod_SubUnidad_Medida)
            _Comando.Parameters.AddWithValue("@Precio", Articulo.Precio)
            _Comando.Parameters.AddWithValue("@Cod_Categoria", Articulo.Cod_Categoria)
            _Comando.Parameters.AddWithValue("@Cod_SubCategoria", Articulo.Cod_SubCategoria)
            _Comando.Parameters.AddWithValue("@Cod_Marca", Articulo.Cod_Marca)
            _Comando.Parameters.AddWithValue("@Stock", Articulo.Stock)
            '_Comando.Parameters.AddWithValue("@Imagen", Articulo.Imagen)

            _Comando.ExecuteNonQuery()

            MsgBox("Se ha cargado correctamente el artículo " + Articulo.Descripcion, MsgBoxStyle.Information, "INFORMACION")

            Return True
        Catch ex As Exception
            MsgBox("ERROR AL CARGAR ARTICULO", MsgBoxStyle.Critical)
            Return False
        Finally
            Me.Conexion.Close()
        End Try










    End Function


    Public Function ObtenerTodosArticulos() As DataSet

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DatSet As New DataSet

        _Consulta = "Select A.Cod_Articulo as Codigo, A.Cod_Articulo_Proveedor AS 'CodigoBarras', A.Descripcion, M.Descripcion as 'Marca', SU.Descripcion as 'Sub Unidad', A.Precio, SC.Descripcion 'Sub Categoria', C.Descripcion as 'Categoria' from Articulo as A, Marca as M, Unidad_Medida as U, SubUnidad_Medida as SU, Categoria as C, SubCategoria as SC Where U.Cod_Unidad_Medida = A.Cod_Unidad_Medida And SU.Cod_SubUnidad_Medida = A.Cod_SubUnidad_Medida and "
        _Consulta += "M.Cod_Marca=A.Cod_Marca and C.Cod_Categoria=A.Cod_Categoria and SC.Cod_SubCategoria=A.Cod_SubCategoria ORDER BY A.Descripcion"

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DatSet)

        Return _DatSet

        Me.Conexion.Close()

    End Function



    Public Function ObtenerPrimerosArticulos() As DataSet
        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DatSet As New DataSet

        _Consulta = "Select top 50 A.Cod_Articulo as Codigo, A.Cod_Articulo_Proveedor AS 'CodigoBarras', A.Descripcion, M.Descripcion as 'Marca', SU.Descripcion as 'Sub Unidad', A.Precio, SC.Descripcion 'Sub Categoria', C.Descripcion as 'Categoria' from Articulo as A, Marca as M, Unidad_Medida as U, SubUnidad_Medida as SU, Categoria as C, SubCategoria as SC Where U.Cod_Unidad_Medida = A.Cod_Unidad_Medida And SU.Cod_SubUnidad_Medida = A.Cod_SubUnidad_Medida and "
        _Consulta += "M.Cod_Marca=A.Cod_Marca and C.Cod_Categoria=A.Cod_Categoria and SC.Cod_SubCategoria=A.Cod_SubCategoria ORDER BY A.Descripcion"

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DatSet)

        Return _DatSet

        Me.Conexion.Close()
    End Function

    Public Function ObtenerArticuloConID(ByVal articulo As Articulo) As Articulo
        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataSet As New DataSet

        _Consulta = "Select * from Articulo where Cod_Articulo=@Cod_Articulo"

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Comando = New SqlCommand(_Consulta, Me.Conexion)
        _Comando.Parameters.AddWithValue("@Cod_Articulo", articulo.Cod_Articulo)



        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataSet)

        articulo.Cod_Articulo_Proveedor = _DataSet.Tables(0).Rows(0).Item("Cod_Articulo_Proveedor")
        articulo.Descripcion = _DataSet.Tables(0).Rows(0).Item("Descripcion")
        articulo.Cod_Unidad_Medida = _DataSet.Tables(0).Rows(0).Item("Cod_Unidad_Medida")
        articulo.Cod_SubUnidad_Medida = _DataSet.Tables(0).Rows(0).Item("Cod_SubUnidad_Medida")
        articulo.Precio = _DataSet.Tables(0).Rows(0).Item("Precio")
        articulo.Cod_Categoria = _DataSet.Tables(0).Rows(0).Item("Cod_Categoria")
        articulo.Cod_SubCategoria = _DataSet.Tables(0).Rows(0).Item("Cod_SubCategoria")
        articulo.Cod_Marca = _DataSet.Tables(0).Rows(0).Item("Cod_Marca")
        articulo.Stock = _DataSet.Tables(0).Rows(0).Item("Stock")

        Return articulo

        Conexion.Close()

    End Function

    Public Function BuscarArticuloPorCodigoBarras(ByVal articulo As Articulo) As DataSet
        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataSet As New DataSet

        _Consulta = "Select A.Cod_Articulo as Codigo, A.Cod_Articulo_Proveedor AS 'CodigoBarras', A.Descripcion, M.Descripcion as 'Marca',SU.Descripcion as 'Sub Unidad', A.Precio, SC.Descripcion 'Sub Categoria', C.Descripcion as 'Categoria' from Articulo as A, Marca as M, Unidad_Medida as U, SubUnidad_Medida as SU, Categoria as C, SubCategoria as SC Where U.Cod_Unidad_Medida = A.Cod_Unidad_Medida And SU.Cod_SubUnidad_Medida = A.Cod_SubUnidad_Medida and "
        _Consulta += "M.Cod_Marca=A.Cod_Marca and C.Cod_Categoria=A.Cod_Categoria and SC.Cod_SubCategoria=A.Cod_SubCategoria and A.Cod_Articulo_Proveedor=" & articulo.Cod_Articulo_Proveedor & " ORDER BY A.Descripcion"

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Comando = New SqlCommand(_Consulta, Me.Conexion)
        _Comando.Parameters.AddWithValue("@Cod_Articulo", articulo.Cod_Articulo)



        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataSet)



        Return _DataSet

        Conexion.Close()
    End Function





    Public Function BuscarArticuloPorCodigo(ByVal articulo As Articulo) As ArticuloParaPresupuesto
        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _ArticuloParaPresupuesto As New ArticuloParaPresupuesto
        Dim _DataSet As New DataSet

        _Consulta = "Select A.Cod_Articulo as Codigo, A.Cod_Articulo_Proveedor AS 'CodigoBarras', A.Descripcion, M.Descripcion as 'Marca',SU.Descripcion as 'Sub Unidad', A.Precio, SC.Descripcion 'Sub Categoria', C.Descripcion as 'Categoria' from Articulo as A, Marca as M, Unidad_Medida as U, SubUnidad_Medida as SU, Categoria as C, SubCategoria as SC Where U.Cod_Unidad_Medida = A.Cod_Unidad_Medida And SU.Cod_SubUnidad_Medida = A.Cod_SubUnidad_Medida and "
        _Consulta += "M.Cod_Marca=A.Cod_Marca and C.Cod_Categoria=A.Cod_Categoria and SC.Cod_SubCategoria=A.Cod_SubCategoria and A.Cod_Articulo=@Cod_Articulo"

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Comando = New SqlCommand(_Consulta, Me.Conexion)
        _Comando.Parameters.AddWithValue("@Cod_Articulo", articulo.Cod_Articulo)


        

        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataSet)

        _ArticuloParaPresupuesto.Cod_Articulo = _DataSet.Tables(0).Rows(0).Item("Codigo")
        _ArticuloParaPresupuesto.Cod_Articulo_Proveedor = _DataSet.Tables(0).Rows(0).Item("CodigoBarras")
        _ArticuloParaPresupuesto.Descripcion = _DataSet.Tables(0).Rows(0).Item("Descripcion")
        _ArticuloParaPresupuesto.Marca = _DataSet.Tables(0).Rows(0).Item("Marca")
        _ArticuloParaPresupuesto.SubUnidad_Medida = _DataSet.Tables(0).Rows(0).Item("Sub Unidad")
        _ArticuloParaPresupuesto.Precio = Convert.ToDecimal(_DataSet.Tables(0).Rows(0).Item("Precio"))


        Return _ArticuloParaPresupuesto

        Conexion.Close()
    End Function
    Public Sub ActualizarArticulo(ByVal articulo As Articulo)
        Dim _Consulta As String
        Dim _Comando As SqlCommand

        Try
            _Consulta = "Update Articulo set Cod_Articulo_Proveedor=@Cod_Articulo_Proveedor, Descripcion=@Descripcion, Cod_Unidad_Medida=@Cod_Unidad_Medida, Cod_SubUnidad_Medida=@Cod_SubUnidad_Medida, Precio=@Precio, Cod_Categoria=@Cod_Categoria, Cod_SubCategoria=@Cod_SubCategoria, Cod_Marca=@Cod_Marca, Stock=@Stock where Cod_Articulo=@Cod_Articulo"

            Me.Conexion.Close()
            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Cod_Articulo", articulo.Cod_Articulo)
            _Comando.Parameters.AddWithValue("@Cod_Articulo_Proveedor", articulo.Cod_Articulo_Proveedor)
            _Comando.Parameters.AddWithValue("@Descripcion", articulo.Descripcion)
            _Comando.Parameters.AddWithValue("@Cod_Unidad_Medida", articulo.Cod_Unidad_Medida)
            _Comando.Parameters.AddWithValue("@Cod_SubUnidad_Medida", articulo.Cod_SubUnidad_Medida)
            _Comando.Parameters.AddWithValue("@Precio", articulo.Precio)
            _Comando.Parameters.AddWithValue("@Cod_Categoria", articulo.Cod_Categoria)
            _Comando.Parameters.AddWithValue("@Cod_SubCategoria", articulo.Cod_SubCategoria)
            _Comando.Parameters.AddWithValue("@Cod_Marca", articulo.Cod_Marca)
            _Comando.Parameters.AddWithValue("@Stock", articulo.Stock)


            _Comando.ExecuteNonQuery()




            MsgBox("Se he modificado correctamente el articulo " + articulo.Descripcion, MsgBoxStyle.Information, "INFORMACIÓN")


        Catch ex As Exception

        End Try




        Me.Conexion.Close()
    End Sub


    Public Function BuscarArticuloPorNombre(ByVal articulo As Articulo) As DataSet
        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _dataSet As New DataSet

        _Consulta = "Select A.Cod_Articulo as Codigo, A.Cod_Articulo_Proveedor AS 'CodigoBarras', A.Descripcion , M.Descripcion as 'Marca' ,SU.Descripcion as 'Sub Unidad', A.Precio, SC.Descripcion 'Sub Categoria',C.Descripcion as 'Categoria' from Articulo as A, Marca as M, Unidad_Medida as U, SubUnidad_Medida as SU, Categoria as C, SubCategoria as SC Where U.Cod_Unidad_Medida = A.Cod_Unidad_Medida And SU.Cod_SubUnidad_Medida = A.Cod_SubUnidad_Medida and "
        _Consulta += "M.Cod_Marca=A.Cod_Marca and C.Cod_Categoria=A.Cod_Categoria and SC.Cod_SubCategoria=A.Cod_SubCategoria and A.Descripcion like '%" + articulo.Descripcion + "%' order by A.Descripcion"


        ' _Consulta = "Select A.Cod_Articulo as Codigo, A.Cod_Articulo_Proveedor AS 'CodigoBarras', A.Descripcion , M.Descripcion as 'Marca', U.Descripcion as 'Unidad Medida' ,SU.Descripcion as 'Sub Unidad', A.Precio, SC.Descripcion 'Sub Categoria',C.Descripcion as 'Categoria' from Articulo as A, Marca as M, Unidad_Medida as U, SubUnidad_Medida as SU, Categoria as C, SubCategoria as SC Where U.Cod_Unidad_Medida = A.Cod_Unidad_Medida And SU.Cod_SubUnidad_Medida = A.Cod_SubUnidad_Medida and "
        '_Consulta += "M.Cod_Marca=A.Cod_Marca and C.Cod_Categoria=A.Cod_Categoria and SC.Cod_SubCategoria=A.Cod_SubCategoria and A.Descripcion like '%" + articulo.Descripcion + "%' order by A.Descripcion"


        Me.Conexion.Close()
        Me.Conexion.Open()



        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        '_Comando.Parameters.AddWithValue("@Descripcion", articulo.Descripcion)

        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_dataSet)

        Return _dataSet

        Me.Conexion.Close()

    End Function




    Public Function ObtenerArticuloPorMarca(ByVal marca As Marca) As DataTable


        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataTable As New DataTable

        _Consulta = "Select A.Cod_Articulo as Codigo, A.Cod_Articulo_Proveedor AS 'CodigoBarras', A.Descripcion, M.Descripcion as 'Marca', SU.Descripcion as 'Sub Unidad', A.Precio, SC.Descripcion 'Sub Categoria', C.Descripcion as 'Categoria' from Articulo as A, Marca as M, Unidad_Medida as U, SubUnidad_Medida as SU, Categoria as C, SubCategoria as SC Where A.Cod_Marca=@Cod_Marca and U.Cod_Unidad_Medida = A.Cod_Unidad_Medida And SU.Cod_SubUnidad_Medida = A.Cod_SubUnidad_Medida and "
        _Consulta += "M.Cod_Marca=A.Cod_Marca and C.Cod_Categoria=A.Cod_Categoria and SC.Cod_SubCategoria=A.Cod_SubCategoria ORDER BY A.Descripcion"

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Comando = New SqlCommand(_Consulta, Me.Conexion)
        _Comando.Parameters.AddWithValue("@Cod_Marca", marca.Cod_Marca)
        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataTable)

        Return _DataTable

        Me.Conexion.Close()



    End Function

    Public Function ObtenerArticuloPorSubCategoria(ByVal subcategoria As SubCategoria) As DataTable


        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataTable As New DataTable

        _Consulta = "Select A.Cod_Articulo as Codigo, A.Cod_Articulo_Proveedor AS 'CodigoBarras', A.Descripcion, M.Descripcion as 'Marca', SU.Descripcion as 'Sub Unidad', A.Precio, SC.Descripcion 'Sub Categoria', C.Descripcion as 'Categoria' from Articulo as A, Marca as M, Unidad_Medida as U, SubUnidad_Medida as SU, Categoria as C, SubCategoria as SC Where A.Cod_SubCategoria=@Cod_SubCategoria and U.Cod_Unidad_Medida = A.Cod_Unidad_Medida And SU.Cod_SubUnidad_Medida = A.Cod_SubUnidad_Medida and "
        _Consulta += "M.Cod_Marca=A.Cod_Marca and C.Cod_Categoria=A.Cod_Categoria and SC.Cod_SubCategoria=A.Cod_SubCategoria ORDER BY A.Descripcion"

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Comando = New SqlCommand(_Consulta, Me.Conexion)
        _Comando.Parameters.AddWithValue("@Cod_SubCategoria", subcategoria.Cod_SubCategoria)
        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataTable)

        Return _DataTable

        Me.Conexion.Close()



    End Function


    Public Function ObtenenrArticulosPorCategoria(ByVal categoria As Categoria) As DataTable

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataTable As New DataTable

        _Consulta = "Select A.Cod_Articulo as Codigo, A.Cod_Articulo_Proveedor AS 'CodigoBarras', A.Descripcion, M.Descripcion as 'Marca', SU.Descripcion as 'Sub Unidad', A.Precio, SC.Descripcion 'Sub Categoria', C.Descripcion as 'Categoria' from Articulo as A, Marca as M, Unidad_Medida as U, SubUnidad_Medida as SU, Categoria as C, SubCategoria as SC Where A.Cod_Categoria=@Cod_Categoria and U.Cod_Unidad_Medida = A.Cod_Unidad_Medida And SU.Cod_SubUnidad_Medida = A.Cod_SubUnidad_Medida and "
        _Consulta += "M.Cod_Marca=A.Cod_Marca and C.Cod_Categoria=A.Cod_Categoria and SC.Cod_SubCategoria=A.Cod_SubCategoria ORDER BY A.Descripcion"

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Comando = New SqlCommand(_Consulta, Me.Conexion)
        _Comando.Parameters.AddWithValue("@Cod_Categoria", categoria.Cod_Categoria)
        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataTable)

        Return _DataTable

        Me.Conexion.Close()
    End Function


    Public Sub ActualizarPrecio(ByVal Articulo As Articulo)


        Dim _Consulta As String
        Dim _Comando As SqlCommand

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Consulta = "Update Articulo set Precio=@Precio where Cod_Articulo=@Cod_Articulo"

        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        _Comando.Parameters.AddWithValue("@Precio", Articulo.Precio)
        _Comando.Parameters.AddWithValue("Cod_Articulo", Articulo.Cod_Articulo)


        _Comando.ExecuteNonQuery()

        Me.Conexion.Close()

    End Sub




    Public Sub MovimientoPrecios(ByVal articulo As Articulo, Fecha As Date)

        Dim _Consulta As String
        Dim _Comando As SqlCommand

        _Consulta = "Insert into MovimientoPrecios (Cod_Articulo, Precio, Fecha) values (@Cod_Articulo, @Precio, @Fecha)"

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        _Comando.Parameters.AddWithValue("@Cod_Articulo", articulo.Cod_Articulo)
        _Comando.Parameters.AddWithValue("Precio", articulo.Precio)
        _Comando.Parameters.AddWithValue("Fecha", Fecha)

        _Comando.ExecuteNonQuery()

        Me.Conexion.Close()

    End Sub



    Public Function ObtenerIdDeArticulo() As Articulo

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim Articulo As New Articulo

        _Consulta = "select MAX(cod_articulo) from Articulo"

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        Articulo.Cod_Articulo = _Comando.ExecuteScalar

        Return Articulo

        Me.Conexion.Close()

    End Function



    Public Function ObtenerPreciosHistoricosPorDescripcion(ByVal articulo As Articulo) As DataSet
        Dim _Comando As New SqlCommand
        Dim _DataSet As New DataSet
        Dim _Consulta As String




        _Consulta = "Select id_Movimiento as ID, Mo.Cod_Articulo as Codigo, A.Cod_Articulo_Proveedor AS 'CodigoBarras', A.Descripcion, M.Descripcion as 'Marca', SU.Descripcion as 'Sub Unidad', Mo.Precio, SC.Descripcion 'Sub Categoria', C.Descripcion as 'Categoria', Mo.Fecha from MovimientoPrecios as Mo, Articulo as A, Marca as M, Unidad_Medida as U, SubUnidad_Medida as SU, Categoria as C, SubCategoria as SC Where U.Cod_Unidad_Medida = A.Cod_Unidad_Medida And SU.Cod_SubUnidad_Medida = A.Cod_SubUnidad_Medida and M.Cod_Marca=A.Cod_Marca and C.Cod_Categoria=A.Cod_Categoria and SC.Cod_SubCategoria=A.Cod_SubCategoria and Mo.Cod_Articulo=A.Cod_Articulo and A.Descripcion like '%" + articulo.Descripcion + "%' ORDER BY Mo.Fecha DESC"

        Me.Conexion.Close()
        Me.Conexion.Open()
        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataSet)


        Return _DataSet



        Me.Conexion.Close()


    End Function

    Public Function ObtenerPreciosHistoricosPorCodigo(ByVal articulo As Articulo) As DataSet
        Dim _Comando As New SqlCommand
        Dim _DataSet As New DataSet
        Dim _Consulta As String




        _Consulta = "Select id_Movimiento as ID, Mo.Cod_Articulo as Codigo, A.Cod_Articulo_Proveedor AS 'CodigoBarras', A.Descripcion, M.Descripcion as 'Marca', SU.Descripcion as 'Sub Unidad', Mo.Precio, SC.Descripcion 'Sub Categoria', C.Descripcion as 'Categoria', Mo.Fecha from MovimientoPrecios as Mo, Articulo as A, Marca as M, Unidad_Medida as U, SubUnidad_Medida as SU, Categoria as C, SubCategoria as SC Where U.Cod_Unidad_Medida = A.Cod_Unidad_Medida And SU.Cod_SubUnidad_Medida = A.Cod_SubUnidad_Medida and M.Cod_Marca=A.Cod_Marca and C.Cod_Categoria=A.Cod_Categoria and SC.Cod_SubCategoria=A.Cod_SubCategoria and Mo.Cod_Articulo=A.Cod_Articulo and A.Cod_Articulo_Proveedor =" & articulo.Cod_Articulo_Proveedor & " ORDER BY Mo.Fecha DESC"

        Me.Conexion.Close()
        Me.Conexion.Open()
        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataSet)


        Return _DataSet



        Me.Conexion.Close()


    End Function

    Public Sub CopiarArticulo(Articulo)

        Dim _Consulta As String
        Dim _Comando As SqlCommand

        _Consulta = "insert into ArticulosEliminados (Cod_Articulo,Cod_Articulo_Proveedor,Descripcion,Cod_Unidad_Medida,Cod_SubUnidad_Medida,Precio,Cod_Categoria,Cod_SubCategoria,Cod_Marca,Stock ) select Cod_Articulo,Cod_Articulo_Proveedor,Descripcion,Cod_Unidad_Medida,Cod_SubUnidad_Medida,Precio,Cod_Categoria,Cod_SubCategoria,Cod_Marca,Stock from Articulo where Cod_Articulo=@Cod_Articulo"

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        _Comando.Parameters.AddWithValue("@Cod_Articulo", Articulo.Cod_Articulo)
        

        _Comando.ExecuteNonQuery()

        Me.Conexion.Close()


    End Sub



    Public Sub EliminarArticulo(Articulo)



        Dim _Consulta As String
        Dim _Comando As SqlCommand

        _Consulta = "Delete from Articulo where Cod_Articulo=@Cod_Articulo"

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        _Comando.Parameters.AddWithValue("@Cod_Articulo", Articulo.Cod_Articulo)


        _Comando.ExecuteNonQuery()

        Me.Conexion.Close()




    End Sub

    Public Function ObtenerArticulosEliminados() As DataSet

Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DatSet As New DataSet

        _Consulta = "Select ae.Id_Eliminado, Ae.Cod_Articulo as Codigo, Ae.Cod_Articulo_Proveedor AS 'CodigoBarras', Ae.Descripcion, M.Descripcion as 'Marca', SU.Descripcion as 'Sub Unidad', Ae.Precio, SC.Descripcion 'Sub Categoria', C.Descripcion as 'Categoria' from ArticulosEliminados as Ae, Marca as M, Unidad_Medida as U, SubUnidad_Medida as SU, Categoria as C, SubCategoria as SC Where U.Cod_Unidad_Medida = Ae.Cod_Unidad_Medida And SU.Cod_SubUnidad_Medida = Ae.Cod_SubUnidad_Medida and "
        _Consulta += "M.Cod_Marca=Ae.Cod_Marca and C.Cod_Categoria=Ae.Cod_Categoria and SC.Cod_SubCategoria=Ae.Cod_SubCategoria ORDER BY Ae.Descripcion"

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DatSet)

        Return _DatSet

        Me.Conexion.Close()


    End Function


    Public Function ObtenerModificacionesTop50() As DataTable
        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataTable As New DataTable

        _Consulta = "Select  top 50 AUDIT_LOG_DATA_ID as IDviejo, KEY1  as Codigo, COL_NAME as 'Dato Modificado',NEW_VALUE as 'Valor Nuevo',OLD_VALUE as 'Valor Viejo'  from AUDIT_LOG_DATA order by IDviejo desc"

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataTable)

        Return _DataTable

        Me.Conexion.Close()

    End Function
End Class
