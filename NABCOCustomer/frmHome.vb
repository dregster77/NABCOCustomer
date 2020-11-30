Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports NabcoCustomer.SAPClass
Imports SAP.Middleware.Connector
Imports Telerik.WinControls.UI

Public Class frmHome
    Inherits Telerik.WinControls.UI.RadForm
    Dim DTSQL, DTSAP, DTDiff As DataTable

    'Private Declare Function SetParent Lib "user32" (ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Integer
    'Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    Public SAP As New SAPClass
    Dim rowID As Integer
#Region "Control Code"

    Public Sub New()

        'Set the main form to invisible while it does the loading of the SAP dataTable in the background
        InitializeComponent()
        Me.Visible = False

    End Sub

    'Tests the connection with SQL, SAP and pulls information from SAP that is needed
    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try


            'Need to reset the visibility of the form to not visible
            Me.Visible = False
            DirectCast(My.Application.SplashScreen, frmLoading).UpdateLoadingStatus("Checking SQL Connection...")
            CheckSQLConnection()
            'DirectCast(My.Application.SplashScreen, frmLoading).UpdateLoadingStatus("Checking SQL Connection...")
            'TestSQLConnection()
            DirectCast(My.Application.SplashScreen, frmLoading).UpdateLoadingStatus("Checking SAP Connection...")
            SAP.TestSAPConnection()
            DirectCast(My.Application.SplashScreen, frmLoading).UpdateLoadingStatus("Retrieving SQL Information...")
            PopSQLCustomers()
            DirectCast(My.Application.SplashScreen, frmLoading).UpdateLoadingStatus("Retrieving SAP Information...")
            SAP.GetCustomerData()
            DTSAP = My.Settings.CustomerDATARaw

            Me.BringToFront()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Compare()
        DTDiff = New DataTable
        DTDiff.Columns.Add("RowID")
        DTDiff.Columns.Add("customer_ID")
        DTDiff.Columns.Add("Matched")
        rowID = 0
        For Each row In DTSAP.Rows
            Dim dr As DataRow() = DTSQL.Select("IDSAP='" & row("CustNR") & "' AND DISTRIBUTION_CHANNEL = '" & row("VTWEG") & "'")
            If dr.Length > 0 Then
                If row("companyname") = dr(0)("customer_Name") And row("street") = dr(0)("street_address") Then
                    DTDiff.Rows.Add(rowID, dr(0)("customer_ID"), "YES")
                Else
                    DTDiff.Rows.Add(rowID, row("custNR"), "Not")
                End If
                'If row("") Then
                '        DTDiff.Rows.Add(dr("customer"))
                '    End If
            End If
            rowID += 1
        Next
        gv_Progress.DataSource = DTDiff
    End Sub

    'Fires once the data has been pulled from SAP and kept in memory of the application 
    Private Sub frmHome_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Visible = True
        Me.IsMdiContainer = True
        Me.WindowState = FormWindowState.Maximized

        gv_SAP.DataSource = My.Settings.CustomerDATARaw
        'pnlMain.MdiChildrenDockType = Telerik.WinControls.UI.Docking.DockType.ToolWindow
        ' PopLoginForm()
        Me.BringToFront()

    End Sub

    Private Sub PopSQLCustomers()
        'gv_SQL.BeginUpdate()
        DTSQL = New DataTable
        DTSQL.Columns.Add("rowID")
        DTSQL.Columns.Add("customer_id")
        DTSQL.Columns.Add("canadian")
        DTSQL.Columns.Add("city")
        DTSQL.Columns.Add("region")
        DTSQL.Columns.Add("zip")
        DTSQL.Columns.Add("country")
        DTSQL.Columns.Add("customer_name")
        DTSQL.Columns.Add("distribution_Channel")
        DTSQL.Columns.Add("SAP_ID")
        DTSQL.Columns.Add("street_Address")
        DTSQL.Columns.Add("status")
        DTSQL.Columns.Add("live_branch")
        DTSQL.Columns.Add("Distributor_ID")
        DTSQL.Columns.Add("IDSAP")
        rowID = 0
        Try
            SQL = "Select * from t_customer "
            SRS(RS)

            While RS.Read
                DTSQL.Rows.Add(rowID, TrimRS("customer_id"), TrimRS("canadian"), TrimRS("city"), TrimRS("region"), TrimRS("zip"), TrimRS("country"), TrimRS("customer_name"),
                            TrimRS("distribution_Channel"), TrimRS("SAP_ID"), TrimRS("street_Address"), TrimRS("status"), TrimRS("Live_Branch"), TrimRS("Distributor_ID"), TrimRS("IDSAP"))
                rowID += 1
            End While
        Catch ex As Exception
        Finally
            CRS(RS)
        End Try
        ' gv_SQL.EndUpdate()
        gv_SQL.DataSource = DTSQL
        gv_SQL.BestFitColumns()
    End Sub

#End Region

#Region "Subs & Functions"

    Public Sub showDesktopAlert(ByRef Caption As String, ByRef Content As String, Optional isError As Boolean = False, Optional img As Image = Nothing)
        'dskAlert.CaptionText = Caption
        'dskAlert.ContentText = Content
        'If img IsNot Nothing Then
        '    dskAlert.ContentImage = img
        'End If
        'If isError = True Then
        '    dskAlert.ContentImage = My.Resources._error

        'End If
        'dskAlert.ShowOptionsButton = False
        'dskAlert.ShowPinButton = False
        'dskAlert.Show()
    End Sub



    Public Sub ShowForm(ByVal frm As Form)
        frm.IsMdiContainer = False
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Compare()
    End Sub









#End Region
End Class
