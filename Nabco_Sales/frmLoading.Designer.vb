<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoading
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
        Me.lblFormName = New System.Windows.Forms.Label()
        Me.lblVer = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.prgWait = New Telerik.WinControls.UI.RadWaitingBar()
        Me.WaitingBarIndicatorElement1 = New Telerik.WinControls.UI.WaitingBarIndicatorElement()
        Me.WaitingBarIndicatorElement2 = New Telerik.WinControls.UI.WaitingBarIndicatorElement()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prgWait, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFormName
        '
        Me.lblFormName.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormName.Location = New System.Drawing.Point(0, 250)
        Me.lblFormName.Name = "lblFormName"
        Me.lblFormName.Size = New System.Drawing.Size(275, 50)
        Me.lblFormName.TabIndex = 1
        Me.lblFormName.Text = "Nabco One Sales"
        Me.lblFormName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVer
        '
        Me.lblVer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVer.Location = New System.Drawing.Point(4, 300)
        Me.lblVer.Name = "lblVer"
        Me.lblVer.Size = New System.Drawing.Size(319, 21)
        Me.lblVer.TabIndex = 2
        Me.lblVer.Text = "Version:  {0}.{1:00}.{1:00}.{1:00}"
        Me.lblVer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Nabco_Sales.My.Resources.Resources.NabcoLogo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(600, 250)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'prgWait
        '
        Me.prgWait.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prgWait.Location = New System.Drawing.Point(12, 324)
        Me.prgWait.Name = "prgWait"
        Me.prgWait.ShowText = True
        Me.prgWait.Size = New System.Drawing.Size(576, 64)
        Me.prgWait.TabIndex = 3
        Me.prgWait.Text = "Loading Please Wait..."
        Me.prgWait.WaitingIndicators.Add(Me.WaitingBarIndicatorElement2)
        Me.prgWait.WaitingIndicators.Add(Me.WaitingBarIndicatorElement1)
        Me.prgWait.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.Throbber
        '
        'WaitingBarIndicatorElement1
        '
        Me.WaitingBarIndicatorElement1.BackColor = System.Drawing.Color.Transparent
        Me.WaitingBarIndicatorElement1.BackColor2 = System.Drawing.Color.Blue
        Me.WaitingBarIndicatorElement1.BackColor3 = System.Drawing.Color.Blue
        Me.WaitingBarIndicatorElement1.BackColor4 = System.Drawing.Color.Transparent
        Me.WaitingBarIndicatorElement1.BorderInnerColor = System.Drawing.Color.Red
        Me.WaitingBarIndicatorElement1.BorderInnerColor2 = System.Drawing.Color.Red
        Me.WaitingBarIndicatorElement1.Name = "WaitingBarIndicatorElement1"
        Me.WaitingBarIndicatorElement1.StretchHorizontally = False
        '
        'WaitingBarIndicatorElement2
        '
        Me.WaitingBarIndicatorElement2.BackColor = System.Drawing.Color.Transparent
        Me.WaitingBarIndicatorElement2.BackColor2 = System.Drawing.Color.Blue
        Me.WaitingBarIndicatorElement2.BackColor3 = System.Drawing.Color.Blue
        Me.WaitingBarIndicatorElement2.BackColor4 = System.Drawing.Color.Transparent
        Me.WaitingBarIndicatorElement2.BorderInnerColor = System.Drawing.Color.Red
        Me.WaitingBarIndicatorElement2.BorderInnerColor2 = System.Drawing.Color.Red
        Me.WaitingBarIndicatorElement2.Name = "WaitingBarIndicatorElement2"
        Me.WaitingBarIndicatorElement2.StretchHorizontally = False
        '
        'frmLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(600, 400)
        Me.Controls.Add(Me.prgWait)
        Me.Controls.Add(Me.lblVer)
        Me.Controls.Add(Me.lblFormName)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLoading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLoading"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prgWait, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblFormName As Label
    Friend WithEvents lblVer As Label
    Friend WithEvents prgWait As Telerik.WinControls.UI.RadWaitingBar
    Friend WithEvents WaitingBarIndicatorElement2 As Telerik.WinControls.UI.WaitingBarIndicatorElement
    Friend WithEvents WaitingBarIndicatorElement1 As Telerik.WinControls.UI.WaitingBarIndicatorElement
End Class
