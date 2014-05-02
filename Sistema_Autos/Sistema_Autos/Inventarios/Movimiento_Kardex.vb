Imports Entidades
Imports Reglas_Negocio
Imports Microsoft.Office.Interop
Public Class frmMovimiento_Kardex
    Dim objKardex As New Kardex
    Dim objProducto As New Producto
    Dim objProducto_Almacen As New Producto_Almacen
    Dim Vista As DataView
    Dim Tabla As DataTable
    Dim nProducto_Almacen As New RNProducto_Almacen
    Dim nKardex As New RNKardex
    Dim nAlmacen As New RNAlmacen
    Dim nPersonal As New RNPersonal
    Dim Cantidad As Integer
    Private Sub frmMovimiento_Kardex_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Cantidad = nPersonal.ContraAlmacen_Personal(id_Vededor)
            LlenaCombos()
            Me.txtFiltro_producto.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Dim fila As Integer
        fila = Me.lstProducto.SelectedItems.Count
        If fila > 0 Then
            Me.objProducto = CType(Me.lstProducto.SelectedItems(0).Tag, Producto)
            LlenarKardex(Me.cboAlmacen.SelectedValue, Me.objProducto.id_producto, Me.dtpfecha_desde.Value, Me.dtpfecha_hasta.Value)
        Else
            MessageBox.Show("Selecionar un producto")
        End If
    End Sub
    Private Sub cboAlmacen_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedValueChanged
        ActualizaLista()
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            ' intentar generar el documento
            ' se adjunta un texto debajo del encabezado con la fecha actual del sistema
            ExportarDatosExcel(dgvMovimientos, "Fecha:" + Now.Date())
        Catch ex As Exception
            'si el intento es fallido mostrar msgbox
            MessageBox.Show("No se puede Generar el Documento en Excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
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
            .Range("A1:L1").Value = "Movimiento de Kardex"
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
            For Each c As DataGridViewColumn In dgvMovimientos.Columns
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
    Private Sub lstProducto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstProducto.Click
        Me.objProducto = CType(Me.lstProducto.SelectedItems(0).Tag, Producto)
        LlenarKardex(Me.cboAlmacen.SelectedValue, Me.objProducto.id_producto)
    End Sub
    Sub ActualizaLista()
        Try
            Me.lstProducto.Items.Clear()
            Tabla = nProducto_Almacen.ListarAlmacen(Me.cboAlmacen.SelectedValue)
            LlenaLista(Tabla)
            Vista = Tabla.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub LlenaLista(ByVal Datos As DataTable)
        For Each Fila As DataRow In Datos.Rows
            Dim Item As New ListViewItem
            Dim objPROD As New Producto
            Item.Text = CStr(Fila.Item("nombre_producto"))
            Item.SubItems.Add(CStr(Fila.Item("Unidad")))
            objPROD.id_producto = Fila.Item("id_producto")
            objPROD.nombre_producto = Fila.Item("nombre_producto")
            objPROD.codigo_producto = Fila.Item("codigo_producto")
            objProducto_Almacen.stock = Fila.Item("stock")
            Item.Tag = objPROD
            Me.lstProducto.Items.Add(Item)
        Next
    End Sub
    Sub LlenaLista(ByVal Datos As DataView)
        Try
            Me.lstProducto.Items.Clear()
            For Each Fila As DataRowView In Datos.Item(0).DataView
                Dim Item As New ListViewItem
                Dim objPROD As New Producto
                Item.Text = CStr(Fila.Item("nombre_producto"))
                Item.SubItems.Add(CStr(Fila.Item("Unidad")))
                objPROD.id_producto = Fila.Item("id_producto")
                objPROD.nombre_producto = Fila.Item("nombre_producto")
                objPROD.codigo_producto = Fila.Item("codigo_producto")
                objProducto_Almacen.stock = Fila.Item("stock")
                Item.Tag = objPROD
                Me.lstProducto.Items.Add(Item)
            Next
        Catch ex As Exception
            '   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Filtrar() Handles txtFiltro_producto.TextChanged
        Vista = Tabla.DefaultView
        Vista.RowFilter = String.Format("nombre_producto LIKE '%{0}%'", Me.txtFiltro_producto.Text)
        LlenaLista(Vista)
    End Sub
    '---------------------------------------------
    '-----------------FUNCIONALIDAD
    '---------------------------------------------
    Sub LlenarKardex(ByVal Id_almacen As Integer, ByVal Id_producto As Integer)
        Dim Id_Kardex As Integer
        Dim Fecha As Date
        Dim Tipo As String
        Dim Motivo As String
        Dim Tipodocumento As String
        Dim Nro_documento As String
        Dim Serie_documento As String
        Dim Documento As String
        Dim Ruc_Dni As String
        Dim Nombre As String
        Dim Stock As Integer
        Dim Cant As Integer
        Dim ing As Integer
        Dim sal As Integer
        Dim total As Integer
        Dim X As Integer
        Dim Actual As Integer
        Tabla = nKardex.Listar(Id_almacen, Id_producto)
        Me.dgvMovimientos.Rows.Clear()
        X = 0
        Actual = 0
        For Each Fila As DataRow In Tabla.Rows
            Id_Kardex = Fila.Item("id_kardex")
            Fecha = Fila.Item("fecha")
            Tipo = Fila.Item("tipo")
            Motivo = ""
            ing = 0
            sal = 0
            Tipodocumento = Fila.Item("tipodocumento")
            Nro_documento = Fila.Item("nro_documento")
            Serie_documento = Fila.Item("serie_documento")
            Ruc_Dni = Fila.Item("ruc_dni")
            Nombre = Fila.Item("nombre")
            Stock = Fila.Item("stock")
            Cant = Fila.Item("cantidad")
            Select Case Tipo
                Case "C"
                    Motivo = "Compra"
                    ing = Cant
                Case "V"
                    Motivo = "Venta"
                    sal = Cant
                Case "E"
                    Motivo = "Devolución Nota Credito Provedor"
                    sal = Cant
                Case "S"
                    Motivo = "Devolución Nota Credito Cliente"
                    ing = Cant
                Case "P"
                    Motivo = "Devolución Nota Debito Provedor"
                    sal = Cant
                Case "D"
                    Motivo = "Devolución Nota Debito Cliente"
                    ing = Cant
            End Select
            total = Stock + ing - sal
            Documento = Tipodocumento & "/ " & Nro_documento & " - " & Serie_documento
            Me.dgvMovimientos.Rows.Add(Id_Kardex, Fecha, Motivo, Documento, Ruc_Dni, Nombre, Stock, ing, sal, total)
            If X = 0 Then
                Actual = total
            End If
            X = X + 1
        Next
        Me.txtStock_Final.Text = Actual
    End Sub
    Sub LlenarKardex(ByVal Id_almacen As Integer, ByVal Id_producto As Integer, ByVal Fecha_Ini As Date, ByVal Fecha_Fin As Date)
        Dim Id_Kardex As Integer
        Dim Fecha As Date
        Dim Tipo As String
        Dim Motivo As String
        Dim Tipodocumento As String
        Dim Nro_documento As String
        Dim Serie_documento As String
        Dim Documento As String
        Dim Ruc_Dni As String
        Dim Nombre As String
        Dim Stock As Integer
        Dim Cant As Integer
        Dim ing As Integer
        Dim sal As Integer
        Dim total As Integer
        Dim X As Integer
        Dim Actual As Integer
        Tabla = nKardex.Listar(Id_almacen, Id_producto, Fecha_Ini, Fecha_Fin)
        Me.dgvMovimientos.Rows.Clear()
        X = 0
        Actual = 0
        For Each Fila As DataRow In Tabla.Rows
            Id_Kardex = Fila.Item("id_kardex")
            Fecha = Fila.Item("fecha")
            Tipo = Fila.Item("tipo")
            Motivo = ""
            ing = 0
            sal = 0
            Tipodocumento = Fila.Item("tipodocumento")
            Nro_documento = Fila.Item("nro_documento")
            Serie_documento = Fila.Item("serie_documento")
            Ruc_Dni = Fila.Item("ruc_dni")
            Nombre = Fila.Item("nombre")
            Stock = Fila.Item("stock")
            Cant = Fila.Item("cantidad")
            Select Case Tipo
                Case "C"
                    Motivo = "Compra"
                    ing = Cant
                Case "V"
                    Motivo = "Venta"
                    sal = Cant
                Case "E"
                    Motivo = "Devolución Nota Credito Provedor"
                    sal = Cant
                Case "S"
                    Motivo = "Devolución Nota Credito Cliente"
                    ing = Cant
                Case "P"
                    Motivo = "Devolución Nota Debito Provedor"
                    sal = Cant
                Case "D"
                    Motivo = "Devolución Nota Debito Cliente"
                    ing = Cant
            End Select
            total = Stock + ing - sal
            Documento = Tipodocumento & "/ " & Nro_documento & " - " & Serie_documento
            Me.dgvMovimientos.Rows.Add(Id_Kardex, Fecha, Motivo, Documento, Ruc_Dni, Nombre, Stock, ing, sal, total)
            If X = 0 Then
                Actual = total
            End If
            X = X + 1
        Next
        Me.txtStock_Final.Text = Actual
    End Sub
    Sub Exportar()
        Try
            Dim xla As New Microsoft.Office.Interop.Excel.Application()
            xla.Visible = True

            Dim wb As Microsoft.Office.Interop.Excel.Workbook = xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet)

            Dim ws As Microsoft.Office.Interop.Excel.Worksheet = DirectCast(xla.ActiveSheet, Microsoft.Office.Interop.Excel.Worksheet)

            Dim i As Integer = 1
            Dim j As Integer = 1

            Dim jj As Integer = lstProducto.Columns.Count

            For rr = 0 To lstProducto.Columns.Count - 1
                ws.Cells(i, j) = lstProducto.Columns(rr).Text
                j = j + 1
            Next
            i = 2
            j = 1
            For Each comp As ListViewItem In lstProducto.Items
                ws.Cells(i, j) = comp.Text.ToString()
                For Each drv As ListViewItem.ListViewSubItem In comp.SubItems
                    ws.Cells(i, j) = drv.Text.ToString()
                    j += 1
                Next
                j = 1
                i += 1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '---------------------------------------------
    '-----------------INICIALIZAR
    '---------------------------------------------
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
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class