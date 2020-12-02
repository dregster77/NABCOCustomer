Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports SAP.Middleware.Connector

Public Class IFfcTableExtension

    Public Shared Function ToDataTable(ByVal sapTable As IRfcTable, ByVal name As String) As DataTable
        Dim adoTable As DataTable = New DataTable(name)


        'ADD THE COLUMNS YOU NEED TO DATATABLE
        For liElement As Integer = 0 To sapTable.ElementCount - 1
            Dim metadata As RfcElementMetadata = sapTable.GetElementMetadata(liElement)
            'If metadata.Name = "FIRSTNAME" Or metadata.Name = "LASTNAME" Or metadata.Name = "ONEUSE_FLAG" Or metadata.Name = "CREATION_DATE" Or metadata.Name = "EXTRA_DATA" Then GoTo skiprow
            If metadata.Name = "ONEUSE_FLAG" Or metadata.Name = "CREATION_DATE" Or metadata.Name = "EXTRA_DATA" Then GoTo skiprow
            adoTable.Columns.Add(metadata.Name, GetDataType(metadata.DataType))


            'MsgBox(metadata.Name & "   " & metadata.Documentation)
skiprow:
        Next

        'ADDS THE ROWS TO THE DATATABLE
        For Each row As IRfcStructure In sapTable

            Dim ldr As DataRow = adoTable.NewRow()
            If row(15).GetValue.ToString = "D" Then GoTo NextRow
            If row(6).GetValue.ToString = "" Then
                row(6).SetValue(row(4).GetValue.ToString)
            End If
            'MsgBox(row(5).GetValue.ToString & "    " & row(4).GetValue.ToString & "       " & row(6).GetValue.ToString)

            For liElement As Integer = 0 To sapTable.ElementCount - 1
                Dim metadata As RfcElementMetadata = sapTable.GetElementMetadata(liElement)
                If metadata.Name = "ONEUSE_FLAG" Or metadata.Name = "CREATION_DATE" Or metadata.Name = "EXTRA_DATA" Then GoTo skiprow2
                Select Case metadata.DataType
                    Case RfcDataType.DATE
                        Dim STR As String = row.GetString(metadata.Name).Substring(0, 4) + row.GetString(metadata.Name).Substring(5, 2) + row.GetString(metadata.Name).Substring(8, 2)
                        If Left(STR, 1) <> "0" Then STR = Date.ParseExact(STR, "yyyyMMdd", CultureInfo.InvariantCulture)
                        ldr(metadata.Name) = STR
                    Case RfcDataType.BCD
                        ldr(metadata.Name) = row.GetDecimal(metadata.Name)
                    Case RfcDataType.CHAR
                        ldr(metadata.Name) = row.GetString(metadata.Name).TrimStart("0"c)
                    Case RfcDataType.STRING
                        ldr(metadata.Name) = row.GetString(metadata.Name)
                    Case RfcDataType.INT2
                        ldr(metadata.Name) = row.GetInt(metadata.Name)
                    Case RfcDataType.INT4
                        ldr(metadata.Name) = row.GetInt(metadata.Name)
                    Case RfcDataType.FLOAT
                        ldr(metadata.Name) = row.GetDouble(metadata.Name)
                    Case Else
                        ldr(metadata.Name) = row.GetString(metadata.Name)
                End Select
skiprow2:
            Next

            adoTable.Rows.Add(ldr)
NextRow:
        Next

        Return adoTable
    End Function

    Private Shared Function GetDataType(ByVal rfcDataType As RfcDataType) As Type
        Select Case rfcDataType
            Case RfcDataType.DATE
                Return GetType(String)
            Case RfcDataType.CHAR
                Return GetType(String)
            Case RfcDataType.STRING
                Return GetType(String)
            Case RfcDataType.BCD
                Return GetType(Decimal)
            Case RfcDataType.INT2
                Return GetType(Integer)
            Case RfcDataType.INT4
                Return GetType(Integer)
            Case RfcDataType.FLOAT
                Return GetType(Double)
            Case Else
                Return GetType(String)
        End Select
    End Function

End Class

