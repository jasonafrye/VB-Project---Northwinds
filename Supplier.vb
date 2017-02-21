Public Class Supplier
    Private SuppID As Integer
    Private CompName As String
    Private ContactName As String
    Private CompAddress As String
    Private CompCity As String
    Private CompRegion As String
    Private CompPostalCode As String
    Private CompCountry As String
    Private CompPhone As String
    Private CompFax As String
    Private CompHomePage As String
    Public Sub New(ByVal SIDIn As Integer, ByVal CompNameIn As String)
        SuppID = SIDIn
        CompName = CompNameIn
    End Sub
    Public Sub New()

    End Sub
    Public Property SupplierID() As Integer
        Get
            Return SuppID
        End Get
        Set(ByVal value As Integer)
            SuppID = value
        End Set
    End Property
    Public Property Company() As String
        Get
            Return CompName
        End Get
        Set(ByVal value As String)
            CompName = value
        End Set
    End Property
    Public Property Contact() As String
        Get
            Return ContactName
        End Get
        Set(ByVal value As String)
            ContactName = value
        End Set
    End Property
    Public Property Address() As String
        Get
            Return CompAddress
        End Get
        Set(ByVal value As String)
            CompAddress = value
        End Set
    End Property
    Public Property Phone() As String
        Get
            Return CompPhone
        End Get
        Set(ByVal value As String)
            CompPhone = value
        End Set
    End Property
    Public Property Zip() As String
        Get
            Return CompPostalCode
        End Get
        Set(ByVal value As String)
            CompPostalCode = value
        End Set
    End Property
    Public Property City() As String
        Get
            Return CompCity
        End Get
        Set(ByVal value As String)
            CompCity = value
        End Set
    End Property
    Public Property Country() As String
        Get
            Return CompCountry
        End Get
        Set(ByVal value As String)
            CompCountry = value
        End Set
    End Property
    Public Property Region() As String
        Get
            Return CompRegion
        End Get
        Set(ByVal value As String)
            CompRegion = value
        End Set
    End Property
    Public Property Fax() As String
        Get
            Return CompFax
        End Get
        Set(ByVal value As String)
            CompFax = value
        End Set
    End Property
    Public Property HomePage() As String
        Get
            Return CompHomePage
        End Get
        Set(ByVal value As String)
            CompHomePage = value
        End Set
    End Property
End Class
