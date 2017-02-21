Public Class frmProdCat
    Private lisCat As ArrayList
    Private CatQuery As New Queries
    Private tblCategories As DataTable
    Private Sub frmProdCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmMain
        RemoveHandler cboCat.SelectedIndexChanged, _
        AddressOf cboCat_SelectedIndexChanged
        lisCat = CatQuery.ReadCatList
        cboCat.DataSource = lisCat
        cboCat.DisplayMember = "CName"
        AddHandler cboCat.SelectedIndexChanged, _
        AddressOf cboCat_SelectedIndexChanged

    End Sub

    Private Sub cboCat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCat.SelectedIndexChanged
        Dim cboIn As ComboBox
        Dim intSV As Integer
        cboIn = sender
        intSV = cboIn.SelectedIndex + 1
        tblCategories = CatQuery.ReadProdbyCat(intSV)
        dgCatProd.DataSource = tblCategories

    End Sub
End Class