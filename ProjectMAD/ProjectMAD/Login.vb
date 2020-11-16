Public Class FormLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonLogin_SignIn_Click(sender As Object, e As EventArgs) Handles ButtonLogin_SignIn.Click
        'MsgBox("hola como estas?", vbOKOnly, "ejemplo")'
        Dim InicioSesion As New FormAdministracion()
        Me.Hide()
        InicioSesion.ShowDialog()
        Me.Close()
    End Sub

    Private Sub TextBoxLogin_Username_TextChanged(sender As Object, e As EventArgs) Handles TextBoxLogin_Username.TextChanged

    End Sub
End Class
