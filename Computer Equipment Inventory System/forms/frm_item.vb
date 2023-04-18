Imports MySql.Data.MySqlClient

Public Class frm_item
    Dim ID As String = 0
    Dim maxcolumn


    Private Sub txtcusid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            reloadtxt("SELECT * FROM tblitems WHERE ItemID ='" & txtitemid.Text & "'")
            txtdescription.Text = dt.Rows(0).Item("Description")
            txtitemname.Text = dt.Rows(0).Item("Name")
            cbobrand.Text = dt.Rows(0).Item("Brand")
            cbotype.Text = dt.Rows(0).Item("Types")
            txtprice.Text = dt.Rows(0).Item("Price")
            txtquantity.Text = dt.Rows(0).Item("Quantity")
            cbounit.Text = dt.Rows(0).Item("Unit")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub frm_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT * FROM tblitems WHERE Type ='Item'"
        reloadDtg(sql, dtglist)
        '---------------------------------
        'cleartext(Panel1)
        '----------------------------------
        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False
        dtglist.Columns(0).Visible = False
        '-------------------------------------
        reloadtxt("SELECT CONCAT(STRT, END) FROM tblautonumber WHERE ID = 1")
        txtitemid.Text = dt.Rows(0).Item(0)
        ' MsgBox(ID)
        'reloadtxt("SELECT  `SUPLIERCUSTOMERID` FROM `tblperson` WHERE  `TYPE` ='Customer'")
        'select_navigation(sql)
        inc = 0
        maxrows = dtglist.Rows.Count
        lblmax.Text = maxrows

        '   fillComboBox("select * from tblbrand", "Brand", cbobrand)
        '   fillComboBox("select * from tblparts", "Parts", cbotype)
    End Sub

    Private Sub dtglist_DoubleClick(sender As Object, e As EventArgs) Handles dtglist.DoubleClick
        Try
            txtitemid.Text = dtglist.CurrentRow.Cells(1).Value
            reloadtxt("SELECT * FROM tblitems WHERE ItemID ='" & dtglist.CurrentRow.Cells(1).Value & "'")
            txtdescription.Text = dt.Rows(0).Item("Description")
            txtitemname.Text = dt.Rows(0).Item("Name")
            cbobrand.Text = dt.Rows(0).Item("Brand")
            cbotype.Text = dt.Rows(0).Item("Types")
            txtprice.Text = dt.Rows(0).Item("Price")
            txtquantity.Text = dt.Rows(0).Item("Quantity")
            cbounit.Text = dt.Rows(0).Item("Unit")
        Catch ex As Exception
            '   MsgBox("Action is not valid.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub new_btn_Click_1(sender As Object, e As EventArgs) Handles new_btn.Click
        '----------------------------------
        Call clear()

        '   txtlastname.Text = ""  Or  txtmobile.Text = "" Or txttelephone.Text = "" And cmbgender.Text = "" Then
        ' MsgBox("Reaquired to fill up all the empty fields.", MsgBoxStyle.Exclamation)
        'Exit Sub
        'End If
        sql = "SELECT * FROM tblitems WHERE Type ='Item'"
        reloadDtg(sql, dtglist)
        '---------------------------------       

        '----------------------------------
        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False
        dtglist.Columns(0).Visible = False
        '-------------------------------------
        reloadtxt("SELECT CONCAT(STRT, END) FROM tblautonumber WHERE ID = 1")
        txtitemid.Text = dt.Rows(0).Item(0)
        ' MsgBox(ID)
        reloadtxt("SELECT  `ItemID` FROM `tblitems` WHERE  `Type` ='Item'")
        select_navigation(sql)
        lblmax.Text = maxrows
        Call clear()

    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click

        'For Each txt As Control In Panel1.Controls
        '    'If txt.GetType Is GetType(TextBox) Then
        '    '    If txt.Text = "" Then
        '    '        MsgBox("Reaquired to fill up all the empty fields.", MsgBoxStyle.Exclamation)
        '    '        Exit Sub
        '    '    End If
        '    'End If
        '    If txt.GetType Is GetType(RichTextBox) Then
        '        If txt.Text = "" Then
        '            MsgBox("Reaquired to fill up all the empty fields.", MsgBoxStyle.Exclamation)
        '            Exit Sub
        '        End If
        '    End If
        'Next
        sql = "INSERT INTO tblitems (`ItemID`, `Name`, `Description`, `Brand`, `Types`, `Price`, `Quantity`, `Unit`, `Type`)" &
        " VALUES ('" & txtitemid.Text & "','" & txtitemname.Text & "','" & txtdescription.Text & "','" & cbobrand.Text & "','" & cbotype.Text & "','" & txtprice.Text & "','" & txtquantity.Text & "','" & cbounit.Text & "' ,'Item')"
        create(sql, txtdescription.Text & " " & txtitemname.Text, txtdescription.Text & " " & txtitemname.Text)
        '----------------------------------
        sql = "SELECT * FROM tblitems WHERE Type ='Item'"
        reloadDtg(sql, dtglist)
        '---------------------------------
        'cleartext(Panel1)
        Call clear()

        '----------------------------------
        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False
        dtglist.Columns(0).Visible = False
        '------------------------------------------
        createNoMsg("UPDATE tblautonumber SET END = END + INCREMENT WHERE ID =1")
        '-------------------------------------
        reloadtxt("SELECT CONCAT(STRT, END) FROM tblautonumber WHERE ID = 1")
        txtitemid.Text = dt.Rows(0).Item(0)

    End Sub

    Private Sub update_btn_Click_1(sender As Object, e As EventArgs) Handles update_btn.Click
        sql = "UPDATE tblitems SET  `Description`='" & txtdescription.Text & "', `Name`='" & txtitemname.Text &
  "', `Brand`='" & cbobrand.Text & "', `Types`='" & cbotype.Text & "', `Price`='" & txtprice.Text & "', `Quantity`='" & txtquantity.Text & "', `Unit`='" & cbounit.Text & "' WHERE `ItemID`='" & txtitemid.Text & "'"
        updates(sql, txtdescription.Text & " " & txtitemname.Text, txtdescription.Text & " " & txtitemname.Text)
        '----------------------------------
        sql = "SELECT * FROM tblitems WHERE Type ='Item'"
        reloadDtg(sql, dtglist)
        '---------------------------------
        '    cleartext(Panel1)
        Call clear()
        '----------------------------------
        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False
        dtglist.Columns(0).Visible = False
        '-------------------------------------
        reloadtxt("SELECT CONCAT(STRT, END) FROM tblautonumber WHERE ID = 1")
        ID = dt.Rows(0).Item(0)
    End Sub

    Private Sub delete_btn_Click_1(sender As Object, e As EventArgs) Handles delete_btn.Click
        Dim ask As MsgBoxResult = MsgBox("Would you like to Delete?", MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then


            Try
                sql = "DELETE FROM tblitems WHERE `ItemID`='" & dtglist.CurrentRow.Cells("ItemID").Value & "'"
                deletes(sql, dtglist.CurrentRow.Cells("ItemID").Value, dtglist.CurrentRow.Cells("ItemID").Value)
                '----------------------------------
                sql = "SELECT * FROM tblitems WHERE Type ='Item'"
                reloadDtg(sql, dtglist)
                '---------------------------------
                '    cleartext(Panel1)
                '----------------------------------
                maxcolumn = dtglist.Columns.Count - 1
                dtglist.Columns(maxcolumn).Visible = False
                dtglist.Columns(0).Visible = False
                '-------------------------------------
                reloadtxt("SELECT CONCAT(STRT, END) FROM tblautonumber WHERE ID = 1")
                txtitemid.Text = dt.Rows(0).Item(0)
            Catch ex As Exception
                MsgBox("Action is not valid", MsgBoxStyle.Exclamation)
            End Try
            Call clear()
        Else
            MsgBox("No record deleted", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub search_txt_TextChanged(sender As Object, e As EventArgs) Handles search_txt.TextChanged
        '  sql = "SELECT * FROM tblitems WHERE Type ='Item' AND  Name LIKE '%" & search_txt.Text & "%'"
        sql = "SELECT * FROM tblitems WHERE Types LIKE '%" & search_txt.Text & "%' OR Name LIKE '%" & search_txt.Text & "%'"
        reloadDtg(sql, dtglist)
        '---------------------------------- 
        'cleartext(Panel1)
        '----------------------------------
        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False
        dtglist.Columns(0).Visible = False
        '-------------------------------------
        reloadtxt("SELECT CONCAT(STRT, END) FROM tblautonumber WHERE ID = 1")
        txtitemid.Text = dt.Rows(0).Item(0)

    End Sub

    Private Sub close_btn_Click_1(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub
    Private Sub txtemail_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim NotAllowed As String = "~`#$%^&*()-+={[}]:;!><?/|\"

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Sub clear()
        txtitemname.Text = ""
        cbobrand.Text = ""
        txtdescription.Text = ""
        cbotype.Text = ""
        txtprice.Text = ""
        cbounit.Text = ""
        txtquantity.Text = ""
    End Sub

    Private Sub cmbgender_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtprice_TextChanged(sender As Object, e As EventArgs) Handles txtprice.TextChanged

    End Sub

    Private Sub txtprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprice.KeyPress
        Dim NotAllowed As String = "abcdefghijklmnopqrstuvwxyz~`@#$%^&*_={[}]:;'><?|/\!"

        'Allowed Numbers Only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtquantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtquantity.KeyPress
        Dim NotAllowed As String = "abcdefghijklmnopqrstuvwxyz~`@#$%^&*_={[}]:;'><?|/\!"

        'Allowed Numbers Only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtitemname_TextChanged(sender As Object, e As EventArgs) Handles txtitemname.TextChanged

    End Sub

    Private Sub txtbrand_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;!><?/|\"

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txttype_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;!><?/|\"

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txtdescription_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescription.KeyPress
        Dim NotAllowed As String = "~`#$%^&*()+={[}]:;!><?/|\"

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txtitemname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtitemname.KeyPress
        Dim NotAllowed As String = "~`@#$%^&*()_+={[}]:;!><?/|\"

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub fillComboBox(sql As String, feilds As String, combo As ComboBox)
        Try
            mysqldb.Open()
            cmd = New MySqlCommand
            With cmd
                .Connection = mysqldb()
                .CommandText = sql
            End With
            da = New MySqlDataAdapter
            da.SelectCommand = cmd
            dt = New DataTable
            da.Fill(dt)

            With combo
                .DataSource = dt
                .DisplayMember = feilds
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            mysqldb.Close()
            da.Dispose()
        End Try
    End Sub

    Private Sub cbobrand_Click(sender As Object, e As EventArgs) Handles cbobrand.Click
        fillComboBox("select * from tblbrand", "Brand", cbobrand)
    End Sub

    Private Sub cbotype_Click(sender As Object, e As EventArgs) Handles cbotype.Click
        fillComboBox("select * from tblparts", "Parts", cbotype)
    End Sub
End Class