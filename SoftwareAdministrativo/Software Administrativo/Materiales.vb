Public Class Materiales

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
End Class