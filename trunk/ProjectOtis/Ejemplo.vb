Public Class Ejemplo



    
    Private Sub ButtonOk_Click(sender As Object, e As EventArgs) Handles ButtonOk.Click
        If RadioButtonC.Checked = True Then
            MessageBox.Show("Respuesta Correcta. La respuesta correcta es algodón. La palabra algodón corresponde a la letra C..")
            Ejemplo2.Show()
            Me.Close()
        Else
            MessageBox.Show("Respueta Incorrecta. La respuesta correcta es algodón. La palabra algodón corresponde a la letra C.")
            Ejemplo2.Show()
            Me.Close()
        End If
    End Sub
End Class