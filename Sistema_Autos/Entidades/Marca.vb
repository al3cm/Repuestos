Public Class Marca
    Private mid_marca As Integer
    Private mdescripcion As String
    Public Property id_marca() As String
        Get
            Return mid_marca

        End Get
        Set(ByVal value As String)
            mid_marca = value
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

    Sub New(ByVal wid_marca As Integer, ByVal wdescripcion As String)
        Me.id_marca = wid_marca
        Me.descripcion = wdescripcion
    End Sub


End Class
