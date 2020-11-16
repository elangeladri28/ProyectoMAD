<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.LabelLogin_Username = New System.Windows.Forms.Label()
        Me.LabelLogin_Password = New System.Windows.Forms.Label()
        Me.TextBoxLogin_Username = New System.Windows.Forms.TextBox()
        Me.TextBoxLogin_Password = New System.Windows.Forms.TextBox()
        Me.ButtonLogin_SignIn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelLogin_Username
        '
        Me.LabelLogin_Username.AutoSize = True
        Me.LabelLogin_Username.Location = New System.Drawing.Point(84, 84)
        Me.LabelLogin_Username.Name = "LabelLogin_Username"
        Me.LabelLogin_Username.Size = New System.Drawing.Size(73, 17)
        Me.LabelLogin_Username.TabIndex = 0
        Me.LabelLogin_Username.Text = "Username"
        '
        'LabelLogin_Password
        '
        Me.LabelLogin_Password.AutoSize = True
        Me.LabelLogin_Password.Location = New System.Drawing.Point(84, 157)
        Me.LabelLogin_Password.Name = "LabelLogin_Password"
        Me.LabelLogin_Password.Size = New System.Drawing.Size(69, 17)
        Me.LabelLogin_Password.TabIndex = 1
        Me.LabelLogin_Password.Text = "Password"
        '
        'TextBoxLogin_Username
        '
        Me.TextBoxLogin_Username.Location = New System.Drawing.Point(87, 104)
        Me.TextBoxLogin_Username.Name = "TextBoxLogin_Username"
        Me.TextBoxLogin_Username.Size = New System.Drawing.Size(206, 22)
        Me.TextBoxLogin_Username.TabIndex = 2
        '
        'TextBoxLogin_Password
        '
        Me.TextBoxLogin_Password.Location = New System.Drawing.Point(87, 177)
        Me.TextBoxLogin_Password.Name = "TextBoxLogin_Password"
        Me.TextBoxLogin_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxLogin_Password.Size = New System.Drawing.Size(206, 22)
        Me.TextBoxLogin_Password.TabIndex = 3
        '
        'ButtonLogin_SignIn
        '
        Me.ButtonLogin_SignIn.Location = New System.Drawing.Point(142, 231)
        Me.ButtonLogin_SignIn.Name = "ButtonLogin_SignIn"
        Me.ButtonLogin_SignIn.Size = New System.Drawing.Size(93, 32)
        Me.ButtonLogin_SignIn.TabIndex = 4
        Me.ButtonLogin_SignIn.Text = "Sign In"
        Me.ButtonLogin_SignIn.UseVisualStyleBackColor = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(388, 346)
        Me.Controls.Add(Me.ButtonLogin_SignIn)
        Me.Controls.Add(Me.TextBoxLogin_Password)
        Me.Controls.Add(Me.TextBoxLogin_Username)
        Me.Controls.Add(Me.LabelLogin_Password)
        Me.Controls.Add(Me.LabelLogin_Username)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de Sesión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelLogin_Username As Label
    Friend WithEvents LabelLogin_Password As Label
    Friend WithEvents TextBoxLogin_Username As TextBox
    Friend WithEvents TextBoxLogin_Password As TextBox
    Friend WithEvents ButtonLogin_SignIn As Button
End Class
