Public Class frm_main
    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCustomerToolStripMenuItem.Click
        frm_customer.Show()


    End Sub

    Private Sub BrandToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrandToolStripMenuItem.Click
        frm_brand.Show()

    End Sub

    Private Sub PartsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartsToolStripMenuItem.Click
        frm_parts.Show()

    End Sub

    Private Sub AddItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddItemsToolStripMenuItem.Click
        frm_item.Show()

    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click

    End Sub

    Private Sub StockInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockInToolStripMenuItem.Click
        frm_stockin.Show()

    End Sub

    Private Sub StockOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockOutToolStripMenuItem.Click
        frm_stockout.Show()

    End Sub



    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click
    End Sub

    Private Sub StockReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockReturnToolStripMenuItem.Click
        frm_stockreturn.Show()

    End Sub

    Private Sub AddSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSupplierToolStripMenuItem.Click
        frm_supplier.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbltime.Text = "Time : " & Format(Now(), "H:mm:ss")
        lbldate.Text = "Date : " & Format(Now(), "MM/dd/yyyy")


        Dim ampm As String = Format(Now, "tt")
        Dim checkdate As Integer
        Dim checkmin As String = DatePart("n", Now)
        Dim checkhour As String = DatePart("h", Now)

        If checkmin < 10 Then
            checkmin = 0 & checkmin
        End If

        checkdate = checkhour & checkmin


        Try


            'Select Case ampm
            '    Case "AM"
            '        If checkdate >= 830 And checkdate <= 1130 Then
            '            ToolStripButton1.Enabled = True
            '            ToolStripButton2.Enabled = True
            '            ToolStripButton3.Enabled = True
            '            'MenuToolStripMenuItem.Enabled = True
            '        Else
            '            ToolStripButton1.Enabled = False
            '            ToolStripButton2.Enabled = False
            '            ToolStripButton3.Enabled = False
            '            'MenuToolStripMenuItem.Enabled = False
            '        End If
            '    Case "PM"
            '        If checkdate >= 1330 And checkdate <= 1730 Then
            '            ToolStripButton1.Enabled = True
            '            ToolStripButton2.Enabled = True
            '            ToolStripButton3.Enabled = True
            '            'MenuToolStripMenuItem.Enabled = True
            '        Else
            '            ToolStripButton1.Enabled = False
            '            ToolStripButton2.Enabled = False
            '            ToolStripButton3.Enabled = False
            '            'MenuToolStripMenuItem.Enabled = False
            '        End If

            'End Select



        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ToolStripTextBox1_Click_1(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click
        frm_user.Show()
    End Sub

    Private Sub itemreporttoolstripmenu_Click(sender As Object, e As EventArgs) Handles itemreporttoolstripmenu.Click
        frm_itemreport.Show()

    End Sub
End Class