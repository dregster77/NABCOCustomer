<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.btntest = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadCollapsiblePanel1 = New Telerik.WinControls.UI.RadCollapsiblePanel()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCollapsiblePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadCollapsiblePanel1.PanelContainer.SuspendLayout()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(598, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 76)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "find file"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(296, 94)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(432, 167)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(3, 96)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 40)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Insert"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(3, 51)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 39)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "PopFile"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(3, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(118, 42)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Clear Images"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(511, 283)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(217, 20)
        Me.NumericUpDown1.TabIndex = 5
        '
        'btntest
        '
        Me.btntest.Location = New System.Drawing.Point(12, 12)
        Me.btntest.Name = "btntest"
        Me.btntest.Size = New System.Drawing.Size(130, 76)
        Me.btntest.TabIndex = 6
        Me.btntest.Text = "Remove Handler"
        Me.btntest.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(788, 94)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(289, 167)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(296, 282)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(209, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(184, 290)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Label1"
        '
        'RadCollapsiblePanel1
        '
        Me.RadCollapsiblePanel1.Location = New System.Drawing.Point(12, 334)
        Me.RadCollapsiblePanel1.Name = "RadCollapsiblePanel1"
        '
        'RadCollapsiblePanel1.PanelContainer
        '
        Me.RadCollapsiblePanel1.PanelContainer.Controls.Add(Me.Button4)
        Me.RadCollapsiblePanel1.PanelContainer.Controls.Add(Me.Button3)
        Me.RadCollapsiblePanel1.PanelContainer.Controls.Add(Me.Button2)
        Me.RadCollapsiblePanel1.PanelContainer.Size = New System.Drawing.Size(264, 172)
        Me.RadCollapsiblePanel1.Size = New System.Drawing.Size(266, 200)
        Me.RadCollapsiblePanel1.TabIndex = 10
        '
        'RadGridView1
        '
        Me.RadGridView1.Location = New System.Drawing.Point(307, 347)
        '
        '
        '
        Me.RadGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewTextBoxColumn1.HeaderText = "Small"
        GridViewTextBoxColumn1.Name = "Column Small"
        GridViewTextBoxColumn1.Width = 236
        GridViewTextBoxColumn2.HeaderText = "Med"
        GridViewTextBoxColumn2.Name = "ColMedium"
        GridViewTextBoxColumn2.Width = 236
        GridViewTextBoxColumn3.HeaderText = "Big"
        GridViewTextBoxColumn3.Name = "ColBig"
        GridViewTextBoxColumn3.Width = 235
        Me.RadGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3})
        Me.RadGridView1.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.Size = New System.Drawing.Size(726, 301)
        Me.RadGridView1.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1439, 678)
        Me.Controls.Add(Me.RadGridView1)
        Me.Controls.Add(Me.RadCollapsiblePanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btntest)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadCollapsiblePanel1.PanelContainer.ResumeLayout(False)
        CType(Me.RadCollapsiblePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents btntest As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RadCollapsiblePanel1 As Telerik.WinControls.UI.RadCollapsiblePanel
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
End Class
