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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewCommandColumn1 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrderInfo))
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.pvOrderInfo = New Telerik.WinControls.UI.RadPageView()
        Me.pvpOrderDetails = New Telerik.WinControls.UI.RadPageViewPage()
        Me.lblCallingbtn = New System.Windows.Forms.Label()
        Me.gvCustomer = New Telerik.WinControls.UI.RadGridView()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.btnClearShip = New Telerik.WinControls.UI.RadButton()
        Me.txtCustNoShipTP = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.txtZipShipTP = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.txtCityShipTP = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.txtCountryShipTP = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.txtRegionShipTP = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.txtAddr1ShipTP = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.txtCustShipTP = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnShipTP = New Telerik.WinControls.UI.RadButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ddlDistChannelShipTP = New Telerik.WinControls.UI.RadDropDownList()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkMatchShip = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.btnClearSold = New Telerik.WinControls.UI.RadButton()
        Me.txtCustNoSoldTP = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.txtZipSoldTP = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.txtCitySoldTP = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.txtCountrySoldTP = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.txtRegionSoldTP = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.txtAddr1SoldTP = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.txtCustSoldTP = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSoldTP = New Telerik.WinControls.UI.RadButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ddlDistChannelSoldTP = New Telerik.WinControls.UI.RadDropDownList()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.ddlSalesOffice = New Telerik.WinControls.UI.RadDropDownList()
        Me.pvpQuoteDetails = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadTextBoxControl8 = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadTextBoxControl1 = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadTextBoxControl3 = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadTextBoxControl4 = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadTextBoxControl5 = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadTextBoxControl6 = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadTextBoxControl7 = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.pvpDocuments = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadButton3 = New Telerik.WinControls.UI.RadButton()
        Me.btnAdd = New Telerik.WinControls.UI.RadButton()
        Me.RadGridView2 = New Telerik.WinControls.UI.RadGridView()
        Me.pvpProducts = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadPageView1 = New Telerik.WinControls.UI.RadPageView()
        Me.RadPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadDropDownButton1 = New Telerik.WinControls.UI.RadDropDownButton()
        Me.mnuSlider = New Telerik.WinControls.UI.RadMenuItem()
        Me.mnuSwinger = New Telerik.WinControls.UI.RadMenuItem()
        Me.btnDelete = New Telerik.WinControls.UI.RadButton()
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnEdit = New Telerik.WinControls.UI.RadButton()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.RadDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
        CType(Me.pvOrderInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pvOrderInfo.SuspendLayout()
        Me.pvpOrderDetails.SuspendLayout()
        CType(Me.gvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCustomer.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.btnClearShip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustNoShipTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtZipShipTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCityShipTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCountryShipTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRegionShipTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddr1ShipTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustShipTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnShipTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlDistChannelShipTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMatchShip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.btnClearSold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustNoSoldTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtZipSoldTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCitySoldTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCountrySoldTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRegionSoldTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddr1SoldTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustSoldTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSoldTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlDistChannelSoldTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlSalesOffice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pvpQuoteDetails.SuspendLayout()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.RadTextBoxControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBoxControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBoxControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBoxControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBoxControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBoxControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pvpDocuments.SuspendLayout()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView2.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pvpProducts.SuspendLayout()
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageView1.SuspendLayout()
        Me.RadPageViewPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.RadDropDownButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pvOrderInfo.Size = New System.Drawing.Size(1121, 779)
        Me.pvOrderInfo.TabIndex = 0
        Me.pvOrderInfo.ViewMode = Telerik.WinControls.UI.PageViewMode.NavigationView
        CType(Me.pvOrderInfo.GetChildAt(0), Telerik.WinControls.UI.RadPageViewNavigationViewElement).DisplayMode = Telerik.WinControls.UI.NavigationViewDisplayModes.Expanded
        '
        'pvpOrderDetails
        '
        Me.pvpOrderDetails.Controls.Add(Me.lblCallingbtn)
        Me.pvpOrderDetails.Controls.Add(Me.gvCustomer)
        Me.pvpOrderDetails.Controls.Add(Me.RadGroupBox2)
        Me.pvpOrderDetails.Controls.Add(Me.Label1)
        Me.pvpOrderDetails.Controls.Add(Me.chkMatchShip)
        Me.pvpOrderDetails.Controls.Add(Me.RadGroupBox1)
        Me.pvpOrderDetails.Controls.Add(Me.lblModel)
        Me.pvpOrderDetails.Controls.Add(Me.ddlSalesOffice)
        Me.pvpOrderDetails.Image = Global.Nabco_Sales.My.Resources.Resources.lorry
        Me.pvpOrderDetails.ItemSize = New System.Drawing.SizeF(46.0!, 46.0!)
        Me.pvpOrderDetails.Location = New System.Drawing.Point(47, 30)
        Me.pvpOrderDetails.Name = "pvpOrderDetails"
        Me.pvpOrderDetails.Size = New System.Drawing.Size(1073, 748)
        Me.pvpOrderDetails.Text = "Sales and Shipping Details"
        Me.pvpOrderDetails.ToolTipText = "Add Sales Office and Shipping Information"
        '
        'lblCallingbtn
        '
        Me.lblCallingbtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCallingbtn.Location = New System.Drawing.Point(9, 560)
        Me.lblCallingbtn.Margin = New System.Windows.Forms.Padding(5, 10, 5, 0)
        Me.lblCallingbtn.Name = "lblCallingbtn"
        Me.lblCallingbtn.Size = New System.Drawing.Size(150, 30)
        Me.lblCallingbtn.TabIndex = 23
        Me.lblCallingbtn.Text = "Match for Ship To:"
        Me.lblCallingbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCallingbtn.Visible = False
        '
        'gvCustomer
        '
        Me.gvCustomer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvCustomer.Location = New System.Drawing.Point(9, 605)
        '
        '
        '
        Me.gvCustomer.MasterTemplate.AllowAddNewRow = False
        Me.gvCustomer.MasterTemplate.AllowDeleteRow = False
        Me.gvCustomer.MasterTemplate.AllowDragToGroup = False
        Me.gvCustomer.MasterTemplate.AllowEditRow = False
        Me.gvCustomer.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvCustomer.Name = "gvCustomer"
        Me.gvCustomer.ReadOnly = True
        Me.gvCustomer.ShowGroupPanel = False
        Me.gvCustomer.Size = New System.Drawing.Size(1053, 355)
        Me.gvCustomer.TabIndex = 22
        Me.gvCustomer.Visible = False
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox2.Controls.Add(Me.btnClearShip)
        Me.RadGroupBox2.Controls.Add(Me.txtCustNoShipTP)
        Me.RadGroupBox2.Controls.Add(Me.txtZipShipTP)
        Me.RadGroupBox2.Controls.Add(Me.txtCityShipTP)
        Me.RadGroupBox2.Controls.Add(Me.txtCountryShipTP)
        Me.RadGroupBox2.Controls.Add(Me.txtRegionShipTP)
        Me.RadGroupBox2.Controls.Add(Me.txtAddr1ShipTP)
        Me.RadGroupBox2.Controls.Add(Me.txtCustShipTP)
        Me.RadGroupBox2.Controls.Add(Me.Label9)
        Me.RadGroupBox2.Controls.Add(Me.Label10)
        Me.RadGroupBox2.Controls.Add(Me.Label11)
        Me.RadGroupBox2.Controls.Add(Me.Label12)
        Me.RadGroupBox2.Controls.Add(Me.btnShipTP)
        Me.RadGroupBox2.Controls.Add(Me.Label13)
        Me.RadGroupBox2.Controls.Add(Me.Label14)
        Me.RadGroupBox2.Controls.Add(Me.ddlDistChannelShipTP)
        Me.RadGroupBox2.Controls.Add(Me.Label15)
        Me.RadGroupBox2.Controls.Add(Me.Label16)
        Me.RadGroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBox2.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        Me.RadGroupBox2.HeaderText = "Ship To Party Info"
        Me.RadGroupBox2.Location = New System.Drawing.Point(9, 316)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(1053, 231)
        Me.RadGroupBox2.TabIndex = 21
        Me.RadGroupBox2.Text = "Ship To Party Info"
        '
        'btnClearShip
        '
        Me.btnClearShip.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearShip.Image = Global.Nabco_Sales.My.Resources.Resources.arrow_refresh
        Me.btnClearShip.Location = New System.Drawing.Point(715, 138)
        Me.btnClearShip.Name = "btnClearShip"
        Me.btnClearShip.Size = New System.Drawing.Size(112, 64)
        Me.btnClearShip.TabIndex = 44
        Me.btnClearShip.Text = "Clear"
        '
        'txtCustNoShipTP
        '
        Me.txtCustNoShipTP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCustNoShipTP.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtCustNoShipTP.Location = New System.Drawing.Point(158, 30)
        Me.txtCustNoShipTP.Name = "txtCustNoShipTP"
        Me.txtCustNoShipTP.Size = New System.Drawing.Size(154, 30)
        Me.txtCustNoShipTP.TabIndex = 11
        '
        'txtZipShipTP
        '
        Me.txtZipShipTP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtZipShipTP.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtZipShipTP.Location = New System.Drawing.Point(535, 173)
        Me.txtZipShipTP.Name = "txtZipShipTP"
        Me.txtZipShipTP.Size = New System.Drawing.Size(150, 30)
        Me.txtZipShipTP.TabIndex = 18
        '
        'txtCityShipTP
        '
        Me.txtCityShipTP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCityShipTP.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtCityShipTP.Location = New System.Drawing.Point(158, 138)
        Me.txtCityShipTP.Name = "txtCityShipTP"
        Me.txtCityShipTP.Size = New System.Drawing.Size(250, 30)
        Me.txtCityShipTP.TabIndex = 15
        '
        'txtCountryShipTP
        '
        Me.txtCountryShipTP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCountryShipTP.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtCountryShipTP.Location = New System.Drawing.Point(158, 173)
        Me.txtCountryShipTP.Name = "txtCountryShipTP"
        Me.txtCountryShipTP.Size = New System.Drawing.Size(250, 30)
        Me.txtCountryShipTP.TabIndex = 17
        '
        'txtRegionShipTP
        '
        Me.txtRegionShipTP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtRegionShipTP.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtRegionShipTP.Location = New System.Drawing.Point(535, 138)
        Me.txtRegionShipTP.Name = "txtRegionShipTP"
        Me.txtRegionShipTP.Size = New System.Drawing.Size(150, 30)
        Me.txtRegionShipTP.TabIndex = 16
        '
        'txtAddr1ShipTP
        '
        Me.txtAddr1ShipTP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtAddr1ShipTP.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtAddr1ShipTP.Location = New System.Drawing.Point(158, 102)
        Me.txtAddr1ShipTP.Name = "txtAddr1ShipTP"
        Me.txtAddr1ShipTP.Size = New System.Drawing.Size(528, 30)
        Me.txtAddr1ShipTP.TabIndex = 14
        '
        'txtCustShipTP
        '
        Me.txtCustShipTP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCustShipTP.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtCustShipTP.Location = New System.Drawing.Point(158, 66)
        Me.txtCustShipTP.Name = "txtCustShipTP"
        Me.txtCustShipTP.Size = New System.Drawing.Size(528, 30)
        Me.txtCustShipTP.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(406, 173)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 30)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Postal Code:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(80, 170)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 30)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Country:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(406, 138)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 30)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Region:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 135)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(143, 30)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "City:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnShipTP
        '
        Me.btnShipTP.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShipTP.Image = Global.Nabco_Sales.My.Resources.Resources.google_custom_search
        Me.btnShipTP.Location = New System.Drawing.Point(715, 30)
        Me.btnShipTP.Name = "btnShipTP"
        Me.btnShipTP.Size = New System.Drawing.Size(112, 64)
        Me.btnShipTP.TabIndex = 18
        Me.btnShipTP.Text = "Search"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 100)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(143, 30)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Address:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(7, 65)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(143, 30)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Name:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ddlDistChannelShipTP
        '
        Me.ddlDistChannelShipTP.AutoSize = False
        Me.ddlDistChannelShipTP.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlDistChannelShipTP.Location = New System.Drawing.Point(449, 30)
        Me.ddlDistChannelShipTP.Name = "ddlDistChannelShipTP"
        Me.ddlDistChannelShipTP.ReadOnly = True
        Me.ddlDistChannelShipTP.Size = New System.Drawing.Size(237, 30)
        Me.ddlDistChannelShipTP.TabIndex = 12
        Me.ddlDistChannelShipTP.Text = "RadDropDownList1"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(320, 30)
        Me.Label15.Margin = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(121, 30)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Dist Channel:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(7, 30)
        Me.Label16.Margin = New System.Windows.Forms.Padding(5, 30, 5, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(143, 30)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Customer Number:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 280)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 10, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 30)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Match for Ship To:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkMatchShip
        '
        Me.chkMatchShip.AutoSize = False
        Me.chkMatchShip.Location = New System.Drawing.Point(167, 280)
        Me.chkMatchShip.Name = "chkMatchShip"
        Me.chkMatchShip.Size = New System.Drawing.Size(33, 30)
        Me.chkMatchShip.TabIndex = 10
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox1.Controls.Add(Me.RadDropDownList1)
        Me.RadGroupBox1.Controls.Add(Me.btnClearSold)
        Me.RadGroupBox1.Controls.Add(Me.txtCustNoSoldTP)
        Me.RadGroupBox1.Controls.Add(Me.txtZipSoldTP)
        Me.RadGroupBox1.Controls.Add(Me.txtCitySoldTP)
        Me.RadGroupBox1.Controls.Add(Me.txtCountrySoldTP)
        Me.RadGroupBox1.Controls.Add(Me.txtRegionSoldTP)
        Me.RadGroupBox1.Controls.Add(Me.txtAddr1SoldTP)
        Me.RadGroupBox1.Controls.Add(Me.txtCustSoldTP)
        Me.RadGroupBox1.Controls.Add(Me.Label8)
        Me.RadGroupBox1.Controls.Add(Me.Label7)
        Me.RadGroupBox1.Controls.Add(Me.Label6)
        Me.RadGroupBox1.Controls.Add(Me.Label5)
        Me.RadGroupBox1.Controls.Add(Me.btnSoldTP)
        Me.RadGroupBox1.Controls.Add(Me.Label4)
        Me.RadGroupBox1.Controls.Add(Me.Label3)
        Me.RadGroupBox1.Controls.Add(Me.ddlDistChannelSoldTP)
        Me.RadGroupBox1.Controls.Add(Me.Label2)
        Me.RadGroupBox1.Controls.Add(Me.Label22)
        Me.RadGroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        Me.RadGroupBox1.HeaderText = "Sold To Party Info"
        Me.RadGroupBox1.Location = New System.Drawing.Point(9, 43)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(1053, 231)
        Me.RadGroupBox1.TabIndex = 17
        Me.RadGroupBox1.Text = "Sold To Party Info"
        '
        'btnClearSold
        '
        Me.btnClearSold.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearSold.Image = Global.Nabco_Sales.My.Resources.Resources.arrow_refresh
        Me.btnClearSold.Location = New System.Drawing.Point(715, 138)
        Me.btnClearSold.Name = "btnClearSold"
        Me.btnClearSold.Size = New System.Drawing.Size(112, 64)
        Me.btnClearSold.TabIndex = 43
        Me.btnClearSold.Text = "Clear"
        '
        'txtCustNoSoldTP
        '
        Me.txtCustNoSoldTP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCustNoSoldTP.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtCustNoSoldTP.Location = New System.Drawing.Point(158, 30)
        Me.txtCustNoSoldTP.Name = "txtCustNoSoldTP"
        Me.txtCustNoSoldTP.Size = New System.Drawing.Size(154, 30)
        Me.txtCustNoSoldTP.TabIndex = 2
        '
        'txtZipSoldTP
        '
        Me.txtZipSoldTP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtZipSoldTP.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtZipSoldTP.Location = New System.Drawing.Point(535, 172)
        Me.txtZipSoldTP.Name = "txtZipSoldTP"
        Me.txtZipSoldTP.Size = New System.Drawing.Size(150, 30)
        Me.txtZipSoldTP.TabIndex = 9
        '
        'txtCitySoldTP
        '
        Me.txtCitySoldTP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCitySoldTP.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtCitySoldTP.Location = New System.Drawing.Point(158, 138)
        Me.txtCitySoldTP.Name = "txtCitySoldTP"
        Me.txtCitySoldTP.Size = New System.Drawing.Size(250, 30)
        Me.txtCitySoldTP.TabIndex = 6
        '
        'txtCountrySoldTP
        '
        Me.txtCountrySoldTP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCountrySoldTP.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtCountrySoldTP.Location = New System.Drawing.Point(158, 173)
        Me.txtCountrySoldTP.Name = "txtCountrySoldTP"
        Me.txtCountrySoldTP.Size = New System.Drawing.Size(250, 30)
        Me.txtCountrySoldTP.TabIndex = 8
        '
        'txtRegionSoldTP
        '
        Me.txtRegionSoldTP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtRegionSoldTP.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtRegionSoldTP.Location = New System.Drawing.Point(535, 138)
        Me.txtRegionSoldTP.Name = "txtRegionSoldTP"
        Me.txtRegionSoldTP.Size = New System.Drawing.Size(150, 30)
        Me.txtRegionSoldTP.TabIndex = 7
        '
        'txtAddr1SoldTP
        '
        Me.txtAddr1SoldTP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtAddr1SoldTP.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtAddr1SoldTP.Location = New System.Drawing.Point(158, 102)
        Me.txtAddr1SoldTP.Name = "txtAddr1SoldTP"
        Me.txtAddr1SoldTP.Size = New System.Drawing.Size(528, 30)
        Me.txtAddr1SoldTP.TabIndex = 5
        '
        'txtCustSoldTP
        '
        Me.txtCustSoldTP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCustSoldTP.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtCustSoldTP.Location = New System.Drawing.Point(158, 66)
        Me.txtCustSoldTP.Name = "txtCustSoldTP"
        Me.txtCustSoldTP.Size = New System.Drawing.Size(528, 30)
        Me.txtCustSoldTP.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(406, 173)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 30)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Postal Code:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(80, 170)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 30)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Country:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(406, 138)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 30)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Region:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 135)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 30)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "City:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSoldTP
        '
        Me.btnSoldTP.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSoldTP.Image = Global.Nabco_Sales.My.Resources.Resources.google_custom_search
        Me.btnSoldTP.Location = New System.Drawing.Point(715, 30)
        Me.btnSoldTP.Name = "btnSoldTP"
        Me.btnSoldTP.Size = New System.Drawing.Size(112, 64)
        Me.btnSoldTP.TabIndex = 18
        Me.btnSoldTP.Text = "Search"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 100)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 30)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Address:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 65)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 30)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ddlDistChannelSoldTP
        '
        Me.ddlDistChannelSoldTP.AutoSize = False
        Me.ddlDistChannelSoldTP.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlDistChannelSoldTP.Location = New System.Drawing.Point(449, 30)
        Me.ddlDistChannelSoldTP.Name = "ddlDistChannelSoldTP"
        Me.ddlDistChannelSoldTP.ReadOnly = True
        Me.ddlDistChannelSoldTP.Size = New System.Drawing.Size(237, 30)
        Me.ddlDistChannelSoldTP.TabIndex = 3
        Me.ddlDistChannelSoldTP.Text = "RadDropDownList1"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(320, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 30)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Dist Channel:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(7, 30)
        Me.Label22.Margin = New System.Windows.Forms.Padding(5, 30, 5, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(143, 30)
        Me.Label22.TabIndex = 17
        Me.Label22.Text = "Customer Number:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblModel
        '
        Me.lblModel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.Location = New System.Drawing.Point(9, 10)
        Me.lblModel.Margin = New System.Windows.Forms.Padding(5, 10, 5, 0)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(150, 30)
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
        Me.ddlSalesOffice.Location = New System.Drawing.Point(167, 10)
        Me.ddlSalesOffice.Margin = New System.Windows.Forms.Padding(5, 10, 5, 0)
        Me.ddlSalesOffice.Name = "ddlSalesOffice"
        Me.ddlSalesOffice.Size = New System.Drawing.Size(250, 27)
        Me.ddlSalesOffice.TabIndex = 1
        '
        'pvpQuoteDetails
        '
        Me.pvpQuoteDetails.Controls.Add(Me.RadGroupBox3)
        Me.pvpQuoteDetails.Image = Global.Nabco_Sales.My.Resources.Resources.script
        Me.pvpQuoteDetails.ItemSize = New System.Drawing.SizeF(46.0!, 46.0!)
        Me.pvpQuoteDetails.Location = New System.Drawing.Point(47, 30)
        Me.pvpQuoteDetails.Name = "pvpQuoteDetails"
        Me.pvpQuoteDetails.Size = New System.Drawing.Size(1065, 718)
        Me.pvpQuoteDetails.Text = "Quote Details"
        Me.pvpQuoteDetails.ToolTipText = "Quote Details"
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox3.Controls.Add(Me.RadTextBoxControl8)
        Me.RadGroupBox3.Controls.Add(Me.RadButton1)
        Me.RadGroupBox3.Controls.Add(Me.RadTextBoxControl1)
        Me.RadGroupBox3.Controls.Add(Me.RadTextBoxControl3)
        Me.RadGroupBox3.Controls.Add(Me.RadTextBoxControl4)
        Me.RadGroupBox3.Controls.Add(Me.RadTextBoxControl5)
        Me.RadGroupBox3.Controls.Add(Me.RadTextBoxControl6)
        Me.RadGroupBox3.Controls.Add(Me.RadTextBoxControl7)
        Me.RadGroupBox3.Controls.Add(Me.Label18)
        Me.RadGroupBox3.Controls.Add(Me.Label19)
        Me.RadGroupBox3.Controls.Add(Me.Label20)
        Me.RadGroupBox3.Controls.Add(Me.RadButton2)
        Me.RadGroupBox3.Controls.Add(Me.Label21)
        Me.RadGroupBox3.Controls.Add(Me.Label23)
        Me.RadGroupBox3.Controls.Add(Me.Label24)
        Me.RadGroupBox3.Controls.Add(Me.Label25)
        Me.RadGroupBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBox3.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        Me.RadGroupBox3.HeaderText = ""
        Me.RadGroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        Me.RadGroupBox3.Size = New System.Drawing.Size(1045, 586)
        Me.RadGroupBox3.TabIndex = 18
        '
        'RadTextBoxControl8
        '
        Me.RadTextBoxControl8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.RadTextBoxControl8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBoxControl8.Location = New System.Drawing.Point(158, 221)
        Me.RadTextBoxControl8.Name = "RadTextBoxControl8"
        Me.RadTextBoxControl8.Size = New System.Drawing.Size(300, 30)
        Me.RadTextBoxControl8.TabIndex = 44
        '
        'RadButton1
        '
        Me.RadButton1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadButton1.Image = Global.Nabco_Sales.My.Resources.Resources.arrow_refresh
        Me.RadButton1.Location = New System.Drawing.Point(715, 114)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(112, 64)
        Me.RadButton1.TabIndex = 43
        Me.RadButton1.Text = "Clear"
        '
        'RadTextBoxControl1
        '
        Me.RadTextBoxControl1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.RadTextBoxControl1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBoxControl1.Location = New System.Drawing.Point(158, 6)
        Me.RadTextBoxControl1.Name = "RadTextBoxControl1"
        Me.RadTextBoxControl1.Size = New System.Drawing.Size(300, 30)
        Me.RadTextBoxControl1.TabIndex = 2
        '
        'RadTextBoxControl3
        '
        Me.RadTextBoxControl3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.RadTextBoxControl3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBoxControl3.Location = New System.Drawing.Point(158, 114)
        Me.RadTextBoxControl3.Name = "RadTextBoxControl3"
        Me.RadTextBoxControl3.Size = New System.Drawing.Size(300, 30)
        Me.RadTextBoxControl3.TabIndex = 6
        '
        'RadTextBoxControl4
        '
        Me.RadTextBoxControl4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.RadTextBoxControl4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBoxControl4.Location = New System.Drawing.Point(158, 149)
        Me.RadTextBoxControl4.Name = "RadTextBoxControl4"
        Me.RadTextBoxControl4.Size = New System.Drawing.Size(300, 30)
        Me.RadTextBoxControl4.TabIndex = 8
        '
        'RadTextBoxControl5
        '
        Me.RadTextBoxControl5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.RadTextBoxControl5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBoxControl5.Location = New System.Drawing.Point(158, 185)
        Me.RadTextBoxControl5.Name = "RadTextBoxControl5"
        Me.RadTextBoxControl5.Size = New System.Drawing.Size(300, 30)
        Me.RadTextBoxControl5.TabIndex = 7
        '
        'RadTextBoxControl6
        '
        Me.RadTextBoxControl6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.RadTextBoxControl6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBoxControl6.Location = New System.Drawing.Point(158, 78)
        Me.RadTextBoxControl6.Name = "RadTextBoxControl6"
        Me.RadTextBoxControl6.Size = New System.Drawing.Size(300, 30)
        Me.RadTextBoxControl6.TabIndex = 5
        '
        'RadTextBoxControl7
        '
        Me.RadTextBoxControl7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.RadTextBoxControl7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadTextBoxControl7.Location = New System.Drawing.Point(158, 42)
        Me.RadTextBoxControl7.Name = "RadTextBoxControl7"
        Me.RadTextBoxControl7.Size = New System.Drawing.Size(300, 30)
        Me.RadTextBoxControl7.TabIndex = 4
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(11, 151)
        Me.Label18.Margin = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(139, 30)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Job Name:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(15, 186)
        Me.Label19.Margin = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(135, 30)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "Shipping Method:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(7, 113)
        Me.Label20.Margin = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(143, 30)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "Customer PO:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadButton2
        '
        Me.RadButton2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadButton2.Image = Global.Nabco_Sales.My.Resources.Resources.google_custom_search
        Me.RadButton2.Location = New System.Drawing.Point(715, 6)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(112, 64)
        Me.RadButton2.TabIndex = 18
        Me.RadButton2.Text = "Search"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(7, 78)
        Me.Label21.Margin = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(143, 30)
        Me.Label21.TabIndex = 25
        Me.Label21.Text = "SAP Entry Date:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(7, 42)
        Me.Label23.Margin = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(143, 30)
        Me.Label23.TabIndex = 23
        Me.Label23.Text = "SAP Order #:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(11, 221)
        Me.Label24.Margin = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(139, 30)
        Me.Label24.TabIndex = 20
        Me.Label24.Text = "Customer Contact:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(7, 6)
        Me.Label25.Margin = New System.Windows.Forms.Padding(5, 30, 5, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(143, 30)
        Me.Label25.TabIndex = 17
        Me.Label25.Text = "Quote Number:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pvpDocuments
        '
        Me.pvpDocuments.Controls.Add(Me.RadButton3)
        Me.pvpDocuments.Controls.Add(Me.btnAdd)
        Me.pvpDocuments.Controls.Add(Me.RadGridView2)
        Me.pvpDocuments.Image = Global.Nabco_Sales.My.Resources.Resources.inbox_upload
        Me.pvpDocuments.ItemSize = New System.Drawing.SizeF(46.0!, 46.0!)
        Me.pvpDocuments.Location = New System.Drawing.Point(47, 30)
        Me.pvpDocuments.Name = "pvpDocuments"
        Me.pvpDocuments.Size = New System.Drawing.Size(1065, 718)
        Me.pvpDocuments.Text = "Upload Documents"
        Me.pvpDocuments.ToolTipText = "Upload PO an Supporting Documents"
        '
        'RadButton3
        '
        Me.RadButton3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadButton3.Enabled = False
        Me.RadButton3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadButton3.Image = Global.Nabco_Sales.My.Resources.Resources.bin
        Me.RadButton3.Location = New System.Drawing.Point(256, 5)
        Me.RadButton3.Name = "RadButton3"
        Me.RadButton3.Size = New System.Drawing.Size(112, 32)
        Me.RadButton3.TabIndex = 15
        Me.RadButton3.Text = "Delete"
        Me.RadButton3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        CType(Me.RadButton3.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.Nabco_Sales.My.Resources.Resources.bin
        CType(Me.RadButton3.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        CType(Me.RadButton3.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Delete"
        CType(Me.RadButton3.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.None
        CType(Me.RadButton3.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).CustomFontSize = 15.0!
        CType(Me.RadButton3.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Padding = New System.Windows.Forms.Padding(10, 1, 1, 1)
        CType(Me.RadButton3.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ClipDrawing = False
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = Global.Nabco_Sales.My.Resources.Resources.add
        Me.btnAdd.Location = New System.Drawing.Point(18, 5)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(112, 32)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        CType(Me.btnAdd.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.Nabco_Sales.My.Resources.Resources.add
        CType(Me.btnAdd.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        CType(Me.btnAdd.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Add"
        CType(Me.btnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.None
        CType(Me.btnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).CustomFontSize = 15.0!
        CType(Me.btnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Padding = New System.Windows.Forms.Padding(10, 1, 1, 1)
        CType(Me.btnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ClipDrawing = False
        '
        'RadGridView2
        '
        Me.RadGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGridView2.Location = New System.Drawing.Point(0, 45)
        '
        '
        '
        Me.RadGridView2.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewTextBoxColumn1.HeaderText = "Document Name "
        GridViewTextBoxColumn1.Name = "Part"
        GridViewTextBoxColumn1.Width = 857
        GridViewCommandColumn1.HeaderText = "View PDF"
        GridViewCommandColumn1.Name = "column1"
        GridViewCommandColumn1.Width = 177
        Me.RadGridView2.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewCommandColumn1})
        Me.RadGridView2.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.RadGridView2.Name = "RadGridView2"
        Me.RadGridView2.Size = New System.Drawing.Size(1054, 662)
        Me.RadGridView2.TabIndex = 1
        '
        'pvpProducts
        '
        Me.pvpProducts.Controls.Add(Me.RadPageView1)
        Me.pvpProducts.Image = Global.Nabco_Sales.My.Resources.Resources.tag_blue_add
        Me.pvpProducts.ItemSize = New System.Drawing.SizeF(46.0!, 46.0!)
        Me.pvpProducts.Location = New System.Drawing.Point(237, 30)
        Me.pvpProducts.Name = "pvpProducts"
        Me.pvpProducts.Size = New System.Drawing.Size(844, 730)
        Me.pvpProducts.Text = "Products"
        Me.pvpProducts.ToolTipText = "Add Products to Order"
        '
        'RadPageView1
        '
        Me.RadPageView1.Controls.Add(Me.RadPageViewPage1)
        Me.RadPageView1.Location = New System.Drawing.Point(3, 3)
        Me.RadPageView1.Name = "RadPageView1"
        Me.RadPageView1.SelectedPage = Me.RadPageViewPage1
        Me.RadPageView1.Size = New System.Drawing.Size(1012, 664)
        Me.RadPageView1.TabIndex = 0
        CType(Me.RadPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemFitMode = Telerik.WinControls.UI.StripViewItemFitMode.Fill
        CType(Me.RadPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ShowItemCloseButton = False
        '
        'RadPageViewPage1
        '
        Me.RadPageViewPage1.Controls.Add(Me.Panel1)
        Me.RadPageViewPage1.Controls.Add(Me.RadGridView1)
        Me.RadPageViewPage1.Location = New System.Drawing.Point(10, 37)
        Me.RadPageViewPage1.Name = "RadPageViewPage1"
        Me.RadPageViewPage1.Size = New System.Drawing.Size(991, 616)
        Me.RadPageViewPage1.Text = "Product Details"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadDropDownButton1)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Location = New System.Drawing.Point(3, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(988, 42)
        Me.Panel1.TabIndex = 14
        '
        'RadDropDownButton1
        '
        Me.RadDropDownButton1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownButton1.Image = Global.Nabco_Sales.My.Resources.Resources.add
        Me.RadDropDownButton1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.mnuSlider, Me.mnuSwinger})
        Me.RadDropDownButton1.Location = New System.Drawing.Point(13, 5)
        Me.RadDropDownButton1.Name = "RadDropDownButton1"
        Me.RadDropDownButton1.Size = New System.Drawing.Size(106, 32)
        Me.RadDropDownButton1.TabIndex = 14
        Me.RadDropDownButton1.Text = "Add"
        Me.RadDropDownButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'mnuSlider
        '
        Me.mnuSlider.Name = "mnuSlider"
        Me.mnuSlider.Text = "Slider"
        '
        'mnuSwinger
        '
        Me.mnuSwinger.Name = "mnuSwinger"
        Me.mnuSwinger.Text = "Swinger"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.Nabco_Sales.My.Resources.Resources.bin
        Me.btnDelete.Location = New System.Drawing.Point(243, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(112, 32)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        CType(Me.btnDelete.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.Nabco_Sales.My.Resources.Resources.bin
        CType(Me.btnDelete.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        CType(Me.btnDelete.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Delete"
        CType(Me.btnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.None
        CType(Me.btnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).CustomFontSize = 15.0!
        CType(Me.btnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Padding = New System.Windows.Forms.Padding(10, 1, 1, 1)
        CType(Me.btnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ClipDrawing = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(125, 5)
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
        'btnEdit
        '
        Me.btnEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        'RadGridView1
        '
        Me.RadGridView1.Location = New System.Drawing.Point(0, 124)
        '
        '
        '
        Me.RadGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewTextBoxColumn2.HeaderText = "Part "
        GridViewTextBoxColumn2.Name = "Part"
        GridViewTextBoxColumn2.Width = 243
        GridViewTextBoxColumn3.HeaderText = "Cost"
        GridViewTextBoxColumn3.Name = "Cost"
        GridViewTextBoxColumn3.Width = 243
        GridViewTextBoxColumn4.HeaderText = "Description"
        GridViewTextBoxColumn4.Name = "column3"
        GridViewTextBoxColumn4.Width = 243
        GridViewTextBoxColumn5.HeaderText = "Unit ID"
        GridViewTextBoxColumn5.Name = "column4"
        GridViewTextBoxColumn5.Width = 244
        Me.RadGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5})
        Me.RadGridView1.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.Size = New System.Drawing.Size(991, 489)
        Me.RadGridView1.TabIndex = 0
        '
        'RadDropDownList1
        '
        Me.RadDropDownList1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.RadDropDownList1.Location = New System.Drawing.Point(715, 102)
        Me.RadDropDownList1.Name = "RadDropDownList1"
        Me.RadDropDownList1.Size = New System.Drawing.Size(283, 20)
        Me.RadDropDownList1.TabIndex = 44
        Me.RadDropDownList1.Text = "RadDropDownList1"
        '
        'frmOrderInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 779)
        Me.Controls.Add(Me.pvOrderInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmOrderInfo"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Order"
        CType(Me.pvOrderInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pvOrderInfo.ResumeLayout(False)
        Me.pvpOrderDetails.ResumeLayout(False)
        Me.pvpOrderDetails.PerformLayout()
        CType(Me.gvCustomer.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        CType(Me.btnClearShip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustNoShipTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtZipShipTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCityShipTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCountryShipTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRegionShipTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddr1ShipTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustShipTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnShipTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlDistChannelShipTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMatchShip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.btnClearSold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustNoSoldTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtZipSoldTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCitySoldTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCountrySoldTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRegionSoldTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddr1SoldTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustSoldTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSoldTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlDistChannelSoldTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlSalesOffice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pvpQuoteDetails.ResumeLayout(False)
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        CType(Me.RadTextBoxControl8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBoxControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBoxControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBoxControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBoxControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBoxControl7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pvpDocuments.ResumeLayout(False)
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView2.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pvpProducts.ResumeLayout(False)
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageView1.ResumeLayout(False)
        Me.RadPageViewPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.RadDropDownButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RadPageView1 As Telerik.WinControls.UI.RadPageView
    Friend WithEvents RadPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadDropDownButton1 As Telerik.WinControls.UI.RadDropDownButton
    Friend WithEvents mnuSlider As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents mnuSwinger As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents btnDelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnEdit As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadGridView2 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents chkMatchShip As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSoldTP As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label22 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ddlDistChannelSoldTP As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCustSoldTP As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents txtZipShipTP As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents txtCityShipTP As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents txtCountryShipTP As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents txtRegionShipTP As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents txtAddr1ShipTP As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents txtCustShipTP As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnShipTP As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents ddlDistChannelShipTP As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtZipSoldTP As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents txtCitySoldTP As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents txtCountrySoldTP As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents txtRegionSoldTP As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents txtAddr1SoldTP As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents txtCustNoShipTP As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents txtCustNoSoldTP As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents gvCustomer As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnClearShip As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnClearSold As Telerik.WinControls.UI.RadButton
    Friend WithEvents lblCallingbtn As Label
    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadTextBoxControl1 As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadTextBoxControl3 As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadTextBoxControl4 As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadTextBoxControl5 As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadTextBoxControl6 As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadTextBoxControl7 As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label21 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents RadTextBoxControl8 As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadButton3 As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadDropDownList1 As Telerik.WinControls.UI.RadDropDownList
End Class

