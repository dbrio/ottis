Public Class preguntas
    Dim id As Integer = 1
    Dim idRespuesta As Integer = 1
    Private Sub preguntas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatasetOtis.Respuestas' Puede moverla o quitarla según sea necesario.
        Me.RespuestasTableAdapter.Fill(Me.DatasetOtis.Respuestas)
        'TODO: esta línea de código carga datos en la tabla 'DatasetOtis.Preguntas1' Puede moverla o quitarla según sea necesario.
        'Me.Preguntas1TableAdapter.Fill(Me.DatasetOtis.Preguntas1)
        'TODO: esta línea de código carga datos en la tabla 'DatasetOtis.Preguntas' Puede moverla o quitarla según sea necesario.

        Dim Pregunta As String = Preguntas1TableAdapter.Fill(Me.DatasetOtis.Preguntas1, 1)
        LabelPregunta.Text = Pregunta

        Dim Respueta As String = RespuestasTableAdapter.FillBy(Me.DatasetOtis.Respuestas, 1)
        RadioButtonRespuesta.Text = Respueta




    End Sub

    'Private Sub PreguntasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.PreguntasBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DatasetOtis)

    'End Sub

    
    Private Sub ButtonOk_Click(sender As Object, e As EventArgs) Handles ButtonOk.Click
        id = id + 1
        Dim Pregunta As String = Preguntas1TableAdapter.Fill(Me.DatasetOtis.Preguntas1, id)
        LabelPregunta.Text = Pregunta

        idRespuesta = idRespuesta + 1


        If id = 81 Then
            ButtonOk.Enabled = False
        End If


    End Sub

   
End Class