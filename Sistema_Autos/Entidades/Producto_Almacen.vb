Public Class Producto_Almacen
    Private mid_producto As Integer
    Private mid_almacen As Integer
    Private mid_sucursal As Integer
    Private mstock As Integer
    Private mdescripcion As String
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
    Public Property id_sucursal() As Integer
        Get
            Return mid_sucursal
        End Get
        Set(ByVal value As Integer)
            mid_sucursal = value
        End Set
    End Property
    Public Property stock() As Integer
        Get
            Return mstock
        End Get
        Set(ByVal value As Integer)
            mstock = value
        End Set
    End Property
    Public Property descripcion() As String
        Get
            Return mdescripcion
        End Get
        Set(ByVal value As String)
            mdescripcion = value
        End Set
    End Property
    Public Sub New()

    End Sub
End Class
