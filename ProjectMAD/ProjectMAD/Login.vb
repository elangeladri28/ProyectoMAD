Public Class FormLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonLogin_SignIn_Click(sender As Object, e As EventArgs) Handles ButtonLogin_SignIn.Click
        'MsgBox("hola como estas?", vbOKOnly, "ejemplo")'

        'If String.IsNullOrEmpty(TextBoxLogin_Username.Text) Or String.IsNullOrEmpty(TextBoxLogin_Password.Text) Then
        '    MsgBox("faltan datos", vbOKOnly, "ejemplo")
        'Else
        '    Dim InicioSesion As New FormAdministracion()
        '    Me.Hide()
        '    InicioSesion.ShowDialog()
        '    Me.Close()
        'End If

        Dim InicioSesion As New FormAdministracion()
        Me.Hide()
        InicioSesion.ShowDialog()
        Me.Close()

    End Sub

    Private Sub TextBoxLogin_Username_TextChanged(sender As Object, e As EventArgs) Handles TextBoxLogin_Username.TextChanged

    End Sub
End Class
