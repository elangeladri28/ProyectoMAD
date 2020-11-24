Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports ProjectMAD.SQL_Connection

Public Class AdministrarEmpresas_Querys

    Dim dataadapter As New SqlDataAdapter()
    Dim ds As New DataSet()

    Public Function SelectAllFromEmpresas()
        Try
            Dim conect As New SQL_Connection()
            conect.ConectarSQL()

            Dim query As String = "EXEC SelectAllFromEmpresas;"
            Dim sqlCom As New SqlCommand(query, conect.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "Empresas")
            conect.DesconectarSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "OH NO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    Public Function DeleteRowFromEmpresas(Nombre As String)
        Try
            Dim conect As New SQL_Connection()
            conect.ConectarSQL()

            Dim query As String = "EXEC EliminarEmpresa '" + Nombre + "';"
            Dim sqlCom As New SqlCommand(query, conect.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "Empresas")
            conect.DesconectarSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "OH NO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function InsertEmpresa(Nombre As String, DomFis As String, Telefono As String, RegPat As String, RFC As String, Fecha As Date)
        Try
            Dim conect As New SQL_Connection()
            conect.ConectarSQL()

            Dim query As String = "EXEC InsertarEmpresa " + "'" + Nombre + "', '" + DomFis + "', '" + Telefono + "', '" + RegPat + "', '" + RFC + "', '" + Fecha + "';"
            Dim sqlCom As New SqlCommand(query, conect.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "Empresas")
            conect.DesconectarSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "OH NO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function ModificarEmpresa(Nombre As String, DomFis As String, Telefono As String, RegPat As String, RFC As String, Fecha As Date)
        Try
            Dim con As New SQL_Connection()
            con.ConectarSQL()
            Dim query As String = "EXEC ModificarEmpresa " + "'" + Nombre + "', '" + DomFis + "', '" + Telefono + "', '" + RegPat + "', '" + RFC + "', '" + Fecha + "';"
            Dim sqlCom As New SqlCommand(query, con.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "Empresas")
            con.DesconectarSQL()
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "OH NOoOoooOoO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
End Class
