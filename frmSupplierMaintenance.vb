Public Class frmSupplierMaintenance

    Private Sub SuppliersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppliersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SuppliersBindingSource.EndEdit()

        Me.TableAdapterManager.UpdateAll(Me.NorthwindsDataSet)

    End Sub

    Private Sub frmSupplierMaintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NorthwindsDataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.NorthwindsDataSet.Suppliers)

    End Sub
End Class