Public Class login2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim contar As Integer = UsuariosTableAdapter.ScalarQuery(TextBoxUser.Text, TextBoxPss.Text)

        If contar = 1 Then
            With listaUsuarios
                .Show()

            End With
            Me.Close()
        Else
            MsgBox("Usuario ó Contraseña incorrecta")
            TextBoxUser.Text = ""
            TextBoxPss.Text = ""
            TextBoxUser.Focus()
        End If
    End Sub

    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatasetOtis)

    End Sub

    Private Sub login2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatasetOtis.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.DatasetOtis.Usuarios)

    End Sub
End Class