﻿Public Class baremos
    Public id As Integer
    Private Sub baremos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatasetOtis.Buenas' Puede moverla o quitarla según sea necesario.
        Dim buenas As Integer = Me.BuenasTableAdapter.ScalarQuery(id)

        BuenasLabel1.Text = buenas

        Dim malas As Integer = 80 - buenas

        LabelMalas.Text = malas

        Dim crudo As Integer = malas - buenas

        If crudo < 0 Then
            crudo = crudo * -1
            LabelBaremo.Text = crudo
        Else
            LabelBaremo.Text = crudo
        End If




    End Sub
End Class