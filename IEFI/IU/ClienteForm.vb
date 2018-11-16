Public Class ClienteForm

    Dim operacion_ As String
    Dim MiCliente As New ClienteClass
    Dim ClienteCombo_ As Integer
    Dim indice_ As Integer

    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property


    Public Property indice() As Integer
        Get
            Return indice_
        End Get
        Set(ByVal value As Integer)

            indice_ = value
        End Set
    End Property

    'Debió llamarse IdProvincia
    Public Property ClienteCombo() As Integer
        Get
            Return ClienteCombo
        End Get
        Set(ByVal value As Integer)
            ClienteCombo_ = value
        End Set
    End Property

    Private Sub Aceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Aceptar.Click

        If operacion_ <> "Agregar" Then
            MiCliente.Id = CInt(IdLabel.Text)
        End If

        MiCliente.Nombre = NombreLabel.Text
        MiCliente.IdProvincia = ComboBox1.SelectedIndex

        Select Case operacion_

            Case "Agregar"
                ClienteList.InsertarCliente(MiCliente)

            Case "Modificar"
                ClienteList.ActualizarCliente(MiCliente)
                ClientesGrid.DataGridView1.Refresh()

            Case "Eliminar"
                ClienteList.EliminarCliente(MiCliente)

        End Select


        Me.Close()
    End Sub
    Private Sub ClienteForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        'De donde traigo los datos
        'ComboBox1.DataSource = ClienteList.TraerClientes
        'ComboBox1 debe ser llenado con provincias no con clientes.
        ComboBox1.DataSource = ProvinciasList.TraerProvincias

        'Los valores que quiero mostrar
        'ComboBox1.DisplayMember = "Nombre"
        ComboBox1.DisplayMember = "Provincia"
        ComboBox1.ValueMember = "Id"

        'ComboBox1.SelectedValue = ComboBox1
        'El valor sleccionado proviene de la propiedad IdProvincia que se llena en la grilla.
        ComboBox1.SelectedValue = ClienteCombo_

        'MiCliente.IdProvincia = CInt(ComboBox1 .SelectedValue)
    End Sub

    Private Sub Cancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub

 
End Class

