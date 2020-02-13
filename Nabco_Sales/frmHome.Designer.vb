<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
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
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdmin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTier = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCustomerTier = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUserSet = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlHomebtns = New System.Windows.Forms.Panel()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.btnSwingDoor = New Telerik.WinControls.UI.RadButton()
        Me.stsMain = New Telerik.WinControls.UI.RadStatusStrip()
        Me.lblStatusMain = New Telerik.WinControls.UI.RadLabelElement()
        Me.pnlMain = New Telerik.WinControls.UI.Docking.RadDock()
        Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
        Me.btnLogout = New Telerik.WinControls.UI.RadButton()
        Me.mnuStrip.SuspendLayout()
        Me.pnlHomebtns.SuspendLayout()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSwingDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stsMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuStrip
        '
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.mnuAdmin, Me.mnuUserSet})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(1116, 24)
        Me.mnuStrip.TabIndex = 3
        Me.mnuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.ExitToolStripMenuItem.Text = "Exit "
        '
        'mnuAdmin
        '
        Me.mnuAdmin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuUser, Me.mnuTier, Me.mnuCustomerTier})
        Me.mnuAdmin.Name = "mnuAdmin"
        Me.mnuAdmin.Size = New System.Drawing.Size(92, 20)
        Me.mnuAdmin.Text = "Administrator"
        Me.mnuAdmin.Visible = False
        '
        'mnuUser
        '
        Me.mnuUser.Name = "mnuUser"
        Me.mnuUser.Size = New System.Drawing.Size(148, 22)
        Me.mnuUser.Text = "Users"
        '
        'mnuTier
        '
        Me.mnuTier.Name = "mnuTier"
        Me.mnuTier.Size = New System.Drawing.Size(148, 22)
        Me.mnuTier.Text = "Tier"
        '
        'mnuCustomerTier
        '
        Me.mnuCustomerTier.Name = "mnuCustomerTier"
        Me.mnuCustomerTier.Size = New System.Drawing.Size(148, 22)
        Me.mnuCustomerTier.Text = "Customer Tier"
        '
        'mnuUserSet
        '
        Me.mnuUserSet.Name = "mnuUserSet"
        Me.mnuUserSet.Size = New System.Drawing.Size(87, 20)
        Me.mnuUserSet.Text = "User Settings"
        Me.mnuUserSet.Visible = False
        '
        'pnlHomebtns
        '
        Me.pnlHomebtns.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlHomebtns.Controls.Add(Me.RadButton2)
        Me.pnlHomebtns.Controls.Add(Me.btnLogout)
        Me.pnlHomebtns.Controls.Add(Me.btnSwingDoor)
        Me.pnlHomebtns.Enabled = False
        Me.pnlHomebtns.Location = New System.Drawing.Point(0, 24)
        Me.pnlHomebtns.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlHomebtns.Name = "pnlHomebtns"
        Me.pnlHomebtns.Size = New System.Drawing.Size(1116, 70)
        Me.pnlHomebtns.TabIndex = 4
        '
        'RadButton2
        '
        Me.RadButton2.Location = New System.Drawing.Point(79, 5)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(70, 60)
        Me.RadButton2.TabIndex = 1
        Me.RadButton2.Text = "RadButton2"
        '
        'btnSwingDoor
        '
        Me.btnSwingDoor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSwingDoor.Location = New System.Drawing.Point(3, 5)
        Me.btnSwingDoor.Name = "btnSwingDoor"
        Me.btnSwingDoor.Size = New System.Drawing.Size(70, 60)
        Me.btnSwingDoor.TabIndex = 0
        Me.btnSwingDoor.Text = "Swing Door"
        Me.btnSwingDoor.TextWrap = True
        '
        'stsMain
        '
        Me.stsMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.stsMain.Dock = System.Windows.Forms.DockStyle.None
        Me.stsMain.Items.AddRange(New Telerik.WinControls.RadItem() {Me.lblStatusMain})
        Me.stsMain.Location = New System.Drawing.Point(0, 618)
        Me.stsMain.Name = "stsMain"
        Me.stsMain.Size = New System.Drawing.Size(1116, 26)
        Me.stsMain.SizingGrip = False
        Me.stsMain.TabIndex = 6
        '
        'lblStatusMain
        '
        Me.lblStatusMain.Name = "lblStatusMain"
        Me.stsMain.SetSpring(Me.lblStatusMain, False)
        Me.lblStatusMain.Text = "No User Currently Loged In"
        Me.lblStatusMain.TextWrap = True
        '
        'pnlMain
        '
        Me.pnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMain.AutoDetectMdiChildren = True
        Me.pnlMain.BackgroundImage = Global.Nabco_Sales.My.Resources.Resources.NabcoLogo
        Me.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlMain.Controls.Add(Me.DocumentContainer1)
        Me.pnlMain.IsCleanUpTarget = True
        Me.pnlMain.Location = New System.Drawing.Point(0, 94)
        Me.pnlMain.MainDocumentContainer = Me.DocumentContainer1
        Me.pnlMain.Name = "pnlMain"
        '
        '
        '
        Me.pnlMain.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.pnlMain.Size = New System.Drawing.Size(1116, 521)
        Me.pnlMain.TabIndex = 5
        Me.pnlMain.TabStop = False
        '
        'DocumentContainer1
        '
        Me.DocumentContainer1.Name = "DocumentContainer1"
        '
        '
        '
        Me.DocumentContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Image = Global.Nabco_Sales.My.Resources.Resources.door_out
        Me.btnLogout.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.btnLogout.Location = New System.Drawing.Point(1041, 5)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(5)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(70, 60)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        CType(Me.btnLogout.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.Nabco_Sales.My.Resources.Resources.door_out
        CType(Me.btnLogout.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.TopCenter
        CType(Me.btnLogout.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        CType(Me.btnLogout.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Logout"
        CType(Me.btnLogout.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 644)
        Me.Controls.Add(Me.stsMain)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlHomebtns)
        Me.Controls.Add(Me.mnuStrip)
        Me.Name = "frmHome"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "RadForm1"
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.pnlHomebtns.ResumeLayout(False)
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSwingDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stsMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLogout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAdmin As ToolStripMenuItem
    Friend WithEvents mnuUser As ToolStripMenuItem
    Friend WithEvents mnuTier As ToolStripMenuItem
    Friend WithEvents mnuCustomerTier As ToolStripMenuItem
    Friend WithEvents mnuUserSet As ToolStripMenuItem
    Friend WithEvents pnlHomebtns As Panel
    Friend WithEvents pnlMain As Telerik.WinControls.UI.Docking.RadDock
    Friend WithEvents DocumentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnLogout As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSwingDoor As Telerik.WinControls.UI.RadButton
    Friend WithEvents stsMain As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents lblStatusMain As Telerik.WinControls.UI.RadLabelElement
End Class

