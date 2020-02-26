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
        ddlCustSold.DataSource = My.Settings.CustomerDATARaw
        ddlCustSold.DisplayMember = "COMPANYNAME"
        ddlCustSold.AutoCompleteDataSource = My.Settings.CustomerDATARaw
        ddlCustSold.AutoCompleteDisplayMember = "COMPNAYNAME"
        ddlCustSold.AutoCompleteMode = AutoCompleteMode.SuggestAppend
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
