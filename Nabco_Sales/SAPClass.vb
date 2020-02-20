Imports SAP.Middleware.Connector
Imports Nabco_Sales.IFfcTableExtension

Public Class SAPClass
    Implements IDestinationConfiguration
    Public RFCDEST As RfcDestination
    Public REPO As RfcRepository

    Public Shared Property CustomerData As DataTable = New DataTable()
    Public Event ConfigurationChanged As RfcDestinationManager.ConfigurationChangeHandler Implements IDestinationConfiguration.ConfigurationChanged

    Public Sub SetCustomerData()
        Dim func As IRfcFunction = REPO.CreateFunction("/SAPXCQM/GET_CUSTOMERS")
        func.Invoke(RFCDEST)
        My.Settings.CustomerDATA = ToDataTable(func.GetTable("T_Customer"), "CustomerData")
    End Sub

    Public Sub TestSAPConnection()
        Try
            RfcDestinationManager.RegisterDestinationConfiguration(New SAPClass)
            RFCDEST = RfcDestinationManager.GetDestination("NabTest")
            REPO = RFCDEST.Repository
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Public Function GetParameters(destinationName As String) As RfcConfigParameters Implements IDestinationConfiguration.GetParameters
        Dim parms As New RfcConfigParameters
        Select Case destinationName
            Case "NabTest"
                parms.Add(RfcConfigParameters.AppServerHost, "172.26.3.13")
                parms.Add(RfcConfigParameters.SystemNumber, "00")
                parms.Add(RfcConfigParameters.SystemID, "UTA")
                parms.Add(RfcConfigParameters.User, "idreger")
                parms.Add(RfcConfigParameters.Password, "Ian1234")
                parms.Add(RfcConfigParameters.Client, "700")
                parms.Add(RfcConfigParameters.Language, "EN")
                parms.Add(RfcConfigParameters.PoolSize, "5")
                parms.Add(RfcConfigParameters.PeakConnectionsLimit, "10")
                parms.Add(RfcConfigParameters.ConnectionIdleTimeout, "600")

            Case "NabUser"
                parms.Add(RfcConfigParameters.AppServerHost, "172.26.3.13")
                parms.Add(RfcConfigParameters.SystemNumber, "00")
                parms.Add(RfcConfigParameters.SystemID, "UTA")
                parms.Add(RfcConfigParameters.User, My.Settings.Sap_User)
                parms.Add(RfcConfigParameters.Password, My.Settings.sap_Pass)
                parms.Add(RfcConfigParameters.Client, "700")
                parms.Add(RfcConfigParameters.Language, "EN")
                parms.Add(RfcConfigParameters.PoolSize, "5")
                parms.Add(RfcConfigParameters.PeakConnectionsLimit, "10")
                parms.Add(RfcConfigParameters.ConnectionIdleTimeout, "600")
            Case Else
        End Select
        Return parms
    End Function

    Public Function ChangeEventsSupported() As Boolean Implements IDestinationConfiguration.ChangeEventsSupported
        Return False
    End Function



End Class
