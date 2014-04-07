Imports Reglas_Negocio
Imports Entidades
Public Class frmListarConceptos
    Dim nConcepto As New RNConcepto
    Dim Vista As DataView
    Dim Tabla As DataTable
    Public objConcepto As Concepto


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub frmListarConceptos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.btnAceptar.Enabled = False
            ActualizaLista()
            Me.txtbuscar_concepto.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.objConcepto = CType(Me.lstConceptos.SelectedItems(0).Tag, Concepto)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub lstConceptos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstConceptos.KeyPress
        If Me.lstConceptos.SelectedItems.Count > 0 And e.KeyChar = ChrW(Keys.Enter) Then
            btnAceptar_Click(sender, e)
        End If
    End Sub


    Private Sub lstConceptos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstConceptos.SelectedIndexChanged
        If Me.lstConceptos.SelectedItems.Count > 0 Then
            Me.btnAceptar.Enabled = True
        Else
            Me.btnAceptar.Enabled = False
        End If
    End Sub


    Private Sub lstConceptos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstConceptos.DoubleClick
        btnAceptar_Click(sender, e)
    End Sub

    Sub ActualizaLista()
        Try
            Me.lstConceptos.Items.Clear()
            Tabla = nConcepto.Listar
            LlenaLista(Tabla)
            Vista = Tabla.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub LlenaLista(ByVal Datos As DataTable)

        For Each Fila As DataRow In Datos.Rows
            Dim Item As New ListViewItem
            Dim objC As New Concepto
            Item.Text = CStr(Fila.Item("id_concepto"))
            Item.SubItems.Add(CStr(Fila.Item("descripcion")))
            objC.id_concepto = Fila.Item("id_concepto")
            objC.descripcion = Fila.Item("descripcion")
            Item.Tag = objC
            Me.lstConceptos.Items.Add(Item)
        Next
    End Sub

    Sub LlenaLista(ByVal Datos As DataView)
        Try
            Me.lstConceptos.Items.Clear()
            For Each Fila As DataRowView In Datos.Item(0).DataView
                Dim Item As New ListViewItem
                Dim objC As New Concepto
                Item.Text = CStr(Fila.Item("id_concepto"))
                Item.SubItems.Add(CStr(Fila.Item("descripcion")))
                objC.id_concepto = Fila.Item("id_concepto")
                objC.descripcion = Fila.Item("descripcion")
                Item.Tag = objC
                Me.lstConceptos.Items.Add(Item)
            Next
        Catch ex As Exception
            '   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Filtrar() Handles txtbuscar_concepto.TextChanged
        Vista = Tabla.DefaultView
        Vista.RowFilter = String.Format("Descripcion LIKE '%{0}%'", Me.txtbuscar_concepto.Text)
        LlenaLista(Vista)
        Me.btnAceptar.Enabled = False ' Added 2014.03.24
    End Sub

    Private Sub validaTexto_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbuscar_concepto.KeyPress
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