<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcreateaccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcreateaccount))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboposition = New System.Windows.Forms.ComboBox()
        Me.lblposition = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtconfirmpassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnsignup = New System.Windows.Forms.Button()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(1138, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 43)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "x"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 25.81132!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(73, 400)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(329, 102)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "POS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Inventory System"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label4.Location = New System.Drawing.Point(98, 557)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(282, 46)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Welcome ! Please fill up the text box " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to create your account"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cboposition)
        Me.GroupBox1.Controls.Add(Me.lblposition)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtconfirmpassword)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnsignup)
        Me.GroupBox1.Controls.Add(Me.lblpassword)
        Me.GroupBox1.Controls.Add(Me.txtpassword)
        Me.GroupBox1.Controls.Add(Me.lblusername)
        Me.GroupBox1.Controls.Add(Me.txtusername)
        Me.GroupBox1.Location = New System.Drawing.Point(494, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(620, 672)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'cboposition
        '
        Me.cboposition.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.cboposition.FormattingEnabled = True
        Me.cboposition.Items.AddRange(New Object() {"Cashier", "Admin", "Manager"})
        Me.cboposition.Location = New System.Drawing.Point(98, 484)
        Me.cboposition.Name = "cboposition"
        Me.cboposition.Size = New System.Drawing.Size(433, 21)
        Me.cboposition.TabIndex = 26
        Me.cboposition.UseWaitCursor = True
        '
        'lblposition
        '
        Me.lblposition.AutoSize = True
        Me.lblposition.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblposition.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblposition.Location = New System.Drawing.Point(94, 434)
        Me.lblposition.Name = "lblposition"
        Me.lblposition.Size = New System.Drawing.Size(73, 24)
        Me.lblposition.TabIndex = 25
        Me.lblposition.Text = "Position"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Location = New System.Drawing.Point(94, 342)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 24)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Confirm Password"
        '
        'txtconfirmpassword
        '
        Me.txtconfirmpassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtconfirmpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconfirmpassword.Location = New System.Drawing.Point(98, 377)
        Me.txtconfirmpassword.Multiline = True
        Me.txtconfirmpassword.Name = "txtconfirmpassword"
        Me.txtconfirmpassword.Size = New System.Drawing.Size(433, 37)
        Me.txtconfirmpassword.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(256, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 49)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Sign up"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnsignup
        '
        Me.btnsignup.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.btnsignup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsignup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsignup.Font = New System.Drawing.Font("Palatino Linotype", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsignup.Location = New System.Drawing.Point(98, 552)
        Me.btnsignup.Name = "btnsignup"
        Me.btnsignup.Size = New System.Drawing.Size(433, 37)
        Me.btnsignup.TabIndex = 21
        Me.btnsignup.Text = "Sign up"
        Me.btnsignup.UseVisualStyleBackColor = False
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassword.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblpassword.Location = New System.Drawing.Point(94, 250)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(84, 24)
        Me.lblpassword.TabIndex = 16
        Me.lblpassword.Text = "Password"
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(98, 285)
        Me.txtpassword.Multiline = True
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(433, 37)
        Me.txtpassword.TabIndex = 15
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblusername.Location = New System.Drawing.Point(94, 156)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(100, 24)
        Me.lblusername.TabIndex = 14
        Me.lblusername.Text = "User Name"
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(98, 194)
        Me.txtusername.Multiline = True
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(433, 37)
        Me.txtusername.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(115, 140)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(234, 195)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'frmcreateaccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1192, 769)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmcreateaccount"
        Me.Text = "frmcreateaccount"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnsignup As Button
    Friend WithEvents lblpassword As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents lblusername As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtconfirmpassword As TextBox
    Friend WithEvents lblposition As Label
    Friend WithEvents cboposition As ComboBox
End Class
