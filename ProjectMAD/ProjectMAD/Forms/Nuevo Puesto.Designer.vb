<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNuevoPuesto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.ComboBoxNuevoPuesto_Empresa = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxNuevoPuesto_Departamento = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxNuevoPuesto_SueldoBase = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DGVNuevoPuesto = New System.Windows.Forms.DataGridView()
        CType(Me.DGVNuevoPuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelNuevoPuesto_Nombre
        '
        Me.LabelNuevoPuesto_Nombre.AutoSize = True
        Me.LabelNuevoPuesto_Nombre.Location = New System.Drawing.Point(31, 198)
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
        Me.TextBoxNuevoPuesto_Nombre.Location = New System.Drawing.Point(33, 219)
        Me.TextBoxNuevoPuesto_Nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNuevoPuesto_Nombre.Name = "TextBoxNuevoPuesto_Nombre"
        Me.TextBoxNuevoPuesto_Nombre.Size = New System.Drawing.Size(194, 22)
        Me.TextBoxNuevoPuesto_Nombre.TabIndex = 2
        '
        'LabelNuevoPuesto_ProporcionSalarial
        '
        Me.LabelNuevoPuesto_ProporcionSalarial.AutoSize = True
        Me.LabelNuevoPuesto_ProporcionSalarial.Location = New System.Drawing.Point(31, 270)
        Me.LabelNuevoPuesto_ProporcionSalarial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNuevoPuesto_ProporcionSalarial.Name = "LabelNuevoPuesto_ProporcionSalarial"
        Me.LabelNuevoPuesto_ProporcionSalarial.Size = New System.Drawing.Size(132, 17)
        Me.LabelNuevoPuesto_ProporcionSalarial.TabIndex = 3
        Me.LabelNuevoPuesto_ProporcionSalarial.Text = "Proporción Salarial:"
        '
        'TextBoxNuevoPuesto_ProporcionSalarial
        '
        Me.TextBoxNuevoPuesto_ProporcionSalarial.Location = New System.Drawing.Point(33, 291)
        Me.TextBoxNuevoPuesto_ProporcionSalarial.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNuevoPuesto_ProporcionSalarial.Name = "TextBoxNuevoPuesto_ProporcionSalarial"
        Me.TextBoxNuevoPuesto_ProporcionSalarial.Size = New System.Drawing.Size(194, 22)
        Me.TextBoxNuevoPuesto_ProporcionSalarial.TabIndex = 4
        '
        'LabelNuevoPuesto_SalarioDiario
        '
        Me.LabelNuevoPuesto_SalarioDiario.AutoSize = True
        Me.LabelNuevoPuesto_SalarioDiario.Location = New System.Drawing.Point(260, 270)
        Me.LabelNuevoPuesto_SalarioDiario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNuevoPuesto_SalarioDiario.Name = "LabelNuevoPuesto_SalarioDiario"
        Me.LabelNuevoPuesto_SalarioDiario.Size = New System.Drawing.Size(97, 17)
        Me.LabelNuevoPuesto_SalarioDiario.TabIndex = 5
        Me.LabelNuevoPuesto_SalarioDiario.Text = "Salario Diario:"
        '
        'TextBoxNuevoPuesto_SalarioDiario
        '
        Me.TextBoxNuevoPuesto_SalarioDiario.Location = New System.Drawing.Point(263, 291)
        Me.TextBoxNuevoPuesto_SalarioDiario.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNuevoPuesto_SalarioDiario.Name = "TextBoxNuevoPuesto_SalarioDiario"
        Me.TextBoxNuevoPuesto_SalarioDiario.ReadOnly = True
        Me.TextBoxNuevoPuesto_SalarioDiario.Size = New System.Drawing.Size(193, 22)
        Me.TextBoxNuevoPuesto_SalarioDiario.TabIndex = 6
        '
        'ButtonNuevoPuesto_Cancelar
        '
        Me.ButtonNuevoPuesto_Cancelar.Location = New System.Drawing.Point(119, 360)
        Me.ButtonNuevoPuesto_Cancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonNuevoPuesto_Cancelar.Name = "ButtonNuevoPuesto_Cancelar"
        Me.ButtonNuevoPuesto_Cancelar.Size = New System.Drawing.Size(101, 37)
        Me.ButtonNuevoPuesto_Cancelar.TabIndex = 7
        Me.ButtonNuevoPuesto_Cancelar.Text = "Cancelar"
        Me.ButtonNuevoPuesto_Cancelar.UseVisualStyleBackColor = True
        '
        'ButtonNuevoPuesto_Guardar
        '
        Me.ButtonNuevoPuesto_Guardar.Location = New System.Drawing.Point(266, 360)
        Me.ButtonNuevoPuesto_Guardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonNuevoPuesto_Guardar.Name = "ButtonNuevoPuesto_Guardar"
        Me.ButtonNuevoPuesto_Guardar.Size = New System.Drawing.Size(101, 37)
        Me.ButtonNuevoPuesto_Guardar.TabIndex = 8
        Me.ButtonNuevoPuesto_Guardar.Text = "Agregar"
        Me.ButtonNuevoPuesto_Guardar.UseVisualStyleBackColor = True
        '
        'ComboBoxNuevoPuesto_Empresa
        '
        Me.ComboBoxNuevoPuesto_Empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxNuevoPuesto_Empresa.FormattingEnabled = True
        Me.ComboBoxNuevoPuesto_Empresa.Location = New System.Drawing.Point(33, 93)
        Me.ComboBoxNuevoPuesto_Empresa.Name = "ComboBoxNuevoPuesto_Empresa"
        Me.ComboBoxNuevoPuesto_Empresa.Size = New System.Drawing.Size(194, 24)
        Me.ComboBoxNuevoPuesto_Empresa.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Empresa:"
        '
        'ComboBoxNuevoPuesto_Departamento
        '
        Me.ComboBoxNuevoPuesto_Departamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxNuevoPuesto_Departamento.FormattingEnabled = True
        Me.ComboBoxNuevoPuesto_Departamento.Location = New System.Drawing.Point(33, 154)
        Me.ComboBoxNuevoPuesto_Departamento.Name = "ComboBoxNuevoPuesto_Departamento"
        Me.ComboBoxNuevoPuesto_Departamento.Size = New System.Drawing.Size(194, 24)
        Me.ComboBoxNuevoPuesto_Departamento.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Departamento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(263, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Sueldo Base:"
        '
        'TextBoxNuevoPuesto_SueldoBase
        '
        Me.TextBoxNuevoPuesto_SueldoBase.Location = New System.Drawing.Point(263, 154)
        Me.TextBoxNuevoPuesto_SueldoBase.Name = "TextBoxNuevoPuesto_SueldoBase"
        Me.TextBoxNuevoPuesto_SueldoBase.ReadOnly = True
        Me.TextBoxNuevoPuesto_SueldoBase.Size = New System.Drawing.Size(195, 22)
        Me.TextBoxNuevoPuesto_SueldoBase.TabIndex = 14
        Me.TextBoxNuevoPuesto_SueldoBase.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(235, 293)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "-->"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(233, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "-->"
        '
        'DGVNuevoPuesto
        '
        Me.DGVNuevoPuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVNuevoPuesto.Location = New System.Drawing.Point(450, 35)
        Me.DGVNuevoPuesto.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVNuevoPuesto.Name = "DGVNuevoPuesto"
        Me.DGVNuevoPuesto.ReadOnly = True
        Me.DGVNuevoPuesto.RowHeadersWidth = 51
        Me.DGVNuevoPuesto.Size = New System.Drawing.Size(31, 25)
        Me.DGVNuevoPuesto.TabIndex = 18
        Me.DGVNuevoPuesto.Visible = False
        '
        'FormNuevoPuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(486, 441)
        Me.Controls.Add(Me.DGVNuevoPuesto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxNuevoPuesto_SueldoBase)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxNuevoPuesto_Departamento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxNuevoPuesto_Empresa)
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
        CType(Me.DGVNuevoPuesto, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ComboBoxNuevoPuesto_Empresa As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxNuevoPuesto_Departamento As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxNuevoPuesto_SueldoBase As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DGVNuevoPuesto As DataGridView
End Class
