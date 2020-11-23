Imports System.Data.SqlClient


Public Class SQL_Connection
    Public connectionString As String = Configuration.ConfigurationManager.AppSettings("ConnectionDB").ToString()
    Public connection As New SqlConnection(connectionString)
    Public dataadapter As New SqlDataAdapter()
    Public ds As New DataSet()

    Public Sub ConectarSQL()
        connection.Open()
    End Sub

    Public Sub DesconectarSQL()
        connection.Close()
    End Sub

End Class
