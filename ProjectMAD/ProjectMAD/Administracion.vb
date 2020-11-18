Public Class FormAdministracion
    Private Sub FormAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class