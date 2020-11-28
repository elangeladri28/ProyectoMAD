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
        Try
            Dim cargarCombo As New AdministrarEmpresas_Querys()
            ComboBoxNuevoDepartamento_Empresa.DataSource = cargarCombo.GetAllEmpresasName()
            ComboBoxNuevoDepartamento_Empresa.DisplayMember = "NombreEmpresa"
            ComboBoxNuevoDepartamento_Empresa.SelectedItem = Nothing
        Catch ex As Exception
            MessageBox.Show("No se pudo cargar la información de las empresas.", "Ohhquelas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ButtonNuevoDepartamento_Insertar_Click(sender As Object, e As EventArgs) Handles ButtonNuevoDepartamento_Insertar.Click
        Try
            Dim con As New SQL_Connection()
            con.ConectarSQL()

            Dim insert As New AdministrarDepartamentos_Querys()
            insert.InsertDepartamento(TextBoxNuevoDepartamento_Nombre.Text, TextBoxNuevoDepartamento_Sueldo.Text, TextBoxNuevoDepartamento_Gerente.Text,
                                      ComboBoxNuevoDepartamento_Empresa.Text)

            MessageBox.Show("Nice! Se ha añadido la empresa!", "We got this", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Uhh! Se ha añadido la empresa!", "We ain't into this", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class