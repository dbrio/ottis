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
        Dim BuenasLabel2 As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim BuenasLabel As System.Windows.Forms.Label
        Dim Column1Label As System.Windows.Forms.Label
        Me.BuenasLabel3 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BuenasBindingSource = New System.Windows.Forms.BindingSource()
        Me.DatasetOtis = New ProjectOtis.DatasetOtis()
        Me.TotalLabel1 = New System.Windows.Forms.Label()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource()
        Me.Resultado = New System.Windows.Forms.Panel()
        Me.LabelMalas = New System.Windows.Forms.Label()
        Me.BuenasLabel1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelBaremo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.LabelCategoria7 = New System.Windows.Forms.Label()
        Me.LabelCategoria6 = New System.Windows.Forms.Label()
        Me.LabelCategoria5 = New System.Windows.Forms.Label()
        Me.LabelCategoria4 = New System.Windows.Forms.Label()
        Me.LabelCategoria3 = New System.Windows.Forms.Label()
        Me.LabelCategoria2 = New System.Windows.Forms.Label()
        Me.LabelCategoria1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LabelRA = New System.Windows.Forms.Label()
        Me.LabelSerie = New System.Windows.Forms.Label()
        Me.LabelRazonamientoL = New System.Windows.Forms.Label()
        Me.LabelInter = New System.Windows.Forms.Label()
        Me.LabelOraciones = New System.Windows.Forms.Label()
        Me.labelAnalogia = New System.Windows.Forms.Label()
        Me.LabelSignP = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New ProjectOtis.DatasetOtisTableAdapters.TableAdapterManager()
        Me.BuenasTableAdapter = New ProjectOtis.DatasetOtisTableAdapters.BuenasTableAdapter()
        Me.DataTable1TableAdapter = New ProjectOtis.DatasetOtisTableAdapters.DataTable1TableAdapter()
        Me.DataTable2BindingSource = New System.Windows.Forms.BindingSource()
        Me.DataTable2TableAdapter = New ProjectOtis.DatasetOtisTableAdapters.DataTable2TableAdapter()
        Me.Column1Label1 = New System.Windows.Forms.Label()
        BuenasLabel2 = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        BuenasLabel = New System.Windows.Forms.Label()
        Column1Label = New System.Windows.Forms.Label()
        CType(Me.BuenasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatasetOtis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Resultado.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Label5.Location = New System.Drawing.Point(37, 32)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(236, 25)
        Label5.TabIndex = 33
        Label5.Text = "Respuestas de Usuario"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Label1.Location = New System.Drawing.Point(37, 122)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(76, 25)
        Label1.TabIndex = 31
        Label1.Text = "Malas:"
        '
        'BuenasLabel
        '
        BuenasLabel.AutoSize = True
        BuenasLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BuenasLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        BuenasLabel.Location = New System.Drawing.Point(37, 84)
        BuenasLabel.Name = "BuenasLabel"
        BuenasLabel.Size = New System.Drawing.Size(91, 25)
        BuenasLabel.TabIndex = 29
        BuenasLabel.Text = "Buenas:"
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
        'Label3
        '
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuenasBindingSource, "Buenas", True))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(67, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(225, 58)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Label1"
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
        'Resultado
        '
        Me.Resultado.BackColor = System.Drawing.Color.LemonChiffon
        Me.Resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Resultado.Controls.Add(Label5)
        Me.Resultado.Controls.Add(Label1)
        Me.Resultado.Controls.Add(Me.LabelMalas)
        Me.Resultado.Controls.Add(BuenasLabel)
        Me.Resultado.Controls.Add(Me.BuenasLabel1)
        Me.Resultado.Location = New System.Drawing.Point(12, 118)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Size = New System.Drawing.Size(297, 192)
        Me.Resultado.TabIndex = 29
        '
        'LabelMalas
        '
        Me.LabelMalas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuenasBindingSource, "Buenas", True))
        Me.LabelMalas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMalas.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelMalas.Location = New System.Drawing.Point(173, 121)
        Me.LabelMalas.Name = "LabelMalas"
        Me.LabelMalas.Size = New System.Drawing.Size(100, 23)
        Me.LabelMalas.TabIndex = 32
        Me.LabelMalas.Text = "Label1"
        '
        'BuenasLabel1
        '
        Me.BuenasLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuenasBindingSource, "Buenas", True))
        Me.BuenasLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuenasLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BuenasLabel1.Location = New System.Drawing.Point(173, 84)
        Me.BuenasLabel1.Name = "BuenasLabel1"
        Me.BuenasLabel1.Size = New System.Drawing.Size(100, 23)
        Me.BuenasLabel1.TabIndex = 30
        Me.BuenasLabel1.Text = "Label1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.LabelBaremo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(329, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(297, 192)
        Me.Panel1.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuenasBindingSource, "Buenas", True))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(3, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 58)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "MT"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelBaremo
        '
        Me.LabelBaremo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuenasBindingSource, "Buenas", True))
        Me.LabelBaremo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBaremo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelBaremo.Location = New System.Drawing.Point(204, 32)
        Me.LabelBaremo.Name = "LabelBaremo"
        Me.LabelBaremo.Size = New System.Drawing.Size(88, 28)
        Me.LabelBaremo.TabIndex = 9
        Me.LabelBaremo.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuenasBindingSource, "Buenas", True))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(3, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 58)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Resultado Crudo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Controls.Add(Me.Label20)
        Me.PanelControl1.Controls.Add(Me.LabelCategoria7)
        Me.PanelControl1.Controls.Add(Me.LabelCategoria6)
        Me.PanelControl1.Controls.Add(Me.LabelCategoria5)
        Me.PanelControl1.Controls.Add(Me.LabelCategoria4)
        Me.PanelControl1.Controls.Add(Me.LabelCategoria3)
        Me.PanelControl1.Controls.Add(Me.LabelCategoria2)
        Me.PanelControl1.Controls.Add(Me.LabelCategoria1)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Controls.Add(Me.Label12)
        Me.PanelControl1.Controls.Add(Me.Label13)
        Me.PanelControl1.Controls.Add(Me.Label14)
        Me.PanelControl1.Controls.Add(Me.Label15)
        Me.PanelControl1.Controls.Add(Me.Label16)
        Me.PanelControl1.Controls.Add(Me.Label17)
        Me.PanelControl1.Controls.Add(Me.Label18)
        Me.PanelControl1.Controls.Add(Me.LabelRA)
        Me.PanelControl1.Controls.Add(Me.LabelSerie)
        Me.PanelControl1.Controls.Add(Me.LabelRazonamientoL)
        Me.PanelControl1.Controls.Add(Me.LabelInter)
        Me.PanelControl1.Controls.Add(Me.LabelOraciones)
        Me.PanelControl1.Controls.Add(Me.labelAnalogia)
        Me.PanelControl1.Controls.Add(Me.LabelSignP)
        Me.PanelControl1.Location = New System.Drawing.Point(653, 35)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(415, 387)
        Me.PanelControl1.TabIndex = 35
        '
        'Label20
        '
        Me.Label20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuenasBindingSource, "Buenas", True))
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(342, 33)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 29)
        Me.Label20.TabIndex = 72
        Me.Label20.Text = "Total"
        '
        'LabelCategoria7
        '
        Me.LabelCategoria7.AutoSize = True
        Me.LabelCategoria7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCategoria7.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.LabelCategoria7.Location = New System.Drawing.Point(344, 334)
        Me.LabelCategoria7.Name = "LabelCategoria7"
        Me.LabelCategoria7.Size = New System.Drawing.Size(66, 18)
        Me.LabelCategoria7.TabIndex = 71
        Me.LabelCategoria7.Text = "Label11"
        '
        'LabelCategoria6
        '
        Me.LabelCategoria6.AutoSize = True
        Me.LabelCategoria6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCategoria6.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.LabelCategoria6.Location = New System.Drawing.Point(344, 289)
        Me.LabelCategoria6.Name = "LabelCategoria6"
        Me.LabelCategoria6.Size = New System.Drawing.Size(66, 18)
        Me.LabelCategoria6.TabIndex = 70
        Me.LabelCategoria6.Text = "Label19"
        '
        'LabelCategoria5
        '
        Me.LabelCategoria5.AutoSize = True
        Me.LabelCategoria5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCategoria5.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.LabelCategoria5.Location = New System.Drawing.Point(345, 247)
        Me.LabelCategoria5.Name = "LabelCategoria5"
        Me.LabelCategoria5.Size = New System.Drawing.Size(57, 18)
        Me.LabelCategoria5.TabIndex = 69
        Me.LabelCategoria5.Text = "Label9"
        '
        'LabelCategoria4
        '
        Me.LabelCategoria4.AutoSize = True
        Me.LabelCategoria4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCategoria4.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.LabelCategoria4.Location = New System.Drawing.Point(343, 206)
        Me.LabelCategoria4.Name = "LabelCategoria4"
        Me.LabelCategoria4.Size = New System.Drawing.Size(66, 18)
        Me.LabelCategoria4.TabIndex = 68
        Me.LabelCategoria4.Text = "Label10"
        '
        'LabelCategoria3
        '
        Me.LabelCategoria3.AutoSize = True
        Me.LabelCategoria3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCategoria3.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.LabelCategoria3.Location = New System.Drawing.Point(345, 161)
        Me.LabelCategoria3.Name = "LabelCategoria3"
        Me.LabelCategoria3.Size = New System.Drawing.Size(57, 18)
        Me.LabelCategoria3.TabIndex = 67
        Me.LabelCategoria3.Text = "Label8"
        '
        'LabelCategoria2
        '
        Me.LabelCategoria2.AutoSize = True
        Me.LabelCategoria2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCategoria2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.LabelCategoria2.Location = New System.Drawing.Point(344, 120)
        Me.LabelCategoria2.Name = "LabelCategoria2"
        Me.LabelCategoria2.Size = New System.Drawing.Size(57, 18)
        Me.LabelCategoria2.TabIndex = 66
        Me.LabelCategoria2.Text = "Label7"
        '
        'LabelCategoria1
        '
        Me.LabelCategoria1.AutoSize = True
        Me.LabelCategoria1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCategoria1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.LabelCategoria1.Location = New System.Drawing.Point(344, 75)
        Me.LabelCategoria1.Name = "LabelCategoria1"
        Me.LabelCategoria1.Size = New System.Drawing.Size(57, 18)
        Me.LabelCategoria1.TabIndex = 65
        Me.LabelCategoria1.Text = "Label7"
        '
        'Label4
        '
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuenasBindingSource, "Buenas", True))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(38, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(256, 29)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Total Buenas Por Categorias"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label12.Location = New System.Drawing.Point(231, 336)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 18)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "Label12"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label13.Location = New System.Drawing.Point(204, 290)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 18)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "Label13"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label14.Location = New System.Drawing.Point(204, 248)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 18)
        Me.Label14.TabIndex = 61
        Me.Label14.Text = "Label14"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label15.Location = New System.Drawing.Point(255, 208)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 18)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Label15"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label16.Location = New System.Drawing.Point(244, 161)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 18)
        Me.Label16.TabIndex = 59
        Me.Label16.Text = "Label16"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label17.Location = New System.Drawing.Point(180, 122)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 18)
        Me.Label17.TabIndex = 58
        Me.Label17.Text = "Label17"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label18.Location = New System.Drawing.Point(239, 76)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 18)
        Me.Label18.TabIndex = 57
        Me.Label18.Text = "Label18"
        '
        'LabelRA
        '
        Me.LabelRA.AutoSize = True
        Me.LabelRA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRA.ForeColor = System.Drawing.Color.DimGray
        Me.LabelRA.Location = New System.Drawing.Point(39, 336)
        Me.LabelRA.Name = "LabelRA"
        Me.LabelRA.Size = New System.Drawing.Size(183, 16)
        Me.LabelRA.TabIndex = 56
        Me.LabelRA.Text = "Razonamiento aritmetico:"
        '
        'LabelSerie
        '
        Me.LabelSerie.AutoSize = True
        Me.LabelSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSerie.ForeColor = System.Drawing.Color.DimGray
        Me.LabelSerie.Location = New System.Drawing.Point(39, 291)
        Me.LabelSerie.Name = "LabelSerie"
        Me.LabelSerie.Size = New System.Drawing.Size(145, 16)
        Me.LabelSerie.TabIndex = 55
        Me.LabelSerie.Text = "Series de Numeros:"
        '
        'LabelRazonamientoL
        '
        Me.LabelRazonamientoL.AutoSize = True
        Me.LabelRazonamientoL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRazonamientoL.ForeColor = System.Drawing.Color.DimGray
        Me.LabelRazonamientoL.Location = New System.Drawing.Point(39, 249)
        Me.LabelRazonamientoL.Name = "LabelRazonamientoL"
        Me.LabelRazonamientoL.Size = New System.Drawing.Size(162, 16)
        Me.LabelRazonamientoL.TabIndex = 54
        Me.LabelRazonamientoL.Text = "Razonamiento Logico:"
        '
        'LabelInter
        '
        Me.LabelInter.AutoSize = True
        Me.LabelInter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInter.ForeColor = System.Drawing.Color.DimGray
        Me.LabelInter.Location = New System.Drawing.Point(38, 208)
        Me.LabelInter.Name = "LabelInter"
        Me.LabelInter.Size = New System.Drawing.Size(209, 16)
        Me.LabelInter.TabIndex = 53
        Me.LabelInter.Text = "Interpretacion de Proverbios:"
        '
        'LabelOraciones
        '
        Me.LabelOraciones.AutoSize = True
        Me.LabelOraciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOraciones.ForeColor = System.Drawing.Color.DimGray
        Me.LabelOraciones.Location = New System.Drawing.Point(38, 163)
        Me.LabelOraciones.Name = "LabelOraciones"
        Me.LabelOraciones.Size = New System.Drawing.Size(190, 16)
        Me.LabelOraciones.TabIndex = 52
        Me.LabelOraciones.Text = "Oraciones Desordenadas:"
        '
        'labelAnalogia
        '
        Me.labelAnalogia.AutoSize = True
        Me.labelAnalogia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelAnalogia.ForeColor = System.Drawing.Color.DimGray
        Me.labelAnalogia.Location = New System.Drawing.Point(38, 122)
        Me.labelAnalogia.Name = "labelAnalogia"
        Me.labelAnalogia.Size = New System.Drawing.Size(124, 16)
        Me.labelAnalogia.TabIndex = 51
        Me.labelAnalogia.Text = "Analogia Verbal:"
        '
        'LabelSignP
        '
        Me.LabelSignP.AutoSize = True
        Me.LabelSignP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSignP.ForeColor = System.Drawing.Color.DimGray
        Me.LabelSignP.Location = New System.Drawing.Point(38, 77)
        Me.LabelSignP.Name = "LabelSignP"
        Me.LabelSignP.Size = New System.Drawing.Size(178, 16)
        Me.LabelSignP.TabIndex = 50
        Me.LabelSignP.Text = "Significado de palabras:"
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
        'DataTable2BindingSource
        '
        Me.DataTable2BindingSource.DataMember = "DataTable2"
        Me.DataTable2BindingSource.DataSource = Me.DatasetOtis
        '
        'DataTable2TableAdapter
        '
        Me.DataTable2TableAdapter.ClearBeforeFill = True
        '
        'Column1Label
        '
        Column1Label.AutoSize = True
        Column1Label.Location = New System.Drawing.Point(10, 9)
        Column1Label.Name = "Column1Label"
        Column1Label.Size = New System.Drawing.Size(51, 13)
        Column1Label.TabIndex = 35
        Column1Label.Text = "Column1:"
        Column1Label.Visible = False
        '
        'Column1Label1
        '
        Me.Column1Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable2BindingSource, "Column1", True))
        Me.Column1Label1.Location = New System.Drawing.Point(67, 9)
        Me.Column1Label1.Name = "Column1Label1"
        Me.Column1Label1.Size = New System.Drawing.Size(100, 23)
        Me.Column1Label1.TabIndex = 36
        Me.Column1Label1.Text = "Label7"
        Me.Column1Label1.Visible = False
        '
        'baremos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1100, 454)
        Me.Controls.Add(Column1Label)
        Me.Controls.Add(Me.Column1Label1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalLabel1)
        Me.Controls.Add(BuenasLabel2)
        Me.Controls.Add(Me.BuenasLabel3)
        Me.Name = "baremos"
        Me.Text = "Baremos"
        CType(Me.BuenasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatasetOtis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Resultado.ResumeLayout(False)
        Me.Resultado.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatasetOtis As ProjectOtis.DatasetOtis
    Friend WithEvents BuenasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As ProjectOtis.DatasetOtisTableAdapters.TableAdapterManager
    Friend WithEvents BuenasTableAdapter As ProjectOtis.DatasetOtisTableAdapters.BuenasTableAdapter
    Friend WithEvents BuenasLabel3 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable1TableAdapter As ProjectOtis.DatasetOtisTableAdapters.DataTable1TableAdapter
    Friend WithEvents TotalLabel1 As System.Windows.Forms.Label
    Friend WithEvents Resultado As System.Windows.Forms.Panel
    Friend WithEvents LabelMalas As System.Windows.Forms.Label
    Friend WithEvents BuenasLabel1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabelBaremo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents LabelRA As System.Windows.Forms.Label
    Friend WithEvents LabelSerie As System.Windows.Forms.Label
    Friend WithEvents LabelRazonamientoL As System.Windows.Forms.Label
    Friend WithEvents LabelInter As System.Windows.Forms.Label
    Friend WithEvents LabelOraciones As System.Windows.Forms.Label
    Friend WithEvents labelAnalogia As System.Windows.Forms.Label
    Friend WithEvents LabelSignP As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents LabelCategoria7 As System.Windows.Forms.Label
    Friend WithEvents LabelCategoria6 As System.Windows.Forms.Label
    Friend WithEvents LabelCategoria5 As System.Windows.Forms.Label
    Friend WithEvents LabelCategoria4 As System.Windows.Forms.Label
    Friend WithEvents LabelCategoria3 As System.Windows.Forms.Label
    Friend WithEvents LabelCategoria2 As System.Windows.Forms.Label
    Friend WithEvents LabelCategoria1 As System.Windows.Forms.Label
    Friend WithEvents DataTable2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable2TableAdapter As ProjectOtis.DatasetOtisTableAdapters.DataTable2TableAdapter
    Friend WithEvents Column1Label1 As System.Windows.Forms.Label
End Class
