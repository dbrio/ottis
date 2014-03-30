Public Class Welcome
    Public nombre As String
    Public apellido As String
    
    Private Sub ButtonIrInstrucciones_Click(sender As Object, e As EventArgs) Handles ButtonIrInstrucciones.Click
        Instrucciones.Show()
        Me.Close()
    End Sub


   
    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelBienvenido.Text = "Bienvenido(a): " + nombre + " " + apellido
    End Sub

  
End Class