Public Class frm_stockreturn
    Dim returnid As Integer
    Dim stockinID As Integer = 0
    Dim stockoutID As Integer = 0
    Dim stockreturnID As Integer = 0
    Private Sub frm_stockreturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sql = "SELECT `ITEMID` as 'Item Id', `NAME` as 'Name', `DESCRIPTION` as 'Description', `PRICE` as 'Price', `QTY` as 'Available Quantity' FROM `tblitems`"
        'reloadDtg(sql, dtgCus_itemlist)

        '   sql = "SELECT ITEMID FROM tblitems"
        '  autocompletetxt(sql, txtSup_itemid)
        '------------------------------------auto stock in
        '  reloadtxt("SELECT concat(STRT,END) FROM tblautonumber WHERE ID = 4")
        ' stockinID = dt.Rows(0).Item(0)
        ''------------------------------------auto stock out
        '  reloadtxt("SELECT concat(STRT,END) FROM tblautonumber WHERE ID = 5")
        '  stockoutID = dt.Rows(0).Item(0)
        '------------------------------------auto stock return
        ' reloadtxt("SELECT concat(STRT,END) FROM tblautonumber WHERE ID = 6")
        ' stockreturnID = dt.Rows(0).Item(0)

        '   TabControl1.TabPages.Remove(TabPage1)
        btnadditem.Enabled = False

    End Sub

    Private Sub txttransactionid_TextChanged(sender As Object, e As EventArgs) Handles txttransactionid.TextChanged
        Try

            If txttransactionid.Text <> "" Then

                sql = "SELECT p.CustomerID, `FirstName`, `LastName` ,`Address` FROM  `tbltransaction` t, `tblperson`  p  WHERE t.`SupplierCustomerID`=p.`CustomerID` AND `TransactionNumber`='" & txttransactionid.Text & "'"
                reloadtxt(sql)
                returnid = dt.Rows(0).Item("CustomerID")
                txtlastfirstname.Text = dt.Rows(0).Item("FirstName") & " " & dt.Rows(0).Item("LastName")
                txtaddress.Text = dt.Rows(0).Item("Address")

                sql = "SELECT   i.`ItemID`, `Name`, `Description`, `Price`,`TransactionDate`, o.`Quantity`, `TotalPrice`,`StockOutID` FROM  `tblitems` i , `tblstock_in_out` o WHERE i.`ItemID`=o.`ItemID` AND `TransactionNumber`='" & txttransactionid.Text & "'"
                reloadDtg(sql, dtgreturnitemlist)
                dtgreturnitemlist.Columns(7).Visible = False
            Else
                txtlastfirstname.Clear()
                txtaddress.Clear()
                dtgreturnitemlist.Columns.Clear()
            End If


        Catch ex As Exception

        End Try
    End Sub


    Private Sub dtgreturn_cart_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dtgreturncart.CellValueChanged
        Try
            If dtgreturncart.CurrentCell.ColumnIndex = 4 Then
                Dim total As Double
                For Each row As DataGridViewRow In dtgreturncart.Rows
                    total = row.Cells(4).Value * row.Cells(3).Value
                    row.Cells(5).Value = total
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnreturn_Search_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnadditem_Click(sender As Object, e As EventArgs) Handles btnadditem.Click

        Try


            If dtgreturncart.RowCount = 0 Then
                With dtgreturnitemlist.CurrentRow
                    dtgreturncart.ColumnCount = 7
                    dtgreturncart.Columns(0).Name = "Item Id"
                    dtgreturncart.Columns(1).Name = "Item Name"
                    dtgreturncart.Columns(2).Name = "Description"
                    dtgreturncart.Columns(3).Name = "Price"
                    dtgreturncart.Columns(4).Name = "Quantity"
                    dtgreturncart.Columns(5).Name = "Total Price"
                    Dim row As String() = New String() { .Cells(0).Value,
                                                   .Cells(1).Value,
                                                       .Cells(2).Value,
                                                       .Cells(3).Value,
                                                       .Cells(5).Value,
                                                       .Cells(6).Value,
                                                       .Cells(7).Value}
                    dtgreturncart.Rows.Add(row)

                End With

            Else
                If dtgreturncart.CurrentRow.Cells(0).Value <> dtgreturnitemlist.CurrentRow.Cells(0).Value Then
                    With dtgreturnitemlist.CurrentRow
                        dtgreturncart.ColumnCount = 7
                        dtgreturncart.Columns(0).Name = "Item Id"
                        dtgreturncart.Columns(1).Name = "Item Name"
                        dtgreturncart.Columns(2).Name = "Description"
                        dtgreturncart.Columns(3).Name = "Price"
                        dtgreturncart.Columns(4).Name = "Quantity"
                        dtgreturncart.Columns(5).Name = "Total Price"
                        Dim row As String() = New String() { .Cells(0).Value,
                                                        .Cells(1).Value,
                                                       .Cells(2).Value,
                                                       .Cells(3).Value,
                                                       .Cells(5).Value,
                                                       .Cells(6).Value,
                                                       .Cells(7).Value}
                        dtgreturncart.Rows.Add(row)

                    End With


                Else
                    MsgBox("Item is already in the cart", MsgBoxStyle.Exclamation)
                End If
            End If



        Catch ex As Exception
            'dtgreturn_cart.Columns(7).Visible = False
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnreturnadd_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txttransactionid.Text = "" Then
            MsgBox("There are empty fields left that must be fill up!", MsgBoxStyle.Exclamation)
            Return
        End If

        If dtgreturncart.RowCount = 0 Then
            MsgBox("Cart is empty!", MsgBoxStyle.Exclamation)
            Return
        End If
        sql = "SELECT `ItemID`, `Quantity` FROM `tblstock_in_out` WHERE  `TransactionNumber` ='" & txttransactionid.Text & "'"
        reloadtxt(sql)
        For Each row As DataRow In dt.Rows
            For i As Integer = 0 To dtgreturncart.Rows.Count - 1
                If dtgreturncart.Rows(i).Cells(0).Value = row.Item(0) Then
                    'MsgBox(row.Item(0))
                    If dtgreturncart.Rows(i).Cells(4).Value > row.Item(1) Then
                        MsgBox("The Quantity of the item ( " & dtgreturncart.Rows(i).Cells(1).Value & " ) is greater than the available quantity of it.", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If

                End If
                'If dtCus_addedlist.Rows(i).Cells(4).Value = "" Then
                '    MsgBox("Set your purpose.", MsgBoxStyle.Exclamation)
                '    Return
                'End If
            Next
        Next



        For Each r As DataGridViewRow In dtgreturncart.Rows
            sql = "INSERT INTO `tblstock_return` (  `StockReturnNumber`, `ItemID`, `ReturnDate`, `Quantity`, `TotalPrice`, `OwnerCustomerID`)" &
            " VALUES ('" & stockreturnID & "','" & r.Cells(0).Value & "','" & Format(Now, "yyyy-MM-dd") & "','" & r.Cells(4).Value &
            "','" & r.Cells(5).Value & "','" & returnid & "')"
            createNoMsg(sql)
            '-----------------------------------------------update item
            sql = "UPDATE `tblitems`  SET `Quantity`=`Quantity` + '" & r.Cells(4).Value & "' WHERE ItemID='" & r.Cells(0).Value & "'"
            createNoMsg(sql)

            sql = "UPDATE `tblstock_in_out` SET  `Quantity`=`Quantity`-'" & r.Cells(4).Value & "', `TotalPrice`=`TotalPrice`-'" & r.Cells(5).Value & "'  WHERE `StockOutID` ='" & r.Cells(6).Value & "'"
            createNoMsg(sql)

        Next
        '--------------------------------------------------
        sql = "INSERT INTO  `tbltransaction` (`TransactionNumber`,  `TransactionDate`,  `Type`, `SupplierCustomerID`)" &
                " VALUES ('" & txttransactionid.Text & "','" & Format(Now, "yyyy-MM-dd") & "','Returned','" & returnid & "')"
        createNoMsg(sql)
        '-----------------------------------------------update autonumber
        createNoMsg("UPDATE tblautonumber SET END= END + INCREMENT WHERE ID = 6")
        '------------------------------------auto stock in
        ' reloadtxt("SELECT concat(STRT,END) FROM tblautonumber WHERE ID = 6")
        'stockreturnID = dt.Rows(0).Item(0)
        '--------------------------------------------a----------------
        MsgBox("Item(s) has been returned.")
        '------------------------------------------------------------clearing
        ' cleartext(Panel6)
        dtgreturncart.Columns.Clear()
        dtgreturnitemlist.Columns.Clear()
        txtlastfirstname.Text = ""
        txtaddress.Text = ""
        txttransactionid.Text = ""
        btnadditem.Enabled = False
    End Sub

    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        Try
            dtgreturncart.Rows.Remove(dtgreturncart.CurrentRow)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        dtgreturncart.Columns.Clear()
    End Sub



    Private Sub btnviewlist_Click(sender As Object, e As EventArgs) Handles btnviewlist.Click
        frm_viewstockreturn.Show()
    End Sub

    Private Sub btnreturn_transaction_Click(sender As Object, e As EventArgs) Handles btnreturn_transaction.Click
        frm_viewtransaction.Show()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class