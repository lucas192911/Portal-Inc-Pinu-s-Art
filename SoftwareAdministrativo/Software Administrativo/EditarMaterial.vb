Public Class EditarMaterial

    Private Sub Panel2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim sql As String = String.Format("update materiales set nombre = '{0}', precio =  {1}, descripcion = '{2}', cantidad = {3} where id = {4}", txtNombre.Text, txtPrecio.Text, txtDescripcion.Text, txtCantidad.Text, Materiales.dtgMostrar.CurrentRow.Cells(0).Value.ToString)

        Editar(sql)

        Dim s As String = <a>select id as ID, 
                                    nombre as Nombre, 
                                    precio as Precio,
                                    cantidad as Cantidad, 
                                    descripcion as Descripcion 
                                    from materiales</a>
        Materiales.dtgMostrar.DataSource = Consulta(s)
        If PreguntarParaEditar.num2 = 1 Then
            Me.Close()
        End If

    End Sub
End Class