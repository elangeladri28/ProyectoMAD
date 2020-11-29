Public Class Functions

    Public Function NotSymbols(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
            Return False
        Else
            e.Handled = True
            Return True
        End If
    End Function

    Public Function NotLetters(sender As Object, e As KeyPressEventArgs)
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator

        If (Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))) Then
            e.Handled = True
            Return True
        Else
            e.Handled = False
            Return False
        End If

    End Function
End Class
