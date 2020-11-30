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

    Public Function InsertarEmpleado(Pass As String, Nombre As String, AP As String, AM As String,
                                     EmpreTrab As String, Depto As String, Puesto As String, NivSal As Double, FechaNac As Date,
                                     Curp As String, NSS As String, RFC As String, Domicilio As String, Banco As String, NumCuenta As String,
                                     Email As String, Tel As String)
        Try
            Dim con As New SQL_Connection()
            con.ConectarSQL()

            Dim query As String = "EXEC InsertarEmpleado '" + Pass + "', '" + Nombre + "', '" + AP + "', '" + AM + "', '" + EmpreTrab + "', '" +
                Depto + "', '" + Puesto + "', " + NivSal.ToString + ",'" + FechaNac + "','" + Curp + "','" + NSS + "','" + RFC + "','" +
            Domicilio + "','" + Banco + "'," + NumCuenta + ", '" + Email + "'," + Tel + ";"

            Dim sqlCom As New SqlCommand(query, con.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "Empleados")
            con.DesconectarSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "OH Cieeelos!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function EliminarEmpleado(ID As Integer)
        Try
            Dim con As New SQL_Connection()
            con.ConectarSQL()

            Dim query As String = "EXEC EliminarEmpleado " + ID + ";"
            Dim sqlCom As New SqlCommand(query, con.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "Empleados")
            con.DesconectarSQL()
            Return ds
        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "OH, hay errorsito!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function ObtenerHeadCounter(Puesto As String, Departamento As String, Empresa As String)
        Try
            Dim con As New SQL_Connection()
            con.ConectarSQL()

            Dim query As String = "EXEC ObtenerHeadCounter '" + Puesto + "', '" + Departamento + "','" + Empresa + "';"
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


    Public Function ObtenerHeadCounterDepto(Departamento As String, Empresa As String)
        Try
            Dim con As New SQL_Connection()
            con.ConectarSQL()

            Dim query As String = "EXEC ObtenerHeadCounterDepto '" + Departamento + "','" + Empresa + "';"
            Dim sqlCom As New SqlCommand(query, con.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "Departamentos")
            con.DesconectarSQL()
            Return ds

        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Oh, SIMP shimatta!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function


    Public Function ObtenerHeadCounterEmpresa(Empresa As String)
        Try
            Dim con As New SQL_Connection()
            con.ConectarSQL()

            Dim query As String = "EXEC ObtenerHeadCounterEmpresa '" + Empresa + "';"
            Dim sqlCom As New SqlCommand(query, con.connection)
            dataadapter.SelectCommand = sqlCom
            dataadapter.Fill(ds, "Empresas")
            con.DesconectarSQL()
            Return ds

        Catch ex As Exception
            Dim errorsito As String = "¡Excepción en la base de datos!" + vbCrLf + ex.Message
            MessageBox.Show(errorsito, "Oh, SIMP shimatta!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function


End Class
