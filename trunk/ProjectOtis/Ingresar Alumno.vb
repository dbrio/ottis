Public Class Ingresar_Alumno
    Dim Alumno As String
    Private Sub AlumnosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        'Me.Validate()
        'Me.AlumnosBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.DatasetOtis)

    End Sub
    'Private Function dameNombre() As String
    '    Try
    '        Return Alumno = NombreTextEdit.EditValue
    '    Catch ex As Exception
    '        Return 0
    '    End Try
    'End Function

    Private Sub Ingresar_Alumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatasetOtis.Alumnos' Puede moverla o quitarla según sea necesario.
        'Me.AlumnosTableAdapter.Fill(Me.DatasetOtis.Alumnos)

    End Sub
    Private Sub ButtonIngresar_Click(sender As Object, e As EventArgs) Handles ButtonIngresar.Click

        'Alumno = NombreTextEdit.EditValue
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

        If Not IsNumeric(TelefonoTextEdit.EditValue) Then
            MsgBox("Debe de ser numero")
            TelefonoTextEdit.Focus()
            TelefonoTextEdit.EditValue = ""
            Exit Sub
        End If

        If CorreoTextEdit.EditValue = "" Then
            MsgBox("Debe agregar un Correo", MsgBoxStyle.Information)
            CorreoTextEdit.Focus()
            Exit Sub
        End If



        AlumnosTableAdapter.FillByProcd(RNPTextEdit.EditValue, NombreTextEdit.EditValue, ApellidosTextEdit.EditValue, DireccionTextEdit.EditValue, TelefonoTextEdit.EditValue, CorreoTextEdit.EditValue)

      

        Dim nombre As String = NombreTextEdit.EditValue
        Dim apellido As String = ApellidosTextEdit.EditValue

        With Welcome
            .nombre = nombre
            .apellido = apellido
            .Show()
        End With
        With Form1
            .nombre = nombre
            .apellido = apellido
        End With
        With preguntas
            .nombre = nombre
            .apellido = apellido
        End With

        With reporte
            .nombre = nombre
            .apellido = apellido

        End With

       
       

        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        login2.Show()
        Me.Close()
    End Sub

    Private Sub ApellidosTextEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ApellidosTextEdit.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub NombreTextEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NombreTextEdit.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub



End Class