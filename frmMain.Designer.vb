<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.txtSms = New System.Windows.Forms.TextBox()
        Me.txtPhone2 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.btnRep1 = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerSend = New System.Windows.Forms.Timer(Me.components)
        Me.cmbModerm = New System.Windows.Forms.ComboBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblForm = New System.Windows.Forms.Label()
        Me.btnRep5 = New System.Windows.Forms.Button()
        Me.btnRep3 = New System.Windows.Forms.Button()
        Me.btnRep4 = New System.Windows.Forms.Button()
        Me.btnRep2 = New System.Windows.Forms.Button()
        Me.btnCosting = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnAllocation = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnSites = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Labl78 = New System.Windows.Forms.Label()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(33, 187)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(211, 107)
        Me.PictureBox7.TabIndex = 684
        Me.PictureBox7.TabStop = False
        '
        'txtSms
        '
        Me.txtSms.Location = New System.Drawing.Point(19, 134)
        Me.txtSms.Name = "txtSms"
        Me.txtSms.Size = New System.Drawing.Size(123, 20)
        Me.txtSms.TabIndex = 683
        Me.txtSms.Visible = False
        '
        'txtPhone2
        '
        Me.txtPhone2.Location = New System.Drawing.Point(19, 108)
        Me.txtPhone2.Name = "txtPhone2"
        Me.txtPhone2.Size = New System.Drawing.Size(123, 20)
        Me.txtPhone2.TabIndex = 682
        Me.txtPhone2.Visible = False
        '
        'Timer1
        '
        '
        'PictureBox6
        '
        Me.PictureBox6.Location = New System.Drawing.Point(88, 429)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(156, 86)
        Me.PictureBox6.TabIndex = 681
        Me.PictureBox6.TabStop = False
        '
        'btnConnect
        '
        Me.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConnect.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.ForeColor = System.Drawing.Color.White
        Me.btnConnect.Image = CType(resources.GetObject("btnConnect.Image"), System.Drawing.Image)
        Me.btnConnect.Location = New System.Drawing.Point(125, 440)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(17, 25)
        Me.btnConnect.TabIndex = 680
        Me.btnConnect.Text = "Connect Dongle"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(148, 446)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(94, 13)
        Me.lblStatus.TabIndex = 679
        Me.lblStatus.Text = "Connection Status"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(148, 474)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(94, 13)
        Me.lblState.TabIndex = 678
        Me.lblState.Text = "Connection Status"
        '
        'btnRep1
        '
        Me.btnRep1.BackgroundImage = CType(resources.GetObject("btnRep1.BackgroundImage"), System.Drawing.Image)
        Me.btnRep1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRep1.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRep1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRep1.Image = CType(resources.GetObject("btnRep1.Image"), System.Drawing.Image)
        Me.btnRep1.Location = New System.Drawing.Point(759, 229)
        Me.btnRep1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRep1.Name = "btnRep1"
        Me.btnRep1.Size = New System.Drawing.Size(190, 30)
        Me.btnRep1.TabIndex = 667
        Me.btnRep1.Text = "Fuel Sales"
        Me.btnRep1.UseVisualStyleBackColor = True
        Me.btnRep1.Visible = False
        '
        'SerialPort1
        '
        '
        'TimerSend
        '
        Me.TimerSend.Interval = 1000
        '
        'cmbModerm
        '
        Me.cmbModerm.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModerm.FormattingEnabled = True
        Me.cmbModerm.Location = New System.Drawing.Point(15, 614)
        Me.cmbModerm.Name = "cmbModerm"
        Me.cmbModerm.Size = New System.Drawing.Size(246, 23)
        Me.cmbModerm.TabIndex = 677
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.DarkOrange
        Me.btnLogout.BackgroundImage = CType(resources.GetObject("btnLogout.BackgroundImage"), System.Drawing.Image)
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.Location = New System.Drawing.Point(15, 575)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(192, 32)
        Me.btnLogout.TabIndex = 676
        Me.btnLogout.Text = "User Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DarkOrange
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(15, 522)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(192, 32)
        Me.btnExit.TabIndex = 675
        Me.btnExit.Text = "Exit System"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Goldenrod
        Me.PictureBox5.Location = New System.Drawing.Point(1354, 89)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(15, 557)
        Me.PictureBox5.TabIndex = 674
        Me.PictureBox5.TabStop = False
        '
        'lblForm
        '
        Me.lblForm.AutoSize = True
        Me.lblForm.BackColor = System.Drawing.Color.Goldenrod
        Me.lblForm.Font = New System.Drawing.Font("Goudy Old Style", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForm.ForeColor = System.Drawing.Color.White
        Me.lblForm.Location = New System.Drawing.Point(19, 37)
        Me.lblForm.Name = "lblForm"
        Me.lblForm.Size = New System.Drawing.Size(242, 55)
        Me.lblForm.TabIndex = 672
        Me.lblForm.Text = "Form Label"
        Me.lblForm.Visible = False
        '
        'btnRep5
        '
        Me.btnRep5.BackgroundImage = CType(resources.GetObject("btnRep5.BackgroundImage"), System.Drawing.Image)
        Me.btnRep5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRep5.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRep5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRep5.Image = CType(resources.GetObject("btnRep5.Image"), System.Drawing.Image)
        Me.btnRep5.Location = New System.Drawing.Point(759, 309)
        Me.btnRep5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRep5.Name = "btnRep5"
        Me.btnRep5.Size = New System.Drawing.Size(190, 30)
        Me.btnRep5.TabIndex = 671
        Me.btnRep5.Text = "Fuel Allocations"
        Me.btnRep5.UseVisualStyleBackColor = True
        Me.btnRep5.Visible = False
        '
        'btnRep3
        '
        Me.btnRep3.BackgroundImage = CType(resources.GetObject("btnRep3.BackgroundImage"), System.Drawing.Image)
        Me.btnRep3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRep3.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRep3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRep3.Image = CType(resources.GetObject("btnRep3.Image"), System.Drawing.Image)
        Me.btnRep3.Location = New System.Drawing.Point(759, 271)
        Me.btnRep3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRep3.Name = "btnRep3"
        Me.btnRep3.Size = New System.Drawing.Size(190, 30)
        Me.btnRep3.TabIndex = 669
        Me.btnRep3.Text = "Fuel Transfers"
        Me.btnRep3.UseVisualStyleBackColor = True
        Me.btnRep3.Visible = False
        '
        'btnRep4
        '
        Me.btnRep4.BackgroundImage = CType(resources.GetObject("btnRep4.BackgroundImage"), System.Drawing.Image)
        Me.btnRep4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRep4.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRep4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRep4.Image = CType(resources.GetObject("btnRep4.Image"), System.Drawing.Image)
        Me.btnRep4.Location = New System.Drawing.Point(760, 191)
        Me.btnRep4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRep4.Name = "btnRep4"
        Me.btnRep4.Size = New System.Drawing.Size(189, 30)
        Me.btnRep4.TabIndex = 670
        Me.btnRep4.Text = "Redemption Sites"
        Me.btnRep4.UseVisualStyleBackColor = True
        Me.btnRep4.Visible = False
        '
        'btnRep2
        '
        Me.btnRep2.BackgroundImage = CType(resources.GetObject("btnRep2.BackgroundImage"), System.Drawing.Image)
        Me.btnRep2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRep2.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRep2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRep2.Image = CType(resources.GetObject("btnRep2.Image"), System.Drawing.Image)
        Me.btnRep2.Location = New System.Drawing.Point(760, 149)
        Me.btnRep2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRep2.Name = "btnRep2"
        Me.btnRep2.Size = New System.Drawing.Size(189, 30)
        Me.btnRep2.TabIndex = 668
        Me.btnRep2.Text = "Fuel Redemptions"
        Me.btnRep2.UseVisualStyleBackColor = True
        Me.btnRep2.Visible = False
        '
        'btnCosting
        '
        Me.btnCosting.BackgroundImage = CType(resources.GetObject("btnCosting.BackgroundImage"), System.Drawing.Image)
        Me.btnCosting.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCosting.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCosting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCosting.Image = CType(resources.GetObject("btnCosting.Image"), System.Drawing.Image)
        Me.btnCosting.Location = New System.Drawing.Point(955, 149)
        Me.btnCosting.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCosting.Name = "btnCosting"
        Me.btnCosting.Size = New System.Drawing.Size(177, 30)
        Me.btnCosting.TabIndex = 665
        Me.btnCosting.Text = "Fuel Costing"
        Me.btnCosting.UseVisualStyleBackColor = True
        Me.btnCosting.Visible = False
        '
        'btnUsers
        '
        Me.btnUsers.BackgroundImage = CType(resources.GetObject("btnUsers.BackgroundImage"), System.Drawing.Image)
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUsers.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnUsers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUsers.Image = CType(resources.GetObject("btnUsers.Image"), System.Drawing.Image)
        Me.btnUsers.Location = New System.Drawing.Point(955, 187)
        Me.btnUsers.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(177, 30)
        Me.btnUsers.TabIndex = 666
        Me.btnUsers.Text = "System Users"
        Me.btnUsers.UseVisualStyleBackColor = True
        Me.btnUsers.Visible = False
        '
        'btnAllocation
        '
        Me.btnAllocation.BackColor = System.Drawing.Color.DarkOrange
        Me.btnAllocation.BackgroundImage = CType(resources.GetObject("btnAllocation.BackgroundImage"), System.Drawing.Image)
        Me.btnAllocation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAllocation.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllocation.ForeColor = System.Drawing.Color.White
        Me.btnAllocation.Image = CType(resources.GetObject("btnAllocation.Image"), System.Drawing.Image)
        Me.btnAllocation.Location = New System.Drawing.Point(547, 109)
        Me.btnAllocation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAllocation.Name = "btnAllocation"
        Me.btnAllocation.Size = New System.Drawing.Size(207, 32)
        Me.btnAllocation.TabIndex = 664
        Me.btnAllocation.Text = "Sites Fuel Allocation"
        Me.btnAllocation.UseVisualStyleBackColor = False
        '
        'btnAdmin
        '
        Me.btnAdmin.BackgroundImage = CType(resources.GetObject("btnAdmin.BackgroundImage"), System.Drawing.Image)
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdmin.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ForeColor = System.Drawing.Color.White
        Me.btnAdmin.Image = CType(resources.GetObject("btnAdmin.Image"), System.Drawing.Image)
        Me.btnAdmin.Location = New System.Drawing.Point(955, 109)
        Me.btnAdmin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(177, 32)
        Me.btnAdmin.TabIndex = 663
        Me.btnAdmin.Text = "Administration"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'btnSales
        '
        Me.btnSales.BackColor = System.Drawing.Color.DarkOrange
        Me.btnSales.BackgroundImage = CType(resources.GetObject("btnSales.BackgroundImage"), System.Drawing.Image)
        Me.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSales.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSales.ForeColor = System.Drawing.Color.White
        Me.btnSales.Image = CType(resources.GetObject("btnSales.Image"), System.Drawing.Image)
        Me.btnSales.Location = New System.Drawing.Point(156, 109)
        Me.btnSales.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(192, 32)
        Me.btnSales.TabIndex = 659
        Me.btnSales.Text = "Fuel Sales"
        Me.btnSales.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackgroundImage = CType(resources.GetObject("btnHelp.BackgroundImage"), System.Drawing.Image)
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHelp.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.Color.White
        Me.btnHelp.Image = CType(resources.GetObject("btnHelp.Image"), System.Drawing.Image)
        Me.btnHelp.Location = New System.Drawing.Point(1138, 109)
        Me.btnHelp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(155, 32)
        Me.btnHelp.TabIndex = 662
        Me.btnHelp.Text = "System About"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.BackgroundImage = CType(resources.GetObject("btnReports.BackgroundImage"), System.Drawing.Image)
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReports.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.White
        Me.btnReports.Image = CType(resources.GetObject("btnReports.Image"), System.Drawing.Image)
        Me.btnReports.Location = New System.Drawing.Point(760, 109)
        Me.btnReports.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(189, 32)
        Me.btnReports.TabIndex = 661
        Me.btnReports.Text = "Reporting"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnSites
        '
        Me.btnSites.BackColor = System.Drawing.Color.DarkOrange
        Me.btnSites.BackgroundImage = CType(resources.GetObject("btnSites.BackgroundImage"), System.Drawing.Image)
        Me.btnSites.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSites.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSites.ForeColor = System.Drawing.Color.White
        Me.btnSites.Image = CType(resources.GetObject("btnSites.Image"), System.Drawing.Image)
        Me.btnSites.Location = New System.Drawing.Point(354, 109)
        Me.btnSites.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSites.Name = "btnSites"
        Me.btnSites.Size = New System.Drawing.Size(187, 32)
        Me.btnSites.TabIndex = 660
        Me.btnSites.Text = "Redemption Sites"
        Me.btnSites.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.LimeGreen
        Me.PictureBox3.Location = New System.Drawing.Point(-1, 685)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1710, 65)
        Me.PictureBox3.TabIndex = 658
        Me.PictureBox3.TabStop = False
        '
        'Labl78
        '
        Me.Labl78.AutoSize = True
        Me.Labl78.Font = New System.Drawing.Font("Imprint MT Shadow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labl78.ForeColor = System.Drawing.Color.Green
        Me.Labl78.Location = New System.Drawing.Point(81, 349)
        Me.Labl78.Name = "Labl78"
        Me.Labl78.Size = New System.Drawing.Size(103, 38)
        Me.Labl78.TabIndex = 656
        Me.Labl78.Text = "Total "
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.BackColor = System.Drawing.Color.Goldenrod
        Me.lblMain.Font = New System.Drawing.Font("Goudy Old Style", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.ForeColor = System.Drawing.Color.White
        Me.lblMain.Location = New System.Drawing.Point(285, 37)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(973, 55)
        Me.lblMain.TabIndex = 655
        Me.lblMain.Text = "Petrotrade Electronic Coupon System Main Menu"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Goldenrod
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 644)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1710, 35)
        Me.PictureBox2.TabIndex = 654
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Goldenrod
        Me.PictureBox1.Location = New System.Drawing.Point(-13, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1710, 75)
        Me.PictureBox1.TabIndex = 653
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1362, 24)
        Me.MenuStrip1.TabIndex = 657
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Goldenrod
        Me.PictureBox4.Location = New System.Drawing.Point(-1, 97)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(10, 549)
        Me.PictureBox4.TabIndex = 673
        Me.PictureBox4.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackgroundImage = CType(resources.GetObject("RectangleShape1.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape1.BorderWidth = 3
        Me.RectangleShape1.Location = New System.Drawing.Point(247, 143)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(876, 492)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1362, 741)
        Me.ShapeContainer1.TabIndex = 685
        Me.ShapeContainer1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.txtSms)
        Me.Controls.Add(Me.txtPhone2)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.btnRep1)
        Me.Controls.Add(Me.cmbModerm)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.lblForm)
        Me.Controls.Add(Me.btnRep5)
        Me.Controls.Add(Me.btnRep3)
        Me.Controls.Add(Me.btnRep4)
        Me.Controls.Add(Me.btnRep2)
        Me.Controls.Add(Me.btnCosting)
        Me.Controls.Add(Me.btnUsers)
        Me.Controls.Add(Me.btnAllocation)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.btnSales)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnSites)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Labl78)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSms As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone2 As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents btnRep1 As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents TimerSend As System.Windows.Forms.Timer
    Friend WithEvents cmbModerm As System.Windows.Forms.ComboBox
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents lblForm As System.Windows.Forms.Label
    Friend WithEvents btnRep5 As System.Windows.Forms.Button
    Friend WithEvents btnRep3 As System.Windows.Forms.Button
    Friend WithEvents btnRep4 As System.Windows.Forms.Button
    Friend WithEvents btnRep2 As System.Windows.Forms.Button
    Friend WithEvents btnCosting As System.Windows.Forms.Button
    Friend WithEvents btnUsers As System.Windows.Forms.Button
    Friend WithEvents btnAllocation As System.Windows.Forms.Button
    Friend WithEvents btnAdmin As System.Windows.Forms.Button
    Friend WithEvents btnSales As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnSites As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Labl78 As System.Windows.Forms.Label
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
End Class
