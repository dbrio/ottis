<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ButtonEmpezar = New System.Windows.Forms.Button()
        Me.LabelBienv = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonEmpezar
        '
        Me.ButtonEmpezar.BackColor = System.Drawing.Color.DarkKhaki
        Me.ButtonEmpezar.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEmpezar.ForeColor = System.Drawing.Color.White
        Me.ButtonEmpezar.Location = New System.Drawing.Point(591, 608)
        Me.ButtonEmpezar.Name = "ButtonEmpezar"
        Me.ButtonEmpezar.Size = New System.Drawing.Size(168, 66)
        Me.ButtonEmpezar.TabIndex = 0
        Me.ButtonEmpezar.Text = "Empezar"
        Me.ButtonEmpezar.UseVisualStyleBackColor = False
        '
        'LabelBienv
        '
        Me.LabelBienv.AutoSize = True
        Me.LabelBienv.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBienv.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelBienv.Location = New System.Drawing.Point(438, 575)
        Me.LabelBienv.Name = "LabelBienv"
        Me.LabelBienv.Size = New System.Drawing.Size(157, 25)
        Me.LabelBienv.TabIndex = 1
        Me.LabelBienv.Text = "Bienvenido(a): "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.ProjectOtis.My.Resources.Resources.Otis_011
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1200, 686)
        Me.Controls.Add(Me.LabelBienv)
        Me.Controls.Add(Me.ButtonEmpezar)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Bienvenido"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonEmpezar As System.Windows.Forms.Button
    Friend WithEvents LabelBienv As System.Windows.Forms.Label

End Class
