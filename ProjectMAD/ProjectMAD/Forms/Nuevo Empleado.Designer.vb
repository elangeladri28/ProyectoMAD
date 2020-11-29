<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNuevoEmpleado
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
        Me.LabelNuevoEmpleado_Instruccion = New System.Windows.Forms.Label()
        Me.LabelNuevoEmpleado_Contraseña = New System.Windows.Forms.Label()
        Me.TextBoxNuevoEmpleado_Contraseña = New System.Windows.Forms.TextBox()
        Me.LabelNuevoEmpleado_Nombres = New System.Windows.Forms.Label()
        Me.TextBoxNuevoEmpleado_Nombres = New System.Windows.Forms.TextBox()
        Me.LabelNuevoEmpleado_Trabajo = New System.Windows.Forms.Label()
        Me.LabelNuevoEmpleado_Depto = New System.Windows.Forms.Label()
        Me.TextBoxNuevoEmpleado_ApPaterno = New System.Windows.Forms.TextBox()
        Me.LabelNuevoEmpleado_ApPaterno = New System.Windows.Forms.Label()
        Me.TextBoxNuevoEmpleado_ApMaterno = New System.Windows.Forms.TextBox()
        Me.LabelNuevoEmpleado_ApMaterno = New System.Windows.Forms.Label()
        Me.LabelNuevoEmpleado_Puesto = New System.Windows.Forms.Label()
        Me.LabelNuevoEmpleado_Salarial = New System.Windows.Forms.Label()
        Me.TextBoxNuevoEmpleado_Salarial = New System.Windows.Forms.TextBox()
        Me.LabelNuevoEmpleado_CURP = New System.Windows.Forms.Label()
        Me.TextBoxNuevoEmpleado_CURP = New System.Windows.Forms.TextBox()
        Me.LabelNuevoEmpleado_NSS = New System.Windows.Forms.Label()
        Me.TextBoxNuevoEmpleado_NSS = New System.Windows.Forms.TextBox()
        Me.LabelNuevoEmpleado_RFC = New System.Windows.Forms.Label()
        Me.TextBoxNuevoEmpleado_RFC = New System.Windows.Forms.TextBox()
        Me.LabelNuevoEmpleado_Domicilio = New System.Windows.Forms.Label()
        Me.TextBoxNuevoEmpleado_Domicilio = New System.Windows.Forms.TextBox()
        Me.LabelNuevoEmpleado_Banco = New System.Windows.Forms.Label()
        Me.TextBoxNuevoEmpleado_Banco = New System.Windows.Forms.TextBox()
        Me.LabelNuevoEmpleado_NumCuenta = New System.Windows.Forms.Label()
        Me.TextBoxNuevoEmpleado_NumCuenta = New System.Windows.Forms.TextBox()
        Me.LabelNuevoEmpleado_Email = New System.Windows.Forms.Label()
        Me.TextBoxNuevoEmpleado_Email = New System.Windows.Forms.TextBox()
        Me.LabelNuevoEmpleado_Telefono = New System.Windows.Forms.Label()
        Me.TextBoxNuevoEmpleado_Telefono = New System.Windows.Forms.TextBox()
        Me.LabelNuevoEmpleado_FechaNac = New System.Windows.Forms.Label()
        Me.ButtonNuevoEmpleado_Cancelar = New System.Windows.Forms.Button()
        Me.ButtonNuevoEmpleado_Guardar = New System.Windows.Forms.Button()
        Me.DateTimePickerNuevoEmpleado_FechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxNuevoEmpleado_Depto = New System.Windows.Forms.ComboBox()
        Me.ComboBoxNuevoEmpleado_Puesto = New System.Windows.Forms.ComboBox()
        Me.ComboBoxNuevoEmpleado_Trabajo = New System.Windows.Forms.ComboBox()
        Me.DGVDinerito = New System.Windows.Forms.DataGridView()
        CType(Me.DGVDinerito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelNuevoEmpleado_Instruccion
        '
        Me.LabelNuevoEmpleado_Instruccion.AutoSize = True
        Me.LabelNuevoEmpleado_Instruccion.Location = New System.Drawing.Point(99, 9)
        Me.LabelNuevoEmpleado_Instruccion.Name = "LabelNuevoEmpleado_Instruccion"
        Me.LabelNuevoEmpleado_Instruccion.Size = New System.Drawing.Size(594, 17)
        Me.LabelNuevoEmpleado_Instruccion.TabIndex = 0
        Me.LabelNuevoEmpleado_Instruccion.Text = "LLENAR LOS SIGUIENTES CAMPOS PARA AGREGAR EL NUEVO EMPLEADO AL SISTEMA"
        '
        'LabelNuevoEmpleado_Contraseña
        '
        Me.LabelNuevoEmpleado_Contraseña.AutoSize = True
        Me.LabelNuevoEmpleado_Contraseña.Location = New System.Drawing.Point(24, 42)
        Me.LabelNuevoEmpleado_Contraseña.Name = "LabelNuevoEmpleado_Contraseña"
        Me.LabelNuevoEmpleado_Contraseña.Size = New System.Drawing.Size(81, 17)
        Me.LabelNuevoEmpleado_Contraseña.TabIndex = 3
        Me.LabelNuevoEmpleado_Contraseña.Text = "Contraseña"
        '
        'TextBoxNuevoEmpleado_Contraseña
        '
        Me.TextBoxNuevoEmpleado_Contraseña.Location = New System.Drawing.Point(27, 62)
        Me.TextBoxNuevoEmpleado_Contraseña.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxNuevoEmpleado_Contraseña.Name = "TextBoxNuevoEmpleado_Contraseña"
        Me.TextBoxNuevoEmpleado_Contraseña.Size = New System.Drawing.Size(232, 22)
        Me.TextBoxNuevoEmpleado_Contraseña.TabIndex = 4
        '
        'LabelNuevoEmpleado_Nombres
        '
        Me.LabelNuevoEmpleado_Nombres.AutoSize = True
        Me.LabelNuevoEmpleado_Nombres.Location = New System.Drawing.Point(24, 91)
        Me.LabelNuevoEmpleado_Nombres.Name = "LabelNuevoEmpleado_Nombres"
        Me.LabelNuevoEmpleado_Nombres.Size = New System.Drawing.Size(75, 17)
        Me.LabelNuevoEmpleado_Nombres.TabIndex = 5
        Me.LabelNuevoEmpleado_Nombres.Text = "Nombre(s)"
        '
        'TextBoxNuevoEmpleado_Nombres
        '
        Me.TextBoxNuevoEmpleado_Nombres.Location = New System.Drawing.Point(27, 111)
        Me.TextBoxNuevoEmpleado_Nombres.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxNuevoEmpleado_Nombres.Name = "TextBoxNuevoEmpleado_Nombres"
        Me.TextBoxNuevoEmpleado_Nombres.Size = New System.Drawing.Size(232, 22)
        Me.TextBoxNuevoEmpleado_Nombres.TabIndex = 6
        '
        'LabelNuevoEmpleado_Trabajo
        '
        Me.LabelNuevoEmpleado_Trabajo.AutoSize = True
        Me.LabelNuevoEmpleado_Trabajo.Location = New System.Drawing.Point(24, 238)
        Me.LabelNuevoEmpleado_Trabajo.Name = "LabelNuevoEmpleado_Trabajo"
        Me.LabelNuevoEmpleado_Trabajo.Size = New System.Drawing.Size(132, 17)
        Me.LabelNuevoEmpleado_Trabajo.TabIndex = 11
        Me.LabelNuevoEmpleado_Trabajo.Text = "Empresa de trabajo"
        '
        'LabelNuevoEmpleado_Depto
        '
        Me.LabelNuevoEmpleado_Depto.AutoSize = True
        Me.LabelNuevoEmpleado_Depto.Location = New System.Drawing.Point(24, 287)
        Me.LabelNuevoEmpleado_Depto.Name = "LabelNuevoEmpleado_Depto"
        Me.LabelNuevoEmpleado_Depto.Size = New System.Drawing.Size(98, 17)
        Me.LabelNuevoEmpleado_Depto.TabIndex = 13
        Me.LabelNuevoEmpleado_Depto.Text = "Departamento"
        '
        'TextBoxNuevoEmpleado_ApPaterno
        '
        Me.TextBoxNuevoEmpleado_ApPaterno.Location = New System.Drawing.Point(27, 160)
        Me.TextBoxNuevoEmpleado_ApPaterno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxNuevoEmpleado_ApPaterno.Name = "TextBoxNuevoEmpleado_ApPaterno"
        Me.TextBoxNuevoEmpleado_ApPaterno.Size = New System.Drawing.Size(232, 22)
        Me.TextBoxNuevoEmpleado_ApPaterno.TabIndex = 8
        '
        'LabelNuevoEmpleado_ApPaterno
        '
        Me.LabelNuevoEmpleado_ApPaterno.AutoSize = True
        Me.LabelNuevoEmpleado_ApPaterno.Location = New System.Drawing.Point(24, 140)
        Me.LabelNuevoEmpleado_ApPaterno.Name = "LabelNuevoEmpleado_ApPaterno"
        Me.LabelNuevoEmpleado_ApPaterno.Size = New System.Drawing.Size(112, 17)
        Me.LabelNuevoEmpleado_ApPaterno.TabIndex = 7
        Me.LabelNuevoEmpleado_ApPaterno.Text = "Apellido Paterno"
        '
        'TextBoxNuevoEmpleado_ApMaterno
        '
        Me.TextBoxNuevoEmpleado_ApMaterno.Location = New System.Drawing.Point(27, 209)
        Me.TextBoxNuevoEmpleado_ApMaterno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxNuevoEmpleado_ApMaterno.Name = "TextBoxNuevoEmpleado_ApMaterno"
        Me.TextBoxNuevoEmpleado_ApMaterno.Size = New System.Drawing.Size(232, 22)
        Me.TextBoxNuevoEmpleado_ApMaterno.TabIndex = 10
        '
        'LabelNuevoEmpleado_ApMaterno
        '
        Me.LabelNuevoEmpleado_ApMaterno.AutoSize = True
        Me.LabelNuevoEmpleado_ApMaterno.Location = New System.Drawing.Point(24, 188)
        Me.LabelNuevoEmpleado_ApMaterno.Name = "LabelNuevoEmpleado_ApMaterno"
        Me.LabelNuevoEmpleado_ApMaterno.Size = New System.Drawing.Size(114, 17)
        Me.LabelNuevoEmpleado_ApMaterno.TabIndex = 9
        Me.LabelNuevoEmpleado_ApMaterno.Text = "Apellido Materno"
        '
        'LabelNuevoEmpleado_Puesto
        '
        Me.LabelNuevoEmpleado_Puesto.AutoSize = True
        Me.LabelNuevoEmpleado_Puesto.Location = New System.Drawing.Point(24, 337)
        Me.LabelNuevoEmpleado_Puesto.Name = "LabelNuevoEmpleado_Puesto"
        Me.LabelNuevoEmpleado_Puesto.Size = New System.Drawing.Size(52, 17)
        Me.LabelNuevoEmpleado_Puesto.TabIndex = 15
        Me.LabelNuevoEmpleado_Puesto.Text = "Puesto"
        '
        'LabelNuevoEmpleado_Salarial
        '
        Me.LabelNuevoEmpleado_Salarial.AutoSize = True
        Me.LabelNuevoEmpleado_Salarial.Location = New System.Drawing.Point(24, 387)
        Me.LabelNuevoEmpleado_Salarial.Name = "LabelNuevoEmpleado_Salarial"
        Me.LabelNuevoEmpleado_Salarial.Size = New System.Drawing.Size(90, 17)
        Me.LabelNuevoEmpleado_Salarial.TabIndex = 17
        Me.LabelNuevoEmpleado_Salarial.Text = "Nivel Salarial"
        '
        'TextBoxNuevoEmpleado_Salarial
        '
        Me.TextBoxNuevoEmpleado_Salarial.Location = New System.Drawing.Point(27, 408)
        Me.TextBoxNuevoEmpleado_Salarial.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxNuevoEmpleado_Salarial.Name = "TextBoxNuevoEmpleado_Salarial"
        Me.TextBoxNuevoEmpleado_Salarial.ReadOnly = True
        Me.TextBoxNuevoEmpleado_Salarial.Size = New System.Drawing.Size(232, 22)
        Me.TextBoxNuevoEmpleado_Salarial.TabIndex = 18
        '
        'LabelNuevoEmpleado_CURP
        '
        Me.LabelNuevoEmpleado_CURP.AutoSize = True
        Me.LabelNuevoEmpleado_CURP.Location = New System.Drawing.Point(417, 43)
        Me.LabelNuevoEmpleado_CURP.Name = "LabelNuevoEmpleado_CURP"
        Me.LabelNuevoEmpleado_CURP.Size = New System.Drawing.Size(46, 17)
        Me.LabelNuevoEmpleado_CURP.TabIndex = 19
        Me.LabelNuevoEmpleado_CURP.Text = "CURP"
        '
        'TextBoxNuevoEmpleado_CURP
        '
        Me.TextBoxNuevoEmpleado_CURP.Location = New System.Drawing.Point(420, 63)
        Me.TextBoxNuevoEmpleado_CURP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxNuevoEmpleado_CURP.Name = "TextBoxNuevoEmpleado_CURP"
        Me.TextBoxNuevoEmpleado_CURP.Size = New System.Drawing.Size(232, 22)
        Me.TextBoxNuevoEmpleado_CURP.TabIndex = 20
        '
        'LabelNuevoEmpleado_NSS
        '
        Me.LabelNuevoEmpleado_NSS.AutoSize = True
        Me.LabelNuevoEmpleado_NSS.Location = New System.Drawing.Point(417, 88)
        Me.LabelNuevoEmpleado_NSS.Name = "LabelNuevoEmpleado_NSS"
        Me.LabelNuevoEmpleado_NSS.Size = New System.Drawing.Size(212, 17)
        Me.LabelNuevoEmpleado_NSS.TabIndex = 21
        Me.LabelNuevoEmpleado_NSS.Text = "Numero de Seguro Social (NSS)"
        '
        'TextBoxNuevoEmpleado_NSS
        '
        Me.TextBoxNuevoEmpleado_NSS.Location = New System.Drawing.Point(420, 107)
        Me.TextBoxNuevoEmpleado_NSS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxNuevoEmpleado_NSS.Name = "TextBoxNuevoEmpleado_NSS"
        Me.TextBoxNuevoEmpleado_NSS.Size = New System.Drawing.Size(232, 22)
        Me.TextBoxNuevoEmpleado_NSS.TabIndex = 22
        '
        'LabelNuevoEmpleado_RFC
        '
        Me.LabelNuevoEmpleado_RFC.AutoSize = True
        Me.LabelNuevoEmpleado_RFC.Location = New System.Drawing.Point(420, 137)
        Me.LabelNuevoEmpleado_RFC.Name = "LabelNuevoEmpleado_RFC"
        Me.LabelNuevoEmpleado_RFC.Size = New System.Drawing.Size(273, 17)
        Me.LabelNuevoEmpleado_RFC.TabIndex = 23
        Me.LabelNuevoEmpleado_RFC.Text = "Registro Federal de Contribuyentes (RFC)"
        '
        'TextBoxNuevoEmpleado_RFC
        '
        Me.TextBoxNuevoEmpleado_RFC.Location = New System.Drawing.Point(420, 155)
        Me.TextBoxNuevoEmpleado_RFC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxNuevoEmpleado_RFC.Name = "TextBoxNuevoEmpleado_RFC"
        Me.TextBoxNuevoEmpleado_RFC.Size = New System.Drawing.Size(232, 22)
        Me.TextBoxNuevoEmpleado_RFC.TabIndex = 24
        '
        'LabelNuevoEmpleado_Domicilio
        '
        Me.LabelNuevoEmpleado_Domicilio.AutoSize = True
        Me.LabelNuevoEmpleado_Domicilio.Location = New System.Drawing.Point(420, 195)
        Me.LabelNuevoEmpleado_Domicilio.Name = "LabelNuevoEmpleado_Domicilio"
        Me.LabelNuevoEmpleado_Domicilio.Size = New System.Drawing.Size(127, 17)
        Me.LabelNuevoEmpleado_Domicilio.TabIndex = 25
        Me.LabelNuevoEmpleado_Domicilio.Text = "Domicilio Completo"
        '
        'TextBoxNuevoEmpleado_Domicilio
        '
        Me.TextBoxNuevoEmpleado_Domicilio.Location = New System.Drawing.Point(420, 215)
        Me.TextBoxNuevoEmpleado_Domicilio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxNuevoEmpleado_Domicilio.Multiline = True
        Me.TextBoxNuevoEmpleado_Domicilio.Name = "TextBoxNuevoEmpleado_Domicilio"
        Me.TextBoxNuevoEmpleado_Domicilio.Size = New System.Drawing.Size(232, 62)
        Me.TextBoxNuevoEmpleado_Domicilio.TabIndex = 26
        '
        'LabelNuevoEmpleado_Banco
        '
        Me.LabelNuevoEmpleado_Banco.AutoSize = True
        Me.LabelNuevoEmpleado_Banco.Location = New System.Drawing.Point(420, 283)
        Me.LabelNuevoEmpleado_Banco.Name = "LabelNuevoEmpleado_Banco"
        Me.LabelNuevoEmpleado_Banco.Size = New System.Drawing.Size(48, 17)
        Me.LabelNuevoEmpleado_Banco.TabIndex = 27
        Me.LabelNuevoEmpleado_Banco.Text = "Banco"
        '
        'TextBoxNuevoEmpleado_Banco
        '
        Me.TextBoxNuevoEmpleado_Banco.Location = New System.Drawing.Point(420, 304)
        Me.TextBoxNuevoEmpleado_Banco.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxNuevoEmpleado_Banco.Name = "TextBoxNuevoEmpleado_Banco"
        Me.TextBoxNuevoEmpleado_Banco.Size = New System.Drawing.Size(232, 22)
        Me.TextBoxNuevoEmpleado_Banco.TabIndex = 28
        '
        'LabelNuevoEmpleado_NumCuenta
        '
        Me.LabelNuevoEmpleado_NumCuenta.AutoSize = True
        Me.LabelNuevoEmpleado_NumCuenta.Location = New System.Drawing.Point(420, 334)
        Me.LabelNuevoEmpleado_NumCuenta.Name = "LabelNuevoEmpleado_NumCuenta"
        Me.LabelNuevoEmpleado_NumCuenta.Size = New System.Drawing.Size(127, 17)
        Me.LabelNuevoEmpleado_NumCuenta.TabIndex = 29
        Me.LabelNuevoEmpleado_NumCuenta.Text = "Numero de Cuenta"
        '
        'TextBoxNuevoEmpleado_NumCuenta
        '
        Me.TextBoxNuevoEmpleado_NumCuenta.Location = New System.Drawing.Point(420, 354)
        Me.TextBoxNuevoEmpleado_NumCuenta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxNuevoEmpleado_NumCuenta.Name = "TextBoxNuevoEmpleado_NumCuenta"
        Me.TextBoxNuevoEmpleado_NumCuenta.Size = New System.Drawing.Size(232, 22)
        Me.TextBoxNuevoEmpleado_NumCuenta.TabIndex = 30
        '
        'LabelNuevoEmpleado_Email
        '
        Me.LabelNuevoEmpleado_Email.AutoSize = True
        Me.LabelNuevoEmpleado_Email.Location = New System.Drawing.Point(420, 382)
        Me.LabelNuevoEmpleado_Email.Name = "LabelNuevoEmpleado_Email"
        Me.LabelNuevoEmpleado_Email.Size = New System.Drawing.Size(42, 17)
        Me.LabelNuevoEmpleado_Email.TabIndex = 31
        Me.LabelNuevoEmpleado_Email.Text = "Email"
        '
        'TextBoxNuevoEmpleado_Email
        '
        Me.TextBoxNuevoEmpleado_Email.Location = New System.Drawing.Point(420, 400)
        Me.TextBoxNuevoEmpleado_Email.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxNuevoEmpleado_Email.Name = "TextBoxNuevoEmpleado_Email"
        Me.TextBoxNuevoEmpleado_Email.Size = New System.Drawing.Size(232, 22)
        Me.TextBoxNuevoEmpleado_Email.TabIndex = 32
        '
        'LabelNuevoEmpleado_Telefono
        '
        Me.LabelNuevoEmpleado_Telefono.AutoSize = True
        Me.LabelNuevoEmpleado_Telefono.Location = New System.Drawing.Point(420, 431)
        Me.LabelNuevoEmpleado_Telefono.Name = "LabelNuevoEmpleado_Telefono"
        Me.LabelNuevoEmpleado_Telefono.Size = New System.Drawing.Size(64, 17)
        Me.LabelNuevoEmpleado_Telefono.TabIndex = 33
        Me.LabelNuevoEmpleado_Telefono.Text = "Telefono"
        '
        'TextBoxNuevoEmpleado_Telefono
        '
        Me.TextBoxNuevoEmpleado_Telefono.Location = New System.Drawing.Point(420, 450)
        Me.TextBoxNuevoEmpleado_Telefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxNuevoEmpleado_Telefono.Name = "TextBoxNuevoEmpleado_Telefono"
        Me.TextBoxNuevoEmpleado_Telefono.Size = New System.Drawing.Size(232, 22)
        Me.TextBoxNuevoEmpleado_Telefono.TabIndex = 34
        '
        'LabelNuevoEmpleado_FechaNac
        '
        Me.LabelNuevoEmpleado_FechaNac.AutoSize = True
        Me.LabelNuevoEmpleado_FechaNac.Location = New System.Drawing.Point(28, 436)
        Me.LabelNuevoEmpleado_FechaNac.Name = "LabelNuevoEmpleado_FechaNac"
        Me.LabelNuevoEmpleado_FechaNac.Size = New System.Drawing.Size(141, 17)
        Me.LabelNuevoEmpleado_FechaNac.TabIndex = 36
        Me.LabelNuevoEmpleado_FechaNac.Text = "Fecha de Nacimiento"
        '
        'ButtonNuevoEmpleado_Cancelar
        '
        Me.ButtonNuevoEmpleado_Cancelar.Location = New System.Drawing.Point(511, 527)
        Me.ButtonNuevoEmpleado_Cancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonNuevoEmpleado_Cancelar.Name = "ButtonNuevoEmpleado_Cancelar"
        Me.ButtonNuevoEmpleado_Cancelar.Size = New System.Drawing.Size(101, 30)
        Me.ButtonNuevoEmpleado_Cancelar.TabIndex = 37
        Me.ButtonNuevoEmpleado_Cancelar.Text = "Cancelar"
        Me.ButtonNuevoEmpleado_Cancelar.UseVisualStyleBackColor = True
        '
        'ButtonNuevoEmpleado_Guardar
        '
        Me.ButtonNuevoEmpleado_Guardar.Location = New System.Drawing.Point(640, 527)
        Me.ButtonNuevoEmpleado_Guardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonNuevoEmpleado_Guardar.Name = "ButtonNuevoEmpleado_Guardar"
        Me.ButtonNuevoEmpleado_Guardar.Size = New System.Drawing.Size(101, 30)
        Me.ButtonNuevoEmpleado_Guardar.TabIndex = 38
        Me.ButtonNuevoEmpleado_Guardar.Text = "Guardar"
        Me.ButtonNuevoEmpleado_Guardar.UseVisualStyleBackColor = True
        '
        'DateTimePickerNuevoEmpleado_FechaNacimiento
        '
        Me.DateTimePickerNuevoEmpleado_FechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerNuevoEmpleado_FechaNacimiento.Location = New System.Drawing.Point(28, 454)
        Me.DateTimePickerNuevoEmpleado_FechaNacimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePickerNuevoEmpleado_FechaNacimiento.Name = "DateTimePickerNuevoEmpleado_FechaNacimiento"
        Me.DateTimePickerNuevoEmpleado_FechaNacimiento.Size = New System.Drawing.Size(231, 22)
        Me.DateTimePickerNuevoEmpleado_FechaNacimiento.TabIndex = 35
        '
        'ComboBoxNuevoEmpleado_Depto
        '
        Me.ComboBoxNuevoEmpleado_Depto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxNuevoEmpleado_Depto.FormattingEnabled = True
        Me.ComboBoxNuevoEmpleado_Depto.Location = New System.Drawing.Point(27, 307)
        Me.ComboBoxNuevoEmpleado_Depto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxNuevoEmpleado_Depto.Name = "ComboBoxNuevoEmpleado_Depto"
        Me.ComboBoxNuevoEmpleado_Depto.Size = New System.Drawing.Size(232, 24)
        Me.ComboBoxNuevoEmpleado_Depto.Sorted = True
        Me.ComboBoxNuevoEmpleado_Depto.TabIndex = 14
        '
        'ComboBoxNuevoEmpleado_Puesto
        '
        Me.ComboBoxNuevoEmpleado_Puesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxNuevoEmpleado_Puesto.FormattingEnabled = True
        Me.ComboBoxNuevoEmpleado_Puesto.Location = New System.Drawing.Point(27, 357)
        Me.ComboBoxNuevoEmpleado_Puesto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxNuevoEmpleado_Puesto.Name = "ComboBoxNuevoEmpleado_Puesto"
        Me.ComboBoxNuevoEmpleado_Puesto.Size = New System.Drawing.Size(232, 24)
        Me.ComboBoxNuevoEmpleado_Puesto.Sorted = True
        Me.ComboBoxNuevoEmpleado_Puesto.TabIndex = 16
        '
        'ComboBoxNuevoEmpleado_Trabajo
        '
        Me.ComboBoxNuevoEmpleado_Trabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxNuevoEmpleado_Trabajo.FormattingEnabled = True
        Me.ComboBoxNuevoEmpleado_Trabajo.Location = New System.Drawing.Point(27, 257)
        Me.ComboBoxNuevoEmpleado_Trabajo.Name = "ComboBoxNuevoEmpleado_Trabajo"
        Me.ComboBoxNuevoEmpleado_Trabajo.Size = New System.Drawing.Size(232, 24)
        Me.ComboBoxNuevoEmpleado_Trabajo.TabIndex = 12
        '
        'DGVDinerito
        '
        Me.DGVDinerito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDinerito.Location = New System.Drawing.Point(158, 527)
        Me.DGVDinerito.Name = "DGVDinerito"
        Me.DGVDinerito.RowHeadersWidth = 51
        Me.DGVDinerito.RowTemplate.Height = 24
        Me.DGVDinerito.Size = New System.Drawing.Size(55, 49)
        Me.DGVDinerito.TabIndex = 39
        Me.DGVDinerito.Visible = False
        '
        'FormNuevoEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(783, 588)
        Me.Controls.Add(Me.DGVDinerito)
        Me.Controls.Add(Me.ComboBoxNuevoEmpleado_Trabajo)
        Me.Controls.Add(Me.ComboBoxNuevoEmpleado_Puesto)
        Me.Controls.Add(Me.ComboBoxNuevoEmpleado_Depto)
        Me.Controls.Add(Me.DateTimePickerNuevoEmpleado_FechaNacimiento)
        Me.Controls.Add(Me.ButtonNuevoEmpleado_Guardar)
        Me.Controls.Add(Me.ButtonNuevoEmpleado_Cancelar)
        Me.Controls.Add(Me.LabelNuevoEmpleado_FechaNac)
        Me.Controls.Add(Me.TextBoxNuevoEmpleado_Telefono)
        Me.Controls.Add(Me.LabelNuevoEmpleado_Telefono)
        Me.Controls.Add(Me.TextBoxNuevoEmpleado_Email)
        Me.Controls.Add(Me.LabelNuevoEmpleado_Email)
        Me.Controls.Add(Me.TextBoxNuevoEmpleado_NumCuenta)
        Me.Controls.Add(Me.LabelNuevoEmpleado_NumCuenta)
        Me.Controls.Add(Me.TextBoxNuevoEmpleado_Banco)
        Me.Controls.Add(Me.LabelNuevoEmpleado_Banco)
        Me.Controls.Add(Me.TextBoxNuevoEmpleado_Domicilio)
        Me.Controls.Add(Me.LabelNuevoEmpleado_Domicilio)
        Me.Controls.Add(Me.TextBoxNuevoEmpleado_RFC)
        Me.Controls.Add(Me.LabelNuevoEmpleado_RFC)
        Me.Controls.Add(Me.TextBoxNuevoEmpleado_NSS)
        Me.Controls.Add(Me.LabelNuevoEmpleado_NSS)
        Me.Controls.Add(Me.TextBoxNuevoEmpleado_CURP)
        Me.Controls.Add(Me.LabelNuevoEmpleado_CURP)
        Me.Controls.Add(Me.TextBoxNuevoEmpleado_Salarial)
        Me.Controls.Add(Me.LabelNuevoEmpleado_Salarial)
        Me.Controls.Add(Me.LabelNuevoEmpleado_Puesto)
        Me.Controls.Add(Me.TextBoxNuevoEmpleado_ApMaterno)
        Me.Controls.Add(Me.LabelNuevoEmpleado_ApMaterno)
        Me.Controls.Add(Me.TextBoxNuevoEmpleado_ApPaterno)
        Me.Controls.Add(Me.LabelNuevoEmpleado_ApPaterno)
        Me.Controls.Add(Me.LabelNuevoEmpleado_Depto)
        Me.Controls.Add(Me.LabelNuevoEmpleado_Trabajo)
        Me.Controls.Add(Me.TextBoxNuevoEmpleado_Nombres)
        Me.Controls.Add(Me.LabelNuevoEmpleado_Nombres)
        Me.Controls.Add(Me.TextBoxNuevoEmpleado_Contraseña)
        Me.Controls.Add(Me.LabelNuevoEmpleado_Contraseña)
        Me.Controls.Add(Me.LabelNuevoEmpleado_Instruccion)
        Me.Location = New System.Drawing.Point(400, 400)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormNuevoEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Nuevo Empleado"
        CType(Me.DGVDinerito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelNuevoEmpleado_Instruccion As Label
    Friend WithEvents LabelNuevoEmpleado_Contraseña As Label
    Friend WithEvents TextBoxNuevoEmpleado_Contraseña As TextBox
    Friend WithEvents LabelNuevoEmpleado_Nombres As Label
    Friend WithEvents TextBoxNuevoEmpleado_Nombres As TextBox
    Friend WithEvents LabelNuevoEmpleado_Trabajo As Label
    Friend WithEvents LabelNuevoEmpleado_Depto As Label
    Friend WithEvents TextBoxNuevoEmpleado_ApPaterno As TextBox
    Friend WithEvents LabelNuevoEmpleado_ApPaterno As Label
    Friend WithEvents TextBoxNuevoEmpleado_ApMaterno As TextBox
    Friend WithEvents LabelNuevoEmpleado_ApMaterno As Label
    Friend WithEvents LabelNuevoEmpleado_Puesto As Label
    Friend WithEvents LabelNuevoEmpleado_Salarial As Label
    Friend WithEvents TextBoxNuevoEmpleado_Salarial As TextBox
    Friend WithEvents LabelNuevoEmpleado_CURP As Label
    Friend WithEvents TextBoxNuevoEmpleado_CURP As TextBox
    Friend WithEvents LabelNuevoEmpleado_NSS As Label
    Friend WithEvents TextBoxNuevoEmpleado_NSS As TextBox
    Friend WithEvents LabelNuevoEmpleado_RFC As Label
    Friend WithEvents TextBoxNuevoEmpleado_RFC As TextBox
    Friend WithEvents LabelNuevoEmpleado_Domicilio As Label
    Friend WithEvents TextBoxNuevoEmpleado_Domicilio As TextBox
    Friend WithEvents LabelNuevoEmpleado_Banco As Label
    Friend WithEvents TextBoxNuevoEmpleado_Banco As TextBox
    Friend WithEvents LabelNuevoEmpleado_NumCuenta As Label
    Friend WithEvents TextBoxNuevoEmpleado_NumCuenta As TextBox
    Friend WithEvents LabelNuevoEmpleado_Email As Label
    Friend WithEvents TextBoxNuevoEmpleado_Email As TextBox
    Friend WithEvents LabelNuevoEmpleado_Telefono As Label
    Friend WithEvents TextBoxNuevoEmpleado_Telefono As TextBox
    Friend WithEvents LabelNuevoEmpleado_FechaNac As Label
    Friend WithEvents ButtonNuevoEmpleado_Cancelar As Button
    Friend WithEvents ButtonNuevoEmpleado_Guardar As Button
    Friend WithEvents DateTimePickerNuevoEmpleado_FechaNacimiento As DateTimePicker
    Friend WithEvents ComboBoxNuevoEmpleado_Depto As ComboBox
    Friend WithEvents ComboBoxNuevoEmpleado_Puesto As ComboBox
    Friend WithEvents ComboBoxNuevoEmpleado_Trabajo As ComboBox
    Friend WithEvents DGVDinerito As DataGridView
End Class
