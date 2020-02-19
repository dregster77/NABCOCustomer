<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen1
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pgrWait = New Telerik.WinControls.UI.RadWaitingBar()
        Me.WaitingBarIndicatorElement1 = New Telerik.WinControls.UI.WaitingBarIndicatorElement()
        Me.WaitingBarIndicatorElement2 = New Telerik.WinControls.UI.WaitingBarIndicatorElement()
        CType(Me.pgrWait, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pgrWait
        '
        Me.pgrWait.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.pgrWait.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pgrWait.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pgrWait.Location = New System.Drawing.Point(0, 0)
        Me.pgrWait.Name = "pgrWait"
        Me.pgrWait.ShowText = True
        Me.pgrWait.Size = New System.Drawing.Size(379, 85)
        Me.pgrWait.TabIndex = 0
        Me.pgrWait.Text = "Loading Nabco Sales Applicaiton "
        Me.pgrWait.UseWaitCursor = True
        '
        '
        '
        Me.pgrWait.WaitingBarElement.ShowText = True
        Me.pgrWait.WaitingIndicators.Add(Me.WaitingBarIndicatorElement1)
        Me.pgrWait.WaitingIndicators.Add(Me.WaitingBarIndicatorElement2)
        Me.pgrWait.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.Dash
        '
        'WaitingBarIndicatorElement1
        '
        Me.WaitingBarIndicatorElement1.Name = "WaitingBarIndicatorElement1"
        Me.WaitingBarIndicatorElement1.StretchHorizontally = False
        '
        'WaitingBarIndicatorElement2
        '
        Me.WaitingBarIndicatorElement2.Name = "WaitingBarIndicatorElement2"
        Me.WaitingBarIndicatorElement2.StretchHorizontally = False
        '
        'SplashScreen1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 85)
        Me.ControlBox = False
        Me.Controls.Add(Me.pgrWait)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pgrWait, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pgrWait As Telerik.WinControls.UI.RadWaitingBar
    Friend WithEvents WaitingBarIndicatorElement1 As Telerik.WinControls.UI.WaitingBarIndicatorElement
    Friend WithEvents WaitingBarIndicatorElement2 As Telerik.WinControls.UI.WaitingBarIndicatorElement
End Class
