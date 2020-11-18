Public Class FormNuevoEmpleado
    Private Sub FormNuevoEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonNuevoEmpleado_Cancelar_Click(sender As Object, e As EventArgs) Handles ButtonNuevoEmpleado_Cancelar.Click
        Dim Resp
        Resp = MsgBox("¿Estás seguro de que deseas salir?, ningún dato sera guardado", vbYesNo, "Advertencia")
        If Resp = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub ButtonNuevoEmpleado_Guardar_Click(sender As Object, e As EventArgs) Handles ButtonNuevoEmpleado_Guardar.Click
        Dim Resp
        Resp = MsgBox("¿Está todo correcto?", vbYesNo, "Advertencia")
        If Resp = vbYes Then
            Me.Close()
        End If
    End Sub
End Class