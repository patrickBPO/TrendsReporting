Imports TrendsReporting.CRPath
Imports TrendsReporting.GlobalVariables
Imports Microsoft.Office.Interop
Imports System.ComponentModel

'--64Bit ODBC Trial
Public Class frmMain
    Private Sub INCIDENTSYTDSUMMARYToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles INCIDENTSYTDSUMMARYToolStripMenuItem1.Click
        If Not PrepReport(1) Then
            frmTrends.Show()

        End If
    End Sub

    Private Sub INCIDENTSYTDMTHSSUMMARYToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles INCIDENTSYTDMTHSSUMMARYToolStripMenuItem1.Click
        If Not PrepReport(2) Then
            frmTrends.Show()
        End If
    End Sub

    Private Sub OFFENCEYTDSUMMARYToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OFFENCEYTDSUMMARYToolStripMenuItem1.Click
        If Not PrepReport(3) Then
            frmTrends.Show()
        End If
    End Sub

    Private Sub OFFENCEDETAILBYLOCATIONToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OFFENCEDETAILBYLOCATIONToolStripMenuItem1.Click
        If Not PrepReport(5) Then
            frmTrends.Show()
        End If
    End Sub

    Private Sub CONFISCATIONSBYLOCATIONToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CONFISCATIONSBYLOCATIONToolStripMenuItem1.Click
        If Not PrepReport(4) Then
            frmTrends.Show()
        End If
    End Sub

    Private Sub INMATEINCIDENTSUMMARYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INMATEINCIDENTSUMMARYToolStripMenuItem.Click
        If Not PrepReport(6) Then
            frmTrends.Show()
        End If
    End Sub

    Private Sub IncidentTrackingSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncidentTrackingSystemToolStripMenuItem.Click
        'Dim appAccess As New Access.application

        Process.Start("\\web\64-Bit\ITS64_X.accdb")

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim setCrPth As New CRPath
        Dim verifLog As New VerifyLogin

        If Not setCrPth.CreateRegEnvPath() Then
            glbErrMsg = ErrorMes(1, "F")
            MsgBox(glbErrMsg, vbCritical, "Key Creation Fail")
        End If

        If Not verifLog.IsReportAdmin(glbUname, glbPwd) Then
            TrendReportsToolStripMenuItem.Visible = False
        Else
            TrendReportsToolStripMenuItem.Visible = True
        End If
    End Sub

    Private Sub CONTRABANDSEIZURESYTDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONTRABANDSEIZURESYTDToolStripMenuItem.Click
        If Not PrepReport(7) Then
            frmTrends.Show()
        End If
    End Sub

    Private Sub INCIDENTSBYLOCATIONANDMONTHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INCIDENTSBYLOCATIONANDMONTHToolStripMenuItem.Click
        If Not PrepReport(8) Then
            frmTrends.Show()
        End If
    End Sub

    Private Sub INCIDENTSBYETHNICITYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INCIDENTSBYETHNICITYToolStripMenuItem.Click
        If Not PrepReport(9) Then
            frmTrends.Show()
        End If
    End Sub

    Private Sub INCIDENTSBYSTATUSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INCIDENTSBYSTATUSToolStripMenuItem.Click
        If Not PrepReport(10) Then
            frmTrends.Show()
        End If
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim fmLgin As New frmLogin
        glbConn.Close()
        fmLgin.Show()

    End Sub

End Class