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
    Private dtFilterSold As DataTable
    Private dtFilterShip As DataTable
    Private chkToClose As Boolean
    Private soldFilter As GridViewFilterDescriptorCollection

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
    End Sub



    Private Sub frmOrderInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load a fresh datatable with customers
        dtFilterSold = New DataTable
        dtFilterSold = My.Settings.CustomerDATARaw.Copy()
        dtFilterShip = New DataTable
        dtFilterShip = My.Settings.CustomerDATARaw.Copy()
        'TestingLinqQuery()

        'force the pageview to be expanded
        Dim navele = TryCast(Me.pvOrderInfo.ViewElement, RadPageViewNavigationViewElement)
        navele.Expand()
        PopDistChannels()

        '   FilterData(True)
        '  FilterData(False)

    End Sub

    Private Sub PopDistChannels()
        Dim view As DataView = My.Settings.CustomerDATARaw.DefaultView
        Dim dt As New DataTable
        dt = view.ToTable(True, "VTWEG")


        ddlDistChannelSoldTP.DataSource = dt
        ddlDistChannelSoldTP.DisplayMember = "VTWEG"
        ddlDistChannelShipTP.DataSource = dt
        ddlDistChannelShipTP.DisplayMember = "VTWEG"

    End Sub
#End Region

#Region "Sales and Shipping Details"


#Region "Population and Filtering Logic"

    Private Sub FilterData(ByVal shipsold As Boolean) 'true ship false sold

        Dim dt As DataTable = IIf(shipsold = True, dtFilterShip.Copy, dtFilterSold.Copy)
        ConvertToRead(dt)
        gvCustomer.DataSource = dt
        gvCustomer.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        ' Dim Results = From ROW In dt Select ROW

        gvCustomer.FilterDescriptors.Clear()

        gvCustomer.FilterDescriptors.Add("VTWEG", FilterOperator.IsEqualTo, IIf(shipsold, ddlDistChannelShipTP.SelectedItem.Text, ddlDistChannelSoldTP.SelectedItem.Text))

        If IIf(shipsold, txtCountryShipTP.Text, txtCountrySoldTP.Text) <> "" Then
            gvCustomer.FilterDescriptors.Add("COUNTRY", FilterOperator.StartsWith, IIf(shipsold, txtCountryShipTP.Text, txtCountrySoldTP.Text))
        End If


        If IIf(shipsold, txtCityShipTP.Text, txtCitySoldTP.Text) <> "" Then
            gvCustomer.FilterDescriptors.Add("CITY", FilterOperator.StartsWith, IIf(shipsold, txtCityShipTP.Text, txtCitySoldTP.Text))
        End If


        If IIf(shipsold, txtAddr1ShipTP.Text, txtAddr1SoldTP.Text) <> "" Then
            gvCustomer.FilterDescriptors.Add("STREET", FilterOperator.StartsWith, IIf(shipsold, txtAddr1ShipTP.Text, txtAddr1SoldTP.Text))
        End If


        If IIf(shipsold, txtCustNoShipTP.Text, txtCustNoSoldTP.Text) <> "" Then
            gvCustomer.FilterDescriptors.Add("CUSTNR", FilterOperator.StartsWith, IIf(shipsold, txtCustNoShipTP.Text, txtCustNoSoldTP.Text))
        End If


        If IIf(shipsold, txtRegionShipTP.Text, txtRegionSoldTP.Text) <> "" Then
            gvCustomer.FilterDescriptors.Add("REGION", FilterOperator.StartsWith, IIf(shipsold, txtRegionShipTP.Text, txtRegionSoldTP.Text))
        End If


        If IIf(shipsold, txtZipShipTP.Text, txtZipSoldTP.Text) <> "" Then
            gvCustomer.FilterDescriptors.Add("ZIP", FilterOperator.StartsWith, IIf(shipsold, txtZipShipTP.Text, txtZipSoldTP.Text))
        End If

        If IIf(shipsold, txtCustShipTP.Text, txtCustSoldTP.Text) <> "" Then
            gvCustomer.FilterDescriptors.Add("COMPNAYNAME", FilterOperator.StartsWith, IIf(shipsold, txtCustShipTP.Text, txtCustSoldTP.Text))
        End If
        gvCustomer.EnableFiltering = True
        gvCustomer.ShowFilteringRow = False
        gvCustomer.Refresh()
    End Sub

    Private Function ConvertToRead(ByVal DT As DataTable) As DataTable
        '   Dim temp As New DataTable
        ' temp = dt
        DT = My.Settings.CustomerDATARaw
        Dim colsToDelete As List(Of DataColumn) = New List(Of DataColumn)()
        For Each col As DataColumn In DT.Columns
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
                Case "VTWEG"
                    col.Caption = "Dist Channel"
                Case Else
                    colsToDelete.Add(col)
            End Select
        Next

        For Each col In colsToDelete
            DT.Columns.Remove(col)
        Next
        Return DT
    End Function

    Private Sub PopData(ByVal data As DataTable, ByVal shipsold As Boolean)  'false= sold; true =ship



    End Sub
#End Region

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
        FilterData(False)
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
        FilterData(True)
        gvCustomer.Visible = True
        gvCustomer.Location = Label1.Location
        lblCallingbtn.Text = "SHIP"
    End Sub

    Private Sub mnuSlider_Click(sender As Object, e As EventArgs) Handles mnuSlider.Click

    End Sub

    Private Sub mnuSwinger_Click(sender As Object, e As EventArgs) Handles mnuSwinger.Click
        frmHome.OpenNewSwing()
    End Sub



#End Region

#Region "Quote Details"

#End Region

#Region "Upload PO and Documents"

#End Region

#Region "Products"

#End Region
End Class
