
Imports IBM.Data.Informix
Public Class frmCobranza
    Dim TipoBusqueda As Integer
    Private Sub frmCobranza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
        AbrirConexion()

    End Sub


    Private Sub Limpiar()
        lblCriterio.Text = ""
        lblDivisa.Text = ""
        lblEstatusLC.Text = ""
        lblFechaApert.Text = ""
        lblFechaOrig.Text = ""
        lblImporteVenci.Text = ""
        lblMontoOtor.Text = ""
        lblNoCliente.Text = ""
        lblNoLC.Text = ""
        lblNombreCliente.Text = ""
        lblNoOperaciones.Text = ""
        lblProducto.Text = ""
        lblSucursal.Text = ""
        txtCriterio.Text = ""
        txtImporte.Text = "$0.00"
    End Sub

    Private Sub rbNoCliente_CheckedChanged(sender As Object, e As EventArgs) Handles rbNoCliente.CheckedChanged
        lblCriterio.Text = "Numero de Cliente"
        TipoBusqueda = 1
    End Sub

    Private Sub rbNoLC_CheckedChanged(sender As Object, e As EventArgs) Handles rbNoLC.CheckedChanged
        lblCriterio.Text = "Numero de Limite Cambiario"
        TipoBusqueda = 2
    End Sub

    Private Sub rbNoOpera_CheckedChanged(sender As Object, e As EventArgs) Handles rbNoOpera.CheckedChanged
        lblCriterio.Text = "Numero de Operacion"
        TipoBusqueda = 3
    End Sub

    Private Sub cmdBusqueda_Click(sender As Object, e As EventArgs) Handles cmdBusqueda.Click

    End Sub
End Class
