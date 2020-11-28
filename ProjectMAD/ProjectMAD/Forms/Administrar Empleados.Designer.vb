<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdministrarEmpleados
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
        Me.DGVAdministrarEmpleados = New System.Windows.Forms.DataGridView()
        Me.GroupBoxAdministrarEmpelados = New System.Windows.Forms.GroupBox()
        Me.ComboBoxAdministrarEmpelados_FiltroEmpresa = New System.Windows.Forms.ComboBox()
        Me.ComboBoxAdministrarEmpelados_FiltroDepartamento = New System.Windows.Forms.ComboBox()
        Me.ComboBoxAdministrarEmpelados_FiltroPuesto = New System.Windows.Forms.ComboBox()
        Me.LabelFiltro_Empresa = New System.Windows.Forms.Label()
        Me.LabelFiltro_Departamento = New System.Windows.Forms.Label()
        Me.LabelFiltro_Puesto = New System.Windows.Forms.Label()
        Me.ButtonAdministrarEmpleados_ActualizarDGV = New System.Windows.Forms.Button()
        CType(Me.DGVAdministrarEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxAdministrarEmpelados.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVAdministrarEmpleados
        '
        Me.DGVAdministrarEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAdministrarEmpleados.Location = New System.Drawing.Point(12, 229)
        Me.DGVAdministrarEmpleados.Name = "DGVAdministrarEmpleados"
        Me.DGVAdministrarEmpleados.Size = New System.Drawing.Size(1055, 318)
        Me.DGVAdministrarEmpleados.TabIndex = 0
        '
        'GroupBoxAdministrarEmpelados
        '
        Me.GroupBoxAdministrarEmpelados.Controls.Add(Me.LabelFiltro_Puesto)
        Me.GroupBoxAdministrarEmpelados.Controls.Add(Me.LabelFiltro_Departamento)
        Me.GroupBoxAdministrarEmpelados.Controls.Add(Me.LabelFiltro_Empresa)
        Me.GroupBoxAdministrarEmpelados.Controls.Add(Me.ComboBoxAdministrarEmpelados_FiltroPuesto)
        Me.GroupBoxAdministrarEmpelados.Controls.Add(Me.ComboBoxAdministrarEmpelados_FiltroDepartamento)
        Me.GroupBoxAdministrarEmpelados.Controls.Add(Me.ComboBoxAdministrarEmpelados_FiltroEmpresa)
        Me.GroupBoxAdministrarEmpelados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxAdministrarEmpelados.Location = New System.Drawing.Point(12, 23)
        Me.GroupBoxAdministrarEmpelados.Name = "GroupBoxAdministrarEmpelados"
        Me.GroupBoxAdministrarEmpelados.Size = New System.Drawing.Size(280, 200)
        Me.GroupBoxAdministrarEmpelados.TabIndex = 1
        Me.GroupBoxAdministrarEmpelados.TabStop = False
        Me.GroupBoxAdministrarEmpelados.Text = "Filtros"
        '
        'ComboBoxAdministrarEmpelados_FiltroEmpresa
        '
        Me.ComboBoxAdministrarEmpelados_FiltroEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxAdministrarEmpelados_FiltroEmpresa.FormattingEnabled = True
        Me.ComboBoxAdministrarEmpelados_FiltroEmpresa.Location = New System.Drawing.Point(6, 50)
        Me.ComboBoxAdministrarEmpelados_FiltroEmpresa.Name = "ComboBoxAdministrarEmpelados_FiltroEmpresa"
        Me.ComboBoxAdministrarEmpelados_FiltroEmpresa.Size = New System.Drawing.Size(268, 23)
        Me.ComboBoxAdministrarEmpelados_FiltroEmpresa.TabIndex = 0
        '
        'ComboBoxAdministrarEmpelados_FiltroDepartamento
        '
        Me.ComboBoxAdministrarEmpelados_FiltroDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxAdministrarEmpelados_FiltroDepartamento.FormattingEnabled = True
        Me.ComboBoxAdministrarEmpelados_FiltroDepartamento.Location = New System.Drawing.Point(6, 113)
        Me.ComboBoxAdministrarEmpelados_FiltroDepartamento.Name = "ComboBoxAdministrarEmpelados_FiltroDepartamento"
        Me.ComboBoxAdministrarEmpelados_FiltroDepartamento.Size = New System.Drawing.Size(268, 23)
        Me.ComboBoxAdministrarEmpelados_FiltroDepartamento.TabIndex = 1
        '
        'ComboBoxAdministrarEmpelados_FiltroPuesto
        '
        Me.ComboBoxAdministrarEmpelados_FiltroPuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxAdministrarEmpelados_FiltroPuesto.FormattingEnabled = True
        Me.ComboBoxAdministrarEmpelados_FiltroPuesto.Location = New System.Drawing.Point(6, 171)
        Me.ComboBoxAdministrarEmpelados_FiltroPuesto.Name = "ComboBoxAdministrarEmpelados_FiltroPuesto"
        Me.ComboBoxAdministrarEmpelados_FiltroPuesto.Size = New System.Drawing.Size(268, 23)
        Me.ComboBoxAdministrarEmpelados_FiltroPuesto.TabIndex = 2
        '
        'LabelFiltro_Empresa
        '
        Me.LabelFiltro_Empresa.AutoSize = True
        Me.LabelFiltro_Empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFiltro_Empresa.Location = New System.Drawing.Point(6, 27)
        Me.LabelFiltro_Empresa.Name = "LabelFiltro_Empresa"
        Me.LabelFiltro_Empresa.Size = New System.Drawing.Size(66, 16)
        Me.LabelFiltro_Empresa.TabIndex = 2
        Me.LabelFiltro_Empresa.Text = "Empresa:"
        '
        'LabelFiltro_Departamento
        '
        Me.LabelFiltro_Departamento.AutoSize = True
        Me.LabelFiltro_Departamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFiltro_Departamento.Location = New System.Drawing.Point(6, 94)
        Me.LabelFiltro_Departamento.Name = "LabelFiltro_Departamento"
        Me.LabelFiltro_Departamento.Size = New System.Drawing.Size(94, 16)
        Me.LabelFiltro_Departamento.TabIndex = 3
        Me.LabelFiltro_Departamento.Text = "Departamento"
        '
        'LabelFiltro_Puesto
        '
        Me.LabelFiltro_Puesto.AutoSize = True
        Me.LabelFiltro_Puesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFiltro_Puesto.Location = New System.Drawing.Point(6, 152)
        Me.LabelFiltro_Puesto.Name = "LabelFiltro_Puesto"
        Me.LabelFiltro_Puesto.Size = New System.Drawing.Size(50, 16)
        Me.LabelFiltro_Puesto.TabIndex = 4
        Me.LabelFiltro_Puesto.Text = "Puesto"
        '
        'ButtonAdministrarEmpleados_ActualizarDGV
        '
        Me.ButtonAdministrarEmpleados_ActualizarDGV.Location = New System.Drawing.Point(308, 194)
        Me.ButtonAdministrarEmpleados_ActualizarDGV.Name = "ButtonAdministrarEmpleados_ActualizarDGV"
        Me.ButtonAdministrarEmpleados_ActualizarDGV.Size = New System.Drawing.Size(101, 23)
        Me.ButtonAdministrarEmpleados_ActualizarDGV.TabIndex = 2
        Me.ButtonAdministrarEmpleados_ActualizarDGV.Text = "Actualizar Lista"
        Me.ButtonAdministrarEmpleados_ActualizarDGV.UseVisualStyleBackColor = True
        '
        'FormAdministrarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1079, 559)
        Me.Controls.Add(Me.ButtonAdministrarEmpleados_ActualizarDGV)
        Me.Controls.Add(Me.GroupBoxAdministrarEmpelados)
        Me.Controls.Add(Me.DGVAdministrarEmpleados)
        Me.Name = "FormAdministrarEmpleados"
        Me.Text = "Administrar Empleados"
        CType(Me.DGVAdministrarEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxAdministrarEmpelados.ResumeLayout(False)
        Me.GroupBoxAdministrarEmpelados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVAdministrarEmpleados As DataGridView
    Friend WithEvents GroupBoxAdministrarEmpelados As GroupBox
    Friend WithEvents LabelFiltro_Puesto As Label
    Friend WithEvents LabelFiltro_Departamento As Label
    Friend WithEvents LabelFiltro_Empresa As Label
    Friend WithEvents ComboBoxAdministrarEmpelados_FiltroPuesto As ComboBox
    Friend WithEvents ComboBoxAdministrarEmpelados_FiltroDepartamento As ComboBox
    Friend WithEvents ComboBoxAdministrarEmpelados_FiltroEmpresa As ComboBox
    Friend WithEvents ButtonAdministrarEmpleados_ActualizarDGV As Button
End Class
