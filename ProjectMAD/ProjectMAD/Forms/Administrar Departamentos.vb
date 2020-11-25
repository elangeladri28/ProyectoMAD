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
        DGVAdministrarDepartamentos.DataSource = cargarDGV.SelectAllFromDepartamentos(ComboBoxAdministrarDepartamentos_Empresa.SelectedText)
        DGVAdministrarDepartamentos.DataMember = "Departamentos"

        If (DGVAdministrarDepartamentos.Columns.Count <> 0) Then
            DGVAdministrarDepartamentos.Columns.Item(0).HeaderText = "Nombre de Departamento"
            DGVAdministrarDepartamentos.Columns.Item(1).HeaderText = "Sueldo Base"
            DGVAdministrarDepartamentos.Columns.Item(2).HeaderText = "Gerente"
        End If
    End Sub
End Class