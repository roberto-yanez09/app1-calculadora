Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Numero1 As Integer = Integer.Parse(TextBox1.Text)
        Dim Numero2 As Integer = Integer.Parse(TextBox2.Text)
        Dim resultado As Integer = Numero1 + Numero2
        Label6.Text = resultado.ToString()
    End Sub
End Class
