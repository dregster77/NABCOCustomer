Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports Nabco_Sales.SAPClass
Imports SAP.Middleware.Connector

Public Class frmHome
    Inherits Telerik.WinControls.UI.RadForm

    Private Declare Function SetParent Lib "user32" (ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Integer
    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    Public SAP As New SAPClass



#Region "Control Code"

    Public Sub New()


        InitializeComponent()
        Me.Visible = False

    End Sub

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Visible = False

        TestSQLConnection()
        SAP.TestSAPConnection()
        SAP.SetCustomerData()

    End Sub

    'Fires once the data has been pulled from SAP and kept in memory of the application 
    Private Sub frmHome_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Visible = True
        Me.IsMdiContainer = True
        Me.WindowState = FormWindowState.Maximized
        pnlMain.MdiChildrenDockType = Telerik.WinControls.UI.Docking.DockType.ToolWindow
        PopLoginForm()
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Logoff()
    End Sub

    Private Sub mnuTier_Click(sender As Object, e As EventArgs) Handles mnuTier.Click
        Dim frm As New frmTier
        ShowForm(frm)
    End Sub

    Private Sub btnSwingDoor_Click(sender As Object, e As EventArgs) Handles btnSwingDoor.Click
        Dim frm As New frmSwingDoor
        ShowForm(frm)
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        Dim frm As New FrmOrderInfo
        ShowForm(frm)
    End Sub

    Private Sub cmdTest_Click(sender As Object, e As EventArgs) Handles cmdTest.Click
        Dim frm As New frmWaitTest
        ShowForm(frm)
    End Sub
#End Region

#Region "Subs & Functions"

    Public Sub Login()

        lblStatusMain.Text = "Current User: " & My.Settings.User_Full
        If My.Settings.User_security = 1 Then
        End If
        mnuAdmin.Visible = True
        mnuUserSet.Visible = True
        btnLogout.Enabled = True
        pnlHomebtns.Enabled = True
    End Sub

    Public Sub Logoff()
        btnLogout.Enabled = False
        My.Settings.User = ""
        My.Settings.User_ID = 0
        My.Settings.User_Full = ""
        My.Settings.User_security = -1
        pnlHomebtns.Enabled = False
        mnuAdmin.Visible = False
        mnuUserSet.Visible = False
        lblStatusMain.Text = "No User Logged In"
        PopLoginForm()
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
        SetParent(frm.Handle, pnlMain.Handle)
        frm.StartPosition = FormStartPosition.Manual
        Dim x As Integer = (pnlMain.Width / 2) - (frm.Width / 2)
        Dim y As Integer = ((pnlMain.Height / 2) - (frm.Height / 2) - 94)
        frm.Show()
        frm.Location = New Point(x, y)
    End Sub

    Public Sub ShowForm(ByVal frm As Form)
        frm.IsMdiContainer = False
        frm.MdiParent = Me
        frm.Show()
    End Sub




#End Region
End Class
