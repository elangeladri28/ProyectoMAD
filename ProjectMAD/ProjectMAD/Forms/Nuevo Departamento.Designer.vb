<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNuevoDepartamento
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
        Me.LabelNuevoDepartamento_Instruccion = New System.Windows.Forms.Label()
        Me.LabelNuevoDepartamento_Nombre = New System.Windows.Forms.Label()
        Me.TextBoxNuevoDepartamento_Nombre = New System.Windows.Forms.TextBox()
        Me.LabelNuevoDepartamento_Gerente = New System.Windows.Forms.Label()
        Me.TextBoxNuevoDepartamento_Gerente = New System.Windows.Forms.TextBox()
        Me.LabelNuevoDepartamento_SueldoBase = New System.Windows.Forms.Label()
        Me.TextBoxNuevoDepartamento_Sueldo = New System.Windows.Forms.TextBox()
        Me.ButtonNuevoDepartamento_Cancelar = New System.Windows.Forms.Button()
        Me.ButtonNuevoDepartamento_Guardar = New System.Windows.Forms.Button()
        Me.ButtonNuevoDepartamento_Insertar = New System.Windows.Forms.Button()
        Me.LabelNuevoDepartamento_Empresa = New System.Windows.Forms.Label()
        Me.ComboBoxNuevoDepartamento_Empresa = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'LabelNuevoDepartamento_Instruccion
        '
        Me.LabelNuevoDepartamento_Instruccion.AutoSize = True
        Me.LabelNuevoDepartamento_Instruccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNuevoDepartamento_Instruccion.Location = New System.Drawing.Point(36, 9)
        Me.LabelNuevoDepartamento_Instruccion.Name = "LabelNuevoDepartamento_Instruccion"
        Me.LabelNuevoDepartamento_Instruccion.Size = New System.Drawing.Size(343, 32)
        Me.LabelNuevoDepartamento_Instruccion.TabIndex = 0
        Me.LabelNuevoDepartamento_Instruccion.Text = "LLENAR LOS SIGUIENTES CAMPOS PARA AGREGAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " UN NUEVO DEPARTAMENTO AL SISTEMA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LabelNuevoDepartamento_Instruccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelNuevoDepartamento_Nombre
        '
        Me.LabelNuevoDepartamento_Nombre.AutoSize = True
        Me.LabelNuevoDepartamento_Nombre.Location = New System.Drawing.Point(98, 49)
        Me.LabelNuevoDepartamento_Nombre.Name = "LabelNuevoDepartamento_Nombre"
        Me.LabelNuevoDepartamento_Nombre.Size = New System.Drawing.Size(47, 13)
        Me.LabelNuevoDepartamento_Nombre.TabIndex = 1
        Me.LabelNuevoDepartamento_Nombre.Text = "Nombre:"
        '
        'TextBoxNuevoDepartamento_Nombre
        '
        Me.TextBoxNuevoDepartamento_Nombre.Location = New System.Drawing.Point(102, 65)
        Me.TextBoxNuevoDepartamento_Nombre.Name = "TextBoxNuevoDepartamento_Nombre"
        Me.TextBoxNuevoDepartamento_Nombre.Size = New System.Drawing.Size(183, 20)
        Me.TextBoxNuevoDepartamento_Nombre.TabIndex = 2
        '
        'LabelNuevoDepartamento_Gerente
        '
        Me.LabelNuevoDepartamento_Gerente.AutoSize = True
        Me.LabelNuevoDepartamento_Gerente.Location = New System.Drawing.Point(98, 105)
        Me.LabelNuevoDepartamento_Gerente.Name = "LabelNuevoDepartamento_Gerente"
        Me.LabelNuevoDepartamento_Gerente.Size = New System.Drawing.Size(48, 13)
        Me.LabelNuevoDepartamento_Gerente.TabIndex = 3
        Me.LabelNuevoDepartamento_Gerente.Text = "Gerente:"
        '
        'TextBoxNuevoDepartamento_Gerente
        '
        Me.TextBoxNuevoDepartamento_Gerente.Location = New System.Drawing.Point(102, 122)
        Me.TextBoxNuevoDepartamento_Gerente.Name = "TextBoxNuevoDepartamento_Gerente"
        Me.TextBoxNuevoDepartamento_Gerente.Size = New System.Drawing.Size(183, 20)
        Me.TextBoxNuevoDepartamento_Gerente.TabIndex = 4
        '
        'LabelNuevoDepartamento_SueldoBase
        '
        Me.LabelNuevoDepartamento_SueldoBase.AutoSize = True
        Me.LabelNuevoDepartamento_SueldoBase.Location = New System.Drawing.Point(98, 167)
        Me.LabelNuevoDepartamento_SueldoBase.Name = "LabelNuevoDepartamento_SueldoBase"
        Me.LabelNuevoDepartamento_SueldoBase.Size = New System.Drawing.Size(70, 13)
        Me.LabelNuevoDepartamento_SueldoBase.TabIndex = 5
        Me.LabelNuevoDepartamento_SueldoBase.Text = "Sueldo Base:"
        '
        'TextBoxNuevoDepartamento_Sueldo
        '
        Me.TextBoxNuevoDepartamento_Sueldo.Location = New System.Drawing.Point(101, 184)
        Me.TextBoxNuevoDepartamento_Sueldo.Name = "TextBoxNuevoDepartamento_Sueldo"
        Me.TextBoxNuevoDepartamento_Sueldo.Size = New System.Drawing.Size(67, 20)
        Me.TextBoxNuevoDepartamento_Sueldo.TabIndex = 6
        '
        'ButtonNuevoDepartamento_Cancelar
        '
        Me.ButtonNuevoDepartamento_Cancelar.Location = New System.Drawing.Point(237, 289)
        Me.ButtonNuevoDepartamento_Cancelar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonNuevoDepartamento_Cancelar.Name = "ButtonNuevoDepartamento_Cancelar"
        Me.ButtonNuevoDepartamento_Cancelar.Size = New System.Drawing.Size(74, 28)
        Me.ButtonNuevoDepartamento_Cancelar.TabIndex = 7
        Me.ButtonNuevoDepartamento_Cancelar.Text = "Cancelar"
        Me.ButtonNuevoDepartamento_Cancelar.UseVisualStyleBackColor = True
        '
        'ButtonNuevoDepartamento_Guardar
        '
        Me.ButtonNuevoDepartamento_Guardar.Location = New System.Drawing.Point(315, 289)
        Me.ButtonNuevoDepartamento_Guardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonNuevoDepartamento_Guardar.Name = "ButtonNuevoDepartamento_Guardar"
        Me.ButtonNuevoDepartamento_Guardar.Size = New System.Drawing.Size(74, 28)
        Me.ButtonNuevoDepartamento_Guardar.TabIndex = 8
        Me.ButtonNuevoDepartamento_Guardar.Text = "Guardar"
        Me.ButtonNuevoDepartamento_Guardar.UseVisualStyleBackColor = True
        '
        'ButtonNuevoDepartamento_Insertar
        '
        Me.ButtonNuevoDepartamento_Insertar.Location = New System.Drawing.Point(39, 288)
        Me.ButtonNuevoDepartamento_Insertar.Name = "ButtonNuevoDepartamento_Insertar"
        Me.ButtonNuevoDepartamento_Insertar.Size = New System.Drawing.Size(75, 28)
        Me.ButtonNuevoDepartamento_Insertar.TabIndex = 9
        Me.ButtonNuevoDepartamento_Insertar.Text = "Insertar"
        Me.ButtonNuevoDepartamento_Insertar.UseVisualStyleBackColor = True
        '
        'LabelNuevoDepartamento_Empresa
        '
        Me.LabelNuevoDepartamento_Empresa.AutoSize = True
        Me.LabelNuevoDepartamento_Empresa.Location = New System.Drawing.Point(99, 219)
        Me.LabelNuevoDepartamento_Empresa.Name = "LabelNuevoDepartamento_Empresa"
        Me.LabelNuevoDepartamento_Empresa.Size = New System.Drawing.Size(51, 13)
        Me.LabelNuevoDepartamento_Empresa.TabIndex = 10
        Me.LabelNuevoDepartamento_Empresa.Text = "Empresa:"
        '
        'ComboBoxNuevoDepartamento_Empresa
        '
        Me.ComboBoxNuevoDepartamento_Empresa.FormattingEnabled = True
        Me.ComboBoxNuevoDepartamento_Empresa.Location = New System.Drawing.Point(102, 235)
        Me.ComboBoxNuevoDepartamento_Empresa.Name = "ComboBoxNuevoDepartamento_Empresa"
        Me.ComboBoxNuevoDepartamento_Empresa.Size = New System.Drawing.Size(183, 21)
        Me.ComboBoxNuevoDepartamento_Empresa.TabIndex = 11
        '
        'FormNuevoDepartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(400, 328)
        Me.Controls.Add(Me.ComboBoxNuevoDepartamento_Empresa)
        Me.Controls.Add(Me.LabelNuevoDepartamento_Empresa)
        Me.Controls.Add(Me.ButtonNuevoDepartamento_Insertar)
        Me.Controls.Add(Me.ButtonNuevoDepartamento_Guardar)
        Me.Controls.Add(Me.ButtonNuevoDepartamento_Cancelar)
        Me.Controls.Add(Me.TextBoxNuevoDepartamento_Sueldo)
        Me.Controls.Add(Me.LabelNuevoDepartamento_SueldoBase)
        Me.Controls.Add(Me.TextBoxNuevoDepartamento_Gerente)
        Me.Controls.Add(Me.LabelNuevoDepartamento_Gerente)
        Me.Controls.Add(Me.TextBoxNuevoDepartamento_Nombre)
        Me.Controls.Add(Me.LabelNuevoDepartamento_Nombre)
        Me.Controls.Add(Me.LabelNuevoDepartamento_Instruccion)
        Me.Location = New System.Drawing.Point(400, 400)
        Me.Name = "FormNuevoDepartamento"
        Me.Text = "Nuevo Departamento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelNuevoDepartamento_Instruccion As Label
    Friend WithEvents LabelNuevoDepartamento_Nombre As Label
    Friend WithEvents TextBoxNuevoDepartamento_Nombre As TextBox
    Friend WithEvents LabelNuevoDepartamento_Gerente As Label
    Friend WithEvents TextBoxNuevoDepartamento_Gerente As TextBox
    Friend WithEvents LabelNuevoDepartamento_SueldoBase As Label
    Friend WithEvents TextBoxNuevoDepartamento_Sueldo As TextBox
    Friend WithEvents ButtonNuevoDepartamento_Cancelar As Button
    Friend WithEvents ButtonNuevoDepartamento_Guardar As Button
    Friend WithEvents ButtonNuevoDepartamento_Insertar As Button
    Friend WithEvents LabelNuevoDepartamento_Empresa As Label
    Friend WithEvents ComboBoxNuevoDepartamento_Empresa As ComboBox
End Class
