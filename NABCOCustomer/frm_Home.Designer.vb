<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Home
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Home))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gv_Info = New System.Windows.Forms.DataGridView()
        Me.Time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rows_Updated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Run_Time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.gv_Info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 300000
        '
        'gv_Info
        '
        Me.gv_Info.AllowUserToAddRows = False
        Me.gv_Info.AllowUserToDeleteRows = False
        Me.gv_Info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gv_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gv_Info.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Time, Me.Rows_Updated, Me.Run_Time})
        Me.gv_Info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gv_Info.Location = New System.Drawing.Point(0, 0)
        Me.gv_Info.Name = "gv_Info"
        Me.gv_Info.ReadOnly = True
        Me.gv_Info.Size = New System.Drawing.Size(800, 450)
        Me.gv_Info.TabIndex = 0
        '
        'Time
        '
        Me.Time.HeaderText = "Update Time"
        Me.Time.Name = "Time"
        Me.Time.ReadOnly = True
        '
        'Rows_Updated
        '
        Me.Rows_Updated.HeaderText = "Rows Updated"
        Me.Rows_Updated.Name = "Rows_Updated"
        Me.Rows_Updated.ReadOnly = True
        '
        'Run_Time
        '
        Me.Run_Time.HeaderText = "Run Time"
        Me.Run_Time.Name = "Run_Time"
        Me.Run_Time.ReadOnly = True
        '
        'frm_Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gv_Info)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Home"
        Me.Text = "Customer Updates"
        CType(Me.gv_Info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents gv_Info As DataGridView
    Friend WithEvents Time As DataGridViewTextBoxColumn
    Friend WithEvents Rows_Updated As DataGridViewTextBoxColumn
    Friend WithEvents Run_Time As DataGridViewTextBoxColumn
End Class
