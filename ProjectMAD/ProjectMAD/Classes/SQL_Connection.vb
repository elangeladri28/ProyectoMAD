Imports System.Data.SqlClient


Public Class SQL_Connection
    'El ConnectionDB está en el App.config, de ahí se declara la conexión
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
