Imports MoveTrackerWinApp.GlobalVar
Imports ADODB
'* --Note...to manually create ODBC datasources you have to create Registry Values in:
'   \HKEY_CURRENT_USER\Software\ODBC\ODBC.INI\ODBC Data Sources
'      - "ITS" Value = (MySQL ODBC 3.51 Driver)
'   \HKEY_CURRENT_USER\Software\ODBC\ODBC.INI\ITS
'      - DATABASE Value = (dbkolbe)
'      - Driver Value = (C:\Windows\SysWOW64\myodbc3.dll)
'      - PORT Value = (3308)
'      - PWD Value = (K0lb3@xs4db)
'      - SERVER Value = (web) or (192.168.2.14)
'      - UID Value = (kolbe)

Public Class ManageConn
    'Public myConnL As New ADODB.Connection
    Friend Function HandleConn(ByVal IntConn As Integer) As Boolean
        'Dim myConnL As New ADODB.Connection
        Try
            If IntConn = 1 Then
                glbConn.CursorLocation = CursorLocationEnum.adUseClient '-- Prepare to examine the cursor location and contents ReadOnly
                glbConn.Open("ITS")
                Return True
            Else
                glbConn.Close()
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
