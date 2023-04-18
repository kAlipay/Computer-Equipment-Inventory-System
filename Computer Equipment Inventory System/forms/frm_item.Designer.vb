<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_item
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.new_btn = New System.Windows.Forms.Button()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.update_btn = New System.Windows.Forms.Button()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.dtglist = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.search_txt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbotype = New System.Windows.Forms.ComboBox()
        Me.cbobrand = New System.Windows.Forms.ComboBox()
        Me.cbounit = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.txtitemname = New System.Windows.Forms.TextBox()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.txtitemid = New System.Windows.Forms.TextBox()
        Me.lblmax = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtglist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.new_btn)
        Me.GroupBox2.Controls.Add(Me.close_btn)
        Me.GroupBox2.Controls.Add(Me.delete_btn)
        Me.GroupBox2.Controls.Add(Me.update_btn)
        Me.GroupBox2.Controls.Add(Me.save_btn)
        Me.GroupBox2.Controls.Add(Me.dtglist)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.search_txt)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 303)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1139, 379)
        Me.GroupBox2.TabIndex = 85
        Me.GroupBox2.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(507, 20)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(269, 19)
        Me.Label15.TabIndex = 90
        Me.Label15.Text = "Note: (Please Search by: Name or Type)"
        '
        'new_btn
        '
        Me.new_btn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_btn.Location = New System.Drawing.Point(100, 326)
        Me.new_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.new_btn.Name = "new_btn"
        Me.new_btn.Size = New System.Drawing.Size(105, 33)
        Me.new_btn.TabIndex = 89
        Me.new_btn.Text = "New"
        Me.new_btn.UseVisualStyleBackColor = False
        '
        'close_btn
        '
        Me.close_btn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close_btn.Location = New System.Drawing.Point(828, 326)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(105, 33)
        Me.close_btn.TabIndex = 88
        Me.close_btn.Text = "Close"
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'delete_btn
        '
        Me.delete_btn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_btn.Location = New System.Drawing.Point(640, 326)
        Me.delete_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(105, 33)
        Me.delete_btn.TabIndex = 87
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = True
        '
        'update_btn
        '
        Me.update_btn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_btn.Location = New System.Drawing.Point(457, 326)
        Me.update_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.update_btn.Name = "update_btn"
        Me.update_btn.Size = New System.Drawing.Size(105, 33)
        Me.update_btn.TabIndex = 86
        Me.update_btn.Text = "Update"
        Me.update_btn.UseVisualStyleBackColor = True
        '
        'save_btn
        '
        Me.save_btn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_btn.Location = New System.Drawing.Point(271, 326)
        Me.save_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(105, 33)
        Me.save_btn.TabIndex = 85
        Me.save_btn.Text = "Save"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'dtglist
        '
        Me.dtglist.AllowUserToAddRows = False
        Me.dtglist.AllowUserToDeleteRows = False
        Me.dtglist.AllowUserToResizeColumns = False
        Me.dtglist.AllowUserToResizeRows = False
        Me.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtglist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtglist.Location = New System.Drawing.Point(13, 52)
        Me.dtglist.Margin = New System.Windows.Forms.Padding(4)
        Me.dtglist.Name = "dtglist"
        Me.dtglist.RowHeadersWidth = 51
        Me.dtglist.Size = New System.Drawing.Size(1117, 267)
        Me.dtglist.TabIndex = 84
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 21)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Search :"
        '
        'search_txt
        '
        Me.search_txt.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_txt.Location = New System.Drawing.Point(113, 12)
        Me.search_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.search_txt.Name = "search_txt"
        Me.search_txt.Size = New System.Drawing.Size(384, 30)
        Me.search_txt.TabIndex = 82
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbotype)
        Me.GroupBox1.Controls.Add(Me.cbobrand)
        Me.GroupBox1.Controls.Add(Me.cbounit)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtquantity)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtprice)
        Me.GroupBox1.Controls.Add(Me.txtitemname)
        Me.GroupBox1.Controls.Add(Me.txtdescription)
        Me.GroupBox1.Controls.Add(Me.txtitemid)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1139, 281)
        Me.GroupBox1.TabIndex = 84
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item Detail's"
        '
        'cbotype
        '
        Me.cbotype.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.cbotype.FormattingEnabled = True
        Me.cbotype.Location = New System.Drawing.Point(143, 226)
        Me.cbotype.Name = "cbotype"
        Me.cbotype.Size = New System.Drawing.Size(214, 31)
        Me.cbotype.TabIndex = 121
        '
        'cbobrand
        '
        Me.cbobrand.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.cbobrand.FormattingEnabled = True
        Me.cbobrand.Location = New System.Drawing.Point(143, 185)
        Me.cbobrand.Name = "cbobrand"
        Me.cbobrand.Size = New System.Drawing.Size(214, 31)
        Me.cbobrand.TabIndex = 120
        '
        'cbounit
        '
        Me.cbounit.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbounit.FormattingEnabled = True
        Me.cbounit.Items.AddRange(New Object() {"Peices", "Box"})
        Me.cbounit.Location = New System.Drawing.Point(779, 185)
        Me.cbounit.Margin = New System.Windows.Forms.Padding(4)
        Me.cbounit.Name = "cbounit"
        Me.cbounit.Size = New System.Drawing.Size(211, 31)
        Me.cbounit.TabIndex = 119
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(71, 190)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 21)
        Me.Label6.TabIndex = 117
        Me.Label6.Text = "Brand:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 150)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 21)
        Me.Label5.TabIndex = 116
        Me.Label5.Text = "Description:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(711, 190)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 21)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "Unit :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(685, 138)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 21)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "Quantity :"
        '
        'txtquantity
        '
        Me.txtquantity.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquantity.Location = New System.Drawing.Point(779, 138)
        Me.txtquantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(211, 30)
        Me.txtquantity.TabIndex = 110
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(988, 277)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 21)
        Me.Label7.TabIndex = 108
        Me.Label7.Text = "Item Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 226)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 21)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Type :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(51, 41)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 21)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "Item Id :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(711, 90)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 21)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "Price :"
        '
        'txtprice
        '
        Me.txtprice.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.Location = New System.Drawing.Point(779, 90)
        Me.txtprice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(211, 30)
        Me.txtprice.TabIndex = 101
        '
        'txtitemname
        '
        Me.txtitemname.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitemname.Location = New System.Drawing.Point(143, 97)
        Me.txtitemname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtitemname.Name = "txtitemname"
        Me.txtitemname.Size = New System.Drawing.Size(496, 30)
        Me.txtitemname.TabIndex = 99
        '
        'txtdescription
        '
        Me.txtdescription.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescription.Location = New System.Drawing.Point(143, 145)
        Me.txtdescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(496, 30)
        Me.txtdescription.TabIndex = 97
        '
        'txtitemid
        '
        Me.txtitemid.Enabled = False
        Me.txtitemid.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitemid.Location = New System.Drawing.Point(143, 36)
        Me.txtitemid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtitemid.Name = "txtitemid"
        Me.txtitemid.Size = New System.Drawing.Size(221, 30)
        Me.txtitemid.TabIndex = 104
        '
        'lblmax
        '
        Me.lblmax.AutoSize = True
        Me.lblmax.Location = New System.Drawing.Point(1164, 251)
        Me.lblmax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmax.Name = "lblmax"
        Me.lblmax.Size = New System.Drawing.Size(48, 16)
        Me.lblmax.TabIndex = 86
        Me.lblmax.Text = "Label5"
        '
        'frm_item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1167, 687)
        Me.Controls.Add(Me.lblmax)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_item"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Information"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtglist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents new_btn As Button
    Friend WithEvents close_btn As Button
    Friend WithEvents delete_btn As Button
    Friend WithEvents update_btn As Button
    Friend WithEvents save_btn As Button
    Friend WithEvents dtglist As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents search_txt As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtprice As TextBox
    Friend WithEvents txtitemname As TextBox
    Friend WithEvents txtdescription As TextBox
    Friend WithEvents txtitemid As TextBox
    Friend WithEvents lblmax As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbounit As ComboBox
    Friend WithEvents cbobrand As ComboBox
    Friend WithEvents cbotype As ComboBox
End Class
