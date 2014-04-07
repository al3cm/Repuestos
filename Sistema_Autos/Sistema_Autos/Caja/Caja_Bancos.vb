Public Class frmCaja_Bancos

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnMovimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMovimiento.Click
        frmResumen_Caja.ShowDialog()
    End Sub
End Class