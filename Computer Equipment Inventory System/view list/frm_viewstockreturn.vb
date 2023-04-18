Public Class frm_viewstockreturn
    Private Sub frm_viewstockreturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT `FirstName`  as 'First Name',`LastName` as 'Last Name',`Name` as 'Item Name', `ReturnDate` as 'Return Date' FROM `tblstock_return` r, `tblitems` i,`tblperson` p WHERE i.`ItemID`=r.`ItemID` and r.`OwnerCustomerID` =p.`CustomerID` and p.Type not in ('Suplier')"
        reloadDtg(sql, dtglist)


        '   sql = "SELECT concat(`FirstName`, `LastName`) as 'Full Name',`StockReturnNumber` as 'TRANSACTION#',`Name` as 'Item Name', `ReturnDate` as 'Return Date' FROM `tblstock_return` r, `tblitems` i,`tblperson` p WHERE i.`ItemID`=r.`ItemID` and r.`OwnerCustomerID` =p.`CustomerID` and p.Type not in ('Suplier')"
        '     reloadDtg(sql, dtglist)

    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        sql = "SELECT `FirstName`  as 'First Name',`LastName` as 'Last Name',`Name` as 'Item Name', `ReturnDate` as 'Return Date' FROM `tblstock_return` r, `tblitems` i,`tblperson` p WHERE i.`ItemID`=r.`ItemID` and r.`OwnerCustomerID` =p.`CustomerID` and p.Type not in ('Suplier')" &
             " AND (FirstName like '%" & txtsearch.Text & "%' OR  LastName like '%" & txtsearch.Text & "%')"
        ' " AND STOCKRETURNNUMBER LIKE '%" & txtsearch.Text & "%'"

        'The original code

        '   sql = "SELECT concat(`FirstName`, `LastName`) as 'Full Name',`StockReturnNumber` as 'TRANSACTION#',`Name` as 'Item Name', `ReturnDate` as 'Return Date' FROM `tblstock_return` r, `tblitems` i,`tblperson` p WHERE i.`ItemID`=r.`ItemID` and r.`OwnerCustomerID` =p.`CustomerID` and p.Type not in ('Suplier')" &
        '       " AND (FirstName like '%" & txtsearch.Text & "%' OR  LastName like '%" & txtsearch.Text & "%')"

        reloadDtg(sql, dtglist)
    End Sub
End Class