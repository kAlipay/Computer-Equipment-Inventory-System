Public Class frm_viewcustomer
    Private Sub frm_viewcustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT  `CustomerID` as 'Customer ID', `FirstName` as 'First Name', `LastName` as 'Last Name', `MiddleName` as 'Middle Name', `Address`, `Telephone`, `TYPE` FROM `tblperson` WHERE  `TYPE` ='Customer'"
        reloadDtg(sql, dtglist)
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        sql = "SELECT  `CustomerID` as 'Customer ID', `FirstName` as 'First Name ', `LastName` as 'Last Name', `MiddleName` as 'Middle Name', `Address`, `Telephone`, `TYPE` FROM `tblperson` WHERE  `TYPE` ='Customer' AND  CustomerID LIKE '%" & txtsearch.Text & "%'"
        reloadDtg(sql, dtglist)
    End Sub

    Private Sub dtglist_DoubleClick(sender As Object, e As EventArgs) Handles dtglist.DoubleClick
        Try
            frm_stockout.txtcustomerid.Text = dtglist.CurrentRow.Cells(0).Value
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub dtglist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtglist.CellContentClick

    End Sub
End Class