Public Class Concepto
    Private mid_concepto As String
    Private mdescripcion As String

    Public Property id_concepto() As String
        Get
            Return mid_concepto
        End Get
        Set(ByVal value As String)
            mid_concepto = value
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

    Sub New(ByVal wid_concepto As Integer, ByVal wdescripcion As String)
        Me.id_concepto = wdescripcion
        Me.descripcion = wdescripcion
    End Sub


End Class
