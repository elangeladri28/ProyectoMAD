Public Class FormNuevoEmpleado
    Private Sub FormNuevoEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cargarCombo As New AdministrarEmpresas_Querys()
        ComboBoxNuevoEmpleado_Trabajo.DataSource = cargarCombo.GetAllEmpresasName()
        ComboBoxNuevoEmpleado_Trabajo.DisplayMember = "NombreEmpresa"
        ComboBoxNuevoEmpleado_Trabajo.SelectedItem = Nothing
    End Sub

    Private Sub ButtonNuevoEmpleado_Cancelar_Click(sender As Object, e As EventArgs) Handles ButtonNuevoEmpleado_Cancelar.Click
        Dim Resp
        Resp = MsgBox("¿Estás seguro de que deseas salir?, ningún dato sera guardado", vbYesNo, "Advertencia")
        If Resp = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub ButtonNuevoEmpleado_Guardar_Click(sender As Object, e As EventArgs) Handles ButtonNuevoEmpleado_Guardar.Click

        Try

        Catch ex As Exception

        End Try

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

    Private Sub TextBoxNuevoEmpleado_NumCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNuevoEmpleado_NumCuenta.KeyPress
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

    Private Sub TextBoxNuevoEmpleado_NSS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNuevoEmpleado_NSS.KeyPress
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

    Private Sub ComboBoxNuevoEmpleado_Trabajo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNuevoEmpleado_Trabajo.SelectedIndexChanged
        Dim cargarCombo2 As New AdministrarDepartamentos_Querys()
        Dim EmpresaCombo As String = ComboBoxNuevoEmpleado_Trabajo.Text
        ComboBoxNuevoEmpleado_Depto.DataSource = cargarCombo2.GetAllDeptosName(EmpresaCombo)
        ComboBoxNuevoEmpleado_Depto.DisplayMember = "NombreDepartamento"
        ComboBoxNuevoEmpleado_Depto.SelectedItem = Nothing
    End Sub

    Private Sub ComboBoxNuevoEmpleado_Depto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNuevoEmpleado_Depto.SelectedIndexChanged
        Dim cargarCombo As New AdministrarPuestos_Querys()
        Dim EmpresaCombo As String = ComboBoxNuevoEmpleado_Trabajo.Text
        Dim DeptoCombo As String = ComboBoxNuevoEmpleado_Depto.Text
        ComboBoxNuevoEmpleado_Puesto.DataSource = cargarCombo.SelectAllPuestosName(EmpresaCombo, DeptoCombo)
        ComboBoxNuevoEmpleado_Puesto.DisplayMember = "NombrePuesto"
        ComboBoxNuevoEmpleado_Puesto.SelectedItem = Nothing
    End Sub

    Private Sub ComboBoxNuevoEmpleado_Puesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNuevoEmpleado_Puesto.SelectedIndexChanged
        Dim agregarsueldo As New AdministrarPuestos_Querys()
        Dim EmpresaCombo As String = ComboBoxNuevoEmpleado_Trabajo.Text
        Dim DeptoCombo As String = ComboBoxNuevoEmpleado_Depto.Text
        Dim PuestoCombo As String = ComboBoxNuevoEmpleado_Puesto.Text
        DGVDinerito.DataSource = agregarsueldo.GetOnlyMoneyPuesto(PuestoCombo, DeptoCombo, EmpresaCombo)
        DGVDinerito.DataMember = "Puestos"

        If (DGVDinerito.Columns.Count <> 0) Then
            DGVDinerito.Columns.Item(0).HeaderText = "Salario"
        End If

        TextBoxNuevoEmpleado_Salarial.Text = ""
        TextBoxNuevoEmpleado_Salarial.Text = DGVDinerito.Rows(0).Cells("SalarioDiario").Value

    End Sub
End Class