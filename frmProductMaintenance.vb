Imports System.Data.SqlClient
Imports System.Convert
Public Class frmProductMaintenance
    Private SelectQ As New Queries
    Private QMaintenance As New MaintenanceQueries
    Private blnChangesMade As Boolean
    Private intcurrentrow As Integer
    Private UpdatedProduct As ProductClass
    Private ProductArray As New ArrayList
    Private ProductAdded As ProductClass
    Private PAddedArray As New ArrayList

    Private Sub ProductsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call UpdateDB()


    End Sub

    Private Sub frmProdMainTest_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Validate()
        Me.ProductsTableAdapter.Update(NorthwindsDataSet.Products)
        Me.ProductsBindingSource.EndEdit()

        Me.ProductsTableAdapter.Update(Me.NorthwindsDataSet.Products)

    End Sub

    Private Sub frmProdMainTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NorthwindsDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.NorthwindsDataSet.Products)


        Me.MdiParent = frmMain

    End Sub

    Private Sub UpdateDB()
        Dim intPID As Integer
        Dim strName As String
        Dim lngCID As Integer
        Dim lngSID As Integer
        Dim strQPU As String
        Dim sngUPrice As Single
        Dim intUIS As Integer
        Dim intUOO As Integer
        Dim intReord As Integer
        Dim intDIS As Integer
        Try
            intPID = ToInt32(ProductIDTextBox.Text)
            strName = ProductNameTextBox.Text
            lngSID = ToInt32(SupplierIDTextBox.Text)
            lngCID = ToInt32(CategoryIDTextBox.Text)
            strQPU = QuantityPerUnitTextBox.Text
            sngUPrice = ToSingle(UnitPriceTextBox.Text)
            intUIS = ToInt32(UnitsInStockTextBox.Text)
            intUOO = ToInt32(UnitsOnOrderTextBox.Text)
            intReord = ToInt32(ReorderLevelTextBox.Text)
            intDIS = ToInt32(DiscontinuedCheckBox.Checked)
            UpdatedProduct = New ProductClass(intPID, strName, lngSID, lngCID, strQPU, sngUPrice, intUIS, intUOO, intReord, intDIS)
            ProductArray.Add(UpdatedProduct)

        Catch ex As Exception
            Dim strEx As String
            strEx = ex.Message
        End Try

    End Sub



    Private Sub BindingNavigatorUpdateDatabase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strUpdated As String = ""
        Dim strAdded As String = ""
        Dim strOut As String
        For Each P As ProductClass In ProductArray
            strUpdated = QMaintenance.Update(P.ProductName, P.SupplierID, P.CategoryID, P.QuanitityPerUnit, P.UnitPrice, P.UnitsInStock, P.UnitsOnOrder, P.ReorderLevel)
        Next
        For Each P As ProductClass In PAddedArray
            strUpdated = QMaintenance.Update(P.ProductName, P.SupplierID, P.CategoryID, P.QuanitityPerUnit, P.UnitPrice, P.UnitsInStock, P.UnitsOnOrder, P.ReorderLevel)
        Next
        strOut = strAdded & "; " & strUpdated
        MessageBox.Show(strOut, "Records Added and Updated", MessageBoxButtons.OK)
    End Sub

    Private Sub AddtoDB()
        Dim intPID As Integer
        Dim strName As String
        Dim lngCID As Integer
        Dim lngSID As Integer
        Dim strQPU As String
        Dim sngUPrice As Single
        Dim intUIS As Integer
        Dim intUOO As Integer
        Dim intReord As Integer
        Dim intDIS As Integer
        Try
            intPID = ToInt32(ProductIDTextBox.Text)
            strName = ProductNameTextBox.Text
            lngSID = ToInt32(SupplierIDTextBox.Text)
            lngCID = ToInt32(CategoryIDTextBox.Text)
            strQPU = QuantityPerUnitTextBox.Text
            sngUPrice = ToSingle(UnitPriceTextBox.Text)
            intUIS = ToInt32(UnitsInStockTextBox.Text)
            intUOO = ToInt32(UnitsOnOrderTextBox.Text)
            intReord = ToInt32(ReorderLevelTextBox.Text)
            intDIS = ToBoolean(DiscontinuedCheckBox.Checked)
            UpdatedProduct = New ProductClass(intPID, strName, lngSID, lngCID, strQPU, sngUPrice, intUIS, intUOO, intReord, intDIS)
            ProductArray.Add(UpdatedProduct)
            ProductAdded = New ProductClass(intPID, strName, lngSID, lngCID, strQPU, sngUPrice, intUIS, intUOO, intReord, intDIS)

            PAddedArray.Add(ProductAdded)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ProductsBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductsBindingNavigatorSaveItem.Click
        UpdateDB()
    End Sub
End Class