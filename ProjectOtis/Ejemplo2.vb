Public Class Ejemplo2

    Private Sub ButtonOk_Click(sender As Object, e As EventArgs) Handles ButtonOk.Click
        If RadioButtonB.Checked Then
            MessageBox.Show("Respuesta correcta. La respuesta es pájaro, la cual corresponde a la letra B;")
            ejemplo3.Show()
            Me.Close()
        Else
            MessageBox.Show("Respuesta incorrecta. La respuesta es pájaro, la cual corresponde a la letra B;")
            ejemplo3.Show()
            Me.Close()
        End If
    End Sub

  
End Class