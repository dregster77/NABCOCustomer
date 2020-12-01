Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.Remoting.Messaging
Imports Telerik.WinControls.UI

Module DatabaseMod
    Public SQL As String
    Public SQL2 As String
    Public Database As String
    Public Datasource As String
    Public CONSTR As String
    Public DR As DataTableReader
    Public RS As SqlDataReader
    Public RS2 As SqlDataReader
    Public Params As New List(Of SqlParameter)



    'Checking the Connection to the database to insure there is a proper connection 
    Public Function CheckSQLConnection() As Boolean
        Datasource = "Nabco-td"
        Database = "CPQ"
        CONSTR = "Data Source=" & Datasource & ";Initial Catalog= " & Database & " ;Integrated Security=SSPI" 'User ID= sa;Password=2SZvW9hDY7_KJC"
        Dim connection As New SqlConnection(CONSTR)



        Try
            connection.ConnectionString = CONSTR
            connection.Open()

        Catch ex As Exception
            Return False
        Finally
            connection.Close()
            connection.Dispose()
            connection = Nothing
        End Try
        Return True
    End Function

    'is closed once the reader is complete
    Public Sub SRS2(ByRef LocalRS As SqlDataReader)
        Dim connection As New SqlConnection(CONSTR)
        Dim command As New SqlCommand(SQL2, connection)
        connection.Open()
        LocalRS = command.ExecuteReader(CommandBehavior.CloseConnection)
    End Sub

    'is closed once the reader is complete
    Public Sub SRS(ByRef LocalRS As SqlDataReader)
        Dim connection As New SqlConnection(CONSTR)
        Dim command As New SqlCommand(SQL, connection)
        connection.Open()
        LocalRS = command.ExecuteReader(CommandBehavior.CloseConnection)
    End Sub

    'Closing the connection to the database after using the reader
    Public Sub CRS(ByRef LocalRS As SqlDataReader)
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
            MsgBox(SQL & "    " & ex.Message,, "Execute")
            Identity = Nothing
            SqlConnection.ClearAllPools()
            Return 0
        End Try

    End Function

    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    'Checks to make sure that they are using a unique value
    Public Function CheckDuplicate() As Boolean
        CheckDuplicate = False

        Try

            SRS(RS)
            If RS.Read Then
                If CInt(RS("cnt")) > 0 Then
                    CheckDuplicate = True
                End If
            End If
        Catch ex As Exception
            'Frm_Home.DesktopAlertMessage("Application Error - " & System.Reflection.MethodInfo.GetCurrentMethod.ToString, ex.Message, 4)
        Finally
            CRS(RS)
        End Try
        Return CheckDuplicate
    End Function

    Public Function TrimRS(ByVal Val As String) As String
        Try
            TrimRS = Trim("" & RS(Val))
        Catch ex As Exception
            ' Frm_Home.DesktopAlertMessage("Application Error - " & System.Reflection.MethodInfo.GetCurrentMethod.ToString, ex.Message, 4)
        End Try
    End Function

End Module
