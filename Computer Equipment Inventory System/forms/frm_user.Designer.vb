<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_user
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
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.dtg_listUser = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbotype = New System.Windows.Forms.ComboBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.masktextboxphonenumber = New System.Windows.Forms.MaskedTextBox()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.update_btn = New System.Windows.Forms.Button()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.new_btn = New System.Windows.Forms.Button()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dtg_listUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.txtusername.Location = New System.Drawing.Point(143, 29)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(356, 30)
        Me.txtusername.TabIndex = 13
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(14, 282)
        Me.lbl_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(23, 22)
        Me.lbl_id.TabIndex = 21
        Me.lbl_id.Text = "id"
        Me.lbl_id.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Lavender
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(17, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 21)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "User Name :"
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.txtpassword.Location = New System.Drawing.Point(143, 117)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(356, 30)
        Me.txtpassword.TabIndex = 16
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'dtg_listUser
        '
        Me.dtg_listUser.AllowUserToAddRows = False
        Me.dtg_listUser.AllowUserToDeleteRows = False
        Me.dtg_listUser.AllowUserToResizeColumns = False
        Me.dtg_listUser.AllowUserToResizeRows = False
        Me.dtg_listUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtg_listUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_listUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtg_listUser.Location = New System.Drawing.Point(497, 22)
        Me.dtg_listUser.Margin = New System.Windows.Forms.Padding(4)
        Me.dtg_listUser.Name = "dtg_listUser"
        Me.dtg_listUser.RowHeadersVisible = False
        Me.dtg_listUser.RowHeadersWidth = 51
        Me.dtg_listUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_listUser.Size = New System.Drawing.Size(887, 347)
        Me.dtg_listUser.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 348)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Label6"
        '
        'cbotype
        '
        Me.cbotype.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.cbotype.FormattingEnabled = True
        Me.cbotype.Items.AddRange(New Object() {"Administrator", "Staff"})
        Me.cbotype.Location = New System.Drawing.Point(143, 74)
        Me.cbotype.Name = "cbotype"
        Me.cbotype.Size = New System.Drawing.Size(356, 31)
        Me.cbotype.TabIndex = 30
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.txtname.Location = New System.Drawing.Point(143, 156)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(358, 30)
        Me.txtname.TabIndex = 31
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.txtemail.Location = New System.Drawing.Point(143, 204)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(358, 30)
        Me.txtemail.TabIndex = 32
        '
        'masktextboxphonenumber
        '
        Me.masktextboxphonenumber.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.masktextboxphonenumber.Location = New System.Drawing.Point(143, 246)
        Me.masktextboxphonenumber.Name = "masktextboxphonenumber"
        Me.masktextboxphonenumber.Size = New System.Drawing.Size(356, 30)
        Me.masktextboxphonenumber.TabIndex = 34
        '
        'save_btn
        '
        Me.save_btn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_btn.Location = New System.Drawing.Point(184, 278)
        Me.save_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(105, 33)
        Me.save_btn.TabIndex = 86
        Me.save_btn.Text = "Save"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'update_btn
        '
        Me.update_btn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_btn.Location = New System.Drawing.Point(334, 278)
        Me.update_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.update_btn.Name = "update_btn"
        Me.update_btn.Size = New System.Drawing.Size(105, 33)
        Me.update_btn.TabIndex = 87
        Me.update_btn.Text = "Update"
        Me.update_btn.UseVisualStyleBackColor = True
        '
        'delete_btn
        '
        Me.delete_btn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_btn.Location = New System.Drawing.Point(184, 326)
        Me.delete_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(105, 33)
        Me.delete_btn.TabIndex = 88
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = True
        '
        'new_btn
        '
        Me.new_btn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_btn.Location = New System.Drawing.Point(46, 280)
        Me.new_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.new_btn.Name = "new_btn"
        Me.new_btn.Size = New System.Drawing.Size(105, 33)
        Me.new_btn.TabIndex = 89
        Me.new_btn.Text = "New"
        Me.new_btn.UseVisualStyleBackColor = True
        '
        'close_btn
        '
        Me.close_btn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close_btn.Location = New System.Drawing.Point(334, 326)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(105, 33)
        Me.close_btn.TabIndex = 90
        Me.close_btn.Text = "Close"
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.close_btn)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.update_btn)
        Me.GroupBox1.Controls.Add(Me.delete_btn)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.save_btn)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.new_btn)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtg_listUser)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1391, 376)
        Me.GroupBox1.TabIndex = 91
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Details"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Lavender
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label5.Location = New System.Drawing.Point(23, 62)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 21)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "User Type :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Lavender
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(28, 110)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 21)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Password :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Lavender
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label3.Location = New System.Drawing.Point(56, 153)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 21)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Lavender
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.Location = New System.Drawing.Point(56, 197)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 21)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Email :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Lavender
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label7.Location = New System.Drawing.Point(-4, 239)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 21)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "Phone Number :"
        '
        'frm_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1414, 400)
        Me.Controls.Add(Me.masktextboxphonenumber)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.cbotype)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_user"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User"
        CType(Me.dtg_listUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtusername As TextBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents dtg_listUser As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents cbotype As ComboBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents masktextboxphonenumber As MaskedTextBox
    Friend WithEvents save_btn As Button
    Friend WithEvents update_btn As Button
    Friend WithEvents delete_btn As Button
    Friend WithEvents new_btn As Button
    Friend WithEvents close_btn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
End Class
