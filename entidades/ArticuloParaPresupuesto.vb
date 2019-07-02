Public Class ArticuloParaPresupuesto

    Private _Cod_Articulo As Long
    Private _Cod_Articulo_Proveedor As Long
    Private _Descripcion As String
    Private _Marca As String
    Private _SubUnidad_Medida As String
    Private _Precio As Decimal


    Public Property Cod_Articulo As Long
        Get
            Return _Cod_Articulo
        End Get
        Set(value As Long)
            _Cod_Articulo = value
        End Set
    End Property



    Public Property Cod_Articulo_Proveedor As Long
        Get
            Return _Cod_Articulo_Proveedor
        End Get
        Set(value As Long)
            _Cod_Articulo_Proveedor = value
        End Set
    End Property



    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property


    Public Property Marca As String
        Get
            Return _Marca
        End Get
        Set(value As String)
            _Marca = value
        End Set
    End Property

    Public Property SubUnidad_Medida As String
        Get
            Return _SubUnidad_Medida
        End Get
        Set(value As String)
            _SubUnidad_Medida = value
        End Set
    End Property


    Public Property Precio As Decimal
        Get
            Return _Precio
        End Get
        Set(value As Decimal)
            _Precio = value
        End Set
    End Property

End Class
