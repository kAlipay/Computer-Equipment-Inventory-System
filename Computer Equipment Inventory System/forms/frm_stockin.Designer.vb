<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_stockin
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsupplierid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnadditem = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtg_itemlist = New System.Windows.Forms.DataGridView()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnviewlist = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.dtg_addedlist = New System.Windows.Forms.DataGridView()
        Me.btnviewcustomer = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtg_itemlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dtg_addedlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnviewcustomer)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtsupplierid)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtlastname)
        Me.GroupBox1.Controls.Add(Me.txtfirstname)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(919, 140)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supplier Info"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(17, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 21)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Supplier Id :"
        '
        'txtsupplierid
        '
        Me.txtsupplierid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtsupplierid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtsupplierid.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.txtsupplierid.Location = New System.Drawing.Point(156, 37)
        Me.txtsupplierid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtsupplierid.Name = "txtsupplierid"
        Me.txtsupplierid.Size = New System.Drawing.Size(272, 30)
        Me.txtsupplierid.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(473, 85)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 21)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Last Name :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label15.Location = New System.Drawing.Point(17, 85)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 21)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "First Name :"
        '
        'txtlastname
        '
        Me.txtlastname.Enabled = False
        Me.txtlastname.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.txtlastname.Location = New System.Drawing.Point(584, 80)
        Me.txtlastname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(292, 30)
        Me.txtlastname.TabIndex = 10
        '
        'txtfirstname
        '
        Me.txtfirstname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtfirstname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtfirstname.Enabled = False
        Me.txtfirstname.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.txtfirstname.Location = New System.Drawing.Point(156, 80)
        Me.txtfirstname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(272, 30)
        Me.txtfirstname.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnadditem)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dtg_itemlist)
        Me.GroupBox2.Controls.Add(Me.txtsearch)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 162)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(927, 311)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List of Items"
        '
        'btnadditem
        '
        Me.btnadditem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadditem.Location = New System.Drawing.Point(41, 266)
        Me.btnadditem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnadditem.Name = "btnadditem"
        Me.btnadditem.Size = New System.Drawing.Size(105, 33)
        Me.btnadditem.TabIndex = 86
        Me.btnadditem.Text = "Add Item"
        Me.btnadditem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(17, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 21)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Search by Item Name:"
        '
        'dtg_itemlist
        '
        Me.dtg_itemlist.AllowUserToAddRows = False
        Me.dtg_itemlist.AllowUserToDeleteRows = False
        Me.dtg_itemlist.AllowUserToResizeColumns = False
        Me.dtg_itemlist.AllowUserToResizeRows = False
        Me.dtg_itemlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtg_itemlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtg_itemlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_itemlist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtg_itemlist.Location = New System.Drawing.Point(21, 59)
        Me.dtg_itemlist.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtg_itemlist.Name = "dtg_itemlist"
        Me.dtg_itemlist.RowHeadersVisible = False
        Me.dtg_itemlist.RowHeadersWidth = 51
        Me.dtg_itemlist.Size = New System.Drawing.Size(897, 199)
        Me.dtg_itemlist.TabIndex = 4
        '
        'txtsearch
        '
        Me.txtsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtsearch.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.txtsearch.Location = New System.Drawing.Point(208, 20)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(292, 30)
        Me.txtsearch.TabIndex = 5
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnclose)
        Me.GroupBox3.Controls.Add(Me.btnviewlist)
        Me.GroupBox3.Controls.Add(Me.btnclear)
        Me.GroupBox3.Controls.Add(Me.btnremove)
        Me.GroupBox3.Controls.Add(Me.btnsave)
        Me.GroupBox3.Controls.Add(Me.dtg_addedlist)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 481)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(919, 303)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "List of Added Items"
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(701, 252)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(105, 33)
        Me.btnclose.TabIndex = 91
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnviewlist
        '
        Me.btnviewlist.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnviewlist.Location = New System.Drawing.Point(551, 252)
        Me.btnviewlist.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnviewlist.Name = "btnviewlist"
        Me.btnviewlist.Size = New System.Drawing.Size(105, 33)
        Me.btnviewlist.TabIndex = 90
        Me.btnviewlist.Text = "View List"
        Me.btnviewlist.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(379, 252)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(105, 33)
        Me.btnclear.TabIndex = 89
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnremove
        '
        Me.btnremove.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnremove.Location = New System.Drawing.Point(221, 252)
        Me.btnremove.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(105, 33)
        Me.btnremove.TabIndex = 88
        Me.btnremove.Text = "Remove"
        Me.btnremove.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(60, 251)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(105, 33)
        Me.btnsave.TabIndex = 87
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'dtg_addedlist
        '
        Me.dtg_addedlist.AllowUserToAddRows = False
        Me.dtg_addedlist.AllowUserToDeleteRows = False
        Me.dtg_addedlist.AllowUserToResizeColumns = False
        Me.dtg_addedlist.AllowUserToResizeRows = False
        Me.dtg_addedlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_addedlist.Location = New System.Drawing.Point(13, 23)
        Me.dtg_addedlist.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtg_addedlist.Name = "dtg_addedlist"
        Me.dtg_addedlist.RowHeadersWidth = 51
        Me.dtg_addedlist.Size = New System.Drawing.Size(897, 207)
        Me.dtg_addedlist.TabIndex = 0
        '
        'btnviewcustomer
        '
        Me.btnviewcustomer.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnviewcustomer.Location = New System.Drawing.Point(449, 35)
        Me.btnviewcustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnviewcustomer.Name = "btnviewcustomer"
        Me.btnviewcustomer.Size = New System.Drawing.Size(105, 33)
        Me.btnviewcustomer.TabIndex = 88
        Me.btnviewcustomer.Text = "Search"
        Me.btnviewcustomer.UseVisualStyleBackColor = True
        '
        'frm_stockin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(960, 802)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_stockin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock In"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtg_itemlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dtg_addedlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtsupplierid As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtg_itemlist As DataGridView
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtg_addedlist As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnadditem As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnremove As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnviewlist As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents btnviewcustomer As Button
End Class
