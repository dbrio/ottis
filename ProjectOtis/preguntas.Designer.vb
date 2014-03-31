<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class preguntas
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
        Dim IdRespuestaUsuarioLabel As System.Windows.Forms.Label
        Dim IdAlumnoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(preguntas))
        Me.PreguntasLabel = New System.Windows.Forms.Label()
        Me.Preguntas1BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatasetOtis = New ProjectOtis.DatasetOtis()
        Me.LabelPregunta = New System.Windows.Forms.Label()
        Me.btnSaltar = New System.Windows.Forms.Button()
        Me.RespuestaRadioA = New System.Windows.Forms.RadioButton()
        Me.RespuestasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RadioButtonB = New System.Windows.Forms.RadioButton()
        Me.RadioButtonC = New System.Windows.Forms.RadioButton()
        Me.RadioButtonD = New System.Windows.Forms.RadioButton()
        Me.RadioButtonE = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IdRespuestaUsuarioLabel1 = New System.Windows.Forms.Label()
        Me.RespuestasUsuarioBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdAlumnoLabel1 = New System.Windows.Forms.Label()
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PreguntasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PreguntasTableAdapter = New ProjectOtis.DatasetOtisTableAdapters.PreguntasTableAdapter()
        Me.TableAdapterManager = New ProjectOtis.DatasetOtisTableAdapters.TableAdapterManager()
        Me.Preguntas1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Preguntas1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Preguntas1BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Preguntas1TableAdapter = New ProjectOtis.DatasetOtisTableAdapters.Preguntas1TableAdapter()
        Me.RespuestasTableAdapter = New ProjectOtis.DatasetOtisTableAdapters.RespuestasTableAdapter()
        Me.RespuestasUsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RespuestasUsuarioTableAdapter = New ProjectOtis.DatasetOtisTableAdapters.RespuestasUsuarioTableAdapter()
        Me.RespuestasUsuarioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlumnosTableAdapter = New ProjectOtis.DatasetOtisTableAdapters.AlumnosTableAdapter()
        Me.Picture8 = New System.Windows.Forms.PictureBox()
        Me.PictureR8A = New System.Windows.Forms.PictureBox()
        Me.PictureR8B = New System.Windows.Forms.PictureBox()
        Me.PictureR8C = New System.Windows.Forms.PictureBox()
        Me.PictureR8D = New System.Windows.Forms.PictureBox()
        Me.PictureR8E = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Picture77 = New System.Windows.Forms.PictureBox()
        Me.ButtonOk2 = New System.Windows.Forms.Button()
        IdRespuestaUsuarioLabel = New System.Windows.Forms.Label()
        IdAlumnoLabel = New System.Windows.Forms.Label()
        CType(Me.Preguntas1BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatasetOtis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RespuestasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RespuestasUsuarioBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreguntasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Preguntas1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Preguntas1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Preguntas1BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RespuestasUsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RespuestasUsuarioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureR8A, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureR8B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureR8C, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureR8D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureR8E, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture77, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdRespuestaUsuarioLabel
        '
        IdRespuestaUsuarioLabel.AutoSize = True
        IdRespuestaUsuarioLabel.Location = New System.Drawing.Point(1120, 21)
        IdRespuestaUsuarioLabel.Name = "IdRespuestaUsuarioLabel"
        IdRespuestaUsuarioLabel.Size = New System.Drawing.Size(112, 13)
        IdRespuestaUsuarioLabel.TabIndex = 11
        IdRespuestaUsuarioLabel.Text = "Id Respuesta Usuario:"
        IdRespuestaUsuarioLabel.Visible = False
        '
        'IdAlumnoLabel
        '
        IdAlumnoLabel.AutoSize = True
        IdAlumnoLabel.Location = New System.Drawing.Point(149, 12)
        IdAlumnoLabel.Name = "IdAlumnoLabel"
        IdAlumnoLabel.Size = New System.Drawing.Size(57, 13)
        IdAlumnoLabel.TabIndex = 12
        IdAlumnoLabel.Text = "Id Alumno:"
        IdAlumnoLabel.Visible = False
        '
        'PreguntasLabel
        '
        Me.PreguntasLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Preguntas1BindingSource3, "Preguntas", True))
        Me.PreguntasLabel.Font = New System.Drawing.Font("Arial Unicode MS", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreguntasLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PreguntasLabel.Location = New System.Drawing.Point(73, 77)
        Me.PreguntasLabel.Name = "PreguntasLabel"
        Me.PreguntasLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PreguntasLabel.Size = New System.Drawing.Size(1106, 172)
        Me.PreguntasLabel.TabIndex = 2
        Me.PreguntasLabel.Text = "Preguntas"
        Me.PreguntasLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Preguntas1BindingSource3
        '
        Me.Preguntas1BindingSource3.DataMember = "Preguntas1"
        Me.Preguntas1BindingSource3.DataSource = Me.DatasetOtis
        '
        'DatasetOtis
        '
        Me.DatasetOtis.DataSetName = "DatasetOtis"
        Me.DatasetOtis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelPregunta
        '
        Me.LabelPregunta.AutoSize = True
        Me.LabelPregunta.Location = New System.Drawing.Point(20, 21)
        Me.LabelPregunta.Name = "LabelPregunta"
        Me.LabelPregunta.Size = New System.Drawing.Size(39, 13)
        Me.LabelPregunta.TabIndex = 0
        Me.LabelPregunta.Text = "Label1"
        Me.LabelPregunta.Visible = False
        '
        'btnSaltar
        '
        Me.btnSaltar.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnSaltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSaltar.Location = New System.Drawing.Point(1032, 613)
        Me.btnSaltar.Name = "btnSaltar"
        Me.btnSaltar.Size = New System.Drawing.Size(121, 59)
        Me.btnSaltar.TabIndex = 4
        Me.btnSaltar.Text = "Saltar"
        Me.btnSaltar.UseVisualStyleBackColor = False
        Me.btnSaltar.Visible = False
        '
        'RespuestaRadioA
        '
        Me.RespuestaRadioA.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.RespuestasBindingSource, "Respuesta", True))
        Me.RespuestaRadioA.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RespuestaRadioA.Location = New System.Drawing.Point(38, 447)
        Me.RespuestaRadioA.Name = "RespuestaRadioA"
        Me.RespuestaRadioA.Size = New System.Drawing.Size(234, 34)
        Me.RespuestaRadioA.TabIndex = 6
        Me.RespuestaRadioA.TabStop = True
        Me.RespuestaRadioA.Text = "RadioButton1"
        Me.RespuestaRadioA.UseVisualStyleBackColor = True
        '
        'RespuestasBindingSource
        '
        Me.RespuestasBindingSource.DataMember = "Respuestas"
        Me.RespuestasBindingSource.DataSource = Me.DatasetOtis
        '
        'RadioButtonB
        '
        Me.RadioButtonB.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.RespuestasBindingSource, "Respuesta", True))
        Me.RadioButtonB.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonB.Location = New System.Drawing.Point(306, 447)
        Me.RadioButtonB.Name = "RadioButtonB"
        Me.RadioButtonB.Size = New System.Drawing.Size(197, 34)
        Me.RadioButtonB.TabIndex = 7
        Me.RadioButtonB.TabStop = True
        Me.RadioButtonB.Text = "RadioButton1"
        Me.RadioButtonB.UseVisualStyleBackColor = True
        '
        'RadioButtonC
        '
        Me.RadioButtonC.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.RespuestasBindingSource, "Respuesta", True))
        Me.RadioButtonC.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonC.Location = New System.Drawing.Point(535, 447)
        Me.RadioButtonC.Name = "RadioButtonC"
        Me.RadioButtonC.Size = New System.Drawing.Size(216, 34)
        Me.RadioButtonC.TabIndex = 8
        Me.RadioButtonC.TabStop = True
        Me.RadioButtonC.Text = "RadioButton1"
        Me.RadioButtonC.UseVisualStyleBackColor = True
        '
        'RadioButtonD
        '
        Me.RadioButtonD.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.RespuestasBindingSource, "Respuesta", True))
        Me.RadioButtonD.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonD.Location = New System.Drawing.Point(757, 447)
        Me.RadioButtonD.Name = "RadioButtonD"
        Me.RadioButtonD.Size = New System.Drawing.Size(220, 34)
        Me.RadioButtonD.TabIndex = 9
        Me.RadioButtonD.TabStop = True
        Me.RadioButtonD.Text = "RadioButton1"
        Me.RadioButtonD.UseVisualStyleBackColor = True
        '
        'RadioButtonE
        '
        Me.RadioButtonE.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.RespuestasBindingSource, "Respuesta", True))
        Me.RadioButtonE.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonE.Location = New System.Drawing.Point(983, 447)
        Me.RadioButtonE.Name = "RadioButtonE"
        Me.RadioButtonE.Size = New System.Drawing.Size(249, 34)
        Me.RadioButtonE.TabIndex = 10
        Me.RadioButtonE.TabStop = True
        Me.RadioButtonE.Text = "RadioButton1"
        Me.RadioButtonE.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 33)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'IdRespuestaUsuarioLabel1
        '
        Me.IdRespuestaUsuarioLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RespuestasUsuarioBindingSource2, "IdRespuestaUsuario", True))
        Me.IdRespuestaUsuarioLabel1.Location = New System.Drawing.Point(1238, 21)
        Me.IdRespuestaUsuarioLabel1.Name = "IdRespuestaUsuarioLabel1"
        Me.IdRespuestaUsuarioLabel1.Size = New System.Drawing.Size(100, 23)
        Me.IdRespuestaUsuarioLabel1.TabIndex = 12
        Me.IdRespuestaUsuarioLabel1.Text = "Label2"
        Me.IdRespuestaUsuarioLabel1.Visible = False
        '
        'RespuestasUsuarioBindingSource2
        '
        Me.RespuestasUsuarioBindingSource2.DataMember = "RespuestasUsuario"
        Me.RespuestasUsuarioBindingSource2.DataSource = Me.DatasetOtis
        '
        'IdAlumnoLabel1
        '
        Me.IdAlumnoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "IdAlumno", True))
        Me.IdAlumnoLabel1.Location = New System.Drawing.Point(212, 12)
        Me.IdAlumnoLabel1.Name = "IdAlumnoLabel1"
        Me.IdAlumnoLabel1.Size = New System.Drawing.Size(100, 23)
        Me.IdAlumnoLabel1.TabIndex = 13
        Me.IdAlumnoLabel1.Text = "Label2"
        Me.IdAlumnoLabel1.Visible = False
        '
        'AlumnosBindingSource
        '
        Me.AlumnosBindingSource.DataMember = "Alumnos"
        Me.AlumnosBindingSource.DataSource = Me.DatasetOtis
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProjectOtis.My.Resources.Resources.barra_05
        Me.PictureBox1.Location = New System.Drawing.Point(48, 537)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(609, 53)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'PreguntasBindingSource
        '
        Me.PreguntasBindingSource.DataMember = "Preguntas"
        Me.PreguntasBindingSource.DataSource = Me.DatasetOtis
        '
        'PreguntasTableAdapter
        '
        Me.PreguntasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlumnosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoríaTableAdapter = Nothing
        Me.TableAdapterManager.Preguntas1TableAdapter = Nothing
        Me.TableAdapterManager.PreguntasTableAdapter = Me.PreguntasTableAdapter
        Me.TableAdapterManager.RespuestasTableAdapter = Nothing
        Me.TableAdapterManager.RespuestasUsuarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProjectOtis.DatasetOtisTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'Preguntas1BindingSource
        '
        Me.Preguntas1BindingSource.DataSource = Me.DatasetOtis
        Me.Preguntas1BindingSource.Position = 0
        '
        'Preguntas1BindingSource1
        '
        Me.Preguntas1BindingSource1.DataSource = Me.DatasetOtis
        Me.Preguntas1BindingSource1.Position = 0
        '
        'Preguntas1BindingSource2
        '
        Me.Preguntas1BindingSource2.DataSource = Me.DatasetOtis
        Me.Preguntas1BindingSource2.Position = 0
        '
        'Preguntas1TableAdapter
        '
        Me.Preguntas1TableAdapter.ClearBeforeFill = True
        '
        'RespuestasTableAdapter
        '
        Me.RespuestasTableAdapter.ClearBeforeFill = True
        '
        'RespuestasUsuarioBindingSource
        '
        Me.RespuestasUsuarioBindingSource.DataSource = Me.DatasetOtis
        Me.RespuestasUsuarioBindingSource.Position = 0
        '
        'RespuestasUsuarioTableAdapter
        '
        Me.RespuestasUsuarioTableAdapter.ClearBeforeFill = True
        '
        'RespuestasUsuarioBindingSource1
        '
        Me.RespuestasUsuarioBindingSource1.DataSource = Me.DatasetOtis
        Me.RespuestasUsuarioBindingSource1.Position = 0
        '
        'AlumnosTableAdapter
        '
        Me.AlumnosTableAdapter.ClearBeforeFill = True
        '
        'Picture8
        '
        Me.Picture8.Location = New System.Drawing.Point(48, 188)
        Me.Picture8.Name = "Picture8"
        Me.Picture8.Size = New System.Drawing.Size(1116, 154)
        Me.Picture8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Picture8.TabIndex = 15
        Me.Picture8.TabStop = False
        Me.Picture8.Visible = False
        '
        'PictureR8A
        '
        Me.PictureR8A.Location = New System.Drawing.Point(98, 348)
        Me.PictureR8A.Name = "PictureR8A"
        Me.PictureR8A.Size = New System.Drawing.Size(135, 79)
        Me.PictureR8A.TabIndex = 16
        Me.PictureR8A.TabStop = False
        Me.PictureR8A.Visible = False
        '
        'PictureR8B
        '
        Me.PictureR8B.Location = New System.Drawing.Point(306, 348)
        Me.PictureR8B.Name = "PictureR8B"
        Me.PictureR8B.Size = New System.Drawing.Size(135, 79)
        Me.PictureR8B.TabIndex = 17
        Me.PictureR8B.TabStop = False
        Me.PictureR8B.Visible = False
        '
        'PictureR8C
        '
        Me.PictureR8C.Location = New System.Drawing.Point(535, 348)
        Me.PictureR8C.Name = "PictureR8C"
        Me.PictureR8C.Size = New System.Drawing.Size(135, 79)
        Me.PictureR8C.TabIndex = 18
        Me.PictureR8C.TabStop = False
        Me.PictureR8C.Visible = False
        '
        'PictureR8D
        '
        Me.PictureR8D.Location = New System.Drawing.Point(757, 348)
        Me.PictureR8D.Name = "PictureR8D"
        Me.PictureR8D.Size = New System.Drawing.Size(135, 79)
        Me.PictureR8D.TabIndex = 19
        Me.PictureR8D.TabStop = False
        Me.PictureR8D.Visible = False
        '
        'PictureR8E
        '
        Me.PictureR8E.Location = New System.Drawing.Point(983, 353)
        Me.PictureR8E.Name = "PictureR8E"
        Me.PictureR8E.Size = New System.Drawing.Size(135, 74)
        Me.PictureR8E.TabIndex = 20
        Me.PictureR8E.TabStop = False
        '
        'Timer1
        '
        '
        'Picture77
        '
        Me.Picture77.Location = New System.Drawing.Point(930, 54)
        Me.Picture77.Name = "Picture77"
        Me.Picture77.Size = New System.Drawing.Size(302, 288)
        Me.Picture77.TabIndex = 21
        Me.Picture77.TabStop = False
        Me.Picture77.Visible = False
        '
        'ButtonOk2
        '
        Me.ButtonOk2.BackColor = System.Drawing.Color.DarkKhaki
        Me.ButtonOk2.Enabled = False
        Me.ButtonOk2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOk2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOk2.ForeColor = System.Drawing.Color.White
        Me.ButtonOk2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ButtonOk2.Location = New System.Drawing.Point(354, 516)
        Me.ButtonOk2.Name = "ButtonOk2"
        Me.ButtonOk2.Size = New System.Drawing.Size(387, 85)
        Me.ButtonOk2.TabIndex = 22
        Me.ButtonOk2.Text = "Ok"
        Me.ButtonOk2.UseVisualStyleBackColor = False
        '
        'preguntas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1284, 688)
        Me.Controls.Add(Me.ButtonOk2)
        Me.Controls.Add(Me.Picture77)
        Me.Controls.Add(Me.PictureR8E)
        Me.Controls.Add(Me.PictureR8D)
        Me.Controls.Add(Me.PictureR8C)
        Me.Controls.Add(Me.PictureR8B)
        Me.Controls.Add(Me.PictureR8A)
        Me.Controls.Add(Me.Picture8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(IdAlumnoLabel)
        Me.Controls.Add(Me.IdAlumnoLabel1)
        Me.Controls.Add(IdRespuestaUsuarioLabel)
        Me.Controls.Add(Me.IdRespuestaUsuarioLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RadioButtonE)
        Me.Controls.Add(Me.RadioButtonD)
        Me.Controls.Add(Me.RadioButtonC)
        Me.Controls.Add(Me.RadioButtonB)
        Me.Controls.Add(Me.RespuestaRadioA)
        Me.Controls.Add(Me.btnSaltar)
        Me.Controls.Add(Me.PreguntasLabel)
        Me.Controls.Add(Me.LabelPregunta)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "preguntas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Preguntas1BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatasetOtis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RespuestasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RespuestasUsuarioBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreguntasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Preguntas1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Preguntas1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Preguntas1BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RespuestasUsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RespuestasUsuarioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureR8A, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureR8B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureR8C, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureR8D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureR8E, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture77, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatasetOtis As ProjectOtis.DatasetOtis
    Friend WithEvents PreguntasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PreguntasTableAdapter As ProjectOtis.DatasetOtisTableAdapters.PreguntasTableAdapter
    Friend WithEvents TableAdapterManager As ProjectOtis.DatasetOtisTableAdapters.TableAdapterManager
    Friend WithEvents Preguntas1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Preguntas1BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Preguntas1BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Preguntas1BindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents Preguntas1TableAdapter As ProjectOtis.DatasetOtisTableAdapters.Preguntas1TableAdapter
    Friend WithEvents PreguntasLabel As System.Windows.Forms.Label
    Friend WithEvents LabelPregunta As System.Windows.Forms.Label
    Friend WithEvents btnSaltar As System.Windows.Forms.Button
    Friend WithEvents RespuestasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RespuestasTableAdapter As ProjectOtis.DatasetOtisTableAdapters.RespuestasTableAdapter
    Friend WithEvents RespuestaRadioA As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonB As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonC As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonD As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonE As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RespuestasUsuarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RespuestasUsuarioTableAdapter As ProjectOtis.DatasetOtisTableAdapters.RespuestasUsuarioTableAdapter
    Friend WithEvents RespuestasUsuarioBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents RespuestasUsuarioBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents IdRespuestaUsuarioLabel1 As System.Windows.Forms.Label
    Friend WithEvents AlumnosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AlumnosTableAdapter As ProjectOtis.DatasetOtisTableAdapters.AlumnosTableAdapter
    Friend WithEvents IdAlumnoLabel1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Picture8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureR8A As System.Windows.Forms.PictureBox
    Friend WithEvents PictureR8B As System.Windows.Forms.PictureBox
    Friend WithEvents PictureR8C As System.Windows.Forms.PictureBox
    Friend WithEvents PictureR8D As System.Windows.Forms.PictureBox
    Friend WithEvents PictureR8E As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Picture77 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonOk2 As System.Windows.Forms.Button
End Class
