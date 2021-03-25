<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSales))
        Me.txtValid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHidProduct = New System.Windows.Forms.TextBox()
        Me.txtHidLitres = New System.Windows.Forms.TextBox()
        Me.TimerSet = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPin = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtLitres = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSaleID = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtAlias = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtRegDat = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.cmbProduct = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnTransect = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtValid
        '
        Me.txtValid.Location = New System.Drawing.Point(317, 500)
        Me.txtValid.Name = "txtValid"
        Me.txtValid.Size = New System.Drawing.Size(60, 20)
        Me.txtValid.TabIndex = 654
        Me.txtValid.Text = "1"
        Me.txtValid.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(257, 447)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 652
        Me.Label1.Text = "Hidden Litres"
        Me.Label1.Visible = False
        '
        'txtHidProduct
        '
        Me.txtHidProduct.BackColor = System.Drawing.Color.White
        Me.txtHidProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHidProduct.Enabled = False
        Me.txtHidProduct.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHidProduct.Location = New System.Drawing.Point(137, 465)
        Me.txtHidProduct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHidProduct.MaxLength = 15
        Me.txtHidProduct.Name = "txtHidProduct"
        Me.txtHidProduct.Size = New System.Drawing.Size(117, 24)
        Me.txtHidProduct.TabIndex = 651
        Me.txtHidProduct.TabStop = False
        Me.txtHidProduct.Visible = False
        '
        'txtHidLitres
        '
        Me.txtHidLitres.BackColor = System.Drawing.Color.White
        Me.txtHidLitres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHidLitres.Enabled = False
        Me.txtHidLitres.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHidLitres.Location = New System.Drawing.Point(260, 465)
        Me.txtHidLitres.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHidLitres.MaxLength = 15
        Me.txtHidLitres.Name = "txtHidLitres"
        Me.txtHidLitres.Size = New System.Drawing.Size(117, 24)
        Me.txtHidLitres.TabIndex = 650
        Me.txtHidLitres.TabStop = False
        Me.txtHidLitres.Visible = False
        '
        'TimerSet
        '
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DarkGray
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(95, 419)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(170, 70)
        Me.PictureBox2.TabIndex = 627
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(134, 447)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 15)
        Me.Label2.TabIndex = 653
        Me.Label2.Text = "Hidden Fuel Type"
        Me.Label2.Visible = False
        '
        'txtBal
        '
        Me.txtBal.BackColor = System.Drawing.Color.White
        Me.txtBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBal.Enabled = False
        Me.txtBal.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBal.Location = New System.Drawing.Point(498, 242)
        Me.txtBal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBal.MaxLength = 15
        Me.txtBal.Name = "txtBal"
        Me.txtBal.Size = New System.Drawing.Size(309, 28)
        Me.txtBal.TabIndex = 649
        Me.txtBal.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(496, 224)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(188, 15)
        Me.Label9.TabIndex = 648
        Me.Label9.Text = "Current  Account Balance In Litres"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 447)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 15)
        Me.Label5.TabIndex = 647
        Me.Label5.Text = "Fuel Pin Number"
        Me.Label5.Visible = False
        '
        'txtPin
        '
        Me.txtPin.BackColor = System.Drawing.Color.White
        Me.txtPin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPin.Enabled = False
        Me.txtPin.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPin.Location = New System.Drawing.Point(14, 466)
        Me.txtPin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPin.MaxLength = 15
        Me.txtPin.Name = "txtPin"
        Me.txtPin.Size = New System.Drawing.Size(117, 24)
        Me.txtPin.TabIndex = 646
        Me.txtPin.TabStop = False
        Me.txtPin.Visible = False
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.White
        Me.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStatus.Enabled = False
        Me.txtStatus.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(499, 319)
        Me.txtStatus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStatus.MaxLength = 15
        Me.txtStatus.Multiline = True
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(309, 28)
        Me.txtStatus.TabIndex = 645
        Me.txtStatus.TabStop = False
        Me.txtStatus.Text = "New / Exist / Exist But New To Product /  Blocked"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(497, 301)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(135, 15)
        Me.Label17.TabIndex = 644
        Me.Label17.Text = "Current Customer Status"
        '
        'txtLitres
        '
        Me.txtLitres.BackColor = System.Drawing.Color.White
        Me.txtLitres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLitres.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLitres.Location = New System.Drawing.Point(500, 78)
        Me.txtLitres.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLitres.MaxLength = 15
        Me.txtLitres.Name = "txtLitres"
        Me.txtLitres.Size = New System.Drawing.Size(307, 28)
        Me.txtLitres.TabIndex = 643
        Me.txtLitres.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(498, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(122, 15)
        Me.Label14.TabIndex = 642
        Me.Label14.Text = "Total Purchased Litres"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(495, 131)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 15)
        Me.Label12.TabIndex = 640
        Me.Label12.Text = "Total Sale Cost $"
        '
        'txtAmount
        '
        Me.txtAmount.BackColor = System.Drawing.Color.White
        Me.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmount.Enabled = False
        Me.txtAmount.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(498, 149)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAmount.MaxLength = 15
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(309, 28)
        Me.txtAmount.TabIndex = 641
        Me.txtAmount.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1045, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 15)
        Me.Label4.TabIndex = 638
        Me.Label4.Text = "Sale Transection Receipt Number"
        '
        'txtSaleID
        '
        Me.txtSaleID.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSaleID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaleID.Enabled = False
        Me.txtSaleID.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaleID.ForeColor = System.Drawing.Color.Black
        Me.txtSaleID.Location = New System.Drawing.Point(1047, 26)
        Me.txtSaleID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSaleID.MaxLength = 15
        Me.txtSaleID.Name = "txtSaleID"
        Me.txtSaleID.Size = New System.Drawing.Size(180, 24)
        Me.txtSaleID.TabIndex = 639
        Me.txtSaleID.TabStop = False
        Me.txtSaleID.Text = "54646646"
        Me.txtSaleID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(134, 223)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 15)
        Me.Label13.TabIndex = 636
        Me.Label13.Text = "Customer Name In Full"
        '
        'txtAlias
        '
        Me.txtAlias.BackColor = System.Drawing.Color.White
        Me.txtAlias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlias.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlias.Location = New System.Drawing.Point(136, 242)
        Me.txtAlias.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAlias.MaxLength = 29
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Size = New System.Drawing.Size(310, 28)
        Me.txtAlias.TabIndex = 637
        Me.txtAlias.TabStop = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(134, 300)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(120, 15)
        Me.Label33.TabIndex = 634
        Me.Label33.Text = "Sale Transection Date"
        '
        'txtRegDat
        '
        Me.txtRegDat.BackColor = System.Drawing.Color.White
        Me.txtRegDat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRegDat.Enabled = False
        Me.txtRegDat.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegDat.Location = New System.Drawing.Point(137, 319)
        Me.txtRegDat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRegDat.MaxLength = 15
        Me.txtRegDat.Name = "txtRegDat"
        Me.txtRegDat.Size = New System.Drawing.Size(307, 28)
        Me.txtRegDat.TabIndex = 635
        Me.txtRegDat.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Khaki
        Me.PictureBox4.Location = New System.Drawing.Point(1325, 24)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(34, 371)
        Me.PictureBox4.TabIndex = 633
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Khaki
        Me.PictureBox3.Location = New System.Drawing.Point(13, 28)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 371)
        Me.PictureBox3.TabIndex = 632
        Me.PictureBox3.TabStop = False
        '
        'cmbProduct
        '
        Me.cmbProduct.BackColor = System.Drawing.Color.White
        Me.cmbProduct.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProduct.FormattingEnabled = True
        Me.cmbProduct.Items.AddRange(New Object() {"Petrol", "Diesel"})
        Me.cmbProduct.Location = New System.Drawing.Point(135, 76)
        Me.cmbProduct.Name = "cmbProduct"
        Me.cmbProduct.Size = New System.Drawing.Size(309, 29)
        Me.cmbProduct.TabIndex = 631
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(133, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 15)
        Me.Label8.TabIndex = 630
        Me.Label8.Text = "Select Fuel Product Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(132, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(266, 15)
        Me.Label6.TabIndex = 628
        Me.Label6.Text = "Customer Cellphone Number (Account Number)"
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.ForeColor = System.Drawing.Color.White
        Me.txtPhone.Location = New System.Drawing.Point(136, 149)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPhone.MaxLength = 10
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(309, 28)
        Me.txtPhone.TabIndex = 629
        Me.txtPhone.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkOrange
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1047, 76)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 32)
        Me.Button1.TabIndex = 625
        Me.Button1.Text = "Fuel Sale Search"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnTransect
        '
        Me.btnTransect.BackColor = System.Drawing.Color.DarkOrange
        Me.btnTransect.BackgroundImage = CType(resources.GetObject("btnTransect.BackgroundImage"), System.Drawing.Image)
        Me.btnTransect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransect.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransect.ForeColor = System.Drawing.Color.White
        Me.btnTransect.Image = CType(resources.GetObject("btnTransect.Image"), System.Drawing.Image)
        Me.btnTransect.Location = New System.Drawing.Point(847, 76)
        Me.btnTransect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnTransect.Name = "btnTransect"
        Me.btnTransect.Size = New System.Drawing.Size(194, 32)
        Me.btnTransect.TabIndex = 620
        Me.btnTransect.Text = "Save Sale"
        Me.btnTransect.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackgroundImage = CType(resources.GetObject("btnHome.BackgroundImage"), System.Drawing.Image)
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHome.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Image = CType(resources.GetObject("btnHome.Image"), System.Drawing.Image)
        Me.btnHome.Location = New System.Drawing.Point(1048, 205)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(181, 32)
        Me.btnHome.TabIndex = 624
        Me.btnHome.Text = "Main Menu"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.BackgroundImage = CType(resources.GetObject("btnClear.BackgroundImage"), System.Drawing.Image)
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.Location = New System.Drawing.Point(1048, 142)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(181, 32)
        Me.btnClear.TabIndex = 623
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DarkOrange
        Me.btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), System.Drawing.Image)
        Me.btnDelete.Enabled = False
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(847, 205)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(194, 32)
        Me.btnDelete.TabIndex = 621
        Me.btnDelete.Text = "Delete Sale"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DarkOrange
        Me.btnUpdate.BackgroundImage = CType(resources.GetObject("btnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.Location = New System.Drawing.Point(847, 142)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(194, 32)
        Me.btnUpdate.TabIndex = 622
        Me.btnUpdate.Text = "Update Sale Details"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkGray
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(866, 244)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(350, 183)
        Me.PictureBox1.TabIndex = 626
        Me.PictureBox1.TabStop = False
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 564)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtValid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHidProduct)
        Me.Controls.Add(Me.txtHidLitres)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPin)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtLitres)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSaleID)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtAlias)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.txtRegDat)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.cmbProduct)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnTransect)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmSales"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtValid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtHidProduct As System.Windows.Forms.TextBox
    Friend WithEvents txtHidLitres As System.Windows.Forms.TextBox
    Friend WithEvents TimerSet As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPin As System.Windows.Forms.TextBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtLitres As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSaleID As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtAlias As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtRegDat As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbProduct As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnTransect As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
