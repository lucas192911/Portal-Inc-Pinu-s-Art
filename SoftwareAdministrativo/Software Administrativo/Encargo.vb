Public Class Encargo


    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        If (dtgMostrar.GetCellCount(DataGridViewElementStates.Selected) > 0) Then
            Dim i As String = dtgMostrar.SelectedRows.Item(0).Cells(0).Value.ToString
            Dim sql As String = String.Format("UPDATE encargo SET estado = 0 WHERE id = {0}", i)

            Dim s As String = <a>   select encargo.id, 
                                encargo.nombre, 
                                fecha, presupuesto, 
                                descripcion, 
                                cliente.nombre as nombreCliente
                                from encargo join cliente
                                on id_Cliente = cliente.id
                                where estado = 1</a>


            Consulta(sql)

            dtgMostrar.AutoGenerateColumns = False
            dtgMostrar.DataSource = Consulta(s)
            dtgMostrar.Columns(0).DataPropertyName = "id"
            dtgMostrar.Columns(1).DataPropertyName = "nombre"
            dtgMostrar.Columns(2).DataPropertyName = "fecha"
            dtgMostrar.Columns(3).DataPropertyName = "presupuesto"
            dtgMostrar.Columns(4).DataPropertyName = "descripcion"
            dtgMostrar.Columns(5).DataPropertyName = "nombreCliente"

        End If

    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Dim frm As New EditarEncargo

        frm.txtNombre.Text = dtgMostrar.CurrentRow.Cells(1).Value.ToString
        frm.txtPresupuesto.Text = dtgMostrar.CurrentRow.Cells(3).Value.ToString
        frm.txtDescripcion.Text = dtgMostrar.CurrentRow.Cells(4).Value.ToString
        frm.ShowDialog()
    End Sub
End Class