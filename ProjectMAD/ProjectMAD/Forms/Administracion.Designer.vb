<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdministracion
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EmpresasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAdministracion_AñadirEmpresa = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAdministracion_AñadirDepartamento = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAdministracion_AñadirPuesto = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAdministracion_AñadirEmpleado = New System.Windows.Forms.ToolStripMenuItem()
        Me.NominasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PercepcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeduccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PuestosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MAD_PIADataSet = New ProjectMAD.MAD_PIADataSet()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresasTableAdapter = New ProjectMAD.MAD_PIADataSetTableAdapters.EmpresasTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.MAD_PIADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpresasToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.AdministrarDatosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(731, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EmpresasToolStripMenuItem
        '
        Me.EmpresasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAdministracion_AñadirEmpresa, Me.MenuAdministracion_AñadirDepartamento, Me.MenuAdministracion_AñadirPuesto})
        Me.EmpresasToolStripMenuItem.Name = "EmpresasToolStripMenuItem"
        Me.EmpresasToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.EmpresasToolStripMenuItem.Text = "Empresas"
        '
        'MenuAdministracion_AñadirEmpresa
        '
        Me.MenuAdministracion_AñadirEmpresa.Name = "MenuAdministracion_AñadirEmpresa"
        Me.MenuAdministracion_AñadirEmpresa.Size = New System.Drawing.Size(188, 22)
        Me.MenuAdministracion_AñadirEmpresa.Text = "Añadir Empresa"
        '
        'MenuAdministracion_AñadirDepartamento
        '
        Me.MenuAdministracion_AñadirDepartamento.Name = "MenuAdministracion_AñadirDepartamento"
        Me.MenuAdministracion_AñadirDepartamento.Size = New System.Drawing.Size(188, 22)
        Me.MenuAdministracion_AñadirDepartamento.Text = "Añadir Departamento"
        '
        'MenuAdministracion_AñadirPuesto
        '
        Me.MenuAdministracion_AñadirPuesto.Name = "MenuAdministracion_AñadirPuesto"
        Me.MenuAdministracion_AñadirPuesto.Size = New System.Drawing.Size(188, 22)
        Me.MenuAdministracion_AñadirPuesto.Text = "Añadir Puesto"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAdministracion_AñadirEmpleado, Me.NominasToolStripMenuItem})
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'MenuAdministracion_AñadirEmpleado
        '
        Me.MenuAdministracion_AñadirEmpleado.Name = "MenuAdministracion_AñadirEmpleado"
        Me.MenuAdministracion_AñadirEmpleado.Size = New System.Drawing.Size(165, 22)
        Me.MenuAdministracion_AñadirEmpleado.Text = "Añadir Empleado"
        '
        'NominasToolStripMenuItem
        '
        Me.NominasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PercepcionesToolStripMenuItem, Me.DeduccionesToolStripMenuItem})
        Me.NominasToolStripMenuItem.Name = "NominasToolStripMenuItem"
        Me.NominasToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.NominasToolStripMenuItem.Text = "Nominas"
        '
        'PercepcionesToolStripMenuItem
        '
        Me.PercepcionesToolStripMenuItem.Name = "PercepcionesToolStripMenuItem"
        Me.PercepcionesToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PercepcionesToolStripMenuItem.Text = "Percepciones"
        '
        'DeduccionesToolStripMenuItem
        '
        Me.DeduccionesToolStripMenuItem.Name = "DeduccionesToolStripMenuItem"
        Me.DeduccionesToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.DeduccionesToolStripMenuItem.Text = "Deducciones"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'AdministrarDatosToolStripMenuItem
        '
        Me.AdministrarDatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpresasToolStripMenuItem1, Me.DepartamentosToolStripMenuItem, Me.PuestosToolStripMenuItem, Me.EmpleadosToolStripMenuItem1, Me.UsuariosToolStripMenuItem})
        Me.AdministrarDatosToolStripMenuItem.Name = "AdministrarDatosToolStripMenuItem"
        Me.AdministrarDatosToolStripMenuItem.Size = New System.Drawing.Size(114, 20)
        Me.AdministrarDatosToolStripMenuItem.Text = "Administrar Datos"
        '
        'EmpresasToolStripMenuItem1
        '
        Me.EmpresasToolStripMenuItem1.Name = "EmpresasToolStripMenuItem1"
        Me.EmpresasToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.EmpresasToolStripMenuItem1.Text = "Empresas"
        '
        'DepartamentosToolStripMenuItem
        '
        Me.DepartamentosToolStripMenuItem.Name = "DepartamentosToolStripMenuItem"
        Me.DepartamentosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DepartamentosToolStripMenuItem.Text = "Departamentos"
        '
        'PuestosToolStripMenuItem
        '
        Me.PuestosToolStripMenuItem.Name = "PuestosToolStripMenuItem"
        Me.PuestosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PuestosToolStripMenuItem.Text = "Puestos"
        '
        'EmpleadosToolStripMenuItem1
        '
        Me.EmpleadosToolStripMenuItem1.Name = "EmpleadosToolStripMenuItem1"
        Me.EmpleadosToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.EmpleadosToolStripMenuItem1.Text = "Empleados"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'MAD_PIADataSet
        '
        Me.MAD_PIADataSet.DataSetName = "MAD_PIADataSet"
        Me.MAD_PIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataMember = "Empresas"
        Me.EmpresasBindingSource.DataSource = Me.MAD_PIADataSet
        '
        'EmpresasTableAdapter
        '
        Me.EmpresasTableAdapter.ClearBeforeFill = True
        '
        'FormAdministracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(731, 440)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormAdministracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Administración"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.MAD_PIADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EmpresasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuAdministracion_AñadirEmpresa As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuAdministracion_AñadirEmpleado As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NominasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PercepcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeduccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MAD_PIADataSet As MAD_PIADataSet
    Friend WithEvents EmpresasBindingSource As BindingSource
    Friend WithEvents EmpresasTableAdapter As MAD_PIADataSetTableAdapters.EmpresasTableAdapter
    Friend WithEvents MenuAdministracion_AñadirDepartamento As ToolStripMenuItem
    Friend WithEvents MenuAdministracion_AñadirPuesto As ToolStripMenuItem
    Friend WithEvents AdministrarDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpresasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DepartamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PuestosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
End Class
