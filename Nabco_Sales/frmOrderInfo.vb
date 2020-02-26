Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports System.Linq
Imports Telerik.WinControls.Data

Public Class frmOrderInfo

#Region "Form Level"
    Public searchrowinfo As GridViewRowInfo

    ' Private custDT As DataTable
    Private filterDTSold As DataTable
    Private filterDTShip As DataTable
    Private chkToClose As Boolean
    Private soldFilter As GridViewFilterDescriptorCollection

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
    End Sub



    Private Sub frmOrderInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load a fresh datatable with customers
        filterDTSold = New DataTable
        filterDTSold = My.Settings.CustomerDATARaw.Copy()
        filterDTShip = New DataTable
        filterDTShip = My.Settings.CustomerDATARaw.Copy()
        'TestingLinqQuery()

        'force the pageview to be expanded
        Dim navele = TryCast(Me.pvOrderInfo.ViewElement, RadPageViewNavigationViewElement)
        navele.Expand()
        PopDistChannels()

        PopAutCompleteSold(SAPClass.CleanCustomerData(filterDTSold))
        RadDropDownList1.AutoCompleteDataSource = My.Settings.CustomerDATARaw
        RadDropDownList1.AutoCompleteDisplayMember = "COMPANYNAME"


    End Sub

    Private Sub PopDistChannels()
        Dim view As DataView = My.Settings.CustomerDATARaw.DefaultView
        Dim dt As New DataTable
        dt = view.ToTable(True, "VTWEG")
        'Dim distchannel = (From rows In My.Settings.CustomerDATARaw Select rows.Field(Of String)("VTWEG").Distinct.ToList)


        ddlDistChannelSoldTP.DataSource = dt
        ddlDistChannelSoldTP.DisplayMember = "VTWEG"
        ddlDistChannelShipTP.DataSource = dt
        ddlDistChannelShipTP.DisplayMember = "VTWEG"

    End Sub
#End Region

#Region "Sales and Shipping Details"

    Private Sub chkMatchShip_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles chkMatchShip.ToggleStateChanged
        If chkMatchShip.Checked = True Then
            txtAddr1ShipTP.Text = txtAddr1SoldTP.Text
            txtCityShipTP.Text = txtCitySoldTP.Text
            txtCountryShipTP.Text = txtCountrySoldTP.Text
            txtCustNoShipTP.Text = txtCustNoSoldTP.Text
            txtCustShipTP.Text = txtCustSoldTP.Text
            txtRegionShipTP.Text = txtRegionSoldTP.Text
            txtZipShipTP.Text = txtZipSoldTP.Text
            ddlDistChannelShipTP.SelectedValue = ddlDistChannelSoldTP.SelectedValue
        End If
    End Sub

    Private Sub FilterSoldParty()
        Dim Results = From ROW In filterDTSold Select ROW

        If txtCitySoldTP.Text <> "" Then
            Results = Results.Where(Function(X) X.Field(Of String)("CITY").ToUpper.Contains(txtCitySoldTP.Text.ToUpper))
        End If
        If txtRegionSoldTP.Text <> "" Then
            Results = Results.Where(Function(X) X.Field(Of String)("REGION").ToUpper.Contains(txtRegionSoldTP.Text.ToUpper))
        End If
        If txtCountrySoldTP.Text <> "" Then
            Results = Results.Where(Function(X) X.Field(Of String)("COUNTRY").ToUpper.Contains(txtCountrySoldTP.Text.ToUpper))
        End If
        If txtCountrySoldTP.Text <> "" Then
            Results = Results.Where(Function(X) X.Field(Of String)("COUNTRY").ToUpper.Contains(txtCountrySoldTP.Text.ToUpper))
        End If
        If txtZipSoldTP.Text <> "" Then
            Results = Results.Where(Function(X) X.Field(Of String)("ZIP").ToUpper.Contains(txtZipSoldTP.Text.ToUpper))
        End If
        If txtCustSoldTP.Text <> "" Then
            Results = Results.Where(Function(X) X.Field(Of String)("COMPANYNAME").ToUpper.Contains(txtCustSoldTP.Text.ToUpper))
        End If

        If Results.Count > 0 Then
            If Results.Count = 1 Then
                txtCustSoldTP.Text = Results.ElementAt(0)("COMPANYNAME")
                txtCustNoSoldTP.Text = Results.ElementAt(0)("CUSTNR")
                '   txtcu
            End If
            gvCustomer.DataSource = SAPClass.CleanCustomerData(Results.CopyToDataTable)
            gvCustomer.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        Else
            MsgBox("No Company matches your search")
        End If
    End Sub

    Private Sub txtRegionSoldTP_LostFocus(sender As Object, e As EventArgs) Handles txtRegionSoldTP.LostFocus
        FilterSoldParty()
    End Sub

    Private Sub txtCitySoldTP_LostFocus(sender As Object, e As EventArgs) Handles txtCitySoldTP.LostFocus
        FilterSoldParty()
    End Sub

    Private Sub FilterCustomers(ByVal shipsold As String, ByVal fltrval As String)
        ' Dim res = From filterdtship
        Dim Results = From ROW In filterDTSold Select ROW

        If txtCitySoldTP.Text <> "" Then
            Results = Results.Where(Function(X) X.Field(Of String)("CITY").ToUpper.Contains(txtCitySoldTP.Text.ToUpper))
        End If
        If txtRegionSoldTP.Text <> "" Then
            Results = Results.Where(Function(X) X.Field(Of String)("REGION").ToUpper.Contains(txtRegionSoldTP.Text.ToUpper))
        End If
        If txtCountrySoldTP.Text <> "" Then
            Results = Results.Where(Function(X) X.Field(Of String)("COUNTRY").ToUpper.Contains(txtCountrySoldTP.Text.ToUpper))
        End If
        If txtCountrySoldTP.Text <> "" Then
            Results = Results.Where(Function(X) X.Field(Of String)("COUNTRY").ToUpper.Contains(txtCountrySoldTP.Text.ToUpper))
        End If
        If txtZipSoldTP.Text <> "" Then
            Results = Results.Where(Function(X) X.Field(Of String)("ZIP").ToUpper.Contains(txtZipSoldTP.Text.ToUpper))
        End If
        If txtCustSoldTP.Text <> "" Then
            Results = Results.Where(Function(X) X.Field(Of String)("COMPANYNAME").ToUpper.Contains(txtCustSoldTP.Text.ToUpper))
        End If

        If Results.Count > 0 Then
            If Results.Count = 1 Then
                txtCustSoldTP.Text = Results.ElementAt(0)("COMPANYNAME")
                txtCustNoSoldTP.Text = Results.ElementAt(0)("CUSTNR")
            End If
            gvCustomer.DataSource = SAPClass.CleanCustomerData(Results.CopyToDataTable)
            gvCustomer.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        Else
            MsgBox("No Company matches your search")
        End If
        PopAutCompleteSold(SAPClass.CleanCustomerData(Results.CopyToDataTable))
        'Dim fltrSTR As String = ""

        'If shipsold = "SOLD" Then
        '    If txtAddr1SoldTP.Text <> "" Then fltrSTR = " STREET LIKE '" & txtAddr1SoldTP.Text & "' and "
        '    If txtCitySoldTP.Text <> "" Then fltrSTR = " CITY LIKE '" & txtCitySoldTP.Text & "' and"
        '    If txtCountrySoldTP.Text <> "" Then fltrSTR = " COUNTRY  LIKE '" & txtCountrySoldTP.Text & "' and"
        '    If txtCustNoSoldTP.Text <> "" Then fltrSTR = " CUSTNR LIKE '" & txtCustNoSoldTP.Text & "' and"
        '    If txtCustSoldTP.Text <> "" Then fltrSTR = " COMPANYNAME LIKE '" & txtCustSoldTP.Text & "' and"
        '    If txtRegionSoldTP.Text <> "" Then fltrSTR = " REGION LIKE '" & txtRegionSoldTP.Text & "' and"
        '    If txtZipSoldTP.Text <> "" Then fltrSTR = " ZIP LIKE '" & txtZipSoldTP.Text & "' and"
        'End If

        'If shipsold = "SHIP" Then

        '    If txtAddr1ShipTP.Text <> "" Then fltrSTR = " STREET LIKE '" & txtAddr1ShipTP.Text & "' and "
        '    If txtCityShipTP.Text <> "" Then fltrSTR = " CITY LIKE '" & txtCityShipTP.Text & "' and"
        '    If txtCountryShipTP.Text <> "" Then fltrSTR = " COUNTRY  LIKE '" & txtCountryShipTP.Text & "' and"
        '    If txtCustNoShipTP.Text <> "" Then fltrSTR = " CUSTNR LIKE '" & txtCustNoShipTP.Text & "' and"
        '    If txtCustShipTP.Text <> "" Then fltrSTR = " COMPANYNAME LIKE '" & txtCustShipTP.Text & "' and"
        '    If txtRegionShipTP.Text <> "" Then fltrSTR = " REGION LIKE '" & txtRegionShipTP.Text & "' and"
        '    If txtZipShipTP.Text <> "" Then fltrSTR = " ZIP LIKE '" & txtZipShipTP.Text & "' and"
        'End If

        'fltrSTR = fltrSTR.Remove(fltrSTR.Length - 4, 4)

        'If shipsold = "SHIP" Then
        '    filterDTShip.DefaultView.RowFilter = fltrSTR
        '    If filterDTShip.DefaultView.Count = 1 Then
        '        txtAddr1ShipTP.Text = filterDTShip.DefaultView(0)("STREET")
        '        txtCityShipTP.Text = filterDTShip.DefaultView(0)("CITY")
        '        txtCountryShipTP.Text = filterDTShip.DefaultView(0)("COUNTRY")
        '        txtCustNoShipTP.Text = filterDTShip.DefaultView(0)("CUSTNR")
        '        txtRegionShipTP.Text = filterDTShip.DefaultView(0)("REGION")
        '        txtZipShipTP.Text = filterDTShip.DefaultView(0)("ZIP")
        '        txtCustShipTP.Text = filterDTShip.DefaultView(0)("COMPANYNAME")
        '    Else
        '        PopAutCompleteShip(filterDTShip)
        '    End If
        'ElseIf shipsold = "SOLD" Then
        '    filterDTSold.DefaultView.RowFilter = fltrSTR
        '    If filterDTSold.DefaultView.Count = 1 Then
        '        txtAddr1SoldTP.Text = filterDTSold.DefaultView(0)("STREET")
        '        txtCitySoldTP.Text = filterDTSold.DefaultView(0)("CITY")
        '        txtCountrySoldTP.Text = filterDTSold.DefaultView(0)("COUNTRY")
        '        txtCustNoSoldTP.Text = filterDTSold.DefaultView(0)("CUSTNR")
        '        txtRegionSoldTP.Text = filterDTSold.DefaultView(0)("REGION")
        '        txtZipSoldTP.Text = filterDTSold.DefaultView(0)("ZIP")
        '        txtCustSoldTP.Text = filterDTSold.DefaultView(0)("COMPANYNAME")
        '    Else
        '        PopAutCompleteSold(filterDTSold)
        '    End If
        'End If

    End Sub


    'dynamic Txt box filtering
    Private Sub PopAutCompleteSold(ByVal data As DataTable)
        'COMPANYNAME
        txtCustSoldTP.AutoCompleteDataSource = data
        txtCustSoldTP.AutoCompleteDisplayMember = "COMPANYNAME"

        'ADDRESS
        txtAddr1SoldTP.AutoCompleteDataSource = data
        txtAddr1SoldTP.AutoCompleteDisplayMember = "STREET"

        'CITY
        txtCitySoldTP.AutoCompleteDataSource = data
        txtCitySoldTP.AutoCompleteDisplayMember = "CITY"

        'COUNTRY

        txtCountrySoldTP.AutoCompleteDataSource = data
        txtCountrySoldTP.AutoCompleteDisplayMember = "COUNTRY"

        'ZIP
        txtZipSoldTP.AutoCompleteDataSource = data
        txtZipSoldTP.AutoCompleteDisplayMember = "ZIP"

        'REGIOIN
        txtRegionSoldTP.AutoCompleteDataSource = data
        txtRegionSoldTP.AutoCompleteDisplayMember = "REGION"

        'COMPANYNO
        txtCustNoSoldTP.AutoCompleteDataSource = data
        txtCustNoSoldTP.AutoCompleteDisplayMember = "CUSTNR"

    End Sub

    Private Sub PopAutCompleteShip(ByVal data As DataTable)
        'COMPANYNAME
        txtCustShipTP.AutoCompleteDataSource = data
        txtCustShipTP.AutoCompleteDisplayMember = "COMPANYNAME"

        'ADDRESS
        txtAddr1ShipTP.AutoCompleteDataSource = data
        txtAddr1ShipTP.AutoCompleteDisplayMember = "STREET"

        'CITY
        txtCityShipTP.AutoCompleteDataSource = data
        txtCityShipTP.AutoCompleteDisplayMember = "CITY"

        'COUNTRY
        txtCountryShipTP.AutoCompleteDataSource = data
        txtCountryShipTP.AutoCompleteDisplayMember = "COUNTRY"

        'ZIP
        txtZipShipTP.AutoCompleteDataSource = data
        txtZipShipTP.AutoCompleteDisplayMember = "ZIP"

        'REGIOIN
        txtRegionShipTP.AutoCompleteDataSource = data
        txtRegionShipTP.AutoCompleteDisplayMember = "REGION"

        'COMPANYNO
        txtCustNoShipTP.AutoCompleteDataSource = data
        txtCustNoShipTP.AutoCompleteDisplayMember = "CUSTNR"

    End Sub

    Private Sub txtAddr1ShipTP_LostFocus(sender As Object, e As EventArgs) Handles txtAddr1ShipTP.LostFocus
        If txtAddr1ShipTP.ListElement.SelectedItem IsNot Nothing Then
            FilterCustomers("SHIP", txtAddr1ShipTP.ListElement.SelectedItem.Text)
        End If
    End Sub


    Private Sub txtCityShipTP_LostFocus(sender As Object, e As EventArgs) Handles txtCityShipTP.LostFocus
        'If txtCityShipTP.ListElement.SelectedItem IsNot Nothing Then
        '    FilterCustomers("SHIP", txtCityShipTP.ListElement.SelectedItem.Text)
        'End If
    End Sub

    Private Sub txtCountryShipTP_LostFocus(sender As Object, e As EventArgs) Handles txtCountryShipTP.LostFocus

    End Sub

    Private Sub txtCountrySoldTP_LostFocus(sender As Object, e As EventArgs) Handles txtCountrySoldTP.LostFocus

        FilterSoldParty()
    End Sub

    Private Sub txtCustNoShipTP_LostFocus(sender As Object, e As EventArgs) Handles txtCustNoShipTP.LostFocus

    End Sub

    Private Sub txtCustNoSoldTP_LostFocus(sender As Object, e As EventArgs) Handles txtCustNoSoldTP.LostFocus

        FilterSoldParty()
    End Sub

    Private Sub txtCustShipTP_LostFocus(sender As Object, e As EventArgs) Handles txtCustShipTP.LostFocus

    End Sub

    Private Sub txtCustSoldTP_LostFocus(sender As Object, e As EventArgs) Handles txtCustSoldTP.LostFocus

        FilterSoldParty()
    End Sub

    Private Sub txtRegionShipTP_LostFocus(sender As Object, e As EventArgs) Handles txtRegionShipTP.LostFocus

    End Sub

    Private Sub txtZipShipTP_LostFocus(sender As Object, e As EventArgs) Handles txtZipShipTP.LostFocus

    End Sub

    Private Sub txtZipSoldTP_LostFocus(sender As Object, e As EventArgs) Handles txtZipSoldTP.LostFocus

        FilterSoldParty()
    End Sub

    Private Sub btnClearSold_Click(sender As Object, e As EventArgs) Handles btnClearSold.Click
        txtCustNoSoldTP.Text = ""
        txtCustSoldTP.Text = ""
        txtAddr1SoldTP.Text = ""
        txtCitySoldTP.Text = ""
        txtRegionSoldTP.Text = ""
        txtCountrySoldTP.Text = ""
        txtZipSoldTP.Text = ""
    End Sub

    Private Sub btnClearShip_Click(sender As Object, e As EventArgs) Handles btnClearShip.Click
        txtCustNoShipTP.Text = ""
        txtCustShipTP.Text = ""
        txtAddr1ShipTP.Text = ""
        txtCityShipTP.Text = ""
        txtRegionShipTP.Text = ""
        txtCountryShipTP.Text = ""
        txtZipShipTP.Text = ""
    End Sub

    Private Sub btnSoldTP_Click(sender As Object, e As EventArgs) Handles btnSoldTP.Click
        gvCustomer.Visible = True
        gvCustomer.Location = Label1.Location
        lblCallingbtn.Text = "SOLD"
    End Sub


    Private Sub gvCustomer_DoubleClick(sender As Object, e As EventArgs) Handles gvCustomer.DoubleClick

        If gvCustomer.CurrentRow IsNot Nothing Then
            If lblCallingbtn.Text = "SOLD" Then
                txtAddr1SoldTP.Text = gvCustomer.CurrentRow.Cells("STREET").Value
                txtCustSoldTP.Text = gvCustomer.CurrentRow.Cells("COMPANYNAME").Value
                txtCustNoSoldTP.Text = gvCustomer.CurrentRow.Cells("CUSTNR").Value
                txtCitySoldTP.Text = gvCustomer.CurrentRow.Cells("CITY").Value
                txtZipSoldTP.Text = gvCustomer.CurrentRow.Cells("ZIP").Value
                txtRegionSoldTP.Text = gvCustomer.CurrentRow.Cells("REGION").Value
                txtCountrySoldTP.Text = gvCustomer.CurrentRow.Cells("COUNTRY").Value
                For I As Integer = 0 To ddlDistChannelSoldTP.Items.Count - 1
                    If ddlDistChannelSoldTP.Items(I).Text = gvCustomer.CurrentRow.Cells("VTWEG").Value Then
                        ddlDistChannelSoldTP.SelectedIndex = I
                    End If
                Next

            Else
                txtAddr1ShipTP.Text = gvCustomer.CurrentRow.Cells("STREET").Value
                txtCustShipTP.Text = gvCustomer.CurrentRow.Cells("COMPANYNAME").Value
                txtCustNoShipTP.Text = gvCustomer.CurrentRow.Cells("CUSTNR").Value
                txtCityShipTP.Text = gvCustomer.CurrentRow.Cells("CITY").Value
                txtZipShipTP.Text = gvCustomer.CurrentRow.Cells("ZIP").Value
                txtRegionShipTP.Text = gvCustomer.CurrentRow.Cells("REGION").Value
                txtCountryShipTP.Text = gvCustomer.CurrentRow.Cells("COUNTRY").Value
                For I As Integer = 0 To ddlDistChannelShipTP.Items.Count - 1
                    If ddlDistChannelShipTP.Items(I).Text = gvCustomer.CurrentRow.Cells("VTWEG").Value Then
                        ddlDistChannelShipTP.SelectedIndex = I
                    End If
                Next
                ddlDistChannelShipTP.SelectedValue = gvCustomer.CurrentRow.Cells("VTWEG").Value

            End If
            gvCustomer.Visible = False
        End If

    End Sub

    Private Sub btnShipTP_Click(sender As Object, e As EventArgs) Handles btnShipTP.Click
        gvCustomer.Visible = True
        gvCustomer.Location = Label1.Location
        lblCallingbtn.Text = "sHIP"
    End Sub

    Private Sub txtCustSoldTP_GotFocus(sender As Object, e As EventArgs) Handles txtCustSoldTP.GotFocus
        txtCustSoldTP.LoadElementTree()
    End Sub





    '  This Is the Event that Is called when the user selects a items for the autopop
    'Private Sub txtCitySoldEle(ByVal sender As Object, ByVal e As EventArgs)
    '    Dim elementTree As ComponentThemableElementTree = txtCitySoldTP.ListElement.ElementTree
    '    Dim mousePosition As Point = elementTree.Control.PointToClient(Control.MousePosition)
    '    Dim element As RadElement = elementTree.GetElementAtPoint(mousePosition)
    '    While element IsNot Nothing
    '        Dim item As RadListVisualItem = TryCast(element, RadListVisualItem)

    '        If item IsNot Nothing Then
    '            FilterCustomers("SOLD", item.Text)
    '            Exit While
    '        End If

    '        element = element.Parent
    '    End While
    'End Sub

    'Private Sub txtCountrySoldEle(ByVal sender As Object, ByVal e As EventArgs)
    '    Dim elementTree As ComponentThemableElementTree = txtCountrySoldTP.ListElement.ElementTree
    '    Dim mousePosition As Point = elementTree.Control.PointToClient(Control.MousePosition)
    '    Dim element As RadElement = elementTree.GetElementAtPoint(mousePosition)
    '    While element IsNot Nothing
    '        Dim item As RadListVisualItem = TryCast(element, RadListVisualItem)

    '        If item IsNot Nothing Then
    '            FilterCustomers("SOLD", item.Text)
    '            Exit While
    '        End If

    '        element = element.Parent
    '    End While
    'End Sub

    'Private Sub txtRegionSoldEle(ByVal sender As Object, ByVal e As EventArgs)
    '    Dim elementTree As ComponentThemableElementTree = txtRegionSoldTP.ListElement.ElementTree
    '    Dim mousePosition As Point = elementTree.Control.PointToClient(Control.MousePosition)
    '    Dim element As RadElement = elementTree.GetElementAtPoint(mousePosition)
    '    While element IsNot Nothing
    '        Dim item As RadListVisualItem = TryCast(element, RadListVisualItem)

    '        If item IsNot Nothing Then
    '            FilterCustomers("SOLD", item.Text)
    '            Exit While
    '        End If

    '        element = element.Parent
    '    End While
    'End Sub

    'Private Sub txtCus(ByVal sender As Object, ByVal e As EventArgs)
    '    Dim elementTree As ComponentThemableElementTree = txtCitySoldTP.ListElement.ElementTree
    '    Dim mousePosition As Point = elementTree.Control.PointToClient(Control.MousePosition)
    '    Dim element As RadElement = elementTree.GetElementAtPoint(mousePosition)
    '    While element IsNot Nothing
    '        Dim item As RadListVisualItem = TryCast(element, RadListVisualItem)

    '        If item IsNot Nothing Then
    '            FilterCustomers("SOLD", item.Text)
    '            Exit While
    '        End If

    '        element = element.Parent
    '    End While
    'End Sub


#End Region

#Region "Quote Details"

#End Region

#Region "Upload PO and Documents"

#End Region

#Region "Products"

#End Region
End Class
