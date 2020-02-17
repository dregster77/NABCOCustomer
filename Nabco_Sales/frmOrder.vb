Imports SAP.Middleware.Connector


Public Class frmOrder

    Private _RFCDest As RfcDestination


    Sub Main()

    End Sub

    Private Sub frmOrder_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try


            RfcDestinationManager.RegisterDestinationConfiguration(New SAPConnector)
            Dim rfcDest As RfcDestination = RfcDestinationManager.GetDestination("NabTest")



            Dim customer As Customers = New Customers()
            customer.GetCustomerDetails(rfcDest)
            System.Environment.[Exit](0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    'Private Sub GetCustList()
    '    Try
    '        Dim RFCDest As New RfcDestination

    '        Dim repo As RfcRepository = RFCDest.Repository
    '        Dim custlist As IRfcFunction = repo.CreateFunction("BAPI_CUSTOMER_GETLIST")
    '        custlist.Invoke(RFCDest)
    '        Dim idRange As IRfcTable = custlist.GetTable("IdRange")
    '        idRange.SetValue("SIGN", "I")
    '        idRange.SetValue("OPTION", "BT")
    '        idRange.SetValue("LOW", "")
    '        idRange.SetValue("HIGH", "999999")
    '        custlist.SetValue("idrange", idRange)
    '        Dim addressData As IRfcTable = custlist.GetTable("AddressData")
    '        custlist.Invoke(RFCDest)
    '    Catch ex As Exception
    '        MsgBox(ex.Message)

    '    End Try


    '    'System.Console.WriteLine(String.Format("Successfully connected to System {0} Client {1}.", _ecc.SystemID, _ecc.Client))
    '    'System.Console.WriteLine("Enter a company ID:")

    '    Dim companyID As String = System.Console.ReadLine()

    '        While Not String.IsNullOrEmpty(companyID.Trim)

    '            Dim CustList As IRfcFunction = _RFCDest.Repository.CreateFunction("BAPI_CUSTOMER_GETLIST")
    '            CustList.Invoke(_RFCDest)

    '        CustList.SetValue("9,999", companyID)


    '        Dim idRange As IRfcTable = CustList.GetTable("IdRange")
    '            idRange.SetValue("SIGN", "I")
    '            idRange.SetValue("OPTION", "BT")
    '            idRange.SetValue("LOW", "")
    '            idRange.SetValue("HIGH", "999999")
    '            Dim companyName As String = companyAPI.GetStructure("COMPANY_DETAIL").GetString("NAME1")

    '            If String.IsNullOrEmpty(companyName.Trim) Then
    '                companyName = "Not found"
    '            End If

    '            System.Console.WriteLine(companyName)

    '            companyID = System.Console.ReadLine()

    '        End While
    'End Sub

End Class
