<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQuoteLookup
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
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuoteLookup))
        Me.gvQuoteLookup = New Telerik.WinControls.UI.RadGridView()
        Me.btnEditOrder = New Telerik.WinControls.UI.RadButton()
        CType(Me.gvQuoteLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvQuoteLookup.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEditOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvQuoteLookup
        '
        Me.gvQuoteLookup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvQuoteLookup.Location = New System.Drawing.Point(12, 12)
        '
        '
        '
        Me.gvQuoteLookup.MasterTemplate.AllowAddNewRow = False
        Me.gvQuoteLookup.MasterTemplate.AllowDeleteRow = False
        Me.gvQuoteLookup.MasterTemplate.AllowDragToGroup = False
        Me.gvQuoteLookup.MasterTemplate.AllowEditRow = False
        Me.gvQuoteLookup.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewTextBoxColumn1.HeaderText = "Quote Number"
        GridViewTextBoxColumn1.Name = "quote_num"
        GridViewTextBoxColumn1.Width = 163
        GridViewTextBoxColumn2.HeaderText = "Customer PO"
        GridViewTextBoxColumn2.Name = "customer_po"
        GridViewTextBoxColumn2.Width = 163
        GridViewTextBoxColumn3.HeaderText = "Job Name"
        GridViewTextBoxColumn3.Name = "job_name"
        GridViewTextBoxColumn3.Width = 163
        GridViewTextBoxColumn4.HeaderText = "Shipping Method"
        GridViewTextBoxColumn4.Name = "shipping_method"
        GridViewTextBoxColumn4.Width = 163
        GridViewTextBoxColumn5.HeaderText = "Customer Contact"
        GridViewTextBoxColumn5.Name = "cust_contact"
        GridViewTextBoxColumn5.Width = 162
        Me.gvQuoteLookup.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5})
        Me.gvQuoteLookup.MasterTemplate.EnableFiltering = True
        Me.gvQuoteLookup.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvQuoteLookup.Name = "gvQuoteLookup"
        Me.gvQuoteLookup.ReadOnly = True
        Me.gvQuoteLookup.ShowGroupPanel = False
        Me.gvQuoteLookup.Size = New System.Drawing.Size(831, 355)
        Me.gvQuoteLookup.TabIndex = 23
        '
        'btnEditOrder
        '
        Me.btnEditOrder.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEditOrder.Image = Global.NabcoCustomer.My.Resources.Resources.application_form_edit
        Me.btnEditOrder.Location = New System.Drawing.Point(740, 381)
        Me.btnEditOrder.Name = "btnEditOrder"
        Me.btnEditOrder.Size = New System.Drawing.Size(103, 47)
        Me.btnEditOrder.TabIndex = 25
        Me.btnEditOrder.Text = "Edit Order"
        Me.btnEditOrder.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditOrder.TextWrap = True
        '
        'frmQuoteLookup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 440)
        Me.Controls.Add(Me.btnEditOrder)
        Me.Controls.Add(Me.gvQuoteLookup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQuoteLookup"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = ""
        CType(Me.gvQuoteLookup.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvQuoteLookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEditOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gvQuoteLookup As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnEditOrder As Telerik.WinControls.UI.RadButton
End Class

