<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class baremos
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
        Dim BuenasLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim BuenasLabel2 As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Me.BuenasLabel1 = New System.Windows.Forms.Label()
        Me.BuenasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatasetOtis = New ProjectOtis.DatasetOtis()
        Me.LabelMalas = New System.Windows.Forms.Label()
        Me.BuenasLabel3 = New System.Windows.Forms.Label()
        Me.LabelBaremo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TotalLabel1 = New System.Windows.Forms.Label()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelSignP = New System.Windows.Forms.Label()
        Me.labelAnalogia = New System.Windows.Forms.Label()
        Me.LabelInter = New System.Windows.Forms.Label()
        Me.LabelOraciones = New System.Windows.Forms.Label()
        Me.LabelRA = New System.Windows.Forms.Label()
        Me.LabelSerie = New System.Windows.Forms.Label()
        Me.LabelRazonamientoL = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New ProjectOtis.DatasetOtisTableAdapters.TableAdapterManager()
        Me.BuenasTableAdapter = New ProjectOtis.DatasetOtisTableAdapters.BuenasTableAdapter()
        Me.DataTable1TableAdapter = New ProjectOtis.DatasetOtisTableAdapters.DataTable1TableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        BuenasLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        BuenasLabel2 = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        CType(Me.BuenasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatasetOtis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BuenasLabel
        '
        BuenasLabel.AutoSize = True
        BuenasLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BuenasLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        BuenasLabel.Location = New System.Drawing.Point(29, 117)
        BuenasLabel.Name = "BuenasLabel"
        BuenasLabel.Size = New System.Drawing.Size(91, 25)
        BuenasLabel.TabIndex = 1
        BuenasLabel.Text = "Buenas:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Label1.Location = New System.Drawing.Point(29, 200)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(76, 25)
        Label1.TabIndex = 3
        Label1.Text = "Malas:"
        '
        'BuenasLabel2
        '
        BuenasLabel2.AutoSize = True
        BuenasLabel2.Location = New System.Drawing.Point(598, 9)
        BuenasLabel2.Name = "BuenasLabel2"
        BuenasLabel2.Size = New System.Drawing.Size(46, 13)
        BuenasLabel2.TabIndex = 4
        BuenasLabel2.Text = "Buenas:"
        BuenasLabel2.Visible = False
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(704, 9)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(34, 13)
        TotalLabel.TabIndex = 9
        TotalLabel.Text = "Total:"
        TotalLabel.Visible = False
        '
        'BuenasLabel1
        '
        Me.BuenasLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuenasBindingSource, "Buenas", True))
        Me.BuenasLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuenasLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BuenasLabel1.Location = New System.Drawing.Point(126, 117)
        Me.BuenasLabel1.Name = "BuenasLabel1"
        Me.BuenasLabel1.Size = New System.Drawing.Size(100, 23)
        Me.BuenasLabel1.TabIndex = 2
        Me.BuenasLabel1.Text = "Label1"
        '
        'BuenasBindingSource
        '
        Me.BuenasBindingSource.DataMember = "Buenas"
        Me.BuenasBindingSource.DataSource = Me.DatasetOtis
        '
        'DatasetOtis
        '
        Me.DatasetOtis.DataSetName = "DatasetOtis"
        Me.DatasetOtis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelMalas
        '
        Me.LabelMalas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuenasBindingSource, "Buenas", True))
        Me.LabelMalas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMalas.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelMalas.Location = New System.Drawing.Point(126, 200)
        Me.LabelMalas.Name = "LabelMalas"
        Me.LabelMalas.Size = New System.Drawing.Size(100, 23)
        Me.LabelMalas.TabIndex = 4
        Me.LabelMalas.Text = "Label1"
        '
        'BuenasLabel3
        '
        Me.BuenasLabel3.Location = New System.Drawing.Point(650, 9)
        Me.BuenasLabel3.Name = "BuenasLabel3"
        Me.BuenasLabel3.Size = New System.Drawing.Size(100, 23)
        Me.BuenasLabel3.TabIndex = 5
        Me.BuenasLabel3.Text = "Label2"
        Me.BuenasLabel3.Visible = False
        '
        'LabelBaremo
        '
        Me.LabelBaremo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuenasBindingSource, "Buenas", True))
        Me.LabelBaremo.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBaremo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelBaremo.Location = New System.Drawing.Point(377, 165)
        Me.LabelBaremo.Name = "LabelBaremo"
        Me.LabelBaremo.Size = New System.Drawing.Size(202, 58)
        Me.LabelBaremo.TabIndex = 6
        Me.LabelBaremo.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuenasBindingSource, "Buenas", True))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(343, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 58)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Resultado Crudo"
        '
        'Label3
        '
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuenasBindingSource, "Buenas", True))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(343, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(256, 58)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Label1"
        '
        'TotalLabel1
        '
        Me.TotalLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "Total", True))
        Me.TotalLabel1.Location = New System.Drawing.Point(744, 9)
        Me.TotalLabel1.Name = "TotalLabel1"
        Me.TotalLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TotalLabel1.TabIndex = 10
        Me.TotalLabel1.Text = "Label4"
        Me.TotalLabel1.Visible = False
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.DatasetOtis
        '
        'LabelSignP
        '
        Me.LabelSignP.AutoSize = True
        Me.LabelSignP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSignP.ForeColor = System.Drawing.Color.DimGray
        Me.LabelSignP.Location = New System.Drawing.Point(649, 89)
        Me.LabelSignP.Name = "LabelSignP"
        Me.LabelSignP.Size = New System.Drawing.Size(178, 16)
        Me.LabelSignP.TabIndex = 11
        Me.LabelSignP.Text = "Significado de palabras:"
        '
        'labelAnalogia
        '
        Me.labelAnalogia.AutoSize = True
        Me.labelAnalogia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelAnalogia.ForeColor = System.Drawing.Color.DimGray
        Me.labelAnalogia.Location = New System.Drawing.Point(649, 134)
        Me.labelAnalogia.Name = "labelAnalogia"
        Me.labelAnalogia.Size = New System.Drawing.Size(124, 16)
        Me.labelAnalogia.TabIndex = 12
        Me.labelAnalogia.Text = "Analogia Verbal:"
        '
        'LabelInter
        '
        Me.LabelInter.AutoSize = True
        Me.LabelInter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInter.ForeColor = System.Drawing.Color.DimGray
        Me.LabelInter.Location = New System.Drawing.Point(649, 221)
        Me.LabelInter.Name = "LabelInter"
        Me.LabelInter.Size = New System.Drawing.Size(209, 16)
        Me.LabelInter.TabIndex = 14
        Me.LabelInter.Text = "Interpretacion de Proverbios:"
        '
        'LabelOraciones
        '
        Me.LabelOraciones.AutoSize = True
        Me.LabelOraciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOraciones.ForeColor = System.Drawing.Color.DimGray
        Me.LabelOraciones.Location = New System.Drawing.Point(649, 176)
        Me.LabelOraciones.Name = "LabelOraciones"
        Me.LabelOraciones.Size = New System.Drawing.Size(190, 16)
        Me.LabelOraciones.TabIndex = 13
        Me.LabelOraciones.Text = "Oraciones Desordenadas:"
        '
        'LabelRA
        '
        Me.LabelRA.AutoSize = True
        Me.LabelRA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRA.ForeColor = System.Drawing.Color.DimGray
        Me.LabelRA.Location = New System.Drawing.Point(650, 349)
        Me.LabelRA.Name = "LabelRA"
        Me.LabelRA.Size = New System.Drawing.Size(183, 16)
        Me.LabelRA.TabIndex = 18
        Me.LabelRA.Text = "Razonamiento aritmetico:"
        '
        'LabelSerie
        '
        Me.LabelSerie.AutoSize = True
        Me.LabelSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSerie.ForeColor = System.Drawing.Color.DimGray
        Me.LabelSerie.Location = New System.Drawing.Point(650, 304)
        Me.LabelSerie.Name = "LabelSerie"
        Me.LabelSerie.Size = New System.Drawing.Size(145, 16)
        Me.LabelSerie.TabIndex = 17
        Me.LabelSerie.Text = "Series de Numeros:"
        '
        'LabelRazonamientoL
        '
        Me.LabelRazonamientoL.AutoSize = True
        Me.LabelRazonamientoL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRazonamientoL.ForeColor = System.Drawing.Color.DimGray
        Me.LabelRazonamientoL.Location = New System.Drawing.Point(650, 262)
        Me.LabelRazonamientoL.Name = "LabelRazonamientoL"
        Me.LabelRazonamientoL.Size = New System.Drawing.Size(162, 16)
        Me.LabelRazonamientoL.TabIndex = 16
        Me.LabelRazonamientoL.Text = "Razonamiento Logico:"
        '
        'Label11
        '
        Me.Label11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuenasBindingSource, "Buenas", True))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(27, 309)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(221, 58)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Diagnostico"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label12.Location = New System.Drawing.Point(842, 349)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 18)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Label12"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label13.Location = New System.Drawing.Point(815, 303)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 18)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Label13"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label14.Location = New System.Drawing.Point(815, 261)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 18)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Label14"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label15.Location = New System.Drawing.Point(866, 221)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 18)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Label15"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label16.Location = New System.Drawing.Point(855, 174)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 18)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Label16"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label17.Location = New System.Drawing.Point(791, 135)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 18)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Label17"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label18.Location = New System.Drawing.Point(850, 88)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 18)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Label18"
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
        'BuenasTableAdapter
        '
        Me.BuenasTableAdapter.ClearBeforeFill = True
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuenasBindingSource, "Buenas", True))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(649, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(256, 29)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Total Buenas Por Categorias"
        '
        'baremos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(953, 415)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LabelRA)
        Me.Controls.Add(Me.LabelSerie)
        Me.Controls.Add(Me.LabelRazonamientoL)
        Me.Controls.Add(Me.LabelInter)
        Me.Controls.Add(Me.LabelOraciones)
        Me.Controls.Add(Me.labelAnalogia)
        Me.Controls.Add(Me.LabelSignP)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelBaremo)
        Me.Controls.Add(BuenasLabel2)
        Me.Controls.Add(Me.BuenasLabel3)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.LabelMalas)
        Me.Controls.Add(BuenasLabel)
        Me.Controls.Add(Me.BuenasLabel1)
        Me.Name = "baremos"
        Me.Text = "Baremos"
        CType(Me.BuenasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatasetOtis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatasetOtis As ProjectOtis.DatasetOtis
    Friend WithEvents BuenasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As ProjectOtis.DatasetOtisTableAdapters.TableAdapterManager
    Friend WithEvents BuenasLabel1 As System.Windows.Forms.Label
    Friend WithEvents LabelMalas As System.Windows.Forms.Label
    Friend WithEvents BuenasTableAdapter As ProjectOtis.DatasetOtisTableAdapters.BuenasTableAdapter
    Friend WithEvents BuenasLabel3 As System.Windows.Forms.Label
    Friend WithEvents LabelBaremo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable1TableAdapter As ProjectOtis.DatasetOtisTableAdapters.DataTable1TableAdapter
    Friend WithEvents TotalLabel1 As System.Windows.Forms.Label
    Friend WithEvents LabelSignP As System.Windows.Forms.Label
    Friend WithEvents labelAnalogia As System.Windows.Forms.Label
    Friend WithEvents LabelInter As System.Windows.Forms.Label
    Friend WithEvents LabelOraciones As System.Windows.Forms.Label
    Friend WithEvents LabelRA As System.Windows.Forms.Label
    Friend WithEvents LabelSerie As System.Windows.Forms.Label
    Friend WithEvents LabelRazonamientoL As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
