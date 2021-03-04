Imports SAP.Middleware.Connector
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class frm_Home
    Dim DTSQL, DTSAP, DTProgress As DataTable
    Dim StpWatch As New Stopwatch

    Public SAP As SAPClass
    Dim rowID As Integer
#Region "Control Code"

    Public Sub New()

        'Set the main form to invisible while it does the loading of the SAP dataTable in the background
        InitializeComponent()
        Me.Visible = False


    End Sub

    Private Sub InitProgress()
        DTProgress = New DataTable
        DTProgress.Columns.Add("Time")
        DTProgress.Columns.Add("Rows_Updated")
        DTProgress.Columns.Add("Run_Time")
    End Sub

    'Tests the connection with SQL, SAP and pulls information from SAP that is needed
    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Need to reset the visibility of the form to not visible
            Me.Visible = False
            InitProgress()
            CheckSQLConnection()
            SAP = New SAPClass
            SAP.TestSAP2()
            'SAP.TestSAP()
            RunUpdatCheck()
            Timer1.Start()
            'Me.BringToFront()
        Catch ex As Exception
            ' MsgBox(ex.Message)
            'EventLog1.WriteEntry(ex.Message)
        End Try
    End Sub

    Private Sub StopTiming()
        StpWatch.Stop()
        Dim ts As TimeSpan = StpWatch.Elapsed
        DTProgress.Rows.Add(DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"), rowID, String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10))
        gv_Info.DataSource = DTProgress



    End Sub

    Private Sub Compare()
        Try


            rowID = 0
            Dim cntr As Integer = 0
            Dim updateRow As Boolean = False
            Dim str As String
            SQL = ""
            'StartWatch()

            SQL = "update t_customer set status = 0"
            Execute()
            str = ""

            For Each row In DTSAP.Rows
                updateRow = False
                'look to see if there is a customer with that sap id and distribution channel
                Dim dr As DataRow() = DTSQL.Select("SAP_ID='" & row("CustNR") & "' AND DISTRIBUTION_CHANNEL = '" & row("VTWEG") & "'")
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
                            "status = 1" &
                            "SAP_Change_Date = " & IIf(Microsoft.VisualBasic.Left(Replace(row("change_date"), "'", "''"), 1) = "0", "Null", "'" & Replace(row("change_date"), "'", "''") & "'") & "  " &
                            " where customer_id = " & dr(0)("customer_Id") & " " & vbCr
                    Else
                        str &= dr(0)("customer_id") & ","
                    End If
                Else
                    If Len(SQL) > 0 Then Execute()
                    rowID += 1
                    cntr += 1
                    SQL &= "Insert into t_customer (customer_name, SAP_ID, distribution_channel, status, street_address, city, region, zip, country,sap_change_date) values (" &
                        "'" & Replace(row("companyname"), "'", "''") & "' ," &
                        "'" & Replace(row("CustNR"), "'", "''") & "'  ," &
                         "'" & Replace(row("VTWEG"), "'", "''") & "'  ," &
                         "1  ," &
                         "'" & Replace(row("street"), "'", "''") & "'  ," &
                         "'" & Replace(row("city"), "'", "''") & "'  ," &
                         "'" & Replace(row("region"), "'", "''") & "'  ," &
                         "'" & Replace(row("zip"), "'", "''") & "'  ," &
                         "'" & Replace(row("country"), "'", "''") & "'  ," &
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
            str = Microsoft.VisualBasic.Left(str, Len(str) - 1)
            SQL = "Update t_customer set status = 1 where customer_id in (" & str & ")"
            Execute()

            SQL = "Delete from t_customer where status = 0 "
            Execute()
        Catch ex As Exception
            'EventLog1.WriteEntry(ex.Message)
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PopSQLCustomers()
        DTSQL = New DataTable
        DTSQL.Columns.Add("rowID")
        DTSQL.Columns.Add("customer_id")
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
        rowID = 0
        Try
            SQL = "Select * from t_customer "
            SRS(RS)

            While RS.Read
                DTSQL.Rows.Add(rowID, TrimRS("customer_id"), TrimRS("city"), TrimRS("region"), TrimRS("zip"), TrimRS("country"), TrimRS("customer_name"),
                            TrimRS("distribution_Channel"), TrimRS("SAP_ID"), TrimRS("street_Address"), TrimRS("status"), TrimRS("Live_Branch"), TrimRS("Distributor_ID"))
                rowID += 1
            End While
        Catch ex As Exception
            'EventLog1.WriteEntry(ex.Message)
            MsgBox(ex.Message)
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

    Private Sub RunUpdatCheck()
        Timer1.Stop()

        StpWatch.Reset()
        StpWatch.Start()
        DTSAP = New DataTable
        DTSQL = New DataTable
        PopSQLCustomers()

        DTSAP = SAP.GetCustomerData()

        Compare()
        StopTiming()
        Timer1.Start()
        DTSAP.Clear()
        DTSQL.Clear()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RunUpdatCheck()
    End Sub
#End Region
End Class