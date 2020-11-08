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

            Dim sqlValidation As String = "select * from producto where nombre=" & txtNombre.Text & ";"
            Dim sql As String = String.Format("insert into producto(nombre,precio) values ('{0}',{1})", txtNombre.Text, txtPrecio.Text)

            IngresarRegistro(sqlValidation, sql)

            If Modulo.num = 0 Then
                Dim s As String = <a>select id as ID, 
                                    nombre as Nombre,
                                    precio as Precio    
                                    from producto</a>

                Clientes.dtgMostrar.DataSource = Consulta(s)
                Me.Close()
            End If

        End If
    End Sub
End Class