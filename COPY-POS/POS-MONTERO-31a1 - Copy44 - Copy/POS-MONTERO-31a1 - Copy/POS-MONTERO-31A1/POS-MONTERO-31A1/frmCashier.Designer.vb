<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCashier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCashier))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lbltransactionNo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtstatus = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcrit = New System.Windows.Forms.TextBox()
        Me.txtquantity1 = New System.Windows.Forms.TextBox()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.txtprodname = New System.Windows.Forms.TextBox()
        Me.txtcode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnremoved = New System.Windows.Forms.Button()
        Me.btnpayment = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbodiscount = New System.Windows.Forms.ComboBox()
        Me.lblDisc = New System.Windows.Forms.Label()
        Me.lblVsales = New System.Windows.Forms.Label()
        Me.lblVAT = New System.Windows.Forms.Label()
        Me.lblRefNo = New System.Windows.Forms.Label()
        Me.lblMOP = New System.Windows.Forms.Label()
        Me.lblchange = New System.Windows.Forms.Label()
        Me.lblamountpaid = New System.Windows.Forms.Label()
        Me.lbltotalitems = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblcashier = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1177, 111)
        Me.Panel1.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 25.81132!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(434, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(332, 51)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Chromatic Charm"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 10.86792!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 22)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Transaction Number" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 10.86792!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 22)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Date and Time" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.BackColor = System.Drawing.Color.Transparent
        Me.lbldate.Font = New System.Drawing.Font("Palatino Linotype", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.Black
        Me.lbldate.Location = New System.Drawing.Point(196, 46)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(52, 21)
        Me.lbldate.TabIndex = 27
        Me.lbldate.Text = "******" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lbldate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.BackColor = System.Drawing.Color.Transparent
        Me.lbltime.Font = New System.Drawing.Font("Palatino Linotype", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.Black
        Me.lbltime.Location = New System.Drawing.Point(268, 46)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(52, 21)
        Me.lbltime.TabIndex = 28
        Me.lbltime.Text = "******" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lbltime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbltransactionNo
        '
        Me.lbltransactionNo.AutoSize = True
        Me.lbltransactionNo.BackColor = System.Drawing.Color.Transparent
        Me.lbltransactionNo.Font = New System.Drawing.Font("Palatino Linotype", 10.86792!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltransactionNo.ForeColor = System.Drawing.Color.Black
        Me.lbltransactionNo.Location = New System.Drawing.Point(196, 12)
        Me.lbltransactionNo.Name = "lbltransactionNo"
        Me.lbltransactionNo.Size = New System.Drawing.Size(58, 22)
        Me.lbltransactionNo.TabIndex = 29
        Me.lbltransactionNo.Text = "100000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lbltransactionNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Thistle
        Me.Panel2.Controls.Add(Me.lbltransactionNo)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lbltime)
        Me.Panel2.Controls.Add(Me.lbldate)
        Me.Panel2.Location = New System.Drawing.Point(410, 679)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(377, 78)
        Me.Panel2.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.30189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(1209, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 69)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "x"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Thistle
        Me.GroupBox1.Controls.Add(Me.lbltotal)
        Me.GroupBox1.Font = New System.Drawing.Font("Palatino Linotype", 10.86792!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(793, 679)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 78)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Grand Total"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Palatino Linotype", 16.30189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.Black
        Me.lbltotal.Location = New System.Drawing.Point(18, 30)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(60, 34)
        Me.lbltotal.TabIndex = 32
        Me.lbltotal.Text = "0.00"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Panel3.Controls.Add(Me.txtstatus)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txtcrit)
        Me.Panel3.Controls.Add(Me.txtquantity1)
        Me.Panel3.Controls.Add(Me.txtamount)
        Me.Panel3.Controls.Add(Me.txtprodname)
        Me.Panel3.Controls.Add(Me.txtcode)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(3, 122)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1177, 78)
        Me.Panel3.TabIndex = 28
        '
        'txtstatus
        '
        Me.txtstatus.AutoSize = True
        Me.txtstatus.BackColor = System.Drawing.Color.Transparent
        Me.txtstatus.Font = New System.Drawing.Font("Palatino Linotype", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstatus.ForeColor = System.Drawing.Color.White
        Me.txtstatus.Location = New System.Drawing.Point(937, 43)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(60, 26)
        Me.txtstatus.TabIndex = 38
        Me.txtstatus.Text = "******"
        Me.txtstatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 10.86792!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(937, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 22)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Status"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtcrit
        '
        Me.txtcrit.Location = New System.Drawing.Point(756, 35)
        Me.txtcrit.Multiline = True
        Me.txtcrit.Name = "txtcrit"
        Me.txtcrit.ReadOnly = True
        Me.txtcrit.Size = New System.Drawing.Size(148, 32)
        Me.txtcrit.TabIndex = 36
        '
        'txtquantity1
        '
        Me.txtquantity1.Location = New System.Drawing.Point(590, 35)
        Me.txtquantity1.Multiline = True
        Me.txtquantity1.Name = "txtquantity1"
        Me.txtquantity1.ReadOnly = True
        Me.txtquantity1.Size = New System.Drawing.Size(148, 32)
        Me.txtquantity1.TabIndex = 35
        '
        'txtamount
        '
        Me.txtamount.Location = New System.Drawing.Point(421, 35)
        Me.txtamount.Multiline = True
        Me.txtamount.Name = "txtamount"
        Me.txtamount.ReadOnly = True
        Me.txtamount.Size = New System.Drawing.Size(148, 32)
        Me.txtamount.TabIndex = 34
        '
        'txtprodname
        '
        Me.txtprodname.Location = New System.Drawing.Point(198, 35)
        Me.txtprodname.Multiline = True
        Me.txtprodname.Name = "txtprodname"
        Me.txtprodname.Size = New System.Drawing.Size(202, 32)
        Me.txtprodname.TabIndex = 33
        '
        'txtcode
        '
        Me.txtcode.Location = New System.Drawing.Point(11, 35)
        Me.txtcode.Multiline = True
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(164, 32)
        Me.txtcode.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 10.86792!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(757, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 22)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Critical Level"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 10.86792!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(592, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 22)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Quantity"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 10.86792!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(420, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 22)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Amount"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 10.86792!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(201, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 22)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Product Name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 10.86792!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(7, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 22)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Product Code"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.ListView1)
        Me.GroupBox2.Font = New System.Drawing.Font("Palatino Linotype", 10.86792!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 206)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(775, 467)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CART"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.Font = New System.Drawing.Font("Palatino Linotype", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(6, 19)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(763, 435)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Product Code"
        Me.ColumnHeader1.Width = 180
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Product Name"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Amount"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Quantity"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Sub Total"
        Me.ColumnHeader5.Width = 180
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.Thistle
        Me.btnadd.BackgroundImage = CType(resources.GetObject("btnadd.BackgroundImage"), System.Drawing.Image)
        Me.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnadd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadd.Font = New System.Drawing.Font("Palatino Linotype", 10.86792!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnadd.Location = New System.Drawing.Point(1209, 206)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 75)
        Me.btnadd.TabIndex = 33
        Me.btnadd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btnremoved
        '
        Me.btnremoved.BackColor = System.Drawing.Color.Thistle
        Me.btnremoved.BackgroundImage = CType(resources.GetObject("btnremoved.BackgroundImage"), System.Drawing.Image)
        Me.btnremoved.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnremoved.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnremoved.ForeColor = System.Drawing.SystemColors.Control
        Me.btnremoved.Location = New System.Drawing.Point(1209, 287)
        Me.btnremoved.Name = "btnremoved"
        Me.btnremoved.Size = New System.Drawing.Size(75, 75)
        Me.btnremoved.TabIndex = 34
        Me.btnremoved.UseVisualStyleBackColor = False
        '
        'btnpayment
        '
        Me.btnpayment.BackColor = System.Drawing.Color.Thistle
        Me.btnpayment.BackgroundImage = CType(resources.GetObject("btnpayment.BackgroundImage"), System.Drawing.Image)
        Me.btnpayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnpayment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpayment.ForeColor = System.Drawing.SystemColors.Control
        Me.btnpayment.Location = New System.Drawing.Point(1209, 370)
        Me.btnpayment.Name = "btnpayment"
        Me.btnpayment.Size = New System.Drawing.Size(75, 75)
        Me.btnpayment.TabIndex = 35
        Me.btnpayment.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Thistle
        Me.btnsave.BackgroundImage = CType(resources.GetObject("btnsave.BackgroundImage"), System.Drawing.Image)
        Me.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.ForeColor = System.Drawing.SystemColors.Control
        Me.btnsave.Location = New System.Drawing.Point(1209, 454)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 75)
        Me.btnsave.TabIndex = 36
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.Thistle
        Me.btncancel.BackgroundImage = CType(resources.GetObject("btncancel.BackgroundImage"), System.Drawing.Image)
        Me.btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancel.ForeColor = System.Drawing.SystemColors.Control
        Me.btncancel.Location = New System.Drawing.Point(1209, 538)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 75)
        Me.btncancel.TabIndex = 37
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.cbodiscount)
        Me.GroupBox3.Controls.Add(Me.lblDisc)
        Me.GroupBox3.Controls.Add(Me.lblVsales)
        Me.GroupBox3.Controls.Add(Me.lblVAT)
        Me.GroupBox3.Controls.Add(Me.lblRefNo)
        Me.GroupBox3.Controls.Add(Me.lblMOP)
        Me.GroupBox3.Controls.Add(Me.lblchange)
        Me.GroupBox3.Controls.Add(Me.lblamountpaid)
        Me.GroupBox3.Controls.Add(Me.lbltotalitems)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Panel4)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(793, 206)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(387, 467)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        '
        'cbodiscount
        '
        Me.cbodiscount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbodiscount.FormattingEnabled = True
        Me.cbodiscount.Items.AddRange(New Object() {"Senior CItizen", "PWD"})
        Me.cbodiscount.Location = New System.Drawing.Point(246, 405)
        Me.cbodiscount.Name = "cbodiscount"
        Me.cbodiscount.Size = New System.Drawing.Size(121, 21)
        Me.cbodiscount.TabIndex = 18
        '
        'lblDisc
        '
        Me.lblDisc.AutoSize = True
        Me.lblDisc.Font = New System.Drawing.Font("Palatino Linotype", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisc.ForeColor = System.Drawing.Color.Black
        Me.lblDisc.Location = New System.Drawing.Point(242, 357)
        Me.lblDisc.Name = "lblDisc"
        Me.lblDisc.Size = New System.Drawing.Size(47, 26)
        Me.lblDisc.TabIndex = 17
        Me.lblDisc.Text = "0.00"
        '
        'lblVsales
        '
        Me.lblVsales.AutoSize = True
        Me.lblVsales.Font = New System.Drawing.Font("Palatino Linotype", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVsales.ForeColor = System.Drawing.Color.Black
        Me.lblVsales.Location = New System.Drawing.Point(242, 315)
        Me.lblVsales.Name = "lblVsales"
        Me.lblVsales.Size = New System.Drawing.Size(47, 26)
        Me.lblVsales.TabIndex = 16
        Me.lblVsales.Text = "0.00"
        '
        'lblVAT
        '
        Me.lblVAT.AutoSize = True
        Me.lblVAT.Font = New System.Drawing.Font("Palatino Linotype", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVAT.ForeColor = System.Drawing.Color.Black
        Me.lblVAT.Location = New System.Drawing.Point(242, 274)
        Me.lblVAT.Name = "lblVAT"
        Me.lblVAT.Size = New System.Drawing.Size(47, 26)
        Me.lblVAT.TabIndex = 15
        Me.lblVAT.Text = "0.00"
        '
        'lblRefNo
        '
        Me.lblRefNo.AutoSize = True
        Me.lblRefNo.Font = New System.Drawing.Font("Palatino Linotype", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefNo.ForeColor = System.Drawing.Color.Black
        Me.lblRefNo.Location = New System.Drawing.Point(242, 200)
        Me.lblRefNo.Name = "lblRefNo"
        Me.lblRefNo.Size = New System.Drawing.Size(60, 26)
        Me.lblRefNo.TabIndex = 14
        Me.lblRefNo.Text = "******"
        '
        'lblMOP
        '
        Me.lblMOP.AutoSize = True
        Me.lblMOP.Font = New System.Drawing.Font("Palatino Linotype", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMOP.ForeColor = System.Drawing.Color.Black
        Me.lblMOP.Location = New System.Drawing.Point(242, 157)
        Me.lblMOP.Name = "lblMOP"
        Me.lblMOP.Size = New System.Drawing.Size(60, 26)
        Me.lblMOP.TabIndex = 13
        Me.lblMOP.Text = "******"
        '
        'lblchange
        '
        Me.lblchange.AutoSize = True
        Me.lblchange.Font = New System.Drawing.Font("Palatino Linotype", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchange.ForeColor = System.Drawing.Color.Black
        Me.lblchange.Location = New System.Drawing.Point(242, 109)
        Me.lblchange.Name = "lblchange"
        Me.lblchange.Size = New System.Drawing.Size(47, 26)
        Me.lblchange.TabIndex = 12
        Me.lblchange.Text = "0.00"
        '
        'lblamountpaid
        '
        Me.lblamountpaid.AutoSize = True
        Me.lblamountpaid.Font = New System.Drawing.Font("Palatino Linotype", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamountpaid.ForeColor = System.Drawing.Color.Black
        Me.lblamountpaid.Location = New System.Drawing.Point(242, 60)
        Me.lblamountpaid.Name = "lblamountpaid"
        Me.lblamountpaid.Size = New System.Drawing.Size(47, 26)
        Me.lblamountpaid.TabIndex = 11
        Me.lblamountpaid.Text = "0.00"
        '
        'lbltotalitems
        '
        Me.lbltotalitems.AutoSize = True
        Me.lbltotalitems.Font = New System.Drawing.Font("Palatino Linotype", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalitems.ForeColor = System.Drawing.Color.Black
        Me.lbltotalitems.Location = New System.Drawing.Point(242, 22)
        Me.lbltotalitems.Name = "lbltotalitems"
        Me.lbltotalitems.Size = New System.Drawing.Size(22, 26)
        Me.lbltotalitems.TabIndex = 10
        Me.lbltotalitems.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Palatino Linotype", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(19, 400)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(153, 26)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Discount Type :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Palatino Linotype", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(19, 357)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 26)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Discount :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Palatino Linotype", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(19, 315)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(180, 26)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Vat Amount(12%) :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Palatino Linotype", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(19, 274)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(141, 26)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Vatable Sales :"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 240)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(387, 20)
        Me.Panel4.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Palatino Linotype", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(18, 200)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(192, 26)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Reference Number :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Palatino Linotype", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(19, 157)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(181, 26)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Mode of Payment :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Palatino Linotype", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(18, 109)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(171, 26)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Amount Change :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(18, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(141, 26)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Amount Paid :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(18, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(210, 26)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Total Product(s) Sold :"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lblcashier)
        Me.Panel5.Controls.Add(Me.Label19)
        Me.Panel5.Location = New System.Drawing.Point(14, 679)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(390, 78)
        Me.Panel5.TabIndex = 39
        '
        'lblcashier
        '
        Me.lblcashier.AutoSize = True
        Me.lblcashier.Font = New System.Drawing.Font("Palatino Linotype", 14.26415!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcashier.ForeColor = System.Drawing.Color.White
        Me.lblcashier.Location = New System.Drawing.Point(217, 20)
        Me.lblcashier.Name = "lblcashier"
        Me.lblcashier.Size = New System.Drawing.Size(64, 28)
        Me.lblcashier.TabIndex = 20
        Me.lblcashier.Text = "Kitkit"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Palatino Linotype", 14.26415!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(27, 20)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(161, 28)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Cashier Name :"
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.Color.Thistle
        Me.btnlogout.BackgroundImage = CType(resources.GetObject("btnlogout.BackgroundImage"), System.Drawing.Image)
        Me.btnlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogout.ForeColor = System.Drawing.SystemColors.Control
        Me.btnlogout.Location = New System.Drawing.Point(1209, 673)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(75, 75)
        Me.btnlogout.TabIndex = 40
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(294, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(119, 108)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'frmPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1296, 769)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnpayment)
        Me.Controls.Add(Me.btnremoved)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPOS"
        Me.Text = "frmPOS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents lbltransactionNo As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbltotal As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcrit As TextBox
    Friend WithEvents txtquantity1 As TextBox
    Friend WithEvents txtamount As TextBox
    Friend WithEvents txtprodname As TextBox
    Friend WithEvents txtcode As TextBox
    Friend WithEvents txtstatus As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents btnadd As Button
    Friend WithEvents btnremoved As Button
    Friend WithEvents btnpayment As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbodiscount As ComboBox
    Friend WithEvents lblDisc As Label
    Friend WithEvents lblVsales As Label
    Friend WithEvents lblVAT As Label
    Friend WithEvents lblRefNo As Label
    Friend WithEvents lblMOP As Label
    Friend WithEvents lblchange As Label
    Friend WithEvents lblamountpaid As Label
    Friend WithEvents lbltotalitems As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblcashier As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents btnlogout As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox2 As PictureBox
End Class
