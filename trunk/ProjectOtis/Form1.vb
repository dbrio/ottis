Public Class Form1
    Public nombre As String
    Public apellido As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelBienv.Text = "Bienvenido(a): " + nombre + " " + apellido
    End Sub

    Private Sub LabelBienv_Click(sender As Object, e As EventArgs) Handles LabelBienv.Click

    End Sub

    Private Sub ButtonEmpezar_Click(sender As Object, e As EventArgs) Handles ButtonEmpezar.Click
        preguntas.Show()
        Me.Close()
    End Sub
End Class
