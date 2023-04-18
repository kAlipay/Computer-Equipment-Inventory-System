Imports MySql.Data.MySqlClient
Public Class frm_login
    Public con As MySqlConnection = mysqldb()

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Try

            con.Open()
            reloadtxt("SELECT * FROM `tbluser` WHERE Username= '" & txtusername.Text & "' and Password = sha1('" & txtpassword.Text & "')")


            If dt.Rows.Count > 0 Then

                If dt.Rows(0).Item("Type") = "Administrator" Then
                    MsgBox("Welcome " & dt.Rows(0).Item("Type"))
                    frm_main.toolstripstatususername.Text = dt.Rows(0).Item("Username")
                    frm_main.toolstripstatustype.Text = dt.Rows(0).Item("Type")
                    With frm_main
                        '   .FileToolStripMenuItem.Visible = True
                        '   .TransactionToolStripMenuItem.Visible = True
                        '  .ListOfItemsToolStripMenuItem.Visible = True
                        '  .ReportsToolStripMenuItem.Visible = True
                        '   .Show()
                        '   .Focus()
                        .AddUserToolStripMenuItem.Visible = True
                        .BrandToolStripMenuItem.Visible = True
                        .PartsToolStripMenuItem.Visible = True
                        .ReportsToolStripMenuItem.Visible = True

                    End With


                    'LoginForm1.Hide()

                    frm_main.Show()
                    Me.Hide()
                Else
                    dt.Rows(0).Item("Type") = "Staff"
                    MsgBox("Welcome " & dt.Rows(0).Item("Type"))
                    frm_main.toolstripstatususername.Text = dt.Rows(0).Item("Username")
                    frm_main.toolstripstatustype.Text = dt.Rows(0).Item("Type")
                    With frm_main
                        '     .FileToolStripMenuItem.Visible = True
                        '    .ItemsToolStripMenuItem.Visible = False
                        ''    .ManageUsersToolStripMenuItem.Visible = False
                        '   .TransactionToolStripMenuItem.Visible = False
                        '    .ListOfItemsToolStripMenuItem.Visible = True
                        '    .ReportsToolStripMenuItem.Visible = True
                        '   .UtilitiesToolStripMenuItem.Visible = False

                        '  .Show()
                        '  .Focus()
                    End With
                    '   frmListItems.btnEdit.Visible = False
                    '   LoginForm1.Hide()
                    frm_main.Show()
                    Me.Hide()
                End If

            Else
                MsgBox("Acount doest not exits!", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        da.Dispose()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub


End Class