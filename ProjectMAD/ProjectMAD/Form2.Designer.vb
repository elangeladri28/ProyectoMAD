<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirEmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarEmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpresasToolStripMenuItem, Me.EmpleadosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(783, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EmpresasToolStripMenuItem
        '
        Me.EmpresasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirEmpresaToolStripMenuItem, Me.AdministrarEmpresaToolStripMenuItem})
        Me.EmpresasToolStripMenuItem.Name = "EmpresasToolStripMenuItem"
        Me.EmpresasToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.EmpresasToolStripMenuItem.Text = "Empresas"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirEmpleadoToolStripMenuItem, Me.AdministrarEmpleadosToolStripMenuItem})
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(97, 24)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'AñadirEmpresaToolStripMenuItem
        '
        Me.AñadirEmpresaToolStripMenuItem.Name = "AñadirEmpresaToolStripMenuItem"
        Me.AñadirEmpresaToolStripMenuItem.Size = New System.Drawing.Size(236, 26)
        Me.AñadirEmpresaToolStripMenuItem.Text = "Añadir Empresa"
        '
        'AdministrarEmpresaToolStripMenuItem
        '
        Me.AdministrarEmpresaToolStripMenuItem.Name = "AdministrarEmpresaToolStripMenuItem"
        Me.AdministrarEmpresaToolStripMenuItem.Size = New System.Drawing.Size(236, 26)
        Me.AdministrarEmpresaToolStripMenuItem.Text = "Administrar Empresas"
        '
        'AñadirEmpleadoToolStripMenuItem
        '
        Me.AñadirEmpleadoToolStripMenuItem.Name = "AñadirEmpleadoToolStripMenuItem"
        Me.AñadirEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(247, 26)
        Me.AñadirEmpleadoToolStripMenuItem.Text = "Añadir Empleado"
        '
        'AdministrarEmpleadosToolStripMenuItem
        '
        Me.AdministrarEmpleadosToolStripMenuItem.Name = "AdministrarEmpleadosToolStripMenuItem"
        Me.AdministrarEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(247, 26)
        Me.AdministrarEmpleadosToolStripMenuItem.Text = "Administrar Empleados"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EmpresasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirEmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarEmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarEmpleadosToolStripMenuItem As ToolStripMenuItem
End Class
