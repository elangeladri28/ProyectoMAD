Public Class FormAdministracion
    Private Sub FormAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MAD_PIADataSet.Empresas' table. You can move, or remove it, as needed.
        Me.EmpresasTableAdapter.Fill(Me.MAD_PIADataSet.Empresas)

    End Sub

    Private Sub MenuAdministracion_AñadirEmpresa_Click(sender As Object, e As EventArgs) Handles MenuAdministracion_AñadirEmpresa.Click
        Dim AddEmpresa As New FormNuevaEmpresa()
        'Me.Hide()
        AddEmpresa.ShowDialog()
        'Me.Close()
    End Sub

    Private Sub MenuAdministracion_AñadirEmpleado_Click(sender As Object, e As EventArgs) Handles MenuAdministracion_AñadirEmpleado.Click
        Dim AddEmpleado As New FormNuevoEmpleado()
        AddEmpleado.ShowDialog()
    End Sub

    Private Sub MenuAdministracion_AñadirPuesto_Click(sender As Object, e As EventArgs) Handles MenuAdministracion_AñadirPuesto.Click
        Dim AddPuesto As New FormNuevoPuesto()
        AddPuesto.ShowDialog()
    End Sub
End Class