Public Class EditarStock
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim sql As String = String.Format("update producto set nombre = '{0}', precio = {1} where id = {2}", txtNombre.Text, txtPrecio.Text, Stock.i)
        Editar(sql)

        Dim s As String = <a>select id , 
                                    nombre,
                                    precio
                                    from producto</a>
        Dim dtClientes As DataTable = Consulta(s)

        Stock.dtgMostrarStock.AutoGenerateColumns = False
        Stock.dtgMostrarStock.DataSource = dtClientes
        Stock.dtgMostrarStock.Columns(0).DataPropertyName = "ID"
        Stock.dtgMostrarStock.Columns(1).DataPropertyName = "Nombre"
        Stock.dtgMostrarStock.Columns(2).DataPropertyName = "Precio"

        If PreguntarParaEditar.num2 = 1 Then
            Me.Close()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class