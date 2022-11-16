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
        If rbDia.Checked = True Then
            BusquedaMonitoreo(Now, Now)
        ElseIf rbRangoFechas.Checked = True Then
            BusquedaMonitoreo(dtFInicial.Value, dtFFinal.Value)
        End If

        If dtDetalle Is Nothing OrElse dtDetalle.Rows.Count <= 0 Then
            MsgBox("No se obtuvo Informacion para la fecha seleccionada", MsgBoxStyle.Information, "Monitoreo de Operaciones")
            cmdExportar.Enabled = False
        Else
            cmdExportar.Enabled = True
            dgvResultado.DataSource = dtBusqueda
            dgvResultado.Refresh()
        End If

    End Sub

    Private Sub cmdExportar_Click(sender As Object, e As EventArgs) Handles cmdExportar.Click
        GridExport(Me.dgvResultado)
    End Sub

    Private Sub frmMonitoreo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
    End Sub

    Private Function GridExport(ByVal DGV As DataGridView) As Boolean
        If DGV.RowCount > 0 Then
            Dim filename As String = Application.StartupPath & "\Export_" + Format(Now, "hhmmss").ToString + ".xls"
            DGV.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
            DGV.SelectAll()
            IO.File.WriteAllText(filename, DGV.GetClipboardContent().GetText.TrimEnd)
            DGV.ClearSelection()
            Process.Start(filename)
            Return True
        Else
            Return False
        End If
    End Function
End Class