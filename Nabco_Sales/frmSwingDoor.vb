Imports System
Imports System.IO
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Telerik.WinControls.UI


Public Class frmSwingDoor
    Private LoadingSpecs As Boolean

    Private Sub frmSwingDoor_Load(sender As Object, e As EventArgs) Handles Me.Load
        RemoveHandler tabparenttab.SelectedTabChanged, AddressOf tabparenttab_TabIndexChanged
        PopModelList()
        PopImages(0)
        PopApplications()
        PopSwingersImages()
        PopPivots()
        tabparenttab.SelectedTab = tabModel
        AddHandler tabparenttab.SelectedTabChanged, AddressOf tabparenttab_TabIndexChanged
    End Sub

    Private Sub btnFullPower_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnFullPower.CheckStateChanged
        If btnFullPower.CheckState = CheckState.Checked And btnLowEnergy.CheckState = CheckState.Checked Then
            btnLowEnergy.CheckState = CheckState.Unchecked
        End If

        PopModelList()
    End Sub

    Private Sub btnLowEnergy_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnLowEnergy.CheckStateChanged
        If btnFullPower.CheckState = CheckState.Checked And btnLowEnergy.CheckState = CheckState.Checked Then
            btnFullPower.CheckState = CheckState.Unchecked
        End If

        PopModelList()
    End Sub

    Private Sub btnOHC_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnOHC.CheckStateChanged

        If btnCU.CheckState = CheckState.Checked And btnOHC.CheckState = CheckState.Checked Then
            btnCU.CheckState = CheckState.Unchecked
        End If
        PopModelList()
        PopImages(3)
    End Sub

    Private Sub btnCU_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnCU.CheckStateChanged

        If btnCU.CheckState = CheckState.Checked And btnOHC.CheckState = CheckState.Checked Then
            btnOHC.CheckState = CheckState.Unchecked
        End If

        PopModelList()
        PopImages(4)
    End Sub

    Private Sub btnSide_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnSide.CheckStateChanged

        If btnSide.CheckState = CheckState.Checked And btnBottom.CheckState = CheckState.Checked Then
            btnBottom.CheckState = CheckState.Unchecked
        End If

        PopModelList()
        PopImages(2)
    End Sub

    Private Sub PopImages(ByVal clicked As Integer)
        Select Case clicked
            Case 0 ' just loading the images
                btnBottom.Image = My.Resources.Resources.bottom
                btnCU.Image = My.Resources.Resources.cu
                btnOHC.Image = My.Resources.Resources.ohc
                btnSide.Image = My.Resources.Resources.sideload
                btnBottom.Image = ResizeImage(btnBottom.Image, btnBottom.Size)
                btnCU.Image = ResizeImage(btnCU.Image, btnCU.Size)
                btnOHC.Image = ResizeImage(btnOHC.Image, btnOHC.Size)
                btnSide.Image = ResizeImage(btnSide.Image, btnSide.Size)
                Exit Select
            Case 1 ' bottom clicked
                btnBottom.Image = ResizeImage(IIf(btnBottom.IsChecked, My.Resources.bottomcheck, My.Resources.bottom), btnBottom.Size)
                Exit Select
            Case 2 ' side clicked
                btnSide.Image = ResizeImage(IIf(btnSide.IsChecked, My.Resources.sidecheck, My.Resources.sideload), btnSide.Size)
                Exit Select
            Case 3  ' ohc clicked
                btnOHC.Image = ResizeImage(IIf(btnOHC.IsChecked, My.Resources.ohccheck, My.Resources.ohc), btnOHC.Size)
                Exit Select
            Case 4  ' cu clicked
                btnCU.Image = ResizeImage(IIf(btnCU.IsChecked, My.Resources.cucheck, My.Resources.cu), btnCU.Size)
                Exit Select
        End Select
    End Sub

    Private Sub btnBottom_CheckStateChanged(ByVal sender As Object, e As EventArgs) Handles btnBottom.CheckStateChanged
        If btnSide.CheckState = CheckState.Checked And btnBottom.CheckState = CheckState.Checked Then
            btnSide.CheckState = CheckState.Unchecked
        End If

        PopModelList()
        PopImages(1)
    End Sub

    Private Sub ddlFinsih_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddlFinsih.SelectedIndexChanged
        If ddlFinsih.SelectedIndex = 0 Then
            ddlColor.Visible = True
            txtColor.Visible = False
            ddlColor.SelectedIndex = 0
        ElseIf ddlFinsih.SelectedIndex >= 1 Then
            ddlColor.Visible = False
            txtColor.Visible = True
        End If
    End Sub



    Private Sub ddlColor_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddlColor.SelectedIndexChanged
        tabApplication.Enabled = True
    End Sub

    Private Sub txtColor_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtColor.TextChanged
        If Not String.IsNullOrEmpty(txtColor.Text) Then
            tabApplication.Enabled = True
        End If
    End Sub


    ' set images for all of the buttons 



    ' Populate all the models for the selected options
    Private Sub PopModelList()
        ddlModel.Items.Clear()

        Try
            SQL = "Select m.model, m.model_id " & " from t_model m " & "  where m.status= 1  "

            If btnLowEnergy.CheckState = CheckState.Checked Then
                SQL += " and m.power_type = 0 "
            ElseIf btnFullPower.CheckState = CheckState.Checked Then
                SQL += " and m.power_type = 1 "
            End If

            If btnCU.CheckState = CheckState.Checked Then
                SQL += " and m.cuvohc = 0 "
            ElseIf btnOHC.CheckState = CheckState.Checked Then
                SQL += " and m.cuvohc = 1 "
            End If

            If btnSide.CheckState = CheckState.Checked Then
                SQL += " and m.modload = 0 "
            ElseIf btnBottom.CheckState = CheckState.Checked Then
                SQL += " and m.modload = 1 "
            End If

            SQL += "order by model"
            SetRS(RS)

            While RS.Read()
                Dim lstitem = New RadListDataItem()
                lstitem.Text = Trim("" & RS("model"))
                lstitem.Tag = Trim("" & RS("model_id"))
                ddlModel.Items.Add(lstitem)
            End While

            CloseRS(RS)
            ddlModel.SelectedIndex = 0
            ' dt.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, Title:="PopModelList")
        End Try
    End Sub


    ' Populate the application drop down
    Private Sub PopApplications()
        RemoveHandler ddlapplication.SelectedIndexChanged, AddressOf ddlapplication_SelectedIndexChanged
        RemoveHandler ddlSwing1.SelectedIndexChanged, AddressOf ddlSwing1_SelectedIndexChanged
        RemoveHandler ddlSwing2.SelectedIndexChanged, AddressOf ddlSwing2_SelectedIndexChanged
        ddlapplication.Items.Clear()
        Dim defitem = New RadListDataItem()
        defitem.Text = "Select Application"
        defitem.Tag = -1
        ddlapplication.Items.Add(defitem)

        Try
            SQL = "Select distinct a.app_name,a.app_id " & " from t_application a   " & " where  a.status= 1  "
            SetRS(RS)

            While RS.Read()
                Dim lstitem = New RadListDataItem()
                lstitem.Text = Trim("" & RS("app_name"))
                lstitem.Tag = Trim("" & RS("app_id"))
                ddlapplication.Items.Add(lstitem)
            End While

            CloseRS(RS)
            ddlapplication.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message, Title:="PopApplicaitons")
        End Try

        AddHandler ddlapplication.SelectedIndexChanged, AddressOf ddlapplication_SelectedIndexChanged
        AddHandler ddlSwing1.SelectedIndexChanged, AddressOf ddlSwing1_SelectedIndexChanged
        AddHandler ddlSwing2.SelectedIndexChanged, AddressOf ddlSwing2_SelectedIndexChanged
    End Sub


    ' Creates the image list that will fill which image is to be used
    Private Sub PopSwingersImages()
        ddlSwing1.Items.Clear()
        ddlSwing2.Items.Clear()
        Dim defitem = New RadListDataItem()
        defitem.Text = "Select Swing"
        defitem.Tag = -1
        ddlSwing1.Items.Add(defitem)
        ddlSwing2.Items.Add(defitem)

        Try
            SQL = "Select swing_image, swing_id, inout from t_swing where status = 1"
            SetRS(RS)

            While RS.Read()
                Dim buf As Byte() = RS("swing_image")

                If buf IsNot Nothing Then

                    Using ms = New MemoryStream(buf, 0, buf.Length)
                        imlSwings.Images.Add(RS("swing_id"), New Bitmap(ms))
                    End Using
                End If

            End While

            CloseRS(RS)
            ddlSwing1.SelectedIndex = 0
            ddlSwing2.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message, Title:="PopSwingers")
        End Try
    End Sub

    Private Sub PopPivots()
        ddlPivot.Items.Clear()
        Dim defitem = New RadListDataItem()
        defitem.Text = "Select Pivot"
        defitem.Tag = -1
        ddlPivot.Items.Add(defitem)

        Try
            SQL = "Select  p.* from " & " t_pivot p   " & " where  p.status= 1  "
            SetRS(RS)

            While RS.Read()
                Dim lstitem = New RadListDataItem()
                lstitem.Text = Trim("" & RS("pivot_name"))
                lstitem.Tag = RS("pivot_id")
                lstitem.Value = RS("finger_pro")
                ddlPivot.Items.Add(lstitem)
            End While

            CloseRS(RS)
            ddlPivot.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message, Title:="PopPivots")
        End Try
    End Sub

    Private Function DispPanic() As Boolean
        Dim DispPanicRet As Boolean = Nothing

        Try
            SQL = "Select inout from t_swing where swing_id = " & ddlSwing1.SelectedItem.Tag

            If ddlSwing2.Visible = True Then
                SQL += " or swing_id = " & ddlSwing2.SelectedItem.Tag
            End If

            SetRS(RS)

            If RS.Read() Then
                DispPanicRet = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message, Title:="DispPanic")
        Finally
            CloseRS(RS)
        End Try

        If ddlapplication.SelectedItem.Text = "Double Egress" And ddlPivot.SelectedItem.Text <> "Butt Hinge" Then
            DispPanicRet = True
            Return DispPanicRet
        ElseIf ddlPivot.SelectedItem.Text = "Butt Hinge" Then
            DispPanicRet = False
            Return DispPanicRet
        End If

        Return DispPanicRet
    End Function

    ' Gets the defined 
    Private Sub PopDoorSpecs()
        LoadingSpecs = True
        Dim tempOpen As Double

        Try
            SQL = "Select ms.overlap_min, overlap_def, ms.reveal_limit, ms.reveal_limit_lng, ms.door_opening " &
            " from ((t_model_specs ms left join t_model m on   m.model_id =ms.model_id) " &
            " left join t_application a on  a.app_id = ms.app_id) " &
            " left join t_pivot p on p.pivot_id = ms.pivot_id " &
            " where p.pivot_id = " & ddlPivot.SelectedItem.Tag &
            " and m.model_id = " & ddlModel.SelectedItem.Tag &
            " and a.app_id = " & ddlapplication.SelectedItem.Tag &
            " and swing_dir = (Select inout from t_swing where swing_id =" & ddlSwing1.SelectedItem.Tag & " )"
            SetRS(RS)

            If RS.Read() Then
                txtRHReveal.Minimum = RS("reveal_limit")
                txtRHReveal.Maximum = RS("reveal_limit_lng")
                txtLHReveal.Maximum = RS("reveal_limit_lng")
                txtLHReveal.Minimum = RS("reveal_limit")
                txtOverlap.Minimum = RS("overlap_min")
                txtOverlap.Value = RS("overlap_def")

                If txtRHDoorW.Visible = True Then
                    txtLHDoorW.Value = RS("door_opening")
                    txtRHDoorW.Value = RS("door_opening")
                Else
                    txtLHDoorW.Value = RS("door_opening")
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, Title:="PopDoorSpecs")
        Finally
            CloseRS(RS)
            LoadingSpecs = False
            txtHeaderLength.Value = GetHeaderLength()
        End Try
    End Sub

    ' clears all the options that are not default
    Private Sub ClearVisibleSpecs()
        lblPanic.Visible = False
        chkPanic.Visible = False
        lblLHReveal.Text = "Reveal:"
        lblRHReveal.Visible = False
        txtRHReveal.Visible = False
        lblMatchW.Visible = False
        chkMatchW.Visible = False
        lblCenterJamb.Visible = False
        txtCenterJamb.Visible = False
        lblJambtoPivot.Visible = False
        txtJambtoPivot.Visible = False
        lblRHOpMan.Visible = False
        lblDoorWidth.Text = "Door Width:"
        ddlRHOp.Visible = False
        ddlLHOp.Visible = False
    End Sub

    ' Determines what information should be displayed when they are on the specs screen
    Private Sub GetDoorSpecs()
        If tabApplication.Enabled = False Then Return
        If tabDimensions.Enabled = False Then Return
        If ddlapplication.SelectedItem Is Nothing Then Return
        If ddlapplication.SelectedIndex = 0 Then Return
        If ddlPivot.SelectedIndex = 0 Then Return
        ClearVisibleSpecs()

        If DispPanic() Then
            lblPanic.Visible = True
            chkPanic.Visible = True
        End If

        Dim switchExpr = ddlapplication.SelectedItem.Text

        Select Case switchExpr
            Case "Single"
                lblLHReveal.Text = "Reveal:"
                txtLHReveal.Visible = True
                lblRHReveal.Visible = False
                txtRHReveal.Visible = False
                Exit Select
            Case "Sim Pair"
                lblMatchW.Visible = True
                chkMatchW.Visible = True
                lblDoorWidth.Text = "LH Door Width:"
                lblJambtoPivot.Visible = True
                txtJambtoPivot.Visible = True
                lblRHDoorWidth.Visible = True
                txtRHDoorW.Visible = True
                Exit Select
            Case "Double Egress"
                lblMatchW.Visible = True
                chkMatchW.Visible = True
                lblDoorWidth.Text = "LH Door Width:"
                lblJambtoPivot.Visible = True
                txtJambtoPivot.Visible = True
                lblRHDoorWidth.Visible = True
                txtRHDoorW.Visible = True
                Exit Select
            Case "Dual"
                lblRHReveal.Visible = True
                txtRHReveal.Visible = True
                lblMatchW.Visible = True
                chkMatchW.Visible = True
                lblDoorWidth.Text = "LH Door Width:"
                lblJambtoPivot.Visible = True
                txtJambtoPivot.Visible = True
                lblRHDoorWidth.Visible = True
                txtRHDoorW.Visible = True
                lblCenterJamb.Visible = True
                txtCenterJamb.Visible = True
                Exit Select
            Case "OpMan"
                lblRHReveal.Visible = True
                txtRHReveal.Visible = True
                lblMatchW.Visible = True
                chkMatchW.Visible = True
                lblDoorWidth.Text = "LH Door Width:"
                lblJambtoPivot.Visible = True
                txtJambtoPivot.Visible = True
                lblRHDoorWidth.Visible = True
                txtRHDoorW.Visible = True
                lblCenterJamb.Visible = True
                txtCenterJamb.Visible = True
                lblLHOpMan.Visible = True
                ddlLHOp.Visible = True
                ddlRHOp.Visible = True
                lblRHOpMan.Visible = True
                Exit Select
        End Select

        PopDoorSpecs()

        If txtFingerGuard.Visible = False Then
            txtJambtoPivot.Value = 2.75
        Else
            txtJambtoPivot.Value = 3.75
        End If
    End Sub

    Private Function GetHeaderLength() As Double
        Dim GetHeaderLengthRet As Double = Nothing
        If LoadingSpecs = True Then Return GetHeaderLengthRet

        If If(ddlapplication.SelectedItem.Text, "") = "Single" Then
            GetHeaderLengthRet = txtLHDoorW.Value

            If txtFingerGuard.Visible = True Then
                GetHeaderLengthRet += 1
            End If
        Else
            GetHeaderLengthRet = txtLHDoorW.Value + txtRHDoorW.Value

            If txtFingerGuard.Visible = True Then
                GetHeaderLengthRet += 2
            End If

            If txtCenterJamb.Visible = True Then GetHeaderLengthRet += txtCenterJamb.Value
        End If

        If txtOverlap.Visible = True Then
            GetHeaderLengthRet += Conversions.ToDouble(txtOverlap.Value * CDec(2))
        End If

        Return GetHeaderLengthRet
    End Function

    ' 0 And 1 are left And right anything else pops the grid without the left And right side
    Private Sub PopSwingOptions(ByRef ddl As RadDropDownList, ByVal rightleft As Short)
        ddl.Items.Clear()
        Dim defitem = New RadListDataItem()
        defitem.Text = "Select Swing"
        defitem.Tag = -1
        ddl.Items.Add(defitem)

        Try
            SQL = "Select * from t_swing where app_id = " & ddlapplication.SelectedItem.Tag

            If rightleft = 0 Then
                SQL += " and disp_panel = " & rightleft
            ElseIf rightleft = 1 Then
                SQL += " and disp_panel = " & rightleft
            End If

            SetRS(RS)

            While RS.Read()
                Dim lstitem = New RadListDataItem()
                lstitem.Text = Trim("" & RS("swing_name"))
                lstitem.Tag = Trim("" & RS("swing_id"))
                ddl.Items.Add(lstitem)
            End While

            ddl.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message, "PopSwingOptions")
        End Try
    End Sub

    Private Function ShowSpecsTab() As Boolean
        Dim ShowSpecsTabRet As Boolean = Nothing

        If ddlapplication.SelectedIndex > 0 Then
            ShowSpecsTabRet = True
        Else
            ddlapplication.SelectedIndex = 0
            ShowSpecsTabRet = False
            GoTo Endfun
        End If

        If ddlPivot.SelectedIndex > 0 Then
            ShowSpecsTabRet = True
        Else
            ddlPivot.SelectedIndex = 0
            ShowSpecsTabRet = False
            GoTo Endfun
        End If

        If ddlSwing1.SelectedIndex > 0 Then
            ShowSpecsTabRet = True

            If ddlSwing2.Visible = False Then
                GoTo Endfun
            End If
        Else
            ddlSwing1.SelectedIndex = 0
            ShowSpecsTabRet = False
            GoTo Endfun
        End If

        If ddlSwing2.SelectedIndex > 0 Then
            ShowSpecsTabRet = True
        Else
            ddlSwing2.SelectedIndex = 0
            ShowSpecsTabRet = False
            GoTo Endfun
        End If

Endfun:
        Return ShowSpecsTabRet
    End Function

    Private Sub ddlapplication_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddlapplication.SelectedIndexChanged
        If ddlapplication.SelectedIndex = 0 Then
            tabDimensions.Enabled = False
            pnlSwing.Visible = False
        Else
            ddlSwing1.FilterExpression = Trim("" & ddlapplication.SelectedItem.Value)
            pnlSwing.Visible = True
            pnlSwing.Text = "Select " & ddlapplication.Text & " swing"

            If ddlapplication.SelectedItem.Text = "Dual" Or ddlapplication.SelectedItem.Text = "OpMan" Then
                lblSwing1.Text = "Left Side:"
                lblSwing2.Text = "Right Side:"
                lblSwing2.Visible = True
                ddlSwing2.Visible = True
                pctSwingTwo.Visible = True
                Dim argddl = ddlSwing1
                PopSwingOptions(argddl, 0)
                Dim argddl1 = ddlSwing2
                PopSwingOptions(argddl1, 1)
            Else
                Dim argddl2 = ddlSwing1
                PopSwingOptions(argddl2, 2)
                lblSwing2.Visible = False
                ddlSwing2.Visible = False
                pctSwingTwo.Visible = False
                lblSwing1.Text = "Swing:"
            End If
        End If

        tabDimensions.Enabled = ShowSpecsTab()
    End Sub

    Private Function GetCompelteImage() As String
        Dim GetCompelteImageRet As String = Nothing
        GetCompelteImageRet = ""

        Try
            SQL = "Select img_fname from t_swing " & " where swing_id = " & ddlSwing1.SelectedItem.Tag & " or swing_id = " & ddlSwing2.SelectedItem.Tag
            SetRS(RS)

            While RS.Read()
                GetCompelteImageRet += Trim("" & RS("img_fname"))
                GetCompelteImageRet += "_"
            End While

        Catch ex As Exception
            MsgBox(ex.Message, Title:="GetCompleteImage")
        Finally
            CloseRS(RS)
        End Try

        GetCompelteImageRet = GetCompelteImageRet.Substring(0, GetCompelteImageRet.Length - 1)
        Return GetCompelteImageRet
    End Function

    Private Sub ddlSwing1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddlSwing1.SelectedIndexChanged

        pctSwingOne.Image = imlSwings.Images(ddlSwing1.SelectedItem.Tag)

        If ddlSwing1.SelectedIndex > 0 Then
            pctSpecsComplete.Image = imlSwings.Images(ddlSwing1.SelectedItem.Tag)
            ' 
            ' 
            If ddlapplication.SelectedItem.Text = "Dual" Or ddlapplication.SelectedItem.Text = "OpMan" Then
                If ddlSwing2.SelectedIndex > 0 Then
                    pctComplete.Image = ResizeImage(My.Resources.ResourceManager.GetObject(GetCompelteImage), pctComplete.Size)
                End If
            End If
        ElseIf ddlSwing1.SelectedIndex = 0 Then
            pctSwingOne.Image = Nothing
        End If

        tabDimensions.Enabled = ShowSpecsTab()
    End Sub

    Private Sub ddlSwing2_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddlSwing2.SelectedIndexChanged
        If ddlSwing2.SelectedIndex > 0 Then

            pctSwingTwo.Image = imlSwings.Images(ddlSwing2.SelectedItem.Tag)
            If ddlapplication.SelectedItem.Text = "Dual" Or ddlapplication.SelectedItem.Text = "OpMan" Then

                If ddlSwing1.SelectedIndex > 0 Then
                    pctComplete.Image = ResizeImage(My.Resources.ResourceManager.GetObject(GetCompelteImage), pctComplete.Size)
                End If
            End If
        ElseIf ddlSwing2.SelectedIndex = 0 Then
            pctComplete.Image = Nothing
            pctSwingTwo.Image = Nothing
        End If

        tabDimensions.Enabled = ShowSpecsTab()
    End Sub

    Private Sub tabparenttab_TabIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tabparenttab.TabIndexChanged
        If tabparenttab.SelectedTab Is tabDimensions Then

            If ShowSpecsTab() = True Then
                pctSpecsComplete.Image = ResizeImage(My.Resources.ResourceManager.GetObject(GetCompelteImage), pctSpecsComplete.Size)
            End If

            GetDoorSpecs()
        End If
    End Sub

    Private Sub ddlPivot_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddlPivot.SelectedIndexChanged
        If ddlPivot.SelectedIndex > 0 Then
            pnlSpecs.Enabled = True

            If ddlPivot.SelectedItem.Value = 1 Then
                lblFingerGuard.Visible = True
                txtFingerGuard.Visible = True
            Else
                lblFingerGuard.Visible = False
                txtFingerGuard.Visible = False
            End If
        Else
            pnlSpecs.Enabled = False
        End If

        tabDimensions.Enabled = ShowSpecsTab()
    End Sub

    Private Sub txtLHDoorW_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtLHDoorW.ValueChanged
        If txtLHDoorW.Visible = False Then Return
        txtHeaderLength.Value = Conversions.ToDecimal(GetHeaderLength())
    End Sub

    Private Sub txtRHDoorW_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtRHDoorW.ValueChanged
        If txtRHDoorW.Visible = False Then Return
        txtHeaderLength.Value = Conversions.ToDecimal(GetHeaderLength())
    End Sub

    Private Sub txtOverlap_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtOverlap.ValueChanged
        If txtOverlap.Visible = False Then Return
        txtHeaderLength.Value = GetHeaderLength()
    End Sub

    Private Sub txtCenterJamb_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtCenterJamb.ValueChanged
        If txtCenterJamb.Visible = False Then Return
        Me.txtHeaderLength.Value = GetHeaderLength()
    End Sub

End Class
