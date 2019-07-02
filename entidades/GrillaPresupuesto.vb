Public Class GrillaPresupuesto

    Private _Codigo As Long
    Private _Cantidad As Decimal
    Private _Descripcion As String
    Private _Marca As String
    Private _Medida As String
    Private _Precio As Decimal
    Private _Importe As Decimal



    Public Property Codigo As Long
        Get
            Return _Codigo

        End Get
        Set(value As Long)
            _Codigo = value

        End Set
    End Property




    Public Property Cantidad As Decimal
        Get
            Return _Cantidad

        End Get
        Set(value As Decimal)
            _Cantidad = value

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

    Public Property Medida As String
        Get
            Return _Medida

        End Get
        Set(value As String)
            _Medida = value

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

    Public Property Importe As Decimal
        Get
            Return _Importe

        End Get
        Set(value As Decimal)
            _Importe = value

        End Set
    End Property
End Class
