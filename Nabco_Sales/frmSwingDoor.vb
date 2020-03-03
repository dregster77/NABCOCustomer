Imports System
Imports System.IO
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Telerik.WinControls.UI
Imports Microsoft.Office.Interop

Public Class frmSwingDoor
    Private LoadingSpecs As Boolean
    Private SkipPop As Boolean

    Private Sub frmSwingDoor_Load(sender As Object, e As EventArgs) Handles Me.Load
        RemoveHandler tabparenttab.SelectedTabChanged, AddressOf tabparenttab_TabIndexChanged
        PopModelList()
        PopBtnImages()
        PopApplications()
        PopSwingersImages()
        PopPivots()
        tabparenttab.SelectedTab = tabModel
        ddlFinish.SelectedIndex = 0
        AddHandler tabparenttab.SelectedTabChanged, AddressOf tabparenttab_TabIndexChanged
    End Sub

    Private Sub btnFullPower_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnFullPower.CheckStateChanged
        If SkipPop = True Then Exit Sub
        If btnFullPower.CheckState = CheckState.Checked And btnLowEnergy.CheckState = CheckState.Checked Then
            SkipPop = True
            btnLowEnergy.CheckState = CheckState.Unchecked
            SkipPop = False
        End If

        PopModelList()
    End Sub

    Private Sub btnLowEnergy_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnLowEnergy.CheckStateChanged
        If SkipPop = True Then Exit Sub
        If btnFullPower.CheckState = CheckState.Checked And btnLowEnergy.CheckState = CheckState.Checked Then
            SkipPop = True
            btnFullPower.CheckState = CheckState.Unchecked
            SkipPop = False
        End If
        PopModelList()
    End Sub

    Private Sub btnOHC_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnOHC.CheckStateChanged
        btnOHC.Image = ResizeImage(IIf(btnOHC.IsChecked, My.Resources.ohccheck, My.Resources.ohc), btnOHC.Size)
        If SkipPop = True Then Exit Sub
        If btnCU.CheckState = CheckState.Checked And btnOHC.CheckState = CheckState.Checked Then
            SkipPop = True
            btnCU.CheckState = CheckState.Unchecked
            SkipPop = False
        End If
        PopModelList()
    End Sub

    Private Sub btnCU_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnCU.CheckStateChanged
        btnCU.Image = ResizeImage(IIf(btnCU.IsChecked, My.Resources.cucheck, My.Resources.cu), btnCU.Size)
        If SkipPop = True Then Exit Sub
        If btnCU.CheckState = CheckState.Checked And btnOHC.CheckState = CheckState.Checked Then
            SkipPop = True
            btnOHC.CheckState = CheckState.Unchecked
            SkipPop = False
        End If

        PopModelList()
    End Sub

    Private Sub btnSide_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnSide.CheckStateChanged
        btnSide.Image = ResizeImage(IIf(btnSide.IsChecked, My.Resources.sidecheck, My.Resources.sideload), btnSide.Size)
        If SkipPop = True Then Exit Sub
        If btnSide.CheckState = CheckState.Checked And btnBottom.CheckState = CheckState.Checked Then
            SkipPop = True
            btnBottom.CheckState = CheckState.Unchecked
            SkipPop = False
        End If

        PopModelList()
    End Sub

    Private Sub btnBottom_CheckStateChanged(ByVal sender As Object, e As EventArgs) Handles btnBottom.CheckStateChanged
        btnBottom.Image = ResizeImage(IIf(btnBottom.IsChecked, My.Resources.bottomcheck, My.Resources.bottom), btnBottom.Size)
        If SkipPop = True Then Exit Sub

        If btnSide.CheckState = CheckState.Checked And btnBottom.CheckState = CheckState.Checked Then
            SkipPop = True
            btnSide.CheckState = CheckState.Unchecked
            SkipPop = False
        End If

        PopModelList()
    End Sub

    ' set images for all of the buttons 
    Private Sub PopBtnImages()
        btnBottom.Image = My.Resources.Resources.bottom
        btnCU.Image = My.Resources.Resources.cu
        btnOHC.Image = My.Resources.Resources.ohc
        btnSide.Image = My.Resources.Resources.sideload
        btnBottom.Image = ResizeImage(btnBottom.Image, btnBottom.Size)
        btnCU.Image = ResizeImage(btnCU.Image, btnCU.Size)
        btnOHC.Image = ResizeImage(btnOHC.Image, btnOHC.Size)
        btnSide.Image = ResizeImage(btnSide.Image, btnSide.Size)
    End Sub

    Private Sub ddlFinsih_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddlFinish.SelectedIndexChanged
        If ddlFinish.SelectedIndex = 0 Then
            ddlColor.Visible = True
            txtColor.Visible = False
            ddlColor.SelectedIndex = 0
        ElseIf ddlFinish.SelectedIndex >= 1 Then
            ddlColor.Visible = False
            txtColor.Visible = True
        End If
    End Sub

    Private Sub ddlColor_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddlColor.SelectedIndexChanged
        tabApplication.Enabled = True
        lblColor.Tag = ddlColor.SelectedItem.Text
    End Sub

    Private Sub txtColor_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtColor.TextChanged
        If Not String.IsNullOrEmpty(txtColor.Text) Then
            tabApplication.Enabled = True
            lblColor.Tag = ddlColor.SelectedItem.Text
        End If
    End Sub

    ' Populate all the models for the selected options
    Private Sub PopModelList()
        ddlModel.Items.Clear()

        Try
            SQL = "Select m.model, m.model_id, case when m.mounting_bracket is null then 0 else 1 end as mount " &
             " from t_model m " &
             "  where m.status= 1  "

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
                lstitem.Value = RS("mount")
                ddlModel.Items.Add(lstitem)
            End While

            CloseRS(RS)
            ddlModel.SelectedIndex = 0
            ' dt.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, "PopModelList")
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
            MsgBox(ex.Message, "PopApplicaitons")
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
            MsgBox(ex.Message, "PopSwingers")
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
            MsgBox(ex.Message, "PopPivots")
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
            MsgBox(ex.Message, "DispPanic")
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
                txtLHDoorW.Value = (RS("door_opening") / 2)
                txtLHReveal.Value = txtLHReveal.Minimum
                txtRHReveal.Value = txtRHReveal.Minimum

                If txtRHDoorW.Visible = True Then
                    txtRHDoorW.Value = txtLHDoorW.Value
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, "PopDoorSpecs")
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
        txtRHDoorW.Visible = False
        ddlLHOp.Visible = False
        lblLHOpMan.Visible = False
        lblRHOpMan.Visible = False
        txtRHDoorW.Visible = False
        lblRHDoorWidth.Visible = False
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

        Select Case ddlapplication.SelectedItem.Text
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
            GetHeaderLengthRet += Conversions.ToDouble(txtOverlap.Value * 2)
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
                PopSwingOptions(ddlSwing1, 0)
                PopSwingOptions(ddlSwing2, 1)
            Else
                PopSwingOptions(ddlSwing1, 2)
                lblSwing2.Visible = False
                ddlSwing2.Visible = False
                pctSwingTwo.Visible = False
                lblSwing1.Text = "Swing:"
            End If
        End If

        If ShowSpecsTab() = True Then
            tabDimensions.Enabled = True
            tabAccessories.Enabled = True
            tabReview.Enabled = True
        Else
            tabDimensions.Enabled = False
            tabAccessories.Enabled = False
            tabReview.Enabled = False
        End If
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
            MsgBox(ex.Message, "GetCompleteImage")
        Finally
            CloseRS(RS)
        End Try

        GetCompelteImageRet = GetCompelteImageRet.Substring(0, GetCompelteImageRet.Length - 1)
        Return GetCompelteImageRet
    End Function

    Private Sub ddlSwing1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddlSwing1.SelectedIndexChanged



        If ddlSwing1.SelectedIndex > 0 Then
            pctSwingOne.Image = imlSwings.Images(ddlSwing1.SelectedItem.Tag)
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

        If ShowSpecsTab() = True Then
            tabDimensions.Enabled = True
            tabAccessories.Enabled = True
            tabReview.Enabled = True
        Else
            tabDimensions.Enabled = False
            tabAccessories.Enabled = False
            tabReview.Enabled = False
        End If
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

        If ShowSpecsTab() = True Then
            tabDimensions.Enabled = True
            tabAccessories.Enabled = True
            tabReview.Enabled = True
        Else
            tabDimensions.Enabled = False
            tabAccessories.Enabled = False
            tabReview.Enabled = False
        End If
    End Sub

    Private Sub tabparenttab_TabIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tabparenttab.TabIndexChanged
        If tabparenttab.SelectedTab Is tabDimensions Then
            If ShowSpecsTab() = True Then
                If ddlSwing2.Visible = True Then
                    pctSpecsComplete.Image = ResizeImage(My.Resources.ResourceManager.GetObject(GetCompelteImage), pctSpecsComplete.Size)
                Else
                    pctSpecsComplete.Image = ResizeImage(pctSwingOne.Image, pctSpecsComplete.Size)
                End If
            End If
            GetDoorSpecs()
            tabAccessories.Enabled = True
            tabReview.Enabled = True

        End If
        If tabparenttab.SelectedTab Is tabAccessories Then
            If ddlModel.SelectedItem Is Nothing Then Exit Sub
            If ddlModel.SelectedItem.Value = 1 Then
                ddlMountingBracket.Visible = True
                lblMountingBracket.Visible = True
            Else
                ddlMountingBracket.Visible = False
                lblMountingBracket.Visible = False
            End If
        End If
        If tabparenttab.SelectedTab Is tabReview Then
            txtOrderReivew.Text = PopOrderReview()
        End If
    End Sub

    'This will Populate the order review 
    Private Function PopOrderReview() As String
        Dim NL As String
        NL = "*" & System.Environment.NewLine

        PopOrderReview = "Model: " & ddlModel.SelectedItem.Text
        PopOrderReview &= NL
        If ddlSwing2.Visible = True Then
            PopOrderReview &= "Left Side Panel - " & ddlSwing1.SelectedItem.Text
            PopOrderReview &= "    Right Side Panel - " & ddlSwing2.SelectedItem.Text
        Else
            PopOrderReview &= "Panel - " & ddlSwing1.SelectedItem.Text
        End If
        PopOrderReview &= NL
        PopOrderReview &= "Header Length: " & txtHeaderLength.Value
        PopOrderReview &= NL
        If txtRHDoorW.Visible = True Then
            PopOrderReview &= "Left Side Door Opening: " & txtLHDoorW.Value
            PopOrderReview &= "Right Side Door Opening: " & txtRHDoorW.Value
        Else
            PopOrderReview &= "Door Opening: " & txtLHDoorW.Value
        End If
        PopOrderReview &= NL & "Finish: " & lblColor.Tag

        '  PopOrderReview &= "Finish: " & IIf(ddlFinsih.Visible = True, ddlFinsih.SelectedItem.Text, txtColor.Text)
        PopOrderReview &= NL
        PopOrderReview &= ddlPivot.SelectedItem.Text & NL
        PopOrderReview &= "Overlap: " & txtOverlap.Value & NL
        PopOrderReview &= "Reveal: " & txtLHReveal.Value & "*"
        Return PopOrderReview
    End Function



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

        If ShowSpecsTab() = True Then
            tabDimensions.Enabled = True
            tabAccessories.Enabled = True
            tabReview.Enabled = True
        Else
            tabDimensions.Enabled = False
            tabAccessories.Enabled = False
            tabReview.Enabled = False
        End If
    End Sub

    Private Sub txtLHDoorW_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtLHDoorW.ValueChanged
        If txtLHDoorW.Visible = False Then Exit Sub
        txtHeaderLength.Value = GetHeaderLength()
        If chkMatchW.Checked = True Then txtRHDoorW.Value = txtLHDoorW.Value
    End Sub

    Private Sub txtRHDoorW_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtRHDoorW.ValueChanged
        If txtRHDoorW.Visible = False Then Exit Sub
        txtHeaderLength.Value = GetHeaderLength()
        If chkMatchW.Checked = True Then txtLHDoorW.Value = txtRHDoorW.Value
    End Sub

    Private Sub txtOverlap_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtOverlap.ValueChanged
        If txtOverlap.Visible = False Then Return
        txtHeaderLength.Value = GetHeaderLength()
    End Sub

    Private Sub txtCenterJamb_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtCenterJamb.ValueChanged
        If txtCenterJamb.Visible = False Then Return
        Me.txtHeaderLength.Value = GetHeaderLength()
    End Sub

    Private Sub ddlModel_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddlModel.SelectedIndexChanged
        If ddlModel.SelectedIndex > 0 Then

        End If
    End Sub

    Private Sub chkMatchW_CheckStateChanged(sender As Object, e As EventArgs) Handles chkMatchW.CheckStateChanged
        If chkMatchW.CheckState = CheckState.Checked Then
            txtRHDoorW.Value = txtLHDoorW.Value
        End If
    End Sub

    Private Sub btnSubmitOrder_Click(sender As Object, e As EventArgs)
        Dim xlApp As Object = CreateObject("Excel.Application")
        Dim excelApp As Excel.Application = xlApp

        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        Try

            SQL = "Select fert, baseprice from t_fert where Model = '" & ddlModel.SelectedItem.Text & "' and " &
                 " application = '" & ddlapplication.SelectedItem.Text & "' and  " &
                 " finish = '" & ddlFinish.SelectedItem.Text & "'"
            SetRS(RS)
            If RS.Read Then
                btnSubmitOrder.Tag = Trim("" & RS("fert"))
            End If

            Dim sfile As String = Application.StartupPath & "\SwingBom.xlsm"

            'put data to TextBox
            xlWorkBook = excelApp.Workbooks.Open(sfile)
            xlWorkSheet = xlWorkBook.Worksheets("Inputs")
            xlWorkSheet.Range("SalesOrderNumber").Value = "232704" 'Need to know where these are created
            xlWorkSheet.Range("ItemNumber").Value = "10" ''Need to know where these are created 
            xlWorkSheet.Range("FertNumber").Value = btnSubmitOrder.Tag
            xlWorkSheet.Range("QuantityOfUnits").Value = txtQuant.Value
            xlWorkSheet.Range("UnitIdentification").Value = txtUnit.Text
            xlWorkSheet.Range("JobName").Value = "Wood Country FG"
            xlWorkSheet.Range("Model").Value = ddlModel.SelectedItem.Text

            xlWorkSheet.Range("LHPanel").Value = ddlSwing1.SelectedItem.Text
            xlWorkSheet.Range("RHPanel").Value = IIf(ddlSwing2.Visible = False, "None", ddlSwing2.SelectedItem.Text)
            xlWorkSheet.Range("Panic").Value = IIf(chkPanic.Checked, "True", "False")
            xlWorkSheet.Range("Finish").Value = ddlFinish.SelectedItem.Text
            xlWorkSheet.Range("LHDoorOpening").Value = txtLHDoorW.Value
            xlWorkSheet.Range("RHDoorOpening").Value = txtRHDoorW.Value
            xlWorkSheet.Range("LHOverlap").Value = txtOverlap.Value

            xlWorkSheet.Range("RHOverlap").Value = txtOverlap.Value
            xlWorkSheet.Range("CenterDivider").Value = txtCenterJamb.Value
            xlWorkSheet.Range("HeaderLength").Value = txtHeaderLength.Value
            xlWorkSheet.Range("Pivot").Value = ddlPivot.SelectedItem.Text
            xlWorkSheet.Range("LHReveal").Value = txtLHReveal.Value
            xlWorkSheet.Range("RHReveal").Value = txtRHReveal.Value
            xlWorkSheet.Range("MtgBracket").Value = IIf(ddlMountingBracket.Visible = False, "None", ddlMountingBracket.SelectedItem.Text)
            xlWorkSheet.Range("EntryDate").Value = Today.Date.ToString
            excelApp.Run("QuickRun") 'runs the bom macro
            Dim filepath As String = Application.StartupPath & "\OrderInfo\" & "JobName-OrderNum.xlsm" 'need to modify this once i figure out where we get this ifo
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

    Private Sub chkConfig_CheckedChanged(sender As Object, e As EventArgs) Handles chkConfig.CheckedChanged
        If chkConfig.CheckState = CheckState.Checked Then
            btnSubmitOrder.Enabled = True
        Else
            btnSubmitOrder.Enabled = False
        End If
    End Sub

    Private Declare Auto Function GetWindowThreadProcessId Lib "user32.dll" (ByVal hwnd As IntPtr,
            ByRef lpdwProcessId As Integer) As Integer

    Private Sub tabModel_Paint(sender As Object, e As PaintEventArgs) Handles tabModel.Paint

    End Sub
End Class
