Public Class Marca
    Private _Cod_Marca As Integer
    Private _Descripcion As String



    Public Property Cod_Marca As Integer
        Get
            Return _Cod_Marca

        End Get
        Set(value As Integer)
            _Cod_Marca = value

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
