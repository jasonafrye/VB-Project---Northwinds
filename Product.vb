Public Class Product
    Private ProdID As Integer
    Private ProdName As String
    Private ProdQty As String
    Private ProdPrice As Single
    Private ProdStock As Integer
    Private ProdOnOrder As Integer
    Private ProdReorder As Integer
    Private ProdDis As Integer

    Public Sub New(ByVal PIDIn As Integer, ByVal ProdNameIn As String)
        ProdID = PIDIn
        ProdName = ProdNameIn
    End Sub

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
