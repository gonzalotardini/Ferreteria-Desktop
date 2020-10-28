Public Class ArticuloParaEmail

    Private _Cod_Articulo As Integer
    Private _Descripcion As String
    Private _Descripcion_SubUnidad As String
    Private _Precio_Anterior As Decimal
    Private _Precio As Decimal


    Public Property Cod_Articulo As Integer
        Get
            Return _Cod_Articulo
        End Get
        Set(value As Integer)
            _Cod_Articulo = value
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


    Public Property Precio As Decimal
        Get
            Return _Precio
        End Get
        Set(value As Decimal)
            _Precio = value
        End Set
    End Property

    Public Property Descripcion_SubUnidad As String
        Get
            Return _Descripcion_SubUnidad
        End Get
        Set(value As String)
            _Descripcion_SubUnidad = value
        End Set
    End Property
    Public Property Precio_Anterior As Decimal
        Get
            Return _Precio_Anterior
        End Get
        Set(value As Decimal)
            _Precio_Anterior = value
        End Set
    End Property

End Class
