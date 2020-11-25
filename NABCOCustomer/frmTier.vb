Imports Telerik.WinControls.UI

Public Class frmTier

    Private addedit As Boolean 'true = edit // false = add

    Private Sub frmTier_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Stop the handling of the current row changed event
        RemoveHandler grdTier.CurrentRowChanged, AddressOf grdTier_CurrentRowChanged
        PopgvTiers()
        AddHandler grdTier.CurrentRowChanged, AddressOf grdTier_CurrentRowChanged
        tabEdit.Enabled = False

    End Sub

    'populate the grid as well a make sure it is all formatted as it should be
    Private Sub PopgvTiers()
        Try
            SQL = "Select t.*, u.user_fname + ' ' + u.user_lname as fullname from  " &
            "t_tier as t  left join t_user as u on u.user_id = t.user_id"
            SetRS(RS)
            While RS.Read()
                Dim rowinfo As GridViewRowInfo = grdTier.Rows.AddNew
                rowinfo.Cells("tier_id").Value = Trim("" & RS("tier_id"))
                rowinfo.Cells("tier_level").Value = Trim("" & RS("tier_level"))
                rowinfo.Cells("multiplier").Value = Trim("" & RS("multiplier"))
                rowinfo.Cells("fullname").Value = Trim("" & RS("fullname"))
            End While
            CloseRS(RS)

            grdTier.AllowAddNewRow = False
            grdTier.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            ' dt.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, , "PopgrdTiers")
        End Try
        grdTier.CurrentRow = Nothing
    End Sub

    'Performs checks when they change the gridrow
    Private Sub grdTier_CurrentRowChanged(sender As Object, e As CurrentRowChangedEventArgs)
        If e.CurrentRow.IsCurrent = Nothing Then Exit Sub
        btnEdit.Enabled = True
        lblTier.Text = Trim("" & e.CurrentRow.Cells("tier_level").Value)
        txtMultiplier.Text = Trim("" & e.CurrentRow.Cells("multiplier").Value)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        addedit = True
        AddEditOn()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        addedit = False
        AddEditOn()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        addedit = Nothing
        Editmodeoff()
        tabControl.SelectedPage = tabTier
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If addedit = True Then 'editing 
            If IsNumeric(txtMultiplier.Text) And txtMultiplier.Text <> "" Then
                errorprov.SetError(txtMultiplier, "Invalid Multiplier")
                errorprov.Tag = 2
            End If
        ElseIf addedit = False Then 'adding 
            If IsNumeric(txtTierLevel.Text) And txtTierLevel.Text <> "" Then
                errorprov.SetError(txtTierLevel, "Invalid Tier")
                errorprov.Tag = 1
            End If
            If IsNumeric(txtMultiplier.Text) And txtMultiplier.Text <> "" Then
                errorprov.SetError(txtMultiplier, "Invalid Multiplier")
                errorprov.Tag = 2

            End If
        End If


        Try
            If addedit = True Then 'editing
                SQL = "Update t_tier " &
                "set multiplier = " & txtMultiplier.Text &
                " user_id = " & My.Settings.User_ID &
                " where tier_id =  " & grdTier.CurrentRow.Cells("tier_id").Value
                Execute()
                grdTier.CurrentRow.Cells("multiplier").Value = Trim("" & txtMultiplier.Text)
                Editmodeoff()
            Else 'adding 
                SQL = "Insert into t_tier (tier_level, multiplier, user_id) values " &
                "(" & txtTierLevel.Text & ", " &
                txtMultiplier.Text & "," &
                My.Settings.User_ID & ")"
                Dim tempid As Integer
                tempid = Execute()
                Dim rowinfo As GridViewRowInfo = grdTier.Rows.AddNew
                rowinfo.Cells("tier_id").Value = tempid
                rowinfo.Cells("tier_level").Value = txtTierLevel.Text
                rowinfo.Cells("multiplier").Value = txtMultiplier.Text
                rowinfo.Cells("fullname").Value = My.Settings.User_Full
            End If
        Catch ex As Exception
            MsgBox(ex.Message,, "Saving Error")
        End Try
    End Sub

    Private Sub Editmodeoff()
        btnAdd.Visible = True
        btnDelete.Visible = True
        btnEdit.Visible = True
        btnSave.Visible = False
        btnCancel.Visible = False
        tabTier.Enabled = True
        tabControl.SelectedPage = tabTier
    End Sub

    Private Sub AddEditOn()
        tabControl.SelectedPage = tabEdit
        btnAdd.Visible = False
        btnDelete.Visible = False
        btnEdit.Visible = False
        btnSave.Visible = True
        btnCancel.Visible = True
        tabTier.Enabled = False
        tabEdit.Enabled = True
        pnlEdit.Enabled = True
        If addedit = True Then
            txtMultiplier.Focus()
            lblTier.Visible = True
            txtTierLevel.Visible = False
        ElseIf addedit = False Then
            txtTierLevel.Visible = True
            lblTier.Visible = False
        End If
    End Sub

    Private Sub SaveChanges()
        Try
            If addedit = True Then 'update
                SQL = "Update tier " &
                    "set multiplier = " & txtMultiplier.Text &
                    " where rowid =  " & grdTier.CurrentRow.Cells("rowid").Value
                Execute()
                grdTier.CurrentRow.Cells("multiplier").Value = Trim("" & txtMultiplier.Text)
            ElseIf addedit = False Then 'adding 
                SQL = "Insert into tier (rowid, multiplier, tierlevel) " &
                    "values (" &
                    "'10'" & "'"
            End If
        Catch ex As Exception
            MsgBox(ex.Message,, IIf(addedit = True, "Saving Error", "Updating Error"))
        End Try

    End Sub

    Private Sub txtMultiplier_GotFocus(sender As Object, e As EventArgs) Handles txtMultiplier.GotFocus
        If errorprov.Tag = 2 Then
            errorprov.Clear()
        End If
    End Sub

    Private Sub txtTierLevel_GotFocus(sender As Object, e As EventArgs) Handles txtTierLevel.GotFocus
        If errorprov.Tag = 1 Then
            errorprov.Clear()
        End If
    End Sub
End Class
