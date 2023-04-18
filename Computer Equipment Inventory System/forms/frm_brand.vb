Public Class frm_brand
    Dim typeid As Integer = 0
    Dim unitid As Integer = 0


    Private Sub btntypeLoad_Click(sender As Object, e As EventArgs) Handles btntypeLoad.Click

        sql = "SELECT ID, Brand as 'Brand' FROM tblbrand "
        reloadDtg(sql, dtgbrand)
        dtgbrand.Columns(0).Visible = False

        txtbrand.Clear()
    End Sub

    Private Sub dtgtypelist_DoubleClick(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub frm_brand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT ID, Brand as 'Brand' FROM tblbrand "
        reloadDtg(sql, dtgbrand)
        dtgbrand.Columns(0).Visible = False
    End Sub

    Private Sub dtgbrand_DoubleClick(sender As Object, e As EventArgs) Handles dtgbrand.DoubleClick
        txtbrand.Text = dtgbrand.CurrentRow.Cells(1).Value
        typeid = dtgbrand.CurrentRow.Cells(0).Value
    End Sub


    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtbrand.Text = "" Then
            MsgBox("No record is being save.")
        Else

            sql = "INSERT INTO tblbrand (Brand) VALUES ('" & txtbrand.Text & "')"
            create(sql, txtbrand.Text, txtbrand.Text)

            sql = "INSERT INTO tblautonumber (STRT,END,INCREMENT,DESCRIPTION)" &
               " VALUES ('" & txtbrand.Text.Substring(0, 1) & "0000" & "',1,1,'" & txtbrand.Text & "')"
            createNoMsg(sql)

            txtbrand.Clear()
            sql = "SELECT ID, Brand as 'Brand' FROM tblbrand "
            reloadDtg(sql, dtgbrand)
            dtgbrand.Columns(0).Visible = False

        End If

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        sql = "UPDATE tblbrand  SET Brand= '" & txtbrand.Text & "' WHERE ID ='" & typeid & "'"
        updates(sql, txtbrand.Text, txtbrand.Text)
        sql = "SELECT ID, Brand as 'Brand' FROM tblbrand"
        reloadDtg(sql, dtgbrand)
        dtgbrand.Columns(0).Visible = False
        txtbrand.Clear()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim ask As MsgBoxResult = MsgBox("Would you like to Delete?", MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then

            sql = "DELETE FROM `tblautonumber` WHERE `ID`='" & dtgbrand.CurrentRow.Cells(0).Value & "'"
            createNoMsg(sql)
            sql = "DELETE FROM `tblbrand` WHERE `ID`='" & dtgbrand.CurrentRow.Cells(0).Value & "'"
            deletes(sql, txtbrand.Text, txtbrand.Text)

            sql = "SELECT ID, Brand as 'Brand' FROM tblbrand "
            reloadDtg(sql, dtgbrand)
            dtgbrand.Columns(0).Visible = False

        Else
            MsgBox("No record deleted", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub txtbrand_TextChanged(sender As Object, e As EventArgs) Handles txtbrand.TextChanged

    End Sub
End Class