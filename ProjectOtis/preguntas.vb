﻿Public Class preguntas
    Dim id As Integer = 1
    Dim idRespuesta As Integer = 6

    Private Sub preguntas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatasetOtis.Respuestas' Puede moverla o quitarla según sea necesario.
        Me.RespuestasTableAdapter.Fill(Me.DatasetOtis.Respuestas)
        'TODO: esta línea de código carga datos en la tabla 'DatasetOtis.Preguntas1' Puede moverla o quitarla según sea necesario.
        'Me.Preguntas1TableAdapter.Fill(Me.DatasetOtis.Preguntas1)
        'TODO: esta línea de código carga datos en la tabla 'DatasetOtis.Preguntas' Puede moverla o quitarla según sea necesario.

        Dim Pregunta As String = Preguntas1TableAdapter.Fill(Me.DatasetOtis.Preguntas1, 1)
        LabelPregunta.Text = Pregunta
        Label1.Text = id
        Dim Respueta1 As String = RespuestasTableAdapter.FillBy(1, 1)
        RespuestaRadioA.Text = Respueta1
        Dim Respueta2 As String = RespuestasTableAdapter.FillBy(2, 1)
        RadioButtonB.Text = Respueta2
        Dim Respueta3 As String = RespuestasTableAdapter.FillBy(3, 1)
        RadioButtonC.Text = Respueta3
        Dim Respueta4 As String = RespuestasTableAdapter.FillBy(4, 1)
        RadioButtonD.Text = Respueta4
        Dim Respueta5 As String = RespuestasTableAdapter.FillBy(5, 1)
        RadioButtonE.Text = Respueta5




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
        Label1.Text = id

        Dim Respueta1 As String = RespuestasTableAdapter.FillBy(idRespuesta, id)
        RespuestaRadioA.Text = Respueta1
        Dim Respueta2 As String = RespuestasTableAdapter.FillBy((idRespuesta + 1), id)
        RadioButtonB.Text = Respueta2
        Dim Respueta3 As String = RespuestasTableAdapter.FillBy((idRespuesta + 2), id)
        RadioButtonC.Text = Respueta3
        Dim Respueta4 As String = RespuestasTableAdapter.FillBy((idRespuesta + 3), id)
        RadioButtonD.Text = Respueta4
        Dim Respueta5 As String = RespuestasTableAdapter.FillBy((idRespuesta + 4), id)
        RadioButtonE.Text = Respueta5

        idRespuesta = idRespuesta + 5

        RespuestaRadioA.Checked = False
        RadioButtonB.Checked = False
        RadioButtonC.Checked = False
        RadioButtonD.Checked = False
        RadioButtonE.Checked = False

        If id = 81 Then
            ButtonOk.Enabled = False
        End If




    End Sub

    Private Sub btnSaltar_Click(sender As Object, e As EventArgs) Handles btnSaltar.Click
        id = id + 1

        Dim Pregunta As String = Preguntas1TableAdapter.Fill(Me.DatasetOtis.Preguntas1, id)
        LabelPregunta.Text = Pregunta
        Label1.Text = id

        Dim Respueta1 As String = RespuestasTableAdapter.FillBy(idRespuesta, id)
        RespuestaRadioA.Text = Respueta1
        Dim Respueta2 As String = RespuestasTableAdapter.FillBy((idRespuesta + 1), id)
        RadioButtonB.Text = Respueta2
        Dim Respueta3 As String = RespuestasTableAdapter.FillBy((idRespuesta + 2), id)
        RadioButtonC.Text = Respueta3
        Dim Respueta4 As String = RespuestasTableAdapter.FillBy((idRespuesta + 3), id)
        RadioButtonD.Text = Respueta4
        Dim Respueta5 As String = RespuestasTableAdapter.FillBy((idRespuesta + 4), id)
        RadioButtonE.Text = Respueta5

        idRespuesta = idRespuesta + 5

        If id = 81 Then
            ButtonOk.Enabled = False
        End If
    End Sub
End Class