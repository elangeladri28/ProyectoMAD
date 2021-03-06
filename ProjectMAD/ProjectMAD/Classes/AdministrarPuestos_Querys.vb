﻿Imports System.Data
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
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Oh, SHUT!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function SelectAllPuestosName(Empresa As String, Depto As String)
        Try
            Dim con As New SQL_Connection()
            con.ConectarSQL()

            Dim query As String = "EXEC SelectAllPuestosName '" + Empresa + "', '" + Depto + "';"
            Dim dt As New DataTable()
            Dim sqlCom As New SqlCommand(query, con.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(dt)
            con.DesconectarSQL()
            Return dt

        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Oh, meperd0nas¿", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function IngresarNuevoPuesto(Nombre As String, Prop As Decimal, SD As Decimal, Depto As String, Empre As String)
        Try
            Dim con As New SQL_Connection()
            con.ConectarSQL()

            Dim query As String = "EXEC IngresarNuevoPuesto '" + Nombre + "', " + Prop.ToString + ", " + SD.ToString + ", '" + Depto + "', '" + Empre + "';"
            Dim sqlCom As New SqlCommand(query, con.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "Puestos")
            con.DesconectarSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "OH Cieeelos!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function
    Public Function ModificarPuestos(ID As Integer, Nombre As String, Prop As Decimal, SD As Decimal, Depto As String, Empresa As String)
        Try
            Dim con As New SQL_Connection()
            con.ConectarSQL()

            Dim query As String = "EXEC ModificarPuestos " + ID.ToString + ", '" + Nombre + "', " + Prop.ToString + ", " + SD.ToString + ", '" + Depto + "', '" + Empresa + "';"
            Dim sqlCom As New SqlCommand(query, con.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "Puestos")
            con.DesconectarSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "OH Recórcholis!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function EliminarPuesto(Nombre As String, Depto As String, Empresa As String)
        Try
            Dim con As New SQL_Connection()
            con.ConectarSQL()

            Dim query As String = "EXEC EliminarPuesto '" + Nombre + "', '" + Depto + "', '" + Empresa + "';"
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

    Public Function GetOnlyMoneyPuesto(Puesto As String, Depto As String, Empresa As String)
        Try
            Dim con As New SQL_Connection()
            con.ConectarSQL()

            Dim query As String = "EXEC GetOnlyMoneyPuesto '" + Puesto + "', '" + Depto + "','" + Empresa + "';"
            Dim sqlCom As New SqlCommand(query, con.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "Puestos")
            con.DesconectarSQL()
            Return ds

        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Oh, SIMP shimatta!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

End Class
