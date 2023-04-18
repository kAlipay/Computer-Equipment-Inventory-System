Public Class frm_stockin
    Dim returnid As Integer
    Dim stockinID As Integer = 0
    Dim stockoutID As Integer = 0
    Dim stockreturnID As Integer = 0
    Private Sub frm_stockin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT `ItemID` as 'Item Id', `Name` as 'Name', `Description` as 'Description', `Price` as 'Price', `Quantity` as 'Available Quantity' FROM `tblitems`"
        reloadDtg(sql, dtg_itemlist)

        '  sql = "SELECT ITEMID FROM tblitems"
        '   autocompletetxt(sql, txtSup_itemid)
        '------------------------------------auto stock in
        reloadtxt("SELECT concat(STRT,END) FROM tblautonumber WHERE ID = 4")
        stockinID = dt.Rows(0).Item(0)
        '------------------------------------auto stock out
        reloadtxt("SELECT concat(STRT,END) FROM tblautonumber WHERE ID = 5")
        stockoutID = dt.Rows(0).Item(0)
        '------------------------------------auto stock return
        '  reloadtxt("SELECT concat(STRT,END) FROM tblautonumber WHERE ID = 6")
        '  stockreturnID = dt.Rows(0).Item(0)

        ' TabControl1.TabPages.Remove(TabPage1)
    End Sub

    Private Sub txt_cusid_TextChanged(sender As Object, e As EventArgs) Handles txtsupplierid.TextChanged
        Try
            sql = "SELECT * FROM `tblsupplier` WHERE `SupplierID`='" & txtsupplierid.Text & "'"
            reloadtxt(sql)
            If dt.Rows.Count > 0 Then
                txtfirstname.Text = dt.Rows(0).Item("FirstName")
                txtlastname.Text = dt.Rows(0).Item("LastName")
            Else
                txtfirstname.Clear()
                txtlastname.Clear()
            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub dtCus_addedlist_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dtg_addedlist.CellBeginEdit
        Try
            Dim total As Double
            For Each row As DataGridViewRow In dtg_addedlist.Rows
                total = row.Cells(4).Value * row.Cells(3).Value
                row.Cells(5).Value = total
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtCus_addedlist_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_addedlist.CellMouseLeave
        '   Try
        '  If dtg_addedlist.CurrentCell.ColumnIndex = 4 Then
        ' Dim total As Double
        'For Each row As DataGridViewRow In dtg_addedlist.Rows
        'total = row.Cells(4).Value * row.Cells(3).Value
        'row.Cells(5).Value = total
        'Next
        'End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub dtCus_addedlist_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_addedlist.CellValueChanged
        Try
            If dtg_addedlist.CurrentCell.ColumnIndex = 4 Then
                Dim total As Double
                For Each row As DataGridViewRow In dtg_addedlist.Rows
                    total = row.Cells(4).Value * row.Cells(3).Value
                    row.Cells(5).Value = total
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        sql = "SELECT `ItemID` as 'Item Id', `Name` as 'Name', `Description` as 'Description', `Price` as 'Price', `Quantity` as 'Available Quantity' FROM `tblitems` WHERE  `Name` like '%" & txtsearch.Text & "%' or `ItemID` = '" & txtsearch.Text & "'"
        reloadDtg(sql, dtg_itemlist)
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub btnadditem_Click(sender As Object, e As EventArgs) Handles btnadditem.Click
        Try
            If dtg_addedlist.RowCount = 0 Then
                With dtg_itemlist.CurrentRow
                    dtg_addedlist.ColumnCount = 6
                    dtg_addedlist.Columns(0).Name = "Item Id"
                    dtg_addedlist.Columns(1).Name = "Item Name"
                    dtg_addedlist.Columns(2).Name = "Description"
                    dtg_addedlist.Columns(3).Name = "Price"
                    dtg_addedlist.Columns(4).Name = "Quantity"
                    dtg_addedlist.Columns(5).Name = "Total Price"

                    Dim tot As Double = Double.Parse(.Cells(3).Value) * 1

                    Dim row As String() = New String() { .Cells(0).Value,
                                                    .Cells(1).Value,
                                                   .Cells(2).Value,
                                                   .Cells(3).Value,
                                                   1,
                                                   tot}
                    dtg_addedlist.Rows.Add(row)

                End With
            Else
                For Each r As DataGridViewRow In dtg_addedlist.Rows
                    If dtg_itemlist.CurrentRow.Cells(0).Value = r.Cells(0).Value Then
                        MsgBox("Item is already in the cart", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If
                Next
                If dtg_addedlist.CurrentRow.Cells(0).Value <> dtg_itemlist.CurrentRow.Cells(0).Value Then
                    With dtg_itemlist.CurrentRow
                        dtg_addedlist.ColumnCount = 6
                        dtg_addedlist.Columns(0).Name = "Item Id"
                        dtg_addedlist.Columns(1).Name = "Item Name"
                        dtg_addedlist.Columns(2).Name = "Description"
                        dtg_addedlist.Columns(3).Name = "Price"
                        dtg_addedlist.Columns(4).Name = "Quantity"
                        dtg_addedlist.Columns(5).Name = "Total Price"
                        Dim tot As Double = Double.Parse(.Cells(3).Value) * 1
                        Dim row As String() = New String() { .Cells(0).Value,
                                                        .Cells(1).Value,
                                                        .Cells(2).Value,
                                                       .Cells(3).Value,
                                                      1,
                                                       tot}
                        dtg_addedlist.Rows.Add(row)

                    End With


                Else
                    MsgBox("Item is already in the cart", MsgBoxStyle.Exclamation)
                End If
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If txtsupplierid.Text = "" Then
            MsgBox("There are empty fields left that must be fill up!", MsgBoxStyle.Exclamation)
            Return
        End If

        If dtg_addedlist.RowCount = 0 Then
            MsgBox("Cart is empty!", MsgBoxStyle.Exclamation)
            Return
        End If
        sql = "SELECT ItemID,`Quantity` FROM `tblitems`"
        reloadtxt(sql)
        ' For Each row As DataRow In dt.Rows
        'For i As Integer = 0 To dtCus_addedlist.Rows.Count - 1
        'If dtCus_addedlist.Rows(i).Cells(0).Value = row.Item(0) Then
        'MsgBox(row.Item(0))
        'If dtCus_addedlist.Rows(i).Cells(4).Value > row.Item(1) Then
        'MsgBox("The Quantity of the item ( " & dtCus_addedlist.Rows(i).Cells(1).Value & " ) is greater than the available quantity of it.", MsgBoxStyle.Exclamation)
        'Exit Sub
        'End If

        'End If
        'If dtCus_addedlist.Rows(i).Cells(4).Value = "" Then
        '    MsgBox("Set your purpose.", MsgBoxStyle.Exclamation)
        '    Return
        'End If
        'Next
        ' Next

        For Each r As DataGridViewRow In dtg_addedlist.Rows
            sql = "INSERT INTO `tblstock_in_out` ( `TransactionNumber`, `ItemID`, `TransactionDate`, `Quantity`, `TotalPrice`, `SupplierCustomerID`,Remarks)" &
            " VALUES ('" & stockoutID & "','" & r.Cells(0).Value & "','" & Format(Now, "yyyy-MM-dd") & "','" & r.Cells(4).Value &
            "','" & r.Cells(5).Value & "','" & txtsupplierid.Text & "','StockIn')"
            createNoMsg(sql)
            '-----------------------------------------------update item
            sql = "UPDATE `tblitems`  SET `Quantity`= Quantity + '" & r.Cells(4).Value & "' WHERE ItemID='" & r.Cells(0).Value & "'"
            createNoMsg(sql)
        Next
        '----------------------------------------------transaction
        sql = "INSERT INTO  `tbltransaction` (`TransactionNumber`,  `TransactionDate`,  `Type`, `SupplierCustomerID`)" &
       " VALUES ('" & stockoutID & "','" & Format(Now, "yyyy-MM-dd") & "','StockIn','" & txtsupplierid.Text & "')"
        createNoMsg(sql)
        '-----------------------------------------------update autonumber
        createNoMsg("UPDATE tblautonumber SET END= END + INCREMENT WHERE ID = 5")
        '------------------------------------auto stock in
        'reloadtxt("SELECT concat(STRT,END) FROM tblautonumber WHERE ID = 5")
        'stockoutID = dt.Rows(0).Item(0)

        reloadtxt("SELECT concat(STRT,END) FROM tblautonumber WHERE ID = 4")
        stockinID = dt.Rows(0).Item(0)
        '------------------------------------------------------------
        MsgBox("Item(s) has been save in the database.")
        '------------------------------------------------------------clearing
        '  cleartext(Panel1)
        dtg_addedlist.Rows.Clear()
        txtfirstname.Text = ""
        txtlastname.Text = ""
        txtsupplierid.Text = ""
        ' dtgreturn_itemlist.Rows.Clear()
        '----------------------------------------------------------------
        sql = "SELECT `ItemID` as 'Item Id', `Name` as 'Name', `Description` as 'Description', `Price` as 'Price', `Quantity` as 'Available Quantity' FROM `tblitems`"
        reloadDtg(sql, dtg_itemlist)
    End Sub

    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        Try
            dtg_addedlist.Rows.Remove(dtg_addedlist.CurrentRow)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        dtg_addedlist.Rows.Clear()
    End Sub

    Private Sub btnviewlist_Click(sender As Object, e As EventArgs) Handles btnviewlist.Click
        frm_viewstockin.Show()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnviewcustomer_Click(sender As Object, e As EventArgs) Handles btnviewcustomer.Click
        frm_viewsupplier.Show()

    End Sub
End Class