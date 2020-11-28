Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports ProjectMAD.SQL_Connection


Public Class AdministrarDepartamentos_Querys

    Dim dataadapter As New SqlDataAdapter()
    Dim ds As New DataSet()

    Public Function SelectAllFromDepartamentos(Empresa As String)
        Try
            Dim conect As New SQL_Connection()
            conect.ConectarSQL()

            Dim query As String = "EXEC SelectAllFromDepartamentos '" + Empresa + "';"
            Dim sqlCom As New SqlCommand(query, conect.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "Departamentos")
            conect.DesconectarSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "OH NO le sabes al chitpost!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function InsertDepartamento(Nombre As String, SueldoBase As String, Gerente As String, Empresa As String)
        Try
            Dim con As New SQL_Connection()
            con.ConectarSQL()

            Dim query As String = "EXEC InsertarDepartamento '" + Nombre + "', '" + SueldoBase + "', '" + Gerente + "', '" + Empresa + "';"
            Dim sqlCom As New SqlCommand(query, con.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "Departamentos")
            con.DesconectarSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "OH Cieeelos!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function ModificarDepartamento(ID As Integer, Nombre As String, SueldoBase As String, Gerente As String, Empresa As String)
        Try
            Dim con As New SQL_Connection()
            con.ConectarSQL()

            Dim query As String = "EXEC ModificarDepartamento " + ID.ToString + ",'" + Nombre + "', '" + SueldoBase + "', '" + Gerente + "', '" + Empresa + "';"
            Dim sqlCom As New SqlCommand(query, con.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "Departamentos")
            con.DesconectarSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "OH Recórcholis!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function EliminarDepartamento(Nombre As String, Empresa As String)
        Try
            Dim con As New SQL_Connection()
            con.ConectarSQL()

            Dim query As String = "EXEC EliminarDepartamento '" + Nombre + "', '" + Empresa + "';"
            Dim sqlCom As New SqlCommand(query, con.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "Departamentos")
            con.DesconectarSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Oh, shimatta!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function GetAllDeptosName(Nombre As String)
        Try

            Dim con As New SQL_Connection()
            con.ConectarSQL()

            Dim query As String = "EXEC GetAllDeptosName '" + Nombre + "';"
            Dim dt As New DataTable()
            Dim sqlCom As New SqlCommand(query, con.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(dt)
            con.DesconectarSQL()
            Return dt

        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Oh, shimatta!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function GetOnlyMoneyDepto(Nombre As String)
        Try
            Dim con As New SQL_Connection()
            con.ConectarSQL()

            Dim query As String = "EXEC GetOnlyMoneyDepto '" + Nombre + "';"
            Dim sqlCom As New SqlCommand(query, con.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "Departamentos")
            con.DesconectarSQL()
            Return ds

        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Oh, shimatta!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function
End Class
