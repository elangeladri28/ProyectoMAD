<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdministrarPuestos
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
        Me.LabelAdministrarPuestos_Empresa = New System.Windows.Forms.Label()
        Me.ComboBoxAdministrarPuestos_Empresa = New System.Windows.Forms.ComboBox()
        Me.LabelAdministrarPuestos_Departamento = New System.Windows.Forms.Label()
        Me.ComboBoxAdministrarPuestos_Departamento = New System.Windows.Forms.ComboBox()
        Me.LabelAdministrarPuestos_Puesto = New System.Windows.Forms.Label()
        Me.TextBoxAdministrarPuestos_Puesto = New System.Windows.Forms.TextBox()
        Me.LabelAdministrarPuestos_Proporcion = New System.Windows.Forms.Label()
        Me.TextBoxAdministrarPuestos_Proporcion = New System.Windows.Forms.TextBox()
        Me.LabelAdministrarPuestos_Salario = New System.Windows.Forms.Label()
        Me.TextBoxAdministrarPuestos_Salario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DGVAdministrarPuestos = New System.Windows.Forms.DataGridView()
        Me.ButtonAdministrarPuestos_Modificar = New System.Windows.Forms.Button()
        Me.ButtonAdministrarPuestos_Eliminar = New System.Windows.Forms.Button()
        Me.ButtonAdministrarPuestos_Aceptar = New System.Windows.Forms.Button()
        Me.TextBoxAdministrarPuestos_SueldoBase = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DGVAdministrarPuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelAdministrarPuestos_Empresa
        '
        Me.LabelAdministrarPuestos_Empresa.AutoSize = True
        Me.LabelAdministrarPuestos_Empresa.Location = New System.Drawing.Point(25, 59)
        Me.LabelAdministrarPuestos_Empresa.Name = "LabelAdministrarPuestos_Empresa"
        Me.LabelAdministrarPuestos_Empresa.Size = New System.Drawing.Size(68, 17)
        Me.LabelAdministrarPuestos_Empresa.TabIndex = 1
        Me.LabelAdministrarPuestos_Empresa.Text = "Empresa:"
        '
        'ComboBoxAdministrarPuestos_Empresa
        '
        Me.ComboBoxAdministrarPuestos_Empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAdministrarPuestos_Empresa.FormattingEnabled = True
        Me.ComboBoxAdministrarPuestos_Empresa.Location = New System.Drawing.Point(28, 79)
        Me.ComboBoxAdministrarPuestos_Empresa.Name = "ComboBoxAdministrarPuestos_Empresa"
        Me.ComboBoxAdministrarPuestos_Empresa.Size = New System.Drawing.Size(200, 24)
        Me.ComboBoxAdministrarPuestos_Empresa.TabIndex = 2
        '
        'LabelAdministrarPuestos_Departamento
        '
        Me.LabelAdministrarPuestos_Departamento.AutoSize = True
        Me.LabelAdministrarPuestos_Departamento.Location = New System.Drawing.Point(25, 118)
        Me.LabelAdministrarPuestos_Departamento.Name = "LabelAdministrarPuestos_Departamento"
        Me.LabelAdministrarPuestos_Departamento.Size = New System.Drawing.Size(102, 17)
        Me.LabelAdministrarPuestos_Departamento.TabIndex = 3
        Me.LabelAdministrarPuestos_Departamento.Text = "Departamento:"
        '
        'ComboBoxAdministrarPuestos_Departamento
        '
        Me.ComboBoxAdministrarPuestos_Departamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAdministrarPuestos_Departamento.FormattingEnabled = True
        Me.ComboBoxAdministrarPuestos_Departamento.Location = New System.Drawing.Point(28, 139)
        Me.ComboBoxAdministrarPuestos_Departamento.Name = "ComboBoxAdministrarPuestos_Departamento"
        Me.ComboBoxAdministrarPuestos_Departamento.Size = New System.Drawing.Size(200, 24)
        Me.ComboBoxAdministrarPuestos_Departamento.TabIndex = 4
        '
        'LabelAdministrarPuestos_Puesto
        '
        Me.LabelAdministrarPuestos_Puesto.AutoSize = True
        Me.LabelAdministrarPuestos_Puesto.Location = New System.Drawing.Point(25, 180)
        Me.LabelAdministrarPuestos_Puesto.Name = "LabelAdministrarPuestos_Puesto"
        Me.LabelAdministrarPuestos_Puesto.Size = New System.Drawing.Size(56, 17)
        Me.LabelAdministrarPuestos_Puesto.TabIndex = 5
        Me.LabelAdministrarPuestos_Puesto.Text = "Puesto:"
        '
        'TextBoxAdministrarPuestos_Puesto
        '
        Me.TextBoxAdministrarPuestos_Puesto.Location = New System.Drawing.Point(28, 201)
        Me.TextBoxAdministrarPuestos_Puesto.Name = "TextBoxAdministrarPuestos_Puesto"
        Me.TextBoxAdministrarPuestos_Puesto.Size = New System.Drawing.Size(200, 22)
        Me.TextBoxAdministrarPuestos_Puesto.TabIndex = 6
        '
        'LabelAdministrarPuestos_Proporcion
        '
        Me.LabelAdministrarPuestos_Proporcion.AutoSize = True
        Me.LabelAdministrarPuestos_Proporcion.Location = New System.Drawing.Point(25, 243)
        Me.LabelAdministrarPuestos_Proporcion.Name = "LabelAdministrarPuestos_Proporcion"
        Me.LabelAdministrarPuestos_Proporcion.Size = New System.Drawing.Size(132, 17)
        Me.LabelAdministrarPuestos_Proporcion.TabIndex = 7
        Me.LabelAdministrarPuestos_Proporcion.Text = "Proporción Salarial:"
        '
        'TextBoxAdministrarPuestos_Proporcion
        '
        Me.TextBoxAdministrarPuestos_Proporcion.Location = New System.Drawing.Point(28, 263)
        Me.TextBoxAdministrarPuestos_Proporcion.Name = "TextBoxAdministrarPuestos_Proporcion"
        Me.TextBoxAdministrarPuestos_Proporcion.Size = New System.Drawing.Size(200, 22)
        Me.TextBoxAdministrarPuestos_Proporcion.TabIndex = 8
        '
        'LabelAdministrarPuestos_Salario
        '
        Me.LabelAdministrarPuestos_Salario.AutoSize = True
        Me.LabelAdministrarPuestos_Salario.Location = New System.Drawing.Point(258, 242)
        Me.LabelAdministrarPuestos_Salario.Name = "LabelAdministrarPuestos_Salario"
        Me.LabelAdministrarPuestos_Salario.Size = New System.Drawing.Size(97, 17)
        Me.LabelAdministrarPuestos_Salario.TabIndex = 9
        Me.LabelAdministrarPuestos_Salario.Text = "Salario Diario:"
        '
        'TextBoxAdministrarPuestos_Salario
        '
        Me.TextBoxAdministrarPuestos_Salario.Location = New System.Drawing.Point(258, 263)
        Me.TextBoxAdministrarPuestos_Salario.Name = "TextBoxAdministrarPuestos_Salario"
        Me.TextBoxAdministrarPuestos_Salario.ReadOnly = True
        Me.TextBoxAdministrarPuestos_Salario.Size = New System.Drawing.Size(200, 22)
        Me.TextBoxAdministrarPuestos_Salario.TabIndex = 10
        Me.TextBoxAdministrarPuestos_Salario.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(775, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "NO OLVIDE DEJAR LOS CAMPOS LLENOS DE INFORMACION AL MOMENTO DE GUARDAR O MODIFICA" &
    "R EL PUESTO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DGVAdministrarPuestos
        '
        Me.DGVAdministrarPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAdministrarPuestos.Location = New System.Drawing.Point(474, 59)
        Me.DGVAdministrarPuestos.Name = "DGVAdministrarPuestos"
        Me.DGVAdministrarPuestos.RowHeadersWidth = 51
        Me.DGVAdministrarPuestos.RowTemplate.Height = 24
        Me.DGVAdministrarPuestos.Size = New System.Drawing.Size(509, 269)
        Me.DGVAdministrarPuestos.TabIndex = 11
        '
        'ButtonAdministrarPuestos_Modificar
        '
        Me.ButtonAdministrarPuestos_Modificar.Location = New System.Drawing.Point(185, 313)
        Me.ButtonAdministrarPuestos_Modificar.Name = "ButtonAdministrarPuestos_Modificar"
        Me.ButtonAdministrarPuestos_Modificar.Size = New System.Drawing.Size(109, 39)
        Me.ButtonAdministrarPuestos_Modificar.TabIndex = 12
        Me.ButtonAdministrarPuestos_Modificar.Text = "Modificar"
        Me.ButtonAdministrarPuestos_Modificar.UseVisualStyleBackColor = True
        '
        'ButtonAdministrarPuestos_Eliminar
        '
        Me.ButtonAdministrarPuestos_Eliminar.Location = New System.Drawing.Point(28, 313)
        Me.ButtonAdministrarPuestos_Eliminar.Name = "ButtonAdministrarPuestos_Eliminar"
        Me.ButtonAdministrarPuestos_Eliminar.Size = New System.Drawing.Size(109, 39)
        Me.ButtonAdministrarPuestos_Eliminar.TabIndex = 13
        Me.ButtonAdministrarPuestos_Eliminar.Text = "Eliminar"
        Me.ButtonAdministrarPuestos_Eliminar.UseVisualStyleBackColor = True
        '
        'ButtonAdministrarPuestos_Aceptar
        '
        Me.ButtonAdministrarPuestos_Aceptar.Location = New System.Drawing.Point(331, 313)
        Me.ButtonAdministrarPuestos_Aceptar.Name = "ButtonAdministrarPuestos_Aceptar"
        Me.ButtonAdministrarPuestos_Aceptar.Size = New System.Drawing.Size(109, 39)
        Me.ButtonAdministrarPuestos_Aceptar.TabIndex = 14
        Me.ButtonAdministrarPuestos_Aceptar.Text = "Aceptar"
        Me.ButtonAdministrarPuestos_Aceptar.UseVisualStyleBackColor = True
        '
        'TextBoxAdministrarPuestos_SueldoBase
        '
        Me.TextBoxAdministrarPuestos_SueldoBase.Location = New System.Drawing.Point(258, 139)
        Me.TextBoxAdministrarPuestos_SueldoBase.Name = "TextBoxAdministrarPuestos_SueldoBase"
        Me.TextBoxAdministrarPuestos_SueldoBase.ReadOnly = True
        Me.TextBoxAdministrarPuestos_SueldoBase.Size = New System.Drawing.Size(200, 22)
        Me.TextBoxAdministrarPuestos_SueldoBase.TabIndex = 15
        Me.TextBoxAdministrarPuestos_SueldoBase.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(234, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "->"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(234, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "->"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(261, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Sueldo Base:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(342, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(26, 22)
        Me.DataGridView1.TabIndex = 19
        Me.DataGridView1.Visible = False
        '
        'FormAdministrarPuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1013, 407)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxAdministrarPuestos_SueldoBase)
        Me.Controls.Add(Me.ButtonAdministrarPuestos_Aceptar)
        Me.Controls.Add(Me.ButtonAdministrarPuestos_Eliminar)
        Me.Controls.Add(Me.ButtonAdministrarPuestos_Modificar)
        Me.Controls.Add(Me.DGVAdministrarPuestos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxAdministrarPuestos_Salario)
        Me.Controls.Add(Me.LabelAdministrarPuestos_Salario)
        Me.Controls.Add(Me.TextBoxAdministrarPuestos_Proporcion)
        Me.Controls.Add(Me.LabelAdministrarPuestos_Proporcion)
        Me.Controls.Add(Me.TextBoxAdministrarPuestos_Puesto)
        Me.Controls.Add(Me.LabelAdministrarPuestos_Puesto)
        Me.Controls.Add(Me.ComboBoxAdministrarPuestos_Departamento)
        Me.Controls.Add(Me.LabelAdministrarPuestos_Departamento)
        Me.Controls.Add(Me.ComboBoxAdministrarPuestos_Empresa)
        Me.Controls.Add(Me.LabelAdministrarPuestos_Empresa)
        Me.Name = "FormAdministrarPuestos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Administrar Puestos"
        CType(Me.DGVAdministrarPuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelAdministrarPuestos_Empresa As Label
    Friend WithEvents ComboBoxAdministrarPuestos_Empresa As ComboBox
    Friend WithEvents LabelAdministrarPuestos_Departamento As Label
    Friend WithEvents ComboBoxAdministrarPuestos_Departamento As ComboBox
    Friend WithEvents LabelAdministrarPuestos_Puesto As Label
    Friend WithEvents TextBoxAdministrarPuestos_Puesto As TextBox
    Friend WithEvents LabelAdministrarPuestos_Proporcion As Label
    Friend WithEvents TextBoxAdministrarPuestos_Proporcion As TextBox
    Friend WithEvents LabelAdministrarPuestos_Salario As Label
    Friend WithEvents TextBoxAdministrarPuestos_Salario As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DGVAdministrarPuestos As DataGridView
    Friend WithEvents ButtonAdministrarPuestos_Modificar As Button
    Friend WithEvents ButtonAdministrarPuestos_Eliminar As Button
    Friend WithEvents ButtonAdministrarPuestos_Aceptar As Button
    Friend WithEvents TextBoxAdministrarPuestos_SueldoBase As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
