Public Class frm_viewstockout
    Private Sub frm_viewstockout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT  `TransactionNumber` as 'Transaction Number',`FirstName`  as 'First Name',`LastName` as 'Last Name',`Name` as 'Item Name', `Description`, `Price` ,`TransactionDate` as 'Transaction Date', o.`Quantity`, `TotalPrice` as 'Total Price' FROM  `tblperson` p,`tblstock_in_out` o ,`tblitems` i WHERE Remarks='StockOut' AND i.`ItemID`=o.`ItemID` and p.`CustomerID`=o.`SupplierCustomerID` and p.TYPE = 'Customer'"
        reloadDtg(sql, dtglist)
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        sql = "SELECT  `TransactionNumber` as 'Transaction Number',`FirstName`  as 'First Name',`LastName` as 'Last Name',`Name` as 'Item Name', `Description`, `Price`, `TransactionDate` as 'Transaction Date', o.`Quantity`, `TotalPrice` as 'Total Price' FROM  `tblperson` p,`tblstock_in_out` o ,`tblitems` i WHERE Remarks='StockOut' and i.`ItemID`=o.`ItemID` and p.`CustomerID`=o.`SupplierCustomerID` and p.TYPE = 'Customer'" &
" AND (FirstName like '%" & txtsearch.Text & "%' OR  LastName like '%" & txtsearch.Text & "%')"
        reloadDtg(sql, dtglist)
    End Sub

    Private Sub dtglist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtglist.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class