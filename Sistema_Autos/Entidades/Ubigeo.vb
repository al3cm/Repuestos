Public Class Ubigeo
    Private mid_ubigeo As String
    Private mDescripcion As String
    Public Property id_ubigeo() As String
        Get
            Return mid_ubigeo
        End Get
        Set(ByVal value As String)
            mid_ubigeo = value
        End Set
    End Property


    Public Property Descripcion() As String
        Get
            Return mDescripcion
        End Get
        Set(ByVal value As String)
            mDescripcion = value
        End Set
    End Property
    Sub New()

    End Sub

    Sub New(ByVal wid_ubigeo As String, ByVal wDescripcion As String)
        Me.id_ubigeo = wid_ubigeo
        Me.Descripcion = wDescripcion
    End Sub
End Class
