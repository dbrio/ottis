Public Class baremos
    Public id As Integer
    Private Sub baremos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatasetOtis.Buenas' Puede moverla o quitarla según sea necesario.
        Dim buenas As Integer = Me.BuenasTableAdapter.ScalarQuery(id)

        BuenasLabel1.Text = buenas

        Dim malas As Integer = 80 - buenas

        LabelMalas.Text = malas

        Dim crudo As Integer = buenas - malas
        LabelBaremo.Text = crudo

        If crudo >= 51 Then
            Label3.Text = "Superior"
        End If
        If crudo <= 50 And crudo > 45 Then
            Label3.Text = "Superior al TM"
        End If
        If crudo <= 45 And crudo > 42 Then
            Label3.Text = "TM +"
        End If
        If crudo <= 42 And crudo > 39 Then
            Label3.Text = "TM"
        End If
        If crudo <= 39 And crudo > 35 Then
            Label3.Text = "TM -"
        End If
        If crudo <= 35 And crudo > 30 Then
            Label3.Text = "Inferior al TM"
        End If
        If crudo < 29 Then
            Label3.Text = "Deficiente"
        End If





    End Sub
End Class