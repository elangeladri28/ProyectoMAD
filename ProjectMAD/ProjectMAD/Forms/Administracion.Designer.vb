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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EmpresasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAdministracion_AñadirEmpresa = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAdministracion_AdministrarEmpresas = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAdministracion_AñadirEmpleado = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NominasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PercepcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeduccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpresasToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(783, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EmpresasToolStripMenuItem
        '
        Me.EmpresasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAdministracion_AñadirEmpresa, Me.MenuAdministracion_AdministrarEmpresas})
        Me.EmpresasToolStripMenuItem.Name = "EmpresasToolStripMenuItem"
        Me.EmpresasToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.EmpresasToolStripMenuItem.Text = "Empresas"
        '
        'MenuAdministracion_AñadirEmpresa
        '
        Me.MenuAdministracion_AñadirEmpresa.Name = "MenuAdministracion_AñadirEmpresa"
        Me.MenuAdministracion_AñadirEmpresa.Size = New System.Drawing.Size(236, 26)
        Me.MenuAdministracion_AñadirEmpresa.Text = "Añadir Empresa"
        '
        'MenuAdministracion_AdministrarEmpresas
        '
        Me.MenuAdministracion_AdministrarEmpresas.Name = "MenuAdministracion_AdministrarEmpresas"
        Me.MenuAdministracion_AdministrarEmpresas.Size = New System.Drawing.Size(236, 26)
        Me.MenuAdministracion_AdministrarEmpresas.Text = "Administrar Empresas"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAdministracion_AñadirEmpleado, Me.AdministrarEmpleadosToolStripMenuItem, Me.NominasToolStripMenuItem})
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(97, 24)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'MenuAdministracion_AñadirEmpleado
        '
        Me.MenuAdministracion_AñadirEmpleado.Name = "MenuAdministracion_AñadirEmpleado"
        Me.MenuAdministracion_AñadirEmpleado.Size = New System.Drawing.Size(247, 26)
        Me.MenuAdministracion_AñadirEmpleado.Text = "Añadir Empleado"
        '
        'AdministrarEmpleadosToolStripMenuItem
        '
        Me.AdministrarEmpleadosToolStripMenuItem.Name = "AdministrarEmpleadosToolStripMenuItem"
        Me.AdministrarEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(247, 26)
        Me.AdministrarEmpleadosToolStripMenuItem.Text = "Administrar Empleados"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'NominasToolStripMenuItem
        '
        Me.NominasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PercepcionesToolStripMenuItem, Me.DeduccionesToolStripMenuItem})
        Me.NominasToolStripMenuItem.Name = "NominasToolStripMenuItem"
        Me.NominasToolStripMenuItem.Size = New System.Drawing.Size(247, 26)
        Me.NominasToolStripMenuItem.Text = "Nominas"
        '
        'PercepcionesToolStripMenuItem
        '
        Me.PercepcionesToolStripMenuItem.Name = "PercepcionesToolStripMenuItem"
        Me.PercepcionesToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.PercepcionesToolStripMenuItem.Text = "Percepciones"
        '
        'DeduccionesToolStripMenuItem
        '
        Me.DeduccionesToolStripMenuItem.Name = "DeduccionesToolStripMenuItem"
        Me.DeduccionesToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DeduccionesToolStripMenuItem.Text = "Deducciones"
        '
        'FormAdministracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(783, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormAdministracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Administración"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EmpresasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuAdministracion_AñadirEmpresa As ToolStripMenuItem
    Friend WithEvents MenuAdministracion_AdministrarEmpresas As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuAdministracion_AñadirEmpleado As ToolStripMenuItem
    Friend WithEvents AdministrarEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NominasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PercepcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeduccionesToolStripMenuItem As ToolStripMenuItem
End Class
