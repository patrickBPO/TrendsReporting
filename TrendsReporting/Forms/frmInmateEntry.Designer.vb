<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInmateEntry
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
        Dim L_nameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInmateEntry))
        Dim M_nameLabel As System.Windows.Forms.Label
        Dim F_nameLabel As System.Windows.Forms.Label
        Dim DobLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim O_ageLabel As System.Windows.Forms.Label
        Dim Admiss_dteLabel As System.Windows.Forms.Label
        Dim SexLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim I_StatLabel As System.Windows.Forms.Label
        Dim C_StatLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.grpDemog = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboEthnicity = New System.Windows.Forms.ComboBox()
        Me.InmateBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbkolbeDataSet1 = New TrendsReporting.dbkolbeDataSet()
        Me.cboCountry = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.F_nameTextBox1 = New System.Windows.Forms.TextBox()
        Me.SexTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpStat = New System.Windows.Forms.GroupBox()
        Me.cboSection = New System.Windows.Forms.ComboBox()
        Me.cboLocation = New System.Windows.Forms.ComboBox()
        Me.C_StatTextBox = New System.Windows.Forms.TextBox()
        Me.I_StatTextBox = New System.Windows.Forms.TextBox()
        Me.O_ageTextBox = New System.Windows.Forms.TextBox()
        Me.Admiss_dteDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.DobDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.L_nameTextBox = New System.Windows.Forms.TextBox()
        Me.M_nameTextBox = New System.Windows.Forms.TextBox()
        Me.InmateDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EthnicityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IStatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CStatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InmateTableAdapter = New TrendsReporting.dbkolbeDataSetTableAdapters.inmateTableAdapter()
        Me.TableAdapterManager = New TrendsReporting.dbkolbeDataSetTableAdapters.TableAdapterManager()
        L_nameLabel = New System.Windows.Forms.Label()
        M_nameLabel = New System.Windows.Forms.Label()
        F_nameLabel = New System.Windows.Forms.Label()
        DobLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        O_ageLabel = New System.Windows.Forms.Label()
        Admiss_dteLabel = New System.Windows.Forms.Label()
        SexLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        I_StatLabel = New System.Windows.Forms.Label()
        C_StatLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Me.grpDemog.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.InmateBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbkolbeDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStat.SuspendLayout()
        CType(Me.InmateDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'L_nameLabel
        '
        L_nameLabel.AutoSize = True
        L_nameLabel.BackColor = System.Drawing.Color.Transparent
        L_nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        L_nameLabel.Image = CType(resources.GetObject("L_nameLabel.Image"), System.Drawing.Image)
        L_nameLabel.Location = New System.Drawing.Point(568, 16)
        L_nameLabel.Name = "L_nameLabel"
        L_nameLabel.Size = New System.Drawing.Size(34, 15)
        L_nameLabel.TabIndex = 15
        L_nameLabel.Text = "Last"
        '
        'M_nameLabel
        '
        M_nameLabel.AutoSize = True
        M_nameLabel.BackColor = System.Drawing.Color.Transparent
        M_nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        M_nameLabel.Image = CType(resources.GetObject("M_nameLabel.Image"), System.Drawing.Image)
        M_nameLabel.Location = New System.Drawing.Point(471, 16)
        M_nameLabel.Name = "M_nameLabel"
        M_nameLabel.Size = New System.Drawing.Size(51, 15)
        M_nameLabel.TabIndex = 13
        M_nameLabel.Text = "Middle"
        '
        'F_nameLabel
        '
        F_nameLabel.AutoSize = True
        F_nameLabel.BackColor = System.Drawing.Color.Transparent
        F_nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        F_nameLabel.Image = CType(resources.GetObject("F_nameLabel.Image"), System.Drawing.Image)
        F_nameLabel.Location = New System.Drawing.Point(373, 16)
        F_nameLabel.Name = "F_nameLabel"
        F_nameLabel.Size = New System.Drawing.Size(35, 15)
        F_nameLabel.TabIndex = 11
        F_nameLabel.Text = "First"
        '
        'DobLabel
        '
        DobLabel.AutoSize = True
        DobLabel.BackColor = System.Drawing.Color.Transparent
        DobLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DobLabel.Image = CType(resources.GetObject("DobLabel.Image"), System.Drawing.Image)
        DobLabel.Location = New System.Drawing.Point(793, 16)
        DobLabel.Name = "DobLabel"
        DobLabel.Size = New System.Drawing.Size(89, 15)
        DobLabel.TabIndex = 16
        DobLabel.Text = "Date Of Birth"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.BackColor = System.Drawing.Color.Transparent
        AgeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AgeLabel.Image = CType(resources.GetObject("AgeLabel.Image"), System.Drawing.Image)
        AgeLabel.Location = New System.Drawing.Point(659, 16)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(31, 15)
        AgeLabel.TabIndex = 17
        AgeLabel.Text = "Age"
        '
        'O_ageLabel
        '
        O_ageLabel.AutoSize = True
        O_ageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        O_ageLabel.Image = CType(resources.GetObject("O_ageLabel.Image"), System.Drawing.Image)
        O_ageLabel.Location = New System.Drawing.Point(19, 95)
        O_ageLabel.Name = "O_ageLabel"
        O_ageLabel.Size = New System.Drawing.Size(77, 13)
        O_ageLabel.TabIndex = 23
        O_ageLabel.Text = "Prison Time:"
        '
        'Admiss_dteLabel
        '
        Admiss_dteLabel.AutoSize = True
        Admiss_dteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Admiss_dteLabel.Image = Global.TrendsReporting.My.Resources.Resources.gridGlass
        Admiss_dteLabel.Location = New System.Drawing.Point(1, 70)
        Admiss_dteLabel.Name = "Admiss_dteLabel"
        Admiss_dteLabel.Size = New System.Drawing.Size(98, 13)
        Admiss_dteLabel.TabIndex = 22
        Admiss_dteLabel.Text = "Admission Date:"
        '
        'SexLabel
        '
        SexLabel.AutoSize = True
        SexLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SexLabel.Image = Global.TrendsReporting.My.Resources.Resources.gridGlass
        SexLabel.Location = New System.Drawing.Point(696, 16)
        SexLabel.Name = "SexLabel"
        SexLabel.Size = New System.Drawing.Size(31, 15)
        SexLabel.TabIndex = 24
        SexLabel.Text = "Sex"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Label1.Location = New System.Drawing.Point(53, 18)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(78, 13)
        Label1.TabIndex = 26
        Label1.Text = "Photo Image"
        '
        'I_StatLabel
        '
        I_StatLabel.AutoSize = True
        I_StatLabel.Image = CType(resources.GetObject("I_StatLabel.Image"), System.Drawing.Image)
        I_StatLabel.Location = New System.Drawing.Point(332, 69)
        I_StatLabel.Name = "I_StatLabel"
        I_StatLabel.Size = New System.Drawing.Size(112, 17)
        I_StatLabel.TabIndex = 25
        I_StatLabel.Text = "Inmate Status:"
        '
        'C_StatLabel
        '
        C_StatLabel.AutoSize = True
        C_StatLabel.Image = CType(resources.GetObject("C_StatLabel.Image"), System.Drawing.Image)
        C_StatLabel.Location = New System.Drawing.Point(322, 93)
        C_StatLabel.Name = "C_StatLabel"
        C_StatLabel.Size = New System.Drawing.Size(122, 17)
        C_StatLabel.TabIndex = 26
        C_StatLabel.Text = "Custody Status:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Label3.Location = New System.Drawing.Point(197, 16)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(69, 15)
        Label3.TabIndex = 33
        Label3.Text = "Inmate ID"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.BackColor = System.Drawing.Color.Transparent
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Label5.Location = New System.Drawing.Point(308, 19)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(55, 15)
        Label5.TabIndex = 35
        Label5.Text = "Section"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.Color.Transparent
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Label6.Location = New System.Drawing.Point(94, 19)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(62, 15)
        Label6.TabIndex = 34
        Label6.Text = "Location"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Label2.Location = New System.Drawing.Point(71, 19)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(55, 15)
        Label2.TabIndex = 37
        Label2.Text = "Country"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.Color.Transparent
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Label4.Location = New System.Drawing.Point(67, 72)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(61, 15)
        Label4.TabIndex = 38
        Label4.Text = "Ethnicity"
        '
        'grpDemog
        '
        Me.grpDemog.BackgroundImage = Global.TrendsReporting.My.Resources.Resources.gridFeedbk
        Me.grpDemog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grpDemog.Controls.Add(Me.GroupBox1)
        Me.grpDemog.Controls.Add(Label3)
        Me.grpDemog.Controls.Add(Me.TextBox1)
        Me.grpDemog.Controls.Add(Me.F_nameTextBox1)
        Me.grpDemog.Controls.Add(Label1)
        Me.grpDemog.Controls.Add(SexLabel)
        Me.grpDemog.Controls.Add(Me.SexTextBox)
        Me.grpDemog.Controls.Add(Me.PictureBox1)
        Me.grpDemog.Controls.Add(Me.grpStat)
        Me.grpDemog.Controls.Add(AgeLabel)
        Me.grpDemog.Controls.Add(Me.AgeTextBox)
        Me.grpDemog.Controls.Add(DobLabel)
        Me.grpDemog.Controls.Add(Me.DobDateTimePicker)
        Me.grpDemog.Controls.Add(L_nameLabel)
        Me.grpDemog.Controls.Add(Me.L_nameTextBox)
        Me.grpDemog.Controls.Add(M_nameLabel)
        Me.grpDemog.Controls.Add(Me.M_nameTextBox)
        Me.grpDemog.Controls.Add(F_nameLabel)
        Me.grpDemog.Location = New System.Drawing.Point(12, 274)
        Me.grpDemog.Name = "grpDemog"
        Me.grpDemog.Size = New System.Drawing.Size(967, 202)
        Me.grpDemog.TabIndex = 11
        Me.grpDemog.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.TrendsReporting.My.Resources.Resources.gridGlass
        Me.GroupBox1.Controls.Add(Me.cboEthnicity)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.cboCountry)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(180, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(202, 125)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nationality"
        '
        'cboEthnicity
        '
        Me.cboEthnicity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InmateBindingSource1, "Ethnicity", True))
        Me.cboEthnicity.DisplayMember = "country_id"
        Me.cboEthnicity.FormattingEnabled = True
        Me.cboEthnicity.Location = New System.Drawing.Point(20, 90)
        Me.cboEthnicity.Name = "cboEthnicity"
        Me.cboEthnicity.Size = New System.Drawing.Size(167, 24)
        Me.cboEthnicity.TabIndex = 39
        Me.cboEthnicity.ValueMember = "country_id"
        '
        'InmateBindingSource1
        '
        Me.InmateBindingSource1.DataMember = "inmate"
        Me.InmateBindingSource1.DataSource = Me.DbkolbeDataSet1
        '
        'DbkolbeDataSet1
        '
        Me.DbkolbeDataSet1.DataSetName = "dbkolbeDataSet"
        Me.DbkolbeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboCountry
        '
        Me.cboCountry.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InmateBindingSource1, "Country", True))
        Me.cboCountry.DisplayMember = "country_id"
        Me.cboCountry.FormattingEnabled = True
        Me.cboCountry.Location = New System.Drawing.Point(20, 40)
        Me.cboCountry.Name = "cboCountry"
        Me.cboCountry.Size = New System.Drawing.Size(167, 24)
        Me.cboCountry.TabIndex = 36
        Me.cboCountry.ValueMember = "country_id"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InmateBindingSource1, "First", True))
        Me.TextBox1.Location = New System.Drawing.Point(180, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(106, 20)
        Me.TextBox1.TabIndex = 32
        '
        'F_nameTextBox1
        '
        Me.F_nameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InmateBindingSource1, "First", True))
        Me.F_nameTextBox1.Location = New System.Drawing.Point(339, 34)
        Me.F_nameTextBox1.Name = "F_nameTextBox1"
        Me.F_nameTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.F_nameTextBox1.TabIndex = 29
        '
        'SexTextBox
        '
        Me.SexTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InmateBindingSource1, "Sex", True))
        Me.SexTextBox.Location = New System.Drawing.Point(699, 34)
        Me.SexTextBox.Name = "SexTextBox"
        Me.SexTextBox.Size = New System.Drawing.Size(28, 20)
        Me.SexTextBox.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(162, 159)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'grpStat
        '
        Me.grpStat.BackgroundImage = Global.TrendsReporting.My.Resources.Resources.gridGlass
        Me.grpStat.Controls.Add(Me.cboSection)
        Me.grpStat.Controls.Add(Me.cboLocation)
        Me.grpStat.Controls.Add(Label5)
        Me.grpStat.Controls.Add(Label6)
        Me.grpStat.Controls.Add(C_StatLabel)
        Me.grpStat.Controls.Add(Me.C_StatTextBox)
        Me.grpStat.Controls.Add(I_StatLabel)
        Me.grpStat.Controls.Add(Me.I_StatTextBox)
        Me.grpStat.Controls.Add(O_ageLabel)
        Me.grpStat.Controls.Add(Me.O_ageTextBox)
        Me.grpStat.Controls.Add(Admiss_dteLabel)
        Me.grpStat.Controls.Add(Me.Admiss_dteDateTimePicker)
        Me.grpStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStat.Location = New System.Drawing.Point(388, 68)
        Me.grpStat.Name = "grpStat"
        Me.grpStat.Size = New System.Drawing.Size(557, 125)
        Me.grpStat.TabIndex = 23
        Me.grpStat.TabStop = False
        Me.grpStat.Text = "Status"
        '
        'cboSection
        '
        Me.cboSection.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InmateBindingSource1, "Section", True))
        Me.cboSection.DisplayMember = "country_id"
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.Location = New System.Drawing.Point(260, 36)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Size = New System.Drawing.Size(167, 24)
        Me.cboSection.TabIndex = 39
        Me.cboSection.ValueMember = "country_id"
        '
        'cboLocation
        '
        Me.cboLocation.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InmateBindingSource1, "Location", True))
        Me.cboLocation.DisplayMember = "country_id"
        Me.cboLocation.FormattingEnabled = True
        Me.cboLocation.Location = New System.Drawing.Point(16, 36)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(222, 24)
        Me.cboLocation.TabIndex = 38
        Me.cboLocation.ValueMember = "country_id"
        '
        'C_StatTextBox
        '
        Me.C_StatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InmateBindingSource1, "C-Stat", True))
        Me.C_StatTextBox.Location = New System.Drawing.Point(451, 89)
        Me.C_StatTextBox.Name = "C_StatTextBox"
        Me.C_StatTextBox.Size = New System.Drawing.Size(100, 23)
        Me.C_StatTextBox.TabIndex = 27
        '
        'I_StatTextBox
        '
        Me.I_StatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InmateBindingSource1, "I-Stat", True))
        Me.I_StatTextBox.Location = New System.Drawing.Point(451, 65)
        Me.I_StatTextBox.Name = "I_StatTextBox"
        Me.I_StatTextBox.Size = New System.Drawing.Size(100, 23)
        Me.I_StatTextBox.TabIndex = 26
        '
        'O_ageTextBox
        '
        Me.O_ageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InmateBindingSource1, "P-Time", True))
        Me.O_ageTextBox.Location = New System.Drawing.Point(105, 90)
        Me.O_ageTextBox.Name = "O_ageTextBox"
        Me.O_ageTextBox.Size = New System.Drawing.Size(157, 23)
        Me.O_ageTextBox.TabIndex = 25
        '
        'Admiss_dteDateTimePicker
        '
        Me.Admiss_dteDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InmateBindingSource1, "DOA", True))
        Me.Admiss_dteDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Admiss_dteDateTimePicker.Location = New System.Drawing.Point(105, 64)
        Me.Admiss_dteDateTimePicker.Name = "Admiss_dteDateTimePicker"
        Me.Admiss_dteDateTimePicker.Size = New System.Drawing.Size(197, 20)
        Me.Admiss_dteDateTimePicker.TabIndex = 24
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InmateBindingSource1, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(656, 34)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(34, 20)
        Me.AgeTextBox.TabIndex = 18
        '
        'DobDateTimePicker
        '
        Me.DobDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InmateBindingSource1, "DOB", True))
        Me.DobDateTimePicker.Location = New System.Drawing.Point(741, 34)
        Me.DobDateTimePicker.Name = "DobDateTimePicker"
        Me.DobDateTimePicker.Size = New System.Drawing.Size(199, 20)
        Me.DobDateTimePicker.TabIndex = 17
        '
        'L_nameTextBox
        '
        Me.L_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InmateBindingSource1, "Last", True))
        Me.L_nameTextBox.Location = New System.Drawing.Point(550, 34)
        Me.L_nameTextBox.Name = "L_nameTextBox"
        Me.L_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.L_nameTextBox.TabIndex = 16
        '
        'M_nameTextBox
        '
        Me.M_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InmateBindingSource1, "MI", True))
        Me.M_nameTextBox.Location = New System.Drawing.Point(444, 34)
        Me.M_nameTextBox.Name = "M_nameTextBox"
        Me.M_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.M_nameTextBox.TabIndex = 14
        '
        'InmateDataGridView
        '
        Me.InmateDataGridView.AllowUserToAddRows = False
        Me.InmateDataGridView.AllowUserToDeleteRows = False
        Me.InmateDataGridView.AllowUserToOrderColumns = True
        Me.InmateDataGridView.AutoGenerateColumns = False
        Me.InmateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InmateDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FirstDataGridViewTextBoxColumn, Me.MIDataGridViewTextBoxColumn, Me.LastDataGridViewTextBoxColumn, Me.DOADataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.PTimeDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.EthnicityDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn, Me.SectionDataGridViewTextBoxColumn, Me.CountryDataGridViewTextBoxColumn, Me.IStatDataGridViewTextBoxColumn, Me.CStatDataGridViewTextBoxColumn})
        Me.InmateDataGridView.DataSource = Me.InmateBindingSource1
        Me.InmateDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.InmateDataGridView.Name = "InmateDataGridView"
        Me.InmateDataGridView.Size = New System.Drawing.Size(967, 240)
        Me.InmateDataGridView.TabIndex = 12
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstDataGridViewTextBoxColumn
        '
        Me.FirstDataGridViewTextBoxColumn.DataPropertyName = "First"
        Me.FirstDataGridViewTextBoxColumn.HeaderText = "First"
        Me.FirstDataGridViewTextBoxColumn.Name = "FirstDataGridViewTextBoxColumn"
        Me.FirstDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MIDataGridViewTextBoxColumn
        '
        Me.MIDataGridViewTextBoxColumn.DataPropertyName = "MI"
        Me.MIDataGridViewTextBoxColumn.HeaderText = "MI"
        Me.MIDataGridViewTextBoxColumn.Name = "MIDataGridViewTextBoxColumn"
        Me.MIDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastDataGridViewTextBoxColumn
        '
        Me.LastDataGridViewTextBoxColumn.DataPropertyName = "Last"
        Me.LastDataGridViewTextBoxColumn.HeaderText = "Last"
        Me.LastDataGridViewTextBoxColumn.Name = "LastDataGridViewTextBoxColumn"
        Me.LastDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DOADataGridViewTextBoxColumn
        '
        Me.DOADataGridViewTextBoxColumn.DataPropertyName = "DOA"
        Me.DOADataGridViewTextBoxColumn.HeaderText = "DOA"
        Me.DOADataGridViewTextBoxColumn.Name = "DOADataGridViewTextBoxColumn"
        Me.DOADataGridViewTextBoxColumn.ReadOnly = True
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        Me.DOBDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        Me.AgeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PTimeDataGridViewTextBoxColumn
        '
        Me.PTimeDataGridViewTextBoxColumn.DataPropertyName = "P-Time"
        Me.PTimeDataGridViewTextBoxColumn.HeaderText = "P-Time"
        Me.PTimeDataGridViewTextBoxColumn.Name = "PTimeDataGridViewTextBoxColumn"
        Me.PTimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "Sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "Sex"
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        Me.SexDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EthnicityDataGridViewTextBoxColumn
        '
        Me.EthnicityDataGridViewTextBoxColumn.DataPropertyName = "Ethnicity"
        Me.EthnicityDataGridViewTextBoxColumn.HeaderText = "Ethnicity"
        Me.EthnicityDataGridViewTextBoxColumn.Name = "EthnicityDataGridViewTextBoxColumn"
        Me.EthnicityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "Location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = "Location"
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        Me.LocationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SectionDataGridViewTextBoxColumn
        '
        Me.SectionDataGridViewTextBoxColumn.DataPropertyName = "Section"
        Me.SectionDataGridViewTextBoxColumn.HeaderText = "Section"
        Me.SectionDataGridViewTextBoxColumn.Name = "SectionDataGridViewTextBoxColumn"
        Me.SectionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CountryDataGridViewTextBoxColumn
        '
        Me.CountryDataGridViewTextBoxColumn.DataPropertyName = "Country"
        Me.CountryDataGridViewTextBoxColumn.HeaderText = "Country"
        Me.CountryDataGridViewTextBoxColumn.Name = "CountryDataGridViewTextBoxColumn"
        Me.CountryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IStatDataGridViewTextBoxColumn
        '
        Me.IStatDataGridViewTextBoxColumn.DataPropertyName = "I-Stat"
        Me.IStatDataGridViewTextBoxColumn.HeaderText = "I-Stat"
        Me.IStatDataGridViewTextBoxColumn.Name = "IStatDataGridViewTextBoxColumn"
        Me.IStatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CStatDataGridViewTextBoxColumn
        '
        Me.CStatDataGridViewTextBoxColumn.DataPropertyName = "C-Stat"
        Me.CStatDataGridViewTextBoxColumn.HeaderText = "C-Stat"
        Me.CStatDataGridViewTextBoxColumn.Name = "CStatDataGridViewTextBoxColumn"
        Me.CStatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InmateTableAdapter
        '
        Me.InmateTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.inmateTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TrendsReporting.dbkolbeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmInmateEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TrendsReporting.My.Resources.Resources.grid
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(989, 481)
        Me.Controls.Add(Me.InmateDataGridView)
        Me.Controls.Add(Me.grpDemog)
        Me.Name = "frmInmateEntry"
        Me.Text = "Inmate Entry"
        Me.grpDemog.ResumeLayout(False)
        Me.grpDemog.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.InmateBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbkolbeDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStat.ResumeLayout(False)
        Me.grpStat.PerformLayout()
        CType(Me.InmateDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpDemog As GroupBox
    Friend WithEvents SexTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grpStat As GroupBox
    Friend WithEvents O_ageTextBox As TextBox
    Friend WithEvents Admiss_dteDateTimePicker As DateTimePicker
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents DobDateTimePicker As DateTimePicker
    Friend WithEvents L_nameTextBox As TextBox
    Friend WithEvents M_nameTextBox As TextBox
    Friend WithEvents InmateDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents F_nameTextBox1 As TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents InmateTableAdapter As dbkolbeDataSetTableAdapters.inmateTableAdapter
    Friend WithEvents TableAdapterManager As dbkolbeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DbkolbeDataSet1 As dbkolbeDataSet
    Friend WithEvents InmateBindingSource1 As BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EthnicityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SectionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CountryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IStatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CStatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents C_StatTextBox As TextBox
    Friend WithEvents I_StatTextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cboSection As ComboBox
    Friend WithEvents cboLocation As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboEthnicity As ComboBox
    Friend WithEvents cboCountry As ComboBox
End Class
