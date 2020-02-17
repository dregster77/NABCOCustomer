<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrder
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.grdCustomers = New Telerik.WinControls.UI.RadGridView()
        CType(Me.grdCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCustomers.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdCustomers
        '
        Me.grdCustomers.Location = New System.Drawing.Point(12, 12)
        '
        '
        '
        Me.grdCustomers.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.grdCustomers.Name = "grdCustomers"
        Me.grdCustomers.Size = New System.Drawing.Size(964, 641)
        Me.grdCustomers.TabIndex = 0
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 665)
        Me.Controls.Add(Me.grdCustomers)
        Me.Name = "frmOrder"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "RadForm1"
        CType(Me.grdCustomers.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdCustomers As Telerik.WinControls.UI.RadGridView
End Class

