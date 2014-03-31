Public Class inicio

    

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login2.Show()
        Me.Close()
    End Sub

    Private Sub ButtonOk_Click_1(sender As Object, e As EventArgs) Handles ButtonOk.Click
        Ingresar_Alumno.Show()
        Me.Close()
    End Sub
End Class