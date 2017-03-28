<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lblLocale = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.grpLogin = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPasswd = New System.Windows.Forms.TextBox()
        Me.txtUname = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.grpLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLocale
        '
        Me.lblLocale.AutoSize = True
        Me.lblLocale.BackColor = System.Drawing.Color.White
        Me.lblLocale.Font = New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblLocale.Image = Global.TrendsReporting.My.Resources.Resources.gridGlass
        Me.lblLocale.Location = New System.Drawing.Point(202, 14)
        Me.lblLocale.Name = "lblLocale"
        Me.lblLocale.Size = New System.Drawing.Size(80, 15)
        Me.lblLocale.TabIndex = 7
        Me.lblLocale.Text = "Locale"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.TrendsReporting.My.Resources.Resources.gridGlass
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.lblLogin)
        Me.Panel1.Controls.Add(Me.lblLocale)
        Me.Panel1.Controls.Add(Me.grpLogin)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(304, 201)
        Me.Panel1.TabIndex = 8
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.White
        Me.lblLogin.Font = New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblLogin.Image = Global.TrendsReporting.My.Resources.Resources.gridGlass
        Me.lblLogin.Location = New System.Drawing.Point(18, 14)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(68, 15)
        Me.lblLogin.TabIndex = 8
        Me.lblLogin.Text = "LOGIN"
        '
        'grpLogin
        '
        Me.grpLogin.Controls.Add(Me.btnExit)
        Me.grpLogin.Controls.Add(Me.btnLogin)
        Me.grpLogin.Controls.Add(Me.Label2)
        Me.grpLogin.Controls.Add(Me.Label1)
        Me.grpLogin.Controls.Add(Me.txtPasswd)
        Me.grpLogin.Controls.Add(Me.txtUname)
        Me.grpLogin.Controls.Add(Me.Panel2)
        Me.grpLogin.Location = New System.Drawing.Point(15, 32)
        Me.grpLogin.Name = "grpLogin"
        Me.grpLogin.Size = New System.Drawing.Size(267, 145)
        Me.grpLogin.TabIndex = 0
        Me.grpLogin.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.DimGray
        Me.btnExit.Image = Global.TrendsReporting.My.Resources.Resources.btnExUp
        Me.btnExit.Location = New System.Drawing.Point(173, 99)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 30)
        Me.btnExit.TabIndex = 15
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.BackgroundImage = Global.TrendsReporting.My.Resources.Resources.btnLiUp
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Black
        Me.btnLogin.Location = New System.Drawing.Point(85, 99)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 30)
        Me.btnLogin.TabIndex = 14
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "User Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Password"
        '
        'txtPasswd
        '
        Me.txtPasswd.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswd.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.txtPasswd.Location = New System.Drawing.Point(111, 58)
        Me.txtPasswd.Name = "txtPasswd"
        Me.txtPasswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8224)
        Me.txtPasswd.Size = New System.Drawing.Size(137, 23)
        Me.txtPasswd.TabIndex = 13
        '
        'txtUname
        '
        Me.txtUname.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUname.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.txtUname.Location = New System.Drawing.Point(111, 19)
        Me.txtUname.Name = "txtUname"
        Me.txtUname.Size = New System.Drawing.Size(137, 23)
        Me.txtUname.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.TrendsReporting.My.Resources.Resources.gridFeedbk
        Me.Panel2.Location = New System.Drawing.Point(6, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(255, 125)
        Me.Panel2.TabIndex = 18
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.TrendsReporting.My.Resources.Resources.gridGlass
        Me.ClientSize = New System.Drawing.Size(304, 201)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.Text = "System Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grpLogin.ResumeLayout(False)
        Me.grpLogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblLocale As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents grpLogin As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPasswd As TextBox
    Friend WithEvents txtUname As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblLogin As Label
End Class
