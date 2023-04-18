<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_main
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolstripstatususername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolstripstatustype = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.itemreporttoolstripmenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.SettingsToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1028, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 20)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(57, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUserToolStripMenuItem, Me.ToolStripTextBox1, Me.ToolStripSeparator2, Me.EndToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(39, 20)
        Me.ToolStripMenuItem2.Text = "Log"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AddUserToolStripMenuItem.Text = "Add User"
        Me.AddUserToolStripMenuItem.Visible = False
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox1.Text = "Log Out"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(157, 6)
        '
        'EndToolStripMenuItem
        '
        Me.EndToolStripMenuItem.Name = "EndToolStripMenuItem"
        Me.EndToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.EndToolStripMenuItem.Text = "End"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockInToolStripMenuItem, Me.StockOutToolStripMenuItem, Me.StockReturnToolStripMenuItem})
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(80, 20)
        Me.ToolStripMenuItem3.Text = "Transaction"
        '
        'StockInToolStripMenuItem
        '
        Me.StockInToolStripMenuItem.Name = "StockInToolStripMenuItem"
        Me.StockInToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.StockInToolStripMenuItem.Text = "Stock In"
        '
        'StockOutToolStripMenuItem
        '
        Me.StockOutToolStripMenuItem.Name = "StockOutToolStripMenuItem"
        Me.StockOutToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.StockOutToolStripMenuItem.Text = "Stock Out"
        '
        'StockReturnToolStripMenuItem
        '
        Me.StockReturnToolStripMenuItem.Name = "StockReturnToolStripMenuItem"
        Me.StockReturnToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.StockReturnToolStripMenuItem.Text = "Stock Return"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCustomerToolStripMenuItem, Me.AddItemsToolStripMenuItem, Me.AddSupplierToolStripMenuItem})
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(135, 20)
        Me.ToolStripMenuItem4.Text = "Database Mangement"
        '
        'AddCustomerToolStripMenuItem
        '
        Me.AddCustomerToolStripMenuItem.Name = "AddCustomerToolStripMenuItem"
        Me.AddCustomerToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.AddCustomerToolStripMenuItem.Text = "Customer"
        '
        'AddItemsToolStripMenuItem
        '
        Me.AddItemsToolStripMenuItem.Name = "AddItemsToolStripMenuItem"
        Me.AddItemsToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.AddItemsToolStripMenuItem.Text = "Items"
        '
        'AddSupplierToolStripMenuItem
        '
        Me.AddSupplierToolStripMenuItem.Name = "AddSupplierToolStripMenuItem"
        Me.AddSupplierToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.AddSupplierToolStripMenuItem.Text = "Supplier"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrandToolStripMenuItem, Me.PartsToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'BrandToolStripMenuItem
        '
        Me.BrandToolStripMenuItem.Name = "BrandToolStripMenuItem"
        Me.BrandToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.BrandToolStripMenuItem.Text = "Brand"
        Me.BrandToolStripMenuItem.Visible = False
        '
        'PartsToolStripMenuItem
        '
        Me.PartsToolStripMenuItem.Name = "PartsToolStripMenuItem"
        Me.PartsToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.PartsToolStripMenuItem.Text = "Parts"
        Me.PartsToolStripMenuItem.Visible = False
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itemreporttoolstripmenu})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.toolstripstatususername, Me.ToolStripStatusLabel3, Me.toolstripstatustype, Me.ToolStripStatusLabel5})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 587)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1028, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(71, 17)
        Me.ToolStripStatusLabel1.Text = "User Name :"
        '
        'toolstripstatususername
        '
        Me.toolstripstatususername.Name = "toolstripstatususername"
        Me.toolstripstatususername.Size = New System.Drawing.Size(60, 17)
        Me.toolstripstatususername.Text = "Username"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(38, 17)
        Me.ToolStripStatusLabel3.Text = "Type :"
        '
        'toolstripstatustype
        '
        Me.toolstripstatustype.Name = "toolstripstatustype"
        Me.toolstripstatustype.Size = New System.Drawing.Size(32, 17)
        Me.toolstripstatustype.Text = "Type"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(0, 17)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbltime)
        Me.GroupBox1.Controls.Add(Me.lbldate)
        Me.GroupBox1.Location = New System.Drawing.Point(1127, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(307, 54)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Time and Date"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.lbltime.Location = New System.Drawing.Point(26, 24)
        Me.lbltime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(42, 16)
        Me.lbltime.TabIndex = 3
        Me.lbltime.Text = "Time:"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.lbldate.Location = New System.Drawing.Point(152, 24)
        Me.lbldate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(39, 16)
        Me.lbldate.TabIndex = 1
        Me.lbldate.Text = "Date:"
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Computer_Equipment_Inventory_System.My.Resources.Resources._34178176_2021204711462480_1097867290956791808_n
        Me.PictureBox1.Location = New System.Drawing.Point(0, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1538, 856)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'itemreporttoolstripmenu
        '
        Me.itemreporttoolstripmenu.Name = "itemreporttoolstripmenu"
        Me.itemreporttoolstripmenu.Size = New System.Drawing.Size(152, 22)
        Me.itemreporttoolstripmenu.Text = "Item"
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Computer Equipment Inventory System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BrandToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddItemsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PartsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockReturnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddSupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents toolstripstatususername As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents toolstripstatustype As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbltime As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AddUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents EndToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents itemreporttoolstripmenu As ToolStripMenuItem
End Class
