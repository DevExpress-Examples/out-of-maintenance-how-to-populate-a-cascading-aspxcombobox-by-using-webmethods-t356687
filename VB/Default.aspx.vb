Imports System.Collections.Generic
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Web.Services
Imports System.Web.UI.WebControls

Public Class Product
    Public Property Name() As String
    Public Property ID() As String
    Public Sub New(ByVal name As String, ByVal id As String)
        Me.Name = name
        Me.ID = id
    End Sub
End Class
Partial Public Class _Default
    Inherits System.Web.UI.Page

    Private Shared connectionString As String = ConfigurationManager.ConnectionStrings("NorthwindConnectionString").ConnectionString.ToString()

    <WebMethod> _
    Public Shared Function GetData(ByVal categoryID As String) As List(Of Product)
        Dim dt As New DataTable()
        Using con As New SqlConnection(connectionString)
            Dim query As String = "SELECT ProductName, ProductID FROM Products WHERE CategoryID=" & categoryID
            Dim cmd As New SqlCommand(query, con)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        End Using

        Dim listOfProducts As List(Of Product) = dt.AsEnumerable().Select(Function(a) New Product(a("ProductName").ToString(), a("ProductID").ToString())).ToList()

        Return listOfProducts
    End Function
End Class