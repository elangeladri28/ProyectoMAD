Imports ProjectMAD.SQL_Connection
Imports System.Data.SqlClient

Public Class FormAdministrarEmpleados
    Private Sub FormAdministrarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sel As New AdministrarEmpleados_Query()
        DGVAdministrarEmpleados.DataSource = sel.SelectAllFromEmpleados()
        DGVAdministrarEmpleados.DataMember = "Empleados"
        If (DGVAdministrarEmpleados.Columns.Count <> 0) Then
            DGVAdministrarEmpleados.Columns.Item(0).HeaderText = "ID de Empleado"
            DGVAdministrarEmpleados.Columns.Item(1).HeaderText = "Nombre Completo"
            DGVAdministrarEmpleados.Columns.Item(2).HeaderText = "Empresa de trabajo"
            DGVAdministrarEmpleados.Columns.Item(3).HeaderText = "Departamento"
            DGVAdministrarEmpleados.Columns.Item(4).HeaderText = "Puesto"
            DGVAdministrarEmpleados.Columns.Item(5).HeaderText = "Salario"
            DGVAdministrarEmpleados.Columns.Item(6).HeaderText = "Fecha de nacimiento"

            'EH, FALTA PONERLE BIEN LOS NOMBRES A ESTAS COLUMNAS; FALTAN UNA QUE OTRA.
        End If

        Dim cargarComboFiltroEmpresa As New AdministrarEmpresas_Querys()
        ComboBoxAdministrarEmpelados_FiltroEmpresa.DataSource = cargarComboFiltroEmpresa.GetAllEmpresasName()
        ComboBoxAdministrarEmpelados_FiltroEmpresa.DisplayMember = "NombreEmpresa"
        ComboBoxAdministrarEmpelados_FiltroEmpresa.SelectedItem = Nothing

    End Sub

    Private Sub ComboBoxAdministrarEmpelados_FiltroEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAdministrarEmpelados_FiltroEmpresa.SelectedIndexChanged
        Dim cargarComboFiltroDepartamento As New AdministrarDepartamentos_Querys()
        Dim comboEmpresa As String = ComboBoxAdministrarEmpelados_FiltroEmpresa.Text
        ComboBoxAdministrarEmpelados_FiltroDepartamento.DataSource = cargarComboFiltroDepartamento.GetAllDeptosName(comboEmpresa)
        ComboBoxAdministrarEmpelados_FiltroDepartamento.DisplayMember = "NombreDepartamento"
        ComboBoxAdministrarEmpelados_FiltroDepartamento.SelectedItem = Nothing

    End Sub

    Private Sub ComboBoxAdministrarEmpelados_FiltroDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAdministrarEmpelados_FiltroDepartamento.SelectedIndexChanged
        Dim cargarComboFiltroPuesto As New AdministrarPuestos_Querys()
        Dim comboEmpresa As String = ComboBoxAdministrarEmpelados_FiltroEmpresa.Text
        Dim comboDepto As String = ComboBoxAdministrarEmpelados_FiltroDepartamento.Text

        ComboBoxAdministrarEmpelados_FiltroPuesto.DataSource = cargarComboFiltroPuesto.SelectAllPuestosName(comboEmpresa, comboDepto)
        ComboBoxAdministrarEmpelados_FiltroPuesto.DisplayMember = "NombrePuesto"
        ComboBoxAdministrarEmpelados_FiltroPuesto.SelectedItem = Nothing
    End Sub

    Private Sub ComboBoxAdministrarEmpelados_FiltroPuesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAdministrarEmpelados_FiltroPuesto.SelectedIndexChanged


    End Sub

    Private Sub ComboBoxAdministrarEmpelados_FiltroPuesto_DisplayMemberChanged(sender As Object, e As EventArgs) Handles ComboBoxAdministrarEmpelados_FiltroPuesto.DisplayMemberChanged

    End Sub

    Private Sub DGVAdministrarEmpleados_DataSourceChanged(sender As Object, e As EventArgs) Handles DGVAdministrarEmpleados.DataSourceChanged

    End Sub

    Private Sub ComboBoxAdministrarEmpelados_FiltroPuesto_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxAdministrarEmpelados_FiltroPuesto.SelectedValueChanged

        Dim cargarDGVEmpleados As New AdministrarEmpleados_Query()
        Dim comboEmpresa As String = ComboBoxAdministrarEmpelados_FiltroEmpresa.Text
        Dim comboDepto As String = ComboBoxAdministrarEmpelados_FiltroDepartamento.Text
        Dim comboPuesto As String = ComboBoxAdministrarEmpelados_FiltroPuesto.Text

        DGVAdministrarEmpleados.DataSource = cargarDGVEmpleados.SelectFromEmpleadosFiltros(comboEmpresa, comboDepto, comboPuesto)
        DGVAdministrarEmpleados.DataMember = "Empleados"

    End Sub

    Private Sub ButtonAdministrarEmpleados_ActualizarDGV_Click(sender As Object, e As EventArgs) Handles ButtonAdministrarEmpleados_ActualizarDGV.Click

    End Sub
End Class