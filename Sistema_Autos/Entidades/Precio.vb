Public Class Precio
    Private mid_producto As Integer
    Private mid_almacen As Integer
    Private mprecio_compra As Double
    Private mprecio_venta As Double
    Private mprecio_trajecta As Double
    Public Property id_producto() As Integer
        Get
            Return mid_producto
        End Get
        Set(ByVal value As Integer)
            mid_producto = value
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
    Public Property precio_compra() As Double
        Get
            Return mprecio_compra
        End Get
        Set(ByVal value As Double)
            mprecio_compra = value
        End Set
    End Property
    Public Property precio_venta() As Double
        Get
            Return mprecio_venta
        End Get
        Set(ByVal value As Double)
            mprecio_venta = value
        End Set
    End Property
    Public Property precio_trajecta() As Double
        Get
            Return mprecio_trajecta
        End Get
        Set(ByVal value As Double)
            mprecio_trajecta = value
        End Set
    End Property
    Public Sub New()

    End Sub
End Class
