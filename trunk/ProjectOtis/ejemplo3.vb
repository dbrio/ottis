Public Class ejemplo3

    Private Sub ButtonOk_Click(sender As Object, e As EventArgs) Handles ButtonOk.Click
        If RadioButtonD.Checked = True Then
            MessageBox.Show("Respuesta correcta. La respuesta correcta es 57, la cual corresponde a la letra D.")
            Form1.Show()
            Me.Close()
        Else
            MessageBox.Show("Respuesta incorrecta. La respuesta correcta es 57, la cual corresponde a la letra D.")
            Form1.Show()
            Me.Close()
        End If

    End Sub
End Class