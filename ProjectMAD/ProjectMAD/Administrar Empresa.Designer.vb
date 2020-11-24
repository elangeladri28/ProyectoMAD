<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdministrarEmpresa
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdministrarEmpresa))
        Me.DateTimePickerAdministrarEmpresa_InicioOperaciones = New System.Windows.Forms.DateTimePicker()
        Me.LabelNuevaEmpresa_InicioOperaciones = New System.Windows.Forms.Label()
        Me.ButtonAdministrarEmpresa_Guardar = New System.Windows.Forms.Button()
        Me.ButtonAdministrarEmpresa_Cancelar = New System.Windows.Forms.Button()
        Me.TextBoxAdministrarEmpresa_RFC = New System.Windows.Forms.TextBox()
        Me.LabelAdministrarEmpresa_RFC = New System.Windows.Forms.Label()
        Me.TextBoxAdministrarEmpresa_RegistroPatronal = New System.Windows.Forms.TextBox()
        Me.LabelAdministrarEmpresa_RegistroPatronal = New System.Windows.Forms.Label()
        Me.TextBoxAdministrarEmpresa_Contacto = New System.Windows.Forms.TextBox()
        Me.LabelAdministrarEmpresa_Contacto = New System.Windows.Forms.Label()
        Me.LabelAdministrarEmpresa_DomicilioFiscal = New System.Windows.Forms.Label()
        Me.TextBoxAdministrarEmpresa_DomicilioFiscal = New System.Windows.Forms.TextBox()
        Me.LabelAdministrarEmpresa_RazonSocial = New System.Windows.Forms.Label()
        Me.TextBoxAdministrarEmpresa_RazonSocial = New System.Windows.Forms.TextBox()
        Me.LabelAdministrarEmpresa_Instruccion = New System.Windows.Forms.Label()
        Me.MAD_PIADataSet = New ProjectMAD.MAD_PIADataSet()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresasTableAdapter = New ProjectMAD.MAD_PIADataSetTableAdapters.EmpresasTableAdapter()
        Me.TableAdapterManager = New ProjectMAD.MAD_PIADataSetTableAdapters.TableAdapterManager()
        Me.EmpresasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EmpresasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DGVAdministrarEmpresas = New System.Windows.Forms.DataGridView()
        Me.ButtonAdministrarEmpresas_Borrar = New System.Windows.Forms.Button()
        Me.ButtonAdministrarEmpresa_Modificar = New System.Windows.Forms.Button()
        Me.ButtonAdministrarEmpresa_Insertar = New System.Windows.Forms.Button()
        CType(Me.MAD_PIADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpresasBindingNavigator.SuspendLayout()
        CType(Me.DGVAdministrarEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePickerAdministrarEmpresa_InicioOperaciones
        '
        Me.DateTimePickerAdministrarEmpresa_InicioOperaciones.CustomFormat = ""
        Me.DateTimePickerAdministrarEmpresa_InicioOperaciones.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerAdministrarEmpresa_InicioOperaciones.Location = New System.Drawing.Point(22, 337)
        Me.DateTimePickerAdministrarEmpresa_InicioOperaciones.Name = "DateTimePickerAdministrarEmpresa_InicioOperaciones"
        Me.DateTimePickerAdministrarEmpresa_InicioOperaciones.Size = New System.Drawing.Size(179, 20)
        Me.DateTimePickerAdministrarEmpresa_InicioOperaciones.TabIndex = 26
        Me.DateTimePickerAdministrarEmpresa_InicioOperaciones.Value = New Date(2020, 11, 17, 21, 23, 0, 0)
        '
        'LabelNuevaEmpresa_InicioOperaciones
        '
        Me.LabelNuevaEmpresa_InicioOperaciones.AutoSize = True
        Me.LabelNuevaEmpresa_InicioOperaciones.Location = New System.Drawing.Point(24, 320)
        Me.LabelNuevaEmpresa_InicioOperaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNuevaEmpresa_InicioOperaciones.Name = "LabelNuevaEmpresa_InicioOperaciones"
        Me.LabelNuevaEmpresa_InicioOperaciones.Size = New System.Drawing.Size(158, 13)
        Me.LabelNuevaEmpresa_InicioOperaciones.TabIndex = 29
        Me.LabelNuevaEmpresa_InicioOperaciones.Text = "Fecha de Inicio de Operaciones"
        '
        'ButtonAdministrarEmpresa_Guardar
        '
        Me.ButtonAdministrarEmpresa_Guardar.Location = New System.Drawing.Point(814, 348)
        Me.ButtonAdministrarEmpresa_Guardar.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonAdministrarEmpresa_Guardar.Name = "ButtonAdministrarEmpresa_Guardar"
        Me.ButtonAdministrarEmpresa_Guardar.Size = New System.Drawing.Size(74, 26)
        Me.ButtonAdministrarEmpresa_Guardar.TabIndex = 28
        Me.ButtonAdministrarEmpresa_Guardar.Text = "Guardar"
        Me.ButtonAdministrarEmpresa_Guardar.UseVisualStyleBackColor = True
        '
        'ButtonAdministrarEmpresa_Cancelar
        '
        Me.ButtonAdministrarEmpresa_Cancelar.Location = New System.Drawing.Point(417, 348)
        Me.ButtonAdministrarEmpresa_Cancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonAdministrarEmpresa_Cancelar.Name = "ButtonAdministrarEmpresa_Cancelar"
        Me.ButtonAdministrarEmpresa_Cancelar.Size = New System.Drawing.Size(74, 26)
        Me.ButtonAdministrarEmpresa_Cancelar.TabIndex = 27
        Me.ButtonAdministrarEmpresa_Cancelar.Text = "Cancelar"
        Me.ButtonAdministrarEmpresa_Cancelar.UseVisualStyleBackColor = True
        '
        'TextBoxAdministrarEmpresa_RFC
        '
        Me.TextBoxAdministrarEmpresa_RFC.Location = New System.Drawing.Point(22, 296)
        Me.TextBoxAdministrarEmpresa_RFC.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxAdministrarEmpresa_RFC.Name = "TextBoxAdministrarEmpresa_RFC"
        Me.TextBoxAdministrarEmpresa_RFC.Size = New System.Drawing.Size(179, 20)
        Me.TextBoxAdministrarEmpresa_RFC.TabIndex = 25
        '
        'LabelAdministrarEmpresa_RFC
        '
        Me.LabelAdministrarEmpresa_RFC.AutoSize = True
        Me.LabelAdministrarEmpresa_RFC.Location = New System.Drawing.Point(24, 280)
        Me.LabelAdministrarEmpresa_RFC.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAdministrarEmpresa_RFC.Name = "LabelAdministrarEmpresa_RFC"
        Me.LabelAdministrarEmpresa_RFC.Size = New System.Drawing.Size(28, 13)
        Me.LabelAdministrarEmpresa_RFC.TabIndex = 24
        Me.LabelAdministrarEmpresa_RFC.Text = "RFC"
        '
        'TextBoxAdministrarEmpresa_RegistroPatronal
        '
        Me.TextBoxAdministrarEmpresa_RegistroPatronal.Location = New System.Drawing.Point(24, 261)
        Me.TextBoxAdministrarEmpresa_RegistroPatronal.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxAdministrarEmpresa_RegistroPatronal.Name = "TextBoxAdministrarEmpresa_RegistroPatronal"
        Me.TextBoxAdministrarEmpresa_RegistroPatronal.Size = New System.Drawing.Size(177, 20)
        Me.TextBoxAdministrarEmpresa_RegistroPatronal.TabIndex = 23
        '
        'LabelAdministrarEmpresa_RegistroPatronal
        '
        Me.LabelAdministrarEmpresa_RegistroPatronal.AutoSize = True
        Me.LabelAdministrarEmpresa_RegistroPatronal.Location = New System.Drawing.Point(24, 242)
        Me.LabelAdministrarEmpresa_RegistroPatronal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAdministrarEmpresa_RegistroPatronal.Name = "LabelAdministrarEmpresa_RegistroPatronal"
        Me.LabelAdministrarEmpresa_RegistroPatronal.Size = New System.Drawing.Size(88, 13)
        Me.LabelAdministrarEmpresa_RegistroPatronal.TabIndex = 22
        Me.LabelAdministrarEmpresa_RegistroPatronal.Text = "Registro Patronal"
        '
        'TextBoxAdministrarEmpresa_Contacto
        '
        Me.TextBoxAdministrarEmpresa_Contacto.Location = New System.Drawing.Point(24, 216)
        Me.TextBoxAdministrarEmpresa_Contacto.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxAdministrarEmpresa_Contacto.Name = "TextBoxAdministrarEmpresa_Contacto"
        Me.TextBoxAdministrarEmpresa_Contacto.Size = New System.Drawing.Size(177, 20)
        Me.TextBoxAdministrarEmpresa_Contacto.TabIndex = 21
        '
        'LabelAdministrarEmpresa_Contacto
        '
        Me.LabelAdministrarEmpresa_Contacto.AutoSize = True
        Me.LabelAdministrarEmpresa_Contacto.Location = New System.Drawing.Point(24, 199)
        Me.LabelAdministrarEmpresa_Contacto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAdministrarEmpresa_Contacto.Name = "LabelAdministrarEmpresa_Contacto"
        Me.LabelAdministrarEmpresa_Contacto.Size = New System.Drawing.Size(101, 13)
        Me.LabelAdministrarEmpresa_Contacto.TabIndex = 20
        Me.LabelAdministrarEmpresa_Contacto.Text = "Contacto (Teléfono)"
        '
        'LabelAdministrarEmpresa_DomicilioFiscal
        '
        Me.LabelAdministrarEmpresa_DomicilioFiscal.AutoSize = True
        Me.LabelAdministrarEmpresa_DomicilioFiscal.Location = New System.Drawing.Point(24, 113)
        Me.LabelAdministrarEmpresa_DomicilioFiscal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAdministrarEmpresa_DomicilioFiscal.Name = "LabelAdministrarEmpresa_DomicilioFiscal"
        Me.LabelAdministrarEmpresa_DomicilioFiscal.Size = New System.Drawing.Size(79, 13)
        Me.LabelAdministrarEmpresa_DomicilioFiscal.TabIndex = 19
        Me.LabelAdministrarEmpresa_DomicilioFiscal.Text = "Domicilio Fiscal"
        '
        'TextBoxAdministrarEmpresa_DomicilioFiscal
        '
        Me.TextBoxAdministrarEmpresa_DomicilioFiscal.Location = New System.Drawing.Point(24, 131)
        Me.TextBoxAdministrarEmpresa_DomicilioFiscal.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxAdministrarEmpresa_DomicilioFiscal.Multiline = True
        Me.TextBoxAdministrarEmpresa_DomicilioFiscal.Name = "TextBoxAdministrarEmpresa_DomicilioFiscal"
        Me.TextBoxAdministrarEmpresa_DomicilioFiscal.Size = New System.Drawing.Size(177, 60)
        Me.TextBoxAdministrarEmpresa_DomicilioFiscal.TabIndex = 18
        '
        'LabelAdministrarEmpresa_RazonSocial
        '
        Me.LabelAdministrarEmpresa_RazonSocial.AutoSize = True
        Me.LabelAdministrarEmpresa_RazonSocial.Location = New System.Drawing.Point(24, 40)
        Me.LabelAdministrarEmpresa_RazonSocial.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAdministrarEmpresa_RazonSocial.Name = "LabelAdministrarEmpresa_RazonSocial"
        Me.LabelAdministrarEmpresa_RazonSocial.Size = New System.Drawing.Size(175, 13)
        Me.LabelAdministrarEmpresa_RazonSocial.TabIndex = 17
        Me.LabelAdministrarEmpresa_RazonSocial.Text = "Razon Social (Nombre de Empresa)"
        '
        'TextBoxAdministrarEmpresa_RazonSocial
        '
        Me.TextBoxAdministrarEmpresa_RazonSocial.Location = New System.Drawing.Point(24, 56)
        Me.TextBoxAdministrarEmpresa_RazonSocial.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxAdministrarEmpresa_RazonSocial.Multiline = True
        Me.TextBoxAdministrarEmpresa_RazonSocial.Name = "TextBoxAdministrarEmpresa_RazonSocial"
        Me.TextBoxAdministrarEmpresa_RazonSocial.Size = New System.Drawing.Size(177, 55)
        Me.TextBoxAdministrarEmpresa_RazonSocial.TabIndex = 16
        '
        'LabelAdministrarEmpresa_Instruccion
        '
        Me.LabelAdministrarEmpresa_Instruccion.AutoSize = True
        Me.LabelAdministrarEmpresa_Instruccion.Location = New System.Drawing.Point(238, 7)
        Me.LabelAdministrarEmpresa_Instruccion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAdministrarEmpresa_Instruccion.Name = "LabelAdministrarEmpresa_Instruccion"
        Me.LabelAdministrarEmpresa_Instruccion.Size = New System.Drawing.Size(449, 13)
        Me.LabelAdministrarEmpresa_Instruccion.TabIndex = 15
        Me.LabelAdministrarEmpresa_Instruccion.Text = "NO OLVIDE LLENAR LOS DATOS DE LA EMPRESA PARA SUS RESPECTIVOS CAMBIOS"
        Me.LabelAdministrarEmpresa_Instruccion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MAD_PIADataSet
        '
        Me.MAD_PIADataSet.DataSetName = "MAD_PIADataSet"
        Me.MAD_PIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataMember = "Empresas"
        Me.EmpresasBindingSource.DataSource = Me.MAD_PIADataSet
        '
        'EmpresasTableAdapter
        '
        Me.EmpresasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DeduccionesTableAdapter = Nothing
        Me.TableAdapterManager.DepartamentosTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.EmpresasTableAdapter = Me.EmpresasTableAdapter
        Me.TableAdapterManager.PercepcionesTableAdapter = Nothing
        Me.TableAdapterManager.PuestosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProjectMAD.MAD_PIADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmpresasBindingNavigator
        '
        Me.EmpresasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmpresasBindingNavigator.BindingSource = Me.EmpresasBindingSource
        Me.EmpresasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpresasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmpresasBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.EmpresasBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.EmpresasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmpresasBindingNavigatorSaveItem})
        Me.EmpresasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmpresasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpresasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpresasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpresasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpresasBindingNavigator.Name = "EmpresasBindingNavigator"
        Me.EmpresasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpresasBindingNavigator.Size = New System.Drawing.Size(918, 25)
        Me.EmpresasBindingNavigator.TabIndex = 30
        Me.EmpresasBindingNavigator.Text = "BindingNavigator1"
        Me.EmpresasBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'EmpresasBindingNavigatorSaveItem
        '
        Me.EmpresasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmpresasBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmpresasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmpresasBindingNavigatorSaveItem.Name = "EmpresasBindingNavigatorSaveItem"
        Me.EmpresasBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 22)
        Me.EmpresasBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DGVAdministrarEmpresas
        '
        Me.DGVAdministrarEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAdministrarEmpresas.Location = New System.Drawing.Point(240, 41)
        Me.DGVAdministrarEmpresas.MultiSelect = False
        Me.DGVAdministrarEmpresas.Name = "DGVAdministrarEmpresas"
        Me.DGVAdministrarEmpresas.ReadOnly = True
        Me.DGVAdministrarEmpresas.RowHeadersWidth = 51
        Me.DGVAdministrarEmpresas.Size = New System.Drawing.Size(648, 278)
        Me.DGVAdministrarEmpresas.TabIndex = 30
        '
        'ButtonAdministrarEmpresas_Borrar
        '
        Me.ButtonAdministrarEmpresas_Borrar.Location = New System.Drawing.Point(734, 348)
        Me.ButtonAdministrarEmpresas_Borrar.Name = "ButtonAdministrarEmpresas_Borrar"
        Me.ButtonAdministrarEmpresas_Borrar.Size = New System.Drawing.Size(75, 26)
        Me.ButtonAdministrarEmpresas_Borrar.TabIndex = 31
        Me.ButtonAdministrarEmpresas_Borrar.Text = "Borrar"
        Me.ButtonAdministrarEmpresas_Borrar.UseVisualStyleBackColor = True
        '
        'ButtonAdministrarEmpresa_Modificar
        '
        Me.ButtonAdministrarEmpresa_Modificar.Location = New System.Drawing.Point(496, 348)
        Me.ButtonAdministrarEmpresa_Modificar.Name = "ButtonAdministrarEmpresa_Modificar"
        Me.ButtonAdministrarEmpresa_Modificar.Size = New System.Drawing.Size(75, 26)
        Me.ButtonAdministrarEmpresa_Modificar.TabIndex = 32
        Me.ButtonAdministrarEmpresa_Modificar.Text = "Modificar"
        Me.ButtonAdministrarEmpresa_Modificar.UseVisualStyleBackColor = True
        '
        'ButtonAdministrarEmpresa_Insertar
        '
        Me.ButtonAdministrarEmpresa_Insertar.Location = New System.Drawing.Point(653, 348)
        Me.ButtonAdministrarEmpresa_Insertar.Name = "ButtonAdministrarEmpresa_Insertar"
        Me.ButtonAdministrarEmpresa_Insertar.Size = New System.Drawing.Size(75, 26)
        Me.ButtonAdministrarEmpresa_Insertar.TabIndex = 33
        Me.ButtonAdministrarEmpresa_Insertar.Text = "Insertar"
        Me.ButtonAdministrarEmpresa_Insertar.UseVisualStyleBackColor = True
        '
        'FormAdministrarEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(918, 439)
        Me.Controls.Add(Me.ButtonAdministrarEmpresa_Insertar)
        Me.Controls.Add(Me.ButtonAdministrarEmpresa_Modificar)
        Me.Controls.Add(Me.ButtonAdministrarEmpresas_Borrar)
        Me.Controls.Add(Me.DGVAdministrarEmpresas)
        Me.Controls.Add(Me.EmpresasBindingNavigator)
        Me.Controls.Add(Me.DateTimePickerAdministrarEmpresa_InicioOperaciones)
        Me.Controls.Add(Me.LabelNuevaEmpresa_InicioOperaciones)
        Me.Controls.Add(Me.ButtonAdministrarEmpresa_Guardar)
        Me.Controls.Add(Me.ButtonAdministrarEmpresa_Cancelar)
        Me.Controls.Add(Me.TextBoxAdministrarEmpresa_RFC)
        Me.Controls.Add(Me.LabelAdministrarEmpresa_RFC)
        Me.Controls.Add(Me.TextBoxAdministrarEmpresa_RegistroPatronal)
        Me.Controls.Add(Me.LabelAdministrarEmpresa_RegistroPatronal)
        Me.Controls.Add(Me.TextBoxAdministrarEmpresa_Contacto)
        Me.Controls.Add(Me.LabelAdministrarEmpresa_Contacto)
        Me.Controls.Add(Me.LabelAdministrarEmpresa_DomicilioFiscal)
        Me.Controls.Add(Me.TextBoxAdministrarEmpresa_DomicilioFiscal)
        Me.Controls.Add(Me.LabelAdministrarEmpresa_RazonSocial)
        Me.Controls.Add(Me.TextBoxAdministrarEmpresa_RazonSocial)
        Me.Controls.Add(Me.LabelAdministrarEmpresa_Instruccion)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormAdministrarEmpresa"
        Me.Text = "Administrar Empresa"
        CType(Me.MAD_PIADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpresasBindingNavigator.ResumeLayout(False)
        Me.EmpresasBindingNavigator.PerformLayout()
        CType(Me.DGVAdministrarEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePickerAdministrarEmpresa_InicioOperaciones As DateTimePicker
    Friend WithEvents LabelNuevaEmpresa_InicioOperaciones As Label
    Friend WithEvents ButtonAdministrarEmpresa_Guardar As Button
    Friend WithEvents ButtonAdministrarEmpresa_Cancelar As Button
    Friend WithEvents TextBoxAdministrarEmpresa_RFC As TextBox
    Friend WithEvents LabelAdministrarEmpresa_RFC As Label
    Friend WithEvents TextBoxAdministrarEmpresa_RegistroPatronal As TextBox
    Friend WithEvents LabelAdministrarEmpresa_RegistroPatronal As Label
    Friend WithEvents TextBoxAdministrarEmpresa_Contacto As TextBox
    Friend WithEvents LabelAdministrarEmpresa_Contacto As Label
    Friend WithEvents LabelAdministrarEmpresa_DomicilioFiscal As Label
    Friend WithEvents TextBoxAdministrarEmpresa_DomicilioFiscal As TextBox
    Friend WithEvents LabelAdministrarEmpresa_RazonSocial As Label
    Friend WithEvents TextBoxAdministrarEmpresa_RazonSocial As TextBox
    Friend WithEvents LabelAdministrarEmpresa_Instruccion As Label
    Friend WithEvents MAD_PIADataSet As MAD_PIADataSet
    Friend WithEvents EmpresasBindingSource As BindingSource
    Friend WithEvents EmpresasTableAdapter As MAD_PIADataSetTableAdapters.EmpresasTableAdapter
    Friend WithEvents TableAdapterManager As MAD_PIADataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpresasBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents EmpresasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DGVAdministrarEmpresas As DataGridView
    Friend WithEvents ButtonAdministrarEmpresas_Borrar As Button
    Friend WithEvents ButtonAdministrarEmpresa_Modificar As Button
    Friend WithEvents ButtonAdministrarEmpresa_Insertar As Button
End Class
