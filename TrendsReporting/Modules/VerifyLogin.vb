
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
                        " AND u.u_password = MD5('" & UPwd & "')"

        Debug.Print(CheckStr)
        rsCheck = New ADODB.Recordset
        Try

            rsCheck.Open(CheckStr, glbConn, adOpenDynamic, adLockReadOnly)

            With rsCheck
                If Not .BOF And Not .EOF Then

                    If .RecordCount > 0 Then
                        Return True
                    Else
                        Return True
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
    Friend Function IsReportAdmin(ByVal Uname As String, ByVal UPwd As String) As Boolean
        'Dim myConnL As New ManageConn
        Dim rsCheck As ADODB.Recordset
        Dim CheckStr As String

        'glbHWID = MakeHWID()

        'myConnL = New ADODB.Connection
        'myConnL.CursorLocation = CursorLocationEnum.adUseClient '-- Prepare to examine the cursor location and contents ReadOnly
        'myConnL.Open("MYSQL_REG")



        CheckStr = ""
        CheckStr = " SELECT u.* " &
                            " FROM user u, u_permissions up " &
                            " WHERE u.user_id = up.user_id " &
                            " AND u.u_name = '" & Uname & "' " &
                            " AND u.u_password = MD5('" & UPwd & "')" &
                            " AND up.u_module_id IN " &
                            " (SELECT um.u_module_id " &
                            "   FROM u_module um " &
                            "   WHERE u_module_name = 'mod_rep') "

        Debug.Print(CheckStr)
        rsCheck = New ADODB.Recordset
        Try


            rsCheck.Open(CheckStr, glbConn, adOpenDynamic, adLockReadOnly)

            With rsCheck
                If Not .BOF And Not .EOF Then

                    If .RecordCount > 0 Then
                        Return True
                    Else
                        Return True
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

    Friend Function IsAdmin(ByVal Uname As String, ByVal UPwd As String) As Boolean
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
                            " AND u.u_password = MD5('" & UPwd & "')" &
                            " AND u.u_group = 'ADMINISTRATORS'"

        Debug.Print(CheckStr)
            rsCheck = New ADODB.Recordset
            Try

                rsCheck.Open(CheckStr, glbConn, adOpenDynamic, adLockReadOnly)

                With rsCheck
                    If Not .BOF And Not .EOF Then

                        If .RecordCount > 0 Then
                            Return True
                        Else
                            Return True
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
