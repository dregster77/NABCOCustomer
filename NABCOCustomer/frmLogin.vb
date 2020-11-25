Public Class frmLogin

    Public callingfrm As frmHome

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Dim rst As MsgBoxResult
        If My.Settings.User_ID = 0 Then
            rst = MsgBox("Are you sure you want to close the application?", MsgBoxStyle.YesNo, "Close Application")
            If rst = MsgBoxResult.Yes Then
                Application.Exit()
            Else
                txtUserName.Focus()
            End If
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUserName.Text = "" Then
            errorPop.SetError(txtUserName, "Invalid user name")
            errorPop.Tag = 1
            Exit Sub
        ElseIf txtPassword.Text = "" Then
            errorPop.SetError(txtPassword, "Invalid password")
            errorPop.Tag = 2
            Exit Sub
        Else

            Try
                SQL = "Select * from t_user "
                SQL &= "where "
                SQL &= "user_name = '" & Trim("" & txtUserName.Text) & "'  "
                SQL &= "and user_pass = '" & Trim("" & txtPassword.Text) & "'  "
                SQL &= " and status = 1"

                SetRS(RS)
                If RS.Read Then
                    My.Settings.User = Trim("" & RS("user_name"))
                    My.Settings.User_ID = Trim("" & RS("user_id"))
                    My.Settings.User_Full = Trim("" & RS("user_fname")) & " "
                    My.Settings.User_Full &= Trim("" & RS("user_lname"))
                    My.Settings.User_security = Trim("" & RS("security_level"))

                Else
                    errorPop.SetError(txtUserName, "Invalid user name")
                    Exit Sub
                End If

            Catch ex As Exception
                MsgBox(ex.Message,, "Login Button")
                Exit Sub
            Finally
                CloseRS(RS)
            End Try

            errorPop.Clear()
        End If

        'add logic to get user information from sap
        'SAPClass.SAPUser = "idreger"

        frmHome.Login()

        Me.Close()
    End Sub

    Private Sub txtUserName_GotFocus(sender As Object, e As EventArgs) Handles txtUserName.GotFocus
        If errorPop.Tag = 1 Then
            errorPop.Clear()
        End If
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        If errorPop.Tag = 2 Then
            errorPop.Clear()
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        autopop()
    End Sub

    'fortesting purpose will remove later
    Private Sub autopop()
        txtUserName.Text = "idreger"
        txtPassword.Text = "id2020"
    End Sub

End Class
