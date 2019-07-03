Public Class PresupuestoDetalle

    Private _Cod_Presupuesto As Long
    Private _Cod_Articulo As Integer
    Private _Cantidad As Decimal
    Private _Descripcion As String
    Private _Precio As Decimal
    Private _Importe As Decimal
    Private _SubTotal As Decimal
    Private _Iva As Decimal



    Public Property Cod_Presupuesto As Long
        Get
            Return _Cod_Presupuesto
        End Get
        Set(value As Long)
            _Cod_Presupuesto = value
        End Set
    End Property



    Public Property Cod_Articulo As String
        Get
            Return _Cod_Articulo
        End Get
        Set(value As String)
            _Cod_Articulo = value
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


    Public Property SubTotal As Decimal
        Get
            Return _SubTotal
        End Get
        Set(value As Decimal)
            _SubTotal = value
        End Set
    End Property


    Public Property Iva As Decimal
        Get
            Return _Iva
        End Get
        Set(value As Decimal)
            _Iva = value
        End Set
    End Property
End Class
