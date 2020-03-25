Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class frmOrderInfoOld

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
        filterDTSold = My.Settings.CustomerDATARaw
        PopInfo(0, filterDTSold)
    End Sub

    Private Sub PopInfo(ByVal SoldShip As Int16, ByVal dt As DataTable)
        If SoldShip = 0 Then
            ddlCustSold.DataSource = dt
            ddlCustSold.DisplayMember = "COMPANYNAME"
            ddlCustSold.AutoCompleteDataSource = dt
            ddlCustSold.AutoCompleteDisplayMember = "COMPNAYNAME"

            ddlAddr1Sold.DataSource = dt
            ddlAddr1Sold.DisplayMember = "STREET"
            ddlAddr1Sold.AutoCompleteDataSource = dt
            ddlAddr1Sold.AutoCompleteDisplayMember = "STREET"

            ddlCitySold.DataSource = dt
            ddlCitySold.DisplayMember = "CITY"
            ddlCitySold.AutoCompleteDataSource = dt
            ddlCitySold.AutoCompleteDisplayMember = "CITY"

            ddlCountrySold.DataSource = dt
            ddlCountrySold.DisplayMember = "COUNTRY"
            ddlCountrySold.AutoCompleteDataSource = dt
            ddlCountrySold.AutoCompleteDisplayMember = "COUNTRY"

            ddlRegionSold.DataSource = dt
            ddlRegionSold.DisplayMember = "REGION"
            ddlRegionSold.AutoCompleteDataSource = dt
            ddlRegionSold.AutoCompleteDisplayMember = "REGION"

            ddlZipSold.DataSource = dt
            ddlZipSold.DisplayMember = "ZIP"
            ddlZipSold.AutoCompleteDataSource = dt
            ddlZipSold.AutoCompleteDisplayMember = "ZIP"


        ElseIf SoldShip = 1 Then

        End If
    End Sub

    Private Sub FilterSoldParty()
        Dim Results = From ROW In filterDTSold Select ROW

        If ddlCitySold.SelectedText <> "" Then
            Results = Results.Where(Function(X) X.Field(Of String)("CITY").ToUpper.Contains(ddlCitySold.SelectedText.ToUpper))
        End If
        If ddlRegionSold.SelectedText <> "" Then
            Results = Results.Where(Function(X) X.Field(Of String)("REGION").ToUpper.Contains(ddlRegionSold.SelectedText.ToUpper))
        End If
        If ddlCountrySold.SelectedText <> "" Then
            Results = Results.Where(Function(X) X.Field(Of String)("COUNTRY").ToUpper.Contains(ddlCountrySold.SelectedText.ToUpper))
        End If
        If ddlAddr1Sold.SelectedText <> "" Then
            Results = Results.Where(Function(X) X.Field(Of String)("STREET").ToUpper.Contains(ddlAddr1Sold.SelectedText.ToUpper))
        End If
        If ddlZipSold.SelectedText <> "" Then
            Results = Results.Where(Function(X) X.Field(Of String)("ZIP").ToUpper.Contains(ddlZipSold.SelectedText.ToUpper))
        End If
        If ddlCustSold.SelectedText <> "" Then
            Results = Results.Where(Function(X) X.Field(Of String)("COMPANYNAME").ToUpper.Contains(ddlCustSold.SelectedText.ToUpper))
        End If

        PopInfo(0, SAPClass.CleanCustomerData(Results.CopyToDataTable))


    End Sub

    Private Sub ddlCitySold_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlCitySold.SelectedIndexChanged
        If ddlCitySold.SelectedIndex > 0 Then
            FilterSoldParty()
        End If
    End Sub

    Private Sub ddlAddr1Sold_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlAddr1Sold.SelectedIndexChanged
        If ddlCitySold.SelectedIndex > 0 Then
            FilterSoldParty()
        End If
    End Sub

    Private Sub ddlCountrySold_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlCountrySold.SelectedIndexChanged
        If ddlCountrySold.SelectedIndex > 0 Then
            FilterSoldParty()
        End If
    End Sub

    Private Sub ddlCustSold_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlCustSold.SelectedIndexChanged
        If ddlCustSold.SelectedIndex > 0 Then
            FilterSoldParty()
        End If
    End Sub

    Private Sub ddlRegionSold_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlRegionSold.SelectedIndexChanged
        If ddlRegionSold.SelectedIndex > 0 Then
            FilterSoldParty()
        End If
    End Sub

    Private Sub ddlZipSold_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlZipSold.SelectedIndexChanged
        If ddlZipSold.SelectedIndex > 0 Then
            FilterSoldParty()
        End If
    End Sub

#End Region
#Region "Sales and Shipping Details"

#End Region

#Region "Quote Details"

#End Region

#Region "Upload PO and Documents"

#End Region

#Region "Products"

#End Region
End Class
