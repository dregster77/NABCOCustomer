
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Text
Imports System.Xml
Imports Telerik.WinControls.UI

Module SupportMod
    Public Sub ClearGrid(ByRef GRD As RadGridView)
        GRD.Rows.Clear()
        GRD.Columns.Clear()
    End Sub

    Public Function ResizeImage(ByVal image As Image,
              ByVal size As Size, Optional ByVal preserveAspectRatio As Boolean = True) As Image
        Dim newWidth As Integer
        Dim newHeight As Integer
        If preserveAspectRatio Then
            Dim originalWidth As Integer = image.Width
            Dim originalHeight As Integer = image.Height
            Dim percentWidth As Single = CSng(size.Width) / CSng(originalWidth)
            Dim percentHeight As Single = CSng(size.Height) / CSng(originalHeight)
            Dim percent As Single = If(percentHeight < percentWidth,
                    percentHeight, percentWidth)
            newWidth = CInt(originalWidth * percent)
            newHeight = CInt(originalHeight * percent)
        Else
            newWidth = size.Width
            newHeight = size.Height
        End If
        Dim newImage As Image = New Bitmap(newWidth, newHeight)
        Using graphicsHandle As Graphics = Graphics.FromImage(newImage)
            graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic
            graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight)
        End Using
        Return newImage
    End Function

    'Grabs the grid layout information from the database and will load it 
    Public Sub LoadGridLayout(ByRef GRD As RadGridView, ByVal frmnme As String)
        Try
            SQL = "Select * From t_settings where sap_username = '" & My.Settings.Sap_User & "'" &
            " and grid_name = '" & GRD.Name.ToUpper & "' " &
            " and form_name  = '" & frmnme.ToUpper & "'"
            SetRS(RS)
            If RS.Read Then
                Dim xmlString As String = ""
                xmlString = RS("grid_layout")
                Using xr As XmlReader = XmlReader.Create(New System.IO.StringReader(xmlString))
                    GRD.LoadLayout(xr)
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CloseRS(RS)
        End Try
    End Sub

    Public Sub SaveGridLayout(ByRef GRD As RadGridView, ByVal frmnme As String)
        Try
            Dim xmlString As String = ""

            'Dim layout As String = Encoding.ASCII.GetString(ms.GetBuffer(), 0, CInt(ms.Length))
            Using MS As MemoryStream = New MemoryStream()
                GRD.SaveLayout(MS)
                xmlString = Encoding.ASCII.GetString(MS.GetBuffer(), 0, CInt(MS.Length))
            End Using
            'Upsert statement 
            SQL = "Update t_settings set " &
                 " grid_layout = '" & xmlString & "' " &
                 " where  sap_username = '" & My.Settings.Sap_User & "' and  " & vbCrLf &
                 " grid_name = '" & GRD.Name.ToUpper & "' and " & vbCrLf &
                 " form_name = '" & frmnme.ToUpper & " '  " & vbCrLf &
                 " if @@rowcount = 0 " &
                 " insert into t_settings (grid_name,  sap_username, form_name, grid_layout) Values (" &
                 " '" & GRD.Name.ToUpper & "', " & vbCrLf &         'Grid Name    
                 " '" & My.Settings.Sap_User & "'," & vbCrLf &      'Sap User Name
                 " '" & frmnme.ToUpper & "'," & vbCrLf &            'Form Name
                 " '" & xmlString & "')"                           'Grid Layout
            Execute()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CloseRS(RS)
        End Try
    End Sub

End Module
