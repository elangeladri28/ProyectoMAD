<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNuevaEmpresa
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
        Me.LabelNuevaEmpresa_Instruccion = New System.Windows.Forms.Label()
        Me.TextBoxNuevaEmpresa_RazonSocial = New System.Windows.Forms.TextBox()
        Me.LabelNuevaEmpresa_RazonSocial = New System.Windows.Forms.Label()
        Me.TextBoxNuevaEmpresa_DomicilioFiscal = New System.Windows.Forms.TextBox()
        Me.LabelNuevaEmpresa_DomicilioFiscal = New System.Windows.Forms.Label()
        Me.LabelNuevaEmpresa_Contacto = New System.Windows.Forms.Label()
        Me.TextBoxNuevaEmpresa_Contacto = New System.Windows.Forms.TextBox()
        Me.LabelNuevaEmpresa_RegistroPatronal = New System.Windows.Forms.Label()
        Me.TextBoxNuevaEmpresa_RegistroPatronal = New System.Windows.Forms.TextBox()
        Me.LabelNuevaEmpresa_RFC = New System.Windows.Forms.Label()
        Me.TextBoxNuevaEmpresa_RFC = New System.Windows.Forms.TextBox()
        Me.ButtonNuevaEmpresa_Cancelar = New System.Windows.Forms.Button()
        Me.ButtonNuevaEmpresa_Guardar = New System.Windows.Forms.Button()
        Me.LabelNuevaEmpresa_InicioOperaciones = New System.Windows.Forms.Label()
        Me.DateTimePickerNuevaEmpresa_InicioOperaciones = New System.Windows.Forms.DateTimePicker()
        Me.ButtonNuevaEmpresa_Insertar = New System.Windows.Forms.Button()
        Me.LabelNuevaEmpresa_TelefonoVal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelNuevaEmpresa_Instruccion
        '
        Me.LabelNuevaEmpresa_Instruccion.AutoSize = True
        Me.LabelNuevaEmpresa_Instruccion.Location = New System.Drawing.Point(38, 7)
        Me.LabelNuevaEmpresa_Instruccion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNuevaEmpresa_Instruccion.Name = "LabelNuevaEmpresa_Instruccion"
        Me.LabelNuevaEmpresa_Instruccion.Size = New System.Drawing.Size(203, 39)
        Me.LabelNuevaEmpresa_Instruccion.TabIndex = 0
        Me.LabelNuevaEmpresa_Instruccion.Text = "LLENAR LOS SIGUIENTES CAMPOS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PARA AGREGAR LA NUEVA EMPRESA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AL SISTEMA"
        Me.LabelNuevaEmpresa_Instruccion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBoxNuevaEmpresa_RazonSocial
        '
        Me.TextBoxNuevaEmpresa_RazonSocial.Location = New System.Drawing.Point(47, 76)
        Me.TextBoxNuevaEmpresa_RazonSocial.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxNuevaEmpresa_RazonSocial.Name = "TextBoxNuevaEmpresa_RazonSocial"
        Me.TextBoxNuevaEmpresa_RazonSocial.Size = New System.Drawing.Size(177, 20)
        Me.TextBoxNuevaEmpresa_RazonSocial.TabIndex = 1
        '
        'LabelNuevaEmpresa_RazonSocial
        '
        Me.LabelNuevaEmpresa_RazonSocial.AutoSize = True
        Me.LabelNuevaEmpresa_RazonSocial.Location = New System.Drawing.Point(47, 60)
        Me.LabelNuevaEmpresa_RazonSocial.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNuevaEmpresa_RazonSocial.Name = "LabelNuevaEmpresa_RazonSocial"
        Me.LabelNuevaEmpresa_RazonSocial.Size = New System.Drawing.Size(175, 13)
        Me.LabelNuevaEmpresa_RazonSocial.TabIndex = 2
        Me.LabelNuevaEmpresa_RazonSocial.Text = "Razon Social (Nombre de Empresa)"
        '
        'TextBoxNuevaEmpresa_DomicilioFiscal
        '
        Me.TextBoxNuevaEmpresa_DomicilioFiscal.Location = New System.Drawing.Point(47, 124)
        Me.TextBoxNuevaEmpresa_DomicilioFiscal.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxNuevaEmpresa_DomicilioFiscal.Multiline = True
        Me.TextBoxNuevaEmpresa_DomicilioFiscal.Name = "TextBoxNuevaEmpresa_DomicilioFiscal"
        Me.TextBoxNuevaEmpresa_DomicilioFiscal.Size = New System.Drawing.Size(177, 60)
        Me.TextBoxNuevaEmpresa_DomicilioFiscal.TabIndex = 3
        '
        'LabelNuevaEmpresa_DomicilioFiscal
        '
        Me.LabelNuevaEmpresa_DomicilioFiscal.AutoSize = True
        Me.LabelNuevaEmpresa_DomicilioFiscal.Location = New System.Drawing.Point(47, 106)
        Me.LabelNuevaEmpresa_DomicilioFiscal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNuevaEmpresa_DomicilioFiscal.Name = "LabelNuevaEmpresa_DomicilioFiscal"
        Me.LabelNuevaEmpresa_DomicilioFiscal.Size = New System.Drawing.Size(79, 13)
        Me.LabelNuevaEmpresa_DomicilioFiscal.TabIndex = 4
        Me.LabelNuevaEmpresa_DomicilioFiscal.Text = "Domicilio Fiscal"
        '
        'LabelNuevaEmpresa_Contacto
        '
        Me.LabelNuevaEmpresa_Contacto.AutoSize = True
        Me.LabelNuevaEmpresa_Contacto.Location = New System.Drawing.Point(43, 207)
        Me.LabelNuevaEmpresa_Contacto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNuevaEmpresa_Contacto.Name = "LabelNuevaEmpresa_Contacto"
        Me.LabelNuevaEmpresa_Contacto.Size = New System.Drawing.Size(101, 13)
        Me.LabelNuevaEmpresa_Contacto.TabIndex = 5
        Me.LabelNuevaEmpresa_Contacto.Text = "Contacto (Teléfono)"
        '
        'TextBoxNuevaEmpresa_Contacto
        '
        Me.TextBoxNuevaEmpresa_Contacto.Location = New System.Drawing.Point(47, 244)
        Me.TextBoxNuevaEmpresa_Contacto.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxNuevaEmpresa_Contacto.Name = "TextBoxNuevaEmpresa_Contacto"
        Me.TextBoxNuevaEmpresa_Contacto.Size = New System.Drawing.Size(177, 20)
        Me.TextBoxNuevaEmpresa_Contacto.TabIndex = 6
        '
        'LabelNuevaEmpresa_RegistroPatronal
        '
        Me.LabelNuevaEmpresa_RegistroPatronal.AutoSize = True
        Me.LabelNuevaEmpresa_RegistroPatronal.Location = New System.Drawing.Point(47, 270)
        Me.LabelNuevaEmpresa_RegistroPatronal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNuevaEmpresa_RegistroPatronal.Name = "LabelNuevaEmpresa_RegistroPatronal"
        Me.LabelNuevaEmpresa_RegistroPatronal.Size = New System.Drawing.Size(88, 13)
        Me.LabelNuevaEmpresa_RegistroPatronal.TabIndex = 7
        Me.LabelNuevaEmpresa_RegistroPatronal.Text = "Registro Patronal"
        '
        'TextBoxNuevaEmpresa_RegistroPatronal
        '
        Me.TextBoxNuevaEmpresa_RegistroPatronal.Location = New System.Drawing.Point(47, 289)
        Me.TextBoxNuevaEmpresa_RegistroPatronal.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxNuevaEmpresa_RegistroPatronal.Name = "TextBoxNuevaEmpresa_RegistroPatronal"
        Me.TextBoxNuevaEmpresa_RegistroPatronal.Size = New System.Drawing.Size(177, 20)
        Me.TextBoxNuevaEmpresa_RegistroPatronal.TabIndex = 8
        '
        'LabelNuevaEmpresa_RFC
        '
        Me.LabelNuevaEmpresa_RFC.AutoSize = True
        Me.LabelNuevaEmpresa_RFC.Location = New System.Drawing.Point(47, 312)
        Me.LabelNuevaEmpresa_RFC.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNuevaEmpresa_RFC.Name = "LabelNuevaEmpresa_RFC"
        Me.LabelNuevaEmpresa_RFC.Size = New System.Drawing.Size(28, 13)
        Me.LabelNuevaEmpresa_RFC.TabIndex = 9
        Me.LabelNuevaEmpresa_RFC.Text = "RFC"
        '
        'TextBoxNuevaEmpresa_RFC
        '
        Me.TextBoxNuevaEmpresa_RFC.Location = New System.Drawing.Point(47, 327)
        Me.TextBoxNuevaEmpresa_RFC.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxNuevaEmpresa_RFC.Name = "TextBoxNuevaEmpresa_RFC"
        Me.TextBoxNuevaEmpresa_RFC.Size = New System.Drawing.Size(177, 20)
        Me.TextBoxNuevaEmpresa_RFC.TabIndex = 10
        '
        'ButtonNuevaEmpresa_Cancelar
        '
        Me.ButtonNuevaEmpresa_Cancelar.Location = New System.Drawing.Point(49, 453)
        Me.ButtonNuevaEmpresa_Cancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonNuevaEmpresa_Cancelar.Name = "ButtonNuevaEmpresa_Cancelar"
        Me.ButtonNuevaEmpresa_Cancelar.Size = New System.Drawing.Size(74, 26)
        Me.ButtonNuevaEmpresa_Cancelar.TabIndex = 12
        Me.ButtonNuevaEmpresa_Cancelar.Text = "Cancelar"
        Me.ButtonNuevaEmpresa_Cancelar.UseVisualStyleBackColor = True
        '
        'ButtonNuevaEmpresa_Guardar
        '
        Me.ButtonNuevaEmpresa_Guardar.Location = New System.Drawing.Point(148, 453)
        Me.ButtonNuevaEmpresa_Guardar.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonNuevaEmpresa_Guardar.Name = "ButtonNuevaEmpresa_Guardar"
        Me.ButtonNuevaEmpresa_Guardar.Size = New System.Drawing.Size(74, 26)
        Me.ButtonNuevaEmpresa_Guardar.TabIndex = 13
        Me.ButtonNuevaEmpresa_Guardar.Text = "Guardar"
        Me.ButtonNuevaEmpresa_Guardar.UseVisualStyleBackColor = True
        '
        'LabelNuevaEmpresa_InicioOperaciones
        '
        Me.LabelNuevaEmpresa_InicioOperaciones.AutoSize = True
        Me.LabelNuevaEmpresa_InicioOperaciones.Location = New System.Drawing.Point(46, 354)
        Me.LabelNuevaEmpresa_InicioOperaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNuevaEmpresa_InicioOperaciones.Name = "LabelNuevaEmpresa_InicioOperaciones"
        Me.LabelNuevaEmpresa_InicioOperaciones.Size = New System.Drawing.Size(158, 13)
        Me.LabelNuevaEmpresa_InicioOperaciones.TabIndex = 14
        Me.LabelNuevaEmpresa_InicioOperaciones.Text = "Fecha de Inicio de Operaciones"
        '
        'DateTimePickerNuevaEmpresa_InicioOperaciones
        '
        Me.DateTimePickerNuevaEmpresa_InicioOperaciones.CustomFormat = ""
        Me.DateTimePickerNuevaEmpresa_InicioOperaciones.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerNuevaEmpresa_InicioOperaciones.Location = New System.Drawing.Point(46, 371)
        Me.DateTimePickerNuevaEmpresa_InicioOperaciones.Name = "DateTimePickerNuevaEmpresa_InicioOperaciones"
        Me.DateTimePickerNuevaEmpresa_InicioOperaciones.Size = New System.Drawing.Size(177, 20)
        Me.DateTimePickerNuevaEmpresa_InicioOperaciones.TabIndex = 11
        Me.DateTimePickerNuevaEmpresa_InicioOperaciones.Value = New Date(2020, 11, 17, 21, 23, 0, 0)
        '
        'ButtonNuevaEmpresa_Insertar
        '
        Me.ButtonNuevaEmpresa_Insertar.Location = New System.Drawing.Point(102, 425)
        Me.ButtonNuevaEmpresa_Insertar.Name = "ButtonNuevaEmpresa_Insertar"
        Me.ButtonNuevaEmpresa_Insertar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonNuevaEmpresa_Insertar.TabIndex = 15
        Me.ButtonNuevaEmpresa_Insertar.Text = "Instertar"
        Me.ButtonNuevaEmpresa_Insertar.UseVisualStyleBackColor = True
        '
        'LabelNuevaEmpresa_TelefonoVal
        '
        Me.LabelNuevaEmpresa_TelefonoVal.AutoSize = True
        Me.LabelNuevaEmpresa_TelefonoVal.Location = New System.Drawing.Point(47, 229)
        Me.LabelNuevaEmpresa_TelefonoVal.Name = "LabelNuevaEmpresa_TelefonoVal"
        Me.LabelNuevaEmpresa_TelefonoVal.Size = New System.Drawing.Size(0, 13)
        Me.LabelNuevaEmpresa_TelefonoVal.TabIndex = 16
        '
        'FormNuevaEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(274, 516)
        Me.Controls.Add(Me.LabelNuevaEmpresa_TelefonoVal)
        Me.Controls.Add(Me.ButtonNuevaEmpresa_Insertar)
        Me.Controls.Add(Me.DateTimePickerNuevaEmpresa_InicioOperaciones)
        Me.Controls.Add(Me.LabelNuevaEmpresa_InicioOperaciones)
        Me.Controls.Add(Me.ButtonNuevaEmpresa_Guardar)
        Me.Controls.Add(Me.ButtonNuevaEmpresa_Cancelar)
        Me.Controls.Add(Me.TextBoxNuevaEmpresa_RFC)
        Me.Controls.Add(Me.LabelNuevaEmpresa_RFC)
        Me.Controls.Add(Me.TextBoxNuevaEmpresa_RegistroPatronal)
        Me.Controls.Add(Me.LabelNuevaEmpresa_RegistroPatronal)
        Me.Controls.Add(Me.TextBoxNuevaEmpresa_Contacto)
        Me.Controls.Add(Me.LabelNuevaEmpresa_Contacto)
        Me.Controls.Add(Me.LabelNuevaEmpresa_DomicilioFiscal)
        Me.Controls.Add(Me.TextBoxNuevaEmpresa_DomicilioFiscal)
        Me.Controls.Add(Me.LabelNuevaEmpresa_RazonSocial)
        Me.Controls.Add(Me.TextBoxNuevaEmpresa_RazonSocial)
        Me.Controls.Add(Me.LabelNuevaEmpresa_Instruccion)
        Me.Location = New System.Drawing.Point(400, 400)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormNuevaEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Nueva Empresa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelNuevaEmpresa_Instruccion As Label
    Friend WithEvents TextBoxNuevaEmpresa_RazonSocial As TextBox
    Friend WithEvents LabelNuevaEmpresa_RazonSocial As Label
    Friend WithEvents TextBoxNuevaEmpresa_DomicilioFiscal As TextBox
    Friend WithEvents LabelNuevaEmpresa_DomicilioFiscal As Label
    Friend WithEvents LabelNuevaEmpresa_Contacto As Label
    Friend WithEvents TextBoxNuevaEmpresa_Contacto As TextBox
    Friend WithEvents LabelNuevaEmpresa_RegistroPatronal As Label
    Friend WithEvents TextBoxNuevaEmpresa_RegistroPatronal As TextBox
    Friend WithEvents LabelNuevaEmpresa_RFC As Label
    Friend WithEvents TextBoxNuevaEmpresa_RFC As TextBox
    Friend WithEvents ButtonNuevaEmpresa_Cancelar As Button
    Friend WithEvents ButtonNuevaEmpresa_Guardar As Button
    Friend WithEvents LabelNuevaEmpresa_InicioOperaciones As Label
    Friend WithEvents DateTimePickerNuevaEmpresa_InicioOperaciones As DateTimePicker
    Friend WithEvents ButtonNuevaEmpresa_Insertar As Button
    Friend WithEvents LabelNuevaEmpresa_TelefonoVal As Label
End Class
