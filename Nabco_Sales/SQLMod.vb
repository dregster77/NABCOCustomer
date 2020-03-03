Imports System.Data.SqlClient
Module SQLMod

    Public SQL As String
    Public Const CONSTR As String = "Data Source=Nabco-td;Initial Catalog= NabcoSales;User ID= sa;Password=2SZvW9hDY7_KJC"
    Public DR As DataTableReader
    Public RS As SqlDataReader
    Public Params As New List(Of SqlParameter)

    'Checking the Connection to the database to insure there is a proper connection 
    Public Sub TestSQLConnection()
        Dim con As New SqlConnection(CONSTR)
        Try
            con.ConnectionString = CONSTR
            con.Open()

        Catch ex As Exception
            MsgBox(ex.Message,, "Test Connection")
        Finally
            con.Close()
            con.Dispose()
            con = Nothing
        End Try
    End Sub



    'is closed once the reader is complete
    Public Sub SetRS(ByRef LocalRS As SqlDataReader)
        Dim connection As New SqlConnection(CONSTR)
        Dim command As New SqlCommand(SQL, connection)

        connection.Open()
        LocalRS = command.ExecuteReader(CommandBehavior.CloseConnection)
    End Sub

    'Closing the connection to the database after using the reader
    Public Sub CloseRS(ByRef LocalRS As SqlDataReader)
        If Not IsNothing(LocalRS) Then
            LocalRS.Close()
            LocalRS = Nothing
        End If
    End Sub

    'executes and update,delete, or insert statement and you may have it send back the id of the record that you just updated. 
    Public Function Execute(Optional ByRef Identity As Int32 = 0, Optional ByVal UseParms As Boolean = False) As Integer
        Try
            Dim connection As New SqlConnection(CONSTR)
            Dim command As New SqlCommand(SQL, connection)

            'open the database connection
            connection.Open()
            If UseParms = True Then
                Params.ForEach(Sub(p) command.Parameters.Add(p))
                Params.Clear()

            End If

            Execute = command.ExecuteNonQuery()

            command.CommandText = "select @@identity"
            Identity = Val("" & command.ExecuteScalar())
            command.Dispose()
            command = Nothing
            connection.Dispose()
            connection = Nothing
            Return Identity
        Catch ex As Exception
            MsgBox(ex.Message,, "Execute")
            Identity = Nothing
            SqlConnection.ClearAllPools()
            Return 0
        End Try

    End Function

    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub



End Module
