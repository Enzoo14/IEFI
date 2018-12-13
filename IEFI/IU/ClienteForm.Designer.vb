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
        Me.Fecha = New System.Windows.Forms.Label
        Me.Saldo = New System.Windows.Forms.Label
        Me.TextBoxFecha = New System.Windows.Forms.TextBox
        Me.TextBoxSaldo = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'IdLabel
        '
        Me.IdLabel.AutoSize = True
        Me.IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.IdLabel.Location = New System.Drawing.Point(38, 25)
        Me.IdLabel.Name = "IdLabel"
        Me.IdLabel.Size = New System.Drawing.Size(23, 20)
        Me.IdLabel.TabIndex = 0
        Me.IdLabel.Text = "Id"
        '
        'NombreLabel
        '
        Me.NombreLabel.AutoSize = True
        Me.NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.NombreLabel.Location = New System.Drawing.Point(38, 70)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(65, 20)
        Me.NombreLabel.TabIndex = 1
        Me.NombreLabel.Text = "Nombre"
        '
        'IdProvinciaLabel
        '
        Me.IdProvinciaLabel.AutoSize = True
        Me.IdProvinciaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdProvinciaLabel.Location = New System.Drawing.Point(38, 117)
        Me.IdProvinciaLabel.Name = "IdProvinciaLabel"
        Me.IdProvinciaLabel.Size = New System.Drawing.Size(86, 20)
        Me.IdProvinciaLabel.TabIndex = 2
        Me.IdProvinciaLabel.Text = "IdProvincia"
        '
        'Aceptar
        '
        Me.Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aceptar.Location = New System.Drawing.Point(109, 286)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(92, 40)
        Me.Aceptar.TabIndex = 3
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar.Location = New System.Drawing.Point(225, 286)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(94, 40)
        Me.Cancelar.TabIndex = 4
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Cordoba", "Buenos Aires", "Santa Fe"})
        Me.ComboBox1.Location = New System.Drawing.Point(136, 114)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(183, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'IdTextBox
        '
        Me.IdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.IdTextBox.HideSelection = False
        Me.IdTextBox.Location = New System.Drawing.Point(136, 22)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(90, 26)
        Me.IdTextBox.TabIndex = 6
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.NombreTextBox.Location = New System.Drawing.Point(136, 67)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(187, 26)
        Me.NombreTextBox.TabIndex = 7
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Location = New System.Drawing.Point(38, 177)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(54, 20)
        Me.Fecha.TabIndex = 8
        Me.Fecha.Text = "Fecha"
        '
        'Saldo
        '
        Me.Saldo.AutoSize = True
        Me.Saldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Saldo.Location = New System.Drawing.Point(38, 226)
        Me.Saldo.Name = "Saldo"
        Me.Saldo.Size = New System.Drawing.Size(50, 20)
        Me.Saldo.TabIndex = 9
        Me.Saldo.Text = "Saldo"
        '
        'TextBoxFecha
        '
        Me.TextBoxFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFecha.Location = New System.Drawing.Point(136, 174)
        Me.TextBoxFecha.Name = "TextBoxFecha"
        Me.TextBoxFecha.Size = New System.Drawing.Size(105, 26)
        Me.TextBoxFecha.TabIndex = 10
        '
        'TextBoxSaldo
        '
        Me.TextBoxSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSaldo.Location = New System.Drawing.Point(136, 218)
        Me.TextBoxSaldo.Name = "TextBoxSaldo"
        Me.TextBoxSaldo.Size = New System.Drawing.Size(105, 26)
        Me.TextBoxSaldo.TabIndex = 11
        '
        'ClienteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 350)
        Me.Controls.Add(Me.TextBoxSaldo)
        Me.Controls.Add(Me.TextBoxFecha)
        Me.Controls.Add(Me.Saldo)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.IdProvinciaLabel)
        Me.Controls.Add(Me.NombreLabel)
        Me.Controls.Add(Me.IdLabel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ClienteForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents Fecha As System.Windows.Forms.Label
    Friend WithEvents Saldo As System.Windows.Forms.Label
    Friend WithEvents TextBoxFecha As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSaldo As System.Windows.Forms.TextBox

End Class
