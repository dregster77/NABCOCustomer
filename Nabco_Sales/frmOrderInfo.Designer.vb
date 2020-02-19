<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrderInfo
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
        Me.RadCollapsiblePanel1 = New Telerik.WinControls.UI.RadCollapsiblePanel()
        Me.RadCollapsiblePanel2 = New Telerik.WinControls.UI.RadCollapsiblePanel()
        Me.RadCollapsiblePanel3 = New Telerik.WinControls.UI.RadCollapsiblePanel()
        Me.RadCollapsiblePanel4 = New Telerik.WinControls.UI.RadCollapsiblePanel()
        CType(Me.RadCollapsiblePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCollapsiblePanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCollapsiblePanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCollapsiblePanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadCollapsiblePanel1
        '
        Me.RadCollapsiblePanel1.Location = New System.Drawing.Point(12, 12)
        Me.RadCollapsiblePanel1.Name = "RadCollapsiblePanel1"
        '
        'RadCollapsiblePanel1.PanelContainer
        '
        Me.RadCollapsiblePanel1.PanelContainer.Size = New System.Drawing.Size(1032, 127)
        Me.RadCollapsiblePanel1.Size = New System.Drawing.Size(1034, 155)
        Me.RadCollapsiblePanel1.TabIndex = 0
        '
        'RadCollapsiblePanel2
        '
        Me.RadCollapsiblePanel2.Location = New System.Drawing.Point(11, 280)
        Me.RadCollapsiblePanel2.Name = "RadCollapsiblePanel2"
        '
        'RadCollapsiblePanel2.PanelContainer
        '
        Me.RadCollapsiblePanel2.PanelContainer.Size = New System.Drawing.Size(1032, 100)
        Me.RadCollapsiblePanel2.Size = New System.Drawing.Size(1034, 128)
        Me.RadCollapsiblePanel2.TabIndex = 1
        '
        'RadCollapsiblePanel3
        '
        Me.RadCollapsiblePanel3.Location = New System.Drawing.Point(11, 414)
        Me.RadCollapsiblePanel3.Name = "RadCollapsiblePanel3"
        '
        'RadCollapsiblePanel3.PanelContainer
        '
        Me.RadCollapsiblePanel3.PanelContainer.Size = New System.Drawing.Size(1032, 100)
        Me.RadCollapsiblePanel3.Size = New System.Drawing.Size(1034, 128)
        Me.RadCollapsiblePanel3.TabIndex = 2
        '
        'RadCollapsiblePanel4
        '
        Me.RadCollapsiblePanel4.Location = New System.Drawing.Point(11, 146)
        Me.RadCollapsiblePanel4.Name = "RadCollapsiblePanel4"
        '
        'RadCollapsiblePanel4.PanelContainer
        '
        Me.RadCollapsiblePanel4.PanelContainer.Size = New System.Drawing.Size(1032, 100)
        Me.RadCollapsiblePanel4.Size = New System.Drawing.Size(1034, 128)
        Me.RadCollapsiblePanel4.TabIndex = 3
        '
        'FrmOrderInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 671)
        Me.Controls.Add(Me.RadCollapsiblePanel4)
        Me.Controls.Add(Me.RadCollapsiblePanel3)
        Me.Controls.Add(Me.RadCollapsiblePanel2)
        Me.Controls.Add(Me.RadCollapsiblePanel1)
        Me.Name = "FrmOrderInfo"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "FrmOrderInfo"
        CType(Me.RadCollapsiblePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCollapsiblePanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCollapsiblePanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCollapsiblePanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadCollapsiblePanel1 As Telerik.WinControls.UI.RadCollapsiblePanel
    Friend WithEvents RadCollapsiblePanel2 As Telerik.WinControls.UI.RadCollapsiblePanel
    Friend WithEvents RadCollapsiblePanel3 As Telerik.WinControls.UI.RadCollapsiblePanel
    Friend WithEvents RadCollapsiblePanel4 As Telerik.WinControls.UI.RadCollapsiblePanel
End Class

