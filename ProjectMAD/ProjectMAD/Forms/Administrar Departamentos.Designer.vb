﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrar_Departamento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelAdministrarDepartamentos_Nombre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxAdministrarDepartamentos_ = New System.Windows.Forms.TextBox()
        Me.TextBoxAdministrarDepartamentos_SueldoBase = New System.Windows.Forms.TextBox()
        Me.LabelAdministrarDepartamentos_Gerente = New System.Windows.Forms.Label()
        Me.TextBoxAdministrarDepartamentos_Gerente = New System.Windows.Forms.TextBox()
        Me.LabelAdministrarDepartamentos_Empresa = New System.Windows.Forms.Label()
        Me.ComboBoxAdministrarDepartamentos_Empresa = New System.Windows.Forms.ComboBox()
        Me.DGVAdministrarDepartamentos = New System.Windows.Forms.DataGridView()
        Me.ButtonAdministrarDepartamentos_Insertar = New System.Windows.Forms.Button()
        Me.ButtonAdministrarEmpresas_Modificar = New System.Windows.Forms.Button()
        Me.ButtonAdministrarEmpresas_Eliminar = New System.Windows.Forms.Button()
        CType(Me.DGVAdministrarDepartamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelAdministrarDepartamentos_Nombre
        '
        Me.LabelAdministrarDepartamentos_Nombre.AutoSize = True
        Me.LabelAdministrarDepartamentos_Nombre.Location = New System.Drawing.Point(12, 128)
        Me.LabelAdministrarDepartamentos_Nombre.Name = "LabelAdministrarDepartamentos_Nombre"
        Me.LabelAdministrarDepartamentos_Nombre.Size = New System.Drawing.Size(134, 13)
        Me.LabelAdministrarDepartamentos_Nombre.TabIndex = 0
        Me.LabelAdministrarDepartamentos_Nombre.Text = "Nombre del Departamento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sueldo Base:"
        '
        'TextBoxAdministrarDepartamentos_
        '
        Me.TextBoxAdministrarDepartamentos_.Location = New System.Drawing.Point(15, 145)
        Me.TextBoxAdministrarDepartamentos_.Name = "TextBoxAdministrarDepartamentos_"
        Me.TextBoxAdministrarDepartamentos_.Size = New System.Drawing.Size(219, 20)
        Me.TextBoxAdministrarDepartamentos_.TabIndex = 2
        '
        'TextBoxAdministrarDepartamentos_SueldoBase
        '
        Me.TextBoxAdministrarDepartamentos_SueldoBase.Location = New System.Drawing.Point(15, 199)
        Me.TextBoxAdministrarDepartamentos_SueldoBase.Name = "TextBoxAdministrarDepartamentos_SueldoBase"
        Me.TextBoxAdministrarDepartamentos_SueldoBase.Size = New System.Drawing.Size(85, 20)
        Me.TextBoxAdministrarDepartamentos_SueldoBase.TabIndex = 3
        '
        'LabelAdministrarDepartamentos_Gerente
        '
        Me.LabelAdministrarDepartamentos_Gerente.AutoSize = True
        Me.LabelAdministrarDepartamentos_Gerente.Location = New System.Drawing.Point(12, 242)
        Me.LabelAdministrarDepartamentos_Gerente.Name = "LabelAdministrarDepartamentos_Gerente"
        Me.LabelAdministrarDepartamentos_Gerente.Size = New System.Drawing.Size(48, 13)
        Me.LabelAdministrarDepartamentos_Gerente.TabIndex = 4
        Me.LabelAdministrarDepartamentos_Gerente.Text = "Gerente:"
        '
        'TextBoxAdministrarDepartamentos_Gerente
        '
        Me.TextBoxAdministrarDepartamentos_Gerente.Location = New System.Drawing.Point(15, 259)
        Me.TextBoxAdministrarDepartamentos_Gerente.Name = "TextBoxAdministrarDepartamentos_Gerente"
        Me.TextBoxAdministrarDepartamentos_Gerente.Size = New System.Drawing.Size(219, 20)
        Me.TextBoxAdministrarDepartamentos_Gerente.TabIndex = 5
        '
        'LabelAdministrarDepartamentos_Empresa
        '
        Me.LabelAdministrarDepartamentos_Empresa.AutoSize = True
        Me.LabelAdministrarDepartamentos_Empresa.Location = New System.Drawing.Point(12, 39)
        Me.LabelAdministrarDepartamentos_Empresa.Name = "LabelAdministrarDepartamentos_Empresa"
        Me.LabelAdministrarDepartamentos_Empresa.Size = New System.Drawing.Size(51, 13)
        Me.LabelAdministrarDepartamentos_Empresa.TabIndex = 6
        Me.LabelAdministrarDepartamentos_Empresa.Text = "Empresa:"
        '
        'ComboBoxAdministrarDepartamentos_Empresa
        '
        Me.ComboBoxAdministrarDepartamentos_Empresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxAdministrarDepartamentos_Empresa.FormattingEnabled = True
        Me.ComboBoxAdministrarDepartamentos_Empresa.Location = New System.Drawing.Point(12, 55)
        Me.ComboBoxAdministrarDepartamentos_Empresa.Name = "ComboBoxAdministrarDepartamentos_Empresa"
        Me.ComboBoxAdministrarDepartamentos_Empresa.Size = New System.Drawing.Size(216, 21)
        Me.ComboBoxAdministrarDepartamentos_Empresa.TabIndex = 7
        '
        'DGVAdministrarDepartamentos
        '
        Me.DGVAdministrarDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAdministrarDepartamentos.Location = New System.Drawing.Point(270, 38)
        Me.DGVAdministrarDepartamentos.Name = "DGVAdministrarDepartamentos"
        Me.DGVAdministrarDepartamentos.Size = New System.Drawing.Size(437, 275)
        Me.DGVAdministrarDepartamentos.TabIndex = 8
        '
        'ButtonAdministrarDepartamentos_Insertar
        '
        Me.ButtonAdministrarDepartamentos_Insertar.Location = New System.Drawing.Point(270, 350)
        Me.ButtonAdministrarDepartamentos_Insertar.Name = "ButtonAdministrarDepartamentos_Insertar"
        Me.ButtonAdministrarDepartamentos_Insertar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAdministrarDepartamentos_Insertar.TabIndex = 9
        Me.ButtonAdministrarDepartamentos_Insertar.Text = "Insertar"
        Me.ButtonAdministrarDepartamentos_Insertar.UseVisualStyleBackColor = True
        '
        'ButtonAdministrarEmpresas_Modificar
        '
        Me.ButtonAdministrarEmpresas_Modificar.Location = New System.Drawing.Point(351, 350)
        Me.ButtonAdministrarEmpresas_Modificar.Name = "ButtonAdministrarEmpresas_Modificar"
        Me.ButtonAdministrarEmpresas_Modificar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAdministrarEmpresas_Modificar.TabIndex = 10
        Me.ButtonAdministrarEmpresas_Modificar.Text = "Modificar"
        Me.ButtonAdministrarEmpresas_Modificar.UseVisualStyleBackColor = True
        '
        'ButtonAdministrarEmpresas_Eliminar
        '
        Me.ButtonAdministrarEmpresas_Eliminar.Location = New System.Drawing.Point(432, 350)
        Me.ButtonAdministrarEmpresas_Eliminar.Name = "ButtonAdministrarEmpresas_Eliminar"
        Me.ButtonAdministrarEmpresas_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAdministrarEmpresas_Eliminar.TabIndex = 11
        Me.ButtonAdministrarEmpresas_Eliminar.Text = "Eliminar"
        Me.ButtonAdministrarEmpresas_Eliminar.UseVisualStyleBackColor = True
        '
        'Administrar_Departamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(718, 450)
        Me.Controls.Add(Me.ButtonAdministrarEmpresas_Eliminar)
        Me.Controls.Add(Me.ButtonAdministrarEmpresas_Modificar)
        Me.Controls.Add(Me.ButtonAdministrarDepartamentos_Insertar)
        Me.Controls.Add(Me.DGVAdministrarDepartamentos)
        Me.Controls.Add(Me.ComboBoxAdministrarDepartamentos_Empresa)
        Me.Controls.Add(Me.LabelAdministrarDepartamentos_Empresa)
        Me.Controls.Add(Me.TextBoxAdministrarDepartamentos_Gerente)
        Me.Controls.Add(Me.LabelAdministrarDepartamentos_Gerente)
        Me.Controls.Add(Me.TextBoxAdministrarDepartamentos_SueldoBase)
        Me.Controls.Add(Me.TextBoxAdministrarDepartamentos_)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelAdministrarDepartamentos_Nombre)
        Me.Name = "Administrar_Departamento"
        Me.Text = "Administrar Departamentos"
        CType(Me.DGVAdministrarDepartamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelAdministrarDepartamentos_Nombre As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxAdministrarDepartamentos_ As TextBox
    Friend WithEvents TextBoxAdministrarDepartamentos_SueldoBase As TextBox
    Friend WithEvents LabelAdministrarDepartamentos_Gerente As Label
    Friend WithEvents TextBoxAdministrarDepartamentos_Gerente As TextBox
    Friend WithEvents LabelAdministrarDepartamentos_Empresa As Label
    Friend WithEvents ComboBoxAdministrarDepartamentos_Empresa As ComboBox
    Friend WithEvents DGVAdministrarDepartamentos As DataGridView
    Friend WithEvents ButtonAdministrarDepartamentos_Insertar As Button
    Friend WithEvents ButtonAdministrarEmpresas_Modificar As Button
    Friend WithEvents ButtonAdministrarEmpresas_Eliminar As Button
End Class
