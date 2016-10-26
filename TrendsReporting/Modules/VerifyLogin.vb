
Imports ADODB
Imports TrendsReporting.GlobalVariables
Imports ADODB.CursorTypeEnum
Imports ADODB.LockTypeEnum
'{-- Process User Login Credentials--}
Public Class VerifyLogin
    Friend Function IsActive(ByVal Uname As String, ByVal UPwd As String) As Boolean
        'Dim myConnL As New ManageConn
        Dim rsCheck As ADODB.Recordset
        Dim CheckStr As String

        'glbHWID = MakeHWID()

        'myConnL = New ADODB.Connection
        'myConnL.CursorLocation = CursorLocationEnum.adUseClient '-- Prepare to examine the cursor location and contents ReadOnly
        'myConnL.Open("MYSQL_REG")



        CheckStr = ""
        CheckStr = " SELECT u.* " &
                        " FROM user u " &
                        " WHERE u.u_name = '" & Uname & "' " &
                        " AND u.u_password = '" & UPwd & "'"

        Debug.Print(CheckStr)
        rsCheck = New ADODB.Recordset
        Try

            rsCheck.Open(CheckStr, glbconn, adOpenDynamic, adLockReadOnly)

            With rsCheck
                If Not .BOF And Not .EOF Then

                    If .RecordCount > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return False

                End If
                .Close()
            End With

        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
