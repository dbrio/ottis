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
        Me.PreguntasLabel = New System.Windows.Forms.Label()
        Me.LabelPregunta = New System.Windows.Forms.Label()
        Me.ButtonOk = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RespuestaRadioA = New System.Windows.Forms.RadioButton()
        Me.RespuestasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatasetOtis = New ProjectOtis.DatasetOtis()
        Me.Preguntas1BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PreguntasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PreguntasTableAdapter = New ProjectOtis.DatasetOtisTableAdapters.PreguntasTableAdapter()
        Me.TableAdapterManager = New ProjectOtis.DatasetOtisTableAdapters.TableAdapterManager()
        Me.Preguntas1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Preguntas1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Preguntas1BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Preguntas1TableAdapter = New ProjectOtis.DatasetOtisTableAdapters.Preguntas1TableAdapter()
        Me.RespuestasTableAdapter = New ProjectOtis.DatasetOtisTableAdapters.RespuestasTableAdapter()
        Me.RadioButtonB = New System.Windows.Forms.RadioButton()
        Me.RadioButtonC = New System.Windows.Forms.RadioButton()
        Me.RadioButtonD = New System.Windows.Forms.RadioButton()
        Me.RadioButtonE = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.RespuestasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatasetOtis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Preguntas1BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreguntasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Preguntas1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Preguntas1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Preguntas1BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PreguntasLabel
        '
        Me.PreguntasLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Preguntas1BindingSource3, "Preguntas", True))
        Me.PreguntasLabel.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreguntasLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PreguntasLabel.Location = New System.Drawing.Point(15, 60)
        Me.PreguntasLabel.Name = "PreguntasLabel"
        Me.PreguntasLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PreguntasLabel.Size = New System.Drawing.Size(1106, 172)
        Me.PreguntasLabel.TabIndex = 2
        Me.PreguntasLabel.Text = "Preguntas"
        Me.PreguntasLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        'ButtonOk
        '
        Me.ButtonOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOk.Location = New System.Drawing.Point(859, 372)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(121, 47)
        Me.ButtonOk.TabIndex = 3
        Me.ButtonOk.Text = "Ok"
        Me.ButtonOk.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1000, 372)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 47)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Saltar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RespuestaRadioA
        '
        Me.RespuestaRadioA.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.RespuestasBindingSource, "Respuesta", True))
        Me.RespuestaRadioA.Location = New System.Drawing.Point(64, 285)
        Me.RespuestaRadioA.Name = "RespuestaRadioA"
        Me.RespuestaRadioA.Size = New System.Drawing.Size(185, 24)
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
        'DatasetOtis
        '
        Me.DatasetOtis.DataSetName = "DatasetOtis"
        Me.DatasetOtis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Preguntas1BindingSource3
        '
        Me.Preguntas1BindingSource3.DataMember = "Preguntas1"
        Me.Preguntas1BindingSource3.DataSource = Me.DatasetOtis
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
        Me.TableAdapterManager.UpdateOrder = ProjectOtis.DatasetOtisTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'RadioButtonB
        '
        Me.RadioButtonB.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.RespuestasBindingSource, "Respuesta", True))
        Me.RadioButtonB.Location = New System.Drawing.Point(283, 285)
        Me.RadioButtonB.Name = "RadioButtonB"
        Me.RadioButtonB.Size = New System.Drawing.Size(187, 24)
        Me.RadioButtonB.TabIndex = 7
        Me.RadioButtonB.TabStop = True
        Me.RadioButtonB.Text = "RadioButton1"
        Me.RadioButtonB.UseVisualStyleBackColor = True
        '
        'RadioButtonC
        '
        Me.RadioButtonC.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.RespuestasBindingSource, "Respuesta", True))
        Me.RadioButtonC.Location = New System.Drawing.Point(511, 285)
        Me.RadioButtonC.Name = "RadioButtonC"
        Me.RadioButtonC.Size = New System.Drawing.Size(185, 24)
        Me.RadioButtonC.TabIndex = 8
        Me.RadioButtonC.TabStop = True
        Me.RadioButtonC.Text = "RadioButton1"
        Me.RadioButtonC.UseVisualStyleBackColor = True
        '
        'RadioButtonD
        '
        Me.RadioButtonD.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.RespuestasBindingSource, "Respuesta", True))
        Me.RadioButtonD.Location = New System.Drawing.Point(722, 285)
        Me.RadioButtonD.Name = "RadioButtonD"
        Me.RadioButtonD.Size = New System.Drawing.Size(204, 24)
        Me.RadioButtonD.TabIndex = 9
        Me.RadioButtonD.TabStop = True
        Me.RadioButtonD.Text = "RadioButton1"
        Me.RadioButtonD.UseVisualStyleBackColor = True
        '
        'RadioButtonE
        '
        Me.RadioButtonE.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.RespuestasBindingSource, "Respuesta", True))
        Me.RadioButtonE.Location = New System.Drawing.Point(958, 285)
        Me.RadioButtonE.Name = "RadioButtonE"
        Me.RadioButtonE.Size = New System.Drawing.Size(171, 24)
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
        '
        'preguntas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1141, 498)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RadioButtonE)
        Me.Controls.Add(Me.RadioButtonD)
        Me.Controls.Add(Me.RadioButtonC)
        Me.Controls.Add(Me.RadioButtonB)
        Me.Controls.Add(Me.RespuestaRadioA)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonOk)
        Me.Controls.Add(Me.PreguntasLabel)
        Me.Controls.Add(Me.LabelPregunta)
        Me.Name = "preguntas"
        Me.Text = "preguntas"
        CType(Me.RespuestasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatasetOtis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Preguntas1BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreguntasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Preguntas1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Preguntas1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Preguntas1BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ButtonOk As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RespuestasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RespuestasTableAdapter As ProjectOtis.DatasetOtisTableAdapters.RespuestasTableAdapter
    Friend WithEvents RespuestaRadioA As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonB As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonC As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonD As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonE As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
