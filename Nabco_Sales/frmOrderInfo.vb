Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class frmOrderInfo

#Region "Form Level"
    Public searchrowinfo As GridViewRowInfo
    ' Private custDT As DataTable
    Private filterDTSold As DataTable
    Private filterDTShip As DataTable
    Private chkToClose As Boolean
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

    End Sub



    Private Sub frmOrderInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            '   ddlDistChannelShipTP.SelectedIndex = ddlDistChannelSoldTP.SelectedIndex
        End If
    End Sub

    Private Sub btnSoldTP_Click(sender As Object, e As EventArgs) Handles btnSoldTP.Click
        Dim frm As New frmCustomers
        frm.callingBtn = "SOLD"
        frm.Show()
    End Sub

    Public Sub SETSOLDDETIALS(ByVal rowinfo As GridViewRowInfo)
        txtAddr1SoldTP.Text = rowinfo.Cells("STREET").Value
        txtCitySoldTP.Text = rowinfo.Cells("CITY").Value
        txtCountrySoldTP.Text = rowinfo.Cells("COUNTRY").Value
        txtCustNoSoldTP.Text = rowinfo.Cells("CUSTNR").Value
        txtCustSoldTP.Text = rowinfo.Cells("COMPANYNAME").Value
        txtRegionSoldTP.Text = rowinfo.Cells("REGION").Value
        txtZipSoldTP.Text = rowinfo.Cells("ZIP").Value
        txtDistSoldTP.Text = rowinfo.Cells("VTWEG").Value
        ' ddlDistChannelShipTP.SelectedIndex = ddlDistChannelSoldTP.SelectedIndex

    End Sub
    Public Sub SETSHIPDETAILS(ByVal rowinfo As GridViewRowInfo)
        txtAddr1ShipTP.Text = rowinfo.Cells("STREET").Value
        txtCityShipTP.Text = rowinfo.Cells("CITY").Value
        txtCountryShipTP.Text = rowinfo.Cells("COUNTRY").Value
        txtCustNoShipTP.Text = rowinfo.Cells("CUSTNR").Value
        txtCustShipTP.Text = rowinfo.Cells("COMPANYNAME").Value
        txtRegionShipTP.Text = rowinfo.Cells("REGION").Value
        txtZipShipTP.Text = rowinfo.Cells("ZIP").Value
        txtDistShipTP.Text = rowinfo.Cells("VTWEG").Value
    End Sub
#End Region

#Region "Quote Details"

#End Region

#Region "Upload PO and Documents"

#End Region

#Region "Products"

#End Region
End Class
