Public Class Ingresar_Alumno

    Private Sub AlumnosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AlumnosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatasetOtis)

    End Sub

    Private Sub Ingresar_Alumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatasetOtis.Alumnos' Puede moverla o quitarla según sea necesario.
        Me.AlumnosTableAdapter.Fill(Me.DatasetOtis.Alumnos)

    End Sub

    Private Sub ButtonIngresar_Click(sender As Object, e As EventArgs) Handles ButtonIngresar.Click

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

        If RNPTextEdit.Text = "" Then
            MsgBox("Debe agregar un RNP", MsgBoxStyle.Information)
            RNPTextEdit.Focus()
            Exit Sub
        End If

        If DireccionTextEdit.Text = "" Then
            MsgBox("Debe agregar una Direccion", MsgBoxStyle.Information)
            DireccionTextEdit.Focus()
            Exit Sub
        End If

        If TelefonoTextEdit.Text = "" Then
            MsgBox("Debe agregar un Telefono", MsgBoxStyle.Information)
            TelefonoTextEdit.Focus()
            Exit Sub
        End If

        If CorreoTextEdit.Text = "" Then
            MsgBox("Debe agregar un Correo", MsgBoxStyle.Information)
            CorreoTextEdit.Focus()
            Exit Sub
        End If

        AlumnosTableAdapter.Insert(RNPTextEdit.EditValue, NombreTextEdit.EditValue, ApellidosTextEdit.EditValue, DireccionTextEdit.EditValue, TelefonoTextEdit.EditValue, CorreoTextEdit.EditValue)

        NombreTextEdit.Text = ""
        ApellidosTextEdit.Text = ""
        RNPTextEdit.Text = ""
        DireccionTextEdit.Text = ""
        TelefonoTextEdit.Text = ""
        CorreoTextEdit.Text = ""


    End Sub
End Class