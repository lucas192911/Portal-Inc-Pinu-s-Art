Public Class IngresarMateriales

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim vld As String = String.Format("select * from materiales where nombre = '{0}'", txtNombre.Text)
        Dim sql As String = String.Format("insert into materiales (nombre,precio,cantidad,descripcion) values ('{0}',{1},{2},'{3}')", txtNombre.Text, txtPrecio.Text, txtCantidad.Text, txtDescripcion.Text)

        If txtCantidad.Text <> "" And txtDescripcion.Text <> "" And txtNombre.Text <> "" And txtPrecio.Text <> "" Then
            IngresarRegistro(vld, sql)

            If Modulo.num = 0 Then
                Dim s As String = <a>select id as ID, 
                                    nombre as Nombre, 
                                    precio as Precio,
                                    cantidad as Cantidad, 
                                    descripcion as Descripcion 
                                    from materiales</a>

                Materiales.dtgMostrar.DataSource = Consulta(s)
                Me.Close()
            End If
        Else
            MsgBox("Complete los ampos")
        End If




    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        SoloDigitos(e)
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

End Class