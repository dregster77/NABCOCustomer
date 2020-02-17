Imports SAP.Middleware.Connector

Public Class SAPConnector
    Implements IDestinationConfiguration


    Public Event ConfigurationChanged As RfcDestinationManager.ConfigurationChangeHandler Implements IDestinationConfiguration.ConfigurationChanged

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
            Case Else

        End Select
        Return parms
    End Function

    Public Function ChangeEventsSupported() As Boolean Implements IDestinationConfiguration.ChangeEventsSupported
        Return False
    End Function
End Class
