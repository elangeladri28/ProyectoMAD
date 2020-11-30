Public Class FormReporteHeadCounterEmpresa
    Private Sub FormReporteHeadCounterEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cargarCombo As New AdministrarEmpresas_Querys()
        ComboBoxReporteHC_Empresa.DataSource = cargarCombo.GetAllEmpresasName()
        ComboBoxReporteHC_Empresa.DisplayMember = "NombreEmpresa"
        ComboBoxReporteHC_Empresa.SelectedItem = Nothing
    End Sub
    Private Sub ComboBoxReporteHC_Empresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxReporteHC_Empresa.SelectedIndexChanged
        Dim cargarCombo2 As New AdministrarDepartamentos_Querys()
        Dim Cantidades As New AdministrarEmpleados_Query()

        Dim EmpresaCombo As String = ComboBoxReporteHC_Empresa.Text
        ComboBoxReporteHC_Deptos.DataSource = cargarCombo2.GetAllDeptosName(EmpresaCombo)
        ComboBoxReporteHC_Deptos.DisplayMember = "NombreDepartamento"
        ComboBoxReporteHC_Deptos.SelectedItem = Nothing


        DGVCantidadEmpresa.DataSource = Cantidades.ObtenerHeadCounterEmpresa(EmpresaCombo)
        DGVCantidadEmpresa.DataMember = "Empresas"

        If (DGVCantidadDepto.Columns.Count <> 0) Then
            DGVCantidadDepto.Columns.Item(0).HeaderText = "Cantidad"
        End If

        Try
            TextBoxReportesHC_CantidadEmpresa.Text = ""
            TextBoxReportesHC_CantidadEmpresa.Text = DGVCantidadEmpresa.Rows(0).Cells("Cantidad").Value
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ComboBoxReporteHC_Deptos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxReporteHC_Deptos.SelectedIndexChanged
        Dim cargarCombo As New AdministrarPuestos_Querys()
        Dim Cantidades As New AdministrarEmpleados_Query()
        Dim EmpresaCombo As String = ComboBoxReporteHC_Empresa.Text
        Dim DeptoCombo As String = ComboBoxReporteHC_Deptos.Text
        ComboBoxReporteHC_Puestos.DataSource = cargarCombo.SelectAllPuestosName(EmpresaCombo, DeptoCombo)
        ComboBoxReporteHC_Puestos.DisplayMember = "NombrePuesto"
        ComboBoxReporteHC_Puestos.SelectedItem = Nothing

        DGVCantidadDepto.DataSource = Cantidades.ObtenerHeadCounterDepto(DeptoCombo, EmpresaCombo)
        DGVCantidadDepto.DataMember = "Departamentos"

        If (DGVCantidadDepto.Columns.Count <> 0) Then
            DGVCantidadDepto.Columns.Item(0).HeaderText = "Cantidad"
        End If

        Try
            TextBoxReportesHC_CantidadDepto.Text = ""
            TextBoxReportesHC_CantidadDepto.Text = DGVCantidadDepto.Rows(0).Cells("Cantidad").Value
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ComboBoxReporteHC_Puestos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxReporteHC_Puestos.SelectedIndexChanged
        Dim Cantidades As New AdministrarEmpleados_Query()
        Dim EmpresaCombo As String = ComboBoxReporteHC_Empresa.Text
        Dim DeptoCombo As String = ComboBoxReporteHC_Deptos.Text
        Dim PuestoCombo As String = ComboBoxReporteHC_Puestos.Text
        DGVCantidad.DataSource = Cantidades.ObtenerHeadCounter(PuestoCombo, DeptoCombo, EmpresaCombo)
        DGVCantidad.DataMember = "Puestos"

        If (DGVCantidad.Columns.Count <> 0) Then
            DGVCantidad.Columns.Item(0).HeaderText = "Cantidad"
        End If

        Try
            TextBoxReporteHc_Cantidad.Text = ""
            TextBoxReporteHc_Cantidad.Text = DGVCantidad.Rows(0).Cells("Cantidad").Value
        Catch ex As Exception

        End Try

    End Sub


End Class