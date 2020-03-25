<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomerPricing
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
        Me.RadDataEntry1 = New Telerik.WinControls.UI.RadDataEntry()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        CType(Me.RadDataEntry1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadDataEntry1.PanelContainer.SuspendLayout()
        Me.RadDataEntry1.SuspendLayout()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadDataEntry1
        '
        Me.RadDataEntry1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadDataEntry1.Location = New System.Drawing.Point(0, 0)
        Me.RadDataEntry1.Name = "RadDataEntry1"
        '
        'RadDataEntry1.PanelContainer
        '
        Me.RadDataEntry1.PanelContainer.Controls.Add(Me.RadGroupBox1)
        Me.RadDataEntry1.PanelContainer.Size = New System.Drawing.Size(1240, 694)
        Me.RadDataEntry1.Size = New System.Drawing.Size(1242, 696)
        Me.RadDataEntry1.TabIndex = 0
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.HeaderText = "RadGroupBox1"
        Me.RadGroupBox1.Location = New System.Drawing.Point(11, 11)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(1218, 277)
        Me.RadGroupBox1.TabIndex = 0
        Me.RadGroupBox1.Text = "RadGroupBox1"
        '
        'FrmCustomerPricing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1242, 696)
        Me.Controls.Add(Me.RadDataEntry1)
        Me.Name = "FrmCustomerPricing"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "FrmCustomerPricing"
        Me.RadDataEntry1.PanelContainer.ResumeLayout(False)
        CType(Me.RadDataEntry1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadDataEntry1.ResumeLayout(False)
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadDataEntry1 As Telerik.WinControls.UI.RadDataEntry
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
End Class

