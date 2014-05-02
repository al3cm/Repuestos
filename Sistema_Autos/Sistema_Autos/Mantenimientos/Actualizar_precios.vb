Imports Entidades
Imports Reglas_Negocio
Imports Microsoft.Office.Interop
Public Class frmActualizar_precios
    Dim objOrden_Compra As New Orden_Compra
    Dim objProducto_Almacen As New Producto_Almacen
    Dim Vista As DataView
    Dim Tabla As DataTable
    Dim nProducto_Almacen As New RNProducto_Almacen
    Dim nAlmacen As New RNAlmacen
    Dim nPersonal As New RNPersonal
    Dim Cantidad As Integer
    Private Sub frmActualizar_precios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Tag = RNPersonalSubMenu.ListarPersonalSubMenu(CType(Me.Tag, Personal_SubMenu).id_menu, CType(Me.Tag, Personal_SubMenu).id_submenu, CType(Me.Tag, Personal_SubMenu).id_personal)
            If Me.Tag Is Nothing Then
                MessageBox.Show("Error al asignar archivos, consulte con el Administrador del Sstema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
            Me.btnGrabar.Enabled = False
            Cantidad = nPersonal.ContraAlmacen_Personal(id_Vededor)
            LlenaCombos()
            Limpiar()
            Me.txtfiltro_producto.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged
        ActualizaLista()
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Consultar()
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        'Modificar()
    End Sub
    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            ' intentar generar el documento
            ' se adjunta un texto debajo del encabezado con la fecha actual del sistema
            ExportarDatosExcel(dgvProducto, "Fecha:" + Now.Date())
        Catch ex As Exception
            'si el intento es fallido mostrar msgbox
            MessageBox.Show("No se puede Generar el Documento en Excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub dgvProducto_DoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProducto.DoubleClick
    '    Dim DGV As DataGridView
    '    Dim Id_Producto As Integer
    '    Dim Producto As String
    '    Dim Costo As Double
    '    Dim Precio As Double
    '    DGV = Me.dgvProducto
    '    Id_Producto = DGV.Item(0, e.RowIndex).Value
    '    Producto = DGV.Item(1, e.RowIndex).Value
    '    Costo = DGV.Item(6, e.RowIndex).Value
    '    Precio = DGV.Item(7, e.RowIndex).Value
    '    Me.TxtidProducto.Text = Producto
    '    Me.txtCosto.Text = Costo
    '    Me.txtPrecio.Text = Precio
    '    Me.btnGrabar.Enabled = True
    '    DGV.Rows.Remove(DGV.CurrentRow)
    '    DGV.Refresh()
    'End Sub
    '---------------------------------------------
    '-----------------MANEJO DE LISTVIEW
    '---------------------------------------------
    Sub ActualizaLista()
        Try
            Me.dgvProducto.Rows.Clear()
            Tabla = nProducto_Almacen.Listar(Me.cboAlmacen.SelectedValue)
            LlenaLista(Tabla)
            Vista = Tabla.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub LlenaLista(ByVal Datos As DataTable)
        Me.dgvProducto.Rows.Clear()
        For Each Fila As DataRow In Datos.Rows
            Dim objPROD As New Producto
            Dim objALMC As New Almacen
            Dim objLINE As New Linea
            Dim objMARC As New Marca
            Dim objPREC As New Precio
            objPROD.id_producto = Fila.Item("id_producto")
            objPROD.nombre_producto = Fila.Item("nombre_producto")
            objALMC.id_almacen = Fila.Item("id_almacen")
            objALMC.descripcion = Fila.Item("Almacen")
            objPROD.id_linea = Fila.Item("id_linea")
            objLINE.descripcion = Fila.Item("Linea")
            objPROD.id_marca = Fila.Item("id_marca")
            objMARC.descripcion = Fila.Item("Marca")
            objProducto_Almacen.stock = Fila.Item("stock")
            objPREC.precio_compra = Fila.Item("precio_compra")
            objPREC.precio_venta = Fila.Item("precio_venta")
            objPREC.precio_trajecta = Fila.Item("precio_trajecta")
            Me.dgvProducto.Rows.Add(objPROD.id_producto, objPROD.nombre_producto, objALMC.id_almacen, objALMC.descripcion, objPROD.id_linea, objLINE.descripcion, objPROD.id_marca, objMARC.descripcion, objProducto_Almacen.stock, Format(objPREC.precio_compra, "##0.00"), Format(objPREC.precio_venta, "##0.00"), Format(objPREC.precio_trajecta, "##0.00"))
        Next
    End Sub
    Sub LlenaLista(ByVal Datos As DataView)
        Try
            Me.dgvProducto.Rows.Clear()
            For Each Fila As DataRowView In Datos.Item(0).DataView
                Dim objPROD As New Producto
                Dim objALMC As New Almacen
                Dim objLINE As New Linea
                Dim objMARC As New Marca
                Dim objPREC As New Precio
                objPROD.id_producto = Fila.Item("id_producto")
                objPROD.nombre_producto = Fila.Item("nombre_producto")
                objALMC.id_almacen = Fila.Item("id_almacen")
                objALMC.descripcion = Fila.Item("Almacen")
                objPROD.id_linea = Fila.Item("id_linea")
                objLINE.descripcion = Fila.Item("Linea")
                objPROD.id_marca = Fila.Item("id_marca")
                objMARC.descripcion = Fila.Item("Marca")
                objProducto_Almacen.stock = Fila.Item("stock")
                objPREC.precio_compra = Fila.Item("precio_compra")
                objPREC.precio_venta = Fila.Item("precio_venta")
                objPREC.precio_trajecta = Fila.Item("precio_trajecta")
                Me.dgvProducto.Rows.Add(objPROD.id_producto, objPROD.nombre_producto, objALMC.id_almacen, objALMC.descripcion, objPROD.id_linea, objLINE.descripcion, objPROD.id_marca, objMARC.descripcion, objProducto_Almacen.stock, Format(objPREC.precio_compra, "##0.00"), Format(objPREC.precio_venta, "##0.00"), Format(objPREC.precio_trajecta, "##0.00"))
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Filtrar() Handles txtfiltro_producto.TextChanged
        Vista = Tabla.DefaultView
        Vista.RowFilter = String.Format("nombre_producto LIKE '%{0}%'", Me.txtfiltro_producto.Text)
        LlenaLista(Vista)
    End Sub
    Private Sub Consultar()
        Dim id_Almacen As Integer
        Dim id_linea As Integer
        Dim id_Marca As Integer
        id_Almacen = Me.cboAlmacen.SelectedValue
        id_linea = Me.cboLinea.SelectedValue
        id_Marca = Me.cboMarca.SelectedValue
        If id_linea = 0 Then
            If id_Marca = 0 Then
                Tabla = nProducto_Almacen.Listar(id_Almacen)
            Else
                Tabla = nProducto_Almacen.ListarMarca(id_Almacen, id_Marca)
            End If
        Else
            If id_Marca = 0 Then
                Tabla = nProducto_Almacen.ListarLinea(id_Almacen, id_linea)
            Else
                Tabla = nProducto_Almacen.Listar(id_Almacen, id_linea, id_Marca)
            End If
        End If
        LlenaLista(Tabla)
    End Sub
    '---------------------------------------------
    '-----------------FUNCIONALIDAD
    '---------------------------------------------
    Public Sub ExportarDatosExcel(ByVal DataGridView1 As DataGridView, ByVal titulo As String)

        Dim m_Excel As New Excel.Application
        m_Excel.Cursor = Excel.XlMousePointer.xlWait
        m_Excel.Visible = True
        Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Add
        Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets(1)
        With objHojaExcel
            .Visible = Excel.XlSheetVisibility.xlSheetVisible
            .Activate()
            'Encabezado
            .Range("A1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .Range("A1:L1").Merge()
            .Range("A1:L1").Value = "Actualizar Precios"
            .Range("A1:L1").Font.Bold = True
            .Range("A1:L1").Font.Size = 16
            'Texto despues del encabezado
            .Range("A2:L2").Merge()
            .Range("A2:L2").Value = titulo
            .Range("A2:L2").Font.Bold = True
            .Range("A2:L2").Font.Size = 10
            'Espacio
            .Range("A3:L3").Merge()
            .Range("A3:L3").Value = ""
            .Range("A3:L3").Font.Bold = True
            .Range("A3:L3").Font.Size = 10
            'Estilos a titulos de la Tabla
            .Range("A4:P4").Font.Bold = True
            'Establecer tipo de Letra al Rango Determinado
            .Range("A1:P100").Font.Name = "Tahoma"
            'Los datos se registran a partir de la Columna A, Fila 4
            Const PrimeraLetra As Char = "A"
            Const PrimerNumero As Short = 4
            Dim letra As Char
            Dim UltimaLetra As Char
            Dim Numero As Integer
            Dim UltimoNumero As Integer
            Dim cod_letra As Byte = Asc(PrimeraLetra) - 1
            Dim sepDec As String = Application.CurrentCulture.NumberFormat.CurrencyDecimalSeparator
            Dim sepFil As String = Application.CurrentCulture.NumberFormat.CurrencyDecimalSeparator
            Dim strColumna As String = ""
            Dim LetraIzq As String = ""
            Dim cod_LetraIzq As Byte = Asc(PrimeraLetra) - 1
            letra = PrimeraLetra
            Numero = PrimerNumero
            Dim objCelda As Excel.Range
            For Each c As DataGridViewColumn In dgvProducto.Columns
                If c.Visible Then
                    If letra = "Z" Then
                        letra = PrimeraLetra
                        cod_letra = Asc(PrimeraLetra)
                        cod_LetraIzq += 1
                        LetraIzq = Chr(cod_LetraIzq)
                    Else
                        cod_letra += 1
                        letra = Chr(cod_letra)
                    End If
                    strColumna = LetraIzq + letra + Numero.ToString
                    objCelda = .Range(strColumna, Type.Missing)
                    objCelda.Value = c.HeaderText
                    objCelda.EntireColumn.Font.Size = 10
                    'Establece un formato a los numeros por default
                    'objcelda.entirecolumn.numberformat = c.defaultCellStyle.Format
                    If c.ValueType Is GetType(Decimal) OrElse c.ValueType Is GetType(Double) Then
                        objCelda.EntireColumn.NumberFormat = "#" + sepFil + "0" + sepDec + "00"
                    End If
                End If
            Next
            Dim objRangoEncab As Excel.Range = .Range(PrimeraLetra + Numero.ToString, LetraIzq + letra + Numero.ToString)
            objRangoEncab.BorderAround(1, Excel.XlBorderWeight.xlMedium)
            UltimaLetra = letra
            Dim UltimaLetraIzq As String = LetraIzq
            'Cargar Datos del DataGridView
            Dim i As Integer = Numero + 1
            For Each reg As DataGridViewRow In DataGridView1.Rows
                LetraIzq = ""
                cod_LetraIzq = Asc(PrimeraLetra) - 1
                letra = PrimeraLetra
                cod_letra = Asc(PrimeraLetra) - 1
                For Each c As DataGridViewColumn In DataGridView1.Columns
                    If c.Visible Then
                        If letra = "Z" Then
                            letra = PrimeraLetra
                            cod_letra = Asc(PrimeraLetra)
                            cod_LetraIzq += 1
                            LetraIzq = Asc(cod_LetraIzq)
                        Else
                            cod_letra += 1
                            letra = Chr(cod_letra)
                        End If
                        strColumna = LetraIzq + letra
                        'Aqui se realiza la carga de datos
                        .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", reg.Cells(c.Index).Value)
                    End If
                Next
                Dim objRangoReg As Excel.Range = .Range(PrimeraLetra + i.ToString, strColumna + i.ToString)
                objRangoReg.Rows.BorderAround()
                objRangoReg.Select()
                i += 1
            Next
            UltimoNumero = i
            LetraIzq = ""
            cod_LetraIzq = Asc("A")
            cod_letra = Asc(PrimeraLetra)
            letra = PrimeraLetra
            For Each c As DataGridViewColumn In DataGridView1.Columns
                If c.Visible Then
                    objCelda = .Range(LetraIzq + letra + PrimerNumero.ToString, LetraIzq + letra + (UltimoNumero - 1).ToString)
                    objCelda.BorderAround()
                    If letra = "Z" Then
                        letra = PrimeraLetra
                        cod_letra = Asc(PrimeraLetra)
                        LetraIzq = Chr(cod_LetraIzq)
                        cod_LetraIzq += 1
                    Else
                        cod_letra += 1
                        letra = Chr(cod_letra)
                    End If
                End If
            Next
            ' Dibujar el border exterior grueso de la tabla 
            Dim objRango As Excel.Range = .Range(PrimeraLetra + PrimerNumero.ToString, UltimaLetraIzq + UltimaLetra + (UltimoNumero - 1).ToString)
            objRango.Select()
            objRango.Columns.AutoFit()
            objRango.Columns.BorderAround(1, Excel.XlBorderWeight.xlMedium)
        End With
        m_Excel.Cursor = Excel.XlMousePointer.xlDefault
    End Sub
    '---------------------------------------------
    '-----------------INICIALIZAR
    '---------------------------------------------
    Sub Limpiar()
        If Cantidad = 1 Then
            Tabla = nPersonal.ListarAlmacen_Personal(id_Vededor)
            For Each Fila As DataRow In Tabla.Rows
                objOrden_Compra.id_almacen = Fila.Item("id_almacen")
            Next
            Me.cboAlmacen.SelectedValue = objOrden_Compra.id_almacen
            Me.cboAlmacen.Enabled = False
        Else
            Me.cboAlmacen.SelectedValue = "1"
            Me.cboAlmacen.Enabled = True
        End If
    End Sub
    Sub LlenaCombos()
        Try
            Dim Almacen As DataTable = nAlmacen.Listar()
            Me.cboAlmacen.ValueMember = "id_almacen"
            Me.cboAlmacen.DisplayMember = "descripcion"
            If Almacen.Rows.Count > 0 Then
                Me.cboAlmacen.DataSource = Almacen
            Else
                Dim SinAlmacen As New DataTable
                SinAlmacen.Columns.Add("id_almacen")
                SinAlmacen.Columns.Add("descripcion")
                SinAlmacen.Rows.Add("1", "No hay Almacenes registradas")
                Me.cboAlmacen.DataSource = SinAlmacen
                Me.cboAlmacen.ValueMember = "id_almacen"
                Me.cboAlmacen.DisplayMember = "descripcion"
                Me.cboAlmacen.SelectedValue = "1"
                Me.btnGrabar.Enabled = False
            End If
            Dim Linea As New DataTable
            Linea.Columns.Add("id_Linea")
            Linea.Columns.Add("descripcion")
            Linea.Rows.Add("0", "Todas Las Lineas")
            Me.cboLinea.ValueMember = "id_Linea"
            Me.cboLinea.DisplayMember = "descripcion"
            Dim ConLinea As DataTable = RNLinea.Listar
            If ConLinea.Rows.Count > 0 Then
                For Each Fila As DataRow In ConLinea.Rows
                    Linea.Rows.Add(Fila.Item("id_Linea"), Fila.Item("descripcion"))
                    Me.cboLinea.DataSource = Linea
                Next
            Else
                Dim SinLinea As New DataTable
                SinLinea.Columns.Add("id_Linea")
                SinLinea.Columns.Add("descripcion")
                SinLinea.Rows.Add("0", "No hay Linea registradas")
                Me.cboLinea.DataSource = SinLinea
                Me.cboLinea.ValueMember = "id_Linea"
                Me.cboLinea.DisplayMember = "descripcion"
                Me.cboLinea.SelectedValue = "0"
                Me.btnGrabar.Enabled = False
            End If
            Dim Marca As New DataTable
            Marca.Columns.Add("id_Marca")
            Marca.Columns.Add("descripcion")
            Marca.Rows.Add("0", "Todas Las Marcas")
            Me.cboMarca.ValueMember = "id_Marca"
            Me.cboMarca.DisplayMember = "descripcion"
            Dim ConMarca As DataTable = RNMarca.Listar
            If ConMarca.Rows.Count > 0 Then
                For Each Fila As DataRow In ConMarca.Rows
                    Marca.Rows.Add(Fila.Item("id_Marca"), Fila.Item("descripcion"))
                    Me.cboMarca.DataSource = Marca
                Next
            Else
                Dim SinMarca As New DataTable
                SinMarca.Columns.Add("id_Marca")
                SinMarca.Columns.Add("descripcion")
                SinMarca.Rows.Add("1", "No hay Marca registradas")
                Me.cboMarca.DataSource = SinMarca
                Me.cboMarca.ValueMember = "id_Marca"
                Me.cboMarca.DisplayMember = "descripcion"
                Me.cboMarca.SelectedValue = "1"
                Me.btnGrabar.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class