Imports SAP.Middleware.Connector
Imports NabcoCustomer.IFfcTableExtension
Imports Telerik.WinControls.UI
Imports System.ComponentModel

Public Class frmCustomers
    Public callingBtn As String
    Private dt As DataTable
    Public _RFCDest As RfcDestination
    Public _Repo As RfcRepository


    Private Sub frmOrder_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' gvCustomer.DataSource = My.Settings.CustomerDATA
        dt = New DataTable
        dt = ConvertToRead()
        gvCustomer.DataSource = dt
        gvCustomer.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

    End Sub

    Public Sub calledBtn(ByVal shiporsold As String)
        callingBtn = shiporsold
    End Sub

    'This function will take in the data from SAP and output more usefull data
    Private Function ConvertToRead() As DataTable
        '   Dim temp As New DataTable
        ' temp = dt
        dt = My.Settings.CustomerDATARaw
        Dim colsToDelete As List(Of DataColumn) = New List(Of DataColumn)()
        For Each col As DataColumn In dt.Columns
            Select Case col.ColumnName.ToUpper
                Case "CUSTNR"
                    col.Caption = "Customer Number"
                Case "COMPANYNAME"
                    col.Caption = "Company Name"
                Case "CITY"
                    col.Caption = "City"
                Case "STREET"
                    col.Caption = "Street"
                Case "ZIP"
                    col.Caption = "ZIP"
                Case "COUNTRY"
                    col.Caption = "Country"
                Case "REGION"
                    col.Caption = "Region"
                Case "TELEF1"
                    col.Caption = "Telephone Number"
                Case "VTWEG"
                    col.Caption = "Dist Channel"
                Case Else
                    colsToDelete.Add(col)
            End Select
        Next

        For Each col In colsToDelete
            dt.Columns.Remove(col)
        Next
        Return dt
    End Function

    Private Sub frmOrder_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        For i As Integer = 0 To gvCustomer.Columns.Count - 1
            'gvCustomer.Columns(i).Width
        Next
    End Sub

    Private Sub gvCustomer_DoubleClick(sender As Object, e As EventArgs) Handles gvCustomer.DoubleClick
        If gvCustomer.SelectedRows.Count = 0 Then
            MsgBox("Please Select a customer")
            Exit Sub
        Else
            If callingBtn = "SOLD" Then
                'frmOrderInfoOld.SETSOLDDETIALS(gvCustomer.SelectedRows(0))
            Else
                ' frmOrderInfoOld.SETSOLDDETIALS(gvCustomer.SelectedRows(0))
            End If
        End If
        Me.Close()
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        If gvCustomer.SelectedRows.Count = 0 Then
            MsgBox("Please Select a customer")
            Exit Sub
        Else
            If callingBtn = "SOLD" Then
                ' frmOrderInfoOld.SETSOLDDETIALS(gvCustomer.SelectedRows(0))
            Else
                ' frmOrderInfoOld.SETSOLDDETIALS(gvCustomer.SelectedRows(0))
            End If
        End If
        Me.Close()
    End Sub
End Class
