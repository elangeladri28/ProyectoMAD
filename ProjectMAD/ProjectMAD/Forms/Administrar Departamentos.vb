Imports ProjectMAD.SQL_Connection
Imports System.Data.SqlClient

Public Class Administrar_Departamento

    'Public connectionString As String = Configuration.ConfigurationManager.AppSettings("ConnectionDB").ToString()
    'Public connection As New SqlConnection(connectionString)

    Private Sub Administrar_Departamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim con As New SQL_Connection()

        'Dim sqlCom As New SqlCommand
        'Dim dataReader As SqlDataReader

        'connection.Open()
        'sqlCom.Connection = connection
        'sqlCom.CommandText = "EXEC GetAllEmpresasName;"

        'dataReader = sqlCom.ExecuteReader()

        'Do While dataReader.Read = True
        '  ComboBoxAdministrarDepartamentos_Empresa.Items.Add(dataReader.GetString(0))
        'Loop

        'con.DesconectarSQL()

        Dim cargarCombo As New AdministrarEmpresas_Querys()
        ComboBoxAdministrarDepartamentos_Empresa.DataSource = cargarCombo.GetAllEmpresasName()
        ComboBoxAdministrarDepartamentos_Empresa.DisplayMember = "NombreEmpresa"
        ComboBoxAdministrarDepartamentos_Empresa.SelectedItem = Nothing

    End Sub

    Private Sub ComboBoxAdministrarDepartamentos_Empresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAdministrarDepartamentos_Empresa.SelectedIndexChanged
        Dim cargarDGV As New AdministrarDepartamentos_Querys()
        Dim empresa As String = ComboBoxAdministrarDepartamentos_Empresa.Text
        DGVAdministrarDepartamentos.DataSource = cargarDGV.SelectAllFromDepartamentos(empresa)
        DGVAdministrarDepartamentos.DataMember = "Departamentos"

        If (DGVAdministrarDepartamentos.Columns.Count <> 0) Then
            DGVAdministrarDepartamentos.Columns.Item(0).HeaderText = "Nombre de Departamento"
            DGVAdministrarDepartamentos.Columns.Item(1).HeaderText = "Sueldo Base"
            DGVAdministrarDepartamentos.Columns.Item(2).HeaderText = "Gerente"
        End If
        TextBoxAdministrarDepartamentos_Nombre.Enabled = True
        TextBoxAdministrarDepartamentos_SueldoBase.Enabled = True
        TextBoxAdministrarDepartamentos_Gerente.Enabled = True

        TextBoxAdministrarDepartamentos_Nombre.Text = ""
        TextBoxAdministrarDepartamentos_SueldoBase.Text = ""
        TextBoxAdministrarDepartamentos_Gerente.Text = ""

    End Sub

    Private Sub ButtonAdministrarDepartamentos_Insertar_Click(sender As Object, e As EventArgs) Handles ButtonAdministrarDepartamentos_Insertar.Click
        Dim insert As New AdministrarDepartamentos_Querys()
        Dim empresa As String = ComboBoxAdministrarDepartamentos_Empresa.Text
        insert.InsertDepartamento(TextBoxAdministrarDepartamentos_Nombre.Text, TextBoxAdministrarDepartamentos_SueldoBase.Text,
                                    TextBoxAdministrarDepartamentos_Gerente.Text, empresa)
        Dim contadorFilas As Integer = DGVAdministrarDepartamentos.Rows.Count
        Administrar_Departamento_Load(sender, e)
        'cargarDGV(empresa)
        'ComboBoxAdministrarDepartamentos_Empresa.SelectedItem = ComboBoxAdministrarDepartamentos_Empresa.FindStringExact(empresa)
        Dim nuevaCantidadFilas As Integer = DGVAdministrarDepartamentos.Rows.Count

        'If (contadorFilas < nuevaCantidadFilas) Then
        '    MessageBox.Show("Los datos se han insertado correctamente", "OH YES!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Else
        '    MessageBox.Show("Los datos NO se han insertado correctamente, verifique los campos", "Oopsis!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If

    End Sub

    Public Function cargarDGV(empresa As String)
        Dim cargarCombo As New AdministrarEmpresas_Querys()
        ComboBoxAdministrarDepartamentos_Empresa.DataSource = cargarCombo.GetAllEmpresasName()
        ComboBoxAdministrarDepartamentos_Empresa.DisplayMember = "NombreEmpresa"
        ComboBoxAdministrarDepartamentos_Empresa.SelectedText = empresa
    End Function

    Private Sub ButtonAdministrarEmpresas_Modificar_Click(sender As Object, e As EventArgs) Handles ButtonAdministrarEmpresas_Modificar.Click
        Try
            Dim update As New AdministrarDepartamentos_Querys()
            update.ModificarDepartamento(TextBoxAdministrarDepartamentos_Nombre.Text, TextBoxAdministrarDepartamentos_SueldoBase.Text,
                                        TextBoxAdministrarDepartamentos_Gerente.Text, ComboBoxAdministrarDepartamentos_Empresa.Text)
            MessageBox.Show("Los datos se han modificado correctamente", "OH YES!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Administrar_Departamento_Load(sender, e)


        Catch ex As Exception
            MessageBox.Show("Los datos NO se han modificado correctamente", "OH Repámpanos!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub DGVAdministrarDepartamentos_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVAdministrarDepartamentos.RowHeaderMouseClick
        TextBoxAdministrarDepartamentos_Nombre.Text = DGVAdministrarDepartamentos.CurrentRow.Cells("NombreDepartamento").Value
        TextBoxAdministrarDepartamentos_SueldoBase.Text = DGVAdministrarDepartamentos.CurrentRow.Cells("SueldoBase").Value
        TextBoxAdministrarDepartamentos_Gerente.Text = DGVAdministrarDepartamentos.CurrentRow.Cells("Gerente").Value

    End Sub

    Private Sub ButtonAdministrarEmpresas_Eliminar_Click(sender As Object, e As EventArgs) Handles ButtonAdministrarEmpresas_Eliminar.Click
        Try
            Dim delete As New AdministrarDepartamentos_Querys()
            delete.EliminarDepartamento(TextBoxAdministrarDepartamentos_Nombre.Text, ComboBoxAdministrarDepartamentos_Empresa.Text)
            MessageBox.Show("Los datos se han eliminado correctamente", "OH YES!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Administrar_Departamento_Load(sender, e)
        Catch ex As Exception
            MessageBox.Show("Los datos NO se han modificado correctamente", "Oh no, bro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class