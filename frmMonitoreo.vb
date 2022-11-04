Public Class frmMonitoreo
    Private Sub rbDia_CheckedChanged(sender As Object, e As EventArgs) Handles rbDia.CheckedChanged
        gpbCriterios.Visible = False
        cmdBusqueda.Location = New Point(261, 81)
    End Sub

    Private Sub rbRangoFechas_CheckedChanged(sender As Object, e As EventArgs) Handles rbRangoFechas.CheckedChanged
        gpbCriterios.Visible = True
        cmdBusqueda.Location = New Point(505, 154)
    End Sub

    Private Sub cmdBusqueda_Click(sender As Object, e As EventArgs) Handles cmdBusqueda.Click
        BusquedaInfo(1, "Valor")
    End Sub
End Class