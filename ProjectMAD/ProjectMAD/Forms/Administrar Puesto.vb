Imports ProjectMAD.SQL_Connection
Imports System.Data.SqlClient

Public Class FormAdministrarPuestos
    Private Sub FormAdministrarPuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cargarCombo As New AdministrarEmpresas_Querys()
        ComboBoxAdministrarPuestos_Empresa.DataSource = cargarCombo.GetAllEmpresasName()
        ComboBoxAdministrarPuestos_Empresa.DisplayMember = "NombreEmpresa"
        ComboBoxAdministrarPuestos_Empresa.SelectedItem = Nothing

    End Sub

    Private Sub ComboBoxAdministrarPuestos_Empresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAdministrarPuestos_Empresa.SelectedIndexChanged

        Dim cargarCombo2 As New AdministrarDepartamentos_Querys()
        Dim EmpresaCombo As String = ComboBoxAdministrarPuestos_Empresa.Text
        ComboBoxAdministrarPuestos_Departamento.DataSource = cargarCombo2.GetAllDeptosName(EmpresaCombo)
        ComboBoxAdministrarPuestos_Departamento.DisplayMember = "NombreDepartamento"
        ComboBoxAdministrarPuestos_Departamento.SelectedItem = Nothing


    End Sub

    Private Sub ComboBoxAdministrarPuestos_Departamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAdministrarPuestos_Departamento.SelectedIndexChanged

        Dim cargarDGV As New AdministrarPuestos_Querys()
            Dim EmpresaCombo As String = ComboBoxAdministrarPuestos_Empresa.Text
            Dim DeptoCombo As String = ComboBoxAdministrarPuestos_Departamento.Text
            DGVAdministrarPuestos.DataSource = cargarDGV.SelectAllFromPuestos(EmpresaCombo, DeptoCombo)
            DGVAdministrarPuestos.DataMember = "Puestos"

            If (DGVAdministrarPuestos.Columns.Count <> 0) Then
                DGVAdministrarPuestos.Columns.Item(0).HeaderText = "Nombre de Puesto"
                DGVAdministrarPuestos.Columns.Item(1).HeaderText = "Proporcion Salarial"
                DGVAdministrarPuestos.Columns.Item(2).HeaderText = "Salario Diario"
            End If

            TextBoxAdministrarPuestos_Puesto.Text = ""
            TextBoxAdministrarPuestos_Proporcion.Text = ""
            TextBoxAdministrarPuestos_Salario.Text = ""



    End Sub
End Class