Imports Entidades
Imports Reglas_Negocio
Imports Microsoft.Office.Interop
Public Class frmCuentas_Pagar
    'Dim objKardex As New Kardex
    'Dim objProducto As New Producto
    'Dim objProducto_Almacen As New Producto_Almacen
    Dim objOrden_Compra As Orden_Compra
    Dim objCuenta As New Cuenta
    Dim Tabla As DataTable
    'Dim nProducto_Almacen As New RNProducto_Almacen
    'Dim nKardex As New RNKardex
    Dim nAlmacen As New RNAlmacen
    Dim nCuenta As New RNCuenta
    Dim nPersonal As New RNPersonal
    Dim Cantidad As Integer
    Private Sub frmCuentas_Pagar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Cantidad = nPersonal.ContraAlmacen_Personal(id_Vededor)
            LlenaCombos()
            Limpiar()
            Me.txtfiltro_proveedor.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged
        ActualizaLista()
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        ActualizaLista()
    End Sub
    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            ' intentar generar el documento
            ' se adjunta un texto debajo del encabezado con la fecha actual del sistema
            ExportarDatosExcel(DataGridView1, "Fecha:" + Now.Date())
        Catch ex As Exception
            'si el intento es fallido mostrar msgbox
            MessageBox.Show("No se puede Generar el Documento en Excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub txtfiltro_proveedor_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtfiltro_proveedor.TextChanged
        Try
            Me.DataGridView1.Rows.Clear()
            If Me.chbuscar_fechas.Checked Then
                Tabla = nCuenta.ListarDeuda(Me.cboAlmacen.SelectedValue, Me.dtpfecha_desde.Value, Me.dtpfecha_hasta.Value, Me.txtfiltro_proveedor.Text)
            Else
                Tabla = nCuenta.ListarDeuda(Me.cboAlmacen.SelectedValue, Me.txtfiltro_proveedor.Text)
            End If
            LlenaLista(Tabla)
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    '---------------------------------------------
    '-----------------FUNCIONALIDAD
    '---------------------------------------------
    Sub ActualizaLista()
        Try
            Me.DataGridView1.Rows.Clear()
            If Me.chbuscar_fechas.Checked Then
                Tabla = nCuenta.ListarDeuda(Me.cboAlmacen.SelectedValue, Me.dtpfecha_desde.Value, Me.dtpfecha_hasta.Value)
            Else
                Tabla = nCuenta.ListarDeuda(Me.cboAlmacen.SelectedValue)
            End If
            LlenaLista(Tabla)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub LlenaLista(ByVal Datos As DataTable)
        Dim razon_social As String
        Dim serie_documento As String
        Dim numero_documento As String
        Dim coprobrante As String
        Dim fecha_emision As Date
        Dim monto As String
        Dim Moneda As String
        Dim Almacen As String
        Me.DataGridView1.Rows.Clear()
        For Each Fila As DataRow In Datos.Rows
            razon_social = Fila.Item("razon_social")
            serie_documento = Fila.Item("serie_documento")
            numero_documento = Fila.Item("numero_documento")
            coprobrante = "OC/ " & serie_documento & " " & numero_documento
            fecha_emision = Fila.Item("fecha_compra")
            monto = Fila.Item("deudad")
            Moneda = Fila.Item("Moneda")
            Almacen = Fila.Item("Almacen")
            Me.DataGridView1.Rows.Add(razon_social, coprobrante, fecha_emision, monto, Moneda, Almacen)
        Next
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
            For Each c As DataGridViewColumn In DataGridView1.Columns
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
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class