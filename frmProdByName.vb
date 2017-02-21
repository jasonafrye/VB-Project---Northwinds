Imports System.Convert
Public Class frmProdByName
    Private lisProductList As ArrayList
    Private QueryProduct As Queries = New Queries
    Private tblProduct As DataTable

    Private Sub frmProdByName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'load form as a child of the main form
        Me.MdiParent = frmMain

        'disable selectindexchanged event until the listbox has been populted
        RemoveHandler lisProduct.SelectedIndexChanged, _
        AddressOf lisProduct_SelectedIndexChanged

        'call the query to load the arraylist of the products table. 
        lisProductList = QueryProduct.ReadProdByNameList

        'set the listbox datasource to the arraylist and select the property to be displayed
        lisProduct.DataSource = lisProductList
        lisProduct.DisplayMember = "ProductName"

        'enable selectedindexchanged event
        AddHandler lisProduct.SelectedIndexChanged, _
        AddressOf lisProduct_SelectedIndexChanged

    End Sub


    Private Sub lisProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lisProduct.SelectedIndexChanged
        'declare variable
        Dim lisInfo As ListBox
        Dim intSV As Integer
        lisInfo = sender
        intSV = lisInfo.SelectedIndex + 1

        'set datatable to query results
        tblProduct = QueryProduct.ReadProdByName(intSV)

        'allocate the entry columns to the appropriate textboxes
        txtProdName.Text = tblProduct.Rows(0).Item(1)
        txtProdID.Text = tblProduct.Rows(0).Item(0)
        txtProdQty.Text = tblProduct.Rows(0).Item(2)
        txtProdPrice.Text = tblProduct.Rows(0).Item(3)
        txtProdStock.Text = tblProduct.Rows(0).Item(4)
        txtProdOnOrder.Text = tblProduct.Rows(0).Item(5)
        txtProdReorder.Text = tblProduct.Rows(0).Item(6)
        chkDis.Checked = tblProduct.Rows(0).Item(7)
    End Sub
End Class