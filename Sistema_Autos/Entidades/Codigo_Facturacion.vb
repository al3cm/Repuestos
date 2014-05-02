Public Class Codigo_Facturacion
    Private mid_Codigo As String
    Private mid_almacen As Integer
    Public Property id_Codigo() As String
        Get
            Return mid_Codigo
        End Get
        Set(ByVal value As String)
            mid_Codigo = value
        End Set
    End Property
    Public Property id_almacen() As Integer
        Get
            Return mid_almacen
        End Get
        Set(ByVal value As Integer)
            mid_almacen = value
        End Set
    End Property
    Public Sub New()

    End Sub
End Class
