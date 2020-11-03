Public Class Clientes

    Public id_Cliente As Integer

    Private Sub mostar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As String = <a>select id , 
                                    nombre,
                                    telefono, 
                                    direccion
                                    from cliente</a>
        Dim dtClientes As DataTable = Consulta(s)

        dtgMostrar.AutoGenerateColumns = False
        dtgMostrar.DataSource = dtClientes
        dtgMostrar.Columns(0).DataPropertyName = "ID"
        dtgMostrar.Columns(1).DataPropertyName = "Nombre"
        dtgMostrar.Columns(2).DataPropertyName = "Telefono"
        dtgMostrar.Columns(3).DataPropertyName = "Direccion"
    End Sub




    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click

        IngresarCliente.ShowDialog()

    End Sub


    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        If (dtgMostrar.GetCellCount(DataGridViewElementStates.Selected) > 0) Then
            Dim i As Integer = dtgMostrar.SelectedRows.Item(0).Cells(0).Value
            Dim sql As String = String.Format("delete from cliente where id = {0}", i)

            Dim s As String = <a>select id as ID, 
                                    nombre as Nombre,
                                    telefono as Telefono, 
                                    direccion as Direccion 
                                    from cliente</a>

            Eliminar(sql)
            dtgMostrar.DataSource = Consulta(s)
        End If


    End Sub


    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim frm As New EditarCliente

        frm.txtNombre.Text = dtgMostrar.CurrentRow.Cells(1).Value.ToString
        frm.txtTelefono.Text = dtgMostrar.CurrentRow.Cells(2).Value.ToString
        frm.txtDireccion.Text = dtgMostrar.CurrentRow.Cells(3).Value.ToString
        frm.ShowDialog()
    End Sub

End Class