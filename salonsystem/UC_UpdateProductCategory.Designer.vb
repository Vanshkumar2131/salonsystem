﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_UpdateProductCategory
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_UpdateProductCategory))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbIdProductCat = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GunaLabel21 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel29 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel20 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Separator6 = New Guna.UI2.WinForms.Guna2Separator()
        Me.btnclear = New Guna.UI.WinForms.GunaButton()
        Me.btnadd = New Guna.UI.WinForms.GunaButton()
        Me.txtcatdesc = New Guna.UI.WinForms.GunaTextBox()
        Me.txtcatname = New Guna.UI.WinForms.GunaTextBox()
        Me.lbladdress = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel24 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel22 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel23 = New Guna.UI.WinForms.GunaLabel()
        Me.lblcustomer = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox4 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox5 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox6 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox7 = New Guna.UI.WinForms.GunaPictureBox()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox3 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.pcthairdrressing = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Panel1.SuspendLayout()
        CType(Me.GunaPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcthairdrressing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cmbIdProductCat)
        Me.Panel1.Controls.Add(Me.GunaLabel21)
        Me.Panel1.Controls.Add(Me.GunaLabel29)
        Me.Panel1.Controls.Add(Me.GunaLabel20)
        Me.Panel1.Controls.Add(Me.Guna2Separator6)
        Me.Panel1.Controls.Add(Me.btnclear)
        Me.Panel1.Controls.Add(Me.btnadd)
        Me.Panel1.Controls.Add(Me.txtcatdesc)
        Me.Panel1.Controls.Add(Me.txtcatname)
        Me.Panel1.Controls.Add(Me.lbladdress)
        Me.Panel1.Controls.Add(Me.GunaLabel24)
        Me.Panel1.Controls.Add(Me.GunaLabel22)
        Me.Panel1.Controls.Add(Me.GunaLabel23)
        Me.Panel1.Controls.Add(Me.lblcustomer)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 1003)
        Me.Panel1.TabIndex = 182
        '
        'cmbIdProductCat
        '
        Me.cmbIdProductCat.BackColor = System.Drawing.Color.Transparent
        Me.cmbIdProductCat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbIdProductCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdProductCat.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbIdProductCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbIdProductCat.FocusedState.Parent = Me.cmbIdProductCat
        Me.cmbIdProductCat.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbIdProductCat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbIdProductCat.HoverState.Parent = Me.cmbIdProductCat
        Me.cmbIdProductCat.ItemHeight = 30
        Me.cmbIdProductCat.ItemsAppearance.Parent = Me.cmbIdProductCat
        Me.cmbIdProductCat.Location = New System.Drawing.Point(395, 104)
        Me.cmbIdProductCat.Name = "cmbIdProductCat"
        Me.cmbIdProductCat.ShadowDecoration.Parent = Me.cmbIdProductCat
        Me.cmbIdProductCat.Size = New System.Drawing.Size(300, 36)
        Me.cmbIdProductCat.TabIndex = 147
        '
        'GunaLabel21
        '
        Me.GunaLabel21.AutoSize = True
        Me.GunaLabel21.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel21.ForeColor = System.Drawing.Color.Red
        Me.GunaLabel21.Location = New System.Drawing.Point(279, 179)
        Me.GunaLabel21.Name = "GunaLabel21"
        Me.GunaLabel21.Size = New System.Drawing.Size(32, 39)
        Me.GunaLabel21.TabIndex = 145
        Me.GunaLabel21.Text = "*"
        '
        'GunaLabel29
        '
        Me.GunaLabel29.AutoSize = True
        Me.GunaLabel29.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel29.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel29.Location = New System.Drawing.Point(321, 270)
        Me.GunaLabel29.Name = "GunaLabel29"
        Me.GunaLabel29.Size = New System.Drawing.Size(53, 39)
        Me.GunaLabel29.TabIndex = 144
        Me.GunaLabel29.Text = " : "
        '
        'GunaLabel20
        '
        Me.GunaLabel20.AutoSize = True
        Me.GunaLabel20.Font = New System.Drawing.Font("Algerian", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel20.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel20.Location = New System.Drawing.Point(95, 17)
        Me.GunaLabel20.Name = "GunaLabel20"
        Me.GunaLabel20.Size = New System.Drawing.Size(585, 45)
        Me.GunaLabel20.TabIndex = 143
        Me.GunaLabel20.Text = "update Product Category"
        '
        'Guna2Separator6
        '
        Me.Guna2Separator6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator6.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator6.FillStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.Guna2Separator6.FillThickness = 8
        Me.Guna2Separator6.Location = New System.Drawing.Point(-1, 71)
        Me.Guna2Separator6.Name = "Guna2Separator6"
        Me.Guna2Separator6.Size = New System.Drawing.Size(834, 10)
        Me.Guna2Separator6.TabIndex = 142
        '
        'btnclear
        '
        Me.btnclear.AnimationHoverSpeed = 0.07!
        Me.btnclear.AnimationSpeed = 0.03!
        Me.btnclear.BaseColor = System.Drawing.Color.Transparent
        Me.btnclear.BorderColor = System.Drawing.Color.Black
        Me.btnclear.BorderSize = 2
        Me.btnclear.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnclear.FocusedColor = System.Drawing.Color.Empty
        Me.btnclear.Font = New System.Drawing.Font("Algerian", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.Black
        Me.btnclear.Image = Nothing
        Me.btnclear.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnclear.Location = New System.Drawing.Point(447, 508)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.OnHoverBaseColor = System.Drawing.Color.Black
        Me.btnclear.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnclear.OnHoverForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnclear.OnHoverImage = Nothing
        Me.btnclear.OnPressedColor = System.Drawing.Color.Black
        Me.btnclear.Size = New System.Drawing.Size(248, 67)
        Me.btnclear.TabIndex = 9
        Me.btnclear.Text = "Clear Data"
        Me.btnclear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnadd
        '
        Me.btnadd.AnimationHoverSpeed = 0.07!
        Me.btnadd.AnimationSpeed = 0.03!
        Me.btnadd.BaseColor = System.Drawing.Color.Transparent
        Me.btnadd.BorderColor = System.Drawing.Color.Black
        Me.btnadd.BorderSize = 2
        Me.btnadd.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnadd.FocusedColor = System.Drawing.Color.Empty
        Me.btnadd.Font = New System.Drawing.Font("Algerian", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.Black
        Me.btnadd.Image = Nothing
        Me.btnadd.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnadd.Location = New System.Drawing.Point(36, 508)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.OnHoverBaseColor = System.Drawing.Color.Black
        Me.btnadd.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnadd.OnHoverForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnadd.OnHoverImage = Nothing
        Me.btnadd.OnPressedColor = System.Drawing.Color.Black
        Me.btnadd.Size = New System.Drawing.Size(316, 67)
        Me.btnadd.TabIndex = 8
        Me.btnadd.Text = "update category"
        Me.btnadd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcatdesc
        '
        Me.txtcatdesc.BaseColor = System.Drawing.Color.White
        Me.txtcatdesc.BorderColor = System.Drawing.Color.Black
        Me.txtcatdesc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcatdesc.FocusedBaseColor = System.Drawing.Color.White
        Me.txtcatdesc.FocusedBorderColor = System.Drawing.Color.Blue
        Me.txtcatdesc.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtcatdesc.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcatdesc.ForeColor = System.Drawing.Color.Black
        Me.txtcatdesc.Location = New System.Drawing.Point(395, 270)
        Me.txtcatdesc.Multiline = True
        Me.txtcatdesc.Name = "txtcatdesc"
        Me.txtcatdesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcatdesc.SelectedText = ""
        Me.txtcatdesc.Size = New System.Drawing.Size(300, 157)
        Me.txtcatdesc.TabIndex = 7
        '
        'txtcatname
        '
        Me.txtcatname.BaseColor = System.Drawing.Color.White
        Me.txtcatname.BorderColor = System.Drawing.Color.Black
        Me.txtcatname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcatname.FocusedBaseColor = System.Drawing.Color.White
        Me.txtcatname.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcatname.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtcatname.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcatname.ForeColor = System.Drawing.Color.Black
        Me.txtcatname.Location = New System.Drawing.Point(395, 174)
        Me.txtcatname.Name = "txtcatname"
        Me.txtcatname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcatname.SelectedText = ""
        Me.txtcatname.Size = New System.Drawing.Size(300, 41)
        Me.txtcatname.TabIndex = 1
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdress.ForeColor = System.Drawing.Color.Black
        Me.lbladdress.Location = New System.Drawing.Point(51, 265)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(168, 39)
        Me.lbladdress.TabIndex = 129
        Me.lbladdress.Text = "Description"
        '
        'GunaLabel24
        '
        Me.GunaLabel24.AutoSize = True
        Me.GunaLabel24.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel24.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel24.Location = New System.Drawing.Point(47, 174)
        Me.GunaLabel24.Name = "GunaLabel24"
        Me.GunaLabel24.Size = New System.Drawing.Size(226, 39)
        Me.GunaLabel24.TabIndex = 124
        Me.GunaLabel24.Text = "Category Name"
        '
        'GunaLabel22
        '
        Me.GunaLabel22.AutoSize = True
        Me.GunaLabel22.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel22.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel22.Location = New System.Drawing.Point(321, 101)
        Me.GunaLabel22.Name = "GunaLabel22"
        Me.GunaLabel22.Size = New System.Drawing.Size(53, 39)
        Me.GunaLabel22.TabIndex = 123
        Me.GunaLabel22.Text = " : "
        '
        'GunaLabel23
        '
        Me.GunaLabel23.AutoSize = True
        Me.GunaLabel23.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel23.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel23.Location = New System.Drawing.Point(321, 176)
        Me.GunaLabel23.Name = "GunaLabel23"
        Me.GunaLabel23.Size = New System.Drawing.Size(53, 39)
        Me.GunaLabel23.TabIndex = 123
        Me.GunaLabel23.Text = " : "
        '
        'lblcustomer
        '
        Me.lblcustomer.AutoSize = True
        Me.lblcustomer.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustomer.ForeColor = System.Drawing.Color.Black
        Me.lblcustomer.Location = New System.Drawing.Point(47, 99)
        Me.lblcustomer.Name = "lblcustomer"
        Me.lblcustomer.Size = New System.Drawing.Size(226, 39)
        Me.lblcustomer.TabIndex = 123
        Me.lblcustomer.Text = "Category Name"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel7.Location = New System.Drawing.Point(1524, 918)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(251, 70)
        Me.GunaLabel7.TabIndex = 211
        Me.GunaLabel7.Text = "Urban Gabru " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Charcoal Face Wash"
        Me.GunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaPictureBox4
        '
        Me.GunaPictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox4.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GunaPictureBox4.Image = CType(resources.GetObject("GunaPictureBox4.Image"), System.Drawing.Image)
        Me.GunaPictureBox4.Location = New System.Drawing.Point(1538, 627)
        Me.GunaPictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GunaPictureBox4.Name = "GunaPictureBox4"
        Me.GunaPictureBox4.Size = New System.Drawing.Size(220, 280)
        Me.GunaPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox4.TabIndex = 210
        Me.GunaPictureBox4.TabStop = False
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel8.Location = New System.Drawing.Point(1302, 915)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(220, 70)
        Me.GunaLabel8.TabIndex = 209
        Me.GunaLabel8.Text = "Urban Gabru Clay" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hair Wax"
        Me.GunaLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaPictureBox5
        '
        Me.GunaPictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox5.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GunaPictureBox5.Image = CType(resources.GetObject("GunaPictureBox5.Image"), System.Drawing.Image)
        Me.GunaPictureBox5.Location = New System.Drawing.Point(1298, 627)
        Me.GunaPictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GunaPictureBox5.Name = "GunaPictureBox5"
        Me.GunaPictureBox5.Size = New System.Drawing.Size(220, 280)
        Me.GunaPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox5.TabIndex = 208
        Me.GunaPictureBox5.TabStop = False
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel9.Location = New System.Drawing.Point(1050, 919)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(224, 70)
        Me.GunaLabel9.TabIndex = 207
        Me.GunaLabel9.Text = "Urban Gabru Red " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Onion Shampoo"
        Me.GunaLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaPictureBox6
        '
        Me.GunaPictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox6.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GunaPictureBox6.Image = CType(resources.GetObject("GunaPictureBox6.Image"), System.Drawing.Image)
        Me.GunaPictureBox6.Location = New System.Drawing.Point(1051, 627)
        Me.GunaPictureBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GunaPictureBox6.Name = "GunaPictureBox6"
        Me.GunaPictureBox6.Size = New System.Drawing.Size(220, 280)
        Me.GunaPictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox6.TabIndex = 206
        Me.GunaPictureBox6.TabStop = False
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Gill Sans MT Condensed", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel10.Location = New System.Drawing.Point(1206, 550)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(215, 60)
        Me.GunaLabel10.TabIndex = 205
        Me.GunaLabel10.Text = "Urban Gabru"
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel11.Location = New System.Drawing.Point(836, 918)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(172, 70)
        Me.GunaLabel11.TabIndex = 204
        Me.GunaLabel11.Text = "Urban Gabru " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hair Mask"
        Me.GunaLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaPictureBox7
        '
        Me.GunaPictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox7.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GunaPictureBox7.Image = CType(resources.GetObject("GunaPictureBox7.Image"), System.Drawing.Image)
        Me.GunaPictureBox7.Location = New System.Drawing.Point(809, 627)
        Me.GunaPictureBox7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GunaPictureBox7.Name = "GunaPictureBox7"
        Me.GunaPictureBox7.Size = New System.Drawing.Size(220, 280)
        Me.GunaPictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox7.TabIndex = 203
        Me.GunaPictureBox7.TabStop = False
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator2.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator2.FillStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Separator2.FillThickness = 8
        Me.Guna2Separator2.Location = New System.Drawing.Point(807, 537)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(1161, 10)
        Me.Guna2Separator2.TabIndex = 202
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel6.Location = New System.Drawing.Point(1563, 443)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(204, 70)
        Me.GunaLabel6.TabIndex = 201
        Me.GunaLabel6.Text = "Beardo Charcoal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Body Wash"
        Me.GunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaPictureBox3
        '
        Me.GunaPictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox3.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GunaPictureBox3.Image = CType(resources.GetObject("GunaPictureBox3.Image"), System.Drawing.Image)
        Me.GunaPictureBox3.Location = New System.Drawing.Point(1547, 149)
        Me.GunaPictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GunaPictureBox3.Name = "GunaPictureBox3"
        Me.GunaPictureBox3.Size = New System.Drawing.Size(220, 280)
        Me.GunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.GunaPictureBox3.TabIndex = 200
        Me.GunaPictureBox3.TabStop = False
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel5.Location = New System.Drawing.Point(1320, 443)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(204, 70)
        Me.GunaLabel5.TabIndex = 199
        Me.GunaLabel5.Text = "Beardo Charcoal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Face Scrub"
        Me.GunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GunaPictureBox2.Image = CType(resources.GetObject("GunaPictureBox2.Image"), System.Drawing.Image)
        Me.GunaPictureBox2.Location = New System.Drawing.Point(1307, 149)
        Me.GunaPictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(220, 280)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox2.TabIndex = 198
        Me.GunaPictureBox2.TabStop = False
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel3.Location = New System.Drawing.Point(1095, 442)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(174, 70)
        Me.GunaLabel3.TabIndex = 197
        Me.GunaLabel3.Text = "Beardo Hair " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Building Fiber"
        Me.GunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(1060, 149)
        Me.GunaPictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(220, 280)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.GunaPictureBox1.TabIndex = 196
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Gill Sans MT Condensed", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel2.Location = New System.Drawing.Point(1222, 81)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(126, 60)
        Me.GunaLabel2.TabIndex = 195
        Me.GunaLabel2.Text = "Beardo"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel4.Location = New System.Drawing.Point(840, 441)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(182, 70)
        Me.GunaLabel4.TabIndex = 194
        Me.GunaLabel4.Text = "Beardo Beard " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Softner"
        Me.GunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pcthairdrressing
        '
        Me.pcthairdrressing.BackColor = System.Drawing.Color.Transparent
        Me.pcthairdrressing.BaseColor = System.Drawing.Color.White
        Me.pcthairdrressing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcthairdrressing.Image = CType(resources.GetObject("pcthairdrressing.Image"), System.Drawing.Image)
        Me.pcthairdrressing.Location = New System.Drawing.Point(817, 149)
        Me.pcthairdrressing.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pcthairdrressing.Name = "pcthairdrressing"
        Me.pcthairdrressing.Size = New System.Drawing.Size(220, 280)
        Me.pcthairdrressing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pcthairdrressing.TabIndex = 193
        Me.pcthairdrressing.TabStop = False
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Algerian", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel1.Location = New System.Drawing.Point(881, 18)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(788, 45)
        Me.GunaLabel1.TabIndex = 192
        Me.GunaLabel1.Text = "Famous Brands with their Porducts"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator1.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator1.FillStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.Guna2Separator1.FillThickness = 8
        Me.Guna2Separator1.Location = New System.Drawing.Point(702, 72)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(1145, 10)
        Me.Guna2Separator1.TabIndex = 191
        '
        'UC_UpdateProductCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.GunaPictureBox4)
        Me.Controls.Add(Me.GunaLabel8)
        Me.Controls.Add(Me.GunaPictureBox5)
        Me.Controls.Add(Me.GunaLabel9)
        Me.Controls.Add(Me.GunaPictureBox6)
        Me.Controls.Add(Me.GunaLabel10)
        Me.Controls.Add(Me.GunaLabel11)
        Me.Controls.Add(Me.GunaPictureBox7)
        Me.Controls.Add(Me.Guna2Separator2)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.GunaPictureBox3)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaPictureBox2)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.pcthairdrressing)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "UC_UpdateProductCategory"
        Me.Size = New System.Drawing.Size(1783, 1003)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GunaPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcthairdrressing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaLabel21 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel29 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel20 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Separator6 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents btnclear As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnadd As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtcatdesc As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtcatname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lbladdress As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel24 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel22 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel23 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblcustomer As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cmbIdProductCat As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox4 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox5 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox6 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox7 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox3 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents pcthairdrressing As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
End Class
