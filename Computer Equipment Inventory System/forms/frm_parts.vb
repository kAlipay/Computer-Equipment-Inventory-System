Public Class frm_parts
    Dim typeid As Integer = 0
    Dim unitid As Integer = 0

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtparts.Text = "" Then
            MsgBox("No record is being save.")
        Else

            sql = "INSERT INTO tblparts (Parts) VALUES ('" & txtparts.Text & "')"
            create(sql, txtparts.Text, txtparts.Text)

            sql = "INSERT INTO tblautonumber (STRT,END,INCREMENT,DESCRIPTION)" &
               " VALUES ('" & txtparts.Text.Substring(0, 1) & "0000" & "',1,1,'" & txtparts.Text & "')"
            createNoMsg(sql)

            txtparts.Clear()
            sql = "SELECT ID, Parts as 'Parts' FROM tblparts "
            reloadDtg(sql, dtgparts)
            dtgparts.Columns(0).Visible = False

        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        sql = "UPDATE tblparts  SET Parts= '" & txtparts.Text & "' WHERE ID ='" & typeid & "'"
        updates(sql, txtparts.Text, txtparts.Text)
        sql = "SELECT ID, Parts as 'Brand' FROM tblparts"
        reloadDtg(sql, dtgparts)
        dtgparts.Columns(0).Visible = False
        txtparts.Clear()
    End Sub

    Private Sub btncdel_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim ask As MsgBoxResult = MsgBox("Would you like to Delete?", MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then

            sql = "DELETE FROM `tblautonumber` WHERE `ID`='" & dtgparts.CurrentRow.Cells(0).Value & "'"
            createNoMsg(sql)
            sql = "DELETE FROM `tblparts` WHERE `ID`='" & dtgparts.CurrentRow.Cells(0).Value & "'"
            deletes(sql, txtparts.Text, txtparts.Text)

            sql = "SELECT ID, Parts as 'Brand' FROM tblparts "
            reloadDtg(sql, dtgparts)
            dtgparts.Columns(0).Visible = False

        Else
            MsgBox("No record deleted", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub btntypeLoad_Click(sender As Object, e As EventArgs) Handles btntypeLoad.Click
        sql = "SELECT ID, Parts as 'Parts' FROM tblparts"
        reloadDtg(sql, dtgparts)
        dtgparts.Columns(0).Visible = False

        txtparts.Clear()
    End Sub

    Private Sub frm_parts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT ID, Parts as 'Parts' FROM tblparts "
        reloadDtg(sql, dtgparts)
        dtgparts.Columns(0).Visible = False
    End Sub

    Private Sub dtgbrand_DoubleClick(sender As Object, e As EventArgs) Handles dtgparts.DoubleClick
        txtparts.Text = dtgparts.CurrentRow.Cells(1).Value
        typeid = dtgparts.CurrentRow.Cells(0).Value
    End Sub

End Class