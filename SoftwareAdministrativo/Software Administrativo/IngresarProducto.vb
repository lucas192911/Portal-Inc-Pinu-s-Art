Public Class IngresarProducto
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If (txtNombre.Text = "" Or txtNombre.Text = "" Or txtPrecio.Text = "") Then

            MsgBox("Complete los campos", MsgBoxStyle.Critical)

        Else

            Dim sql As String = String.Format("insert into producto(nombre,precio) values ('{0}',{1})", txtNombre.Text, txtPrecio.Text)

            IngresarRegistro(sql)

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
            Me.Close()

        End If
    End Sub
End Class