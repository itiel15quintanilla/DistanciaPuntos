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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxXA = New System.Windows.Forms.TextBox()
        Me.TextBoxYA = New System.Windows.Forms.TextBox()
        Me.TextBoxXB = New System.Windows.Forms.TextBox()
        Me.TextBoxYB = New System.Windows.Forms.TextBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.TxtResultado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Punto A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Punto B"
        '
        'TextBoxXA
        '
        Me.TextBoxXA.Location = New System.Drawing.Point(83, 95)
        Me.TextBoxXA.Name = "TextBoxXA"
        Me.TextBoxXA.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxXA.TabIndex = 2
        '
        'TextBoxYA
        '
        Me.TextBoxYA.Location = New System.Drawing.Point(83, 133)
        Me.TextBoxYA.Name = "TextBoxYA"
        Me.TextBoxYA.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxYA.TabIndex = 3
        '
        'TextBoxXB
        '
        Me.TextBoxXB.Location = New System.Drawing.Point(83, 234)
        Me.TextBoxXB.Name = "TextBoxXB"
        Me.TextBoxXB.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxXB.TabIndex = 4
        '
        'TextBoxYB
        '
        Me.TextBoxYB.Location = New System.Drawing.Point(83, 274)
        Me.TextBoxYB.Name = "TextBoxYB"
        Me.TextBoxYB.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxYB.TabIndex = 5
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(47, 335)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(197, 23)
        Me.Calcular.TabIndex = 6
        Me.Calcular.Text = "Calcula la distancia "
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'TxtResultado
        '
        Me.TxtResultado.Location = New System.Drawing.Point(144, 387)
        Me.TxtResultado.Name = "TxtResultado"
        Me.TxtResultado.Size = New System.Drawing.Size(100, 22)
        Me.TxtResultado.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "X"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Y"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "X"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(60, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Y"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(60, 389)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Resultado:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 495)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtResultado)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.TextBoxYB)
        Me.Controls.Add(Me.TextBoxXB)
        Me.Controls.Add(Me.TextBoxYA)
        Me.Controls.Add(Me.TextBoxXA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxXA As TextBox
    Friend WithEvents TextBoxYA As TextBox
    Friend WithEvents TextBoxXB As TextBox
    Friend WithEvents TextBoxYB As TextBox
    Friend WithEvents Calcular As Button
    Friend WithEvents TxtResultado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
