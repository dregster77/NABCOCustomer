Imports SAP.Middleware.Connector
Imports NabcoCustomer.IFfcTableExtension

Public Class SAPClass
    Implements IDestinationConfiguration
    Public RFCDEST As RfcDestination
    Public REPO As RfcRepository

    Public Shared Property CustomerData As DataTable = New DataTable()
    Public Event ConfigurationChanged As RfcDestinationManager.ConfigurationChangeHandler Implements IDestinationConfiguration.ConfigurationChanged

    Sub New()

    End Sub

    Public Sub UpdateCustomer()
        Dim func As IRfcFunction = REPO.CreateFunction("Bapi_Customer_Edit")
        func.Invoke(RFCDEST)
    End Sub

    Public Sub GetCustomerData()
        ' Dim func As IRfcFunction = REPO.CreateFunction("/SAPXCQM/GET_CUSTOMERS")
        Dim func As IRfcFunction = REPO.CreateFunction("Z_GET_CUSTOMERS ")
        func.Invoke(RFCDEST)
        My.Settings.CustomerDATARaw = ToDataTable(func.GetTable("T_Customer"), "CustomerData")

    End Sub



    Public Sub TestSAP()
        RfcDestinationManager.RegisterDestinationConfiguration(New SAPClass())
        RFCDEST = RfcDestinationManager.GetDestination("NABCO")
        REPO = RFCDEST.Repository

    End Sub

    Public Function GetParameters(destinationName As String) As RfcConfigParameters Implements IDestinationConfiguration.GetParameters
        Dim parms As New RfcConfigParameters

        ''Sandbox
        parms.Add(RfcConfigParameters.AppServerHost, "172.26.3.13")
        parms.Add(RfcConfigParameters.SystemNumber, "00")
        parms.Add(RfcConfigParameters.SystemID, "UTA")
        parms.Add(RfcConfigParameters.User, "CPQSYS")
        parms.Add(RfcConfigParameters.Password, "Driveworks2020!")
        parms.Add(RfcConfigParameters.Client, "700")
        parms.Add(RfcConfigParameters.Language, "EN")
        parms.Add(RfcConfigParameters.PoolSize, "5")
        parms.Add(RfcConfigParameters.PeakConnectionsLimit, "10")
        parms.Add(RfcConfigParameters.ConnectionIdleTimeout, "600")


        Return parms
    End Function

    Public Function ChangeEventsSupported() As Boolean Implements IDestinationConfiguration.ChangeEventsSupported

        Return False
    End Function

End Class
