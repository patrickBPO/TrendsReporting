
Imports TrendsReporting.GlobalVariables
Public Module modReport

    Public Function PrepReport(ByRef intMenuItemSect As Integer) As Boolean

        'Call MenuItemSection(intMenuItemSect)
        If MenuItemSection(intMenuItemSect) Then
            PrepReport = True
        Else
            PrepReport = False
        End If

    End Function

    Private Function MenuItemSection(ByRef intMIS As Integer) As Boolean
        Select Case intMIS
            Case 1  '- INCIDENTS YTD SUMMARY
                glbRepTtlDisp = "INCIDENTS YTD SUMMARY"
                glbRepDteDisp = True '- Display Date Picker Controls
                glbRepYrDisp = False '- Display Year ComboBox
                glbRepWSDisp = False '- Display Search String TextBox
                glbRepRNme = "IncidentsYTDSum.rpt" '- Report Name

                MenuItemSection = False
            Case 2 '- INCIDENTS YTD MTHS SUMMARY
                glbRepTtlDisp = "INCIDENTS YTD MTHS SUMMARY"
                glbRepDteDisp = False '- Display Date Picker Controls
                glbRepYrDisp = True '- Display Year ComboBox
                glbRepWSDisp = False '- Display Search String TextBox
                glbRepRNme = "IncidentsYTDMthSum.rpt" '- Report Name

                MenuItemSection = False
            Case 3 '- OFFENCE YTD SUMMARY
                glbRepTtlDisp = "OFFENCE YTD SUMMARY"
                glbRepDteDisp = True '- Display Date Picker Controls
                glbRepYrDisp = False '- Display Year ComboBox
                glbRepWSDisp = False '- Display Search String TextBox
                glbRepRNme = "OffenceSum.rpt" '- Report Name

                MenuItemSection = False
            Case 4 '- CONFISCATIONS BY LOCATION
                glbRepTtlDisp = "CONFISCATIONS BY LOCATION"
                glbRepDteDisp = True '- Display Date Picker Controls
                glbRepYrDisp = False '- Display Year ComboBox
                glbRepWSDisp = False '- Display Search String TextBox
                glbRepRNme = "Confiscations.rpt" '- Report Name

                MenuItemSection = False
            Case 5 '- OFFENCE DETAIL BY LOCATION
                glbRepTtlDisp = "OFFENCE DETAIL BY LOCATION"
                glbRepDteDisp = True '- Display Date Picker Controls
                glbRepYrDisp = False '- Display Year ComboBox
                glbRepWSDisp = False '- Display Search String TextBox
                glbRepRNme = "OffenceDet.rpt" '- Report Name

                MenuItemSection = False
            Case 6 '- INMATE INCIDENT SUMMARY
                glbRepTtlDisp = "INMATE INCIDENT SUMMARY"
                glbRepDteDisp = True '- Display Date Picker Controls
                glbRepYrDisp = False '- Display Year ComboBox
                glbRepWSDisp = True '- Display Search String TextBox
                glbRepRNme = "IncidentByInmate.rpt" '- Report Name

                MenuItemSection = False
            Case 7 '- CONTRABAND SEIZURES BY MONTH
                glbRepTtlDisp = "CONTRABAND YTD SUMMARY"
                glbRepDteDisp = False '- Display Date Picker Controls
                glbRepYrDisp = True '- Display Year ComboBox
                glbRepWSDisp = False '- Display Search String TextBox
                glbRepRNme = "ContrabandYTDSum.rpt" '- Report Name

                MenuItemSection = False

            Case 8 '- INCIDENTS BY LOCATION AND MONTH
                glbRepTtlDisp = "INCIDENTS BY LOCATION AND MONTH"
                glbRepDteDisp = True '- Display Date Picker Controls
                glbRepYrDisp = False '- Display Year ComboBox
                glbRepWSDisp = False '- Display Search String TextBox
                glbRepRNme = "IncidentByLocMthSum.rpt" '- Report Name

                MenuItemSection = False

            Case 9 '- INCIDENTS BY ETHNICITY
                glbRepTtlDisp = "INCIDENTS BY ETHNICITY"
                glbRepDteDisp = True '- Display Date Picker Controls
                glbRepYrDisp = False '- Display Year ComboBox
                glbRepWSDisp = False '- Display Search String TextBox
                glbRepRNme = "IncidentByEthnicSum.rpt" '- Report Name

                MenuItemSection = False

            Case 10 '- INCIDENTS BY CUSTODY STATUS
                glbRepTtlDisp = "INCIDENTS BY CUSTODY STATUS"
                glbRepDteDisp = True '- Display Date Picker Controls
                glbRepYrDisp = False '- Display Year ComboBox
                glbRepWSDisp = False '- Display Search String TextBox
                glbRepRNme = "IncidentByStatSum.rpt" '- Report Name

                MenuItemSection = False

            Case Else
                glbErrMsg = ErrorMes(1, intMIS)
                MsgBox(glbErrMsg, vbExclamation, "Critical Error")
                MenuItemSection = True
        End Select
    End Function
End Module
