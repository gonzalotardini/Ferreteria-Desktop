Public Class PresupuestoCabecera

    Private _Cod_Presupuesto As Long
    Private _Nombre As String
    Private _Fecha As Date
    Private _Total As Decimal


    Public Property Cod_Presupuesto As Long
        Get
            Return _Cod_Presupuesto
        End Get
        Set(value As Long)
            _Cod_Presupuesto = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(value As Date)
            _Fecha = value
        End Set
    End Property

    Public Property Total As Decimal
        Get
            Return _Total
        End Get
        Set(value As Decimal)
            _Total = value
        End Set
    End Property


    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

End Class
