Public Class Letras
    Private mid_letras As Integer
    Private mid_venta As Integer
    Private mcoprobrante As String
    Private mfecha_emision As Date
    Private mtasa As Double
    Private msaldo As Double
    Private mid_Detalle As Integer
    Private mnum_letra As Integer
    Private mdias As Integer
    Private mfecha_vencimiento As Date
    Private mmonto As Double
    Private mdescripcion As String
    Private mid_pagos_letras As Integer
    Private mid_personal As Integer
    Private mid_caja As Integer
    Private mid_almacen As Integer
    Private mid_movimiento As Integer
    Private mfecha As Date
    Private mtipo_cambio As Double
    Private mtotal As Double
    Private mobservaciones As String
    Private mtipo_pago As String
    Public Property id_letras() As Integer
        Get
            Return mid_letras
        End Get
        Set(ByVal value As Integer)
            mid_letras = value
        End Set
    End Property
    Public Property id_venta() As Integer
        Get
            Return mid_venta
        End Get
        Set(ByVal value As Integer)
            mid_venta = value
        End Set
    End Property
    Public Property coprobrante() As String
        Get
            Return mcoprobrante
        End Get
        Set(ByVal value As String)
            mcoprobrante = value
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
    Public Property tasa() As Double
        Get
            Return mtasa
        End Get
        Set(ByVal value As Double)
            mtasa = value
        End Set
    End Property
    Public Property saldo() As Double
        Get
            Return msaldo
        End Get
        Set(ByVal value As Double)
            msaldo = value
        End Set
    End Property
    Public Property id_Detalle() As Integer
        Get
            Return mid_Detalle
        End Get
        Set(ByVal value As Integer)
            mid_Detalle = value
        End Set
    End Property
    Public Property num_letra() As Integer
        Get
            Return mnum_letra
        End Get
        Set(ByVal value As Integer)
            mnum_letra = value
        End Set
    End Property
    Public Property dias() As Integer
        Get
            Return mdias
        End Get
        Set(ByVal value As Integer)
            mdias = value
        End Set
    End Property
    Public Property fecha_vencimiento() As Date
        Get
            Return mfecha_vencimiento
        End Get
        Set(ByVal value As Date)
            mfecha_vencimiento = value
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
    Public Property descripcion() As String
        Get
            Return mdescripcion
        End Get
        Set(ByVal value As String)
            mdescripcion = value
        End Set
    End Property
    Public Property id_pagos_letras() As Integer
        Get
            Return mid_pagos_letras
        End Get
        Set(ByVal value As Integer)
            mid_pagos_letras = value
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
    Public Property id_caja() As Integer
        Get
            Return mid_caja
        End Get
        Set(ByVal value As Integer)
            mid_caja = value
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
    Public Property id_movimiento() As Integer
        Get
            Return mid_movimiento
        End Get
        Set(ByVal value As Integer)
            mid_movimiento = value
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
    Public Property tipo_cambio() As Double
        Get
            Return mtipo_cambio
        End Get
        Set(ByVal value As Double)
            mtipo_cambio = value
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
    Public Property observaciones() As String
        Get
            Return mobservaciones
        End Get
        Set(ByVal value As String)
            mobservaciones = value
        End Set
    End Property
    Public Property tipo_pago() As String
        Get
            Return mtipo_pago
        End Get
        Set(ByVal value As String)
            mtipo_pago = value
        End Set
    End Property
    Public Sub New()

    End Sub
End Class
