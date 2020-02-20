Imports SAP.Middleware.Connector
Imports Nabco_Sales.IFfcTableExtension
Imports Telerik.WinControls.UI
Imports System.ComponentModel

Public Class frmCustomers
    Private dt As DataTable
    Public _RFCDest As RfcDestination
    Public _Repo As RfcRepository


    Private Sub frmOrder_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' gvCustomer.DataSource = My.Settings.CustomerDATA
        dt = New DataTable
        dt = ConvertToRead()
        gvCustomer.DataSource = dt
        gvCustomer.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

    End Sub

    'This function will take in the data from SAP and output more usefull data
    Private Function ConvertToRead() As DataTable
        '   Dim temp As New DataTable
        ' temp = dt
        dt = My.Settings.CustomerDATA
        Dim colsToDelete As List(Of DataColumn) = New List(Of DataColumn)()
        For Each col As DataColumn In dt.Columns
            Select Case col.ColumnName.ToUpper
                Case "CUSTNR"
                    col.Caption = "Customer Number"
                Case "COMPANYNAME"
                    col.Caption = "Company Name"
                Case "CITY"
                    col.Caption = "City"
                Case "STREET"
                    col.Caption = "Street"
                Case "ZIP"
                    col.Caption = "ZIP"
                Case "COUNTRY"
                    col.Caption = "Country"
                Case "REGION"
                    col.Caption = "Region"
                Case "TELEF1"
                    col.Caption = "Telephone Number"
                Case Else
                    colsToDelete.Add(col)
            End Select
        Next

        For Each col In colsToDelete
            dt.Columns.Remove(col)
        Next
        Return dt
    End Function

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


    'Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGETlist.Click

    '    Dim repo As RfcRepository = _RFCDest.Repository
    '    'Need to know the name of the FUnction or BAPI to call and insert that into the function below 
    '    Dim func As IRfcFunction = repo.CreateFunction("/SAPXCQM/GET_CUSTOMERS")
    '    func.Invoke(_RFCDest) 'actually executes the given funciton 
    '    Dim results As IRfcTable = func.GetTable("T_CUSTOMER")
    '    Dim dt As DataTable = ToDataTable(results, "data")
    '    gvCustomer.DataSource = dt
    '    gvCustomer.EnableFiltering = True
    '    '    lblROwcount.Text = "Row Count: " & dt.Rows.Count

    'End Sub

    'Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnFind.Click
    '    '  Dim repo As RfcRepository = _RFCDest.Repository
    '    'Need to know the name of the FUnction or BAPI to call and insert that into the function below 
    '    Dim func As IRfcFunction = _Repo.CreateFunction("BAPI_CUSTOMER_FIND")
    '    'EXPORTING Information goes here 
    '    func.SetValue("MAX_CNT", "100") 'maximum number of records found 
    '    func.SetValue("PL_HOLD", "*")
    '    Dim searchFields As IRfcTable = func.GetTable("SELOPT_TAB") 'search fields
    '    ' Dim dt2 As DataTable = ToDataTable(customerList, "search")
    '    searchFields.Insert()
    '    'Values that i will be sending to the rfc
    '    searchFields.CurrentRow.SetValue("COMP_CODE", "R000")
    '    searchFields.CurrentRow.SetValue("TABNAME", "KNA1")
    '    searchFields.CurrentRow.SetValue("FIELDNAME", "NAME1")
    '    searchFields.CurrentRow.SetValue("FIELDVALUE", "*")
    '    func.Invoke(_RFCDest) 'actually executes the given funciton 
    '    Dim results As IRfcTable = func.GetTable("RESULT_TAB")
    '    Dim dt As DataTable = ToDataTable(results, "data")
    '    gvCustomer.DataSource = dt
    '    gvCustomer.EnableFiltering = True
    '  End Sub


    Private Sub frmOrder_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        For i As Integer = 0 To gvCustomer.Columns.Count - 1
            'gvCustomer.Columns(i).Width
        Next
    End Sub



End Class
