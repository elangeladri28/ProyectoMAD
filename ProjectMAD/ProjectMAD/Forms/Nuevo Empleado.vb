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
        Dim funcion As New Functions()
        funcion.NotSymbols(e)
    End Sub

    Private Sub TextBoxNuevoEmpleado_ApPaterno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNuevoEmpleado_ApPaterno.KeyPress
        Dim funcion As New Functions()
        funcion.NotSymbols(e)
    End Sub

    Private Sub TextBoxNuevoEmpleado_ApMaterno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNuevoEmpleado_ApMaterno.KeyPress
        Dim funcion As New Functions()
        funcion.NotSymbols(e)
    End Sub

    Private Sub TextBoxNuevoEmpleado_Telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNuevoEmpleado_Telefono.KeyPress
        Dim funcion As New Functions()
        funcion.NotLetters(sender, e)
    End Sub

    Private Sub TextBoxNuevoEmpleado_NumCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNuevoEmpleado_NumCuenta.KeyPress
        Dim funcion As New Functions()
        funcion.NotLetters(sender, e)
    End Sub

    Private Sub TextBoxNuevoEmpleado_NSS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNuevoEmpleado_NSS.KeyPress
        Dim funcion As New Functions()
        funcion.NotLetters(sender, e)
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

    Private Sub ButtonNuevoEmpleado_Insertar_Click(sender As Object, e As EventArgs) Handles ButtonNuevoEmpleado_Insertar.Click
        Dim insertar As New AdministrarEmpleados_Query()

        Dim pass As String = TextBoxNuevoEmpleado_Contraseña.Text
        Dim nombres As String = TextBoxNuevoEmpleado_Nombres.Text
        Dim APaterno As String = TextBoxNuevoEmpleado_ApPaterno.Text
        Dim AMaterno As String = TextBoxNuevoEmpleado_ApMaterno.Text
        Dim Empresa As String = ComboBoxNuevoEmpleado_Trabajo.Text
        Dim Depto As String = ComboBoxNuevoEmpleado_Depto.Text
        Dim Puesto As String = ComboBoxNuevoEmpleado_Puesto.Text
        Dim NSalarial As Double = Double.Parse(TextBoxNuevoEmpleado_Salarial.Text)
        Dim FechaN As Date = DateTimePickerNuevoEmpleado_FechaNacimiento.Value
        Dim CURP As String = TextBoxNuevoEmpleado_CURP.Text
        Dim NSS As String = TextBoxNuevoEmpleado_NSS.Text
        Dim RFC As String = TextBoxNuevoEmpleado_RFC.Text
        Dim Domicilio As String = TextBoxNuevoEmpleado_Domicilio.Text
        Dim Banco As String = TextBoxNuevoEmpleado_Banco.Text
        Dim NumCuenta As String = TextBoxNuevoEmpleado_NumCuenta.Text
        Dim Email As String = TextBoxNuevoEmpleado_Email.Text
        Dim Telefono As String = TextBoxNuevoEmpleado_Telefono.Text

        Try
            insertar.InsertarEmpleado(pass, nombres, APaterno, AMaterno, Empresa, Depto, Puesto, NSalarial, FechaN, CURP, NSS, RFC, Domicilio, Banco, NumCuenta, Email, Telefono)
            MessageBox.Show("Se ha añadido el empleado! Very chido", "Ya quedó esclavizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("No se ha añadido el empleado! Very muy mal", "No se puedo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
End Class