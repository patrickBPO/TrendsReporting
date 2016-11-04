Imports TrendsReporting.GlobalVariables
Imports TrendsReporting.VerifyLogin
Imports TrendsReporting.CtrlHotKeys

Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim chkConn As New ManageConn
        Call ClearFields()

        If Not chkConn.HandleConn(1) Then
            glbErrMesg = ErrorMes(7, "F")
            MsgBox(glbErrMesg, vbCritical, "Connection Error")
        Else
            lblLocale.Text = glbLocNme
            txtUname.Select()
        End If
    End Sub

    Private Sub ClearFields()
        txtUname.Text = ""
        txtPasswd.Text = ""
    End Sub
    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        glbUname = txtUname.Text
        glbPwd = txtPasswd.Text
        Call EnterPressed(sender, e)
    End Sub

    Private Sub EnterPressed(ByVal sender As Object, ByVal e As KeyEventArgs)
        Dim verifLog As New VerifyLogin
        Dim kyResult As Integer
        Dim kyPress As New CtrlHotKeys

        glbUname = txtUname.Text
        glbPwd = txtPasswd.Text
        If (e.KeyCode = Keys.Enter) Then
            If Not verifLog.IsActive(txtUname.Text, txtPasswd.Text) Then
                glbErrMesg = ErrorMes(8, "F")
                MsgBox(glbErrMesg, vbCritical, "Login Error")
            Else
                frmMain.Show()
                Me.Hide()
            End If
        Else
            kyResult = kyPress.KeyPressd(e)
            If kyResult = 1 Then
                btnLogin.PerformClick()
            Else
                If kyResult = 2 Then
                    btnExit.PerformClick()
                End If
            End If
        End If
    End Sub

    Private Sub txtUname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUname.KeyDown
        glbUname = txtUname.Text
        glbPwd = txtPasswd.Text
        Call EnterPressed(sender, e)

    End Sub

    Private Sub txtPasswd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPasswd.KeyDown
        glbUname = txtUname.Text
        glbPwd = txtPasswd.Text
        Call EnterPressed(sender, e)

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim verifLog As New VerifyLogin
        glbUname = txtUname.Text
        glbPwd = txtPasswd.Text
        If Not verifLog.IsActive(glbUname, glbPwd) Then
            glbErrMesg = ErrorMes(8, "F")
            MsgBox(glbErrMesg, vbCritical, "Login Error")
        Else
            frmMain.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class