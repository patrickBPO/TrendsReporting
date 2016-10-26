Imports TrendsReporting.GlobalVariables
Imports TrendsReporting.VerifyLogin
Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim chkConn As New ManageConn
        If Not chkConn.HandleConn(1) Then
            glbErrMesg = ErrorMes(7, "F")
            MsgBox(glbErrMesg, vbCritical, "Connection Error")
        Else
            lblLocale.Text = glbLocNme
            txtUname.Select()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim verifLog As New VerifyLogin

        If Not verifLog.IsActive(txtUname.Text, txtPasswd.Text) Then
            glbErrMesg = ErrorMes(8, "F")
            MsgBox(glbErrMesg, vbCritical, "Login Error")
        Else
            frmMain.Show()
            Me.Close()
        End If
    End Sub

    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call EnterPressed(sender, e)
    End Sub

    Private Sub EnterPressed(ByVal sender As Object, ByVal e As KeyEventArgs)
        Dim verifLog As New VerifyLogin
        If (e.KeyCode = Keys.Enter) Then
            If Not verifLog.IsActive(txtUname.Text, txtPasswd.Text) Then
                glbErrMesg = ErrorMes(8, "F")
                MsgBox(glbErrMesg, vbCritical, "Login Error")
            Else
                MovementSystem.Show()
                Me.Close()
            End If
        End If

    End Sub

    Private Sub txtUname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUname.KeyDown
        Call EnterPressed(sender, e)

    End Sub

    Private Sub txtPasswd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPasswd.KeyDown
        Call EnterPressed(sender, e)

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmMain.Show()
        Me.Close()
    End Sub

End Class