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

    Public Function GetCustomerData() As DataTable
        ' Dim func As IRfcFunction = REPO.CreateFunction("/SAPXCQM/GET_CUSTOMERS")

        Dim func As IRfcFunction = REPO.CreateFunction("Z_GET_CUSTOMERS ")
        'func.SetValue("I_NO_DELETED", "")
        func.Invoke(RFCDEST)
        Return ToDataTable(func.GetTable("T_Customer"), "CustomerData")
        ' My.Settings.CustomerDATARaw = ToDataTable(func.GetTable("T_Customer"), "CustomerData")

    End Function



    Public Sub TestSAP()
        RfcDestinationManager.RegisterDestinationConfiguration(New SAPClass)
        RFCDEST = RfcDestinationManager.GetDestination("QAS")
        REPO = RFCDEST.Repository

    End Sub

    Public Sub TestSAP2()
        Dim objDestConfig As New InMemoryDestinationConfiguration

        Try
            Dim parms As New RfcConfigParameters
            parms.Add(RfcConfigParameters.Name, "Sandbox")
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
            RfcDestinationManager.RegisterDestinationConfiguration(objDestConfig)
            objDestConfig.AddOrEditDestination(parms)
            RFCDEST = RfcDestinationManager.GetDestination("Sandbox")
            RFCDEST.Ping()
            REPO = RFCDEST.Repository
        Catch ex As Exception

        End Try
    End Sub

    Public Function GetParameters(destinationName As String) As RfcConfigParameters Implements IDestinationConfiguration.GetParameters
        Dim parms As New RfcConfigParameters
        Select Case destinationName
            Case "Sandbox"
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
            Case "QAS"
                ''Sandbox
                parms.Add(RfcConfigParameters.AppServerHost, "172.26.3.11")
                parms.Add(RfcConfigParameters.SystemNumber, "00")
                parms.Add(RfcConfigParameters.SystemID, "UT1")
                parms.Add(RfcConfigParameters.User, "R000-3030001")
                parms.Add(RfcConfigParameters.Password, "FluffySamer98")
                parms.Add(RfcConfigParameters.Client, "700")
                parms.Add(RfcConfigParameters.Language, "EN")
                parms.Add(RfcConfigParameters.PoolSize, "5")
                parms.Add(RfcConfigParameters.PeakConnectionsLimit, "10")
                parms.Add(RfcConfigParameters.ConnectionIdleTimeout, "600")
        End Select



        Return parms
    End Function

    Public Function ChangeEventsSupported() As Boolean Implements IDestinationConfiguration.ChangeEventsSupported

        Return False
    End Function

End Class


Public Class InMemoryDestinationConfiguration
    Implements IDestinationConfiguration
    Private availableDestinations As Dictionary(Of String, RfcConfigParameters)

    Public Sub New()
        availableDestinations = New Dictionary(Of String, RfcConfigParameters)()
    End Sub

    Public Function GetParameters(ByVal destinationName As String) As RfcConfigParameters _
    Implements IDestinationConfiguration.GetParameters
        Dim foundDestination As RfcConfigParameters = Nothing
        availableDestinations.TryGetValue(destinationName, foundDestination)
        Return foundDestination
    End Function

    Public Function ChangeEventsSupported() As Boolean _
    Implements IDestinationConfiguration.ChangeEventsSupported
        Return True
    End Function

    Public Event ConfigurationChanged As RfcDestinationManager.ConfigurationChangeHandler _
    Implements IDestinationConfiguration.ConfigurationChanged


    Public Sub AddOrEditDestination(ByVal parameters As RfcConfigParameters)
        Dim name As String = parameters(RfcConfigParameters.Name)

        If availableDestinations.ContainsKey(name) Then
            Dim EventArgs As New RfcConfigurationEventArgs(RfcConfigParameters.EventType.CHANGED, parameters)
            RaiseEvent ConfigurationChanged(name, EventArgs)
        End If

        availableDestinations(name) = parameters
        Dim tmp As String = "Application server"
        Dim isLoadValancing As Boolean = parameters.TryGetValue(RfcConfigParameters.LogonGroup, tmp)
        If isLoadValancing Then
            tmp = "Load balancing"
        End If

    End Sub

    Public Sub RemoveDestination(ByVal name As String)

        If availableDestinations.Remove(name) Then

            RaiseEvent ConfigurationChanged(name, New RfcConfigurationEventArgs(RfcConfigParameters.EventType.DELETED))

        End If
    End Sub
End Class