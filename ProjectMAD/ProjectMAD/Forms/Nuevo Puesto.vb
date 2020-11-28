Public Class FormNuevoPuesto
    Dim Sueldito As Decimal
    Dim PropS As Decimal
    Dim SalD As Decimal
    Private Sub ButtonNuevoPuesto_Cancelar_Click(sender As Object, e As EventArgs) Handles ButtonNuevoPuesto_Cancelar.Click
        Dim Resp
        Resp = MsgBox("¿Estás seguro de que deseas salir?, ningún dato sera guardado", vbYesNo, "Advertencia")
        If Resp = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub ButtonNuevoPuesto_Guardar_Click(sender As Object, e As EventArgs) Handles ButtonNuevoPuesto_Guardar.Click
        Try
            Dim Insertar As New AdministrarPuestos_Querys()
            Dim Resp
            Dim Ban As Boolean = False
            Resp = MsgBox("¿Está todo correcto?", vbYesNo, "Advertencia")
            If Resp = vbYes Then

                If (TextBoxNuevoPuesto_ProporcionSalarial.Text = "" And TextBoxNuevoPuesto_Nombre.Text = "" And
                TextBoxNuevoPuesto_SalarioDiario.Text = "" And TextBoxNuevoPuesto_SueldoBase.Text = "") Then

                    MsgBox("Todos los campos deben estar llenos para agregar el puesto", vbOKOnly, "Advertencia")
                    Ban = True
                End If

                If Ban = False Then
                    Dim Combo1 As String = ComboBoxNuevoPuesto_Departamento.Text
                    Dim Combo2 As String = ComboBoxNuevoPuesto_Empresa.Text
                    Insertar.IngresarNuevoPuesto(TextBoxNuevoPuesto_Nombre.Text, TextBoxNuevoPuesto_ProporcionSalarial.Text,
                     TextBoxNuevoPuesto_SalarioDiario.Text, Combo1, Combo2)
                    'Me.Close()
                    MessageBox.Show("Se ha añadido la empresa! Very chido", "Ya quedó", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Se ha añadido la empresa! Very unchido", "Ya quedó errado", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

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



    Private Sub TextBoxNuevoPuesto_ProporcionSalarial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNuevoPuesto_ProporcionSalarial.KeyPress

        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))

    End Sub

    Private Sub FormNuevoPuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cargarCombo As New AdministrarEmpresas_Querys()
        ComboBoxNuevoPuesto_Empresa.DataSource = cargarCombo.GetAllEmpresasName()
        ComboBoxNuevoPuesto_Empresa.DisplayMember = "NombreEmpresa"
        ComboBoxNuevoPuesto_Empresa.SelectedItem = Nothing
    End Sub

    Private Sub ComboBoxNuevoPuesto_Empresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNuevoPuesto_Empresa.SelectedIndexChanged
        Dim cargarCombo2 As New AdministrarDepartamentos_Querys()
        Dim EmpresaCombo As String = ComboBoxNuevoPuesto_Empresa.Text
        ComboBoxNuevoPuesto_Departamento.DataSource = cargarCombo2.GetAllDeptosName(EmpresaCombo)
        ComboBoxNuevoPuesto_Departamento.DisplayMember = "NombreDepartamento"
        ComboBoxNuevoPuesto_Departamento.SelectedItem = Nothing
    End Sub

    Private Sub ComboBoxNuevoPuesto_Departamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNuevoPuesto_Departamento.SelectedIndexChanged

        Dim cargarDGV As New AdministrarDepartamentos_Querys()
        Dim DeptoCombo As String = ComboBoxNuevoPuesto_Departamento.Text
        DGVNuevoPuesto.DataSource = cargarDGV.GetOnlyMoneyDepto(DeptoCombo)
        DGVNuevoPuesto.DataMember = "Departamentos"

        If (DGVNuevoPuesto.Columns.Count <> 0) Then
            DGVNuevoPuesto.Columns.Item(0).HeaderText = "SueldoBase"
        End If

        TextBoxNuevoPuesto_SueldoBase.Text = ""
        TextBoxNuevoPuesto_SueldoBase.Text = DGVNuevoPuesto.Rows(0).Cells("SueldoBase").Value

    End Sub

    Private Sub TextBoxNuevoPuesto_ProporcionSalarial_MouseMove(sender As Object, e As MouseEventArgs) Handles TextBoxNuevoPuesto_ProporcionSalarial.MouseMove

    End Sub

    Private Sub TextBoxNuevoPuesto_ProporcionSalarial_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNuevoPuesto_ProporcionSalarial.TextChanged
        Try
            PropS = Decimal.Parse(TextBoxNuevoPuesto_ProporcionSalarial.Text).ToString("##.00")
            Sueldito = Decimal.Parse(TextBoxNuevoPuesto_SueldoBase.Text).ToString("##.00")
            SalD = Sueldito * PropS
            TextBoxNuevoPuesto_SalarioDiario.Text = SalD.ToString()
        Catch

        End Try
    End Sub
End Class