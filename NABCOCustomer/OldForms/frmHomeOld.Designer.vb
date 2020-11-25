<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHomeOld
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHomeOld))
        Me.btnLogout = New Telerik.WinControls.UI.RadButton()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.dskAlert = New Telerik.WinControls.UI.RadDesktopAlert(Me.components)
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdmin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTier = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCustomerTier = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUserSet = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.object_a0a0e0a6_8166_4f2b_92c7_33185d4c8605 = New Telerik.WinControls.RootRadElement()
        Me.pnlHomebtns = New System.Windows.Forms.Panel()
        Me.pnlMDI = New System.Windows.Forms.Panel()
        Me.stsMain = New Telerik.WinControls.UI.RadStatusStrip()
        CType(Me.btnLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuStrip.SuspendLayout()
        Me.pnlHomebtns.SuspendLayout()
        CType(Me.stsMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Image = Global.NabcoCustomer.My.Resources.Resources.door_out
        Me.btnLogout.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.btnLogout.Location = New System.Drawing.Point(802, 5)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(5)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(70, 60)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        CType(Me.btnLogout.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.NabcoCustomer.My.Resources.Resources.door_out
        CType(Me.btnLogout.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.TopCenter
        CType(Me.btnLogout.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        CType(Me.btnLogout.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Logout"
        CType(Me.btnLogout.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        '
        'RadButton2
        '
        Me.RadButton2.Location = New System.Drawing.Point(79, 5)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(70, 60)
        Me.RadButton2.TabIndex = 1
        Me.RadButton2.Text = "RadButton2"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(3, 5)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(70, 60)
        Me.RadButton1.TabIndex = 0
        Me.RadButton1.Text = "RadButton1"
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
        'mnuStrip
        '
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.mnuAdmin, Me.mnuUserSet})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(877, 24)
        Me.mnuStrip.TabIndex = 2
        Me.mnuStrip.Text = "MenuStrip1"
        '
        'object_a0a0e0a6_8166_4f2b_92c7_33185d4c8605
        '
        Me.object_a0a0e0a6_8166_4f2b_92c7_33185d4c8605.Name = "object_a0a0e0a6_8166_4f2b_92c7_33185d4c8605"
        Me.object_a0a0e0a6_8166_4f2b_92c7_33185d4c8605.StretchHorizontally = True
        Me.object_a0a0e0a6_8166_4f2b_92c7_33185d4c8605.StretchVertically = True
        '
        'pnlHomebtns
        '
        Me.pnlHomebtns.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlHomebtns.Controls.Add(Me.RadButton2)
        Me.pnlHomebtns.Controls.Add(Me.btnLogout)
        Me.pnlHomebtns.Controls.Add(Me.RadButton1)
        Me.pnlHomebtns.Enabled = False
        Me.pnlHomebtns.Location = New System.Drawing.Point(0, 24)
        Me.pnlHomebtns.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlHomebtns.Name = "pnlHomebtns"
        Me.pnlHomebtns.Size = New System.Drawing.Size(877, 70)
        Me.pnlHomebtns.TabIndex = 3
        '
        'pnlMDI
        '
        Me.pnlMDI.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMDI.BackgroundImage = Global.NabcoCustomer.My.Resources.Resources.NabcoLogo
        Me.pnlMDI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlMDI.Location = New System.Drawing.Point(0, 94)
        Me.pnlMDI.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlMDI.Name = "pnlMDI"
        Me.pnlMDI.Size = New System.Drawing.Size(877, 428)
        Me.pnlMDI.TabIndex = 4
        '
        'stsMain
        '
        Me.stsMain.Location = New System.Drawing.Point(0, 518)
        Me.stsMain.Name = "stsMain"
        Me.stsMain.Size = New System.Drawing.Size(877, 26)
        Me.stsMain.SizingGrip = False
        Me.stsMain.TabIndex = 5
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 544)
        Me.Controls.Add(Me.stsMain)
        Me.Controls.Add(Me.pnlMDI)
        Me.Controls.Add(Me.pnlHomebtns)
        Me.Controls.Add(Me.mnuStrip)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuStrip
        Me.Name = "frmHome"
        Me.Text = "Form1"
        CType(Me.btnLogout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.pnlHomebtns.ResumeLayout(False)
        CType(Me.stsMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents dskAlert As Telerik.WinControls.UI.RadDesktopAlert
    Friend WithEvents btnLogout As Telerik.WinControls.UI.RadButton
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAdmin As ToolStripMenuItem
    Friend WithEvents mnuUser As ToolStripMenuItem
    Friend WithEvents mnuUserSet As ToolStripMenuItem
    Friend WithEvents mnuStrip As MenuStrip
    Friend WithEvents object_a0a0e0a6_8166_4f2b_92c7_33185d4c8605 As Telerik.WinControls.RootRadElement
    Friend WithEvents mnuTier As ToolStripMenuItem
    Friend WithEvents mnuCustomerTier As ToolStripMenuItem
    Friend WithEvents pnlHomebtns As Panel
    Friend WithEvents pnlMDI As Panel
    Friend WithEvents stsMain As Telerik.WinControls.UI.RadStatusStrip
End Class
