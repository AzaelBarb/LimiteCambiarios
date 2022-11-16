Imports IBM.Data.Informix

Module modMain

#Region "VariablesGlobales"

    'BANCO
    Public server As String = "bcoltp_shm"
    Public psw As String = "8AnCre4&"
    Public Database As String = "bdifacturacion"
    Public Uid As String = "informix"
    Public service As String = "19001"
    Public host As String = "10.19.3.1"

    'ARRENDADORA
    'Public server As String = "arrendabcoltp_tcp"
    'Public psw As String = "8AnCre4&"
    'Public Database As String = "bdinteg"
    'Public Uid As String = "informix"
    'Public service As String = "20001"
    'Public host As String = "10.19.3.4"

    'Variables
    Public IfxADOConexion As IfxConnection
    Public ifxCadenaConexion As String
    Public strMsg As String
    Public dtDetalle As New DataTable
    Public dtDetalleLM As New DataTable
    Public dtResult As New DataTable
    Public dtDetalleFact As New DataTable
    Public dtUpdate As New DataTable
    Public dtBusqueda As New DataTable
    Public dtEnviar As New DataTable
    Public intRegistro As Integer
    Public strFolio As String
    Public dsDevs As DataSet
    Public sSQL As String
    Public strRutaLog As String
    Public Proceso As String

#End Region

    Public Sub AbrirConexion()
        Try
            clsConexion.Conectar()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, frmCobranza.Text)
        End Try
    End Sub

    Public Sub BusquedaInfo(ByVal TipoBusqueda As Integer, ByVal Valor As String)
        Dim oParam(3) As IfxParameter

        sSQL = "bdilimcamb:blc_consulta"
        oParam(0) = New IfxParameter("etipobusq", TipoBusqueda)
        oParam(1) = New IfxParameter("enumcte", Valor)
        oParam(2) = New IfxParameter("enumlc", Valor)
        oParam(3) = New IfxParameter("enumoper", Valor)
        dtDetalle = clsConexion.ExecSPReturnDT(sSQL, oParam, "Resultado")

    End Sub


    Public Sub BusquedaMonitoreo(ByVal FechaIni As Date, ByVal FechaFin As Date)
        Dim oParam(1) As IfxParameter

        sSQL = "bdilimcamb:blc_spmonitoroper"
        oParam(0) = New IfxParameter("pfechaini", FechaIni)
        oParam(1) = New IfxParameter("pfechafin", FechaFin)
        dtDetalle = clsConexion.ExecSPReturnDT(sSQL, oParam, "Resultado")
    End Sub

    Public Sub BusquedaLC(ByVal Solicitud As String)
        Dim oParam(0) As IfxParameter

        sSQL = "bdilimcamb:blc_consultalm"
        oParam(0) = New IfxParameter("numsolicitud", Solicitud)
        dtDetalleLM = clsConexion.ExecSPReturnDT(sSQL, oParam, "Resultado")
    End Sub




End Module
