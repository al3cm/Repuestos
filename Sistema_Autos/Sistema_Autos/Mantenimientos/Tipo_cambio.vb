Imports Entidades
Imports Reglas_Negocio
Public Class frmTipo_cambio
    Dim nTipo_Cambio As New RNTipo_cambio
    Dim objTipo_Cambio As New Tipo_cambio
    '---------------------------------------------
    '-----------------EVENTOS
    '---------------------------------------------
    Private Sub frmTipo_cambio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try
            Grabar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    '---------------------------------------------
    '-----------------FUNCIONALIDAD
    '---------------------------------------------
    Sub Grabar()
        Try
            Dim Tabla As DataTable
            If Valida() Then
                objTipo_Cambio.fecha_inicio = Me.dtpfecha.Value
                objTipo_Cambio.cambio_compra = Me.txttipoc_compra.Text.Trim
                objTipo_Cambio.cambio_venta = Me.txttipoc_venta.Text.Trim
                objTipo_Cambio.cambio_empresa = Me.txtipocam_empresa.Text.Trim
                If MessageBox.Show("¿Desea registrar los datos de este Tipo del Cambio?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Tabla = nTipo_Cambio.Listar()
                    For Each Fila As DataRow In Tabla.Rows
                        objTipo_Cambio.id_tipo_cambio = Fila.Item("id_tipo_cambio")
                        objTipo_Cambio.fecha_fin = Me.dtpfecha.Value
                        nTipo_Cambio.EleminarTipo_Cambio(objTipo_Cambio)
                    Next
                    objTipo_Cambio = nTipo_Cambio.RegistrarTipo_cambio(objTipo_Cambio)
                    MessageBox.Show("Los datos se guardaron satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '---------------------------------------------
    '-----------------INICIALIZAR
    '---------------------------------------------
    Sub Limpiar()
        Me.dtpfecha.Value = DateTime.Now()
        Me.txtipocam_empresa.Text = ""
        Me.txttipoc_compra.Text = ""
        Me.txttipoc_venta.Text = ""
    End Sub
    '---------------------------------------------
    '-----------------VALIDACIONES
    '---------------------------------------------
    Function Valida() As Boolean
        Dim TextoError As String = ""
        If Me.txtipocam_empresa.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un Tipo de Cambio de Empresa." & vbCrLf
        End If
        If Me.txttipoc_compra.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un Tipo de Cambio de Compra." & vbCrLf
        End If
        If Me.txttipoc_venta.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un Tipo de Cambio de Venta." & vbCrLf
        End If
        If TextoError <> "" Then
            MessageBox.Show("Faltan completar datos: " & vbCrLf & TextoError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If
    End Function
End Class