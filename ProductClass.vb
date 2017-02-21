Public Class ProductClass
    Private ProdID As Integer
    Private ProdName As String
    Private ProdQty As String
    Private ProdPrice As Single
    Private ProdStock As Integer
    Private ProdOnOrder As Integer
    Private ProdReorder As Integer
    Private ProdDis As Integer
    Private ProdCatID As Integer
    Private ProdSuppID As Integer

    Sub New(ByVal intPID As Integer, ByVal strName As String, ByVal lngSID As Integer, ByVal lngCID As Integer, ByVal strQPU As String, ByVal sngUPrice As Single, ByVal intUIS As Integer, ByVal intUOO As Integer, ByVal intReord As Integer, ByVal intDIS As Integer)

        ProdID = intPID
        ProdName = strName
        ProdSuppID = lngSID
        ProdCatID = lngCID
        ProdQty = strQPU
        ProdPrice = sngUPrice
        ProdStock = intUIS
        ProdOnOrder = intUOO
        ProdReorder = intReord
        ProdDis = intDIS
    End Sub

    Public Property CategoryID As Integer
        Get
            Return ProdCatID
        End Get
        Set(ByVal value As Integer)
            ProdCatID = value

        End Set
    End Property

    Public Property SupplierID As Integer
        Get
            Return ProdSuppID

        End Get
        Set(ByVal value As Integer)
            ProdSuppID = value

        End Set
    End Property

    Public Property ProductID() As Integer
        Get
            Return ProdID
        End Get
        Set(ByVal value As Integer)
            ProdID = value
        End Set
    End Property

    Public Property ProductName() As String
        Get
            Return ProdName
        End Get
        Set(ByVal value As String)
            ProdName = value
        End Set
    End Property

    Public Property QuanitityPerUnit() As String
        Get
            Return ProdQty
        End Get
        Set(ByVal value As String)
            ProdQty = value
        End Set
    End Property

    Public Property UnitPrice() As Single
        Get
            Return ProdPrice
        End Get
        Set(ByVal value As Single)
            ProdPrice = value
        End Set
    End Property

    Public Property UnitsInStock() As Integer
        Get
            Return ProdStock
        End Get
        Set(ByVal value As Integer)
            ProdStock = value
        End Set
    End Property

    Public Property UnitsOnOrder() As Integer
        Get
            Return ProdOnOrder
        End Get
        Set(ByVal value As Integer)
            ProdOnOrder = value
        End Set
    End Property

    Public Property ReorderLevel() As Integer
        Get
            Return ProdReorder
        End Get
        Set(ByVal value As Integer)
            ProdReorder = value
        End Set
    End Property

    Public Property Discontinued() As Integer
        Get
            Return ProdDis
        End Get
        Set(ByVal value As Integer)
            ProdDis = value
        End Set
    End Property

End Class