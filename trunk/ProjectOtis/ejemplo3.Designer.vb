<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ejemplo3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ejemplo3))
        Me.RadioButtonE = New System.Windows.Forms.RadioButton()
        Me.RadioButtonD = New System.Windows.Forms.RadioButton()
        Me.RadioButtonC = New System.Windows.Forms.RadioButton()
        Me.RadioButtonB = New System.Windows.Forms.RadioButton()
        Me.RespuestaRadioA = New System.Windows.Forms.RadioButton()
        Me.ButtonOk = New System.Windows.Forms.Button()
        Me.PreguntasLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RadioButtonE
        '
        Me.RadioButtonE.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonE.Location = New System.Drawing.Point(1040, 246)
        Me.RadioButtonE.Name = "RadioButtonE"
        Me.RadioButtonE.Size = New System.Drawing.Size(197, 24)
        Me.RadioButtonE.TabIndex = 31
        Me.RadioButtonE.TabStop = True
        Me.RadioButtonE.Text = "E 16"
        Me.RadioButtonE.UseVisualStyleBackColor = True
        '
        'RadioButtonD
        '
        Me.RadioButtonD.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonD.Location = New System.Drawing.Point(807, 246)
        Me.RadioButtonD.Name = "RadioButtonD"
        Me.RadioButtonD.Size = New System.Drawing.Size(230, 24)
        Me.RadioButtonD.TabIndex = 30
        Me.RadioButtonD.TabStop = True
        Me.RadioButtonD.Text = "D 57"
        Me.RadioButtonD.UseVisualStyleBackColor = True
        '
        'RadioButtonC
        '
        Me.RadioButtonC.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonC.Location = New System.Drawing.Point(544, 246)
        Me.RadioButtonC.Name = "RadioButtonC"
        Me.RadioButtonC.Size = New System.Drawing.Size(205, 24)
        Me.RadioButtonC.TabIndex = 29
        Me.RadioButtonC.TabStop = True
        Me.RadioButtonC.Text = "C 29"
        Me.RadioButtonC.UseVisualStyleBackColor = True
        '
        'RadioButtonB
        '
        Me.RadioButtonB.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonB.Location = New System.Drawing.Point(268, 246)
        Me.RadioButtonB.Name = "RadioButtonB"
        Me.RadioButtonB.Size = New System.Drawing.Size(222, 24)
        Me.RadioButtonB.TabIndex = 28
        Me.RadioButtonB.TabStop = True
        Me.RadioButtonB.Text = "B 48"
        Me.RadioButtonB.UseVisualStyleBackColor = True
        '
        'RespuestaRadioA
        '
        Me.RespuestaRadioA.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RespuestaRadioA.Location = New System.Drawing.Point(33, 246)
        Me.RespuestaRadioA.Name = "RespuestaRadioA"
        Me.RespuestaRadioA.Size = New System.Drawing.Size(213, 24)
        Me.RespuestaRadioA.TabIndex = 27
        Me.RespuestaRadioA.TabStop = True
        Me.RespuestaRadioA.Text = "A 53"
        Me.RespuestaRadioA.UseVisualStyleBackColor = True
        '
        'ButtonOk
        '
        Me.ButtonOk.BackColor = System.Drawing.Color.DarkKhaki
        Me.ButtonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOk.ForeColor = System.Drawing.Color.White
        Me.ButtonOk.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ButtonOk.Location = New System.Drawing.Point(1011, 348)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(121, 56)
        Me.ButtonOk.TabIndex = 26
        Me.ButtonOk.Text = "Ok"
        Me.ButtonOk.UseVisualStyleBackColor = False
        '
        'PreguntasLabel
        '
        Me.PreguntasLabel.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreguntasLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PreguntasLabel.Location = New System.Drawing.Point(54, 47)
        Me.PreguntasLabel.Name = "PreguntasLabel"
        Me.PreguntasLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PreguntasLabel.Size = New System.Drawing.Size(1106, 172)
        Me.PreguntasLabel.TabIndex = 25
        Me.PreguntasLabel.Text = "¿Cuál de los cinco números de abajo es mayor que 55?"
        Me.PreguntasLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ejemplo3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1258, 431)
        Me.Controls.Add(Me.RadioButtonE)
        Me.Controls.Add(Me.RadioButtonD)
        Me.Controls.Add(Me.RadioButtonC)
        Me.Controls.Add(Me.RadioButtonB)
        Me.Controls.Add(Me.RespuestaRadioA)
        Me.Controls.Add(Me.ButtonOk)
        Me.Controls.Add(Me.PreguntasLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ejemplo3"
        Me.Text = "Ejemplo 3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadioButtonE As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonD As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonC As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonB As System.Windows.Forms.RadioButton
    Friend WithEvents RespuestaRadioA As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonOk As System.Windows.Forms.Button
    Friend WithEvents PreguntasLabel As System.Windows.Forms.Label
End Class
