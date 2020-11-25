<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNuevoPuesto
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
        Me.LabelNuevoPuesto_Nombre = New System.Windows.Forms.Label()
        Me.LabelNuevoPuesto_Instruccion = New System.Windows.Forms.Label()
        Me.TextBoxNuevoPuesto_Nombre = New System.Windows.Forms.TextBox()
        Me.LabelNuevoPuesto_ProporcionSalarial = New System.Windows.Forms.Label()
        Me.TextBoxNuevoPuesto_ProporcionSalarial = New System.Windows.Forms.TextBox()
        Me.LabelNuevoPuesto_SalarioDiario = New System.Windows.Forms.Label()
        Me.TextBoxNuevoPuesto_SalarioDiario = New System.Windows.Forms.TextBox()
        Me.ButtonNuevoPuesto_Cancelar = New System.Windows.Forms.Button()
        Me.ButtonNuevoPuesto_Guardar = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelNuevoPuesto_Nombre
        '
        Me.LabelNuevoPuesto_Nombre.AutoSize = True
        Me.LabelNuevoPuesto_Nombre.Location = New System.Drawing.Point(131, 201)
        Me.LabelNuevoPuesto_Nombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNuevoPuesto_Nombre.Name = "LabelNuevoPuesto_Nombre"
        Me.LabelNuevoPuesto_Nombre.Size = New System.Drawing.Size(62, 17)
        Me.LabelNuevoPuesto_Nombre.TabIndex = 0
        Me.LabelNuevoPuesto_Nombre.Text = "Nombre:"
        '
        'LabelNuevoPuesto_Instruccion
        '
        Me.LabelNuevoPuesto_Instruccion.AutoSize = True
        Me.LabelNuevoPuesto_Instruccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNuevoPuesto_Instruccion.Location = New System.Drawing.Point(9, 11)
        Me.LabelNuevoPuesto_Instruccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNuevoPuesto_Instruccion.Name = "LabelNuevoPuesto_Instruccion"
        Me.LabelNuevoPuesto_Instruccion.Size = New System.Drawing.Size(433, 40)
        Me.LabelNuevoPuesto_Instruccion.TabIndex = 1
        Me.LabelNuevoPuesto_Instruccion.Text = "LLENAR LOS SIGUIENTES CAMPOS PARA AGREGAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " UN NUEVO PUESTO AL SISTEMA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LabelNuevoPuesto_Instruccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxNuevoPuesto_Nombre
        '
        Me.TextBoxNuevoPuesto_Nombre.Location = New System.Drawing.Point(134, 222)
        Me.TextBoxNuevoPuesto_Nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNuevoPuesto_Nombre.Name = "TextBoxNuevoPuesto_Nombre"
        Me.TextBoxNuevoPuesto_Nombre.Size = New System.Drawing.Size(194, 22)
        Me.TextBoxNuevoPuesto_Nombre.TabIndex = 2
        '
        'LabelNuevoPuesto_ProporcionSalarial
        '
        Me.LabelNuevoPuesto_ProporcionSalarial.AutoSize = True
        Me.LabelNuevoPuesto_ProporcionSalarial.Location = New System.Drawing.Point(131, 273)
        Me.LabelNuevoPuesto_ProporcionSalarial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNuevoPuesto_ProporcionSalarial.Name = "LabelNuevoPuesto_ProporcionSalarial"
        Me.LabelNuevoPuesto_ProporcionSalarial.Size = New System.Drawing.Size(132, 17)
        Me.LabelNuevoPuesto_ProporcionSalarial.TabIndex = 3
        Me.LabelNuevoPuesto_ProporcionSalarial.Text = "Proporción Salarial:"
        '
        'TextBoxNuevoPuesto_ProporcionSalarial
        '
        Me.TextBoxNuevoPuesto_ProporcionSalarial.Location = New System.Drawing.Point(134, 294)
        Me.TextBoxNuevoPuesto_ProporcionSalarial.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNuevoPuesto_ProporcionSalarial.Name = "TextBoxNuevoPuesto_ProporcionSalarial"
        Me.TextBoxNuevoPuesto_ProporcionSalarial.Size = New System.Drawing.Size(194, 22)
        Me.TextBoxNuevoPuesto_ProporcionSalarial.TabIndex = 4
        '
        'LabelNuevoPuesto_SalarioDiario
        '
        Me.LabelNuevoPuesto_SalarioDiario.AutoSize = True
        Me.LabelNuevoPuesto_SalarioDiario.Location = New System.Drawing.Point(131, 348)
        Me.LabelNuevoPuesto_SalarioDiario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNuevoPuesto_SalarioDiario.Name = "LabelNuevoPuesto_SalarioDiario"
        Me.LabelNuevoPuesto_SalarioDiario.Size = New System.Drawing.Size(97, 17)
        Me.LabelNuevoPuesto_SalarioDiario.TabIndex = 5
        Me.LabelNuevoPuesto_SalarioDiario.Text = "Salario Diario:"
        '
        'TextBoxNuevoPuesto_SalarioDiario
        '
        Me.TextBoxNuevoPuesto_SalarioDiario.Location = New System.Drawing.Point(134, 369)
        Me.TextBoxNuevoPuesto_SalarioDiario.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNuevoPuesto_SalarioDiario.Name = "TextBoxNuevoPuesto_SalarioDiario"
        Me.TextBoxNuevoPuesto_SalarioDiario.Size = New System.Drawing.Size(193, 22)
        Me.TextBoxNuevoPuesto_SalarioDiario.TabIndex = 6
        '
        'ButtonNuevoPuesto_Cancelar
        '
        Me.ButtonNuevoPuesto_Cancelar.Location = New System.Drawing.Point(88, 437)
        Me.ButtonNuevoPuesto_Cancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonNuevoPuesto_Cancelar.Name = "ButtonNuevoPuesto_Cancelar"
        Me.ButtonNuevoPuesto_Cancelar.Size = New System.Drawing.Size(101, 37)
        Me.ButtonNuevoPuesto_Cancelar.TabIndex = 7
        Me.ButtonNuevoPuesto_Cancelar.Text = "Cancelar"
        Me.ButtonNuevoPuesto_Cancelar.UseVisualStyleBackColor = True
        '
        'ButtonNuevoPuesto_Guardar
        '
        Me.ButtonNuevoPuesto_Guardar.Location = New System.Drawing.Point(277, 437)
        Me.ButtonNuevoPuesto_Guardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonNuevoPuesto_Guardar.Name = "ButtonNuevoPuesto_Guardar"
        Me.ButtonNuevoPuesto_Guardar.Size = New System.Drawing.Size(101, 37)
        Me.ButtonNuevoPuesto_Guardar.TabIndex = 8
        Me.ButtonNuevoPuesto_Guardar.Text = "Agregar"
        Me.ButtonNuevoPuesto_Guardar.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(133, 96)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(194, 24)
        Me.ComboBox1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Empresa:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(133, 157)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(194, 24)
        Me.ComboBox2.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Departamento"
        '
        'FormNuevoPuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(473, 552)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ButtonNuevoPuesto_Guardar)
        Me.Controls.Add(Me.ButtonNuevoPuesto_Cancelar)
        Me.Controls.Add(Me.TextBoxNuevoPuesto_SalarioDiario)
        Me.Controls.Add(Me.LabelNuevoPuesto_SalarioDiario)
        Me.Controls.Add(Me.TextBoxNuevoPuesto_ProporcionSalarial)
        Me.Controls.Add(Me.LabelNuevoPuesto_ProporcionSalarial)
        Me.Controls.Add(Me.TextBoxNuevoPuesto_Nombre)
        Me.Controls.Add(Me.LabelNuevoPuesto_Instruccion)
        Me.Controls.Add(Me.LabelNuevoPuesto_Nombre)
        Me.Location = New System.Drawing.Point(400, 400)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormNuevoPuesto"
        Me.Text = "Nuevo Puesto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelNuevoPuesto_Nombre As Label
    Friend WithEvents LabelNuevoPuesto_Instruccion As Label
    Friend WithEvents TextBoxNuevoPuesto_Nombre As TextBox
    Friend WithEvents LabelNuevoPuesto_ProporcionSalarial As Label
    Friend WithEvents TextBoxNuevoPuesto_ProporcionSalarial As TextBox
    Friend WithEvents LabelNuevoPuesto_SalarioDiario As Label
    Friend WithEvents TextBoxNuevoPuesto_SalarioDiario As TextBox
    Friend WithEvents ButtonNuevoPuesto_Cancelar As Button
    Friend WithEvents ButtonNuevoPuesto_Guardar As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
End Class
