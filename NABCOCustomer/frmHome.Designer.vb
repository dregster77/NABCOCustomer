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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.gv_SAP = New Telerik.WinControls.UI.RadGridView()
        Me.gv_SQL = New Telerik.WinControls.UI.RadGridView()
        CType(Me.gv_SAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_SAP.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_SQL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_SQL.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gv_SAP
        '
        Me.gv_SAP.Dock = System.Windows.Forms.DockStyle.Top
        Me.gv_SAP.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.gv_SAP.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.gv_SAP.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gv_SAP.Name = "gv_SAP"
        Me.gv_SAP.Size = New System.Drawing.Size(1116, 279)
        Me.gv_SAP.TabIndex = 0
        Me.gv_SAP.TitleText = "SAP"
        '
        'gv_SQL
        '
        Me.gv_SQL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gv_SQL.Location = New System.Drawing.Point(0, 279)
        '
        '
        '
        Me.gv_SQL.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.gv_SQL.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.gv_SQL.Name = "gv_SQL"
        Me.gv_SQL.Size = New System.Drawing.Size(1116, 365)
        Me.gv_SQL.TabIndex = 1
        Me.gv_SQL.TitleText = "SQL"
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 644)
        Me.Controls.Add(Me.gv_SQL)
        Me.Controls.Add(Me.gv_SAP)
        Me.Name = "frmHome"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Customer Form"
        CType(Me.gv_SAP.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_SAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_SQL.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_SQL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gv_SAP As Telerik.WinControls.UI.RadGridView
    Friend WithEvents gv_SQL As Telerik.WinControls.UI.RadGridView
End Class

