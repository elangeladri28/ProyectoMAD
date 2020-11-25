Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports ProjectMAD.SQL_Connection


Public Class AdministrarPuestos_Querys

    Dim dataadapter As New SqlDataAdapter()
    Dim ds As New DataSet()

    Public Function SelectAllFromPuestos(Empresa As String, Depto As String)
        Try
            Dim conect As New SQL_Connection()
            conect.ConectarSQL()

            Dim query As String = "EXEC SelectAllFromPuestos '" + Empresa + "','" + Depto + "';"
            Dim sqlCom As New SqlCommand(query, conect.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "Puestos")
            conect.DesconectarSQL()
            Return ds
        Catch ex As Exception

        End Try
    End Function



End Class
