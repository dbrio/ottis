Public Class preguntas
    Dim id As Integer = 1
    Dim idRespuesta As Integer = 6
    Dim respuestaUsuario As String
    Public nombre As String
    Public apellido As String

    Dim tiempo As Integer


    Private Sub preguntas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatasetOtis.Alumnos' Puede moverla o quitarla según sea necesario.
        Me.AlumnosTableAdapter.Fill(Me.DatasetOtis.Alumnos)
        'TODO: esta línea de código carga datos en la tabla 'DatasetOtis.RespuestasUsuario' Puede moverla o quitarla según sea necesario.
        'Me.RespuestasUsuarioTableAdapter.Fill(Me.DatasetOtis.RespuestasUsuario)
        'TODO: esta línea de código carga datos en la tabla 'DatasetOtis.Respuestas' Puede moverla o quitarla según sea necesario.
        Me.RespuestasTableAdapter.Fill(Me.DatasetOtis.Respuestas)
        'TODO: esta línea de código carga datos en la tabla 'DatasetOtis.Preguntas1' Puede moverla o quitarla según sea necesario.
        'Me.Preguntas1TableAdapter.Fill(Me.DatasetOtis.Preguntas1)
        'TODO: esta línea de código carga datos en la tabla 'DatasetOtis.Preguntas' Puede moverla o quitarla según sea necesario.

        Timer1.Enabled = True
       


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
        Picture8.Visible = False
        PictureR8A.Visible = False
        PictureR8B.Visible = False
        PictureR8C.Visible = False
        PictureR8D.Visible = False
        RadioButtonE.Visible = True

        Dim idAlumno As Integer = AlumnosTableAdapter.ObtenerID(nombre, apellido)

        RespuestasUsuarioTableAdapter.UpdateRespU(respuestaUsuario, idAlumno, id)
        id = id + 1

        'Evaluamos la pregunta 8
        If id = 8 Then

            Picture8.Visible = True
            PictureR8A.Visible = True
            PictureR8B.Visible = True
            PictureR8C.Visible = True
            PictureR8D.Visible = True
            RadioButtonE.Visible = False


            Picture8.Image = Image.FromFile("../../Resources/Pregunta8.JPG")
            PictureR8A.Image = Image.FromFile("../../Resources/8A.JPG")
            PictureR8B.Image = Image.FromFile("../../Resources/8B.JPG")
            PictureR8C.Image = Image.FromFile("../../Resources/8C.JPG")
            PictureR8D.Image = Image.FromFile("../../Resources/8D.JPG")


        End If

        'Evaluamos la pregunta 19
        If id = 19 Then

            Picture8.Visible = True
            PictureR8A.Visible = True
            PictureR8B.Visible = True
            PictureR8C.Visible = True
            PictureR8D.Visible = True
            RadioButtonE.Visible = False


            Picture8.Image = Image.FromFile("../../Resources/Pregunta19.JPG")
            PictureR8A.Image = Image.FromFile("../../Resources/19A.JPG")
            PictureR8B.Image = Image.FromFile("../../Resources/19B.JPG")
            PictureR8C.Image = Image.FromFile("../../Resources/19C.JPG")
            PictureR8D.Image = Image.FromFile("../../Resources/19D.JPG")


        End If

        'evaluamos la pregunta 33
        If id = 33 Then

            Picture8.Visible = True
            PictureR8A.Visible = True
            PictureR8B.Visible = True
            PictureR8C.Visible = True
            PictureR8D.Visible = True
            RadioButtonE.Visible = False


            Picture8.Image = Image.FromFile("../../Resources/Pregunta33.JPG")
            PictureR8A.Image = Image.FromFile("../../Resources/33A.JPG")
            PictureR8B.Image = Image.FromFile("../../Resources/33B.JPG")
            PictureR8C.Image = Image.FromFile("../../Resources/33C.JPG")
            PictureR8D.Image = Image.FromFile("../../Resources/33D.JPG")


        End If

        'evaluamos la pregunta 50
        If id = 50 Then

            Picture8.Visible = True
            PictureR8A.Visible = True
            PictureR8B.Visible = True
            PictureR8C.Visible = True
            PictureR8D.Visible = True
            RadioButtonE.Visible = False


            Picture8.Image = Image.FromFile("../../Resources/Pregunta50.JPG")
            PictureR8A.Image = Image.FromFile("../../Resources/50A.JPG")
            PictureR8B.Image = Image.FromFile("../../Resources/50B.JPG")
            PictureR8C.Image = Image.FromFile("../../Resources/50C.JPG")
            PictureR8D.Image = Image.FromFile("../../Resources/50D.JPG")


        End If

        'evaluamos la pregutna 61
        If id = 61 Then

            Picture8.Visible = True
            PictureR8A.Visible = True
            PictureR8B.Visible = True
            PictureR8C.Visible = True
            PictureR8D.Visible = True
            RadioButtonE.Visible = False


            Picture8.Image = Image.FromFile("../../Resources/Pregunta61.JPG")
            PictureR8A.Image = Image.FromFile("../../Resources/61A.JPG")
            PictureR8B.Image = Image.FromFile("../../Resources/61B.JPG")
            PictureR8C.Image = Image.FromFile("../../Resources/61C.JPG")
            PictureR8D.Image = Image.FromFile("../../Resources/61D.JPG")


        End If


        'evaluacion de la pregunta 73
        If id = 73 Then

            Picture8.Visible = True
            PictureR8A.Visible = True
            PictureR8B.Visible = True
            PictureR8C.Visible = True
            PictureR8D.Visible = True
            RadioButtonE.Visible = False


            Picture8.Image = Image.FromFile("../../Resources/Pregunta73.JPG")
            PictureR8A.Image = Image.FromFile("../../Resources/73A.JPG")
            PictureR8B.Image = Image.FromFile("../../Resources/73B.JPG")
            PictureR8C.Image = Image.FromFile("../../Resources/73C.JPG")
            PictureR8D.Image = Image.FromFile("../../Resources/73D.JPG")


        End If

        'Evaluamos las pregutnas 77, 78 ,79
        If id = 77 Then

            Picture8.Visible = True
            PictureR8A.Visible = True
            PictureR8B.Visible = True
            PictureR8C.Visible = True
            PictureR8D.Visible = True

            Picture8.Image = Image.FromFile("../../Resources/Pregunta777879.JPG")



        End If

        If id = 78 Then

            Picture8.Visible = True
            PictureR8A.Visible = True
            PictureR8B.Visible = True
            PictureR8C.Visible = True
            PictureR8D.Visible = True

            Picture8.Image = Image.FromFile("../../Resources/Pregunta777879.JPG")



        End If

        If id = 79 Then

            Picture8.Visible = True
            PictureR8A.Visible = True
            PictureR8B.Visible = True
            PictureR8C.Visible = True
            PictureR8D.Visible = True

            Picture8.Image = Image.FromFile("../../Resources/Pregunta777879.JPG")



        End If



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
        btnSaltar.Enabled = True
        ButtonOk.Enabled = False




    End Sub

    Private Sub btnSaltar_Click(sender As Object, e As EventArgs) Handles btnSaltar.Click
        Picture8.Visible = False
        PictureR8A.Visible = False
        PictureR8B.Visible = False
        PictureR8C.Visible = False
        PictureR8D.Visible = False
        RadioButtonE.Visible = True
        id = id + 1
        'Evaluamos la pregunta 8
        If id = 8 Then

            Picture8.Visible = True
            PictureR8A.Visible = True
            PictureR8B.Visible = True
            PictureR8C.Visible = True
            PictureR8D.Visible = True
            RadioButtonE.Visible = False


            Picture8.Image = Image.FromFile("../../Resources/Pregunta8.JPG")
            PictureR8A.Image = Image.FromFile("../../Resources/8A.JPG")
            PictureR8B.Image = Image.FromFile("../../Resources/8B.JPG")
            PictureR8C.Image = Image.FromFile("../../Resources/8C.JPG")
            PictureR8D.Image = Image.FromFile("../../Resources/8D.JPG")


        End If

        'Evaluamos la pregunta 19
        If id = 19 Then

            Picture8.Visible = True
            PictureR8A.Visible = True
            PictureR8B.Visible = True
            PictureR8C.Visible = True
            PictureR8D.Visible = True
            RadioButtonE.Visible = False


            Picture8.Image = Image.FromFile("../../Resources/Pregunta19.JPG")
            PictureR8A.Image = Image.FromFile("../../Resources/19A.JPG")
            PictureR8B.Image = Image.FromFile("../../Resources/19B.JPG")
            PictureR8C.Image = Image.FromFile("../../Resources/19C.JPG")
            PictureR8D.Image = Image.FromFile("../../Resources/19D.JPG")


        End If

        'evaluamos la pregunta 33
        If id = 33 Then

            Picture8.Visible = True
            PictureR8A.Visible = True
            PictureR8B.Visible = True
            PictureR8C.Visible = True
            PictureR8D.Visible = True
            RadioButtonE.Visible = False


            Picture8.Image = Image.FromFile("../../Resources/Pregunta33.JPG")
            PictureR8A.Image = Image.FromFile("../../Resources/33A.JPG")
            PictureR8B.Image = Image.FromFile("../../Resources/33B.JPG")
            PictureR8C.Image = Image.FromFile("../../Resources/33C.JPG")
            PictureR8D.Image = Image.FromFile("../../Resources/33D.JPG")


        End If

        'evaluamos la pregunta 50
        If id = 50 Then

            Picture8.Visible = True
            PictureR8A.Visible = True
            PictureR8B.Visible = True
            PictureR8C.Visible = True
            PictureR8D.Visible = True
            RadioButtonE.Visible = False


            Picture8.Image = Image.FromFile("../../Resources/Pregunta50.JPG")
            PictureR8A.Image = Image.FromFile("../../Resources/50A.JPG")
            PictureR8B.Image = Image.FromFile("../../Resources/50B.JPG")
            PictureR8C.Image = Image.FromFile("../../Resources/50C.JPG")
            PictureR8D.Image = Image.FromFile("../../Resources/50D.JPG")


        End If

        'evaluamos la pregutna 61
        If id = 61 Then

            Picture8.Visible = True
            PictureR8A.Visible = True
            PictureR8B.Visible = True
            PictureR8C.Visible = True
            PictureR8D.Visible = True
            RadioButtonE.Visible = False


            Picture8.Image = Image.FromFile("../../Resources/Pregunta61.JPG")
            PictureR8A.Image = Image.FromFile("../../Resources/61A.JPG")
            PictureR8B.Image = Image.FromFile("../../Resources/61B.JPG")
            PictureR8C.Image = Image.FromFile("../../Resources/61C.JPG")
            PictureR8D.Image = Image.FromFile("../../Resources/61D.JPG")


        End If


        'evaluacion de la pregunta 73
        If id = 73 Then

            Picture8.Visible = True
            PictureR8A.Visible = True
            PictureR8B.Visible = True
            PictureR8C.Visible = True
            PictureR8D.Visible = True
            RadioButtonE.Visible = False


            Picture8.Image = Image.FromFile("../../Resources/Pregunta73.JPG")
            PictureR8A.Image = Image.FromFile("../../Resources/73A.JPG")
            PictureR8B.Image = Image.FromFile("../../Resources/73B.JPG")
            PictureR8C.Image = Image.FromFile("../../Resources/73C.JPG")
            PictureR8D.Image = Image.FromFile("../../Resources/73D.JPG")


        End If

        'Evaluamos las pregutnas 77, 78 ,79
        If id = 77 Then

            Picture8.Visible = True
            PictureR8A.Visible = True
            PictureR8B.Visible = True
            PictureR8C.Visible = True
            PictureR8D.Visible = True

            Picture8.Image = Image.FromFile("../../Resources/Pregunta777879.JPG")



        End If

        If id = 78 Then

            Picture8.Visible = True
            PictureR8A.Visible = True
            PictureR8B.Visible = True
            PictureR8C.Visible = True
            PictureR8D.Visible = True

            Picture8.Image = Image.FromFile("../../Resources/Pregunta777879.JPG")



        End If

        If id = 79 Then

            Picture8.Visible = True
            PictureR8A.Visible = True
            PictureR8B.Visible = True
            PictureR8C.Visible = True
            PictureR8D.Visible = True

            Picture8.Image = Image.FromFile("../../Resources/Pregunta777879.JPG")



        End If

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

    Private Sub RespuestaRadioA_CheckedChanged(sender As Object, e As EventArgs) Handles RespuestaRadioA.CheckedChanged
        ButtonOk.Enabled = True
        btnSaltar.Enabled = False
        respuestaUsuario = "A"
    End Sub

    Private Sub RadioButtonB_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonB.CheckedChanged
        ButtonOk.Enabled = True
        btnSaltar.Enabled = False
        respuestaUsuario = "B"
    End Sub

    Private Sub RadioButtonC_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonC.CheckedChanged
        ButtonOk.Enabled = True
        btnSaltar.Enabled = False
        respuestaUsuario = "C"
    End Sub

    Private Sub RadioButtonD_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonD.CheckedChanged
        ButtonOk.Enabled = True
        btnSaltar.Enabled = False
        respuestaUsuario = "D"
    End Sub

    Private Sub RadioButtonE_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonE.CheckedChanged
        ButtonOk.Enabled = True
        btnSaltar.Enabled = False
        respuestaUsuario = "E"
    End Sub


   
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If tiempo = 0 Then
            tiempo = tiempo + 1
        Else
            tiempo = 2
            With Form2
                .Show()
            End With
            Me.Close()

        End If
    End Sub
End Class