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
        Me.SuspendLayout()
        '
        'LabelNuevoPuesto_Nombre
        '
        Me.LabelNuevoPuesto_Nombre.AutoSize = True
        Me.LabelNuevoPuesto_Nombre.Location = New System.Drawing.Point(101, 54)
        Me.LabelNuevoPuesto_Nombre.Name = "LabelNuevoPuesto_Nombre"
        Me.LabelNuevoPuesto_Nombre.Size = New System.Drawing.Size(47, 13)
        Me.LabelNuevoPuesto_Nombre.TabIndex = 0
        Me.LabelNuevoPuesto_Nombre.Text = "Nombre:"
        '
        'LabelNuevoPuesto_Instruccion
        '
        Me.LabelNuevoPuesto_Instruccion.AutoSize = True
        Me.LabelNuevoPuesto_Instruccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNuevoPuesto_Instruccion.Location = New System.Drawing.Point(7, 9)
        Me.LabelNuevoPuesto_Instruccion.Name = "LabelNuevoPuesto_Instruccion"
        Me.LabelNuevoPuesto_Instruccion.Size = New System.Drawing.Size(343, 32)
        Me.LabelNuevoPuesto_Instruccion.TabIndex = 1
        Me.LabelNuevoPuesto_Instruccion.Text = "LLENAR LOS SIGUIENTES CAMPOS PARA AGREGAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " UN NUEVO PUESTO AL SISTEMA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LabelNuevoPuesto_Instruccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxNuevoPuesto_Nombre
        '
        Me.TextBoxNuevoPuesto_Nombre.Location = New System.Drawing.Point(104, 71)
        Me.TextBoxNuevoPuesto_Nombre.Name = "TextBoxNuevoPuesto_Nombre"
        Me.TextBoxNuevoPuesto_Nombre.Size = New System.Drawing.Size(137, 20)
        Me.TextBoxNuevoPuesto_Nombre.TabIndex = 2
        '
        'LabelNuevoPuesto_ProporcionSalarial
        '
        Me.LabelNuevoPuesto_ProporcionSalarial.AutoSize = True
        Me.LabelNuevoPuesto_ProporcionSalarial.Location = New System.Drawing.Point(101, 113)
        Me.LabelNuevoPuesto_ProporcionSalarial.Name = "LabelNuevoPuesto_ProporcionSalarial"
        Me.LabelNuevoPuesto_ProporcionSalarial.Size = New System.Drawing.Size(98, 13)
        Me.LabelNuevoPuesto_ProporcionSalarial.TabIndex = 3
        Me.LabelNuevoPuesto_ProporcionSalarial.Text = "Proporción Salarial:"
        '
        'TextBoxNuevoPuesto_ProporcionSalarial
        '
        Me.TextBoxNuevoPuesto_ProporcionSalarial.Location = New System.Drawing.Point(104, 129)
        Me.TextBoxNuevoPuesto_ProporcionSalarial.Name = "TextBoxNuevoPuesto_ProporcionSalarial"
        Me.TextBoxNuevoPuesto_ProporcionSalarial.Size = New System.Drawing.Size(137, 20)
        Me.TextBoxNuevoPuesto_ProporcionSalarial.TabIndex = 4
        '
        'LabelNuevoPuesto_SalarioDiario
        '
        Me.LabelNuevoPuesto_SalarioDiario.AutoSize = True
        Me.LabelNuevoPuesto_SalarioDiario.Location = New System.Drawing.Point(104, 173)
        Me.LabelNuevoPuesto_SalarioDiario.Name = "LabelNuevoPuesto_SalarioDiario"
        Me.LabelNuevoPuesto_SalarioDiario.Size = New System.Drawing.Size(72, 13)
        Me.LabelNuevoPuesto_SalarioDiario.TabIndex = 5
        Me.LabelNuevoPuesto_SalarioDiario.Text = "Salario Diario:"
        '
        'TextBoxNuevoPuesto_SalarioDiario
        '
        Me.TextBoxNuevoPuesto_SalarioDiario.Location = New System.Drawing.Point(104, 190)
        Me.TextBoxNuevoPuesto_SalarioDiario.Name = "TextBoxNuevoPuesto_SalarioDiario"
        Me.TextBoxNuevoPuesto_SalarioDiario.Size = New System.Drawing.Size(137, 20)
        Me.TextBoxNuevoPuesto_SalarioDiario.TabIndex = 6
        '
        'ButtonNuevoPuesto_Cancelar
        '
        Me.ButtonNuevoPuesto_Cancelar.Location = New System.Drawing.Point(68, 245)
        Me.ButtonNuevoPuesto_Cancelar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonNuevoPuesto_Cancelar.Name = "ButtonNuevoPuesto_Cancelar"
        Me.ButtonNuevoPuesto_Cancelar.Size = New System.Drawing.Size(76, 30)
        Me.ButtonNuevoPuesto_Cancelar.TabIndex = 7
        Me.ButtonNuevoPuesto_Cancelar.Text = "Cancelar"
        Me.ButtonNuevoPuesto_Cancelar.UseVisualStyleBackColor = True
        '
        'ButtonNuevoPuesto_Guardar
        '
        Me.ButtonNuevoPuesto_Guardar.Location = New System.Drawing.Point(201, 245)
        Me.ButtonNuevoPuesto_Guardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonNuevoPuesto_Guardar.Name = "ButtonNuevoPuesto_Guardar"
        Me.ButtonNuevoPuesto_Guardar.Size = New System.Drawing.Size(76, 30)
        Me.ButtonNuevoPuesto_Guardar.TabIndex = 8
        Me.ButtonNuevoPuesto_Guardar.Text = "Guardar"
        Me.ButtonNuevoPuesto_Guardar.UseVisualStyleBackColor = True
        '
        'FormNuevoPuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(355, 306)
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
End Class
