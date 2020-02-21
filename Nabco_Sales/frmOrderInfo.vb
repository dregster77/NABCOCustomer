Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class frmOrderInfo

#Region "Form Level"
    Private CustDT As DataTable
    Private flrDT As DataTable
    Private chkToClose As Boolean
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler txtCitySoldTP.ListElement.ElementTree.Control.Click, AddressOf OnListElementClick
        '  Me.txtCustSoldTP.ListElement.ElementTree.Control.Click += AddressOf Me.OnListElementClick
    End Sub


    Private Sub frmOrderInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load a fresh datatable with customers
        CustDT = New DataTable
        CustDT = My.Settings.CustomerDATARaw


        'force the pageview to be expanded
        Dim navele = TryCast(Me.pvOrderInfo.ViewElement, RadPageViewNavigationViewElement)
        navele.Expand()
        PopAutoCompleteInfo(CustDT)

        ddlSalesOffice.SelectedIndex = 0
        '    AddHandler txtCustSoldTP.au

        ' AddHandler txtCustSoldTP.ElementTree.Control.Click, AddressOf OnListElementClick

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
            ddlDistChannelShipTP.SelectedIndex = ddlDistChannelSoldTP.SelectedIndex
        End If
    End Sub

    Private Sub PopFilterDatas()
        Dim fltr As String = "CITY LIKE 'Z*'"

        Dim dt As DataTable = CustDT
        dt.DefaultView.RowFilter = fltr
        flrDT = dt.DefaultView.ToTable
        'Dim FR As DataRow() = dt.Select(fltr)
        '  CustDT = FR.CopyToDataTable
        '  CustDT = FR.CopyToDataTable
        PopAutoCompleteInfo(flrDT)
        '   Dim dtOutput As DataTable = dt.DefaultView.ToTable()
        ' CustDT = dtOutput
    End Sub

    Private Sub PopAutoCompleteInfo(ByVal data As DataTable)
        'COMPANYNAME
        txtCustSoldTP.AutoCompleteDataSource = data
        txtCustSoldTP.AutoCompleteDisplayMember = "COMPANYNAME"
        txtCustShipTP.AutoCompleteDataSource = data
        txtCustShipTP.AutoCompleteDisplayMember = "COMPANYNAME"

        'ADDRESS
        txtAddr1ShipTP.AutoCompleteDataSource = data
        txtAddr1ShipTP.AutoCompleteDisplayMember = "STREET"
        txtAddr1SoldTP.AutoCompleteDataSource = data
        txtAddr1SoldTP.AutoCompleteDisplayMember = "STREET"

        'CITY
        txtCityShipTP.AutoCompleteDataSource = data
        txtCityShipTP.AutoCompleteDisplayMember = "CITY"
        txtCitySoldTP.AutoCompleteDataSource = data
        txtCitySoldTP.AutoCompleteDisplayMember = "CITY"

        'COUNTRY
        txtCountryShipTP.AutoCompleteDataSource = data
        txtCountryShipTP.AutoCompleteDisplayMember = "COUNTRY"
        txtCountrySoldTP.AutoCompleteDataSource = data
        txtCountrySoldTP.AutoCompleteDisplayMember = "COUNTRY"

        'ZIP
        txtZipShipTP.AutoCompleteDataSource = data
        txtZipShipTP.AutoCompleteDisplayMember = "ZIP"
        txtZipSoldTP.AutoCompleteDataSource = data
        txtZipSoldTP.AutoCompleteDisplayMember = "ZIP"

        'REGIOIN
        txtRegionShipTP.AutoCompleteDataSource = data
        txtRegionShipTP.AutoCompleteDisplayMember = "REGION"
        txtRegionSoldTP.AutoCompleteDataSource = data
        txtRegionSoldTP.AutoCompleteDisplayMember = "REGION"

        'COMPANYNO
        txtCustNoShipTP.AutoCompleteDataSource = data
        txtCustNoShipTP.AutoCompleteDisplayMember = "CUSTNR"
        txtCustNoSoldTP.AutoCompleteDataSource = data
        txtCustNoSoldTP.AutoCompleteDisplayMember = "CUSTNR"


        'txtCityShipTP.AutoCompleteDataSource = CustDT
        'txtCitySoldTP.AutoCompleteDisplayMember = "COMPANYNAME"
        'txtCountryShipTP.AutoCompleteDataSource = CustDT
        'txtCountrySoldTP.AutoCompleteDisplayMember = "COMPANYNAME"
        'txtCustSoldTP.AutoCompleteDataSource = CustDT
        'txtCustSoldTP.AutoCompleteDisplayMember = "COMPANYNAME"
        'txtCustShipTP.AutoCompleteCustomSource.AddRange((From r In CustDT.AsEnumerable() Select r.Field(Of String)("COMPANYNAME")).ToList().ToArray)

    End Sub

    Private Sub OnListElementClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim elementTree As ComponentThemableElementTree = txtCitySoldTP.ListElement.ElementTree
        Dim mousePosition As Point = elementTree.Control.PointToClient(Control.MousePosition)
        Dim element As RadElement = elementTree.GetElementAtPoint(mousePosition)
        While element IsNot Nothing
            Dim item As RadListVisualItem = TryCast(element, RadListVisualItem)

            If item IsNot Nothing Then
                PopFilterDatas
                '  MsgBox(item.Text)
                ' YOUR LOGIC HERE
                Exit While
            End If

            element = element.Parent
        End While
    End Sub

    Private Sub RadGroupBox1_Click(sender As Object, e As EventArgs) Handles RadGroupBox1.Click

    End Sub

    Private Sub RadTextBoxControl4_TextChanged(sender As Object, e As EventArgs) Handles txtRegionShipTP.TextChanged

    End Sub

#End Region

#Region "Quote Details"

#End Region

#Region "Upload PO and Documents"

#End Region

#Region "Products"

#End Region
End Class
