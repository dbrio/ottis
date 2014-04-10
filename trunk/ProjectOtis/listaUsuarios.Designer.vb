<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listaUsuarios
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
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatasetOtis = New ProjectOtis.DatasetOtis()
        Me.AlumnosTableAdapter = New ProjectOtis.DatasetOtisTableAdapters.AlumnosTableAdapter()
        Me.AlumnosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New ProjectOtis.DatasetOtisTableAdapters.TableAdapterManager()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIdAlumno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRNP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApellidos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDireccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelefono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCorreo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdSexo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AlumnosGridControl = New DevExpress.XtraGrid.GridControl()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatasetOtis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlumnosBindingSource
        '
        Me.AlumnosBindingSource.DataMember = "Alumnos"
        Me.AlumnosBindingSource.DataSource = Me.DatasetOtis
        '
        'DatasetOtis
        '
        Me.DatasetOtis.DataSetName = "DatasetOtis"
        Me.DatasetOtis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlumnosTableAdapter
        '
        Me.AlumnosTableAdapter.ClearBeforeFill = True
        '
        'AlumnosBindingSource1
        '
        Me.AlumnosBindingSource1.DataMember = "Alumnos"
        Me.AlumnosBindingSource1.DataSource = Me.DatasetOtis
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlumnosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoríaTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.Preguntas1TableAdapter = Nothing
        Me.TableAdapterManager.PreguntasTableAdapter = Nothing
        Me.TableAdapterManager.RespuestasTableAdapter = Nothing
        Me.TableAdapterManager.RespuestasUsuarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProjectOtis.DatasetOtisTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxBuscar.Location = New System.Drawing.Point(511, 8)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(218, 20)
        Me.TextBoxBuscar.TabIndex = 1
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonBuscar.BackColor = System.Drawing.Color.Gainsboro
        Me.ButtonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonBuscar.Location = New System.Drawing.Point(741, 5)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBuscar.TabIndex = 2
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = False
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdAlumno, Me.colRNP, Me.colNombre, Me.colApellidos, Me.colDireccion, Me.colTelefono, Me.colCorreo, Me.colFecha, Me.colIdSexo})
        Me.GridView1.GridControl = Me.AlumnosGridControl
        Me.GridView1.GroupPanelText = " "
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.RowHeight = 20
        '
        'colIdAlumno
        '
        Me.colIdAlumno.FieldName = "IdAlumno"
        Me.colIdAlumno.Name = "colIdAlumno"
        Me.colIdAlumno.OptionsColumn.ReadOnly = True
        '
        'colRNP
        '
        Me.colRNP.FieldName = "RNP"
        Me.colRNP.Name = "colRNP"
        Me.colRNP.Visible = True
        Me.colRNP.VisibleIndex = 0
        '
        'colNombre
        '
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 1
        '
        'colApellidos
        '
        Me.colApellidos.FieldName = "Apellidos"
        Me.colApellidos.Name = "colApellidos"
        Me.colApellidos.Visible = True
        Me.colApellidos.VisibleIndex = 2
        '
        'colDireccion
        '
        Me.colDireccion.FieldName = "Direccion"
        Me.colDireccion.Name = "colDireccion"
        Me.colDireccion.Visible = True
        Me.colDireccion.VisibleIndex = 3
        '
        'colTelefono
        '
        Me.colTelefono.FieldName = "Telefono"
        Me.colTelefono.Name = "colTelefono"
        Me.colTelefono.Visible = True
        Me.colTelefono.VisibleIndex = 4
        '
        'colCorreo
        '
        Me.colCorreo.FieldName = "Correo"
        Me.colCorreo.Name = "colCorreo"
        Me.colCorreo.Visible = True
        Me.colCorreo.VisibleIndex = 5
        '
        'colFecha
        '
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 6
        '
        'colIdSexo
        '
        Me.colIdSexo.FieldName = "IdSexo"
        Me.colIdSexo.Name = "colIdSexo"
        Me.colIdSexo.Visible = True
        Me.colIdSexo.VisibleIndex = 7
        '
        'AlumnosGridControl
        '
        Me.AlumnosGridControl.DataSource = Me.AlumnosBindingSource
        Me.AlumnosGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AlumnosGridControl.Location = New System.Drawing.Point(0, 0)
        Me.AlumnosGridControl.MainView = Me.GridView1
        Me.AlumnosGridControl.Name = "AlumnosGridControl"
        Me.AlumnosGridControl.Size = New System.Drawing.Size(829, 402)
        Me.AlumnosGridControl.TabIndex = 0
        Me.AlumnosGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'listaUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(829, 402)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.TextBoxBuscar)
        Me.Controls.Add(Me.AlumnosGridControl)
        Me.Name = "listaUsuarios"
        Me.Text = "Lista de Usuarios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatasetOtis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatasetOtis As ProjectOtis.DatasetOtis
    Friend WithEvents AlumnosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AlumnosTableAdapter As ProjectOtis.DatasetOtisTableAdapters.AlumnosTableAdapter
    Friend WithEvents AlumnosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As ProjectOtis.DatasetOtisTableAdapters.TableAdapterManager
    Friend WithEvents TextBoxBuscar As System.Windows.Forms.TextBox
    Friend WithEvents ButtonBuscar As System.Windows.Forms.Button
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIdAlumno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRNP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApellidos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDireccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCorreo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdSexo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AlumnosGridControl As DevExpress.XtraGrid.GridControl
End Class
