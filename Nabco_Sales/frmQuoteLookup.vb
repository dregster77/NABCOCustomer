Imports Telerik.WinControls.UI

Public Class frmQuoteLookup
    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles btnEditOrder.Click

    End Sub

    Private Sub frmQuoteLookup_Load(sender As Object, e As EventArgs) Handles Me.Load
        PopQuoteHistory()
    End Sub

    Private Sub PopQuoteHistory()
        Try
            SQL = "Select * from t_quote"
            SetRS(RS)
            While RS.Read
                Dim rowinfo As GridViewRowInfo = gvQuoteLookup.Rows.AddNew
                rowinfo.Cells("quote_num").Value = Trim("" & RS("quote_id"))
                rowinfo.Cells("customer_po").Value = Trim("" & RS("customer_po"))
                rowinfo.Cells("job_name").Value = Trim("" & RS("job_name"))
                rowinfo.Cells("shipping_method").Value = Trim("" & RS("shipping_method"))
                rowinfo.Cells("cust_contact").Value = Trim("" & RS("customer_contact"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CloseRS(RS)
        End Try
    End Sub
End Class
