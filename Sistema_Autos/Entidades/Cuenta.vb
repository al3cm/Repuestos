Public Class Cuenta
    Private mid_cuenta As Integer
    Private mid_compra As Integer
    Private mpago_inicial As Double
    Private mmonto_financiado As Double
    Private mnro_cuotas As Integer
    Private mdeudad As Double
    Public Property id_cuenta() As Integer
        Get
            Return mid_cuenta
        End Get
        Set(ByVal value As Integer)
            mid_cuenta = value
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
            Return mpago_inicial
        End Get
        Set(ByVal value As Double)
            mpago_inicial = value
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
    Public Property deudad() As Double
        Get
            Return mdeudad
        End Get
        Set(ByVal value As Double)
            mdeudad = value
        End Set
    End Property
    Public Sub New()

    End Sub
End Class
