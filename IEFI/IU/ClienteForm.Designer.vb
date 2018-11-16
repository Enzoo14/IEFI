<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClienteForm
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
        Me.IdLabel = New System.Windows.Forms.Label
        Me.NombreLabel = New System.Windows.Forms.Label
        Me.IdProvinciaLabel = New System.Windows.Forms.Label
        Me.Aceptar = New System.Windows.Forms.Button
        Me.Cancelar = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.IdTextBox = New System.Windows.Forms.TextBox
        Me.NombreTextBox = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'IdLabel
        '
        Me.IdLabel.AutoSize = True
        Me.IdLabel.Location = New System.Drawing.Point(38, 25)
        Me.IdLabel.Name = "IdLabel"
        Me.IdLabel.Size = New System.Drawing.Size(16, 13)
        Me.IdLabel.TabIndex = 0
        Me.IdLabel.Text = "Id"
        '
        'NombreLabel
        '
        Me.NombreLabel.AutoSize = True
        Me.NombreLabel.Location = New System.Drawing.Point(38, 70)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(44, 13)
        Me.NombreLabel.TabIndex = 1
        Me.NombreLabel.Text = "Nombre"
        '
        'IdProvinciaLabel
        '
        Me.IdProvinciaLabel.AutoSize = True
        Me.IdProvinciaLabel.Location = New System.Drawing.Point(38, 117)
        Me.IdProvinciaLabel.Name = "IdProvinciaLabel"
        Me.IdProvinciaLabel.Size = New System.Drawing.Size(60, 13)
        Me.IdProvinciaLabel.TabIndex = 2
        Me.IdProvinciaLabel.Text = "IdProvincia"
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(112, 166)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Aceptar.TabIndex = 3
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(244, 166)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Cancelar.TabIndex = 4
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Cordoba", "Buenos Aires", "Santa Fe"})
        Me.ComboBox1.Location = New System.Drawing.Point(136, 114)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(183, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'IdTextBox
        '
        Me.IdTextBox.HideSelection = False
        Me.IdTextBox.Location = New System.Drawing.Point(136, 22)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(90, 20)
        Me.IdTextBox.TabIndex = 6
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Location = New System.Drawing.Point(136, 63)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(187, 20)
        Me.NombreTextBox.TabIndex = 7
        '
        'ClienteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 229)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.IdProvinciaLabel)
        Me.Controls.Add(Me.NombreLabel)
        Me.Controls.Add(Me.IdLabel)
        Me.Name = "ClienteForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IdLabel As System.Windows.Forms.Label
    Friend WithEvents NombreLabel As System.Windows.Forms.Label
    Friend WithEvents IdProvinciaLabel As System.Windows.Forms.Label
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox

End Class
