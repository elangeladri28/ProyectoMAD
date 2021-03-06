﻿Imports ProjectMAD.SQL_Connection
Imports System.Data.SqlClient

Public Class FormAdministrarPuestos
    Dim Sueldito As Decimal
    Dim PropS As Decimal
    Dim SalD As Decimal
    Private Sub FormAdministrarPuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cargarCombo As New AdministrarEmpresas_Querys()
        ComboBoxAdministrarPuestos_Empresa.DataSource = cargarCombo.GetAllEmpresasName()
        ComboBoxAdministrarPuestos_Empresa.DisplayMember = "NombreEmpresa"
        ComboBoxAdministrarPuestos_Empresa.SelectedItem = Nothing

    End Sub

    Private Sub ComboBoxAdministrarPuestos_Empresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAdministrarPuestos_Empresa.SelectedIndexChanged

        Dim cargarCombo2 As New AdministrarDepartamentos_Querys()
        Dim EmpresaCombo As String = ComboBoxAdministrarPuestos_Empresa.Text
        ComboBoxAdministrarPuestos_Departamento.DataSource = cargarCombo2.GetAllDeptosName(EmpresaCombo)
        ComboBoxAdministrarPuestos_Departamento.DisplayMember = "NombreDepartamento"
        ComboBoxAdministrarPuestos_Departamento.SelectedItem = Nothing


    End Sub

    Private Sub ComboBoxAdministrarPuestos_Departamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAdministrarPuestos_Departamento.SelectedIndexChanged
        Try
            Dim cargarDGV As New AdministrarPuestos_Querys()
            Dim EmpresaCombo As String = ComboBoxAdministrarPuestos_Empresa.Text
            Dim DeptoCombo As String = ComboBoxAdministrarPuestos_Departamento.Text
            DGVAdministrarPuestos.DataSource = cargarDGV.SelectAllFromPuestos(EmpresaCombo, DeptoCombo)
            DGVAdministrarPuestos.DataMember = "Puestos"

            If (DGVAdministrarPuestos.Columns.Count <> 0) Then
                DGVAdministrarPuestos.Columns.Item(0).HeaderText = "ID de Puesto"
                DGVAdministrarPuestos.Columns.Item(1).HeaderText = "Nombre de Puesto"
                DGVAdministrarPuestos.Columns.Item(2).HeaderText = "Proporcion Salarial"
                DGVAdministrarPuestos.Columns.Item(3).HeaderText = "Salario Diario"
            End If

            TextBoxAdministrarPuestos_Puesto.Text = ""
            TextBoxAdministrarPuestos_Proporcion.Text = ""
            TextBoxAdministrarPuestos_Salario.Text = ""

            Dim dgv As New AdministrarDepartamentos_Querys()
            Dim dc As String = ComboBoxAdministrarPuestos_Departamento.Text
            Dim de As String = ComboBoxAdministrarPuestos_Empresa.Text
            DataGridView1.DataSource = dgv.GetOnlyMoneyDepto(dc, de)
            DataGridView1.DataMember = "Departamentos"

            If (DataGridView1.Columns.Count <> 0) Then
                DataGridView1.Columns.Item(0).HeaderText = "Sueldo Base"
            End If

            TextBoxAdministrarPuestos_SueldoBase.Text = ""
            TextBoxAdministrarPuestos_SueldoBase.Text = DataGridView1.Rows(0).Cells("SueldoBase").Value
        Catch ex As Exception
            MessageBox.Show("Chale no hay datos", "OH Repámpanos!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub ButtonAdministrarPuestos_Modificar_Click(sender As Object, e As EventArgs) Handles ButtonAdministrarPuestos_Modificar.Click
        Try
            Dim Update As New AdministrarPuestos_Querys()
            Update.ModificarPuestos(DGVAdministrarPuestos.CurrentRow.Cells("IDPuesto").Value, TextBoxAdministrarPuestos_Puesto.Text, TextBoxAdministrarPuestos_Proporcion.Text,
                            TextBoxAdministrarPuestos_Salario.Text, ComboBoxAdministrarPuestos_Departamento.Text, ComboBoxAdministrarPuestos_Empresa.Text)

            MessageBox.Show("Los datos se han modificado correctamente", "OH YES!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FormAdministrarPuestos_Load(sender, e)

        Catch ex As Exception
            MessageBox.Show("Los datos NO se han modificado correctamente", "OH Repámpanos!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub DGVAdministrarPuestos_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVAdministrarPuestos.RowHeaderMouseClick
        TextBoxAdministrarPuestos_Puesto.Text = DGVAdministrarPuestos.CurrentRow.Cells("NombrePuesto").Value
        TextBoxAdministrarPuestos_Proporcion.Text = DGVAdministrarPuestos.CurrentRow.Cells("ProporcionSalarial").Value
        TextBoxAdministrarPuestos_Salario.Text = DGVAdministrarPuestos.CurrentRow.Cells("SalarioDiario").Value
    End Sub

    Private Sub TextBoxAdministrarPuestos_Proporcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxAdministrarPuestos_Proporcion.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))

    End Sub

    Private Sub TextBoxAdministrarPuestos_Proporcion_MouseMove(sender As Object, e As MouseEventArgs) Handles TextBoxAdministrarPuestos_Proporcion.MouseMove
        'Try
        '    PropS = Decimal.Parse(TextBoxAdministrarPuestos_Proporcion.Text).ToString("##.00")
        '    Sueldito = Decimal.Parse(TextBoxAdministrarPuestos_SueldoBase.Text).ToString("##.00")
        '    SalD = Sueldito * PropS
        '    TextBoxAdministrarPuestos_Salario.Text = SalD.ToString()
        'Catch

        'End Try
    End Sub

    Private Sub TextBoxAdministrarPuestos_Proporcion_TextChanged(sender As Object, e As EventArgs) Handles TextBoxAdministrarPuestos_Proporcion.TextChanged
        Try
            PropS = Decimal.Parse(TextBoxAdministrarPuestos_Proporcion.Text).ToString("##.00")
            Sueldito = Decimal.Parse(TextBoxAdministrarPuestos_SueldoBase.Text).ToString("##.00")
            SalD = Sueldito * PropS
            TextBoxAdministrarPuestos_Salario.Text = SalD.ToString("#########.##")
        Catch
        End Try
    End Sub

    Private Sub ButtonAdministrarPuestos_Eliminar_Click(sender As Object, e As EventArgs) Handles ButtonAdministrarPuestos_Eliminar.Click
        Try
            Dim delete As New AdministrarPuestos_Querys()
            delete.EliminarPuesto(TextBoxAdministrarPuestos_Puesto.Text, ComboBoxAdministrarPuestos_Departamento.Text, ComboBoxAdministrarPuestos_Empresa.Text)
            FormAdministrarPuestos_Load(sender, e)

            MessageBox.Show("Los datos se han eliminado correctamente", "OH Yeah, Baby!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Los datos NO se han eliminado correctamente", "OH Mamma!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonAdministrarPuestos_Insertar_Click(sender As Object, e As EventArgs) Handles ButtonAdministrarPuestos_Insertar.Click

        Try
            Dim insert As New AdministrarPuestos_Querys()
            insert.IngresarNuevoPuesto(TextBoxAdministrarPuestos_Puesto.Text, Decimal.Parse(TextBoxAdministrarPuestos_Proporcion.Text), Decimal.Parse(TextBoxAdministrarPuestos_Salario.Text),
                                        ComboBoxAdministrarPuestos_Departamento.Text, ComboBoxAdministrarPuestos_Empresa.Text)
            FormAdministrarPuestos_Load(sender, e)

        Catch ex As Exception
            MessageBox.Show("Los datos NO se han insertado correctamente", "OH Repámpanos!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class