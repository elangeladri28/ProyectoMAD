Imports ProjectMAD.SQL_Connection
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

        Dim ola As New AdministrarEmpresas_Querys()
        'PARA RELLENAR EL DGV CON INFORMACIÓN, MANDO LLAMAR A LA FUNCIÓN DEL SELECT
        DGVAdministrarEmpresas.DataSource = ola.SelectAllFromEmpresas()
        DGVAdministrarEmpresas.DataMember = "Empresas"
        If (DGVAdministrarEmpresas.Columns.Count <> 0) Then
            DGVAdministrarEmpresas.Columns.Item(0).HeaderText = "Nombre de Empresa"
            DGVAdministrarEmpresas.Columns.Item(1).HeaderText = "Domicilio Fiscal"
            DGVAdministrarEmpresas.Columns.Item(2).HeaderText = "Teléfono de contacto"
            DGVAdministrarEmpresas.Columns.Item(3).HeaderText = "Registro Patronal"
            DGVAdministrarEmpresas.Columns.Item(5).HeaderText = "Inicio de Operaciones"
        End If
    End Sub

    Private Sub DGVAdministrarEmpresas_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVAdministrarEmpresas.RowHeaderMouseClick

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

            MsgBox("Hay datos que no han sido rellenados", vbOK, "Aviso")

        Else
            MsgBox("Los datos se han guardado correctamente", vbOK, "Aviso")
            'AQUI SE PONEN LAS CAGADAS PARA MANDAR A LLAMAR EL UPDATE DEL SQL
        End If
    End Sub
End Class