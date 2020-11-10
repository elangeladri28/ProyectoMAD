Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MsgBox("hola como estas?", vbOKOnly, "ejemplo")'
        Dim InicioSesion As New Form2()
        Me.Hide()
        InicioSesion.ShowDialog()
        Me.Close()
    End Sub
End Class
