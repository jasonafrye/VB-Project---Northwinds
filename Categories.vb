Public Class Categories
    Private CatId As Int16
    Private CatName As String
    Public Sub New()

    End Sub
    Public Sub New(ByVal IdIn As Integer, ByVal NameIn As String)
        CatId = IdIn
        CatName = NameIn
    End Sub
    Public Property CID() As Integer
        Get
            Return CatId

        End Get
        Set(ByVal value As Integer)
            CatId = value

        End Set
    End Property
    Public Property Cname() As String
        Get
            Return CatName

        End Get
        Set(ByVal value As String)
            CatName = value
        End Set
    End Property
End Class
