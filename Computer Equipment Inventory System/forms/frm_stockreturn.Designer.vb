<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_stockreturn
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
        Me.btnadditem = New System.Windows.Forms.Button()
        Me.btnreturn_transaction = New System.Windows.Forms.Button()
        Me.dtgreturnitemlist = New System.Windows.Forms.DataGridView()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtlastfirstname = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txttransactionid = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnviewlist = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.dtgreturncart = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgreturnitemlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtgreturncart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnadditem)
        Me.GroupBox1.Controls.Add(Me.btnreturn_transaction)
        Me.GroupBox1.Controls.Add(Me.dtgreturnitemlist)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Controls.Add(Me.txtlastfirstname)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.txttransactionid)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(938, 404)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaction Info:"
        '
        'btnadditem
        '
        Me.btnadditem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadditem.Location = New System.Drawing.Point(16, 353)
        Me.btnadditem.Margin = New System.Windows.Forms.Padding(4)
        Me.btnadditem.Name = "btnadditem"
        Me.btnadditem.Size = New System.Drawing.Size(105, 33)
        Me.btnadditem.TabIndex = 88
        Me.btnadditem.Text = "Add Item"
        Me.btnadditem.UseVisualStyleBackColor = True
        '
        'btnreturn_transaction
        '
        Me.btnreturn_transaction.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreturn_transaction.Location = New System.Drawing.Point(418, 35)
        Me.btnreturn_transaction.Margin = New System.Windows.Forms.Padding(4)
        Me.btnreturn_transaction.Name = "btnreturn_transaction"
        Me.btnreturn_transaction.Size = New System.Drawing.Size(105, 33)
        Me.btnreturn_transaction.TabIndex = 87
        Me.btnreturn_transaction.Text = "Find"
        Me.btnreturn_transaction.UseVisualStyleBackColor = True
        '
        'dtgreturnitemlist
        '
        Me.dtgreturnitemlist.AllowUserToAddRows = False
        Me.dtgreturnitemlist.AllowUserToDeleteRows = False
        Me.dtgreturnitemlist.AllowUserToResizeColumns = False
        Me.dtgreturnitemlist.AllowUserToResizeRows = False
        Me.dtgreturnitemlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgreturnitemlist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgreturnitemlist.Location = New System.Drawing.Point(16, 141)
        Me.dtgreturnitemlist.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgreturnitemlist.Name = "dtgreturnitemlist"
        Me.dtgreturnitemlist.RowHeadersWidth = 51
        Me.dtgreturnitemlist.Size = New System.Drawing.Size(904, 204)
        Me.dtgreturnitemlist.TabIndex = 11
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label25.Location = New System.Drawing.Point(400, 94)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(81, 21)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "Address :"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label24.Location = New System.Drawing.Point(32, 94)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(64, 21)
        Me.Label24.TabIndex = 10
        Me.Label24.Text = "Name :"
        '
        'txtaddress
        '
        Me.txtaddress.Enabled = False
        Me.txtaddress.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.txtaddress.Location = New System.Drawing.Point(501, 89)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(331, 30)
        Me.txtaddress.TabIndex = 7
        '
        'txtlastfirstname
        '
        Me.txtlastfirstname.Enabled = False
        Me.txtlastfirstname.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.txtlastfirstname.Location = New System.Drawing.Point(116, 89)
        Me.txtlastfirstname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtlastfirstname.Name = "txtlastfirstname"
        Me.txtlastfirstname.Size = New System.Drawing.Size(247, 30)
        Me.txtlastfirstname.TabIndex = 8
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label26.Location = New System.Drawing.Point(29, 42)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(128, 21)
        Me.Label26.TabIndex = 5
        Me.Label26.Text = "Transaction Id :"
        '
        'txttransactionid
        '
        Me.txttransactionid.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.txttransactionid.Location = New System.Drawing.Point(165, 38)
        Me.txttransactionid.Margin = New System.Windows.Forms.Padding(4)
        Me.txttransactionid.Name = "txttransactionid"
        Me.txttransactionid.Size = New System.Drawing.Size(220, 30)
        Me.txttransactionid.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnclose)
        Me.GroupBox2.Controls.Add(Me.btnviewlist)
        Me.GroupBox2.Controls.Add(Me.btnclear)
        Me.GroupBox2.Controls.Add(Me.btnremove)
        Me.GroupBox2.Controls.Add(Me.btnsave)
        Me.GroupBox2.Controls.Add(Me.dtgreturncart)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 425)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(941, 294)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List of Added Items"
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(759, 244)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(105, 33)
        Me.btnclose.TabIndex = 93
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnviewlist
        '
        Me.btnviewlist.BackColor = System.Drawing.SystemColors.Control
        Me.btnviewlist.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnviewlist.Location = New System.Drawing.Point(556, 244)
        Me.btnviewlist.Margin = New System.Windows.Forms.Padding(4)
        Me.btnviewlist.Name = "btnviewlist"
        Me.btnviewlist.Size = New System.Drawing.Size(105, 33)
        Me.btnviewlist.TabIndex = 92
        Me.btnviewlist.Text = "View List"
        Me.btnviewlist.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(389, 244)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(105, 33)
        Me.btnclear.TabIndex = 91
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnremove
        '
        Me.btnremove.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnremove.Location = New System.Drawing.Point(213, 244)
        Me.btnremove.Margin = New System.Windows.Forms.Padding(4)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(105, 33)
        Me.btnremove.TabIndex = 90
        Me.btnremove.Text = "Remove"
        Me.btnremove.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(55, 244)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(105, 33)
        Me.btnsave.TabIndex = 89
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'dtgreturncart
        '
        Me.dtgreturncart.AllowUserToAddRows = False
        Me.dtgreturncart.AllowUserToDeleteRows = False
        Me.dtgreturncart.AllowUserToResizeColumns = False
        Me.dtgreturncart.AllowUserToResizeRows = False
        Me.dtgreturncart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgreturncart.Location = New System.Drawing.Point(19, 23)
        Me.dtgreturncart.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgreturncart.Name = "dtgreturncart"
        Me.dtgreturncart.RowHeadersWidth = 51
        Me.dtgreturncart.Size = New System.Drawing.Size(904, 213)
        Me.dtgreturncart.TabIndex = 26
        '
        'frm_stockreturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(965, 750)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_stockreturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Return"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgreturnitemlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dtgreturncart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtgreturnitemlist As DataGridView
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtlastfirstname As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txttransactionid As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtgreturncart As DataGridView
    Friend WithEvents btnreturn_transaction As Button
    Friend WithEvents btnadditem As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnremove As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnviewlist As Button
    Friend WithEvents btnclose As Button
End Class
