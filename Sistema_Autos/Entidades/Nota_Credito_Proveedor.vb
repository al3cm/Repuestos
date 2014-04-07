Public Class Nota_Credito_Proveedor
    Private mid_nota_credito As Integer
    Private mnro_nota_credito As String
    Private mserie_nota_credito As String
    Private mMotivo As String
    Private mid_tipodocumento As String
    Private mfecha_emision As Date
    Private mtotal As Double
    Private msubtotal As Double
    Private migv As Double
    Private mSaldo_Pendiente As Double
    Private mid_compra As Integer
    Private mid_producto As Integer
    Private mcantidad As Integer
    Private mprecio_compra As Double
    Private mdescuento As Double
    Private mSub_Total As Double
    Public Property id_nota_credito() As Integer
        Get
            Return mid_nota_credito
        End Get
        Set(ByVal value As Integer)
            mid_nota_credito = value
        End Set
    End Property
    Public Property nro_nota_credito() As String
        Get
            Return mnro_nota_credito
        End Get
        Set(ByVal value As String)
            mnro_nota_credito = value
        End Set
    End Property
    Public Property serie_nota_credito() As String
        Get
            Return mserie_nota_credito
        End Get
        Set(ByVal value As String)
            mserie_nota_credito = value
        End Set
    End Property
    Public Property Motivo() As String
        Get
            Return mMotivo
        End Get
        Set(ByVal value As String)
            mMotivo = value
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
    Public Property Saldo_Pendiente() As Double
        Get
            Return mSaldo_Pendiente
        End Get
        Set(ByVal value As Double)
            mSaldo_Pendiente = value
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
