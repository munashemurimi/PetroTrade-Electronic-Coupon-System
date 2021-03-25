<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuelStocks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFuelStocks))
        Me.txtHidProduct = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBalDie = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRegDat = New System.Windows.Forms.TextBox()
        Me.txtHidLitres = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBalPet = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLitres = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNewBal = New System.Windows.Forms.TextBox()
        Me.txtAddr = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TimerSet = New System.Windows.Forms.Timer(Me.components)
        Me.txtSaleID = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.cmbProduct = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtStatID = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnTransect = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtHidProduct
        '
        Me.txtHidProduct.BackColor = System.Drawing.Color.White
        Me.txtHidProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHidProduct.Enabled = False
        Me.txtHidProduct.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHidProduct.Location = New System.Drawing.Point(520, 497)
        Me.txtHidProduct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHidProduct.MaxLength = 15
        Me.txtHidProduct.Name = "txtHidProduct"
        Me.txtHidProduct.Size = New System.Drawing.Size(117, 24)
        Me.txtHidProduct.TabIndex = 688
        Me.txtHidProduct.TabStop = False
        Me.txtHidProduct.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(517, 479)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 15)
        Me.Label2.TabIndex = 689
        Me.Label2.Text = "Hidden Fuel"
        Me.Label2.Visible = False
        '
        'txtBalDie
        '
        Me.txtBalDie.BackColor = System.Drawing.Color.White
        Me.txtBalDie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBalDie.Enabled = False
        Me.txtBalDie.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalDie.Location = New System.Drawing.Point(288, 152)
        Me.txtBalDie.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBalDie.MaxLength = 15
        Me.txtBalDie.Name = "txtBalDie"
        Me.txtBalDie.Size = New System.Drawing.Size(154, 28)
        Me.txtBalDie.TabIndex = 687
        Me.txtBalDie.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(286, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 15)
        Me.Label7.TabIndex = 686
        Me.Label7.Text = "Current  Fuel Balance Diesel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(489, 304)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 15)
        Me.Label3.TabIndex = 684
        Me.Label3.Text = "Date Registered"
        '
        'txtRegDat
        '
        Me.txtRegDat.BackColor = System.Drawing.Color.White
        Me.txtRegDat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRegDat.Enabled = False
        Me.txtRegDat.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegDat.Location = New System.Drawing.Point(492, 322)
        Me.txtRegDat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRegDat.MaxLength = 15
        Me.txtRegDat.Name = "txtRegDat"
        Me.txtRegDat.Size = New System.Drawing.Size(309, 28)
        Me.txtRegDat.TabIndex = 685
        Me.txtRegDat.TabStop = False
        '
        'txtHidLitres
        '
        Me.txtHidLitres.BackColor = System.Drawing.Color.White
        Me.txtHidLitres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHidLitres.Enabled = False
        Me.txtHidLitres.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHidLitres.Location = New System.Drawing.Point(643, 497)
        Me.txtHidLitres.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHidLitres.MaxLength = 15
        Me.txtHidLitres.Name = "txtHidLitres"
        Me.txtHidLitres.Size = New System.Drawing.Size(117, 24)
        Me.txtHidLitres.TabIndex = 682
        Me.txtHidLitres.TabStop = False
        Me.txtHidLitres.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(640, 479)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 683
        Me.Label1.Text = "Hidden Litres"
        Me.Label1.Visible = False
        '
        'txtBalPet
        '
        Me.txtBalPet.BackColor = System.Drawing.Color.White
        Me.txtBalPet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBalPet.Enabled = False
        Me.txtBalPet.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalPet.Location = New System.Drawing.Point(128, 152)
        Me.txtBalPet.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBalPet.MaxLength = 15
        Me.txtBalPet.Name = "txtBalPet"
        Me.txtBalPet.Size = New System.Drawing.Size(154, 28)
        Me.txtBalPet.TabIndex = 681
        Me.txtBalPet.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(126, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 15)
        Me.Label9.TabIndex = 680
        Me.Label9.Text = "Current  Fuel Balance Petrol"
        '
        'txtLitres
        '
        Me.txtLitres.BackColor = System.Drawing.Color.White
        Me.txtLitres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLitres.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLitres.Location = New System.Drawing.Point(490, 152)
        Me.txtLitres.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLitres.MaxLength = 15
        Me.txtLitres.Name = "txtLitres"
        Me.txtLitres.Size = New System.Drawing.Size(307, 28)
        Me.txtLitres.TabIndex = 679
        Me.txtLitres.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(488, 134)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(122, 15)
        Me.Label14.TabIndex = 678
        Me.Label14.Text = "Total Purchased Litres"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(489, 227)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(276, 15)
        Me.Label12.TabIndex = 676
        Me.Label12.Text = "Total Selected Fuel Balance After Stock Add (Litres)"
        '
        'txtNewBal
        '
        Me.txtNewBal.BackColor = System.Drawing.Color.White
        Me.txtNewBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewBal.Enabled = False
        Me.txtNewBal.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewBal.Location = New System.Drawing.Point(492, 245)
        Me.txtNewBal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNewBal.MaxLength = 15
        Me.txtNewBal.Name = "txtNewBal"
        Me.txtNewBal.Size = New System.Drawing.Size(309, 28)
        Me.txtNewBal.TabIndex = 677
        Me.txtNewBal.TabStop = False
        '
        'txtAddr
        '
        Me.txtAddr.BackColor = System.Drawing.Color.White
        Me.txtAddr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddr.Enabled = False
        Me.txtAddr.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddr.Location = New System.Drawing.Point(127, 245)
        Me.txtAddr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAddr.MaxLength = 29
        Me.txtAddr.Multiline = True
        Me.txtAddr.Name = "txtAddr"
        Me.txtAddr.Size = New System.Drawing.Size(310, 105)
        Me.txtAddr.TabIndex = 673
        Me.txtAddr.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Goldenrod
        Me.PictureBox3.Location = New System.Drawing.Point(-2, -16)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(29, 615)
        Me.PictureBox3.TabIndex = 670
        Me.PictureBox3.TabStop = False
        '
        'TimerSet
        '
        '
        'txtSaleID
        '
        Me.txtSaleID.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSaleID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaleID.Enabled = False
        Me.txtSaleID.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaleID.Location = New System.Drawing.Point(1055, 31)
        Me.txtSaleID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSaleID.MaxLength = 15
        Me.txtSaleID.Name = "txtSaleID"
        Me.txtSaleID.Size = New System.Drawing.Size(194, 24)
        Me.txtSaleID.TabIndex = 675
        Me.txtSaleID.TabStop = False
        Me.txtSaleID.Text = "54646646"
        Me.txtSaleID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(125, 226)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(126, 15)
        Me.Label13.TabIndex = 672
        Me.Label13.Text = "Service Station Address"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Green
        Me.PictureBox4.Location = New System.Drawing.Point(1325, 31)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(34, 504)
        Me.PictureBox4.TabIndex = 671
        Me.PictureBox4.TabStop = False
        '
        'cmbProduct
        '
        Me.cmbProduct.BackColor = System.Drawing.Color.White
        Me.cmbProduct.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProduct.FormattingEnabled = True
        Me.cmbProduct.Items.AddRange(New Object() {"Petrol", "Diesel"})
        Me.cmbProduct.Location = New System.Drawing.Point(491, 79)
        Me.cmbProduct.Name = "cmbProduct"
        Me.cmbProduct.Size = New System.Drawing.Size(309, 29)
        Me.cmbProduct.TabIndex = 669
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(489, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 15)
        Me.Label8.TabIndex = 668
        Me.Label8.Text = "Select Fuel Product Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(124, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 15)
        Me.Label6.TabIndex = 666
        Me.Label6.Text = "Service Station ID"
        '
        'txtStatID
        '
        Me.txtStatID.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtStatID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStatID.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatID.ForeColor = System.Drawing.Color.White
        Me.txtStatID.Location = New System.Drawing.Point(128, 81)
        Me.txtStatID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStatID.MaxLength = 10
        Me.txtStatID.Name = "txtStatID"
        Me.txtStatID.Size = New System.Drawing.Size(309, 28)
        Me.txtStatID.TabIndex = 667
        Me.txtStatID.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DarkGray
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(182, 380)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(217, 114)
        Me.PictureBox2.TabIndex = 665
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkOrange
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1054, 79)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 32)
        Me.Button1.TabIndex = 663
        Me.Button1.Text = "Search Addition"
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
        Me.btnTransect.Location = New System.Drawing.Point(838, 79)
        Me.btnTransect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnTransect.Name = "btnTransect"
        Me.btnTransect.Size = New System.Drawing.Size(210, 32)
        Me.btnTransect.TabIndex = 659
        Me.btnTransect.Text = "Save Stock Addition"
        Me.btnTransect.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackgroundImage = CType(resources.GetObject("btnHome.BackgroundImage"), System.Drawing.Image)
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHome.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Image = CType(resources.GetObject("btnHome.Image"), System.Drawing.Image)
        Me.btnHome.Location = New System.Drawing.Point(1055, 208)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(194, 32)
        Me.btnHome.TabIndex = 662
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
        Me.btnClear.Location = New System.Drawing.Point(1055, 145)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(194, 32)
        Me.btnClear.TabIndex = 661
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
        Me.btnDelete.Location = New System.Drawing.Point(838, 145)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(210, 32)
        Me.btnDelete.TabIndex = 660
        Me.btnDelete.Text = "Delete Stock Details"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkGray
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(838, 248)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(411, 224)
        Me.PictureBox1.TabIndex = 664
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1064, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 18)
        Me.Label4.TabIndex = 674
        Me.Label4.Text = "Stock Transection Number"
        '
        'frmFuelStocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 564)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtHidProduct)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBalDie)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRegDat)
        Me.Controls.Add(Me.txtHidLitres)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBalPet)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtLitres)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNewBal)
        Me.Controls.Add(Me.txtAddr)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.txtSaleID)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.cmbProduct)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtStatID)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnTransect)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmFuelStocks"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHidProduct As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBalDie As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRegDat As System.Windows.Forms.TextBox
    Friend WithEvents txtHidLitres As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBalPet As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtLitres As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNewBal As System.Windows.Forms.TextBox
    Friend WithEvents txtAddr As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents TimerSet As System.Windows.Forms.Timer
    Friend WithEvents txtSaleID As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbProduct As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtStatID As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnTransect As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
