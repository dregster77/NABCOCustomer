<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrderInfo
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
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.pvOrderInfo = New Telerik.WinControls.UI.RadPageView()
        Me.pvpOrderDetails = New Telerik.WinControls.UI.RadPageViewPage()
        Me.pvpQuoteDetails = New Telerik.WinControls.UI.RadPageViewPage()
        Me.pvpDocuments = New Telerik.WinControls.UI.RadPageViewPage()
        Me.pvpProducts = New Telerik.WinControls.UI.RadPageViewPage()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.ddlSalesOffice = New Telerik.WinControls.UI.RadDropDownList()
        CType(Me.pvOrderInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pvOrderInfo.SuspendLayout()
        Me.pvpOrderDetails.SuspendLayout()
        CType(Me.ddlSalesOffice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pvOrderInfo
        '
        Me.pvOrderInfo.Controls.Add(Me.pvpOrderDetails)
        Me.pvOrderInfo.Controls.Add(Me.pvpQuoteDetails)
        Me.pvOrderInfo.Controls.Add(Me.pvpDocuments)
        Me.pvOrderInfo.Controls.Add(Me.pvpProducts)
        Me.pvOrderInfo.DefaultPage = Me.pvpOrderDetails
        Me.pvOrderInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pvOrderInfo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pvOrderInfo.Location = New System.Drawing.Point(0, 0)
        Me.pvOrderInfo.Name = "pvOrderInfo"
        Me.pvOrderInfo.SelectedPage = Me.pvpOrderDetails
        Me.pvOrderInfo.Size = New System.Drawing.Size(1058, 671)
        Me.pvOrderInfo.TabIndex = 0
        Me.pvOrderInfo.ViewMode = Telerik.WinControls.UI.PageViewMode.NavigationView
        CType(Me.pvOrderInfo.GetChildAt(0), Telerik.WinControls.UI.RadPageViewNavigationViewElement).DisplayMode = Telerik.WinControls.UI.NavigationViewDisplayModes.Expanded
        '
        'pvpOrderDetails
        '
        Me.pvpOrderDetails.Controls.Add(Me.lblModel)
        Me.pvpOrderDetails.Controls.Add(Me.ddlSalesOffice)
        Me.pvpOrderDetails.Image = Global.Nabco_Sales.My.Resources.Resources.lorry
        Me.pvpOrderDetails.ItemSize = New System.Drawing.SizeF(46.0!, 46.0!)
        Me.pvpOrderDetails.Location = New System.Drawing.Point(47, 30)
        Me.pvpOrderDetails.Name = "pvpOrderDetails"
        Me.pvpOrderDetails.Size = New System.Drawing.Size(1010, 640)
        Me.pvpOrderDetails.Text = "Sales and Shipping Details"
        Me.pvpOrderDetails.ToolTipText = "Add Sales Office and Shipping Information"
        '
        'pvpQuoteDetails
        '
        Me.pvpQuoteDetails.Image = Global.Nabco_Sales.My.Resources.Resources.script
        Me.pvpQuoteDetails.ItemSize = New System.Drawing.SizeF(46.0!, 46.0!)
        Me.pvpQuoteDetails.Location = New System.Drawing.Point(47, 30)
        Me.pvpQuoteDetails.Name = "pvpQuoteDetails"
        Me.pvpQuoteDetails.Size = New System.Drawing.Size(1010, 640)
        Me.pvpQuoteDetails.Text = "Quote Details"
        Me.pvpQuoteDetails.ToolTipText = "Quote Details"
        '
        'pvpDocuments
        '
        Me.pvpDocuments.Image = Global.Nabco_Sales.My.Resources.Resources.inbox_upload
        Me.pvpDocuments.ItemSize = New System.Drawing.SizeF(46.0!, 46.0!)
        Me.pvpDocuments.Location = New System.Drawing.Point(47, 30)
        Me.pvpDocuments.Name = "pvpDocuments"
        Me.pvpDocuments.Size = New System.Drawing.Size(1010, 640)
        Me.pvpDocuments.Text = "Upload Documents"
        Me.pvpDocuments.ToolTipText = "Upload PO an Supporting Documents"
        '
        'pvpProducts
        '
        Me.pvpProducts.Image = Global.Nabco_Sales.My.Resources.Resources.tag_blue_add
        Me.pvpProducts.ItemSize = New System.Drawing.SizeF(46.0!, 46.0!)
        Me.pvpProducts.Location = New System.Drawing.Point(47, 30)
        Me.pvpProducts.Name = "pvpProducts"
        Me.pvpProducts.Size = New System.Drawing.Size(1010, 640)
        Me.pvpProducts.Text = "Products"
        Me.pvpProducts.ToolTipText = "Add Products to Order"
        '
        'lblModel
        '
        Me.lblModel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.Location = New System.Drawing.Point(5, 10)
        Me.lblModel.Margin = New System.Windows.Forms.Padding(5, 10, 5, 0)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(115, 27)
        Me.lblModel.TabIndex = 16
        Me.lblModel.Text = "Sales Office:"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ddlSalesOffice
        '
        Me.ddlSalesOffice.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        RadListDataItem1.Text = "R000"
        RadListDataItem2.Text = "R001"
        RadListDataItem3.Text = "R002"
        RadListDataItem4.Text = "R004"
        RadListDataItem5.Text = "R005"
        Me.ddlSalesOffice.Items.Add(RadListDataItem1)
        Me.ddlSalesOffice.Items.Add(RadListDataItem2)
        Me.ddlSalesOffice.Items.Add(RadListDataItem3)
        Me.ddlSalesOffice.Items.Add(RadListDataItem4)
        Me.ddlSalesOffice.Items.Add(RadListDataItem5)
        Me.ddlSalesOffice.Location = New System.Drawing.Point(130, 10)
        Me.ddlSalesOffice.Margin = New System.Windows.Forms.Padding(5, 10, 5, 0)
        Me.ddlSalesOffice.Name = "ddlSalesOffice"
        Me.ddlSalesOffice.Size = New System.Drawing.Size(216, 27)
        Me.ddlSalesOffice.TabIndex = 15
        '
        'frmOrderInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 671)
        Me.Controls.Add(Me.pvOrderInfo)
        Me.Name = "frmOrderInfo"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "frmOrderInfo"
        CType(Me.pvOrderInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pvOrderInfo.ResumeLayout(False)
        Me.pvpOrderDetails.ResumeLayout(False)
        Me.pvpOrderDetails.PerformLayout()
        CType(Me.ddlSalesOffice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pvOrderInfo As Telerik.WinControls.UI.RadPageView
    Friend WithEvents pvpOrderDetails As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents pvpQuoteDetails As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents pvpDocuments As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents pvpProducts As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents lblModel As Label
    Friend WithEvents ddlSalesOffice As Telerik.WinControls.UI.RadDropDownList
End Class

