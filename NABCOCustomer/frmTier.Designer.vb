<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTier
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTier))
        Me.tabControl = New Telerik.WinControls.UI.RadPageView()
        Me.tabTier = New Telerik.WinControls.UI.RadPageViewPage()
        Me.pnlTier = New System.Windows.Forms.Panel()
        Me.grdTier = New Telerik.WinControls.UI.RadGridView()
        Me.tabEdit = New Telerik.WinControls.UI.RadPageViewPage()
        Me.pnlEdit = New System.Windows.Forms.Panel()
        Me.txtTierLevel = New System.Windows.Forms.TextBox()
        Me.txtMultiplier = New System.Windows.Forms.TextBox()
        Me.lblTier = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.errorprov = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDelete = New Telerik.WinControls.UI.RadButton()
        Me.btnAdd = New Telerik.WinControls.UI.RadButton()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.btnEdit = New Telerik.WinControls.UI.RadButton()
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl.SuspendLayout()
        Me.tabTier.SuspendLayout()
        Me.pnlTier.SuspendLayout()
        CType(Me.grdTier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTier.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEdit.SuspendLayout()
        Me.pnlEdit.SuspendLayout()
        CType(Me.errorprov, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btnEdit.SuspendLayout()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabControl
        '
        Me.tabControl.AllowShowFocusCues = True
        Me.tabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabControl.Controls.Add(Me.tabTier)
        Me.tabControl.Controls.Add(Me.tabEdit)
        Me.tabControl.DefaultPage = Me.tabTier
        Me.tabControl.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControl.Location = New System.Drawing.Point(0, 45)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedPage = Me.tabEdit
        Me.tabControl.Size = New System.Drawing.Size(803, 406)
        Me.tabControl.TabIndex = 4
        CType(Me.tabControl.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.None
        CType(Me.tabControl.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemFitMode = Telerik.WinControls.UI.StripViewItemFitMode.Fill
        '
        'tabTier
        '
        Me.tabTier.Controls.Add(Me.pnlTier)
        Me.tabTier.ItemSize = New System.Drawing.SizeF(384.0!, 43.0!)
        Me.tabTier.Location = New System.Drawing.Point(10, 52)
        Me.tabTier.Name = "tabTier"
        Me.tabTier.Size = New System.Drawing.Size(782, 343)
        Me.tabTier.Text = "Tiers"
        Me.tabTier.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.tabTier.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'pnlTier
        '
        Me.pnlTier.Controls.Add(Me.grdTier)
        Me.pnlTier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTier.Location = New System.Drawing.Point(0, 0)
        Me.pnlTier.Name = "pnlTier"
        Me.pnlTier.Size = New System.Drawing.Size(782, 343)
        Me.pnlTier.TabIndex = 0
        '
        'grdTier
        '
        Me.grdTier.BackColor = System.Drawing.SystemColors.Control
        Me.grdTier.Cursor = System.Windows.Forms.Cursors.Default
        Me.grdTier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTier.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdTier.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdTier.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.grdTier.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.grdTier.MasterTemplate.AllowAddNewRow = False
        Me.grdTier.MasterTemplate.AllowCellContextMenu = False
        Me.grdTier.MasterTemplate.AllowColumnChooser = False
        Me.grdTier.MasterTemplate.AllowColumnHeaderContextMenu = False
        Me.grdTier.MasterTemplate.AllowColumnReorder = False
        Me.grdTier.MasterTemplate.AllowDeleteRow = False
        Me.grdTier.MasterTemplate.AllowDragToGroup = False
        Me.grdTier.MasterTemplate.AllowEditRow = False
        Me.grdTier.MasterTemplate.AllowRowHeaderContextMenu = False
        Me.grdTier.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.HeaderText = "tier_id"
        GridViewTextBoxColumn1.IsVisible = False
        GridViewTextBoxColumn1.Name = "tier_id"
        GridViewTextBoxColumn1.Width = 55
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.HeaderText = "Tier level"
        GridViewTextBoxColumn2.Name = "tier_level"
        GridViewTextBoxColumn2.Width = 270
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.HeaderText = "Multiplier"
        GridViewTextBoxColumn3.Name = "multiplier"
        GridViewTextBoxColumn3.Width = 288
        GridViewTextBoxColumn4.HeaderText = "Last Edit By"
        GridViewTextBoxColumn4.Name = "fullname"
        GridViewTextBoxColumn4.Width = 205
        Me.grdTier.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4})
        Me.grdTier.MasterTemplate.EnableGrouping = False
        Me.grdTier.MasterTemplate.EnableSorting = False
        Me.grdTier.MasterTemplate.SearchRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom
        Me.grdTier.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.grdTier.Name = "grdTier"
        Me.grdTier.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.grdTier.ReadOnly = True
        Me.grdTier.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grdTier.Size = New System.Drawing.Size(782, 343)
        Me.grdTier.TabIndex = 4
        Me.grdTier.ThemeName = "Crystal"
        '
        'tabEdit
        '
        Me.tabEdit.Controls.Add(Me.pnlEdit)
        Me.tabEdit.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabEdit.ItemSize = New System.Drawing.SizeF(405.0!, 43.0!)
        Me.tabEdit.Location = New System.Drawing.Point(10, 52)
        Me.tabEdit.Name = "tabEdit"
        Me.tabEdit.Size = New System.Drawing.Size(782, 343)
        Me.tabEdit.Text = "Details"
        Me.tabEdit.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlEdit
        '
        Me.pnlEdit.Controls.Add(Me.txtTierLevel)
        Me.pnlEdit.Controls.Add(Me.txtMultiplier)
        Me.pnlEdit.Controls.Add(Me.lblTier)
        Me.pnlEdit.Controls.Add(Me.Label2)
        Me.pnlEdit.Controls.Add(Me.Label1)
        Me.pnlEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEdit.Location = New System.Drawing.Point(0, 0)
        Me.pnlEdit.Name = "pnlEdit"
        Me.pnlEdit.Size = New System.Drawing.Size(782, 343)
        Me.pnlEdit.TabIndex = 0
        '
        'txtTierLevel
        '
        Me.txtTierLevel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txtTierLevel.Location = New System.Drawing.Point(161, 12)
        Me.txtTierLevel.Name = "txtTierLevel"
        Me.txtTierLevel.Size = New System.Drawing.Size(150, 35)
        Me.txtTierLevel.TabIndex = 4
        Me.txtTierLevel.Visible = False
        '
        'txtMultiplier
        '
        Me.txtMultiplier.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txtMultiplier.Location = New System.Drawing.Point(161, 60)
        Me.txtMultiplier.Name = "txtMultiplier"
        Me.txtMultiplier.Size = New System.Drawing.Size(150, 35)
        Me.txtMultiplier.TabIndex = 3
        '
        'lblTier
        '
        Me.lblTier.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lblTier.Location = New System.Drawing.Point(161, 15)
        Me.lblTier.Name = "lblTier"
        Me.lblTier.Size = New System.Drawing.Size(150, 25)
        Me.lblTier.TabIndex = 2
        Me.lblTier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(5, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Multiplier:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(5, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tier Level:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'errorprov
        '
        Me.errorprov.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(803, 42)
        Me.Panel1.TabIndex = 13
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.NabcoCustomer.My.Resources.Resources.bin
        Me.btnDelete.Location = New System.Drawing.Point(243, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(112, 32)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        CType(Me.btnDelete.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.NabcoCustomer.My.Resources.Resources.bin
        CType(Me.btnDelete.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        CType(Me.btnDelete.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Delete"
        CType(Me.btnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.None
        CType(Me.btnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).CustomFontSize = 15.0!
        CType(Me.btnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Padding = New System.Windows.Forms.Padding(10, 1, 1, 1)
        CType(Me.btnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ClipDrawing = False
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = Global.NabcoCustomer.My.Resources.Resources.add
        Me.btnAdd.Location = New System.Drawing.Point(5, 5)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(112, 32)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        CType(Me.btnAdd.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.NabcoCustomer.My.Resources.Resources.add
        CType(Me.btnAdd.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        CType(Me.btnAdd.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Add"
        CType(Me.btnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.None
        CType(Me.btnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).CustomFontSize = 15.0!
        CType(Me.btnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Padding = New System.Windows.Forms.Padding(10, 1, 1, 1)
        CType(Me.btnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ClipDrawing = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnSave.Image = Global.NabcoCustomer.My.Resources.Resources._04_Save_24x24
        Me.btnSave.Location = New System.Drawing.Point(8, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(110, 32)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Visible = False
        CType(Me.btnSave.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.NabcoCustomer.My.Resources.Resources._04_Save_24x24
        CType(Me.btnSave.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        CType(Me.btnSave.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Save"
        CType(Me.btnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.None
        CType(Me.btnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).CustomFontSize = 15.0!
        CType(Me.btnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Padding = New System.Windows.Forms.Padding(10, 1, 1, 1)
        CType(Me.btnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ClipDrawing = False
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Controls.Add(Me.btnCancel)
        Me.btnEdit.Enabled = False
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(125, 5)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(112, 32)
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        CType(Me.btnEdit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        CType(Me.btnEdit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        CType(Me.btnEdit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Edit"
        CType(Me.btnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.None
        CType(Me.btnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).CustomFontSize = 15.0!
        CType(Me.btnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Padding = New System.Windows.Forms.Padding(10, 1, 1, 1)
        CType(Me.btnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ClipDrawing = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(0, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 32)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.Visible = False
        CType(Me.btnCancel.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        CType(Me.btnCancel.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        CType(Me.btnCancel.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Cancel"
        CType(Me.btnCancel.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.None
        CType(Me.btnCancel.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).CustomFontSize = 15.0!
        CType(Me.btnCancel.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Padding = New System.Windows.Forms.Padding(10, 1, 1, 1)
        CType(Me.btnCancel.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ClipDrawing = False
        '
        'frmTier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(804, 452)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tabControl)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTier"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Discount Adjustment"
        Me.ThemeName = "Crystal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl.ResumeLayout(False)
        Me.tabTier.ResumeLayout(False)
        Me.pnlTier.ResumeLayout(False)
        CType(Me.grdTier.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEdit.ResumeLayout(False)
        Me.pnlEdit.ResumeLayout(False)
        Me.pnlEdit.PerformLayout()
        CType(Me.errorprov, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btnEdit.ResumeLayout(False)
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabControl As Telerik.WinControls.UI.RadPageView
    Friend WithEvents tabTier As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents tabEdit As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents pnlTier As Panel
    Friend WithEvents grdTier As Telerik.WinControls.UI.RadGridView
    Friend WithEvents pnlEdit As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTier As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMultiplier As TextBox
    Friend WithEvents txtTierLevel As TextBox
    Friend WithEvents errorprov As ErrorProvider
    Friend WithEvents btnDelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnEdit As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents Panel1 As Panel
End Class
