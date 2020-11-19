Public Class FormNuevaEmpresa
    Private Sub FormNuevaEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonNuevaEmpresa_Guardar_Click(sender As Object, e As EventArgs) Handles ButtonNuevaEmpresa_Guardar.Click
        Me.Close()
    End Sub

    Private Sub ButtonNuevaEmpresa_Cancelar_Click(sender As Object, e As EventArgs) Handles ButtonNuevaEmpresa_Cancelar.Click
        Dim Resp
        Resp = MsgBox("¿Estás seguro de que deseas salir?, ningun dato sera guardado", vbYesNo, "Advertencia")
        If Resp = vbYes Then
            Me.Close()
        End If
    End Sub
End Class