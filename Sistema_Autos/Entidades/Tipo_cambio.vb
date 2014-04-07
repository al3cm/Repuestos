Public Class Tipo_cambio
    Private mid_tipo_cambio As Integer
    Private mcambio_venta As Double
    Private mcambio_compra As Double
    Private mcambio_empresa As Double
    Private mfecha_inicio As Date
    Private mfecha_fin As Date
    Public Property id_tipo_cambio() As Integer
        Get
            Return mid_tipo_cambio
        End Get
        Set(ByVal value As Integer)
            mid_tipo_cambio = value
        End Set
    End Property
    Public Property cambio_venta() As Double
        Get
            Return mcambio_venta
        End Get
        Set(ByVal value As Double)
            mcambio_venta = value
        End Set
    End Property
    Public Property cambio_compra() As Double
        Get
            Return mcambio_compra
        End Get
        Set(ByVal value As Double)
            mcambio_compra = value
        End Set
    End Property
    Public Property cambio_empresa() As Double
        Get
            Return mcambio_empresa
        End Get
        Set(ByVal value As Double)
            mcambio_empresa = value
        End Set
    End Property
    Public Property fecha_inicio() As Date
        Get
            Return mfecha_inicio
        End Get
        Set(ByVal value As Date)
            mfecha_inicio = value
        End Set
    End Property
    Public Property fecha_fin() As Date
        Get
            Return mfecha_fin
        End Get
        Set(ByVal value As Date)
            mfecha_fin = value
        End Set
    End Property
    Public Sub New()

    End Sub
End Class
