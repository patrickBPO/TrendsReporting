<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTrends
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrends))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.IncidentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New TrendsReporting.DataSet1()
        Me.dtpEdate = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.dtpBdate = New System.Windows.Forms.DateTimePicker()
        Me.cboReport = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.IncidentTableAdapter = New TrendsReporting.DataSet1TableAdapters.incidentTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CRV = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncidentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'cboYear
        '
        Me.cboYear.DataSource = Me.IncidentBindingSource
        Me.cboYear.DisplayMember = "IYear"
        resources.ApplyResources(Me.cboYear, "cboYear")
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Name = "cboYear"
        '
        'IncidentBindingSource
        '
        Me.IncidentBindingSource.DataMember = "incident"
        Me.IncidentBindingSource.DataSource = Me.DataSet1BindingSource
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpEdate
        '
        resources.ApplyResources(Me.dtpEdate, "dtpEdate")
        Me.dtpEdate.Name = "dtpEdate"
        '
        'PictureBox2
        '
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'btnRun
        '
        Me.btnRun.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.btnRun, "btnRun")
        Me.btnRun.Image = Global.TrendsReporting.My.Resources.Resources.btnRnUp
        Me.btnRun.Name = "btnRun"
        Me.btnRun.UseVisualStyleBackColor = False
        '
        'dtpBdate
        '
        resources.ApplyResources(Me.dtpBdate, "dtpBdate")
        Me.dtpBdate.Name = "dtpBdate"
        '
        'cboReport
        '
        Me.cboReport.DisplayMember = "u_module_name"
        Me.cboReport.FormattingEnabled = True
        resources.ApplyResources(Me.cboReport, "cboReport")
        Me.cboReport.Name = "cboReport"
        Me.cboReport.ValueMember = "u_module_name"
        '
        'txtSearch
        '
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtSearch, "txtSearch")
        Me.txtSearch.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.txtSearch.Name = "txtSearch"
        '
        'IncidentTableAdapter
        '
        Me.IncidentTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.TrendsReporting.My.Resources.Resources.gridFeedbk
        Me.Panel1.Controls.Add(Me.CRV)
        Me.Panel1.Controls.Add(Me.lblSearch)
        Me.Panel1.Controls.Add(Me.lblYear)
        Me.Panel1.Controls.Add(Me.dtpBdate)
        Me.Panel1.Controls.Add(Me.dtpEdate)
        Me.Panel1.Controls.Add(Me.btnRun)
        Me.Panel1.Controls.Add(Me.cboYear)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'CRV
        '
        Me.CRV.ActiveViewIndex = -1
        resources.ApplyResources(Me.CRV, "CRV")
        Me.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV.Name = "CRV"
        '
        'lblSearch
        '
        resources.ApplyResources(Me.lblSearch, "lblSearch")
        Me.lblSearch.BackColor = System.Drawing.Color.Transparent
        Me.lblSearch.Name = "lblSearch"
        '
        'lblYear
        '
        resources.ApplyResources(Me.lblYear, "lblYear")
        Me.lblYear.BackColor = System.Drawing.Color.Transparent
        Me.lblYear.Name = "lblYear"
        '
        'frmTrends
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cboReport)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmTrends"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncidentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cboYear As ComboBox
    Friend WithEvents dtpEdate As DateTimePicker
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnRun As Button
    Friend WithEvents dtpBdate As DateTimePicker
    Friend WithEvents cboReport As ComboBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents DataSet1BindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents IncidentBindingSource As BindingSource
    Friend WithEvents IncidentTableAdapter As DataSet1TableAdapters.incidentTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblYear As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents CRV As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
