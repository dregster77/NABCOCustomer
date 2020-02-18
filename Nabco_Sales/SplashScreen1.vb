Imports System.ComponentModel

Public NotInheritable Class SplashScreen1

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RadWaitingBar1.StartWaiting()

    End Sub

    Private Sub SplashScreen1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        RadWaitingBar1.StopWaiting()
    End Sub
End Class
