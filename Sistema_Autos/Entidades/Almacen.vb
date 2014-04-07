Public Class Almacen
    Private mid_almacen As Integer
    Private mid_sucursal As Integer
    Private mdescripcion As String
    Public Property id_almacen() As String
        Get
            Return mid_almacen
        End Get
        Set(ByVal value As String)
            mid_almacen = value
        End Set
    End Property
    Public Property id_sucursal() As String
        Get
            Return mid_sucursal
        End Get
        Set(ByVal value As String)
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

    Sub New()

    End Sub

    Sub New(ByVal wid_almacen As Integer, ByVal wid_sucursal As Integer, ByVal wdescripcion As String)
        Me.id_almacen = wid_almacen
        Me.id_sucursal = wid_sucursal
        Me.descripcion = wdescripcion
    End Sub
    Sub New(ByVal wid_sucursal As Integer, ByVal wdescripcion As String)

        Me.id_sucursal = wid_sucursal
        Me.descripcion = wdescripcion
    End Sub

End Class
