Public Class Kardex
    Private mid_kardex As Integer
    Private mfecha As Date
    Private mnumero_documento As String
    Private mserie_documento As String
    Private mruc_dni As String
    Private mNombre As String
    Private mid_tipodocumento As String
    Private mid_producto As Integer
    Private mid_almacen As Integer
    Private mid_sucursal As Integer
    Private mid_movimiento As Integer
    Private mstock As Integer
    Private mcantidad As Integer
    Private mprecio As Double
    Private mDescuentro As Double
    Private mtipo As String
    Private mtotal As Double
    Private mTipo_Pago As String
    Private mpago_inicial As Double
    Private mmonto_financiado As Double
    Private mnro_cuotas As Integer
    Private mMonto_cuota As Double
    Private msubtotal As Double
    Private migv As Double
    Private mid_compra As Integer
    Private mSub_Total As Double
    Public Property id_kardex() As Integer
        Get
            Return mid_kardex
        End Get
        Set(ByVal value As Integer)
            mid_kardex = value
        End Set
    End Property
    Public Property fecha() As Date
        Get
            Return mfecha
        End Get
        Set(ByVal value As Date)
            mfecha = value
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
    Public Property ruc_dni() As String
        Get
            Return mruc_dni
        End Get
        Set(ByVal value As String)
            mruc_dni = value
        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return mNombre
        End Get
        Set(ByVal value As String)
            mNombre = value
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
    Public Property id_producto() As Integer
        Get
            Return mid_producto
        End Get
        Set(ByVal value As Integer)
            mid_producto = value
        End Set
    End Property
    Public Property id_movimiento() As Integer
        Get
            Return mid_movimiento
        End Get
        Set(ByVal value As Integer)
            mid_movimiento = value
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
    Public Property cantidad() As Integer
        Get
            Return mcantidad
        End Get
        Set(ByVal value As Integer)
            mcantidad = value
        End Set
    End Property
    Public Property precio() As Double
        Get
            Return mprecio
        End Get
        Set(ByVal value As Double)
            mprecio = value
        End Set
    End Property
    Public Property Descuentro() As Double
        Get
            Return mDescuentro
        End Get
        Set(ByVal value As Double)
            mDescuentro = value
        End Set
    End Property
    Public Property tipo() As String
        Get
            Return mtipo
        End Get
        Set(ByVal value As String)
            mtipo = value
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
    Public Property Tipo_Pago() As String
        Get
            Return mTipo_Pago
        End Get
        Set(ByVal value As String)
            mTipo_Pago = value
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
    Public Property id_compra() As Integer
        Get
            Return mid_compra
        End Get
        Set(ByVal value As Integer)
            mid_compra = value
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
