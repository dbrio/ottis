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
        Me.LabelBaremo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.LabelMalas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMalas.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelMalas.Location = New System.Drawing.Point(126, 200)
        Me.LabelMalas.Name = "LabelMalas"
        Me.LabelMalas.Size = New System.Drawing.Size(100, 23)
        Me.LabelMalas.TabIndex = 4
        Me.LabelMalas.Text = "Label1"
        '
        'BuenasTableAdapter
        '
        Me.BuenasTableAdapter.ClearBeforeFill = True
        '
        'BuenasLabel3
        '
        Me.BuenasLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuenasBindingSource, "Buenas", True))
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
        Me.Label3.Location = New System.Drawing.Point(322, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 58)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Label1"
        '
        'baremos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(752, 369)
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
End Class
