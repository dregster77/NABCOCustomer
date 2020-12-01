Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports NabcoCustomer.SAPClass
Imports SAP.Middleware.Connector
Imports Telerik.WinControls.UI

Public Class frmHome
    Inherits Telerik.WinControls.UI.RadForm
    Dim DTSQL, DTSAP As DataTable
    Dim tmr As New Stopwatch
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
            '   DirectCast(My.Application.SplashScreen, frmLoading).UpdateLoadingStatus("Checking SQL Connection...")
            CheckSQLConnection()
            SAP.TestSAPConnection()
            PopSQLCustomers()
            SAP.GetCustomerData()
            DTSAP = My.Settings.CustomerDATARaw
            Compare()
            Me.BringToFront()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Compare()

        rowID = 0
        Dim cntr As Integer = 0
        Dim updateRow As Boolean = False
        Dim str As String
        SQL = ""
        'StartWatch()

        SQL = "update t_customer set update_staus = 0"
        Execute()
        str = ""
        For Each row In DTSAP.Rows
            updateRow = False
            'look to see if there is a customer with that sap id and distribution channel
            Dim dr As DataRow() = DTSQL.Select("IDSAP='" & row("CustNR") & "' AND DISTRIBUTION_CHANNEL = '" & row("VTWEG") & "'")
            If dr.Length > 0 Then

                If row("companyname") <> dr(0)("customer_Name") And row("street") <> dr(0)("street_address") And row("city") <> dr(0)("city") And row("region") <> dr(0)("region") And
                    row("zip") <> dr(0)("zip") And row("country") <> dr(0)("country") Then
                    cntr += 1 : rowID += 1
                    SQL &= "Update t_customer set " &
                        "customer_Name = '" & Replace(row("companyname"), "'", "''") & "' ," &
                        "street_address = '" & Replace(row("street"), "'", "''") & "'  ," &
                        "city = '" & Replace(row("city"), "'", "''") & "'  ," &
                        "region = '" & Replace(row("region"), "'", "''") & "'  ," &
                        "zip = '" & Replace(row("zip"), "'", "''") & "'  ," &
                        "country = '" & Replace(row("country"), "'", "''") & "'  ," &
                        "lst_update = '" & Today.Date & "', " &
                        "SAP_Change_Date = " & IIf(Microsoft.VisualBasic.Left(Replace(row("change_date"), "'", "''"), 1) = "0", "Null", "'" & Replace(row("change_date"), "'", "''") & "'") & "  " &
                        " where customer_id = " & dr(0)("customer_Id") & " " & vbCr
                Else
                    str &= dr(0)("customer_id") & ", "
                End If

            Else
                If Len(SQL) > 0 Then Execute()
                rowID += 1
                cntr += 1
                SQL &= "Insert into t_customer (customer_name, idsap, distribution_channel, update_status, street_address, city, region, zip, country, lst_update, sap_change_date) values (" &
                    "'" & Replace(row("companyname"), "'", "''") & "' ," &
                    "'" & Replace(row("CustNR"), "'", "''") & "'  ," &
                     "'" & Replace(row("VTWEG"), "'", "''") & "'  ," &
                     "1  ," &
                     "'" & Replace(row("street"), "'", "''") & "'  ," &
                     "'" & Replace(row("city"), "'", "''") & "'  ," &
                     "'" & Replace(row("region"), "'", "''") & "'  ," &
                     "'" & Replace(row("zip"), "'", "''") & "'  ," &
                     "'" & Replace(row("country"), "'", "''") & "'  ," &
                     "'" & Today.Date & "'  ," &
                      IIf(Microsoft.VisualBasic.Left(Replace(row("change_date"), "'", "''"), 1) = "0", "Null", "'" & Replace(row("change_date"), "'", "''") & "'") & ")" & vbCr
                Execute()
            End If
            If cntr = 10 Then
                Execute()
                cntr = 0
                SQL = ""
            End If
        Next
        If Len(SQL) > 0 Then Execute()
        Dim rowinfo As GridViewRowInfo = gv_Progress.Rows.AddNew
        rowinfo.Cells("update_Time").Value = DateTime.Now
        rowinfo.Cells("records_updated").Value = rowID



    End Sub

    'Fires once the data has been pulled from SAP and kept in memory of the application 
    Private Sub FrmHome_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Visible = True
        Me.IsMdiContainer = True
        Me.WindowState = FormWindowState.Maximized

        Me.BringToFront()
        Timer1.Start()
    End Sub

    Private Sub PopSQLCustomers()
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
    End Sub

#End Region

#Region "Subs & Functions"

    Public Sub ShowForm(ByVal frm As Form)
        frm.IsMdiContainer = False
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DTSAP = New DataTable
        DTSQL = New DataTable
        CheckSQLConnection()
        PopSQLCustomers()
        SAP.GetCustomerData()
        DTSAP = My.Settings.CustomerDATARaw
        Compare()
    End Sub
#End Region
End Class
