Public Class UnidadMedida
    Private _Cod_Unidad_Medida As Integer
    Private _Descripcion As String

    Public Property Cod_UnidadMedida As Integer
        Get
            Return _Cod_Unidad_Medida
        End Get
        Set(value As Integer)
            _Cod_Unidad_Medida = value
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


End Class
