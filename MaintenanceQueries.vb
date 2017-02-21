Imports System.Data.SqlClient

Public Class MaintenanceQueries
    Private conCon As New ConnectionClass
    Private cmdUP As New SqlCommand
    Private cmdAdd As New SqlCommand
#Region "Products Table"
    Private Sub UpdateSQL(ByVal Namein As String, ByVal SIDin As Long, ByVal CIDin As Long, ByVal QPUin As String, _
                            ByVal Pricein As Decimal, ByVal UISin As Integer, ByVal UOOin As Integer, _
                            ByVal Reorderin As Integer)
        cmdUP = New SqlCommand
        conCon = New ConnectionClass
        Dim strSql As String
        strSql = "UPDATE Products"
        strSql &= " SET ProductName = @PName, SupplierID = @SID, CategoryID = @CID, QuantityPerUnit = @QPU, UnitPrice = @UnitPrice, "
        strSql &= " UnitsInStock = @UIS, UnitsOnOrder = @UOO, ReorderLevel = @Reorder"
        strSql &= " WHERE (ProductName = @strCurrentName)"
        cmdUP.Parameters.Add("@PName", SqlDbType.NVarChar).Value = Namein
        cmdUP.Parameters.Add("SID", SqlDbType.Int).Value = SIDin
        cmdUP.Parameters.Add("@CID", SqlDbType.Int).Value = CIDin
        cmdUP.Parameters.Add("@QPU", SqlDbType.NVarChar).Value = QPUin
        cmdUP.Parameters.Add("@UnitPrice", SqlDbType.Decimal).Value = Pricein
        cmdUP.Parameters.Add("@UIS", SqlDbType.Int).Value = UISin
        cmdUP.Parameters.Add("@UOO", SqlDbType.Int).Value = UOOin
        cmdUP.Parameters.Add("@Reorder", SqlDbType.Int).Value = Reorderin
        'cmdUP.Parameters.Add("@Dis", SqlDbType.Variant).Value = DISin
        cmdUP.Parameters.Add("@strCurrentName", SqlDbType.NVarChar).Value = Namein
        cmdUP.Connection = conCon.Con
        cmdUP.CommandText = strSql

    End Sub
    Public Function Update(ByVal Namein As String, ByVal SIDin As Long, ByVal CIDin As Long, ByVal QPUin As String, _
                            ByVal Pricein As Decimal, ByVal UISin As Integer, ByVal UOOin As Integer, _
                            ByVal Reorderin As Integer) As String
        Dim strUpdateMsg As String
        Dim intRowsUpdated As Integer
        Call UpdateSQL(Namein, SIDin, CIDin, QPUin, Pricein, UISin, UOOin, Reorderin)
        intRowsUpdated = cmdUP.ExecuteNonQuery()
        strUpdateMsg = intRowsUpdated.ToString & " were updated."
        Return strUpdateMsg
    End Function
    Private Sub AddSQL(ByVal Namein As String, ByVal SIDin As Long, ByVal CIDin As Long, ByVal QPUin As String, _
                            ByVal Pricein As Decimal, ByVal UISin As Integer, ByVal UOOin As Integer, _
                            ByVal Reorderin As Integer)
        Dim strSQL As String
        cmdAdd = New SqlCommand
        conCon = New ConnectionClass
        strSQL = "INSERT INTO Products"
        strSQL &= " (ProductName, SupplierID, CategoryID, QuantityPerUnit,"
        strSQL &= " UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel)"
        strSQL = " VALUES (@PName,@SID,@CID,@QPU,@UnitPrice,@UIS,@UOO,@REORDER)"
        cmdUP.Parameters.Add("@PName", SqlDbType.NVarChar).Value = Namein
        cmdUP.Parameters.Add("SID", SqlDbType.Int).Value = SIDin
        cmdUP.Parameters.Add("@CID", SqlDbType.Int).Value = CIDin
        cmdUP.Parameters.Add("@QPU", SqlDbType.NVarChar).Value = QPUin
        cmdUP.Parameters.Add("@UnitPrice", SqlDbType.Decimal).Value = Pricein
        cmdUP.Parameters.Add("@UIS", SqlDbType.Int).Value = UISin
        cmdUP.Parameters.Add("@UOO", SqlDbType.Int).Value = UOOin
        cmdUP.Parameters.Add("@Reorder", SqlDbType.Int).Value = Reorderin
        cmdAdd.Connection = conCon.Con
        cmdAdd.CommandText = strSQL
    End Sub
    Public Function Add(ByVal Namein As String, ByVal SIDin As Long, ByVal CIDin As Long, ByVal QPUin As String, _
                            ByVal Pricein As Decimal, ByVal UISin As Integer, ByVal UOOin As Integer, _
                            ByVal Reorderin As Integer) As String
        Dim strAddMsg As String
        Dim intRowsAdded As Integer
        Dim strsqlLocal As String
        Call AddSQL(Namein, SIDin, CIDin, QPUin, Pricein, UISin, UOOin, Reorderin)
        intRowsAdded = cmdAdd.ExecuteNonQuery
        strsqlLocal = "Select Ident_current('Products') from Products"
        'cmdAdd = New SqlCommand
        'cmdAdd.Connection = conCon.Con
        'cmdAdd.CommandText = strsqlLocal

        strAddMsg = intRowsAdded.ToString & " were added."
        Return strAddMsg
    End Function
    
#End Region

#Region "Categories Table"
    Private Sub UpdateCat(ByVal NameIn As String, ByVal DescIn As String)
        cmdUP = New SqlCommand
        conCon = New ConnectionClass
        Dim strSql As String
        strSql = "UPDATE Categories"
        strSql &= " SET CategoryName = @CName, Description = @Desc"
        strSql &= " WHERE (CategoryName = @strCurrentName)"
        cmdUP.Parameters.Add("@CName", SqlDbType.NVarChar).Value = NameIn
        cmdUP.Parameters.Add("@Desc", SqlDbType.NText).Value = DescIn
        cmdUP.Connection = conCon.Con
        cmdUP.CommandText = strSql



    End Sub

#End Region

#Region "Suppliers Table"

#End Region


End Class
