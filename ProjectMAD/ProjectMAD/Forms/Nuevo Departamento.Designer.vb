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
        Me.SuspendLayout()
        '
        'LabelNuevoDepartamento_Instruccion
        '
        Me.LabelNuevoDepartamento_Instruccion.AutoSize = True
        Me.LabelNuevoDepartamento_Instruccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNuevoDepartamento_Instruccion.Location = New System.Drawing.Point(48, 11)
        Me.LabelNuevoDepartamento_Instruccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNuevoDepartamento_Instruccion.Name = "LabelNuevoDepartamento_Instruccion"
        Me.LabelNuevoDepartamento_Instruccion.Size = New System.Drawing.Size(433, 40)
        Me.LabelNuevoDepartamento_Instruccion.TabIndex = 0
        Me.LabelNuevoDepartamento_Instruccion.Text = "LLENAR LOS SIGUIENTES CAMPOS PARA AGREGAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " UN NUEVO DEPARTAMENTO AL SISTEMA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LabelNuevoDepartamento_Instruccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelNuevoDepartamento_Nombre
        '
        Me.LabelNuevoDepartamento_Nombre.AutoSize = True
        Me.LabelNuevoDepartamento_Nombre.Location = New System.Drawing.Point(165, 60)
        Me.LabelNuevoDepartamento_Nombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNuevoDepartamento_Nombre.Name = "LabelNuevoDepartamento_Nombre"
        Me.LabelNuevoDepartamento_Nombre.Size = New System.Drawing.Size(62, 17)
        Me.LabelNuevoDepartamento_Nombre.TabIndex = 1
        Me.LabelNuevoDepartamento_Nombre.Text = "Nombre:"
        '
        'TextBoxNuevoDepartamento_Nombre
        '
        Me.TextBoxNuevoDepartamento_Nombre.Location = New System.Drawing.Point(171, 80)
        Me.TextBoxNuevoDepartamento_Nombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxNuevoDepartamento_Nombre.Name = "TextBoxNuevoDepartamento_Nombre"
        Me.TextBoxNuevoDepartamento_Nombre.Size = New System.Drawing.Size(196, 22)
        Me.TextBoxNuevoDepartamento_Nombre.TabIndex = 2
        '
        'LabelNuevoDepartamento_Gerente
        '
        Me.LabelNuevoDepartamento_Gerente.AutoSize = True
        Me.LabelNuevoDepartamento_Gerente.Location = New System.Drawing.Point(165, 129)
        Me.LabelNuevoDepartamento_Gerente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNuevoDepartamento_Gerente.Name = "LabelNuevoDepartamento_Gerente"
        Me.LabelNuevoDepartamento_Gerente.Size = New System.Drawing.Size(64, 17)
        Me.LabelNuevoDepartamento_Gerente.TabIndex = 3
        Me.LabelNuevoDepartamento_Gerente.Text = "Gerente:"
        '
        'TextBoxNuevoDepartamento_Gerente
        '
        Me.TextBoxNuevoDepartamento_Gerente.Location = New System.Drawing.Point(171, 150)
        Me.TextBoxNuevoDepartamento_Gerente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxNuevoDepartamento_Gerente.Name = "TextBoxNuevoDepartamento_Gerente"
        Me.TextBoxNuevoDepartamento_Gerente.Size = New System.Drawing.Size(196, 22)
        Me.TextBoxNuevoDepartamento_Gerente.TabIndex = 4
        '
        'LabelNuevoDepartamento_SueldoBase
        '
        Me.LabelNuevoDepartamento_SueldoBase.AutoSize = True
        Me.LabelNuevoDepartamento_SueldoBase.Location = New System.Drawing.Point(165, 206)
        Me.LabelNuevoDepartamento_SueldoBase.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNuevoDepartamento_SueldoBase.Name = "LabelNuevoDepartamento_SueldoBase"
        Me.LabelNuevoDepartamento_SueldoBase.Size = New System.Drawing.Size(92, 17)
        Me.LabelNuevoDepartamento_SueldoBase.TabIndex = 5
        Me.LabelNuevoDepartamento_SueldoBase.Text = "Sueldo Base:"
        '
        'TextBoxNuevoDepartamento_Sueldo
        '
        Me.TextBoxNuevoDepartamento_Sueldo.Location = New System.Drawing.Point(169, 226)
        Me.TextBoxNuevoDepartamento_Sueldo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxNuevoDepartamento_Sueldo.Name = "TextBoxNuevoDepartamento_Sueldo"
        Me.TextBoxNuevoDepartamento_Sueldo.Size = New System.Drawing.Size(197, 22)
        Me.TextBoxNuevoDepartamento_Sueldo.TabIndex = 6
        '
        'ButtonNuevoDepartamento_Cancelar
        '
        Me.ButtonNuevoDepartamento_Cancelar.Location = New System.Drawing.Point(116, 287)
        Me.ButtonNuevoDepartamento_Cancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonNuevoDepartamento_Cancelar.Name = "ButtonNuevoDepartamento_Cancelar"
        Me.ButtonNuevoDepartamento_Cancelar.Size = New System.Drawing.Size(99, 34)
        Me.ButtonNuevoDepartamento_Cancelar.TabIndex = 7
        Me.ButtonNuevoDepartamento_Cancelar.Text = "Cancelar"
        Me.ButtonNuevoDepartamento_Cancelar.UseVisualStyleBackColor = True
        '
        'ButtonNuevoDepartamento_Guardar
        '
        Me.ButtonNuevoDepartamento_Guardar.Location = New System.Drawing.Point(320, 287)
        Me.ButtonNuevoDepartamento_Guardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonNuevoDepartamento_Guardar.Name = "ButtonNuevoDepartamento_Guardar"
        Me.ButtonNuevoDepartamento_Guardar.Size = New System.Drawing.Size(99, 34)
        Me.ButtonNuevoDepartamento_Guardar.TabIndex = 8
        Me.ButtonNuevoDepartamento_Guardar.Text = "Guardar"
        Me.ButtonNuevoDepartamento_Guardar.UseVisualStyleBackColor = True
        '
        'FormNuevoDepartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(533, 345)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
End Class
