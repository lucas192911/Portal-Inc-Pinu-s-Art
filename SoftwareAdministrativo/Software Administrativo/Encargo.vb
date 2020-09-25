Public Class Encargo

    Private Sub Encargo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As String = <a>select nombre as Nombre,
                                    fecha as Fecha, 
                                    presupuesto as Presupuesto,
                                    descripcion as Descripcion 
                                    from encargo</a>

        Me.dtgMostrar.DataSource = Consulta(s)


    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        If (dtgMostrar.GetCellCount(DataGridViewElementStates.Selected) > 0) Then
            Dim i As String = dtgMostrar.SelectedRows.Item(0).Cells(0).Value.ToString
            Dim sql As String = String.Format("delete from encargo where nombre = '{0}'", i)

            Dim s As String = <a>select nombre as Nombre, 
                                    fecha as Fecha,
                                    presupuesto as Presupuesto, 
                                    descripcion as Descripcion 
                                    from encargo</a>

            Eliminar(sql)
            dtgMostrar.DataSource = Consulta(s)
        End If

    End Sub
End Class