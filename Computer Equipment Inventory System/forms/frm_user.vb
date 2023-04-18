Imports MySql.Data.MySqlClient
Public Class frm_user
    Private Sub frm_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '  cbotype.Text = "Administrator"
            reloadDtg("Select UserID as 'ID' ,Username as 'User Name',Type as 'User Type',Name as 'Name',Email as 'E mail',PhoneNumber as 'Phone Number' From tbluser", dtg_listUser)
            dtg_listUser.Columns(0).Visible = False
            If lbl_id.Text = "id" Then

                '   btn_update.Enabled = False
                '  btn_delete.Enabled = False
                '   btn_saveuser.Enabled = True

            Else
                '  btn_saveuser.Enabled = False
                '    btn_update.Enabled = True
                '   btn_delete.Enabled = True
            End If


        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtg_listUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub




    Private Sub dtg_listUser_DoubleClick(sender As Object, e As EventArgs) Handles dtg_listUser.DoubleClick
        Try
            With dtg_listUser.CurrentRow
                lbl_id.Text = .Cells(0).Value
                txtusername.Text = .Cells(1).Value
                cbotype.Text = .Cells(2).Value
                txtname.Text = .Cells(3).Value
                txtemail.Text = .Cells(4).Value
                masktextboxphonenumber.Text = .Cells(5).Value
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label6_TextChanged(sender As Object, e As EventArgs) Handles Label6.TextChanged
        Try
            If lbl_id.Text = "id" Then

                '    btn_update.Enabled = False
                '    btn_delete.Enabled = False
                '    btn_saveuser.Enabled = True

            Else
                '   btn_saveuser.Enabled = False
                '    btn_update.Enabled = True
                '   btn_delete.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        If txtusername.Text = "" Or txtpassword.Text = "" Or cbotype.Text = "" Or txtname.Text = "" Or txtemail.Text = "" Or masktextboxphonenumber.Text = "" Then
            '   emptymessage()
        Else
            create("insert into tbluser (Username,Type,Password,Name,Email,PhoneNumber) " _
             & "values('" & txtusername.Text & "','" & cbotype.Text _
             & "',sha1('" & txtpassword.Text & "'),'" & txtname.Text _
             & "','" & txtemail.Text & "','" & masktextboxphonenumber.Text _
             & "')", "User", "User")

            Call frm_user_Load(sender, e)
            '  cleartext(grp_user)

        End If
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        Try
            If txtusername.Text = "" Or txtpassword.Text = "" Or cbotype.Text = "" Or txtemail.Text = "" Or masktextboxphonenumber.Text = "" Or txtname.Text = "" Then
                '  emptymessage()
            Else
                updates("update tbluser set Username = '" & txtusername.Text & "',Type= '" & cbotype.Text _
                            & "',Password= sha1('" & txtpassword.Text & "'),Name= '" & txtname.Text _
                            & "', Email= '" & txtemail.Text _
                            & "',PhoneNumber= '" & masktextboxphonenumber.Text _
                            & "' where UserID = " & lbl_id.Text, "User", "User")

                txtname.Text = ""
                txtusername.Text = ""
                cbotype.Text = ""
                txtpassword.Text = ""
                txtemail.Text = ""
                masktextboxphonenumber.Text = ""

                Call frm_user_Load(sender, e)
                '  cleartext(grp_user)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub new_btn_Click(sender As Object, e As EventArgs) Handles new_btn.Click
        lbl_id.Text = "id"
        txtname.Text = ""
        txtusername.Text = ""
        cbotype.Text = ""
        txtpassword.Text = ""
        txtemail.Text = ""
        masktextboxphonenumber.Text = ""
        Call frm_user_Load(sender, e)
        'cleartext(grp_user)
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        Try
            deletes("delete from tbluser where UserID = '" & lbl_id.Text & "'", "User", "User")
            Call frm_user_Load(sender, e)
            '  cleartext(grp_user)
            txtname.Text = ""
            txtusername.Text = ""
            cbotype.Text = ""
            txtpassword.Text = ""
            txtemail.Text = ""
            masktextboxphonenumber.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub


End Class