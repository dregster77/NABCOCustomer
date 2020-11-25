Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports NabcoCustomer.SAPClass
Imports SAP.Middleware.Connector

Public Class frmHome
    Inherits Telerik.WinControls.UI.RadForm

    'Private Declare Function SetParent Lib "user32" (ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Integer
    'Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    Public SAP As New SAPClass

#Region "Control Code"

    Public Sub New()

        'Set the main form to invisible while it does the loading of the SAP dataTable in the background
        InitializeComponent()
        Me.Visible = False

    End Sub

    'Tests the connection with SQL, SAP and pulls information from SAP that is needed
    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Need to reset the visibility of the form to not visible
        Me.Visible = False
        DirectCast(My.Application.SplashScreen, frmLoading).UpdateLoadingStatus("Checking SQL Connection...")
        TestSQLConnection()
        DirectCast(My.Application.SplashScreen, frmLoading).UpdateLoadingStatus("Checking SAP Connection...")
        SAP.TestSAPConnection()
        DirectCast(My.Application.SplashScreen, frmLoading).UpdateLoadingStatus("Retrieving SAP Information...")
        SAP.GetCustomerData()
        Me.BringToFront()
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


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        Logoff()
    End Sub

    Private Sub mnuTier_Click(sender As Object, e As EventArgs)
        Dim frm As New frmTier
        ShowForm(frm)
    End Sub

    Private Sub btnSwingDoor_Click(sender As Object, e As EventArgs)
        Dim frm As New frmOrderInfo
        ShowForm(frm)
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs)
        Dim frm As New Form2
        ShowForm(frm)
    End Sub

    Private Sub cmdTest_Click(sender As Object, e As EventArgs)
        showDesktopAlert("Working?", "Making sure that the new desktop alert is working for the applicaiton", True)
        ' ' Dim frm As New frmSwingers
        'ShowForm(frm)
    End Sub

    Private Sub frmHome_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Public Sub OpenNewSwing()
        'Dim frm As frmSwingers
        'ShowForm(frm)

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


    Public Sub Login()

        'lblStatusMain.Text = "Current User: " & My.Settings.User_Full
        'If My.Settings.User_security = 1 Then
        'End If
        'mnuAdmin.Visible = True
        'mnuUserSet.Visible = True
        'btnLogout.Enabled = True
        'pnlHomebtns.Enabled = True


    End Sub

    Public Sub Logoff()
        'btnLogout.Enabled = False
        'My.Settings.User = ""
        'My.Settings.User_ID = 0
        'My.Settings.User_Full = ""
        'My.Settings.User_security = -1
        'pnlHomebtns.Enabled = False
        'mnuAdmin.Visible = False
        'mnuUserSet.Visible = False
        'lblStatusMain.Text = "No User Logged In"
        'PopLoginForm()
    End Sub

    Private Function IsAlreadyOpen(ByVal formType As Type) As Boolean
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.[GetType]() = formType Then
                f.BringToFront()
                f.WindowState = FormWindowState.Normal
                isOpen = True
            End If
        Next
        Return isOpen
    End Function

    Public Sub PopLoginForm()
        Dim frm As New frmLogin
        ShowDialogForm(frm)
    End Sub

    Public Sub ShowDialogForm(ByVal frm As Form)
        'SetParent(frm.Handle, pnlMain.Handle)
        'frm.StartPosition = FormStartPosition.Manual
        'Dim x As Integer = (pnlMain.Width / 2) - (frm.Width / 2)
        'Dim y As Integer = ((pnlMain.Height / 2) - (frm.Height / 2) - 94)
        'frm.Show()
        'frm.Location = New Point(x, y)
    End Sub

    Public Sub ShowForm(ByVal frm As Form)
        frm.IsMdiContainer = False
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnFindOrder_Click(sender As Object, e As EventArgs)
        frmQuoteLookup.ShowDialog()
    End Sub







#End Region
End Class
