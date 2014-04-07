Public Class Producto
    Private mid_producto As Integer
    Private mnombre_producto As String
    Private mcodigo_producto As String
    Private mmodelo_producto As String
    Private mnumero_comprobante As String
    Private mstock As Integer
    Private mestado As Boolean
    Private mdescripcion As String
    Private mprecio_compra As Double
    Private mprecio_venta As Double
    Private mid_marca As Integer
    Private mid_unidad As Integer
    Private mid_linea As Integer
    'Imagen
    Public arrImage() As Byte
    Private midRutaImagen As String
    Public Property RutaImagen() As String
        Get
            Return midRutaImagen
        End Get
        Set(ByVal value As String)
            midRutaImagen = value
        End Set
    End Property
    Private mimagen As Byte
    Public Property imagen() As Byte
        Get
            Return mimagen
        End Get
        Set(ByVal value As Byte)
            mimagen = value
        End Set
    End Property
    'Imagen
    'imagen
    'Private mfoto As String
    'Public Property foto() As String
    '    Get
    '        Return mfoto
    '    End Get
    '    Set(ByVal value As String)
    '        mfoto = value
    '    End Set
    'End Property
    'imagen

    Public Property id_producto() As String
        Get
            Return mid_producto
        End Get
        Set(ByVal value As String)
            mid_producto = value
        End Set
    End Property
    Public Property nombre_producto() As String
        Get
            Return mnombre_producto
        End Get
        Set(ByVal value As String)
            mnombre_producto = value
        End Set
    End Property
    Public Property codigo_producto() As String
        Get
            Return mcodigo_producto
        End Get
        Set(ByVal value As String)
            mcodigo_producto = value
        End Set
    End Property
    Public Property modelo_producto() As String
        Get
            Return mmodelo_producto
        End Get
        Set(ByVal value As String)
            mmodelo_producto = value
        End Set
    End Property
    Public Property numero_comprobante() As String
        Get
            Return mnumero_comprobante
        End Get
        Set(ByVal value As String)
            mnumero_comprobante = value
        End Set
    End Property
    Public Property stock() As String
        Get
            Return mstock
        End Get
        Set(ByVal value As String)
            mstock = value
        End Set
    End Property
    Public Property estado() As Boolean
        Get
            Return mestado
        End Get
        Set(ByVal value As Boolean)
            mestado = value
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
    Public Property precio_compra() As Double
        Get
            Return mprecio_compra
        End Get
        Set(ByVal value As Double)
            mprecio_compra = value
        End Set
    End Property
    Public Property precio_venta() As Double
        Get
            Return mprecio_venta
        End Get
        Set(ByVal value As Double)
            mprecio_venta = value
        End Set
    End Property
    Public Property id_marca() As String
        Get
            Return mid_marca
        End Get
        Set(ByVal value As String)
            mid_marca = value
        End Set
    End Property
    Public Property id_unidad() As String
        Get
            Return mid_unidad
        End Get
        Set(ByVal value As String)
            mid_unidad = value
        End Set
    End Property
    Public Property id_linea() As String
        Get
            Return mid_linea
        End Get
        Set(ByVal value As String)
            mid_linea = value
        End Set
    End Property

    Sub New()

    End Sub

    Sub New(ByVal wid_producto As Integer, ByVal wnombre_producto As String, ByVal wcodigo_producto As String, ByVal wmodelo_producto As String, ByVal wnumero_comprobante As String, ByVal wstock As Integer, ByVal westado As Boolean, ByVal wprecio_compra As Double, ByVal wprecio_venta As Double, ByVal wdescripcion As String, ByVal wid_marca As Integer, ByVal wid_linea As Integer, ByVal wid_unidad As Integer, ByVal wimagen As Byte)
        Me.id_producto = wid_producto
        Me.id_linea = wid_linea
        Me.id_marca = wid_marca
        Me.id_unidad = wid_unidad
        Me.codigo_producto = wcodigo_producto
        Me.nombre_producto = wnombre_producto
        Me.modelo_producto = wmodelo_producto
        Me.numero_comprobante = wnumero_comprobante
        Me.stock = wstock
        Me.estado = westado
        Me.descripcion = wdescripcion
        Me.precio_compra = wprecio_compra
        Me.precio_venta = wprecio_venta
        Me.imagen = wimagen
        '    Me.foto = wfoto
    End Sub

    Sub New(ByVal wnombre_producto As String, ByVal wcodigo_producto As String, ByVal wmodelo_producto As String, ByVal wnumero_comprobante As String, ByVal wstock As Integer, ByVal westado As Boolean, ByVal wprecio_compra As Double, ByVal wprecio_venta As Double, ByVal wdescripcion As String, ByVal wid_marca As Integer, ByVal wid_linea As Integer, ByVal wid_unidad As Integer, ByVal wimagen As Byte)
        Me.id_linea = wid_linea
        Me.id_marca = wid_marca
        Me.id_unidad = wid_unidad
        Me.codigo_producto = wcodigo_producto
        Me.nombre_producto = wnombre_producto
        Me.modelo_producto = wmodelo_producto
        Me.numero_comprobante = wnumero_comprobante
        Me.stock = wstock
        Me.estado = westado
        Me.descripcion = wdescripcion
        Me.precio_compra = wprecio_compra
        Me.precio_venta = wprecio_venta
        Me.imagen = wimagen
        '    Me.foto = wfoto
    End Sub




End Class
