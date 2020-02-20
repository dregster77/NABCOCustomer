Imports Telerik.WinControls.UI

Public Class frmOrderInfo
    Private Sub frmOrderInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim navele = TryCast(Me.pvOrderInfo.ViewElement, RadPageViewNavigationViewElement)
        navele.Expand()
        ddlSalesOffice.SelectedIndex = 0
        'dalaCustomer.DataSource = My.Settings.CustomerDATA
        '  pvOrderInfo.ViewElement.p
    End Sub

    Private Sub frmOrderInfo_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        ' navele.DisplayMode = NavigationViewDisplayModes.Expanded

    End Sub

End Class
