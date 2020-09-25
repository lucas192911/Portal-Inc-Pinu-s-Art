Public Class mostar

    Private Sub mostar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Public x As Integer

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

    
End Class