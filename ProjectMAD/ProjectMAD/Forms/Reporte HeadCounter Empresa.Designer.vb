<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteHeadCounterEmpresa
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
        Me.ComboBoxReporteHC_Empresa = New System.Windows.Forms.ComboBox()
        Me.ComboBoxReporteHC_Deptos = New System.Windows.Forms.ComboBox()
        Me.ComboBoxReporteHC_Puestos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGVReporteHC = New System.Windows.Forms.DataGridView()
        Me.TextBoxReporteHc_Cantidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGVCantidad = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxReportesHC_CantidadEmpresa = New System.Windows.Forms.TextBox()
        Me.TextBoxReportesHC_CantidadDepto = New System.Windows.Forms.TextBox()
        Me.DGVCantidadDepto = New System.Windows.Forms.DataGridView()
        Me.DGVCantidadEmpresa = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVReporteHC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVCantidadDepto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVCantidadEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxReporteHC_Empresa
        '
        Me.ComboBoxReporteHC_Empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxReporteHC_Empresa.FormattingEnabled = True
        Me.ComboBoxReporteHC_Empresa.Location = New System.Drawing.Point(39, 47)
        Me.ComboBoxReporteHC_Empresa.Name = "ComboBoxReporteHC_Empresa"
        Me.ComboBoxReporteHC_Empresa.Size = New System.Drawing.Size(203, 24)
        Me.ComboBoxReporteHC_Empresa.TabIndex = 0
        '
        'ComboBoxReporteHC_Deptos
        '
        Me.ComboBoxReporteHC_Deptos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxReporteHC_Deptos.FormattingEnabled = True
        Me.ComboBoxReporteHC_Deptos.Location = New System.Drawing.Point(309, 47)
        Me.ComboBoxReporteHC_Deptos.Name = "ComboBoxReporteHC_Deptos"
        Me.ComboBoxReporteHC_Deptos.Size = New System.Drawing.Size(203, 24)
        Me.ComboBoxReporteHC_Deptos.TabIndex = 1
        '
        'ComboBoxReporteHC_Puestos
        '
        Me.ComboBoxReporteHC_Puestos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxReporteHC_Puestos.FormattingEnabled = True
        Me.ComboBoxReporteHC_Puestos.Location = New System.Drawing.Point(578, 47)
        Me.ComboBoxReporteHC_Puestos.Name = "ComboBoxReporteHC_Puestos"
        Me.ComboBoxReporteHC_Puestos.Size = New System.Drawing.Size(203, 24)
        Me.ComboBoxReporteHC_Puestos.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Empresa:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(309, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Departamentos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(578, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Puestos:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxReporteHC_Puestos)
        Me.GroupBox1.Controls.Add(Me.ComboBoxReporteHC_Deptos)
        Me.GroupBox1.Controls.Add(Me.ComboBoxReporteHC_Empresa)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(820, 109)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros:"
        '
        'DGVReporteHC
        '
        Me.DGVReporteHC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVReporteHC.Location = New System.Drawing.Point(48, 192)
        Me.DGVReporteHC.Name = "DGVReporteHC"
        Me.DGVReporteHC.RowHeadersWidth = 51
        Me.DGVReporteHC.RowTemplate.Height = 24
        Me.DGVReporteHC.Size = New System.Drawing.Size(781, 210)
        Me.DGVReporteHC.TabIndex = 7
        '
        'TextBoxReporteHc_Cantidad
        '
        Me.TextBoxReporteHc_Cantidad.Location = New System.Drawing.Point(707, 147)
        Me.TextBoxReporteHc_Cantidad.Name = "TextBoxReporteHc_Cantidad"
        Me.TextBoxReporteHc_Cantidad.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxReporteHc_Cantidad.TabIndex = 8
        Me.TextBoxReporteHc_Cantidad.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(601, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 34)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Cantidad de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Empleados:"
        '
        'DGVCantidad
        '
        Me.DGVCantidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCantidad.Location = New System.Drawing.Point(748, 175)
        Me.DGVCantidad.Name = "DGVCantidad"
        Me.DGVCantidad.RowHeadersWidth = 51
        Me.DGVCantidad.RowTemplate.Height = 24
        Me.DGVCantidad.Size = New System.Drawing.Size(43, 11)
        Me.DGVCantidad.TabIndex = 10
        Me.DGVCantidad.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 34)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Cantidad de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Empleados:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(332, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 34)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cantidad de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Empleados:"
        '
        'TextBoxReportesHC_CantidadEmpresa
        '
        Me.TextBoxReportesHC_CantidadEmpresa.Location = New System.Drawing.Point(168, 147)
        Me.TextBoxReportesHC_CantidadEmpresa.Name = "TextBoxReportesHC_CantidadEmpresa"
        Me.TextBoxReportesHC_CantidadEmpresa.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxReportesHC_CantidadEmpresa.TabIndex = 13
        Me.TextBoxReportesHC_CantidadEmpresa.TabStop = False
        '
        'TextBoxReportesHC_CantidadDepto
        '
        Me.TextBoxReportesHC_CantidadDepto.Location = New System.Drawing.Point(438, 147)
        Me.TextBoxReportesHC_CantidadDepto.Name = "TextBoxReportesHC_CantidadDepto"
        Me.TextBoxReportesHC_CantidadDepto.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxReportesHC_CantidadDepto.TabIndex = 14
        Me.TextBoxReportesHC_CantidadDepto.TabStop = False
        '
        'DGVCantidadDepto
        '
        Me.DGVCantidadDepto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCantidadDepto.Location = New System.Drawing.Point(477, 170)
        Me.DGVCantidadDepto.Name = "DGVCantidadDepto"
        Me.DGVCantidadDepto.RowHeadersWidth = 51
        Me.DGVCantidadDepto.RowTemplate.Height = 24
        Me.DGVCantidadDepto.Size = New System.Drawing.Size(43, 16)
        Me.DGVCantidadDepto.TabIndex = 15
        Me.DGVCantidadDepto.Visible = False
        '
        'DGVCantidadEmpresa
        '
        Me.DGVCantidadEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCantidadEmpresa.Location = New System.Drawing.Point(204, 175)
        Me.DGVCantidadEmpresa.Name = "DGVCantidadEmpresa"
        Me.DGVCantidadEmpresa.RowHeadersWidth = 51
        Me.DGVCantidadEmpresa.RowTemplate.Height = 24
        Me.DGVCantidadEmpresa.Size = New System.Drawing.Size(43, 11)
        Me.DGVCantidadEmpresa.TabIndex = 16
        Me.DGVCantidadEmpresa.Visible = False
        '
        'FormReporteHeadCounterEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(876, 552)
        Me.Controls.Add(Me.DGVCantidadEmpresa)
        Me.Controls.Add(Me.DGVCantidadDepto)
        Me.Controls.Add(Me.TextBoxReportesHC_CantidadDepto)
        Me.Controls.Add(Me.TextBoxReportesHC_CantidadEmpresa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DGVCantidad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxReporteHc_Cantidad)
        Me.Controls.Add(Me.DGVReporteHC)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormReporteHeadCounterEmpresa"
        Me.Text = "Reporte HeadCounter Empresa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVReporteHC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVCantidadDepto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVCantidadEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxReporteHC_Empresa As ComboBox
    Friend WithEvents ComboBoxReporteHC_Deptos As ComboBox
    Friend WithEvents ComboBoxReporteHC_Puestos As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGVReporteHC As DataGridView
    Friend WithEvents TextBoxReporteHc_Cantidad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DGVCantidad As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxReportesHC_CantidadEmpresa As TextBox
    Friend WithEvents TextBoxReportesHC_CantidadDepto As TextBox
    Friend WithEvents DGVCantidadDepto As DataGridView
    Friend WithEvents DGVCantidadEmpresa As DataGridView
End Class
