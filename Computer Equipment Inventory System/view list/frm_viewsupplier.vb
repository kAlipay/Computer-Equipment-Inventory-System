Public Class frm_viewsupplier
    Private Sub frm_viewsupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT  `SupplierID` as 'Supplier ID', `FirstName` as 'First Name', `LastName` as 'Last Name', `MiddleName` as 'Middle Name', `Address`, `Telephone`, `TYPE` FROM `tblsupplier` WHERE  `TYPE` ='Supplier'"
        reloadDtg(sql, dtglist)
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        sql = "SELECT  `SupplierID` as 'Supplier ID', `FirstName` as 'First Name ', `LastName` as 'Last Name', `MiddleName` as 'Middle Name', `Address`, `Telephone`, `TYPE` FROM `tblsupplier` WHERE  `TYPE` ='Supplier' AND  SupplierID LIKE '%" & txtsearch.Text & "%'"
        reloadDtg(sql, dtglist)
    End Sub

    Private Sub dtglist_DoubleClick(sender As Object, e As EventArgs) Handles dtglist.DoubleClick
        Try
            frm_stockin.txtsupplierid.Text = dtglist.CurrentRow.Cells(0).Value
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtglist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtglist.CellContentClick

    End Sub
End Class