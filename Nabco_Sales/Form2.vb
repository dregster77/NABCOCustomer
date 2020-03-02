Imports Microsoft.Office.Interop

Public Class Form2
    Dim xlApp As Excel.Application = New Excel.Application()
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim sfile As String = Application.StartupPath & "\SwingBom.xlsm"

        'put data to TextBox

        xlApp = New Excel.Application()
        xlWorkBook = xlApp.Workbooks.Open(sFile)
        xlWorkSheet = xlWorkBook.Worksheets("Inputs")
        xlWorkSheet.Cells(10, 2).value = TextBox1.Text
        xlWorkBook.SaveCopyAs(Application.StartupPath & "\NewOrder.xlsm")
        ' xlApp.Modules.r
        xlWorkBook.Close()
        xlApp.Quit()



    End Sub
End Class