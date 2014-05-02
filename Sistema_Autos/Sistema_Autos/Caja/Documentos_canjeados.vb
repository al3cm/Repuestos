Imports Entidades
Imports Reglas_Negocio
Public Class frmDocumentos_canjeados
    Dim nLetras As New RNLetras
    Dim Vista As DataView
    Dim Tabla As DataTable
    Public ObjLetras As New Letras
    '---------------------------------------------
    '-----------------EVENTOS
    '---------------------------------------------
    Private Sub frmDocumentos_canjeados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.btnAceptar.Enabled = False
            ActualizaLista()
            Me.txtbuscar_razonsocial.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.ObjLetras = CType(Me.lstBuscar_canje.SelectedItems(0).Tag, Letras)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub lstBuscar_canje_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstBuscar_canje.KeyPress
        If Me.lstBuscar_canje.SelectedItems.Count > 0 And e.KeyChar = ChrW(Keys.Enter) Then
            btnAceptar_Click(sender, e)
        End If
    End Sub
    Private Sub lstBuscar_canje_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstBuscar_canje.SelectedIndexChanged
        If Me.lstBuscar_canje.SelectedItems.Count > 0 Then
            Me.btnAceptar.Enabled = True
        Else
            Me.btnAceptar.Enabled = False
        End If
    End Sub
    Private Sub lstBuscar_canje_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstBuscar_canje.DoubleClick
        btnAceptar_Click(sender, e)
    End Sub
    '---------------------------------------------
    '-----------------MANEJO DE LISTVIEW
    '---------------------------------------------
    Sub ActualizaLista()
        Try
            Me.lstBuscar_canje.Items.Clear()
            Tabla = nLetras.Listar
            LlenaLista(Tabla)
            Vista = Tabla.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub LlenaLista(ByVal Datos As DataTable)
        For Each Fila As DataRow In Datos.Rows
            Dim Item As New ListViewItem
            Dim objLE As New Letras
            Dim serie As String
            objLE.id_letras = CStr(Fila.Item("id_letras"))
            If objLE.id_letras < 10 Then
                serie = "0000000" & objLE.id_letras.ToString
            ElseIf objLE.id_letras < 100 Then
                serie = "000000" & objLE.id_letras.ToString
            ElseIf objLE.id_letras < 1000 Then
                serie = "00000" & objLE.id_letras.ToString
            ElseIf objLE.id_letras < 10000 Then
                serie = "0000" & objLE.id_letras.ToString
            ElseIf objLE.id_letras < 100000 Then
                serie = "000" & objLE.id_letras.ToString
            ElseIf objLE.id_letras < 1000000 Then
                serie = "00" & objLE.id_letras.ToString
            ElseIf objLE.id_letras < 10000000 Then
                serie = "0" & objLE.id_letras.ToString
            Else
                serie = objLE.id_letras.ToString
            End If
            Item.Text = "LC/" & serie
            Item.SubItems.Add(CStr(Fila.Item("razon_social")))
            Item.SubItems.Add(CStr(Fila.Item("saldo")))
            Item.SubItems.Add(CStr(Fila.Item("Moneda")))
            objLE.saldo = Fila.Item("saldo")
            Item.Tag = objLE
            Me.lstBuscar_canje.Items.Add(Item)
        Next
    End Sub
    Sub LlenaLista(ByVal Datos As DataView)
        Try
            Me.lstBuscar_canje.Items.Clear()
            For Each Fila As DataRowView In Datos.Item(0).DataView
                Dim Item As New ListViewItem
                Dim objLE As New Letras
                Dim serie As String
                objLE.id_letras = CStr(Fila.Item("id_letras"))
                If objLE.id_letras < 10 Then
                    serie = "0000000" & objLE.id_letras.ToString
                ElseIf objLE.id_letras < 100 Then
                    serie = "000000" & objLE.id_letras.ToString
                ElseIf objLE.id_letras < 1000 Then
                    serie = "00000" & objLE.id_letras.ToString
                ElseIf objLE.id_letras < 10000 Then
                    serie = "0000" & objLE.id_letras.ToString
                ElseIf objLE.id_letras < 100000 Then
                    serie = "000" & objLE.id_letras.ToString
                ElseIf objLE.id_letras < 1000000 Then
                    serie = "00" & objLE.id_letras.ToString
                ElseIf objLE.id_letras < 10000000 Then
                    serie = "0" & objLE.id_letras.ToString
                Else
                    serie = objLE.id_letras.ToString
                End If
                Item.Text = "LC/" & serie
                Item.SubItems.Add(CStr(Fila.Item("razon_social")))
                Item.SubItems.Add(CStr(Fila.Item("saldo")))
                Item.SubItems.Add(CStr(Fila.Item("Moneda")))
                objLE.saldo = Fila.Item("saldo")
                Item.Tag = objLE
                Me.lstBuscar_canje.Items.Add(Item)
            Next
        Catch ex As Exception
            '   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Filtrar() Handles txtbuscar_razonsocial.TextChanged
        Vista = Tabla.DefaultView
        Vista.RowFilter = String.Format("razon_social LIKE '%{0}%' ", Me.txtbuscar_razonsocial.Text)
        LlenaLista(Vista)
        Me.btnAceptar.Enabled = False 'Added 2014.03.24s
    End Sub
    '---------------------------------------------
    '-----------------VALIDACIONES
    '---------------------------------------------
    Private Sub validaTexto_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbuscar_razonsocial.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class