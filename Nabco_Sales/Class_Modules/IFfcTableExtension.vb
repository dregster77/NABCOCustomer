Imports System.Runtime.CompilerServices
Imports SAP.Middleware.Connector

Public Class IFfcTableExtension

    Public Shared Function ToDataTable(ByVal sapTable As IRfcTable, ByVal name As String) As DataTable
        Dim adoTable As DataTable = New DataTable(name)

        For liElement As Integer = 0 To sapTable.ElementCount - 1
            Dim metadata As RfcElementMetadata = sapTable.GetElementMetadata(liElement)
            adoTable.Columns.Add(metadata.Name, GetDataType(metadata.DataType))
        Next

        For Each row As IRfcStructure In sapTable
            Dim ldr As DataRow = adoTable.NewRow()

            For liElement As Integer = 0 To sapTable.ElementCount - 1
                Dim metadata As RfcElementMetadata = sapTable.GetElementMetadata(liElement)

                Select Case metadata.DataType
                    Case RfcDataType.DATE
                        ldr(metadata.Name) = row.GetString(metadata.Name).Substring(0, 4) + row.GetString(metadata.Name).Substring(5, 2) + row.GetString(metadata.Name).Substring(8, 2)
                    Case RfcDataType.BCD
                        ldr(metadata.Name) = row.GetDecimal(metadata.Name)
                    Case RfcDataType.CHAR
                        ldr(metadata.Name) = row.GetString(metadata.Name)
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
            Next

            adoTable.Rows.Add(ldr)
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

