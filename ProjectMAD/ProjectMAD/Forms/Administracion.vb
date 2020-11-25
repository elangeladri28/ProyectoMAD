Public Class FormAdministracion

    Dim addEmpresa As New FormNuevaEmpresa()
    Dim addEmpleado As New FormNuevoEmpleado()
    Dim addPuesto As New FormNuevoPuesto()
    Dim addDepartamento As New FormNuevoDepartamento()

    Dim adminEmpresas As New FormAdministrarEmpresa()
    Dim adminDepartamentos As New Administrar_Departamento()

    Private Sub FormAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MAD_PIADataSet.Empresas' table. You can move, or remove it, as needed.
        Me.EmpresasTableAdapter.Fill(Me.MAD_PIADataSet.Empresas)

    End Sub

    Private Sub MenuAdministracion_AñadirEmpresa_Click(sender As Object, e As EventArgs) Handles MenuAdministracion_AñadirEmpresa.Click
        addEmpresa.ShowDialog()
    End Sub

    Private Sub MenuAdministracion_AñadirEmpleado_Click(sender As Object, e As EventArgs) Handles MenuAdministracion_AñadirEmpleado.Click
        addEmpleado.ShowDialog()
    End Sub

    Private Sub MenuAdministracion_AñadirPuesto_Click(sender As Object, e As EventArgs) Handles MenuAdministracion_AñadirPuesto.Click
        addPuesto.ShowDialog()
    End Sub

    Private Sub MenuAdministracion_AñadirDepartamento_Click(sender As Object, e As EventArgs) Handles MenuAdministracion_AñadirDepartamento.Click
        addDepartamento.ShowDialog()
    End Sub

    Private Sub EmpresasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpresasToolStripMenuItem1.Click
        adminEmpresas.ShowDialog()
    End Sub

    Private Sub DepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartamentosToolStripMenuItem.Click
        adminDepartamentos.ShowDialog()
    End Sub
End Class