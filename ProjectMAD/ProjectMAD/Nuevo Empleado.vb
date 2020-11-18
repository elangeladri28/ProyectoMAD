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

    Private Sub TextBoxNuevoEmpleado_Nombres_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNuevoEmpleado_Nombres.KeyPress
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

    Private Sub TextBoxNuevoEmpleado_ApPaterno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNuevoEmpleado_ApPaterno.KeyPress
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

    Private Sub TextBoxNuevoEmpleado_ApMaterno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNuevoEmpleado_ApMaterno.KeyPress
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

    Private Sub TextBoxNuevoEmpleado_Telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNuevoEmpleado_Telefono.KeyPress
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
End Class