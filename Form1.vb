
Imports IBM.Data.Informix
Public Class frmCobranza
    Dim numSoli As String
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
        TipoBusqueda = 2
    End Sub

    Private Sub rbNoLC_CheckedChanged(sender As Object, e As EventArgs) Handles rbNoLC.CheckedChanged
        lblCriterio.Text = "Numero de Limite Cambiario"
        TipoBusqueda = 1
    End Sub

    Private Sub rbNoOpera_CheckedChanged(sender As Object, e As EventArgs) Handles rbNoOpera.CheckedChanged
        lblCriterio.Text = "Numero de Operacion"
        TipoBusqueda = 3
    End Sub

    Private Sub cmdBusqueda_Click(sender As Object, e As EventArgs) Handles cmdBusqueda.Click
        Try
            BusquedaInfo(TipoBusqueda, txtCriterio.Text)

            dgvResultado.DataSource = dtDetalle
            dgvResultado.Refresh()

            dgvResultado.Columns.Item(0).Visible = False
            dgvResultado.Columns.Item(1).Visible = False
            dgvResultado.Columns.Item(2).HeaderText = "Numero de LC"
            dgvResultado.Columns.Item(3).HeaderText = "Nombre del Cliente"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvResultado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResultado.CellContentClick

    End Sub

    Private Sub dgvResultado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResultado.CellDoubleClick
        Dim i As Integer
        Dim solicitud As String
        Dim drDetalle As DataRow


        i = dgvResultado.CurrentRow.Index
        numSoli = dgvResultado.Item(2, i).Value

        BusquedaLC(numSoli)


        If dtDetalleLM Is Nothing OrElse dtDetalleLM.Rows.Count <= 0 Then
            MsgBox("No se obtuvo Informacion", MsgBoxStyle.Information, "Cobranza Operaciones")
        Else
            drDetalle = dtDetalleLM.Rows(0)

            lblNoCliente.Text = drDetalle("numerocliente").ToString.Trim.ToUpper()
            lblMontoOtor.Text = 0
            lblEstatusLC.Text = drDetalle("estatus").ToString.Trim.ToUpper()
            lblFechaApert.Text = drDetalle("fechaapertura").ToString.Trim.ToUpper()
            lblFechaOrig.Text = drDetalle("fechaapertura").ToString.Trim.ToUpper()
            lblImporteVenci.Text = 1000
            lblNoLC.Text = drDetalle("numerolimitecambiario").ToString.Trim.ToUpper()
            lblNombreCliente.Text = drDetalle("nombrecliente").ToString.Trim.ToUpper()
            lblProducto.Text = drDetalle("nombreproducto").ToString.Trim.ToUpper()
            lblSucursal.Text = ""
            lblDivisa.Text = drDetalle("moneda").ToString.Trim.ToUpper()
            txtComentarios.Text = drDetalle("comentarios").ToString.Trim.ToUpper()

            cboNumeroCuenta.Items.Add(drDetalle("vcuenta").ToString.Trim.ToUpper())
        End If

    End Sub

    Private Sub cmdAplicarPago_Click(sender As Object, e As EventArgs) Handles cmdAplicarPago.Click
        Dim oParam(13) As IfxParameter
        Dim drDetalle As DataRow

        sSQL = "bdilimcamb:blc_spaltapago"
        oParam(0) = New IfxParameter("empresa", "001")
        oParam(1) = New IfxParameter("idpago", 1)
        oParam(2) = New IfxParameter("numsolicitud", numSoli)
        oParam(3) = New IfxParameter("fechapago", Now.Date)
        oParam(4) = New IfxParameter("monto", CDec(txtImporte.Text))
        oParam(5) = New IfxParameter("divisa", lblDivisa.Text)
        oParam(6) = New IfxParameter("comentarios", txtComentarios.Text)
        oParam(7) = New IfxParameter("estatus", "OK")
        oParam(8) = New IfxParameter("fechainsert", Now.Date)
        oParam(9) = New IfxParameter("horainsert", Mid(Now.TimeOfDay.ToString, 1, 8))
        oParam(10) = New IfxParameter("userinsert", "0001")
        oParam(11) = New IfxParameter("fechaautoriza", Now.Date)
        oParam(12) = New IfxParameter("horaautoriza", Mid(Now.TimeOfDay.ToString, 1, 8))
        oParam(13) = New IfxParameter("userautoriza", "0001")

        dtResult = clsConexion.ExecSPReturnDT(sSQL, oParam, "Resultado")

        If dtResult Is Nothing OrElse dtResult.Rows.Count <= 0 Then
            MsgBox("Ocurrio un Problema al realizar el Pago", MsgBoxStyle.Information, "Cobranza")
        Else
            drDetalle = dtResult.Rows(0)
            If drDetalle("o_cod_ret").ToString.Trim.ToUpper() = "00000" Then
                MsgBox("Se registro pago correctamente", MsgBoxStyle.Information, "Cobranza")
            End If
        End If
    End Sub
End Class
