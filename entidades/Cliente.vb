Public Class Cliente

    Private _Cod_Cliente As Integer
    Private _Razon_Social As String
    Private _Cuit As Long
    Private _Direccion As String
    Private _Localidad As String
    Private _Telefono As String
    Private _Email As String



    Public Property Cod_Cliente As Integer
        Get
            Return _Cod_Cliente
        End Get
        Set(value As Integer)
            _Cod_Cliente = value
        End Set
    End Property


    Public Property Razon_Social As String
        Get
            Return _Razon_Social
        End Get
        Set(value As String)
            _Razon_Social = value
        End Set
    End Property


    Public Property Cuit As Long
        Get
            Return _Cuit
        End Get
        Set(value As Long)
            _Cuit = value
        End Set
    End Property


    Public Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(value As String)
            _Direccion = value
        End Set
    End Property

    Public Property Localidad As String
        Get
            Return _Localidad
        End Get
        Set(value As String)
            _Localidad = value
        End Set
    End Property



    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property


    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property


End Class
