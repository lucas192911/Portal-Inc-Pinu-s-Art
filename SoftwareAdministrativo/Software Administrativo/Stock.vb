Public Class Stock
    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim s As String = <a>select id , 
                                    nombre,
                                    precio
                                    from producto</a>
        Dim dtClientes As DataTable = Consulta(s)

        dtgMostrarStock.AutoGenerateColumns = False
        dtgMostrarStock.DataSource = dtClientes
        dtgMostrarStock.Columns(0).DataPropertyName = "ID"
        dtgMostrarStock.Columns(1).DataPropertyName = "Nombre"
        dtgMostrarStock.Columns(2).DataPropertyName = "Precio"
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        IngresarProducto.ShowDialog()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim frm As New EditarStock
        i = dtgMostrarStock.SelectedRows.Item(0).Cells(0).Value
        frm.txtNombre.Text = dtgMostrarStock.CurrentRow.Cells(1).Value.ToString
        frm.txtPrecio.Text = dtgMostrarStock.CurrentRow.Cells(2).Value.ToString
        frm.ShowDialog()
    End Sub
    Public i As Integer
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (dtgMostrarStock.GetCellCount(DataGridViewElementStates.Selected) > 0) Then
            i = dtgMostrarStock.SelectedRows.Item(0).Cells(0).Value
            Dim sql As String = String.Format("delete from producto where id = {0}", i)

            Dim s As String = <a>select id as ID, 
                                    nombre as Nombre,
                                    precio as Precio
                                    from producto</a>

            Eliminar(sql)
            dtgMostrarStock.DataSource = Consulta(s)
        End If

    End Sub
End Class