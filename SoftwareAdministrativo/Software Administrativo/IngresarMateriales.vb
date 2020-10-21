Public Class IngresarMateriales

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim vld As String = String.Format("select * from materiales where nombre = '{0}'", txtNombre.Text)
        Dim sql As String = String.Format("insert into materiales (nombre,precio,cantidad,descripcion) values ('{0}',{1},{2},'{3}')", txtNombre.Text, txtPrecio.Text, txtCantidad.Text, txtDescripcion.Text)

        IngresarRegistro(vld, sql)

        If funciones.num = 0 Then
            Dim s As String = <a>select id as ID, 
                                    nombre as Nombre, 
                                    precio as Precio,
                                    cantidad as Cantidad, 
                                    descripcion as Descripcion 
                                    from materiales</a>

            Materiales.dtgMostrar.DataSource = Consulta(s)
            Me.Close()
        End If


    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class