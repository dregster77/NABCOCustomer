Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class frmOrderInfoBackup

#Region "Form Level"
    Public searchrowinfo As GridViewRowInfo
    ' Private custDT As DataTable
    Private filterDTSold As DataTable
    Private filterDTShip As DataTable
    Private chkToClose As Boolean
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'AddHandler txtCityShipTP.TextBoxElement.AutoCompleteDropDown.PopupClosed, AddressOf txtCityShipTP_AutocompleteSelect
        'AddHandler txtCitySoldTP.TextBoxElement.AutoCompleteDropDown.PopupClosed, AddressOf txtCitySoldTP_AutocompleteSelect
        'AddHandler txtCountryShipTP.TextBoxElement.AutoCompleteDropDown.PopupClosed, AddressOf txtCountryShipTP_AutocompleteSelect
        'AddHandler txtCountrySoldTP.TextBoxElement.AutoCompleteDropDown.PopupClosed, AddressOf txtCountrySoldTP_AutocompleteSelect
        'AddHandler txtZipSoldTP.TextBoxElement.AutoCompleteDropDown.PopupClosed, AddressOf txtZipSoldTP_AutocompleteSelect
        'AddHandler txtZipShipTP.TextBoxElement.AutoCompleteDropDown.PopupClosed, AddressOf txtZipShipTP_AutocompleteSelect
        'AddHandler txtCityShipTP.TextBoxElement.AutoCompleteDropDown.PopupClosed, AddressOf txtCityShipTP_AutocompleteSelect

        'AddHandler txtCityShipTP.TextBoxElement.AutoCompleteDropDown.PopupClosed, AddressOf txtCityShipTP_AutocompleteSelect
        'AddHandler txtCityShipTP.TextBoxElement.AutoCompleteDropDown.PopupClosed, AddressOf txtCityShipTP_AutocompleteSelect
        'AddHandler txtCityShipTP.TextBoxElement.AutoCompleteDropDown.PopupClosed, AddressOf txtCityShipTP_AutocompleteSelect
        'AddHandler txtCityShipTP.TextBoxElement.AutoCompleteDropDown.PopupClosed, AddressOf txtCityShipTP_AutocompleteSelect

        '  AddHandler txtCitySoldTP.ListElement.ElementTree.Control.Click, AddressOf txtCitySoldEle

        '  Me.txtCustSoldTP.ListElement.ElementTree.Control.Click += AddressOf Me.OnListElementClick
    End Sub



    Private Sub frmOrderInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load a fresh datatable with customers
        filterDTSold = New DataTable
        filterDTSold = My.Settings.CustomerDATARaw.Copy()
        filterDTShip = New DataTable
        filterDTShip = My.Settings.CustomerDATARaw.Copy()


        'force the pageview to be expanded
        Dim navele = TryCast(Me.pvOrderInfo.ViewElement, RadPageViewNavigationViewElement)
        navele.Expand()

        'Add later as an update
        PopAutCompleteShip(filterDTSold)
        PopAutCompleteSold(filterDTShip)
        ddlSalesOffice.SelectedIndex = 0
        ddlCustomers.DataSource = filterDTSold
        ddlCustomers.DataMember = "COMPANYNAME"

    End Sub

#End Region
#Region "Sales and Shipping Details"

    'Private Sub txtCustNoShipTP_AutocompleteSelect(sender As Object, e As RadPopupClosedEventArgs)

    'End Sub

    'Private Sub txtCustNoSoldTP_AutocompleteSelect(sender As Object, e As RadPopupClosedEventArgs)
    '    If txtCitySoldTP.ListElement.SelectedItem IsNot Nothing Then
    '        FilterCustomers("SOLD", txtCitySoldTP.ListElement.SelectedItem.Text)
    '    End If
    'End Sub

    'Private Sub txtCityShipTP_AutocompleteSelect(sender As Object, e As RadPopupClosedEventArgs)
    '    If txtCityShipTP.ListElement.SelectedItem IsNot Nothing Then
    '        FilterCustomers("SHIP", txtCityShipTP.ListElement.SelectedItem.Text)
    '    End If
    'End Sub

    'Private Sub txtCitySoldTP_AutocompleteSelect(sender As Object, e As RadPopupClosedEventArgs)
    '    If txtCitySoldTP.ListElement.SelectedItem IsNot Nothing Then
    '        FilterCustomers("SOLD", txtCitySoldTP.ListElement.SelectedItem.Text)
    '    End If
    'End Sub

    'Private Sub txtCountryShipTP_AutocompleteSelect(sender As Object, e As RadPopupClosedEventArgs)
    '    If txtCountryShipTP.ListElement.SelectedItem IsNot Nothing Then
    '        FilterCustomers("SHIP", txtCountryShipTP.ListElement.SelectedItem.Text)
    '    End If
    'End Sub

    'Private Sub txtCountrySoldTP_AutocompleteSelect(sender As Object, e As RadPopupClosedEventArgs)
    '    If txtCountrySoldTP.ListElement.SelectedItem IsNot Nothing Then
    '        FilterCustomers("SOLD", txtCountrySoldTP.ListElement.SelectedItem.Text)
    '    End If
    'End Sub

    'Private Sub txtZipShipTP_AutocompleteSelect(sender As Object, e As RadPopupClosedEventArgs)
    '    If txtZipShipTP.ListElement.SelectedItem IsNot Nothing Then
    '        FilterCustomers("SHIP", txtZipShipTP.ListElement.SelectedItem.Text)
    '    End If
    'End Sub

    'Private Sub txtZipSoldTP_AutocompleteSelect(sender As Object, e As RadPopupClosedEventArgs)
    '    If txtZipSoldTP.ListElement.SelectedItem IsNot Nothing Then
    '        FilterCustomers("SOLD", txtZipSoldTP.ListElement.SelectedItem.Text)
    '    End If
    'End Sub

    Private Sub chkMatchShip_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles chkMatchShip.ToggleStateChanged
        If chkMatchShip.Checked = True Then
            txtAddr1ShipTP.Text = txtAddr1SoldTP.Text
            txtCityShipTP.Text = txtCitySoldTP.Text
            txtCountryShipTP.Text = txtCountrySoldTP.Text
            txtCustNoShipTP.Text = txtCustNoSoldTP.Text
            txtCustShipTP.Text = txtCustSoldTP.Text
            txtRegionShipTP.Text = txtRegionSoldTP.Text
            txtZipShipTP.Text = txtZipSoldTP.Text
            ddlDistChannelShipTP.SelectedIndex = ddlDistChannelSoldTP.SelectedIndex
        End If
    End Sub

    Private Sub FilterCustomers(ByVal shipsold As String, ByVal fltrval As String)

        Dim fltrSTR As String = ""

        If shipsold = "SOLD" Then
            If txtAddr1SoldTP.Text <> "" Then fltrSTR = " STREET LIKE '" & txtAddr1SoldTP.Text & "' and "
            If txtCitySoldTP.Text <> "" Then fltrSTR = " CITY LIKE '" & txtCitySoldTP.Text & "' and"
            If txtCountrySoldTP.Text <> "" Then fltrSTR = " COUNTRY  LIKE '" & txtCountrySoldTP.Text & "' and"
            If txtCustNoSoldTP.Text <> "" Then fltrSTR = " CUSTNR LIKE '" & txtCustNoSoldTP.Text & "' and"
            If txtCustSoldTP.Text <> "" Then fltrSTR = " COMPANYNAME LIKE '" & txtCustSoldTP.Text & "' and"
            If txtRegionSoldTP.Text <> "" Then fltrSTR = " REGION LIKE '" & txtRegionSoldTP.Text & "' and"
            If txtZipSoldTP.Text <> "" Then fltrSTR = " ZIP LIKE '" & txtZipSoldTP.Text & "' and"
        End If

        If shipsold = "SHIP" Then

            If txtAddr1ShipTP.Text <> "" Then fltrSTR = " STREET LIKE '" & txtAddr1ShipTP.Text & "' and "
            If txtCityShipTP.Text <> "" Then fltrSTR = " CITY LIKE '" & txtCityShipTP.Text & "' and"
            If txtCountryShipTP.Text <> "" Then fltrSTR = " COUNTRY  LIKE '" & txtCountryShipTP.Text & "' and"
            If txtCustNoShipTP.Text <> "" Then fltrSTR = " CUSTNR LIKE '" & txtCustNoShipTP.Text & "' and"
            If txtCustShipTP.Text <> "" Then fltrSTR = " COMPANYNAME LIKE '" & txtCustShipTP.Text & "' and"
            If txtRegionShipTP.Text <> "" Then fltrSTR = " REGION LIKE '" & txtRegionShipTP.Text & "' and"
            If txtZipShipTP.Text <> "" Then fltrSTR = " ZIP LIKE '" & txtZipShipTP.Text & "' and"
        End If

        fltrSTR = fltrSTR.Remove(fltrSTR.Length - 4, 4)

        If shipsold = "SHIP" Then
            filterDTShip.DefaultView.RowFilter = fltrSTR
            If filterDTShip.DefaultView.Count = 1 Then
                txtAddr1ShipTP.Text = filterDTShip.DefaultView(0)("STREET")
                txtCityShipTP.Text = filterDTShip.DefaultView(0)("CITY")
                txtCountryShipTP.Text = filterDTShip.DefaultView(0)("COUNTRY")
                txtCustNoShipTP.Text = filterDTShip.DefaultView(0)("CUSTNR")
                txtRegionShipTP.Text = filterDTShip.DefaultView(0)("REGION")
                txtZipShipTP.Text = filterDTShip.DefaultView(0)("ZIP")
                txtCustShipTP.Text = filterDTShip.DefaultView(0)("COMPANYNAME")
            Else
                PopAutCompleteShip(filterDTShip)
            End If
        ElseIf shipsold = "SOLD" Then
            filterDTSold.DefaultView.RowFilter = fltrSTR
            If filterDTSold.DefaultView.Count = 1 Then
                txtAddr1SoldTP.Text = filterDTSold.DefaultView(0)("STREET")
                txtCitySoldTP.Text = filterDTSold.DefaultView(0)("CITY")
                txtCountrySoldTP.Text = filterDTSold.DefaultView(0)("COUNTRY")
                txtCustNoSoldTP.Text = filterDTSold.DefaultView(0)("CUSTNR")
                txtRegionSoldTP.Text = filterDTSold.DefaultView(0)("REGION")
                txtZipSoldTP.Text = filterDTSold.DefaultView(0)("ZIP")
                txtCustSoldTP.Text = filterDTSold.DefaultView(0)("COMPANYNAME")
            Else
                PopAutCompleteSold(filterDTSold)
            End If
        End If

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

    Private Sub txtAddr1SoldTP_LostFocus(sender As Object, e As EventArgs) Handles txtAddr1SoldTP.LostFocus
        If txtAddr1SoldTP.ListElement.SelectedItem IsNot Nothing Then
            FilterCustomers("SOLD", txtAddr1SoldTP.ListElement.SelectedItem.Text)
        End If
    End Sub

    Private Sub txtCityShipTP_LostFocus(sender As Object, e As EventArgs) Handles txtCityShipTP.LostFocus
        If txtCityShipTP.ListElement.SelectedItem IsNot Nothing Then
            FilterCustomers("SHIP", txtCityShipTP.ListElement.SelectedItem.Text)
        End If
    End Sub

    Private Sub txtCitySoldTP_LostFocus(sender As Object, e As EventArgs) Handles txtCitySoldTP.LostFocus
        If txtCitySoldTP.ListElement.SelectedItem IsNot Nothing Then
            FilterCustomers("SOLD", txtCitySoldTP.ListElement.SelectedItem.Text)
        End If
    End Sub

    Private Sub txtCountryShipTP_LostFocus(sender As Object, e As EventArgs) Handles txtCountryShipTP.LostFocus
        If txtCountryShipTP.ListElement.SelectedItem IsNot Nothing Then
            FilterCustomers("SHIP", txtCountryShipTP.ListElement.SelectedItem.Text)
        End If
    End Sub

    Private Sub txtCountrySoldTP_LostFocus(sender As Object, e As EventArgs) Handles txtCountrySoldTP.LostFocus
        If txtCountrySoldTP.ListElement.SelectedItem IsNot Nothing Then
            FilterCustomers("SOLD", txtCountrySoldTP.ListElement.SelectedItem.Text)
        End If
    End Sub

    Private Sub txtCustNoShipTP_LostFocus(sender As Object, e As EventArgs) Handles txtCustNoShipTP.LostFocus
        If txtCustNoShipTP.ListElement.SelectedItem IsNot Nothing Then
            FilterCustomers("SHIP", txtCustNoShipTP.ListElement.SelectedItem.Text)
        End If
    End Sub

    Private Sub txtCustNoSoldTP_LostFocus(sender As Object, e As EventArgs) Handles txtCustNoSoldTP.LostFocus
        If txtCustNoSoldTP.ListElement.SelectedItem IsNot Nothing Then
            FilterCustomers("SOLD", txtCustNoSoldTP.ListElement.SelectedItem.Text)
        End If
    End Sub

    Private Sub txtCustShipTP_LostFocus(sender As Object, e As EventArgs) Handles txtCustShipTP.LostFocus
        If txtCustShipTP.ListElement.SelectedItem IsNot Nothing Then
            FilterCustomers("SHIP", txtCustShipTP.ListElement.SelectedItem.Text)
        End If
    End Sub

    Private Sub txtCustSoldTP_LostFocus(sender As Object, e As EventArgs) Handles txtCustSoldTP.LostFocus
        If txtCustSoldTP.ListElement.SelectedItem IsNot Nothing Then
            FilterCustomers("SOLD", txtCustSoldTP.ListElement.SelectedItem.Text)
        End If
    End Sub

    Private Sub txtRegionShipTP_LostFocus(sender As Object, e As EventArgs) Handles txtRegionShipTP.LostFocus
        If txtRegionShipTP.ListElement.SelectedItem IsNot Nothing Then
            FilterCustomers("SHIP", txtRegionShipTP.ListElement.SelectedItem.Text)
        End If
    End Sub

    Private Sub txtZipShipTP_LostFocus(sender As Object, e As EventArgs) Handles txtZipShipTP.LostFocus
        If txtZipShipTP.ListElement.SelectedItem IsNot Nothing Then
            FilterCustomers("SHIP", txtZipShipTP.ListElement.SelectedItem.Text)
        End If
    End Sub

    Private Sub txtZipSoldTP_LostFocus(sender As Object, e As EventArgs) Handles txtZipSoldTP.LostFocus
        If txtZipSoldTP.ListElement.SelectedItem IsNot Nothing Then
            FilterCustomers("SOLD", txtZipSoldTP.ListElement.SelectedItem.Text)
        End If
    End Sub

    Private Sub btnSoldTP_Click(sender As Object, e As EventArgs) Handles btnSoldTP.Click
        txtCustNoSoldTP.Text = ""
        txtCustSoldTP.Text = ""
        txtAddr1SoldTP.Text = ""
        txtCitySoldTP.Text = ""
        txtRegionSoldTP.Text = ""
        txtCountrySoldTP.Text = ""
        txtZipSoldTP.Text = ""
    End Sub

    Private Sub btnShipTP_Click(sender As Object, e As EventArgs) Handles btnShipTP.Click
        txtCustNoShipTP.Text = ""
        txtCustShipTP.Text = ""
        txtAddr1ShipTP.Text = ""
        txtCityShipTP.Text = ""
        txtRegionShipTP.Text = ""
        txtCountryShipTP.Text = ""
        txtZipShipTP.Text = ""
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
