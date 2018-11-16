Public Class ClientesGrid


    Private Sub ClientesGrid_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        'Fuente de datos del ComboBox.
        ' ClienteForm.ComboBox1.DataSource = ClienteList.TraerClientes
        'Indicar la fuente de datos del bindinglist en este caso con ClientesList
        ClientesCollectionBindingSource.DataSource = ClienteList.TraerClientes

        'Se debe llenar provinciasList para que se muestre en la grilla.
        ProvinciasList.TraerProvincias()

        ' El miembro a mostrar de la lista es MesAnio.
        'ClienteForm.ComboBox1.DisplayMember = "Nombre"

        ' El miembro de valor es siempre el id.
        'ClienteForm.TextBox1 = "Id"

        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.Rows(0).Selected = True
        End If

    End Sub




    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click

        Me.Dispose()

    End Sub

    Private Sub llenarform()

        'Número de fila seleccionado en el datagridview
        Dim fila As Integer = DataGridView1.CurrentRow.Index

        'funcion que llena la grilla con los datos de base de datos
        ClienteForm.IdTextBox.Text = ClienteList.Item(fila).Id
        ClienteForm.NombreTextBox.Text = ClienteList.Item(fila).Nombre
        'ClienteForm.IdProvinciaLabel.Text = ClienteList.Item(fila).IdProvincia
        'La propiedad ClienteCombo en el form debió llamrse IdProvincia para que no
        'genere confusión.
        ClienteForm.ClienteCombo = ClienteList.Item(fila).IdProvincia

    End Sub

    Private Sub Modificar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Modificar.Click

        'Determina si existen filas en el DataGridView
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay filas para modificar.")
            Exit Sub
        End If

        'boton modificar
        ClienteForm.operacion = "Modificar"
        ClienteForm.Text = "Modificar Cliente"
        ClienteForm.indice = DataGridView1.CurrentRow.Index

        llenarform()
        ClienteForm.Show()

        Dim fila As Integer = DataGridView1.CurrentRow.Index

        'Selecciono nuevamente la fila para que refresque el contenido, sino no muestra la modificación.
        DataGridView1.Rows.Item(fila).Selected = False
        DataGridView1.Rows.Item(fila).Selected = True

        'Coloreamos la fila de nuevo despues de modificar.
        'If ClienteList.Item(fila).Nombre Then
        '    DataGridView1.Rows.Item(fila).DefaultCellStyle.BackColor = Color.Red
        'Else
        '    DataGridView1.Rows.Item(fila).DefaultCellStyle.BackColor = Color.White
        'End If

    End Sub

    Private Sub Agregar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Agregar.Click
        ClienteForm.operacion = "Agregar"
        ClienteForm.Text = "Agregar  Cliente"

        ClienteForm.Show()
    End Sub

    Private Sub Eliminar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Eliminar.Click
        'Determina si existen filas en el DataGridView
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay filas para eliminar.")
            Exit Sub
        End If

        ClienteForm.operacion = "Eliminar"
        ClienteForm.Text = "Eliminar  Cliente"
        ClienteForm.indice = DataGridView1.CurrentRow.Index
        'ArticuloForm.TituloLable1.text = "Eliminar Ariculo"

        llenarform()
        ClienteForm.Show()
    End Sub
End Class

