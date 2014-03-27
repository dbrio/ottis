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
        

        If NombreTextEdit.EditValue = "" Then
            MsgBox("Debe agregar un Nombre", MsgBoxStyle.Information)
            NombreTextEdit.Focus()
            Exit Sub
        End If

        If ApellidosTextEdit.EditValue = "" Then
            MsgBox("Debe agregar un Apellido", MsgBoxStyle.Information)
            ApellidosTextEdit.Focus()
            Exit Sub
        End If


        If DireccionTextEdit.EditValue = "" Then
            MsgBox("Debe agregar una Direccion", MsgBoxStyle.Information)
            DireccionTextEdit.Focus()
            Exit Sub
        End If

        If TelefonoTextEdit.EditValue = "" Then
            MsgBox("Debe agregar un Telefono", MsgBoxStyle.Information)
            TelefonoTextEdit.Focus()
            Exit Sub
        End If

        If CorreoTextEdit.EditValue = "" Then
            MsgBox("Debe agregar un Correo", MsgBoxStyle.Information)
            CorreoTextEdit.Focus()
            Exit Sub
        End If

        AlumnosTableAdapter.Insert(RNPTextEdit.EditValue, NombreTextEdit.EditValue, ApellidosTextEdit.EditValue, DireccionTextEdit.EditValue, TelefonoTextEdit.EditValue, CorreoTextEdit.EditValue)

        NombreTextEdit.EditValue = ""
        ApellidosTextEdit.EditValue = ""
        RNPTextEdit.EditValue = ""
        DireccionTextEdit.EditValue = ""
        TelefonoTextEdit.EditValue = ""
        CorreoTextEdit.EditValue = ""

        Welcome.Show()
        Me.Close()
    End Sub
End Class