<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporte
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RespuestasUsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatasetOtis = New ProjectOtis.DatasetOtis()
        Me.DatasetOtisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RespuestasUsuarioTableAdapter = New ProjectOtis.DatasetOtisTableAdapters.RespuestasUsuarioTableAdapter()
        Me.ReporteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReporteTableAdapter = New ProjectOtis.DatasetOtisTableAdapters.reporteTableAdapter()
        Me.TableAdapterManager = New ProjectOtis.DatasetOtisTableAdapters.TableAdapterManager()
        Me.ReporteGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPreguntas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRespuestaUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Respuesta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlumnosTableAdapter = New ProjectOtis.DatasetOtisTableAdapters.AlumnosTableAdapter()
        CType(Me.RespuestasUsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatasetOtis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatasetOtisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReporteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReporteGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RespuestasUsuarioBindingSource
        '
        Me.RespuestasUsuarioBindingSource.DataMember = "RespuestasUsuario"
        Me.RespuestasUsuarioBindingSource.DataSource = Me.DatasetOtis
        '
        'DatasetOtis
        '
        Me.DatasetOtis.DataSetName = "DatasetOtis"
        Me.DatasetOtis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatasetOtisBindingSource
        '
        Me.DatasetOtisBindingSource.DataSource = Me.DatasetOtis
        Me.DatasetOtisBindingSource.Position = 0
        '
        'RespuestasUsuarioTableAdapter
        '
        Me.RespuestasUsuarioTableAdapter.ClearBeforeFill = True
        '
        'ReporteBindingSource
        '
        Me.ReporteBindingSource.DataMember = "reporte"
        Me.ReporteBindingSource.DataSource = Me.DatasetOtis
        '
        'ReporteTableAdapter
        '
        Me.ReporteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlumnosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoríaTableAdapter = Nothing
        Me.TableAdapterManager.Preguntas1TableAdapter = Nothing
        Me.TableAdapterManager.PreguntasTableAdapter = Nothing
        Me.TableAdapterManager.RespuestasTableAdapter = Nothing
        Me.TableAdapterManager.RespuestasUsuarioTableAdapter = Me.RespuestasUsuarioTableAdapter
        Me.TableAdapterManager.UpdateOrder = ProjectOtis.DatasetOtisTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ReporteGridControl
        '
        Me.ReporteGridControl.DataSource = Me.ReporteBindingSource
        Me.ReporteGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReporteGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ReporteGridControl.MainView = Me.GridView1
        Me.ReporteGridControl.Name = "ReporteGridControl"
        Me.ReporteGridControl.Size = New System.Drawing.Size(834, 432)
        Me.ReporteGridControl.TabIndex = 0
        Me.ReporteGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPreguntas, Me.colRespuestaUsuario, Me.Respuesta})
        Me.GridView1.GridControl = Me.ReporteGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colPreguntas
        '
        Me.colPreguntas.FieldName = "Preguntas"
        Me.colPreguntas.Name = "colPreguntas"
        Me.colPreguntas.Visible = True
        Me.colPreguntas.VisibleIndex = 0
        '
        'colRespuestaUsuario
        '
        Me.colRespuestaUsuario.FieldName = "RespuestaUsuario"
        Me.colRespuestaUsuario.Name = "colRespuestaUsuario"
        Me.colRespuestaUsuario.Visible = True
        Me.colRespuestaUsuario.VisibleIndex = 1
        '
        'Respuesta
        '
        Me.Respuesta.FieldName = "Expr1"
        Me.Respuesta.Name = "Respuesta"
        Me.Respuesta.OptionsColumn.ReadOnly = True
        Me.Respuesta.Visible = True
        Me.Respuesta.VisibleIndex = 2
        '
        'AlumnosBindingSource
        '
        Me.AlumnosBindingSource.DataMember = "Alumnos"
        Me.AlumnosBindingSource.DataSource = Me.DatasetOtis
        '
        'AlumnosTableAdapter
        '
        Me.AlumnosTableAdapter.ClearBeforeFill = True
        '
        'reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 432)
        Me.Controls.Add(Me.ReporteGridControl)
        Me.Name = "reporte"
        Me.Text = "reporte"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RespuestasUsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatasetOtis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatasetOtisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReporteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReporteGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DatasetOtisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatasetOtis As ProjectOtis.DatasetOtis
    Friend WithEvents RespuestasUsuarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RespuestasUsuarioTableAdapter As ProjectOtis.DatasetOtisTableAdapters.RespuestasUsuarioTableAdapter
    Friend WithEvents ReporteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReporteTableAdapter As ProjectOtis.DatasetOtisTableAdapters.reporteTableAdapter
    Friend WithEvents TableAdapterManager As ProjectOtis.DatasetOtisTableAdapters.TableAdapterManager
    Friend WithEvents ReporteGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPreguntas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRespuestaUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Respuesta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AlumnosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AlumnosTableAdapter As ProjectOtis.DatasetOtisTableAdapters.AlumnosTableAdapter
End Class
