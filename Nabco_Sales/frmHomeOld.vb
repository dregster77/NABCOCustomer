Imports System.Runtime.InteropServices

Public Class frmHomeOld

    Inherits System.Windows.Forms.Form
    Private Declare Function SetParent Lib "user32" (ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Integer
    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr

    'Sets the Home Form to be a MDI form as well as setting then
    'background image to be the 
    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles Me.Load

        '   Me.IsMdiContainer = True
        Me.WindowState = FormWindowState.Maximized
        TestConnection()

        '   Me.BackgroundImage = My.Resources.NabcoLogo
        'Me.BackgroundImageLayout = ImageLayout.Stretch

    End Sub
    Private Sub frmHome_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        PopLoginForm()
        Me.BackgroundImage = My.Resources.NabcoLogo
        Me.BackgroundImageLayout = ImageLayout.Stretch

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Logoff()
    End Sub

    Private Sub mnuTier_Click(sender As Object, e As EventArgs) Handles mnuTier.Click
        Dim frm As New frmTier
        ShowFrom(frm, True)
    End Sub
    Public Sub Login()
        stsMain.Text = "Current User: " & My.Settings.User_Full
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

    Public Sub ShowFrom(ByVal frm As Form, ByVal large As Boolean)

        SetParent(frm.Handle, pnlMDI.Handle)
        ' SetParent(frm.Handle, Me.Handle)
        'frm.IsMdiContainer = False
        ' frm.MdiParent = pnlHome
        frm.StartPosition = FormStartPosition.CenterScreen
        IIf(large = True, frm.WindowState = FormWindowState.Maximized, frm.WindowState = FormWindowState.Normal)
        frm.Show()
    End Sub

    Public Sub PopLoginForm()
        If My.Settings.User_ID = 0 Then
            Dim frm As New frmLogin
            ShowFrom(frm, False)
        End If
    End Sub


End Class

