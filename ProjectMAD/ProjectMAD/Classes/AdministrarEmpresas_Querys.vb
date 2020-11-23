Imports System.Data.SqlClient
Imports ProjectMAD.SQL_Connection

Public Class AdministrarEmpresas_Querys

    Dim dataadapter As New SqlDataAdapter()
    Dim ds As New DataSet()

    Public Function SelectAllFromEmpresas()
        Try
            Dim conect As New SQL_Connection()
            conect.ConectarSQL()

            Dim sql As String = "SELECT NombreEmpresa, DomicilioFiscal, Telefono, RegistroPatronal, RFC, FechaInicio FROM dbo.Empresas"
            Dim sqlCom As New SqlCommand(sql, conect.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "Empresas")
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "OH NO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Function

End Class
