﻿Imports ProjectMAD.SQL_Connection
Imports System.Data.SqlClient

Public Class FormAdministrarEmpresa


    Private Sub EmpresasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpresasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpresasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MAD_PIADataSet)

    End Sub

    Private Sub FormAdministrarEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MAD_PIADataSet.Empresas' table. You can move, or remove it, as needed.
        'Me.EmpresasTableAdapter.Fill(Me.MAD_PIADataSet.Empresas)
        'PARA RELLENAR EL DGV CON INFORMACIÓN, MANDO LLAMAR A LA FUNCIÓN DEL SELECT
        Dim ola As New AdministrarEmpresas_Querys()
        DGVAdministrarEmpresas.DataSource = ola.SelectAllFromEmpresas()
        DGVAdministrarEmpresas.DataMember = "Empresas"
        If (DGVAdministrarEmpresas.Columns.Count <> 0) Then
            DGVAdministrarEmpresas.Columns.Item(0).HeaderText = "ID de Empresa"
            DGVAdministrarEmpresas.Columns.Item(1).HeaderText = "Nombre de Empresa"
            DGVAdministrarEmpresas.Columns.Item(2).HeaderText = "Domicilio Fiscal"
            DGVAdministrarEmpresas.Columns.Item(3).HeaderText = "Teléfono de contacto"
            DGVAdministrarEmpresas.Columns.Item(4).HeaderText = "Registro Patronal"
            DGVAdministrarEmpresas.Columns.Item(6).HeaderText = "Inicio de Operaciones"
        End If
    End Sub

    Private Sub DGVAdministrarEmpresas_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVAdministrarEmpresas.RowHeaderMouseClick
        Try
            TextBoxAdministrarEmpresa_RazonSocial.Text = DGVAdministrarEmpresas.CurrentRow.Cells("NombreEmpresa").Value
            TextBoxAdministrarEmpresa_DomicilioFiscal.Text = DGVAdministrarEmpresas.CurrentRow.Cells("DomicilioFiscal").Value
            TextBoxAdministrarEmpresa_Contacto.Text = DGVAdministrarEmpresas.CurrentRow.Cells("Telefono").Value
            TextBoxAdministrarEmpresa_RegistroPatronal.Text = DGVAdministrarEmpresas.CurrentRow.Cells("RegistroPatronal").Value
            TextBoxAdministrarEmpresa_RFC.Text = DGVAdministrarEmpresas.CurrentRow.Cells("RFC").Value
            DateTimePickerAdministrarEmpresa_InicioOperaciones.Value = Convert.ToDateTime(DGVAdministrarEmpresas.CurrentRow.Cells("FechaInicio").Value)
        Catch ex As Exception
            MessageBox.Show("NO HAY DATOS EN EL DGV PUÑETAS", "OH NO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



        TextBoxAdministrarEmpresa_RazonSocial.Text = DGVAdministrarEmpresas.CurrentRow.Cells("NombreEmpresa").Value
        TextBoxAdministrarEmpresa_DomicilioFiscal.Text = DGVAdministrarEmpresas.CurrentRow.Cells("DomicilioFiscal").Value
        TextBoxAdministrarEmpresa_Contacto.Text = DGVAdministrarEmpresas.CurrentRow.Cells("Telefono").Value
        TextBoxAdministrarEmpresa_RegistroPatronal.Text = DGVAdministrarEmpresas.CurrentRow.Cells("RegistroPatronal").Value
        TextBoxAdministrarEmpresa_RFC.Text = DGVAdministrarEmpresas.CurrentRow.Cells("RFC").Value
        DateTimePickerAdministrarEmpresa_InicioOperaciones.Value = Convert.ToDateTime(DGVAdministrarEmpresas.CurrentRow.Cells("FechaInicio").Value)

    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub ButtonAdministrarEmpresa_Guardar_Click(sender As Object, e As EventArgs) Handles ButtonAdministrarEmpresa_Guardar.Click
        If TextBoxAdministrarEmpresa_RazonSocial.Text = "" Or TextBoxAdministrarEmpresa_DomicilioFiscal.Text = "" Or
             TextBoxAdministrarEmpresa_Contacto.Text = "" Or TextBoxAdministrarEmpresa_RegistroPatronal.Text = "" Or
             TextBoxAdministrarEmpresa_RFC.Text = "" Then

            MessageBox.Show("Hay datos que no han sido rellenados", "OH NO!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            MessageBox.Show("Los datos se han guardado correctamente", "OH YES!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub ButtonAdministrarEmpresas_Borrar_Click(sender As Object, e As EventArgs) Handles ButtonAdministrarEmpresas_Borrar.Click
        Dim borrar As New AdministrarEmpresas_Querys()
        Dim contadorFilas As Integer = DGVAdministrarEmpresas.Rows.Count
        borrar.DeleteRowFromEmpresas(DGVAdministrarEmpresas.CurrentRow.Cells("IDEmpresa").Value)
        FormAdministrarEmpresa_Load(sender, Nothing)
        Dim nuevaCantidadFilas As Integer = DGVAdministrarEmpresas.Rows.Count

        If (contadorFilas > nuevaCantidadFilas) Then
            MessageBox.Show("Los datos se han borrado correctamente", "OH YES!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Los datos NO se han borrado correctamente", "OH Darn!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub ButtonAdministrarEmpresa_Modificar_Click(sender As Object, e As EventArgs) Handles ButtonAdministrarEmpresa_Modificar.Click
        Try
            'Dim nombreOriginal As String = DGVAdministrarEmpresas.CurrentRow.Cells("NombreEmpresa").Value
            'Dim RFCOriginal As String = DGVAdministrarEmpresas.CurrentRow.Cells("RFC").Value

            'If (TextBoxAdministrarEmpresa_RazonSocial.Text <> nombreOriginal And TextBoxAdministrarEmpresa_RFC.Text <> RFCOriginal) Then
            '    MessageBox.Show("No puede modificar el Nombre de la empresa y el RFC al mismo tiempo", "Ahí viene el SAT!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Return
            'End If

            Dim update As New AdministrarEmpresas_Querys()
            update.ModificarEmpresa(DGVAdministrarEmpresas.CurrentRow.Cells("IDEmpresa").Value, TextBoxAdministrarEmpresa_RazonSocial.Text, TextBoxAdministrarEmpresa_DomicilioFiscal.Text,
            TextBoxAdministrarEmpresa_Contacto.Text, TextBoxAdministrarEmpresa_RegistroPatronal.Text, TextBoxAdministrarEmpresa_RFC.Text,
            DateTimePickerAdministrarEmpresa_InicioOperaciones.Value)
            MessageBox.Show("Los datos se han modificado correctamente", "OH YES!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FormAdministrarEmpresa_Load(sender, Nothing)
        Catch ex As Exception
            MessageBox.Show("Los datos NO se han modificado correctamente", "OH Repámpanos!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try


    End Sub

    Private Sub ButtonAdministrarEmpresa_Insertar_Click(sender As Object, e As EventArgs) Handles ButtonAdministrarEmpresa_Insertar.Click
        Dim insert As New AdministrarEmpresas_Querys()
        insert.InsertEmpresa(TextBoxAdministrarEmpresa_RazonSocial.Text, TextBoxAdministrarEmpresa_DomicilioFiscal.Text,
        TextBoxAdministrarEmpresa_Contacto.Text, TextBoxAdministrarEmpresa_RegistroPatronal.Text, TextBoxAdministrarEmpresa_RFC.Text,
        DateTimePickerAdministrarEmpresa_InicioOperaciones.Value)
        Dim contadorFilas As Integer = DGVAdministrarEmpresas.Rows.Count
        FormAdministrarEmpresa_Load(sender, Nothing)
        Dim nuevaCantidadFilas As Integer = DGVAdministrarEmpresas.Rows.Count

        If (contadorFilas < nuevaCantidadFilas) Then
            MessageBox.Show("Los datos se han insertado correctamente", "OH YES!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Los datos NO se han insertado correctamente, verifique los campos", "Oopsis!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
End Class