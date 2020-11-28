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
        Me.ButtonAdministrarPuestos_Insertar = New System.Windows.Forms.Button()
        CType(Me.DGVAdministrarPuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelAdministrarPuestos_Empresa
        '
        Me.LabelAdministrarPuestos_Empresa.AutoSize = True
        Me.LabelAdministrarPuestos_Empresa.Location = New System.Drawing.Point(19, 48)
        Me.LabelAdministrarPuestos_Empresa.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAdministrarPuestos_Empresa.Name = "LabelAdministrarPuestos_Empresa"
        Me.LabelAdministrarPuestos_Empresa.Size = New System.Drawing.Size(51, 13)
        Me.LabelAdministrarPuestos_Empresa.TabIndex = 1
        Me.LabelAdministrarPuestos_Empresa.Text = "Empresa:"
        '
        'ComboBoxAdministrarPuestos_Empresa
        '
        Me.ComboBoxAdministrarPuestos_Empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAdministrarPuestos_Empresa.FormattingEnabled = True
        Me.ComboBoxAdministrarPuestos_Empresa.Location = New System.Drawing.Point(21, 64)
        Me.ComboBoxAdministrarPuestos_Empresa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxAdministrarPuestos_Empresa.Name = "ComboBoxAdministrarPuestos_Empresa"
        Me.ComboBoxAdministrarPuestos_Empresa.Size = New System.Drawing.Size(151, 21)
        Me.ComboBoxAdministrarPuestos_Empresa.TabIndex = 2
        '
        'LabelAdministrarPuestos_Departamento
        '
        Me.LabelAdministrarPuestos_Departamento.AutoSize = True
        Me.LabelAdministrarPuestos_Departamento.Location = New System.Drawing.Point(19, 96)
        Me.LabelAdministrarPuestos_Departamento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAdministrarPuestos_Departamento.Name = "LabelAdministrarPuestos_Departamento"
        Me.LabelAdministrarPuestos_Departamento.Size = New System.Drawing.Size(77, 13)
        Me.LabelAdministrarPuestos_Departamento.TabIndex = 3
        Me.LabelAdministrarPuestos_Departamento.Text = "Departamento:"
        '
        'ComboBoxAdministrarPuestos_Departamento
        '
        Me.ComboBoxAdministrarPuestos_Departamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAdministrarPuestos_Departamento.FormattingEnabled = True
        Me.ComboBoxAdministrarPuestos_Departamento.Location = New System.Drawing.Point(21, 113)
        Me.ComboBoxAdministrarPuestos_Departamento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxAdministrarPuestos_Departamento.Name = "ComboBoxAdministrarPuestos_Departamento"
        Me.ComboBoxAdministrarPuestos_Departamento.Size = New System.Drawing.Size(151, 21)
        Me.ComboBoxAdministrarPuestos_Departamento.TabIndex = 4
        '
        'LabelAdministrarPuestos_Puesto
        '
        Me.LabelAdministrarPuestos_Puesto.AutoSize = True
        Me.LabelAdministrarPuestos_Puesto.Location = New System.Drawing.Point(19, 146)
        Me.LabelAdministrarPuestos_Puesto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAdministrarPuestos_Puesto.Name = "LabelAdministrarPuestos_Puesto"
        Me.LabelAdministrarPuestos_Puesto.Size = New System.Drawing.Size(43, 13)
        Me.LabelAdministrarPuestos_Puesto.TabIndex = 5
        Me.LabelAdministrarPuestos_Puesto.Text = "Puesto:"
        '
        'TextBoxAdministrarPuestos_Puesto
        '
        Me.TextBoxAdministrarPuestos_Puesto.Location = New System.Drawing.Point(21, 163)
        Me.TextBoxAdministrarPuestos_Puesto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxAdministrarPuestos_Puesto.Name = "TextBoxAdministrarPuestos_Puesto"
        Me.TextBoxAdministrarPuestos_Puesto.Size = New System.Drawing.Size(151, 20)
        Me.TextBoxAdministrarPuestos_Puesto.TabIndex = 6
        '
        'LabelAdministrarPuestos_Proporcion
        '
        Me.LabelAdministrarPuestos_Proporcion.AutoSize = True
        Me.LabelAdministrarPuestos_Proporcion.Location = New System.Drawing.Point(19, 197)
        Me.LabelAdministrarPuestos_Proporcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAdministrarPuestos_Proporcion.Name = "LabelAdministrarPuestos_Proporcion"
        Me.LabelAdministrarPuestos_Proporcion.Size = New System.Drawing.Size(98, 13)
        Me.LabelAdministrarPuestos_Proporcion.TabIndex = 7
        Me.LabelAdministrarPuestos_Proporcion.Text = "Proporción Salarial:"
        '
        'TextBoxAdministrarPuestos_Proporcion
        '
        Me.TextBoxAdministrarPuestos_Proporcion.Location = New System.Drawing.Point(21, 214)
        Me.TextBoxAdministrarPuestos_Proporcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxAdministrarPuestos_Proporcion.Name = "TextBoxAdministrarPuestos_Proporcion"
        Me.TextBoxAdministrarPuestos_Proporcion.Size = New System.Drawing.Size(151, 20)
        Me.TextBoxAdministrarPuestos_Proporcion.TabIndex = 8
        '
        'LabelAdministrarPuestos_Salario
        '
        Me.LabelAdministrarPuestos_Salario.AutoSize = True
        Me.LabelAdministrarPuestos_Salario.Location = New System.Drawing.Point(194, 197)
        Me.LabelAdministrarPuestos_Salario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAdministrarPuestos_Salario.Name = "LabelAdministrarPuestos_Salario"
        Me.LabelAdministrarPuestos_Salario.Size = New System.Drawing.Size(72, 13)
        Me.LabelAdministrarPuestos_Salario.TabIndex = 9
        Me.LabelAdministrarPuestos_Salario.Text = "Salario Diario:"
        '
        'TextBoxAdministrarPuestos_Salario
        '
        Me.TextBoxAdministrarPuestos_Salario.Location = New System.Drawing.Point(194, 214)
        Me.TextBoxAdministrarPuestos_Salario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxAdministrarPuestos_Salario.Name = "TextBoxAdministrarPuestos_Salario"
        Me.TextBoxAdministrarPuestos_Salario.ReadOnly = True
        Me.TextBoxAdministrarPuestos_Salario.Size = New System.Drawing.Size(151, 20)
        Me.TextBoxAdministrarPuestos_Salario.TabIndex = 10
        Me.TextBoxAdministrarPuestos_Salario.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 7)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(602, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "NO OLVIDE DEJAR LOS CAMPOS LLENOS DE INFORMACION AL MOMENTO DE GUARDAR O MODIFICA" &
    "R EL PUESTO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DGVAdministrarPuestos
        '
        Me.DGVAdministrarPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAdministrarPuestos.Location = New System.Drawing.Point(356, 48)
        Me.DGVAdministrarPuestos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DGVAdministrarPuestos.Name = "DGVAdministrarPuestos"
        Me.DGVAdministrarPuestos.RowHeadersWidth = 51
        Me.DGVAdministrarPuestos.RowTemplate.Height = 24
        Me.DGVAdministrarPuestos.Size = New System.Drawing.Size(382, 219)
        Me.DGVAdministrarPuestos.TabIndex = 11
        '
        'ButtonAdministrarPuestos_Modificar
        '
        Me.ButtonAdministrarPuestos_Modificar.Location = New System.Drawing.Point(139, 254)
        Me.ButtonAdministrarPuestos_Modificar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonAdministrarPuestos_Modificar.Name = "ButtonAdministrarPuestos_Modificar"
        Me.ButtonAdministrarPuestos_Modificar.Size = New System.Drawing.Size(82, 32)
        Me.ButtonAdministrarPuestos_Modificar.TabIndex = 12
        Me.ButtonAdministrarPuestos_Modificar.Text = "Modificar"
        Me.ButtonAdministrarPuestos_Modificar.UseVisualStyleBackColor = True
        '
        'ButtonAdministrarPuestos_Eliminar
        '
        Me.ButtonAdministrarPuestos_Eliminar.Location = New System.Drawing.Point(21, 254)
        Me.ButtonAdministrarPuestos_Eliminar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonAdministrarPuestos_Eliminar.Name = "ButtonAdministrarPuestos_Eliminar"
        Me.ButtonAdministrarPuestos_Eliminar.Size = New System.Drawing.Size(82, 32)
        Me.ButtonAdministrarPuestos_Eliminar.TabIndex = 13
        Me.ButtonAdministrarPuestos_Eliminar.Text = "Eliminar"
        Me.ButtonAdministrarPuestos_Eliminar.UseVisualStyleBackColor = True
        '
        'ButtonAdministrarPuestos_Aceptar
        '
        Me.ButtonAdministrarPuestos_Aceptar.Location = New System.Drawing.Point(656, 288)
        Me.ButtonAdministrarPuestos_Aceptar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonAdministrarPuestos_Aceptar.Name = "ButtonAdministrarPuestos_Aceptar"
        Me.ButtonAdministrarPuestos_Aceptar.Size = New System.Drawing.Size(82, 32)
        Me.ButtonAdministrarPuestos_Aceptar.TabIndex = 14
        Me.ButtonAdministrarPuestos_Aceptar.Text = "Aceptar"
        Me.ButtonAdministrarPuestos_Aceptar.UseVisualStyleBackColor = True
        '
        'TextBoxAdministrarPuestos_SueldoBase
        '
        Me.TextBoxAdministrarPuestos_SueldoBase.Location = New System.Drawing.Point(194, 113)
        Me.TextBoxAdministrarPuestos_SueldoBase.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxAdministrarPuestos_SueldoBase.Name = "TextBoxAdministrarPuestos_SueldoBase"
        Me.TextBoxAdministrarPuestos_SueldoBase.ReadOnly = True
        Me.TextBoxAdministrarPuestos_SueldoBase.Size = New System.Drawing.Size(151, 20)
        Me.TextBoxAdministrarPuestos_SueldoBase.TabIndex = 15
        Me.TextBoxAdministrarPuestos_SueldoBase.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(176, 113)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "->"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 214)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "->"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 94)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Sueldo Base:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(256, 48)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(20, 18)
        Me.DataGridView1.TabIndex = 19
        Me.DataGridView1.Visible = False
        '
        'ButtonAdministrarPuestos_Insertar
        '
        Me.ButtonAdministrarPuestos_Insertar.Location = New System.Drawing.Point(256, 254)
        Me.ButtonAdministrarPuestos_Insertar.Name = "ButtonAdministrarPuestos_Insertar"
        Me.ButtonAdministrarPuestos_Insertar.Size = New System.Drawing.Size(76, 32)
        Me.ButtonAdministrarPuestos_Insertar.TabIndex = 20
        Me.ButtonAdministrarPuestos_Insertar.Text = "Insertar"
        Me.ButtonAdministrarPuestos_Insertar.UseVisualStyleBackColor = True
        '
        'FormAdministrarPuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(760, 331)
        Me.Controls.Add(Me.ButtonAdministrarPuestos_Insertar)
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
        Me.Location = New System.Drawing.Point(400, 400)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "FormAdministrarPuestos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents ButtonAdministrarPuestos_Insertar As Button
End Class
