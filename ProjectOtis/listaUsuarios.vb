﻿Public Class listaUsuarios

    Private Sub listaUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatasetOtis.Alumnos' Puede moverla o quitarla según sea necesario.
        Me.AlumnosTableAdapter.Fill(Me.DatasetOtis.Alumnos)

    End Sub

    Private Function DameId() As Integer
        Try
            Return GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdAlumno")
        Catch ex As Exception
            Return 0
        End Try
    End Function




    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        Dim ID As Integer = DameId()

        With baremos
            .id = ID
            .ShowDialog()

        End With

    End Sub

   
End Class