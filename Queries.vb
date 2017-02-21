Imports System.Data.SqlClient
Public Class Queries
    'Declaare a new instance of the SQLCommand object
    Private cmdSelect As New SqlCommand
    'Declare a new instance of the DataTable object
    Private tblProducts = New DataTable
    'Declare a new instance of the ConnectionClass
    'Since the code to create the connection and open it 
    'is in the constructor of this class, this will create the connection
    'and open it.
    Private ConIn As New ConnectionClass


#Region "Supplier queries and readers"
    Private Sub GetSupplierList()
        Dim strSelect As String
        strSelect = "Select SupplierID, CompanyName"
        strSelect &= " from Suppliers"
        cmdSelect.Connection = ConIn.Con
        cmdSelect.CommandText = strSelect
    End Sub
    Private Sub GetSuppliers(ByVal SVin As Long)
        Dim strSelect As String
        Dim strdebug As String

        strSelect = "SELECT SupplierID, CompanyName, ContactName, Phone "
        strSelect &= " FROM Suppliers "
        strSelect &= " WHERE (SupplierID = @ID ) "
        cmdSelect.Connection = ConIn.Con
        cmdSelect.CommandText = strSelect
        cmdSelect.Parameters.Add("@ID", SqlDbType.Int).Value = SVin
        strdebug = strSelect
    End Sub
    Public Function ReadSupplierList() As ArrayList
        'Define a variable as having an SQLDataReader type

        Dim lisSupplier As New ArrayList

        Try
            'Call the subroutine located in this class that will
            'fill setup the SQLCommand, cmdSelect
            Call GetSupplierList()

            Dim blnMoreData As Boolean
            Dim dbr As SqlDataReader
            dbr = cmdSelect.ExecuteReader
            blnMoreData = dbr.Read
            Do While blnMoreData

                Dim intSID As Integer
                Dim strComp As String
                intSID = dbr.GetInt32(0)
                strComp = dbr.GetString(1)
                lisSupplier.Add(New Supplier(intSID, strComp))
                blnMoreData = dbr.Read
            Loop
            dbr.Close()


        Catch sqlEx As SqlException
            Dim strout As String
            strout = sqlEx.Message
            Console.WriteLine(strout)
        End Try
        Return lisSupplier
    End Function
    Public Function ReadSuppliers(ByVal SVin As Integer) As DataTable
        Dim dbr As SqlDataReader = Nothing

        Dim tblSupplier As New DataTable

        Try
            'Call the subroutine located in this class that will
            'fill setup the SQLCommand, cmdSelect
            Call GetSuppliers(SVin)
            dbr = cmdSelect.ExecuteReader
            If dbr.HasRows Then
                tblSupplier.Load(dbr)

            End If
        Catch ex As Exception
            Dim strOut As String
            strOut = ex.Message
        Finally
            cmdSelect.Parameters.Clear()
            dbr.Close()
        End Try
        Return tblSupplier
    End Function
#End Region
#Region "Products queries, readers and properties"
    Private Sub OrderDetailsProducts()
        'Holds the query that links orderdetails and products
        Dim strSelect As String
        strSelect = "SELECT [Order Details].OrderID, [Order Details].Discount, [Order Details].ProductID, [Order Details].UnitPrice, [Order Details].Quantity, Products.ProductName"
        strSelect &= " FROM ([Order Details] INNER JOIN"
        strSelect &= " Products ON [Order Details].ProductID = Products.ProductID)"
        cmdSelect.Connection = ConIn.Con
        cmdSelect.CommandText = strSelect
    End Sub

    Public Function ReadProdByName(ByVal SVin As Integer) As DataTable
        Dim dbr As SqlDataReader = Nothing

        Dim tblProdByName As New DataTable

        Try
            'Call the subroutine located in this class that will
            'fill setup the SQLCommand, cmdSelect
            Call GetProdByName(SVin)
            dbr = cmdSelect.ExecuteReader
            If dbr.HasRows Then
                tblProdByName.Load(dbr)

            End If
        Catch ex As Exception
            Dim strOut As String
            strOut = ex.Message
        Finally
            cmdSelect.Parameters.Clear()
            dbr.Close()
        End Try
        Return tblProdByName

    End Function

    Public Function ReadProdByNameList() As ArrayList
        'Define a variable as having an SQLDataReader type

        Dim lisProdByName As New ArrayList

        Try
            'Call the subroutine located in this class that will
            'fill setup the SQLCommand, cmdSelect
            Call GetProdByNameList()

            Dim blnMoreData As Boolean
            Dim dbr As SqlDataReader
            dbr = cmdSelect.ExecuteReader
            blnMoreData = dbr.Read
            Do While blnMoreData

                Dim intPID As Integer
                Dim strProdName As String
                intPID = dbr.GetInt32(0)
                strProdName = dbr.GetString(1)
                lisProdByName.Add(New Product(intPID, strProdName))
                blnMoreData = dbr.Read
            Loop
            dbr.Close()


        Catch sqlEx As SqlException
            Dim strout As String
            strout = sqlEx.Message
            Console.WriteLine(strout)
        End Try
        Return lisProdByName
    End Function

    Private Sub GetProdByName(ByVal SVin As Long)
        Dim strSelect As String
        Dim strdebug As String

        strSelect = "SELECT ProductID, ProductName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued"
        strSelect &= " FROM Products "
        strSelect &= " WHERE (ProductID = @ID ) "
        cmdSelect.Connection = ConIn.Con
        cmdSelect.CommandText = strSelect
        cmdSelect.Parameters.Add("@ID", SqlDbType.Int).Value = SVin
        strdebug = strSelect
    End Sub

    Private Sub GetProdByNameList()
        Dim strSelect As String
        strSelect = "Select ProductID, ProductName"
        strSelect &= " from Products"
        cmdSelect.Connection = ConIn.Con
        cmdSelect.CommandText = strSelect
    End Sub


    Public Sub ProductsbyName()

        'disregard?
    End Sub
    'property that enables the form to access the datatable.
    Public ReadOnly Property ProductsTable() As DataTable
        Get
            Return tblProducts
        End Get
    End Property
    Private Sub SelectProductsbyCategories()
        'Declare the string to hold the SQL
        Dim strSelect As String
        'Set the connection for the cmdSelect instance of the 
        'SQLCommand object to the CON property of the
        'Connection class
        cmdSelect.Connection = ConIn.Con
        'Create the command by placing the needed SQL statement 
        'into a string variable.
        strSelect = "SELECT Categories.CategoryName, Products.ProductName "
        strSelect &= "FROM Categories JOIN "
        strSelect &= "Products ON Categories.CategoryID = Products.CategoryID "
        strSelect &= "Order By Categories.Categoryname"
        'Set the CommandText property of the cmdSelect object to
        'the string that was just filled with the SQL statement.
        cmdSelect.CommandText = strSelect
    End Sub
    Public Sub ReadProducts()
        'Define a variable as having an SQLDataReader type
        Dim dbr As SqlDataReader
        Try
            'Call the subroutine located in this class that will
            'fill setup the SQLCommand, cmdSelect
            Call SelectProductsbyCategories()
            'Setup SQLDataReader options by telling it that when
            'the database has been read, it should close the connection
            dbr = cmdSelect.ExecuteReader(CommandBehavior.CloseConnection)
            'read the database selecting the records indicated by the SQL statement
            dbr.Read()
            'Fill the DataTable from the SQLDataReader.
            tblProducts.Load(dbr)
        Catch sqlEx As SqlException
            Dim strout As String
            strout = sqlEx.Message
            Console.WriteLine(strout)
        End Try
    End Sub
#End Region
#Region "Categories queries, readers and properties"
    Public Function ReadProdbyCat(ByVal CIDin As Integer) As DataTable
        Dim tblProd As New DataTable
        Dim dbr As SqlDataReader
        Dim cmdSelectCat As New SqlCommand
        Call GetProdbyCat(CIDin, cmdSelectCat)
        Try
            dbr = cmdSelectCat.ExecuteReader
            If dbr.HasRows Then
                tblProd.Load(dbr)
            End If
            Return tblProd
        Catch ex As Exception
            Dim strOut As String
            strOut = ex.Message
        Finally
            cmdSelect.Parameters.Clear()
            '  dbr.Close()
        End Try
        Return tblProd
    End Function
    Private Sub GetProdbyCat(ByVal CIDin As Integer, ByVal cmdSelect As SqlCommand)
        Dim strSelect As String

        strSelect = "SELECT Categories.CategoryID, Categories.CategoryName, Categories.Description, Products.ProductName, Products.UnitPrice, Products.UnitsInStock, Suppliers.CompanyName"
        strSelect &= " FROM Suppliers INNER JOIN"
        strSelect &= " Products ON Suppliers.SupplierID = Products.SupplierID INNER JOIN"
        strSelect &= " Categories ON Products.CategoryID = Categories.CategoryID"
        strSelect &= " WHERE Categories.CategoryID = @CatID"
        cmdSelect.Connection = ConIn.Con
        cmdSelect.CommandText = strSelect
        cmdSelect.Parameters.Add("@CatID", SqlDbType.Int).Value = CIDin

    End Sub
    Private Sub GetCatList()
        Dim strSelect As String
        strSelect = "Select CategoryID, CategoryName"
        strSelect &= " from Categories"
        cmdSelect.Connection = ConIn.Con
        cmdSelect.CommandText = strSelect
    End Sub
    Public Function ReadCatList() As ArrayList
        Dim lisCat As New ArrayList
        Dim Cat1 As New Categories
        Try
            Call GetCatList()
            Dim blnMoreData As Boolean
            Dim dbr As SqlDataReader
            dbr = cmdSelect.ExecuteReader
            blnMoreData = dbr.Read
            Do While blnMoreData
                Dim intCID As Integer
                Dim strCName As String
                intCID = dbr.GetInt32(0)
                strCName = dbr.GetString(1)
                lisCat.Add(New Categories(intCID, strCName))
                blnMoreData = dbr.Read
            Loop
            dbr.Close()


        Catch sqlEx As SqlException
            Dim strout As String
            strout = sqlEx.Message
            Console.WriteLine(strout)
        End Try
        Return lisCat

    End Function

#End Region











End Class

