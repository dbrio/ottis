Public Class login
    Dim contar As Integer
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatasetOtis.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.DatasetOtis.Usuarios)


       
    End Sub

    Private Sub butonEntrar_Click(sender As Object, e As EventArgs) Handles butonEntrar.Click
        contar = UsuariosTableAdapter.ScalarQuery(TextBoxUser.Text, TextBoxPass.Text)
        If contar = 1 Then
            With listaUsuarios
                .Show()
            End With
            Me.Close()
        Else
            MsgBox("Usuario ó Contraseña Incorrecta ")
            TextBoxUser.Text = ""
            TextBoxPass.Text = ""
            TextBoxUser.Show()

        End If
    End Sub
End Class