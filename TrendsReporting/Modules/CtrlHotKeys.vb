Imports TrendsReporting.GlobalVariables
Public Class CtrlHotKeys
    Friend Function KeyPressd(ByVal e As KeyEventArgs) As Integer
        If (e.KeyCode And Not Keys.Modifiers) = Keys.L AndAlso e.Modifiers = Keys.Control Then
            KeyPressd = 1 ' CTRL-L
        Else
            If (e.KeyCode And Not Keys.Modifiers) = Keys.X AndAlso e.Modifiers = Keys.Control Then
                KeyPressd = 2 ' CTRL-X
            Else
                If (e.KeyCode And Not Keys.Modifiers) = Keys.R AndAlso e.Modifiers = Keys.Control Then
                    KeyPressd = 3 ' CTRL-R
                Else
                    Return 0
                End If
            End If
        End If
    End Function

    'Friend Function EnterPressed(ByVal sender As Object, ByVal e As KeyEventArgs, ByVal frm As Form) As Boolean
    '    Dim verifLog As New VerifyLogin
    '    Dim kyResult As Integer
    '    Dim kyPress As New CtrlHotKeys

    '    If (e.KeyCode = Keys.Enter) Then
    '        If Not verifLog.IsActive(glbUname, glbPwd) Then
    '            glbErrMesg = ErrorMes(8, "F")
    '            MsgBox(glbErrMesg, vbCritical, "Login Error")
    '            Return False
    '        Else
    '            frmMain.Show()
    '            frm.Hide()
    '            Return True
    '        End If
    '    Else
    '        kyResult = kyPress.KeyPressd(e)
    '        If kyResult = 1 Then
    '            frmLogin.btnLogin.PerformClick()
    '        Else
    '            If kyResult = 2 Then
    '                frmLogin.btnExit.PerformClick()
    '            End If
    '        End If
    '        Return True
    '    End If
    'End Function

End Class
