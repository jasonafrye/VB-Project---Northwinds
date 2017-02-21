Public Class frmCategoryMaintenance

    Private UpdatedCategory As New CategoryClass
    Private CategoryArray As New ArrayList



    Private Sub CategoriesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoriesBindingNavigatorSaveItem.Click
        Me.Validate()
        CategoriesTableAdapter.Update(NorthwindsDataSet.Categories)
        CategoriesBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(NorthwindsDataSet)


    End Sub

    Private Sub frmCategoryMaintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NorthwindsDataSet.Categories' table. You can move, or remove it, as needed.
        Me.CategoriesTableAdapter.Fill(Me.NorthwindsDataSet.Categories)

    End Sub

    
End Class