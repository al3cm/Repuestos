Public Class Orden_Venta
    Private mid_venta As Integer
    Private mid_Moneda As Integer
    Private mfecha_emision As Date
    Private mtotal As Double
    Private msubtotal As Double
    Private migv As Double
    Private mnumero_documento As String
    Private mserie_documento As String
    Private mTipo_Pago As String
    Private mtipo_cambio As Double
    Private mid_almacen As Integer
    Private mid_sucursal As Integer
    Private mid_personal As Integer
    Private mid_tipodocumento As String
    Private mid_cliente As Integer
    Private mpago_inicial As Double
    Private mmonto_financiado As Double
    Private mnro_cuotas As Integer
    Private mMonto_cuota As Double
    Private mid_producto As Integer
    Private mcantidad As Integer
    Private mprecio_venta As Double
    Private mdescuento As Double
    Private mSub_Total As Double
    Private mEstado As String
    Public Property id_venta() As Integer
        Get
            Return mid_venta
        End Get
        Set(ByVal value As Integer)
            mid_venta = value
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
    Public Property fecha_emision() As Date
        Get
            Return mfecha_emision
        End Get
        Set(ByVal value As Date)
            mfecha_emision = value
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
    Public Property id_personal() As Integer
        Get
            Return mid_personal
        End Get
        Set(ByVal value As Integer)
            mid_personal = value
        End Set
    End Property
    Public Property id_tipodocumento() As String
        Get
            Return mid_tipodocumento
        End Get
        Set(ByVal value As String)
            mid_tipodocumento = value
        End Set
    End Property
    Public Property id_cliente() As Integer
        Get
            Return mid_cliente
        End Get
        Set(ByVal value As Integer)
            mid_cliente = value
        End Set
    End Property
    Public Property pago_inicial() As Double
        Get
            Return mpago_inicial
        End Get
        Set(ByVal value As Double)
            mpago_inicial = value
        End Set
    End Property
    Public Property monto_financiado() As Double
        Get
            Return mmonto_financiado
        End Get
        Set(ByVal value As Double)
            mmonto_financiado = value
        End Set
    End Property
    Public Property nro_cuotas() As Integer
        Get
            Return mnro_cuotas
        End Get
        Set(ByVal value As Integer)
            mnro_cuotas = value
        End Set
    End Property
    Public Property Monto_cuota() As Double
        Get
            Return mMonto_cuota
        End Get
        Set(ByVal value As Double)
            mMonto_cuota = value
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
    Public Property precio_venta() As Double
        Get
            Return mprecio_venta
        End Get
        Set(ByVal value As Double)
            mprecio_venta = value
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
    Public Property Estado() As String
        Get
            Return mEstado
        End Get
        Set(ByVal value As String)
            mEstado = value
        End Set
    End Property
    Public Sub New()

    End Sub
End Class
