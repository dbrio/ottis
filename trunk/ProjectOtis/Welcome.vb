Public Class Welcome
    Dim nombre As String
    Dim apellido As String
    
    Private Sub ButtonIrInstrucciones_Click(sender As Object, e As EventArgs) Handles ButtonIrInstrucciones.Click
        Instrucciones.Show()
        Me.Close()
    End Sub


    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class