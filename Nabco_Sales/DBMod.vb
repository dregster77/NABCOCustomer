Imports System.Data.SqlClient
Module DBMod

    Public SQL As String
    Public Const CONSTR As String = "Data Source=Nabco-td;Initial Catalog= NabcoSales;User ID= sa;Password=2SZvW9hDY7_KJC"
    Public DR As DataTableReader
    Public RS As SqlDataReader

    'Checking the Connection to the database to insure there is a proper connection 
    Public Sub TestConnection()
        Dim con As New SqlConnection
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

    'This will pull the data using a sql call establish then will return a datatable that you can read from 
    Public Sub GetData(ByRef DT As DataTable)
        Dim connection As New SqlConnection(CONSTR)
        Dim command As New SqlCommand(SQL, connection)
        Dim rdr As SqlDataReader
        Try
            connection.Open()
            rdr = command.ExecuteReader()
            DT.Load(rdr)
            command.Dispose()
            command = Nothing
            connection.Dispose()
            connection = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Opening the connection to the database and then also making sure that the connection 
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
    Public Function Execute(Optional ByRef Identity As Int32 = 0) As Integer
        Try
            Dim connection As New SqlConnection(CONSTR)
            Dim command As New SqlCommand(SQL, connection)

            connection.Open()

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



End Module
