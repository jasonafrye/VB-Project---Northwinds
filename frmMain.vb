Public Class frmMain


    Private Sub ProductsByCatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductsByCatToolStripMenuItem.Click
        frmProductsbyCat.Show()
    End Sub

    Private Sub CustomersByNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomersByNameToolStripMenuItem.Click
        frmSuppliers.Show()
    End Sub

    Private Sub CategoriesProductsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoriesProductsToolStripMenuItem.Click
        frmProdCat.Show()
    End Sub
    Private Sub ProductsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductsToolStripMenuItem.Click
        frmProductMaintenance.Show()
    End Sub

    Private Sub ProductsByNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductsByNameToolStripMenuItem.Click
        frmProdByName.Show()

    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()

    End Sub

    
    Private Sub CategoriesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoriesToolStripMenuItem.Click
        frmCategoryMaintenance.Show()

    End Sub

    Private Sub SuppliersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppliersToolStripMenuItem.Click
        frmSupplierMaintenance.Show()

    End Sub
End Class