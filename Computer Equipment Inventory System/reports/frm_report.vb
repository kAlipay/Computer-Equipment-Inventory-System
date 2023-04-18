Public Class frm_report
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnListStockin_Click(sender As Object, e As EventArgs) Handles btnListStockin.Click
        'sql = "SELECT * FROM `tblitems`"
        'reports(sql, "itemlist", CrystalReportViewer1)

        If cbooption.Text = "Daily Report" Then
            sql = "SELECT i.`ItemID`, `Name`, `Description`, `Types`, `Price`,so.`Quantity`, `Unit`,TransactionDate FROM `tblitems` i ,`tblstock_in_out` so WHERE  i.`ItemID`=so.`ItemID` AND `Remarks`='StockIn' AND DATE(`TransactionDate`)=CURDATE()"
        ElseIf cbooption.Text = "Weekly Report" Then
            sql = "SELECT i.`ItemID`, `Name`, `Description`, `Types`, `Price`,so.`Quantity`, `Unit`,TransactionDate FROM `tblitems` i ,`tblstock_in_out` so WHERE  i.`ItemID`=so.`ItemID` AND `Remarks`='StockIn' AND WEEKDAY(`TransactionDate`) >=0 AND WEEKDAY(`TransactionDate`) <=4"
        ElseIf cbooption.Text = "Monthly Report" Then
            sql = "SELECT i.`ItemID`, `Name`, `Description`, `Types`, `Price`,so.`Quantity`, `Unit`,TransactionDate FROM `tblitems` i ,`tblstock_in_out` so WHERE  i.`ItemID`=so.`ItemID` AND `Remarks`='StockIn' AND MONTH(`TransactionDate`)=MONTH(CURDATE())"
        End If

        reports(sql, "itemlist", CrystalReportViewer1)
    End Sub
End Class