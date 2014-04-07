Public Class Orden_Compra
    Private mid_compra As Integer
    Private mid_Moneda As Integer
    Private mfecha_compra As Date
    Private mtotal As Double
    Private msubtotal As Double
    Private migv As Double
    Private mnumero_documento As String
    Private mserie_documento As String
    Private mTipo_Pago As String
    Private mtipo_cambio As Double
    Private mid_almacen As Integer
    Private mid_sucursal As Integer
    Private mdescripcion As String
    Private mid_proveedor As Integer
    Private mid_producto As Integer
    Private mcantidad As Integer
    Private mprecio_compra As Double
    Private mdescuento As Double
    Private mSub_Total As Double
    Public Property id_compra() As Integer
        Get
            Return mid_compra
        End Get
        Set(ByVal value As Integer)
            mid_compra = value
        End Set
    End Property
    Public Property id_Moneda() As Integer
        Get
            Return mid_Moneda
        End Get
        Set(ByVal value As Integer)
            mid_Moneda = value
        End Set
    End Property
    Public Property fecha_compra() As Date
        Get
            Return mfecha_compra
        End Get
        Set(ByVal value As Date)
            mfecha_compra = value
        End Set
    End Property
    Public Property total() As Double
        Get
            Return mtotal
        End Get
        Set(ByVal value As Double)
            mtotal = value
        End Set
    End Property
    Public Property subtotal() As Double
        Get
            Return msubtotal
        End Get
        Set(ByVal value As Double)
            msubtotal = value
        End Set
    End Property
    Public Property igv() As Double
        Get
            Return migv
        End Get
        Set(ByVal value As Double)
            migv = value
        End Set
    End Property
    Public Property numero_documento() As String
        Get
            Return mnumero_documento
        End Get
        Set(ByVal value As String)
            mnumero_documento = value
        End Set
    End Property
    Public Property serie_documento() As String
        Get
            Return mserie_documento
        End Get
        Set(ByVal value As String)
            mserie_documento = value
        End Set
    End Property
    Public Property Tipo_Pago() As String
        Get
            Return mTipo_Pago
        End Get
        Set(ByVal value As String)
            mTipo_Pago = value
        End Set
    End Property
    Public Property tipo_cambio() As Double
        Get
            Return mtipo_cambio
        End Get
        Set(ByVal value As Double)
            mtipo_cambio = value
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
    Public Property descripcion() As String
        Get
            Return mdescripcion
        End Get
        Set(ByVal value As String)
            mdescripcion = value
        End Set
    End Property
    Public Property id_proveedor() As Integer
        Get
            Return mid_proveedor
        End Get
        Set(ByVal value As Integer)
            mid_proveedor = value
        End Set
    End Property
    Public Property id_producto() As Integer
        Get
            Return mid_producto
        End Get
        Set(ByVal value As Integer)
            mid_producto = value
        End Set
    End Property
    Public Property cantidad() As Integer
        Get
            Return mcantidad
        End Get
        Set(ByVal value As Integer)
            mcantidad = value
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
    Public Property descuento() As Double
        Get
            Return mdescuento
        End Get
        Set(ByVal value As Double)
            mdescuento = value
        End Set
    End Property
    Public Property Sub_Total() As Double
        Get
            Return mSub_Total
        End Get
        Set(ByVal value As Double)
            mSub_Total = value
        End Set
    End Property
    Public Sub New()

    End Sub
End Class
