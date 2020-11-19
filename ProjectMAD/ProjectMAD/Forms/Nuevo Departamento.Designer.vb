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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
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
        Me.LabelNuevoDepartamento_Nombre.Location = New System.Drawing.Point(12, 74)
        Me.LabelNuevoDepartamento_Nombre.Name = "LabelNuevoDepartamento_Nombre"
        Me.LabelNuevoDepartamento_Nombre.Size = New System.Drawing.Size(47, 13)
        Me.LabelNuevoDepartamento_Nombre.TabIndex = 1
        Me.LabelNuevoDepartamento_Nombre.Text = "Nombre:"
        '
        'TextBoxNuevoDepartamento_Nombre
        '
        Me.TextBoxNuevoDepartamento_Nombre.Location = New System.Drawing.Point(15, 90)
        Me.TextBoxNuevoDepartamento_Nombre.Name = "TextBoxNuevoDepartamento_Nombre"
        Me.TextBoxNuevoDepartamento_Nombre.Size = New System.Drawing.Size(148, 20)
        Me.TextBoxNuevoDepartamento_Nombre.TabIndex = 2
        '
        'LabelNuevoDepartamento_Gerente
        '
        Me.LabelNuevoDepartamento_Gerente.AutoSize = True
        Me.LabelNuevoDepartamento_Gerente.Location = New System.Drawing.Point(12, 130)
        Me.LabelNuevoDepartamento_Gerente.Name = "LabelNuevoDepartamento_Gerente"
        Me.LabelNuevoDepartamento_Gerente.Size = New System.Drawing.Size(48, 13)
        Me.LabelNuevoDepartamento_Gerente.TabIndex = 3
        Me.LabelNuevoDepartamento_Gerente.Text = "Gerente:"
        '
        'TextBoxNuevoDepartamento_Gerente
        '
        Me.TextBoxNuevoDepartamento_Gerente.Location = New System.Drawing.Point(15, 147)
        Me.TextBoxNuevoDepartamento_Gerente.Name = "TextBoxNuevoDepartamento_Gerente"
        Me.TextBoxNuevoDepartamento_Gerente.Size = New System.Drawing.Size(148, 20)
        Me.TextBoxNuevoDepartamento_Gerente.TabIndex = 4
        '
        'LabelNuevoDepartamento_SueldoBase
        '
        Me.LabelNuevoDepartamento_SueldoBase.AutoSize = True
        Me.LabelNuevoDepartamento_SueldoBase.Location = New System.Drawing.Point(15, 193)
        Me.LabelNuevoDepartamento_SueldoBase.Name = "LabelNuevoDepartamento_SueldoBase"
        Me.LabelNuevoDepartamento_SueldoBase.Size = New System.Drawing.Size(70, 13)
        Me.LabelNuevoDepartamento_SueldoBase.TabIndex = 5
        Me.LabelNuevoDepartamento_SueldoBase.Text = "Sueldo Base:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(18, 209)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(145, 20)
        Me.TextBox1.TabIndex = 6
        '
        'FormNuevoDepartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(427, 462)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LabelNuevoDepartamento_SueldoBase)
        Me.Controls.Add(Me.TextBoxNuevoDepartamento_Gerente)
        Me.Controls.Add(Me.LabelNuevoDepartamento_Gerente)
        Me.Controls.Add(Me.TextBoxNuevoDepartamento_Nombre)
        Me.Controls.Add(Me.LabelNuevoDepartamento_Nombre)
        Me.Controls.Add(Me.LabelNuevoDepartamento_Instruccion)
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
    Friend WithEvents TextBox1 As TextBox
End Class
