Public Class Form1
    Public nombre As String
    Public apellido As String
    Public contador As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LabelBienv_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonEmpezar_Click(sender As Object, e As EventArgs) Handles ButtonEmpezar.Click
        preguntas.Show()
        'Timer1.Start()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        'If contador < 10000 Then
        '    contador = contador + 1
        'Else
        '    preguntas.Close()
        '    Timer1.Stop()
        'End If

    End Sub
End Class
