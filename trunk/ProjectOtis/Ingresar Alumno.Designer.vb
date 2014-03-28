<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingresar_Alumno
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim RNPLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.DatasetOtis = New ProjectOtis.DatasetOtis()
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlumnosTableAdapter = New ProjectOtis.DatasetOtisTableAdapters.AlumnosTableAdapter()
        Me.TableAdapterManager = New ProjectOtis.DatasetOtisTableAdapters.TableAdapterManager()
        Me.ButtonIngresar = New System.Windows.Forms.Button()
        Me.NombreTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ApellidosTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DireccionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RNPTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TelefonoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CorreoTextEdit = New DevExpress.XtraEditors.TextEdit()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        RNPLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.DatasetOtis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NombreTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApellidosTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DireccionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RNPTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TelefonoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CorreoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.ForeColor = System.Drawing.Color.DimGray
        NombreLabel.Location = New System.Drawing.Point(512, 116)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(96, 24)
        NombreLabel.TabIndex = 15
        NombreLabel.Text = "* Nombre:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApellidosLabel.ForeColor = System.Drawing.Color.DimGray
        ApellidosLabel.Location = New System.Drawing.Point(815, 116)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(105, 24)
        ApellidosLabel.TabIndex = 17
        ApellidosLabel.Text = "* Apellidos:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DireccionLabel.ForeColor = System.Drawing.Color.DimGray
        DireccionLabel.Location = New System.Drawing.Point(150, 205)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(107, 24)
        DireccionLabel.TabIndex = 19
        DireccionLabel.Text = "* Direccion:"
        '
        'RNPLabel
        '
        RNPLabel.AutoSize = True
        RNPLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RNPLabel.ForeColor = System.Drawing.Color.DimGray
        RNPLabel.Location = New System.Drawing.Point(150, 116)
        RNPLabel.Name = "RNPLabel"
        RNPLabel.Size = New System.Drawing.Size(144, 24)
        RNPLabel.TabIndex = 19
        RNPLabel.Text = "N° de Identidad:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.ForeColor = System.Drawing.Color.DimGray
        TelefonoLabel.Location = New System.Drawing.Point(150, 284)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(102, 24)
        TelefonoLabel.TabIndex = 20
        TelefonoLabel.Text = "* Telefono:"
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CorreoLabel.ForeColor = System.Drawing.Color.DimGray
        CorreoLabel.Location = New System.Drawing.Point(742, 278)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(73, 24)
        CorreoLabel.TabIndex = 21
        CorreoLabel.Text = "Correo:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.DimGray
        Label1.Location = New System.Drawing.Point(370, 86)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(0, 24)
        Label1.TabIndex = 22
        '
        'DatasetOtis
        '
        Me.DatasetOtis.DataSetName = "DatasetOtis"
        Me.DatasetOtis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlumnosTableAdapter = Me.AlumnosTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoríaTableAdapter = Nothing
        Me.TableAdapterManager.Preguntas1TableAdapter = Nothing
        Me.TableAdapterManager.PreguntasTableAdapter = Nothing
        Me.TableAdapterManager.RespuestasTableAdapter = Nothing
        Me.TableAdapterManager.RespuestasUsuarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProjectOtis.DatasetOtisTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ButtonIngresar
        '
        Me.ButtonIngresar.BackColor = System.Drawing.Color.DarkKhaki
        Me.ButtonIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIngresar.ForeColor = System.Drawing.Color.White
        Me.ButtonIngresar.Location = New System.Drawing.Point(536, 394)
        Me.ButtonIngresar.Name = "ButtonIngresar"
        Me.ButtonIngresar.Size = New System.Drawing.Size(224, 68)
        Me.ButtonIngresar.TabIndex = 6
        Me.ButtonIngresar.Text = "Ingresar"
        Me.ButtonIngresar.UseVisualStyleBackColor = False
        '
        'NombreTextEdit
        '
        Me.NombreTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AlumnosBindingSource, "Nombre", True))
        Me.NombreTextEdit.Location = New System.Drawing.Point(614, 113)
        Me.NombreTextEdit.Name = "NombreTextEdit"
        Me.NombreTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextEdit.Properties.Appearance.Options.UseFont = True
        Me.NombreTextEdit.Size = New System.Drawing.Size(160, 30)
        Me.NombreTextEdit.TabIndex = 1
        '
        'ApellidosTextEdit
        '
        Me.ApellidosTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AlumnosBindingSource, "Apellidos", True))
        Me.ApellidosTextEdit.Location = New System.Drawing.Point(921, 113)
        Me.ApellidosTextEdit.Name = "ApellidosTextEdit"
        Me.ApellidosTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidosTextEdit.Properties.Appearance.Options.UseFont = True
        Me.ApellidosTextEdit.Size = New System.Drawing.Size(160, 30)
        Me.ApellidosTextEdit.TabIndex = 2
        '
        'DireccionTextEdit
        '
        Me.DireccionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AlumnosBindingSource, "Direccion", True))
        Me.DireccionTextEdit.Location = New System.Drawing.Point(307, 202)
        Me.DireccionTextEdit.Name = "DireccionTextEdit"
        Me.DireccionTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionTextEdit.Properties.Appearance.Options.UseFont = True
        Me.DireccionTextEdit.Size = New System.Drawing.Size(774, 30)
        Me.DireccionTextEdit.TabIndex = 3
        '
        'RNPTextEdit
        '
        Me.RNPTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AlumnosBindingSource, "RNP", True))
        Me.RNPTextEdit.Location = New System.Drawing.Point(307, 113)
        Me.RNPTextEdit.Name = "RNPTextEdit"
        Me.RNPTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RNPTextEdit.Properties.Appearance.Options.UseFont = True
        Me.RNPTextEdit.Size = New System.Drawing.Size(177, 30)
        Me.RNPTextEdit.TabIndex = 0
        '
        'TelefonoTextEdit
        '
        Me.TelefonoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AlumnosBindingSource, "Telefono", True))
        Me.TelefonoTextEdit.Location = New System.Drawing.Point(307, 281)
        Me.TelefonoTextEdit.Name = "TelefonoTextEdit"
        Me.TelefonoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.TelefonoTextEdit.Size = New System.Drawing.Size(152, 30)
        Me.TelefonoTextEdit.TabIndex = 4
        '
        'CorreoTextEdit
        '
        Me.CorreoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AlumnosBindingSource, "Correo", True))
        Me.CorreoTextEdit.Location = New System.Drawing.Point(832, 274)
        Me.CorreoTextEdit.Name = "CorreoTextEdit"
        Me.CorreoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CorreoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.CorreoTextEdit.Size = New System.Drawing.Size(249, 30)
        Me.CorreoTextEdit.TabIndex = 5
        '
        'Ingresar_Alumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1268, 479)
        Me.Controls.Add(Label1)
        Me.Controls.Add(CorreoLabel)
        Me.Controls.Add(Me.CorreoTextEdit)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextEdit)
        Me.Controls.Add(RNPLabel)
        Me.Controls.Add(Me.RNPTextEdit)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextEdit)
        Me.Controls.Add(ApellidosLabel)
        Me.Controls.Add(Me.ApellidosTextEdit)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextEdit)
        Me.Controls.Add(Me.ButtonIngresar)
        Me.Name = "Ingresar_Alumno"
        Me.Text = "REGISTRO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DatasetOtis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NombreTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApellidosTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DireccionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RNPTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TelefonoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CorreoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatasetOtis As ProjectOtis.DatasetOtis
    Friend WithEvents AlumnosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AlumnosTableAdapter As ProjectOtis.DatasetOtisTableAdapters.AlumnosTableAdapter
    Friend WithEvents TableAdapterManager As ProjectOtis.DatasetOtisTableAdapters.TableAdapterManager
    Friend WithEvents ButtonIngresar As System.Windows.Forms.Button
    Friend WithEvents NombreTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ApellidosTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DireccionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RNPTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TelefonoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CorreoTextEdit As DevExpress.XtraEditors.TextEdit
End Class
