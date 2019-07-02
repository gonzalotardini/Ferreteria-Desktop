Public Class SubCategoria

    Private _Cod_SubCategoria As Integer
    Private _Cod_Categoria As Integer
    Private _Descripcion As String


    Public Property Cod_SubCategoria As Integer
        Get
            Return _Cod_SubCategoria
        End Get
        Set(value As Integer)
            _Cod_SubCategoria = value
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

    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property


End Class
