Imports SAP.Middleware.Connector
Imports Nabco_Sales.IFfcTableExtension
Imports Telerik.WinControls.UI

Public Class frmOrder

    Private _RFCDest As RfcDestination
    Private _Repo As RfcRepository
    Private _WaitingBar As New RadWaitingBar()

    Private Sub frmOrder_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try

            RfcDestinationManager.RegisterDestinationConfiguration(New SAPConnector)
            '  Dim rfcDest As RfcDestination = RfcDestinationManager.GetDestination("NabTest")

            _RFCDest = RfcDestinationManager.GetDestination("NabTest")
            _Repo = _RFCDest.Repository

            ' GetCustList()

            '  Dim customer As Customers = New Customers()
            ' customer.GetCustomerDetails(rfcDest)
            '     System.Environment.[Exit](0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GetCustList()
        '   Dim cfg As SAPConnectionConfigurator = New SAPConnectionConfigurator()
        ' RfcDestinationManager.RegisterDestinationConfiguration(cfg)
        'Dim dest As RfcDestination = RfcDestinationManager.GetDestination("mySAPdestination"
        'Need to know the name of the FUnction or BAPI to call and insert that into the function below 
        Dim func As IRfcFunction = _Repo.CreateFunction("BAPI_CUSTOMER_FIND")
        'EXPORTING Information goes here 
        func.SetValue("MAX_CNT", "100") 'maximum number of records found 
        func.SetValue("PL_HOLD", "*")
        Dim searchFields As IRfcTable = func.GetTable("SELOPT_TAB") 'search fields
        ' Dim dt2 As DataTable = ToDataTable(customerList, "search")
        searchFields.Insert()
        'Values that i will be sending to the rfc
        searchFields.CurrentRow.SetValue("COMP_CODE", "R000")
        searchFields.CurrentRow.SetValue("TABNAME", "KNA1")
        searchFields.CurrentRow.SetValue("FIELDNAME", "NAME1")
        searchFields.CurrentRow.SetValue("FIELDVALUE", "*")
        func.Invoke(_RFCDest) 'actually executes the given funciton 
        Dim results As IRfcTable = func.GetTable("RESULT_TAB")
        Dim dt As DataTable = ToDataTable(results, "data")

        ' gvInfo.DataSource = dt
    End Sub

    Private Sub StartWaiting()
    End Sub
    Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGETlist.Click

        Dim repo As RfcRepository = _RFCDest.Repository
        'Need to know the name of the FUnction or BAPI to call and insert that into the function below 

        Dim func As IRfcFunction = repo.CreateFunction("/SAPXCQM/GET_CUSTOMERS")
        func.Invoke(_RFCDest) 'actually executes the given funciton 
        Dim results As IRfcTable = func.GetTable("T_CUSTOMER")
        Dim dt As DataTable = ToDataTable(results, "data")
        gvCustomer.DataSource = dt
        gvCustomer.EnableFiltering = True
        lblROwcount.Text = "Row Count: " & dt.Rows.Count
        ' Dim func As IRfcFunction = _RFCDest.CreateFunction("BAPI_CUSTOMER_FIND")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        '  Dim repo As RfcRepository = _RFCDest.Repository
        'Need to know the name of the FUnction or BAPI to call and insert that into the function below 
        Dim func As IRfcFunction = _Repo.CreateFunction("BAPI_CUSTOMER_FIND")
        'EXPORTING Information goes here 
        func.SetValue("MAX_CNT", "100") 'maximum number of records found 
        func.SetValue("PL_HOLD", "*")
        Dim searchFields As IRfcTable = func.GetTable("SELOPT_TAB") 'search fields
        ' Dim dt2 As DataTable = ToDataTable(customerList, "search")
        searchFields.Insert()
        'Values that i will be sending to the rfc
        searchFields.CurrentRow.SetValue("COMP_CODE", "R000")
        searchFields.CurrentRow.SetValue("TABNAME", "KNA1")
        searchFields.CurrentRow.SetValue("FIELDNAME", "NAME1")
        searchFields.CurrentRow.SetValue("FIELDVALUE", "*")
        func.Invoke(_RFCDest) 'actually executes the given funciton 
        Dim results As IRfcTable = func.GetTable("RESULT_TAB")
        Dim dt As DataTable = ToDataTable(results, "data")
        gvCustomer.DataSource = dt
        gvCustomer.EnableFiltering = True
    End Sub

    Private Sub btnOPen_Click(sender As Object, e As EventArgs) Handles btnOPen.Click
        SplashScreen1.Show()
        SplashScreen1.BringToFront()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SplashScreen1.Close()
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
