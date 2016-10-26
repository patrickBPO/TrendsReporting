Public Class CRPath
    Friend Function CreateRegEnvPath() As Boolean
        Dim SubKyName As String
        Dim SubKyName1 As String
        Dim crValNme As String
        Dim crVal As String
        Dim regVersion As Microsoft.Win32.RegistryKey
        'Dim regKey As Microsoft.Win32.RegistryKey

        SubKyName = "Environment"
        SubKyName1 = "HKEY_CURRENT_USER\Environment"
        crValNme = "CRPATH"
        crVal = "\\web\Reports\"

        Try

            regVersion =
                Microsoft.Win32.Registry.CurrentUser.OpenSubKey(SubKyName, True)
            If regVersion Is Nothing Then
                My.Computer.Registry.CurrentUser.CreateSubKey(SubKyName)
                My.Computer.Registry.SetValue(SubKyName1, crValNme, crVal)
                regVersion.Close()
                Return True
            Else
                'regKey = Microsoft.Win32.Registry.CurrentUser.GetValue(crValNme)
                'regKey = Microsoft.Win32.Registry.CurrentUser.GetValue(crValNme, crVal, Nothing)
                If Microsoft.Win32.Registry.CurrentUser.GetValue(crValNme, crVal, Nothing) Is Nothing Then
                    My.Computer.Registry.SetValue(SubKyName1, crValNme, crVal)
                    regVersion.Close()
                    Return True
                Else '- Set the value anyway even if it exists
                    My.Computer.Registry.SetValue(SubKyName1, crValNme, crVal)
                    regVersion.Close()
                    Return True

                End If
            End If
        Catch
            Return False
        End Try

    End Function

End Class
