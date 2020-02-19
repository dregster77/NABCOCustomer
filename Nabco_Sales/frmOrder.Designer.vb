<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrder
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
        Me.btnGETlist = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnOPen = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.gvCustomer = New Telerik.WinControls.UI.RadGridView()
        Me.lblROwcount = New System.Windows.Forms.Label()
        CType(Me.gvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCustomer.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGETlist
        '
        Me.btnGETlist.Location = New System.Drawing.Point(12, 630)
        Me.btnGETlist.Name = "btnGETlist"
        Me.btnGETlist.Size = New System.Drawing.Size(228, 23)
        Me.btnGETlist.TabIndex = 1
        Me.btnGETlist.Text = "BAPI_CUSTOMER_GETLIST"
        Me.btnGETlist.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(821, 630)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(155, 23)
        Me.btnFind.TabIndex = 2
        Me.btnFind.Text = "BAPI_CUST_FIND"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnOPen
        '
        Me.btnOPen.Location = New System.Drawing.Point(412, 630)
        Me.btnOPen.Name = "btnOPen"
        Me.btnOPen.Size = New System.Drawing.Size(75, 23)
        Me.btnOPen.TabIndex = 3
        Me.btnOPen.Text = "POpLoad"
        Me.btnOPen.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(509, 630)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "CloseWAIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'gvCustomer
        '
        Me.gvCustomer.Location = New System.Drawing.Point(12, 12)
        '
        '
        '
        Me.gvCustomer.MasterTemplate.AllowAddNewRow = False
        Me.gvCustomer.MasterTemplate.AllowCellContextMenu = False
        Me.gvCustomer.MasterTemplate.AllowDeleteRow = False
        Me.gvCustomer.MasterTemplate.AllowDragToGroup = False
        Me.gvCustomer.MasterTemplate.AllowSearchRow = True
        Me.gvCustomer.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvCustomer.Name = "gvCustomer"
        Me.gvCustomer.ReadOnly = True
        Me.gvCustomer.Size = New System.Drawing.Size(964, 612)
        Me.gvCustomer.TabIndex = 5
        '
        'lblROwcount
        '
        Me.lblROwcount.Location = New System.Drawing.Point(632, 635)
        Me.lblROwcount.Name = "lblROwcount"
        Me.lblROwcount.Size = New System.Drawing.Size(123, 21)
        Me.lblROwcount.TabIndex = 6
        Me.lblROwcount.Text = "Label1"
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 665)
        Me.Controls.Add(Me.lblROwcount)
        Me.Controls.Add(Me.gvCustomer)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnOPen)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.btnGETlist)
        Me.Name = "frmOrder"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "RadForm1"
        CType(Me.gvCustomer.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGETlist As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents btnOPen As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents gvCustomer As Telerik.WinControls.UI.RadGridView
    Friend WithEvents lblROwcount As Label
End Class

