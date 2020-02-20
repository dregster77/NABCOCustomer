<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomers
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
        Me.gvCustomer = New Telerik.WinControls.UI.RadGridView()
        CType(Me.gvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCustomer.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvCustomer
        '
        Me.gvCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvCustomer.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.gvCustomer.MasterTemplate.AllowAddNewRow = False
        Me.gvCustomer.MasterTemplate.AllowCellContextMenu = False
        Me.gvCustomer.MasterTemplate.AllowDeleteRow = False
        Me.gvCustomer.MasterTemplate.AllowDragToGroup = False
        Me.gvCustomer.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.gvCustomer.MasterTemplate.EnableAlternatingRowColor = True
        Me.gvCustomer.MasterTemplate.EnableFiltering = True
        Me.gvCustomer.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvCustomer.Name = "gvCustomer"
        Me.gvCustomer.ReadOnly = True
        Me.gvCustomer.Size = New System.Drawing.Size(1004, 725)
        Me.gvCustomer.TabIndex = 5
        '
        'frmCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 725)
        Me.Controls.Add(Me.gvCustomer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCustomers"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "RadForm1"
        CType(Me.gvCustomer.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gvCustomer As Telerik.WinControls.UI.RadGridView
End Class

