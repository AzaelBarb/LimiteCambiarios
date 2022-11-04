Imports IBM.Data.Informix
Imports System.Linq
Imports System.Text
Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports Microsoft.SqlServer
Imports System.Security.Cryptography

Public Class clsConexion

    Private Shared mintTimeOut As Integer = 300
    Private Shared mobjTransaction As IfxTransaction
    Private Shared mblnDisposed As Boolean = False
    Public Shared Sub Conectar()

        strMsg = strMsg & Format(Now, "HH:mm:ss").ToString & "~" & "Conexion a Instancia: " & Server & vbNewLine
        Console.WriteLine("Conexion a Instancia: " & Server)
        Try
            ifxCadenaConexion = "Host=" & host & ";" &
                                "Server=" & server & ";" &
                                "Service=" & service & ";" &
                                "Protocol=onsoctcp;Database=" & Database & ";" &
                                "Uid=" & Uid & ";Pwd=" & psw & ";"

            IfxADOConexion = New IfxConnection(ifxCadenaConexion)
            IfxADOConexion.Open()
            Console.WriteLine("Conectado...")

        Catch ex As Exception
            strMsg = strMsg & Format(Now, "HH:mm:ss").ToString & "~" & "ERROR: " & ex.Message & vbNewLine
        End Try


    End Sub

    Public Shared Sub ExecuteSP(ByVal Tipo As String, ByVal strFolio As String)
        Try

            If Tipo = "Encabezado" Then
                Using mIfxComando As New IfxCommand
                    With mIfxComando
                        .Connection = IfxADOConexion
                        .CommandText = "bdifacturacion:sp_consulta_encabezado_factura_reproceso"
                        .CommandType = CommandType.StoredProcedure
                    End With
                    Using mIfxAdaptador As New IfxDataAdapter
                        mIfxAdaptador.SelectCommand = mIfxComando
                        mIfxAdaptador.Fill(dtDetalle)
                    End Using
                End Using
            ElseIf Tipo = "Detalle" Then
                Using mIfxComando As New IfxCommand
                    With mIfxComando
                        .Connection = IfxADOConexion
                        .CommandText = "bdifacturacion:sp_consulta_detalle_factura_reproceso"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add(New IfxParameter("pintfolio", IBM.Data.Informix.IfxType.Char))
                        .Parameters("pintfolio").Value = strFolio
                    End With
                    Using mIfxAdaptador As New IfxDataAdapter
                        mIfxAdaptador.SelectCommand = mIfxComando
                        mIfxAdaptador.Fill(dtDetalleFact)
                    End Using
                End Using

            End If

        Catch ex As Exception
            strMsg = strMsg & Format(Now, "HH:mm:ss").ToString & "~" & "ERROR: " & ex.Message & vbNewLine
        End Try

    End Sub

    Public Shared Sub Execute(ByVal Consulta As String)

        Using mIfxComando As New IfxCommand
            With mIfxComando
                .Connection = IfxADOConexion
                .CommandText = Consulta
                .CommandType = CommandType.Text

            End With
            Using mIfxAdaptador As New IfxDataAdapter
                mIfxAdaptador.SelectCommand = mIfxComando
                mIfxAdaptador.Fill(dtDetalleFact)
            End Using
        End Using

    End Sub

    Public Shared Sub ExecSP(ByVal SPName As String, Optional ByVal ParamValues() As IfxParameter = Nothing)
        Dim objCommand As IfxCommand

        Try

            If IfxADOConexion.State <> ConnectionState.Open Then
                IfxADOConexion.Open()
            End If

            objCommand = New IfxCommand(SPName, IfxADOConexion)

            objCommand.CommandType = CommandType.StoredProcedure

            If Not ParamValues Is Nothing Then
                AttachParameters(objCommand, ParamValues)
            End If

            If Not mobjTransaction Is Nothing Then
                objCommand.Transaction = mobjTransaction
            End If

            objCommand.CommandTimeout = mintTimeOut
            objCommand.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Shared Function ExecSPReturnDT(ByVal SPName As String,
                                   Optional ByVal ParamValues() As IfxParameter = Nothing,
                                    Optional ByVal TableName As String = "Table") As DataTable

        Dim objCommand As IfxCommand
        Dim objDA As IfxDataAdapter
        Dim objDT As New DataTable

        Try

            If IfxADOConexion.State <> ConnectionState.Open Then
                IfxADOConexion.Open()
            End If


            objCommand = New IfxCommand(SPName, IfxADOConexion)
            objCommand.CommandTimeout = mintTimeOut
            objCommand.CommandType = CommandType.StoredProcedure

            'Construyo Parametros
            If Not ParamValues Is Nothing Then
                AttachParameters(objCommand, ParamValues)
            End If

            If Not mobjTransaction Is Nothing Then
                objCommand.Transaction = mobjTransaction
            End If

            objDA = New IfxDataAdapter(objCommand)

            'Lleno DataTable
            objDA.Fill(objDT)
            objDT.TableName = TableName

            'Return the value
            Return objDT

        Catch objException As Exception
            Throw objException
        End Try

    End Function

    Private Shared Sub AttachParameters(ByVal command As IfxCommand, ByVal commandParameters() As IfxParameter)
        Dim p As IfxParameter
        For Each p In commandParameters
            'check for derived output value with no value assigned
            If p.Direction = ParameterDirection.InputOutput And p.Value Is Nothing Then
                p.Value = Nothing
            End If
            command.Parameters.Add(p)
        Next p
    End Sub

    Public Shared Sub ExecSQL(ByVal strSQL As String)
        Dim objCommand As IfxCommand

        Try

            If IfxADOConexion.State <> ConnectionState.Open Then
                IfxADOConexion.Open()
            End If

            objCommand = New IfxCommand(strSQL, IfxADOConexion)
            objCommand.CommandTimeout = mintTimeOut
            objCommand.CommandType = CommandType.Text

            If Not mobjTransaction Is Nothing Then
                objCommand.Transaction = mobjTransaction
            End If

            objCommand.ExecuteNonQuery()

        Catch objException As Exception

            Throw objException

        End Try

    End Sub

    Public Shared Function ExecSQLReturnDT(ByVal strSQL As String, Optional ByVal TableName As String = "NewTable") As DataTable

        Dim objCommand As IfxCommand
        Dim objDA As IfxDataAdapter
        Dim objDT As New DataTable

        Try

            If IfxADOConexion.State <> ConnectionState.Open Then
                IfxADOConexion.Open()
            End If

            objCommand = New IfxCommand(strSQL, IfxADOConexion)
            objCommand.CommandTimeout = 300
            objCommand.CommandType = CommandType.Text

            If Not mobjTransaction Is Nothing Then
                objCommand.Transaction = mobjTransaction
            End If

            objDA = New IfxDataAdapter(objCommand)

            objDA.Fill(objDT)
            objDT.TableName = TableName

            Return objDT

        Catch objException As Exception

            Throw objException


        End Try

    End Function

End Class
