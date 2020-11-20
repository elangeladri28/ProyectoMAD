Public Class FormNuevoPuesto
    Private Sub ButtonNuevoPuesto_Cancelar_Click(sender As Object, e As EventArgs) Handles ButtonNuevoPuesto_Cancelar.Click
        Dim Resp
        Resp = MsgBox("¿Estás seguro de que deseas salir?, ningún dato sera guardado", vbYesNo, "Advertencia")
        If Resp = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub ButtonNuevoPuesto_Guardar_Click(sender As Object, e As EventArgs) Handles ButtonNuevoPuesto_Guardar.Click
        Dim Resp
        Resp = MsgBox("¿Está todo correcto?", vbYesNo, "Advertencia")
        If Resp = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub TextBoxNuevoPuesto_Nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNuevoPuesto_Nombre.KeyPress
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

    Private Sub TextBoxNuevoPuesto_SalarioDiario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNuevoPuesto_SalarioDiario.KeyPress
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