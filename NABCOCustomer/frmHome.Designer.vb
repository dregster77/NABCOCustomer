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
        Me.components = New System.ComponentModel.Container()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.gv_Progress = New Telerik.WinControls.UI.RadGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.gv_Progress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_Progress.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gv_Progress
        '
        Me.gv_Progress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gv_Progress.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.gv_Progress.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewTextBoxColumn1.HeaderText = "Update Time"
        GridViewTextBoxColumn1.Name = "update_Time"
        GridViewTextBoxColumn1.Width = 896
        GridViewTextBoxColumn2.HeaderText = "Records Updated"
        GridViewTextBoxColumn2.MinWidth = 200
        GridViewTextBoxColumn2.Name = "Records_updated"
        GridViewTextBoxColumn2.Width = 200
        Me.gv_Progress.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2})
        Me.gv_Progress.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gv_Progress.Name = "gv_Progress"
        Me.gv_Progress.Size = New System.Drawing.Size(1116, 748)
        Me.gv_Progress.TabIndex = 2
        Me.gv_Progress.TitleText = "Progress"
        '
        'Timer1
        '
        Me.Timer1.Interval = 300000
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 748)
        Me.Controls.Add(Me.gv_Progress)
        Me.Name = "frmHome"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Customer Form"
        CType(Me.gv_Progress.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_Progress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gv_Progress As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Timer1 As Timer
End Class

