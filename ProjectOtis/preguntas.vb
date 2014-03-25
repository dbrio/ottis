Public Class preguntas

    Private Sub preguntas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatasetOtis.Preguntas1' Puede moverla o quitarla según sea necesario.
        'Me.Preguntas1TableAdapter.Fill(Me.DatasetOtis.Preguntas1)
        'TODO: esta línea de código carga datos en la tabla 'DatasetOtis.Preguntas' Puede moverla o quitarla según sea necesario.

        Dim Pregunta As String = Preguntas1TableAdapter.Fill(Me.DatasetOtis.Preguntas1, 1)
        LabelPregunta.Text = Pregunta

    End Sub

    'Private Sub PreguntasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.PreguntasBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DatasetOtis)

    'End Sub

    
End Class