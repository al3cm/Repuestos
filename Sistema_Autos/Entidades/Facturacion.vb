Public Class Facturacion
    Private mid_movimiento As Integer
    Private mid_caja As Integer
    Private mId_Operacion As Integer
    Private mid_personal As Integer
    Private mid_tipodocumento As String
    Private mtipo_movimiento As String = "E"
    Private mmonto As Double
    Private mfecha_movimiento As Date
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
End Class
