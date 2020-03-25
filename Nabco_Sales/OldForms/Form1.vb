Imports Nabco_Sales.SQLMod
Imports System.ComponentModel
Imports System.IO
Imports Telerik.WinControls.UI

Public Class Form1

    Dim tempdt As DataTable
    Private sql2 As New TestSQLControl
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Chose Image (*.JPG; *.png; *.gif)| *.JPG; *.png; *.gif"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ms As New MemoryStream()
        Dim img As Image = PictureBox1.Image
        img.Save(ms, img.RawFormat)
        Dim buf As Byte() = ms.GetBuffer

        'sql2.AddParam("@app_id", 1)
        sql2.AddParam("@image", buf)

        sql2.ExecQuery("Update t_swing set swing_image = @image where swing_id = " & NumericUpDown1.Value)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox2.Image = PictureBox1.Image
        ' PictureBox1.Image = Nothing
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        sql2.ExecQuery("Select swing_image, swing_id, swing_name from t_swing where swing_id = " & NumericUpDown1.Value)
        Dim buf As Byte() = sql2.DBDS.Tables(0).Rows(0)("swing_image")

        If buf IsNot Nothing Then
            Using ms As New MemoryStream(buf, 0, buf.Length)
                ms.Write(buf, 0, buf.Length)
                PictureBox1.Image = Image.FromStream(ms, True)
            End Using
        End If
        Label1.Text = sql2.DBDS.Tables(0).Rows(0)("swing_id")
        TextBox1.Text = sql2.DBDS.Tables(0).Rows(0)("swing_name")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btntest.Click
        If btntest.Text = "Remove Handler" Then
            btntest.Text = "Add Handler"
            RemoveHandler Button1.Click, AddressOf Button1_Click
        Else
            btntest.Text = "Remove Handler"
            AddHandler Button1.Click, AddressOf Button1_Click
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        tempdt = New DataTable
        TestSQLConnection()
        My.Settings.Sap_User = "idreger"
        LoadGridLayout(RadGridView1, Me.Name)
        SQL = "select * from t_user"
        SetRS(RS)
        If RS.Read Then

            tempdt.Load(RS)
        End If
        CloseRS(RS)

        txtUser.AutoCompleteDataSource = tempdt
        txtUser.AutoCompleteDisplayMember = "user_name"
        txtUser.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim autoCompleteItems As RadListDataItemCollection = Me.txtu2.AutoCompleteItems
        autoCompleteItems.Add(New RadListDataItem("Luke"))
        autoCompleteItems.Add(New RadListDataItem("Max"))
        autoCompleteItems.Add(New RadListDataItem("Adam"))
        autoCompleteItems.Add(New RadListDataItem("Henry"))
        autoCompleteItems.Add(New RadListDataItem("Jack"))
        autoCompleteItems.Add(New RadListDataItem("Ben"))
        autoCompleteItems.Add(New RadListDataItem("Tyler"))
        autoCompleteItems.Add(New RadListDataItem("Ethan"))
        autoCompleteItems.Add(New RadListDataItem("David"))
        autoCompleteItems.Add(New RadListDataItem("Mike"))

    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SaveGridLayout(RadGridView1, Me.Name)
    End Sub


End Class