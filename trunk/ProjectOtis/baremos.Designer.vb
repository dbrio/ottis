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
        Me.BuenasLabel1 = New System.Windows.Forms.Label()
        Me.BuenasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatasetOtis = New ProjectOtis.DatasetOtis()
        Me.TableAdapterManager = New ProjectOtis.DatasetOtisTableAdapters.TableAdapterManager()
        Me.LabelMalas = New System.Windows.Forms.Label()
        Me.BuenasTableAdapter = New ProjectOtis.DatasetOtisTableAdapters.BuenasTableAdapter()
        Me.BuenasLabel3 = New System.Windows.Forms.Label()
        BuenasLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        BuenasLabel2 = New System.Windows.Forms.Label()
        CType(Me.BuenasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatasetOtis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BuenasLabel
        '
        BuenasLabel.AutoSize = True
        BuenasLabel.Location = New System.Drawing.Point(20, 77)
        BuenasLabel.Name = "BuenasLabel"
        BuenasLabel.Size = New System.Drawing.Size(46, 13)
        BuenasLabel.TabIndex = 1
        BuenasLabel.Text = "Buenas:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(20, 160)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(38, 13)
        Label1.TabIndex = 3
        Label1.Text = "Malas:"
        '
        'BuenasLabel1
        '
        Me.BuenasLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuenasBindingSource, "Buenas", True))
        Me.BuenasLabel1.Location = New System.Drawing.Point(72, 77)
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
        '
        'LabelMalas
        '
        Me.LabelMalas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuenasBindingSource, "Buenas", True))
        Me.LabelMalas.Location = New System.Drawing.Point(72, 160)
        Me.LabelMalas.Name = "LabelMalas"
        Me.LabelMalas.Size = New System.Drawing.Size(100, 23)
        Me.LabelMalas.TabIndex = 4
        Me.LabelMalas.Text = "Label1"
        '
        'BuenasTableAdapter
        '
        Me.BuenasTableAdapter.ClearBeforeFill = True
        '
        'BuenasLabel2
        '
        BuenasLabel2.AutoSize = True
        BuenasLabel2.Location = New System.Drawing.Point(343, 69)
        BuenasLabel2.Name = "BuenasLabel2"
        BuenasLabel2.Size = New System.Drawing.Size(46, 13)
        BuenasLabel2.TabIndex = 4
        BuenasLabel2.Text = "Buenas:"
        BuenasLabel2.Visible = False
        '
        'BuenasLabel3
        '
        Me.BuenasLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuenasBindingSource, "Buenas", True))
        Me.BuenasLabel3.Location = New System.Drawing.Point(395, 69)
        Me.BuenasLabel3.Name = "BuenasLabel3"
        Me.BuenasLabel3.Size = New System.Drawing.Size(100, 23)
        Me.BuenasLabel3.TabIndex = 5
        Me.BuenasLabel3.Text = "Label2"
        Me.BuenasLabel3.Visible = False
        '
        'baremos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(752, 369)
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
End Class
