Public Class frm_customer
    Dim ID As String = 0
    Dim maxcolumn


    Private Sub txtcusid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            reloadtxt("SELECT * FROM tblperson WHERE CustomerID ='" & txtcusid.Text & "'")
            txtfirstname.Text = dt.Rows(0).Item("FirstName")
            txtlastname.Text = dt.Rows(0).Item("LastName")
            txtmiddlename.Text = dt.Rows(0).Item("MiddleName")
            cmbgender.Text = dt.Rows(0).Item("Gender")
            txtaddress.Text = dt.Rows(0).Item("Address")
            txttelephone.Text = dt.Rows(0).Item("Telephone")
            txtmobile.Text = dt.Rows(0).Item("Mobile")
            txtemail.Text = dt.Rows(0).Item("Email")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub frm_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT * FROM tblperson WHERE TYPE ='Customer'"
        reloadDtg(sql, dtglist)
        '---------------------------------
        'cleartext(Panel1)
        '----------------------------------
        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False
        dtglist.Columns(0).Visible = False
        '-------------------------------------
        reloadtxt("SELECT CONCAT(STRT, END) FROM tblautonumber WHERE ID = 1")
        txtcusid.Text = dt.Rows(0).Item(0)
        ' MsgBox(ID)
        'reloadtxt("SELECT  `SUPLIERCUSTOMERID` FROM `tblperson` WHERE  `TYPE` ='Customer'")
        'select_navigation(sql)
        inc = 0
        maxrows = dtglist.Rows.Count
        lblmax.Text = maxrows
    End Sub

    Private Sub dtglist_DoubleClick(sender As Object, e As EventArgs) Handles dtglist.DoubleClick
        Try
            txtcusid.Text = dtglist.CurrentRow.Cells(1).Value
            reloadtxt("SELECT * FROM tblperson WHERE CustomerID ='" & dtglist.CurrentRow.Cells(1).Value & "'")
            txtfirstname.Text = dt.Rows(0).Item("FirstName")
            txtlastname.Text = dt.Rows(0).Item("LastName")
            txtmiddlename.Text = dt.Rows(0).Item("MiddleName")
            cmbgender.Text = dt.Rows(0).Item("Gender")
            txtaddress.Text = dt.Rows(0).Item("Address")
            txttelephone.Text = dt.Rows(0).Item("Telephone")
            txtmobile.Text = dt.Rows(0).Item("Mobile")
            txtemail.Text = dt.Rows(0).Item("EMail")
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
        sql = "SELECT * FROM tblperson WHERE TYPE ='Customer'"
        reloadDtg(sql, dtglist)
        '---------------------------------       

        '----------------------------------
        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False
        dtglist.Columns(0).Visible = False
        '-------------------------------------
        reloadtxt("SELECT CONCAT(STRT, END) FROM tblautonumber WHERE ID = 1")
        txtcusid.Text = dt.Rows(0).Item(0)
        ' MsgBox(ID)
        reloadtxt("SELECT  `CustomerID` FROM `tblperson` WHERE  `TYPE` ='Customer'")
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
        sql = "INSERT INTO tblperson (`CustomerID`, `FirstName`, `LastName`, `MiddleName`, `Gender`, `Address`, `Telephone`, `Mobile`, `EMail`, `TYPE`)" &
        " VALUES ('" & txtcusid.Text & "','" & txtfirstname.Text & "','" & txtlastname.Text & "','" & txtmiddlename.Text & "','" & cmbgender.Text & "','" & txtaddress.Text & "','" & txttelephone.Text & "','" & txtmobile.Text & "' ,'" & txtemail.Text & "','Customer')"
        create(sql, txtfirstname.Text & " " & txtlastname.Text, txtfirstname.Text & " " & txtlastname.Text)
        '----------------------------------
        sql = "SELECT * FROM tblperson WHERE TYPE ='Customer'"
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
        txtcusid.Text = dt.Rows(0).Item(0)

    End Sub

    Private Sub update_btn_Click_1(sender As Object, e As EventArgs) Handles update_btn.Click
        sql = "UPDATE tblperson SET  `FirstName`='" & txtfirstname.Text & "', `LastName`='" & txtlastname.Text &
  "', `MiddleName`='" & txtmiddlename.Text & "', `Gender`='" & cmbgender.Text & "', `Address`='" & txtaddress.Text & "', `Telephone`='" & txttelephone.Text & "', `Mobile`='" & txtmobile.Text & "', `EMail`='" & txtemail.Text & "' WHERE `CustomerID`='" & txtcusid.Text & "'"
        updates(sql, txtfirstname.Text & " " & txtlastname.Text, txtfirstname.Text & " " & txtlastname.Text)
        '----------------------------------
        sql = "SELECT * FROM tblperson WHERE TYPE ='Customer'"
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
                sql = "DELETE FROM tblperson WHERE `CustomerID`='" & dtglist.CurrentRow.Cells("CustomerID").Value & "'"
                deletes(sql, dtglist.CurrentRow.Cells("CustomerID").Value, dtglist.CurrentRow.Cells("CustomerID").Value)
                '----------------------------------
                sql = "SELECT * FROM tblperson WHERE TYPE ='Customer'"
                reloadDtg(sql, dtglist)
                '---------------------------------
                '    cleartext(Panel1)
                '----------------------------------
                maxcolumn = dtglist.Columns.Count - 1
                dtglist.Columns(maxcolumn).Visible = False
                dtglist.Columns(0).Visible = False
                '-------------------------------------
                reloadtxt("SELECT CONCAT(STRT, END) FROM tblautonumber WHERE ID = 1")
                txtcusid.Text = dt.Rows(0).Item(0)
            Catch ex As Exception
                MsgBox("Action is not valid", MsgBoxStyle.Exclamation)
            End Try
            Call clear()
        Else
            MsgBox("No record deleted", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub search_txt_TextChanged(sender As Object, e As EventArgs) Handles search_txt.TextChanged
        sql = "SELECT * FROM tblperson WHERE TYPE ='Customer' AND  LastName LIKE '%" & search_txt.Text & "%'"
        reloadDtg(sql, dtglist)
        '---------------------------------- 
        'cleartext(Panel1)
        '----------------------------------
        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False
        dtglist.Columns(0).Visible = False
        '-------------------------------------
        reloadtxt("SELECT CONCAT(STRT, END) FROM tblautonumber WHERE ID = 1")
        txtcusid.Text = dt.Rows(0).Item(0)

    End Sub

    Private Sub close_btn_Click_1(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub

    Private Sub txtlastname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtlastname.KeyPress
        Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;!><?/|\"

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If


    End Sub

    Private Sub txtfirstname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfirstname.KeyPress
        Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;!><?/|\"

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub



    Private Sub txtaddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtaddress.KeyPress
        Dim NotAllowed As String = "~`@#$%^&*()_-+={[}]:;!><?/|\"

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtmiddlename_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmiddlename.KeyPress
        Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;!><?/|\"

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txttelephone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelephone.KeyPress
        Dim NotAllowed As String = "abcdefghijklmnopqrstuvwxyz~`@#$%^&*_={[}]:;'.><?|/\.!"

        'Allowed Numbers Only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtmobile_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmobile.KeyPress
        Dim NotAllowed As String = "abcdefghijklmnopqrstuvwxyz~`@#$%^&*_-={[}]:;'.><?|/\.!"

        'Allowed Numbers Only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtemail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtemail.KeyPress
        Dim NotAllowed As String = "~`#$%^&*()-+={[}]:;!><?/|\"

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Sub clear()
        txtlastname.Text = ""
        txtmiddlename.Text = ""
        txtfirstname.Text = ""
        cmbgender.Text = ""
        txtaddress.Text = ""
        txtmobile.Text = ""
        txttelephone.Text = ""
        txtemail.Text = ""
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class