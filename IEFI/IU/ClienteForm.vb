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
            MiCliente.Id = CInt(Id.Text)
        End If

        MiCliente.Nombre = Nombre.Text
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
        ComboBox1.DataSource = ClienteList.TraerClientes
        'Los valores que quiero mostrar
        ComboBox1.DisplayMember = "Nombre"
        ComboBox1.ValueMember = "Id"

        ComboBox1.SelectedValue = ComboBox1

        MiCliente.IdProvincia = CInt(ComboBox1 .SelectedValue)
    End Sub

    Private Sub Cancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub

 
End Class

