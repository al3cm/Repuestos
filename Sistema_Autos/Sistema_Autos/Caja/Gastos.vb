Public Class frmGastos

    Private Sub btnbuscar_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar_cliente.Click
        cargar()
    End Sub

    Sub cargar()
        If rbOtros.Checked Then
            'btnbuscar_cliente.Select()
            Me.lblnombre.Text = "Otros"
            frmListarConceptos.ShowDialog()
        Else
            If rbProveedor.Checked Then
                ' btnbuscar_cliente.Select()
                Me.lblnombre.Text = "Proveedor"
                frmListarProveedores.ShowDialog()
            End If
        End If
    End Sub
   

End Class