Imports System.Convert
Public Class frmSuppliers
    Private lisSupplier As ArrayList
    Private QuerySupplier As Queries = New Queries
    Private tblSupplier As DataTable

    Private Sub frmSuppliers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmMain

        RemoveHandler lisCompany.SelectedIndexChanged, _
        AddressOf lisCompany_SelectedIndexChanged

        lisSupplier = QuerySupplier.ReadSupplierList
        lisCompany.DataSource = lisSupplier
        lisCompany.DisplayMember = "Company"
        

        AddHandler lisCompany.SelectedIndexChanged, _
        AddressOf lisCompany_SelectedIndexChanged

    End Sub


    Private Sub lisCompany_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lisCompany.SelectedIndexChanged
        Dim lisInfo As ListBox
        Dim intSV As Integer
        lisInfo = sender
        intSV = lisInfo.SelectedIndex + 1
        tblSupplier = QuerySupplier.ReadSuppliers(intSV)
        txtCompName.Text = tblSupplier.Rows(0).Item(1)
        txtContact.Text = tblSupplier.Rows(0).Item(2)
        txtPhone.Text = tblSupplier.Rows(0).Item(3)
    End Sub
End Class