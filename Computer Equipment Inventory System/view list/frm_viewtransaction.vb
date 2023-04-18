Public Class frm_viewtransaction
    Private Sub frm_viewtransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = " SELECT `TransactionNumber` as 'Transaction Number',  `TransactionDate` as 'Transaction Date',  `FirstName` as 'First Name', `LastName` as 'Last Name' FROM `tbltransaction` t,`tblperson` c WHERE  c.`CustomerID`=t.`SupplierCustomerID` AND t.TYPE ='StockOut'"
        reloadDtg(sql, dtglist)
    End Sub



    Private Sub dtglist_DoubleClick(sender As Object, e As EventArgs) Handles dtglist.DoubleClick
        frm_stockreturn.txttransactionid.Text = dtglist.CurrentRow.Cells(0).Value
        frm_stockreturn.btnadditem.Enabled = True
        Me.Close()
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        sql = " SELECT `TransactionNumber` as 'Transaction NUmber',  `TransactionDate` as 'Transaction Date',  `FirstName` as 'First Name', `LastName` as 'Last Name' FROM `tbltransaction` t,`tblperson` c WHERE  c.`CustomerID`=t.`SupplierCustomerID` AND t.TYPE ='StockOut' " &
" AND (FirstName like '%" & txtsearch.Text & "%' OR  LastName like '%" & txtsearch.Text & "%')"
        ' " WHERE LastName LIKE '%" & txtsearch.Text & "%'"
    End Sub

    Private Sub dtglist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtglist.CellContentClick

    End Sub
End Class