Public Class Materiales

    Private Sub Materiales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As String = <A>select * from materiales</A>

        Dim dtMateriales As DataTable = Consulta(s)

        dtgMostrar.AutoGenerateColumns = False
        dtgMostrar.DataSource = dtMateriales
        dtgMostrar.Columns(0).DataPropertyName = "ID"
        dtgMostrar.Columns(1).DataPropertyName = "Nombre"
        dtgMostrar.Columns(2).DataPropertyName = "Precio"
        dtgMostrar.Columns(3).DataPropertyName = "Cantidad"
        dtgMostrar.Columns(4).DataPropertyName = "Descripcion"
    End Sub


    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        IngresarMateriales.ShowDialog()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        If (dtgMostrar.GetCellCount(DataGridViewElementStates.Selected) > 0) Then
            Dim i As Integer = dtgMostrar.SelectedRows.Item(0).Cells(0).Value
            Dim sql As String = String.Format("delete from materiales where id = {0}", i)

            Dim s As String = <a>select id as ID, 
                                    nombre as Nombre, 
                                    precio as Precio,
                                    cantidad as Cantidad, 
                                    descripcion as Descripcion 
                                    from materiales</a>

            Eliminar(sql)
            dtgMostrar.DataSource = Consulta(s)
        End If

    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Dim frm As New EditarMaterial

        frm.txtNombre.Text = dtgMostrar.CurrentRow.Cells(1).Value.ToString
        frm.txtPrecio.Text = dtgMostrar.CurrentRow.Cells(2).Value.ToString
        frm.txtCantidad.Text = dtgMostrar.CurrentRow.Cells(3).Value.ToString
        frm.txtDescripcion.Text = dtgMostrar.CurrentRow.Cells(4).Value.ToString
        frm.ShowDialog()
    End Sub


End Class