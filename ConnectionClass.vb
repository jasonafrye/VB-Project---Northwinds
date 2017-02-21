Imports System.Data.SqlClient
Public Class ConnectionClass
    'Declare a variable as having the type SQLConnection
    Dim sqlCon As SqlConnection

    Public Sub New()
        'Declare the boolean flag that will be used to determine if the
        'connection is open or closed
        Dim blnOpen As Boolean
        'declare a string variable to hold the connection string.
        Dim conNW As String

        Try
            'Set the connection string variable to the connection string. 
            'This is the ENTIRE connection string that I copied 
            conNW = "Data Source=.\SQLSERVER2008;AttachDbFilename='C:\Northwinds.mdf';Integrated Security=True;Connect Timeout=30;User Instance=True"
            'Create a new instance of the SQLConnection object name sqlCon
            'with a connection string of conNW
            sqlCon = New SqlConnection(conNW)
            'Open the connection
            sqlCon.Open()
            'Set the connection flag = to true
            blnOpen = True
        Catch ex As SqlException
            'Handle any errors that will occur when declaring or opening the connection
            Dim strOut As String
            strOut = ex.Message & vbCrLf
            strOut &= "Line Number " & ex.LineNumber & vbCrLf
            strOut &= ex.Source
            'Test to see if the connection opened even though there was an error
            'If it opened then close it.
            If blnOpen Then
                sqlCon.Close()
            End If
        End Try
    End Sub
    Public ReadOnly Property Con() As SqlConnection
        Get
            Return SQLCon
        End Get

    End Property
End Class
