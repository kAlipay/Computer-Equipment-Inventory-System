<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_parts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btntypeLoad = New System.Windows.Forms.Button()
        Me.dtgparts = New System.Windows.Forms.DataGridView()
        Me.txtparts = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgparts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btndelete)
        Me.GroupBox1.Controls.Add(Me.btnupdate)
        Me.GroupBox1.Controls.Add(Me.btntypeLoad)
        Me.GroupBox1.Controls.Add(Me.dtgparts)
        Me.GroupBox1.Controls.Add(Me.txtparts)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 184)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btndelete.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btndelete.ForeColor = System.Drawing.Color.Black
        Me.btndelete.Location = New System.Drawing.Point(16, 111)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(79, 27)
        Me.btndelete.TabIndex = 13
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnupdate.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnupdate.ForeColor = System.Drawing.Color.Black
        Me.btnupdate.Location = New System.Drawing.Point(16, 82)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(79, 27)
        Me.btnupdate.TabIndex = 12
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btntypeLoad
        '
        Me.btntypeLoad.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btntypeLoad.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btntypeLoad.ForeColor = System.Drawing.Color.Black
        Me.btntypeLoad.Location = New System.Drawing.Point(16, 143)
        Me.btntypeLoad.Name = "btntypeLoad"
        Me.btntypeLoad.Size = New System.Drawing.Size(79, 27)
        Me.btntypeLoad.TabIndex = 11
        Me.btntypeLoad.Text = "Load"
        Me.btntypeLoad.UseVisualStyleBackColor = False
        '
        'dtgparts
        '
        Me.dtgparts.AllowUserToAddRows = False
        Me.dtgparts.AllowUserToDeleteRows = False
        Me.dtgparts.AllowUserToResizeColumns = False
        Me.dtgparts.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dtgparts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgparts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgparts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgparts.Location = New System.Drawing.Point(119, 56)
        Me.dtgparts.Name = "dtgparts"
        Me.dtgparts.RowHeadersVisible = False
        Me.dtgparts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dtgparts.Size = New System.Drawing.Size(214, 114)
        Me.dtgparts.TabIndex = 10
        '
        'txtparts
        '
        Me.txtparts.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.txtparts.Location = New System.Drawing.Point(69, 19)
        Me.txtparts.Name = "txtparts"
        Me.txtparts.Size = New System.Drawing.Size(264, 26)
        Me.txtparts.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Parts :"
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnsave.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnsave.ForeColor = System.Drawing.Color.Black
        Me.btnsave.Location = New System.Drawing.Point(16, 53)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(79, 27)
        Me.btnsave.TabIndex = 7
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'frm_parts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(368, 193)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_parts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parts"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgparts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btndelete As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btntypeLoad As Button
    Friend WithEvents dtgparts As DataGridView
    Friend WithEvents txtparts As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnsave As Button
End Class
