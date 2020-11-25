Public Class FormNuevoDepartamento
    Private Sub TextBoxNuevoDepartamento_Nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNuevoDepartamento_Nombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxNuevoDepartamento_Sueldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNuevoDepartamento_Sueldo.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub ButtonNuevoDepartamento_Cancelar_Click(sender As Object, e As EventArgs) Handles ButtonNuevoDepartamento_Cancelar.Click
        Dim Resp
        Resp = MsgBox("¿Estás seguro de que deseas salir?, ningún dato sera guardado", vbYesNo, "Advertencia")
        If Resp = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub ButtonNuevoDepartamento_Guardar_Click(sender As Object, e As EventArgs) Handles ButtonNuevoDepartamento_Guardar.Click
        Dim Resp
        Resp = MsgBox("¿Está todo correcto?", vbYesNo, "Advertencia")
        If Resp = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub FormNuevoDepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class