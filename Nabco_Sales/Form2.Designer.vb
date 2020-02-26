<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

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
        Me.txtu2 = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RadDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
        CType(Me.txtu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtu2
        '
        Me.txtu2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtu2.Location = New System.Drawing.Point(308, 212)
        Me.txtu2.Name = "txtu2"
        Me.txtu2.Size = New System.Drawing.Size(184, 27)
        Me.txtu2.TabIndex = 14
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(308, 297)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(184, 20)
        Me.TextBox1.TabIndex = 15
        '
        'RadDropDownList1
        '
        Me.RadDropDownList1.Location = New System.Drawing.Point(308, 164)
        Me.RadDropDownList1.Name = "RadDropDownList1"
        Me.RadDropDownList1.Size = New System.Drawing.Size(184, 20)
        Me.RadDropDownList1.TabIndex = 16
        Me.RadDropDownList1.Text = "RadDropDownList1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RadDropDownList1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtu2)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.txtu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtu2 As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RadDropDownList1 As Telerik.WinControls.UI.RadDropDownList
End Class
