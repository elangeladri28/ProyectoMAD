Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports ProjectMAD.SQL_Connection


Public Class AdministrarEmpleados_Query

    Dim dataadapter As New SqlDataAdapter()
    Dim ds As New DataSet()

    Public Function SelectAllFromEmpleados()
        Try
            Dim conect As New SQL_Connection()
            conect.ConectarSQL()

            Dim query As String = "EXEC SelectAllFromEmpleados;"
            Dim sqlCom As New SqlCommand(query, conect.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "Empleados")
            conect.DesconectarSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "OH NO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function SelectFromEmpleadosFiltros(Empresa As String, Depto As String, Puesto As String)
        Try
            Dim con As New SQL_Connection()
            con.ConectarSQL()

            Dim query As String = "EXEC SelectFromEmpleadosFiltros '" + Empresa + "', '" + Depto + "', '" + Puesto + "';"
            Dim sqlCom As New SqlCommand(query, con.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "Empleados")
            con.DesconectarSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Pos no wachas nada!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function


End Class
