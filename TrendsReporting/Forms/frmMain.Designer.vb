<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrendReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YEARTODATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INCIDENTSYTDSUMMARYToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.INCIDENTSYTDMTHSSUMMARYToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OFFENCEYTDSUMMARYToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONTRABANDSEIZURESYTDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOCATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONFISCATIONSBYLOCATIONToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OFFENCEDETAILBYLOCATIONToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.INCIDENTSBYLOCATIONANDMONTHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DETAILToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INMATEINCIDENTSUMMARYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLASSIFICATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INCIDENTSBYETHNICITYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INCIDENTSBYSTATUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ITSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncidentTrackingSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TrendReportsToolStripMenuItem, Me.ITSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(380, 26)
        Me.MenuStrip1.TabIndex = 31
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Demi", 10.0!)
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(43, 22)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'TrendReportsToolStripMenuItem
        '
        Me.TrendReportsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.TrendReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YEARTODATEToolStripMenuItem, Me.LOCATIONToolStripMenuItem, Me.DETAILToolStripMenuItem, Me.CLASSIFICATIONToolStripMenuItem})
        Me.TrendReportsToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Demi", 10.0!)
        Me.TrendReportsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TrendReportsToolStripMenuItem.Name = "TrendReportsToolStripMenuItem"
        Me.TrendReportsToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.TrendReportsToolStripMenuItem.Text = "Trend &Reports"
        '
        'YEARTODATEToolStripMenuItem
        '
        Me.YEARTODATEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INCIDENTSYTDSUMMARYToolStripMenuItem1, Me.INCIDENTSYTDMTHSSUMMARYToolStripMenuItem1, Me.OFFENCEYTDSUMMARYToolStripMenuItem1, Me.CONTRABANDSEIZURESYTDToolStripMenuItem})
        Me.YEARTODATEToolStripMenuItem.Name = "YEARTODATEToolStripMenuItem"
        Me.YEARTODATEToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.YEARTODATEToolStripMenuItem.Text = "YEAR TO DATE"
        '
        'INCIDENTSYTDSUMMARYToolStripMenuItem1
        '
        Me.INCIDENTSYTDSUMMARYToolStripMenuItem1.Name = "INCIDENTSYTDSUMMARYToolStripMenuItem1"
        Me.INCIDENTSYTDSUMMARYToolStripMenuItem1.Size = New System.Drawing.Size(280, 22)
        Me.INCIDENTSYTDSUMMARYToolStripMenuItem1.Text = "INCIDENTS YTD SUMMARY"
        '
        'INCIDENTSYTDMTHSSUMMARYToolStripMenuItem1
        '
        Me.INCIDENTSYTDMTHSSUMMARYToolStripMenuItem1.Name = "INCIDENTSYTDMTHSSUMMARYToolStripMenuItem1"
        Me.INCIDENTSYTDMTHSSUMMARYToolStripMenuItem1.Size = New System.Drawing.Size(280, 22)
        Me.INCIDENTSYTDMTHSSUMMARYToolStripMenuItem1.Text = "INCIDENTS YTD MTHS SUMMARY"
        '
        'OFFENCEYTDSUMMARYToolStripMenuItem1
        '
        Me.OFFENCEYTDSUMMARYToolStripMenuItem1.Name = "OFFENCEYTDSUMMARYToolStripMenuItem1"
        Me.OFFENCEYTDSUMMARYToolStripMenuItem1.Size = New System.Drawing.Size(280, 22)
        Me.OFFENCEYTDSUMMARYToolStripMenuItem1.Text = "OFFENCE YTD SUMMARY"
        '
        'CONTRABANDSEIZURESYTDToolStripMenuItem
        '
        Me.CONTRABANDSEIZURESYTDToolStripMenuItem.Name = "CONTRABANDSEIZURESYTDToolStripMenuItem"
        Me.CONTRABANDSEIZURESYTDToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.CONTRABANDSEIZURESYTDToolStripMenuItem.Text = "CONTRABAND SEIZURES YTD"
        '
        'LOCATIONToolStripMenuItem
        '
        Me.LOCATIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CONFISCATIONSBYLOCATIONToolStripMenuItem1, Me.OFFENCEDETAILBYLOCATIONToolStripMenuItem1, Me.INCIDENTSBYLOCATIONANDMONTHToolStripMenuItem})
        Me.LOCATIONToolStripMenuItem.Name = "LOCATIONToolStripMenuItem"
        Me.LOCATIONToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LOCATIONToolStripMenuItem.Text = "LOCATION"
        '
        'CONFISCATIONSBYLOCATIONToolStripMenuItem1
        '
        Me.CONFISCATIONSBYLOCATIONToolStripMenuItem1.Name = "CONFISCATIONSBYLOCATIONToolStripMenuItem1"
        Me.CONFISCATIONSBYLOCATIONToolStripMenuItem1.Size = New System.Drawing.Size(311, 22)
        Me.CONFISCATIONSBYLOCATIONToolStripMenuItem1.Text = "CONFISCATIONS BY LOCATION"
        '
        'OFFENCEDETAILBYLOCATIONToolStripMenuItem1
        '
        Me.OFFENCEDETAILBYLOCATIONToolStripMenuItem1.Name = "OFFENCEDETAILBYLOCATIONToolStripMenuItem1"
        Me.OFFENCEDETAILBYLOCATIONToolStripMenuItem1.Size = New System.Drawing.Size(311, 22)
        Me.OFFENCEDETAILBYLOCATIONToolStripMenuItem1.Text = "OFFENCE DETAIL BY LOCATION"
        '
        'INCIDENTSBYLOCATIONANDMONTHToolStripMenuItem
        '
        Me.INCIDENTSBYLOCATIONANDMONTHToolStripMenuItem.Name = "INCIDENTSBYLOCATIONANDMONTHToolStripMenuItem"
        Me.INCIDENTSBYLOCATIONANDMONTHToolStripMenuItem.Size = New System.Drawing.Size(311, 22)
        Me.INCIDENTSBYLOCATIONANDMONTHToolStripMenuItem.Text = "INCIDENTS BY LOCATION AND MONTH"
        '
        'DETAILToolStripMenuItem
        '
        Me.DETAILToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INMATEINCIDENTSUMMARYToolStripMenuItem})
        Me.DETAILToolStripMenuItem.Name = "DETAILToolStripMenuItem"
        Me.DETAILToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DETAILToolStripMenuItem.Text = "DETAIL"
        '
        'INMATEINCIDENTSUMMARYToolStripMenuItem
        '
        Me.INMATEINCIDENTSUMMARYToolStripMenuItem.Name = "INMATEINCIDENTSUMMARYToolStripMenuItem"
        Me.INMATEINCIDENTSUMMARYToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.INMATEINCIDENTSUMMARYToolStripMenuItem.Text = "INMATE INCIDENT SUMMARY"
        '
        'CLASSIFICATIONToolStripMenuItem
        '
        Me.CLASSIFICATIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INCIDENTSBYETHNICITYToolStripMenuItem, Me.INCIDENTSBYSTATUSToolStripMenuItem})
        Me.CLASSIFICATIONToolStripMenuItem.Name = "CLASSIFICATIONToolStripMenuItem"
        Me.CLASSIFICATIONToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CLASSIFICATIONToolStripMenuItem.Text = "CLASSIFICATION"
        '
        'INCIDENTSBYETHNICITYToolStripMenuItem
        '
        Me.INCIDENTSBYETHNICITYToolStripMenuItem.Name = "INCIDENTSBYETHNICITYToolStripMenuItem"
        Me.INCIDENTSBYETHNICITYToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.INCIDENTSBYETHNICITYToolStripMenuItem.Text = "INCIDENTS BY ETHNICITY"
        '
        'INCIDENTSBYSTATUSToolStripMenuItem
        '
        Me.INCIDENTSBYSTATUSToolStripMenuItem.Name = "INCIDENTSBYSTATUSToolStripMenuItem"
        Me.INCIDENTSBYSTATUSToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.INCIDENTSBYSTATUSToolStripMenuItem.Text = "INCIDENTS BY STATUS"
        '
        'ITSToolStripMenuItem
        '
        Me.ITSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IncidentTrackingSystemToolStripMenuItem})
        Me.ITSToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Demi", 10.0!)
        Me.ITSToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.ITSToolStripMenuItem.Name = "ITSToolStripMenuItem"
        Me.ITSToolStripMenuItem.Size = New System.Drawing.Size(39, 22)
        Me.ITSToolStripMenuItem.Text = "&ITS"
        Me.ITSToolStripMenuItem.ToolTipText = "Incident Tracking System"
        '
        'IncidentTrackingSystemToolStripMenuItem
        '
        Me.IncidentTrackingSystemToolStripMenuItem.Name = "IncidentTrackingSystemToolStripMenuItem"
        Me.IncidentTrackingSystemToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.IncidentTrackingSystemToolStripMenuItem.Text = "Incident Tracking System"
        Me.IncidentTrackingSystemToolStripMenuItem.ToolTipText = "ITS"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.TrendsReporting.My.Resources.Resources.Doberman30pct
        Me.ClientSize = New System.Drawing.Size(380, 401)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Opacity = 0.75R
        Me.Text = "Trends Reporting Interface"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrendReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YEARTODATEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents INCIDENTSYTDSUMMARYToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents INCIDENTSYTDMTHSSUMMARYToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OFFENCEYTDSUMMARYToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LOCATIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONFISCATIONSBYLOCATIONToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OFFENCEDETAILBYLOCATIONToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DETAILToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents INMATEINCIDENTSUMMARYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ITSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IncidentTrackingSystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents INCIDENTSBYLOCATIONANDMONTHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONTRABANDSEIZURESYTDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CLASSIFICATIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents INCIDENTSBYETHNICITYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents INCIDENTSBYSTATUSToolStripMenuItem As ToolStripMenuItem
End Class
