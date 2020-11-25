Imports System.ComponentModel

Public Class frmWaitTest
    Private frm As Form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        wkrBack.WorkerReportsProgress = True
        wkrBack.WorkerSupportsCancellation = True
        If Not wkrBack.IsBusy Then
            wkrBack.RunWorkerAsync(40)
            frm = New frmWait
            frm.Show()
            ' frmWait.Show()
        End If
    End Sub

    Private Sub wkrBack_DoWork(sender As Object, e As DoWorkEventArgs) Handles wkrBack.DoWork
        Dim worker As BackgroundWorker = TryCast(sender, BackgroundWorker)
        Dim n As Integer = Convert.ToInt32(e.Argument)
        e.Result = ComplexCalcs(n, worker, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm.Close()

        frm.Dispose()
    End Sub

    Private Sub wkrBack_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles wkrBack.RunWorkerCompleted
        frm.Close()
        frm.Dispose()
        If e.Cancelled = True Then
            TextBox1.Text = "Canceled Load"
        ElseIf Not (e.Error Is Nothing) Then
            TextBox1.Text = ("Error: " & e.Error.Message)
        Else
            TextBox1.Text = e.Result.ToString
        End If

    End Sub

    Private Function ComplexCalcs(ByVal n As Integer, ByVal worker As BackgroundWorker, ByVal e As DoWorkEventArgs) As Long
        Dim res As Long = 0
        If worker.CancellationPending Then
            e.Cancel = True
        Else
            If n < 2 Then
                Return 1
            End If
            res = ComplexCalcs(n - 1, worker, e) + ComplexCalcs(n - 2, worker, e)

        End If
        Return res
    End Function
End Class