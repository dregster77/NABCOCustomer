Imports System.IO
Imports Microsoft.Office.Interop

Public Class Form2


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim xlApp As Object = CreateObject("Excel.Application")
        Dim excelApp As Excel.Application = xlApp



        ' Dim xlApp As Excel.Application
        'excelApp = New Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        Try

            Dim sfile As String = Application.StartupPath & "\SwingBom.xlsm"

            'put data to TextBox
            xlWorkBook = excelApp.Workbooks.Open(sfile)
            xlWorkSheet = xlWorkBook.Worksheets("Inputs")
            xlWorkSheet.Range("SalesOrderNumber").Value = "232704"
            xlWorkSheet.Range("ItemNumber").Value = "10"
            xlWorkSheet.Range("FertNumber").Value = "GT8500-100"
            xlWorkSheet.Range("QuantityOfUnits").Value = "1"
            xlWorkSheet.Range("UnitIdentification").Value = "Exterior Vestibule"
            xlWorkSheet.Range("JobName").Value = "Wood Country FG"
            xlWorkSheet.Range("Model").Value = "GT8500"

            xlWorkSheet.Range("LHPanel").Value = "LH Outswing"
            xlWorkSheet.Range("RHPanel").Value = "None"
            xlWorkSheet.Range("Panic").Value = "False"
            xlWorkSheet.Range("Finish").Value = "Clear (204)"
            xlWorkSheet.Range("LHDoorOpening").Value = "36"
            xlWorkSheet.Range("RHDoorOpening").Value = "36"
            xlWorkSheet.Range("LHOverlap").Value = "1.75"

            xlWorkSheet.Range("RHOverlap").Value = "1.75"
            xlWorkSheet.Range("CenterDivider").Value = "0"
            xlWorkSheet.Range("HeaderLength").Value = "39.5"
            xlWorkSheet.Range("Pivot").Value = "Butt Hinge/Offset Pivot"
            xlWorkSheet.Range("LHReveal").Value = "11"
            xlWorkSheet.Range("RHReveal").Value = "11"
            xlWorkSheet.Range("MtgBracket").Value = "None"
            xlWorkSheet.Range("EntryDate").Value = "3/3/2020"
            excelApp.Run("QuickRun")
            Dim filepath As String = Application.StartupPath & "\OrderInfo\" & "JobName-OrderNum.xlsm"
            ' Dim orderinfo As String = "JobName-OrderNum.xlsm"
            xlWorkBook.SaveCopyAs(filepath)

            xlWorkBook.Close(False)
            excelApp.Quit()
            SaveExcelFiletoSQL(filepath)
        Catch ex As Exception
        Finally
            GC.Collect()
            Dim xlHWND As Integer = xlApp.hwnd
            Dim ProcIDXL As Integer = 0
            GetWindowThreadProcessId(xlHWND, ProcIDXL)
            Dim xproc As Process = Process.GetProcessById(ProcIDXL)

            xlApp.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
            xlApp = Nothing
            If Not xproc.HasExited Then
                xproc.Kill()
            End If
        End Try
    End Sub

    Private Declare Auto Function GetWindowThreadProcessId Lib "user32.dll" (ByVal hwnd As IntPtr,
              ByRef lpdwProcessId As Integer) As Integer


    Private Sub SaveExcelFiletoSQL(ByVal excelfile As String)

        Try
            Dim buf = File.ReadAllBytes(excelfile)
            Dim ms As MemoryStream = New MemoryStream(buf)
            AddParam("@xlfile", buf)
            SQL = "Insert into t_orders (sap_cust_id, xlfile, filename) values (" &
                "'value1', @xlfile, 'JobName-Order1')"

            Execute(, True)
        Catch ex As Exception
            MsgBox(ex.Message,, "SaveExcelFiletoSQL")
        Finally
            ' CloseRS(RS)
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        TestSQLConnection()
    End Sub
End Class