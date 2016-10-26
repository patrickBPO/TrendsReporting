Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports TrendsReporting.GlobalVariables
'Imports CrystalDecisions.ReportSource
'Imports CrystalDecisions.ReportAppServer
'Imports System.DateTime

Public Class frmTrends
    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        Call HandleBlnkDate()

    End Sub

    Private Sub HandleBlnkDate()
        If (IsDBNull(dtpBdate.Value) Or IsDBNull(dtpEdate.Value)) Then
            MsgBox("Both Dates Need To Be Provided To Complete This Operation", vbInformation, "Illegal Operation")

            If IsDBNull(dtpBdate.Value) Then
                dtpBdate.Select()
            Else
                If IsDBNull(dtpEdate.Value) Then
                    dtpEdate.Select()
                End If
            End If
        Else
            Call PrepareParams()
        End If
    End Sub

    Private Sub PrepareParams()
        Dim CrxReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim strReportName As String
        Dim crParamDefs As ParameterFieldDefinitions
        Dim crParamDef As ParameterFieldDefinition
        Dim paramV As New ParameterValues
        Dim paramDValue As New ParameterDiscreteValue
        Dim crParamCount As Integer


        Try

            Cursor.Current = Cursors.WaitCursor

            strReportName = Environment.GetEnvironmentVariable("CRPATH") & glbRepRNme

            CrxReport.Load(strReportName, OpenReportMethod.OpenReportByDefault)

            '-1. Refresh ReportDocument object
            'CrxReport.Refresh()


            '-2. Set ReportDocument object as CrystalReportViewer.ReportSource
            CRV.ReportSource = CrxReport


            '-3. Set parameters  to ReportDocument ----
            crParamCount = CrxReport.DataDefinition.ParameterFields.Count

            'If (crParamCount > 1 And crParamCount <= 2) Then
            'If crParamCount = 1 Then

            If glbRepYrDisp Then
                paramDValue = New ParameterDiscreteValue
                paramDValue.Value = cboYear.Text
                crParamDefs = CrxReport.DataDefinition.ParameterFields
                crParamDef = crParamDefs.Item("prmYear")
                paramV = crParamDef.CurrentValues
                paramV.Add(paramDValue)
                crParamDef.ApplyCurrentValues(paramV)
            End If

            If glbRepDteDisp Then
                paramDValue = New ParameterDiscreteValue
                paramDValue.Value = Convert.ToDateTime(dtpBdate.Text)
                crParamDefs = CrxReport.DataDefinition.ParameterFields
                crParamDef = crParamDefs.Item("prmBdate")
                paramV = crParamDef.CurrentValues
                paramV.Add(paramDValue)
                crParamDef.ApplyCurrentValues(paramV)

                '- Second Parameter
                paramDValue = New ParameterDiscreteValue
                paramDValue.Value = Convert.ToDateTime(dtpEdate.Text)
                crParamDefs = CrxReport.DataDefinition.ParameterFields
                crParamDef = crParamDefs.Item("prmEdate")
                paramV = crParamDef.CurrentValues
                paramV.Add(paramDValue)
                crParamDef.ApplyCurrentValues(paramV)
            End If

            If glbRepWSDisp Then
                paramDValue = New ParameterDiscreteValue
                paramDValue.Value = Convert.ToDateTime(dtpBdate.Text)
                crParamDefs = CrxReport.DataDefinition.ParameterFields
                crParamDef = crParamDefs.Item("prmBdate")
                paramV = crParamDef.CurrentValues
                paramV.Add(paramDValue)
                crParamDef.ApplyCurrentValues(paramV)

                '- Second Parameter
                paramDValue = New ParameterDiscreteValue
                paramDValue.Value = Convert.ToDateTime(dtpEdate.Text)
                crParamDefs = CrxReport.DataDefinition.ParameterFields
                crParamDef = crParamDefs.Item("prmEdate")
                paramV = crParamDef.CurrentValues
                paramV.Add(paramDValue)
                crParamDef.ApplyCurrentValues(paramV)

                '- Third Parameter
                paramDValue = New ParameterDiscreteValue
                paramDValue.Value = txtSearch.Text
                crParamDefs = CrxReport.DataDefinition.ParameterFields
                crParamDef = crParamDefs.Item("prmWhrStr")
                paramV = crParamDef.CurrentValues
                paramV.Add(paramDValue)
                crParamDef.ApplyCurrentValues(paramV)
            End If

            paramV.Clear()

            CRV.ShowExportButton = True
            CRV.ShowPrintButton = True
            CRV.ShowGroupTreeButton = True
            CRV.ShowRefreshButton = False


            CRV.Zoom(100)
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'MsgBox(ex.ToString & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
            paramV.Clear()
        End Try


        'CRV.Refresh()
    End Sub

    Private Sub frmTrends_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.incident' table. You can move, or remove it, as needed.
        Me.IncidentTableAdapter.Fill(Me.DataSet1.incident)

        Call CtrlParams()
    End Sub

    Private Sub CtrlParams()

        Me.Text = "TRENDS (" & glbRepTtlDisp & ")"

        If glbRepDteDisp = True Then
            dtpBdate.Visible = True
            dtpEdate.Visible = True
        Else
            dtpBdate.Visible = False
            dtpEdate.Visible = False
        End If

        If glbRepYrDisp = True Then
            cboYear.Visible = True
            lblYear.Visible = True
        Else
            cboYear.Visible = False
            lblYear.Visible = False
        End If

        If glbRepWSDisp = True Then
            lblSearch.Visible = True
            txtSearch.Visible = True
        Else
            lblSearch.Visible = False
            txtSearch.Visible = False
        End If

    End Sub
    Private Sub cboReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReport.SelectedIndexChanged
        If UCase(cboReport.SelectedValue) Like "*MTH*" Then
            cboYear.Visible = True
            lblYear.Visible = True
            dtpBdate.Visible = False
            dtpEdate.Visible = False
        Else
            cboYear.Visible = False
            lblYear.Visible = False
            dtpBdate.Visible = True
            dtpEdate.Visible = True
        End If


    End Sub

End Class
