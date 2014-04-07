Public Class Detalle_Caja
    Private mid_caja As Integer
    Private mid_almacen As Integer
    Private mcaja As String
    Private mdescripcion As String
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
    Public Property caja() As String
        Get
            Return mcaja
        End Get
        Set(ByVal value As String)
            mcaja = value
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
