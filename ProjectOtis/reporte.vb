Public Class reporte
    Public nombre As String
    Public apellido As String



    Private Sub reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatasetOtis.Alumnos' Puede moverla o quitarla según sea necesario.
        Me.AlumnosTableAdapter.Fill(Me.DatasetOtis.Alumnos)
        'TODO: esta línea de código carga datos en la tabla 'DatasetOtis.reporte' Puede moverla o quitarla según sea necesario.
        Dim idAlumno As Integer = AlumnosTableAdapter.ObtenerID(nombre, apellido)
        Me.ReporteTableAdapter.Fill(Me.DatasetOtis.reporte, idAlumno)
        'TODO: esta línea de código carga datos en la tabla 'DatasetOtis.RespuestasUsuario' Puede moverla o quitarla según sea necesario.
        'Me.RespuestasUsuarioTableAdapter.Fill(Me.DatasetOtis.RespuestasUsuario)

    End Sub



  
    Private Sub ReporteGridControl_DoubleClick(sender As Object, e As EventArgs) Handles ReporteGridControl.DoubleClick

    End Sub
End Class