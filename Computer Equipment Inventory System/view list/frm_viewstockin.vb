Public Class frm_viewstockin
    Private Sub frm_viewstockin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT  `TransactionNumber` as 'Transaction Number', `FirstName`  as 'First Name',`LastName` as 'Last Name',`Name` as 'Item Name', `Description`, `Price` ,`TransactionDate` as 'Transaction Date', o.`Quantity`, `TotalPrice` as 'Total Price' FROM  `tblsupplier` s,`tblstock_in_out` o ,`tblitems` i WHERE Remarks='StockIn' AND i.`ItemID`=o.`ITEMID` and s.`SupplierID`=o.`SupplierCustomerID` and s.TYPE = 'Supplier'"
        reloadDtg(sql, dtglist)
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        sql = "SELECT  `TransactionNumber` as 'Transaction Number', `FirstName`  as 'First Name',`LastName` as 'Last Name',`Name` as 'Item Name', `Description`, `Price`, `TransactionDate` as 'Transaction Date', o.`Quantity`, `TotalPrice` as 'Total Price' FROM  `tblsupplier` s,`tblstock_in_out` o ,`tblitems` i WHERE Remarks='StockIn' and i.`ITEMID`=o.`ITEMID` and s.`SupplierID`=o.`SupplierCustomerID` and s.TYPE = 'Supplier'" &
" AND (FirstName like '%" & txtsearch.Text & "%' OR  LastName like '%" & txtsearch.Text & "%')"
        reloadDtg(sql, dtglist)
    End Sub

    Private Sub dtglist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtglist.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class