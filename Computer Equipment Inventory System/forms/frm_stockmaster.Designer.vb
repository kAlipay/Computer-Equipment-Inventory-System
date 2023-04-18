<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_stockmaster
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
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnl_stockmaster = New System.Windows.Forms.Panel()
        Me.txtitemid = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbounit = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.txtdescription = New System.Windows.Forms.RichTextBox()
        Me.cbotype = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtglist = New System.Windows.Forms.DataGridView()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnfirst = New System.Windows.Forms.Button()
        Me.btnprev = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnlast = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblinc = New System.Windows.Forms.Label()
        Me.lblmax = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnl_stockmaster.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dtglist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.BurlyWood
        Me.txtname.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(153, 76)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(252, 22)
        Me.txtname.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.BurlyWood
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Item Name ::"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.BurlyWood
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description ::"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.BurlyWood
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(79, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Category ::"
        '
        'txtprice
        '
        Me.txtprice.BackColor = System.Drawing.Color.BurlyWood
        Me.txtprice.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.Location = New System.Drawing.Point(154, 208)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(250, 22)
        Me.txtprice.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.BurlyWood
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(103, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Price ::"
        '
        'pnl_stockmaster
        '
        Me.pnl_stockmaster.BackColor = System.Drawing.Color.BurlyWood
        Me.pnl_stockmaster.Controls.Add(Me.txtitemid)
        Me.pnl_stockmaster.Controls.Add(Me.Label8)
        Me.pnl_stockmaster.Controls.Add(Me.cbounit)
        Me.pnl_stockmaster.Controls.Add(Me.Label7)
        Me.pnl_stockmaster.Controls.Add(Me.txtqty)
        Me.pnl_stockmaster.Controls.Add(Me.txtdescription)
        Me.pnl_stockmaster.Controls.Add(Me.cbotype)
        Me.pnl_stockmaster.Controls.Add(Me.txtname)
        Me.pnl_stockmaster.Controls.Add(Me.Label4)
        Me.pnl_stockmaster.Controls.Add(Me.Label3)
        Me.pnl_stockmaster.Controls.Add(Me.txtprice)
        Me.pnl_stockmaster.Controls.Add(Me.Label2)
        Me.pnl_stockmaster.Controls.Add(Me.Label1)
        Me.pnl_stockmaster.Controls.Add(Me.Label5)
        Me.pnl_stockmaster.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_stockmaster.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_stockmaster.Location = New System.Drawing.Point(0, 0)
        Me.pnl_stockmaster.Name = "pnl_stockmaster"
        Me.pnl_stockmaster.Size = New System.Drawing.Size(564, 282)
        Me.pnl_stockmaster.TabIndex = 2
        '
        'txtitemid
        '
        Me.txtitemid.BackColor = System.Drawing.Color.BurlyWood
        Me.txtitemid.Enabled = False
        Me.txtitemid.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitemid.Location = New System.Drawing.Point(153, 48)
        Me.txtitemid.Name = "txtitemid"
        Me.txtitemid.Size = New System.Drawing.Size(251, 22)
        Me.txtitemid.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.BurlyWood
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(90, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Item Id ::"
        '
        'cbounit
        '
        Me.cbounit.BackColor = System.Drawing.Color.BurlyWood
        Me.cbounit.FormattingEnabled = True
        Me.cbounit.Items.AddRange(New Object() {"Metre", "Pcs."})
        Me.cbounit.Location = New System.Drawing.Point(317, 243)
        Me.cbounit.Name = "cbounit"
        Me.cbounit.Size = New System.Drawing.Size(87, 23)
        Me.cbounit.TabIndex = 6
        Me.cbounit.Text = "Metre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.BurlyWood
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(84, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Quantity ::"
        '
        'txtqty
        '
        Me.txtqty.BackColor = System.Drawing.Color.BurlyWood
        Me.txtqty.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Location = New System.Drawing.Point(154, 243)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(153, 22)
        Me.txtqty.TabIndex = 4
        '
        'txtdescription
        '
        Me.txtdescription.BackColor = System.Drawing.Color.BurlyWood
        Me.txtdescription.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescription.Location = New System.Drawing.Point(152, 112)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(253, 52)
        Me.txtdescription.TabIndex = 3
        Me.txtdescription.Text = ""
        '
        'cbotype
        '
        Me.cbotype.BackColor = System.Drawing.Color.BurlyWood
        Me.cbotype.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotype.FormattingEnabled = True
        Me.cbotype.Location = New System.Drawing.Point(152, 171)
        Me.cbotype.Name = "cbotype"
        Me.cbotype.Size = New System.Drawing.Size(252, 24)
        Me.cbotype.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.BurlyWood
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(185, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 29)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Add New Item"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.dtglist)
        Me.Panel2.Controls.Add(Me.btnadd)
        Me.Panel2.Location = New System.Drawing.Point(0, 287)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(564, 139)
        Me.Panel2.TabIndex = 3
        '
        'dtglist
        '
        Me.dtglist.AllowUserToAddRows = False
        Me.dtglist.AllowUserToDeleteRows = False
        Me.dtglist.AllowUserToResizeColumns = False
        Me.dtglist.AllowUserToResizeRows = False
        Me.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtglist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtglist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtglist.Location = New System.Drawing.Point(0, 0)
        Me.dtglist.Name = "dtglist"
        Me.dtglist.Size = New System.Drawing.Size(562, 137)
        Me.dtglist.TabIndex = 0
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(344, 55)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(142, 25)
        Me.btnadd.TabIndex = 2
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(270, 476)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 14)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Search :"
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(332, 473)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(184, 20)
        Me.txtsearch.TabIndex = 1
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.ForestGreen
        Me.btnsave.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnsave.Location = New System.Drawing.Point(1, 432)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(106, 30)
        Me.btnsave.TabIndex = 4
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.ForestGreen
        Me.btnupdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnupdate.Location = New System.Drawing.Point(113, 432)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(103, 30)
        Me.btnupdate.TabIndex = 4
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.ForestGreen
        Me.btndelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btndelete.Location = New System.Drawing.Point(222, 432)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(106, 30)
        Me.btndelete.TabIndex = 4
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnnew
        '
        Me.btnnew.BackColor = System.Drawing.Color.ForestGreen
        Me.btnnew.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnnew.Location = New System.Drawing.Point(332, 432)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(106, 30)
        Me.btnnew.TabIndex = 4
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = False
        '
        'btnfirst
        '
        Me.btnfirst.BackColor = System.Drawing.Color.ForestGreen
        Me.btnfirst.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnfirst.Location = New System.Drawing.Point(78, 468)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(39, 30)
        Me.btnfirst.TabIndex = 9
        Me.btnfirst.Text = "<<"
        Me.btnfirst.UseVisualStyleBackColor = False
        '
        'btnprev
        '
        Me.btnprev.BackColor = System.Drawing.Color.ForestGreen
        Me.btnprev.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnprev.Location = New System.Drawing.Point(123, 468)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(39, 30)
        Me.btnprev.TabIndex = 9
        Me.btnprev.Text = "<"
        Me.btnprev.UseVisualStyleBackColor = False
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.Color.ForestGreen
        Me.btnnext.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnnext.Location = New System.Drawing.Point(169, 468)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(39, 30)
        Me.btnnext.TabIndex = 9
        Me.btnnext.Text = ">"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'btnlast
        '
        Me.btnlast.BackColor = System.Drawing.Color.ForestGreen
        Me.btnlast.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnlast.Location = New System.Drawing.Point(217, 468)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(39, 30)
        Me.btnlast.TabIndex = 9
        Me.btnlast.Text = ">>"
        Me.btnlast.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(31, 474)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "of"
        '
        'lblinc
        '
        Me.lblinc.AutoSize = True
        Me.lblinc.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinc.Location = New System.Drawing.Point(9, 474)
        Me.lblinc.Name = "lblinc"
        Me.lblinc.Size = New System.Drawing.Size(14, 16)
        Me.lblinc.TabIndex = 10
        Me.lblinc.Text = "1"
        '
        'lblmax
        '
        Me.lblmax.AutoSize = True
        Me.lblmax.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmax.Location = New System.Drawing.Point(58, 474)
        Me.lblmax.Name = "lblmax"
        Me.lblmax.Size = New System.Drawing.Size(14, 16)
        Me.lblmax.TabIndex = 11
        Me.lblmax.Text = "1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.ForestGreen
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(444, 432)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 30)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frm_stockmaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(564, 508)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblmax)
        Me.Controls.Add(Me.lblinc)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnlast)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnprev)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnfirst)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnl_stockmaster)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frm_stockmaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Mater"
        Me.pnl_stockmaster.ResumeLayout(False)
        Me.pnl_stockmaster.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dtglist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pnl_stockmaster As System.Windows.Forms.Panel
    Friend WithEvents txtdescription As System.Windows.Forms.RichTextBox
    Friend WithEvents cbotype As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtglist As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents cbounit As System.Windows.Forms.ComboBox
    Friend WithEvents txtitemid As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnfirst As System.Windows.Forms.Button
    Friend WithEvents btnprev As System.Windows.Forms.Button
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents btnlast As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblinc As System.Windows.Forms.Label
    Friend WithEvents lblmax As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
