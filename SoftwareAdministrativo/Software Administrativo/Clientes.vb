Public Class Clientes

    Public id_Cliente As Integer

    Private Sub mostar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As String = <a>select id , 
                                    nombre,
                                    apellido,
                                    telefono, 
                                    direccion
                                    from cliente</a>

        Dim dtClientes As DataTable = Consulta(s)

        dtgMostrar.AutoGenerateColumns = False
        dtgMostrar.DataSource = dtClientes
        dtgMostrar.Columns(0).DataPropertyName = "ID"
        dtgMostrar.Columns(1).DataPropertyName = "Nombre"
        dtgMostrar.Columns(2).DataPropertyName = "Apellido"
        dtgMostrar.Columns(3).DataPropertyName = "Telefono"
        dtgMostrar.Columns(4).DataPropertyName = "Direccion"
    End Sub




    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click

        IngresarCliente.ShowDialog()

    End Sub


    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        If (dtgMostrar.GetCellCount(DataGridViewElementStates.Selected) > 0) Then
            Dim i As Integer = dtgMostrar.SelectedRows.Item(0).Cells(0).Value
            Dim sqlEncargo As String = String.Format("delete encargo.* from encargo join cliente on cliente.id = encargo.id_Cliente where cliente.id = {0}", i)
            Dim sqlCliente As String = String.Format("delete from cliente where id = {0}", i)

            Dim s As String = <a>select id as ID, 
                                    nombre as Nombre,
                                    telefono as Telefono, 
                                    direccion as Direccion 
                                    from cliente</a>

            EliminarNoAlert(sqlEncargo)
            Eliminar(sqlCliente)


            Dim dtClientes As DataTable = Consulta(s)

            dtgMostrar.AutoGenerateColumns = False
            dtgMostrar.DataSource = dtClientes
            dtgMostrar.Columns(0).DataPropertyName = "ID"
            dtgMostrar.Columns(1).DataPropertyName = "Nombre"
            dtgMostrar.Columns(2).DataPropertyName = "Apellido"
            dtgMostrar.Columns(3).DataPropertyName = "Telefono"
            dtgMostrar.Columns(4).DataPropertyName = "Direccion"
        End If

    End Sub


    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim frm As New EditarCliente

        frm.txtNombre.Text = dtgMostrar.CurrentRow.Cells(1).Value.ToString
        frm.txtApellido.Text = dtgMostrar.CurrentRow.Cells(2).Value.ToString
        frm.txtTelefono.Text = dtgMostrar.CurrentRow.Cells(3).Value.ToString
        frm.txtDireccion.Text = dtgMostrar.CurrentRow.Cells(4).Value.ToString
        frm.ShowDialog()
    End Sub

End Class