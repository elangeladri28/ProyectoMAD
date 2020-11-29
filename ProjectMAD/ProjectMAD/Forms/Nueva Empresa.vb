Public Class FormNuevaEmpresa
    Private Sub FormNuevaEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Private Sub ButtonNuevaEmpresa_Guardar_Click(sender As Object, e As EventArgs) Handles ButtonNuevaEmpresa_Guardar.Click
    'Me.Close()
    'End Sub

    Private Sub ButtonNuevaEmpresa_Cancelar_Click(sender As Object, e As EventArgs) Handles ButtonNuevaEmpresa_Cancelar.Click
        Dim Resp
        Resp = MsgBox("¿Estás seguro de que deseas salir?, ningun dato sera guardado", vbYesNo, "Advertencia")
        If Resp = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub ButtonNuevaEmpresa_Insertar_Click(sender As Object, e As EventArgs) Handles ButtonNuevaEmpresa_Insertar.Click
        If (TextBoxNuevaEmpresa_RazonSocial.Text <> "" And TextBoxNuevaEmpresa_DomicilioFiscal.Text <> "" And TextBoxNuevaEmpresa_Contacto.Text <> "" And
                TextBoxNuevaEmpresa_RegistroPatronal.Text <> "" And TextBoxNuevaEmpresa_RFC.Text <> "") Then
            Try


                Dim con As New SQL_Connection()
                con.ConectarSQL()

                Dim insert As New AdministrarEmpresas_Querys()
                insert.InsertEmpresa(TextBoxNuevaEmpresa_RazonSocial.Text, TextBoxNuevaEmpresa_DomicilioFiscal.Text, TextBoxNuevaEmpresa_Contacto.Text,
                                    TextBoxNuevaEmpresa_RegistroPatronal.Text, TextBoxNuevaEmpresa_RFC.Text, DateTimePickerNuevaEmpresa_InicioOperaciones.Value)

                MessageBox.Show("BIEN! Se ha añadido la empresa!", "Tu confiado yo tranquilo", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Catch ex As Exception

                MessageBox.Show("MAL! No se ha añadido la empresa!", "Ya perdí la tranquilidad", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End Try
        Else
            MsgBox("Debes de llenar todos los campos", vbOKOnly, "Advertencia")
        End If


        Dim Resp
        Resp = MsgBox("¿Quieres insertar alguna otra empresa?", vbYesNo, "Advertencia")
        If Resp = vbNo Then
            Me.Close()
        ElseIf Resp = vbYes Then
            TextBoxNuevaEmpresa_RazonSocial.Text = ""
            TextBoxNuevaEmpresa_DomicilioFiscal.Text = ""
            TextBoxNuevaEmpresa_Contacto.Text = ""
            TextBoxNuevaEmpresa_RegistroPatronal.Text = ""
            TextBoxNuevaEmpresa_RFC.Text = ""

        End If

    End Sub

    Private Sub TextBoxNuevaEmpresa_Contacto_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNuevaEmpresa_Contacto.TextChanged


        If TextBoxNuevaEmpresa_Contacto.Text.Length < 10 Then
            LabelNuevaEmpresa_TelefonoVal.Text = "El número debe ser de 10 dígitos"
            TextBoxNuevaEmpresa_Contacto.Focus()
        End If
        If TextBoxNuevaEmpresa_Contacto.Text.Length > 10 Then
            LabelNuevaEmpresa_TelefonoVal.Text = "El número debe ser de 10 dígitos"
            TextBoxNuevaEmpresa_Contacto.Focus()
        End If
        If TextBoxNuevaEmpresa_Contacto.Text.Length = 10 Then
            LabelNuevaEmpresa_TelefonoVal.Text = ""
        End If
    End Sub

    Private Sub TextBoxNuevaEmpresa_Contacto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNuevaEmpresa_Contacto.KeyPress
        Dim funcion As New Functions()
        funcion.NotLetters(sender, e)
    End Sub
End Class