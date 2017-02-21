Public Class frmProductsbyCat

    Private Sub frmProducts_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.MdiParent = frmMain
            'Create a new instance of the queries class
            Dim newQuery As New Queries
            'Call the ReadProducts method in the queries class
            newQuery.ReadProducts()
            'Set the DataSource property of the DataGrid Products to the 
            'ProductsTable property in the newQuery instance of Queries.
            dgProducts.DataSource = newQuery.ProductsTable
        Catch ex As Exception
            Dim strOUt As String
            strOUt = ex.Message
            MessageBox.Show(strOUt, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
