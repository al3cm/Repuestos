Public Class Facturacion
    Private mid_movimiento As Integer
    Private mid_caja As Integer
    Private mId_Operacion As Integer
    Private mid_almacen As Integer
    Private mid_tipodocumento As String
    Private mnumero_documento As String
    Private mserie_documento As String
    Private mtipo_movimiento As String
    Private mmonto As Double
    Private mfecha_movimiento As Date
    Private mtipo_cambio As Double
    Public Property id_movimiento() As Integer
        Get
            Return mid_movimiento
        End Get
        Set(ByVal value As Integer)
            mid_movimiento = value
        End Set
    End Property
    Public Property id_caja() As Integer
        Get
            Return mid_caja
        End Get
        Set(ByVal value As Integer)
            mid_caja = value
        End Set
    End Property
    Public Property Id_Operacion() As Integer
        Get
            Return mId_Operacion
        End Get
        Set(ByVal value As Integer)
            mId_Operacion = value
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
    Public Property id_tipodocumento() As String
        Get
            Return mid_tipodocumento
        End Get
        Set(ByVal value As String)
            mid_tipodocumento = value
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
    Public Property Tipo_movimiento() As String
        Get
            Return mtipo_movimiento
        End Get
        Set(ByVal value As String)
            mtipo_movimiento = value
        End Set
    End Property
    Public Property monto() As Double
        Get
            Return mmonto
        End Get
        Set(ByVal value As Double)
            mmonto = value
        End Set
    End Property
    Public Property fecha_movimiento() As Date
        Get
            Return mfecha_movimiento
        End Get
        Set(ByVal value As Date)
            mfecha_movimiento = value
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
    Public Sub New()

    End Sub
End Class
