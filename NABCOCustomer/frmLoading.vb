Public Class frmLoading
    Private Sub frmLoading_Load(sender As Object, e As EventArgs) Handles Me.Load
        RoundCorners()
        lblVer.Text = "Version: " & Application.ProductVersion
        prgWait.StartWaiting()
    End Sub

    Public Sub UpdateLoadingStatus(txt As String)
        If InvokeRequired Then
            Invoke(New Action(Of String)(AddressOf UpdateLoadingStatus), txt)
        Else
            prgWait.Text = txt
        End If
    End Sub

    Private Sub RoundCorners()
        Me.DoubleBuffered = True
        Me.FormBorderStyle = FormBorderStyle.None
        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        p.AddLine(40, 0, Me.Width - 40, 0)
        p.AddArc(New Rectangle(Me.Width - 40, 0, 40, 40), -90, 90)
        p.AddLine(Me.Width, 40, Me.Width, Me.Height - 40)
        p.AddArc(New Rectangle(Me.Width - 40, Me.Height - 40, 40, 40), 0, 90)
        p.AddLine(Me.Width - 40, Me.Height, 40, Me.Height)
        p.AddArc(New Rectangle(0, Me.Height - 40, 40, 40), 90, 90)
        p.CloseFigure()
        Me.Region = New Region(p)

    End Sub
End Class