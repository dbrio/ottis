Public Class Ingresar_Alumno

    Private Sub AlumnosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        'Me.Validate()
        'Me.AlumnosBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.DatasetOtis)

    End Sub

    Private Sub Ingresar_Alumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatasetOtis.Alumnos' Puede moverla o quitarla según sea necesario.
        'Me.AlumnosTableAdapter.Fill(Me.DatasetOtis.Alumnos)

    End Sub

    Private Sub ButtonIngresar_Click(sender As Object, e As EventArgs) Handles ButtonIngresar.Click

        If RNPMaskedTextBox.Text = "" Then
            MsgBox("Debe agregar un RNP", MsgBoxStyle.Information)
            RNPMaskedTextBox.Focus()
            Exit Sub
        End If

        If NombreTextEdit.Text = "" Then
            MsgBox("Debe agregar un Nombre", MsgBoxStyle.Information)
            NombreTextEdit.Focus()
            Exit Sub
        End If

        If ApellidosTextEdit.Text = "" Then
            MsgBox("Debe agregar un Apellido", MsgBoxStyle.Information)
            ApellidosTextEdit.Focus()
            Exit Sub
        End If


        If DireccionTextEdit.Text = "" Then
            MsgBox("Debe agregar una Direccion", MsgBoxStyle.Information)
            DireccionTextEdit.Focus()
            Exit Sub
        End If

        If TelefonoMaskedTextBox.Text = "" Then
            MsgBox("Debe agregar un Telefono", MsgBoxStyle.Information)
            TelefonoMaskedTextBox.Focus()
            Exit Sub
        End If

        If CorreoMaskedTextBox.Text = "" Then
            MsgBox("Debe agregar un Correo", MsgBoxStyle.Information)
            CorreoMaskedTextBox.Focus()
            Exit Sub
        End If

        AlumnosTableAdapter.Insert(RNPMaskedTextBox.Text, NombreTextEdit.EditValue, ApellidosTextEdit.EditValue, DireccionTextEdit.EditValue, TelefonoMaskedTextBox.Text, CorreoMaskedTextBox.Text)

        NombreTextEdit.Text = ""
        ApellidosTextEdit.Text = ""
        RNPMaskedTextBox.Text = ""
        DireccionTextEdit.Text = ""
        TelefonoMaskedTextBox.Text = ""
        CorreoMaskedTextBox.Text = ""


    End Sub
End Class