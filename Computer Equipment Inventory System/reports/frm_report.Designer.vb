<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_report
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnListStockin = New System.Windows.Forms.Button()
        Me.cbooption = New System.Windows.Forms.ComboBox()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnListStockin)
        Me.Panel1.Controls.Add(Me.cbooption)
        Me.Panel1.Location = New System.Drawing.Point(1, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(201, 495)
        Me.Panel1.TabIndex = 0
        '
        'btnListStockin
        '
        Me.btnListStockin.BackColor = System.Drawing.Color.ForestGreen
        Me.btnListStockin.ForeColor = System.Drawing.Color.White
        Me.btnListStockin.Location = New System.Drawing.Point(11, 158)
        Me.btnListStockin.Name = "btnListStockin"
        Me.btnListStockin.Size = New System.Drawing.Size(124, 30)
        Me.btnListStockin.TabIndex = 4
        Me.btnListStockin.Text = "List Of Stock Items"
        Me.btnListStockin.UseVisualStyleBackColor = False
        '
        'cbooption
        '
        Me.cbooption.FormattingEnabled = True
        Me.cbooption.Items.AddRange(New Object() {"Daily Report", "Weekly Report", "Monthly Report"})
        Me.cbooption.Location = New System.Drawing.Point(11, 118)
        Me.cbooption.Name = "cbooption"
        Me.cbooption.Size = New System.Drawing.Size(124, 21)
        Me.cbooption.TabIndex = 3
        Me.cbooption.Text = "Daily Report"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(1, 4)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(911, 518)
        Me.CrystalReportViewer1.TabIndex = 1
        '
        'frm_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 520)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frm_report"
        Me.Text = "Reports"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnListStockin As Button
    Friend WithEvents cbooption As ComboBox
End Class
