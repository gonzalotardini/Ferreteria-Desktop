Public Class Articulo

    Private _Cod_Articulo As Integer
    Private _Cod_Articuolo_Proveedor As Long
    Private _Descripcion As String
    Private _Cod_Unidad_Medida As Integer
    Private _Cod_SubUnidad_Medida As Integer
    Private _Precio As Decimal
    Private _Cod_Categoria As Integer
    Private _Cod_SubCategoria As Integer
    Private _Cod_Marca As Integer
    Private _Stock As Integer
    Private _Imagen

    Public Property Cod_Articulo As Integer
        Get
            Return _Cod_Articulo
        End Get
        Set(value As Integer)
            _Cod_Articulo = value
        End Set
    End Property


    Public Property Cod_Articulo_Proveedor As Long
        Get
            Return _Cod_Articuolo_Proveedor
        End Get
        Set(value As Long)
            _Cod_Articuolo_Proveedor = value

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


    Public Property Cod_Unidad_Medida As Integer
        Get
            Return _Cod_Unidad_Medida
        End Get
        Set(value As Integer)
            _Cod_Unidad_Medida = value
        End Set
    End Property

    Public Property Cod_SubUnidad_Medida As Integer
        Get
            Return _Cod_SubUnidad_Medida
        End Get
        Set(value As Integer)
            _Cod_SubUnidad_Medida = value
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


    Public Property Cod_Categoria As Integer
        Get
            Return _Cod_Categoria
        End Get
        Set(value As Integer)
            _Cod_Categoria = value
        End Set
    End Property


    Public Property Cod_SubCategoria As Integer
        Get
            Return _Cod_SubCategoria
        End Get
        Set(value As Integer)
            _Cod_SubCategoria = value
        End Set
    End Property



    Public Property Cod_Marca As Integer
        Get
            Return _Cod_Marca
        End Get
        Set(value As Integer)
            _Cod_Marca = value
        End Set
    End Property


    Public Property Stock As Integer
        Get
            Return _Stock
        End Get
        Set(value As Integer)
            _Stock = value
        End Set
    End Property




    Public Property Imagen
        Get
            Return _Imagen
        End Get
        Set(value)
            _Imagen = value
        End Set
    End Property
End Class
